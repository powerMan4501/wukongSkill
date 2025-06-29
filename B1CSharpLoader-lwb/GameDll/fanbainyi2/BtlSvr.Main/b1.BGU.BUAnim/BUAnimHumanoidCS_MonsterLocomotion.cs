using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion")]
public class BUAnimHumanoidCS_MonsterLocomotion : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPMonsterLocomotionData MonsterLocomotionData;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool VelocityBlendAlpha_IsValid;

	private static int VelocityBlendAlpha_Offset;

	private static bool MoveLoopFwdBlendAlpha_IsValid;

	private static int MoveLoopFwdBlendAlpha_Offset;

	private static bool ASFreeRunFwd_IsValid;

	private static int ASFreeRunFwd_Offset;

	private static bool ASFreeRunStartFwd_IsValid;

	private static int ASFreeRunStartFwd_Offset;

	private static bool ASFreeRunStartFR_IsValid;

	private static int ASFreeRunStartFR_Offset;

	private static bool ASFreeRunStartBR_IsValid;

	private static int ASFreeRunStartBR_Offset;

	private static bool ASFreeRunStartFL_IsValid;

	private static int ASFreeRunStartFL_Offset;

	private static bool ASFreeRunStartBL_IsValid;

	private static int ASFreeRunStartBL_Offset;

	private static bool BSFreeLeanAdditive_IsValid;

	private static int BSFreeLeanAdditive_Offset;

	private static bool BSFreeLeanAdditiveX_IsValid;

	private static int BSFreeLeanAdditiveX_Offset;

	private static bool BSFreeLeanAdditiveY_IsValid;

	private static int BSFreeLeanAdditiveY_Offset;

	private static bool BSFreeRotAdditive_IsValid;

	private static int BSFreeRotAdditive_Offset;

	private static bool BSFreeRotAdditiveX_IsValid;

	private static int BSFreeRotAdditiveX_Offset;

	private static bool BSFreeRotAdditiveY_IsValid;

	private static int BSFreeRotAdditiveY_Offset;

	private static bool ASFreeRunStopLeftFoot_IsValid;

	private static int ASFreeRunStopLeftFoot_Offset;

	private static bool ASFreeRunStopRightFoot_IsValid;

	private static int ASFreeRunStopRightFoot_Offset;

	private static bool bLeftFootFront_IsValid;

	private static int bLeftFootFront_Offset;

	private static FFieldAddress bLeftFootFront_PropertyAddress;

	private static bool ASLockWalkFwd_IsValid;

	private static int ASLockWalkFwd_Offset;

	private static bool ASLockWalkFR_IsValid;

	private static int ASLockWalkFR_Offset;

	private static bool ASLockWalkBR_IsValid;

	private static int ASLockWalkBR_Offset;

	private static bool ASLockWalkFL_IsValid;

	private static int ASLockWalkFL_Offset;

	private static bool ASLockWalkBL_IsValid;

	private static int ASLockWalkBL_Offset;

	private static bool ASLockWalkBwd_IsValid;

	private static int ASLockWalkBwd_Offset;

	private static bool LockMoveDir_IsValid;

	private static int LockMoveDir_Offset;

	private static FFieldAddress LockMoveDir_PropertyAddress;

	private static bool LockWalkFwdExplicitTimeForLeftFootStop_IsValid;

	private static int LockWalkFwdExplicitTimeForLeftFootStop_Offset;

	private static bool LockWalkBwdExplicitTimeForLeftFootStop_IsValid;

	private static int LockWalkBwdExplicitTimeForLeftFootStop_Offset;

	private static bool LockWalkFLExplicitTimeForLeftFootStop_IsValid;

	private static int LockWalkFLExplicitTimeForLeftFootStop_Offset;

	private static bool LockWalkBLExplicitTimeForLeftFootStop_IsValid;

	private static int LockWalkBLExplicitTimeForLeftFootStop_Offset;

	private static bool LockWalkFRExplicitTimeForLeftFootStop_IsValid;

	private static int LockWalkFRExplicitTimeForLeftFootStop_Offset;

	private static bool LockWalkBRExplicitTimeForLeftFootStop_IsValid;

	private static int LockWalkBRExplicitTimeForLeftFootStop_Offset;

	private static bool LockWalkFwdExplicitTimeForRightFootStop_IsValid;

	private static int LockWalkFwdExplicitTimeForRightFootStop_Offset;

	private static bool LockWalkBwdExplicitTimeForRightFootStop_IsValid;

	private static int LockWalkBwdExplicitTimeForRightFootStop_Offset;

	private static bool LockWalkFLExplicitTimeForRightFootStop_IsValid;

	private static int LockWalkFLExplicitTimeForRightFootStop_Offset;

	private static bool LockWalkBLExplicitTimeForRightFootStop_IsValid;

	private static int LockWalkBLExplicitTimeForRightFootStop_Offset;

	private static bool LockWalkFRExplicitTimeForRightFootStop_IsValid;

	private static int LockWalkFRExplicitTimeForRightFootStop_Offset;

	private static bool LockWalkBRExplicitTimeForRightFootStop_IsValid;

	private static int LockWalkBRExplicitTimeForRightFootStop_Offset;

	private static bool bSwitchToLock_IsValid;

	private static int bSwitchToLock_Offset;

	private static FFieldAddress bSwitchToLock_PropertyAddress;

	private static bool bLockMoveF_IsValid;

	private static int bLockMoveF_Offset;

	private static FFieldAddress bLockMoveF_PropertyAddress;

	private static bool bLockMoveB_IsValid;

	private static int bLockMoveB_Offset;

	private static FFieldAddress bLockMoveB_PropertyAddress;

	private static bool bLockMoveL_IsValid;

	private static int bLockMoveL_Offset;

	private static FFieldAddress bLockMoveL_PropertyAddress;

	private static bool bLockMoveR_IsValid;

	private static int bLockMoveR_Offset;

	private static FFieldAddress bLockMoveR_PropertyAddress;

	private static bool bFreeMoveStartFwd_IsValid;

	private static int bFreeMoveStartFwd_Offset;

	private static FFieldAddress bFreeMoveStartFwd_PropertyAddress;

	private static bool bFreeMoveStartBL_IsValid;

	private static int bFreeMoveStartBL_Offset;

	private static FFieldAddress bFreeMoveStartBL_PropertyAddress;

	private static bool bFreeMoveStartFL_IsValid;

	private static int bFreeMoveStartFL_Offset;

	private static FFieldAddress bFreeMoveStartFL_PropertyAddress;

	private static bool bFreeMoveStartBR_IsValid;

	private static int bFreeMoveStartBR_Offset;

	private static FFieldAddress bFreeMoveStartBR_PropertyAddress;

	private static bool bFreeMoveStartFR_IsValid;

	private static int bFreeMoveStartFR_Offset;

	private static FFieldAddress bFreeMoveStartFR_PropertyAddress;

	private static bool bIdleToMove_IsValid;

	private static int bIdleToMove_Offset;

	private static FFieldAddress bIdleToMove_PropertyAddress;

	private static bool bMoveStop_IsValid;

	private static int bMoveStop_Offset;

	private static FFieldAddress bMoveStop_PropertyAddress;

	private static bool bStandardFreeMoveStop_IsValid;

	private static int bStandardFreeMoveStop_Offset;

	private static FFieldAddress bStandardFreeMoveStop_PropertyAddress;

	[BlueprintReadOnly]
	[UProperty]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:VelocityBlendAlpha")]
	public FVector4 VelocityBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!VelocityBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:VelocityBlendAlpha");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, VelocityBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:VelocityBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, VelocityBlendAlpha_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:MoveLoopFwdBlendAlpha")]
	public float MoveLoopFwdBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopFwdBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:MoveLoopFwdBlendAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopFwdBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopFwdBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:MoveLoopFwdBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopFwdBlendAlpha_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Free")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunFwd")]
	public UAnimSequence ASFreeRunFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFwd")]
	public UAnimSequence ASFreeRunStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStartFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFR")]
	public UAnimSequence ASFreeRunStartFR
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStartFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStartFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStartFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStartFR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartBR")]
	public UAnimSequence ASFreeRunStartBR
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStartBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStartBR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFL")]
	public UAnimSequence ASFreeRunStartFL
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStartFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStartFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStartFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartFL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStartFL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartBL")]
	public UAnimSequence ASFreeRunStartBL
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStartBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStartBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStartBL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditive")]
	public UBlendSpace BSFreeLeanAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeLeanAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSFreeLeanAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeLeanAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSFreeLeanAdditive_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditiveX")]
	public float BSFreeLeanAdditiveX
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeLeanAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditiveX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFreeLeanAdditiveX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeLeanAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditiveX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFreeLeanAdditiveX_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Free")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditiveY")]
	public float BSFreeLeanAdditiveY
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeLeanAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditiveY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFreeLeanAdditiveY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeLeanAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeLeanAdditiveY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFreeLeanAdditiveY_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Free")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditive")]
	public UBlendSpace BSFreeRotAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeRotAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSFreeRotAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeRotAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSFreeRotAdditive_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Free")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditiveX")]
	public float BSFreeRotAdditiveX
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeRotAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditiveX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFreeRotAdditiveX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeRotAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditiveX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFreeRotAdditiveX_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MonsterLocomotion_Free")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditiveY")]
	public float BSFreeRotAdditiveY
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeRotAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditiveY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFreeRotAdditiveY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeRotAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:BSFreeRotAdditiveY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFreeRotAdditiveY_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MonsterLocomotion_Free")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStopLeftFoot")]
	public UAnimSequence ASFreeRunStopLeftFoot
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStopLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStopLeftFoot");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStopLeftFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStopLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStopLeftFoot");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStopLeftFoot_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Free")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStopRightFoot")]
	public UAnimSequence ASFreeRunStopRightFoot
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStopRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStopRightFoot");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStopRightFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStopRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASFreeRunStopRightFoot");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStopRightFoot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Free")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLeftFootFront")]
	public bool bLeftFootFront
	{
		get
		{
			CheckDestroyed();
			if (!bLeftFootFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLeftFootFront");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLeftFootFront_Offset), 0, bLeftFootFront_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLeftFootFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLeftFootFront");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLeftFootFront_Offset), 0, bLeftFootFront_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFwd")]
	public UAnimSequence ASLockWalkFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkFwd_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFR")]
	public UAnimSequence ASLockWalkFR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkFR_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBR")]
	public UAnimSequence ASLockWalkBR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkBR_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFL")]
	public UAnimSequence ASLockWalkFL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkFL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkFL_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBL")]
	public UAnimSequence ASLockWalkBL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkBL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Lock")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBwd")]
	public UAnimSequence ASLockWalkBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:ASLockWalkBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkBwd_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockMoveDir")]
	public EMoveDirectionEight LockMoveDir
	{
		get
		{
			CheckDestroyed();
			if (!LockMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockMoveDir");
				return EMoveDirectionEight.None;
			}
			return EnumMarshaler<EMoveDirectionEight>.FromNative(IntPtr.Add(base.Address, LockMoveDir_Offset), 0, LockMoveDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockMoveDir");
			}
			else
			{
				EnumMarshaler<EMoveDirectionEight>.ToNative(IntPtr.Add(base.Address, LockMoveDir_Offset), 0, LockMoveDir_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Lock")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFwdExplicitTimeForLeftFootStop")]
	public float LockWalkFwdExplicitTimeForLeftFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkFwdExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFwdExplicitTimeForLeftFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkFwdExplicitTimeForLeftFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkFwdExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFwdExplicitTimeForLeftFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkFwdExplicitTimeForLeftFootStop_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBwdExplicitTimeForLeftFootStop")]
	public float LockWalkBwdExplicitTimeForLeftFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkBwdExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBwdExplicitTimeForLeftFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkBwdExplicitTimeForLeftFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkBwdExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBwdExplicitTimeForLeftFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkBwdExplicitTimeForLeftFootStop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("MonsterLocomotion_Lock")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFLExplicitTimeForLeftFootStop")]
	public float LockWalkFLExplicitTimeForLeftFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkFLExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFLExplicitTimeForLeftFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkFLExplicitTimeForLeftFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkFLExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFLExplicitTimeForLeftFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkFLExplicitTimeForLeftFootStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Lock")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBLExplicitTimeForLeftFootStop")]
	public float LockWalkBLExplicitTimeForLeftFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkBLExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBLExplicitTimeForLeftFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkBLExplicitTimeForLeftFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkBLExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBLExplicitTimeForLeftFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkBLExplicitTimeForLeftFootStop_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFRExplicitTimeForLeftFootStop")]
	public float LockWalkFRExplicitTimeForLeftFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkFRExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFRExplicitTimeForLeftFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkFRExplicitTimeForLeftFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkFRExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFRExplicitTimeForLeftFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkFRExplicitTimeForLeftFootStop_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBRExplicitTimeForLeftFootStop")]
	public float LockWalkBRExplicitTimeForLeftFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkBRExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBRExplicitTimeForLeftFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkBRExplicitTimeForLeftFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkBRExplicitTimeForLeftFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBRExplicitTimeForLeftFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkBRExplicitTimeForLeftFootStop_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFwdExplicitTimeForRightFootStop")]
	public float LockWalkFwdExplicitTimeForRightFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkFwdExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFwdExplicitTimeForRightFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkFwdExplicitTimeForRightFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkFwdExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFwdExplicitTimeForRightFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkFwdExplicitTimeForRightFootStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Lock")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBwdExplicitTimeForRightFootStop")]
	public float LockWalkBwdExplicitTimeForRightFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkBwdExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBwdExplicitTimeForRightFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkBwdExplicitTimeForRightFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkBwdExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBwdExplicitTimeForRightFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkBwdExplicitTimeForRightFootStop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFLExplicitTimeForRightFootStop")]
	public float LockWalkFLExplicitTimeForRightFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkFLExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFLExplicitTimeForRightFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkFLExplicitTimeForRightFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkFLExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFLExplicitTimeForRightFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkFLExplicitTimeForRightFootStop_Offset), value);
			}
		}
	}

	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBLExplicitTimeForRightFootStop")]
	public float LockWalkBLExplicitTimeForRightFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkBLExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBLExplicitTimeForRightFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkBLExplicitTimeForRightFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkBLExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBLExplicitTimeForRightFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkBLExplicitTimeForRightFootStop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("MonsterLocomotion_Lock")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFRExplicitTimeForRightFootStop")]
	public float LockWalkFRExplicitTimeForRightFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkFRExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFRExplicitTimeForRightFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkFRExplicitTimeForRightFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkFRExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkFRExplicitTimeForRightFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkFRExplicitTimeForRightFootStop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("MonsterLocomotion_Lock")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBRExplicitTimeForRightFootStop")]
	public float LockWalkBRExplicitTimeForRightFootStop
	{
		get
		{
			CheckDestroyed();
			if (!LockWalkBRExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBRExplicitTimeForRightFootStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockWalkBRExplicitTimeForRightFootStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockWalkBRExplicitTimeForRightFootStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:LockWalkBRExplicitTimeForRightFootStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockWalkBRExplicitTimeForRightFootStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bSwitchToLock")]
	public bool bSwitchToLock
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bSwitchToLock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bSwitchToLock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveF")]
	public bool bLockMoveF
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveF_Offset), 0, bLockMoveF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveF_Offset), 0, bLockMoveF_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveB")]
	public bool bLockMoveB
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveB_Offset), 0, bLockMoveB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveB_Offset), 0, bLockMoveB_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveL")]
	public bool bLockMoveL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveL_Offset), 0, bLockMoveL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveL_Offset), 0, bLockMoveL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveR")]
	public bool bLockMoveR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveR_Offset), 0, bLockMoveR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bLockMoveR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveR_Offset), 0, bLockMoveR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFwd")]
	public bool bFreeMoveStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!bFreeMoveStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeMoveStartFwd_Offset), 0, bFreeMoveStartFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeMoveStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeMoveStartFwd_Offset), 0, bFreeMoveStartFwd_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartBL")]
	public bool bFreeMoveStartBL
	{
		get
		{
			CheckDestroyed();
			if (!bFreeMoveStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeMoveStartBL_Offset), 0, bFreeMoveStartBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeMoveStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeMoveStartBL_Offset), 0, bFreeMoveStartBL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFL")]
	public bool bFreeMoveStartFL
	{
		get
		{
			CheckDestroyed();
			if (!bFreeMoveStartFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeMoveStartFL_Offset), 0, bFreeMoveStartFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeMoveStartFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeMoveStartFL_Offset), 0, bFreeMoveStartFL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartBR")]
	public bool bFreeMoveStartBR
	{
		get
		{
			CheckDestroyed();
			if (!bFreeMoveStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeMoveStartBR_Offset), 0, bFreeMoveStartBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeMoveStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeMoveStartBR_Offset), 0, bFreeMoveStartBR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFR")]
	public bool bFreeMoveStartFR
	{
		get
		{
			CheckDestroyed();
			if (!bFreeMoveStartFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeMoveStartFR_Offset), 0, bFreeMoveStartFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeMoveStartFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bFreeMoveStartFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeMoveStartFR_Offset), 0, bFreeMoveStartFR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bIdleToMove")]
	public bool bIdleToMove
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bIdleToMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToMove_Offset), 0, bIdleToMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bIdleToMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToMove_Offset), 0, bIdleToMove_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bMoveStop")]
	public bool bMoveStop
	{
		get
		{
			CheckDestroyed();
			if (!bMoveStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bMoveStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMoveStop_Offset), 0, bMoveStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMoveStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bMoveStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMoveStop_Offset), 0, bMoveStop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bStandardFreeMoveStop")]
	public bool bStandardFreeMoveStop
	{
		get
		{
			CheckDestroyed();
			if (!bStandardFreeMoveStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bStandardFreeMoveStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStandardFreeMoveStop_Offset), 0, bStandardFreeMoveStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStandardFreeMoveStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion:bStandardFreeMoveStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStandardFreeMoveStop_Offset), 0, bStandardFreeMoveStop_PropertyAddress.Address, value);
			}
		}
	}

	private bool bHasStandardStopAnim { get; set; }

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null && b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.MonsterLocomotion, aBPSettingData))
			{
				InitMonsterLocomotionSetting(aBPSettingData.MonsterLocomotionSetting);
				InitData();
			}
		}
	}

	private void InitMonsterLocomotionSetting(BUABPMonsterLocomotionSettingData Setting)
	{
		InitMonsterLocomotionFreeSetting(Setting.Free);
		InitMonsterLocomotionLockSetting(Setting.Lock);
	}

	private void InitMonsterLocomotionFreeSetting(BUABPMonsterLocomotion_FreeSettingData Setting)
	{
		ASFreeRunFwd = Setting.ASFreeRunFwd;
		ASFreeRunStartFwd = Setting.ASFreeRunStartFwd;
		ASFreeRunStartFR = Setting.ASFreeRunStartFR;
		ASFreeRunStartBR = Setting.ASFreeRunStartBR;
		ASFreeRunStartFL = Setting.ASFreeRunStartFL;
		ASFreeRunStartBL = Setting.ASFreeRunStartBL;
		BSFreeLeanAdditive = Setting.BSFreeLeanAdditive;
		BSFreeRotAdditive = Setting.BSFreeRotAdditive;
		ASFreeRunStopLeftFoot = Setting.ASFreeRunStopLeftFoot;
		ASFreeRunStopRightFoot = Setting.ASFreeRunStopRightFoot;
		bHasStandardStopAnim = ASFreeRunStopLeftFoot != null && ASFreeRunStopRightFoot != null;
	}

	private void InitMonsterLocomotionLockSetting(BUABPMonsterLocomotion_LockSettingData Setting)
	{
		ASLockWalkFwd = Setting.ASLockWalkFwd;
		ASLockWalkFR = Setting.ASLockWalkFR;
		ASLockWalkBR = Setting.ASLockWalkBR;
		ASLockWalkFL = Setting.ASLockWalkFL;
		ASLockWalkBL = Setting.ASLockWalkBL;
		ASLockWalkBwd = Setting.ASLockWalkBwd;
		InitMonsterLocomotionLockExplicitTimeLeftFootSetting(Setting.ExplicitTimeForLeftFootStop);
		InitMonsterLocomotionLockExplicitTimeRightFootSetting(Setting.ExplicitTimeForRightFootStop);
	}

	private void InitMonsterLocomotionLockExplicitTimeLeftFootSetting(BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData Setting)
	{
		LockWalkFwdExplicitTimeForLeftFootStop = Setting.Fwd;
		LockWalkBwdExplicitTimeForLeftFootStop = Setting.Bwd;
		LockWalkFLExplicitTimeForLeftFootStop = Setting.FL;
		LockWalkFRExplicitTimeForLeftFootStop = Setting.FR;
		LockWalkBLExplicitTimeForLeftFootStop = Setting.BL;
		LockWalkBRExplicitTimeForLeftFootStop = Setting.BR;
	}

	private void InitMonsterLocomotionLockExplicitTimeRightFootSetting(BUABPMonsterLocomotion_Lock_ExplicitTimeForMoveStopSettingData Setting)
	{
		LockWalkFwdExplicitTimeForRightFootStop = Setting.Fwd;
		LockWalkBwdExplicitTimeForRightFootStop = Setting.Bwd;
		LockWalkFLExplicitTimeForRightFootStop = Setting.FL;
		LockWalkFRExplicitTimeForRightFootStop = Setting.FR;
		LockWalkBLExplicitTimeForRightFootStop = Setting.BL;
		LockWalkBRExplicitTimeForRightFootStop = Setting.BR;
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter != null)
		{
			if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
			{
				AnimIdle = TopAnimInst.ABPSettingData.CommonSetting.AnimSeqIdle;
			}
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(aCharacter);
			if (CommonData != null)
			{
				AnimIdle = CommonData.AnimIdle;
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
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			MonsterLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPMonsterLocomotionData, BUC_ABPMonsterLocomotionData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
		}
	}

	private void UpdateData(float DeltaTime)
	{
		if (CommonData != null && CommonData.FinalABPMoveMode == EABPMoveMode.MonsterLocomotion)
		{
			if (CommonData != null)
			{
				AnimIdle = CommonData.AnimIdle;
			}
			if (ChrData != null)
			{
				bLeftFootFront = ChrData.IsLeftFootFront();
			}
			if (MonsterLocomotionData != null)
			{
				bFreeMoveStartFwd = MonsterLocomotionData.FreeMoveStartDirection == EMoveDirectionEight.F && ASFreeRunStartFwd != null;
				bFreeMoveStartFL = MonsterLocomotionData.FreeMoveStartDirection == EMoveDirectionEight.FL;
				bFreeMoveStartFR = MonsterLocomotionData.FreeMoveStartDirection == EMoveDirectionEight.FR;
				bFreeMoveStartBL = MonsterLocomotionData.FreeMoveStartDirection == EMoveDirectionEight.BL;
				bFreeMoveStartBR = MonsterLocomotionData.FreeMoveStartDirection == EMoveDirectionEight.BR;
				bLockMoveF = MonsterLocomotionData.TargetLockMoveDirection == EMoveDirection.Forward;
				bLockMoveB = MonsterLocomotionData.TargetLockMoveDirection == EMoveDirection.Backward;
				bLockMoveL = MonsterLocomotionData.TargetLockMoveDirection == EMoveDirection.Left;
				bLockMoveR = MonsterLocomotionData.TargetLockMoveDirection == EMoveDirection.Right;
				MoveLoopFwdBlendAlpha = MonsterLocomotionData.MoveLoopFwdBlendAlpha;
				VelocityBlendAlpha = MonsterLocomotionData.VelocityBlendAlpha;
				float bSFreeLeanAdditiveX = (BSFreeRotAdditiveX = MonsterLocomotionData.FreeLeanAdditiveX);
				BSFreeLeanAdditiveX = bSFreeLeanAdditiveX;
				bSFreeLeanAdditiveX = (BSFreeRotAdditiveY = MonsterLocomotionData.FreeLeanAdditiveY);
				BSFreeLeanAdditiveY = bSFreeLeanAdditiveX;
				bSwitchToLock = MonsterLocomotionData.bSwitchToLock;
				bIdleToMove = MonsterLocomotionData.bIdleToMove;
				bMoveStop = MonsterLocomotionData.bMoveToBlendStop;
				bStandardFreeMoveStop = bHasStandardStopAnim && MonsterLocomotionData.bMoveToStandardFreeStop;
				LockMoveDir = MonsterLocomotionData.CurLockMoveDirection;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_MonsterLocomotion");
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimIdle", Classes.FObjectProperty);
		VelocityBlendAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocityBlendAlpha");
		VelocityBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocityBlendAlpha", Classes.FStructProperty);
		MoveLoopFwdBlendAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveLoopFwdBlendAlpha");
		MoveLoopFwdBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveLoopFwdBlendAlpha", Classes.FFloatProperty);
		ASFreeRunFwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunFwd");
		ASFreeRunFwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunFwd", Classes.FObjectProperty);
		ASFreeRunStartFwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStartFwd");
		ASFreeRunStartFwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStartFwd", Classes.FObjectProperty);
		ASFreeRunStartFR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStartFR");
		ASFreeRunStartFR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStartFR", Classes.FObjectProperty);
		ASFreeRunStartBR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStartBR");
		ASFreeRunStartBR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStartBR", Classes.FObjectProperty);
		ASFreeRunStartFL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStartFL");
		ASFreeRunStartFL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStartFL", Classes.FObjectProperty);
		ASFreeRunStartBL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStartBL");
		ASFreeRunStartBL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStartBL", Classes.FObjectProperty);
		BSFreeLeanAdditive_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFreeLeanAdditive");
		BSFreeLeanAdditive_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFreeLeanAdditive", Classes.FObjectProperty);
		BSFreeLeanAdditiveX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFreeLeanAdditiveX");
		BSFreeLeanAdditiveX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFreeLeanAdditiveX", Classes.FFloatProperty);
		BSFreeLeanAdditiveY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFreeLeanAdditiveY");
		BSFreeLeanAdditiveY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFreeLeanAdditiveY", Classes.FFloatProperty);
		BSFreeRotAdditive_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFreeRotAdditive");
		BSFreeRotAdditive_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFreeRotAdditive", Classes.FObjectProperty);
		BSFreeRotAdditiveX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFreeRotAdditiveX");
		BSFreeRotAdditiveX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFreeRotAdditiveX", Classes.FFloatProperty);
		BSFreeRotAdditiveY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFreeRotAdditiveY");
		BSFreeRotAdditiveY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFreeRotAdditiveY", Classes.FFloatProperty);
		ASFreeRunStopLeftFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStopLeftFoot");
		ASFreeRunStopLeftFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStopLeftFoot", Classes.FObjectProperty);
		ASFreeRunStopRightFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFreeRunStopRightFoot");
		ASFreeRunStopRightFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFreeRunStopRightFoot", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bLeftFootFront_PropertyAddress, unrealStruct, "bLeftFootFront");
		bLeftFootFront_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLeftFootFront");
		bLeftFootFront_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLeftFootFront", Classes.FBoolProperty);
		ASLockWalkFwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLockWalkFwd");
		ASLockWalkFwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLockWalkFwd", Classes.FObjectProperty);
		ASLockWalkFR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLockWalkFR");
		ASLockWalkFR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLockWalkFR", Classes.FObjectProperty);
		ASLockWalkBR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLockWalkBR");
		ASLockWalkBR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLockWalkBR", Classes.FObjectProperty);
		ASLockWalkFL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLockWalkFL");
		ASLockWalkFL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLockWalkFL", Classes.FObjectProperty);
		ASLockWalkBL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLockWalkBL");
		ASLockWalkBL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLockWalkBL", Classes.FObjectProperty);
		ASLockWalkBwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASLockWalkBwd");
		ASLockWalkBwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASLockWalkBwd", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref LockMoveDir_PropertyAddress, unrealStruct, "LockMoveDir");
		LockMoveDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockMoveDir");
		LockMoveDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockMoveDir", Classes.FEnumProperty);
		LockWalkFwdExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkFwdExplicitTimeForLeftFootStop");
		LockWalkFwdExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkFwdExplicitTimeForLeftFootStop", Classes.FFloatProperty);
		LockWalkBwdExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkBwdExplicitTimeForLeftFootStop");
		LockWalkBwdExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkBwdExplicitTimeForLeftFootStop", Classes.FFloatProperty);
		LockWalkFLExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkFLExplicitTimeForLeftFootStop");
		LockWalkFLExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkFLExplicitTimeForLeftFootStop", Classes.FFloatProperty);
		LockWalkBLExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkBLExplicitTimeForLeftFootStop");
		LockWalkBLExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkBLExplicitTimeForLeftFootStop", Classes.FFloatProperty);
		LockWalkFRExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkFRExplicitTimeForLeftFootStop");
		LockWalkFRExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkFRExplicitTimeForLeftFootStop", Classes.FFloatProperty);
		LockWalkBRExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkBRExplicitTimeForLeftFootStop");
		LockWalkBRExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkBRExplicitTimeForLeftFootStop", Classes.FFloatProperty);
		LockWalkFwdExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkFwdExplicitTimeForRightFootStop");
		LockWalkFwdExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkFwdExplicitTimeForRightFootStop", Classes.FFloatProperty);
		LockWalkBwdExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkBwdExplicitTimeForRightFootStop");
		LockWalkBwdExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkBwdExplicitTimeForRightFootStop", Classes.FFloatProperty);
		LockWalkFLExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkFLExplicitTimeForRightFootStop");
		LockWalkFLExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkFLExplicitTimeForRightFootStop", Classes.FFloatProperty);
		LockWalkBLExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkBLExplicitTimeForRightFootStop");
		LockWalkBLExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkBLExplicitTimeForRightFootStop", Classes.FFloatProperty);
		LockWalkFRExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkFRExplicitTimeForRightFootStop");
		LockWalkFRExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkFRExplicitTimeForRightFootStop", Classes.FFloatProperty);
		LockWalkBRExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockWalkBRExplicitTimeForRightFootStop");
		LockWalkBRExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockWalkBRExplicitTimeForRightFootStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bSwitchToLock_PropertyAddress, unrealStruct, "bSwitchToLock");
		bSwitchToLock_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bSwitchToLock");
		bSwitchToLock_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bSwitchToLock", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveF_PropertyAddress, unrealStruct, "bLockMoveF");
		bLockMoveF_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLockMoveF");
		bLockMoveF_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLockMoveF", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveB_PropertyAddress, unrealStruct, "bLockMoveB");
		bLockMoveB_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLockMoveB");
		bLockMoveB_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLockMoveB", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveL_PropertyAddress, unrealStruct, "bLockMoveL");
		bLockMoveL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLockMoveL");
		bLockMoveL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLockMoveL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveR_PropertyAddress, unrealStruct, "bLockMoveR");
		bLockMoveR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLockMoveR");
		bLockMoveR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLockMoveR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeMoveStartFwd_PropertyAddress, unrealStruct, "bFreeMoveStartFwd");
		bFreeMoveStartFwd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFreeMoveStartFwd");
		bFreeMoveStartFwd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFreeMoveStartFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeMoveStartBL_PropertyAddress, unrealStruct, "bFreeMoveStartBL");
		bFreeMoveStartBL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFreeMoveStartBL");
		bFreeMoveStartBL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFreeMoveStartBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeMoveStartFL_PropertyAddress, unrealStruct, "bFreeMoveStartFL");
		bFreeMoveStartFL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFreeMoveStartFL");
		bFreeMoveStartFL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFreeMoveStartFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeMoveStartBR_PropertyAddress, unrealStruct, "bFreeMoveStartBR");
		bFreeMoveStartBR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFreeMoveStartBR");
		bFreeMoveStartBR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFreeMoveStartBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeMoveStartFR_PropertyAddress, unrealStruct, "bFreeMoveStartFR");
		bFreeMoveStartFR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFreeMoveStartFR");
		bFreeMoveStartFR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFreeMoveStartFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToMove_PropertyAddress, unrealStruct, "bIdleToMove");
		bIdleToMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bIdleToMove");
		bIdleToMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bIdleToMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMoveStop_PropertyAddress, unrealStruct, "bMoveStop");
		bMoveStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bMoveStop");
		bMoveStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bMoveStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStandardFreeMoveStop_PropertyAddress, unrealStruct, "bStandardFreeMoveStop");
		bStandardFreeMoveStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bStandardFreeMoveStop");
		bStandardFreeMoveStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bStandardFreeMoveStop", Classes.FBoolProperty);
	}

	static BUAnimHumanoidCS_MonsterLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_MonsterLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_MonsterLocomotion));
	}
}
