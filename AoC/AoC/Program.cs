
// ---- DAY 02 -----

//using AoC;

//string dayTwoInput = File.ReadAllText(@"C:\Gitrepos\aoc2022\day2\input.txt");

//var rounds = dayTwoInput.TrimEnd().Split('\n');

//var totalPoints = 0;

//foreach (var round in rounds)
//{
//    var input = round.Split(' ');
//    var points = Helpers.GetRpsPoints(input[0], input[1]);
//    totalPoints += points;
//    Console.WriteLine($"Its {input[0]} vs {input[1]} so you get {points} points.");
//}

//Console.WriteLine("Total points: " + totalPoints);

// PART 2
//totalPoints = 0;
//foreach (var round in rounds)
//{
//    var input = round.Split(' ');
//    var points = Helpers.GetRpsPointsByOutcome(input[0], input[1]);
//    totalPoints += points;
//    Console.WriteLine($"Its {input[0]} vs ?? to get {input[1]} so you get {points} points.");
//}

//Console.WriteLine("Total points: " + totalPoints);


//using AoC;

//string dayThreeInput = File.ReadAllText(@"C:\Gitrepos\aoc2022\day3\input.txt");
//var rucksacks = dayThreeInput.TrimEnd().Split("\n");

//var totalScore = 0;

//foreach (var rucksack in rucksacks)
//{
//    try
//    {
//        var left = rucksack.Substring(0, (int)(rucksack.Length / 2));
//        var right = rucksack.Substring((int)(rucksack.Length / 2), (int)(rucksack.Length / 2));

//        var matching = left.ToCharArray().Intersect(right.ToCharArray()).First();





//        var score = (int)matching % 32;
//        if (char.IsUpper(matching))
//        {
//            score += 26;
//        }

//        totalScore += score;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//Console.WriteLine("Total: " + totalScore);

//var groups = new List<string[]>();

//for (int i = 0; i < rucksacks.Length; i += 3)
//{
//    groups.Add(new string[]{
//        rucksacks[i],
//        rucksacks[i+1],
//        rucksacks[i+2]
//    });
//}

//Console.WriteLine(groups.Count);

//var totalPrio = 0;

//foreach (var group in groups)
//{
//    var x = group[0].Intersect(group[1].Intersect(group[2]));
//    var y = Helpers.GetCharValue(x.First());
//    Console.WriteLine(x.First() + ": "  + y);
//    totalPrio += y;
//}

//Console.WriteLine("PRIO: " + totalPrio);

using AoC.Days;

//Console.WriteLine($"Answer of day 1 part 1: {Day01.Part01and02()}");
//Console.WriteLine($"Answer of day 1 part 2: {Day01.Part02()}");
//Console.WriteLine($"Answer of day 4 part 2: {Day04.Part02()}");

Day05 dayFive = new Day05();
dayFive.Part01and02();