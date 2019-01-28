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

## API

PreOrder() - Recursively stores the node values of the tree BEFORE traversing to the next and returns them as an array.
InOrder() - Stores the node values of the tree, starting at the left most leaf and recursively adding back upward, then adding as it goes down the right side, and returns them as an array.
PostOrder - Stores the node values of the tree, returning the left side of the tree from the bottom up, then the right side from the bottom up, then finally the top root, then returns them as an array.

Binary Search Tree:

Add(Node root, int value) - Traverses the nodes of the binary search tree that are directly greater than of less than the given value. When it reaches a leaf, it creates a new node in the position greater than or less than that leaf.
Contains(int value) - Searches the tree for a matching node value, traversing left if the target value is less than the node value, or right if the target value is greater than the node value. Returns true is target is found, false if not.
