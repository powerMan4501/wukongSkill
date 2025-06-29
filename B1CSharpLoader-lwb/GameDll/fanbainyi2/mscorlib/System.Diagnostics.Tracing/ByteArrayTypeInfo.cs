namespace System.Diagnostics.Tracing;

internal sealed class ByteArrayTypeInfo : TraceLoggingTypeInfo<byte[]>
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
	{
		switch (format)
		{
		default:
			collector.AddBinary(name, Statics.MakeDataType(TraceLoggingDataType.Binary, format));
			break;
		case EventFieldFormat.String:
			collector.AddBinary(name, TraceLoggingDataType.CountedMbcsString);
			break;
		case EventFieldFormat.Xml:
			collector.AddBinary(name, TraceLoggingDataType.CountedMbcsXml);
			break;
		case EventFieldFormat.Json:
			collector.AddBinary(name, TraceLoggingDataType.CountedMbcsJson);
			break;
		case EventFieldFormat.Boolean:
			collector.AddArray(name, TraceLoggingDataType.Boolean8);
			break;
		case EventFieldFormat.Hexadecimal:
			collector.AddArray(name, TraceLoggingDataType.HexInt8);
			break;
		}
	}

	public override void WriteData(TraceLoggingDataCollector collector, ref byte[] value)
	{
		collector.AddBinary(value);
	}
}
