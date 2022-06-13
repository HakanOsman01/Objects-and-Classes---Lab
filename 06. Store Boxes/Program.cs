using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
    class Box
    { 
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceItem { get; set; }
        public double CalculateBoxPrice(int quantity, double price)
        {
            this.PriceItem = this.Quantity * this.Item.Price;
            return this.PriceItem;
          
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxs = new List<Box>();
            List<string> items = new List<string>();
            string[] cmdArgs = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .ToArray();
            while(cmdArgs[0]!= "end")
            {
                string boxSerialNumber = cmdArgs[0];
                string boxItemName = cmdArgs[1];
                int quantityItem = int.Parse(cmdArgs[2]);
                double itemPrice = double.Parse(cmdArgs[3]);
                Box newBox = new Box()
                {
                    SerialNumber=boxSerialNumber,
                    Quantity=quantityItem

                };
                boxs.Add(newBox);
                newBox.Item = new Item()
                {
                    Name=boxItemName,
                    Price=itemPrice

                };
                items.Add(boxItemName);
                double currentPrice=newBox.CalculateBoxPrice(quantityItem, itemPrice);
                newBox.PriceItem = currentPrice;

                cmdArgs = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .ToArray();
            }
            //var sortedList = cars.OrderByDescending(x => x.name).ToList();
            List<Box>filterBox = (List<Box>)boxs.OrderByDescending(x => x.PriceItem).ToList();
            foreach (Box box in filterBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: " +
                    $"{box.Quantity}");
                Console.WriteLine($"-- ${box.PriceItem:f2}");
            }
        }
        
    }
}
