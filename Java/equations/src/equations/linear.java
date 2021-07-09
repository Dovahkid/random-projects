package equations;

public class linear {

    public static double solveForX(double y, double m, double b){

        return (y - b) / m;
    }

    public static double solveForY(double x, double m, double b){

        return (m * x) + b;
    }

    public static double solveForB(double y, double x, double m){

        return y - (m * x);
    }

    public static double solveForM(double y, double x, double b){

        return (y - b) / x;
    }

}
