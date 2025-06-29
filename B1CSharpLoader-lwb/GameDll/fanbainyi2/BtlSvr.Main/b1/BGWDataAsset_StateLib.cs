using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib")]
public class BGWDataAsset_StateLib : UBGWDataAsset
{
	private static bool LeftSmallTurnSkillID_IsValid;

	private static int LeftSmallTurnSkillID_Offset;

	private static bool RightSmallTurnSkillID_IsValid;

	private static int RightSmallTurnSkillID_Offset;

	private static bool LeftBigTurnSkillID_IsValid;

	private static int LeftBigTurnSkillID_Offset;

	private static bool RightBigTurnSkillID_IsValid;

	private static int RightBigTurnSkillID_Offset;

	private static bool ArmorSetting_IsValid;

	private static int ArmorSetting_Offset;

	private static bool MoveSpeedFast_IsValid;

	private static int MoveSpeedFast_Offset;

	private static bool MoveSpeedNormal_IsValid;

	private static int MoveSpeedNormal_Offset;

	private static bool MoveSpeedSlow_IsValid;

	private static int MoveSpeedSlow_Offset;

	private static bool ABPSetting_IsValid;

	private static int ABPSetting_Offset;

	private static bool BeAttackedInfoID_IsValid;

	private static int BeAttackedInfoID_Offset;

	private static bool UnitCameraID_IsValid;

	private static int UnitCameraID_Offset;

	private static bool DeadInfoID_IsValid;

	private static int DeadInfoID_Offset;

	private static bool MovementMode_IsValid;

	private static int MovementMode_Offset;

	private static FFieldAddress MovementMode_PropertyAddress;

	private static bool PartRuleID_IsValid;

	private static int PartRuleID_Offset;

	private static bool DodgeSkillID_IsValid;

	private static int DodgeSkillID_Offset;

	private static bool PreciseDodgeSkillID_IsValid;

	private static int PreciseDodgeSkillID_Offset;

	private static bool AMScaleMaxRate_IsValid;

	private static int AMScaleMaxRate_Offset;

	private static bool SpecialBoneConfig_IsValid;

	private static int SpecialBoneConfig_Offset;

	private static bool BodiesNameList_BodiesCollisionEnable_IsValid;

	private static int BodiesNameList_BodiesCollisionEnable_Offset;

	private static FFieldAddress BodiesNameList_BodiesCollisionEnable_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BodiesNameList_BodiesCollisionEnable_Marshaler;

	private static bool bEnable_BodiesCollisionEnable_IsValid;

	private static int bEnable_BodiesCollisionEnable_Offset;

	private static FFieldAddress bEnable_BodiesCollisionEnable_PropertyAddress;

	private static bool DefaultDisabledHitMoveCollisions_IsValid;

	private static int DefaultDisabledHitMoveCollisions_Offset;

	private static FFieldAddress DefaultDisabledHitMoveCollisions_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> DefaultDisabledHitMoveCollisions_Marshaler;

	[Category("TurnSkill")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[DisplayName("左小转身技能（0_-90）")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:LeftSmallTurnSkillID")]
	public int LeftSmallTurnSkillID
	{
		get
		{
			CheckDestroyed();
			if (!LeftSmallTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:LeftSmallTurnSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LeftSmallTurnSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftSmallTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:LeftSmallTurnSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LeftSmallTurnSkillID_Offset), value);
			}
		}
	}

