using System.Collections.Generic;

namespace System.Diagnostics.Tracing;

internal sealed class NullableTypeInfo<T> : TraceLoggingTypeInfo<T?> where T : struct
{
	private readonly TraceLoggingTypeInfo<T> valueInfo;

	public NullableTypeInfo(List<Type> recursionCheck)
	{
		valueInfo = TraceLoggingTypeInfo<T>.GetInstance(recursionCheck);
	}

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
	{
		TraceLoggingMetadataCollector traceLoggingMetadataCollector = collector.AddGroup(name);
		traceLoggingMetadataCollector.AddScalar("HasValue", TraceLoggingDataType.Boolean8);
		valueInfo.WriteMetadata(traceLoggingMetadataCollector, "Value", format);
	}

	public override void WriteData(TraceLoggingDataCollector collector, ref T? value)
	{
		bool hasValue = value.HasValue;
		collector.AddScalar(hasValue);
		T value2 = (hasValue ? value.Value : default(T));
		valueInfo.WriteData(collector, ref value2);
	}
}
