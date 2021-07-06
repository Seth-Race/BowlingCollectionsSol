using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingCollections {
    class Bowling {
        Random rnd = new Random();
        List<int> game = new List<int>();

        public int Bowl() {
            for (var idx = 1; idx <= 10; idx++) {
                var score = rnd.Next(31);
             //   Console.Write($"Enter score for frame {idx}:   ");
             //   var score = Convert.ToInt32(Console.ReadLine());
                game.Add(score);
            }
            var total = 0;
            foreach (var score in game) {
                total += score;
            }
            return total;
        }
    
    }

}
