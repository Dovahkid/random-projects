package vehicles;

public class car {
    public static String color = "blue";

    public String carModel(String m)
    {
        String model = m + "abc";
        System.out.println(model);
        return model;
    }

    public int carModel(int m)
    /* This is overloading. I added a second version of the method that takes in int instead of String. When the method
     is called it will automatically choose the best one. */
    {
        int model = m + 100;
        System.out.println(model);
        return model;
    }

}
