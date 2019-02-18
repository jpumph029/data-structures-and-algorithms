using System;
using System.Collections.Generic;
using System.Text;
using hashtable.Classes;

namespace hashtable.Classes
{
    public class Hashtable<K, V>
    {

        private readonly int size;
        private readonly LinkedList<Node<K, V>>[] items;

        /// <summary>
        /// Creates a fixed sized hashtable
        /// </summary>
        /// <param name="size"></param>
        public Hashtable(int size)
        {
            this.size = size;
            items = new LinkedList<Node<K, V>>[size];
        }

        /// <summary>
        ///  takes in an arbitrary key and returns an index in the collection.
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>an index in the collection.</returns>
        protected int Hash(K Key)
        {
            int position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }

        /// <summary>
        /// takes in both the key and value. Adds the key and value pair to the table.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(K key, V value)
        {
            int position = Hash(key);
            LinkedList<Node<K, V>> bucket = GetBucket(position);
            Node<K, V> item = new Node<K, V>() { Key = key, Value = value };
            bucket.AddLast(item);

        }

        /// <summary>
        /// Gets a bucket in hashtable if one exisits or creates one if it does not exist
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        protected LinkedList<Node<K, V>> GetBucket(int position)
        {
            LinkedList<Node<K, V>> bucket = items[position];
            if (bucket == null)
            {
                bucket = new LinkedList<Node<K, V>>();
                items[position] = bucket;
            }
            return bucket;
        }
        /// <summary>
        /// get: takes in the key and returns the value from the table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>value from table</returns>
        public V Get(K key)
        {
            int position = Hash(key);
            LinkedList<Node<K, V>> bucket = GetBucket(position);
            foreach (Node<K, V> item in bucket)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        /// <summary>
        /// : takes in the key and returns a boolean indicating if they key exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns>boolean</returns>
        public bool Contains(K key)
        {
            int position = Hash(key);
            LinkedList<Node<K, V>> bucket = GetBucket(position);

            foreach (Node<K, V> item in bucket)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
