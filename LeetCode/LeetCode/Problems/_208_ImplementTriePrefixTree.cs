using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _208_ImplementTriePrefixTree
    {
        public class Trie
        {
            public bool IsEnd { get; set; }
            public Trie[] Next { get; set; }

            /** Initialize your data structure here. */
            public Trie()
            {
                IsEnd = false;
                Next = new Trie[26];
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                Trie node = this;
                foreach (char c in word)
                {
                    if (node.Next[c - 'a'] == null)
                    {
                        node.Next[c - 'a'] = new Trie();
                    }
                    node = node.Next[c - 'a'];
                }
                node.IsEnd = true;
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                Trie node = this;
                foreach (char c in word)
                {
                    node = node.Next[c - 'a'];
                    if (node == null)
                    {
                        return false;
                    }
                }
                return node.IsEnd;
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                Trie node = this;
                foreach (char c in prefix)
                {
                    node = node.Next[c - 'a'];
                    if (node == null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
