namespace System.Diagnostics;

internal class FilterElement : TypedElement
{
	public FilterElement()
		: base(typeof(TraceFilter))
	{
	}

	public TraceFilter GetRuntimeObject()
	{
		TraceFilter traceFilter = (TraceFilter)BaseGetRuntimeObject();
		traceFilter.initializeData = base.InitData;
		return traceFilter;
	}

	internal TraceFilter RefreshRuntimeObject(TraceFilter filter)
	{
		if (Type.GetType(TypeName) != filter.GetType() || base.InitData != filter.initializeData)
		{
			_runtimeObject = null;
			return GetRuntimeObject();
		}
		return filter;
	}
}
