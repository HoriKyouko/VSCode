using System;
using System.Text;

namespace CaesarCipher {
    static class StringExtension{
        private static int amountOfCounts(char value, string phrase){
            int temp = 0;
            for(int i = 0; i < phrase.Length; i++)
                if(phrase[i] == value)
                    temp++;
            
            return temp;
        }
        private static int amountOfLowers(string phrase){
            int temp = 0;
            for(int i = 0; i < phrase.Length; i++)
                if(Char.IsLower(phrase, i))
                    temp++;
            
            return temp;
        }

        private static float chisqr(float[] x, float[] y){
            double temp = 0;
            for(int i = 0; i < x.Length; i++){
                float value = x[i]-y[i];
                float power = (float)Math.Pow(value, 2);
                temp += power/y[i];
            }
            return (float)temp;
        }

        private static string decode(int y, string phrase){
            return encode(-y, phrase);
        }

        private static string encode(int y, string phrase){
            StringBuilder temp = new StringBuilder();
            for(int i = 0; i < phrase.Length; i++)
                temp.Append(shift(y, phrase[i]));

            return temp.ToString();
        }

        private static float[] frequency(string phrase){
            float [] frequencyTable = new float[26];
            char [] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int n = amountOfLowers(phrase);
            for(int i = 0; i < 26; i++){
                char temp = alphabet[i]; 
                frequencyTable[i] = percentage(amountOfCounts(temp, phrase), n);
            }
            return frequencyTable;
        }

        private static int let2nat(char x){
            return x - 97;
        }

        private static char nat2let(int x){
            return (char)('a' + x);
        }

        private static float percentage(int x, int y){
            return ((float) x / (float) y) * 100;
        }
        
        private static int position(float x, float [] y){
            return positions(x, y, 0);
        }

        private static int positions(float x, float[] y, int z){
            float head = y[0];
            float [] tail = new float [y.Length - 1];
            for(int i = 0; i < y.Length - 1; i++)
                tail[i] = y[i+1];
            
            if(x == head)
                return z;
            else
                z = positions(x, tail, z+1);

            return z;
        }

        public static float [] rotate(int x, float [] y){
            float [] temp = new float [y.Length];
            int lastValue = y.Length - x;
            
            int count = x;
            for(int i = 0; i < y.Length; i++){
                if(count >= y.Length)
                    count = 0;
                temp[i] = y[count];
                count++;
            }

            return temp;
        } 

        private static string shift(int y, char x){
            string temp = x.ToString();
            int value = let2nat(x);
            
            if(value < 0)
                return temp;
            else if(value > 25)
                return temp;
            else if(value + y < 0)
                return nat2let(value + y + 26).ToString();
            else
                return nat2let(value + y % 26).ToString();
        }
        public static string Cracked(string phrase){
            float [] table = {8.2F, 1.5F, 2.8F, 4.3F, 12.7F, 2.2F, 2.0F, 6.1F, 7.0F, 0.2F, 0.8F, 4.0F, 2.4F, 6.7F, 7.5F, 1.9F, 0.1F, 6.0F, 6.3F, 9.1F, 2.8F, 1.0F, 2.4F, 0.2F, 2.0F, 0.1F};
            float [] tablePrime = frequency(phrase);
            float [] chisqrtable = new float[26];
            for(int i = 0; i < 26; i++)
                chisqrtable[i] = chisqr(rotate(i, tablePrime), table);
            
            float min = float.MaxValue;
            for(int i = 0; i < chisqrtable.Length; i++){
                if(chisqrtable[i] < min)
                    min = chisqrtable[i];
            }
            int y = position(min, chisqrtable);
            return decode(y, phrase);
        }
    }
    class CaesarCipher{
        static void Main(string[] args){
            string cracked = StringExtension.Cracked("myxqbkdevkdsyxc yx mywzvodsxq dro ohkw!");
            Console.WriteLine(cracked);
        }
    }
}