using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.Intepreter;

internal class DummyDelegateAdapter : DelegateAdapter
{
	public override Type NativeDelegateType
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override Delegate Delegate
	{
		get
		{
			DelegateAdapter.ThrowAdapterNotFound(method);
			return null;
		}
	}

	public DummyDelegateAdapter()
	{
	}

	protected DummyDelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
		: base(appdomain, instance, method)
	{
	}

	private void InvokeILMethod()
	{
		if (method.HasThis)
		{
			appdomain.Invoke(method, instance, null);
		}
		else
		{
			appdomain.Invoke(method, null, null);
		}
	}

	public override IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		return new DummyDelegateAdapter(appdomain, instance, method);
	}

	public override IDelegateAdapter Clone()
	{
		return new DummyDelegateAdapter(appdomain, instance, method)
		{
			isClone = true
		};
	}

	public override void Combine(Delegate dele)
	{
		DelegateAdapter.ThrowAdapterNotFound(method);
	}

	public override void Remove(Delegate dele)
	{
		DelegateAdapter.ThrowAdapterNotFound(method);
	}
}
