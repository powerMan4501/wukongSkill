using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[UMetaPath("/Script/Engine.AnimNode_CustomProperty", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_CustomProperty
{
	private static bool FAnimNode_CustomProperty_IsValid;

	private static int FAnimNode_CustomProperty_StructSize;

	public FAnimNode_CustomProperty Copy()
	{
		return this;
	}

	public static FAnimNode_CustomProperty FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_CustomProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_CustomProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_CustomProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_CustomProperty(nativeBuffer + arrayIndex * FAnimNode_CustomProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_CustomProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_CustomProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_CustomProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_CustomProperty");
		}
	}

	public FAnimNode_CustomProperty(IntPtr nativeStruct)
	{
		if (!FAnimNode_CustomProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_CustomProperty");
		}
	}

	static FAnimNode_CustomProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_CustomProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_CustomProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_CustomProperty");
		FAnimNode_CustomProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_CustomProperty_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_CustomProperty", FAnimNode_CustomProperty_IsValid);
	}
}
