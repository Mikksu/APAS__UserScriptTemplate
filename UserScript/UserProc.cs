using System;
using System.Threading;
using System.Threading.Tasks;
using UserScript.Service;

namespace UserScript
{
    internal partial class UserScript
    {
        /// <summary>
        /// 使用此脚本模板时请注意以下事项：
        /// 
        /// 1、用户脚本中请勿调用Apas.LogError()函数，因为如果是由于远程调用导致的异常，WCF Client会自动断开连接，如果此时
        ///    调用LogError()函数会导致无法正确获取远程调用异常。
        ///
        /// 2、UserProc1()、UserProc2() 函数可根据实际需求定义；如果更改了此函数，请注意同步修改Main()函数中51行或56行内容。
        ///
        /// 3、该模板引用CommandLineParser库进行启动参数的解析，具体使用方法请参考：https://github.com/commandlineparser/commandline
        /// </summary>

        #region 私有常量定义

        private const string DEMO_STRING = "Demo String";

        #endregion

        #region 私有变量定义

        private string demoVar = "";

        #endregion

        #region 用户函数

#if ARGS_CONTAINS_CMD
        /// <summary>
        /// The section of the user process 1.
        /// 用户函数1，当命令行启动参数中的命令为Command1时，执行此函数。
        /// 
        /// Please write your process in the following method.
        /// 请在以下函数中定义您的工艺流程。
        /// 
        /// </summary>
        /// <param name="apas">APAS主程序Service</param>
        /// <param name="camera">相机程序Service</param>
        /// <param name="opts">启动参数</param>
        /// <returns></returns>
        private static void UserProc1(Command1 opts = null)
        {
            try
            {
        #region 请在这里编写实际的用户脚本

        #endregion
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        ///  <summary>
        ///  The section of the user process 2.
        /// 用户函数2，当命令行启动参数中的命令为Command2时，执行此函数。
        ///  
        ///  Please write your process in the following method.
        ///  请在以下函数中定义您的工艺流程。
        ///  
        ///  </summary>
        /// <param name="apas">APAS主程序Service</param>
        /// <param name="camera">相机程序Service</param>
        /// <param name="opts">启动参数</param>
        ///  <returns></returns>
        private static void UserProc2(Command2 opts = null)
        {
            try
            {
        #region 请在这里编写实际的用户脚本

        #endregion
            }
            catch (Exception ex)
            {
                throw;
            }
        }

#else
        private static void UserProc(StartupArgs opts)
        {
#if TEST1
            var cycle = 0;

            while (true)
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} - Start to home ...");

                var hmTasks = new List<Task>
                {
                    apas.__SSC_HomeAsync("ES6701", "Z"),
                    apas.__SSC_HomeAsync("ES6701", "Y"),
                    apas.__SSC_HomeAsync("ES6701", "X")
                };
                Task.WaitAll(hmTasks.ToArray());
                Console.WriteLine("Home finished.");

                Thread.Sleep(1000);

                Console.WriteLine("Start to move....");
                var movTasks = new List<Task>
                {
                    apas.__SSC_MoveAxisAsync("ES6701", "Z", SSC_MoveMode.REL, 10, 100),
                    apas.__SSC_MoveAxisAsync("ES6701", "Y", SSC_MoveMode.REL, 50, 100),
                    apas.__SSC_MoveAxisAsync("ES6701", "X", SSC_MoveMode.REL, 100, 100)
                };
                Task.WaitAll(hmTasks.ToArray());
                Console.WriteLine("Move finished.");

                Thread.Sleep(1000);


                apas.__SSC_LogInfo($"Cycle {cycle}");

                var bmp = Image.FromFile(@"C:\Users\Mikk\Pictures\屏幕截图\Snipaste_2021-10-10_10-41-59.png");
                using (var ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Jpeg);
                    apas.__SSC_ShowImage(ms.GetBuffer());
                }

                cycle++;
                Console.WriteLine($"Cycle {cycle}");
            }
#endif

#if TEST2
            apas.__SSC_LogInfo("aaaaaa");

            var bmp = Image.FromFile(@"C:\Users\Mikk\Pictures\屏幕截图\Snipaste_2021-10-10_10-41-59.png");
            using (var ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Jpeg);
                apas.__SSC_ShowImage(ms.GetBuffer());
            }

            var ret = apas.__SSC_ShowYesNoMessageBox("adfasfdsafdsa");

#endif

#if TEST3
            //ThreadPool.SetMinThreads(500, 500);
            using (var apas = new SystemServiceClient())
            {
                apas.__SSC_WriteIO("aaa", SSC_IOStatusEnum.Enabled);
            }


            for (var i = 0; i < 10; i++)
                Task.Run(() =>
                {
                    var cycle = 0;
                    while (true)
                    {
                        using (var apas = new SystemServiceClient())
                        {
                            var ret = apas.__SSC_ReadAllInputIO();
                        }

                        Thread.Sleep(1);

                        Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]\tCycle = {cycle++}");
                    }
                });

            Console.ReadLine();

#endif

#if TEST4
            using (var apas = new SystemServiceClient())
            {
               // apas.__SSC_MoveAxis("ES6701", "X", SSC_MoveMode.REL, 50, 10000);

                apas.__SSC_JogStartAsync("ES6701", "X", SSC_JogDir.POSITIVE, 100, null, null);

               Thread.Sleep(5000);

                apas.__SSC_JogStop("ES6701", "X");
            }
#endif

            #region 私有函数请写在这里

            #endregion
        }
#endif

#endregion
        }
}
