namespace GitHubFiles.Exercises;

class E1962LongTimeAgo
{
    public static void Run()
    {
        const int PROBLEM_CURRENT_YEAR = 2015;
        int totalTests, passedYears, yearsDifference;
        string result;
        
        totalTests = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalTests; i++)
        {
            passedYears = int.Parse(Console.ReadLine()) - 1;
            yearsDifference = Math.Abs((passedYears - PROBLEM_CURRENT_YEAR) + 1);
        
            if (passedYears < PROBLEM_CURRENT_YEAR - 1)
            {
        
                result = $"{yearsDifference} D.C."; 
            }
            else if (passedYears == PROBLEM_CURRENT_YEAR - 1)
            {
                result = "1 A.C."; 
            }
            else
            {
                result = $"{yearsDifference + 1} A.C."; 
            }
        
            Console.WriteLine(result);
        }
    }
}