using System.Threading;

namespace System;

internal sealed class System_LazyDebugView<T>
{
	private readonly Lazy<T> m_lazy;

	public bool IsValueCreated => m_lazy.IsValueCreated;

	public T Value => m_lazy.ValueForDebugDisplay;

	public LazyThreadSafetyMode Mode => m_lazy.Mode;

	public bool IsValueFaulted => m_lazy.IsValueFaulted;

	public System_LazyDebugView(Lazy<T> lazy)
	{
		m_lazy = lazy;
	}
}
