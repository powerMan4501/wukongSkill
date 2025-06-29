using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir")]
public class BUAnimHumanoidCS_Simple4Dir : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPBGUCharacterData BGUData;

	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPCommonLocomotionData CommonLocomotionData;

	private IBUC_ABPJogData HumanoidJogData;

	private static bool BSStart_IsValid;

	private static int BSStart_Offset;

	private static bool BSEnd_IsValid;

	private static int BSEnd_Offset;

	private static bool CardinalDirectionBlendTime_IsValid;

	private static int CardinalDirectionBlendTime_Offset;

	private static bool AnimTurnInPlaceLeft_IsValid;

	private static int AnimTurnInPlaceLeft_Offset;

	private static bool AnimTurnInPlaceRight_IsValid;

	private static int AnimTurnInPlaceRight_Offset;

	private static bool BSWalkFwd_IsValid;

	private static int BSWalkFwd_Offset;

	private static bool BSWalkBwd_IsValid;

	private static int BSWalkBwd_Offset;

	private static bool BSWalkLeft_IsValid;

	private static int BSWalkLeft_Offset;

	private static bool BSWalkRight_IsValid;

	private static int BSWalkRight_Offset;

	private static bool BSRunFwd_IsValid;

	private static int BSRunFwd_Offset;

	private static bool BSRunBwd_IsValid;

	private static int BSRunBwd_Offset;

	private static bool BSRunLeft_IsValid;

	private static int BSRunLeft_Offset;

	private static bool BSRunRight_IsValid;

	private static int BSRunRight_Offset;

	private static bool BSSprint_IsValid;

	private static int BSSprint_Offset;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	private static bool VerticleSpeed_IsValid;

	private static int VerticleSpeed_Offset;

	private static bool HorizontalSpeed_IsValid;

	private static int HorizontalSpeed_Offset;

	private static bool bHasRun_IsValid;

	private static int bHasRun_Offset;

	private static FFieldAddress bHasRun_PropertyAddress;

	private static bool JogBaseSpeed_IsValid;

	private static int JogBaseSpeed_Offset;

	private static bool RunSpeed_IsValid;

	private static int RunSpeed_Offset;

	private static bool SprintSpeed_IsValid;

	private static int SprintSpeed_Offset;

	private static bool IsFalling_IsValid;

	private static int IsFalling_Offset;

	private static FFieldAddress IsFalling_PropertyAddress;

	private static bool LeanAngle_IsValid;

	private static int LeanAngle_Offset;

	private static bool SlopeRightAngle_IsValid;

	private static int SlopeRightAngle_Offset;

	private static bool SlopeForwardAngle_IsValid;

	private static int SlopeForwardAngle_Offset;

	private static bool SpeedWarpAmount_IsValid;

	private static int SpeedWarpAmount_Offset;

	private static bool BSStartX_IsValid;

	private static int BSStartX_Offset;

	private static bool BSStartY_IsValid;

	private static int BSStartY_Offset;

	private static bool BSStopX_IsValid;

	private static int BSStopX_Offset;

	private static bool BSStopY_IsValid;

	private static int BSStopY_Offset;

	private static bool BSStopNoBreakX_IsValid;

	private static int BSStopNoBreakX_Offset;

	private static bool BSStopNoBreakY_IsValid;

	private static int BSStopNoBreakY_Offset;

	private static bool bLoopToIdle_IsValid;

	private static int bLoopToIdle_Offset;

	private static FFieldAddress bLoopToIdle_PropertyAddress;

	private static bool bLoopToStop_IsValid;

	private static int bLoopToStop_Offset;

	private static FFieldAddress bLoopToStop_PropertyAddress;

	private static bool bLoopToStopWithNoBreak_IsValid;

	private static int bLoopToStopWithNoBreak_Offset;

	private static FFieldAddress bLoopToStopWithNoBreak_PropertyAddress;

	private static bool bStartToLoop_IsValid;

	private static int bStartToLoop_Offset;

	private static FFieldAddress bStartToLoop_PropertyAddress;

	private static bool bIdleToLoop_IsValid;

	private static int bIdleToLoop_Offset;

	private static FFieldAddress bIdleToLoop_PropertyAddress;

	private static bool bIdleToStart_IsValid;

	private static int bIdleToStart_Offset;

	private static FFieldAddress bIdleToStart_PropertyAddress;

	private static bool bStartToIdle_IsValid;

	private static int bStartToIdle_Offset;

	private static FFieldAddress bStartToIdle_PropertyAddress;

	private static bool bStopToIdle_IsValid;

	private static int bStopToIdle_Offset;

	private static FFieldAddress bStopToIdle_PropertyAddress;

	private static bool bStopWithNoBreakToIdle_IsValid;

	private static int bStopWithNoBreakToIdle_Offset;

	private static FFieldAddress bStopWithNoBreakToIdle_PropertyAddress;

	private static bool LocomotionCardinalDirection_IsValid;

	private static int LocomotionCardinalDirection_Offset;

	private static FFieldAddress LocomotionCardinalDirection_PropertyAddress;

	private static bool LocomotionOrientationAngle_IsValid;

	private static int LocomotionOrientationAngle_Offset;

	private static bool AnimFallingStart_IsValid;

	private static int AnimFallingStart_Offset;

	private static bool AnimFallingLoop_IsValid;

	private static int AnimFallingLoop_Offset;

	private static bool AnimFallingLand_IsValid;

	private static int AnimFallingLand_Offset;

	private static bool FallingLoopPlayRate_IsValid;

	private static int FallingLoopPlayRate_Offset;

	private static bool bHasJumpAnimAsset_IsValid;

	private static int bHasJumpAnimAsset_Offset;

	private static FFieldAddress bHasJumpAnimAsset_PropertyAddress;

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStart")]
	public UBlendSpace BSStart
	{
		get
		{
			CheckDestroyed();
			if (!BSStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStart");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStart");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSStart_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSEnd")]
	public UBlendSpace BSEnd
	{
		get
		{
			CheckDestroyed();
			if (!BSEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSEnd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSEnd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSEnd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:CardinalDirectionBlendTime")]
	public float CardinalDirectionBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!CardinalDirectionBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:CardinalDirectionBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CardinalDirectionBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CardinalDirectionBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:CardinalDirectionBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CardinalDirectionBlendTime_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimTurnInPlaceLeft")]
	public UAnimSequence AnimTurnInPlaceLeft
	{
		get
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimTurnInPlaceLeft");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimTurnInPlaceLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimTurnInPlaceLeft");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimTurnInPlaceLeft_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimTurnInPlaceRight")]
	public UAnimSequence AnimTurnInPlaceRight
	{
		get
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimTurnInPlaceRight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimTurnInPlaceRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimTurnInPlaceRight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimTurnInPlaceRight_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkFwd")]
	public UBlendSpace BSWalkFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSWalkFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSWalkFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSWalkFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSWalkFwd_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkBwd")]
	public UBlendSpace BSWalkBwd
	{
		get
		{
			CheckDestroyed();
			if (!BSWalkBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkBwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSWalkBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSWalkBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkBwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSWalkBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkLeft")]
	public UBlendSpace BSWalkLeft
	{
		get
		{
			CheckDestroyed();
			if (!BSWalkLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkLeft");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSWalkLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSWalkLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkLeft");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSWalkLeft_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkRight")]
	public UBlendSpace BSWalkRight
	{
		get
		{
			CheckDestroyed();
			if (!BSWalkRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkRight");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSWalkRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSWalkRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSWalkRight");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSWalkRight_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunFwd")]
	public UBlendSpace BSRunFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSRunFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunBwd")]
	public UBlendSpace BSRunBwd
	{
		get
		{
			CheckDestroyed();
			if (!BSRunBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunBwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunBwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunBwd_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunLeft")]
	public UBlendSpace BSRunLeft
	{
		get
		{
			CheckDestroyed();
			if (!BSRunLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunLeft");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunLeft");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunLeft_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunRight")]
	public UBlendSpace BSRunRight
	{
		get
		{
			CheckDestroyed();
			if (!BSRunRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunRight");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSRunRight");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunRight_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSSprint")]
	public UBlendSpace BSSprint
	{
		get
		{
			CheckDestroyed();
			if (!BSSprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSSprint");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSSprint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSSprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSSprint");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSSprint_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:Speed")]
	public float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:VerticleSpeed")]
	public float VerticleSpeed
	{
		get
		{
			CheckDestroyed();
			if (!VerticleSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:VerticleSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VerticleSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VerticleSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:VerticleSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VerticleSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:HorizontalSpeed")]
	public float HorizontalSpeed
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:HorizontalSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HorizontalSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:HorizontalSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HorizontalSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bHasRun")]
	public bool bHasRun
	{
		get
		{
			CheckDestroyed();
			if (!bHasRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bHasRun");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasRun_Offset), 0, bHasRun_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bHasRun");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasRun_Offset), 0, bHasRun_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:JogBaseSpeed")]
	public float JogBaseSpeed
	{
		get
		{
			CheckDestroyed();
			if (!JogBaseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:JogBaseSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JogBaseSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JogBaseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:JogBaseSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JogBaseSpeed_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:RunSpeed")]
	public float RunSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RunSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:RunSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RunSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:RunSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RunSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SprintSpeed")]
	public float SprintSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SprintSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SprintSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SprintSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SprintSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SprintSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SprintSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:IsFalling")]
	public bool IsFalling
	{
		get
		{
			CheckDestroyed();
			if (!IsFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:IsFalling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFalling_Offset), 0, IsFalling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:IsFalling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFalling_Offset), 0, IsFalling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LeanAngle")]
	public float LeanAngle
	{
		get
		{
			CheckDestroyed();
			if (!LeanAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LeanAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeanAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeanAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LeanAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeanAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SlopeRightAngle")]
	public float SlopeRightAngle
	{
		get
		{
			CheckDestroyed();
			if (!SlopeRightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SlopeRightAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlopeRightAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlopeRightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SlopeRightAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlopeRightAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Locomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SlopeForwardAngle")]
	public float SlopeForwardAngle
	{
		get
		{
			CheckDestroyed();
			if (!SlopeForwardAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SlopeForwardAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlopeForwardAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlopeForwardAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SlopeForwardAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlopeForwardAngle_Offset), value);
			}
		}
	}

	[Category("Locomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SpeedWarpAmount")]
	public float SpeedWarpAmount
	{
		get
		{
			CheckDestroyed();
			if (!SpeedWarpAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SpeedWarpAmount");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedWarpAmount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedWarpAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:SpeedWarpAmount");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedWarpAmount_Offset), value);
			}
		}
	}

	[Category("Locomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStartX")]
	public float BSStartX
	{
		get
		{
			CheckDestroyed();
			if (!BSStartX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStartX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSStartX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStartX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStartX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSStartX_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStartY")]
	public float BSStartY
	{
		get
		{
			CheckDestroyed();
			if (!BSStartY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStartY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSStartY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStartY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStartY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSStartY_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Locomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopX")]
	public float BSStopX
	{
		get
		{
			CheckDestroyed();
			if (!BSStopX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSStopX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStopX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSStopX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopY")]
	public float BSStopY
	{
		get
		{
			CheckDestroyed();
			if (!BSStopY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSStopY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStopY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSStopY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopNoBreakX")]
	public float BSStopNoBreakX
	{
		get
		{
			CheckDestroyed();
			if (!BSStopNoBreakX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopNoBreakX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSStopNoBreakX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStopNoBreakX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopNoBreakX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSStopNoBreakX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopNoBreakY")]
	public float BSStopNoBreakY
	{
		get
		{
			CheckDestroyed();
			if (!BSStopNoBreakY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopNoBreakY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSStopNoBreakY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSStopNoBreakY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:BSStopNoBreakY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSStopNoBreakY_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToIdle")]
	public bool bLoopToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bLoopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopToIdle_Offset), 0, bLoopToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoopToIdle_Offset), 0, bLoopToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Locomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToStop")]
	public bool bLoopToStop
	{
		get
		{
			CheckDestroyed();
			if (!bLoopToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopToStop_Offset), 0, bLoopToStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoopToStop_Offset), 0, bLoopToStop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Locomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToStopWithNoBreak")]
	public bool bLoopToStopWithNoBreak
	{
		get
		{
			CheckDestroyed();
			if (!bLoopToStopWithNoBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToStopWithNoBreak");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopToStopWithNoBreak_Offset), 0, bLoopToStopWithNoBreak_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopToStopWithNoBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bLoopToStopWithNoBreak");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoopToStopWithNoBreak_Offset), 0, bLoopToStopWithNoBreak_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Locomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStartToLoop")]
	public bool bStartToLoop
	{
		get
		{
			CheckDestroyed();
			if (!bStartToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStartToLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStartToLoop_Offset), 0, bStartToLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStartToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStartToLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStartToLoop_Offset), 0, bStartToLoop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bIdleToLoop")]
	public bool bIdleToLoop
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bIdleToLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToLoop_Offset), 0, bIdleToLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bIdleToLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToLoop_Offset), 0, bIdleToLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Locomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bIdleToStart")]
	public bool bIdleToStart
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bIdleToStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToStart_Offset), 0, bIdleToStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bIdleToStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToStart_Offset), 0, bIdleToStart_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStartToIdle")]
	public bool bStartToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bStartToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStartToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStartToIdle_Offset), 0, bStartToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStartToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStartToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStartToIdle_Offset), 0, bStartToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStopToIdle")]
	public bool bStopToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bStopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStopToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopToIdle_Offset), 0, bStopToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStopToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopToIdle_Offset), 0, bStopToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Locomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStopWithNoBreakToIdle")]
	public bool bStopWithNoBreakToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bStopWithNoBreakToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStopWithNoBreakToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopWithNoBreakToIdle_Offset), 0, bStopWithNoBreakToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopWithNoBreakToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bStopWithNoBreakToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopWithNoBreakToIdle_Offset), 0, bStopWithNoBreakToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("HumanoidJog")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LocomotionCardinalDirection")]
	public ECardinalDir LocomotionCardinalDirection
	{
		get
		{
			CheckDestroyed();
			if (!LocomotionCardinalDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LocomotionCardinalDirection");
				return ECardinalDir.Default;
			}
			return EnumMarshaler<ECardinalDir>.FromNative(IntPtr.Add(base.Address, LocomotionCardinalDirection_Offset), 0, LocomotionCardinalDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocomotionCardinalDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LocomotionCardinalDirection");
			}
			else
			{
				EnumMarshaler<ECardinalDir>.ToNative(IntPtr.Add(base.Address, LocomotionCardinalDirection_Offset), 0, LocomotionCardinalDirection_PropertyAddress.Address, value);
			}
		}
	}

	[Category("HumanoidJog")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LocomotionOrientationAngle")]
	public float LocomotionOrientationAngle
	{
		get
		{
			CheckDestroyed();
			if (!LocomotionOrientationAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LocomotionOrientationAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LocomotionOrientationAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocomotionOrientationAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:LocomotionOrientationAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LocomotionOrientationAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingStart")]
	public UAnimSequence AnimFallingStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallingStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallingStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallingStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallingStart_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingLoop")]
	public UAnimSequence AnimFallingLoop
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallingLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallingLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallingLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallingLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Jump")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingLand")]
	public UAnimSequence AnimFallingLand
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallingLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallingLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallingLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:AnimFallingLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallingLand_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:FallingLoopPlayRate")]
	public float FallingLoopPlayRate
	{
		get
		{
			CheckDestroyed();
			if (!FallingLoopPlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:FallingLoopPlayRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FallingLoopPlayRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallingLoopPlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:FallingLoopPlayRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FallingLoopPlayRate_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bHasJumpAnimAsset")]
	public bool bHasJumpAnimAsset
	{
		get
		{
			CheckDestroyed();
			if (!bHasJumpAnimAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bHasJumpAnimAsset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasJumpAnimAsset_Offset), 0, bHasJumpAnimAsset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasJumpAnimAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir:bHasJumpAnimAsset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasJumpAnimAsset_Offset), 0, bHasJumpAnimAsset_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			InitData();
		}
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
		{
			AnimIdle = TopAnimInst.ABPSettingData.CommonSetting.AnimSeqIdle;
		}
		CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData();
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			BGUData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBGUCharacterData, BUC_ABPBGUCharacterData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			CommonLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonLocomotionData, BUC_ABPCommonLocomotionData>(Owner);
			HumanoidJogData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPJogData, BUC_ABPJogData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (BasicData != null)
		{
			SpeedWarpAmount = BasicData.SpeedWarpAmount;
			Speed = BasicData.Speed;
			bHasRun = BasicData.bHasRun;
			JogBaseSpeed = BasicData.JogBaseSpeed;
			RunSpeed = BasicData.RunSpeed;
			SprintSpeed = BasicData.SprintSpeed;
		}
		if (CommonData != null)
		{
			BSStart = CommonData.BSStart;
			BSEnd = CommonData.BSEnd;
			BSRunFwd = CommonData.BSRunFwd;
			BSRunBwd = CommonData.BSRunBwd;
			BSRunLeft = CommonData.BSRunLeft;
			BSRunRight = CommonData.BSRunRight;
			BSWalkFwd = CommonData.BSWalkFwd;
			BSWalkBwd = CommonData.BSWalkBwd;
			BSWalkLeft = CommonData.BSWalkLeft;
			BSWalkRight = CommonData.BSWalkRight;
			BSSprint = CommonData.BSSprint;
			AnimTurnInPlaceLeft = CommonData.AnimTurnInPlaceLeft;
			AnimTurnInPlaceRight = CommonData.AnimTurnInPlaceRight;
			CardinalDirectionBlendTime = CommonData.CardinalDirectionBlendTime;
			AnimIdle = CommonData.AnimIdle;
		}
		if (CommonLocomotionData != null)
		{
			LeanAngle = CommonLocomotionData.LeanAngle;
		}
		if (HumanoidJogData != null)
		{
			LocomotionCardinalDirection = HumanoidJogData.LocomotionCardinalDirection;
			LocomotionOrientationAngle = HumanoidJogData.LocomotionOrientationAngle;
		}
	}

	private void UpdateData()
	{
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
		}
		if (CommonData != null && CommonData.FinalABPMoveMode == EABPMoveMode.Locomotion_Simple4Dir)
		{
			if (BasicData != null)
			{
				SpeedWarpAmount = BasicData.SpeedWarpAmount;
				Speed = BasicData.Speed;
				VerticleSpeed = BasicData.VerticleSpeed;
				HorizontalSpeed = BasicData.HorizontalSpeed;
				JogBaseSpeed = BasicData.JogBaseSpeed;
				RunSpeed = BasicData.RunSpeed;
				SprintSpeed = BasicData.SprintSpeed;
			}
			if (ChrData != null)
			{
				IsFalling = ChrData.IsFalling;
			}
			if (CommonData != null)
			{
				AnimIdle = CommonData.AnimIdle;
				BSRunFwd = CommonData.BSRunFwd;
				BSRunBwd = CommonData.BSRunBwd;
				BSRunLeft = CommonData.BSRunLeft;
				BSRunRight = CommonData.BSRunRight;
				BSWalkFwd = CommonData.BSWalkFwd;
				BSWalkBwd = CommonData.BSWalkBwd;
				BSWalkLeft = CommonData.BSWalkLeft;
				BSWalkRight = CommonData.BSWalkRight;
			}
			if (CommonLocomotionData != null)
			{
				LeanAngle = CommonLocomotionData.LeanAngle;
				SlopeForwardAngle = CommonLocomotionData.SlopeForwardAngle;
				SlopeRightAngle = CommonLocomotionData.SlopeRightAngle;
				BSStartX = CommonLocomotionData.BSStartX;
				BSStartY = CommonLocomotionData.BSStartY;
				BSStopX = CommonLocomotionData.BSStopX;
				BSStopY = CommonLocomotionData.BSStopY;
				BSStopNoBreakX = CommonLocomotionData.BSStopNoBreakX;
				BSStopNoBreakY = CommonLocomotionData.BSStopNoBreakY;
			}
			if (HumanoidJogData != null)
			{
				LocomotionCardinalDirection = HumanoidJogData.LocomotionCardinalDirection;
				LocomotionOrientationAngle = HumanoidJogData.LocomotionOrientationAngle;
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			float value = 0f;
			float value2 = 0f;
			int num = 0;
			if (CommonData != null)
			{
				flag = CommonData.BSStart != null;
				flag2 = CommonData.BSEnd != null;
			}
			if (ChrData != null)
			{
				flag3 = ChrData.IsMontage;
			}
			if (BGUData != null)
			{
				flag4 = BGUData.bOrientRotationToMovement;
				value = BGUData.InputMoveForward;
				value2 = BGUData.InputMoveSideways;
				num = BGUData.BSEndMode;
				flag6 = BGUData.bSideWalking;
			}
			if (HumanoidJogData != null)
			{
				flag5 = HumanoidJogData.MoveIsAccelerate;
			}
			bLoopToIdle = Speed == 0f || (flag3 && FMath.Abs(value) <= 0.1f);
			bLoopToStopWithNoBreak = FMath.Abs(value) <= 0.1f && FMath.Abs(value2) <= 0.1f && flag2 && num == 2 && flag4 && !flag3;
			bLoopToStop = FMath.Abs(value) <= 0.1f && FMath.Abs(value2) <= 0.1f && flag2 && num != 2 && flag4 && !flag3;
			bStartToLoop = !flag4;
			bIdleToLoop = Speed > 0.1f && (!flag5 || !flag4 || !flag) && !(FMath.Abs(value) <= 0.1f);
			bIdleToStart = flag5 && !flag6 && flag && Speed >= 11f && (!flag3 || !(FMath.Abs(value) <= 0.1f));
			bStartToIdle = (Speed < 50f && !flag5) || (FMath.Abs(value) <= 0.1f && FMath.Abs(value2) <= 0.1f);
			bStopToIdle = flag3 || !flag4 || flag5;
			bStopWithNoBreakToIdle = flag3;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_Simple4Dir");
		BSStart_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStart");
		BSStart_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStart", Classes.FObjectProperty);
		BSEnd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSEnd");
		BSEnd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSEnd", Classes.FObjectProperty);
		CardinalDirectionBlendTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CardinalDirectionBlendTime");
		CardinalDirectionBlendTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CardinalDirectionBlendTime", Classes.FFloatProperty);
		AnimTurnInPlaceLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimTurnInPlaceLeft");
		AnimTurnInPlaceLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimTurnInPlaceLeft", Classes.FObjectProperty);
		AnimTurnInPlaceRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimTurnInPlaceRight");
		AnimTurnInPlaceRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimTurnInPlaceRight", Classes.FObjectProperty);
		BSWalkFwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSWalkFwd");
		BSWalkFwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSWalkFwd", Classes.FObjectProperty);
		BSWalkBwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSWalkBwd");
		BSWalkBwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSWalkBwd", Classes.FObjectProperty);
		BSWalkLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSWalkLeft");
		BSWalkLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSWalkLeft", Classes.FObjectProperty);
		BSWalkRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSWalkRight");
		BSWalkRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSWalkRight", Classes.FObjectProperty);
		BSRunFwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSRunFwd");
		BSRunFwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSRunFwd", Classes.FObjectProperty);
		BSRunBwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSRunBwd");
		BSRunBwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSRunBwd", Classes.FObjectProperty);
		BSRunLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSRunLeft");
		BSRunLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSRunLeft", Classes.FObjectProperty);
		BSRunRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSRunRight");
		BSRunRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSRunRight", Classes.FObjectProperty);
		BSSprint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSSprint");
		BSSprint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSSprint", Classes.FObjectProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimIdle", Classes.FObjectProperty);
		Speed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Speed");
		Speed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Speed", Classes.FFloatProperty);
		VerticleSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VerticleSpeed");
		VerticleSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VerticleSpeed", Classes.FFloatProperty);
		HorizontalSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HorizontalSpeed");
		HorizontalSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HorizontalSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bHasRun_PropertyAddress, unrealStruct, "bHasRun");
		bHasRun_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHasRun");
		bHasRun_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHasRun", Classes.FBoolProperty);
		JogBaseSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JogBaseSpeed");
		JogBaseSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JogBaseSpeed", Classes.FFloatProperty);
		RunSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RunSpeed");
		RunSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RunSpeed", Classes.FFloatProperty);
		SprintSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SprintSpeed");
		SprintSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SprintSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsFalling_PropertyAddress, unrealStruct, "IsFalling");
		IsFalling_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsFalling");
		IsFalling_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsFalling", Classes.FBoolProperty);
		LeanAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeanAngle");
		LeanAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeanAngle", Classes.FFloatProperty);
		SlopeRightAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SlopeRightAngle");
		SlopeRightAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SlopeRightAngle", Classes.FFloatProperty);
		SlopeForwardAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SlopeForwardAngle");
		SlopeForwardAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SlopeForwardAngle", Classes.FFloatProperty);
		SpeedWarpAmount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedWarpAmount");
		SpeedWarpAmount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedWarpAmount", Classes.FFloatProperty);
		BSStartX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStartX");
		BSStartX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStartX", Classes.FFloatProperty);
		BSStartY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStartY");
		BSStartY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStartY", Classes.FFloatProperty);
		BSStopX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStopX");
		BSStopX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStopX", Classes.FFloatProperty);
		BSStopY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStopY");
		BSStopY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStopY", Classes.FFloatProperty);
		BSStopNoBreakX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStopNoBreakX");
		BSStopNoBreakX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStopNoBreakX", Classes.FFloatProperty);
		BSStopNoBreakY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSStopNoBreakY");
		BSStopNoBreakY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSStopNoBreakY", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bLoopToIdle_PropertyAddress, unrealStruct, "bLoopToIdle");
		bLoopToIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLoopToIdle");
		bLoopToIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLoopToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLoopToStop_PropertyAddress, unrealStruct, "bLoopToStop");
		bLoopToStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLoopToStop");
		bLoopToStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLoopToStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLoopToStopWithNoBreak_PropertyAddress, unrealStruct, "bLoopToStopWithNoBreak");
		bLoopToStopWithNoBreak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLoopToStopWithNoBreak");
		bLoopToStopWithNoBreak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLoopToStopWithNoBreak", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStartToLoop_PropertyAddress, unrealStruct, "bStartToLoop");
		bStartToLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bStartToLoop");
		bStartToLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bStartToLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToLoop_PropertyAddress, unrealStruct, "bIdleToLoop");
		bIdleToLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bIdleToLoop");
		bIdleToLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bIdleToLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToStart_PropertyAddress, unrealStruct, "bIdleToStart");
		bIdleToStart_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bIdleToStart");
		bIdleToStart_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bIdleToStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStartToIdle_PropertyAddress, unrealStruct, "bStartToIdle");
		bStartToIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bStartToIdle");
		bStartToIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bStartToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStopToIdle_PropertyAddress, unrealStruct, "bStopToIdle");
		bStopToIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bStopToIdle");
		bStopToIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bStopToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStopWithNoBreakToIdle_PropertyAddress, unrealStruct, "bStopWithNoBreakToIdle");
		bStopWithNoBreakToIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bStopWithNoBreakToIdle");
		bStopWithNoBreakToIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bStopWithNoBreakToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LocomotionCardinalDirection_PropertyAddress, unrealStruct, "LocomotionCardinalDirection");
		LocomotionCardinalDirection_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LocomotionCardinalDirection");
		LocomotionCardinalDirection_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LocomotionCardinalDirection", Classes.FEnumProperty);
		LocomotionOrientationAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LocomotionOrientationAngle");
		LocomotionOrientationAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LocomotionOrientationAngle", Classes.FFloatProperty);
		AnimFallingStart_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimFallingStart");
		AnimFallingStart_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimFallingStart", Classes.FObjectProperty);
		AnimFallingLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimFallingLoop");
		AnimFallingLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimFallingLoop", Classes.FObjectProperty);
		AnimFallingLand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimFallingLand");
		AnimFallingLand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimFallingLand", Classes.FObjectProperty);
		FallingLoopPlayRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FallingLoopPlayRate");
		FallingLoopPlayRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FallingLoopPlayRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bHasJumpAnimAsset_PropertyAddress, unrealStruct, "bHasJumpAnimAsset");
		bHasJumpAnimAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHasJumpAnimAsset");
		bHasJumpAnimAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHasJumpAnimAsset", Classes.FBoolProperty);
	}

	static BUAnimHumanoidCS_Simple4Dir()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_Simple4Dir)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_Simple4Dir));
	}
}
