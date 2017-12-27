using System;

namespace SkyScraper{
    class SkyScraper{
        static void Main(string [] args){
            Random rnd = new Random();
            int [,] arr = new int [4,4];
            int x = 0, y = 0, count = 0;
            bool rowValue = true;
            bool colValue = true;
            // O(n)
            while(true){
                int temp = rnd.Next(1,5);
                // Row checker O(1) since it only goes 4 times and its constant
                for(int i = 0; i < 4; i++)
                    if(arr[i,y] == temp)
                        rowValue = false;
                // Col checker O(1) since it only goes 4 times and its constant
                for(int i = 0; i < 4; i++)
                    if(arr[x,i] == temp)
                        colValue = false;
                // This part makes it O(m) because you never know if its going to 
                // randomly generate a valid number.
                if(rowValue && colValue){
                    arr[x,y] = temp;
                    count++;
                    x++;
                    if(x == 4){
                        x = 0;
                        y++;
                    }
                }
                else{
                    rowValue = true;
                    colValue = true;
                }
                if(count == 16)
                    break;
            }
            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write("{0}", arr[i,j]);
                }
                Console.WriteLine("");
            }
            bool tick = true;
            while(tick){
                tick = playingGame(arr);
            }
        }

        private static bool playingGame(int[,] arr)
        {
            int[,] newarr = new int[8,8];
            for(int i = 0; i < 8; i++){
                for(int j = 0; j < 8; j++){
                    if((i == 1 || i == 6) || (j == 1 || j == 6)){
                        newarr[i,j] = 0;
                    }
                    else if(j == 0 || j == 7){
                        ;
                    }
                    else{
                        newarr[i,j] = arr[i-2,j-2];
                    }
                }
            }
            for(int i = 0; i < 8; i++){
                for(int j = 0; j < 8; j++){
                    Console.Write("{0}", arr[i,j]);
                }
                Console.WriteLine("");
            }
            return false;
        }
    }
}