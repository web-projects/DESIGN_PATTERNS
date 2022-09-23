namespace HotDrinkMachine.Interfaces
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
