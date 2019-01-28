# Trees

## Challenge
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
Create a BinaryTree class
Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.

Create a BinarySearchTree class
Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency
The Big O of a Binary Search Tree for insertion and search is O(log n).

This means that we are always able to reduce the number of searches we do of a logarithmic value each time because of how the tree is structured. Each traversal we do in a Binary Search Tree helps us eliminate the branches of the opposite direction we traverse.

The Big O space of a Binary Search Tree (BST) search would be O(1). During the search, we are not allocating any additional space when searching for a node.
