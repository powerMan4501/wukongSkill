using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.LinkedAnimGraphReference", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FLinkedAnimGraphReference
{
	private static bool FLinkedAnimGraphReference_IsValid;

	private static int FLinkedAnimGraphReference_StructSize;

	public FLinkedAnimGraphReference Copy()
	{
		return this;
	}

	public static FLinkedAnimGraphReference FromNative(IntPtr nativeBuffer)
	{
		return new FLinkedAnimGraphReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLinkedAnimGraphReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLinkedAnimGraphReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLinkedAnimGraphReference(nativeBuffer + arrayIndex * FLinkedAnimGraphReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLinkedAnimGraphReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLinkedAnimGraphReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLinkedAnimGraphReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.LinkedAnimGraphReference");
		}
	}

	public FLinkedAnimGraphReference(IntPtr nativeStruct)
	{
		if (!FLinkedAnimGraphReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.LinkedAnimGraphReference");
		}
	}

	static FLinkedAnimGraphReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLinkedAnimGraphReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLinkedAnimGraphReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.LinkedAnimGraphReference");
		FLinkedAnimGraphReference_StructSize = NativeReflection.GetStructSize(intPtr);
		FLinkedAnimGraphReference_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.LinkedAnimGraphReference", FLinkedAnimGraphReference_IsValid);
	}
}
