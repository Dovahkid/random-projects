# --------------------------------------------------------------------------------------- #
# Name: Samantha Dorton                                                                   #
# Date:   11/3/17                                                                         #
# Assignment:  Project 7 - Text File Processing and String Formatting                     #
# Description:  Process solar-production.txt, text file, convert KwH to MwH format ouput. #
# --------------------------------------------------------------------------------------- #
solar = open("solar-production.txt", "r")

for aline in solar:
    values = aline.split()
	KwH = float(values[1])
    MwH = KwH/1000
    print('{:>25}'.format(values[0]), "had",  '{:4.2f}'.format(MwH), "MwH of generation.")

solar.close()

print("End of file by Samantha Dorton")
input()
