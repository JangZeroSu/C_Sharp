https://school.programmers.co.kr/learn/courses/30/lessons/120813

using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int[] solution(int n) {
        List<int> testList = new List<int>();
        for (int i = 0; i < n+1; i++)
        {
            if(i % 2 != 0)
            {
                testList.Add(i);
            }            
        }         
        int[] answer = testList.ToArray();
        return answer ;
    }
}
