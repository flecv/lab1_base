using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab
{
    public class lab1_base
    {
        //function call will choose natural numbers from the list
        public static List<object> GetIntegerFromList(IEnumerable<object> list)
        {
            var num = list.Where(n => n is int).ToList();
            return num;
        }
        //function call will choose first npn-repeatable letter
        public static string first_non_repeated_letter(string word)
        {
            string lower_word = word.ToLower();
            char[] c = lower_word.ToCharArray();
            //amount of repeats
            int k = 0;
            int letter = 0;
            for (int i = 0; i < lower_word.Length; i++)
            {
                for (int j = 0; j < lower_word.Length; j++)
                {
                    if (c[i] == c[j])
                        k++;
                }
                //k == 1 because we go throught whole word and the letter matches itself
                if (k == 1)
                {
                    letter = i;
                    break;
                }
            }
            if (k == 1)
            {
                char[] d = word.ToCharArray();
                return d[letter].ToString();
            }
            //return nothing if all letters are repeatable 
            else return "";
        }
        public static int digit_root(int num)
        { 
                while (true)
                {
                    int sum = 0;
                    while (num % 10 > 0)
                    {
                        sum = (num % 10) + sum;
                        num = num / 10;
                    }

                    if (sum / 10 > 0)
                    {
                        num = sum;
                        continue;
                    }
                    return sum;
                }
         
        }
        //Go throught list and sum elements with each other. Not to repeat pairs we should start the second for in previous i
        public static int count_pairs(int[] arr, int target)
        {
            int pairs = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (i != j && arr[i] + arr[j] == target)
                        pairs++;
                }
            }

            return pairs;
        }
        
        public static string sort_guests(string guests)
        {
            //split guests by ; in list and uppercase them all
            List<string> guest_list = new List<string>();
            string[] words = guests.ToUpper().Split(';');
            //look through all guests in list, reverse them by : and add to the main list
            foreach (string guest in words)
            {
                var person = guest.Split(':').Reverse();
                guest_list.Add(string.Join(", ", person));
            }
            guest_list.Sort();
            //transform list to the proper output format
            return '(' + string.Join(")(", guest_list) + ')';
        }
    }
}
