namespace Assignment_5._2._1
{
    class Program
    {
        static int LengthOfLastWord(string s)
        {
           
            s = s.TrimEnd();

            int length = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                    break; 
                length++;
            }

            return length;
        }

        static void Main(string[] args)
        {
            string input1 = "Hello World";
            Console.WriteLine($"Output 1: {LengthOfLastWord(input1)}"); 

            string input2 = " fly me to the moon ";
            Console.WriteLine($"Output 2: {LengthOfLastWord(input2)}"); 
        }
    }
}