using System.Reflection;

using Outpost31.Core.Logger;
using Outpost31.Core.Session;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    internal class OptObj
    {

        /// <summary>The Avatar System Code that Tingen will interface with.</summary>
        /// <include file='XmlDoc/Outpost31-Common_doc.xml' path='Outpost31-Common/Type[@name="AvatarSystemCodes"]/AvatarSystemCode/*'/>
        public string SystemCode { get; set; }

        /// <summary>The original data structure sent from Avatar.</summary>
        /// <include file='XmlDoc/Outpost31-Common_doc.xml' path='Outpost31-Common/Type[@name="OptionObjects"]/SentOptionObject/*'/>
        public OptionObject2015 SentOptionObject { get; set; }

        /// <summary>The original Script Parameter sent from Avatar.</summary>
        /// <include file='XmlDoc/Outpost31-Common_doc.xml' path='Outpost31-Common/Type[@name="OptionObjects"]/SentOptionObject/*'/>
        public string SentScriptParameter { get; set; }

        /// <summary>The data structure that (is potentially) modified during a Tingen Session.</summary>
        /// <include file='XmlDoc/Outpost31-Common_doc.xml' path='Outpost31-Common/Type[@name="OptionObjects"]/WorkOptionObject/*'/>
        public OptionObject2015 WorkOptionObject { get; set; }

        /// <summary>The data structure that is returned to Avatar.</summary>
        /// <include file='XmlDoc/Outpost31-Common_doc.xml' path='Outpost31-Common/Type[@name="OptionObjects"]/ReturnOptionObject/*'/>
        public OptionObject2015 ReturnOptionObject { get; set; }


        /////* [DN01] */
        /////// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        /////// <param name="tngnSession">The Tingen Session data structure object.</param>
        /////// <param name="errorString">The OptionObject error string.</param>
        /////// <param name="errorMessage">The OptionObject error message .</param>
        /////// <include file='XmlDoc/Outpost31.Core.Avatar.ReturnObject_doc.xml' path='Outpost31.Core.Avatar.ReturnObject/Type[@name="Method"]/Finalize/*'/>
        ////public static void Finalize(TngnSession tngnSession, string errorString, string errorMessage = "")
        ////{
        ////    //LogEvent.Trace(1, ExeAsm, tnSession.TraceInfo);

        ////    tngnSession.AvData.ReturnOptionObject = tngnSession.AvData.WorkOptionObject.Clone();

        ////    switch (errorString.ToLower())
        ////    {
        ////        case "clone":
        ////        case "none":
        ////        case "success":
        ////      //      LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(0, errorMessage);
        ////            break;

        ////        case "error":
        ////        //    LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(1, errorMessage);
        ////            break;

        ////        case "okcancel":
        ////          //  LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(2, errorMessage);
        ////            break;

        ////        case "info":
        ////           // LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(3, errorMessage);
        ////            break;

        ////        case "yesno":
        ////         //   LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(4, errorMessage);
        ////            break;

        ////        case "openurl":
        ////        //   LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(5, errorMessage);
        ////            break;

        ////        case "openform":
        ////         //   LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(6, errorMessage);
        ////            break;

        ////        default:
        ////       //     LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        ////            // TODO: Graceful error handling.
        ////            break;
        ////    }
        ////}

        /////// <summary>Builds a new AvatarData data structure.</summary>
        /////// <param name="sentOptionObject">The SentOptionObject data structure sent from Avatar.</param>
        /////// <param name="sentScriptParameter">The SentScriptParameter sent from Avatar.</param>
        /////// <returns>All of the data/information Tingen needs in order to do work.</returns>
        /////// <include file='XmlDoc/Outpost31.Core.Avatar.AvatarData_doc.xml' path='Outpost31.Core.Avatar.AvatarData/Type[@name="Method"]/BuildObject/*'/>
        ////public static AvatarData BuildObject(OptionObject2015 sentOptionObject, string sentScriptParameter)
        ////{
        ////    /* Trace Logs can't go here because the logging infrastructure hasn't been initialized yet, so if you
        ////     * need to create a log file here, use a Primeval Log.
        ////     */

        ////    return new AvatarData
        ////    {
        ////        SystemCode          = "defined-at-runtime-in-Tingen.Runscript()",
        ////        SentOptionObject    = sentOptionObject,
        ////        SentScriptParameter = sentScriptParameter.ToLower(),
        ////        WorkOptionObject    = sentOptionObject.Clone(),
        ////        ReturnOptionObject  = null
        ////    };
        ////}



















        /// <summary>The executing assembly name.</summary>
        /// <remarks>This is defined here so it can be used to write log files throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;



































        ///* [DN01] */
        ///// <summary>Finalize an OptionObject so it can be returned to Avatar.</summary>
        ///// <param name="tngnSession">The Tingen Session data structure object.</param>
        ///// <param name="errorString">The OptionObject error string.</param>
        ///// <param name="errorMessage">The OptionObject error message .</param>
        ///// <include file='XmlDoc/Outpost31.Core.Avatar.ReturnObject_doc.xml' path='Outpost31.Core.Avatar.ReturnObject/Type[@name="Method"]/Finalize/*'/>
        //public static void Finalize(TngnSession tngnSession, string errorString, string errorMessage = "")
        //{
        //    //LogEvent.Trace(1, ExeAsm, tngnSession.TraceInfo);

        //    tngnSession.AvData.ReturnOptionObject = tngnSession.AvData.WorkOptionObject.Clone();

        //    switch (errorString.ToLower())
        //    {
        //        case "clone":
        //        case "none":
        //        case "success":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(0, errorMessage);
        //            break;

        //        case "error":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(1, errorMessage);
        //            break;

        //        case "okcancel":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(2, errorMessage);
        //            break;

        //        case "info":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(3, errorMessage);
        //            break;

        //        case "yesno":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(4, errorMessage);
        //            break;

        //        case "openurl":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(5, errorMessage);
        //            break;

        //        case "openform":
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            tngnSession.AvData.ReturnOptionObject.ToReturnOptionObject(6, errorMessage);
        //            break;

        //        default:
        //            //LogEvent.Trace(2, ExeAsm, tnSession.TraceInfo);
        //            // TODO: Graceful error handling.
        //            break;
         //   }
        //}
    }
}
