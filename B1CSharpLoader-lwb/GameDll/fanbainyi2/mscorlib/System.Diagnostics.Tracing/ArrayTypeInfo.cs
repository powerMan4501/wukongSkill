namespace System.Diagnostics.Tracing;

internal sealed class ArrayTypeInfo<ElementType> : TraceLoggingTypeInfo<ElementType[]>
{
	private readonly TraceLoggingTypeInfo<ElementType> elementInfo;

	public ArrayTypeInfo(TraceLoggingTypeInfo<ElementType> elementInfo)
	{
		this.elementInfo = elementInfo;
	}

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
	{
		collector.BeginBufferedArray();
		elementInfo.WriteMetadata(collector, name, format);
		collector.EndBufferedArray();
	}

	public override void WriteData(TraceLoggingDataCollector collector, ref ElementType[] value)
	{
		int bookmark = collector.BeginBufferedArray();
		int count = 0;
		if (value != null)
		{
			count = value.Length;
			for (int i = 0; i < value.Length; i++)
			{
				elementInfo.WriteData(collector, ref value[i]);
			}
		}
		collector.EndBufferedArray(bookmark, count);
	}

	public override object GetData(object value)
	{
		ElementType[] array = (ElementType[])value;
		object[] array2 = new object[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = elementInfo.GetData(array[i]);
		}
		return array2;
	}
}
