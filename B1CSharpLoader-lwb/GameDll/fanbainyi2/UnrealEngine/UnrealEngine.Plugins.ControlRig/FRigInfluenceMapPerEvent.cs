using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigInfluenceMapPerEvent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigInfluenceMapPerEvent
{
	private static bool FRigInfluenceMapPerEvent_IsValid;

	private static int FRigInfluenceMapPerEvent_StructSize;

	public FRigInfluenceMapPerEvent Copy()
	{
		return this;
	}

	public static FRigInfluenceMapPerEvent FromNative(IntPtr nativeBuffer)
	{
		return new FRigInfluenceMapPerEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigInfluenceMapPerEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigInfluenceMapPerEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigInfluenceMapPerEvent(nativeBuffer + arrayIndex * FRigInfluenceMapPerEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigInfluenceMapPerEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigInfluenceMapPerEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigInfluenceMapPerEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigInfluenceMapPerEvent");
		}
	}

	public FRigInfluenceMapPerEvent(IntPtr nativeStruct)
	{
		if (!FRigInfluenceMapPerEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigInfluenceMapPerEvent");
		}
	}

	static FRigInfluenceMapPerEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigInfluenceMapPerEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigInfluenceMapPerEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigInfluenceMapPerEvent");
		FRigInfluenceMapPerEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigInfluenceMapPerEvent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigInfluenceMapPerEvent", FRigInfluenceMapPerEvent_IsValid);
	}
}
