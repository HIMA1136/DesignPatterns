namespace DesignPatternExamples.Creational.Builder;

public sealed class Computer
{
    public required string Cpu { get; init; }
    public required int MemoryGb { get; init; }
    public string? GraphicsCard { get; init; }

    public override string ToString() =>
        $"Computer: {Cpu}, {MemoryGb} GB RAM, GPU: {GraphicsCard ?? "integrated"}";
}

public sealed class ComputerBuilder
{
    private string? _cpu;
    private int _memoryGb;
    private string? _graphicsCard;

    public ComputerBuilder WithCpu(string cpu) { _cpu = cpu; return this; }
    public ComputerBuilder WithMemory(int memoryGb) { _memoryGb = memoryGb; return this; }
    public ComputerBuilder WithGraphicsCard(string graphicsCard) { _graphicsCard = graphicsCard; return this; }

    public Computer Build()
    {
        if (string.IsNullOrWhiteSpace(_cpu)) throw new InvalidOperationException("A CPU must be specified.");
        if (_memoryGb <= 0) throw new InvalidOperationException("Memory must be greater than zero.");

        return new Computer { Cpu = _cpu, MemoryGb = _memoryGb, GraphicsCard = _graphicsCard };
    }
}

public static class BuilderDemo
{
    public static void Run()
    {
        var computer = new ComputerBuilder()
            .WithCpu("8-core CPU")
            .WithMemory(32)
            .WithGraphicsCard("Dedicated GPU")
            .Build();

        Console.WriteLine(computer);
    }
}
