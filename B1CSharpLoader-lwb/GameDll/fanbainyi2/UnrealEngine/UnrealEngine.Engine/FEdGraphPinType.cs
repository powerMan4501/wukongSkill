using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 268289)]
[BlueprintType]
[UMetaPath("/Script/Engine.EdGraphPinType", "Engine", UnrealModuleType.Engine)]
public struct FEdGraphPinType
{
	private static bool FEdGraphPinType_IsValid;

	private static int FEdGraphPinType_StructSize;

	public FEdGraphPinType Copy()
	{
		return this;
	}

	public static FEdGraphPinType FromNative(IntPtr nativeBuffer)
	{
		return new FEdGraphPinType(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEdGraphPinType value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEdGraphPinType FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEdGraphPinType(nativeBuffer + arrayIndex * FEdGraphPinType_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEdGraphPinType value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEdGraphPinType_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEdGraphPinType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.EdGraphPinType");
		}
	}

	public FEdGraphPinType(IntPtr nativeStruct)
	{
		if (!FEdGraphPinType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.EdGraphPinType");
		}
	}

	static FEdGraphPinType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEdGraphPinType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEdGraphPinType));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.EdGraphPinType");
		FEdGraphPinType_StructSize = NativeReflection.GetStructSize(intPtr);
		FEdGraphPinType_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.EdGraphPinType", FEdGraphPinType_IsValid);
	}
}
