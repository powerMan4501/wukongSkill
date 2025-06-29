using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Enviorment;

public class DelegateManager
{
	private class DelegateMapNode
	{
		public IDelegateAdapter Adapter { get; set; }

		public Type[] ParameterTypes { get; set; }
	}

	private List<DelegateMapNode> methods = new List<DelegateMapNode>();

	private List<DelegateMapNode> functions = new List<DelegateMapNode>();

	private IDelegateAdapter zeroParamMethodAdapter = new MethodDelegateAdapter();

	private IDelegateAdapter dummyAdapter = new DummyDelegateAdapter();

	private Dictionary<Type, Func<Delegate, Delegate>> clrDelegates = new Dictionary<Type, Func<Delegate, Delegate>>(new ByReferenceKeyComparer<Type>());

	private Func<Delegate, Delegate> defaultConverter;

	private AppDomain appdomain;

	public DelegateManager(AppDomain appdomain)
	{
		this.appdomain = appdomain;
		defaultConverter = DefaultConverterStub;
	}

	private static Delegate DefaultConverterStub(Delegate dele)
	{
		return dele;
	}

	public static int GetDelegateHash<T>(T action)
	{
		if (action == null)
		{
			return 0;
		}
		if (action is Action action2)
		{
			return action2.Target.GetHashCode();
		}
		if (action is ILMethod iLMethod)
		{
			return iLMethod.GetHashCode();
		}
		if (action is DelegateAdapter delegateAdapter)
		{
			return delegateAdapter.Delegate.GetHashCode();
		}
		return 0;
	}

	public static string GetDelegateName<T>(T action)
	{
		if (action == null)
		{
			return string.Empty;
		}
		if (action is Action action2)
		{
			return action2.Target.ToString();
		}
		if (action is ILMethod iLMethod)
		{
			return iLMethod.ToString();
		}
		if (action is DelegateAdapter delegateAdapter)
		{
			return delegateAdapter.Delegate.ToString();
		}
		return string.Empty;
	}

	public void RegisterDelegateConvertor<T>(Func<Delegate, Delegate> action)
	{
		Type typeFromHandle = typeof(T);
		if (typeFromHandle.IsSubclassOf(typeof(Delegate)))
		{
			clrDelegates[typeFromHandle] = action;
			return;
		}
		throw new NotSupportedException();
	}

