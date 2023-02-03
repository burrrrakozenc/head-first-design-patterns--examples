﻿using AbstractFactoryMethod.KeyfiCiger.Ingredients.IngredientAbstractions;

namespace AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;

public class Isot : IPepper
{
    public string ConvertToString()
    {
        return "Insanlar ikiye ayrilir. Basuru olanlar ve aci sevenler! Aci seven kardeslerimiz icin isot ekleyelim.";
    }
}