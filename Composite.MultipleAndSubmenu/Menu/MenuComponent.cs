﻿namespace Composite.MultipleAndSubmenu.Menu;

public abstract class MenuComponent
{
    public abstract void Add(MenuComponent menuComponent);

    public abstract void Remove(MenuComponent menuComponent);

    public abstract MenuComponent GetChild(int i);

    public abstract string GetName();

    public abstract string GetDescription();

    public abstract double GetPrice();

    public abstract bool IsVegetarian();

    public abstract void Print();

    public abstract IEnumerator<MenuComponent> CreateIterator();
}