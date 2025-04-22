using System.Collections;

namespace Ucu.Poo.Restaurant;

public class Order
{
    private ArrayList order = new ArrayList();

    public void AddOrder(Dish dish)
    {
        this.order.Add(dish);
    }

    public bool HasOrders()
    {
        return this.order.Count > 0;
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Dish dish in this.order)
        {
            total = total + dish.Price;
        }
        return total;
    }
}