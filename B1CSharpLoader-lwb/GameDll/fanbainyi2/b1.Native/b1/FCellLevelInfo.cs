using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.CellLevelInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FCellLevelInfo
{
	private static bool FCellLevelInfo_IsValid;

	private static int FCellLevelInfo_StructSize;

	public FCellLevelInfo Copy()
	{
		return this;
	}

	public static FCellLevelInfo FromNative(IntPtr nativeBuffer)
	{
		return new FCellLevelInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCellLevelInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCellLevelInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCellLevelInfo(nativeBuffer + arrayIndex * FCellLevelInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCellLevelInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCellLevelInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCellLevelInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.CellLevelInfo");
		}
	}

	public FCellLevelInfo(IntPtr nativeStruct)
	{
		if (!FCellLevelInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.CellLevelInfo");
		}
	}

	static FCellLevelInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCellLevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCellLevelInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.CellLevelInfo");
		FCellLevelInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FCellLevelInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.CellLevelInfo", FCellLevelInfo_IsValid);
	}
}
