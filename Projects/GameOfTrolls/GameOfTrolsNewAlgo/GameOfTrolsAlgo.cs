using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static int[,] towerArray;
    static List<Tower> towers = new List<Tower>();
    static Tower towerToPlay;
    static int C;
    static int N;
    static bool left = false;
    static bool right = false;
    static bool top = false;
    static bool bottom = false;
    static bool shouldTake = false;
    static int difference = 0;
    static int totalPoints = 0;
    static int initialArrayPoints = 0;

    static void Main()
    {
        DateTime startTime = DateTime.Now;
        ReadingInput();
        //ReadingInputFromConsole();
        CheckingValues();
        GameLogic();
        DateTime endTime = DateTime.Now;
        Console.WriteLine("Time: {0}", (endTime - startTime));
        Console.WriteLine("Array points at the begining: {0}", initialArrayPoints);
        Console.WriteLine("Array points in the end: {0}", CalculateArrayPoints());
        Console.WriteLine("{0} - {1} = {2}",
            initialArrayPoints, CalculateArrayPoints(), initialArrayPoints - CalculateArrayPoints());
    }

    static int CalculateArrayPoints()
    {
        int sum = 0;
        for (int i = 1; i < towerArray.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < towerArray.GetLength(1) - 1; j++)
            {
                sum += towerArray[i, j];
            }
        }
        return sum;
    }

    private static void GameLogic()
    {
        while (C > 0)
        {
            if (towers.Count >= 1)
            {
                towerToPlay = towers[0];
                CheckingCurrentPoints();
                for (int i = 1; i <= towerToPlay.Difference && towers.Count > 0; i++)
                {
                    if (C > 0)
                    {
                        if (towerToPlay.ShoulPlayTake == true)
                        {
                            towerArray[towerToPlay.Row, towerToPlay.Col]--;
                            Console.WriteLine("take {0} {1}", towerToPlay.Row - 1, towerToPlay.Col - 1);
                        }
                        else
                        {
                            towerArray[towerToPlay.Row, towerToPlay.Col]++;
                            Console.WriteLine("put {0} {1}", towerToPlay.Row - 1, towerToPlay.Col - 1);
                        }
                        if (i == towerToPlay.Difference)
                        {
                            DestroingTowers();
                        }
                    }
                    C--;
                    if (C == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                CheckingValues();
                CalculateArrayPoints();
                if (CalculateArrayPoints() == 0 && towers.Count == 0)  //Creating artifical game logic until turnes = 0
                {
                    while (C > 0)
                    {
                        int row = 1;
                        int col = 1;
                        towerArray[row, col]++;
                        if (C % 2 == 0)
                        {
                            towerArray[row, col]++;
                            Console.WriteLine("put {0} {1}", row - 1, col - 1);
                            C--;
                        }
                        Console.WriteLine("put {0} {1}", row - 1, col - 1);
                        C--;
                        towerArray[row, col]--;
                        Console.WriteLine("take {0} {1}", row - 1, col - 1);
                        C--;
                    }
                }
                if (towers.Count == 0) // If List of Towers is empty , finds first tower and starts destroying it
                {
                    for (int row = 0; row < towerArray.GetLength(0); row++)
                    {
                        for (int col = 0; col < towerArray.GetLength(1); col++)
                        {
                            if (towerArray[row, col] > 0)
                            {
                                towerArray[row, col]--;
                                Console.WriteLine("take {0} {1}", row - 1, col - 1);
                                C--;
                                if (towerArray[row, col] == 0 || C == 0)
                                {
                                    break;
                                }
                            }
                        }
                        if (C == 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
    // Printing the Game List in File 
    private static void PrintList()
    {
        StreamWriter writer = new StreamWriter("List.txt");
        using (writer)
        {
            foreach (var tower in towers)
            {
                writer.WriteLine("Row: {0,-4} Col: {1,-4} TotalPoints: {2,-4} Difference: {3,-5} L: {4,-5} T: {5,-5} R: {6,-5} B: {7,-5}", tower.Row, tower.Col, tower.TotalPoints, tower.Difference, tower.LeftNeighbour, tower.TopNeighbour, tower.RigthNeigbour, tower.BottomNeighbour);
            }
        }
    }

    private static void DestroingTowers()
    {
        towerArray[towerToPlay.Row, towerToPlay.Col] = 0;

        if (towerToPlay.LeftNeighbour == true)
        {
            towerArray[towerToPlay.Row, towerToPlay.Col - 1] = 0;
        }
        if (towerToPlay.TopNeighbour == true)
        {
            towerArray[towerToPlay.Row - 1, towerToPlay.Col] = 0;
        }
        if (towerToPlay.RigthNeigbour == true)
        {
            towerArray[towerToPlay.Row, towerToPlay.Col + 1] = 0;
        }
        if (towerToPlay.BottomNeighbour == true)
        {
            towerArray[towerToPlay.Row + 1, towerToPlay.Col] = 0;
        }
        towers.Remove(towerToPlay);
    }
    //Mehtod Checking if current tower have correct TotalPoints. If not tower is removed from List
    private static void CheckingCurrentPoints()
    {
        int currentPoints = towerArray[towerToPlay.Row, towerToPlay.Col];

        if (towerToPlay.LeftNeighbour == true)
        {
            currentPoints += towerArray[towerToPlay.Row, towerToPlay.Col - 1];
        }
        if (towerToPlay.TopNeighbour == true)
        {
            currentPoints += towerArray[towerToPlay.Row - 1, towerToPlay.Col];
        }
        if (towerToPlay.RigthNeigbour == true)
        {
            currentPoints += towerArray[towerToPlay.Row, towerToPlay.Col + 1];
        }
        if (towerToPlay.BottomNeighbour == true)
        {
            currentPoints += towerArray[towerToPlay.Row + 1, towerToPlay.Col];
        }
        if (towerToPlay.TotalPoints == currentPoints)
        {
            return;
        }
        else
        {
            towers.Remove(towerToPlay);
            if (towers.Count == 0)
            {
                return;
            }
            towerToPlay = towers[0];
            CheckingCurrentPoints();
        }
    }
    //Method for gathering of the gamefield's information
    private static void CheckingValues()
    {
        for (int row = 1; row < towerArray.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < towerArray.GetLength(1) - 1; col++)
            {
                {
                    bool leftIsUsed = false;
                    bool rightIsUsed = false;
                    bool topIsUsed = false;
                    bool bottomIsUsed = false;
                    int leftAndCentralSum = towerArray[row, col] + towerArray[row, col - 1];
                    int rightAndCentralSum = towerArray[row, col] + towerArray[row, col + 1];
                    int topAndCentralSum = towerArray[row, col] + towerArray[row - 1, col];
                    int bottomtAndCentralSum = towerArray[row, col] + towerArray[row + 1, col];

                    // Check for group of 4 or less neigbours
                    if ((leftAndCentralSum == rightAndCentralSum ||
                        leftAndCentralSum == topAndCentralSum ||
                        leftAndCentralSum == bottomtAndCentralSum) &&
                        leftAndCentralSum >= towerArray[row, col])
                    {
                        difference = towerArray[row, col - 1] - towerArray[row, col];
                        if (Math.Abs(difference) < C)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += towerArray[row, col - 1];
                            left = true;
                            leftIsUsed = true;
                            if (leftAndCentralSum == rightAndCentralSum)
                            {
                                right = true;
                                rightIsUsed = true;
                                totalPoints += towerArray[row, col + 1];
                            }
                            if (leftAndCentralSum == topAndCentralSum)
                            {
                                top = true;
                                topIsUsed = true;
                                totalPoints += towerArray[row - 1, col];
                            }
                            if (leftAndCentralSum == bottomtAndCentralSum)
                            {
                                bottom = true;
                                bottomIsUsed = true;
                                totalPoints += towerArray[row + 1, col];
                            }
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }
                    // Check for group of 3 or less neigbours
                    if ((topAndCentralSum == rightAndCentralSum ||
                        topAndCentralSum == bottomtAndCentralSum) &&
                        ((topAndCentralSum != leftAndCentralSum) &&
                        topAndCentralSum >= towerArray[row, col]))
                    {

                        difference = towerArray[row - 1, col] - towerArray[row, col];
                        if (Math.Abs(difference) < C)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += towerArray[row - 1, col];
                            top = true;
                            topIsUsed = true;
                            if (topAndCentralSum == rightAndCentralSum)
                            {
                                right = true;
                                rightIsUsed = true;
                                totalPoints += towerArray[row, col + 1];
                            }
                            if (topAndCentralSum == bottomtAndCentralSum)
                            {
                                bottom = true;
                                bottomIsUsed = true;
                                totalPoints += towerArray[row + 1, col];
                            }
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }
                    // Check for group of 2 neigbours
                    if ((rightAndCentralSum == bottomtAndCentralSum) &&
                        (rightAndCentralSum != topAndCentralSum &&
                        rightAndCentralSum != leftAndCentralSum) &&
                        rightAndCentralSum >= towerArray[row, col])
                    {
                        difference = towerArray[row, col + 1] - towerArray[row, col];
                        if (Math.Abs(difference) < C)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += (towerArray[row, col + 1] + towerArray[row + 1, col]);
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }
                                right = true;
                                rightIsUsed = true;
                                bottom = true;
                                bottomIsUsed = true;
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }

                    //Checking if Left Neighbour should be added
                    if (leftAndCentralSum >= towerArray[row, col] && leftIsUsed == false)
                    {

                        difference = towerArray[row, col - 1] - towerArray[row, col];
                        if (Math.Abs(difference) < C && Math.Abs(difference) <= 10)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += towerArray[row, col - 1];
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }
                                left = true;
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }
                    //Checking if Rightneigbour Should be added
                    if (rightAndCentralSum >= towerArray[row, col] && rightIsUsed == false)
                    {
                        difference = towerArray[row, col + 1] - towerArray[row, col];
                        if (Math.Abs(difference) < C && Math.Abs(difference) <= 10)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += towerArray[row, col + 1];
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }

                                right = true;
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }

                    //Checkign if Top neighbourShould be added
                    if (topAndCentralSum >= towerArray[row, col] && topIsUsed == false)
                    {
                        difference = towerArray[row - 1, col] - towerArray[row, col];
                        if (Math.Abs(difference) < C && Math.Abs(difference) <= 10)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += towerArray[row - 1, col];
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }
                                top = true;
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }
                    //Checking if Bottom neighbour should be added
                    if (bottomtAndCentralSum >= towerArray[row, col] && bottomIsUsed == false)
                    {
                        difference = towerArray[row + 1, col] - towerArray[row, col];
                        if (Math.Abs(difference) < C && Math.Abs(difference) <= 10)
                        {
                            totalPoints = towerArray[row, col];
                            totalPoints += towerArray[row + 1, col];
                            if (totalPoints > towerArray[row, col])
                            {
                                if (difference < 0)
                                {
                                    shouldTake = true;
                                    difference = difference * (-1);
                                }
                                bottom = true;
                                towers.Add(new Tower(row, col, difference, totalPoints, left, right, top, bottom, shouldTake));
                            }
                        }
                        ResetVariables();
                    }
                }
            }
        }
        // Ordering Towers

        towers = towers.OrderBy(t => t.Difference).ThenByDescending(t => t.TotalPoints).ToList();
        //towers = towers.OrderByDescending(t => t.TotalPoints).ThenBy(t => t.Difference).ToList();
        //towers = towers.OrderBy(t => t.Difference).ThenByDescending(t => t.TotalPoints).ToList();
        //PrintList();
    }

    private static void ResetVariables()
    {
        left = false;
        right = false;
        top = false;
        bottom = false;
        shouldTake = false;
        difference = 0;
        totalPoints = 0;
    }
    // Filling the frame around the Game Field
    private static void FillingTheFrame()
    {
        for (int row = 0; row < towerArray.GetLength(0); row++)
        {
            for (int col = 0; col < towerArray.GetLength(1); col++)
            {
                if (row == 0 || col == 0 || row == towerArray.GetLength(1) - 1 || col == towerArray.GetLength(1) - 1)
                {
                    towerArray[row, col] = -1;
                }
            }
        }
    }
    // Printing Game Board on Console
    private static void ShowingResult()
    {
        for (int row = 1; row < towerArray.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < towerArray.GetLength(1) - 1; col++)
            {
                Console.Write("{0,4} ", towerArray[row, col]);
            }
            Console.WriteLine();
        }
    }
    //Method for reading the Initial Data from File
    static void ReadingInput()
    {
        string fileLocation = "input.txt";
        StreamReader reader = new StreamReader(fileLocation);
        using (reader)
        {
            C = int.Parse(reader.ReadLine());
            N = int.Parse(reader.ReadLine());
            int extendetN = N + 2;
            towerArray = new int[extendetN, extendetN];
            FillingTheFrame();
            for (int row = 1; row < towerArray.GetLength(0) - 1; row++)
            {
                string rowData = reader.ReadLine();
                string[] rowCell = rowData.Split(' ');

                for (int col = 1; col < towerArray.GetLength(1) - 1; col++)
                {
                    towerArray[row, col] = int.Parse(rowCell[col - 1]);
                    initialArrayPoints += towerArray[row, col];
                }
            }
        }
    }
    //Method for reading the Initial Data from Console
    static void ReadingInputFromConsole()
    {
        C = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());
        int extendetN = N + 2;
        towerArray = new int[extendetN, extendetN];
        FillingTheFrame();
        for (int row = 1; row < towerArray.GetLength(0) - 1; row++)
        {
            string rowData = Console.ReadLine();
            string[] rowCell = rowData.Split(' ');

            for (int col = 1; col < towerArray.GetLength(1) - 1; col++)
            {
                towerArray[row, col] = int.Parse(rowCell[col - 1]);
                initialArrayPoints += towerArray[row, col];
            }
        }
    }
}

