using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig")]
public class BGWDataAsset_ManualSplineMoveAnimConfig : UBGWDataAsset
{
	private static bool BeginMoveDBC_IsValid;

	private static int BeginMoveDBC_Offset;

	private static bool EndMoveDBC_IsValid;

	private static int EndMoveDBC_Offset;

	private static bool MovingDBC_IsValid;

	private static int MovingDBC_Offset;

	private static bool CameraType_IsValid;

	private static int CameraType_Offset;

	private static FFieldAddress CameraType_PropertyAddress;

	private static bool RotationBlendTime_IsValid;

	private static int RotationBlendTime_Offset;

	private static bool DirectionType_IsValid;

	private static int DirectionType_Offset;

	private static FFieldAddress DirectionType_PropertyAddress;

	private static bool LockDirectionDeltaAngle_IsValid;

	private static int LockDirectionDeltaAngle_Offset;

	private static bool MaxWalkSpeed_IsValid;

	private static int MaxWalkSpeed_Offset;

	private static bool MaxAcceleration_IsValid;

	private static int MaxAcceleration_Offset;

	private static bool AMBeginMove_IsValid;

	private static int AMBeginMove_Offset;

	private static bool AMEndMoveForward_IsValid;

	private static int AMEndMoveForward_Offset;

	private static bool AMEndMoveBackward_IsValid;

	private static int AMEndMoveBackward_Offset;

	private static bool ASIdleForward_IsValid;

	private static int ASIdleForward_Offset;

	private static bool ASIdleBackward_IsValid;

	private static int ASIdleBackward_Offset;

	private static bool ASStartForward_IsValid;

	private static int ASStartForward_Offset;

	private static bool ASStartBackward_IsValid;

	private static int ASStartBackward_Offset;

	private static bool ASLoopForward_IsValid;

	private static int ASLoopForward_Offset;

	private static bool ASLoopBackward_IsValid;

	private static int ASLoopBackward_Offset;

	private static bool ASStopForward_IsValid;

	private static int ASStopForward_Offset;

	private static bool ASStopBackward_IsValid;

	private static int ASStopBackward_Offset;

	private static bool ASTurnF2B_IsValid;

	private static int ASTurnF2B_Offset;

	private static bool ASTurnB2F_IsValid;

