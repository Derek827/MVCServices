using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyServices.Controllers
{
    /// <summary>
    /// API接口描述
    /// </summary>
    public class APIController : ApiController
    {
        /// <summary>
        /// 方法描述asd
        /// </summary>
        /// <param name="Id">参数</param>
        /// <returns></returns>
        [HttpGet]
        public string TestPost(int Id)
        {
            return string.Empty;
        }
    }
}
