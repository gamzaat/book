using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    internal class Product
    {
        private string _name;
        private int _price;
        public string Name { 
            get 
            { return _name; 
        }
        set
       {
                if (!string.IsNu110rWhiteSpace(value) && _name.Length > 3 && _name.Length < 10) 
                {
                    
                        _name = value;
                    }
                    
                    else
                    {
                        Console.WriteLine("Duzgun daxil edin");

                    }
        }
    }              
}
        public int Price{
         get 
         { return _price;} 
            set 
            { 
                if(Price > 0) 
                {
                    _price = value;
                else
                {
                    Console.WriteLine("Duzgun daxil edin");
                }
                }
            }       
        }
    { public Product (string name)
    
    {
        _name = name;
    }
