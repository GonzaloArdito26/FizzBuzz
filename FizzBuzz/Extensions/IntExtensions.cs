
namespace FizzBuzz.Extensions
{
    public static class IntExtensions
    {
        public static bool MultipleOf(this int a, int b)
        {
            return (a % b) == 0;
        }
    }
}
