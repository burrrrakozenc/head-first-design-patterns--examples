﻿using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;

public class GreenPepper : IPepper
{
    public string ConvertToString()
    {
        return "Aci sevmeyenler ya da basuru olanlar guzel insanlarimiz icin acisiz yesil biber!";
    }
}