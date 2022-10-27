https://school.programmers.co.kr/learn/courses/30/lessons/120817

using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer;
        double avg = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            avg += numbers[i];
        }
        
        answer = avg / numbers.Length;
        
        return answer;
    }
}
