largest = None
smallest = None
store = []
while True:
    num = input("Enter a number: ")
    if num == "done":
        break
    try:
        fnum = float(num)
    except:
        print("Invalid input")
        continue

    store.append(fnum)
print(store)
for item in store:
    if largest is None:
        largest = item
    elif item > largest:
        largest = item

for item in store:
    if smallest is None:
        smallest = item
    elif item < smallest:
        smallest = item

print("Maximum", largest)
print("Minimum", smallest)
