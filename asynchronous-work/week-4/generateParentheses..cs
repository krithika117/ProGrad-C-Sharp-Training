using System;
using System.Collections.Generic;

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        GenerateParenthesisRecursive("", n, n, result);
        return result;
    }
    
    private void GenerateParenthesisRecursive(string current, int left, int right, IList<string> result) {
        if (left == 0 && right == 0) {
            result.Add(current);
            return;
        }
        
        if (left > 0) {
            GenerateParenthesisRecursive(current + "(", left - 1, right, result);
        }
        
        if (right > left) {
            GenerateParenthesisRecursive(current + ")", left, right - 1, result);
        }
    }
}

public class Program {
    public static void Main() {
        Solution solution = new Solution();
        int n = 3;
        IList<string> result = solution.GenerateParenthesis(n);
        Console.WriteLine("All combinations of well-formed parentheses for n = " + n + ": ");
        foreach (string s in result) {
            Console.WriteLine(s);
        }
    }
}
