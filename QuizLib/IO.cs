namespace Classes
{
    public static class IO
    {
        public static T Input<T>()
        {
            var userInput = Console.ReadLine() ?? string.Empty;

            try
            {
                var value = (T)Convert.ChangeType(userInput, typeof(T));
                return value;

            }
            catch (Exception)
            {
                throw new FormatException($"The input '{userInput} is not in a correct format for type {typeof(T).Name}.");
            }
        }

        public static void Output<T>(T msg)
        {
            if (msg == null) return;
            Console.WriteLine(msg.ToString());
        }
    }
}
