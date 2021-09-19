﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Core.Requests.Bin
{
    public class GetBinRequest : BaseRequest<GetBinResponse>
    {
        public string Barcode { get; set; } = "";
    }
}
