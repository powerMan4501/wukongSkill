using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.TreeSMLodInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FTreeSMLodInfo
{
	private static bool FTreeSMLodInfo_IsValid;

	private static int FTreeSMLodInfo_StructSize;

	public FTreeSMLodInfo Copy()
	{
		return this;
	}

	public static FTreeSMLodInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTreeSMLodInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTreeSMLodInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTreeSMLodInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTreeSMLodInfo(nativeBuffer + arrayIndex * FTreeSMLodInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTreeSMLodInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTreeSMLodInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTreeSMLodInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.TreeSMLodInfo");
		}
	}

	public FTreeSMLodInfo(IntPtr nativeStruct)
	{
		if (!FTreeSMLodInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.TreeSMLodInfo");
		}
	}

	static FTreeSMLodInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTreeSMLodInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTreeSMLodInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.TreeSMLodInfo");
		FTreeSMLodInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FTreeSMLodInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.TreeSMLodInfo", FTreeSMLodInfo_IsValid);
	}
}
