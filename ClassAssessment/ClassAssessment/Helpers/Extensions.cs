﻿using ClassAssessment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ClassAssessment.Helpers
{
    public class Statistics
    {
        public static double GetMedian(IEnumerable<double> order)
        {
            int count = order.Count();
            if (count % 2 == 0)
                return (order.ElementAt(count / 2) + order.ElementAt(count / 2 - 1)) / 2;

            return order.ElementAt((int)Math.Floor((double)count / 2));
        }

        public static int Clamp(int lowerLimit, int upperLimit, int value)
        {
            return Math.Max(lowerLimit, Math.Min(upperLimit, value));
        }

        public static int GetModeFromAnswers(List<AnswerShort> order, int maxValue)
        {
            int[] frequency = new int[maxValue];
            int maxFrequency = 0, maxVal = 0;

            foreach (var member in order)
            {
                frequency[member.Value.Value]++;
                if (frequency[member.Value.Value] > maxFrequency)
                {
                    maxFrequency = frequency[member.Value.Value];
                    maxVal = member.Value.Value;
                }
            }

            if (maxFrequency > 1)
                return maxVal;
            return -1;
        }

        public static string GetMD5Hash(string input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();

        }
    }
}