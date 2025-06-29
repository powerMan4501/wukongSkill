using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_TickRateLogicComp : UActorCompBaseCS
{
	private BUC_ConfigInfoData ConfigInfoData;

	private BUC_TickRateData TickRateData;

	private IBUC_FsmData FsmData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_PatrolData PatrolData;

	private b1.IBUC_DumperTruckData DumperTruckData;

	private IBUC_GuidData GuidData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_GroupAIData GroupAIData;

	private IBUC_AIData AIData;

	private IBUC_ActorTransformInfoData ActorTransformInfoData;

	private IBUC_PerformerData PerformerData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_GameStateTestData GameStateTestData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private IBGC_GroupAIMgrData GroupAIMgrData;

	private static List<float> CurCharactersDistance = new List<float>();

	private static List<float> LastCharactersDistance = new List<float>();

	private static float LastTickCharacterWorldTime = 0f;

	private static int NumTickedCharacter = 0;

	private static int NumTickedCharacter_Near = 0;

	private static int NumTickedCharacter_Medium = 0;

	private static int NumTickedCharacter_Far = 0;

	private static int NumWaitingCharacter_Near = 0;

	private static int NumWaitingCharacter_Medium = 0;

	private static int NumWaitingCharacter_Far = 0;

	private static int TICK_1000_COUNT = 5;

	private bool bForceUpdateWhenOptimize;

	private int LastActiveInterval;

	private bool bShouldAccumulateDeltaTimeNextFrame;

	private float TimeToAccumulate;

	private float MySelfTickTime = -1f;

	private TStrongObjectPtr<UBGUCharacterMovementComponent> mMoveComp = new TStrongObjectPtr<UBGUCharacterMovementComponent>();

	private bool IsTianbingPerf;

	protected virtual bool bIsSimplifiedLogic => false;

	private UBGUCharacterMovementComponent MoveComp
	{
		get
		{
			return mMoveComp.Get();
		}
		set
		{
			mMoveComp.Set(value);
		}
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override float GetAccumulatedDeltaTime()
	{
		return MySelfTickTime;
	}

	public override void OnAttach()
	{
		MySelfTickTime = -1f;
		ConfigInfoData = RequireWritableData<BUC_ConfigInfoData>();
		TickRateData = RequireWritableData<BUC_TickRateData>();
		FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		PatrolData = RequireReadOnlyData<IBUC_PatrolData, BUC_PatrolData>();
		DumperTruckData = RequireReadOnlyData<b1.IBUC_DumperTruckData, BUC_DumperTruckData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		GroupAIData = RequireReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		ActorTransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		PerformerData = RequireReadOnlyData<IBUC_PerformerData, BUC_PerformerData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		GameStateTestData = RequireReadOnlyGameStateData<IBGC_GameStateTestData, BGC_GameStateTestData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		GroupAIMgrData = RequireReadOnlyGameStateData<IBGC_GroupAIMgrData, BGC_GroupAIMgrData>();
		TickRateData.TickInterval_100ms = FMath.RandRange(0f, 0.1f);
		TickRateData.TickInterval_200ms = FMath.RandRange(0f, 0.2f);
		TickRateData.TickInterval_500ms = FMath.RandRange(0f, 0.5f);
		TickRateData.TickInterval_1000ms = FMath.RandRange(0f, 1f);
		TickRateData.TickInterval_100ms_200 = TickRateData.TickInterval_100ms;
		TickRateData.TickInterval_100ms_500 = TickRateData.TickInterval_100ms;
		TickRateData.TickInterval_100ms_1000 = TickRateData.TickInterval_100ms;
		TickRateData.TickInterval_200ms_100 = TickRateData.TickInterval_200ms;
		TickRateData.TickInterval_200ms_500 = TickRateData.TickInterval_200ms;
		TickRateData.TickInterval_200ms_1000 = TickRateData.TickInterval_200ms;
		TickRateData.TickInterval_500ms_100 = TickRateData.TickInterval_500ms;
		TickRateData.TickInterval_500ms_200 = TickRateData.TickInterval_500ms;
		TickRateData.TickInterval_500ms_1000 = TickRateData.TickInterval_500ms;
		TickRateData.TickInterval_1000ms_100 = TickRateData.TickInterval_1000ms;
		TickRateData.TickInterval_1000ms_200 = TickRateData.TickInterval_1000ms;
		TickRateData.TickInterval_1000ms_500 = TickRateData.TickInterval_1000ms;
		TickRateData.InitFuncs();
	}

	public override void PreBeginPlay()
	{
		TickRateData.bIsOnLine = !UGSE_EngineFuncLib.IsStandAlone(Owner.World);
		TickRateData.bCanTickForCS = true;
		TickRateData.bWasLastOptimized = false;
		TickRateData.bNeedDisableEndPhysicsTick = false;
		TickRateData.bIsPlayer = Owner == UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.World);
		if (OwnerAsCharacterCS != null)
		{
			MoveComp = OwnerAsCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			ABGUTamerBase tamerOwner = OwnerAsCharacterCS.GetTamerOwner();
			if (tamerOwner != null)
			{
				tamerOwner.SetActorTickEnabled(bEnabled: false);
			}
		}
		IsTianbingPerf = false;
		BUTamerActor bUTamerActor = (Owner as BGUCharacterCS)?.GetTamerOwner() as BUTamerActor;
		bool value = default(bool);
		if (bUTamerActor != null && bUTamerActor.ConfigInfoComp.FlagConfig.MonsterRejectTags.TryGetValue(EActorCompRejectFlag.TianbingPerf.ToString(), out value) && value)
		{
			IsTianbingPerf = true;
		}
	}

	public override void OnBeginPlay()
	{
		LoadUROConfig();
		if (TickRateData.bIsPlayer)
		{
			Reset();
		}
		MySelfTickTime = 0f;
	}

	private void LoadUROConfig()
	{
		if (TickRateData.bIsPlayer || ConfigInfoData == null)
		{
			return;
		}
		BGWDataAsset_TROConfig bGWDataAsset_TROConfig = null;
		if (ConfigInfoData.TROConfigOverride != null)
		{
			bGWDataAsset_TROConfig = ConfigInfoData.TROConfigOverride;
		}
		else
		{
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(Owner));
			if (unitCommDesc != null)
			{
				BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
				TickRateData.UnitBodyType = unitCommDesc.UnitBodyType;
				switch (unitCommDesc.UnitBodyType)
				{
				case EUnitBodyType.Small:
					bGWDataAsset_TROConfig = bGW_PreloadAssetMgr.TROConfig_Small;
					break;
				case EUnitBodyType.Medium:
					bGWDataAsset_TROConfig = bGW_PreloadAssetMgr.TROConfig_Medium;
					break;
				case EUnitBodyType.MediumBig:
					bGWDataAsset_TROConfig = bGW_PreloadAssetMgr.TROConfig_MediumBig;
					break;
				case EUnitBodyType.Big:
					bGWDataAsset_TROConfig = bGW_PreloadAssetMgr.TROConfig_Big;
					break;
				case EUnitBodyType.Huge:
					bGWDataAsset_TROConfig = bGW_PreloadAssetMgr.TROConfig_Huge;
					break;
				default:
					BGW_LogUtil.LogError("Failed to find corresponding global TRODataAsset! UnitBodyType is unknown!");
					break;
				}
			}
		}
		if (bGWDataAsset_TROConfig != null)
		{
			bool flag = true;
			bool bDisableLineTraceOptimization = false;
			FUStTROStrategyConfigDesc tROStrategyConfigDesc = BGW_GameDB.GetTROStrategyConfigDesc(GuidData.GetFinalGuid());
			if (tROStrategyConfigDesc != null)
			{
				flag = tROStrategyConfigDesc.Disable == EGSYesNo.No;
				bDisableLineTraceOptimization = tROStrategyConfigDesc.DisableLineTraceOptimization == EGSYesNo.Yes;
			}
			TickRateData.bEnableUROFromConfig = flag;
			TickRateData.bEnableUROLastFrame = flag;
			TickRateData.CppTickCullDistance = bGWDataAsset_TROConfig.CppTickCullDistance;
			TickRateData.bDisableLineTraceOptimization = bDisableLineTraceOptimization;
			InitForAnimation(flag, bGWDataAsset_TROConfig.BaseVisibleDistanceFactorThesholds.ToList(), bGWDataAsset_TROConfig.BaseNonRenderedUpdateRate);
			InitForCharacterMovement(bGWDataAsset_TROConfig.CharacterMovementNavWalkingDistance, bGWDataAsset_TROConfig.CharacterMovementTickCullDistance);
		}
	}

	private void InitForAnimation(bool bEnableURO, List<float> BaseVisibleDistanceFactorThesholds, int BaseNonRenderedUpdateRate)
	{
		UpdateForAnimation(bEnableURO);
		UGSE_SkeletalMeshFuncLib.UpdateUROParams(Owner, BaseVisibleDistanceFactorThesholds, BaseNonRenderedUpdateRate);
	}

	private void UpdateForAnimation(bool bEnableURO)
	{
		ActorFuncLib.SetActorSKMeshesUpdateRateOptimizations(Owner.Address, bEnableURO);
	}

	private void InitForCharacterMovement(float Distance1, float Distance2)
	{
		if (MoveComp != null)
		{
			MoveComp.OptimizeDistanceLevel1 = Distance1;
			MoveComp.OptimizeDistanceLevel2 = Distance2;
		}
	}

	private void Reset()
	{
		TickRateData.bCanTickForCS = true;
		TickRateData.AccumulatedDeltaTime = 0f;
		if (TickRateData.bWasLastOptimized)
		{
			ToggleCppTickEnabled(bEnable: true);
			TickRateData.bWasLastOptimized = false;
		}
		if (TickRateData.bEnableUROLastFrame)
		{
			ActorFuncLib.GetUROResult(Owner.Address, out var OutAccumulatedDeltaTime);
			TickRateData.AccumulatedDeltaTime = OutAccumulatedDeltaTime;
			UpdateForAnimation(bEnableURO: false);
		}
		TickRateData.bEnableUROLastFrame = false;
	}

	private void Apply()
	{
		float OutAccumulatedDeltaTime = 0f;
		TickRateData.bCanTickForCS = TickRateData.bWasLastOptimized || !ActorFuncLib.GetUROResult(Owner.Address, out OutAccumulatedDeltaTime);
		TickRateData.AccumulatedDeltaTime = OutAccumulatedDeltaTime;
		if (!TickRateData.bCanTickForCS)
		{
			TickRateData.AccumulatedDeltaTime = -1f;
		}
		if (TickRateData.bIsPlayer)
		{
			TickRateData.bEnableUROLastFrame = false;
		}
		if (!TickRateData.bEnableUROLastFrame)
		{
			UpdateForAnimation(TickRateData.bEnableUROFromConfig);
		}
		TickRateData.bEnableUROLastFrame = true;
	}

	public override int GetTickGroupMask()
	{
		return 2049;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickGroup == 2048)
		{
			if (TickRateData.TickInterval_100ms > 0.1f)
			{
				while (TickRateData.TickInterval_100ms > 0.1f)
				{
					TickRateData.TickInterval_100ms -= 0.1f;
				}
				while (TickRateData.TickInterval_200ms_100 > 0.1f)
				{
					TickRateData.TickInterval_200ms_100 -= 0.1f;
				}
				while (TickRateData.TickInterval_500ms_100 > 0.1f)
				{
					TickRateData.TickInterval_500ms_100 -= 0.1f;
				}
				while (TickRateData.TickInterval_1000ms_100 > 0.1f)
				{
					TickRateData.TickInterval_1000ms_100 -= 0.1f;
				}
			}
			if (TickRateData.TickInterval_200ms > 0.2f)
			{
				while (TickRateData.TickInterval_200ms > 0.2f)
				{
					TickRateData.TickInterval_200ms -= 0.2f;
				}
				while (TickRateData.TickInterval_100ms_200 > 0.2f)
				{
					TickRateData.TickInterval_100ms_200 -= 0.2f;
				}
				while (TickRateData.TickInterval_500ms_200 > 0.2f)
				{
					TickRateData.TickInterval_500ms_200 -= 0.2f;
				}
				while (TickRateData.TickInterval_1000ms_200 > 0.2f)
				{
					TickRateData.TickInterval_1000ms_200 -= 0.2f;
				}
			}
			if (TickRateData.TickInterval_500ms > 0.5f)
			{
				while (TickRateData.TickInterval_500ms > 0.5f)
				{
					TickRateData.TickInterval_500ms -= 0.5f;
				}
				while (TickRateData.TickInterval_100ms_500 > 0.5f)
				{
					TickRateData.TickInterval_100ms_500 -= 0.5f;
				}
				while (TickRateData.TickInterval_200ms_500 > 0.5f)
				{
					TickRateData.TickInterval_200ms_500 -= 0.5f;
				}
				while (TickRateData.TickInterval_1000ms_500 > 0.5f)
				{
					TickRateData.TickInterval_1000ms_500 -= 0.5f;
				}
			}
			if (TickRateData.TickInterval_1000ms > 1f)
			{
				while (TickRateData.TickInterval_1000ms > 1f)
				{
					TickRateData.TickInterval_1000ms -= 1f;
				}
				while (TickRateData.TickInterval_100ms_1000 > 1f)
				{
					TickRateData.TickInterval_100ms_1000 -= 1f;
				}
				while (TickRateData.TickInterval_200ms_1000 > 1f)
				{
					TickRateData.TickInterval_200ms_1000 -= 1f;
				}
				while (TickRateData.TickInterval_500ms_1000 > 1f)
				{
					TickRateData.TickInterval_500ms_1000 -= 1f;
				}
			}
		}
		else
		{
			if (Owner.IsNullFastCheck())
			{
				return;
			}
			bForceUpdateWhenOptimize = false;
			if (TickRateData.bCanTickForCS)
			{
				TickRateData.AccumulatedDeltaTime = 0f;
			}
			TickRateData.TickInterval_100ms += DeltaTime;
			TickRateData.TickInterval_100ms_200 += DeltaTime;
			TickRateData.TickInterval_100ms_500 += DeltaTime;
			TickRateData.TickInterval_100ms_1000 += DeltaTime;
			TickRateData.TickInterval_200ms += DeltaTime;
			TickRateData.TickInterval_200ms_100 += DeltaTime;
			TickRateData.TickInterval_200ms_500 += DeltaTime;
			TickRateData.TickInterval_200ms_1000 += DeltaTime;
			TickRateData.TickInterval_500ms += DeltaTime;
			TickRateData.TickInterval_500ms_100 += DeltaTime;
			TickRateData.TickInterval_500ms_200 += DeltaTime;
			TickRateData.TickInterval_500ms_1000 += DeltaTime;
			TickRateData.TickInterval_1000ms += DeltaTime;
			TickRateData.TickInterval_1000ms_100 += DeltaTime;
			TickRateData.TickInterval_1000ms_200 += DeltaTime;
			TickRateData.TickInterval_1000ms_500 += DeltaTime;
			TickRateData.bCanTickFor100ms = false;
			TickRateData.bCanTickFor200ms = false;
			TickRateData.bCanTickFor500ms = false;
			TickRateData.bCanTickFor1000ms = false;
			if (TickRateData.TickInterval_100ms > 0.1f)
			{
				TickRateData.bCanTickFor100ms = true;
			}
			if (TickRateData.TickInterval_200ms > 0.2f)
			{
				TickRateData.bCanTickFor200ms = true;
			}
			if (TickRateData.TickInterval_500ms > 0.5f)
			{
				TickRateData.bCanTickFor500ms = true;
			}
			if (TickRateData.TickInterval_1000ms > 1f)
			{
				TickRateData.bCanTickFor1000ms = true;
				bForceUpdateWhenOptimize = true;
			}
			if (bIsSimplifiedLogic)
			{
				return;
			}
			TickRateData.TROHelper_CanTickThisFrame = b1.TroDistanceByIntervalHelper.EvaluateTick(DeltaTime, TickRateData, ref LastActiveInterval, ref bShouldAccumulateDeltaTimeNextFrame, ref TimeToAccumulate, out var AccumulatedDeltaTime);
			TickRateData.TROHelper_DeltaTime = AccumulatedDeltaTime;
			if (TickRateData.bIsPlayer)
			{
				return;
			}
			TickRateData.LocalScreenPercentageUpdateTimer -= DeltaTime;
			if (TickRateData.LocalScreenPercentageUpdateTimer <= 0f)
			{
				TickRateData.LocalScreenPercentageUpdateTimer = FMath.RandRange(0.4f, 0.7f);
				CalculateDistanceToPlayer();
			}
			TickRateData.bIsOptimizing = CheckCanOptimizeTickRate();
			if (TickRateData.bIsOptimizing)
			{
				TickRateData.bIsOptimizing = CheckCanOptimizeTickRateByUnitStatus();
				if (!TickRateData.bIsOptimizing)
				{
					NumTickedCharacter++;
				}
			}
			if (GSGameplayCVar.CVar_UROEnableDebug.GetValueInGameThread() == 1)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
				FVector lineEnd = fVector;
				lineEnd.Z += 1000f;
				USystemLibrary.DrawDebugArrow(Owner, fVector, lineEnd, 30f, TickRateData.bIsOptimizing ? FLinearColor.Green : FLinearColor.Red, 0f, 30f);
			}
			if (MoveComp != null)
			{
				BGW_NativeFuncs.SetOptimizeInfo(MoveComp.Address, PatrolData != null && PatrolData.bIsPatroling, TickRateData.bIsOptimizing, BattleStateData.IsUnitInBattle(), bReturnMaterialOnMove: true);
			}
			if (!TickRateData.bIsOptimizing)
			{
				Reset();
				return;
			}
			Apply();
			bool flag = false;
			flag = ShouldOptimizeByPerformance();
			RecordDistanceAndCounter();
			if (GSGameplayCVar.CVar_TROCounterCullDebug.GetValueInGameThread() == 1)
			{
				USystemLibrary.DrawDebugString(Owner, Owner.GetActorLocation(), flag.ToString(), null, FLinearColor.White, 0f);
			}
			if (!flag)
			{
				NumTickedCharacter++;
			}
			if (flag == TickRateData.bWasLastOptimized)
			{
				if (TickRateData.bNeedDisableEndPhysicsTick)
				{
					ActorFuncLib.DisableSKMeshEndPhysicsTick(Owner.Address);
					TickRateData.bNeedDisableEndPhysicsTick = false;
				}
			}
			else
			{
				TickRateData.bWasLastOptimized = flag;
				TickRateData.bNeedDisableEndPhysicsTick = flag;
				ToggleCppTickEnabled(!flag);
			}
		}
	}

	private void RecordDistanceAndCounter()
	{
		float timeSeconds = UnrealGameplayData.GetTimeSeconds();
		if (LastTickCharacterWorldTime != timeSeconds)
		{
			NumTickedCharacter = 0;
			NumTickedCharacter_Near = 0;
			NumTickedCharacter_Medium = 0;
			NumTickedCharacter_Far = 0;
			NumWaitingCharacter_Near = 0;
			NumWaitingCharacter_Medium = 0;
			NumWaitingCharacter_Far = 0;
			LastTickCharacterWorldTime = timeSeconds;
			LastCharactersDistance.Clear();
			LastCharactersDistance.AddRange(CurCharactersDistance);
			LastCharactersDistance.Sort();
			CurCharactersDistance.Clear();
		}
		CurCharactersDistance.Add(TickRateData.DistanceToPlayer);
	}

	private bool ShouldOptimizeByPerformance()
	{
		if (GSGameplayCVar.CVar_TROCounterCullEnable.GetValueInGameThread() != 1)
		{
			return false;
		}
		int num = GSGameplayCVar.CVar_TROCounterCullMaxCount.GetValueInGameThread();
		int num2 = GSGameplayCVar.CVar_TROCounterNearMaxCount.GetValueInGameThread();
		if (num <= 10)
		{
			num = 10;
		}
		if (num2 > num)
		{
			num2 = num;
		}
		if (LastCharactersDistance.Count <= num2)
		{
			return false;
		}
		if ((int)TickRateData.UnitBodyType >= 4)
		{
			return false;
		}
		if (!ActorFuncLib.CheckActorWasRecentlyRendered(Owner.Address) && TickRateData.DistanceToPlayer > LastCharactersDistance[num2])
		{
			return true;
		}
		if (TickRateData.DistanceToPlayer <= LastCharactersDistance[num2])
		{
			bool num3 = NumTickedCharacter_Near < num2;
			if (num3)
			{
				NumTickedCharacter_Near++;
			}
			return !num3;
		}
		if (NumTickedCharacter_Far < num - num2)
		{
			float AccumulatedDeltaTime;
			float DifferenceTimeToLast100ms;
			float DifferenceTimeToLast200ms;
			float DifferenceTimeToLast500ms;
			float DifferenceTimeToLast1000ms;
			bool num4 = TickRateData.CanTickFor500msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			if (num4)
			{
				NumTickedCharacter_Far++;
			}
			return !num4;
		}
		return true;
	}

	private bool ShouldOptimizeGroupAITROCullType(out int CullType)
	{
		CullType = 0;
		if (GSGameplayCVar.CVar_TROCounterCullEnable.GetValueInGameThread() != 1)
		{
			return false;
		}
		int num = GSGameplayCVar.CVar_TROCounterCullMaxCount.GetValueInGameThread();
		if (num <= 0)
		{
			num = 10;
		}
		if (LastCharactersDistance.Count < num)
		{
			return TickRateData.DistanceToPlayer > TickRateData.CppTickCullDistance;
		}
		if ((int)TickRateData.UnitBodyType >= 4)
		{
			return false;
		}
		if (!ActorFuncLib.CheckActorWasRecentlyRendered(Owner.Address) && TickRateData.DistanceToPlayer > LastCharactersDistance[num / 3])
		{
			return true;
		}
		int num2 = num;
		int count = LastCharactersDistance.Count;
		int valueInGameThread = GSGameplayCVar.CVar_TROCounterNearMaxCount.GetValueInGameThread();
		int num3 = (20 * num2 - count - 19 * valueInGameThread) / 3;
		num3 = ((num3 >= 0) ? num3 : 0);
		int num4 = 20 * num2 / 19 - count / 19;
		valueInGameThread = ((valueInGameThread > num4) ? num4 : valueInGameThread);
		int index = ((valueInGameThread + num3 >= LastCharactersDistance.Count - 1) ? (LastCharactersDistance.Count / 2) : (valueInGameThread + num3));
		bool flag = true;
		bool isCtrlByGroupAI = GroupAIData.GetIsCtrlByGroupAI();
		float AccumulatedDeltaTime;
		float DifferenceTimeToLast100ms;
		float DifferenceTimeToLast200ms;
		float DifferenceTimeToLast500ms;
		float DifferenceTimeToLast1000ms;
		if (TickRateData.DistanceToPlayer <= LastCharactersDistance[valueInGameThread])
		{
			CullType = 1;
			flag = NumTickedCharacter_Near < valueInGameThread;
			if (flag)
			{
				NumTickedCharacter_Near++;
			}
			else if (isCtrlByGroupAI)
			{
				switch (GroupAIData.GroupAITROCullType)
				{
				case EGroupAITROCullType.HighPriority:
					flag = true;
					break;
				case EGroupAITROCullType.WanderInShort:
					flag = TickRateData.CanTickFor100msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
					break;
				case EGroupAITROCullType.WanderInMiddle:
					flag = TickRateData.CanTickFor200msInterval(out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms, out AccumulatedDeltaTime);
					break;
				}
			}
		}
		else if (TickRateData.DistanceToPlayer < LastCharactersDistance[index])
		{
			CullType = 2;
			flag = TickRateData.CanTickFor100msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			if (flag)
			{
				flag = NumTickedCharacter_Medium < num3;
				if (flag)
				{
					NumTickedCharacter_Medium++;
				}
				else if (isCtrlByGroupAI)
				{
					flag = TickRateData.CanTickFor200msInterval(out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms, out AccumulatedDeltaTime);
					if (GroupAIData.GroupAITROCullType == EGroupAITROCullType.HighPriority)
					{
						flag = true;
					}
				}
			}
		}
		else
		{
			CullType = 3;
			flag = TickRateData.CanTickFor500msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			if (flag)
			{
				NumTickedCharacter_Far++;
			}
			else if (isCtrlByGroupAI && GroupAIData.GroupAITROCullType == EGroupAITROCullType.HighPriority)
			{
				flag = true;
			}
		}
		return !flag;
	}

	private void CalculateDistanceToPlayer()
	{
		if (ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation))
		{
			TickRateData.DistanceToPlayer = FVector.Distance(OutLocation, LocalPlayerSharedData.CachedLocalPlayerLocation);
		}
	}

	private void ToggleCppTickEnabled(bool bEnable)
	{
		ActorFuncLib.ToggleActorTickEnabled(Owner.Address, bEnable);
	}

	private bool CheckCanOptimizeTickRate()
	{
		if (!TickRateData.bEnableUROFromConfig || GSGameplayCVar.CVar_UROEnable.GetValueInGameThread() == 0)
		{
			return false;
		}
		if (GameStateTestData != null && GameStateTestData.StopOptimizeTickRate)
		{
			return false;
		}
		if (IsTianbingPerf)
		{
			return false;
		}
		return DebugConfig.CanOptimizeTick;
	}

	private bool CheckCanOptimizeTickRateByUnitStatus()
	{
		if (SimpleStateData != null)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
			{
				return false;
			}
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				return false;
			}
		}
		if (UnitStateData != null)
		{
			if (UnitStateData.HasState(EBGUUnitState.Dead))
			{
				return false;
			}
			if (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback))
			{
				return false;
			}
		}
		if (AIData != null)
		{
			if (AIData.CurrentFsmSolverType == EFsmSolverType.SummonAi)
			{
				return false;
			}
			if (AIData.CurrentFsmSolverType == EFsmSolverType.Normal || AIData.CurrentFsmSolverType == EFsmSolverType.FriendlyBattleNpc)
			{
				if (!FsmData.IsInFsmState(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombat))
				{
					return false;
				}
			}
			else if ((AIData.CurrentFsmSolverType == EFsmSolverType.NeutralAnimalBattle || AIData.CurrentFsmSolverType == EFsmSolverType.NeutralAnimalEscape) && FsmData.IsInFsmState(BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Escape))
			{
				return false;
			}
		}
		if (PatrolData != null && PatrolData.bIsPatroling)
		{
			return false;
		}
		if (DumperTruckData != null && DumperTruckData.IsActive)
		{
			return false;
		}
		if (PerformerData != null && PerformerData.bPerforming)
		{
			return false;
		}
		return true;
	}
}
