using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig")]
public class BGWDataAsset_CloudMoveConfig : UBGWDataAsset
{
	private static bool CloudSkillCooldownTime_IsValid;

	private static int CloudSkillCooldownTime_Offset;

	private static bool CloudSkill_Ride_Walk_IsValid;

	private static int CloudSkill_Ride_Walk_Offset;

	private static bool CloudSkill_Ride_Run_IsValid;

	private static int CloudSkill_Ride_Run_Offset;

	private static bool CloudSkill_Ride_Sprint_IsValid;

	private static int CloudSkill_Ride_Sprint_Offset;

	private static bool CloudSkill_Ride_Fall_IsValid;

	private static int CloudSkill_Ride_Fall_Offset;

	private static bool CloudSkill_Ride_Fall_MinHeight_IsValid;

	private static int CloudSkill_Ride_Fall_MinHeight_Offset;

	private static bool CloudSkill_GetOff_Walk_Low_IsValid;

	private static int CloudSkill_GetOff_Walk_Low_Offset;

	private static bool CloudSkill_GetOff_Walk_High_IsValid;

	private static int CloudSkill_GetOff_Walk_High_Offset;

	private static bool CloudSkill_GetOff_Run_Low_Forward_IsValid;

	private static int CloudSkill_GetOff_Run_Low_Forward_Offset;

	private static bool CloudSkill_GetOff_Run_Low_Upward_IsValid;

	private static int CloudSkill_GetOff_Run_Low_Upward_Offset;

	private static bool CloudSkill_GetOff_Run_Low_Downward_IsValid;

	private static int CloudSkill_GetOff_Run_Low_Downward_Offset;

	private static bool CloudSkill_GetOff_Run_High_Forward_IsValid;

	private static int CloudSkill_GetOff_Run_High_Forward_Offset;

	private static bool CloudSkill_GetOff_Run_High_Upward_IsValid;

	private static int CloudSkill_GetOff_Run_High_Upward_Offset;

	private static bool CloudSkill_GetOff_Run_High_Downward_IsValid;

	private static int CloudSkill_GetOff_Run_High_Downward_Offset;

	private static bool CloudSkill_GetOff_Rush_Low_Forward_IsValid;

	private static int CloudSkill_GetOff_Rush_Low_Forward_Offset;

	private static bool CloudSkill_GetOff_Rush_Low_Upward_IsValid;

	private static int CloudSkill_GetOff_Rush_Low_Upward_Offset;

	private static bool CloudSkill_GetOff_Rush_Low_Downward_IsValid;

	private static int CloudSkill_GetOff_Rush_Low_Downward_Offset;

	private static bool CloudSkill_GetOff_Rush_High_Forward_IsValid;

	private static int CloudSkill_GetOff_Rush_High_Forward_Offset;

	private static bool CloudSkill_GetOff_Rush_High_Upward_IsValid;

	private static int CloudSkill_GetOff_Rush_High_Upward_Offset;

	private static bool CloudSkill_GetOff_Rush_High_Downward_IsValid;

	private static int CloudSkill_GetOff_Rush_High_Downward_Offset;

	private static bool CloudSkill_BreakSkills_IsValid;

	private static int CloudSkill_BreakSkills_Offset;

	private static FFieldAddress CloudSkill_BreakSkills_PropertyAddress;

	private TMapReadWriteMarshaler<int, FCloudMoveBreakSkillConfig> CloudSkill_BreakSkills_Marshaler;

	private static bool HeightLimitThreshold_IsValid;

	private static int HeightLimitThreshold_Offset;

	private static bool HeightLimitMaxPitchCurve_IsValid;

	private static int HeightLimitMaxPitchCurve_Offset;

	private static bool DisableHeightLimitIfNoInput_IsValid;

	private static int DisableHeightLimitIfNoInput_Offset;

	private static FFieldAddress DisableHeightLimitIfNoInput_PropertyAddress;

	private static bool MinimumHeightRestriction_IsValid;

	private static int MinimumHeightRestriction_Offset;

	private static bool MinimumHeightRestrictionThreshold_IsValid;

	private static int MinimumHeightRestrictionThreshold_Offset;

	private static bool HorizontalFlightUpAngleRange_IsValid;

	private static int HorizontalFlightUpAngleRange_Offset;

	private static bool HorizontalFlightDownAngleRange_IsValid;

	private static int HorizontalFlightDownAngleRange_Offset;

