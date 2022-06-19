public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            List<string> joinTable = new List<string>();

            for (int i = 0; i < left.Table.Length; i++)
            {
                if (left.Table[i] != null)
                {
                    Node currentNode = left.Table[i];

                    while (currentNode != null)
                    {
                        string concat = null;
                        concat = concat + $"{currentNode.Key}, {currentNode.Value}, ";
                        if (right.Contains(currentNode.Key))
                        {
                            concat = concat + right.Get(currentNode.Key);
                        }
                        else
                        {
                            concat += "NULL";
                        }
                        joinTable.Add(concat);
                        currentNode = currentNode.Next;
                    }
                }
            }

            return joinTable;
        }