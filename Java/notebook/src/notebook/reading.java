package notebook;

import java.io.File;
import java.util.Scanner;

class reading {

    static void fileRead()
    {
        try{
            File allEntries = new File("entries");
            File[] listOfAllFiles = allEntries.listFiles();

            System.out.println("All File names:");
            if(listOfAllFiles.length == 0)
            {
                System.out.println("  No Entries exist");
            }
            else
            {
                for (File i: listOfAllFiles)
                {
                    System.out.println("  " + i.getName().replace(".txt",""));
                }
                callFile();
            }
        }
        catch(Exception e)
        {
            System.out.println("Error retrieving list of entries");
        }

    }

    private static void callFile()
    {

        System.out.println("What entry do you want to open?");
        Scanner entryName = new Scanner(System.in);
        String filePath = ".\\entries\\" + entryName.nextLine() + ".txt";

        File newEntry = new File(filePath);
        if(newEntry.exists())
        {
            try
            {
                File x = new File(filePath);
                Scanner readingFile = new Scanner(x);
                while(readingFile.hasNext())
                {
                    System.out.println(readingFile.next());
                }
                readingFile.close();
            }
            catch(Exception e)
            {
                System.out.println("ERROR: File reading failed");
            }

        }
        else
        {
            System.out.println("File reading failed. File does not exist.");
        }

    }

}
