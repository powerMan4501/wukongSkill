using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset")]
public class BGWBeCatchThrowPhysAnimDataAsset : BGWBasePhysAnimDataAsset
{
	private static bool BoneNameBelowToSimulatePhysics_IsValid;

	private static int BoneNameBelowToSimulatePhysics_Offset;

	private static bool PhysicsBlendWeight_IsValid;

	private static int PhysicsBlendWeight_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset:BoneNameBelowToSimulatePhysics")]
	public FName BoneNameBelowToSimulatePhysics
	{
		get
		{
			CheckDestroyed();
			if (!BoneNameBelowToSimulatePhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset:BoneNameBelowToSimulatePhysics");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BoneNameBelowToSimulatePhysics_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneNameBelowToSimulatePhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset:BoneNameBelowToSimulatePhysics");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BoneNameBelowToSimulatePhysics_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset:PhysicsBlendWeight")]
	public float PhysicsBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset:PhysicsBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicsBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset:PhysicsBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicsBlendWeight_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWBeCatchThrowPhysAnimDataAsset");
		BoneNameBelowToSimulatePhysics_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneNameBelowToSimulatePhysics");
		BoneNameBelowToSimulatePhysics_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneNameBelowToSimulatePhysics", Classes.FNameProperty);
		PhysicsBlendWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhysicsBlendWeight");
		PhysicsBlendWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhysicsBlendWeight", Classes.FFloatProperty);
	}

	static BGWBeCatchThrowPhysAnimDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWBeCatchThrowPhysAnimDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWBeCatchThrowPhysAnimDataAsset));
	}
}
