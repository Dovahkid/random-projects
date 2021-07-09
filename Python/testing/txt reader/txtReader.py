fp = open("presidents.txt", "r")
fpo = open("jpresidents.txt", "w")

# priming read
aLine = fp.readline()


while aLine != "":
	if aLine[0] == "J":
		fpo.write(aLine)
	#print(aLine, end="")
	aLine = fp.readline()	

fp.close()
fpo.close()
input()