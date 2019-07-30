using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gif_Shoot_Game
{
    public class Logical
    {
        int loser = 0;
        Random instance_Object = new Random();
        //this is post define method that is used to find the winner if the player win the game then 
        public int find_winner()
        {
            int win = instance_Object.Next(1, 6);
                loser = loser + 1;
            return loser;
        }
        public int first_Fire()
        {
            //pass the random no to the global variable for compare the triger count 
           int Random_Fire = instance_Object.Next(1, 6);
            return Random_Fire;
        }
    }
}
