using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
  
        }

        protected void reverseNameButton_Click(object sender, EventArgs e)
        {
            // 1. Reverse your name
            // When you're finished, it should look like this:
            //llennaW etaK

            string name = "Kate Wannell";

            // Iterating through a for loop backward ...
            for (int i = name.Length - 1; i >= 0; i--)
            {
                stringResultTextBox.Text += name[i];
            }

            // Or could use an Array and reverse the order ...
            //char[] values = stringTextBox.Text.ToCharArray();
            //Array.Reverse(values);
            // stringResultTextBox.Text = new String(values);

       }

    protected void reverseSWButton_Click(object sender, EventArgs e)
        {
            // 2. Reverse this sequence: "Luke,Leia,Han,Chewbacca" ... I placed the value in the textbox. 
            //When you're finished, it should look like this: Chewbacca,Han,Leia,Luke

            // Creating a string array and putting elements into the array, separated by a comma via the split() method.
            string[] starWarsArray = StarWarsTextBox.Text.Split(',');
            string starWarsReversed = string.Empty;

            // Iterating through a for loop backward ...
            for (int i = starWarsArray.Length - 1; i >= 0; i--)
            {
                starWarsReversed += starWarsArray[i] + ","; 
            }

            // Can use the Trim() method
            starWarsResultTextBox.Text = starWarsReversed.TrimEnd(',');
            // Or the Remove() method ... 
            starWarsResultTextBox.Text = starWarsReversed.Remove(starWarsReversed.Length - 1, 1);

        }

        protected void asciiArtButton_Click(object sender, EventArgs e)
        {
            // 3.Use the squence "Luke,Leia,Han,Chewbacca" to create ascii art. I placed thestring in the textbox. Each must end up with 14 characters per line:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] starWarsArray = StarWarsTextBox.Text.Split(',');
            string starWarsPaddedString = string.Empty;

            // Iterating through a for loop and pading to 14 characters with *, centering each array element. 
            for (int i = 0; i < starWarsArray.Length; i++)
            {
                int padLeftInt = ((14 - starWarsArray[i].Length) / 2 + starWarsArray[i].Length);
                starWarsPaddedString += starWarsArray[i].PadLeft(padLeftInt, '*').PadRight(14, '*') + "<br/>";
                //starWarsPaddedString += starWarsPaddedString;
            }

           asciiArtResultLabel.Text = starWarsPaddedString;
        }

        protected void sentenceButton_Click(object sender, EventArgs e)
        {
            //4. Solve this puzzle:
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string puzzleSentence = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";

            // changing all of the characters to lowercase except the first  ... could also remove the first character and insert a capital 'N' 
            string puzzleSentenceInitCap = string.Concat(puzzleSentence.Substring(0, 1), puzzleSentence.ToLower().Substring(1));

            // Create a variable to hold the string that you want to remove
            string removeMe = "remove-me";
            // store the index of the first character of the string to be removed
            int index = puzzleSentenceResultLabel.Text.IndexOf(removeMe);
            //Remove the string using the index and the length of the string  ... also replace z with t
            puzzleSentenceResultLabel.Text = puzzleSentenceInitCap.Remove(index, removeMe.Length).Replace("z", "t");





        }
    }
}