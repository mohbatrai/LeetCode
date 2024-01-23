using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            //REST API Tracker
            string ip = "172.217.20.46";
            string result = Result.ipTracker(ip);
            Console.WriteLine(result);


            // Example usage:
            int n = 5;
            float[] weight = { 1.01f, 1.99f, 2.5f, 1.5f, 1.01f };
            int output = Jaintor.efficientJanitor(weight);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }


    class Result
    {

        /*
         * Complete the 'ipTracker' function below.
         *
         * URL for cut and paste
         * https://jsonmock.hackerrank.com/api/ip?ip=<ip>
         *
         * The function is expected to return a STRING.
         * The function accepts a singe parameter ip.
         * 
         * In case of no ip record, return string 'No Result Found'
         */

        public static string ipTracker(string ip)
        {
            string apiUrl = $"https://jsonmock.hackerrank.com/api/ip?ip={ip}";
            string res = "";
            WebRequest requestobjGet = WebRequest.Create(apiUrl);
            requestobjGet.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)requestobjGet.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                res = sr.ReadToEnd();
                sr.Close();

                JObject jsonData = JObject.Parse(res);
                int total = (int)jsonData["total"];
                if (total == 0)
                    return "No Result Found";
                // Extract country code from the first record
                return (string)jsonData["data"][0]["country"];

            }

        }

    }


    class Jaintor
    {

        //the janitor of a high school is extremely efficient.By the end of each day, all of the school's waste is in
        //plastic bags weighing between 1.01 pounds and 3.00 pounds. All plastic bags are then taken to the trash bins 
        //outside. One trip is described as selecting a number of bags which together do not weigh more than 3.00 pounds,
        //dumping them in the outside trash can and returning to the school. Given the number of plastic bags n, and the 
        //weights of each bag, determine the minimum number of trips the janitor has to make.

       public static int efficientJanitor(float[] weight)
        {
            Array.Sort(weight);

            int trips = 0;
            int leftIndex = 0;
            int rightIndex = weight.Length - 1;

            while (leftIndex <= rightIndex)
            {
                // Combine the lightest and heaviest bags
                float combinedWeight = weight[leftIndex] + weight[rightIndex];

                // Check if they can be carried together in one trip
                if (combinedWeight <= 3.0f)
                {
                    leftIndex++;
                }

                // Move to the next bag, even if it can't be combined with the current one
                rightIndex--;

                // Increment the number of trips
                trips++;
            }

            return trips;
        }

    }

}
