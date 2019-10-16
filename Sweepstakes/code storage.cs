using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class code_storage
    {

        public class CustomList<T> : IEnumerable<T>
            public CustomList()
        {
            items = new T[4];
            capacity = 4;
            count = 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }



    static class Program
    {
        private static Random _random = new Random();
        private static Dictionary<string, int> _dict;
        private static Dictionary<string, int> _hits;
        private static int _nCardTypes;
        private static int _nCatds;

        static Program()
        {
            _dict = new Dictionary<string, int>();
            _hits = new Dictionary<string, int>();
            _dict.Add("WarLord", 8);
            _dict.Add("Mage", 3);
            _dict.Add("Dragon", 4);
            _nCardTypes = _dict.Count;
            _nCatds = 0;
            foreach (var cardTypeKey in _dict.Keys)
            {
                _hits.Add(cardTypeKey, 0);
                _nCatds += _dict[cardTypeKey];
            }
        }

        //  The idea is that Value * randomNumber is already weighted
        //  so just remember the key for the most heavily weighted value and the corresponding key
        //  and return that
        public static string GetRandomCard()
        {
            string pick_Key = "";
            int pick_Value = -1;
            foreach (var entry in _dict)
            {
                int pick = _random.Next(_nCardTypes);
                int thisValue = pick * entry.Value;
                if (thisValue > pick_Value)
                {
                    pick_Key = entry.Key;
                    pick_Value = thisValue;
                }
            }
            return pick_Key;
        }

        static void Main(string[] args)
        {
            const int nSamples = 10000000;
            for (int i = 0; i < nSamples; i++)
            {
                var hitKey = GetRandomCard();
                _hits[hitKey]++;
            }
            foreach (var entry in _hits)
            {
                Console.WriteLine($"{entry.Key,-10}: {entry.Value} ({(double)entry.Value * _nCatds / _nCardTypes})");
            }
            Console.ReadKey();
        }
