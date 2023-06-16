namespace code_signal;

public static class BestAppartmentLocation
{
    private static List<Dictionary<int, bool>> _blocks = new List<Dictionary<int, bool>>
    {
        // 0 - gym
        // 1 - school
        // 2 - store
        new Dictionary<int, bool> // 0
        {
            { 0, false },
            { 1, true },
            { 2, false }
        },
        new Dictionary<int, bool> // 1
        {
            { 0, true },
            { 1, false },
            { 2, false }
        },
        new Dictionary<int, bool> // 2
        {
            { 0, true },
            { 1, true },
            { 2, false }
        },
        new Dictionary<int, bool> // 3
        {
            { 0, false },
            { 1, true },
            { 2, false }
        },
        new Dictionary<int, bool> // 3
        {
            { 0, false },
            { 1, true },
            { 2, true }
        }
    };

    public static int solution()
    {
        // choose the best apartment in the block that has gym, school and stores nearby
        // for this input should be the fourth
        // theres a school
        // a gym before
        // a store after
        // if is in the first interation check if the three values are true or
        // if the value of i + 1 combined with the current i is all true
        // if i > 0 check the current iteration, the iteration before and the iteration after

        var currentGym = 0;
        var currentSchool = 0;
        var currentStore = 0;

        var previousGym = 0;
        var previousSchool = 0;
        var previousStore = 0;

        var nextGym = 0;
        var nextSchool = 0;
        var nextStore = 0;

        // first
        for (int i = 0; i == 0; i++)
        {
            for (var j = 0; j <= _blocks[0].Count; j++)
            {
                if (j == 0)
                {
                    if (_blocks[i][j] == true)
                        currentGym = 1;
                    if (_blocks[i + 1][j] == true)
                        nextGym = 1;
                    continue;
                }
                if (j == 1)
                {
                    if (_blocks[i][j] == true)
                        currentSchool = 1;
                    if (_blocks[i + 1][j] == true)
                        nextSchool = 1;
                    continue;
                }
                if (j == 2)
                {
                    if (_blocks[i][j] == true)
                        currentStore = 1;
                    if (_blocks[i + 1][j] == true)
                        nextStore = 1;
                    continue;
                }
            }
            var currentTotal = currentGym + currentSchool + currentStore;
            var nextTotal = nextGym + nextSchool + nextStore;
            var total = currentTotal + nextTotal;

            if (currentGym == 1 && currentGym == nextGym)
                total -= 1;

            if (currentSchool == 1 && currentSchool == nextSchool)
                total -= 1;

            if (currentStore == 1 && currentStore == nextStore)
                total -= 1;

            if (total == 3)
            {
                Console.WriteLine($"block {i}");
                return i;
            }
        }

        // middle
        currentGym = 0;
        currentSchool = 0;
        currentStore = 0;

        previousGym = 0;
        previousSchool = 0;
        previousStore = 0;

        nextGym = 0;
        nextSchool = 0;
        nextStore = 0;
        for (int i = 1; i < _blocks.Count; i++)
        {
            for (var j = 0; j <= _blocks[0].Count; j++)
            {
                if (j == 0)
                {
                    if (_blocks[i - 1][j] == true)
                        previousGym = 1;
                    if (_blocks[i][j] == true)
                        currentGym = 1;
                    if (_blocks[i + 1][j] == true)
                        nextGym = 1;
                    continue;
                }
                if (j == 1)
                {
                    if (_blocks[i - 1][j] == true)
                        previousSchool = 1;
                    if (_blocks[i][j] == true)
                        currentSchool = 1;
                    if (_blocks[i + 1][j] == true)
                        nextSchool = 1;
                    continue;
                }
                if (j == 2)
                {
                    if (_blocks[i - 1][j] == true)
                        previousStore = 1;
                    if (_blocks[i][j] == true)
                        currentStore = 1;
                    if (_blocks[i + 1][j] == true)
                        nextStore = 1;
                    continue;
                }
                var previousTotal = previousGym + previousSchool + previousStore;
                var currentTotal = currentGym + currentSchool + currentStore;
                var nextTotal = nextGym + nextSchool + nextStore;
                var total = previousTotal + currentTotal + nextTotal;

                if (currentGym == 1)
                {
                    if (currentGym == previousGym)
                        total -= 1;
                    if (currentGym == nextGym)
                        total -= 1;
                }
                else if (previousGym == 1)
                {
                    if (previousGym == currentGym)
                        total -= 1;
                    if (previousGym == nextGym)
                        total -= 1;
                }
                else if (nextGym == 1)
                {
                    if (nextGym == currentGym)
                        total -= 1;
                    if (nextGym == previousGym)
                        total -= 1;
                }

                if (currentSchool == 1)
                {
                    if (currentSchool == previousSchool)
                        total -= 1;
                    if (currentSchool == nextSchool)
                        total -= 1;
                }
                else if (previousSchool == 1)
                {
                    if (previousSchool == currentSchool)
                        total -= 1;
                    if (previousSchool == nextSchool)
                        total -= 1;
                }
                else if (nextSchool == 1)
                {
                    if (nextSchool == currentSchool)
                        total -= 1;
                    if (nextSchool == previousSchool)
                        total -= 1;
                }

                if (currentStore == 1)
                {
                    if (currentStore == previousStore)
                        total -= 1;
                    if (currentStore == nextStore)
                        total -= 1;
                }
                else if (previousStore == 1)
                {
                    if (previousStore == currentStore)
                        total -= 1;
                    if (previousStore == nextStore)
                        total -= 1;
                }
                else if (nextStore == 1)
                {
                    if (nextStore == currentStore)
                        total -= 1;
                    if (nextStore == previousStore)
                        total -= 1;
                }

                if (total == 3)
                {
                    Console.WriteLine($"block {i}");
                    return i;
                }
            }
        }

        // last
        currentGym = 0;
        currentSchool = 0;
        currentStore = 0;

        previousGym = 0;
        previousSchool = 0;
        previousStore = 0;

        nextGym = 0;
        nextSchool = 0;
        nextStore = 0;

        for (int i = 4; i == 4; i++)
        {
            for (var j = 0; j <= _blocks[0].Count; j++)
            {
                if (j == 0)
                {
                    if (_blocks[i][j] == true)
                        currentGym = 1;
                    if (_blocks[i - 1][j] == true)
                        previousGym = 1;
                    continue;
                }
                if (j == 1)
                {
                    if (_blocks[i][j] == true)
                        currentSchool = 1;
                    if (_blocks[i - 1][j] == true)
                        previousSchool = 1;
                    continue;
                }
                if (j == 2)
                {
                    if (_blocks[i][j] == true)
                        currentStore = 1;
                    if (_blocks[i - 1][j] == true)
                        previousStore = 1;
                    continue;
                }
            }
            var currentTotal = currentGym + currentSchool + currentStore;
            var previousTotal = previousGym + previousSchool + previousStore;
            var total = currentTotal + previousTotal;

            if (currentGym == 1 && currentGym == previousGym)
                total -= 1;

            if (currentSchool == 1 && currentSchool == previousSchool)
                total -= 1;

            if (currentStore == 1 && currentStore == previousStore)
                total -= 1;

            if (total == 3)
            {
                Console.WriteLine($"block {i}");
                return i;
            }
        }

        return 0;
    }
}