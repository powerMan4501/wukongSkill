namespace UnrealEngine.Runtime;

public struct TStatIdData
{
	public FMinimalName Name;

	public ulong AnsiString;

	public ulong WideString;

	public bool IsNone
	{
		get
		{
			if (Name.Index == 0)
			{
				return Name.Number == 0;
			}
			return false;
		}
	}
}
