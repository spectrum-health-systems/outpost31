/* Outpost31.Module.Admin.Parse.cs
 * u250625_code
 * u250625_documentation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using Outpost31.Core.Blueprint;

namespace Outpost31.Module.Admin
{
    public class Parse
    {
        /// <summary>Admin requests.</summary>
        public static void Request(WsvcSession tngnWbsvSession)
        {
            switch (tngnWbsvSession.ScriptParam.Original.ToLower())
            {
                case "admin.reset.config":
                    Reset.Config(tngnWbsvSession.RuntimeConfig.AvtrSys);
                    break;

                case "admin.status.current":
                    Status.Current(tngnWbsvSession);
                    break;

                default:
                    tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, ErrorContent.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
                    break;
            }
        }
    }
}
