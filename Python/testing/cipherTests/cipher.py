alph = "abcdefghijklmnopqrstuvwxyz "
cipher = "tuvwxyzabcdefghijklmnopqrs "
out = ""
i = 0
msg = input("Enter the plain text or cipher: ")
ch = int(input("1. Encode \n""0. Decode \n""--> "))
if ch == 1:
	while (len(msg) - 1) >= i:
		for x in range(len(alph)):
			if msg[0 + i] == alph[x - 1]:
				out += cipher[x - 1]
		i += 1
else:
	while (len(msg) - 1) >= i:
		for x in range(len(alph)):
			if msg[0 + i] == cipher[x - 1]:
				out += alph[x - 1]
		i += 1
print(out)
file = open("msg.txt", "w")
file.write(out)
file.close()
input()
