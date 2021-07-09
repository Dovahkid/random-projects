import java.io.File;
import java.util.Formatter;
import java.util.Scanner;

public class filez {

    public static void fileCheck() {
        File x = new File(".\\test.txt");
        if(x.exists()) {
            System.out.println("File exists\n" +
                    "Now reading file");
            fileRead();
        }
        else
        {
            System.out.println("File does not exist\n" +
                    "Creating now...");
            fileGen();
        }
    }

    private static void fileRead()
    {
        try
        {
            File x = new File(".\\test.txt");
            Scanner sc = new Scanner(x);

            while(sc.hasNext())
            {
                System.out.println(sc.next());
            }
            sc.close();
        }
        catch(Exception e)
        {
            System.out.println("File reading failed");
        }
    }

    private static void fileGen()
    {
        try
        {
            Formatter f = new Formatter(".\\test.txt");
            f.format("%s\n%s\n%s", "1", "2", "3");
            f.close();
        }
        catch(Exception e)
        {
            System.out.println("File creation failed");
        }
    }

    public static void fileDel()
    {
        File x = new File(".\\test.txt");
        if(x.delete()) {
            System.out.println("Successfully deleted file");
        }
        else
        {
            System.out.println("File could not be deleted");

        }
    }
}
