using CommandLine;

namespace UserScript
{
#if ARGS_CONTAINS_CMD
    [Verb("cmd1", HelpText = "命令1")]
    public class Command1
    {
        [Option('a', "arg1", Required = true,
            Default = 0,
            HelpText = "参数1")]
        public int Arg1 { get; set; }

        [Option('b', "arg2", Required = true,
            Default = 1,
            HelpText = "参数2")]
        public int Arg2 { get; set; }

        [Option('c', "arg3", Required = true,
            Default = false,
            HelpText = "参数3，对于bool型，启动参数中带此开关为true，不带为false")]
        public bool Arg3 { get; set; }
    }

    [Verb("cmd2", HelpText = "命令2")]
    public class Command2
    {
        [Option('a', "arg1", Required = true,
            Default = 0,
            HelpText = "参数1")]
        public int Arg1 { get; set; }

        [Option('b', "arg2", Required = true,
            Default = 1,
            HelpText = "参数2")]
        public int Arg2 { get; set; }
    }
#else
    public class StartupArgs
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }


#endif
}