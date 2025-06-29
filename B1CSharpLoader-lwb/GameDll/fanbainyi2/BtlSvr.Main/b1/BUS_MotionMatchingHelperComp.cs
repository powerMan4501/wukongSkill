using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MotionMatchingHelperComp : UActorCompBaseCS
{
	private IBUC_ABPMotionMatchingData MMData;

	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPBasicData BasicData;

	private IBUC_TickRateData TickRateData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_PatrolData PatrolData;

	private IBUC_ActorBasicData ActorBasicData;

	private readonly float RotateInterpSpeed = 10f;

	public override void OnAttach()
	{
		MMData = RequireReadOnlyData<IBUC_ABPMotionMatchingData, BUC_ABPMotionMatchingData>();
		CommonData = RequireReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>();
		BasicData = RequireReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		PatrolData = RequireReadOnlyData<IBUC_PatrolData, BUC_PatrolData>();
		ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool flag = true;
		bool num = ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer || BattleStateData.IsUnitInBattle() || PatrolData.bIsPatroling;
		float AccumulatedDeltaTime = DeltaTime;
		if (num)
		{
			if (!TickRateData.CanTickFor6000Distance())
			{
				flag = TickRateData.CanTickFor100msInterval(out AccumulatedDeltaTime, out var _, out var _, out var _, out var _);
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			UpdateMotionMatching(AccumulatedDeltaTime);
		}
	}

	private void UpdateMotionMatching(float DeltaTime)
	{
		if (!(OwnerAsCharacterCS == null) && !(OwnerAsCharacterCS.Mesh == null) && CommonData.FinalABPMoveMode == EABPMoveMode.MotionMatching && BasicData.AccelerationVec.Size() > 0f && BasicData.Speed >= MMData.DisableRotVerifyAnimSpeed && MMData.MotionMatchingState != EState_MM.None)
		{
			FRotator Target = MMData.RotatorforMM;
			FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			FRotator relativeRotation = OwnerAsCharacterCS.Mesh.RelativeRotation;
			Target.Yaw -= relativeRotation.Yaw;
			FRotator newRotation = Current;
			if (!Current.Yaw.Equals(Target.Yaw))
			{
				FRotator fRotator = MathLib.RInterpConstantTo(in Current, in Target, DeltaTime, RotateInterpSpeed);
				fRotator.Roll = Current.Roll;
				fRotator.Pitch = Current.Pitch;
				newRotation = fRotator;
			}
			BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, newRotation, bTeleportPhysics: false);
		}
	}
}
