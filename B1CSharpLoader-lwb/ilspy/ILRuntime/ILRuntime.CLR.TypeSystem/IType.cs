using System;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.CLR.TypeSystem;

public interface IType
{
	bool IsGenericInstance { get; }

	KeyValuePair<string, IType>[] GenericArguments { get; }

	Type TypeForCLR { get; }

	Type ReflectionType { get; }

	IType BaseType { get; }

	IType[] Implements { get; }

	IType ByRefType { get; }

	IType ArrayType { get; }

	string FullName { get; }

	string Name { get; }

	bool IsArray { get; }

	int ArrayRank { get; }

	bool IsValueType { get; }

	bool IsDelegate { get; }

	bool IsPrimitive { get; }

	bool IsEnum { get; }

	bool IsByRef { get; }

	bool IsInterface { get; }

	IType ElementType { get; }

	bool HasGenericParameter { get; }

	bool IsGenericParameter { get; }

	StackObject DefaultObject { get; }

	int TypeIndex { get; }

	ILRuntime.Runtime.Enviorment.AppDomain AppDomain { get; }

	int TotalFieldCount { get; }

	IMethod GetMethod(string name, int paramCount, bool declaredOnly = false);

	IMethod GetMethod(string name, List<IType> param, IType[] genericArguments, IType returnType = null, bool declaredOnly = false);

	IMethod GetVirtualMethod(IMethod method);

	List<IMethod> GetMethods();

	int GetFieldIndex(object token);

	IMethod GetConstructor(List<IType> param);

	bool CanAssignTo(IType type);

	IType MakeGenericInstance(KeyValuePair<string, IType>[] genericArguments);

	IType MakeByRefType();

	IType MakeArrayType(int rank);

	IType FindGenericArgument(string key);

	IType ResolveGenericType(IType contextType);

	void GetValueTypeSize(out int fieldCout, out int managedCount);
}
