using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4_Odev5
{
    class MyDictionary<K,V>
    {
        K[] key;
        V[] value;
        K[] tempArrayKey;
        V[] tempArrayValue;
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K formaNo, V isim)
        {
            tempArrayKey = key;
            tempArrayValue = value;
            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                key[i] = tempArrayKey[i];
                value[i] = tempArrayValue[i];
            }
            key[key.Length - 1] = formaNo;
            value[value.Length - 1] = isim;
        }
        public K[] KeyItems
        {
            get { return key; }
        }
        public V[] ValueItems
        {
            get { return value; }
        }
             

        public int ValueLength
        {
            get { return value.Length; }
        }
    }
}
