class Program
{
    static public void Main(String[] args)
    {


        string someString ;
        int point;
        bool isNumerical = false;
        do
        {
            Console.WriteLine("Enter your point");
            someString = Console.ReadLine();
            isNumerical = int.TryParse(someString, out point);
            if (point <0 || point>100)
            {
                isNumerical = false;
            }

        } while (isNumerical == false);
        int gradingResult = gradingStudents(point);
        if (gradingResult >= 40)
        {
            Console.WriteLine($"Congratulations you are successful: {gradingResult}");
        }
        else
        {
            Console.WriteLine($"Unfortunately you are fail: {gradingResult}");
        }
    }

    static int gradingStudents(int grade)
    {
        
        if (grade == 0 || grade == 100)
        {
            return grade;

        }

        int roundNumber = grade % 10;
        int count = 0;
        if (roundNumber >= 5)
        {
            count = 10;
        }
        else
        {
            count = 5;
        }
        int result = grade;

        return count - roundNumber >= 3 ? result : result - roundNumber + count;
    }
}