using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigInfluenceMap", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigInfluenceMap
{
	private static bool FRigInfluenceMap_IsValid;

	private static int FRigInfluenceMap_StructSize;

	public FRigInfluenceMap Copy()
	{
		return this;
	}

	public static FRigInfluenceMap FromNative(IntPtr nativeBuffer)
	{
		return new FRigInfluenceMap(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigInfluenceMap value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigInfluenceMap FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigInfluenceMap(nativeBuffer + arrayIndex * FRigInfluenceMap_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigInfluenceMap value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigInfluenceMap_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigInfluenceMap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigInfluenceMap");
		}
	}

	public FRigInfluenceMap(IntPtr nativeStruct)
	{
		if (!FRigInfluenceMap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigInfluenceMap");
		}
	}

	static FRigInfluenceMap()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigInfluenceMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigInfluenceMap));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigInfluenceMap");
		FRigInfluenceMap_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigInfluenceMap_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigInfluenceMap", FRigInfluenceMap_IsValid);
	}
}
