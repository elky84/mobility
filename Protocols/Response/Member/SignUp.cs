﻿using Mobility.Protocols.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobility.Protocols.Response.Member
{
    public class SignUp : ResponseHeader
    {
        public string Token { get; set; }
    }
}
