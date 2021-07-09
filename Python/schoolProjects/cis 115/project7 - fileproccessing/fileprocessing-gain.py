# --------------------------------------------------------------------------------------- #
# Name: Michael Gain                                                                      #
# Date:   10/29/17                                                                        #
# Assignment:  Project 7 - Text File Processing and String Formatting                     #
# Description:  Process solar-production.txt, text file, convert KwH to MwH format ouput. #
# --------------------------------------------------------------------------------------- #
solar = open("solar-production.txt", "r")

for aline in solar:
    values = aline.split()
    MwH = (float(values[1]))/1000
    print('{:>25}'.format(values[0]), "had",  '{:4.2f}'.format(MwH), "MwH of generation.")

solar.close()

print("End of file by Michael Gain")
input()
