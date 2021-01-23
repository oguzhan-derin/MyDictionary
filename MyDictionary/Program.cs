using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Ankara", 6);
            myDictionary.Add("İzmir", 35);
            myDictionary.Add("Elazığ", 23);
            myDictionary.Add("İstanbul", 34);

            foreach (var dictionary in myDictionary.Keys)
            {
                Console.WriteLine("Şehir : "+ dictionary);
            }
            Console.WriteLine(" -----------------------------  ");
            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine("Plaka : "+item);
            }
        }
    }
    class MyDictionary<K,V>
    {
        K[] key;
        V[] value;
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }
        public void Add(K keys,V values)
        {
            K[] _tempKeys = key;
            V[] _tepmValues = value;
            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                key[i] = _tempKeys[i];
                value[i] = _tepmValues[i];
            }
            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;
        }
        public K[] Keys
        {
            get { return key; }
        }
        public V[] Values
        {
            get { return value; }
        }
    }
}

