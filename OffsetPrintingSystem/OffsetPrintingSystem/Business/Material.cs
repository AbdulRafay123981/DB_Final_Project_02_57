using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetPrintingSystem.Business
{
    public class Material
    {
        private int id;
        private string name;
        private int grammage;
        private decimal sheetWidth;
        private decimal sheetHeight;
        private int sheetsPerPacket;
        private decimal packetPrice;

        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }

        public void SetGrammage(int grammage) { this.grammage = grammage; }
        public int GetGrammage() { return this.grammage; }

        public void SetSheetWidth(decimal width) { this.sheetWidth = width; }
        public decimal GetSheetWidth() { return this.sheetWidth; }

        public void SetSheetHeight(decimal height) { this.sheetHeight = height; }
        public decimal GetSheetHeight() { return this.sheetHeight; }

        public void SetSheetsPerPacket(int sheets) { this.sheetsPerPacket = sheets; }
        public int GetSheetsPerPacket() { return this.sheetsPerPacket; }

        public void SetPacketPrice(decimal price) { this.packetPrice = price; }
        public decimal GetPacketPrice() { return this.packetPrice; }
    }
}