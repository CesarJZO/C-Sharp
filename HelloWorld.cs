namespace CesarJZO
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.WriteLine("Hello, world!");
            else for (int i = 1; i < args.Length; i++)
                Console.WriteLine($"Hello, {args[i]}!");
        }
    }
}
