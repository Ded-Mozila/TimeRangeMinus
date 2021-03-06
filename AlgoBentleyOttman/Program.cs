﻿using System;
using BentleyOttman;

namespace AlgoBentleyOttman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program: "+ DateTime.Now.Minute+":" + DateTime.Now.Second+ ":"+DateTime.Now.Millisecond);

            Rule rule1 = new Rule(
                new Guid(), 
                new DateTime(2020,6,1, 9,0,0),
                new DateTime(2020,6,1,17,0,0), 
                1, 
                TimeMeasure.Days);
            Rule rule2 = new Rule(
                new Guid(),
                new DateTime(2020,6,1, 6,0,0), 
                new DateTime(2020,6,1,7,0,0), 
                null, TimeMeasure.None);
            Exclusion exclusion1 = new Exclusion(
                new DateTime(2020,6,6, 0,0,0),
                new DateTime(2020,6,8,0,0,0), 
                7, TimeMeasure.Days);
            Exclusion exclusion2 = new Exclusion(
                new DateTime(2020,6,2, 13,0,0),
                new DateTime(2020,6,2,14,0,0), 
                7, TimeMeasure.Days);

            Console.WriteLine("Before loop: " + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond);
            BentleyOttmanAlgorithm algo = new BentleyOttmanAlgorithm(null, new DateTime(2020,8,1));
             algo.AddRule(rule1);
             algo.AddRule(rule2);
             algo.AddRule(exclusion1);
             algo.AddRule(exclusion2);
             var result = algo.GetResult();
             
            Console.WriteLine("After loop: " + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond);
            Console.WriteLine("Finish!");
        }
    }
}
