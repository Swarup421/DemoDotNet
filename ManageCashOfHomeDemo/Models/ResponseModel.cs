﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageCashOfHomeDemo.Models
{
    public class ResponseModel
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
}