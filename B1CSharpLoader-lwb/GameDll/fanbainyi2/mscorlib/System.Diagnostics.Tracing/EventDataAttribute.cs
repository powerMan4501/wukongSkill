namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
[__DynamicallyInvokable]
public class EventDataAttribute : Attribute
{
	private EventLevel level = (EventLevel)(-1);

	private EventOpcode opcode = (EventOpcode)(-1);

	[__DynamicallyInvokable]
	public string Name
	{
		[__DynamicallyInvokable]
		get;
		[__DynamicallyInvokable]
		set;
	}

	internal EventLevel Level
	{
		get
		{
			return level;
		}
		set
		{
			level = value;
		}
	}

	internal EventOpcode Opcode
	{
		get
		{
			return opcode;
		}
		set
		{
			opcode = value;
		}
	}

	internal EventKeywords Keywords { get; set; }

	internal EventTags Tags { get; set; }

	[__DynamicallyInvokable]
	public EventDataAttribute()
	{
	}
}
