/* Core
 * ███ █ █ ███ ███ ███ ███  ███ ███ ██
 * █ █ █ █  █  ███ █ █ ████  █   ██  █
 * ███ ███  █  █   ███  ███  █  ███  █
 *             Avatar.OptionObjects.cs

/* u250603_code
 * u250603_documentation
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using System.Security.Policy;
using System.Threading;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    /// <summary>OptionObject logic.</summary>
    /// <remarks>
    ///     The OptionObject holds all of the content of and metadata describing the<br/>
    ///     calling myAvatar form.<br/>
    ///     <br/>
    ///     There are three types of OptionObjects:
    ///     <list type = "bullet">
    ///         <item><see cref= "SentOptObj">SentOptObj</see></item>
    ///         <item><see cref= "WorkOptObj">WorkOptObj</see></item>
    ///         <item><see cref= "ReturnOptObj">ReturnOptObj</see></item>
    ///     </list>
    /// </remarks>
    /// <seealso href= "https://github.com/spectrum-health-systems/Tingen-Documentation">Tingen documentation</seealso>
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
        /// <remarks>
        ///     <para>
        ///         Before an OptionObject can be returned to Avatar, we need to make sure<br/>
        ///         that all of the required OptionObject components exist and/or are<br/>
        ///         modified correctly.<br/>
        ///         <br/>
        ///         This is done by calling the OptionObject's built in <c>ToReturnOptionObject()</c><br/>
        ///         method on the OptionObject, then sending it back to Avatar.
        ///     </para>
        ///     <para>
        ///         When an OptionObject is returned to Avatar, it requires an <see href= "https://spectrum-health-systems.github.io/tingen-documentation/static/optionobject-error-codes">OptionObject Error Code</see><br/>
        ///         <br/>
        ///         The most common error codes are:
        ///         <list type="bullet">
        ///             <item>
        ///                 <term>1</term>
        ///                 <description>
        ///                     Used when you don't want the user to take an action, such as<br/>
        ///                     submitting a form
        ///                 </description>
        ///             </item>
        ///             <item>
        ///                 <term>3</term>
        ///                 <description>Used when you would like to notify the user of something</description>
        ///             </item>
        ///             <item>
        ///                 <term>4</term>
        ///                 <description>
        ///                     Used when you want warn the user they may want to make<br/>
        ///                     changes, and give them the option to stop further processing,<br/>
        ///                     or continuing
        ///                 </description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <param name="tngnSession">The Tingen Session data structure object.</param>
        /// <param name="errorCode">The OptionObject Error Code.</param>
        /// <param name="errorMessage">The OptionObject error message.</param>
        /// <seealso href= "https://spectrum-health-systems.github.io/tingen-documentation/static/optionobject-error-codes">OptionObject Error Codes</seealso>
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

        public static string Validate(OptionObject2015 sentOptObj)
        {
            return (sentOptObj == null)
                ? "The sent OptionObject does not exist."
                : "The sent OptionObject does exist.";
        }
    }
}