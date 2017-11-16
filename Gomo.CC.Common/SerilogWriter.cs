using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gomo.CC.Common
{
    public class SerilogWriter : ILogWriter
    {
        public void WriteLogInfo(string txt)
        {
            Log.Error(txt);
        }
    }
}
