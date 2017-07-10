public abstract class Food
{
    private string foodType;
    private int quantity;

    protected Food(int quantity)
    {
        this.Quantity = quantity;
    }

    public string FoodType
    {
        get { return this.foodType; }
        set { this.foodType = value; }
    }

    

    public int Quantity
    {
        get { return this.quantity; }
        set { this.quantity = value; }
    }


}

