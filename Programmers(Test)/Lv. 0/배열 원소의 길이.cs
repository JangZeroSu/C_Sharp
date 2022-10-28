https://school.programmers.co.kr/learn/courses/30/lessons/120854

using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] result = new int[strlist.Length];
        for (int i = 0; i < strlist.Length; i++)
        {
            result[i] = strlist[i].Length;     
        }
        return result;
    }
}