	private static bool RushEffectSpeed_IsValid;

	private static int RushEffectSpeed_Offset;

	private static bool RushEffectBuffList_IsValid;

	private static int RushEffectBuffList_Offset;

	private static FFieldAddress RushEffectBuffList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> RushEffectBuffList_Marshaler;

	private static bool RushAkEvent_IsValid;

	private static int RushAkEvent_Offset;

	private static bool CloudMoveItemId_IsValid;

	private static int CloudMoveItemId_Offset;

	private static bool CloudMoveBuffId_IsValid;

	private static int CloudMoveBuffId_Offset;

	private static FFieldAddress CloudMoveBuffId_PropertyAddress;

	private TArrayReadWriteMarshaler<int> CloudMoveBuffId_Marshaler;

	private static bool CloudEffectDBC_IsValid;

	private static int CloudEffectDBC_Offset;

	private static bool CloudEffectDBC_RotateLerpSpeedCurve_IsValid;

	private static int CloudEffectDBC_RotateLerpSpeedCurve_Offset;

	private static bool CloudEffectDBC_LocationLerpSpeedCurve_IsValid;

	private static int CloudEffectDBC_LocationLerpSpeedCurve_Offset;

	private static bool CloudEffectDBC_OffsetCurve_IsValid;

	private static int CloudEffectDBC_OffsetCurve_Offset;

	private static bool CloudAkEventBegin_IsValid;

	private static int CloudAkEventBegin_Offset;

	private static bool CloudAkEventStop_IsValid;

	private static int CloudAkEventStop_Offset;

	private static bool CloudFoliageFadeScaleCurve_IsValid;

	private static int CloudFoliageFadeScaleCurve_Offset;

	private static bool GroundEffectDistance_IsValid;

	private static int GroundEffectDistance_Offset;

	private static bool GroundEffectInterval_IsValid;

	private static int GroundEffectInterval_Offset;

	private static bool GroundEffectSpeed_IsValid;

	private static int GroundEffectSpeed_Offset;

	private static bool GroundEffects_IsValid;

	private static int GroundEffects_Offset;

	private static FFieldAddress GroundEffects_PropertyAddress;

	private TMapReadWriteMarshaler<ESceneItemSurfaceType, FCloudMoveGroundEffectConfig> GroundEffects_Marshaler;

