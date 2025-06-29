namespace System.Diagnostics.Tracing;

[__DynamicallyInvokable]
public struct EventSourceOptions
{
	internal EventKeywords keywords;

	internal EventTags tags;

	internal EventActivityOptions activityOptions;

	internal byte level;

	internal byte opcode;

	internal byte valuesSet;

	internal const byte keywordsSet = 1;

	internal const byte tagsSet = 2;

	internal const byte levelSet = 4;

	internal const byte opcodeSet = 8;

	internal const byte activityOptionsSet = 16;

	[__DynamicallyInvokable]
	public EventLevel Level
	{
		[__DynamicallyInvokable]
		get
		{
			return (EventLevel)level;
		}
		[__DynamicallyInvokable]
		set
		{
			level = checked((byte)value);
			valuesSet |= 4;
		}
	}

	[__DynamicallyInvokable]
	public EventOpcode Opcode
	{
		[__DynamicallyInvokable]
		get
		{
			return (EventOpcode)opcode;
		}
		[__DynamicallyInvokable]
		set
		{
			opcode = checked((byte)value);
			valuesSet |= 8;
		}
	}

	internal bool IsOpcodeSet => (valuesSet & 8) != 0;

	[__DynamicallyInvokable]
	public EventKeywords Keywords
	{
		[__DynamicallyInvokable]
		get
		{
			return keywords;
		}
		[__DynamicallyInvokable]
		set
		{
			keywords = value;
			valuesSet |= 1;
		}
	}

	[__DynamicallyInvokable]
	public EventTags Tags
	{
		[__DynamicallyInvokable]
		get
		{
			return tags;
		}
		[__DynamicallyInvokable]
		set
		{
			tags = value;
			valuesSet |= 2;
		}
	}

	[__DynamicallyInvokable]
	public EventActivityOptions ActivityOptions
	{
		[__DynamicallyInvokable]
		get
		{
			return activityOptions;
		}
		[__DynamicallyInvokable]
		set
		{
			activityOptions = value;
			valuesSet |= 16;
		}
	}
}
