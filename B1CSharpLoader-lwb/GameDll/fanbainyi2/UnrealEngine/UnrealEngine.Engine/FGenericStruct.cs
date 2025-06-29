using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.GenericStruct", "Engine", UnrealModuleType.Engine)]
public struct FGenericStruct
{
	private static bool FGenericStruct_IsValid;

	private static int FGenericStruct_StructSize;

	public FGenericStruct Copy()
	{
		return this;
	}

	public static FGenericStruct FromNative(IntPtr nativeBuffer)
	{
		return new FGenericStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGenericStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGenericStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGenericStruct(nativeBuffer + arrayIndex * FGenericStruct_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGenericStruct value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGenericStruct_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGenericStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.GenericStruct");
		}
	}

	public FGenericStruct(IntPtr nativeStruct)
	{
		if (!FGenericStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.GenericStruct");
		}
	}

	static FGenericStruct()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGenericStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGenericStruct));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.GenericStruct");
		FGenericStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		FGenericStruct_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.GenericStruct", FGenericStruct_IsValid);
	}
}
