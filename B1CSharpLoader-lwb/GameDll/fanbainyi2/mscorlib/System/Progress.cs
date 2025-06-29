using System.Threading;

namespace System;

[__DynamicallyInvokable]
public class Progress<T> : IProgress<T>
{
	private readonly SynchronizationContext m_synchronizationContext;

	private readonly Action<T> m_handler;

	private readonly SendOrPostCallback m_invokeHandlers;

	[__DynamicallyInvokable]
	[method: __DynamicallyInvokable]
	public event EventHandler<T> ProgressChanged;

	[__DynamicallyInvokable]
	public Progress()
	{
		m_synchronizationContext = SynchronizationContext.CurrentNoFlow ?? ProgressStatics.DefaultContext;
		m_invokeHandlers = InvokeHandlers;
	}

	[__DynamicallyInvokable]
	public Progress(Action<T> handler)
		: this()
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		m_handler = handler;
	}

	[__DynamicallyInvokable]
	protected virtual void OnReport(T value)
	{
		Action<T> handler = m_handler;
		EventHandler<T> eventHandler = this.ProgressChanged;
		if (handler != null || eventHandler != null)
		{
			m_synchronizationContext.Post(m_invokeHandlers, value);
		}
	}

	[__DynamicallyInvokable]
	void IProgress<T>.Report(T value)
	{
		OnReport(value);
	}

	private void InvokeHandlers(object state)
	{
		T val = (T)state;
		Action<T> handler = m_handler;
		EventHandler<T> eventHandler = this.ProgressChanged;
		handler?.Invoke(val);
		eventHandler?.Invoke(this, val);
	}
}
