namespace UnrealEngine.Runtime;

public struct FMinimalName
{
	public int Index;

	public int Number;

	public FMinimalName(int index, int number)
	{
		Index = index;
		Number = number;
	}

	public static FMinimalName FromName(FName name)
	{
		return new FMinimalName(name.ComparisonIndex, name.Number);
	}

	public FName ToName()
	{
		return new FName(Index, Number);
	}
}
