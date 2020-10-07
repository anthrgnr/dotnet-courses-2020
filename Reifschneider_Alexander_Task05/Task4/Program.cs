namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] c1 = { 'a', 'b', 'c', 'd', 'e', 'f' };
            char[] c2 = { 'c', 'd' };
            MyString mstr1 = new MyString(c1);
            MyString mstr2 = new MyString(c2);
            System.Console.WriteLine("First String: " + mstr1 + "\nSecon String: " + mstr2);
            System.Console.WriteLine("Sum of Strings: " + mstr1 + mstr2);
            System.Console.WriteLine("Difference of Strings: " + (mstr1 - mstr2));
            System.Console.WriteLine("Are Strings Equal? " + (mstr1 == mstr2));
        }
    }

    public class MyString
    {
        private char[] str;

        public MyString()
        {
        }

        public MyString(char[] s)
        {
            str = s;
        }

        public static bool Equals(MyString ms1, MyString ms2)
        {
            if (ms1.str.Length == ms2.str.Length)
            {
                for (int i = 0; i < ms1.str.Length; i++)
                {
                    if (ms1.str[i] != ms2.str[i])
                        return false;
                }
                return true;
            }
            else
                return false;
        }

        public static MyString operator +(MyString ms1, MyString ms2)
        {
            char[] c = new char[ms1.str.Length + ms2.str.Length];
            ms1.str.CopyTo(c, 0);
            ms2.str.CopyTo(c, ms1.str.Length);
            return new MyString(c);
        }

        public static MyString operator -(MyString ms1, MyString ms2)
        {
            if (ms2.str.Length > ms1.str.Length)
            {
                return ms1;
            }

            int index = -1;
            for (int i = 0; i < ms1.str.Length - ms2.str.Length + 1; i++)
            {
                for (int j = 0; j < ms2.str.Length; j++)
                {
                    if (ms1.str[i + j] != ms2.str[j])
                    {
                        break;
                    }
                    index = i;
                }
            }

            if (index != -1)
            {
                char[] result = new char[ms1.str.Length - ms2.str.Length];
                for (int i = 0; i < index; i++)
                {
                    result[i] = ms1.str[i];
                }
                for (int i = index; i < ms1.str.Length - ms2.str.Length; i++)
                {
                    result[i] = ms1.str[i + ms2.str.Length];
                }
                return new MyString(result);
            }
            else
            {
                return ms1;
            }
        }

        public static bool operator ==(MyString ms1, MyString ms2)
        {
            return Equals(ms1, ms2);
        }

        public static bool operator !=(MyString ms1, MyString ms2)
        {
            return !Equals(ms1, ms2);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }
    }
}