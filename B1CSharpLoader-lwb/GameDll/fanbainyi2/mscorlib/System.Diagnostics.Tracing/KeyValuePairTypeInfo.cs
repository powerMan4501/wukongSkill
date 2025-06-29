using System.Collections.Generic;

namespace System.Diagnostics.Tracing;

internal sealed class KeyValuePairTypeInfo<K, V> : TraceLoggingTypeInfo<KeyValuePair<K, V>>
{
	private readonly TraceLoggingTypeInfo<K> keyInfo;

	private readonly TraceLoggingTypeInfo<V> valueInfo;

	public KeyValuePairTypeInfo(List<Type> recursionCheck)
	{
		keyInfo = TraceLoggingTypeInfo<K>.GetInstance(recursionCheck);
		valueInfo = TraceLoggingTypeInfo<V>.GetInstance(recursionCheck);
	}

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
	{
		TraceLoggingMetadataCollector collector2 = collector.AddGroup(name);
		keyInfo.WriteMetadata(collector2, "Key", EventFieldFormat.Default);
		valueInfo.WriteMetadata(collector2, "Value", format);
	}

	public override void WriteData(TraceLoggingDataCollector collector, ref KeyValuePair<K, V> value)
	{
		K value2 = value.Key;
		V value3 = value.Value;
		keyInfo.WriteData(collector, ref value2);
		valueInfo.WriteData(collector, ref value3);
	}

	public override object GetData(object value)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		KeyValuePair<K, V> keyValuePair = (KeyValuePair<K, V>)value;
		dictionary.Add("Key", keyInfo.GetData(keyValuePair.Key));
		dictionary.Add("Value", valueInfo.GetData(keyValuePair.Value));
		return dictionary;
	}
}
