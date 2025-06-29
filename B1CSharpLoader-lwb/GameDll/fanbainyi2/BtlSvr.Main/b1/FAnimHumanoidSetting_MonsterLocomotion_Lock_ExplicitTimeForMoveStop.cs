using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop")]
public struct FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop:Fwd")]
	public float Fwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop:FL")]
	public float FL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop:BL")]
	public float BL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop:FR")]
	public float FR;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop:BR")]
	public float BR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop:Bwd")]
	public float Bwd;

	private static int AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop_StructSize;

	public FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop");
		AnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop));
	}

	static FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop));
	}
}
