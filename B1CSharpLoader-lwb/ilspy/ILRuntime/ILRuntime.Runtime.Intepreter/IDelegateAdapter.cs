using System;
using ILRuntime.CLR.Method;
using ILRuntime.Other;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

internal interface IDelegateAdapter
{
	Type NativeDelegateType { get; }

	Delegate Delegate { get; }

	IDelegateAdapter Next { get; }

	ILTypeInstance Instance { get; }

	ILMethod Method { get; }

	bool IsClone { get; }

	unsafe StackObject* ILInvoke(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack);

	IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method);

	IDelegateAdapter Clone();

	Delegate GetConvertor(Type type);

	void Combine(IDelegateAdapter adapter);

	void Combine(Delegate dele);

	void Remove(IDelegateAdapter adapter);

	void Remove(Delegate dele);

	bool Equals(IDelegateAdapter adapter);

	bool Equals(Delegate dele);
}
