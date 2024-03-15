using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapSnackWindowsForms"), InternalsVisibleTo("GUI")]

namespace KnappSnack
{
    internal class Result
    {
        public int totalWeight { get; set; }
        public int totalValue { get; set; }

        public List<Item> result { get; set; }

        public Result(int totalWeight, int totalValue, List<Item> result)
        {
            this.totalWeight = totalWeight;
            this.totalValue = totalValue;
            this.result = result;
        }

        public override string ToString()
        {

            string resultString = " ";
            foreach (Item item in result)
            {
                resultString += item.ToString() + " ";
            }
            
            string result2 = $"\n totalWeight = {this.totalWeight} \n\n totalValue = {this.totalValue}\n";

            return resultString + result2;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Result other = (Result)obj;

            if (totalWeight != other.totalWeight || totalValue != other.totalValue)
                return false;

            if (result.Count != other.result.Count)
                return false;

            for (int i = 0; i < result.Count; i++)
            {
                if (!result[i].Equals(other.result[i]))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + totalWeight.GetHashCode();
                hash = hash * 23 + totalValue.GetHashCode();
                foreach (var item in result)
                {
                    hash = hash * 23 + item.GetHashCode();
                }
                return hash;
            }
        }

    }
}
