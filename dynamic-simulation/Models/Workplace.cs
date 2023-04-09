using System;namespace dynamic_simulation.Models;class Workplace{    public int LoadedProducts { get; private set; }    public int MaxCapacity { get; }    public Workplace(int maxCapacity)    {        MaxCapacity = maxCapacity;        LoadedProducts = 0;    }    public bool LoadProduct(Product product)    {        if (LoadedProducts < MaxCapacity)        {            LoadedProducts++;            return true;        }        else        {            return false;        }    }    public void ProcessProduct()    {        if (LoadedProducts > 0)        {            LoadedProducts--;        }    }}