	public void RegisterMethodDelegate<T1>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new MethodDelegateAdapter<T1>();
		delegateMapNode.ParameterTypes = new Type[1] { typeof(T1) };
		methods.Add(delegateMapNode);
		RegisterDelegateConvertor<Action<T1>>(defaultConverter);
	}

	public void RegisterMethodDelegate<T1, T2>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new MethodDelegateAdapter<T1, T2>();
		delegateMapNode.ParameterTypes = new Type[2]
		{
			typeof(T1),
			typeof(T2)
		};
		methods.Add(delegateMapNode);
		RegisterDelegateConvertor<Action<T1, T2>>(defaultConverter);
	}

	public void RegisterMethodDelegate<T1, T2, T3>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new MethodDelegateAdapter<T1, T2, T3>();
		delegateMapNode.ParameterTypes = new Type[3]
		{
			typeof(T1),
			typeof(T2),
			typeof(T3)
		};
		methods.Add(delegateMapNode);
		RegisterDelegateConvertor<Action<T1, T2, T3>>(defaultConverter);
	}

	public void RegisterMethodDelegate<T1, T2, T3, T4>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4>();
		delegateMapNode.ParameterTypes = new Type[4]
		{
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4)
		};
		methods.Add(delegateMapNode);
		RegisterDelegateConvertor<Action<T1, T2, T3, T4>>(defaultConverter);
	}

	public void RegisterMethodDelegate<T1, T2, T3, T4, T5>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4, T5>();
		delegateMapNode.ParameterTypes = new Type[5]
		{
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4),
			typeof(T5)
		};
		methods.Add(delegateMapNode);
		RegisterDelegateConvertor<Action<T1, T2, T3, T4, T5>>(defaultConverter);
	}

	public void RegisterFunctionDelegate<TResult>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new FunctionDelegateAdapter<TResult>();
		delegateMapNode.ParameterTypes = new Type[1] { typeof(TResult) };
		functions.Add(delegateMapNode);
		RegisterDelegateConvertor<Func<TResult>>(defaultConverter);
	}

	public void RegisterFunctionDelegate<T1, TResult>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new FunctionDelegateAdapter<T1, TResult>();
		delegateMapNode.ParameterTypes = new Type[2]
		{
			typeof(T1),
			typeof(TResult)
		};
		functions.Add(delegateMapNode);
		RegisterDelegateConvertor<Func<T1, TResult>>(defaultConverter);
	}

	public void RegisterFunctionDelegate<T1, T2, TResult>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new FunctionDelegateAdapter<T1, T2, TResult>();
		delegateMapNode.ParameterTypes = new Type[3]
		{
			typeof(T1),
			typeof(T2),
			typeof(TResult)
		};
		functions.Add(delegateMapNode);
		RegisterDelegateConvertor<Func<T1, T2, TResult>>(defaultConverter);
	}

	public void RegisterFunctionDelegate<T1, T2, T3, TResult>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new FunctionDelegateAdapter<T1, T2, T3, TResult>();
		delegateMapNode.ParameterTypes = new Type[4]
		{
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(TResult)
		};
		functions.Add(delegateMapNode);
		RegisterDelegateConvertor<Func<T1, T2, T3, TResult>>(defaultConverter);
	}

	public void RegisterFunctionDelegate<T1, T2, T3, T4, TResult>()
	{
		DelegateMapNode delegateMapNode = new DelegateMapNode();
		delegateMapNode.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, TResult>();
		delegateMapNode.ParameterTypes = new Type[5]
		{
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4),
			typeof(TResult)
		};
		functions.Add(delegateMapNode);
		RegisterDelegateConvertor<Func<T1, T2, T3, T4, TResult>>(defaultConverter);
	}

	internal Delegate ConvertToDelegate(Type clrDelegateType, IDelegateAdapter adapter)
	{
		if (adapter is DummyDelegateAdapter)
		{
			DelegateAdapter.ThrowAdapterNotFound(adapter.Method);
			return null;
		}
		if (clrDelegates.TryGetValue(clrDelegateType, out var value))
		{
			return value(adapter.Delegate);
		}
		StringBuilder stringBuilder = new StringBuilder();
		clrDelegateType.GetClassName(out var clsName, out var realClsName, out var isByRef);
		stringBuilder.AppendLine("Cannot find convertor for " + realClsName);
		stringBuilder.AppendLine("Please add following code:");
		stringBuilder.Append("appdomain.DelegateManager.RegisterDelegateConvertor<");
		stringBuilder.Append(realClsName);
		stringBuilder.AppendLine(">((act) =>");
		stringBuilder.AppendLine("{");
		stringBuilder.Append("    return new ");
		stringBuilder.Append(realClsName);
		stringBuilder.Append("((");
		MethodInfo method = clrDelegateType.GetMethod("Invoke");
		bool flag = true;
		ParameterInfo[] parameters = method.GetParameters();
		foreach (ParameterInfo parameterInfo in parameters)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(parameterInfo.Name);
		}
		stringBuilder.AppendLine(") =>");
		stringBuilder.AppendLine("    {");
		if (method.ReturnType != appdomain.VoidType.TypeForCLR)
		{
			stringBuilder.Append("        return ((Func<");
			flag = true;
			parameters = method.GetParameters();
			foreach (ParameterInfo obj in parameters)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				obj.ParameterType.GetClassName(out clsName, out realClsName, out isByRef);
				stringBuilder.Append(realClsName);
			}
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			method.ReturnType.GetClassName(out clsName, out realClsName, out isByRef);
			stringBuilder.Append(realClsName);
		}
		else
		{
			stringBuilder.Append("        ((Action<");
			flag = true;
			parameters = method.GetParameters();
			foreach (ParameterInfo obj2 in parameters)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				obj2.ParameterType.GetClassName(out clsName, out realClsName, out isByRef);
				stringBuilder.Append(realClsName);
			}
		}
		stringBuilder.Append(">)act)(");
		flag = true;
		parameters = method.GetParameters();
		foreach (ParameterInfo parameterInfo2 in parameters)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(parameterInfo2.Name);
		}
		stringBuilder.AppendLine(");");
		stringBuilder.AppendLine("    });");
		stringBuilder.AppendLine("});");
		throw new KeyNotFoundException(stringBuilder.ToString());
	}

	internal IDelegateAdapter FindDelegateAdapter(CLRType type, ILTypeInstance ins, ILMethod ilMethod)
	{
		IDelegateAdapter delegateAdapter;
		if (ins != null)
		{
			delegateAdapter = ins.GetDelegateAdapter(ilMethod);
			if (delegateAdapter == null)
			{
				IMethod method = type.GetMethod("Invoke", ilMethod.ParameterCount);
				if (method == null && ilMethod.IsExtend)
				{
					method = type.GetMethod("Invoke", ilMethod.ParameterCount - 1);
				}
				delegateAdapter = appdomain.DelegateManager.FindDelegateAdapter(ins, ilMethod, method);
			}
		}
		else
		{
			if (ilMethod.DelegateAdapter == null)
			{
				IMethod method2 = type.GetMethod("Invoke", ilMethod.ParameterCount);
				ilMethod.DelegateAdapter = appdomain.DelegateManager.FindDelegateAdapter(null, ilMethod, method2);
			}
			delegateAdapter = ilMethod.DelegateAdapter;
		}
		return delegateAdapter;
	}

	internal IDelegateAdapter FindDelegateAdapter(ILTypeInstance instance, ILMethod ilMethod, IMethod method)
	{
		int parameterCount = method.ParameterCount;
		Type typeForCLR = method.ReturnType.TypeForCLR;
		IDelegateAdapter delegateAdapter;
		if (method.ReturnType == appdomain.VoidType)
		{
			if (parameterCount == 0)
			{
				delegateAdapter = zeroParamMethodAdapter.Instantiate(appdomain, instance, ilMethod);
				instance?.SetDelegateAdapter(ilMethod, delegateAdapter);
				return delegateAdapter;
			}
			foreach (DelegateMapNode method2 in methods)
			{
				Type[] parameterTypes = method2.ParameterTypes;
				if (parameterTypes.Length != parameterCount)
				{
					continue;
				}
				bool flag = true;
				for (int i = 0; i < parameterCount; i++)
				{
					if (parameterTypes[i] != method.Parameters[i].TypeForCLR)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					delegateAdapter = method2.Adapter.Instantiate(appdomain, instance, ilMethod);
					instance?.SetDelegateAdapter(ilMethod, delegateAdapter);
					return delegateAdapter;
				}
			}
		}
		else
		{
			foreach (DelegateMapNode function in functions)
			{
				Type[] parameterTypes2 = function.ParameterTypes;
				if (parameterTypes2.Length != parameterCount + 1)
				{
					continue;
				}
				bool flag2 = true;
				for (int j = 0; j < parameterCount; j++)
				{
					if (parameterTypes2[j] != method.Parameters[j].TypeForCLR)
					{
						flag2 = false;
						break;
					}
				}
				if (flag2 && typeForCLR == parameterTypes2[parameterCount])
				{
					delegateAdapter = function.Adapter.Instantiate(appdomain, instance, ilMethod);
					instance?.SetDelegateAdapter(ilMethod, delegateAdapter);
					return delegateAdapter;
				}
			}
		}
		delegateAdapter = dummyAdapter.Instantiate(appdomain, instance, ilMethod);
		instance?.SetDelegateAdapter(ilMethod, delegateAdapter);
		return delegateAdapter;
	}
}
