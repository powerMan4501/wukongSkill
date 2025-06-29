using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting")]
public struct FGSCameraAutoLockSetting
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:MaxCamLockTargetDistance")]
	public float MaxCamLockTargetDistance;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:CamLockAngleMax")]
	public float CamLockAngleMax;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:CamLockSwitchAngleMax")]
	public float CamLockSwitchAngleMax;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:DistScoreRate")]
	public float DistScoreRate;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:G4SpotTurnSpeed")]
	public float G4SpotTurnSpeed;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:CamLockTurnSpeed")]
	public float CamLockTurnSpeed;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:RollSkillTurnSpeed")]
	public float RollSkillTurnSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:RotateToCameraTurnSpeed")]
	public float RotateToCameraTurnSpeed;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:SkillResumeMoveBlendTime")]
	public float SkillResumeMoveBlendTime;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraAutoLockSetting:Camera4GRotateSpeed")]
	public float Camera4GRotateSpeed;

	private static int FGSCameraAutoLockSetting_StructSize;

	public FGSCameraAutoLockSetting Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FGSCameraAutoLockSetting");
		FGSCameraAutoLockSetting_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSCameraAutoLockSetting));
	}

	static FGSCameraAutoLockSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSCameraAutoLockSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCameraAutoLockSetting));
	}
}
