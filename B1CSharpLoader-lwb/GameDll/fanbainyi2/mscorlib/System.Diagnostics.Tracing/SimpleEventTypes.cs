using System.Threading;

namespace System.Diagnostics.Tracing;

internal class SimpleEventTypes<T> : TraceLoggingEventTypes
{
	private static SimpleEventTypes<T> instance;

	internal readonly TraceLoggingTypeInfo<T> typeInfo;

	public static SimpleEventTypes<T> Instance => instance ?? InitInstance();

	private SimpleEventTypes(TraceLoggingTypeInfo<T> typeInfo)
		: base(typeInfo.Name, typeInfo.Tags, typeInfo)
	{
		this.typeInfo = typeInfo;
	}

	private static SimpleEventTypes<T> InitInstance()
	{
		SimpleEventTypes<T> value = new SimpleEventTypes<T>(TraceLoggingTypeInfo<T>.Instance);
		Interlocked.CompareExchange(ref instance, value, null);
		return instance;
	}
}
