package notebook;

import java.io.File;
import java.util.Formatter;
import java.util.Scanner;

class creating {

    static void fileGen()
    {
        File newFolder = new File("entries");
        if(!newFolder.exists())
        {
            newFolder.mkdirs();
        }

        System.out.println("What do you want your entry to be called?");
        Scanner entryName = new Scanner(System.in);
        String filePath = ".\\entries\\" + entryName.nextLine() + ".txt";

        File newEntry = new File(filePath);
        if(newEntry.exists())
        {
            System.out.println("File already exists. Do you want to overwrite? (y/n)");
            System.out.println("This will erase all data in the file.");
            String overInput = (new Scanner(System.in)).nextLine();
            switch(overInput)
            {
                case "y":
                    System.out.println("overwriting...");
                    entryCreation(filePath);
                    break;
                case "n":
                    System.out.println("Please choose a different name:");
                    fileGen();
                    break;
                default:
                    System.out.println("Unrecognized entry. Not overwriting");
                    fileGen();
                    break;
            }
        }
        else
        {
            entryCreation(filePath);
        }

    }

    private static void entryCreation(String filePath)
    {
        try
        {
            Formatter newFile = new Formatter(filePath);
            newFile.close();
            System.out.println("File creation successful");
        }
        catch(Exception e)
        {
            System.out.println("File creation failed");
        }
    }

    static void readEntriesToDel()
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
                    deleteEntry();
                }
            }
        }
        catch(Exception e)
        {
            System.out.println("Error retrieving list of entries");
        }
    }

    static void deleteEntry()
    {

        System.out.println("What file do you want to delete?");
        String filePath = ".\\entries\\" + (new Scanner(System.in)).nextLine() + ".txt";
        File toDelete = new File(filePath);
        if(toDelete.delete())
        {
            System.out.println("File deleted");
        }
        else
        {
            System.out.println("File could not be deleted. File may not exist or there was an error.");
        }
    }

}
