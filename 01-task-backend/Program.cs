

double total = 0;
double all_total = 0;
int continue1 = 1;
while (continue1 != 0)
{
    Console.WriteLine("Enter the price: ");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
    total = price * quantity;
    all_total += total;
    Console.WriteLine($"The price is {total}");
    Console.WriteLine("");
    Console.WriteLine("Do you want to add another product? 0->to_finish 1->to_continue ");
    continue1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"the total price is {all_total}");