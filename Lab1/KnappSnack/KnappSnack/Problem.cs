using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("unitTests")]

namespace KnappSnack
{
    internal class Problem
    {
        int amountOfProducts { get; set; }
        int seed { get; set; }
        List<Item> items { get; set; }

        public Problem(int amountOfProducts, int seed, List<Item> items)
        {
            this.amountOfProducts = amountOfProducts;
            this.seed = seed;
            this.items = items;
        }

        public Problem(int amountOfProducts, int seed)
        {
            this.amountOfProducts = amountOfProducts;
            this.seed = seed;
            this.items = items;
            generateListItems();
        }
        public Problem(int amountOfProducts)
        {
            this.amountOfProducts = amountOfProducts;
            this.seed = Int32.MaxValue;
            generateListItems();
        }

        public Result solveKnappSnackProblem(int capacity)
        {
            int availableCapacity = capacity;

            int totalWeight = 0;
            int totalValue = 0;

            List<Item> resultListItems = new List<Item>();

            items.Sort((x, y) => y.ratio.CompareTo(x.ratio));

            foreach (Item element in items)
            {
                availableCapacity -= element.weight;
                if (availableCapacity >= 0) {
                    resultListItems.Add(element);
                    totalWeight += element.weight;
                    totalValue += element.value;
                }
            }

            return new Result(totalWeight, totalValue, resultListItems);
        }

        private void generateListItems() { 

            Random random = new Random(seed);
            List<Item> result = new List<Item>();
            
            int counterId = 1;
            for (int i = 0; i < amountOfProducts; i++)
            {
                int weight = random.Next(1,10);
                int value = random.Next(1,10);
                Item item = new Item(value, weight, counterId);
                result.Add(item);
                counterId++;
            }

            this.items = result;
        }

    }
}
