﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace CodeScanningService
{
    public interface ICodeScanningServiceLayer
    {
        public string scanCode(CodeModel code);
    }
}
