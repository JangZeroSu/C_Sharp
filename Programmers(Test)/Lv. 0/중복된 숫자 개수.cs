https://school.programmers.co.kr/learn/courses/30/lessons/120583

using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;        
        for(int i=0; i < array.Length; i++)
        {
            if(array[i] == n)
            {
                answer += 1;
            }
        }
        
        return answer;
    }
}
