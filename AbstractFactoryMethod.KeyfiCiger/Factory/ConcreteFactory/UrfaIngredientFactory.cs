﻿using AbstractFactoryMethod.KeyfiCiger.Ingredients.ConcreteIngredients;
using AbstractFactoryMethod.KeyfiCiger.Ingredients.AbstractIngredients;

namespace AbstractFactoryMethod.KeyfiCiger.Factory.ConcreteFactory;

public class UrfaIngredientFactory : LahmacunIngredientFactory
{
    public IDough CreateDough() => new Dough();

    public IMincemeat CreateMincemeat() => new FrozenMincemeat();

    public IPepper CreatePepper() => new GreenPepper();
}