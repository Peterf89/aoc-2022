namespace AoC.Days
{
    public class Day04
    {
        public static int Part02()
        {
            string dayFourInput = File.ReadAllText(@"C:\Gitrepos\aoc2022\day4\input.txt");
            string[] pairs = dayFourInput.TrimEnd().Split('\n');
            var count = 0;
            foreach (var pair in pairs)
            {
                var elfs = pair.Split(',');
                var left = elfs[0].Split('-');
                var right = elfs[1].Split('-');

                var leftFirst = int.Parse(left.First());
                var leftLast = int.Parse(left.Last());

                var rightFirst = int.Parse(right.First());
                var rightLast = int.Parse(right.Last());

                int[] valuesLeft = Enumerable.Range(leftFirst, (leftLast + 1) - leftFirst).ToArray();
                int[] valuesRight = Enumerable.Range(rightFirst, (rightLast + 1) - rightFirst).ToArray();

                var intersects = valuesRight.Intersect(valuesLeft).Any();
                //Console.WriteLine($"{valuesLeft} intersects with {valuesRight}? {intersects}");

                if (intersects)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
