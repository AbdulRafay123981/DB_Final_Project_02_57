using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetPrintingSystem.Business
{
    public class ComponentTemplate
    {
        private int id;
        private int categoryId;
        private string componentName;
        private int defaultMaterialId;
        private decimal defaultWastePercent;
        private int defaultPiecesPerSheet;
        private int defaultNumberOfPlates;
        private int defaultColours;
        private bool defaultLaminationRequired;
        private bool defaultBindingRequired;
        private decimal defaultOtherCosts;

        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetCategoryId(int cid) { this.categoryId = cid; }
        public int GetCategoryId() { return this.categoryId; }

        public void SetComponentName(string name) { this.componentName = name; }
        public string GetComponentName() { return this.componentName; }

        public void SetDefaultMaterialId(int mid) { this.defaultMaterialId = mid; }
        public int GetDefaultMaterialId() { return this.defaultMaterialId; }

        public void SetDefaultWastePercent(decimal wp) { this.defaultWastePercent = wp; }
        public decimal GetDefaultWastePercent() { return this.defaultWastePercent; }

        public void SetDefaultPiecesPerSheet(int pps) { this.defaultPiecesPerSheet = pps; }
        public int GetDefaultPiecesPerSheet() { return this.defaultPiecesPerSheet; }

        public void SetDefaultNumberOfPlates(int plates) { this.defaultNumberOfPlates = plates; }
        public int GetDefaultNumberOfPlates() { return this.defaultNumberOfPlates; }

        public void SetDefaultColours(int cols) { this.defaultColours = cols; }
        public int GetDefaultColours() { return this.defaultColours; }

        public void SetDefaultLaminationRequired(bool req) { this.defaultLaminationRequired = req; }
        public bool GetDefaultLaminationRequired() { return this.defaultLaminationRequired; }

        public void SetDefaultBindingRequired(bool req) { this.defaultBindingRequired = req; }
        public bool GetDefaultBindingRequired() { return this.defaultBindingRequired; }

        public void SetDefaultOtherCosts(decimal oc) { this.defaultOtherCosts = oc; }
        public decimal GetDefaultOtherCosts() { return this.defaultOtherCosts; }
    }
}