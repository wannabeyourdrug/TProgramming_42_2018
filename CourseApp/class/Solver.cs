using System.Collections.Generic;
using static Calculator;

class Solver {
    public static Dictionary<string, double> solve(double a, double b, double xH, double xK, double dX) {
        Dictionary<string, double> answer = new Dictionary<string, double>();
        for (double x = xH; x <= xK; x += dX) {
            answer.Add(x.ToString(), Calculator.calculateY(x, a, b));
        }
        return answer;
    }
}