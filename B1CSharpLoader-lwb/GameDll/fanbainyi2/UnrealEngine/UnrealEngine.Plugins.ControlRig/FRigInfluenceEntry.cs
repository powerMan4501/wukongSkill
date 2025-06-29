using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigInfluenceEntry", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigInfluenceEntry
{
	private static bool FRigInfluenceEntry_IsValid;

	private static int FRigInfluenceEntry_StructSize;

	public FRigInfluenceEntry Copy()
	{
		return this;
	}

	public static FRigInfluenceEntry FromNative(IntPtr nativeBuffer)
	{
		return new FRigInfluenceEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigInfluenceEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigInfluenceEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigInfluenceEntry(nativeBuffer + arrayIndex * FRigInfluenceEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigInfluenceEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigInfluenceEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigInfluenceEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigInfluenceEntry");
		}
	}

	public FRigInfluenceEntry(IntPtr nativeStruct)
	{
		if (!FRigInfluenceEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigInfluenceEntry");
		}
	}

	static FRigInfluenceEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigInfluenceEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigInfluenceEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigInfluenceEntry");
		FRigInfluenceEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigInfluenceEntry_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigInfluenceEntry", FRigInfluenceEntry_IsValid);
	}
}
