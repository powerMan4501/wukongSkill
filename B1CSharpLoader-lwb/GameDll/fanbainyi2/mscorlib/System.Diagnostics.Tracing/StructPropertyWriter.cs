namespace System.Diagnostics.Tracing;

internal class StructPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType>
{
	private delegate ValueType Getter(ref ContainerType container);

	private readonly TraceLoggingTypeInfo<ValueType> valueTypeInfo;

	private readonly Getter getter;

	public StructPropertyWriter(PropertyAnalysis property)
	{
		valueTypeInfo = (TraceLoggingTypeInfo<ValueType>)property.typeInfo;
		getter = (Getter)Statics.CreateDelegate(typeof(Getter), property.getterInfo);
	}

	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container)
	{
		ValueType value = ((container == null) ? default(ValueType) : getter(ref container));
		valueTypeInfo.WriteData(collector, ref value);
	}

	public override object GetData(ContainerType container)
	{
		return (container == null) ? default(ValueType) : getter(ref container);
	}
}
