class Public: # This is the values that would be public, if someone was trying to "listen" to the conversation these are the numbers theyd see outright
	g = 17
	n = 200 #this should be some large number that is 4000 bits

class Person:
	def __init__(self, private_key): # The constructor here represents the private keys for each user
		self.__private_key = private_key
		self.gKey = 0
		self.combinedKey = 0
		
	def genGKey(self): # This would also enter the public area because it has to be traded to the other user. That trade is seen on lines 24 and 25
		self.gKey = pow(Public.g, self.__private_key) % Public.n
		
	def genCombinedKey(self, othersGKey): # The combined keys are never sent because they are calculated by each person.
		self.combinedKey = pow(othersGKey, self.__private_key)%Public.n
		
if __name__ == "__main__":
	alice = Person(40485)
	bob = Person(3)
	
	alice.genGKey()
	bob.genGKey()
	
	alice.genCombinedKey(bob.gKey)
	bob.genCombinedKey(alice.gKey)
	
	print(alice.combinedKey)
	print(bob.combinedKey)

'''
1. Each person has their own private key
2. In the "public" area there are 2 known values g and n
3. g is a prime number and n is a 4000 bit number
4. Each user does this function (g ^ private_key) % n
5. This calculated value is then passed to the other user. This is fine because it is very hard to go backwards in the equation
6. each user then does the function again but instead of g its the value the other user generated. ( ( otherUsersValue ^ private_key ) % n )
7. This value should be the same for each person even though they never directly saw each others private keys.
8. This key can now be used to encrypt and decrypt messages
9. If you want extra security generate a new private key for each message sent and regenerate the shared key
'''
