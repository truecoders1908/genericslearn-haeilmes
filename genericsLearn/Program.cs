using System;
using System.Collections.Generic;

namespace genericsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Generics are a type of placeholder so that when creating a program with 
             * multiple data types you can streamline the way things are handled based on
             * what type of information is being passed through at any given time.
             * 
             * This main program is used to create a virtual bag of
             * letters and then pull one of them out of said bag and 
             * then return a letter at random. */

            Bag<char> scrabbleLetters = new Bag<char>();
            //The line above is creating a new list of characters to be the letters.
            scrabbleLetters.PutItemIntoBag('q');
            scrabbleLetters.PutItemIntoBag('j');
            scrabbleLetters.PutItemIntoBag('z');
            scrabbleLetters.PutItemIntoBag('y');
            scrabbleLetters.PutItemIntoBag('x');
            /*The 4 lines above are referencing the method in which the characters 
             * are added to a created list which becomes this virtual bag of letters.
             */
            char letterFromBag = scrabbleLetters.GetItemFromBag();
            /*This line is referencing the method where it takes the information in 
             * the created list and retrieves a character.
             */
            Console.WriteLine(letterFromBag);
            //This returns the letter that was picked from the bag.
        }
    }

    class Bag<T>
     /*This is where we are declaring a new class which is named "Bag" and has a generic
      * datatype <T> to be used throughout the methods in the class so not to have to specify
      * what that is for every different type used in the class.
      */
    {
        private List<T> items = new List<T>();
        //This is creating a list of whatever data may be passed through it.

        public void PutItemIntoBag(T item)
        {
            items.Add(item);
        }
        /*The method is taking the information being passed through from the main method and 
         * adding them to the list being instanced above.
         */
        public T GetItemFromBag()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, items.Count);
            T randomItem = items[randomIndex];
            items.RemoveAt(randomIndex);
            return randomItem;
        }
        /*This method is for creating a randomly generated number for the index or location of 
         * the items in the list above and then using that generic placeholder T to create a new 
         * type of data that becomes the random letter to eventually be returned to the main method
         */
    }
}