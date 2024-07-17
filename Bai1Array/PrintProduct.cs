﻿using Bai1Array.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Array
{
    public static class PrintProduct
    {
        //In ra product
        public static void Print(this Product? product)
        {
            if(product == null)
            {
                Console.WriteLine("Cannot find product");
            }
            else
            {
                Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity} ,Category: {product.CategoryId}");
            }
        }

        //In ra danh sách product
        public static void Print(this List<Product> products)
        {
            if (products.Count == 0) {
                Console.WriteLine("Cannot find any product");
            }
            foreach (var product in products)
            {
                Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity} ,Category: {product.CategoryId}");
            }
        }

        //In ra danh sách product map với category
        public static void Print(this Dictionary<Product, Category?> productCategoryMap)
        {
            foreach (var keyValue in productCategoryMap)
            {
                Console.WriteLine($"Product Id: {keyValue.Key.Id}, Name: {keyValue.Key.Name}, Price: {keyValue.Key.Price}, Quantity: {keyValue.Key.Quantity}, Category name: {keyValue.Value?.Name ?? "null"}");
            }
        }
    }
}