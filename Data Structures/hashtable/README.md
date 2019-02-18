# Hashtables
a hash table (hash map) is a data structure that implements an associative array abstract data type, a structure that can map keys to values. A hash table uses a hash function to compute an index into an array of buckets or slots, from which the desired value can be found.

## Challenge
add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed. </br>
get: takes in the key and returns the value from the table.
contains: takes in the key and returns a boolean, indicating if the key exists in the table already. </br>
hash: takes in an arbitrary key and returns an index in the collection. </br>

## Approach & Efficiency
Big O </br>
Time: O(n log n)</br>
Space: O(1)</br>
