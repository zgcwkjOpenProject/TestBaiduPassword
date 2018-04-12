using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace zgcwkj
{
    public static class Hash
    {
        //哈希类 36进制
        //有效哈希[10000000,11679615]
        public static string Hash2Str(int hash)
        {
            string ret = "";
            hash -= 10000000;
            while (hash > 0)
            {
                ret += Hash2Char(hash % 36);
                hash /= 36;
            }
            if (ret.Length == 3) ret += "0";//前导零
            if (ret.Length == 2) ret += "00";
            if (ret.Length == 1) ret += "000";
            if (ret.Length == 0) ret += "0000";
            return reverse(ret);
        }
        public static int Str2Hash(string str)
        {
            int ret = 0;
            ret += Char2Hash(str[0]) * 46656;
            ret += Char2Hash(str[1]) * 1296;
            ret += Char2Hash(str[2]) * 36;
            ret += Char2Hash(str[3]);
            ret += 10000000;//防止前导零
            return ret;
        }
        private static int Char2Hash(char c)
        {
            if (c >= '0' && c <= '9') return c - '0';
            else return c - 'a' + 10;
        }
        private static char Hash2Char(int hash)
        {
            if (hash >= 0 && hash <= 9) return (char)('0' + hash);
            else return (char)('a' + hash - 10);
        }
        private static string reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}