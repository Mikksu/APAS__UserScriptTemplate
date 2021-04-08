using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Threading;
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
    partial class APAS_UserScript
    {
        static void Main(string[] args)
        {
            var isExceptionThrown = false;
            var errText = "";

            var camClient = new CamRAC.CamRemoteAccessContractClient();
            var wcfClient = new SystemServiceClient();

            try
            {
                wcfClient.Open();
                wcfClient.__SSC_Connect();

                // print the script version
                wcfClient.__SSC_LogInfo($"Script Version: v{Assembly.GetExecutingAssembly().GetName()}");

                var helpWriter = new StringWriter();
                var parser = new Parser(with =>
                {
                    with.CaseSensitive = false;
                    with.EnableDashDash = true;
                    with.HelpWriter = helpWriter;
                });

                parser.ParseArguments<Command1, Command2>(args)
                    .MapResult(
                        (Command1 opts) =>
                        {
                            UserProc1(wcfClient, camClient, opts);
                            return 0;
                        },
                        (Command2 opts) =>
                        {
                            UserProc2(wcfClient, camClient, opts);
                            return 0;
                        },
                        errs =>
                        {
                            var myErr = "";
                            if (errs.IsHelp() || errs.IsVersion())
                                myErr = helpWriter.ToString();
                            else
                            {
                                myErr = $"启动参数错误。\r\n{helpWriter}";
                            }

                            throw new Exception(myErr);
                        });

                wcfClient.__SSC_Disconnect();
            }
            catch (AggregateException ae)
            {
                var ex = ae.Flatten();
                ex.InnerExceptions.ToList().ForEach(e =>
                {
                    errText = ex.Message;
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
            catch (FaultException faultEx)
            {
                errText = "An unknown exception was received. "
                          + faultEx.Message
                          + faultEx.StackTrace;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            // Standard communication fault handler.
            catch (CommunicationException commProblem)
            {
                errText = "There was a communication problem. " + commProblem.Message + commProblem.StackTrace;
                Console.Error.WriteLine(errText);
            }
            catch (Exception ex)
            {
                errText = ex.Message;
                Console.Error.WriteLine(errText);
                isExceptionThrown = true;
            }
            finally
            {
                wcfClient.Abort();
                if (isExceptionThrown)
                {
                    // try to output the error message to the log.
                    try
                    {
                        using (wcfClient = new SystemServiceClient())
                        {
                            wcfClient.__SSC_LogError(errText);
                            wcfClient.Abort();
                        }
                    }
                    catch (Exception)
                    {
                        // ignore
                    }


                    Environment.ExitCode = -1;
                }
            }
        }
    }
}
