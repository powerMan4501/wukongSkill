using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PatrolCompImpl")]
public class BUS_PatrolCompImpl : UActorCompBaseUObj
{
	private BUC_PatrolData PatrolData;

	private IBUC_WakeUpData WakeUpData;

	private IBUC_FsmData FsmData;

	private IBUC_BuffData BuffData;

	private IBUC_UnitStateData UnitStateData;

	private UBUC_ACharacterComponent CharacterComponent;

	private IBUC_PropMgrData PropMgrData;

	private IBGC_UnitPatrolGroupMgrData UnitPatrolGroupMgrData;

	private USplineComponent Spline;

	private List<USplineComponent> SplineList = new List<USplineComponent>();

	private int MultiSplineCount;

	private int MultiSplineCurIndex;

	private bool IsForword = true;

	private readonly float DelayPatrolTime = 2f;

	private readonly float FollowMinDistance = 100f;

	private readonly float FollowMiddleDistance = 500f;

	private readonly float FollowMaxDistance = 1000f;

	private readonly float FollowWaitDistance = 2000f;

	private readonly float FollowMinTimeRate = 0.5f;

	private readonly float FollowMaxTimeRate = 2f;

	private List<b1.FSplinePathNode> Path = new List<b1.FSplinePathNode>();

	private List<FVector> RandomPoints = new List<FVector>();

	private bool bWaitingRandomEQS;

	private int CurrentPathPointIndex;

	private int CurrentMoveIdx = -1;

	private bool CanMoveStep;

	private float WaitTimer;

	private float UpdateFollowTimer;

	private float BeginPatrolWaitTimer;

	private UAnimMontage LastPlayedMontage;

	private bool LastActionIsWait;

	private int LastRandomPointIndex = -1;

	private bool bShouldInitGroupPatrol;

	private bool HasJumped;

	private bool HasFreeFell;

	private float JumpTimer;

	private float EstimatedJumpTime;

	private FVector JumpStartPoint;

	private float TestTime;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool OnTriggerBoxOverlap_IsValid;

	private static IntPtr OnTriggerBoxOverlap_FunctionAddress;

	private static int OnTriggerBoxOverlap_ParamsSize;

	private static bool OnTriggerBoxOverlap_OverlapActor_IsValid;

	private static int OnTriggerBoxOverlap_OverlapActor_Offset;

	private static bool OnTriggerBoxOverlap_OtherActor_IsValid;

	private static int OnTriggerBoxOverlap_OtherActor_Offset;

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBUC_GuidData GuidData { get; set; }

	private IBUC_NPCAnimData NPCAnimData { get; set; }

