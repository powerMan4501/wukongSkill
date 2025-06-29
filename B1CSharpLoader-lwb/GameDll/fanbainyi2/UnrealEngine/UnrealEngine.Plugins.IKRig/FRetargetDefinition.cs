using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/IKRig.RetargetDefinition", "IKRig", UnrealModuleType.EnginePlugin)]
public struct FRetargetDefinition
{
	private static bool FRetargetDefinition_IsValid;

	private static int FRetargetDefinition_StructSize;

	public FRetargetDefinition Copy()
	{
		return this;
	}

	public static FRetargetDefinition FromNative(IntPtr nativeBuffer)
	{
		return new FRetargetDefinition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRetargetDefinition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRetargetDefinition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRetargetDefinition(nativeBuffer + arrayIndex * FRetargetDefinition_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRetargetDefinition value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRetargetDefinition_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRetargetDefinition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.RetargetDefinition");
		}
	}

	public FRetargetDefinition(IntPtr nativeStruct)
	{
		if (!FRetargetDefinition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.RetargetDefinition");
		}
	}

	static FRetargetDefinition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRetargetDefinition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRetargetDefinition));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/IKRig.RetargetDefinition");
		FRetargetDefinition_StructSize = NativeReflection.GetStructSize(intPtr);
		FRetargetDefinition_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/IKRig.RetargetDefinition", FRetargetDefinition_IsValid);
	}
}
