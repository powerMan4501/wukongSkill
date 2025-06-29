using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWPhysMoveAnimDataAsset")]
public class BGWPhysMoveAnimDataAsset : BGWBasePhysAnimDataAsset
{
	private static bool BoneNameToSimulatePhysics_IsValid;

	private static int BoneNameToSimulatePhysics_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWPhysMoveAnimDataAsset:BoneNameToSimulatePhysics")]
	public FName BoneNameToSimulatePhysics
	{
		get
		{
			CheckDestroyed();
			if (!BoneNameToSimulatePhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWPhysMoveAnimDataAsset:BoneNameToSimulatePhysics");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BoneNameToSimulatePhysics_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneNameToSimulatePhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWPhysMoveAnimDataAsset:BoneNameToSimulatePhysics");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BoneNameToSimulatePhysics_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWPhysMoveAnimDataAsset");
		BoneNameToSimulatePhysics_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneNameToSimulatePhysics");
		BoneNameToSimulatePhysics_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneNameToSimulatePhysics", Classes.FNameProperty);
	}

	static BGWPhysMoveAnimDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWPhysMoveAnimDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWPhysMoveAnimDataAsset));
	}
}
