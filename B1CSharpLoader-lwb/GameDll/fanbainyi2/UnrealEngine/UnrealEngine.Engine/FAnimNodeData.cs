using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNodeData", "Engine", UnrealModuleType.Engine)]
public struct FAnimNodeData
{
	private static bool FAnimNodeData_IsValid;

	private static int FAnimNodeData_StructSize;

	public FAnimNodeData Copy()
	{
		return this;
	}

	public static FAnimNodeData FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNodeData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNodeData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNodeData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNodeData(nativeBuffer + arrayIndex * FAnimNodeData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNodeData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNodeData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNodeData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNodeData");
		}
	}

	public FAnimNodeData(IntPtr nativeStruct)
	{
		if (!FAnimNodeData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNodeData");
		}
	}

	static FAnimNodeData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNodeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNodeData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNodeData");
		FAnimNodeData_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNodeData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNodeData", FAnimNodeData_IsValid);
	}
}
