﻿namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
