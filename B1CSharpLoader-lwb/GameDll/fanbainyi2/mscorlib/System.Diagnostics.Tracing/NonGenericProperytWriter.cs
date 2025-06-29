using System.Reflection;

namespace System.Diagnostics.Tracing;

internal class NonGenericProperytWriter<ContainerType> : PropertyAccessor<ContainerType>
{
	private readonly TraceLoggingTypeInfo typeInfo;

	private readonly MethodInfo getterInfo;

	public NonGenericProperytWriter(PropertyAnalysis property)
	{
		getterInfo = property.getterInfo;
		typeInfo = property.typeInfo;
	}

	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container)
	{
		object value = ((container == null) ? null : getterInfo.Invoke(container, null));
		typeInfo.WriteObjectData(collector, value);
	}

	public override object GetData(ContainerType container)
	{
		if (container != null)
		{
			return getterInfo.Invoke(container, null);
		}
		return null;
	}
}
