using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.SubobjectDataInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SubobjectDataInterface.SubobjectData", "SubobjectDataInterface", UnrealModuleType.Engine)]
public struct FSubobjectData
{
	private static bool FSubobjectData_IsValid;

	private static int FSubobjectData_StructSize;

	public FSubobjectData Copy()
	{
		return this;
	}

	public static FSubobjectData FromNative(IntPtr nativeBuffer)
	{
		return new FSubobjectData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubobjectData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubobjectData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubobjectData(nativeBuffer + arrayIndex * FSubobjectData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubobjectData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubobjectData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubobjectData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.SubobjectData");
		}
	}

	public FSubobjectData(IntPtr nativeStruct)
	{
		if (!FSubobjectData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.SubobjectData");
		}
	}

	static FSubobjectData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubobjectData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubobjectData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SubobjectDataInterface.SubobjectData");
		FSubobjectData_StructSize = NativeReflection.GetStructSize(intPtr);
		FSubobjectData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SubobjectDataInterface.SubobjectData", FSubobjectData_IsValid);
	}
}
