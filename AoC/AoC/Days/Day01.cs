namespace AoC.Days
{

    public class Day01
    {
        private static List<int> caloriesList;

        public static int Part01()
        {
            string dayOneInput = File.ReadAllText(@"C:\Gitrepos\aoc2022\day1\input.txt");

            var caloriesPerElf = dayOneInput.TrimEnd().Split("\n\n");
            //Console.WriteLine("Number of elves: " + caloriesPerElf.Length);

            caloriesList = new List<int>();

            foreach (var s in caloriesPerElf)
            {
                var calories = s.Split('\n');
                int count = calories.Select(c => int.Parse(c)).Sum();
                caloriesList.Add(count);
            }

            return caloriesList.Max();
        }

        public static int Part02()
        {
            var topThreeCals = caloriesList.Max();

            //Console.WriteLine("Highest cal value: " + caloriesList.Max());
            caloriesList.Remove(caloriesList.Max());
            topThreeCals += caloriesList.Max();

            //Console.WriteLine("Highest cal value: " + caloriesList.Max());
            caloriesList.Remove(caloriesList.Max());
            topThreeCals += caloriesList.Max();
            //Console.WriteLine("Highest cal value: " + caloriesList.Max());

            //Console.WriteLine("top three: " + topThreeCals);

            return topThreeCals;
        }
    }
}