	[DisplayName("上下云技能CD")]
	[Category("筋斗云技能CD")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkillCooldownTime")]
	public int CloudSkillCooldownTime
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkillCooldownTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkillCooldownTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkillCooldownTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkillCooldownTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkillCooldownTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkillCooldownTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("筋斗云技能配置")]
	[EditAnywhere]
	[DisplayName("上云技能 Stand/Walk")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Walk")]
	public int CloudSkill_Ride_Walk
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Walk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Walk");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_Ride_Walk_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Walk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Walk");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_Ride_Walk_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云技能配置")]
	[DisplayName("上云技能 Run")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Run")]
	public int CloudSkill_Ride_Run
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Run_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Run");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_Ride_Run_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Run_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Run");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_Ride_Run_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云技能配置")]
	[DisplayName("上云技能 Sprint")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Sprint")]
	public int CloudSkill_Ride_Sprint
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Sprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Sprint");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_Ride_Sprint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Sprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Sprint");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_Ride_Sprint_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("上云技能 Fall")]
	[Category("筋斗云技能配置")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Fall")]
	public int CloudSkill_Ride_Fall
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Fall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Fall");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_Ride_Fall_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Fall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Fall");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_Ride_Fall_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云技能配置")]
	[DisplayName("上云技能 Fall 最小允许释放高度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Fall_MinHeight")]
	public float CloudSkill_Ride_Fall_MinHeight
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Fall_MinHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Fall_MinHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudSkill_Ride_Fall_MinHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_Ride_Fall_MinHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_Ride_Fall_MinHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudSkill_Ride_Fall_MinHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("筋斗云技能配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("下云技能 Stand/Walk 低空")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Walk_Low")]
	public int CloudSkill_GetOff_Walk_Low
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Walk_Low_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Walk_Low");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Walk_Low_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Walk_Low_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Walk_Low");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Walk_Low_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("下云技能 Stand/Walk 高空")]
	[Category("筋斗云技能配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Walk_High")]
	public int CloudSkill_GetOff_Walk_High
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Walk_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Walk_High");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Walk_High_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Walk_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Walk_High");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Walk_High_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("下云技能 Run 低空 向前")]
	[EditAnywhere]
	[UProperty]
	[Category("筋斗云技能配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Forward")]
	public int CloudSkill_GetOff_Run_Low_Forward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_Low_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Forward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_Low_Forward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_Low_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Forward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_Low_Forward_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("下云技能 Run 低空 向上")]
	[Category("筋斗云技能配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Upward")]
	public int CloudSkill_GetOff_Run_Low_Upward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_Low_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Upward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_Low_Upward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_Low_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Upward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_Low_Upward_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("筋斗云技能配置")]
	[DisplayName("下云技能 Run 低空 向下")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Downward")]
	public int CloudSkill_GetOff_Run_Low_Downward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_Low_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Downward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_Low_Downward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_Low_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_Low_Downward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_Low_Downward_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("下云技能 Run 高空 向前")]
	[Category("筋斗云技能配置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Forward")]
	public int CloudSkill_GetOff_Run_High_Forward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_High_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Forward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_High_Forward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_High_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Forward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_High_Forward_Offset), value);
			}
		}
	}

	[Category("筋斗云技能配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("下云技能 Run 高空 向上")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Upward")]
	public int CloudSkill_GetOff_Run_High_Upward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_High_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Upward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_High_Upward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_High_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Upward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_High_Upward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云技能配置")]
	[DisplayName("下云技能 Run 高空 向下")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Downward")]
	public int CloudSkill_GetOff_Run_High_Downward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_High_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Downward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_High_Downward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Run_High_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Run_High_Downward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Run_High_Downward_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("下云技能 Rush 低空 向前")]
	[Category("筋斗云技能配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Forward")]
	public int CloudSkill_GetOff_Rush_Low_Forward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_Low_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Forward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_Low_Forward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_Low_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Forward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_Low_Forward_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("下云技能 Rush 低空 向上")]
	[Category("筋斗云技能配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Upward")]
	public int CloudSkill_GetOff_Rush_Low_Upward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_Low_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Upward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_Low_Upward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_Low_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Upward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_Low_Upward_Offset), value);
			}
		}
	}

	[Category("筋斗云技能配置")]
	[DisplayName("下云技能 Rush 低空 向下")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Downward")]
	public int CloudSkill_GetOff_Rush_Low_Downward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_Low_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Downward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_Low_Downward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_Low_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_Low_Downward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_Low_Downward_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("下云技能 Rush 高空 向前")]
	[UProperty]
	[EditAnywhere]
	[Category("筋斗云技能配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Forward")]
	public int CloudSkill_GetOff_Rush_High_Forward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_High_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Forward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_High_Forward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_High_Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Forward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_High_Forward_Offset), value);
			}
		}
	}

	[Category("筋斗云技能配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("下云技能 Rush 高空 向上")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Upward")]
	public int CloudSkill_GetOff_Rush_High_Upward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_High_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Upward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_High_Upward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_High_Upward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Upward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_High_Upward_Offset), value);
			}
		}
	}

	[DisplayName("下云技能 Rush 高空 向下")]
	[Category("筋斗云技能配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Downward")]
	public int CloudSkill_GetOff_Rush_High_Downward
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_High_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Downward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_High_Downward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudSkill_GetOff_Rush_High_Downward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_GetOff_Rush_High_Downward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudSkill_GetOff_Rush_High_Downward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("击坠动画技能配置")]
	[BlueprintReadWrite]
	[Category("筋斗云技能配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_BreakSkills")]
	public TMapReadWrite<int, FCloudMoveBreakSkillConfig> CloudSkill_BreakSkills
	{
		get
		{
			CheckDestroyed();
			if (!CloudSkill_BreakSkills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudSkill_BreakSkills");
				return null;
			}
			if (CloudSkill_BreakSkills_Marshaler == null)
			{
				CloudSkill_BreakSkills_Marshaler = new TMapReadWriteMarshaler<int, FCloudMoveBreakSkillConfig>(1, CloudSkill_BreakSkills_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FCloudMoveBreakSkillConfig, BlittableTypeMarshaler<FCloudMoveBreakSkillConfig>>.FromNative, CachedMarshalingDelegates<FCloudMoveBreakSkillConfig, BlittableTypeMarshaler<FCloudMoveBreakSkillConfig>>.ToNative);
			}
			return CloudSkill_BreakSkills_Marshaler.FromNative(IntPtr.Add(base.Address, CloudSkill_BreakSkills_Offset));
		}
	}

	[UProperty]
	[Tooltip("从低于软高度限制线多少距离开始逐渐启用飞行上升限制")]
	[UMeta(MDProp.ClampMin, "0")]
	[BlueprintReadWrite]
	[Category("筋斗云限制配置")]
	[EditAnywhere]
	[DisplayName("软高度限制开启阈值")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HeightLimitThreshold")]
	public float HeightLimitThreshold
	{
		get
		{
			CheckDestroyed();
			if (!HeightLimitThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HeightLimitThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeightLimitThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightLimitThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HeightLimitThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeightLimitThreshold_Offset), value);
			}
		}
	}

	[DisplayName("限高区域仰角限制曲线")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云限制配置")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HeightLimitMaxPitchCurve")]
	public UCurveFloat HeightLimitMaxPitchCurve
	{
		get
		{
			CheckDestroyed();
			if (!HeightLimitMaxPitchCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HeightLimitMaxPitchCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, HeightLimitMaxPitchCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightLimitMaxPitchCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HeightLimitMaxPitchCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, HeightLimitMaxPitchCurve_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "0")]
	[Category("筋斗云限制配置")]
	[DisplayName("无输入时禁用限高")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:DisableHeightLimitIfNoInput")]
	public bool DisableHeightLimitIfNoInput
	{
		get
		{
			CheckDestroyed();
			if (!DisableHeightLimitIfNoInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:DisableHeightLimitIfNoInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableHeightLimitIfNoInput_Offset), 0, DisableHeightLimitIfNoInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableHeightLimitIfNoInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:DisableHeightLimitIfNoInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableHeightLimitIfNoInput_Offset), 0, DisableHeightLimitIfNoInput_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("最低高度限制")]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云限制配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:MinimumHeightRestriction")]
	public float MinimumHeightRestriction
	{
		get
		{
			CheckDestroyed();
			if (!MinimumHeightRestriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:MinimumHeightRestriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumHeightRestriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumHeightRestriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:MinimumHeightRestriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumHeightRestriction_Offset), value);
			}
		}
	}

	[Tooltip("从高于最低高度限制多少距离开始逐渐启用飞行下降限制")]
	[DisplayName("最低高度限制减速开启阈值")]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("筋斗云限制配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:MinimumHeightRestrictionThreshold")]
	public float MinimumHeightRestrictionThreshold
	{
		get
		{
			CheckDestroyed();
			if (!MinimumHeightRestrictionThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:MinimumHeightRestrictionThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumHeightRestrictionThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumHeightRestrictionThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:MinimumHeightRestrictionThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumHeightRestrictionThreshold_Offset), value);
			}
		}
	}

	[DisplayName("平飞向上角度范围")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("筋斗云飞行配置")]
	[Tooltip("水平面多少角度范围内视为平飞")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HorizontalFlightUpAngleRange")]
	public float HorizontalFlightUpAngleRange
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalFlightUpAngleRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HorizontalFlightUpAngleRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HorizontalFlightUpAngleRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalFlightUpAngleRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HorizontalFlightUpAngleRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HorizontalFlightUpAngleRange_Offset), value);
			}
		}
	}

	[Tooltip("水平面多少角度范围内视为平飞")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云飞行配置")]
	[DisplayName("平飞向下角度范围")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HorizontalFlightDownAngleRange")]
	public float HorizontalFlightDownAngleRange
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalFlightDownAngleRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HorizontalFlightDownAngleRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HorizontalFlightDownAngleRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalFlightDownAngleRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:HorizontalFlightDownAngleRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HorizontalFlightDownAngleRange_Offset), value);
			}
		}
	}

	[DisplayName("冲刺效果触发速度")]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云飞行配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushEffectSpeed")]
	public float RushEffectSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RushEffectSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushEffectSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RushEffectSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushEffectSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushEffectSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RushEffectSpeed_Offset), value);
			}
		}
	}

	[DisplayName("冲刺效果Buff列表")]
	[Category("筋斗云飞行配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushEffectBuffList")]
	public TArrayReadWrite<int> RushEffectBuffList
	{
		get
		{
			CheckDestroyed();
			if (!RushEffectBuffList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushEffectBuffList");
				return null;
			}
			if (RushEffectBuffList_Marshaler == null)
			{
				RushEffectBuffList_Marshaler = new TArrayReadWriteMarshaler<int>(1, RushEffectBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return RushEffectBuffList_Marshaler.FromNative(IntPtr.Add(base.Address, RushEffectBuffList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("冲刺AkEvent")]
	[Category("筋斗云飞行配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushAkEvent")]
	public UAkAudioEvent RushAkEvent
	{
		get
		{
			CheckDestroyed();
			if (!RushAkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushAkEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, RushAkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushAkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:RushAkEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, RushAkEvent_Offset), value);
			}
		}
	}

	[Category("筋斗云配置")]
	[DisplayName("筋斗云使用条件物品ID")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudMoveItemId")]
	public int CloudMoveItemId
	{
		get
		{
			CheckDestroyed();
			if (!CloudMoveItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudMoveItemId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CloudMoveItemId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudMoveItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudMoveItemId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CloudMoveItemId_Offset), value);
			}
		}
	}

	[Category("筋斗云配置")]
	[DisplayName("筋斗云期间BuffID")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudMoveBuffId")]
	public TArrayReadWrite<int> CloudMoveBuffId
	{
		get
		{
			CheckDestroyed();
			if (!CloudMoveBuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudMoveBuffId");
				return null;
			}
			if (CloudMoveBuffId_Marshaler == null)
			{
				CloudMoveBuffId_Marshaler = new TArrayReadWriteMarshaler<int>(1, CloudMoveBuffId_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return CloudMoveBuffId_Marshaler.FromNative(IntPtr.Add(base.Address, CloudMoveBuffId_Offset));
		}
	}

	[EditAnywhere]
	[DisplayName("筋斗云DBC")]
	[Category("筋斗云配置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC")]
	public BGWDataAsset_B1DBC CloudEffectDBC
	{
		get
		{
			CheckDestroyed();
			if (!CloudEffectDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, CloudEffectDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudEffectDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, CloudEffectDBC_Offset), value);
			}
		}
	}

	[Category("筋斗云配置")]
	[DisplayName("筋斗云DBC转向Lerp速度曲线")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_RotateLerpSpeedCurve")]
	public UCurveFloat CloudEffectDBC_RotateLerpSpeedCurve
	{
		get
		{
			CheckDestroyed();
			if (!CloudEffectDBC_RotateLerpSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_RotateLerpSpeedCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CloudEffectDBC_RotateLerpSpeedCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudEffectDBC_RotateLerpSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_RotateLerpSpeedCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CloudEffectDBC_RotateLerpSpeedCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("筋斗云配置")]
	[EditAnywhere]
	[DisplayName("筋斗云DBC位置Lerp速度曲线")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_LocationLerpSpeedCurve")]
	public UCurveFloat CloudEffectDBC_LocationLerpSpeedCurve
	{
		get
		{
			CheckDestroyed();
			if (!CloudEffectDBC_LocationLerpSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_LocationLerpSpeedCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CloudEffectDBC_LocationLerpSpeedCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudEffectDBC_LocationLerpSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_LocationLerpSpeedCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CloudEffectDBC_LocationLerpSpeedCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("筋斗云配置")]
	[DisplayName("筋斗云DBC位置偏移曲线")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_OffsetCurve")]
	public UCurveVector CloudEffectDBC_OffsetCurve
	{
		get
		{
			CheckDestroyed();
			if (!CloudEffectDBC_OffsetCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_OffsetCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, CloudEffectDBC_OffsetCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudEffectDBC_OffsetCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudEffectDBC_OffsetCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, CloudEffectDBC_OffsetCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云配置")]
	[DisplayName("筋斗云音效开始事件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudAkEventBegin")]
	public UAkAudioEvent CloudAkEventBegin
	{
		get
		{
			CheckDestroyed();
			if (!CloudAkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudAkEventBegin");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, CloudAkEventBegin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudAkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudAkEventBegin");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, CloudAkEventBegin_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云配置")]
	[DisplayName("筋斗云音效停止事件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudAkEventStop")]
	public UAkAudioEvent CloudAkEventStop
	{
		get
		{
			CheckDestroyed();
			if (!CloudAkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudAkEventStop");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, CloudAkEventStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudAkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudAkEventStop");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, CloudAkEventStop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("筋斗云配置")]
	[DisplayName("筋斗云植被透明倍率曲线")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudFoliageFadeScaleCurve")]
	public UCurveFloat CloudFoliageFadeScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!CloudFoliageFadeScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudFoliageFadeScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CloudFoliageFadeScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudFoliageFadeScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:CloudFoliageFadeScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CloudFoliageFadeScaleCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("筋斗云地面效果")]
	[DisplayName("地面效果触发距离")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectDistance")]
	public float GroundEffectDistance
	{
		get
		{
			CheckDestroyed();
			if (!GroundEffectDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GroundEffectDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundEffectDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GroundEffectDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云地面效果")]
	[DisplayName("地面效果创建间隔时间")]
	[Tooltip("填负数时，将不会间隔创建新的特效")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectInterval")]
	public float GroundEffectInterval
	{
		get
		{
			CheckDestroyed();
			if (!GroundEffectInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GroundEffectInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundEffectInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GroundEffectInterval_Offset), value);
			}
		}
	}

	[DisplayName("地面效果触发速度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("筋斗云地面效果")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectSpeed")]
	public float GroundEffectSpeed
	{
		get
		{
			CheckDestroyed();
			if (!GroundEffectSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GroundEffectSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundEffectSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffectSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GroundEffectSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("地面效果DBC")]
	[Category("筋斗云地面效果")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffects")]
	public TMapReadWrite<ESceneItemSurfaceType, FCloudMoveGroundEffectConfig> GroundEffects
	{
		get
		{
			CheckDestroyed();
			if (!GroundEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig:GroundEffects");
				return null;
			}
			if (GroundEffects_Marshaler == null)
			{
				GroundEffects_Marshaler = new TMapReadWriteMarshaler<ESceneItemSurfaceType, FCloudMoveGroundEffectConfig>(1, GroundEffects_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<FCloudMoveGroundEffectConfig, FCloudMoveGroundEffectConfig>.FromNative, CachedMarshalingDelegates<FCloudMoveGroundEffectConfig, FCloudMoveGroundEffectConfig>.ToNative);
			}
			return GroundEffects_Marshaler.FromNative(IntPtr.Add(base.Address, GroundEffects_Offset));
		}
	}

	public List<int> GetRideSkills()
	{
		return new List<int> { CloudSkill_Ride_Walk, CloudSkill_Ride_Run, CloudSkill_Ride_Sprint, CloudSkill_Ride_Fall };
	}

	public List<int> GetGetOffSkills()
	{
		List<int> list = new List<int>
		{
			CloudSkill_GetOff_Walk_Low, CloudSkill_GetOff_Walk_High, CloudSkill_GetOff_Run_Low_Forward, CloudSkill_GetOff_Run_Low_Upward, CloudSkill_GetOff_Run_Low_Downward, CloudSkill_GetOff_Run_High_Forward, CloudSkill_GetOff_Run_High_Upward, CloudSkill_GetOff_Run_High_Downward, CloudSkill_GetOff_Rush_Low_Forward, CloudSkill_GetOff_Rush_Low_Upward,
			CloudSkill_GetOff_Rush_Low_Downward, CloudSkill_GetOff_Rush_High_Forward, CloudSkill_GetOff_Rush_High_Upward, CloudSkill_GetOff_Rush_High_Downward
		};
		foreach (FCloudMoveBreakSkillConfig value in CloudSkill_BreakSkills.Values)
		{
			list.Add(value.BreakSkill_Low);
			list.Add(value.BreakSkill_High);
		}
		return list;
	}

	public List<string> GetResourcesPaths()
	{
		List<string> result = new List<string>();
		AddPathIfNotNull<UCurveFloat>(HeightLimitMaxPitchCurve);
		AddPathIfNotNull<UAkAudioEvent>(RushAkEvent);
		AddPathIfNotNull<BGWDataAsset_B1DBC>(CloudEffectDBC);
		AddPathIfNotNull<UCurveFloat>(CloudEffectDBC_LocationLerpSpeedCurve);
		AddPathIfNotNull<UCurveFloat>(CloudEffectDBC_RotateLerpSpeedCurve);
		AddPathIfNotNull<UCurveVector>(CloudEffectDBC_OffsetCurve);
		AddPathIfNotNull<UAkAudioEvent>(CloudAkEventBegin);
		AddPathIfNotNull<UAkAudioEvent>(CloudAkEventStop);
		AddPathIfNotNull<UCurveFloat>(CloudFoliageFadeScaleCurve);
		foreach (FCloudMoveGroundEffectConfig value in GroundEffects.Values)
		{
			result.Add(value.RunEffectDBC.PathName);
			result.Add(value.RushEffectDBC.PathName);
		}
		return result;
		void AddPathIfNotNull<T>(T Obj) where T : UObject
		{
			if (Obj != null)
			{
				result.Add(Obj.PathName);
			}
		}
	}

	public List<int> GetBuffConfigs()
	{
		List<int> list = new List<int>();
		list.AddRange(RushEffectBuffList);
		list.AddRange(CloudMoveBuffId);
		return list;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_CloudMoveConfig");
		CloudSkillCooldownTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkillCooldownTime");
		CloudSkillCooldownTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkillCooldownTime", Classes.FIntProperty);
		CloudSkill_Ride_Walk_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_Ride_Walk");
		CloudSkill_Ride_Walk_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_Ride_Walk", Classes.FIntProperty);
		CloudSkill_Ride_Run_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_Ride_Run");
		CloudSkill_Ride_Run_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_Ride_Run", Classes.FIntProperty);
		CloudSkill_Ride_Sprint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_Ride_Sprint");
		CloudSkill_Ride_Sprint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_Ride_Sprint", Classes.FIntProperty);
		CloudSkill_Ride_Fall_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_Ride_Fall");
		CloudSkill_Ride_Fall_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_Ride_Fall", Classes.FIntProperty);
		CloudSkill_Ride_Fall_MinHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_Ride_Fall_MinHeight");
		CloudSkill_Ride_Fall_MinHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_Ride_Fall_MinHeight", Classes.FFloatProperty);
		CloudSkill_GetOff_Walk_Low_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Walk_Low");
		CloudSkill_GetOff_Walk_Low_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Walk_Low", Classes.FIntProperty);
		CloudSkill_GetOff_Walk_High_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Walk_High");
		CloudSkill_GetOff_Walk_High_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Walk_High", Classes.FIntProperty);
		CloudSkill_GetOff_Run_Low_Forward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Run_Low_Forward");
		CloudSkill_GetOff_Run_Low_Forward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Run_Low_Forward", Classes.FIntProperty);
		CloudSkill_GetOff_Run_Low_Upward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Run_Low_Upward");
		CloudSkill_GetOff_Run_Low_Upward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Run_Low_Upward", Classes.FIntProperty);
		CloudSkill_GetOff_Run_Low_Downward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Run_Low_Downward");
		CloudSkill_GetOff_Run_Low_Downward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Run_Low_Downward", Classes.FIntProperty);
		CloudSkill_GetOff_Run_High_Forward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Run_High_Forward");
		CloudSkill_GetOff_Run_High_Forward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Run_High_Forward", Classes.FIntProperty);
		CloudSkill_GetOff_Run_High_Upward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Run_High_Upward");
		CloudSkill_GetOff_Run_High_Upward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Run_High_Upward", Classes.FIntProperty);
		CloudSkill_GetOff_Run_High_Downward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Run_High_Downward");
		CloudSkill_GetOff_Run_High_Downward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Run_High_Downward", Classes.FIntProperty);
		CloudSkill_GetOff_Rush_Low_Forward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Rush_Low_Forward");
		CloudSkill_GetOff_Rush_Low_Forward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Rush_Low_Forward", Classes.FIntProperty);
		CloudSkill_GetOff_Rush_Low_Upward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Rush_Low_Upward");
		CloudSkill_GetOff_Rush_Low_Upward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Rush_Low_Upward", Classes.FIntProperty);
		CloudSkill_GetOff_Rush_Low_Downward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Rush_Low_Downward");
		CloudSkill_GetOff_Rush_Low_Downward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Rush_Low_Downward", Classes.FIntProperty);
		CloudSkill_GetOff_Rush_High_Forward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Rush_High_Forward");
		CloudSkill_GetOff_Rush_High_Forward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Rush_High_Forward", Classes.FIntProperty);
		CloudSkill_GetOff_Rush_High_Upward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Rush_High_Upward");
		CloudSkill_GetOff_Rush_High_Upward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Rush_High_Upward", Classes.FIntProperty);
		CloudSkill_GetOff_Rush_High_Downward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_GetOff_Rush_High_Downward");
		CloudSkill_GetOff_Rush_High_Downward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_GetOff_Rush_High_Downward", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CloudSkill_BreakSkills_PropertyAddress, unrealStruct, "CloudSkill_BreakSkills");
		CloudSkill_BreakSkills_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudSkill_BreakSkills");
		CloudSkill_BreakSkills_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudSkill_BreakSkills", Classes.FMapProperty);
		HeightLimitThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeightLimitThreshold");
		HeightLimitThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeightLimitThreshold", Classes.FFloatProperty);
		HeightLimitMaxPitchCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeightLimitMaxPitchCurve");
		HeightLimitMaxPitchCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeightLimitMaxPitchCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DisableHeightLimitIfNoInput_PropertyAddress, unrealStruct, "DisableHeightLimitIfNoInput");
		DisableHeightLimitIfNoInput_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableHeightLimitIfNoInput");
		DisableHeightLimitIfNoInput_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableHeightLimitIfNoInput", Classes.FBoolProperty);
		MinimumHeightRestriction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinimumHeightRestriction");
		MinimumHeightRestriction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinimumHeightRestriction", Classes.FFloatProperty);
		MinimumHeightRestrictionThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinimumHeightRestrictionThreshold");
		MinimumHeightRestrictionThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinimumHeightRestrictionThreshold", Classes.FFloatProperty);
		HorizontalFlightUpAngleRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HorizontalFlightUpAngleRange");
		HorizontalFlightUpAngleRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HorizontalFlightUpAngleRange", Classes.FFloatProperty);
		HorizontalFlightDownAngleRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HorizontalFlightDownAngleRange");
		HorizontalFlightDownAngleRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HorizontalFlightDownAngleRange", Classes.FFloatProperty);
		RushEffectSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RushEffectSpeed");
		RushEffectSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RushEffectSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref RushEffectBuffList_PropertyAddress, unrealStruct, "RushEffectBuffList");
		RushEffectBuffList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RushEffectBuffList");
		RushEffectBuffList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RushEffectBuffList", Classes.FArrayProperty);
		RushAkEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RushAkEvent");
		RushAkEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RushAkEvent", Classes.FObjectProperty);
		CloudMoveItemId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudMoveItemId");
		CloudMoveItemId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudMoveItemId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CloudMoveBuffId_PropertyAddress, unrealStruct, "CloudMoveBuffId");
		CloudMoveBuffId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudMoveBuffId");
		CloudMoveBuffId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudMoveBuffId", Classes.FArrayProperty);
		CloudEffectDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudEffectDBC");
		CloudEffectDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudEffectDBC", Classes.FObjectProperty);
		CloudEffectDBC_RotateLerpSpeedCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudEffectDBC_RotateLerpSpeedCurve");
		CloudEffectDBC_RotateLerpSpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudEffectDBC_RotateLerpSpeedCurve", Classes.FObjectProperty);
		CloudEffectDBC_LocationLerpSpeedCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudEffectDBC_LocationLerpSpeedCurve");
		CloudEffectDBC_LocationLerpSpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudEffectDBC_LocationLerpSpeedCurve", Classes.FObjectProperty);
		CloudEffectDBC_OffsetCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudEffectDBC_OffsetCurve");
		CloudEffectDBC_OffsetCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudEffectDBC_OffsetCurve", Classes.FObjectProperty);
		CloudAkEventBegin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudAkEventBegin");
		CloudAkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudAkEventBegin", Classes.FObjectProperty);
		CloudAkEventStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudAkEventStop");
		CloudAkEventStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudAkEventStop", Classes.FObjectProperty);
		CloudFoliageFadeScaleCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudFoliageFadeScaleCurve");
		CloudFoliageFadeScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudFoliageFadeScaleCurve", Classes.FObjectProperty);
		GroundEffectDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroundEffectDistance");
		GroundEffectDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroundEffectDistance", Classes.FFloatProperty);
		GroundEffectInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroundEffectInterval");
		GroundEffectInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroundEffectInterval", Classes.FFloatProperty);
		GroundEffectSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroundEffectSpeed");
		GroundEffectSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroundEffectSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref GroundEffects_PropertyAddress, unrealStruct, "GroundEffects");
		GroundEffects_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroundEffects");
		GroundEffects_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroundEffects", Classes.FMapProperty);
	}

	static BGWDataAsset_CloudMoveConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_CloudMoveConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_CloudMoveConfig));
	}
}
