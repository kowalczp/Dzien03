﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private String name;
        private double price;
        private String descr = String.Empty;
        private int version = 0;

        public double Price { get { return price; } }

        public String Name { get { return name; } }

        public Product(int id, String name, double price, String descr = "")
        {
            this.id = id; this.name = name; this.price = price; this.descr = descr;
        }

        public override string ToString()
        {
            return String.Format("Id = {0}, Nazwa = {1}, cena ={2}", id, name, price);
        }

    }
}