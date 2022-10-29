https://school.programmers.co.kr/learn/courses/30/lessons/120822

using System;

public class Solution {
    public string solution(string my_string) {
        char[] result = my_string.ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}
