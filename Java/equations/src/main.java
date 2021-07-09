import equations.linear;

public class main {

    public static void main(String[] args){


        /*These are tests*/
        double x = -0.413;
        double y = -5.33;
        double m = 2.009;
        double b = -4.5;

        System.out.println(linear.solveForX(y, m, b));
        System.out.println(linear.solveForY(x, m, b));
        System.out.println(linear.solveForM(y, x, b));
        System.out.println(linear.solveForB(y, x, m));

    }

}
