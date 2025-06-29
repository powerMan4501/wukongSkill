using System.Collections.Generic;
using System.Threading;

namespace System.Diagnostics.Tracing;

internal abstract class TraceLoggingTypeInfo
{
	private readonly string name;

	private readonly EventKeywords keywords;

	private readonly EventLevel level = (EventLevel)(-1);

	private readonly EventOpcode opcode = (EventOpcode)(-1);

	private readonly EventTags tags;

	private readonly Type dataType;

	public string Name => name;

	public EventLevel Level => level;

	public EventOpcode Opcode => opcode;

	public EventKeywords Keywords => keywords;

	public EventTags Tags => tags;

	internal Type DataType => dataType;

	internal TraceLoggingTypeInfo(Type dataType)
	{
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		name = dataType.Name;
		this.dataType = dataType;
	}

	internal TraceLoggingTypeInfo(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
	{
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		if (name == null)
		{
			throw new ArgumentNullException("eventName");
		}
		Statics.CheckName(name);
		this.name = name;
		this.keywords = keywords;
		this.level = level;
		this.opcode = opcode;
		this.tags = tags;
		this.dataType = dataType;
	}

	public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format);

	public abstract void WriteObjectData(TraceLoggingDataCollector collector, object value);

	public virtual object GetData(object value)
	{
		return value;
	}
}
internal abstract class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo
{
	private static TraceLoggingTypeInfo<DataType> instance;

	public static TraceLoggingTypeInfo<DataType> Instance => instance ?? InitInstance();

	protected TraceLoggingTypeInfo()
		: base(typeof(DataType))
	{
	}

	protected TraceLoggingTypeInfo(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
		: base(typeof(DataType), name, level, opcode, keywords, tags)
	{
	}

	public abstract void WriteData(TraceLoggingDataCollector collector, ref DataType value);

	public override void WriteObjectData(TraceLoggingDataCollector collector, object value)
	{
		DataType value2 = ((value == null) ? default(DataType) : ((DataType)value));
		WriteData(collector, ref value2);
	}

	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck)
	{
		if (instance == null)
		{
			int count = recursionCheck.Count;
			TraceLoggingTypeInfo<DataType> value = Statics.CreateDefaultTypeInfo<DataType>(recursionCheck);
			Interlocked.CompareExchange(ref instance, value, null);
			recursionCheck.RemoveRange(count, recursionCheck.Count - count);
		}
		return instance;
	}

	private static TraceLoggingTypeInfo<DataType> InitInstance()
	{
		return GetInstance(new List<Type>());
	}
}
