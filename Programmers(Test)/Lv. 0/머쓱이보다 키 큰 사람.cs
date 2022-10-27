https://school.programmers.co.kr/learn/courses/30/lessons/120585

using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = array.Count(i => i > height);
        return answer;
    }
}
