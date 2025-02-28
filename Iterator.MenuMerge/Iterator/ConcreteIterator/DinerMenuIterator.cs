﻿using Iterator.MenuMerge.Aggregates.Common;

namespace Iterator.MenuMerge.Iterator.ConcreteIterator;

public class DinerMenuIterator : Iterator
{
    private MenuItem[] items;
    private int position = 0;

    public DinerMenuIterator(MenuItem[] items)
    {
        this.items = items;
    }
    
    public object Next()
    {
        MenuItem menuItem = items[position];
        position++;
        
        return menuItem;
    }
    
    public bool HasNext()
    {
        if (position >= items.Length || items[position] == null)
            return false;
        
        return true;
    }
}