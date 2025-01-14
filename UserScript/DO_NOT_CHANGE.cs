using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using CommandLine;
using UserScript.Service;

namespace UserScript
{
    /// <summary>
    /// =========================== ATTENTION ===========================
    /// ===========================    注意   =========================== 
    /// =                                                               =  
    /// =          Please DO NOT make ANY changes to this file.         =
    /// =                    请勿修改当前文件的任何内容。                   =
    /// =                                                               =
    /// =================================================================
    /// 
    /// </summary>
    internal partial class UserScript
    {
        private static void Main(string[] args)
        {
            var isExceptionThrown = false;
            var errText = "";

            try
            {
                using (var apas = new SystemServiceClient())
                {
                    apas.__SSC_Connect();
                    // print the script version
                    apas.__SSC_LogInfo($"Script Info: {Assembly.GetExecutingAssembly().GetName()}");
                }

                var helpWriter = new StringWriter();
                var parser = new Parser(with =>
                {
                    with.CaseSensitive = false;
                    with.EnableDashDash = true;
                    with.HelpWriter = helpWriter;
                });
#if ARGS_CONTAINS_CMD // 传入的参数包含 ”命令“, 例如：command --arg1 xxx --arg2 yyy
                parser.ParseArguments<Command1, Command2>(args)
                    .MapResult(
                        (Command1 opts) =>
                        {
                            UserProc1(opts);

                            return 0;
                        },
                        (Command2 opts) =>
                        {
                            UserProc2(opts);

                            return 0;
                        },
                        errs =>
                        {
                            var myErr = "";
                            if (errs.IsHelp() || errs.IsVersion())
                                myErr = helpWriter.ToString();
                            else
                                myErr = $"启动参数错误。\r\n{helpWriter}";

                            throw new Exception(myErr);
                        });

#else //传入的参数不包含”命令“，例如 --arg1 xxx --arg2 yyy
                Parser.Default.ParseArguments<StartupArgs>(args)
                    .WithParsed<StartupArgs>(UserProc)
                    .WithNotParsed(errs =>
                    {
                        var myErr = "";
                        var enumerable = errs as Error[] ?? errs.ToArray();
                        if (enumerable.IsHelp() || enumerable.IsVersion())
                            myErr = helpWriter.ToString();
                        else
                            myErr = $"启动参数错误。\r\n{helpWriter}";

                        throw new Exception(myErr);
                    });
#endif
                using (var apas = new SystemServiceClient())
                {
                    apas.__SSC_Disconnect();
                }
            }
            catch (AggregateException ae)
            {
                var ex = ae.Flatten();
                ex.InnerExceptions.ToList()
                    .ForEach(e =>
                    {
                        errText = e.Message;
                        Console.Error.WriteLine(errText);
                    });
                isExceptionThrown = true;
            }
            catch (TimeoutException timeProblem)
            {
                errText = "The service operation timed out. " + timeProblem.Message;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            // Catch unrecognized faults. This handler receives exceptions thrown by WCF
            // services when ServiceDebugBehavior.IncludeExceptionDetailInFaults
            // is set to true.
            catch (FaultException<Exception> ex)
            {
                errText = "An unknown exception was received. " + ex.Detail.Message;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            catch (FaultException faultEx)
            {
                errText = "An unknown exception was received. " + faultEx.Message;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            // Standard communication fault handler.
            catch (CommunicationException commProblem)
            {
                errText = "There was a communication problem. " + commProblem.Message + commProblem.StackTrace;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            catch (Exception ex)
            {
                errText = ex.Message;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            finally
            {
                if (isExceptionThrown)
                    /*
                        // try to output the error message to the log.
                        try
                        {
                            using (apasService = new SystemServiceClient())
                            {
                                apasService.__SSC_LogError(errText);
                                apasService.Abort();
                            }
                        }
                        catch (Exception)
                        {
                            // ignore
                        }
                        */

                    Environment.ExitCode = -1;
            }
        }
    }
}
