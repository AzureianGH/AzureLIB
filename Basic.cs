using System.Security;

namespace AzureLIB
{
    public static class HConversion
    {
        /// <summary>
        /// Converts a string to base64
        /// </summary>
        /// <param name="input"> The string to convert </param>
        /// <returns> The base64 string </returns>
        public static string ToBase64(string input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return System.Convert.ToBase64String(bytes);
        }
        /// <summary>
        /// Converts a base64 string to a string
        /// </summary>
        /// <param name="input"> The base64 string to convert </param>
        /// <returns> The string </returns>
        public static string FromBase64(string input)
        {
            byte[] bytes = System.Convert.FromBase64String(input);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
        /// <summary>
        /// Converts an int to a hex string
        /// </summary>
        /// <param name="input"> The int to convert </param>
        /// <returns> The hex string </returns>
        public static string ToHex(int input)
        {
            return input.ToString("X");
        }
        /// <summary>
        /// Converts a hex string to an int
        /// </summary>
        /// <param name="input"> The hex string to convert </param>
        /// <returns> The int </returns>
        public static int FromHex(string input)
        {
            return int.Parse(input, System.Globalization.NumberStyles.HexNumber);
        }
        /// <summary>
        /// Converts a string to a hex string
        /// </summary>
        /// <param name="input"> The string to convert </param>
        /// <returns> The hex string </returns>
        public static string ToHex(string input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return System.BitConverter.ToString(bytes).Replace("-", "");
        }
        /// <summary>
        /// Converts a hex string to a string
        /// </summary>
        /// <param name="input"> The hex string to convert </param>
        /// <returns> The string </returns>
        public static string FromHexToString(string input)
        {
            byte[] bytes = new byte[input.Length / 2];
            for (int i = 0; i < input.Length; i += 2)
            {
                bytes[i / 2] = System.Convert.ToByte(input.Substring(i, 2), 16);
            }
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
        /// <summary>
        /// Converts a string to binary
        /// </summary>
        /// <param name="input"> The string to convert </param>
        /// <returns> The binary string </returns>
        public static string ToBinary(int input)
        {
            return System.Convert.ToString(input, 2);
        }
        /// <summary>
        /// Converts a binary string to an int
        /// </summary>
        /// <param name="input"> The binary string to convert </param>
        /// <returns> The int </returns>
        public static int FromBinary(string input)
        {
            return System.Convert.ToInt32(input, 2);
        }
        /// <summary>
        /// Converts a string to binary
        /// </summary>
        /// <param name="input"> The string to convert </param>
        /// <returns> The binary string </returns>
        public static string ToBinary(string input)
        {
            char[] chars = input.ToCharArray();
            string result = "";
            foreach (char c in chars)
            {
                result += System.Convert.ToString(c, 2).PadLeft(8, '0');
            }
            return result;
        }
        /// <summary>
        /// Converts a binary string to a string
        /// </summary>
        /// <param name="input"> The binary string to convert </param>
        /// <returns> The string </returns>
        public static string FromBinaryToString(string input)
        {
            int numOfBytes = input.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; i++)
            {
                bytes[i] = System.Convert.ToByte(input.Substring(8 * i, 8), 2);
            }
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
    public static class HConsole
    {
        /// <summary>
        /// Writes a message to the console
        /// </summary>
        /// <param name="message"> The message to write </param>
        public static void Write(string message)
        {
            System.Console.Write(message);
        }
        /// <summary>
        /// Writes a message to the console and then a new line
        /// </summary>
        /// <param name="message"> The message to write </param>
        public static void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }
        /// <summary>
        /// Writes a message to the console with a color and then a new line
        /// </summary>
        /// <param name="message"> The message to write </param>
        /// <param name="color"> The color to write the message in </param>
        /// <param name="keepColor"> Whether or not to keep the color after writing the message </param>
        public static void WriteLineColor(string message, System.ConsoleColor color, bool keepColor = false)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(message);
            if (!keepColor) System.Console.ResetColor();
        }
        /// <summary>
        /// Writes a message to the console with a color
        /// </summary>
        /// <param name="message"> The message to write </param>
        /// <param name="color"> The color to write the message in </param>
        /// <param name="keepColor"> Whether or not to keep the color after writing the message </param>
        public static void WriteColor(string message, System.ConsoleColor color, bool keepColor = false)
        {
            System.Console.ForegroundColor = color;
            System.Console.Write(message);
            if (!keepColor) System.Console.ResetColor();
        }
        /// <summary>
        /// Reads an int from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the int </param>
        /// <returns> The int read from the console </returns>
        public static int ReadInt(string message)
        {
            System.Console.Write(message);
            return int.Parse(System.Console.ReadLine());
        }
        /// <summary>
        /// Tries to read an int from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the int </param>
        /// <param name="Worked"> Whether or not the int was read successfully </param>
        /// <returns> The int read from the console </returns>
        public static int TryReadInt(string message, out bool Worked)
        {
            System.Console.Write(message);
            int result;
            bool worked = int.TryParse(System.Console.ReadLine(), out result);
            Worked = worked;
            return result;
        }
        /// <summary>
        /// Reads a float from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the float </param>
        /// <returns> The float read from the console </returns>
        public static float ReadFloat(string message)
        {
            System.Console.Write(message);
            return float.Parse(System.Console.ReadLine());
        }
        /// <summary>
        /// Tries to read a float from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the float </param>
        /// <param name="Worked"> Whether or not the float was read successfully </param>
        /// <returns> The float read from the console </returns>
        public static float TryReadFloat(string message, out bool Worked)
        {
            System.Console.Write(message);
            float result;
            bool worked = float.TryParse(System.Console.ReadLine(), out result);
            Worked = worked;
            return result;
        }
        /// <summary>
        /// Reads a double from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the double </param>
        /// <returns> The double read from the console </returns>
        public static double ReadDouble(string message)
        {
            System.Console.Write(message);
            return double.Parse(System.Console.ReadLine());
        }
        /// <summary>
        /// Tries to read a double from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the double </param>
        /// <param name="Worked"> Whether or not the double was read successfully </param>
        /// <returns> The double read from the console </returns>
        public static double TryReadDouble(string message, out bool Worked)
        {
            System.Console.Write(message);
            double result;
            bool worked = double.TryParse(System.Console.ReadLine(), out result);
            Worked = worked;
            return result;
        }
        /// <summary>
        /// Reads a string from the console
        /// </summary>
        /// <param name="message"> The message to write before reading the string </param>
        /// <returns> The string read from the console </returns>
        public static string ReadString(string message)
        {
            System.Console.Write(message);
            return System.Console.ReadLine();
        }
        /// <summary>
        /// Reads a password from the console using a secure string
        /// </summary>
        /// <param name="message"> The message to write before reading the password </param>
        /// <returns> The password read from the console </returns>
        public static SecureString ReadPassword(string message)
        {
            //use secure string
            System.Console.Write(message);
            System.Security.SecureString secure = new System.Security.SecureString();
            while (true)
            {
                System.ConsoleKeyInfo key = System.Console.ReadKey(true);
                if (key.Key == System.ConsoleKey.Enter)
                {
                    System.Console.WriteLine();
                    break;
                }
                else if (key.Key == System.ConsoleKey.Backspace)
                {
                    if (secure.Length > 0)
                    {
                        secure.RemoveAt(secure.Length - 1);
                        System.Console.Write("\b \b");
                    }
                }
                else
                {
                    secure.AppendChar(key.KeyChar);
                    System.Console.Write("*");
                }
            }
            return secure;
        }
        /// <summary>
        /// Clears the console
        /// </summary>
        public static void Clear()
        {
            System.Console.Clear();
        }
        /// <summary>
        /// Clears the console's color
        /// </summary>
        public static void ClearColor()
        {
            System.Console.ResetColor();
        }
        /// <summary>
        /// Clears the console with a color
        /// </summary>
        /// <param name="color"> The color to clear the console with (fill)</param>
        /// <param name="keepColor"> Whether or not to reset colors after clearing </param>
        public static void ClearWithColor(System.ConsoleColor color, bool keepColor = false)
        {
            //clear and loop spaces through then set cursor back to 0,0
            System.ConsoleColor oldFG = Console.ForegroundColor;
            System.ConsoleColor oldBG = Console.BackgroundColor;
            System.Console.Clear();
            System.Console.ForegroundColor = color;
            System.Console.BackgroundColor = color;
            for (int i = 0; i < System.Console.WindowHeight; i++)
            {
                System.Console.WriteLine(new string(' ', System.Console.WindowWidth));
            }
            System.Console.SetCursorPosition(0, 0);
            //reset colors
            System.Console.ForegroundColor = oldFG;
            System.Console.BackgroundColor = oldBG;
            if (!keepColor)
            {
                //replace the colors
                System.Console.ResetColor();

            }
        }
        /// <summary>
        /// Sets the console's title
        /// </summary>
        /// <param name="title"> The title to set </param>
        public static void SetTitle(string title)
        {
            System.Console.Title = title;
        }
        /// <summary>
        /// Sets the console's color
        /// </summary>
        /// <param name="color"> The color to set the console to </param>
        public static void SetFGColor(System.ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
        }
        /// <summary>
        /// Sets the console's background color
        /// </summary>
        /// <param name="color"> The color to set the console's background to </param> 
        public static void SetBGColor(System.ConsoleColor color)
        {
            System.Console.BackgroundColor = color;
        }
        /// <summary>
        /// Sets the console's color
        /// </summary>
        /// <param name="BGColor"> The color to set the console to </param>
        /// <param name="FGColor"> The color to set the console's background to </param>
        public static void SetColor(System.ConsoleColor BGColor, System.ConsoleColor FGColor)
        {
            SetFGColor(FGColor);
            SetBGColor(BGColor);
        }
        /// <summary>
        /// Reads a key from the console
        /// </summary>
        /// <returns> The key read from the console </returns>
        public static System.ConsoleKey ReadKey()
        {
            return System.Console.ReadKey().Key;
        }
        /// <summary>
        /// Reads a key from the console
        /// </summary>
        /// <param name="intercept"> Whether or not to intercept the key </param>
        /// <returns> The key read from the console </returns>
        public static System.ConsoleKey ReadKey(bool intercept)
        {
            return System.Console.ReadKey(intercept).Key;
        }
    }
}