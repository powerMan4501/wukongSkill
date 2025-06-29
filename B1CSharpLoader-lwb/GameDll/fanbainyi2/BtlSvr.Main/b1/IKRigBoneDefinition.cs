using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.IKRigBoneDefinition")]
public struct IKRigBoneDefinition
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IKRigBoneDefinition:TargetTransform")]
	public FTransform TargetTransform;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IKRigBoneDefinition:BoneName")]
	public FName BoneName;

	private static int IKRigBoneDefinition_StructSize;

	public IKRigBoneDefinition(FName InName)
	{
		BoneName = InName;
		TargetTransform = FTransform.Identity;
	}

	public IKRigBoneDefinition(FName InName, FTransform InTrf)
	{
		BoneName = InName;
		TargetTransform = InTrf;
	}

	public IKRigBoneDefinition Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.IKRigBoneDefinition");
		IKRigBoneDefinition_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(IKRigBoneDefinition));
	}

	static IKRigBoneDefinition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IKRigBoneDefinition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IKRigBoneDefinition));
	}
}
