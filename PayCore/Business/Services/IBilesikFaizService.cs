﻿using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IBilesikFaizService
    {
        public ResponseModel Hesaplama(BilesikFaizPayload payload);
    }
}
