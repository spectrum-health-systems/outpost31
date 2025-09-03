// =============================================================================
// Outpost31.Core.Avatar.AvatarOptionObject.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250903_code
// u250903_documentation
// =============================================================================

using System.Reflection;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    public class AvatarOptionObject
    {
        /// <summary>The original <see cref="OptionObject2015">OptionObject</see> sent from Avatar.</summary>
        /// <remarks>This OptionObject is <i>never</i> modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 Original { get; set; }

        /// <summary>The <see cref="OptionObject2015">OptionObject</see> where work is done.</summary>
        /// <remarks>This OptionObject is <i>potentially</i> modified during a Tingen Web Service session.</remarks>
        public OptionObject2015 Worker { get; set; }

        /// <summary>The finalized <see cref="OptionObject2015">OptionObject</see> that is returned to Avatar.</summary>
        /// <remarks>This is the finalized OptionObject, ready to be returned to Avatar.</remarks>
        public OptionObject2015 Completed { get; set; }

        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static void ToReturn(TngnWsvcSession tngnWsvcSession, int errorCode, string errorMessage = "")
        {
            LogAppEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);

            tngnWsvcSession.OptionObject.Completed = tngnWsvcSession.OptionObject.Worker.Clone();

            // Put logs in switch?

            switch (errorCode)
            {
                case 0:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(0, errorMessage);
                    break;

                case 1:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(1, errorMessage);
                    break;

                case 2:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(2, errorMessage);
                    break;

                case 3:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(3, errorMessage);
                    break;

                case 4:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(4, errorMessage);
                    break;

                case 5:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(5, errorMessage);
                    break;

                case 6:
                    tngnWsvcSession.OptionObject.Completed.ToReturnOptionObject(6, errorMessage);
                    break;

                default:
                    // TODO: Graceful error handling.
                    break;
            }
        }

        public static string CheckExistence(OptionObject2015 origOptObj)
        {
            // Put a log here.

            return (origOptObj == null)
                ? "An OptionObject was not sent."
                : "An OptionObject was sent.";
        }
    }
}