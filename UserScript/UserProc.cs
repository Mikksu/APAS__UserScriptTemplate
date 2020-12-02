using System;
using UserScript.CamRAC;
using UserScript.Service;

namespace UserScript
{
    partial class APAS_UserScript
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

        const string DEMO_STRING = "Demo String";

        #endregion

        #region 私有变量定义

        string demoVar = "";

        #endregion

        #region 用户脚本

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
        private static void UserProc1(SystemServiceClient apas, CamRemoteAccessContractClient camera = null, Command1 opts = null)
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
        private static void UserProc2(SystemServiceClient apas, CamRemoteAccessContractClient camera = null, Command2 opts = null)
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

        #endregion

        #region 私有函数请写在这里


        #endregion

    }
   
}
