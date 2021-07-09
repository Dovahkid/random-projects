package notebook;

import java.util.Scanner;

public class mainClass {

    public static void main(String[] args)
    {
        boolean runProg = true;
        while(runProg) {
            System.out.println("\nWhat do you want to do?");
            System.out.print("1. Create new Entry\n" +
                    "2. Read an entry\n" +
                    "3. Write to an entry\n" +
                    "4. Delete an Entry\n" +
                    "5. Exit program\n"+
                    "--> ");
            String choice = (new Scanner(System.in)).nextLine();

            for(int i = 0; i < 5; i++){System.out.println(" ");}

            switch (choice) {
                case "1":
                    creating.fileGen();
                    break;
                case "2":
                    reading.fileRead();
                    break;
                case "3":
                    System.out.println("Under construction");
                    break;
                case "4":
                    creating.readEntriesToDel();
                    break;
                case "5":
                    runProg = false;
                    break;
                default:
                    System.out.println("Invalid entry. Try again");
                    break;
            }
        }

    }

}
