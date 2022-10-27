https://school.programmers.co.kr/learn/courses/30/lessons/120809

using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        answer = numbers.Select(i => i * 2).ToArray();
        return answer;
    }
}
