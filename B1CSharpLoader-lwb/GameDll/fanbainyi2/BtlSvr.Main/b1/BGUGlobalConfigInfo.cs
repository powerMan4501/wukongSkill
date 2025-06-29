using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGUGlobalConfigInfo
{
	public FUStGlobalConfigType Type { get; set; }

	public int IntValue { get; set; }

	public float FloatValue { get; set; }

	public string StringValue { get; set; }

	public bool BoolValue { get; set; }

	public BGUGlobalConfigInfo()
	{
	}

	public BGUGlobalConfigInfo(FUStGlobalConfigType Type, string Value)
	{
		switch (Type)
		{
		case FUStGlobalConfigType.Int:
		{
			int.TryParse(Value, out var result);
			IntValue = result;
			break;
		}
		case FUStGlobalConfigType.Float:
		{
			StringParseHelper.SafeTryFloatParse(Value, out var Ret);
			FloatValue = Ret;
			break;
		}
		case FUStGlobalConfigType.String:
			StringValue = Value;
			break;
		case FUStGlobalConfigType.EgsyesNo:
			BoolValue = Value == "YES";
			break;
		}
	}
}
