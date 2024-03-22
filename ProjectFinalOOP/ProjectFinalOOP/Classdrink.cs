using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalOOP
{
    internal class Classdrink
    {
        private string _name;
        private string _amount;
        private string _price;
        private string _code;

        public Classdrink(string name, string amount, string price, string code)
        {
            this._name = name;
            this._amount = amount;
            this._price = price;
            this._code = code;
        }
        public string getname()
        {
            return _name;
        }
        public string getamount()
        {
            return _amount;
        }
        public string getprice()
        {
            return _price;
        }
        public string getcode()
        {
            return _code;
        }
    }
}
