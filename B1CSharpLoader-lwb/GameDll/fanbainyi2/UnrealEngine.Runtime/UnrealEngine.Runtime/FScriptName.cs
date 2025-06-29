namespace UnrealEngine.Runtime;

public struct FScriptName
{
	public int ComparisonIndex;

	public int DisplayIndex;

	public int Number;

	public FScriptName(int comparisonIndex, int displayIndex, int number)
	{
		ComparisonIndex = comparisonIndex;
		DisplayIndex = displayIndex;
		Number = number;
	}

	public static FScriptName FromName(FName name)
	{
		return new FScriptName(name.ComparisonIndex, name.ComparisonIndex, name.Number);
	}

	public FName ToName()
	{
		return new FName(ComparisonIndex, DisplayIndex, Number);
	}
}
