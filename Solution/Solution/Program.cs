class Result
{
    public static int ReverseInt(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
    public static bool IsPalindrome(int x)
    {
        int reversedInt = Result.ReverseInt(x);

        if (x != reversedInt)
        {
            return false;
        } else
        {
            return true;
        }
    }
}
class Solution
{
    public static void Main(String[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        bool isPalindrome = Result.IsPalindrome(input);
    }
}