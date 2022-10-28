https://school.programmers.co.kr/learn/courses/30/lessons/120909

using System;

public class Solution {
    public int solution(int n) {
    
        int answer = 0;
        
        double result = (Math.Sqrt(n));
        
        if (Math.Truncate(result) == result)
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

////
answer = Math.Truncate(result) == result ? 1:2;
