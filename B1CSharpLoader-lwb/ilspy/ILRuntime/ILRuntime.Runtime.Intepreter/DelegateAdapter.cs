using System;
using System.Collections.Generic;
using System.Text;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Other;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

internal abstract class DelegateAdapter : ILTypeInstance, IDelegateAdapter
{
	protected ILMethod method;

	protected ILTypeInstance instance;

	protected ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private Dictionary<Type, Delegate> converters;

	private IDelegateAdapter next;

	protected bool isClone;

	public abstract Delegate Delegate { get; }

	public abstract Type NativeDelegateType { get; }

	public IDelegateAdapter Next => next;

	public ILTypeInstance Instance => instance;

	public ILMethod Method => method;

	public override bool IsValueType => false;

	public bool IsClone => isClone;

	protected DelegateAdapter()
	{
	}

	protected DelegateAdapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
	{
		this.appdomain = appdomain;
		this.instance = instance;
		this.method = method;
		base.CLRInstance = this;
	}

	protected unsafe InvocationContext BeginInvoke()
	{
		InvocationContext result = appdomain.BeginInvoke(method);
		*result.ESP = default(StackObject);
		result.ESP++;
		return result;
	}

	public unsafe StackObject* ILInvoke(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* ebp = esp;
		esp = ILInvokeSub(intp, esp, mStack);
		return ClearStack(intp, esp, ebp, mStack);
	}

	private unsafe StackObject* ILInvokeSub(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* ptr = esp;
		if (method.HasThis)
		{
			esp = ILIntepreter.PushObject(esp, mStack, instance);
		}
		int num = method.ParameterCount;
		if (method.IsExtend && instance != null)
		{
			esp = ILIntepreter.PushObject(esp, mStack, instance);
			num--;
		}
		bool shouldUseRegisterVM = method.ShouldUseRegisterVM;
		for (int num2 = num; num2 > 0; num2--)
		{
			intp.CopyToStack(esp, Minus(ptr, num2), mStack);
			if (esp->ObjectType < ObjectTypes.Object && shouldUseRegisterVM)
			{
				mStack.Add(null);
			}
			esp++;
		}
		bool unhandledException;
		StackObject* ptr2 = ((!shouldUseRegisterVM) ? intp.Execute(method, esp, out unhandledException) : intp.ExecuteR(method, esp, out unhandledException));
		if (next != null)
		{
			if (method.ReturnType != appdomain.VoidType)
			{
				intp.Free(ptr2 - 1);
			}
			ptr2 = ((DelegateAdapter)next).ILInvokeSub(intp, ptr, mStack);
		}
		return ptr2;
	}

	private unsafe StackObject* ClearStack(ILIntepreter intp, StackObject* esp, StackObject* ebp, UncheckedList<object> mStack)
	{
		int num = method.ParameterCount;
		if (method.IsExtend && instance != null)
		{
			num--;
		}
		object obj = null;
		StackObject stackObject = StackObject.Null;
		bool flag = method.ReturnType != appdomain.VoidType;
		if (flag)
		{
			StackObject* ptr = esp - 1;
			stackObject = *ptr;
			if (ptr->ObjectType >= ObjectTypes.Object)
			{
				obj = mStack[ptr->Value];
				if (obj == null)
				{
					stackObject.ObjectType = ObjectTypes.Null;
					stackObject.Value = -1;
					stackObject.ValueLow = 0;
				}
				intp.Free(ptr);
			}
		}
		for (int i = 1; i <= num; i++)
		{
			intp.Free(ebp - i);
		}
		StackObject* ptr2 = Minus(ebp, num + 1);
		intp.Free(ptr2);
		if (flag)
		{
			*ptr2 = stackObject;
			if (obj != null)
			{
				ptr2->Value = mStack.Count;
				mStack.Add(obj);
			}
			ptr2++;
		}
		return ptr2;
	}

	public abstract IDelegateAdapter Instantiate(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method);

	public new abstract IDelegateAdapter Clone();

	public virtual void Combine(IDelegateAdapter adapter)
	{
		if (next != null)
		{
			next.Combine(adapter);
		}
		else
		{
			next = adapter;
		}
	}

