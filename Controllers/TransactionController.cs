using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UF.AssessmentProject.Controllers
{
    [Produces("application/json"),
        Route("api/[action]"),
        ApiController]
    [SwaggerTag("Transaction Middleware Controller to keep transactional data in Log Files")]
    public class TransactionController : ControllerBase
    {
        /// <summary>
        /// Submit Transaction data
        /// </summary>
        /// <remarks>
        /// Ensure all parameter needed and responded as per IDD
        /// Ensure all posible validation is done
        /// API purpose: To ensure all data is validated and only valid partner with valid signature are able to access to this API
        /// </remarks>
        /// <param name="req">language:en-US(English), ms-MY(BM)</param>  
        /// <returns></returns>
        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, "Submit Transaction Message successfully", typeof(Model.Transaction.ResponseMessage))]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized, Request")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Oops! Can't get your Post right now")]
        public ActionResult<Model.Transaction.ResponseMessage> SubmitTRansaction(Model.Transaction.RequestMessage req)
        {
            Model.Transaction.ResponseMessage results = new Model.Transaction.ResponseMessage();
          
            // Your Code here

            return Ok(results);
        }

        /// <summary>
        /// Test this controller is active
        /// </summary>
        /// <remarks>
        /// Test API to check API is Alive or not
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> TestAPI()
        {
            string result = "Hello World!";
            return Ok(result);
        }
    }
}
