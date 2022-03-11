using System;
using System.Collections.Generic;
using System.Text;

namespace Testik
{
    public class Product
    {
        private string _name;
        private string _image;

        public string Name => _name;
        public string Image => _image;

        public Product(string name, string image)
        {
            _name = name;
            _image = image;
        }
    }
}
