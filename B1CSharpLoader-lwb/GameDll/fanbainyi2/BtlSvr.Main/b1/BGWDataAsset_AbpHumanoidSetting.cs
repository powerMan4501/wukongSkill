using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting")]
public class BGWDataAsset_AbpHumanoidSetting : UBGWDataAsset
{
	private static bool CommonSetting_IsValid;

	private static int CommonSetting_Offset;

	private static bool FootIKSetting_IsValid;

	private static int FootIKSetting_Offset;

	private static bool MotionMatchingSetting_IsValid;

	private static int MotionMatchingSetting_Offset;

	private static bool Simple4DirSetting_IsValid;

	private static int Simple4DirSetting_Offset;

	private static bool PlayerLocomotionSetting_IsValid;

	private static int PlayerLocomotionSetting_Offset;

	private static bool MonsterLocomotionSetting_IsValid;

	private static int MonsterLocomotionSetting_Offset;

	private static bool AdvancedMonsterLocomotionSetting_IsValid;

	private static int AdvancedMonsterLocomotionSetting_Offset;

	private static bool FlyControlSetting_IsValid;

	private static int FlyControlSetting_Offset;

	private static bool AimOffsetSetting_IsValid;

	private static int AimOffsetSetting_Offset;

	private static bool SpineIKSetting_IsValid;

	private static int SpineIKSetting_Offset;

	private static bool DingShenSetting_IsValid;

	private static int DingShenSetting_Offset;

	private static bool JumpSetting_IsValid;

	private static int JumpSetting_Offset;

	private static bool PatrolSetting_IsValid;

	private static int PatrolSetting_Offset;

	private static bool GlideMoveSetting_IsValid;

	private static int GlideMoveSetting_Offset;

	private static bool ParkourMoveSetting_IsValid;

	private static int ParkourMoveSetting_Offset;

	private static bool BodyBlendSetting_IsValid;

	private static int BodyBlendSetting_Offset;

	private static bool CloudLocomotionSetting_IsValid;

	private static int CloudLocomotionSetting_Offset;

	private static bool SpecialAdditiveSetting_IsValid;

	private static int SpecialAdditiveSetting_Offset;

	private static bool WheelMoveSetting_IsValid;

	private static int WheelMoveSetting_Offset;

	private static bool StriderMoveSetting_IsValid;

	private static int StriderMoveSetting_Offset;

	private static bool QuadrupedLocomotionSetting_IsValid;

	private static int QuadrupedLocomotionSetting_Offset;

