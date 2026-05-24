using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetPrintingSystem.Business
{
    public class JobCategory
    {
        private int id;
        private string categoryName;

        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetCategoryName(string name) { this.categoryName = name; }
        public string GetCategoryName() { return this.categoryName; }
    }
}