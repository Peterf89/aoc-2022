using System.Reflection.PortableExecutable;

namespace AoC;

// Rock A X
// Paper B Y
// Scissors C Z
public static class Helpers
{
    public static int GetCharValue(char c)
    {
        var score = (int)c % 32;
        if (char.IsUpper(c))
        {
            score += 26;
        }

        return score;
    }

    public static int GetRpsPoints(string opponent, string user)
    {
        // Opponent chooses ROCK
        if (opponent == "A" && user == "X")
        {
            // Rock draw (1 + 3)
            return 4;
        }
        if (opponent == "A" && user == "Y")
        {
            // Rock vs Paper, user wins (2 + 6)
            return 8;
        }
        if (opponent == "A" && user == "Z")
        {
            // Rock vs Scissors, user loses (3 + 0)
            return 3;
        }

        // Opponent chooses PAPER
        if (opponent == "B" && user == "X")
        {
            // Paper vs rock, user loses (1 + 0)
            return 1;
        }
        if (opponent == "B" && user == "Y")
        {
            // Paper vs Paper, draw (2 + 3)
            return 5;
        }
        if (opponent == "B" && user == "Z")
        {
            // Paper vs Scissors, user wins (3 + 6)
            return 9;
        }

        // Opponent chooses SCISSORS
        if (opponent == "C" && user == "X")
        {
            // Scissors vs rock, user wins (1 + 6)
            return 7;
        }
        if (opponent == "C" && user == "Y")
        {
            // Scissors vs Paper, user loses (2 + 0)
            return 2;
        }
        if (opponent == "C" && user == "Z")
        {
            // Scissors vs Scissors, draw (3 + 3)
            return 6;
        }

        else
        {
            throw new Exception("BS!");
        }
    }

    // A - ROCK, B - PAPER, C - SCISSORS
    // X - LOSE, Y - DRAW, Z - WIN
    public static int GetRpsPointsByOutcome(string opponent, string wishedOutcome)
    {
        switch (wishedOutcome)
        {
            // loss = 0pt
            // (1 for Rock, 2 for Paper, and 3 for Scissors)
            case "X":
                if (opponent == "A")
                {
                    // scissors 3pt
                    return 3;
                }

                if (opponent == "B")
                {
                    // rock
                    return 1;
                }
                // C = scissors, to lose is paper
                return 2;
            // draw = 3pt
            // (1 for Rock, 2 for Paper, and 3 for Scissors)
            case "Y":
                if (opponent == "C")
                {
                    // scissors 3pt
                    return 6;
                }

                if (opponent == "A")
                {
                    // rock
                    return 4;
                }
                // C = scissors, to lose is paper
                return 5;
            // win = 6pt
            // (1 for Rock, 2 for Paper, and 3 for Scissors)
            case "Z":
                if (opponent == "B")
                {
                    // scissors 3pt
                    return 9;
                }

                if (opponent == "C")
                {
                    // rock
                    return 7;
                }
                // C = scissors, to lose is paper
                return 8;
            default:
                throw new Exception("BS!");
        }
    }
}