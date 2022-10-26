using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = array.Count(x => x == n);
        return answer;
    }
}

using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = array.Count(i => i > height);
        return answer;
    }
}
