using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct ICppStructOps
{
	public IntPtr Address;

	public bool IsValid => Address != IntPtr.Zero;

	public bool HasNoopConstructor => Native_ICppStructOps.HasNoopConstructor(Address);

	public bool HasZeroConstructor => Native_ICppStructOps.HasZeroConstructor(Address);

	public bool HasDestructor => Native_ICppStructOps.HasDestructor(Address);

	public int Size => Native_ICppStructOps.GetSize(Address);

	public int Alignment => Native_ICppStructOps.GetAlignment(Address);

	public bool IsPlainOldData => Native_ICppStructOps.IsPlainOldData(Address);

	public bool HasCopy => Native_ICppStructOps.HasCopy(Address);

	public bool HasIdentical => Native_ICppStructOps.HasIdentical(Address);

	public bool HasGetTypeHash => Native_ICppStructOps.HasGetTypeHash(Address);

	public EPropertyFlags ComputedPropertyFlags => (EPropertyFlags)Native_ICppStructOps.GetComputedPropertyFlags(Address);

	public bool IsAbstract => Native_ICppStructOps.IsAbstract(Address);

	public ICppStructOps(IntPtr address)
	{
		Address = address;
	}

	public void Construct(IntPtr dest)
	{
		Native_ICppStructOps.Construct(Address, dest);
	}

	public void Destruct(IntPtr dest)
	{
		Native_ICppStructOps.Destruct(Address, dest);
	}

	public bool Copy(IntPtr dest, IntPtr src, int arrayDim)
	{
		return Native_ICppStructOps.Copy(Address, dest, src, arrayDim);
	}

	public bool Identical(IntPtr a, IntPtr b, uint portFlags, out bool outResult)
	{
		csbool outResult2;
		bool result = Native_ICppStructOps.Identical(Address, a, b, portFlags, out outResult2);
		outResult = outResult2;
		return result;
	}

	public uint GetTypeHash(IntPtr src)
	{
		return Native_ICppStructOps.GetTypeHash(Address, src);
	}
}
