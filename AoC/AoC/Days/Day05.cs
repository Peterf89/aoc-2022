using System.Diagnostics;

namespace AoC.Days
{
    public class Day05
    {
        private string dayFiveInput;
        private Dictionary<int, Stack<string>> ship;

        public Day05()
        {
            dayFiveInput = File.ReadAllText(@"C:\Gitrepos\aoc2022\day5\input.txt").TrimEnd();
            ship = new Dictionary<int, Stack<string>>()
            {
                { 1, new Stack<string>() },
                { 2, new Stack<string>() },
                { 3, new Stack<string>() },
                { 4, new Stack<string>() },
                { 5, new Stack<string>() },
                { 6, new Stack<string>() },
                { 7, new Stack<string>() },
                { 8, new Stack<string>() },
                { 9, new Stack<string>() }
            };
        }

        public void Part01and02()
        {
            var lines = dayFiveInput.Split('\n');
            var stackLines = lines.Take(8).ToArray();

            for (var i = stackLines.Length - 1; i >= 0; i--)
            {
                var lineLength = stackLines[i].Length;
                //Console.WriteLine($"-------------------- line {i} ---------------------------");
                var takeNumber = 4;

                for (var j = 0; j < lineLength; j += 4)
                {
                    if (j == 32)
                    {
                        takeNumber = 3;
                    }

                    var possibleCrate = stackLines[i].Substring(j, takeNumber).Trim();
                    if (possibleCrate.Length == 3)
                    {
                        //Console.WriteLine("Found crate: " + possibleCrate + " for stack " + (j / 4));
                        ship[(j / 4)+1].Push(possibleCrate);
                    }
                    else
                    {
                        //Console.WriteLine("found something else: " + possibleCrate);
                    }
                }
            }

            var moveLines = lines.TakeLast(lines.Length - 10);

            foreach (var moveLine in moveLines)
            {
                //Console.WriteLine(moveLine);
                var moves = moveLine.Split(' ');
                //DoMove9000(int.Parse(moves[1]), int.Parse(moves[3]), int.Parse(moves[5]));
                DoMove9001(int.Parse(moves[1]), int.Parse(moves[3]), int.Parse(moves[5]));
            }

            var outcome = "";
            foreach (var stack in ship)
            {
                if (stack.Value.Any())
                {
                    outcome += stack.Value.Peek();
                }
            }

            Console.WriteLine(outcome.Replace("[", string.Empty).Replace("]", string.Empty));
        }

        private void DoMove9000(int amount, int source, int destination)
        {
            Console.WriteLine($"Moving {amount} crates from {source} to {destination}");
            while (amount > 0)
            {
                var crate = ship[source].Pop(); 
                ship[destination].Push(crate);
                amount--;
            }
        }

        private void DoMove9001(int amount, int source, int destination)
        {
            Console.WriteLine($"Moving {amount} crates from {source} to {destination}");
            var tempStack = new Stack<string>();
            while (amount > 0)
            {
                tempStack.Push(ship[source].Pop());
                amount--;
            }

            while (tempStack.Count > 0)
            {
                ship[destination].Push(tempStack.Pop());
            }
        }
    }
}