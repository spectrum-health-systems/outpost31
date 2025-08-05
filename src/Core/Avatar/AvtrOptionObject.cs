/* Outpost31.Core.Avatar.AvtrOptionObject.cs
 * u250804_code
 * u250805_documentation
 */

using System.Reflection;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar OptionObjects.</summary>
    /// <remarks>
    ///     An <see cref="OptionObject2015">OptionObject</see> contains metadata of an Avatar form.<br/>
    ///     <br/>
    ///     <include file='AppData/XmlDoc/ProjectInfo.xml' path='ProjectInfo/Class[@name="Project"]/Callback/*'/>
    /// </remarks>
    public class AvtrOptionObject
    {
        /// <summary>The original OptionObject sent from Avatar.</summary>
        /// <remarks>This <see cref="OptionObject2015">OptionObject</see> is <i>never</i> modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 Original { get; set; }

        /// <summary>The OptionObject where work is done.</summary>
        /// <remarks>This <see cref="OptionObject2015">OptionObject</see> is <i>potentially</i> modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 Worker { get; set; }

        /// <summary>The finalized OptionObject that is returned to Avatar.</summary>
        /// <remarks>This is the finalized <see cref="OptionObject2015">OptionObject</see>, ready to be returned to Avatar.</remarks>
        public OptionObject2015 Finalized { get; set; }

        /// <summary>The executing assembly name.</summary>
        /// <include file='AppData/XmlDoc/Common.xml' path='Common/Class[@name="Variable"]/ExeAsmName/*'/>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        /// <remarks>
        ///     An <see cref="OptionObject2015">OptionObject</see> must be finalized before being returned to Avatar.<br/>
        ///     <br/>
        ///     This method finalizes an OptionObject by:
        ///     <list type="bullet">
        ///         <item>Ensuring that all required components of the OptionObject are valid</item>
        ///         <item>Assigning an <i>error code</i> to the OptionObject</item>
        ///         <item>Assigning an <i>error message</i> to the OptionObject</item>
        ///     </list>
        ///     <include file='AppData/XmlDoc/AvtrOptionObject.xml' path='AvtrOptionObject/Class[@name="OptionObject"]/ErrorCode/*'/>
        ///     <include file='AppData/XmlDoc/AvtrOptionObject.xml' path='AvtrOptionObject/Class[@name="OptionObject"]/ErrorCode.Example/*'/>
        /// </remarks>
        /// <param name="wsvcSession">The <see cref="WsvcSession">Tingen session</see> instance.</param>
        /// <param name="errorCode">The OptionObject error code.</param>
        /// <param name="errorMessage">The OptionObject error message.</param>
        public static void Finalize(WsvcSession wsvcSession, int errorCode, string errorMessage = "")
        {
            //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

            wsvcSession.OptObj.Finalized = wsvcSession.OptObj.Worker.Clone();

            switch (errorCode)
            {
                case 0:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(0, errorMessage);
                    break;

                case 1:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(1, errorMessage);
                    break;

                case 2:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(2, errorMessage);
                    break;

                case 3:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(3, errorMessage);
                    break;

                case 4:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(4, errorMessage);
                    break;

                case 5:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(5, errorMessage);
                    break;

                case 6:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(6, errorMessage);
                    break;

                default:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    // TODO: Graceful error handling.
                    break;
            }
        }

        /// <summary> Validates whether the provided OptionObject instance exists.</summary>
        /// <param name="origOptObj">The <see cref="OptionObject2015">OptionObject</see> instance to validate.</param>
        /// <returns>A string indicating the validation result.</returns>
        public static string CheckExistance(OptionObject2015 origOptObj)
        {
            return (origOptObj == null)
                ? "An OptionObject was not sent."
                : "An OptionObject was sent.";
        }
    }
}