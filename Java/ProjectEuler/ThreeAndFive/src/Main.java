/*
*
* Add all multiples of 3 or 5 under 1000
*
*/

/*
*
* Current expansion idea:
*   Make the function support any X amount of numbers that the user inputs
* Curent status:
*   Not working...
* */

import java.util.ArrayList;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) {

        ArrayList<Integer> customValues = new ArrayList<Integer>();

        Scanner input = new Scanner(System.in);

        customValues.add(input.nextInt());
        customValues.add(input.nextInt());

        System.out.println(Logic.customValues(customValues, 1000));

    }

}
