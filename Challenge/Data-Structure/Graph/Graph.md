# Graph 

## Challenge

To implement the Graph and node class. Created instance methods for the Graph class: addNode(), addEdge(), getNodes(), getNeighbors(), size().

## Solution

AddNode()

- Adds a new node to the graph
- Takes in the value of that node
- Returns the added node

AddEdge()

- Adds a new edge between two nodes in the graph
- Include the ability to have a “weight”
- Takes in the two nodes to be connected by the edge
- Both nodes should already be in the Graph


GetNodes()

- Returns all of the nodes in the graph as a collection (set, list, or similar)

GetNeighbors()

- Returns a collection of nodes connected to the given node
- Takes in a given node
- Include the weight of the connection in the returned collection

Size()

- Returns the total number of nodes in the graph

## Approach & Efficiency

| Time Complexity |Space Complexity|
|-----------------|----------------|
| O(n)            | O(n)           |


## Test 

- [x] Node can be successfully added to the graph
- [x] An edge can be successfully added to the graph
- [x] A collection of all nodes can be properly retrieved from the graph
- [x] All appropriate neighbors can be retrieved from the graph
- [x] Neighbors are returned with the weight between nodes included
- [x] The proper size is returned, representing the number of nodes in the graph
- [x] A graph with only one node and edge can be properly returned
- [x] An empty graph properly returns null

## Code Reference

[Code](./Graph/Graph/Graphs.cs) | [Tests](./Graph/GraphTest/UnitTest1.cs)