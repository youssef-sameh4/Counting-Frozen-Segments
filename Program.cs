namespace CountingFrozenSegments
{
    internal class Program
    {
        static int CountMeltedIce(string str)
        {
            int melted_ice = 0;
            char[] arr = str.ToCharArray();
            bool anyMelted;

            do
            {
                anyMelted = false;
                int count_Cold_air = 0;
                List<int> toMelt = new List<int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '_')
                    {
                        count_Cold_air++;
                    }
                    else
                    {
                        count_Cold_air = 0;  
                    }

                    if (count_Cold_air >= 3)
                    {
                        if (i + 1 < arr.Length && arr[i + 1] == 'I')
                        {
                            toMelt.Add(i + 1); 
                        }
                    }
                }

                foreach (int idx in toMelt)
                {
                    arr[idx] = '_';
                    melted_ice++;
                    anyMelted = true;
                }

            } while (anyMelted);

            return melted_ice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the frozen tunnel pattern (I for ice, _ for cold air):");
            string str = Console.ReadLine();
            int melted = CountMeltedIce(str);
            Console.WriteLine($"Total ice blocks melted: {melted} ");
        }
    }
}
