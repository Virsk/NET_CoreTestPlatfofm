namespace Extensions_LINQ.Extens
{
    static class Extensions
    {
        public static void PrintDataAndBeep<T>(this IEnumerable<T> iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
            Console.Beep();
        }
    }
}