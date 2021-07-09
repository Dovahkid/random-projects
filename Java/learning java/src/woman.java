public class woman {
    static final boolean isAnnoyed = true; /* The static keyword makes this boolean true for all woman objects.
                                              The final keyword makes this boolean a constant. unchangeable */

    private String name;
    private int age;

    public woman() //  This is a constructor
    {
        System.out.println("New Woman");
        name = "human woman"; // this gets auto assigned when a new object is created
        age = 20;
    }
    public woman(int initAge) // this is also a constructor
    {
        System.out.println("New Woman");
        this.setAge(initAge); // this one allows you to set the age on construction.
    }                         // but because of the first constructor it is optional to set an age
                              /* If you do set an age on construction the first constructor
                                 is not run so the name does not get assigned a value */

    public String getName() // getter for name
    {
        return name;
    }
    public void setName(String newName) // setter for name
    {
        this.name = newName;
    }

    public int getAge() // getter for age
    {
        return age;
    }
    public void setAge(int newAge) // setter for age
    {
        this.age = newAge;
    }

    static public void celebrateBirthday(woman w) // This takes a "woman" object instance and increments its age by 1
    {                                             // Methods can accept object types
        w.setAge(w.getAge() + 1);
    }
}
