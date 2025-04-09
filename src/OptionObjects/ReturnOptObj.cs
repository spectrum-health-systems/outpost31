//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

using Outpost31.Core.Session;

namespace Outpost31.OptionObjects
{
    public class ReturnOptObj
    {
        ///// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        ///// <param name="tngnSession">The Tingen Session data structure object.</param>
        ///// <param name="errorCode">The OptionObject error string.</param>
        ///// <param name="errorMessage">The OptionObject error message .</param>
        //public static void Finalize(TngnSession tngnSession, int errorCode, string errorMessage = "")
        //{
        //    //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

        //    tngnSession.ReturnOptObj = tngnSession.WorkOptObj.Clone();

        //    switch (errorCode)
        //    {
        //        case 0:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(0, errorMessage);
        //            break;

        //        case 1:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(1, errorMessage);
        //            break;

        //        case 2:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(2, errorMessage);
        //            break;

        //        case 3:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(3, errorMessage);
        //            break;

        //        case 4:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(4, errorMessage);
        //            break;

        //        case 5:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(5, errorMessage);
        //            break;

        //        case 6:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.ReturnOptObj.ToReturnOptionObject(6, errorMessage);
        //            break;

        //        default:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            // TODO: Graceful error handling.
        //            break;
        //    }
        //}
    }
}
