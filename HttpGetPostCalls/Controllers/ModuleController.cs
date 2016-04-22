using AppObjects;
using HttpGetPostCalls.ClassObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace HttpGetPostCalls.Controllers
{
    public class ModuleController : ApiController
    {
        /// <summary>
        /// http get module list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetModuleList()
        {
            string result = string.Empty;
            List<BaseObject> lstStates = new List<BaseObject>();
            BaseObject obj = new BaseObject();
            obj.Id = 1;
            obj.Name = "Karnataka";
            lstStates.Add(obj);
            obj = new BaseObject();
            obj.Id = 3;
            obj.Name = "Delhi";
            lstStates.Add(obj);

            //json stringfy the result
            result = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstStates);
            return result;
        }


    }
}
