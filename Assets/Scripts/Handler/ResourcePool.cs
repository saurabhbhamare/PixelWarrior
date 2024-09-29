using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ResourcePool<T> where T : class
{
    public List<PooledItem<T>> pooledItems = new List<PooledItem<T>>();
    protected T RetrieveItem()
    {
        if (pooledItems.Count > 0)
        {
            PooledItem<T> item = pooledItems.Find(item => !item.isUsed);
            if (item != null)
            {
                item.isUsed = true;
                return item.Item;
            }
        }
        return InitializeNewPooledItem();
    }
    public T InitializeNewPooledItem()
    {
        PooledItem<T> newItem = new PooledItem<T>();
        newItem.Item = InitializeItem();
        newItem.isUsed = true;
        pooledItems.Add(newItem);
        return newItem.Item;
    }
    protected virtual T InitializeItem()
    {
        throw new NotImplementedException("child has no Initialize Item method");
    }
    public void ReturnItem(T item)
    {
        PooledItem<T> pooledItem = pooledItems.Find(i => i.Item.Equals(item));
        pooledItem.isUsed = false;
    }
    public class PooledItem<T>
    {
        public T Item;
        public bool isUsed;
    }


}
