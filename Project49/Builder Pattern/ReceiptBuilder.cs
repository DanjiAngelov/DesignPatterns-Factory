using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Builder_Pattern
{
    public class ReceiptBuilder
    {
        private string receipt = "";

        public void AddHeader()
        {
            receipt += "FAST FOOD\n";
        }

        public void AddItem(string name, double price)
        {
            receipt += $"{name} - {price} лв\n";
        }

        public void AddTotal(double total)
        {
            receipt += $"Общо: {total} лв\n";
        }

        public string GetReceipt()
        {
            return receipt;
        }
    }
}
