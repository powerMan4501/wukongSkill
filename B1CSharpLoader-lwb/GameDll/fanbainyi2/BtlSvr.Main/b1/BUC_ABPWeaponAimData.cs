using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPWeaponAimData : IBUC_ABPWeaponAimData
{
	private float Timer;

	private FVector LastTargetPos_World;

	public float WeaponAimAlpha { get; set; }

	public bool bEnableWeaponAim { get; set; }

	public FName WeaponBoneName { get; set; }

	public FVector WeaponAimPos { get; set; }

	public FVector WeaponAimAxis { get; set; }

	public float DegreesConstraint { get; set; }

	public FAimToConfig AimToConfig { get; set; }

	public void Init()
	{
		WeaponAimAlpha = 0f;
		bEnableWeaponAim = false;
		WeaponBoneName = FName.None;
		WeaponAimPos = FVector.ZeroVector;
		WeaponAimAxis = FVector.ZeroVector;
		DegreesConstraint = 180f;
	}

	public void OnAimToBegin(AActor Owner, FAimToConfig _AimToConfig)
	{
		if (_AimToConfig.AimToType == EAimToType.None || _AimToConfig.WeaponBoneName == FName.None)
		{
			return;
		}
		bEnableWeaponAim = true;
		Timer = 0f;
		AimToConfig = _AimToConfig;
		if (GetTargetPos(Owner, out var FinalAimPos_World))
		{
			LastTargetPos_World = FinalAimPos_World;
			if (AimToConfig.BlendInTime == 0f)
			{
				WeaponAimAlpha = 1f;
				AimTo(Owner as ACharacter, FinalAimPos_World);
			}
		}
	}

	public void OnAimToEnd()
	{
		bEnableWeaponAim = false;
		WeaponAimAlpha = 0f;
		AimToConfig.Reset();
	}

	public void Update(AActor Owner, float DeltaTime)
	{
		if (!bEnableWeaponAim)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (!aCharacter.IsNullOrDestroyed())
		{
			float x = 0f;
			if (Timer <= AimToConfig.BlendInTime)
			{
				x = ((AimToConfig.BlendInTime == 0f) ? 1f : (Timer / AimToConfig.BlendInTime));
			}
			else if (Timer < AimToConfig.TotalTime - AimToConfig.BlendOutTime)
			{
				x = 1f;
			}
			else if (Timer >= AimToConfig.TotalTime - AimToConfig.BlendOutTime)
			{
				x = (AimToConfig.TotalTime - Timer) / AimToConfig.BlendOutTime;
			}
			x = FMath.Clamp(x, 0f, 1f);
			WeaponAimAlpha = x;
			Timer += DeltaTime;
			TraceTick(aCharacter, DeltaTime);
		}
	}

	private void TraceTick(ACharacter Owner, float DeltaTime)
	{
		if (!(AimToConfig.TraceSpd <= 0f) && GetTargetPos(Owner, out var FinalAimPos_World))
		{
			float num = FVector.Dist(FinalAimPos_World, LastTargetPos_World);
			float num2 = FMath.Clamp(AimToConfig.TraceSpd * DeltaTime / num, 0f, 1f);
			FVector fVector = LastTargetPos_World + (FinalAimPos_World - LastTargetPos_World) * num2;
			AimTo(Owner, fVector);
			LastTargetPos_World = fVector;
		}
	}

	private void AimTo(ACharacter Owner, FVector AimPos_World)
	{
		if (AimToConfig.bEnableDebug)
		{
			UBGUFunctionLibraryForCS.BGUDrawDebugSphere(Owner.World, AimPos_World, 25f);
		}
		FVector weaponAimPos = Owner.Mesh.GetSocketTransform(B1GlobalFNames.root).InverseTransformLocation(AimPos_World);
		WeaponBoneName = AimToConfig.WeaponBoneName;
		WeaponAimPos = weaponAimPos;
		WeaponAimAxis = AimToConfig.AimAxis;
		DegreesConstraint = ((AimToConfig.DegreesConstraint != 0f) ? AimToConfig.DegreesConstraint : 180f);
	}

	private bool GetTargetPos(AActor Owner, out FVector FinalAimPos_World)
	{
		FinalAimPos_World = FVector.ZeroVector;
		switch (AimToConfig.AimToType)
		{
		case EAimToType.None:
			return false;
		case EAimToType.Target:
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Owner);
			if (readOnlyData == null)
			{
				return false;
			}
			UnitLockTargetInfo TargetInfo = readOnlyData.GetTargetInfo();
			if (TargetInfo.LockTargetActor.IsNullOrDestroyed())
			{
				return false;
			}
			ACharacter aCharacter = TargetInfo.LockTargetActor as ACharacter;
			if (AimToConfig.TargetSocketName != FName.None)
			{
				FinalAimPos_World = aCharacter.Mesh.GetSocketLocation(AimToConfig.TargetSocketName);
			}
			else
			{
				FinalAimPos_World = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, out var _);
			}
			return true;
		}
		default:
			return false;
		}
	}
}
