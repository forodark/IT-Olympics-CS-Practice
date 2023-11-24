using System;
using System.Collections.Generic;

class Trie
{
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    public void Insert(string word) {
        TrieNode node = root;

        foreach (char c in word) {
            if (!node.Children.ContainsKey(c)) {
                node.Children[c] = new TrieNode();
            }

            node = node.Children[c];
        }

        node.IsEndOfWord = true;
    }

    public bool Search(string word) {
        TrieNode node = SearchNode(word);
        return node != null && node.IsEndOfWord;
    }

    public bool StartsWith(string prefix) {
        return SearchNode(prefix) != null;
    }

    private TrieNode SearchNode(string str) {
        TrieNode node = root;

        foreach (char c in str) {
            if (node.Children.ContainsKey(c)) {
                node = node.Children[c];
            }
            else {
                return null;
            }
        }

        return node;
    }
}

class TrieNode {
    public Dictionary<char, TrieNode> Children { get; set; }
    public bool IsEndOfWord { get; set; }

    public TrieNode() {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}

class Average2 {
    static void Main() {
        Trie trie = new Trie();

        trie.Insert("apple");
        Console.WriteLine(trie.Search("apple"));
        Console.WriteLine(trie.Search("app"));
        Console.WriteLine(trie.StartsWith("app"));
    }
}