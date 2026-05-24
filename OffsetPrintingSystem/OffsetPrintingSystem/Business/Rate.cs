using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetPrintingSystem.Business
{
    public class Rate
    {
        private int id;
        private string rateType;
        private decimal value;

        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetRateType(string rateType) { this.rateType = rateType; }
        public string GetRateType() { return this.rateType; }

        public void SetValue(decimal value) { this.value = value; }
        public decimal GetValue() { return this.value; }
    }
}