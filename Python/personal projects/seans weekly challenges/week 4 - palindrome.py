def check_palindrome(word):
    return (word[::-1].lower() == word.lower())

if __name__ == "__main__":
    print("Is Palindrome?:")
    print("Racecar: ", check_palindrome("racecar"))
    print("palindrome: ", check_palindrome("palindrome"))