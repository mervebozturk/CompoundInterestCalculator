using Business.Models;
using Business.Services;
using Business.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PayCore.Controllers
{
    [Route("Faiz")]
    public class FaizHesaplamaController : ControllerBase
    {
        public readonly IBilesikFaizService _bilesikFaizService;
        private readonly BilesikFaizValidator _validator;

        public FaizHesaplamaController(IBilesikFaizService bilesikFaizService)
        {
            _bilesikFaizService = bilesikFaizService;
            _validator = new BilesikFaizValidator();
        }

        [Route("bilesik-faiz")]
        [HttpPost]
        public ActionResult<ResponseModel> BilesikFaiz([FromBody] BilesikFaizPayload payload)
        {
            var hataMesajlari = _validator.Validate(payload);
            if (!hataMesajlari.IsValid)
            {
                List<string> hataResponse = new List<string>();

                foreach (var hata in hataMesajlari.Errors)
                    hataResponse.Add(hata.ToString());

                return BadRequest(hataResponse);
            }

            var response = _bilesikFaizService.Hesaplama(payload);
            return Ok(response);
        }
    }
}
