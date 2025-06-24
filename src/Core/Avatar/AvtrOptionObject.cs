/* Outpost31.Core.Avatar.ScriptLinkOptionObject.cs
 * u250618_code
 * u250618_documentation
 */

using System.Dynamic;
using System.Reflection;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    /// <summary>OptionObject logic.</summary>
    /// <remarks>
    ///     The OptionObject holds all of the content of and metadata describing the<br/>
    ///     calling myAvatar form.
    ///  </remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/tingen-documentation-project">Tingen Documentation Project</seealso>
    public class AvtrOptionObject
    {
        /// <summary>The original OptionObject sent from Avatar.</summary>
        /// <remarks>This is <i>never</i> modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 Original { get; set; }

        /// <summary>The OptionObject work is done.</summary>
        /// <remarks>This object is <i>potentially</i> modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 Worker { get; set; }

        /// <summary>The finalized OptionObject that is returned to Avatar.</summary>
        /// <remarks>This is the finalized WorkOptObj, ready to be returned to Avatar.</remarks>
        public OptionObject2015 Finalized { get; set; }

        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        /// <remarks>
        ///     <para>
        ///         An OptionObject must be finalized before being returned to Avatar.<br/>
        ///         <br/>
        ///         The <see cref="OptionObject2015.ToReturnOptionObject(int, string)"/> method:
        ///         <list type="bullet">
        ///             <item>Ensures that all required components of the OptionObject are valid</item>
        ///             <item>Assigns an error code to the object</item>
        ///             <item>Assigns an error message to the object</item>
        ///         </list>
        ///     </para>
        ///     <include file='AppData/XmlDoc/Core.xml' path='Core/Class[@name="Avatar.OptionObjects"]/Finalize.ErrorCodes/*'/>    
        ///     <include file='AppData/XmlDoc/Core.xml' path='Core/Class[@name="Avatar.OptionObjects"]/Finalize.Example/*'/>    
        /// </remarks>
        /// <param name="wsvcSession">The Tingen Session data structure object.</param>
        /// <param name="errCode">The OptionObject error code.</param>
        /// <param name="errMsg">The OptionObject error message.</param>

        public static void Finalize(WsvcSession wsvcSession, int errCode, string errMsg = "")
        {
            //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

            wsvcSession.OptObj.Finalized = wsvcSession.OptObj.Worker.Clone();

            switch (errCode)
            {
                case 0:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(0, errMsg);
                    break;

                case 1:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(1, errMsg);
                    break;

                case 2:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(2, errMsg);
                    break;

                case 3:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(3, errMsg);
                    break;

                case 4:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(4, errMsg);
                    break;

                case 5:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(5, errMsg);
                    break;

                case 6:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    wsvcSession.OptObj.Finalized.ToReturnOptionObject(6, errMsg);
                    break;

                default:
                    //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
                    // TODO: Graceful error handling.
                    break;
            }
        }

        /// <summary> Validates whether the provided <see cref="OptionObject2015"/> instance exists.</summary>
        /// <param name="origOptObj">The <see cref="OptionObject2015"/> instance to validate.</param>
        /// <returns>A string indicating the validation result.</returns>
        public static string CheckExistance(OptionObject2015 origOptObj)
        {
            return (origOptObj == null)
                ? "An OptionObject was not sent."
                : "An OptionObject was sent.";
        }
    }
}