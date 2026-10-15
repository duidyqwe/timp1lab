using System;

static class Selection
{
    public static Item[] Apply(Item[] items)
    {
        Item[] result = (Item[])items.Clone();
        Array.Sort(result, (x, y) =>
        {
            int memCompare = y.MemoryMb.CompareTo(x.MemoryMb);
            if (memCompare != 0) return memCompare;
            return StringComparer.Ordinal.Compare(x.Name, y.Name);
        });
        return result;
    }
}