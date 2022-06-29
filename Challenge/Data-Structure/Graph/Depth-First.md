# Depth First Traversal

## Challenge
Depth first Search or Depth first traversal is a recursive algorithm for searching all the vertices of a graph or tree data structure. Traversal means visiting all the nodes of a graph.

## Approach & Efficiency

Time | Space
--- | ---
O(v) | O(v)

## Solution

![White Board to DFS Graph Problem](./img/DFS.jpg)

## Code


```C#
public List<Node> Depthfirst(Node start)
        {
            List<Node> result = new List<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            Stack stack = new Stack();
            stack.Push(start);
            visited.Add(start);

            while (stack.Count > 0)
            {
                Node tempNode = (Node)stack.Pop();
                result.Add(tempNode);

                foreach(var neighbor in tempNode.neighbors)
                {
                    if (!visited.Contains(neighbor.node))
                    {
                        stack.Push(neighbor.node);
                        visited.Add(neighbor.node);
                    }
                }
            }
            return result;
        }
```

## Tests

```C#
[Fact]
        public void test_dfs()
        {
            Graphs graph = new Graphs();
            Node one = graph.addNode(1);
            Node two = graph.addNode(2);
            Node three = graph.addNode(2);

            one.addNeighbor(two);
            one.addNeighbor(three);

            List<Node> expected = new List<Node>();
            expected.Add(one);
            expected.Add(two);
            expected.Add(three);

            Assert.Equal(expected, graph.BreadthFirst(one));
        }
```

