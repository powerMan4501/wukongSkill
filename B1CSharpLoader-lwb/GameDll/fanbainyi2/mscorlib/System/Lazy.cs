using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System;

[Serializable]
[ComVisible(false)]
[DebuggerTypeProxy(typeof(System_LazyDebugView<>))]
[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class Lazy<T>
{
	[Serializable]
	private class Boxed
	{
		internal T m_value;

		internal Boxed(T value)
		{
			m_value = value;
		}
	}

	private class LazyInternalExceptionHolder
	{
		internal ExceptionDispatchInfo m_edi;

		internal LazyInternalExceptionHolder(Exception ex)
		{
			m_edi = ExceptionDispatchInfo.Capture(ex);
		}
	}

	private static readonly Func<T> ALREADY_INVOKED_SENTINEL = () => default(T);

	private object m_boxed;

	[NonSerialized]
	private Func<T> m_valueFactory;

	[NonSerialized]
	private object m_threadSafeObj;

	internal T ValueForDebugDisplay
	{
		get
		{
			if (!IsValueCreated)
			{
				return default(T);
			}
			return ((Boxed)m_boxed).m_value;
		}
	}

	internal LazyThreadSafetyMode Mode
	{
		get
		{
			if (m_threadSafeObj == null)
			{
				return LazyThreadSafetyMode.None;
			}
			if (m_threadSafeObj == LazyHelpers.PUBLICATION_ONLY_SENTINEL)
			{
				return LazyThreadSafetyMode.PublicationOnly;
			}
			return LazyThreadSafetyMode.ExecutionAndPublication;
		}
	}

	internal bool IsValueFaulted => m_boxed is LazyInternalExceptionHolder;

	[__DynamicallyInvokable]
	public bool IsValueCreated
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_boxed != null)
			{
				return m_boxed is Boxed;
			}
			return false;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[__DynamicallyInvokable]
	public T Value
	{
		[__DynamicallyInvokable]
		get
		{
			Boxed boxed = null;
			if (m_boxed != null)
			{
				if (m_boxed is Boxed boxed2)
				{
					return boxed2.m_value;
				}
				LazyInternalExceptionHolder lazyInternalExceptionHolder = m_boxed as LazyInternalExceptionHolder;
				lazyInternalExceptionHolder.m_edi.Throw();
			}
			Debugger.NotifyOfCrossThreadDependency();
			return LazyInitValue();
		}
	}

	[__DynamicallyInvokable]
	public Lazy()
		: this(LazyThreadSafetyMode.ExecutionAndPublication)
	{
	}

	[__DynamicallyInvokable]
	public Lazy(Func<T> valueFactory)
		: this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication)
	{
	}

	[__DynamicallyInvokable]
	public Lazy(bool isThreadSafe)
		: this(isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
	{
	}

	[__DynamicallyInvokable]
	public Lazy(LazyThreadSafetyMode mode)
	{
		m_threadSafeObj = GetObjectFromMode(mode);
	}

	[__DynamicallyInvokable]
	public Lazy(Func<T> valueFactory, bool isThreadSafe)
		: this(valueFactory, isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
	{
	}

	[__DynamicallyInvokable]
	public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode)
	{
		if (valueFactory == null)
		{
			throw new ArgumentNullException("valueFactory");
		}
		m_threadSafeObj = GetObjectFromMode(mode);
		m_valueFactory = valueFactory;
	}

	private static object GetObjectFromMode(LazyThreadSafetyMode mode)
	{
		return mode switch
		{
			LazyThreadSafetyMode.ExecutionAndPublication => new object(), 
			LazyThreadSafetyMode.PublicationOnly => LazyHelpers.PUBLICATION_ONLY_SENTINEL, 
			LazyThreadSafetyMode.None => null, 
			_ => throw new ArgumentOutOfRangeException("mode", Environment.GetResourceString("Lazy_ctor_ModeInvalid")), 
		};
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext context)
	{
		T value = Value;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		if (!IsValueCreated)
		{
			return Environment.GetResourceString("Lazy_ToString_ValueNotCreated");
		}
		return Value.ToString();
	}

	private T LazyInitValue()
	{
		Boxed boxed = null;
		switch (Mode)
		{
		case LazyThreadSafetyMode.None:
			boxed = (Boxed)(m_boxed = CreateValue());
			break;
		case LazyThreadSafetyMode.PublicationOnly:
			boxed = CreateValue();
			if (boxed == null || Interlocked.CompareExchange(ref m_boxed, boxed, null) != null)
			{
				boxed = (Boxed)m_boxed;
			}
			else
			{
				m_valueFactory = ALREADY_INVOKED_SENTINEL;
			}
			break;
		default:
		{
			object obj = Volatile.Read(ref m_threadSafeObj);
			bool lockTaken = false;
			try
			{
				if (obj != ALREADY_INVOKED_SENTINEL)
				{
					Monitor.Enter(obj, ref lockTaken);
				}
				if (m_boxed == null)
				{
					boxed = (Boxed)(m_boxed = CreateValue());
					Volatile.Write(ref m_threadSafeObj, ALREADY_INVOKED_SENTINEL);
					break;
				}
				boxed = m_boxed as Boxed;
				if (boxed == null)
				{
					LazyInternalExceptionHolder lazyInternalExceptionHolder = m_boxed as LazyInternalExceptionHolder;
					lazyInternalExceptionHolder.m_edi.Throw();
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			break;
		}
		}
		return boxed.m_value;
	}

	private Boxed CreateValue()
	{
		Boxed boxed = null;
		LazyThreadSafetyMode mode = Mode;
		if (m_valueFactory != null)
		{
			try
			{
				if (mode != LazyThreadSafetyMode.PublicationOnly && m_valueFactory == ALREADY_INVOKED_SENTINEL)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Lazy_Value_RecursiveCallsToValue"));
				}
				Func<T> valueFactory = m_valueFactory;
				if (mode != LazyThreadSafetyMode.PublicationOnly)
				{
					m_valueFactory = ALREADY_INVOKED_SENTINEL;
				}
				else if (valueFactory == ALREADY_INVOKED_SENTINEL)
				{
					return null;
				}
				return new Boxed(valueFactory());
			}
			catch (Exception ex)
			{
				if (mode != LazyThreadSafetyMode.PublicationOnly)
				{
					m_boxed = new LazyInternalExceptionHolder(ex);
				}
				throw;
			}
		}
		try
		{
			return new Boxed((T)Activator.CreateInstance(typeof(T)));
		}
		catch (MissingMethodException)
		{
			Exception ex3 = new MissingMemberException(Environment.GetResourceString("Lazy_CreateValue_NoParameterlessCtorForT"));
			if (mode != LazyThreadSafetyMode.PublicationOnly)
			{
				m_boxed = new LazyInternalExceptionHolder(ex3);
			}
			throw ex3;
		}
	}
}
