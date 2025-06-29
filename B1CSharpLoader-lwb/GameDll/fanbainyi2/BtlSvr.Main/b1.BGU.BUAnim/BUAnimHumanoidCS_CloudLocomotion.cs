using System;
using System.Collections.Generic;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion")]
public class BUAnimHumanoidCS_CloudLocomotion : BUAnimHumanoidCS_LinkedInstanceBase
{
	private List<UAnimSequence> AnimIdleList = new List<UAnimSequence>();

	private IBUC_ABPCharacterData ChrData;

	private BUC_ABPCloudLocomotionData CloudLocomotionData;

	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPBasicData BasicData;

	private BUC_MovementData MovementData;

	private static bool LeanPitchAdditvie_Up_IsValid;

	private static int LeanPitchAdditvie_Up_Offset;

	private static bool LeanPitchAdditvie_Down_IsValid;

	private static int LeanPitchAdditvie_Down_Offset;

	private static bool StartFwd_IsValid;

	private static int StartFwd_Offset;

	private static bool StartFwdL_IsValid;

	private static int StartFwdL_Offset;

	private static bool StartFwdR_IsValid;

	private static int StartFwdR_Offset;

	private static bool StartBwdL_IsValid;

	private static int StartBwdL_Offset;

	private static bool StartBwdR_IsValid;

	private static int StartBwdR_Offset;

	private static bool RunLoop_IsValid;

	private static int RunLoop_Offset;

	private static bool RushLoop_IsValid;

	private static int RushLoop_Offset;

	private static bool RunLoopAdditvie_Left_IsValid;

	private static int RunLoopAdditvie_Left_Offset;

	private static bool RunLoopAdditvie_Right_IsValid;

	private static int RunLoopAdditvie_Right_Offset;

	private static bool RushLoopAdditvie_Left_IsValid;

	private static int RushLoopAdditvie_Left_Offset;

	private static bool RushLoopAdditvie_Right_IsValid;

	private static int RushLoopAdditvie_Right_Offset;

	private static bool RunStop_IsValid;

	private static int RunStop_Offset;

	private static bool RushStop_IsValid;

	private static int RushStop_Offset;

	private static bool bUpdateAnimIdle_IsValid;

	private static int bUpdateAnimIdle_Offset;

	private static FFieldAddress bUpdateAnimIdle_PropertyAddress;

	private static bool InputVelocityAngle_IsValid;

	private static int InputVelocityAngle_Offset;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	private static bool MoveAcceleration_IsValid;

	private static int MoveAcceleration_Offset;

	private static bool MappedSpeed_IsValid;

	private static int MappedSpeed_Offset;

	private static bool GaitGroundedState_IsValid;

	private static int GaitGroundedState_Offset;

	private static FFieldAddress GaitGroundedState_PropertyAddress;

	private static bool StartAngle_IsValid;

	private static int StartAngle_Offset;

	private static bool RotationSpeed_IsValid;

	private static int RotationSpeed_Offset;

	private static bool MaxAcceleration_IsValid;

	private static int MaxAcceleration_Offset;

	private static bool InputMoveDir_IsValid;

	private static int InputMoveDir_Offset;

	private static bool FinalMoveDir_IsValid;

	private static int FinalMoveDir_Offset;

	private static bool SetupIdleAnim_IsValid;

	private static IntPtr SetupIdleAnim_FunctionAddress;

	private static int SetupIdleAnim_ParamsSize;

	private static bool SetupIdleAnim_Context_IsValid;

	private static int SetupIdleAnim_Context_Offset;

	private static FFieldAddress SetupIdleAnim_Context_PropertyAddress;

	private static bool SetupIdleAnim_Node_IsValid;

	private static int SetupIdleAnim_Node_Offset;

	private static FFieldAddress SetupIdleAnim_Node_PropertyAddress;

