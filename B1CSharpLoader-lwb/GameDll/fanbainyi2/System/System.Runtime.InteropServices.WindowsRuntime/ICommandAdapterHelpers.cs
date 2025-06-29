using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal static class ICommandAdapterHelpers
{
	internal static EventHandler<object> CreateWrapperHandler(EventHandler handler)
	{
		return delegate(object sender, object e)
		{
			EventArgs e2 = e as EventArgs;
			handler(sender, (e2 == null) ? EventArgs.Empty : e2);
		};
	}

	internal static EventHandler CreateWrapperHandler(EventHandler<object> handler)
	{
		return delegate(object sender, EventArgs e)
		{
			handler(sender, e);
		};
	}

	internal static EventHandler<object> GetValueFromEquivalentKey(ConditionalWeakTable<EventHandler, EventHandler<object>> table, EventHandler key, ConditionalWeakTable<EventHandler, EventHandler<object>>.CreateValueCallback callback)
	{
		EventHandler<object> value;
		EventHandler eventHandler = table.FindEquivalentKeyUnsafe(key, out value);
		if (eventHandler == null)
		{
			value = callback(key);
			table.Add(key, value);
		}
		return value;
	}
}
