using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Models
{
    public class CalculatorModel
    {
        public double Item1 { get; set; }
        public double Item2 { get; set; }

        public double AddResult { get; set; }
        public double SubResult { get; set; }
        public double MulResult { get; set; }
        public double DivResult { get; set; }

        public CalculatorModel(string item1, string item2)
        {
            Item1 = double.Parse(item1);
            Item2 = double.Parse(item2);
            AddResult = Item1 + Item2;
            SubResult = Item1 - Item2;
            MulResult = Item1 * Item2;
            DivResult = Item1 / Item2;
        }
    }
}
