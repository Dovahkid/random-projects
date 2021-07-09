public class animals {
    private int location; // This can only be accessed from within the object/class

    void speak(String sound) // This defaultly is public
    {
        System.out.println(sound);
    }

    void walk() // This defaultly is public
    {
        this.location++;
        System.out.println("Moves forward 1 unit. New location: " + this.location);

    }
}
