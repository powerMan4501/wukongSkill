using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[UMetaPath("/Script/Engine.AnimNode_Base", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_Base
{
	private static bool FAnimNode_Base_IsValid;

	private static int FAnimNode_Base_StructSize;

	public FAnimNode_Base Copy()
	{
		return this;
	}

	public static FAnimNode_Base FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Base(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Base value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Base FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Base(nativeBuffer + arrayIndex * FAnimNode_Base_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Base value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Base_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Base_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_Base");
		}
	}

	public FAnimNode_Base(IntPtr nativeStruct)
	{
		if (!FAnimNode_Base_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_Base");
		}
	}

	static FAnimNode_Base()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Base));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_Base");
		FAnimNode_Base_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_Base_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_Base", FAnimNode_Base_IsValid);
	}
}
