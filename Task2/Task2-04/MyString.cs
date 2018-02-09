using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_04
{
    class MyString
    {
        private char[] content;

        public int Length => this.content.Length;

        public MyString(char[] content)
        {
            this.content = new char[content.Length];
            content.CopyTo(this.content, 0);
        }

        public MyString(string content)
        {
            this.content = content.ToCharArray();
        }

        public MyString(char content)
        {
            this.content = new char[] { content };
        }

        public char this[int index] => this.content[index];

        public char[] Content => this.content;

        public static MyString operator +(MyString string_1, MyString string_2)
        {
            char[] string_3 = new char[string_1.Length + string_2.Length];
            string_1.Content.CopyTo(string_3, 0);
            string_2.Content.CopyTo(string_3, string_1.Length);
            return new MyString(string_3);
        }

        public static bool operator ==(MyString string_1, MyString string_2)
        {
            return string_1.Content == string_2.Content;
        }

        public static bool operator !=(MyString string_1, MyString string_2)
        {
            return string_1.Content != string_2.Content;
        }

        public static MyString Concat(MyString string_1, MyString string_2)
        {
            return string_1 + string_2;
        }

        public MyString Concat(MyString string_1)
        {
            return this + string_1;
        }

        public int IndexOf(char symbol)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.content[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOf(char symbol, int start)
        {
            for (int i = start; i < this.Length; i++)
            {
                if (this.content[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOf(char[] symbol)
        {
            bool flag = false;
            for (int j = 0; j < this.Length; j++)
            {
                if (this.content[j] == symbol[0])
                {
                    for (int i = 1; i < symbol.Length; i++)
                    {
                        if (this.content[j + i] != symbol[i])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        return j;
                    }
                    flag = false;
                }
            }
            return -1;
        }

        public int IndexOf(char[] symbol, int start)
        {
            bool flag = false;
            for (int j = start; j < this.Length; j++)
            {
                if (this.content[j] == symbol[0])
                {
                    for (int i = 1; i < symbol.Length; i++)
                    {
                        if (this.content[j + i] != symbol[i])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        return j;
                    }
                    flag = false;
                }
            }
            return -1;
        }

        public int LastIndexOf(char[] array)
        {
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (this.content[i] == array[0])
                {
                    for (int j = 0; j < this.Length; j++)
                    {
                        if (this.content[i + j] != array[j])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int IndexOf(MyString contentString)
        {
            bool flag = false;
            for (int j = 0; j < this.Length; j++)
            {
                if (this.content[j] == contentString[0])
                {
                    for (int i = 1; i < contentString.Length; i++)
                    {
                        if (this.content[j + i] != contentString[i])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        return j;
                    }
                    flag = false;
                }
            }
            return -1;
        }

        public int IndexOf(MyString contentString, int start)
        {
            bool flag = false;
            for (int j = start; j < this.Length; j++)
            {
                if (this.content[j] == contentString[0])
                {
                    for (int i = 1; i < contentString.Length; i++)
                    {
                        if (this.content[j + i] != contentString[i])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        return j;
                    }
                    flag = false;
                }
            }
            return -1;
        }

        public MyString SubString(int start)
        {
            char[] strArray = new char[this.Length - start];
            for (int i = start; i < content.Length; i++)
            {
                strArray[i - start] = content[i];
            }
            return new MyString(strArray);
        }

        public MyString SubString(int start, int length)
        {
            char[] strArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                strArray[i] = content[start + i];

            }
            return new MyString(strArray);
        }

        public MyString Remove(int start, int count)
        {
            char[] strArray = new char[this.Length - count];
            for (int i = 0; i < start; i++)
            {
                strArray[i] = content[i];
            }
            for (int j = start + count; j < this.Length; j++)
            {
                strArray[j - count] = content[j];
            }
            return new MyString(strArray);
        }

        public MyString Remove(int start)
        {
            char[] strArray = new char[start];
            for (int i = 0; i < start; i++)
            {
                strArray[i] = content[i];
            }
            return new MyString(strArray);
        }

        public MyString Replace(MyString oldValue, MyString newValue)
        {
            int[] indexArray = new int[this.Length];
            int index = 0, count = 0;
            do
            {
                index = this.IndexOf(oldValue, index);
                if (index != -1)
                {
                    indexArray[count] = index;
                    count++;
                    index++;
                }
            }
            while (index != -1);

            char[] finalValue = new char[this.Length + (newValue.Length - oldValue.Length) * indexArray.Length];
            int y = 0;
            for (int i = 0; i < this.Length; i++)
            {
                if (i == indexArray[y])
                {
                    for (int j = 0; j < newValue.Length; j++)
                    {
                        finalValue[i + (newValue.Length - oldValue.Length) * y + j] = newValue[j];
                    }
                    y++;
                }
                else
                {
                        finalValue[i + (newValue.Length - oldValue.Length) * y] = this.content[i];
                }
            }
            return new MyString(finalValue);
        }

        public virtual bool Equals(object obj)
        {
            if (obj is MyString)
            {
                MyString myObj = (MyString)obj;
                return myObj == obj;
            }
            return false;
        }

        public virtual int GetHashCode()
        {
            return this.content.GetHashCode();
        }

        public virtual string ToString()
        {
            return new string(this.content);
        }
    }
}

