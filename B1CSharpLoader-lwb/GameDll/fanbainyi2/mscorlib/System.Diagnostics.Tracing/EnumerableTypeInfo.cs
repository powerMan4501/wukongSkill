using System.Collections.Generic;

namespace System.Diagnostics.Tracing;

internal sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType> where IterableType : IEnumerable<ElementType>
{
	private readonly TraceLoggingTypeInfo<ElementType> elementInfo;

	public EnumerableTypeInfo(TraceLoggingTypeInfo<ElementType> elementInfo)
	{
		this.elementInfo = elementInfo;
	}

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
	{
		collector.BeginBufferedArray();
		elementInfo.WriteMetadata(collector, name, format);
		collector.EndBufferedArray();
	}

	public override void WriteData(TraceLoggingDataCollector collector, ref IterableType value)
	{
		int bookmark = collector.BeginBufferedArray();
		int num = 0;
		if (value != null)
		{
			foreach (ElementType item in value)
			{
				ElementType value2 = item;
				elementInfo.WriteData(collector, ref value2);
				num++;
			}
		}
		collector.EndBufferedArray(bookmark, num);
	}

	public override object GetData(object value)
	{
		IterableType val = (IterableType)value;
		List<object> list = new List<object>();
		foreach (ElementType item in val)
		{
			list.Add(elementInfo.GetData(item));
		}
		return list.ToArray();
	}
}
