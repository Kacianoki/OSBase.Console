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
                #if WINDOWS
                System.Console.ForegroundColor = (System.ConsoleColor)value;
                #endif
                #if UNITY_STANDALONE_WIN

                #endif

            } 
        }

        public static ConsoleColor BackgroundColor
        {
            get { return BackgroundColor; }
            set
            {
                BackgroundColor = value;

                #if WINDOWS
                System.Console.BackgroundColor = (System.ConsoleColor)value;
                #endif
            }
        }
        public static void WriteLine(object value)
        {
            #if WINDOWS
            System.Console.WriteLine(value);
            #endif
        }
        public static void Write(object value)
        {
            #if WINDOWS
            System.Console.Write(value);
            #endif
        }
        public static void Beep()
        {
            #if WINDOWS
            System.Console.Beep();
            #endif
        }
    }
}