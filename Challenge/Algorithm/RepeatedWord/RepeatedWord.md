# Program to find the duplicate words in a string

## Explanation
In this program, we need to find out the duplicate words present in the string and display those words.
To find the duplicate words from the string, we first split the string into words. We count the occurrence of each word in the string. If count is greater than 1, it implies that a word has duplicate in the string.

## Algorithm

- Define a string.
- Convert the string into lowercase to make the comparison insensitive.
- Split the string into words.
- Two loops will be used to find duplicate words. Outer loop will select a word and Initialize variable count to 1. Inner loop will compare the word selected by outer loop with rest of the words.
- If a match found, then increment the count by 1 and set the duplicates of word to '0' to avoid counting it again.
- After the inner loop, if count of a word is greater than 1 which signifies that the word has duplicates in the string.
- End

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
| Method    | Time Complexity |Space Complexity|
|-----------|-----------------|----------------|
| Repeated       | O(n^2)  | O(1)         |

## Solution

```C#
public static string Repeated(string word)
        {
            word = word.ToLower();
            string[] arrWords = word.Split(' ');
            int count = 0;

            for (int i = 0; i < arrWords.Length; i++)
            {
                for (int j = 0; j < arrWords.Length; j++)
                {
                    if (arrWords[i] == arrWords[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return arrWords[i];
                }
                count = 0;
            }

            return "No repetition";
        }
```

## Unit Tests

Test different in above example.

```C#
[Fact]
        public void Test1()
        {
            string word = "Once upon a time, there was a brave princess who";
            
            Assert.Equal("a", Program.repeated(word));
        }
        [Fact]
        public void Test2()
        {
            string word = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way � in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";

            Assert.Equal("it", Program.repeated(word));
        }

        [Fact]
        public void Test3()
        {
            string word = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn�t know what I was doing in New York";

            Assert.Equal("was", Program.repeated(word));
        }
```

## Code Reference

[Repeated Word](./RepeatedWord/RepeatedWord/Program.cs)

[Test Repeated Word](./RepeatedWord/TestRepatedWord/UnitTest1.cs)