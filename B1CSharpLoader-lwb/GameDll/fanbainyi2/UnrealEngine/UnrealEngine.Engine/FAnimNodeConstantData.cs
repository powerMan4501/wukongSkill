using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNodeConstantData", "Engine", UnrealModuleType.Engine)]
public struct FAnimNodeConstantData
{
	private static bool FAnimNodeConstantData_IsValid;

	private static int FAnimNodeConstantData_StructSize;

	public FAnimNodeConstantData Copy()
	{
		return this;
	}

	public static FAnimNodeConstantData FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNodeConstantData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNodeConstantData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNodeConstantData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNodeConstantData(nativeBuffer + arrayIndex * FAnimNodeConstantData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNodeConstantData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNodeConstantData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNodeConstantData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNodeConstantData");
		}
	}

	public FAnimNodeConstantData(IntPtr nativeStruct)
	{
		if (!FAnimNodeConstantData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNodeConstantData");
		}
	}

	static FAnimNodeConstantData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNodeConstantData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNodeConstantData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNodeConstantData");
		FAnimNodeConstantData_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNodeConstantData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNodeConstantData", FAnimNodeConstantData_IsValid);
	}
}
