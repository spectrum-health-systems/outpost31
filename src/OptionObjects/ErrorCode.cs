//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

namespace Outpost31.OptionObjects
{
    public class ErrorCode
    {
        public static int ConvertString(string errorString)
        {
            //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

            switch (errorString.ToLower())
            {
                case "clone":
                case "none":
                case "success":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 0;

                case "error":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 1;

                case "okcancel":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 2;

                case "info":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 3;

                case "yesno":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 4;

                case "openurl":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 5;

                case "openform":
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 6;

                default:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    return 3;
            }
        }
    }
}
