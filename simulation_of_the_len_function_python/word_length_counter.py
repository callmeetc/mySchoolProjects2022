def wordCount(string):
    count = 0
    for letter in  string:
        #eliminating spaces from the count
        if letter == " ":
            continue
        count += 1
    return count

print("\n\n\t\t\tReturns the number of letters in a word or sentence.")
print('TYPE "end" TO END PROCESS')
while True:
    test = input("\n\nEnter a word: ")
    if test == "end":
        break
    print(wordCount(test))
