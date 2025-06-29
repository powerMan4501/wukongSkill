using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset")]
public class BGWGroupAIMgrConfigDataAsset : UBGWDataAsset
{
	private static bool PerformerNumToStart_IsValid;

	private static int PerformerNumToStart_Offset;

	private static bool UpdateDuration_IsValid;

	private static int UpdateDuration_Offset;

	private static bool UpdateDurationForAllocHotZonePoint_IsValid;

	private static int UpdateDurationForAllocHotZonePoint_Offset;

	private static bool MaxAtkMoveTime_IsValid;

	private static int MaxAtkMoveTime_Offset;

	private static bool NormalTaskWaitTime_IsValid;

	private static int NormalTaskWaitTime_Offset;

	private static bool NormalTaskBeginNoiseTimeForMeleeAttacker_IsValid;

	private static int NormalTaskBeginNoiseTimeForMeleeAttacker_Offset;

	private static bool NormalTaskBeginNoiseTimeForRangeAttacker_IsValid;

	private static int NormalTaskBeginNoiseTimeForRangeAttacker_Offset;

	private static bool IsNoMoveAttackInFirstRound_IsValid;

	private static int IsNoMoveAttackInFirstRound_Offset;

	private static FFieldAddress IsNoMoveAttackInFirstRound_PropertyAddress;

	private static bool MeleeAttackTokenNum_IsValid;

	private static int MeleeAttackTokenNum_Offset;

	private static bool RangeAttackTokenNum_IsValid;

	private static int RangeAttackTokenNum_Offset;

	private static bool MinMeleeAttackTokenReplenishedNum_IsValid;

	private static int MinMeleeAttackTokenReplenishedNum_Offset;

	private static bool MinRangeAttackTokenNumWhenReplenished_IsValid;

	private static int MinRangeAttackTokenNumWhenReplenished_Offset;

	private static bool InViewAngleOneSide_IsValid;

	private static int InViewAngleOneSide_Offset;

	private static bool MoveTo_DCParam_Switch2KFTDistance_IsValid;

	private static int MoveTo_DCParam_Switch2KFTDistance_Offset;

	private static bool MoveTo_DCParam_Switch2MoveToDistance_IsValid;

	private static int MoveTo_DCParam_Switch2MoveToDistance_Offset;

	private static bool OutermostCircleWanderNearbyChooseRatio_IsValid;

	private static int OutermostCircleWanderNearbyChooseRatio_Offset;

	private static bool NoteString1_IsValid;

	private static int NoteString1_Offset;

	private static bool InCameraViewportWeight_IsValid;

	private static int InCameraViewportWeight_Offset;

	private static bool OutCameraViewportWeight_IsValid;

	private static int OutCameraViewportWeight_Offset;

	private static bool DistanceScoreWeight_IsValid;

	private static int DistanceScoreWeight_Offset;

	private static bool AngleScoreWeight_IsValid;

	private static int AngleScoreWeight_Offset;

	private static bool LastAttackPerSecondScore_IsValid;

	private static int LastAttackPerSecondScore_Offset;

	private static bool LastAttackPerSecondScoreMax_IsValid;

	private static int LastAttackPerSecondScoreMax_Offset;

	private static bool LockExtraScore_IsValid;

	private static int LockExtraScore_Offset;

	private static bool BossExtraScore_IsValid;

	private static int BossExtraScore_Offset;

