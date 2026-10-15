static class Summary
{
    public static string Build(Item[] items)
    {
        int sum = 0;
        foreach (Item item in items)
        {
            sum += item.MemoryMb;
        }
        return "SumMb: " + sum;
    }
}