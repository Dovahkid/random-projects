package calculator;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        boolean run = true;
        while(run)
        {
            System.out.println("How many hours have you played games? (Decimals accepted)");
            double hoursInGame = Double.parseDouble(new Scanner(System.in).nextLine());

            System.out.println("How old are you in years? (Decimals accepted)");
            double userAge = Double.parseDouble(new Scanner(System.in).nextLine());

            System.out.println("How many years have you had your account? (Decimals accepted)");
            double yearsOfAccount = Double.parseDouble(new Scanner(System.in).nextLine());

            System.out.printf("\n\n%s %.2f%s\n", "You have spent about", hourMath.percentLife(hoursInGame, userAge),
                    "% of your life playing video games.");
            System.out.printf("%s %.2f%s\n", "You have spent about", hourMath.percentYears(hoursInGame, yearsOfAccount),
                    "% of your account lifespan playing video games.");
            System.out.printf("%s %.2f%s\n", "You have spent about", hourMath.percentOfYear(hoursInGame),
                    "% of a year playing video games.");

            System.out.println("\n\nWould you like to exit? (y/n)");
            String exit = (new Scanner(System.in)).nextLine();
            switch(exit){
                case "y":
                    run = false;
                    break;

                case "n":
                    System.out.print("\n\n\n");
                    break;

                default:
                    System.out.println("\n\n");
                    break;
            }
        }

    }

}
