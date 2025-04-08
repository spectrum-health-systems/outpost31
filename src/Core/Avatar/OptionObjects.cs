//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

using System.Reflection;

using Outpost31.Core.Session;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    public class OptionObjects
    {
        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>The original data structure sent from Avatar.</summary>
        public OptionObject2015 SentOptObj { get; set; }

        /// <summary>The data structure that (is potentially) modified during a Tingen Session.</summary>
        public OptionObject2015 WorkOptObj { get; set; }

        /// <summary>The data structure that is returned to Avatar.</summary>
        public OptionObject2015 ReturnOptObj { get; set; }

        //public static int ConvertErrorCode(string errorCodeString)
        //{
        //    //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

        //    switch (errorCodeString.ToLower())
        //    {
        //        case "clone":
        //        case "none":
        //        case "success":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 0;

        //        case "error":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 1;

        //        case "okcancel":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 2;

        //        case "info":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 3;

        //        case "yesno":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 4;

        //        case "openurl":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 5;

        //        case "openform":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 6;

        //        default:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            return 3;
        //    }
        //}

        ///// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        ///// <param name="tngnSession">The Tingen Session data structure object.</param>
        ///// <param name="errorCode">The OptionObject error string.</param>
        ///// <param name="errorMessage">The OptionObject error message .</param>
        //public static void FinalizeObj(TngnSession tngnSession, int errorCode, string errorMessage = "")
        //{
        //    //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

        //    tngnSession.OptObjs.ReturnOptObj = tngnSession.OptObjs.WorkOptObj.Clone();

        //    switch (errorCode)
        //    {
        //        case 0:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(0, errorMessage);
        //            break;

        //        case 1:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(1, errorMessage);
        //            break;

        //        case 2:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(2, errorMessage);
        //            break;

        //        case 3:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(3, errorMessage);
        //            break;

        //        case 4:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(4, errorMessage);
        //            break;

        //        case 5:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(5, errorMessage);
        //            break;

        //        case 6:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.OptObjs.ReturnOptObj.ToReturnOptionObject(6, errorMessage);
        //            break;

        //        default:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            // TODO: Graceful error handling.
        //            break;
        //    }
        //}

        ///// <summary>Builds a new AvatarData data structure.</summary>
        ///// <param name="sentOptObj">The SentOptionObject data structure sent from Avatar.</param>
        ///// <returns>All of the data/information Tingen needs in order to do work.</returns>
        //public static OptionObjects Initialize(OptionObject2015 sentOptObj)
        //{
        //    /* Trace Logs won't work here. */

        //    return new OptionObjects
        //    {
        //        SentOptObj   = sentOptObj,
        //        WorkOptObj   = sentOptObj.Clone(),
        //        ReturnOptObj = null
        //    };
        //}
    }
}