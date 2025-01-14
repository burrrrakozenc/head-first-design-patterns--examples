﻿using System.Collections;
using Iterator.MenuMerge.Aggregates.Common;

namespace Iterator.MenuMerge.Iterator.ConcreteIterator;

public class PancakeHouseMenuIterator : Iterator
{
    private ArrayList items;
    private int position = 0;

    public PancakeHouseMenuIterator(ArrayList items)
    {
        this.items = items;
    }

    public object Next()
    {
        MenuItem menuItem = (MenuItem)items[position]!;
        position++;
        
        return menuItem;
    }
    
    public bool HasNext()
    {
        if (position >= items.Count || items[position] == null)
            return false;
        
        return true;
    }
    
    
}