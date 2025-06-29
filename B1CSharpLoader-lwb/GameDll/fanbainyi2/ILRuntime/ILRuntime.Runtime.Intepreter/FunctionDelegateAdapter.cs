using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

internal class FunctionDelegateAdapter<TResult> : DelegateAdapter
{
	private Func<TResult> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Func<TResult>);

	public override Delegate Delegate => action;

	static FunctionDelegateAdapter()
	{
		pTypes = new InvocationTypes[1] { InvocationContext.GetInvocationType<TResult>() };
	}

	public FunctionDelegateAdapter()
	{
	}

	private FunctionDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe TResult InvokeILMethod()
	{
		using InvocationContext invocationContext = BeginInvoke();
		StackObject* invoked = ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
		invocationContext.SetInvoked(invoked);
		return invocationContext.ReadResult<TResult>(pTypes[0]);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new FunctionDelegateAdapter<TResult>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new FunctionDelegateAdapter<TResult>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Func<TResult>)Delegate.Combine(action, (Func<TResult>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Func<TResult>)Delegate.Remove(action, (Func<TResult>)dele);
	}
}
internal class FunctionDelegateAdapter<T1, TResult> : DelegateAdapter
{
	private Func<T1, TResult> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Func<T1, TResult>);

	public override Delegate Delegate => action;

	static FunctionDelegateAdapter()
	{
		pTypes = new InvocationTypes[2]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<TResult>()
		};
	}

	public FunctionDelegateAdapter()
	{
	}

	private FunctionDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe TResult InvokeILMethod(T1 p1)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		StackObject* invoked = ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
		invocationContext.SetInvoked(invoked);
		return invocationContext.ReadResult<TResult>(pTypes[1]);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new FunctionDelegateAdapter<T1, TResult>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new FunctionDelegateAdapter<T1, TResult>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Func<T1, TResult>)Delegate.Combine(action, (Func<T1, TResult>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Func<T1, TResult>)Delegate.Remove(action, (Func<T1, TResult>)dele);
	}
}
internal class FunctionDelegateAdapter<T1, T2, TResult> : DelegateAdapter
{
	private Func<T1, T2, TResult> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Func<T1, T2, TResult>);

	public override Delegate Delegate => action;

	static FunctionDelegateAdapter()
	{
		pTypes = new InvocationTypes[3]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>(),
			InvocationContext.GetInvocationType<TResult>()
		};
	}

	public FunctionDelegateAdapter()
	{
	}

	private FunctionDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe TResult InvokeILMethod(T1 p1, T2 p2)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		StackObject* invoked = ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
		invocationContext.SetInvoked(invoked);
		return invocationContext.ReadResult<TResult>(pTypes[2]);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new FunctionDelegateAdapter<T1, T2, TResult>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new FunctionDelegateAdapter<T1, T2, TResult>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Func<T1, T2, TResult>)Delegate.Combine(action, (Func<T1, T2, TResult>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Func<T1, T2, TResult>)Delegate.Remove(action, (Func<T1, T2, TResult>)dele);
	}
}
internal class FunctionDelegateAdapter<T1, T2, T3, TResult> : DelegateAdapter
{
	private Func<T1, T2, T3, TResult> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Func<T1, T2, T3, TResult>);

	public override Delegate Delegate => action;

	static FunctionDelegateAdapter()
	{
		pTypes = new InvocationTypes[4]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>(),
			InvocationContext.GetInvocationType<T3>(),
			InvocationContext.GetInvocationType<TResult>()
		};
	}

	public FunctionDelegateAdapter()
	{
	}

	private FunctionDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe TResult InvokeILMethod(T1 p1, T2 p2, T3 p3)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		invocationContext.PushParameter(pTypes[2], p3);
		StackObject* invoked = ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
		invocationContext.SetInvoked(invoked);
		return invocationContext.ReadResult<TResult>(pTypes[3]);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new FunctionDelegateAdapter<T1, T2, T3, TResult>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new FunctionDelegateAdapter<T1, T2, T3, TResult>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Func<T1, T2, T3, TResult>)Delegate.Combine(action, (Func<T1, T2, T3, TResult>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Func<T1, T2, T3, TResult>)Delegate.Remove(action, (Func<T1, T2, T3, TResult>)dele);
	}
}
internal class FunctionDelegateAdapter<T1, T2, T3, T4, TResult> : DelegateAdapter
{
	private Func<T1, T2, T3, T4, TResult> action;

	private static InvocationTypes[] pTypes;

	public override Type NativeDelegateType => typeof(Func<T1, T2, T3, T4, TResult>);

	public override Delegate Delegate => action;

	static FunctionDelegateAdapter()
	{
		pTypes = new InvocationTypes[5]
		{
			InvocationContext.GetInvocationType<T1>(),
			InvocationContext.GetInvocationType<T2>(),
			InvocationContext.GetInvocationType<T3>(),
			InvocationContext.GetInvocationType<T4>(),
			InvocationContext.GetInvocationType<TResult>()
		};
	}

	public FunctionDelegateAdapter()
	{
	}

	private FunctionDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
		action = InvokeILMethod;
	}

	private unsafe TResult InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4)
	{
		using InvocationContext invocationContext = BeginInvoke();
		invocationContext.PushParameter(pTypes[0], p1);
		invocationContext.PushParameter(pTypes[1], p2);
		invocationContext.PushParameter(pTypes[2], p3);
		invocationContext.PushParameter(pTypes[3], p4);
		StackObject* invoked = ILInvoke(invocationContext.Intepreter, invocationContext.ESP, invocationContext.ManagedStack);
		invocationContext.SetInvoked(invoked);
		return invocationContext.ReadResult<TResult>(pTypes[4]);
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new FunctionDelegateAdapter<T1, T2, T3, T4, TResult>(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new FunctionDelegateAdapter<T1, T2, T3, T4, TResult>(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		action = (Func<T1, T2, T3, T4, TResult>)Delegate.Combine(action, (Func<T1, T2, T3, T4, TResult>)dele);
	}

	public override void Remove(Delegate dele)
	{
		action = (Func<T1, T2, T3, T4, TResult>)Delegate.Remove(action, (Func<T1, T2, T3, T4, TResult>)dele);
	}
}