	[Category("Common Setting")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:CommonSetting")]
	public FAnimHumanoidSetting_Common CommonSetting
	{
		get
		{
			CheckDestroyed();
			if (!CommonSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:CommonSetting");
				return default(FAnimHumanoidSetting_Common);
			}
			return FAnimHumanoidSetting_Common.FromNative(IntPtr.Add(base.Address, CommonSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommonSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:CommonSetting");
			}
			else
			{
				FAnimHumanoidSetting_Common.ToNative(IntPtr.Add(base.Address, CommonSetting_Offset), value);
			}
		}
	}

	[Category("Common Setting")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:FootIKSetting")]
	public FAnimHumanoidSetting_FootIK FootIKSetting
	{
		get
		{
			CheckDestroyed();
			if (!FootIKSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:FootIKSetting");
				return default(FAnimHumanoidSetting_FootIK);
			}
			return FAnimHumanoidSetting_FootIK.FromNative(IntPtr.Add(base.Address, FootIKSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootIKSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:FootIKSetting");
			}
			else
			{
				FAnimHumanoidSetting_FootIK.ToNative(IntPtr.Add(base.Address, FootIKSetting_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:MotionMatchingSetting")]
	public FAnimHumanoidSetting_MotionMatching MotionMatchingSetting
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:MotionMatchingSetting");
				return default(FAnimHumanoidSetting_MotionMatching);
			}
			return FAnimHumanoidSetting_MotionMatching.FromNative(IntPtr.Add(base.Address, MotionMatchingSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:MotionMatchingSetting");
			}
			else
			{
				FAnimHumanoidSetting_MotionMatching.ToNative(IntPtr.Add(base.Address, MotionMatchingSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:Simple4DirSetting")]
	public FAnimHumanoidSetting_Simple4Dir Simple4DirSetting
	{
		get
		{
			CheckDestroyed();
			if (!Simple4DirSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:Simple4DirSetting");
				return default(FAnimHumanoidSetting_Simple4Dir);
			}
			return FAnimHumanoidSetting_Simple4Dir.FromNative(IntPtr.Add(base.Address, Simple4DirSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Simple4DirSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:Simple4DirSetting");
			}
			else
			{
				FAnimHumanoidSetting_Simple4Dir.ToNative(IntPtr.Add(base.Address, Simple4DirSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Humanoid Setting")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:PlayerLocomotionSetting")]
	public FAnimHumanoidSetting_PlayerLocomotion PlayerLocomotionSetting
	{
		get
		{
			CheckDestroyed();
			if (!PlayerLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:PlayerLocomotionSetting");
				return default(FAnimHumanoidSetting_PlayerLocomotion);
			}
			return FAnimHumanoidSetting_PlayerLocomotion.FromNative(IntPtr.Add(base.Address, PlayerLocomotionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:PlayerLocomotionSetting");
			}
			else
			{
				FAnimHumanoidSetting_PlayerLocomotion.ToNative(IntPtr.Add(base.Address, PlayerLocomotionSetting_Offset), value);
			}
		}
	}

	[Category("Humanoid Setting")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:MonsterLocomotionSetting")]
	public FAnimHumanoidSetting_MonsterLocomotion MonsterLocomotionSetting
	{
		get
		{
			CheckDestroyed();
			if (!MonsterLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:MonsterLocomotionSetting");
				return default(FAnimHumanoidSetting_MonsterLocomotion);
			}
			return FAnimHumanoidSetting_MonsterLocomotion.FromNative(IntPtr.Add(base.Address, MonsterLocomotionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MonsterLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:MonsterLocomotionSetting");
			}
			else
			{
				FAnimHumanoidSetting_MonsterLocomotion.ToNative(IntPtr.Add(base.Address, MonsterLocomotionSetting_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Humanoid Setting")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:AdvancedMonsterLocomotionSetting")]
	public FAnimHumanoidSetting_AdvancedMonsterLocomotion AdvancedMonsterLocomotionSetting
	{
		get
		{
			CheckDestroyed();
			if (!AdvancedMonsterLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:AdvancedMonsterLocomotionSetting");
				return default(FAnimHumanoidSetting_AdvancedMonsterLocomotion);
			}
			return FAnimHumanoidSetting_AdvancedMonsterLocomotion.FromNative(IntPtr.Add(base.Address, AdvancedMonsterLocomotionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvancedMonsterLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:AdvancedMonsterLocomotionSetting");
			}
			else
			{
				FAnimHumanoidSetting_AdvancedMonsterLocomotion.ToNative(IntPtr.Add(base.Address, AdvancedMonsterLocomotionSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Humanoid Setting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:FlyControlSetting")]
	public FAnimHumanoidSetting_FlyControl FlyControlSetting
	{
		get
		{
			CheckDestroyed();
			if (!FlyControlSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:FlyControlSetting");
				return default(FAnimHumanoidSetting_FlyControl);
			}
			return FAnimHumanoidSetting_FlyControl.FromNative(IntPtr.Add(base.Address, FlyControlSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyControlSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:FlyControlSetting");
			}
			else
			{
				FAnimHumanoidSetting_FlyControl.ToNative(IntPtr.Add(base.Address, FlyControlSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Humanoid Setting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:AimOffsetSetting")]
	public FAnimHumanoidSetting_AimOffset AimOffsetSetting
	{
		get
		{
			CheckDestroyed();
			if (!AimOffsetSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:AimOffsetSetting");
				return default(FAnimHumanoidSetting_AimOffset);
			}
			return FAnimHumanoidSetting_AimOffset.FromNative(IntPtr.Add(base.Address, AimOffsetSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimOffsetSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:AimOffsetSetting");
			}
			else
			{
				FAnimHumanoidSetting_AimOffset.ToNative(IntPtr.Add(base.Address, AimOffsetSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Humanoid Setting")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:SpineIKSetting")]
	public FAnimHumanoidSetting_SpineIK SpineIKSetting
	{
		get
		{
			CheckDestroyed();
			if (!SpineIKSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:SpineIKSetting");
				return default(FAnimHumanoidSetting_SpineIK);
			}
			return FAnimHumanoidSetting_SpineIK.FromNative(IntPtr.Add(base.Address, SpineIKSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpineIKSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:SpineIKSetting");
			}
			else
			{
				FAnimHumanoidSetting_SpineIK.ToNative(IntPtr.Add(base.Address, SpineIKSetting_Offset), value);
			}
		}
	}

	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:DingShenSetting")]
	public FAnimHumanoidSetting_DingShen DingShenSetting
	{
		get
		{
			CheckDestroyed();
			if (!DingShenSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:DingShenSetting");
				return default(FAnimHumanoidSetting_DingShen);
			}
			return FAnimHumanoidSetting_DingShen.FromNative(IntPtr.Add(base.Address, DingShenSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DingShenSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:DingShenSetting");
			}
			else
			{
				FAnimHumanoidSetting_DingShen.ToNative(IntPtr.Add(base.Address, DingShenSetting_Offset), value);
			}
		}
	}

	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:JumpSetting")]
	public FAnimHumanoidSetting_Jump JumpSetting
	{
		get
		{
			CheckDestroyed();
			if (!JumpSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:JumpSetting");
				return default(FAnimHumanoidSetting_Jump);
			}
			return FAnimHumanoidSetting_Jump.FromNative(IntPtr.Add(base.Address, JumpSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:JumpSetting");
			}
			else
			{
				FAnimHumanoidSetting_Jump.ToNative(IntPtr.Add(base.Address, JumpSetting_Offset), value);
			}
		}
	}

	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:PatrolSetting")]
	public FAnimHumanoidSetting_Patrol PatrolSetting
	{
		get
		{
			CheckDestroyed();
			if (!PatrolSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:PatrolSetting");
				return default(FAnimHumanoidSetting_Patrol);
			}
			return FAnimHumanoidSetting_Patrol.FromNative(IntPtr.Add(base.Address, PatrolSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PatrolSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:PatrolSetting");
			}
			else
			{
				FAnimHumanoidSetting_Patrol.ToNative(IntPtr.Add(base.Address, PatrolSetting_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Humanoid Setting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:GlideMoveSetting")]
	public FAnimHumanoidSetting_GlideMove GlideMoveSetting
	{
		get
		{
			CheckDestroyed();
			if (!GlideMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:GlideMoveSetting");
				return default(FAnimHumanoidSetting_GlideMove);
			}
			return FAnimHumanoidSetting_GlideMove.FromNative(IntPtr.Add(base.Address, GlideMoveSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlideMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:GlideMoveSetting");
			}
			else
			{
				FAnimHumanoidSetting_GlideMove.ToNative(IntPtr.Add(base.Address, GlideMoveSetting_Offset), value);
			}
		}
	}

	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:ParkourMoveSetting")]
	public FAnimHumanoidSetting_ParkourMove ParkourMoveSetting
	{
		get
		{
			CheckDestroyed();
			if (!ParkourMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:ParkourMoveSetting");
				return default(FAnimHumanoidSetting_ParkourMove);
			}
			return FAnimHumanoidSetting_ParkourMove.FromNative(IntPtr.Add(base.Address, ParkourMoveSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParkourMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:ParkourMoveSetting");
			}
			else
			{
				FAnimHumanoidSetting_ParkourMove.ToNative(IntPtr.Add(base.Address, ParkourMoveSetting_Offset), value);
			}
		}
	}

	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:BodyBlendSetting")]
	public FAnimHumanoidSetting_BodyBlend BodyBlendSetting
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:BodyBlendSetting");
				return default(FAnimHumanoidSetting_BodyBlend);
			}
			return FAnimHumanoidSetting_BodyBlend.FromNative(IntPtr.Add(base.Address, BodyBlendSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:BodyBlendSetting");
			}
			else
			{
				FAnimHumanoidSetting_BodyBlend.ToNative(IntPtr.Add(base.Address, BodyBlendSetting_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Humanoid Setting")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:CloudLocomotionSetting")]
	public FAnimHumanoidSetting_CloudLocomotion CloudLocomotionSetting
	{
		get
		{
			CheckDestroyed();
			if (!CloudLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:CloudLocomotionSetting");
				return default(FAnimHumanoidSetting_CloudLocomotion);
			}
			return FAnimHumanoidSetting_CloudLocomotion.FromNative(IntPtr.Add(base.Address, CloudLocomotionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:CloudLocomotionSetting");
			}
			else
			{
				FAnimHumanoidSetting_CloudLocomotion.ToNative(IntPtr.Add(base.Address, CloudLocomotionSetting_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Humanoid Setting")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:SpecialAdditiveSetting")]
	public FAnimHumanoidSetting_SpecialAdditive SpecialAdditiveSetting
	{
		get
		{
			CheckDestroyed();
			if (!SpecialAdditiveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:SpecialAdditiveSetting");
				return default(FAnimHumanoidSetting_SpecialAdditive);
			}
			return FAnimHumanoidSetting_SpecialAdditive.FromNative(IntPtr.Add(base.Address, SpecialAdditiveSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecialAdditiveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:SpecialAdditiveSetting");
			}
			else
			{
				FAnimHumanoidSetting_SpecialAdditive.ToNative(IntPtr.Add(base.Address, SpecialAdditiveSetting_Offset), value);
			}
		}
	}

	[Category("Wheel Setting")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:WheelMoveSetting")]
	public FAnimWheelSetting_WheelMove WheelMoveSetting
	{
		get
		{
			CheckDestroyed();
			if (!WheelMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:WheelMoveSetting");
				return default(FAnimWheelSetting_WheelMove);
			}
			return FAnimWheelSetting_WheelMove.FromNative(IntPtr.Add(base.Address, WheelMoveSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WheelMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:WheelMoveSetting");
			}
			else
			{
				FAnimWheelSetting_WheelMove.ToNative(IntPtr.Add(base.Address, WheelMoveSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Strider Setting")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:StriderMoveSetting")]
	public FAnimHumanoidSetting_StriderMove StriderMoveSetting
	{
		get
		{
			CheckDestroyed();
			if (!StriderMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:StriderMoveSetting");
				return default(FAnimHumanoidSetting_StriderMove);
			}
			return BlittableTypeMarshaler<FAnimHumanoidSetting_StriderMove>.FromNative(IntPtr.Add(base.Address, StriderMoveSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StriderMoveSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:StriderMoveSetting");
			}
			else
			{
				BlittableTypeMarshaler<FAnimHumanoidSetting_StriderMove>.ToNative(IntPtr.Add(base.Address, StriderMoveSetting_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Quadruped Setting")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:QuadrupedLocomotionSetting")]
	public FAnimHumanoidSetting_QuadrupedLocomotion QuadrupedLocomotionSetting
	{
		get
		{
			CheckDestroyed();
			if (!QuadrupedLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:QuadrupedLocomotionSetting");
				return default(FAnimHumanoidSetting_QuadrupedLocomotion);
			}
			return FAnimHumanoidSetting_QuadrupedLocomotion.FromNative(IntPtr.Add(base.Address, QuadrupedLocomotionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QuadrupedLocomotionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting:QuadrupedLocomotionSetting");
			}
			else
			{
				FAnimHumanoidSetting_QuadrupedLocomotion.ToNative(IntPtr.Add(base.Address, QuadrupedLocomotionSetting_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		AimOffsetSetting = new FAnimHumanoidSetting_AimOffset
		{
			AimOffsetTurnSpeed = 270,
			AimOffsetBlindAngle = 30
		};
		MonsterLocomotionSetting = new FAnimHumanoidSetting_MonsterLocomotion
		{
			Lock = 
			{
				StopLeftBlendAnim = 
				{
					BlendInTime = 0.25f,
					BlendOutTime = 0.25f,
					PlayRate = 1f
				},
				StopRightBlendAnim = 
				{
					BlendInTime = 0.25f,
					BlendOutTime = 0.25f,
					PlayRate = 1f
				}
			}
		};
		FAnimHumanoidSetting_AdvancedMonsterLocomotion advancedMonsterLocomotionSetting = default(FAnimHumanoidSetting_AdvancedMonsterLocomotion);
		float num = 1500f;
		float num2 = 2f;
		float num3 = 1400f;
		advancedMonsterLocomotionSetting.WalkMaxAcceleration = num;
		advancedMonsterLocomotionSetting.RunMaxAcceleration = num;
		advancedMonsterLocomotionSetting.RushMaxAcceleration = num;
		advancedMonsterLocomotionSetting.WalkBrakingFriction = num2;
		advancedMonsterLocomotionSetting.RunBrakingFriction = num2;
		advancedMonsterLocomotionSetting.RushBrakingFriction = num2;
		advancedMonsterLocomotionSetting.WalkBrakingDecelerationWalking = num3;
		advancedMonsterLocomotionSetting.RunBrakingDecelerationWalking = num3;
		advancedMonsterLocomotionSetting.RushBrakingDecelerationWalking = num3;
		advancedMonsterLocomotionSetting.StartAndTurnAnimPlayRateClamped = new FVector2D(0.6000000238418579, 2.0);
		advancedMonsterLocomotionSetting.LoopAnimPlayRateClamped = new FVector2D(0.5, 1.600000023841858);
		AdvancedMonsterLocomotionSetting = advancedMonsterLocomotionSetting;
		MotionMatchingSetting = new FAnimHumanoidSetting_MotionMatching
		{
			AnimationAnalyzerBlendTime = 0.2f,
			MotionBlendTime = 0.2f,
			ForceSetRotAnimSpeed = 30f,
			DisableRotVerifyAnimSpeed = 10f,
			ToIdleAnimSpeed = 5f
		};
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AbpHumanoidSetting");
		CommonSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CommonSetting");
		CommonSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CommonSetting", Classes.FStructProperty);
		FootIKSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FootIKSetting");
		FootIKSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FootIKSetting", Classes.FStructProperty);
		MotionMatchingSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MotionMatchingSetting");
		MotionMatchingSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MotionMatchingSetting", Classes.FStructProperty);
		Simple4DirSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Simple4DirSetting");
		Simple4DirSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Simple4DirSetting", Classes.FStructProperty);
		PlayerLocomotionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerLocomotionSetting");
		PlayerLocomotionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerLocomotionSetting", Classes.FStructProperty);
		MonsterLocomotionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MonsterLocomotionSetting");
		MonsterLocomotionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MonsterLocomotionSetting", Classes.FStructProperty);
		AdvancedMonsterLocomotionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdvancedMonsterLocomotionSetting");
		AdvancedMonsterLocomotionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdvancedMonsterLocomotionSetting", Classes.FStructProperty);
		FlyControlSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FlyControlSetting");
		FlyControlSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FlyControlSetting", Classes.FStructProperty);
		AimOffsetSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AimOffsetSetting");
		AimOffsetSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AimOffsetSetting", Classes.FStructProperty);
		SpineIKSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpineIKSetting");
		SpineIKSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpineIKSetting", Classes.FStructProperty);
		DingShenSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DingShenSetting");
		DingShenSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DingShenSetting", Classes.FStructProperty);
		JumpSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JumpSetting");
		JumpSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JumpSetting", Classes.FStructProperty);
		PatrolSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PatrolSetting");
		PatrolSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PatrolSetting", Classes.FStructProperty);
		GlideMoveSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GlideMoveSetting");
		GlideMoveSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GlideMoveSetting", Classes.FStructProperty);
		ParkourMoveSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParkourMoveSetting");
		ParkourMoveSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParkourMoveSetting", Classes.FStructProperty);
		BodyBlendSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BodyBlendSetting");
		BodyBlendSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BodyBlendSetting", Classes.FStructProperty);
		CloudLocomotionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudLocomotionSetting");
		CloudLocomotionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudLocomotionSetting", Classes.FStructProperty);
		SpecialAdditiveSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialAdditiveSetting");
		SpecialAdditiveSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialAdditiveSetting", Classes.FStructProperty);
		WheelMoveSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WheelMoveSetting");
		WheelMoveSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WheelMoveSetting", Classes.FStructProperty);
		StriderMoveSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StriderMoveSetting");
		StriderMoveSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StriderMoveSetting", Classes.FStructProperty);
		QuadrupedLocomotionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "QuadrupedLocomotionSetting");
		QuadrupedLocomotionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "QuadrupedLocomotionSetting", Classes.FStructProperty);
	}

	static BGWDataAsset_AbpHumanoidSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AbpHumanoidSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AbpHumanoidSetting));
	}
}
