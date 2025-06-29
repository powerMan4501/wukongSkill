using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Attack IK")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSAttackIK")]
internal class BANS_GSAttackIK : BANS_GSBase
{
	private FVector IKOffset;

	private float Timer;

	private float TotalTime;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	private static bool AttackReferencePos_IsValid;

	private static int AttackReferencePos_Offset;

	private static bool TouchIKType_IsValid;

	private static int TouchIKType_Offset;

	private static FFieldAddress TouchIKType_PropertyAddress;

	private static bool OffsetRangeMin_IsValid;

	private static int OffsetRangeMin_Offset;

	private static bool OffsetRangeMax_IsValid;

	private static int OffsetRangeMax_Offset;

	private static bool bDrawDebugRange_IsValid;

	private static int bDrawDebugRange_Offset;

	private static FFieldAddress bDrawDebugRange_PropertyAddress;

	private static bool DebugCapsuleThickness_IsValid;

	private static int DebugCapsuleThickness_Offset;

	private static bool DebugBoxThickness_IsValid;

	private static int DebugBoxThickness_Offset;

	private static bool bUseFullBodyIK_IsValid;

	private static int bUseFullBodyIK_Offset;

	private static FFieldAddress bUseFullBodyIK_PropertyAddress;

	private static bool AttackIKType_IsValid;

	private static int AttackIKType_Offset;

	private static FFieldAddress AttackIKType_PropertyAddress;

	private static bool AttackIKBonePairList_IsValid;

	private static int AttackIKBonePairList_Offset;

	private static FFieldAddress AttackIKBonePairList_PropertyAddress;

	private TArrayReadWriteMarshaler<FAttackIKBonePairs> AttackIKBonePairList_Marshaler;

	private static bool FishSpikeJumpType_IsValid;

	private static int FishSpikeJumpType_Offset;

	private static FFieldAddress FishSpikeJumpType_PropertyAddress;

	private static bool FishSpikeDistance_IsValid;

	private static int FishSpikeDistance_Offset;

	private static bool JumpMax_IsValid;

	private static int JumpMax_Offset;

	private static bool DebugFishSpikeEnable_IsValid;

	private static int DebugFishSpikeEnable_Offset;

	private static FFieldAddress DebugFishSpikeEnable_PropertyAddress;

	private static bool BoneScaleEnable_IsValid;

	private static int BoneScaleEnable_Offset;

	private static FFieldAddress BoneScaleEnable_PropertyAddress;

	private static bool BoneScaleData_IsValid;