	[UMeta(MDProp.ClampMin, 0)]
	[EditAnywhere]
	[Category("CommSetting")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("群体AI启动表演者数量")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:PerformerNumToStart")]
	public int PerformerNumToStart
	{
		get
		{
			CheckDestroyed();
			if (!PerformerNumToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:PerformerNumToStart");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PerformerNumToStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerNumToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:PerformerNumToStart");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PerformerNumToStart_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("观测战场发放战斗Token间隔")]
	[Tooltip("单位：秒")]
	[UMeta(MDProp.ClampMin, 0.1f)]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:UpdateDuration")]
	public float UpdateDuration
	{
		get
		{
			CheckDestroyed();
			if (!UpdateDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:UpdateDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpdateDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:UpdateDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpdateDuration_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0.1f)]
	[Tooltip("单位：秒")]
	[UProperty]
	[Category("CommSetting")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("观测战场发放设置热点间隔")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:UpdateDurationForAllocHotZonePoint")]
	public float UpdateDurationForAllocHotZonePoint
	{
		get
		{
			CheckDestroyed();
			if (!UpdateDurationForAllocHotZonePoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:UpdateDurationForAllocHotZonePoint");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpdateDurationForAllocHotZonePoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateDurationForAllocHotZonePoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:UpdateDurationForAllocHotZonePoint");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpdateDurationForAllocHotZonePoint_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0.1f)]
	[Tooltip("单位：秒，攻击前移动超过这个时间会直接触发攻击")]
	[DisplayName("攻击前最大移动时间")]
	[Category("CommSetting")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MaxAtkMoveTime")]
	public float MaxAtkMoveTime
	{
		get
		{
			CheckDestroyed();
			if (!MaxAtkMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MaxAtkMoveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAtkMoveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAtkMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MaxAtkMoveTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAtkMoveTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("任务最大等待时长")]
	[Tooltip("单位：秒【发出进攻指令后，指令到被执行前最大等待时长】")]
	[UMeta(MDProp.ClampMin, 0f)]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskWaitTime")]
	public float NormalTaskWaitTime
	{
		get
		{
			CheckDestroyed();
			if (!NormalTaskWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskWaitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NormalTaskWaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalTaskWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskWaitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NormalTaskWaitTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0f)]
	[Tooltip("单位：秒【进攻指令执行时，随机等待时长】")]
	[EditAnywhere]
	[Category("CommSetting")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("近战任务开始扰动时间")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskBeginNoiseTimeForMeleeAttacker")]
	public float NormalTaskBeginNoiseTimeForMeleeAttacker
	{
		get
		{
			CheckDestroyed();
			if (!NormalTaskBeginNoiseTimeForMeleeAttacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskBeginNoiseTimeForMeleeAttacker");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NormalTaskBeginNoiseTimeForMeleeAttacker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalTaskBeginNoiseTimeForMeleeAttacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskBeginNoiseTimeForMeleeAttacker");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NormalTaskBeginNoiseTimeForMeleeAttacker_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0f)]
	[Tooltip("单位：秒【进攻指令执行时，随机等待时长】")]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("远程任务开始扰动时间")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskBeginNoiseTimeForRangeAttacker")]
	public float NormalTaskBeginNoiseTimeForRangeAttacker
	{
		get
		{
			CheckDestroyed();
			if (!NormalTaskBeginNoiseTimeForRangeAttacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskBeginNoiseTimeForRangeAttacker");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NormalTaskBeginNoiseTimeForRangeAttacker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalTaskBeginNoiseTimeForRangeAttacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NormalTaskBeginNoiseTimeForRangeAttacker");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NormalTaskBeginNoiseTimeForRangeAttacker_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("第一波群体AI攻击指令不移动")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:IsNoMoveAttackInFirstRound")]
	public bool IsNoMoveAttackInFirstRound
	{
		get
		{
			CheckDestroyed();
			if (!IsNoMoveAttackInFirstRound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:IsNoMoveAttackInFirstRound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNoMoveAttackInFirstRound_Offset), 0, IsNoMoveAttackInFirstRound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNoMoveAttackInFirstRound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:IsNoMoveAttackInFirstRound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNoMoveAttackInFirstRound_Offset), 0, IsNoMoveAttackInFirstRound_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("近战攻击Token数量")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MeleeAttackTokenNum")]
	public int MeleeAttackTokenNum
	{
		get
		{
			CheckDestroyed();
			if (!MeleeAttackTokenNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MeleeAttackTokenNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MeleeAttackTokenNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeleeAttackTokenNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MeleeAttackTokenNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MeleeAttackTokenNum_Offset), value);
			}
		}
	}

	[Category("CommSetting")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("远程攻击Token数量")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:RangeAttackTokenNum")]
	public int RangeAttackTokenNum
	{
		get
		{
			CheckDestroyed();
			if (!RangeAttackTokenNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:RangeAttackTokenNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RangeAttackTokenNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeAttackTokenNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:RangeAttackTokenNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RangeAttackTokenNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("近战攻击Token补充最低数量")]
	[Tooltip("发出去的近战Token如果低于这个值，会找远程Token补充")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MinMeleeAttackTokenReplenishedNum")]
	public int MinMeleeAttackTokenReplenishedNum
	{
		get
		{
			CheckDestroyed();
			if (!MinMeleeAttackTokenReplenishedNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MinMeleeAttackTokenReplenishedNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinMeleeAttackTokenReplenishedNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinMeleeAttackTokenReplenishedNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MinMeleeAttackTokenReplenishedNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinMeleeAttackTokenReplenishedNum_Offset), value);
			}
		}
	}

	[Tooltip("触发了远程Token补充近战后，导致远程Token低于这个值，则只补充大于这个值的部分")]
	[DisplayName("允许远程攻击Token补充最低数量")]
	[Category("CommSetting")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MinRangeAttackTokenNumWhenReplenished")]
	public int MinRangeAttackTokenNumWhenReplenished
	{
		get
		{
			CheckDestroyed();
			if (!MinRangeAttackTokenNumWhenReplenished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MinRangeAttackTokenNumWhenReplenished");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinRangeAttackTokenNumWhenReplenished_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRangeAttackTokenNumWhenReplenished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MinRangeAttackTokenNumWhenReplenished");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinRangeAttackTokenNumWhenReplenished_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("单边视野角度")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:InViewAngleOneSide")]
	public float InViewAngleOneSide
	{
		get
		{
			CheckDestroyed();
			if (!InViewAngleOneSide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:InViewAngleOneSide");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InViewAngleOneSide_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InViewAngleOneSide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:InViewAngleOneSide");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InViewAngleOneSide_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("单位：cm")]
	[UProperty]
	[Category("MoveSetting")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("动态切换KFT和Run距离")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MoveTo_DCParam_Switch2KFTDistance")]
	public int MoveTo_DCParam_Switch2KFTDistance
	{
		get
		{
			CheckDestroyed();
			if (!MoveTo_DCParam_Switch2KFTDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MoveTo_DCParam_Switch2KFTDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveTo_DCParam_Switch2KFTDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveTo_DCParam_Switch2KFTDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MoveTo_DCParam_Switch2KFTDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveTo_DCParam_Switch2KFTDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("MoveSetting")]
	[DisplayName("动态切换None和Sprint距离")]
	[Tooltip("单位：cm; 得比MoveTo_DCParam_Switch2KFTDistance大")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MoveTo_DCParam_Switch2MoveToDistance")]
	public int MoveTo_DCParam_Switch2MoveToDistance
	{
		get
		{
			CheckDestroyed();
			if (!MoveTo_DCParam_Switch2MoveToDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MoveTo_DCParam_Switch2MoveToDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveTo_DCParam_Switch2MoveToDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveTo_DCParam_Switch2MoveToDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:MoveTo_DCParam_Switch2MoveToDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveTo_DCParam_Switch2MoveToDistance_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, 10000)]
	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("万分比。分配到最外圈游走的单位就近选择点的比率，剩下的都是找随机点")]
	[Category("MoveSetting")]
	[DisplayName("最外圈游走就近选择比率")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:OutermostCircleWanderNearbyChooseRatio")]
	public int OutermostCircleWanderNearbyChooseRatio
	{
		get
		{
			CheckDestroyed();
			if (!OutermostCircleWanderNearbyChooseRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:OutermostCircleWanderNearbyChooseRatio");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OutermostCircleWanderNearbyChooseRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutermostCircleWanderNearbyChooseRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:OutermostCircleWanderNearbyChooseRatio");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OutermostCircleWanderNearbyChooseRatio_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("CalcScore")]
	[DisplayName("算分公式：对应攻击优先级 * 在 / 不在镜头内分数权重 * （与玩家角度权重 * cos（与玩家角度）+与玩家距离权重 *（战斗远距离半径 - 与玩家距离）/ 战斗远距离半径 + min{距离上次攻击时间 * 时间加分乘数，距离上次攻击时间加分最大值}）+ 锁定额外加分+ 首领额外加分")]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NoteString1")]
	public byte NoteString1
	{
		get
		{
			CheckDestroyed();
			if (!NoteString1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NoteString1");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, NoteString1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoteString1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:NoteString1");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, NoteString1_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("CalcScore")]
	[DisplayName("在镜头内分数权重")]
	[Tooltip("如果怪在主角视野角度内，使用这个乘数")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.ClampMax, 1)]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:InCameraViewportWeight")]
	public float InCameraViewportWeight
	{
		get
		{
			CheckDestroyed();
			if (!InCameraViewportWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:InCameraViewportWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraViewportWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraViewportWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:InCameraViewportWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraViewportWeight_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.ClampMax, 1)]
	[DisplayName("不在镜头内分数权重")]
	[Category("CalcScore")]
	[BlueprintReadWrite]
	[Tooltip("如果怪不在主角视野角度内，使用这个乘数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:OutCameraViewportWeight")]
	public float OutCameraViewportWeight
	{
		get
		{
			CheckDestroyed();
			if (!OutCameraViewportWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:OutCameraViewportWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutCameraViewportWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutCameraViewportWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:OutCameraViewportWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutCameraViewportWeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CalcScore")]
	[DisplayName("与玩家距离权重")]
	[Tooltip("怪物与玩家距离计算打分参数之后的乘数")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:DistanceScoreWeight")]
	public float DistanceScoreWeight
	{
		get
		{
			CheckDestroyed();
			if (!DistanceScoreWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:DistanceScoreWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceScoreWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceScoreWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:DistanceScoreWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceScoreWeight_Offset), value);
			}
		}
	}

	[Tooltip("怪物与玩家角度计算余弦之后的乘数")]
	[UProperty]
	[Category("CalcScore")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("与玩家角度权重")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:AngleScoreWeight")]
	public float AngleScoreWeight
	{
		get
		{
			CheckDestroyed();
			if (!AngleScoreWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:AngleScoreWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleScoreWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleScoreWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:AngleScoreWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleScoreWeight_Offset), value);
			}
		}
	}

	[Tooltip("距离上次攻击时间（单位秒）乘上这个值，获得一个加分")]
	[UProperty]
	[Category("CalcScore")]
	[BlueprintReadWrite]
	[DisplayName("距离上次攻击时间加分")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LastAttackPerSecondScore")]
	public float LastAttackPerSecondScore
	{
		get
		{
			CheckDestroyed();
			if (!LastAttackPerSecondScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LastAttackPerSecondScore");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LastAttackPerSecondScore_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastAttackPerSecondScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LastAttackPerSecondScore");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LastAttackPerSecondScore_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CalcScore")]
	[DisplayName("距离上次攻击时间加分最大值")]
	[Tooltip("时间加分不会无限累积，最大只会加这么多分")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LastAttackPerSecondScoreMax")]
	public float LastAttackPerSecondScoreMax
	{
		get
		{
			CheckDestroyed();
			if (!LastAttackPerSecondScoreMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LastAttackPerSecondScoreMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LastAttackPerSecondScoreMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastAttackPerSecondScoreMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LastAttackPerSecondScoreMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LastAttackPerSecondScoreMax_Offset), value);
			}
		}
	}

	[Tooltip("如果怪物是玩家当前的锁定目标，额外给这个怪加这么多分")]
	[EditAnywhere]
	[Category("CalcScore")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("锁定额外加分")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LockExtraScore")]
	public float LockExtraScore
	{
		get
		{
			CheckDestroyed();
			if (!LockExtraScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LockExtraScore");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockExtraScore_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockExtraScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:LockExtraScore");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockExtraScore_Offset), value);
			}
		}
	}

	[Tooltip("如果怪物AI被标记为首领，将获得额外加分")]
	[BlueprintReadWrite]
	[Category("CalcScore")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("首领额外加分")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:BossExtraScore")]
	public float BossExtraScore
	{
		get
		{
			CheckDestroyed();
			if (!BossExtraScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:BossExtraScore");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BossExtraScore_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BossExtraScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset:BossExtraScore");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BossExtraScore_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWGroupAIMgrConfigDataAsset");
		PerformerNumToStart_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformerNumToStart");
		PerformerNumToStart_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformerNumToStart", Classes.FIntProperty);
		UpdateDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpdateDuration");
		UpdateDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpdateDuration", Classes.FFloatProperty);
		UpdateDurationForAllocHotZonePoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpdateDurationForAllocHotZonePoint");
		UpdateDurationForAllocHotZonePoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpdateDurationForAllocHotZonePoint", Classes.FFloatProperty);
		MaxAtkMoveTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxAtkMoveTime");
		MaxAtkMoveTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxAtkMoveTime", Classes.FFloatProperty);
		NormalTaskWaitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalTaskWaitTime");
		NormalTaskWaitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalTaskWaitTime", Classes.FFloatProperty);
		NormalTaskBeginNoiseTimeForMeleeAttacker_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalTaskBeginNoiseTimeForMeleeAttacker");
		NormalTaskBeginNoiseTimeForMeleeAttacker_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalTaskBeginNoiseTimeForMeleeAttacker", Classes.FFloatProperty);
		NormalTaskBeginNoiseTimeForRangeAttacker_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalTaskBeginNoiseTimeForRangeAttacker");
		NormalTaskBeginNoiseTimeForRangeAttacker_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalTaskBeginNoiseTimeForRangeAttacker", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsNoMoveAttackInFirstRound_PropertyAddress, unrealStruct, "IsNoMoveAttackInFirstRound");
		IsNoMoveAttackInFirstRound_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsNoMoveAttackInFirstRound");
		IsNoMoveAttackInFirstRound_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsNoMoveAttackInFirstRound", Classes.FBoolProperty);
		MeleeAttackTokenNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeleeAttackTokenNum");
		MeleeAttackTokenNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeleeAttackTokenNum", Classes.FIntProperty);
		RangeAttackTokenNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RangeAttackTokenNum");
		RangeAttackTokenNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RangeAttackTokenNum", Classes.FIntProperty);
		MinMeleeAttackTokenReplenishedNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinMeleeAttackTokenReplenishedNum");
		MinMeleeAttackTokenReplenishedNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinMeleeAttackTokenReplenishedNum", Classes.FIntProperty);
		MinRangeAttackTokenNumWhenReplenished_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinRangeAttackTokenNumWhenReplenished");
		MinRangeAttackTokenNumWhenReplenished_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinRangeAttackTokenNumWhenReplenished", Classes.FIntProperty);
		InViewAngleOneSide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InViewAngleOneSide");
		InViewAngleOneSide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InViewAngleOneSide", Classes.FFloatProperty);
		MoveTo_DCParam_Switch2KFTDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveTo_DCParam_Switch2KFTDistance");
		MoveTo_DCParam_Switch2KFTDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveTo_DCParam_Switch2KFTDistance", Classes.FIntProperty);
		MoveTo_DCParam_Switch2MoveToDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveTo_DCParam_Switch2MoveToDistance");
		MoveTo_DCParam_Switch2MoveToDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveTo_DCParam_Switch2MoveToDistance", Classes.FIntProperty);
		OutermostCircleWanderNearbyChooseRatio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OutermostCircleWanderNearbyChooseRatio");
		OutermostCircleWanderNearbyChooseRatio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OutermostCircleWanderNearbyChooseRatio", Classes.FIntProperty);
		NoteString1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoteString1");
		NoteString1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoteString1", Classes.FByteProperty);
		InCameraViewportWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InCameraViewportWeight");
		InCameraViewportWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InCameraViewportWeight", Classes.FFloatProperty);
		OutCameraViewportWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OutCameraViewportWeight");
		OutCameraViewportWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OutCameraViewportWeight", Classes.FFloatProperty);
		DistanceScoreWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceScoreWeight");
		DistanceScoreWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceScoreWeight", Classes.FFloatProperty);
		AngleScoreWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AngleScoreWeight");
		AngleScoreWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AngleScoreWeight", Classes.FFloatProperty);
		LastAttackPerSecondScore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LastAttackPerSecondScore");
		LastAttackPerSecondScore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LastAttackPerSecondScore", Classes.FFloatProperty);
		LastAttackPerSecondScoreMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LastAttackPerSecondScoreMax");
		LastAttackPerSecondScoreMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LastAttackPerSecondScoreMax", Classes.FFloatProperty);
		LockExtraScore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockExtraScore");
		LockExtraScore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockExtraScore", Classes.FFloatProperty);
		BossExtraScore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BossExtraScore");
		BossExtraScore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BossExtraScore", Classes.FFloatProperty);
	}

	static BGWGroupAIMgrConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWGroupAIMgrConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWGroupAIMgrConfigDataAsset));
	}
}
