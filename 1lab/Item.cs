class Item
{
    public string Name { get; set; }
    public int MemoryMb { get; set; }

    public Item(string name, int memoryMb)
    {
        Name = name;
        MemoryMb = memoryMb;
    }
}