	[Category("TurnSkill")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[DisplayName("右小转身技能（0_90）")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:RightSmallTurnSkillID")]
	public int RightSmallTurnSkillID
	{
		get
		{
			CheckDestroyed();
			if (!RightSmallTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:RightSmallTurnSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RightSmallTurnSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightSmallTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:RightSmallTurnSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RightSmallTurnSkillID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("TurnSkill")]
	[DisplayName("左大转身技能（-90_-180）")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:LeftBigTurnSkillID")]
	public int LeftBigTurnSkillID
	{
		get
		{
			CheckDestroyed();
			if (!LeftBigTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:LeftBigTurnSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LeftBigTurnSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftBigTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:LeftBigTurnSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LeftBigTurnSkillID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("左大转身技能（90_180）")]
	[Category("TurnSkill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:RightBigTurnSkillID")]
	public int RightBigTurnSkillID
	{
		get
		{
			CheckDestroyed();
			if (!RightBigTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:RightBigTurnSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RightBigTurnSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightBigTurnSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:RightBigTurnSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RightBigTurnSkillID_Offset), value);
			}
		}
	}

	[Category("Armor")]
	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("Armor设置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:ArmorSetting")]
	public FGSArmorSettingInBP ArmorSetting
	{
		get
		{
			CheckDestroyed();
			if (!ArmorSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:ArmorSetting");
				return default(FGSArmorSettingInBP);
			}
			return FGSArmorSettingInBP.FromNative(IntPtr.Add(base.Address, ArmorSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArmorSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:ArmorSetting");
			}
			else
			{
				FGSArmorSettingInBP.ToNative(IntPtr.Add(base.Address, ArmorSetting_Offset), value);
			}
		}
	}

	[DisplayName("快速移动速度")]
	[Category("Speed")]
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedFast")]
	public float MoveSpeedFast
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedFast");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveSpeedFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedFast");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveSpeedFast_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("正常移动速度")]
	[Category("Speed")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedNormal")]
	public float MoveSpeedNormal
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedNormal");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveSpeedNormal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedNormal");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveSpeedNormal_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("慢速移动速度")]
	[Category("Speed")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedSlow")]
	public float MoveSpeedSlow
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedSlow");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveSpeedSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MoveSpeedSlow");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveSpeedSlow_Offset), value);
			}
		}
	}

	[Category("Animation")]
	[DisplayName("ABPSetting")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:ABPSetting")]
	public BGWDataAsset_AbpHumanoidSetting ABPSetting
	{
		get
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:ABPSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(base.Address, ABPSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:ABPSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.ToNative(IntPtr.Add(base.Address, ABPSetting_Offset), value);
			}
		}
	}

	[Category("BeAttacked")]
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[DisplayName("受击逻辑信息ID")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:BeAttackedInfoID")]
	public int BeAttackedInfoID
	{
		get
		{
			CheckDestroyed();
			if (!BeAttackedInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:BeAttackedInfoID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BeAttackedInfoID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeAttackedInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:BeAttackedInfoID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BeAttackedInfoID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Camera")]
	[DisplayName("单位相机ID")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:UnitCameraID")]
	public int UnitCameraID
	{
		get
		{
			CheckDestroyed();
			if (!UnitCameraID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:UnitCameraID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UnitCameraID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitCameraID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:UnitCameraID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UnitCameraID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("死亡信息ID")]
	[Category("Dead")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:DeadInfoID")]
	public int DeadInfoID
	{
		get
		{
			CheckDestroyed();
			if (!DeadInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:DeadInfoID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DeadInfoID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeadInfoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:DeadInfoID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DeadInfoID_Offset), value);
			}
		}
	}

	[Category("Movement")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[DisplayName("运动模式")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:MovementMode")]
	public EMovementMode MovementMode
	{
		get
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MovementMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:MovementMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[DisplayName("部位规则ID")]
	[Category("BeAttacked")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:PartRuleID")]
	public int PartRuleID
	{
		get
		{
			CheckDestroyed();
			if (!PartRuleID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:PartRuleID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PartRuleID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PartRuleID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:PartRuleID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PartRuleID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("闪避技能ID")]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:DodgeSkillID")]
	public int DodgeSkillID
	{
		get
		{
			CheckDestroyed();
			if (!DodgeSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:DodgeSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DodgeSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DodgeSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:DodgeSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DodgeSkillID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("精准闪避技能ID")]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:PreciseDodgeSkillID")]
	public int PreciseDodgeSkillID
	{
		get
		{
			CheckDestroyed();
			if (!PreciseDodgeSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:PreciseDodgeSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PreciseDodgeSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreciseDodgeSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:PreciseDodgeSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PreciseDodgeSkillID_Offset), value);
			}
		}
	}

	[DisplayName("AMScale最大比例")]
	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:AMScaleMaxRate")]
	public float AMScaleMaxRate
	{
		get
		{
			CheckDestroyed();
			if (!AMScaleMaxRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:AMScaleMaxRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AMScaleMaxRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMScaleMaxRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:AMScaleMaxRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AMScaleMaxRate_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[DisplayName("骨骼检测白名单配置")]
	[Category("SpecialBone")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:SpecialBoneConfig")]
	public BGWDataAsset_SpecialBoneConfig SpecialBoneConfig
	{
		get
		{
			CheckDestroyed();
			if (!SpecialBoneConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:SpecialBoneConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_SpecialBoneConfig>.FromNative(IntPtr.Add(base.Address, SpecialBoneConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecialBoneConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:SpecialBoneConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_SpecialBoneConfig>.ToNative(IntPtr.Add(base.Address, SpecialBoneConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("PA骨骼列表_局部PA开关碰撞")]
	[Category("局部PA开关碰撞")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:BodiesNameList_BodiesCollisionEnable")]
	public TArrayReadWrite<FName> BodiesNameList_BodiesCollisionEnable
	{
		get
		{
			CheckDestroyed();
			if (!BodiesNameList_BodiesCollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:BodiesNameList_BodiesCollisionEnable");
				return null;
			}
			if (BodiesNameList_BodiesCollisionEnable_Marshaler == null)
			{
				BodiesNameList_BodiesCollisionEnable_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BodiesNameList_BodiesCollisionEnable_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BodiesNameList_BodiesCollisionEnable_Marshaler.FromNative(IntPtr.Add(base.Address, BodiesNameList_BodiesCollisionEnable_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("CollisionEnable_局部PA开关碰撞")]
	[Category("局部PA开关碰撞")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:bEnable_BodiesCollisionEnable")]
	public bool bEnable_BodiesCollisionEnable
	{
		get
		{
			CheckDestroyed();
			if (!bEnable_BodiesCollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:bEnable_BodiesCollisionEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnable_BodiesCollisionEnable_Offset), 0, bEnable_BodiesCollisionEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnable_BodiesCollisionEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:bEnable_BodiesCollisionEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnable_BodiesCollisionEnable_Offset), 0, bEnable_BodiesCollisionEnable_PropertyAddress.Address, value);
			}
		}
	}

	[Category("默认关闭HitMove部分碰撞体")]
	[Tooltip("用于设置HitMove默认关闭部分Collision。填写需要关闭的Collision名称【片段】，将会匹配关闭所有名称包含这一片段的Collision的HitMove功能。")]
	[BlueprintReadOnly]
	[DisplayName("默认关闭HitMove部分碰撞体")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StateLib:DefaultDisabledHitMoveCollisions")]
	public TArrayReadWrite<FName> DefaultDisabledHitMoveCollisions
	{
		get
		{
			CheckDestroyed();
			if (!DefaultDisabledHitMoveCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StateLib:DefaultDisabledHitMoveCollisions");
				return null;
			}
			if (DefaultDisabledHitMoveCollisions_Marshaler == null)
			{
				DefaultDisabledHitMoveCollisions_Marshaler = new TArrayReadWriteMarshaler<FName>(1, DefaultDisabledHitMoveCollisions_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return DefaultDisabledHitMoveCollisions_Marshaler.FromNative(IntPtr.Add(base.Address, DefaultDisabledHitMoveCollisions_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_StateLib");
		LeftSmallTurnSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeftSmallTurnSkillID");
		LeftSmallTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeftSmallTurnSkillID", Classes.FIntProperty);
		RightSmallTurnSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightSmallTurnSkillID");
		RightSmallTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightSmallTurnSkillID", Classes.FIntProperty);
		LeftBigTurnSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeftBigTurnSkillID");
		LeftBigTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeftBigTurnSkillID", Classes.FIntProperty);
		RightBigTurnSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightBigTurnSkillID");
		RightBigTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightBigTurnSkillID", Classes.FIntProperty);
		ArmorSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ArmorSetting");
		ArmorSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ArmorSetting", Classes.FStructProperty);
		MoveSpeedFast_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSpeedFast");
		MoveSpeedFast_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSpeedFast", Classes.FFloatProperty);
		MoveSpeedNormal_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSpeedNormal");
		MoveSpeedNormal_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSpeedNormal", Classes.FFloatProperty);
		MoveSpeedSlow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSpeedSlow");
		MoveSpeedSlow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSpeedSlow", Classes.FFloatProperty);
		ABPSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ABPSetting");
		ABPSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ABPSetting", Classes.FObjectProperty);
		BeAttackedInfoID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeAttackedInfoID");
		BeAttackedInfoID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeAttackedInfoID", Classes.FIntProperty);
		UnitCameraID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitCameraID");
		UnitCameraID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitCameraID", Classes.FIntProperty);
		DeadInfoID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DeadInfoID");
		DeadInfoID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DeadInfoID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref MovementMode_PropertyAddress, unrealStruct, "MovementMode");
		MovementMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MovementMode");
		MovementMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MovementMode", Classes.FEnumProperty);
		PartRuleID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PartRuleID");
		PartRuleID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PartRuleID", Classes.FIntProperty);
		DodgeSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DodgeSkillID");
		DodgeSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DodgeSkillID", Classes.FIntProperty);
		PreciseDodgeSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreciseDodgeSkillID");
		PreciseDodgeSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreciseDodgeSkillID", Classes.FIntProperty);
		AMScaleMaxRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMScaleMaxRate");
		AMScaleMaxRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMScaleMaxRate", Classes.FFloatProperty);
		SpecialBoneConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialBoneConfig");
		SpecialBoneConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialBoneConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BodiesNameList_BodiesCollisionEnable_PropertyAddress, unrealStruct, "BodiesNameList_BodiesCollisionEnable");
		BodiesNameList_BodiesCollisionEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BodiesNameList_BodiesCollisionEnable");
		BodiesNameList_BodiesCollisionEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BodiesNameList_BodiesCollisionEnable", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bEnable_BodiesCollisionEnable_PropertyAddress, unrealStruct, "bEnable_BodiesCollisionEnable");
		bEnable_BodiesCollisionEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnable_BodiesCollisionEnable");
		bEnable_BodiesCollisionEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnable_BodiesCollisionEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DefaultDisabledHitMoveCollisions_PropertyAddress, unrealStruct, "DefaultDisabledHitMoveCollisions");
		DefaultDisabledHitMoveCollisions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultDisabledHitMoveCollisions");
		DefaultDisabledHitMoveCollisions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultDisabledHitMoveCollisions", Classes.FArrayProperty);
	}

	static BGWDataAsset_StateLib()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_StateLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_StateLib));
	}
}
