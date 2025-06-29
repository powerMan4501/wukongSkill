using System;
using System.Collections.Generic;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion")]
public class BUAnimHumanoidCS_QuadrupedLocomotion : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPQuadrupedLocomotionData QuadrupedLocomotionData;

	private IBUC_ABPJumpV2Data JumpData;

	private List<UAnimSequence> AnimIdleList = new List<UAnimSequence>();

	private UAnimSequence ASRunFall;

	private UAnimSequence ASRushFall;

	private UAnimSequence ASRunFallSlope;

	private UAnimSequence ASRushFallSlope;

	private UAnimSequence ASRunLandMove;

	private UAnimSequence ASRushLandMove;

	private UAnimSequence ASRunLandMoveSlope;

	private UAnimSequence ASRushLandMoveSlope;

	private UAnimSequence ASRunLandStop;

	private UAnimSequence ASRushLandStop;

	private UAnimSequence ASRunLandStopSlope;

	private UAnimSequence ASRushLandStopSlope;

	private static bool BSMove_IsValid;

	private static int BSMove_Offset;

	private static bool BSMoveBack_IsValid;

	private static int BSMoveBack_Offset;

	private static bool MoveYaw_IsValid;

	private static int MoveYaw_Offset;

	private static bool SpeedRate_IsValid;

	private static int SpeedRate_Offset;

	private static bool ASWalkStop_IsValid;

	private static int ASWalkStop_Offset;

	private static bool ASRunStartF_IsValid;

	private static int ASRunStartF_Offset;

	private static bool ASRunStartL_IsValid;

	private static int ASRunStartL_Offset;

	private static bool ASRunStartR_IsValid;

	private static int ASRunStartR_Offset;

	private static bool ASRunStartBL_IsValid;

	private static int ASRunStartBL_Offset;

	private static bool ASRunStartBR_IsValid;

	private static int ASRunStartBR_Offset;

	private static bool ASRunTurnStop_IsValid;

	private static int ASRunTurnStop_Offset;

	private static bool ASRunTurnL_IsValid;

	private static int ASRunTurnL_Offset;

	private static bool ASRunTurnR_IsValid;

	private static int ASRunTurnR_Offset;

	private static bool ASRunTurnBL_IsValid;

	private static int ASRunTurnBL_Offset;

	private static bool ASRunTurnBR_IsValid;

	private static int ASRunTurnBR_Offset;

	private static bool ASRunStop_IsValid;

	private static int ASRunStop_Offset;

	private static bool ASRushStartF_IsValid;

	private static int ASRushStartF_Offset;

	private static bool ASRushStartL_IsValid;

	private static int ASRushStartL_Offset;

	private static bool ASRushStartR_IsValid;

	private static int ASRushStartR_Offset;

	private static bool ASRushStartBL_IsValid;

	private static int ASRushStartBL_Offset;

	private static bool ASRushStartBR_IsValid;

	private static int ASRushStartBR_Offset;

	private static bool ASRushTurnStop_IsValid;

	private static int ASRushTurnStop_Offset;

	private static bool ASRushTurnL_IsValid;

	private static int ASRushTurnL_Offset;

	private static bool ASRushTurnR_IsValid;

	private static int ASRushTurnR_Offset;

	private static bool ASRushTurnBL_IsValid;

	private static int ASRushTurnBL_Offset;

	private static bool ASRushTurnBR_IsValid;

	private static int ASRushTurnBR_Offset;

	private static bool ASRushStop_IsValid;

	private static int ASRushStop_Offset;

	private static bool ASRunJump_IsValid;

	private static int ASRunJump_Offset;

	private static bool ASRushJump_IsValid;

	private static int ASRushJump_Offset;

	private static bool ASRunJumpSlope_IsValid;

	private static int ASRunJumpSlope_Offset;

	private static bool ASRushJumpSlope_IsValid;

	private static int ASRushJumpSlope_Offset;

	private static bool bUpdateAnimIdle_IsValid;

	private static int bUpdateAnimIdle_Offset;

	private static FFieldAddress bUpdateAnimIdle_PropertyAddress;

	private static bool bShouldMove_IsValid;

	private static int bShouldMove_Offset;

	private static FFieldAddress bShouldMove_PropertyAddress;

	private static bool bIdleToStart_IsValid;

	private static int bIdleToStart_Offset;

	private static FFieldAddress bIdleToStart_PropertyAddress;

	private static bool bIdleToLoop_IsValid;

	private static int bIdleToLoop_Offset;

	private static FFieldAddress bIdleToLoop_PropertyAddress;

	private static bool bLoopToIdle_IsValid;

	private static int bLoopToIdle_Offset;

	private static FFieldAddress bLoopToIdle_PropertyAddress;

	private static bool bMoveBack_IsValid;

	private static int bMoveBack_Offset;

	private static FFieldAddress bMoveBack_PropertyAddress;

	private static bool bInJump_IsValid;

	private static int bInJump_Offset;

	private static FFieldAddress bInJump_PropertyAddress;

	private static bool bSlopeJump_IsValid;

	private static int bSlopeJump_Offset;

	private static FFieldAddress bSlopeJump_PropertyAddress;

	private static bool bToFall_IsValid;

	private static int bToFall_Offset;

	private static FFieldAddress bToFall_PropertyAddress;

	private static bool bToLandAnim_IsValid;

	private static int bToLandAnim_Offset;

	private static FFieldAddress bToLandAnim_PropertyAddress;

	private static bool bToLandMove_IsValid;

	private static int bToLandMove_Offset;

	private static FFieldAddress bToLandMove_PropertyAddress;

	private static bool bToTurn_IsValid;

	private static int bToTurn_Offset;

	private static FFieldAddress bToTurn_PropertyAddress;

	private static bool bToStop_IsValid;

	private static int bToStop_Offset;

	private static FFieldAddress bToStop_PropertyAddress;

	private static bool bToTurnStop_IsValid;

	private static int bToTurnStop_Offset;

	private static FFieldAddress bToTurnStop_PropertyAddress;

	private static bool bToWalk_IsValid;

	private static int bToWalk_Offset;

	private static FFieldAddress bToWalk_PropertyAddress;

	private static bool bToRun_IsValid;

	private static int bToRun_Offset;

	private static FFieldAddress bToRun_PropertyAddress;

	private static bool bToRush_IsValid;

	private static int bToRush_Offset;

	private static FFieldAddress bToRush_PropertyAddress;

	private static bool bToRunJump_IsValid;

	private static int bToRunJump_Offset;

	private static FFieldAddress bToRunJump_PropertyAddress;

	private static bool bToRushJump_IsValid;

	private static int bToRushJump_Offset;

	private static FFieldAddress bToRushJump_PropertyAddress;

	private static bool bToF_IsValid;

	private static int bToF_Offset;

	private static FFieldAddress bToF_PropertyAddress;

	private static bool bToL_IsValid;

	private static int bToL_Offset;

	private static FFieldAddress bToL_PropertyAddress;

	private static bool bToR_IsValid;

	private static int bToR_Offset;

	private static FFieldAddress bToR_PropertyAddress;

	private static bool bToBL_IsValid;

	private static int bToBL_Offset;

	private static FFieldAddress bToBL_PropertyAddress;

	private static bool bToBR_IsValid;

	private static int bToBR_Offset;

	private static FFieldAddress bToBR_PropertyAddress;

	private static bool SetupFallAnim_IsValid;

	private static IntPtr SetupFallAnim_FunctionAddress;

	private static int SetupFallAnim_ParamsSize;

	private static bool SetupFallAnim_Context_IsValid;

	private static int SetupFallAnim_Context_Offset;

	private static FFieldAddress SetupFallAnim_Context_PropertyAddress;

	private static bool SetupFallAnim_Node_IsValid;

	private static int SetupFallAnim_Node_Offset;

	private static FFieldAddress SetupFallAnim_Node_PropertyAddress;

	private static bool GetRandomIdleAnim_IsValid;

	private static IntPtr GetRandomIdleAnim_FunctionAddress;

	private static int GetRandomIdleAnim_ParamsSize;

	private static bool GetRandomIdleAnim_Context_IsValid;

	private static int GetRandomIdleAnim_Context_Offset;

	private static FFieldAddress GetRandomIdleAnim_Context_PropertyAddress;

	private static bool GetRandomIdleAnim_Node_IsValid;

	private static int GetRandomIdleAnim_Node_Offset;

	private static FFieldAddress GetRandomIdleAnim_Node_PropertyAddress;

	private static bool SetupLandMoveAnim_IsValid;

	private static IntPtr SetupLandMoveAnim_FunctionAddress;

	private static int SetupLandMoveAnim_ParamsSize;

	private static bool SetupLandMoveAnim_Context_IsValid;

	private static int SetupLandMoveAnim_Context_Offset;

	private static FFieldAddress SetupLandMoveAnim_Context_PropertyAddress;

	private static bool SetupLandMoveAnim_Node_IsValid;

	private static int SetupLandMoveAnim_Node_Offset;

	private static FFieldAddress SetupLandMoveAnim_Node_PropertyAddress;

	private static bool SetupLandStopAnim_IsValid;

	private static IntPtr SetupLandStopAnim_FunctionAddress;

	private static int SetupLandStopAnim_ParamsSize;

	private static bool SetupLandStopAnim_Context_IsValid;

	private static int SetupLandStopAnim_Context_Offset;

	private static FFieldAddress SetupLandStopAnim_Context_PropertyAddress;

	private static bool SetupLandStopAnim_Node_IsValid;

	private static int SetupLandStopAnim_Node_Offset;

	private static FFieldAddress SetupLandStopAnim_Node_PropertyAddress;

	[Category("Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:BSMove")]
	public UBlendSpace BSMove
	{
		get
		{
			CheckDestroyed();
			if (!BSMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:BSMove");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:BSMove");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSMove_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:BSMoveBack")]
	public UBlendSpace BSMoveBack
	{
		get
		{
			CheckDestroyed();
			if (!BSMoveBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:BSMoveBack");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSMoveBack_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSMoveBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:BSMoveBack");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSMoveBack_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:MoveYaw")]
	public float MoveYaw
	{
		get
		{
			CheckDestroyed();
			if (!MoveYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:MoveYaw");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveYaw_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:MoveYaw");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveYaw_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SpeedRate")]
	public float SpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedRate_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASWalkStop")]
	public UAnimSequence ASWalkStop
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASWalkStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASWalkStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartF")]
	public UAnimSequence ASRunStartF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartL")]
	public UAnimSequence ASRunStartL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartL_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartR")]
	public UAnimSequence ASRunStartR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartBL")]
	public UAnimSequence ASRunStartBL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartBL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartBR")]
	public UAnimSequence ASRunStartBR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStartBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartBR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnStop")]
	public UAnimSequence ASRunTurnStop
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnL")]
	public UAnimSequence ASRunTurnL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnL_Offset), value);
			}
		}
	}

	[Category("Move")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnR")]
	public UAnimSequence ASRunTurnR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnBL")]
	public UAnimSequence ASRunTurnBL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnBL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnBR")]
	public UAnimSequence ASRunTurnBR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunTurnBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnBR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStop")]
	public UAnimSequence ASRunStop
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartF")]
	public UAnimSequence ASRushStartF
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartL")]
	public UAnimSequence ASRushStartL
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartL_Offset), value);
			}
		}
	}

	[Category("Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartR")]
	public UAnimSequence ASRushStartR
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartBL")]
	public UAnimSequence ASRushStartBL
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartBL_Offset), value);
			}
		}
	}

	[Category("Move")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartBR")]
	public UAnimSequence ASRushStartBR
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStartBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartBR_Offset), value);
			}
		}
	}

	[Category("Move")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnStop")]
	public UAnimSequence ASRushTurnStop
	{
		get
		{
			CheckDestroyed();
			if (!ASRushTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushTurnStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushTurnStop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnL")]
	public UAnimSequence ASRushTurnL
	{
		get
		{
			CheckDestroyed();
			if (!ASRushTurnL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushTurnL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushTurnL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushTurnL_Offset), value);
			}
		}
	}

	[Category("Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnR")]
	public UAnimSequence ASRushTurnR
	{
		get
		{
			CheckDestroyed();
			if (!ASRushTurnR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushTurnR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushTurnR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushTurnR_Offset), value);
			}
		}
	}

	[Category("Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnBL")]
	public UAnimSequence ASRushTurnBL
	{
		get
		{
			CheckDestroyed();
			if (!ASRushTurnBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushTurnBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushTurnBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushTurnBL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnBR")]
	public UAnimSequence ASRushTurnBR
	{
		get
		{
			CheckDestroyed();
			if (!ASRushTurnBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushTurnBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushTurnBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushTurnBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushTurnBR_Offset), value);
			}
		}
	}

	[Category("Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStop")]
	public UAnimSequence ASRushStop
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunJump")]
	public UAnimSequence ASRunJump
	{
		get
		{
			CheckDestroyed();
			if (!ASRunJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunJump");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunJump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunJump");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunJump_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Move")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushJump")]
	public UAnimSequence ASRushJump
	{
		get
		{
			CheckDestroyed();
			if (!ASRushJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushJump");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushJump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushJump");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushJump_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunJumpSlope")]
	public UAnimSequence ASRunJumpSlope
	{
		get
		{
			CheckDestroyed();
			if (!ASRunJumpSlope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunJumpSlope");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunJumpSlope_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunJumpSlope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRunJumpSlope");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunJumpSlope_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushJumpSlope")]
	public UAnimSequence ASRushJumpSlope
	{
		get
		{
			CheckDestroyed();
			if (!ASRushJumpSlope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushJumpSlope");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushJumpSlope_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushJumpSlope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:ASRushJumpSlope");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushJumpSlope_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bUpdateAnimIdle")]
	public bool bUpdateAnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!bUpdateAnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bUpdateAnimIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUpdateAnimIdle_Offset), 0, bUpdateAnimIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUpdateAnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bUpdateAnimIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUpdateAnimIdle_Offset), 0, bUpdateAnimIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bShouldMove")]
	public bool bShouldMove
	{
		get
		{
			CheckDestroyed();
			if (!bShouldMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bShouldMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShouldMove_Offset), 0, bShouldMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShouldMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bShouldMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShouldMove_Offset), 0, bShouldMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bIdleToStart")]
	public bool bIdleToStart
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bIdleToStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToStart_Offset), 0, bIdleToStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bIdleToStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToStart_Offset), 0, bIdleToStart_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bIdleToLoop")]
	public bool bIdleToLoop
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bIdleToLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToLoop_Offset), 0, bIdleToLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bIdleToLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToLoop_Offset), 0, bIdleToLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bLoopToIdle")]
	public bool bLoopToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bLoopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bLoopToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopToIdle_Offset), 0, bLoopToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bLoopToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoopToIdle_Offset), 0, bLoopToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bMoveBack")]
	public bool bMoveBack
	{
		get
		{
			CheckDestroyed();
			if (!bMoveBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bMoveBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMoveBack_Offset), 0, bMoveBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMoveBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bMoveBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMoveBack_Offset), 0, bMoveBack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bInJump")]
	public bool bInJump
	{
		get
		{
			CheckDestroyed();
			if (!bInJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bInJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bInJump_Offset), 0, bInJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bInJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bInJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bInJump_Offset), 0, bInJump_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bSlopeJump")]
	public bool bSlopeJump
	{
		get
		{
			CheckDestroyed();
			if (!bSlopeJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bSlopeJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSlopeJump_Offset), 0, bSlopeJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSlopeJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bSlopeJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSlopeJump_Offset), 0, bSlopeJump_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToFall")]
	public bool bToFall
	{
		get
		{
			CheckDestroyed();
			if (!bToFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToFall");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToFall_Offset), 0, bToFall_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToFall");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToFall_Offset), 0, bToFall_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToLandAnim")]
	public bool bToLandAnim
	{
		get
		{
			CheckDestroyed();
			if (!bToLandAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToLandAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToLandAnim_Offset), 0, bToLandAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToLandAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToLandAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToLandAnim_Offset), 0, bToLandAnim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToLandMove")]
	public bool bToLandMove
	{
		get
		{
			CheckDestroyed();
			if (!bToLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToLandMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToLandMove_Offset), 0, bToLandMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToLandMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToLandMove_Offset), 0, bToLandMove_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToTurn")]
	public bool bToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToTurn_Offset), 0, bToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToTurn_Offset), 0, bToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToStop")]
	public bool bToStop
	{
		get
		{
			CheckDestroyed();
			if (!bToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToStop_Offset), 0, bToStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToStop_Offset), 0, bToStop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToTurnStop")]
	public bool bToTurnStop
	{
		get
		{
			CheckDestroyed();
			if (!bToTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToTurnStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToTurnStop_Offset), 0, bToTurnStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToTurnStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToTurnStop_Offset), 0, bToTurnStop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToWalk")]
	public bool bToWalk
	{
		get
		{
			CheckDestroyed();
			if (!bToWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToWalk");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToWalk_Offset), 0, bToWalk_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToWalk");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToWalk_Offset), 0, bToWalk_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRun")]
	public bool bToRun
	{
		get
		{
			CheckDestroyed();
			if (!bToRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRun");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToRun_Offset), 0, bToRun_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRun");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToRun_Offset), 0, bToRun_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRush")]
	public bool bToRush
	{
		get
		{
			CheckDestroyed();
			if (!bToRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRush");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToRush_Offset), 0, bToRush_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRush");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToRush_Offset), 0, bToRush_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRunJump")]
	public bool bToRunJump
	{
		get
		{
			CheckDestroyed();
			if (!bToRunJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRunJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToRunJump_Offset), 0, bToRunJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToRunJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRunJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToRunJump_Offset), 0, bToRunJump_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRushJump")]
	public bool bToRushJump
	{
		get
		{
			CheckDestroyed();
			if (!bToRushJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRushJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToRushJump_Offset), 0, bToRushJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToRushJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToRushJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToRushJump_Offset), 0, bToRushJump_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToF")]
	public bool bToF
	{
		get
		{
			CheckDestroyed();
			if (!bToF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToF_Offset), 0, bToF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToF_Offset), 0, bToF_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToL")]
	public bool bToL
	{
		get
		{
			CheckDestroyed();
			if (!bToL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToL_Offset), 0, bToL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToL_Offset), 0, bToL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToR")]
	public bool bToR
	{
		get
		{
			CheckDestroyed();
			if (!bToR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToR_Offset), 0, bToR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToR_Offset), 0, bToR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToBL")]
	public bool bToBL
	{
		get
		{
			CheckDestroyed();
			if (!bToBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToBL_Offset), 0, bToBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToBL_Offset), 0, bToBL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToBR")]
	public bool bToBR
	{
		get
		{
			CheckDestroyed();
			if (!bToBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToBR_Offset), 0, bToBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:bToBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToBR_Offset), 0, bToBR_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null && b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.QuadrupedLocomotion, aBPSettingData))
			{
				BUABPQuadrupedLocomotionSettingData quadrupedLocomotionSetting = aBPSettingData.QuadrupedLocomotionSetting;
				AnimIdleList = quadrupedLocomotionSetting.AnimIdleList;
				BSMove = quadrupedLocomotionSetting.BSMove;
				BSMoveBack = quadrupedLocomotionSetting.BSMoveBack;
				ASWalkStop = quadrupedLocomotionSetting.ASWalkStop;
				ASRunStartF = quadrupedLocomotionSetting.ASRunStartF;
				ASRunStartL = quadrupedLocomotionSetting.ASRunStartL;
				ASRunStartR = quadrupedLocomotionSetting.ASRunStartR;
				ASRunStartBL = quadrupedLocomotionSetting.ASRunStartBL;
				ASRunStartBR = quadrupedLocomotionSetting.ASRunStartBR;
				ASRunTurnStop = quadrupedLocomotionSetting.ASRunTurnStop;
				ASRunTurnL = quadrupedLocomotionSetting.ASRunTurnL;
				ASRunTurnR = quadrupedLocomotionSetting.ASRunTurnR;
				ASRunTurnBL = quadrupedLocomotionSetting.ASRunTurnBL;
				ASRunTurnBR = quadrupedLocomotionSetting.ASRunTurnBR;
				ASRunStop = quadrupedLocomotionSetting.ASRunStop;
				ASRushStartF = quadrupedLocomotionSetting.ASRushStartF;
				ASRushStartL = quadrupedLocomotionSetting.ASRushStartL;
				ASRushStartR = quadrupedLocomotionSetting.ASRushStartR;
				ASRushStartBL = quadrupedLocomotionSetting.ASRushStartBL;
				ASRushStartBR = quadrupedLocomotionSetting.ASRushStartBR;
				ASRushTurnStop = quadrupedLocomotionSetting.ASRushTurnStop;
				ASRushTurnL = quadrupedLocomotionSetting.ASRushTurnL;
				ASRushTurnR = quadrupedLocomotionSetting.ASRushTurnR;
				ASRushTurnBL = quadrupedLocomotionSetting.ASRushTurnBL;
				ASRushTurnBR = quadrupedLocomotionSetting.ASRushTurnBR;
				ASRushStop = quadrupedLocomotionSetting.ASRushStop;
				ASRunJump = quadrupedLocomotionSetting.ASRunJump;
				ASRushJump = quadrupedLocomotionSetting.ASRushJump;
				ASRunJumpSlope = quadrupedLocomotionSetting.ASRunJumpSlope;
				ASRushJumpSlope = quadrupedLocomotionSetting.ASRushJumpSlope;
				ASRunFall = quadrupedLocomotionSetting.ASRunFall;
				ASRushFall = quadrupedLocomotionSetting.ASRushFall;
				ASRunFallSlope = quadrupedLocomotionSetting.ASRunFallSlope;
				ASRushFallSlope = quadrupedLocomotionSetting.ASRushFallSlope;
				ASRunLandMove = quadrupedLocomotionSetting.ASRunLandMove;
				ASRushLandMove = quadrupedLocomotionSetting.ASRushLandMove;
				ASRunLandMoveSlope = quadrupedLocomotionSetting.ASRunLandMoveSlope;
				ASRushLandMoveSlope = quadrupedLocomotionSetting.ASRushLandMoveSlope;
				ASRunLandStop = quadrupedLocomotionSetting.ASRunLandStop;
				ASRushLandStop = quadrupedLocomotionSetting.ASRushLandStop;
				ASRunLandStopSlope = quadrupedLocomotionSetting.ASRunLandStopSlope;
				ASRushLandStopSlope = quadrupedLocomotionSetting.ASRushLandStopSlope;
				InitData();
			}
		}
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter != null)
		{
			if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
			{
				AnimIdleList = TopAnimInst.ABPSettingData.QuadrupedLocomotionSetting.AnimIdleList;
			}
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(aCharacter);
			if (CommonData != null)
			{
				AnimIdleList = CommonData.ExtendAnimIdleList;
			}
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData(DeltaTimeX);
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			QuadrupedLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPQuadrupedLocomotionData, BUC_ABPQuadrupedLocomotionData>(Owner);
			JumpData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (CommonData != null)
		{
			AnimIdleList = CommonData.ExtendAnimIdleList;
		}
	}

	private void UpdateData(float DeltaTime)
	{
		if (CommonData == null || CommonData.FinalABPMoveMode != EABPMoveMode.QuadrupedLocomotion)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bUpdateAnimIdle = false;
		if (CommonData != null && AnimIdleList != CommonData.ExtendAnimIdleList)
		{
			AnimIdleList = CommonData.ExtendAnimIdleList;
			bUpdateAnimIdle = true;
		}
		if (BasicData != null)
		{
			flag3 = BasicData.bHasMoveInput;
		}
		if (ChrData != null)
		{
			flag = ChrData.IsFalling || ChrData.IsFlying;
		}
		if (QuadrupedLocomotionData != null)
		{
			bShouldMove = QuadrupedLocomotionData.GaitGroundedState != EGaitGroundedState.Idle && QuadrupedLocomotionData.GaitGroundedState != EGaitGroundedState.None;
			MoveYaw = QuadrupedLocomotionData.MoveYaw;
			SpeedRate = QuadrupedLocomotionData.SpeedRate;
			bIdleToStart = bShouldMove && QuadrupedLocomotionData.bToStart;
			bIdleToLoop = bShouldMove && !QuadrupedLocomotionData.bToStart;
			bMoveBack = QuadrupedLocomotionData.bMoveBack;
			bToTurn = QuadrupedLocomotionData.bToTurn;
			bToStop = !bShouldMove && QuadrupedLocomotionData.bToStop;
			bLoopToIdle = !bShouldMove && !QuadrupedLocomotionData.bToStop;
			bToTurnStop = bToTurn || (bToStop && QuadrupedLocomotionData.SpeedRateLevel != EMoveSpeedLevel.Walk);
			bToWalk = QuadrupedLocomotionData.SpeedRateLevel == EMoveSpeedLevel.Walk;
			bToRun = QuadrupedLocomotionData.SpeedRateLevel == EMoveSpeedLevel.Run;
			bToRush = QuadrupedLocomotionData.SpeedRateLevel == EMoveSpeedLevel.Sprint;
			bToF = QuadrupedLocomotionData.TurnDirection == EMoveDirectionFive.F;
			bToL = QuadrupedLocomotionData.TurnDirection == EMoveDirectionFive.L;
			bToR = QuadrupedLocomotionData.TurnDirection == EMoveDirectionFive.R;
			bToBL = QuadrupedLocomotionData.TurnDirection == EMoveDirectionFive.BL;
			bToBR = QuadrupedLocomotionData.TurnDirection == EMoveDirectionFive.BR;
			bInJump = QuadrupedLocomotionData.bInJump;
			bSlopeJump = QuadrupedLocomotionData.bSlopeJump;
			bToRunJump = QuadrupedLocomotionData.JumpSpeedRateLevel == EMoveSpeedLevel.Walk || QuadrupedLocomotionData.JumpSpeedRateLevel == EMoveSpeedLevel.Run;
			bToRushJump = QuadrupedLocomotionData.JumpSpeedRateLevel == EMoveSpeedLevel.Sprint;
			flag4 = QuadrupedLocomotionData.bHasRunFallAnim;
			flag5 = QuadrupedLocomotionData.bHasRushFallAnim;
			flag6 = QuadrupedLocomotionData.bHasRunLandAnim;
			flag7 = QuadrupedLocomotionData.bHasRushLandAnim;
		}
		if (JumpData != null)
		{
			flag2 = JumpData.bIsLittleFall;
		}
		bToFall = flag && !flag2;
		bToLandAnim = !flag && !flag3;
		bToLandMove = !flag && flag3;
		if (bToRunJump)
		{
			if (!flag4)
			{
				bToFall = false;
			}
			if (!flag6)
			{
				bToLandAnim = false;
				bToLandMove = false;
			}
		}
		if (bToRushJump)
		{
			if (!flag5)
			{
				bToFall = false;
			}
			if (!flag7)
			{
				bToLandAnim = false;
				bToLandMove = false;
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:GetRandomIdleAnim")]
	private void GetRandomIdleAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		if (AnimIdleList.Count != 0)
		{
			USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
			if (Result)
			{
				int index = FMath.RandRange(0, AnimIdleList.Count - 1);
				USequencePlayerLibrary.SetSequence(SequencePlayer, AnimIdleList[index]);
			}
		}
	}

	[UFunction]
	[Category("Thread Safe")]
	[BlueprintCallable]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupFallAnim")]
	private void SetupFallAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence sequence = ASRunFall;
			if (bToRunJump)
			{
				sequence = (bSlopeJump ? ASRunFallSlope : ASRunFall);
			}
			else if (bToRushJump)
			{
				sequence = (bSlopeJump ? ASRushFallSlope : ASRushFall);
			}
			USequencePlayerLibrary.SetSequence(SequencePlayer, sequence);
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupLandMoveAnim")]
	private void SetupLandMoveAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence sequence = ASRunLandMove;
			if (bToRunJump)
			{
				sequence = (bSlopeJump ? ASRunLandMoveSlope : ASRunLandMove);
			}
			else if (bToRushJump)
			{
				sequence = (bSlopeJump ? ASRushLandMoveSlope : ASRushLandMove);
			}
			USequencePlayerLibrary.SetSequence(SequencePlayer, sequence);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupLandStopAnim")]
	private void SetupLandStopAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence sequence = ASRunLandStop;
			if (bToRunJump)
			{
				sequence = (bSlopeJump ? ASRunLandStopSlope : ASRunLandStop);
			}
			else if (bToRushJump)
			{
				sequence = (bSlopeJump ? ASRushLandStopSlope : ASRushLandStop);
			}
			USequencePlayerLibrary.SetSequence(SequencePlayer, sequence);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupFallAnim")]
	private static void SetupFallAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_QuadrupedLocomotion bUAnimHumanoidCS_QuadrupedLocomotion = GCHelper.Find<BUAnimHumanoidCS_QuadrupedLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupFallAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupFallAnim_Node_Offset));
		bUAnimHumanoidCS_QuadrupedLocomotion.SetupFallAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupFallAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupFallAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:GetRandomIdleAnim")]
	private static void GetRandomIdleAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_QuadrupedLocomotion bUAnimHumanoidCS_QuadrupedLocomotion = GCHelper.Find<BUAnimHumanoidCS_QuadrupedLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, GetRandomIdleAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, GetRandomIdleAnim_Node_Offset));
		bUAnimHumanoidCS_QuadrupedLocomotion.GetRandomIdleAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, GetRandomIdleAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, GetRandomIdleAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupLandMoveAnim")]
	private static void SetupLandMoveAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_QuadrupedLocomotion bUAnimHumanoidCS_QuadrupedLocomotion = GCHelper.Find<BUAnimHumanoidCS_QuadrupedLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupLandMoveAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupLandMoveAnim_Node_Offset));
		bUAnimHumanoidCS_QuadrupedLocomotion.SetupLandMoveAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupLandMoveAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupLandMoveAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupLandStopAnim")]
	private static void SetupLandStopAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_QuadrupedLocomotion bUAnimHumanoidCS_QuadrupedLocomotion = GCHelper.Find<BUAnimHumanoidCS_QuadrupedLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupLandStopAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupLandStopAnim_Node_Offset));
		bUAnimHumanoidCS_QuadrupedLocomotion.SetupLandStopAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupLandStopAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupLandStopAnim_Node_Offset), Node);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion");
		BSMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSMove");
		BSMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSMove", Classes.FObjectProperty);
		BSMoveBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSMoveBack");
		BSMoveBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSMoveBack", Classes.FObjectProperty);
		MoveYaw_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveYaw");
		MoveYaw_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveYaw", Classes.FFloatProperty);
		SpeedRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRate");
		SpeedRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRate", Classes.FFloatProperty);
		ASWalkStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStop");
		ASWalkStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStop", Classes.FObjectProperty);
		ASRunStartF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartF");
		ASRunStartF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartF", Classes.FObjectProperty);
		ASRunStartL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartL");
		ASRunStartL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartL", Classes.FObjectProperty);
		ASRunStartR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartR");
		ASRunStartR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartR", Classes.FObjectProperty);
		ASRunStartBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBL");
		ASRunStartBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBL", Classes.FObjectProperty);
		ASRunStartBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBR");
		ASRunStartBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBR", Classes.FObjectProperty);
		ASRunTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnStop");
		ASRunTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnStop", Classes.FObjectProperty);
		ASRunTurnL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnL");
		ASRunTurnL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnL", Classes.FObjectProperty);
		ASRunTurnR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnR");
		ASRunTurnR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnR", Classes.FObjectProperty);
		ASRunTurnBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBL");
		ASRunTurnBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBL", Classes.FObjectProperty);
		ASRunTurnBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBR");
		ASRunTurnBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBR", Classes.FObjectProperty);
		ASRunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStop");
		ASRunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStop", Classes.FObjectProperty);
		ASRushStartF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartF");
		ASRushStartF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartF", Classes.FObjectProperty);
		ASRushStartL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartL");
		ASRushStartL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartL", Classes.FObjectProperty);
		ASRushStartR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartR");
		ASRushStartR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartR", Classes.FObjectProperty);
		ASRushStartBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartBL");
		ASRushStartBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartBL", Classes.FObjectProperty);
		ASRushStartBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartBR");
		ASRushStartBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartBR", Classes.FObjectProperty);
		ASRushTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnStop");
		ASRushTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnStop", Classes.FObjectProperty);
		ASRushTurnL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnL");
		ASRushTurnL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnL", Classes.FObjectProperty);
		ASRushTurnR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnR");
		ASRushTurnR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnR", Classes.FObjectProperty);
		ASRushTurnBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnBL");
		ASRushTurnBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnBL", Classes.FObjectProperty);
		ASRushTurnBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnBR");
		ASRushTurnBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnBR", Classes.FObjectProperty);
		ASRushStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStop");
		ASRushStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStop", Classes.FObjectProperty);
		ASRunJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunJump");
		ASRunJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunJump", Classes.FObjectProperty);
		ASRushJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushJump");
		ASRushJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushJump", Classes.FObjectProperty);
		ASRunJumpSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunJumpSlope");
		ASRunJumpSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunJumpSlope", Classes.FObjectProperty);
		ASRushJumpSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushJumpSlope");
		ASRushJumpSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushJumpSlope", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bUpdateAnimIdle_PropertyAddress, intPtr, "bUpdateAnimIdle");
		bUpdateAnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUpdateAnimIdle");
		bUpdateAnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUpdateAnimIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShouldMove_PropertyAddress, intPtr, "bShouldMove");
		bShouldMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShouldMove");
		bShouldMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShouldMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToStart_PropertyAddress, intPtr, "bIdleToStart");
		bIdleToStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIdleToStart");
		bIdleToStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIdleToStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToLoop_PropertyAddress, intPtr, "bIdleToLoop");
		bIdleToLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIdleToLoop");
		bIdleToLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIdleToLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLoopToIdle_PropertyAddress, intPtr, "bLoopToIdle");
		bLoopToIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoopToIdle");
		bLoopToIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoopToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMoveBack_PropertyAddress, intPtr, "bMoveBack");
		bMoveBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMoveBack");
		bMoveBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMoveBack", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bInJump_PropertyAddress, intPtr, "bInJump");
		bInJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInJump");
		bInJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSlopeJump_PropertyAddress, intPtr, "bSlopeJump");
		bSlopeJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSlopeJump");
		bSlopeJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSlopeJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToFall_PropertyAddress, intPtr, "bToFall");
		bToFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToFall");
		bToFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToFall", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToLandAnim_PropertyAddress, intPtr, "bToLandAnim");
		bToLandAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToLandAnim");
		bToLandAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToLandAnim", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToLandMove_PropertyAddress, intPtr, "bToLandMove");
		bToLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToLandMove");
		bToLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToLandMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToTurn_PropertyAddress, intPtr, "bToTurn");
		bToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToTurn");
		bToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToStop_PropertyAddress, intPtr, "bToStop");
		bToStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToStop");
		bToStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToTurnStop_PropertyAddress, intPtr, "bToTurnStop");
		bToTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToTurnStop");
		bToTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToTurnStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToWalk_PropertyAddress, intPtr, "bToWalk");
		bToWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToWalk");
		bToWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToWalk", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToRun_PropertyAddress, intPtr, "bToRun");
		bToRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToRun");
		bToRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToRun", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToRush_PropertyAddress, intPtr, "bToRush");
		bToRush_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToRush");
		bToRush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToRush", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToRunJump_PropertyAddress, intPtr, "bToRunJump");
		bToRunJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToRunJump");
		bToRunJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToRunJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToRushJump_PropertyAddress, intPtr, "bToRushJump");
		bToRushJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToRushJump");
		bToRushJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToRushJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToF_PropertyAddress, intPtr, "bToF");
		bToF_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToF");
		bToF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToF", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToL_PropertyAddress, intPtr, "bToL");
		bToL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToL");
		bToL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToR_PropertyAddress, intPtr, "bToR");
		bToR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToR");
		bToR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToBL_PropertyAddress, intPtr, "bToBL");
		bToBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToBL");
		bToBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToBR_PropertyAddress, intPtr, "bToBR");
		bToBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToBR");
		bToBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToBR", Classes.FBoolProperty);
		SetupFallAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupFallAnim");
		SetupFallAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupFallAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupFallAnim_Context_PropertyAddress, SetupFallAnim_FunctionAddress, "Context");
		SetupFallAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupFallAnim_FunctionAddress, "Context");
		SetupFallAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupFallAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupFallAnim_Node_PropertyAddress, SetupFallAnim_FunctionAddress, "Node");
		SetupFallAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupFallAnim_FunctionAddress, "Node");
		SetupFallAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupFallAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupFallAnim_IsValid = SetupFallAnim_FunctionAddress != IntPtr.Zero && SetupFallAnim_Context_IsValid && SetupFallAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupFallAnim", SetupFallAnim_IsValid);
		GetRandomIdleAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRandomIdleAnim");
		GetRandomIdleAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomIdleAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetRandomIdleAnim_Context_PropertyAddress, GetRandomIdleAnim_FunctionAddress, "Context");
		GetRandomIdleAnim_Context_Offset = NativeReflection.GetPropertyOffset(GetRandomIdleAnim_FunctionAddress, "Context");
		GetRandomIdleAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(GetRandomIdleAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetRandomIdleAnim_Node_PropertyAddress, GetRandomIdleAnim_FunctionAddress, "Node");
		GetRandomIdleAnim_Node_Offset = NativeReflection.GetPropertyOffset(GetRandomIdleAnim_FunctionAddress, "Node");
		GetRandomIdleAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(GetRandomIdleAnim_FunctionAddress, "Node", Classes.FStructProperty);
		GetRandomIdleAnim_IsValid = GetRandomIdleAnim_FunctionAddress != IntPtr.Zero && GetRandomIdleAnim_Context_IsValid && GetRandomIdleAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:GetRandomIdleAnim", GetRandomIdleAnim_IsValid);
		SetupLandMoveAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupLandMoveAnim");
		SetupLandMoveAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupLandMoveAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupLandMoveAnim_Context_PropertyAddress, SetupLandMoveAnim_FunctionAddress, "Context");
		SetupLandMoveAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupLandMoveAnim_FunctionAddress, "Context");
		SetupLandMoveAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupLandMoveAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupLandMoveAnim_Node_PropertyAddress, SetupLandMoveAnim_FunctionAddress, "Node");
		SetupLandMoveAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupLandMoveAnim_FunctionAddress, "Node");
		SetupLandMoveAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupLandMoveAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupLandMoveAnim_IsValid = SetupLandMoveAnim_FunctionAddress != IntPtr.Zero && SetupLandMoveAnim_Context_IsValid && SetupLandMoveAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupLandMoveAnim", SetupLandMoveAnim_IsValid);
		SetupLandStopAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupLandStopAnim");
		SetupLandStopAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupLandStopAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupLandStopAnim_Context_PropertyAddress, SetupLandStopAnim_FunctionAddress, "Context");
		SetupLandStopAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupLandStopAnim_FunctionAddress, "Context");
		SetupLandStopAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupLandStopAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupLandStopAnim_Node_PropertyAddress, SetupLandStopAnim_FunctionAddress, "Node");
		SetupLandStopAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupLandStopAnim_FunctionAddress, "Node");
		SetupLandStopAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupLandStopAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupLandStopAnim_IsValid = SetupLandStopAnim_FunctionAddress != IntPtr.Zero && SetupLandStopAnim_Context_IsValid && SetupLandStopAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedLocomotion:SetupLandStopAnim", SetupLandStopAnim_IsValid);
	}

	static BUAnimHumanoidCS_QuadrupedLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_QuadrupedLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_QuadrupedLocomotion));
	}
}
