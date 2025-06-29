using System;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Enviorment;

public class CrossBindingMethodInfo<T, T2, T3, T4, T5> : CrossBindingMethodInfo
{
	public delegate void InvocationDelegate(ILTypeInstance instance, T arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	private static InvocationTypes[] piTypes = new InvocationTypes[5]
	{
		InvocationContext.GetInvocationType<T>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<T3>(),
		InvocationContext.GetInvocationType<T4>(),
		InvocationContext.GetInvocationType<T5>()
	};

	private static Type[] pTypes = new Type[5]
	{
		typeof(T),
		typeof(T2),
		typeof(T3),
		typeof(T4),
		typeof(T5)
	};

	protected override Type ReturnType => null;

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingMethodInfo(string name)
		: base(name)
	{
	}

	public void Invoke(ILTypeInstance instance, T arg, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
		EnsureMethod(instance);
		if (method == null)
		{
			return;
		}
		invoking = true;
		try
		{
			if (DoInvoke != null)
			{
				DoInvoke(instance, arg, arg2, arg3, arg4, arg5);
				return;
			}
			using InvocationContext invocationContext = domain.BeginInvoke(method);
			invocationContext.PushObject(instance);
			invocationContext.PushParameter(piTypes[0], arg);
			invocationContext.PushParameter(piTypes[1], arg2);
			invocationContext.PushParameter(piTypes[2], arg3);
			invocationContext.PushParameter(piTypes[3], arg4);
			invocationContext.PushParameter(piTypes[4], arg5);
			invocationContext.Invoke();
		}
		finally
		{
			invoking = false;
		}
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingMethodInfo<T, T2, T3, T4> : CrossBindingMethodInfo
{
	public delegate void InvocationDelegate(ILTypeInstance instance, T arg, T2 arg2, T3 arg3, T4 arg4);

	private static InvocationTypes[] piTypes = new InvocationTypes[4]
	{
		InvocationContext.GetInvocationType<T>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<T3>(),
		InvocationContext.GetInvocationType<T4>()
	};

	private static Type[] pTypes = new Type[4]
	{
		typeof(T),
		typeof(T2),
		typeof(T3),
		typeof(T4)
	};

	protected override Type ReturnType => null;

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingMethodInfo(string name)
		: base(name)
	{
	}

	public void Invoke(ILTypeInstance instance, T arg, T2 arg2, T3 arg3, T4 arg4)
	{
		EnsureMethod(instance);
		if (method == null)
		{
			return;
		}
		invoking = true;
		try
		{
			if (DoInvoke != null)
			{
				DoInvoke(instance, arg, arg2, arg3, arg4);
				return;
			}
			using InvocationContext invocationContext = domain.BeginInvoke(method);
			invocationContext.PushObject(instance);
			invocationContext.PushParameter(piTypes[0], arg);
			invocationContext.PushParameter(piTypes[1], arg2);
			invocationContext.PushParameter(piTypes[2], arg3);
			invocationContext.PushParameter(piTypes[3], arg4);
			invocationContext.Invoke();
		}
		finally
		{
			invoking = false;
		}
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingMethodInfo<T, T2, T3> : CrossBindingMethodInfo
{
	public delegate void InvocationDelegate(ILTypeInstance instance, T arg, T2 arg2, T3 arg3);

	private static InvocationTypes[] piTypes = new InvocationTypes[3]
	{
		InvocationContext.GetInvocationType<T>(),
		InvocationContext.GetInvocationType<T2>(),
		InvocationContext.GetInvocationType<T3>()
	};

	private static Type[] pTypes = new Type[3]
	{
		typeof(T),
		typeof(T2),
		typeof(T3)
	};

	protected override Type ReturnType => null;

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingMethodInfo(string name)
		: base(name)
	{
	}

	public void Invoke(ILTypeInstance instance, T arg, T2 arg2, T3 arg3)
	{
		EnsureMethod(instance);
		if (method == null)
		{
			return;
		}
		invoking = true;
		try
		{
			if (DoInvoke != null)
			{
				DoInvoke(instance, arg, arg2, arg3);
				return;
			}
			using InvocationContext invocationContext = domain.BeginInvoke(method);
			invocationContext.PushObject(instance);
			invocationContext.PushParameter(piTypes[0], arg);
			invocationContext.PushParameter(piTypes[1], arg2);
			invocationContext.PushParameter(piTypes[2], arg3);
			invocationContext.Invoke();
		}
		finally
		{
			invoking = false;
		}
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingMethodInfo<T, T2> : CrossBindingMethodInfo
{
	public delegate void InvocationDelegate(ILTypeInstance instance, T arg, T2 arg2);

	private static InvocationTypes[] piTypes = new InvocationTypes[2]
	{
		InvocationContext.GetInvocationType<T>(),
		InvocationContext.GetInvocationType<T2>()
	};

	private static Type[] pTypes = new Type[2]
	{
		typeof(T),
		typeof(T2)
	};

	protected override Type ReturnType => null;

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingMethodInfo(string name)
		: base(name)
	{
	}

	public void Invoke(ILTypeInstance instance, T arg, T2 arg2)
	{
		EnsureMethod(instance);
		if (method == null)
		{
			return;
		}
		invoking = true;
		try
		{
			if (DoInvoke != null)
			{
				DoInvoke(instance, arg, arg2);
				return;
			}
			using InvocationContext invocationContext = domain.BeginInvoke(method);
			invocationContext.PushObject(instance);
			invocationContext.PushParameter(piTypes[0], arg);
			invocationContext.PushParameter(piTypes[1], arg2);
			invocationContext.Invoke();
		}
		finally
		{
			invoking = false;
		}
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingMethodInfo<T> : CrossBindingMethodInfo
{
	public delegate void InvocationDelegate(ILTypeInstance instance, T arg);

	private static InvocationTypes piTypes = InvocationContext.GetInvocationType<T>();

	private static Type[] pTypes = new Type[1] { typeof(T) };

	protected override Type ReturnType => null;

	protected override Type[] Parameters => pTypes;

	public InvocationDelegate DoInvoke { get; set; }

	public CrossBindingMethodInfo(string name)
		: base(name)
	{
	}

	public void Invoke(ILTypeInstance instance, T arg)
	{
		EnsureMethod(instance);
		if (method == null)
		{
			return;
		}
		invoking = true;
		try
		{
			if (DoInvoke != null)
			{
				DoInvoke(instance, arg);
				return;
			}
			using InvocationContext invocationContext = domain.BeginInvoke(method);
			invocationContext.PushObject(instance);
			invocationContext.PushParameter(piTypes, arg);
			invocationContext.Invoke();
		}
		finally
		{
			invoking = false;
		}
	}

	public override void Invoke(ILTypeInstance instance)
	{
		throw new NotSupportedException();
	}
}
public class CrossBindingMethodInfo
{
	protected AppDomain domain;

	protected IMethod method;

	private IMethod baseMethod;

	private bool methodGot;

	protected bool invoking;

	private static List<IType> emptyParam = new List<IType>();

	public string Name { get; private set; }

	protected virtual Type[] Parameters => null;

	protected virtual Type ReturnType => null;

	public CrossBindingMethodInfo(string name)
	{
		Name = name;
	}

	public bool CheckShouldInvokeBase(ILTypeInstance ins)
	{
		EnsureMethod(ins);
		if (method != null)
		{
			return invoking;
		}
		return true;
	}

	protected void EnsureMethod(ILTypeInstance ins)
	{
		if (!methodGot)
		{
			ILType type = ins.Type;
			domain = type.AppDomain;
			methodGot = true;
			List<IType> list = null;
			IType returnType = null;
			if (Parameters != null)
			{
				list = new List<IType>();
				Type[] parameters = Parameters;
				foreach (Type type2 in parameters)
				{
					if (type2.IsByRef)
					{
						IType type3 = domain.GetType(type2.GetElementType());
						list.Add(type3.MakeByRefType());
					}
					else
					{
						list.Add(domain.GetType(type2));
					}
				}
			}
			else
			{
				list = emptyParam;
			}
			if (ReturnType != null)
			{
				returnType = domain.GetType(ReturnType);
			}
			if (type.FirstCLRBaseType != null)
			{
				baseMethod = type.FirstCLRBaseType.BaseType.GetMethod(Name, list, null, returnType);
			}
			if (type.FirstCLRInterface != null)
			{
				IType[] implements = type.FirstCLRInterface.Implements;
				for (int j = 0; j < implements.Length; j++)
				{
					baseMethod = implements[j].GetMethod(Name, list, null, returnType);
					if (baseMethod != null)
					{
						break;
					}
				}
			}
			if (baseMethod == null)
			{
				method = type.GetMethod(Name, list, null, returnType);
			}
		}
		if (baseMethod != null)
		{
			method = ins.Type.GetVirtualMethod(baseMethod);
			if (method is CLRMethod)
			{
				method = null;
			}
		}
	}

	public virtual void Invoke(ILTypeInstance instance)
	{
		EnsureMethod(instance);
		if (method != null)
		{
			invoking = true;
			try
			{
				domain.Invoke(method, instance, null);
			}
			finally
			{
				invoking = false;
			}
		}
	}
}
