namespace UnrealEngine.Runtime;

public struct FSetElementId
{
	public int Index;

	public bool IsValidId => Index != -1;

	public static FSetElementId Default => new FSetElementId(-1);

	public FSetElementId(int index)
	{
		Index = index;
	}

	public int AsInteger()
	{
		return Index;
	}

	public static FSetElementId FromInteger(int integer)
	{
		return new FSetElementId(integer);
	}
}
