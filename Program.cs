using System;
using System.Collections.Generic;

namespace deck
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=============================");

      // Setup
      var numbers = new List<string> {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};
      var suits = new List<string> { "clubs", "spades", "diamonds", "hearts" };
     
      var cards = new List<string> ();
      var hand1 = new List<string> ();
      var hand2 = new List<string> ();
      var playerHand = new List<string> ();

      // Create Deck
      for(var i=0;i<suits.Count;i++)
      {
        for(var j=0;j<numbers.Count;j++)
        {
          cards.Add($"{numbers[j]} of {suits[i]}");
        }
      }

     // Display Deck
     //Console.WriteLine("In Order");
     //Console.WriteLine("");
     //for(var i=0;i<cards.Count;i++) Console.WriteLine(cards[i]);


      // Randomize Deck
     var rand = new Random();
     var n = 52;
     for(var i=n-1;i>0;i--) {
       var j = rand.Next(i);
       var hold = cards[i];
       cards[i] = cards[j];
       cards[j] = hold;
       }

      // Display Deck
      //Console.WriteLine("");
      //Console.WriteLine("Randomized");
      //for(var i=0;i<cards.Count;i++) Console.WriteLine(cards[i]);

      // Display Top 2 Cards And Display Them
      Console.WriteLine("");
      Console.WriteLine("Top 2 cards");

      playerHand.Add(cards[0]);
      playerHand.Add(cards[1]);  

      Console.WriteLine(cards[0]);
      Console.WriteLine(cards[1]);
      
    }
  }
}



    


    
