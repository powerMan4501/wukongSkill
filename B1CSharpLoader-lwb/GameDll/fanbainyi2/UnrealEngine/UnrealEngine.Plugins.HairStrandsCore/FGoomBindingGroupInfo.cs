using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GoomBindingGroupInfo", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FGoomBindingGroupInfo
{
	private static bool FGoomBindingGroupInfo_IsValid;

	private static int FGoomBindingGroupInfo_StructSize;

	public FGoomBindingGroupInfo Copy()
	{
		return this;
	}

	public static FGoomBindingGroupInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGoomBindingGroupInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGoomBindingGroupInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGoomBindingGroupInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGoomBindingGroupInfo(nativeBuffer + arrayIndex * FGoomBindingGroupInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGoomBindingGroupInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGoomBindingGroupInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGoomBindingGroupInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GoomBindingGroupInfo");
		}
	}

	public FGoomBindingGroupInfo(IntPtr nativeStruct)
	{
		if (!FGoomBindingGroupInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GoomBindingGroupInfo");
		}
	}

	static FGoomBindingGroupInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGoomBindingGroupInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGoomBindingGroupInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.GoomBindingGroupInfo");
		FGoomBindingGroupInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FGoomBindingGroupInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.GoomBindingGroupInfo", FGoomBindingGroupInfo_IsValid);
	}
}