	private static int ASTurnB2F_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[Category("Disp Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:BeginMoveDBC")]
	public BGWDataAsset_B1DBC BeginMoveDBC
	{
		get
		{
			CheckDestroyed();
			if (!BeginMoveDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:BeginMoveDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, BeginMoveDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginMoveDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:BeginMoveDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, BeginMoveDBC_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Disp Config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:EndMoveDBC")]
	public BGWDataAsset_B1DBC EndMoveDBC
	{
		get
		{
			CheckDestroyed();
			if (!EndMoveDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:EndMoveDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, EndMoveDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndMoveDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:EndMoveDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, EndMoveDBC_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Disp Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MovingDBC")]
	public BGWDataAsset_B1DBC MovingDBC
	{
		get
		{
			CheckDestroyed();
			if (!MovingDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MovingDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, MovingDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovingDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MovingDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, MovingDBC_Offset), value);
			}
		}
	}

	[Category("Camera Config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:CameraType")]
	public EManualSplineMoveCameraType CameraType
	{
		get
		{
			CheckDestroyed();
			if (!CameraType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:CameraType");
				return EManualSplineMoveCameraType.None;
			}
			return EnumMarshaler<EManualSplineMoveCameraType>.FromNative(IntPtr.Add(base.Address, CameraType_Offset), 0, CameraType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:CameraType");
			}
			else
			{
				EnumMarshaler<EManualSplineMoveCameraType>.ToNative(IntPtr.Add(base.Address, CameraType_Offset), 0, CameraType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Move Anim Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:RotationBlendTime")]
	public float RotationBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!RotationBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:RotationBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotationBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:RotationBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotationBlendTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:DirectionType")]
	public EManualSplineMoveDirectionType DirectionType
	{
		get
		{
			CheckDestroyed();
			if (!DirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:DirectionType");
				return EManualSplineMoveDirectionType.Free;
			}
			return EnumMarshaler<EManualSplineMoveDirectionType>.FromNative(IntPtr.Add(base.Address, DirectionType_Offset), 0, DirectionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:DirectionType");
			}
			else
			{
				EnumMarshaler<EManualSplineMoveDirectionType>.ToNative(IntPtr.Add(base.Address, DirectionType_Offset), 0, DirectionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[UMeta(MDProp.EditCondition, "DirectionType == ManualSplineMoveDirectionType::Lock")]
	[Tooltip("Delta angle between actor forward direction and spline direction when lock moving")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:LockDirectionDeltaAngle")]
	public float LockDirectionDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!LockDirectionDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:LockDirectionDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockDirectionDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockDirectionDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:LockDirectionDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockDirectionDeltaAngle_Offset), value);
			}
		}
	}

	[Category("Move Anim Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MaxWalkSpeed")]
	public float MaxWalkSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxWalkSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MaxWalkSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxWalkSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxWalkSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MaxWalkSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxWalkSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MaxAcceleration")]
	public float MaxAcceleration
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MaxAcceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:MaxAcceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceleration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Move Anim Config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMBeginMove")]
	public UAnimMontage AMBeginMove
	{
		get
		{
			CheckDestroyed();
			if (!AMBeginMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMBeginMove");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMBeginMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMBeginMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMBeginMove");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMBeginMove_Offset), value);
			}
		}
	}

	[Category("Move Anim Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMEndMoveForward")]
	public UAnimMontage AMEndMoveForward
	{
		get
		{
			CheckDestroyed();
			if (!AMEndMoveForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMEndMoveForward");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMEndMoveForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMEndMoveForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMEndMoveForward");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMEndMoveForward_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMEndMoveBackward")]
	public UAnimMontage AMEndMoveBackward
	{
		get
		{
			CheckDestroyed();
			if (!AMEndMoveBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMEndMoveBackward");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMEndMoveBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMEndMoveBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:AMEndMoveBackward");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMEndMoveBackward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASIdleForward")]
	public UAnimSequence ASIdleForward
	{
		get
		{
			CheckDestroyed();
			if (!ASIdleForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASIdleForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASIdleForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASIdleForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASIdleForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASIdleForward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASIdleBackward")]
	public UAnimSequence ASIdleBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASIdleBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASIdleBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASIdleBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASIdleBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASIdleBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASIdleBackward_Offset), value);
			}
		}
	}

	[Category("Move Anim Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStartForward")]
	public UAnimSequence ASStartForward
	{
		get
		{
			CheckDestroyed();
			if (!ASStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStartForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStartForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStartForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStartForward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStartBackward")]
	public UAnimSequence ASStartBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASStartBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStartBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStartBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStartBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStartBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStartBackward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASLoopForward")]
	public UAnimSequence ASLoopForward
	{
		get
		{
			CheckDestroyed();
			if (!ASLoopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASLoopForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLoopForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLoopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASLoopForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLoopForward_Offset), value);
			}
		}
	}

	[Category("Move Anim Config")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASLoopBackward")]
	public UAnimSequence ASLoopBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASLoopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASLoopBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLoopBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLoopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASLoopBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLoopBackward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStopForward")]
	public UAnimSequence ASStopForward
	{
		get
		{
			CheckDestroyed();
			if (!ASStopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStopForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStopForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStopForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStopForward_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStopBackward")]
	public UAnimSequence ASStopBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASStopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStopBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStopBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASStopBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStopBackward_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASTurnF2B")]
	public UAnimSequence ASTurnF2B
	{
		get
		{
			CheckDestroyed();
			if (!ASTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASTurnF2B");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASTurnF2B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASTurnF2B");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASTurnF2B_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Move Anim Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASTurnB2F")]
	public UAnimSequence ASTurnB2F
	{
		get
		{
			CheckDestroyed();
			if (!ASTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASTurnB2F");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASTurnB2F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig:ASTurnB2F");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASTurnB2F_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ManualSplineMoveAnimConfig");
		BeginMoveDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginMoveDBC");
		BeginMoveDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginMoveDBC", Classes.FObjectProperty);
		EndMoveDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndMoveDBC");
		EndMoveDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndMoveDBC", Classes.FObjectProperty);
		MovingDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MovingDBC");
		MovingDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MovingDBC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CameraType_PropertyAddress, unrealStruct, "CameraType");
		CameraType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraType");
		CameraType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraType", Classes.FEnumProperty);
		RotationBlendTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotationBlendTime");
		RotationBlendTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotationBlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DirectionType_PropertyAddress, unrealStruct, "DirectionType");
		DirectionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionType");
		DirectionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionType", Classes.FEnumProperty);
		LockDirectionDeltaAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockDirectionDeltaAngle");
		LockDirectionDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockDirectionDeltaAngle", Classes.FFloatProperty);
		MaxWalkSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxWalkSpeed");
		MaxWalkSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxWalkSpeed", Classes.FFloatProperty);
		MaxAcceleration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxAcceleration");
		MaxAcceleration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxAcceleration", Classes.FFloatProperty);
		AMBeginMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMBeginMove");
		AMBeginMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMBeginMove", Classes.FObjectProperty);
		AMEndMoveForward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMEndMoveForward");
		AMEndMoveForward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMEndMoveForward", Classes.FObjectProperty);
		AMEndMoveBackward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMEndMoveBackward");
		AMEndMoveBackward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMEndMoveBackward", Classes.FObjectProperty);
		ASIdleForward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASIdleForward");
		ASIdleForward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASIdleForward", Classes.FObjectProperty);
		ASIdleBackward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASIdleBackward");
		ASIdleBackward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASIdleBackward", Classes.FObjectProperty);
		ASStartForward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASStartForward");
		ASStartForward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASStartForward", Classes.FObjectProperty);
		ASStartBackward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASStartBackward");
		ASStartBackward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASStartBackward", Classes.FObjectProperty);
		ASLoopForward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLoopForward");
		ASLoopForward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLoopForward", Classes.FObjectProperty);
		ASLoopBackward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLoopBackward");
		ASLoopBackward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLoopBackward", Classes.FObjectProperty);
		ASStopForward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASStopForward");
		ASStopForward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASStopForward", Classes.FObjectProperty);
		ASStopBackward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASStopBackward");
		ASStopBackward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASStopBackward", Classes.FObjectProperty);
		ASTurnF2B_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASTurnF2B");
		ASTurnF2B_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASTurnF2B", Classes.FObjectProperty);
		ASTurnB2F_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASTurnB2F");
		ASTurnB2F_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASTurnB2F", Classes.FObjectProperty);
	}

	static BGWDataAsset_ManualSplineMoveAnimConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ManualSplineMoveAnimConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ManualSplineMoveAnimConfig));
	}
}
