using System;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Enviorment;

public class CrossBindingFunctionInfo<T1, T2, T3, T4, T5, TResult> : CrossBindingMethodInfo
{
	public delegate TResult InvocationDelegate(ILTypeInstance instance, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	private static InvocationTypes[] piTypes = new InvocationTypes[6]
	{
		InvocationContext.GetInvocationType<T1>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<T3>(),
		InvocationContext.GetInvocationType<T4>(),
		InvocationContext.GetInvocationType<T5>(),
		InvocationContext.GetInvocationType<TResult>()
	};

	private static Type[] pTypes = new Type[5]
	{
		typeof(T1),
		typeof(T2),
		typeof(T3),
		typeof(T4),
		typeof(T5)
	};

	protected override Type ReturnType => typeof(TResult);

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingFunctionInfo(string name)
		: base(name)
	{
	}

	public TResult Invoke(ILTypeInstance instance, T1 arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			TResult val = default(TResult);
			try
			{
				if (DoInvoke != null)
				{
					return DoInvoke(instance, arg, arg2, arg3, arg4, arg5);
				}
				using InvocationContext invocationContext = domain.BeginInvoke(method);
				invocationContext.PushObject(instance);
				invocationContext.PushParameter(piTypes[0], arg);
				invocationContext.PushParameter(piTypes[1], arg2);
				invocationContext.PushParameter(piTypes[2], arg3);
				invocationContext.PushParameter(piTypes[3], arg4);
				invocationContext.PushParameter(piTypes[4], arg5);
				invocationContext.Invoke();
				return invocationContext.ReadResult<TResult>(piTypes[5]);
			}
			finally
			{
				invoking = false;
			}
		}
		return default(TResult);
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingFunctionInfo<T1, T2, T3, T4, TResult> : CrossBindingMethodInfo
{
	public delegate TResult InvocationDelegate(ILTypeInstance instance, T1 arg, T2 arg2, T3 arg3, T4 arg4);

	private static InvocationTypes[] piTypes = new InvocationTypes[5]
	{
		InvocationContext.GetInvocationType<T1>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<T3>(),
		InvocationContext.GetInvocationType<T4>(),
		InvocationContext.GetInvocationType<TResult>()
	};

	private static Type[] pTypes = new Type[4]
	{
		typeof(T1),
		typeof(T2),
		typeof(T3),
		typeof(T4)
	};

	protected override Type ReturnType => typeof(TResult);

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingFunctionInfo(string name)
		: base(name)
	{
	}

	public TResult Invoke(ILTypeInstance instance, T1 arg, T2 arg2, T3 arg3, T4 arg4)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			TResult val = default(TResult);
			try
			{
				if (DoInvoke != null)
				{
					return DoInvoke(instance, arg, arg2, arg3, arg4);
				}
				using InvocationContext invocationContext = domain.BeginInvoke(method);
				invocationContext.PushObject(instance);
				invocationContext.PushParameter(piTypes[0], arg);
				invocationContext.PushParameter(piTypes[1], arg2);
				invocationContext.PushParameter(piTypes[2], arg3);
				invocationContext.PushParameter(piTypes[3], arg4);
				invocationContext.Invoke();
				return invocationContext.ReadResult<TResult>(piTypes[4]);
			}
			finally
			{
				invoking = false;
			}
		}
		return default(TResult);
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingFunctionInfo<T1, T2, T3, TResult> : CrossBindingMethodInfo
{
	public delegate TResult InvocationDelegate(ILTypeInstance instance, T1 arg, T2 arg2, T3 arg3);

	private static InvocationTypes[] piTypes = new InvocationTypes[4]
	{
		InvocationContext.GetInvocationType<T1>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<T3>(),
		InvocationContext.GetInvocationType<TResult>()
	};

	private static Type[] pTypes = new Type[3]
	{
		typeof(T1),
		typeof(T2),
		typeof(T3)
	};

	protected override Type ReturnType => typeof(TResult);

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingFunctionInfo(string name)
		: base(name)
	{
	}

	public TResult Invoke(ILTypeInstance instance, T1 arg, T2 arg2, T3 arg3)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			TResult val = default(TResult);
			try
			{
				if (DoInvoke != null)
				{
					return DoInvoke(instance, arg, arg2, arg3);
				}
				using InvocationContext invocationContext = domain.BeginInvoke(method);
				invocationContext.PushObject(instance);
				invocationContext.PushParameter(piTypes[0], arg);
				invocationContext.PushParameter(piTypes[1], arg2);
				invocationContext.PushParameter(piTypes[2], arg3);
				invocationContext.Invoke();
				return invocationContext.ReadResult<TResult>(piTypes[3]);
			}
			finally
			{
				invoking = false;
			}
		}
		return default(TResult);
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingFunctionInfo<T1, T2, TResult> : CrossBindingMethodInfo
{
	public delegate TResult InvocationDelegate(ILTypeInstance instance, T1 arg, T2 arg2);

	private static InvocationTypes[] piTypes = new InvocationTypes[3]
	{
		InvocationContext.GetInvocationType<T1>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<TResult>()
	};

	private static Type[] pTypes = new Type[2]
	{
		typeof(T1),
		typeof(T2)
	};

	protected override Type ReturnType => typeof(TResult);

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingFunctionInfo(string name)
		: base(name)
	{
	}

	public TResult Invoke(ILTypeInstance instance, T1 arg, T2 arg2)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			TResult val = default(TResult);
			try
			{
				if (DoInvoke != null)
				{
					return DoInvoke(instance, arg, arg2);
				}
				using InvocationContext invocationContext = domain.BeginInvoke(method);
				invocationContext.PushObject(instance);
				invocationContext.PushParameter(piTypes[0], arg);
				invocationContext.PushParameter(piTypes[1], arg2);
				invocationContext.Invoke();
				return invocationContext.ReadResult<TResult>(piTypes[2]);
			}
			finally
			{
				invoking = false;
			}
		}
		return default(TResult);
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingFunctionInfo<T1, TResult> : CrossBindingMethodInfo
{
	public delegate TResult InvocationDelegate(ILTypeInstance instance, T1 arg);

	private static InvocationTypes[] piTypes = new InvocationTypes[2]
	{
		InvocationContext.GetInvocationType<T1>(),
		InvocationContext.GetInvocationType<TResult>()
	};

	private static Type[] pTypes = new Type[1] { typeof(T1) };

	protected override Type ReturnType => typeof(TResult);

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingFunctionInfo(string name)
		: base(name)
	{
	}

	public TResult Invoke(ILTypeInstance instance, T1 arg)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			TResult val = default(TResult);
			try
			{
				if (DoInvoke != null)
				{
					return DoInvoke(instance, arg);
				}
				using InvocationContext invocationContext = domain.BeginInvoke(method);
				invocationContext.PushObject(instance);
				invocationContext.PushParameter(piTypes[0], arg);
				invocationContext.Invoke();
				return invocationContext.ReadResult<TResult>(piTypes[1]);
			}
			finally
			{
				invoking = false;
			}
		}
		return default(TResult);
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingFunctionInfo<TResult> : CrossBindingMethodInfo
{
	public delegate TResult InvocationDelegate(ILTypeInstance instance);

	private static InvocationTypes rType = InvocationContext.GetInvocationType<TResult>();

	protected override Type ReturnType => typeof(TResult);

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingFunctionInfo(string name)
		: base(name)
	{
	}

	public new TResult Invoke(ILTypeInstance instance)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			TResult val = default(TResult);
			try
			{
				if (DoInvoke != null)
				{
					return DoInvoke(instance);
				}
				using InvocationContext invocationContext = domain.BeginInvoke(method);
				invocationContext.PushObject(instance);
				invocationContext.Invoke();
				return invocationContext.ReadResult<TResult>(rType);
			}
			finally
			{
				invoking = false;
			}
		}
		return default(TResult);
	}
}
