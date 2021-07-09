import java.util.Scanner;

import java.util.ArrayList; // Array list is an array that is dynamically sized

//import vehicles.plane; // Here I imported the plane from the vehicles package
import vehicles.*; // This imports all files in the vehicles package

public class helloworld {
    public static void main(String[] args){
        /* *Javadoc?*/
        Scanner myName = new Scanner(System.in);
        System.out.println("Hello " + myName.nextLine());

        System.out.println(" ");

        animals dog = new animals();
        dog.speak("bark");
        dog.walk();
        dog.walk();

        System.out.println(" ");

        animals cat = new animals();
        cat.speak("meow");
        cat.walk();
        cat.walk();

        System.out.println(" ");

        woman hum1 = new woman(18);
        System.out.println(hum1.getName()); // Because the constructor was manually used a name does not get assigned
        System.out.println(hum1.getAge());
        woman.celebrateBirthday(hum1);
        System.out.println(hum1.getAge());

        System.out.println(" ");

        woman hum2 = new woman();
        System.out.println(hum2.getName());
        System.out.println(hum2.getAge());
        woman.celebrateBirthday(hum2);
        System.out.println(hum2.getAge());

        System.out.println(" ");

        //System.out.println(plane.test);
        /* If the above line was not commented it would cause an error because it is trying to access a
        protected variable from the plane class. Protected variables can only be accessed within the same package. */

        System.out.println(car.color); /* The car class is not inside the same package as this file (helloworld.java)
                                          but because it is set to public it can be accessed any way*/

        System.out.println(" ");

        car kia = new car();
        car honda = new car();

        kia.carModel("z"); // These 2 are method overloading in action. Part 1
        honda.carModel(26); // Part 2

        System.out.println(" ");

        int[] intArr = new int[10]; // This is an array with 10 blank values
        for(int i = 0; i < intArr.length; i++) // this loop adds a value to of the blank indexes
        {
            intArr[i] = i * 2;
            System.out.print(intArr[i] + " ");
        }

        System.out.println(" ");

        int[] intArr2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}; // This array is also size 10 but initialized with values
        for(int i: intArr2)
        {
            System.out.print(intArr2[i] + " ");
        }

        System.out.println(" \n");

        plane[] planeArr = new plane[2]; // this is an array of plane objects.
        for(int i = 0; i < planeArr.length; i++) // This loop creates an instance of the
                                                 // plane class for each index of the array
        {
            planeArr[i] = new plane();
        }
        planeArr[0].name = "Plane A";
        planeArr[1].name = "Plane B";

        System.out.println(planeArr[0].name);
        System.out.println(planeArr[1].name);
        planeArr[0].fly();

        System.out.println(" ");

        ArrayList<woman> womanList = new ArrayList<>(); // Created an ArrayList of woman objects
                                                        // but I have no idea how to work with them
        for(int i = 0; i < 10; i++)
        {
            womanList.add(new woman());
        }

        ArrayList<Integer> intList = new ArrayList<>();
        intList.add(0);
        intList.add(1);
        intList.add(2);
        System.out.println(intList);
        intList.remove(1);
        System.out.println(intList);
        System.out.println(intList.get(1));
        intList.clear();
        System.out.println(intList);

        System.out.println("");

        filez.fileCheck();

        System.out.println("Do you want to delete the file?(y/n)");
        Scanner deleteFileQ = new Scanner(System.in);
        switch(deleteFileQ.nextLine())
        {
            case("y"):
                System.out.println("Deleting file");
                filez.fileDel();
                break;
            case("n"):
                System.out.println("Not deleting");
                break;
            default:
                System.out.println("Unrecognized entry. Not deleting file");
        }

    }
}
