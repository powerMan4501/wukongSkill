using System.Collections.Generic;

namespace System.Diagnostics.Tracing;

internal sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType>
{
	private readonly PropertyAnalysis[] properties;

	private readonly PropertyAccessor<ContainerType>[] accessors;

	public InvokeTypeInfo(TypeAnalysis typeAnalysis)
		: base(typeAnalysis.name, typeAnalysis.level, typeAnalysis.opcode, typeAnalysis.keywords, typeAnalysis.tags)
	{
		if (typeAnalysis.properties.Length != 0)
		{
			properties = typeAnalysis.properties;
			accessors = new PropertyAccessor<ContainerType>[properties.Length];
			for (int i = 0; i < accessors.Length; i++)
			{
				accessors[i] = PropertyAccessor<ContainerType>.Create(properties[i]);
			}
		}
	}

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
	{
		TraceLoggingMetadataCollector traceLoggingMetadataCollector = collector.AddGroup(name);
		if (properties == null)
		{
			return;
		}
		PropertyAnalysis[] array = properties;
		foreach (PropertyAnalysis propertyAnalysis in array)
		{
			EventFieldFormat format2 = EventFieldFormat.Default;
			EventFieldAttribute fieldAttribute = propertyAnalysis.fieldAttribute;
			if (fieldAttribute != null)
			{
				traceLoggingMetadataCollector.Tags = fieldAttribute.Tags;
				format2 = fieldAttribute.Format;
			}
			propertyAnalysis.typeInfo.WriteMetadata(traceLoggingMetadataCollector, propertyAnalysis.name, format2);
		}
	}

	public override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value)
	{
		if (accessors != null)
		{
			PropertyAccessor<ContainerType>[] array = accessors;
			foreach (PropertyAccessor<ContainerType> propertyAccessor in array)
			{
				propertyAccessor.Write(collector, ref value);
			}
		}
	}

	public override object GetData(object value)
	{
		if (properties != null)
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			for (int i = 0; i < properties.Length; i++)
			{
				object data = accessors[i].GetData((ContainerType)value);
				list.Add(properties[i].name);
				list2.Add(properties[i].typeInfo.GetData(data));
			}
			return new EventPayload(list, list2);
		}
		return null;
	}

	public override void WriteObjectData(TraceLoggingDataCollector collector, object valueObj)
	{
		if (accessors != null)
		{
			ContainerType value = ((valueObj == null) ? default(ContainerType) : ((ContainerType)valueObj));
			WriteData(collector, ref value);
		}
	}
}
