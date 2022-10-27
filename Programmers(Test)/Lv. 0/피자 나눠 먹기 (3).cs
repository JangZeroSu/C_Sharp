https://school.programmers.co.kr/learn/courses/30/lessons/120816

using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;        
        return (n-1)/slice + 1;
    }
}
