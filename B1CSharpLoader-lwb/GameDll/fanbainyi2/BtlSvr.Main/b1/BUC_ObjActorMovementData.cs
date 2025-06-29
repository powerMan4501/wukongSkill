using System;
using b1.ECS;
using BtlShare;
using GUR.Runtime;
using GurGsReplicate;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ObjActorMovementData : IBUC_ObjActorMovementData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public ObjActorMovementData[] _RepData = new ObjActorMovementData[64];

	private bool __UseSimpleMove_Raw;

	public bool bForceUseProjectileMovementComp;

	public FVector StartLocation;

	public FVector TargetPosAtSpawn;

	public bool AttachToTargetWhenTraceOver;

	public FVector CurVelocity { get; set; }

	public EBulletOrMagicFieldMoveModeType MoveMode { get; set; }

	[GSReplicated]
	public bool UseSimpleMove
	{
		get
		{
			return __UseSimpleMove_Raw;
		}
		set
		{
			bool _UseSimpleMove_Raw = __UseSimpleMove_Raw;
			__UseSimpleMove_Raw = value;
			OnUseSimpleMoveChg_Invoke(_UseSimpleMove_Raw, value);
		}
	}

	public EProjectileObjSpdType SpeedType { get; set; }

	public FSpawnBulletSpeed BulletFlySpd { get; set; }

	public FSpawnBulletSpeed BulletRotSpd { get; set; }

	public float ProjectileFlySpdCurveTimer { get; set; }

	public float ProjectileRotSpdCurveTimer { get; set; }

	public float SpdScaleValue { get; set; }

	public int TotalNumInAWave { get; set; }

	public int SelfIndexInAWave { get; set; }

	public float OriginalFlyTime { get; set; }

	public float FlyTime { get; set; }

	public AActor TargetActor { get; set; }

	public bool bUseSocket_Target { get; set; }

	public string TargetSocketName { get; set; }

	public bool UseRangeTargetOffset { get; set; }

	public FVector TargetPos { get; set; }

	public FGSTargetOffsetInfo TargetOffsetInfo { get; set; }

	public EBGUBulletTraceType TraceType { get; set; }

	public float TraceTime { get; set; }

	public bool CloseZTrace { get; set; }

	public bool TraceOverTriggerLifeOverEffect { get; set; }

	public bool TraceOverSwitchToStraightMode { get; set; }

	public EInertialState InertialState { get; set; }

	public UCurveFloat InertialRotSpdCurve { get; set; }

	public UCurveFloat InertialTraceSpdCurve { get; set; }

	public float InertialTraceRadius { get; set; }

	public float InertialTraceTime { get; set; }

	public float OriginalInertialTraceTime { get; set; }

	public float InertialDecreaseTime { get; set; }

	public float OriginalInertialDecreaseTime { get; set; }

	public float InertialAdjustTransTime { get; set; }

	public float OriginalInertialAdjustTransTime { get; set; }

	public UCurveVector ManualMoveCurve { get; set; }

	public FVector TargetVector { get; set; }

	public FVector BulletOriPos { get; set; }

	public float ManualMoveCurveTimer { get; set; }

	public bool ByTimeOrDis { get; set; }

	public float MaxCurveLen { get; set; }

	public float CurDis { get; set; }

	public float OriDis { get; set; }

	public float DefaultOriDis { get; set; }

	public FVector LastBulletPos { get; set; }

	public FVector OriTargetPos { get; set; }

	public bool IsFaceTarget { get; set; }

	public bool UseSocketAsNest { get; set; }

	public FName NestName { get; set; }

	public float Top_X { get; set; }

	public float Top_Y { get; set; }

	public float TargetShortestDist_Hor { get; set; }

	public float TargetFurthestDist_Hor { get; set; }

	public ECircleSurround_CenterType CenterType { get; set; }

	public ECircleSurround_RadiusType RadiusType { get; set; }

	public ECircleSurround_SpdType SpdType { get; set; }

	public ECircleSurround_RotType RotType { get; set; }

	public ECircleSurround_UpAxisType UpAxisType { get; set; }

	public TWeakObject<USplineComponent> SplineCompPtr { get; set; }

	public bool TriggerLifeOver_SplineMoveEnd { get; set; }

	public bool RotAlignToSpline { get; set; }

	public float RadiusSurCurveTimer { get; set; }

	public UCurveFloat RadiusCurve { get; set; }

	public float StaticRadius { get; set; }

	public float CircleHeightOffset { get; set; }

	public UCurveFloat SelfRotCurve { get; set; }

	public FBM_MoveConstraintType MoveConstraintType_FBM { get; set; }

	public float MotionRadius_FBM { get; set; }

	public int FractalLevel_FBM { get; set; }

	public float SpdScale_FBM { get; set; }

	public bool MoveClampToLand { get; set; }

	public bool MoveAlignToLand { get; set; }

	public float BulletNowRotSpd { get; set; }

	public event Action<bool, bool> OnUseSimpleMoveChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public ObjActorMovementData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		ObjActorMovementData objActorMovementData = _RepData[__LocalRepVersion % 64];
		if (objActorMovementData == null)
		{
			objActorMovementData = new ObjActorMovementData();
			_RepData[__LocalRepVersion % 64] = objActorMovementData;
		}
		else if (flag)
		{
			objActorMovementData.ClearUseSimpleMove();
		}
		return objActorMovementData;
	}

	public ObjActorMovementData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		ObjActorMovementData objActorMovementData = new ObjActorMovementData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"ObjActorMovementData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			objActorMovementData.UseSimpleMove = UseSimpleMove;
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					ObjActorMovementData other = _RepData[i % 64];
					objActorMovementData.MergeFrom(other);
				}
			}
		}
		return objActorMovementData;
	}

	private void OnUseSimpleMoveChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().UseSimpleMove = NewValue;
			}
			this.OnUseSimpleMoveChg?.Invoke(OldValue, NewValue);
		}
	}

	public BUC_ObjActorMovementData()
	{
		MoveMode = EBulletOrMagicFieldMoveModeType.None;
		UseSimpleMove = false;
		ProjectileFlySpdCurveTimer = 0f;
		ProjectileRotSpdCurveTimer = 0f;
		TargetActor = null;
		TargetOffsetInfo = new FGSTargetOffsetInfo();
		FlyTime = 0f;
		TraceType = EBGUBulletTraceType.None;
		TraceTime = -1f;
		CloseZTrace = false;
		TraceOverTriggerLifeOverEffect = false;
		TraceOverSwitchToStraightMode = false;
		InertialState = EInertialState.None;
		InertialRotSpdCurve = null;
		InertialTraceSpdCurve = null;
		InertialDecreaseTime = 0f;
		InertialAdjustTransTime = 0f;
		InertialTraceTime = 0f;
		UseSocketAsNest = false;
		NestName = default(FName);
		SpdScaleValue = 1f;
		CenterType = ECircleSurround_CenterType.None;
		RadiusType = ECircleSurround_RadiusType.None;
		UpAxisType = ECircleSurround_UpAxisType.None;
		SpdType = ECircleSurround_SpdType.None;
		RotType = ECircleSurround_RotType.None;
	}

	public void InitBulletNowRotSpd()
	{
		if (BulletRotSpd.SpdCurve != null)
		{
			BulletNowRotSpd = BulletRotSpd.SpdCurve.GetFloatValue(0f);
		}
		else
		{
			BulletNowRotSpd = BulletRotSpd.Spd.LeftValue;
		}
	}

	public void UpdateRotSpd(float DeltaTime)
	{
		if (BulletRotSpd.SpdCurve == null)
		{
			if (BulletRotSpd.AccelerationTime > 0f)
			{
				float num = BulletRotSpd.Spd.RightValue - BulletRotSpd.Spd.LeftValue;
				BulletNowRotSpd += num / BulletRotSpd.AccelerationTime * DeltaTime;
				if (num > 0f)
				{
					BulletNowRotSpd = MathLib.Clamp(BulletNowRotSpd, BulletRotSpd.Spd.LeftValue, BulletRotSpd.Spd.RightValue);
				}
				else
				{
					BulletNowRotSpd = MathLib.Clamp(BulletNowRotSpd, BulletRotSpd.Spd.RightValue, BulletRotSpd.Spd.LeftValue);
				}
			}
			else if (BulletRotSpd.AccelerationTime == 0f)
			{
				BulletNowRotSpd = ((BulletRotSpd.Spd.RightValue > BulletRotSpd.Spd.LeftValue) ? BulletRotSpd.Spd.RightValue : BulletRotSpd.Spd.LeftValue);
			}
		}
		else
		{
			BulletNowRotSpd = BulletRotSpd.SpdCurve.GetFloatValue(ProjectileRotSpdCurveTimer);
		}
	}
}
