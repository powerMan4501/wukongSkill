using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819986596uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUProjectileMovementComponent", "b1", UnrealModuleType.Game)]
public class UBGUProjectileMovementComponent : UProjectileMovementComponent
{
	private static bool ForceEnableSimulateWithoutBounce_IsValid;

	private static FFieldAddress ForceEnableSimulateWithoutBounce_PropertyAddress;

	private static int ForceEnableSimulateWithoutBounce_Offset;

	private static bool ComputeMoveDeltaOnClient_IsValid;

	private static FFieldAddress ComputeMoveDeltaOnClient_PropertyAddress;

	private static int ComputeMoveDeltaOnClient_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUProjectileMovementComponent:bForceEnableSimulateWithoutBounce")]
	public bool ForceEnableSimulateWithoutBounce
	{
		get
		{
			CheckDestroyed();
			if (!ForceEnableSimulateWithoutBounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUProjectileMovementComponent:bForceEnableSimulateWithoutBounce");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceEnableSimulateWithoutBounce_Offset), 0, ForceEnableSimulateWithoutBounce_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceEnableSimulateWithoutBounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUProjectileMovementComponent:bForceEnableSimulateWithoutBounce");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceEnableSimulateWithoutBounce_Offset), 0, ForceEnableSimulateWithoutBounce_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUProjectileMovementComponent:bComputeMoveDeltaOnClient")]
	public bool ComputeMoveDeltaOnClient
	{
		get
		{
			CheckDestroyed();
			if (!ComputeMoveDeltaOnClient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUProjectileMovementComponent:bComputeMoveDeltaOnClient");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ComputeMoveDeltaOnClient_Offset), 0, ComputeMoveDeltaOnClient_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComputeMoveDeltaOnClient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUProjectileMovementComponent:bComputeMoveDeltaOnClient");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ComputeMoveDeltaOnClient_Offset), 0, ComputeMoveDeltaOnClient_PropertyAddress.Address, value);
			}
		}
	}

	static UBGUProjectileMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUProjectileMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUProjectileMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGUProjectileMovementComponent");
		NativeReflectionCached.GetPropertyRef(ref ForceEnableSimulateWithoutBounce_PropertyAddress, unrealStruct, "bForceEnableSimulateWithoutBounce");
		ForceEnableSimulateWithoutBounce_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForceEnableSimulateWithoutBounce");
		ForceEnableSimulateWithoutBounce_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForceEnableSimulateWithoutBounce", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMoveDeltaOnClient_PropertyAddress, unrealStruct, "bComputeMoveDeltaOnClient");
		ComputeMoveDeltaOnClient_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bComputeMoveDeltaOnClient");
		ComputeMoveDeltaOnClient_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bComputeMoveDeltaOnClient", Classes.FBoolProperty);
	}
}
