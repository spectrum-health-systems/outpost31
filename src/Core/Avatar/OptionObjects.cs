// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                   Core.Avatar.OptionObjects.cs

// u250501_code
// u250501_documentation

using System.Reflection;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    /// <summary>The data structure that is used to pass information between Avatar and the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Avatar.xml' path='Core.Avatar/Class[@name="OptionObjects"]/ClassDescription/*'/>
    public class OptionObjects
    {
        /// <summary>The original OptionObject sent from Avatar.</summary>
        /// <remarks>This is never modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 SentOptObj { get; set; }

        /// <summary>Where OptionObject work is done.</summary>
        /// <remarks>This object is potentially modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 WorkOptObj { get; set; }

        /// <summary>The OptionObject that is returned to Avatar.</summary>
        /// <remarks>This is the finalized WorkOptObj, ready to be returned to Avatar.</remarks>
        public OptionObject2015 ReturnOptObj { get; set; }

        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        /// <param name="tngnSession">The Tingen Session data structure object.</param>
        /// <param name="errorCode">The OptionObject Error Code.</param>
        /// <param name="errorMessage">The OptionObject error message.</param>
        /// <include file='AppData/XmlDoc/Core.Avatar.xml' path='Core.Avatar/Class[@name="OptionObjects"]/Finalize/*'/>
        public static void Finalize(TngnWbsvSession tngnSession, int errorCode, string errorMessage = "")
        {
            //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

            tngnSession.ReturnOptObj = tngnSession.WorkOptObj.Clone();

            switch (errorCode)
            {
                case 0:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(0, errorMessage);
                    break;

                case 1:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(1, errorMessage);
                    break;

                case 2:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(2, errorMessage);
                    break;

                case 3:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(3, errorMessage);
                    break;

                case 4:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(4, errorMessage);
                    break;

                case 5:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(5, errorMessage);
                    break;

                case 6:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    tngnSession.ReturnOptObj.ToReturnOptionObject(6, errorMessage);
                    break;

                default:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    // TODO: Graceful error handling.
                    break;
            }
        }
    }
}