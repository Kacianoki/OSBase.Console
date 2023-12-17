namespace OSBase.Console
{
using System;
    public enum ConsoleColor
    {
        Black,
        Blue,
        Cyan,
        DarkBlue,
        DarkCyan,
        DarkGray,
        DarkGreen,
        DarkMagenta,
        DarkRed,
        DarkYellow,
        Gray,
        Green,
        Magenta,
        Red,
        White,
        Yellow
    }
    public class Console
    {
        public static ConsoleColor ForegroundColor
        { 
            get { return ForegroundColor; } set 
            { 

                ForegroundColor = value;
                System.Console.ForegroundColor = (System.ConsoleColor)value;
            } 
        }

        public static ConsoleColor BackgroundColor
        {
            get { return BackgroundColor; }
            set
            {
                BackgroundColor = value;

                System.Console.BackgroundColor = (System.ConsoleColor)value;
            }
        }
        public static void WriteLine(object value)
        {
            System.Console.WriteLine(value);
        }
        public static void Write(object value)
        {
            System.Console.Write(value);
        }
        public static void Beep()
        {
            System.Console.Beep();
        }
        public static string ReadLine() => System.Console.ReadLine();
        public static ConsoleKeyInfo ReadKey() => System.Console.ReadKey();
    }
}