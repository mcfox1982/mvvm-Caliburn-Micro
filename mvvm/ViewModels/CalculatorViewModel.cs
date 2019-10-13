using Caliburn.Micro;
using mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels
{
    public class CalculatorViewModel : Screen
    {
        private string _valueItem1 = "33.3";

        public string ValueItem1
        {
            get { return _valueItem1; }
            set
            {
                _valueItem1 = value;
                NotifyOfPropertyChange(() => ValueItem1);
                NotifyOfPropertyChange(() => Calculator);
            }
        }

        private string _valueItem2 = "56.33";

        public string ValueItem2
        {
            get { return _valueItem2; }
            set
            {
                _valueItem2 = value;
                NotifyOfPropertyChange(() => ValueItem2);
                NotifyOfPropertyChange(() => Calculator);
            }
        }



        private string _resultItem = "1111";

        public string ResultItem
        {
            get { return _resultItem; }
            set { _resultItem = value; NotifyOfPropertyChange(() => ResultItem); }
        }




        private CalculatorModel _calculator;

        public CalculatorModel Calculator
        {
            get
            {
                CalculatorModel calc = new CalculatorModel(ValueItem1, ValueItem2);
                return calc;
            }
            set
            {
                _calculator = value;
            }
        }



        public CalculatorViewModel()
        {
            Calculator = new CalculatorModel(ValueItem1, ValueItem2);

        }

        public void AddMethod()
        {
            double item1 = double.Parse(ValueItem1);
            double item2 = double.Parse(ValueItem2);
            ResultItem = (item1 + item2).ToString();
        }

        public bool CanSubMethod(string valueItem1, string valueItem2)
        {
            double item1 = double.Parse(valueItem1);
            double item2 = double.Parse(valueItem2);
            if (item1 < item2) { return false; }
            return true;
        }
        public void SubMethod(string valueItem1, string valueItem2)
        {
            double item1 = double.Parse(ValueItem1);
            double item2 = double.Parse(ValueItem2);
            ResultItem = (item1 - item2).ToString();
        }
    }
}