	[Category("CloudLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:LeanPitchAdditvie_Up")]
	public UAnimSequence LeanPitchAdditvie_Up
	{
		get
		{
			CheckDestroyed();
			if (!LeanPitchAdditvie_Up_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:LeanPitchAdditvie_Up");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, LeanPitchAdditvie_Up_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeanPitchAdditvie_Up_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:LeanPitchAdditvie_Up");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, LeanPitchAdditvie_Up_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:LeanPitchAdditvie_Down")]
	public UAnimSequence LeanPitchAdditvie_Down
	{
		get
		{
			CheckDestroyed();
			if (!LeanPitchAdditvie_Down_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:LeanPitchAdditvie_Down");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, LeanPitchAdditvie_Down_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeanPitchAdditvie_Down_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:LeanPitchAdditvie_Down");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, LeanPitchAdditvie_Down_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("CloudLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwd")]
	public UAnimSequence StartFwd
	{
		get
		{
			CheckDestroyed();
			if (!StartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, StartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, StartFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwdL")]
	public UAnimSequence StartFwdL
	{
		get
		{
			CheckDestroyed();
			if (!StartFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, StartFwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, StartFwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwdR")]
	public UAnimSequence StartFwdR
	{
		get
		{
			CheckDestroyed();
			if (!StartFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, StartFwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartFwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, StartFwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartBwdL")]
	public UAnimSequence StartBwdL
	{
		get
		{
			CheckDestroyed();
			if (!StartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, StartBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, StartBwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartBwdR")]
	public UAnimSequence StartBwdR
	{
		get
		{
			CheckDestroyed();
			if (!StartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, StartBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, StartBwdR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoop")]
	public UAnimSequence RunLoop
	{
		get
		{
			CheckDestroyed();
			if (!RunLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RunLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RunLoop_Offset), value);
			}
		}
	}

	[Category("CloudLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoop")]
	public UAnimSequence RushLoop
	{
		get
		{
			CheckDestroyed();
			if (!RushLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RushLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RushLoop_Offset), value);
			}
		}
	}

	[Category("CloudLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoopAdditvie_Left")]
	public UAnimSequence RunLoopAdditvie_Left
	{
		get
		{
			CheckDestroyed();
			if (!RunLoopAdditvie_Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoopAdditvie_Left");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RunLoopAdditvie_Left_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunLoopAdditvie_Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoopAdditvie_Left");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RunLoopAdditvie_Left_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoopAdditvie_Right")]
	public UAnimSequence RunLoopAdditvie_Right
	{
		get
		{
			CheckDestroyed();
			if (!RunLoopAdditvie_Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoopAdditvie_Right");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RunLoopAdditvie_Right_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunLoopAdditvie_Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunLoopAdditvie_Right");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RunLoopAdditvie_Right_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("CloudLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoopAdditvie_Left")]
	public UAnimSequence RushLoopAdditvie_Left
	{
		get
		{
			CheckDestroyed();
			if (!RushLoopAdditvie_Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoopAdditvie_Left");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RushLoopAdditvie_Left_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushLoopAdditvie_Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoopAdditvie_Left");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RushLoopAdditvie_Left_Offset), value);
			}
		}
	}

	[Category("CloudLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoopAdditvie_Right")]
	public UAnimSequence RushLoopAdditvie_Right
	{
		get
		{
			CheckDestroyed();
			if (!RushLoopAdditvie_Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoopAdditvie_Right");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RushLoopAdditvie_Right_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushLoopAdditvie_Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushLoopAdditvie_Right");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RushLoopAdditvie_Right_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunStop")]
	public UAnimSequence RunStop
	{
		get
		{
			CheckDestroyed();
			if (!RunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RunStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RunStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RunStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("CloudLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushStop")]
	public UAnimSequence RushStop
	{
		get
		{
			CheckDestroyed();
			if (!RushStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, RushStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RushStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, RushStop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:bUpdateAnimIdle")]
	public bool bUpdateAnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!bUpdateAnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:bUpdateAnimIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUpdateAnimIdle_Offset), 0, bUpdateAnimIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUpdateAnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:bUpdateAnimIdle");
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
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:InputVelocityAngle")]
	public float InputVelocityAngle
	{
		get
		{
			CheckDestroyed();
			if (!InputVelocityAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:InputVelocityAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputVelocityAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputVelocityAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:InputVelocityAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputVelocityAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:Velocity")]
	public FVector Velocity
	{
		get
		{
			CheckDestroyed();
			if (!Velocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:Velocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Velocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Velocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:Velocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Velocity_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MoveAcceleration")]
	public FVector MoveAcceleration
	{
		get
		{
			CheckDestroyed();
			if (!MoveAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MoveAcceleration");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MoveAcceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MoveAcceleration");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MoveAcceleration_Offset), value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MappedSpeed")]
	public float MappedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MappedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MappedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MappedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MappedSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:GaitGroundedState")]
	public EGaitGroundedState GaitGroundedState
	{
		get
		{
			CheckDestroyed();
			if (!GaitGroundedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:GaitGroundedState");
				return EGaitGroundedState.None;
			}
			return EnumMarshaler<EGaitGroundedState>.FromNative(IntPtr.Add(base.Address, GaitGroundedState_Offset), 0, GaitGroundedState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GaitGroundedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:GaitGroundedState");
			}
			else
			{
				EnumMarshaler<EGaitGroundedState>.ToNative(IntPtr.Add(base.Address, GaitGroundedState_Offset), 0, GaitGroundedState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartAngle")]
	public float StartAngle
	{
		get
		{
			CheckDestroyed();
			if (!StartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:StartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartAngle_Offset), value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RotationSpeed")]
	public float RotationSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RotationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RotationSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotationSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:RotationSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotationSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MaxAcceleration")]
	public float MaxAcceleration
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MaxAcceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:MaxAcceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceleration_Offset), value);
			}
		}
	}

	[Category("Movement")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:InputMoveDir")]
	public FVector InputMoveDir
	{
		get
		{
			CheckDestroyed();
			if (!InputMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:InputMoveDir");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, InputMoveDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:InputMoveDir");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, InputMoveDir_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Movement")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:FinalMoveDir")]
	public FVector FinalMoveDir
	{
		get
		{
			CheckDestroyed();
			if (!FinalMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:FinalMoveDir");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, FinalMoveDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:FinalMoveDir");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, FinalMoveDir_Offset), value);
			}
		}
	}

	protected override bool ShouldSkipBlueprintUpdateAnimation()
	{
		return false;
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null && b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.CloudLocomotion, aBPSettingData))
			{
				BUABPCloudLocomotionSettingData cloudLocomotionSetting = aBPSettingData.CloudLocomotionSetting;
				AnimIdleList = cloudLocomotionSetting.AnimIdleList;
				LeanPitchAdditvie_Up = cloudLocomotionSetting.LeanPitchAdditvie_Up;
				LeanPitchAdditvie_Down = cloudLocomotionSetting.LeanPitchAdditvie_Down;
				StartFwd = cloudLocomotionSetting.StartFwd;
				StartFwdL = cloudLocomotionSetting.StartFwdL;
				StartFwdR = cloudLocomotionSetting.StartFwdR;
				StartBwdL = cloudLocomotionSetting.StartBwdL;
				StartBwdR = cloudLocomotionSetting.StartBwdR;
				RunLoop = cloudLocomotionSetting.RunLoop;
				RushLoop = cloudLocomotionSetting.RushLoop;
				RunLoopAdditvie_Left = cloudLocomotionSetting.RunLoopAdditvie_Left;
				RunLoopAdditvie_Right = cloudLocomotionSetting.RunLoopAdditvie_Right;
				RushLoopAdditvie_Left = cloudLocomotionSetting.RushLoopAdditvie_Left;
				RushLoopAdditvie_Right = cloudLocomotionSetting.RushLoopAdditvie_Right;
				RunStop = cloudLocomotionSetting.RunStop;
				RushStop = cloudLocomotionSetting.RushStop;
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
				AnimIdleList = TopAnimInst.ABPSettingData.CloudLocomotionSetting.AnimIdleList;
			}
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(aCharacter);
			if (CommonData != null)
			{
				AnimIdleList = CommonData.ExtendAnimIdleList;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_CacheCloudLocomotionAnimInst.Invoke(this);
			}
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData(DeltaTimeX);
	}

	private void InitData()
	{
		InitBUCData();
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			CloudLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCloudLocomotionData, BUC_ABPCloudLocomotionData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			MovementData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementData, BUC_MovementData>(Owner);
		}
	}

	private void UpdateData(float DeltaTime)
	{
		if (CommonData == null || CommonData.FinalABPMoveMode != EABPMoveMode.CloudLocomotion)
		{
			return;
		}
		bUpdateAnimIdle = false;
		if (BasicData != null)
		{
			MappedSpeed = BasicData.GetMappedSpeed3D();
		}
		if (CommonData != null && AnimIdleList != CommonData.ExtendAnimIdleList)
		{
			AnimIdleList = CommonData.ExtendAnimIdleList;
			bUpdateAnimIdle = true;
		}
		if (ChrData != null)
		{
			Velocity = ChrData.Velocity;
			MoveAcceleration = ChrData.MoveAcceleration;
		}
		else
		{
			FVector velocity = (MoveAcceleration = FVector.ZeroVector);
			Velocity = velocity;
		}
		if (MovementData != null)
		{
			InputMoveDir = MovementData.InputCloudMoveDir;
			if (FinalMoveDir != FVector.ZeroVector)
			{
				MovementData.FinalCloudMoveDir = FinalMoveDir;
				FinalMoveDir = FVector.ZeroVector;
			}
		}
		if (CloudLocomotionData != null)
		{
			InputVelocityAngle = CloudLocomotionData.InputVelocityAngle;
			GaitGroundedState = CloudLocomotionData.GaitGroundedState;
			StartAngle = CloudLocomotionData.StartAngle;
			CloudLocomotionData.RotationSpeed = RotationSpeed;
			CloudLocomotionData.MaxAcceleration = MaxAcceleration;
		}
		else
		{
			InputVelocityAngle = 0f;
			GaitGroundedState = EGaitGroundedState.None;
			StartAngle = 0f;
			CloudLocomotionData.RotationSpeed = 0f;
			CloudLocomotionData.MaxAcceleration = 0f;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:SetupIdleAnim")]
	private void SetupIdleAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
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

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:SetupIdleAnim")]
	private static void SetupIdleAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_CloudLocomotion bUAnimHumanoidCS_CloudLocomotion = GCHelper.Find<BUAnimHumanoidCS_CloudLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupIdleAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupIdleAnim_Node_Offset));
		bUAnimHumanoidCS_CloudLocomotion.SetupIdleAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupIdleAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupIdleAnim_Node_Offset), Node);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion");
		LeanPitchAdditvie_Up_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeanPitchAdditvie_Up");
		LeanPitchAdditvie_Up_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeanPitchAdditvie_Up", Classes.FObjectProperty);
		LeanPitchAdditvie_Down_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeanPitchAdditvie_Down");
		LeanPitchAdditvie_Down_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeanPitchAdditvie_Down", Classes.FObjectProperty);
		StartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartFwd");
		StartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartFwd", Classes.FObjectProperty);
		StartFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartFwdL");
		StartFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartFwdL", Classes.FObjectProperty);
		StartFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartFwdR");
		StartFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartFwdR", Classes.FObjectProperty);
		StartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartBwdL");
		StartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartBwdL", Classes.FObjectProperty);
		StartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartBwdR");
		StartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartBwdR", Classes.FObjectProperty);
		RunLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunLoop");
		RunLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunLoop", Classes.FObjectProperty);
		RushLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushLoop");
		RushLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushLoop", Classes.FObjectProperty);
		RunLoopAdditvie_Left_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunLoopAdditvie_Left");
		RunLoopAdditvie_Left_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunLoopAdditvie_Left", Classes.FObjectProperty);
		RunLoopAdditvie_Right_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunLoopAdditvie_Right");
		RunLoopAdditvie_Right_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunLoopAdditvie_Right", Classes.FObjectProperty);
		RushLoopAdditvie_Left_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushLoopAdditvie_Left");
		RushLoopAdditvie_Left_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushLoopAdditvie_Left", Classes.FObjectProperty);
		RushLoopAdditvie_Right_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushLoopAdditvie_Right");
		RushLoopAdditvie_Right_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushLoopAdditvie_Right", Classes.FObjectProperty);
		RunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunStop");
		RunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunStop", Classes.FObjectProperty);
		RushStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushStop");
		RushStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushStop", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bUpdateAnimIdle_PropertyAddress, intPtr, "bUpdateAnimIdle");
		bUpdateAnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUpdateAnimIdle");
		bUpdateAnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUpdateAnimIdle", Classes.FBoolProperty);
		InputVelocityAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputVelocityAngle");
		InputVelocityAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputVelocityAngle", Classes.FFloatProperty);
		Velocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		MoveAcceleration_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAcceleration");
		MoveAcceleration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAcceleration", Classes.FStructProperty);
		MappedSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappedSpeed");
		MappedSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappedSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref GaitGroundedState_PropertyAddress, intPtr, "GaitGroundedState");
		GaitGroundedState_Offset = NativeReflection.GetPropertyOffset(intPtr, "GaitGroundedState");
		GaitGroundedState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GaitGroundedState", Classes.FEnumProperty);
		StartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartAngle");
		StartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartAngle", Classes.FFloatProperty);
		RotationSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationSpeed");
		RotationSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationSpeed", Classes.FFloatProperty);
		MaxAcceleration_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxAcceleration");
		MaxAcceleration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxAcceleration", Classes.FFloatProperty);
		InputMoveDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputMoveDir");
		InputMoveDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputMoveDir", Classes.FStructProperty);
		FinalMoveDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "FinalMoveDir");
		FinalMoveDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FinalMoveDir", Classes.FStructProperty);
		SetupIdleAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupIdleAnim");
		SetupIdleAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupIdleAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupIdleAnim_Context_PropertyAddress, SetupIdleAnim_FunctionAddress, "Context");
		SetupIdleAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupIdleAnim_FunctionAddress, "Context");
		SetupIdleAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupIdleAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupIdleAnim_Node_PropertyAddress, SetupIdleAnim_FunctionAddress, "Node");
		SetupIdleAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupIdleAnim_FunctionAddress, "Node");
		SetupIdleAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupIdleAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupIdleAnim_IsValid = SetupIdleAnim_FunctionAddress != IntPtr.Zero && SetupIdleAnim_Context_IsValid && SetupIdleAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_CloudLocomotion:SetupIdleAnim", SetupIdleAnim_IsValid);
	}

	static BUAnimHumanoidCS_CloudLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_CloudLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_CloudLocomotion));
	}
}
