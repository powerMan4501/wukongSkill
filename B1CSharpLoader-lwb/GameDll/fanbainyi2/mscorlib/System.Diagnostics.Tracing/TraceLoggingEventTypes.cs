using System.Collections.Generic;
using System.Reflection;

namespace System.Diagnostics.Tracing;

internal class TraceLoggingEventTypes
{
	internal readonly TraceLoggingTypeInfo[] typeInfos;

	internal readonly string name;

	internal readonly EventTags tags;

	internal readonly byte level;

	internal readonly byte opcode;

	internal readonly EventKeywords keywords;

	internal readonly byte[] typeMetadata;

	internal readonly int scratchSize;

	internal readonly int dataCount;

	internal readonly int pinCount;

	private ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos;

	internal string Name => name;

	internal EventLevel Level => (EventLevel)level;

	internal EventOpcode Opcode => (EventOpcode)opcode;

	internal EventKeywords Keywords => keywords;

	internal EventTags Tags => tags;

	internal TraceLoggingEventTypes(string name, EventTags tags, params Type[] types)
		: this(tags, name, MakeArray(types))
	{
	}

	internal TraceLoggingEventTypes(string name, EventTags tags, params TraceLoggingTypeInfo[] typeInfos)
		: this(tags, name, MakeArray(typeInfos))
	{
	}

	internal TraceLoggingEventTypes(string name, EventTags tags, ParameterInfo[] paramInfos)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		typeInfos = MakeArray(paramInfos);
		this.name = name;
		this.tags = tags;
		level = 5;
		TraceLoggingMetadataCollector traceLoggingMetadataCollector = new TraceLoggingMetadataCollector();
		for (int i = 0; i < typeInfos.Length; i++)
		{
			TraceLoggingTypeInfo traceLoggingTypeInfo = typeInfos[i];
			level = Statics.Combine((int)traceLoggingTypeInfo.Level, level);
			opcode = Statics.Combine((int)traceLoggingTypeInfo.Opcode, opcode);
			keywords |= traceLoggingTypeInfo.Keywords;
			string fieldName = paramInfos[i].Name;
			if (Statics.ShouldOverrideFieldName(fieldName))
			{
				fieldName = traceLoggingTypeInfo.Name;
			}
			traceLoggingTypeInfo.WriteMetadata(traceLoggingMetadataCollector, fieldName, EventFieldFormat.Default);
		}
		typeMetadata = traceLoggingMetadataCollector.GetMetadata();
		scratchSize = traceLoggingMetadataCollector.ScratchSize;
		dataCount = traceLoggingMetadataCollector.DataCount;
		pinCount = traceLoggingMetadataCollector.PinCount;
	}

	private TraceLoggingEventTypes(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		this.typeInfos = typeInfos;
		name = defaultName;
		this.tags = tags;
		level = 5;
		TraceLoggingMetadataCollector traceLoggingMetadataCollector = new TraceLoggingMetadataCollector();
		foreach (TraceLoggingTypeInfo traceLoggingTypeInfo in typeInfos)
		{
			level = Statics.Combine((int)traceLoggingTypeInfo.Level, level);
			opcode = Statics.Combine((int)traceLoggingTypeInfo.Opcode, opcode);
			keywords |= traceLoggingTypeInfo.Keywords;
			traceLoggingTypeInfo.WriteMetadata(traceLoggingMetadataCollector, null, EventFieldFormat.Default);
		}
		typeMetadata = traceLoggingMetadataCollector.GetMetadata();
		scratchSize = traceLoggingMetadataCollector.ScratchSize;
		dataCount = traceLoggingMetadataCollector.DataCount;
		pinCount = traceLoggingMetadataCollector.PinCount;
	}

	internal NameInfo GetNameInfo(string name, EventTags tags)
	{
		NameInfo nameInfo = nameInfos.TryGet(new KeyValuePair<string, EventTags>(name, tags));
		if (nameInfo == null)
		{
			nameInfo = nameInfos.GetOrAdd(new NameInfo(name, tags, typeMetadata.Length));
		}
		return nameInfo;
	}

	private TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos)
	{
		if (paramInfos == null)
		{
			throw new ArgumentNullException("paramInfos");
		}
		List<Type> recursionCheck = new List<Type>(paramInfos.Length);
		TraceLoggingTypeInfo[] array = new TraceLoggingTypeInfo[paramInfos.Length];
		for (int i = 0; i < paramInfos.Length; i++)
		{
			array[i] = Statics.GetTypeInfoInstance(paramInfos[i].ParameterType, recursionCheck);
		}
		return array;
	}

	private static TraceLoggingTypeInfo[] MakeArray(Type[] types)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		List<Type> recursionCheck = new List<Type>(types.Length);
		TraceLoggingTypeInfo[] array = new TraceLoggingTypeInfo[types.Length];
		for (int i = 0; i < types.Length; i++)
		{
			array[i] = Statics.GetTypeInfoInstance(types[i], recursionCheck);
		}
		return array;
	}

	private static TraceLoggingTypeInfo[] MakeArray(TraceLoggingTypeInfo[] typeInfos)
	{
		if (typeInfos == null)
		{
			throw new ArgumentNullException("typeInfos");
		}
		return (TraceLoggingTypeInfo[])typeInfos.Clone();
	}
}