	public abstract void Combine(Delegate dele);

	public virtual void Remove(IDelegateAdapter adapter)
	{
		if (next != null)
		{
			if (next.Equals(adapter))
			{
				next = ((DelegateAdapter)next).next;
			}
			else
			{
				next.Remove(adapter);
			}
		}
	}

	public abstract void Remove(Delegate dele);

	public virtual bool Equals(IDelegateAdapter adapter)
	{
		if (adapter is DelegateAdapter)
		{
			DelegateAdapter delegateAdapter = (DelegateAdapter)adapter;
			if (instance == delegateAdapter.instance)
			{
				return method == delegateAdapter.method;
			}
			return false;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is DelegateAdapter)
		{
			DelegateAdapter delegateAdapter = (DelegateAdapter)obj;
			if (instance == delegateAdapter.instance)
			{
				return method == delegateAdapter.method;
			}
			return false;
		}
		return false;
	}

	public virtual bool Equals(Delegate dele)
	{
		return Delegate == dele;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		return method.ToString();
	}

	public override bool CanAssignTo(IType type)
	{
		if (type.IsDelegate)
		{
			int num = (this.method.IsExtend ? (this.method.ParameterCount - 1) : this.method.ParameterCount);
			IMethod method = type.GetMethod("Invoke", num);
			if (method == null)
			{
				return false;
			}
			IType type2 = method.ReturnType;
			if (method.ReturnType != appdomain.VoidType && type.IsGenericInstance)
			{
				type2 = type.GenericArguments[method.ParameterCount].Value;
			}
			if (method.IsDelegateInvoke)
			{
				if (method.ParameterCount == num && type2 == this.method.ReturnType)
				{
					for (int i = 0; i < method.ParameterCount; i++)
					{
						int index = (this.method.IsExtend ? (i + 1) : i);
						if (method.Parameters[i] != this.method.Parameters[index] && (!(method is CLRMethod) || method.Parameters[i].TypeForCLR != this.method.Parameters[index].TypeForCLR))
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public Delegate GetConvertor(Type type)
	{
		if (converters == null)
		{
			converters = new Dictionary<Type, Delegate>(new ByReferenceKeyComparer<Type>());
		}
		if (converters.TryGetValue(type, out var value))
		{
			return value;
		}
		value = appdomain.DelegateManager.ConvertToDelegate(type, this);
		converters[type] = value;
		return value;
	}

	private unsafe StackObject* Minus(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a - (ulong)(sizeof(StackObject) * b));
	}

	public static void ThrowAdapterNotFound(IMethod method)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Cannot find Delegate Adapter for:");
		stringBuilder.Append(method.ToString());
		if (method.ReturnType.Name != "Void" || method.ParameterCount > 0)
		{
			stringBuilder.AppendLine(", Please add following code:");
			string clsName;
			string realClsName;
			bool isByRef;
			if (method.ReturnType.Name == "Void")
			{
				stringBuilder.Append("appdomain.DelegateManager.RegisterMethodDelegate<");
				bool flag = true;
				foreach (IType parameter in method.Parameters)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						stringBuilder.Append(", ");
					}
					parameter.TypeForCLR.GetClassName(out clsName, out realClsName, out isByRef);
					stringBuilder.Append(realClsName);
				}
				stringBuilder.AppendLine(">();");
			}
			else
			{
				stringBuilder.Append("appdomain.DelegateManager.RegisterFunctionDelegate<");
				bool flag2 = true;
				foreach (IType parameter2 in method.Parameters)
				{
					if (flag2)
					{
						flag2 = false;
					}
					else
					{
						stringBuilder.Append(", ");
					}
					parameter2.TypeForCLR.GetClassName(out clsName, out realClsName, out isByRef);
					stringBuilder.Append(realClsName);
				}
				if (!flag2)
				{
					stringBuilder.Append(", ");
				}
				method.ReturnType.TypeForCLR.GetClassName(out clsName, out realClsName, out isByRef);
				stringBuilder.Append(realClsName);
				stringBuilder.AppendLine(">();");
			}
		}
		throw new KeyNotFoundException(stringBuilder.ToString());
	}
}
