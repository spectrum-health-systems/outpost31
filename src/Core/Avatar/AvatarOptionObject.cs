// =============================================================================
// Outpost31.Core.Avatar.AvatarOptionObject.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

using System.Reflection;
using ScriptLinkStandard.Objects;
using Outpost31.Core.Session;

namespace Outpost31.Core.Avatar
{
    /// <summary>The AvatarOptionObject contains metadata about the Avatar environment.</summary>
    /// <remarks>For more information about Outpost31, please see the <see cref="Outpost31.ProjectInfo"/> file.</remarks>
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



        public static void ToReturn(Instance session, int errorCode, string errorMessage = "")
        {
            //LogEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);

            session.OptionObject.Completed = session.OptionObject.Worker.Clone();

            // Put logs in switch?

            switch (errorCode)
            {
                case 0:
                    session.OptionObject.Completed.ToReturnOptionObject(0, errorMessage);
                    break;

                case 1:
                    session.OptionObject.Completed.ToReturnOptionObject(1, errorMessage);
                    break;

                case 2:
                    session.OptionObject.Completed.ToReturnOptionObject(2, errorMessage);
                    break;

                case 3:
                    session.OptionObject.Completed.ToReturnOptionObject(3, errorMessage);
                    break;

                case 4:
                    session.OptionObject.Completed.ToReturnOptionObject(4, errorMessage);
                    break;

                case 5:
                    session.OptionObject.Completed.ToReturnOptionObject(5, errorMessage);
                    break;

                case 6:
                    session.OptionObject.Completed.ToReturnOptionObject(6, errorMessage);
                    break;

                default:
                    // TODO: Graceful error handling.
                    break;
            }
        }

        /// <summary>Verify if an OptionObject was sent from Avatar.</summary>
        /// <param name="origOptObj">The original OptionObject sent from Avatar.</param>
        /// <returns>A string indicating if an OptionObject was sent or not.</returns>
        public static string VerifyExistence(OptionObject2015 origOptObj) =>
            (origOptObj == null)
                ? "An OptionObject was not sent."
                : "An OptionObject was sent.";
    }
}