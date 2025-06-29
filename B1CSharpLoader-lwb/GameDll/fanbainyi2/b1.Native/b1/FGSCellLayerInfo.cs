using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSCellLayerInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FGSCellLayerInfo
{
	private static bool FGSCellLayerInfo_IsValid;

	private static int FGSCellLayerInfo_StructSize;

	public FGSCellLayerInfo Copy()
	{
		return this;
	}

	public static FGSCellLayerInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSCellLayerInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCellLayerInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCellLayerInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCellLayerInfo(nativeBuffer + arrayIndex * FGSCellLayerInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCellLayerInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSCellLayerInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSCellLayerInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSCellLayerInfo");
		}
	}

	public FGSCellLayerInfo(IntPtr nativeStruct)
	{
		if (!FGSCellLayerInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSCellLayerInfo");
		}
	}

	static FGSCellLayerInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSCellLayerInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCellLayerInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.GSCellLayerInfo");
		FGSCellLayerInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSCellLayerInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.GSCellLayerInfo", FGSCellLayerInfo_IsValid);
	}
}
