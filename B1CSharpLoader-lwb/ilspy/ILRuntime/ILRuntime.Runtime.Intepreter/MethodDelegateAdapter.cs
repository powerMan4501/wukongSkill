using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.Intepreter;

internal class MethodDelegateAdapter<T1> : DelegateAdapter
{
	private Action<T1> action;

	private static InvocationTypes pType;

	public override Type NativeDelegateType => typeof(Action<T1>);

	public override Delegate Delegate => action;

	static MethodDelegateAdapter()
	{
		pType = InvocationContext.GetInvocationType<T1>();
	}

	public MethodDelegateAdapter()
	{
	}

	private MethodDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe void InvokeILMethod(T1 p1)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pType, p1);
		ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new MethodDelegateAdapter<T1>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new MethodDelegateAdapter<T1>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Action<T1>)Delegate.Combine(action, (Action<T1>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Action<T1>)Delegate.Remove(action, (Action<T1>)dele);
	}
}
internal class MethodDelegateAdapter<T1, T2> : DelegateAdapter
{
	private Action<T1, T2> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Action<T1, T2>);

	public override Delegate Delegate => action;

	static MethodDelegateAdapter()
	{
		pTypes = new InvocationTypes[2]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>()
		};
	}

	public MethodDelegateAdapter()
	{
	}

	private MethodDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe void InvokeILMethod(T1 p1, T2 p2)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new MethodDelegateAdapter<T1, T2>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new MethodDelegateAdapter<T1, T2>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Action<T1, T2>)Delegate.Combine(action, (Action<T1, T2>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Action<T1, T2>)Delegate.Remove(action, (Action<T1, T2>)dele);
	}
}
internal class MethodDelegateAdapter<T1, T2, T3> : DelegateAdapter
{
	private Action<T1, T2, T3> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Action<T1, T2, T3>);

	public override Delegate Delegate => action;

	static MethodDelegateAdapter()
	{
		pTypes = new InvocationTypes[3]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>(),
			InvocationContext.GetInvocationType<T3>()
		};
	}

	public MethodDelegateAdapter()
	{
	}

	private MethodDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe void InvokeILMethod(T1 p1, T2 p2, T3 p3)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		invocationContext.PushParameter(pTypes[2], p3);
		ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new MethodDelegateAdapter<T1, T2, T3>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new MethodDelegateAdapter<T1, T2, T3>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Action<T1, T2, T3>)Delegate.Combine(action, (Action<T1, T2, T3>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Action<T1, T2, T3>)Delegate.Remove(action, (Action<T1, T2, T3>)dele);
	}
}
internal class MethodDelegateAdapter<T1, T2, T3, T4> : DelegateAdapter
{
	private Action<T1, T2, T3, T4> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Action<T1, T2, T3, T4>);

	public override Delegate Delegate => action;

	static MethodDelegateAdapter()
	{
		pTypes = new InvocationTypes[4]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>(),
			InvocationContext.GetInvocationType<T3>(),
			InvocationContext.GetInvocationType<T4>()
		};
	}

	public MethodDelegateAdapter()
	{
	}

	private MethodDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe void InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		invocationContext.PushParameter(pTypes[2], p3);
		invocationContext.PushParameter(pTypes[3], p4);
		ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new MethodDelegateAdapter<T1, T2, T3, T4>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new MethodDelegateAdapter<T1, T2, T3, T4>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Action<T1, T2, T3, T4>)Delegate.Combine(action, (Action<T1, T2, T3, T4>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Action<T1, T2, T3, T4>)Delegate.Remove(action, (Action<T1, T2, T3, T4>)dele);
	}
}
internal class MethodDelegateAdapter<T1, T2, T3, T4, T5> : DelegateAdapter
{
	private Action<T1, T2, T3, T4, T5> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Action<T1, T2, T3, T4, T5>);

	public override Delegate Delegate => action;

	static MethodDelegateAdapter()
	{
		pTypes = new InvocationTypes[5]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>(),
			InvocationContext.GetInvocationType<T3>(),
			InvocationContext.GetInvocationType<T4>(),
			InvocationContext.GetInvocationType<T5>()
		};
	}

	public MethodDelegateAdapter()
	{
	}

	private MethodDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe void InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		invocationContext.PushParameter(pTypes[2], p3);
		invocationContext.PushParameter(pTypes[3], p4);
		invocationContext.PushParameter(pTypes[4], p5);
		ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new MethodDelegateAdapter<T1, T2, T3, T4, T5>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new MethodDelegateAdapter<T1, T2, T3, T4, T5>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Action<T1, T2, T3, T4, T5>)Delegate.Combine(action, (Action<T1, T2, T3, T4, T5>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Action<T1, T2, T3, T4, T5>)Delegate.Remove(action, (Action<T1, T2, T3, T4, T5>)dele);
	}
}
internal class MethodDelegateAdapter : DelegateAdapter
{
	private Action action;

	public override Type NativeDelegateType => typeof(Action);

	public override Delegate Delegate => action;

	public MethodDelegateAdapter()
	{
	}

	protected MethodDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe void InvokeILMethod()
	{
		using InvocationContext invocationContext = BeginInvoke();
		ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new MethodDelegateAdapter(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new MethodDelegateAdapter(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Action)Delegate.Combine(action, (Action)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Action)Delegate.Remove(action, (Action)dele);
	}
}
