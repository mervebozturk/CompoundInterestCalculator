using Business.Models;
using Business.Services;
using Business.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class BilesikFaizManager : IBilesikFaizService
    {
        public ResponseModel Hesaplama(BilesikFaizPayload payload)
        {
            var responseModel = new ResponseModel();

            double toplamTutar = payload.AnaPara * Math.Pow((1 + (payload.FaizOrani / 100)), payload.Sure);

            responseModel.ToplamTutar = toplamTutar;
            responseModel.KazanilanFaizTutari = toplamTutar - payload.AnaPara;

            return responseModel;
        }
    }
}
