using System;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.CLR.TypeSystem;

internal class ILGenericParameterType : IType
{
	private string name;

	private bool isArray;

	private bool isByRef;

	private ILGenericParameterType arrayType;

	private ILGenericParameterType byrefType;

	private ILGenericParameterType elementType;

	public bool IsGenericInstance => false;

	public KeyValuePair<string, IType>[] GenericArguments => null;

	public bool HasGenericParameter => true;

	public bool IsGenericParameter
	{
		get
		{
			if (!isByRef)
			{
				return !isArray;
			}
			return false;
		}
	}

	public Type TypeForCLR => typeof(ILGenericParameterType);

	public string FullName => name;

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => null;

	public IType ByRefType => byrefType;

	public IType ArrayType => arrayType;

	public bool IsValueType
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public bool IsPrimitive => false;

	public bool IsEnum => false;

	public bool IsInterface => false;

	public string Name => name;

	public bool IsDelegate => false;

	public Type ReflectionType
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public IType BaseType => null;

	public bool IsArray => isArray;

	public bool IsByRef => isByRef;

	public IType ElementType => elementType;

	public int ArrayRank => 1;

	public IType[] Implements => null;

	public int TotalFieldCount => 0;

	public StackObject DefaultObject => default(StackObject);

	public int TypeIndex => -1;

	public ILGenericParameterType(string name)
	{
		this.name = name;
	}

	public IMethod GetMethod(string name, int paramCount, bool declaredOnly = false)
	{
		return null;
	}

	public IMethod GetMethod(string name, List<IType> param, IType[] genericArguments, IType returnType = null, bool declaredOnly = false)
	{
		return null;
	}

	public List<IMethod> GetMethods()
	{
		return null;
	}

	public IMethod GetConstructor(List<IType> param)
	{
		return null;
	}

	public bool CanAssignTo(IType type)
	{
		return false;
	}

	public IType MakeGenericInstance(KeyValuePair<string, IType>[] genericArguments)
	{
		return null;
	}

	public IType ResolveGenericType(IType contextType)
	{
		throw new NotImplementedException();
	}

	public int GetFieldIndex(object token)
	{
		return -1;
	}

	public IType FindGenericArgument(string key)
	{
		return null;
	}

	public IType MakeByRefType()
	{
		if (byrefType == null)
		{
			byrefType = new ILGenericParameterType(name + "&");
			byrefType.isByRef = true;
			byrefType.elementType = this;
		}
		return byrefType;
	}

	public IType MakeArrayType(int rank)
	{
		if (arrayType == null)
		{
			arrayType = new ILGenericParameterType(name + "[]");
			arrayType.isArray = true;
			arrayType.elementType = this;
		}
		return arrayType;
	}

	public IMethod GetVirtualMethod(IMethod method)
	{
		return method;
	}

	public void GetValueTypeSize(out int fieldCout, out int managedCount)
	{
		throw new NotImplementedException();
	}
}
