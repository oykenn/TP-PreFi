﻿using System;

namespace Inventory
{
    public class ProductClass
    {
        // Private fields
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName;
        private string _Category;
        private string _ManufacturingDate;
        private string _ExpirationDate;
        private string _Description;

        // Constructor
        public ProductClass(string productName, string category, string mfgDate, string expDate, double price, int quantity, string description)
        {
            this._Quantity = quantity;
            this._SellingPrice = price;
            this._ProductName = productName;
            this._Category = category;
            this._ManufacturingDate = mfgDate;
            this._ExpirationDate = expDate;
            this._Description = description;
        }

        // Public properties
        public string ProductName
        {
            get { return this._ProductName; }
            set { this._ProductName = value; }
        }

        public string Category
        {
            get { return this._Category; }
            set { this._Category = value; }
        }

        public string ManufacturingDate
        {
            get { return this._ManufacturingDate; }
            set { this._ManufacturingDate = value; }
        }

        public string ExpirationDate
        {
            get { return this._ExpirationDate; }
            set { this._ExpirationDate = value; }
        }

        public double SellingPrice
        {
            get { return this._SellingPrice; }
            set { this._SellingPrice = value; }
        }

        public int Quantity
        {
            get { return this._Quantity; }
            set { this._Quantity = value; }
        }

        public string Description
        {
            get { return this._Description; }
            set { this._Description = value; }
        }
    }
}
