namespace FKTV
{
    public class ConsoleLoggerClass
    {
        public void LogNewLineBlue(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(inputString);
            Console.ResetColor();
        }

        public void LogNewLineYellow(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(inputString);
            Console.ResetColor();
        }

        public void LogNewLineMagenta(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(inputString);
            Console.ResetColor();

        }

        public void LogNewLineRed(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(inputString);
            Console.ResetColor();

        }

        public void LogNewLineGreen(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(inputString);
            Console.ResetColor();

        }

        public void LogSameLineGreen(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(inputString);
            Console.ResetColor();

        }

        public void LogNewLineDefault(string inputString)
        {
            Console.WriteLine(inputString);
        }

        public void LogSameLine(string inputString)
        {
            Console.Write(inputString);
        }

        public void LogLineShift()
        {
            Console.WriteLine();
        }

    }
}
