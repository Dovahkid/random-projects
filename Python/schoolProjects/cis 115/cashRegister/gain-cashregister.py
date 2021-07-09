item_text = "test"
item_price = 0.0
quantity = 0


def ask_input():
    global item_text, item_price, quantity
    item_text = input("Enter the description of the item: ")
    price_text = input("Enter the item price in dollars and cents: ")
    item_price = float( price_text )
    quantity_text = input("Enter the quantity: ")
    quantity = int( quantity_text )


def main():
    ask_input()
    print("Order Receipt")
    print("Item: ", item_text)
    print("Quantity: ", quantity)
    print("Price: ${:3.2f}".format(item_price))
    merchandise_total = item_price * quantity
    sales_tax = (merchandise_total * 0.075)
    total_price = sales_tax + merchandise_total
    print("Merchandise Total: ${:3.2f}".format(merchandise_total))
    print("The sales tax is ${:3.2f}".format(sales_tax))
    print("The total price is ${:3.2f}".format(total_price))

main()

input()