	private static int BoneScaleData_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UMeta(MDProp.ClampMin, "0")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:AttackReferencePos")]
	public FVector AttackReferencePos
	{
		get
		{
			CheckDestroyed();
			if (!AttackReferencePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:AttackReferencePos");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, AttackReferencePos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackReferencePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:AttackReferencePos");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, AttackReferencePos_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:TouchIKType")]
	public ETouchIKType TouchIKType
	{
		get
		{
			CheckDestroyed();
			if (!TouchIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:TouchIKType");
				return ETouchIKType.LeftHand;
			}
			return EnumMarshaler<ETouchIKType>.FromNative(IntPtr.Add(base.Address, TouchIKType_Offset), 0, TouchIKType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TouchIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:TouchIKType");
			}
			else
			{
				EnumMarshaler<ETouchIKType>.ToNative(IntPtr.Add(base.Address, TouchIKType_Offset), 0, TouchIKType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:OffsetRangeMin")]
	public FVector OffsetRangeMin
	{
		get
		{
			CheckDestroyed();
			if (!OffsetRangeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:OffsetRangeMin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, OffsetRangeMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetRangeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:OffsetRangeMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, OffsetRangeMin_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:OffsetRangeMax")]
	public FVector OffsetRangeMax
	{
		get
		{
			CheckDestroyed();
			if (!OffsetRangeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:OffsetRangeMax");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, OffsetRangeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetRangeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:OffsetRangeMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, OffsetRangeMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:bDrawDebugRange")]
	public bool bDrawDebugRange
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebugRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:bDrawDebugRange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebugRange_Offset), 0, bDrawDebugRange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebugRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:bDrawDebugRange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebugRange_Offset), 0, bDrawDebugRange_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:DebugCapsuleThickness")]
	public float DebugCapsuleThickness
	{
		get
		{
			CheckDestroyed();
			if (!DebugCapsuleThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:DebugCapsuleThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugCapsuleThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugCapsuleThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:DebugCapsuleThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugCapsuleThickness_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:DebugBoxThickness")]
	public float DebugBoxThickness
	{
		get
		{
			CheckDestroyed();
			if (!DebugBoxThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:DebugBoxThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugBoxThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugBoxThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:DebugBoxThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugBoxThickness_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:bUseFullBodyIK")]
	public bool bUseFullBodyIK
	{
		get
		{
			CheckDestroyed();
			if (!bUseFullBodyIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:bUseFullBodyIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseFullBodyIK_Offset), 0, bUseFullBodyIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseFullBodyIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:bUseFullBodyIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseFullBodyIK_Offset), 0, bUseFullBodyIK_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("攻击IK模式")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:AttackIKType")]
	public EAttackIKType AttackIKType
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:AttackIKType");
				return EAttackIKType.None;
			}
			return EnumMarshaler<EAttackIKType>.FromNative(IntPtr.Add(base.Address, AttackIKType_Offset), 0, AttackIKType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttackIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:AttackIKType");
			}
			else
			{
				EnumMarshaler<EAttackIKType>.ToNative(IntPtr.Add(base.Address, AttackIKType_Offset), 0, AttackIKType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("攻击IK骨链设置")]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:AttackIKBonePairList")]
	public TArrayReadWrite<FAttackIKBonePairs> AttackIKBonePairList
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKBonePairList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:AttackIKBonePairList");
				return null;
			}
			if (AttackIKBonePairList_Marshaler == null)
			{
				AttackIKBonePairList_Marshaler = new TArrayReadWriteMarshaler<FAttackIKBonePairs>(1, AttackIKBonePairList_PropertyAddress, CachedMarshalingDelegates<FAttackIKBonePairs, FAttackIKBonePairs>.FromNative, CachedMarshalingDelegates<FAttackIKBonePairs, FAttackIKBonePairs>.ToNative);
			}
			return AttackIKBonePairList_Marshaler.FromNative(IntPtr.Add(base.Address, AttackIKBonePairList_Offset));
		}
	}

	[Category("Anim Notify")]
	[DisplayName("范围跳跃模式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:FishSpikeJumpType")]
	public FishSpikeJumpType FishSpikeJumpType
	{
		get
		{
			CheckDestroyed();
			if (!FishSpikeJumpType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:FishSpikeJumpType");
				return FishSpikeJumpType.Default;
			}
			return EnumMarshaler<FishSpikeJumpType>.FromNative(IntPtr.Add(base.Address, FishSpikeJumpType_Offset), 0, FishSpikeJumpType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FishSpikeJumpType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:FishSpikeJumpType");
			}
			else
			{
				EnumMarshaler<FishSpikeJumpType>.ToNative(IntPtr.Add(base.Address, FishSpikeJumpType_Offset), 0, FishSpikeJumpType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("咸鱼突刺距离")]
	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:FishSpikeDistance")]
	public float FishSpikeDistance
	{
		get
		{
			CheckDestroyed();
			if (!FishSpikeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:FishSpikeDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FishSpikeDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FishSpikeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:FishSpikeDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FishSpikeDistance_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[DisplayName("最大跳跃距离")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:JumpMax")]
	public float JumpMax
	{
		get
		{
			CheckDestroyed();
			if (!JumpMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:JumpMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:JumpMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[DisplayName("范围跳跃debug")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:DebugFishSpikeEnable")]
	public bool DebugFishSpikeEnable
	{
		get
		{
			CheckDestroyed();
			if (!DebugFishSpikeEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:DebugFishSpikeEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugFishSpikeEnable_Offset), 0, DebugFishSpikeEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugFishSpikeEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:DebugFishSpikeEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugFishSpikeEnable_Offset), 0, DebugFishSpikeEnable_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[DisplayName("开启追踪缩放")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:BoneScaleEnable")]
	public bool BoneScaleEnable
	{
		get
		{
			CheckDestroyed();
			if (!BoneScaleEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BoneScaleEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BoneScaleEnable_Offset), 0, BoneScaleEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BoneScaleEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BoneScaleEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BoneScaleEnable_Offset), 0, BoneScaleEnable_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("追踪缩放数据")]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:BoneScaleData")]
	public FAttackIKBoneScale BoneScaleData
	{
		get
		{
			CheckDestroyed();
			if (!BoneScaleData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BoneScaleData");
				return default(FAttackIKBoneScale);
			}
			return BlittableTypeMarshaler<FAttackIKBoneScale>.FromNative(IntPtr.Add(base.Address, BoneScaleData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneScaleData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIK:BoneScaleData");
			}
			else
			{
				BlittableTypeMarshaler<FAttackIKBoneScale>.ToNative(IntPtr.Add(base.Address, BoneScaleData_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DebugCapsuleThickness = 1f;
		DebugBoxThickness = 4f;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null || aCharacter.Mesh == null)
		{
			return;
		}
		IBUC_ABPFootIKData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPFootIKData>(aCharacter);
		if (unPersistentReadOnlyData != null)
		{
			if (!unPersistentReadOnlyData.bActiveTouchIK)
			{
				return;
			}
			float x = 0f;
			if (Timer <= BlendInTime)
			{
				x = Timer / BlendInTime;
			}
			else if (Timer < TotalTime - BlendOutTime)
			{
				x = 1f;
			}
			else if (Timer >= TotalTime - BlendOutTime)
			{
				x = (TotalTime - Timer) / BlendOutTime;
			}
			x = FMath.Clamp(x, 0f, 1f);
			BUS_EventCollectionCS.Get(aCharacter).Evt_SetTouchIKInfo.Invoke(TouchIKType, IKOffset, FVector.ZeroVector, x);
		}
		IBUC_ABPAttackIKData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPAttackIKData>(aCharacter);
		if (unPersistentReadOnlyData2 != null)
		{
			if (unPersistentReadOnlyData2.EnableAttackIK)
			{
				float x2 = 0f;
				if (Timer <= BlendInTime)
				{
					x2 = Timer / BlendInTime;
				}
				else if (Timer < TotalTime - BlendOutTime)
				{
					x2 = 1f;
				}
				else if (Timer >= TotalTime - BlendOutTime)
				{
					x2 = (TotalTime - Timer) / BlendOutTime;
				}
				x2 = FMath.Clamp(x2, 0f, 1f);
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKAlpha.Invoke(x2);
				if (unPersistentReadOnlyData2.AttackIKType == EAttackIKType.FishSpike)
				{
					float alpha = Timer / TotalTime;
					BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKFishSpikeAlpha.Invoke(alpha);
				}
				if (unPersistentReadOnlyData2.BoneScaleEnable)
				{
					BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKBoneScaleAlpha.Invoke(x2);
				}
			}
			else
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKAlpha.Invoke(0f);
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKFishSpikeAlpha.Invoke(0f);
			}
		}
		Timer += FrameDeltaTime;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			BUS_EventCollectionCS.Get(aCharacter).Evt_SetTouchIKActive.Invoke(P1: false, bUseFullBodyIK);
			BUS_EventCollectionCS.Get(aCharacter).Evt_SetTouchIKInfo.Invoke(TouchIKType, FVector.ZeroVector, FVector.ZeroVector, 0f);
			if (EAttackIKType.FishSpike != AttackIKType && AttackIKType != EAttackIKType.None)
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKTargetActor.Invoke(null, enableAttackPlaneIK: false, EAttackIKType.None, null);
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKAlpha.Invoke(0f);
			}
			else if (EAttackIKType.FishSpike == AttackIKType)
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKFishSpike.Invoke(null, null, enableAttackPlaneIK: false, 0f, 0f, FishSpikeJumpType.None, DebugEnable: false);
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKFishSpikeAlpha.Invoke(0f);
			}
			if (BoneScaleEnable)
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKBoneScale.Invoke(null, InBoneScaleEnable: false, BoneScaleData);
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKBoneScaleAlpha.Invoke(0f);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (OffsetRangeMin.X > 0f || OffsetRangeMin.Y > 0f || OffsetRangeMin.Z > 0f || OffsetRangeMax.X < 0f || OffsetRangeMax.Y < 0f || OffsetRangeMax.Z < 0f)
		{
			return;
		}
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner) && bDrawDebugRange)
		{
			DrawDebugOffsetRange(NotifyParam.owner.GetRootComponent());
		}
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null || aCharacter.Mesh == null)
		{
			return;
		}
		BUS_EventCollectionCS.Get(aCharacter).Evt_SetTouchIKActive.Invoke(P1: true, bUseFullBodyIK);
		ACharacter aCharacter2 = BGUFunctionLibraryCS.BGUGetTarget(aCharacter) as ACharacter;
		if (aCharacter2 == null)
		{
			return;
		}
		if (AttackIKType != EAttackIKType.None)
		{
			if (EAttackIKType.FishSpike != AttackIKType)
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKTargetActor.Invoke(aCharacter2, enableAttackPlaneIK: true, AttackIKType, AttackIKBonePairList);
			}
			else
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKFishSpike.Invoke(aCharacter, aCharacter2, enableAttackPlaneIK: true, FishSpikeDistance, JumpMax, FishSpikeJumpType, DebugFishSpikeEnable);
			}
		}
		if (BoneScaleEnable)
		{
			BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKBoneScale.Invoke(aCharacter2, InBoneScaleEnable: true, BoneScaleData);
			BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttackIKBoneScaleAlpha.Invoke(0f);
		}
		FVector location = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter2);
		BUS_EventCollectionCS.Get(aCharacter).Evt_SetTouchIKInfo.Invoke(TouchIKType, FVector.ZeroVector, FVector.ZeroVector, 0f);
		FVector fVector = MathLib.InverseTransformLocation(aCharacter.Mesh.GetWorldTransform(), location);
		MathLib.TransformLocation(aCharacter.Mesh.GetWorldTransform(), AttackReferencePos);
		IKOffset = fVector - AttackReferencePos;
		float num = new FBox(OffsetRangeMin, OffsetRangeMax).ComputeSquaredDistanceToPoint(IKOffset);
		if (num > 0f)
		{
			float num2 = IKOffset.Size();
			FVector fVector2 = IKOffset.Normal();
			IKOffset = fVector2 * (num2 - FMath.Sqrt(num));
		}
		Timer = 0f;
		TotalTime = TotalDuration;
	}

	private void DrawDebugOffsetRange(USceneComponent RootComponent)
	{
		FVector location = new FVector
		{
			X = (AttackReferencePos.X + OffsetRangeMin.X + AttackReferencePos.X + OffsetRangeMax.X) / 2f,
			Y = (AttackReferencePos.Y + OffsetRangeMin.Y + AttackReferencePos.Y + OffsetRangeMax.Y) / 2f,
			Z = (AttackReferencePos.Z + OffsetRangeMin.Z + AttackReferencePos.Z + OffsetRangeMax.Z) / 2f
		};
		FVector extent = new FVector
		{
			X = AttackReferencePos.X + OffsetRangeMax.X - location.X,
			Y = AttackReferencePos.Y + OffsetRangeMax.Y - location.Y,
			Z = AttackReferencePos.Z + OffsetRangeMax.Z - location.Z
		};
		FVector center = MathLib.TransformLocation(RootComponent.GetWorldTransform(), AttackReferencePos);
		FVector center2 = MathLib.TransformLocation(RootComponent.GetWorldTransform(), location);
		USystemLibrary.DrawDebugCapsule(RootComponent, center, 96f, 42f, RootComponent.GetWorldRotation(), FLinearColor.Blue, 2f, DebugCapsuleThickness);
		USystemLibrary.DrawDebugBox(RootComponent, center2, extent, FLinearColor.Red, RootComponent.GetWorldRotation(), 2f, DebugBoxThickness);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackIK bANS_GSAttackIK = GCHelper.Find<b1.BANS_GSAttackIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttackIK.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackIK bANS_GSAttackIK = GCHelper.Find<b1.BANS_GSAttackIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSAttackIK.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackIK bANS_GSAttackIK = GCHelper.Find<b1.BANS_GSAttackIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttackIK.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttackIK");
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		AttackReferencePos_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackReferencePos");
		AttackReferencePos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackReferencePos", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TouchIKType_PropertyAddress, intPtr, "TouchIKType");
		TouchIKType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchIKType");
		TouchIKType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchIKType", Classes.FEnumProperty);
		OffsetRangeMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetRangeMin");
		OffsetRangeMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetRangeMin", Classes.FStructProperty);
		OffsetRangeMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetRangeMax");
		OffsetRangeMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetRangeMax", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebugRange_PropertyAddress, intPtr, "bDrawDebugRange");
		bDrawDebugRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawDebugRange");
		bDrawDebugRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawDebugRange", Classes.FBoolProperty);
		DebugCapsuleThickness_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugCapsuleThickness");
		DebugCapsuleThickness_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugCapsuleThickness", Classes.FFloatProperty);
		DebugBoxThickness_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugBoxThickness");
		DebugBoxThickness_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugBoxThickness", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bUseFullBodyIK_PropertyAddress, intPtr, "bUseFullBodyIK");
		bUseFullBodyIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseFullBodyIK");
		bUseFullBodyIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseFullBodyIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AttackIKType_PropertyAddress, intPtr, "AttackIKType");
		AttackIKType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKType");
		AttackIKType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttackIKBonePairList_PropertyAddress, intPtr, "AttackIKBonePairList");
		AttackIKBonePairList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKBonePairList");
		AttackIKBonePairList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKBonePairList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FishSpikeJumpType_PropertyAddress, intPtr, "FishSpikeJumpType");
		FishSpikeJumpType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FishSpikeJumpType");
		FishSpikeJumpType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FishSpikeJumpType", Classes.FEnumProperty);
		FishSpikeDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "FishSpikeDistance");
		FishSpikeDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FishSpikeDistance", Classes.FFloatProperty);
		JumpMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpMax");
		JumpMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpMax", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DebugFishSpikeEnable_PropertyAddress, intPtr, "DebugFishSpikeEnable");
		DebugFishSpikeEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugFishSpikeEnable");
		DebugFishSpikeEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugFishSpikeEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BoneScaleEnable_PropertyAddress, intPtr, "BoneScaleEnable");
		BoneScaleEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneScaleEnable");
		BoneScaleEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneScaleEnable", Classes.FBoolProperty);
		BoneScaleData_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneScaleData");
		BoneScaleData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneScaleData", Classes.FStructProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackIK:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAttackIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAttackIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAttackIK));
	}
}