	private IBIC_MovieData MovieData { get; set; }

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_PatrolCompImpl:TriggerBox")]
	private ATriggerBase TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PatrolCompImpl:TriggerBox");
				return null;
			}
			return UObjectMarshaler<ATriggerBase>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PatrolCompImpl:TriggerBox");
			}
			else
			{
				UObjectMarshaler<ATriggerBase>.ToNative(IntPtr.Add(base.Address, TriggerBox_Offset), value);
			}
		}
	}

	public override void OnAttach()
	{
		PatrolData = RequireWritableData<BUC_PatrolData>();
		WakeUpData = RequireReadOnlyData<IBUC_WakeUpData, BUC_WakeUpData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		CharacterComponent = RequireReadOnlyData<UBUC_ACharacterComponent, UBUC_ACharacterComponent>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		NPCAnimData = RequireReadOnlyData<IBUC_NPCAnimData, BUC_NPCAnimData>();
		MovieData = RequireReadonlyGameInstanceData<IBIC_MovieData, BIC_MovieData>();
		UnitPatrolGroupMgrData = RequireReadOnlyGameStateData<IBGC_UnitPatrolGroupMgrData, BGC_UnitPatrolGroupMgrData>();
		base.BUSEventCollection.Evt_AIPathMoveComplete += new Del_AIPathMoveComplete(OnAIPathMoveComplete);
		base.BUSEventCollection.Evt_StartPatrolAndLeisure += new Del_Void(OnStartPatrolAndLeisure);
		base.BUSEventCollection.Evt_StopPatrolAndLeisure += new Del_Void(OnStopPatrolAndLeisure);
		base.BUSEventCollection.Evt_NotifyFollowPatrol += new Del_Void_ActorVector(OnNotifyFollowPatrol);
		base.BUSEventCollection.Evt_SetGroupPatrolLeader += new Del_SetGroupPatrolLeader(OnSetPatrolGroupLeader);
		base.BUSEventCollection.Evt_SetGroupPatrolMember += new Del_SetGroupPatrolMember(OnSetPatrolGroupMember);
		base.BUSEventCollection.Evt_OnGroupPatrolMoveComplete += new Del_OnGroupPatrolMoveComplete(OnGroupPatrolMoveComplete);
		base.BUSEventCollection.Evt_GroupPatrolContinue += new Del_Void(GroupPatrolContinue);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallBack);
		base.BUSEventCollection.Evt_NPCReplaceLeisureAnim += new Del_Void_AnimMontage(OnNPCReplaceLeisureAnim);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Combine(bGWEventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(OnMovieInstanceFinished));
	}

	public override void PreBeginPlay()
	{
		InitPatrol();
	}

	private void MoveStep(float DeltaTime)
	{
		if (CanMoveStep)
		{
			RandomMoveStep();
			SplineMoveStep(DeltaTime);
			MulitSplineMoveStep();
			FollowMoveStep();
			GroupMoveStep();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PatrolData.PatrolType == EPatrolType.None)
		{
			return;
		}
		if (bShouldInitGroupPatrol)
		{
			InitGroupPatrol();
		}
		UpdatePatrolRetry();
		if (CanMoveStep)
		{
			MoveStep(DeltaTime);
		}
		else if (WaitTimer > 0f)
		{
			WaitTimer -= DeltaTime;
			if (WaitTimer <= 0f)
			{
				WaitTimer = 0f;
				ContinuePatrol();
				StopLastPlayedMontage();
			}
		}
		if (BeginPatrolWaitTimer > 0f)
		{
			BeginPatrolWaitTimer -= DeltaTime;
			if (BeginPatrolWaitTimer <= 0f)
			{
				BeginPatrolWaitTimer = 0f;
				if (CheckCanPatrol())
				{
					DelayInitPatrol();
					BeginPatrol();
				}
				else
				{
					PatrolData.bPatrolNeedRetry = true;
				}
			}
		}
		if (UpdateFollowTimer > 0f)
		{
			UpdateFollowTimer -= DeltaTime;
			if (UpdateFollowTimer <= 0f)
			{
				UpdateFollowTimer = 0.1f;
				if (PatrolData.PatrolType == EPatrolType.Follow)
				{
					UpdateFollowTimeRate();
				}
			}
		}
		PatrolData.HasCDIndex.Clear();
		foreach (KeyValuePair<int, float> item in PatrolData.LeisureRandomCDTimer)
		{
			if (item.Value > 0f)
			{
				PatrolData.HasCDIndex.Add(item.Key);
			}
		}
		foreach (int item2 in PatrolData.HasCDIndex)
		{
			PatrolData.LeisureRandomCDTimer[item2] -= DeltaTime;
		}
		if (PatrolData.bPendingMoveRequest && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			PatrolData.bPendingMoveRequest = false;
			CurrentMoveIdx = BGUFuncLibAICS.BGURequestAIMoveToLocation(GetOwner(), PatrolData.PendingTargetLocation, PatrolData.PatrolMoveSpeedType, PatrolData.MoveAcceptableRadius, PatrolData.FindPathMoveType, IncludeSelfRadius: true, IncludeTargetRadius: false);
		}
	}

	private void DelayInitPatrol()
	{
		if (PatrolData.bNeedDelayInit)
		{
			switch (PatrolData.PatrolType)
			{
			case EPatrolType.Random:
				InitRandomPatrol();
				break;
			case EPatrolType.Follow:
				InitFollowPatrol();
				break;
			case EPatrolType.Group:
				InitGroupPatrol();
				break;
			}
			PatrolData.bNeedDelayInit = false;
		}
	}

	private void UpdatePatrolRetry()
	{
		if (PatrolData.bPatrolStarted && PatrolData.bPatrolNeedRetry && BeginPatrolWaitTimer <= 0f)
		{
			DelayBeginPatrol();
			PatrolData.bPatrolNeedRetry = false;
		}
	}

	private bool CheckCanPatrol()
	{
		if (!PatrolData.bPatrolStarted)
		{
			return false;
		}
		if (!FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NONCOMBAT_IDLE) && !FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NEUTRALANIMAL_PATROL))
		{
			return false;
		}
		return true;
	}

	private void InitPatrol()
	{
		switch (PatrolData.PatrolType)
		{
		case EPatrolType.Spline:
			InitSplinePatrol();
			break;
		case EPatrolType.MultiSpline:
			InitMultiSplinePatrol();
			break;
		case EPatrolType.Leisure:
			InitLeisure();
			break;
		case EPatrolType.Random:
		case EPatrolType.Follow:
		case EPatrolType.Group:
			PatrolData.bNeedDelayInit = true;
			break;
		}
	}

	private void CheckBeginPatrol()
	{
		if (PatrolData.PatrolType == EPatrolType.Spline)
		{
			if (TriggerBox == null || !TriggerBox.GetActorEnableCollision())
			{
				DelayBeginPatrol();
			}
		}
		else if (PatrolData.PatrolType == EPatrolType.MultiSpline)
		{
			if (TriggerBox == null || !TriggerBox.GetActorEnableCollision())
			{
				DelayBeginPatrol();
			}
		}
		else if (PatrolData.PatrolType == EPatrolType.Random)
		{
			DelayBeginPatrol();
		}
		else if (PatrolData.PatrolType == EPatrolType.Follow)
		{
			DelayBeginPatrol();
		}
		else if (PatrolData.PatrolType == EPatrolType.Group)
		{
			InitGroupPatrol();
			DelayBeginPatrol();
		}
	}

	private void DelayBeginPatrol()
	{
		BeginPatrolWaitTimer = (UpdateFollowTimer = DelayPatrolTime);
	}

	private void InitSplinePatrol()
	{
		if (AttachSplineAndTriggerBox())
		{
			InitPath();
		}
	}

	private void InitMultiSplinePatrol()
	{
		if (AttachSplineAndTriggerBox())
		{
			MultiSplineCurIndex = 0;
		}
	}

	private void InitRandomPatrol()
	{
		if (!bWaitingRandomEQS && base.BGSEventCollection != null)
		{
			bWaitingRandomEQS = true;
			base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(PatrolData.RandomPatrolConfig.EnvQuery, GetOwner(), EBGURunEQSObjReason.RandomPatrol, default(FGSEQSExParam), OnEnvQueryFinished);
		}
	}

	private void InitLeisure()
	{
	}

	private void InitFollowPatrol()
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PatrolData.FollowTargetGuid);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			PatrolData.FollowTargetGuid = BGU_DataUtil.GetActorGuid(actorByGuid);
		}
		if (PatrolData.FollowTargetGuid.Length != 0)
		{
			PatrolData.FollowRelativeLocation = MathLib.InverseTransformLocation(BGUFuncLibActorTransformCS.BGUGetActorTransform(actorByGuid), BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()));
			BUS_EventCollectionCS.Get(actorByGuid).Evt_NotifyFollowPatrol.Invoke(GetOwner(), PatrolData.FollowRelativeLocation);
		}
	}

	private void StartLeisureImpl()
	{
		PatrolData.LeisureLoopCount = 0;
		PatrolData.LeisureRandomCDTimer.Clear();
		BeginLeisure();
	}

	private void BeginLeisure()
	{
		bool flag = PatrolData.LastLeisureRandomIndex != -1;
		PatrolData.LastLeisureRandomIndex = -1;
		GSLeisureConfig leisureConfig = PatrolData.LeisureConfig;
		float num = 0f;
		Dictionary<int, GSLeisureRandomConfig> dictionary = new Dictionary<int, GSLeisureRandomConfig>();
		PatrolData.StartLeisureLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		if (!flag)
		{
			for (int i = 0; i < leisureConfig.RandomConfig.Count; i++)
			{
				if (!PatrolData.LeisureRandomCDTimer.TryGetValue(i, out var value) || !(value > 0f))
				{
					dictionary.Add(i, leisureConfig.RandomConfig[i]);
					num += leisureConfig.RandomConfig[i].Weight;
				}
			}
		}
		int count = dictionary.Count;
		bool flag2 = count > 0 && !flag;
		bool bRandomStartTime = leisureConfig.bRandomStartTime && !flag2 && PatrolData.LeisureLoopCount == 0;
		BUC_PatrolData patrolData = PatrolData;
		int leisureLoopCount = patrolData.LeisureLoopCount + 1;
		patrolData.LeisureLoopCount = leisureLoopCount;
		UAnimMontage uAnimMontage = null;
		if (NPCAnimData != null && NPCAnimData.IsTriggerReplaceLeisureAnim)
		{
			bRandomStartTime = false;
			uAnimMontage = PatrolData.LeisureConfig.NPCAnimOverrideLeisureAnim;
		}
		else if (PatrolData.HasReplaceLeisureSequenceID() && MovieData.IsSequencePlayed(PatrolData.LeisureConfig.ReplaceLeisureSequenceID))
		{
			bRandomStartTime = false;
			uAnimMontage = PatrolData.LeisureConfig.AfterSequenceOverrideLeisureAnim;
		}
		else if (flag2)
		{
			if (count == 1)
			{
				KeyValuePair<int, GSLeisureRandomConfig> keyValuePair = dictionary.First();
				uAnimMontage = keyValuePair.Value.RandomAnim;
				PatrolData.LastLeisureRandomIndex = keyValuePair.Key;
			}
			else
			{
				float num2 = 0f;
				float num3 = FMath.FRand();
				foreach (KeyValuePair<int, GSLeisureRandomConfig> item in dictionary)
				{
					num2 += ((num <= 0f) ? 1f : (item.Value.Weight / num));
					if (num3 <= num2)
					{
						uAnimMontage = leisureConfig.RandomConfig[item.Key].RandomAnim;
						PatrolData.LastLeisureRandomIndex = item.Key;
						break;
					}
				}
			}
		}
		else
		{
			uAnimMontage = leisureConfig.LeisureAnim;
		}
		if (uAnimMontage == null)
		{
			PatrolData.bIsInLeisure = false;
			StopLastPlayedMontage();
			return;
		}
		PatrolData.bIsInLeisure = true;
		if (PatrolData.LeisureConfig.bGroupSyncLeisure)
		{
			if (base.BGSEventCollection.Evt_BGS_OnSyncPlayGroupLeisureMontage.Invoke(Owner, uAnimMontage) >= 0f)
			{
				LastPlayedMontage = uAnimMontage;
				LastActionIsWait = true;
			}
		}
		else
		{
			PlayWaitMontage(uAnimMontage, bRandomStartTime);
		}
	}

	private void OnEnvQueryFinished(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (ExParam.RunEQSObjReason == EBGURunEQSObjReason.RandomPatrol)
		{
			RandomPoints = Result;
			bWaitingRandomEQS = false;
		}
	}

	private void OnAIPathMoveComplete(int MoveIdx, EPathFollowingResult Result)
	{
		if (MoveIdx != CurrentMoveIdx)
		{
			return;
		}
		if (Result != EPathFollowingResult.Success)
		{
			PatrolData.bPatrolNeedRetry = true;
			return;
		}
		CurrentMoveIdx = -1;
		if (PatrolData.PatrolType == EPatrolType.Spline)
		{
			if (Path.Count > CurrentPathPointIndex)
			{
				b1.FSplinePathNode fSplinePathNode = Path[CurrentPathPointIndex++];
				WaitTimer = fSplinePathNode.WaitTime;
				if (WaitTimer > 0f || WaitTimer == -1f)
				{
					PlayWaitMontage(fSplinePathNode.WaitAM);
				}
				else
				{
					ContinuePatrol(bMoveImmediately: true);
				}
			}
			else
			{
				StopPatrol();
			}
		}
		else if (PatrolData.PatrolType == EPatrolType.MultiSpline)
		{
			ContinuePatrol(bMoveImmediately: true);
		}
		else if (PatrolData.PatrolType == EPatrolType.Random)
		{
			if (PatrolData.RandomPatrolConfig.ShouldPlayWaitAM())
			{
				UAnimMontage randomAMToPlay = PatrolData.RandomPatrolConfig.GetRandomAMToPlay();
				PlayWaitMontage(randomAMToPlay);
			}
			else
			{
				ContinuePatrol(bMoveImmediately: true);
			}
		}
		else if (PatrolData.PatrolType == EPatrolType.Follow)
		{
			ContinuePatrol(bMoveImmediately: true);
		}
		else if (PatrolData.PatrolType == EPatrolType.Group)
		{
			OnGroupPatrolPathMoveCompleted();
		}
	}

	private void OnStartPatrolAndLeisure()
	{
		if (PatrolData.PatrolType == EPatrolType.Leisure)
		{
			StartLeisureImpl();
		}
		else if (PatrolData.PatrolType != EPatrolType.None)
		{
			StartPatrolImpl();
		}
	}

	private void OnStopPatrolAndLeisure()
	{
		if (PatrolData.PatrolType != EPatrolType.Leisure && PatrolData.PatrolType != EPatrolType.None)
		{
			StopPatrol();
		}
	}

	private void StartPatrolImpl()
	{
		if (PatrolData.PatrolType != EPatrolType.None && (!(TriggerBox != null) || !TriggerBox.GetActorEnableCollision()))
		{
			PatrolData.bPatrolStarted = true;
			PatrolData.bPatrolNeedRetry = false;
			ResetFollowTimeRate();
			CheckBeginPatrol();
		}
	}

	private void OnNotifyFollowPatrol(AActor Follower, FVector FollowRelativeLocation)
	{
		Entity key = ECSUtil.ToEntity(Follower);
		if (!PatrolData.FollowerRelativeLocationMap.ContainsKey(key))
		{
			PatrolData.FollowerRelativeLocationMap.Add(key, FollowRelativeLocation);
		}
	}

	private void PlayWaitMontage(UAnimMontage Montage, bool bRandomStartTime = false)
	{
		if (Montage != null)
		{
			float montagePosOffset = (bRandomStartTime ? FMath.RandRange(0f, Montage.GetPlayLength()) : 0f);
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, Montage, FName.None, EMontageBindReason.Patrol, 1f, 1f, montagePosOffset);
			LastPlayedMontage = Montage;
			LastActionIsWait = true;
		}
	}

	private void PlayJumpMontage(UAnimMontage Montage)
	{
		BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, Montage, FName.None, EMontageBindReason.Patrol);
		HasJumped = true;
		LastPlayedMontage = Montage;
		LastActionIsWait = false;
	}

	private void StopLastPlayedMontage()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter != null)
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			if (LastPlayedMontage != null)
			{
				aCharacter.StopAnimMontage(LastPlayedMontage);
			}
		}
	}

	private bool AttachSplineAndTriggerBox()
	{
		if (PatrolData.PatrolType == EPatrolType.MultiSpline)
		{
			if (PatrolData.MultiSplinePatrolConfig.SplineList == null || PatrolData.MultiSplinePatrolConfig.SplineList.Count == 0)
			{
				BGW_LogUtil.LogError("PatrolSystem AttachSplineAndTriggerBox SplineList is null!");
				return false;
			}
			foreach (TSoftObject<AActor> spline in PatrolData.MultiSplinePatrolConfig.SplineList)
			{
				SplineList.Add(spline.Value.GetComponentByClass<USplineComponent>());
			}
			if (SplineList == null || SplineList.Count == 0)
			{
				BGW_LogUtil.LogError("PatrolSystem AttachSplineAndTriggerBox SplineList is null! Owner: {0}", GetOwner());
				return false;
			}
		}
		if (!PatrolData.SplinePatrolConfig.SplineActor.IsValid)
		{
			BGW_LogUtil.LogError("PatrolSystem AttachSplineAndTriggerBox SplineActor is null!");
			return false;
		}
		Spline = PatrolData.SplinePatrolConfig.SplineActor.Value.GetComponentByClass<USplineComponent>();
		if (Spline == null)
		{
			BGW_LogUtil.LogError("PatrolSystem AttachSplineAndTriggerBox Spline is null! Owner: {0}", GetOwner());
			return false;
		}
		if (PatrolData.SplinePatrolConfig.TriggerBox.IsValid)
		{
			TriggerBox = PatrolData.SplinePatrolConfig.TriggerBox.Value;
			UBGUFunctionLibraryForCS.BGUBindOnActorBeginOverlapEvent(TriggerBox, this, B1GlobalFNames.OnTriggerBoxOverlap);
			TriggerBox.SetActorEnableCollision(bNewActorEnableCollision: true);
		}
		return true;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_PatrolCompImpl:OnTriggerBoxOverlap")]
	private void OnTriggerBoxOverlap(AActor OverlapActor, AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.IsPlayerControlled())
		{
			TriggerBox.SetActorEnableCollision(bNewActorEnableCollision: false);
			StartSplinePatrolByTriggerBox();
		}
	}

	private void StartSplinePatrolByTriggerBox()
	{
		PatrolData.bPatrolStarted = true;
		BeginPatrolWaitTimer = 0.1f;
	}

	private void InitPath()
	{
		Path.Clear();
		CurrentPathPointIndex = 0;
		int numberOfSplinePoints = Spline.GetNumberOfSplinePoints();
		Dictionary<int, GSSplinePatrolWaitPoint> waitPointConfig = PatrolData.SplinePatrolConfig.WaitPointConfig;
		Dictionary<int, GSSplinePatrolJumpPoint> jumpPointConfig = PatrolData.SplinePatrolConfig.JumpPointConfig;
		Path.Capacity = numberOfSplinePoints;
		b1.FSplinePathNode item = default(b1.FSplinePathNode);
		for (int i = 0; i < numberOfSplinePoints; i++)
		{
			item.Pos = Spline.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.World);
			item.WaitTime = 0f;
			item.WaitAM = null;
			item.JumpAM = null;
			item.IsJumpPoint = false;
			item.JumpForce = 0f;
			if (waitPointConfig.ContainsKey(i))
			{
				item.WaitTime = waitPointConfig[i].WaitTime;
				item.WaitAM = waitPointConfig[i].WaitAM;
			}
			if (jumpPointConfig.ContainsKey(i))
			{
				item.JumpAM = jumpPointConfig[i].JumpAM;
				item.IsJumpPoint = true;
				item.JumpForce = jumpPointConfig[i].JumpForce;
			}
			Path.Add(item);
		}
	}

	private void BeginPatrol()
	{
		bool flag = true;
		if (PatrolData.PatrolType == EPatrolType.Spline && Path.Count == 0)
		{
			flag = false;
		}
		if (PatrolData.PatrolType == EPatrolType.MultiSpline && SplineList != null && SplineList.Count == 0)
		{
			flag = false;
		}
		if (PatrolData.PatrolType == EPatrolType.Random && RandomPoints.Count == 0)
		{
			if (bWaitingRandomEQS)
			{
				PatrolData.bPatrolNeedRetry = true;
				return;
			}
			flag = false;
		}
		if (PatrolData.PatrolType == EPatrolType.Follow && PatrolData.FollowTargetGuid.Length == 0)
		{
			flag = false;
		}
		if (PatrolData.PatrolType == EPatrolType.Group && bShouldInitGroupPatrol)
		{
			PatrolData.bPatrolNeedRetry = true;
			return;
		}
		if (!flag)
		{
			PatrolData.bPatrolStarted = false;
			return;
		}
		PatrolData.bIsPatroling = true;
		if (PatrolData.StartWaitAMConfig.ShouldPlayWaitAM())
		{
			UAnimMontage randomAMToPlay = PatrolData.StartWaitAMConfig.GetRandomAMToPlay();
			PlayWaitMontage(randomAMToPlay);
		}
		else
		{
			CanMoveStep = true;
		}
		if (PatrolData.ABPSettingForPatrol != null)
		{
			base.BUSEventCollection.Evt_ChangeABPSetting.Invoke(PatrolData.ABPSettingForPatrol);
		}
		if (PatrolData.PatrolBuff != 0)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(PatrolData.PatrolBuff, Owner, Owner, 0f, EBuffSourceType.Patrol);
		}
	}

	private void ContinuePatrol(bool bMoveImmediately = false)
	{
		PatrolData.bIsPatroling = true;
		CanMoveStep = true;
		if (bMoveImmediately)
		{
			MoveStep(0f);
		}
	}

	private void StopPatrol()
	{
		if (LastActionIsWait)
		{
			StopLastPlayedMontage();
		}
		PatrolData.bPatrolStarted = false;
		PatrolData.bPatrolNeedRetry = false;
		PatrolData.bIsPatroling = false;
		InitPatrol();
		CurrentPathPointIndex = 0;
		CurrentMoveIdx = -1;
		CanMoveStep = false;
		WaitTimer = 0f;
		UpdateFollowTimer = 0f;
		LastPlayedMontage = null;
		LastRandomPointIndex = -1;
		if (PatrolData.ABPSettingForPatrol != null)
		{
			base.BUSEventCollection.Evt_ResetABPSetting.Invoke();
		}
		if (PatrolData.PatrolBuff != 0 && BuffData.HasBuff(PatrolData.PatrolBuff))
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(PatrolData.PatrolBuff, EBuffEffectTriggerType.None, 1);
		}
		if (PatrolData.PatrolType == EPatrolType.Group)
		{
			StopGroupPatrol();
		}
		ResetFollowTimeRate();
	}

	private void RandomMoveStep()
	{
		if (PatrolData.PatrolType != EPatrolType.Random)
		{
			return;
		}
		PatrolData.FindPathDistance = 200f;
		int count = RandomPoints.Count;
		if (count > 0)
		{
			int num = UB1Util.GetRandomNumberInt(0, count - 1);
			if (num == LastRandomPointIndex)
			{
				num = ((num == 0) ? 1 : (num - 1));
			}
			num = (LastRandomPointIndex = FMath.Clamp(num, 0, count - 1));
			CommonMoveStep(RandomPoints[num]);
		}
	}

	private void SplineMoveStep(float DeltaTime)
	{
		if (PatrolData.PatrolType != EPatrolType.Spline || Spline == null)
		{
			return;
		}
		PatrolData.FindPathDistance = 200f;
		if (CurrentPathPointIndex >= Path.Count)
		{
			if (PatrolData.SplinePatrolConfig.SingleDirection)
			{
				if (!Spline.IsClosedLoop())
				{
					StopPatrol();
					OnPatrolEnd();
					OnSigleDirectionPatrolEnded();
					return;
				}
				CurrentPathPointIndex = 0;
			}
			else
			{
				Path.Reverse();
				CurrentPathPointIndex = 1;
			}
		}
		if (CurrentPathPointIndex >= 1 && CurrentPathPointIndex <= Path.Count - 1 && Path[CurrentPathPointIndex - 1].IsJumpPoint)
		{
			if (HasJumped && HasFreeFell)
			{
				JumpMopveStep(DeltaTime);
			}
			else if (!HasJumped)
			{
				StartPatrolJump();
			}
		}
		else
		{
			CommonMoveStep(Path[CurrentPathPointIndex].Pos);
		}
	}

	private void MulitSplineMoveStep()
	{
		if (PatrolData.PatrolType == EPatrolType.MultiSpline && SplineList != null && SplineList.Count != 0)
		{
			USplineComponent uSplineComponent = SplineList[MultiSplineCurIndex];
			FVector actorLocation = Owner.GetActorLocation();
			int num = 700;
			int num2 = 700;
			float inputKeyAtDistanceAlongSpline = uSplineComponent.GetInputKeyAtDistanceAlongSpline(num2);
			float num3 = uSplineComponent.FindInputKeyClosestToWorldLocation(actorLocation);
			if ((float)(uSplineComponent.GetNumberOfSplinePoints() - 1) - num3 < inputKeyAtDistanceAlongSpline)
			{
				CheckNeedJumpToNextSpline();
			}
			if (num3 < inputKeyAtDistanceAlongSpline)
			{
				IsForword = true;
				CheckNeedJumpToPreSpline();
			}
			float inputKeyAtDistanceAlongSpline2 = uSplineComponent.GetInputKeyAtDistanceAlongSpline(num);
			num3 += (IsForword ? inputKeyAtDistanceAlongSpline2 : (0f - inputKeyAtDistanceAlongSpline2));
			FVector locationAtSplineInputKey = uSplineComponent.GetLocationAtSplineInputKey(num3, ESplineCoordinateSpace.World);
			PatrolData.FindPathDistance = 200f;
			CommonMoveStep(locationAtSplineInputKey);
		}
	}

	private void CheckNeedJumpToNextSpline()
	{
		AActor nearestPlayerActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(Owner);
		USplineComponent uSplineComponent = SplineList[MultiSplineCurIndex];
		if (uSplineComponent.FindInputKeyClosestToWorldLocation(nearestPlayerActor.GetActorLocation()) == (float)(uSplineComponent.GetNumberOfSplinePoints() - 1) && MultiSplineCurIndex + 1 < SplineList.Count)
		{
			MultiSplineCurIndex++;
			IsForword = true;
		}
		else
		{
			IsForword = false;
		}
	}

	private void CheckNeedJumpToPreSpline()
	{
		AActor nearestPlayerActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(Owner);
		if (SplineList[MultiSplineCurIndex].FindInputKeyClosestToWorldLocation(nearestPlayerActor.GetActorLocation()) == 0f && MultiSplineCurIndex - 1 >= 0)
		{
			MultiSplineCurIndex--;
			IsForword = false;
		}
		else
		{
			IsForword = true;
		}
	}

	private void FollowMoveStep()
	{
		if (PatrolData.PatrolType == EPatrolType.Follow && FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NONCOMBAT_IDLE))
		{
			ACharacter aCharacter = BGU_DataUtil.GetActorByGuid(GetOwner(), PatrolData.FollowTargetGuid) as ACharacter;
			if (!(aCharacter == null))
			{
				PatrolData.FindPathDistance = 0f;
				FVector targetLocation = MathLib.TransformLocation(BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter), PatrolData.FollowRelativeLocation);
				CommonMoveStep(targetLocation);
				WaitTimer = 0.05f;
			}
		}
	}

	private void UpdateFollowTimeRate()
	{
		float num = 1f;
		if (FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NONCOMBAT_IDLE))
		{
			ACharacter aCharacter = GetOwner() as ACharacter;
			ACharacter aCharacter2 = BGU_DataUtil.GetActorByGuid(GetOwner(), PatrolData.FollowTargetGuid) as ACharacter;
			if (aCharacter2 != null && aCharacter != null)
			{
				float num2 = 0f;
				UCapsuleComponent uCapsuleComponent = aCharacter.GetRootComponent() as UCapsuleComponent;
				if (uCapsuleComponent != null)
				{
					num2 = uCapsuleComponent.GetScaledCapsuleRadius();
				}
				float num3 = (MathLib.TransformLocation(BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter2), PatrolData.FollowRelativeLocation) - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).Size() - num2;
				if (0f <= num3 && num3 < FollowMinDistance)
				{
					num = FollowMinTimeRate + (1f - FollowMinTimeRate) * (num3 / FollowMinDistance);
				}
				else if (FollowMinDistance <= num3 && num3 < FollowMiddleDistance)
				{
					num = 1f;
				}
				else if (FollowMiddleDistance <= num3 && num3 < FollowMaxDistance)
				{
					num = 1f + (FollowMaxTimeRate - 1f) * (num3 - FollowMinDistance) / (FollowMaxDistance - FollowMinDistance);
				}
				else if (FollowMaxDistance <= num3)
				{
					num = FollowMaxTimeRate;
				}
			}
			if (PatrolData.FollowerRelativeLocationMap.Count > 0)
			{
				float num4 = 0f;
				foreach (KeyValuePair<Entity, FVector> item in PatrolData.FollowerRelativeLocationMap)
				{
					ACharacter aCharacter3 = ECSUtil.ToActor(item.Key) as ACharacter;
					if (!aCharacter3.IsNullOrDestroyed())
					{
						float num5 = (MathLib.TransformLocation(BGUFuncLibActorTransformCS.BGUGetActorTransform(GetOwner()), item.Value) - BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter3)).Size();
						if (num5 > num4)
						{
							num4 = num5;
						}
					}
				}
				if (num4 > FollowWaitDistance)
				{
					num *= 1f - (1f - FollowMinTimeRate) * MathLib.Clamp((num4 - FollowWaitDistance) / 100f, 0f, 1f);
				}
			}
		}
		if (PatrolData.CustomTimeDilationHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, num);
			PatrolData.CustomTimeDilationHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, num, PatrolData.CustomTimeDilationHandleID);
		}
	}

	private void ResetFollowTimeRate()
	{
		base.BUSEventCollection.Evt_ResetProperty.Invoke(PatrolData.CustomTimeDilationHandleID);
		PatrolData.CustomTimeDilationHandleID = 0u;
	}

	private void StartPatrolJump()
	{
		FVector inVec = Path[CurrentPathPointIndex].Pos - Path[CurrentPathPointIndex - 1].Pos;
		inVec.Z = 0f;
		inVec.Normalize();
		BGUFuncLibActorTransformCS.BGUSetActorRotation(GetOwner(), inVec.Conv_VectorToRotator(), bTeleportPhysics: true);
		float jumpForce = Path[CurrentPathPointIndex - 1].JumpForce;
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			PlayJumpMontage(Path[CurrentPathPointIndex - 1].JumpAM);
			if (PatrolData.GravityScaleHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f);
				PatrolData.GravityScaleHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f, PatrolData.GravityScaleHandleID);
			}
			UCharacterMovementComponent uCharacterMovementComponent = bGUCharacterCS.GetMovementComponent() as UCharacterMovementComponent;
			if (!uCharacterMovementComponent.IsNullOrDestroyed())
			{
				jumpForce = MathLib.Abs(jumpForce);
				float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(GetOwner(), PatrolData.PatrolMoveSpeedType);
				unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
				uCharacterMovementComponent.AddImpulse(GetOwner().GetActorForwardVector() * jumpForce * uCharacterMovementComponent.Mass * unitSpeedRateByMoveSpeedType);
			}
		}
	}

	private void JumpMoveInit()
	{
		if (CurrentPathPointIndex < 0 || CurrentPathPointIndex >= Path.Count)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		JumpStartPoint = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		FVector pos = Path[CurrentPathPointIndex].Pos;
		base.BUSEventCollection.Evt_ResetProperty.Invoke(PatrolData.GravityScaleHandleID);
		PatrolData.GravityScaleHandleID = 0u;
		UCharacterMovementComponent uCharacterMovementComponent = bGUCharacterCS.GetMovementComponent() as UCharacterMovementComponent;
		if (!uCharacterMovementComponent.IsNullOrDestroyed())
		{
			uCharacterMovementComponent.Velocity = FVector.ZeroVector;
			float num = MathLib.Abs(JumpStartPoint.Z - pos.Z);
			float num2 = MathLib.Abs(uCharacterMovementComponent.GetGravityZ());
			if (num2 != 0f)
			{
				EstimatedJumpTime = MathLib.Sqrt(2f * num / num2);
				JumpTimer = 0f;
				HasFreeFell = true;
			}
		}
	}

	private void JumpMopveStep(float DeltaTime)
	{
		JumpTimer += DeltaTime;
		FVector pos = Path[CurrentPathPointIndex].Pos;
		float num = MathLib.Clamp(JumpTimer / EstimatedJumpTime, 0f, 1f);
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			FVector newLocation = (1f - num) * JumpStartPoint + num * pos;
			newLocation.Z = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS).Z;
			BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS, newLocation, bSweep: false, bTeleport: false);
			if (num == 1f)
			{
				OnPatrolJumpEnded();
			}
		}
	}

	private void OnPatrolJumpEnded()
	{
		CanMoveStep = false;
		CurrentMoveIdx = -1;
		OnAIPathMoveComplete(CurrentMoveIdx, EPathFollowingResult.Success);
		HasJumped = false;
		HasFreeFell = false;
		JumpTimer = 0f;
	}

	private void CommonMoveStep(FVector TargetLocation)
	{
		CanMoveStep = false;
		if ((TargetLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).Size2D() <= CharacterComponent.OwnerCharacter.CapsuleComponent.GetScaledCapsuleRadius() + 10f)
		{
			CurrentMoveIdx = -1;
			OnAIPathMoveComplete(CurrentMoveIdx, EPathFollowingResult.Success);
			return;
		}
		bool flag = false;
		if (PatrolData.PatrolType != EPatrolType.Group)
		{
			flag = BGUFunctionLibraryCS.CheckNeedCastTurnSkill(Owner, PatrolData.TurnSkillConfig, TargetLocation);
		}
		if (PatrolData.MotionMatchingState != EState_MM.None)
		{
			base.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(PatrolData.MotionMatchingState);
		}
		if (!PatrolData.TurnSkillConfig.bDisableImmediatePathfinding)
		{
			CurrentMoveIdx = BGUFuncLibAICS.BGURequestAIMoveToLocation(GetOwner(), TargetLocation, PatrolData.PatrolMoveSpeedType, PatrolData.MoveAcceptableRadius, PatrolData.FindPathMoveType, IncludeSelfRadius: true, IncludeTargetRadius: false);
		}
		else if (flag)
		{
			PatrolData.bPendingMoveRequest = true;
			PatrolData.PendingTargetLocation = TargetLocation;
		}
		else
		{
			CurrentMoveIdx = BGUFuncLibAICS.BGURequestAIMoveToLocation(GetOwner(), TargetLocation, PatrolData.PatrolMoveSpeedType, PatrolData.MoveAcceptableRadius, PatrolData.FindPathMoveType, IncludeSelfRadius: true, IncludeTargetRadius: false);
		}
	}

	private void OnPatrolEnd()
	{
	}

	private void OnSigleDirectionPatrolEnded()
	{
		CurrentPathPointIndex = Path.Count;
	}

	private void InitGroupPatrol()
	{
		string finalGuid = GuidData.GetFinalGuid();
		base.BGSEventCollection?.Evt_BGS_AddUnitToPatrolGroup.Invoke(finalGuid);
		bShouldInitGroupPatrol = UnitPatrolGroupMgrData.TryFindPatrolUnitInfo(finalGuid) == null;
	}

	public void StopGroupPatrol()
	{
		base.BGSEventCollection?.Evt_BGS_RemoveUnitFromPatrolGroup.Invoke(BGU_DataUtil.GetActorGuid(Owner));
		PatrolData.IsGroupOnWaitPoint = false;
		PatrolData.bGroupMemberPauseFindPath = false;
	}

	private void GroupMoveStep()
	{
		if (PatrolData.PatrolType != EPatrolType.Group)
		{
			return;
		}
		if (PatrolData.GroupPatrolType == EGroupPatrolType.Leader)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PatrolData.GroupSplineActorGuid);
			if (actorByGuid == null)
			{
				return;
			}
			if (PatrolData.GroupSpline == null)
			{
				PatrolData.GroupSpline = actorByGuid.GetComponentByClass<USplineComponent>();
				if (PatrolData.GroupSpline == null)
				{
					return;
				}
			}
			PatrolData.FindPathDistance = 200f;
			FVector locationAtSplinePoint = PatrolData.GroupSpline.GetLocationAtSplinePoint(PatrolData.TargetGroupSplinePoint, ESplineCoordinateSpace.World);
			if (!PatrolData.IsGroupOnWaitPoint)
			{
				CommonMoveStep(locationAtSplinePoint);
			}
		}
		else
		{
			if (PatrolData.GroupPatrolType != EGroupPatrolType.Member)
			{
				return;
			}
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(Owner, PatrolData.GroupLeaderGuid);
			if (!(actorByGuid2 == null))
			{
				PatrolData.FindPathDistance = 0f;
				FVector fVector = MathLib.TransformLocation(BGUFuncLibActorTransformCS.BGUGetActorTransform(actorByGuid2), PatrolData.GroupRelativeLocation);
				WaitTimer = 0.05f;
				if (PatrolData.GroupPatrolConfig.GroupFollowConfig.bEnableAdjustTimeRate)
				{
					UpdateGroupFollowTimeRate((fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).Size());
				}
				if (PatrolData.bGroupMemberPauseFindPath && (fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)).Size() > 200f)
				{
					PatrolData.bGroupMemberPauseFindPath = false;
				}
				if (!PatrolData.IsGroupOnWaitPoint && !PatrolData.bGroupMemberPauseFindPath)
				{
					CommonMoveStep(fVector);
				}
			}
		}
	}

	private void UpdateGroupFollowTimeRate(float Distance)
	{
		float num = 1f;
		GSGroupFollowConfig groupFollowConfig = PatrolData.GroupPatrolConfig.GroupFollowConfig;
		num = ((Distance < groupFollowConfig.MinRateDistance) ? groupFollowConfig.MinTimeRate : ((Distance < groupFollowConfig.DecreaseRateDistance) ? (groupFollowConfig.MinTimeRate + (1f - groupFollowConfig.MinTimeRate) * (Distance - groupFollowConfig.MinTimeRate) / (groupFollowConfig.DecreaseRateDistance - groupFollowConfig.MinTimeRate)) : ((Distance < groupFollowConfig.IncreaseRateDistance) ? 1f : ((!(Distance < groupFollowConfig.MaxRateDistance)) ? groupFollowConfig.MaxTimeRate : (1f + (groupFollowConfig.MinTimeRate - 1f) * (Distance - groupFollowConfig.IncreaseRateDistance) / (groupFollowConfig.MaxRateDistance - groupFollowConfig.IncreaseRateDistance))))));
		if (PatrolData.CustomTimeDilationHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, num);
			PatrolData.CustomTimeDilationHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, num, PatrolData.CustomTimeDilationHandleID);
		}
	}

	private void OnGroupPatrolPathMoveCompleted()
	{
		if (PatrolData.GroupPatrolType == EGroupPatrolType.Leader)
		{
			base.BGSEventCollection?.Evt_BGS_GroupPatrolLeaderPathMoveComplete.Invoke(BGU_DataUtil.GetActorGuid(Owner));
		}
		if (PatrolData.GroupPatrolType == EGroupPatrolType.Member)
		{
			PatrolData.bGroupMemberPauseFindPath = true;
		}
	}

	private void OnSetPatrolGroupLeader(string SplineActorGuid, int TargetSplinePoint)
	{
		PatrolData.GroupPatrolType = EGroupPatrolType.Leader;
		PatrolData.GroupSplineActorGuid = SplineActorGuid;
		PatrolData.TargetGroupSplinePoint = TargetSplinePoint;
		ResetFollowTimeRate();
	}

	private void OnSetPatrolGroupMember(string GroupLeaderGuid, FVector GroupRelativeLocation, int TargetSplinePoint)
	{
		PatrolData.GroupPatrolType = EGroupPatrolType.Member;
		PatrolData.GroupLeaderGuid = GroupLeaderGuid;
		PatrolData.GroupRelativeLocation = GroupRelativeLocation;
		PatrolData.TargetGroupSplinePoint = TargetSplinePoint;
		ResetFollowTimeRate();
	}

	private void OnGroupPatrolMoveComplete(int NewTargetSplinePoint)
	{
		PatrolData.IsGroupOnWaitPoint = true;
		CanMoveStep = false;
		if (PatrolData.GroupPatrolConfig.WaitPointConfig.TryGetValue(PatrolData.TargetGroupSplinePoint, out var value))
		{
			WaitTimer = value.WaitTime;
			if (WaitTimer > 0f || WaitTimer == -1f)
			{
				PlayWaitMontage(value.WaitAM);
			}
			else
			{
				GroupPatrolWaitPointEnd();
			}
		}
		else
		{
			GroupPatrolWaitPointEnd();
		}
		PatrolData.TargetGroupSplinePoint = NewTargetSplinePoint;
	}

	private void GroupPatrolWaitPointEnd()
	{
		if (base.BGSEventCollection == null || UnitPatrolGroupMgrData.TryFindPatrolUnitInfo(BGU_DataUtil.GetActorGuid(Owner)) == null)
		{
			bShouldInitGroupPatrol = true;
			return;
		}
		if (PatrolData.GroupPatrolType == EGroupPatrolType.Leader)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PatrolData.GroupSplineActorGuid);
			if (actorByGuid == null)
			{
				return;
			}
			if (PatrolData.GroupSpline == null)
			{
				PatrolData.GroupSpline = actorByGuid.GetComponentByClass<USplineComponent>();
				if (PatrolData.GroupSpline == null)
				{
					return;
				}
			}
			BGUFunctionLibraryCS.CheckNeedCastTurnSkill(Owner, PatrolData.TurnSkillConfig, PatrolData.GroupSpline.GetLocationAtSplinePoint(PatrolData.TargetGroupSplinePoint, ESplineCoordinateSpace.World));
		}
		else if (PatrolData.GroupPatrolType == EGroupPatrolType.Member)
		{
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(Owner, PatrolData.GroupLeaderGuid);
			if (actorByGuid2 == null)
			{
				return;
			}
			FVector targetLocation = MathLib.TransformLocation(BGUFuncLibActorTransformCS.BGUGetActorTransform(actorByGuid2), PatrolData.GroupRelativeLocation);
			BGUFunctionLibraryCS.CheckNeedCastTurnSkill(Owner, PatrolData.TurnSkillConfig, targetLocation);
		}
		base.BGSEventCollection.Evt_BGS_GroupPatrolWaitPointEnd.Invoke(BGU_DataUtil.GetActorGuid(Owner));
	}

	private void GroupPatrolContinue()
	{
		ContinuePatrol();
		PatrolData.IsGroupOnWaitPoint = false;
		PatrolData.bGroupMemberPauseFindPath = false;
	}

	private void OnPlayMontageCallBack(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason != EMontageBindReason.Patrol || (State != EMontageCallbackState.OnBlendOut && State != EMontageCallbackState.OnInterrupted) || LastPlayedMontage == null)
		{
			return;
		}
		if (LastActionIsWait)
		{
			LastPlayedMontage = null;
			if (PatrolData.PatrolType == EPatrolType.Group)
			{
				GroupPatrolWaitPointEnd();
			}
			else if (State == EMontageCallbackState.OnInterrupted)
			{
				OnPlayMontageInterrupted();
			}
			else
			{
				if (WaitTimer > 0f)
				{
					return;
				}
				if (PatrolData.PatrolType == EPatrolType.Spline)
				{
					ContinuePatrol();
				}
				else if (PatrolData.PatrolType == EPatrolType.Random)
				{
					ContinuePatrol();
				}
				else if (PatrolData.PatrolType == EPatrolType.Leisure)
				{
					List<GSLeisureRandomConfig> randomConfig = PatrolData.LeisureConfig.RandomConfig;
					if (PatrolData.LastLeisureRandomIndex != -1 && randomConfig[PatrolData.LastLeisureRandomIndex].RandomAnim == Montage)
					{
						PatrolData.LeisureRandomCDTimer[PatrolData.LastLeisureRandomIndex] = randomConfig[PatrolData.LastLeisureRandomIndex].CDTime;
					}
					BeginLeisure();
				}
			}
		}
		else
		{
			JumpMoveInit();
			LastPlayedMontage = null;
		}
	}

	private void OnPlayMontageInterrupted()
	{
		if (PatrolData.PatrolType == EPatrolType.Leisure)
		{
			PatrolData.bIsInLeisure = false;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Remove(bGWEventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(OnMovieInstanceFinished));
		if (PatrolData.PatrolType == EPatrolType.Group)
		{
			StopGroupPatrol();
		}
		PatrolData.ABPSettingForPatrol = null;
	}

	private void OnResetActorStatusPre(EResetActorReason Reason)
	{
		PatrolData.FinishedMovieSequenceBeforeReset.Clear();
	}

	private void OnMovieInstanceFinished(int SequenceID)
	{
		PatrolData.FinishedMovieSequenceBeforeReset.Add(SequenceID);
	}

	private void OnNPCReplaceLeisureAnim(UAnimMontage LeisureAnim)
	{
		PatrolData.LeisureConfig.NPCAnimOverrideLeisureAnim = LeisureAnim;
		if (PatrolData.PatrolType == EPatrolType.Leisure && FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NONCOMBAT))
		{
			StopLastPlayedMontage();
			StartLeisureImpl();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_PatrolCompImpl:OnTriggerBoxOverlap")]
	private static void OnTriggerBoxOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_PatrolCompImpl bUS_PatrolCompImpl = GCHelper.Find<BUS_PatrolCompImpl>(obj);
		AActor overlapActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnTriggerBoxOverlap_OverlapActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnTriggerBoxOverlap_OtherActor_Offset));
		bUS_PatrolCompImpl.OnTriggerBoxOverlap(overlapActor, otherActor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_PatrolCompImpl");
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerBox", Classes.FObjectProperty);
		OnTriggerBoxOverlap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTriggerBoxOverlap");
		OnTriggerBoxOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTriggerBoxOverlap_FunctionAddress);
		OnTriggerBoxOverlap_OverlapActor_Offset = NativeReflection.GetPropertyOffset(OnTriggerBoxOverlap_FunctionAddress, "OverlapActor");
		OnTriggerBoxOverlap_OverlapActor_IsValid = NativeReflection.ValidatePropertyClass(OnTriggerBoxOverlap_FunctionAddress, "OverlapActor", Classes.FObjectProperty);
		OnTriggerBoxOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnTriggerBoxOverlap_FunctionAddress, "OtherActor");
		OnTriggerBoxOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnTriggerBoxOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnTriggerBoxOverlap_IsValid = OnTriggerBoxOverlap_FunctionAddress != IntPtr.Zero && OnTriggerBoxOverlap_OverlapActor_IsValid && OnTriggerBoxOverlap_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_PatrolCompImpl:OnTriggerBoxOverlap", OnTriggerBoxOverlap_IsValid);
	}

	static BUS_PatrolCompImpl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PatrolCompImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PatrolCompImpl));
	}
}
