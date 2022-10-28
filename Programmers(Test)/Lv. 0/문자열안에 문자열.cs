https://school.programmers.co.kr/learn/courses/30/lessons/120908

using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        if (str1.Contains(str2))
        {
            answer = 1;
        }
        else 
        {
            answer = 2;
        }
        return answer;
    }
}
