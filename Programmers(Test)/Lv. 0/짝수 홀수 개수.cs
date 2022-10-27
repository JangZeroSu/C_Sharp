https://school.programmers.co.kr/learn/courses/30/lessons/120824

using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        
        answer[0] = num_list.Count(i => i % 2 == 0);
        answer[1] = num_list.Count(i => i % 2 != 0);
        
        return answer;
    }
    
