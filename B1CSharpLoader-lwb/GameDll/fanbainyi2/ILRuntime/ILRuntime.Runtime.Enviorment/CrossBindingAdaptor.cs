using System;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

public abstract class CrossBindingAdaptor : IType
{
	private IType type;

	public abstract Type BaseCLRType { get; }

	public virtual Type[] BaseCLRTypes => null;

	public abstract Type AdaptorType { get; }

	internal IType RuntimeType
	{
		get
		{
			return type;
		}
		set
		{
			type = value;
		}
	}

	public bool IsGenericInstance => type.IsGenericInstance;

	public KeyValuePair<string, IType>[] GenericArguments => type.GenericArguments;

	public Type TypeForCLR => type.TypeForCLR;

	public IType ByRefType => type.ByRefType;

	public IType ArrayType => type.ArrayType;

	public string FullName => type.FullName;

	public string Name => type.Name;

	public bool IsValueType => type.IsValueType;

	public bool IsPrimitive => type.IsPrimitive;

	public bool IsEnum => type.IsEnum;

	public bool IsDelegate => type.IsDelegate;

	public AppDomain AppDomain => type.AppDomain;

	public Type ReflectionType => type.ReflectionType;

	public IType BaseType => type.BaseType;

	public IType[] Implements => type.Implements;

	public bool HasGenericParameter => type.HasGenericParameter;

	public bool IsGenericParameter => type.IsGenericParameter;

	public bool IsArray => false;

	public bool IsByRef => type.IsByRef;

	public bool IsInterface => type.IsInterface;

	public IType ElementType => type.ElementType;

	public int ArrayRank => type.ArrayRank;

	public int TotalFieldCount => type.TotalFieldCount;

	public StackObject DefaultObject => default(StackObject);

	public int TypeIndex => -1;

	public abstract object CreateCLRInstance(AppDomain appdomain, ILTypeInstance instance);

	public IMethod GetMethod(string name, int paramCount, bool declaredOnly = false)
	{
		return type.GetMethod(name, paramCount, declaredOnly);
	}

	public IMethod GetMethod(string name, List<IType> param, IType[] genericArguments, IType returnType = null, bool declaredOnly = false)
	{
		return type.GetMethod(name, param, genericArguments, returnType, declaredOnly);
	}

	public List<IMethod> GetMethods()
	{
		return type.GetMethods();
	}

	public int GetFieldIndex(object token)
	{
		return type.GetFieldIndex(token);
	}

	public IMethod GetConstructor(List<IType> param)
	{
		return type.GetConstructor(param);
	}

	public bool CanAssignTo(IType type)
	{
		bool flag = false;
		if (BaseType != null)
		{
			flag = BaseType.CanAssignTo(type);
		}
		IType[] implements = Implements;
		if (!flag && implements != null)
		{
			for (int i = 0; i < implements.Length; i++)
			{
				flag = implements[i].CanAssignTo(type);
				if (flag)
				{
					return true;
				}
			}
		}
		return flag;
	}

	public IType MakeGenericInstance(KeyValuePair<string, IType>[] genericArguments)
	{
		return type.MakeGenericInstance(genericArguments);
	}

	public IType MakeByRefType()
	{
		return type.MakeByRefType();
	}

	public IType MakeArrayType(int rank)
	{
		return type.MakeArrayType(rank);
	}

	public IType FindGenericArgument(string key)
	{
		return type.FindGenericArgument(key);
	}

	public IType ResolveGenericType(IType contextType)
	{
		return type.ResolveGenericType(contextType);
	}

	public IMethod GetVirtualMethod(IMethod method)
	{
		return type.GetVirtualMethod(method);
	}

	public void GetValueTypeSize(out int fieldCout, out int managedCount)
	{
		type.GetValueTypeSize(out fieldCout, out managedCount);
	}
}
