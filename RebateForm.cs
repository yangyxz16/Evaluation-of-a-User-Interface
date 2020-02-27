using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3_xxy180008
{
    class RebateForm
    {
        private DateTime startTime;
        private DateTime endTime;
        private int backcount;

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int Backcount { get => backcount; set => backcount = value; }

        public RebateForm() { }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(startTime.ToLongTimeString()).Append(",")
                .Append(endTime.ToLongTimeString()).Append(",")
                .Append(backcount);

            return sb.ToString();
        }
    }
}