class Tower
{
    private int row;
    private int col;
    private int difference;
    private int totalPoints;
    private bool leftNeighbour;
    private bool rightNeighbour;
    private bool topNeighbour;
    private bool bottomNeighbour;
    private bool shouldPlayTake;

    public int Row
    {
        get { return this.row; }
        set { this.row = value; }
    }
    public int Col
    {
        get { return this.col; }
        set { this.col = value; }
    }

    public int Difference
    {
        get { return this.difference; }
        set { this.difference = value; }
    }
    public int TotalPoints
    {
        get { return this.totalPoints; }
        set { this.totalPoints = value; }
    }

    public bool LeftNeighbour
    {
        get { return this.leftNeighbour; }
        set { this.leftNeighbour = value; }
    }
    public bool RigthNeigbour
    {
        get { return this.rightNeighbour; }
        set { this.rightNeighbour = value; }
    }
    public bool TopNeighbour
    {
        get { return this.topNeighbour; }
        set { this.bottomNeighbour = value; }
    }
    public bool BottomNeighbour
    {
        get { return this.bottomNeighbour; }
        set { this.bottomNeighbour = value; }
    }

    public bool ShoulPlayTake
    {
        get { return this.shouldPlayTake; }
        set { this.shouldPlayTake = value; }
    }

    public Tower(int row, int col, int difference, int totalPoints, bool leftNeighbour, bool rightNeighbour, bool topNeighbour, bool bottomNeighbour, bool shouldTake)
    {
        this.row = row;
        this.col = col;
        this.difference = difference;
        this.totalPoints = totalPoints;
        this.leftNeighbour = leftNeighbour;
        this.rightNeighbour = rightNeighbour;
        this.topNeighbour = topNeighbour;
        this.bottomNeighbour = bottomNeighbour;
        this.shouldPlayTake = shouldTake;
    }
}

