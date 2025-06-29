using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BGAnimSpider")]
internal class BGAnimSpider : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	protected AActor Owner;

	protected USkeletalMeshComponent Mesh;

	protected UBGUCharacterMovementComponent MovementComp;

	private List<bool> IsMovingLeg = new List<bool>();

	private List<FName> LegNames = new List<FName>();

	private List<float> LegMoveDistance = new List<float>();

	private List<float> LegForwardDistance = new List<float>();

	private List<float> LegMoveSpeed = new List<float>();

	private List<FTransform> LegInitBoneCS = new List<FTransform>();

	private int LegCount;

	private bool bShouldLeftMove;

	private float RelativeScale;

	private static float StandardUnit;

	private IBUC_SimpleJumpData SimpleJumpData;

	private IBUC_AINodeData AINodeData;

	private IBUC_ABPPoseSnapshotData PoseSnapshotData;

	private static bool ABPSetting_IsValid;

	private static int ABPSetting_Offset;

	private static bool DefaultIdle_IsValid;

	private static int DefaultIdle_Offset;

	private static bool JumpStart_IsValid;

	private static int JumpStart_Offset;

	private static bool JumpLoop_IsValid;

	private static int JumpLoop_Offset;

	private static bool JumpEndLight_IsValid;

	private static int JumpEndLight_Offset;

	private static bool JumpEndHeavy_IsValid;

	private static int JumpEndHeavy_Offset;

	private static bool bUseJumpEndLight_IsValid;

	private static int bUseJumpEndLight_Offset;

	private static FFieldAddress bUseJumpEndLight_PropertyAddress;

	private static bool LegTargetCS_IsValid;

	private static int LegTargetCS_Offset;

	private static FFieldAddress LegTargetCS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LegTargetCS_Marshaler;

	private static bool LegRecordTargetCS_IsValid;

	private static int LegRecordTargetCS_Offset;

	private static FFieldAddress LegRecordTargetCS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LegRecordTargetCS_Marshaler;

	private static bool LegLastTargetCS_IsValid;

	private static int LegLastTargetCS_Offset;

	private static FFieldAddress LegLastTargetCS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LegLastTargetCS_Marshaler;

	private static bool LegRatio_IsValid;

	private static int LegRatio_Offset;

	private static FFieldAddress LegRatio_PropertyAddress;

	private TArrayReadWriteMarshaler<float> LegRatio_Marshaler;

	private static bool LegCurTargetWS_IsValid;

	private static int LegCurTargetWS_Offset;

	private static FFieldAddress LegCurTargetWS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LegCurTargetWS_Marshaler;

	private static bool LegLastTargetWS_IsValid;

	private static int LegLastTargetWS_Offset;

	private static FFieldAddress LegLastTargetWS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LegLastTargetWS_Marshaler;

	private static bool LegTargetWS_IsValid;

	private static int LegTargetWS_Offset;

	private static FFieldAddress LegTargetWS_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> LegTargetWS_Marshaler;

	private static bool SpineTargetRot_IsValid;

	private static int SpineTargetRot_Offset;

	private static bool SpineLerpSpeed_IsValid;

	private static int SpineLerpSpeed_Offset;

	private static bool SpineCurRot_IsValid;

	private static int SpineCurRot_Offset;

	private static bool bIsOnPlatform_IsValid;

	private static int bIsOnPlatform_Offset;

	private static FFieldAddress bIsOnPlatform_PropertyAddress;

	private static bool bIsFalling_IsValid;

	private static int bIsFalling_Offset;

	private static FFieldAddress bIsFalling_PropertyAddress;

	private static bool bStartJump_IsValid;

	private static int bStartJump_Offset;

	private static FFieldAddress bStartJump_PropertyAddress;

	private static bool bIsAISpiderMove_IsValid;

	private static int bIsAISpiderMove_Offset;

	private static FFieldAddress bIsAISpiderMove_PropertyAddress;

	private static bool bUsePoseOverride_IsValid;

	private static int bUsePoseOverride_Offset;

	private static FFieldAddress bUsePoseOverride_PropertyAddress;

	private static bool PoseSnapshot_IsValid;

	private static int PoseSnapshot_Offset;

	private static bool EnableSnapshotBlendTime_IsValid;

	private static int EnableSnapshotBlendTime_Offset;

	private static bool DisableSnapshotBlendTime_IsValid;

	private static int DisableSnapshotBlendTime_Offset;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaSeconds_IsValid;

	private static int BlueprintUpdateAnimation_DeltaSeconds_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("ABP Setting")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:ABPSetting")]
	private BGWDataAsset_SpiderSetting ABPSetting
	{
		get
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:ABPSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_SpiderSetting>.FromNative(IntPtr.Add(base.Address, ABPSetting_Offset));
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:DefaultIdle")]
	private UAnimSequence DefaultIdle
	{
		get
		{
			CheckDestroyed();
			if (!DefaultIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:DefaultIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, DefaultIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:DefaultIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, DefaultIdle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:JumpStart")]
	private UAnimSequence JumpStart
	{
		get
		{
			CheckDestroyed();
			if (!JumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, JumpStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, JumpStart_Offset), value);
			}
		}
	}

	[Category("Spider")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:JumpLoop")]
	private UAnimSequence JumpLoop
	{
		get
		{
			CheckDestroyed();
			if (!JumpLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, JumpLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, JumpLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Spider")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:JumpEndLight")]
	private UAnimSequence JumpEndLight
	{
		get
		{
			CheckDestroyed();
			if (!JumpEndLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpEndLight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, JumpEndLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpEndLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpEndLight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, JumpEndLight_Offset), value);
			}
		}
	}

	[Category("Spider")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:JumpEndHeavy")]
	private UAnimSequence JumpEndHeavy
	{
		get
		{
			CheckDestroyed();
			if (!JumpEndHeavy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpEndHeavy");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, JumpEndHeavy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpEndHeavy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:JumpEndHeavy");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, JumpEndHeavy_Offset), value);
			}
		}
	}

	[Category("Spider")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:bUseJumpEndLight")]
	private bool bUseJumpEndLight
	{
		get
		{
			CheckDestroyed();
			if (!bUseJumpEndLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bUseJumpEndLight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseJumpEndLight_Offset), 0, bUseJumpEndLight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseJumpEndLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bUseJumpEndLight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseJumpEndLight_Offset), 0, bUseJumpEndLight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Spider")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegTargetCS")]
	private TArrayReadWrite<FVector> LegTargetCS
	{
		get
		{
			CheckDestroyed();
			if (!LegTargetCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegTargetCS");
				return null;
			}
			if (LegTargetCS_Marshaler == null)
			{
				LegTargetCS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LegTargetCS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LegTargetCS_Marshaler.FromNative(IntPtr.Add(base.Address, LegTargetCS_Offset));
		}
	}

	[Category("Spider")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegRecordTargetCS")]
	private TArrayReadWrite<FVector> LegRecordTargetCS
	{
		get
		{
			CheckDestroyed();
			if (!LegRecordTargetCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegRecordTargetCS");
				return null;
			}
			if (LegRecordTargetCS_Marshaler == null)
			{
				LegRecordTargetCS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LegRecordTargetCS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LegRecordTargetCS_Marshaler.FromNative(IntPtr.Add(base.Address, LegRecordTargetCS_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Spider")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegLastTargetCS")]
	private TArrayReadWrite<FVector> LegLastTargetCS
	{
		get
		{
			CheckDestroyed();
			if (!LegLastTargetCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegLastTargetCS");
				return null;
			}
			if (LegLastTargetCS_Marshaler == null)
			{
				LegLastTargetCS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LegLastTargetCS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LegLastTargetCS_Marshaler.FromNative(IntPtr.Add(base.Address, LegLastTargetCS_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegRatio")]
	private TArrayReadWrite<float> LegRatio
	{
		get
		{
			CheckDestroyed();
			if (!LegRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegRatio");
				return null;
			}
			if (LegRatio_Marshaler == null)
			{
				LegRatio_Marshaler = new TArrayReadWriteMarshaler<float>(1, LegRatio_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return LegRatio_Marshaler.FromNative(IntPtr.Add(base.Address, LegRatio_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Spider")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegCurTargetWS")]
	private TArrayReadWrite<FVector> LegCurTargetWS
	{
		get
		{
			CheckDestroyed();
			if (!LegCurTargetWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegCurTargetWS");
				return null;
			}
			if (LegCurTargetWS_Marshaler == null)
			{
				LegCurTargetWS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LegCurTargetWS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LegCurTargetWS_Marshaler.FromNative(IntPtr.Add(base.Address, LegCurTargetWS_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegLastTargetWS")]
	private TArrayReadWrite<FVector> LegLastTargetWS
	{
		get
		{
			CheckDestroyed();
			if (!LegLastTargetWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegLastTargetWS");
				return null;
			}
			if (LegLastTargetWS_Marshaler == null)
			{
				LegLastTargetWS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LegLastTargetWS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LegLastTargetWS_Marshaler.FromNative(IntPtr.Add(base.Address, LegLastTargetWS_Offset));
		}
	}

	[Category("Spider")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:LegTargetWS")]
	private TArrayReadWrite<FVector> LegTargetWS
	{
		get
		{
			CheckDestroyed();
			if (!LegTargetWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:LegTargetWS");
				return null;
			}
			if (LegTargetWS_Marshaler == null)
			{
				LegTargetWS_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, LegTargetWS_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LegTargetWS_Marshaler.FromNative(IntPtr.Add(base.Address, LegTargetWS_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:SpineTargetRot")]
	private FRotator SpineTargetRot
	{
		get
		{
			CheckDestroyed();
			if (!SpineTargetRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:SpineTargetRot");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, SpineTargetRot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpineTargetRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:SpineTargetRot");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, SpineTargetRot_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:SpineLerpSpeed")]
	private float SpineLerpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SpineLerpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:SpineLerpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpineLerpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpineLerpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:SpineLerpSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpineLerpSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:SpineCurRot")]
	private FRotator SpineCurRot
	{
		get
		{
			CheckDestroyed();
			if (!SpineCurRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:SpineCurRot");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, SpineCurRot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpineCurRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:SpineCurRot");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, SpineCurRot_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:bIsOnPlatform")]
	private bool bIsOnPlatform
	{
		get
		{
			CheckDestroyed();
			if (!bIsOnPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bIsOnPlatform");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsOnPlatform_Offset), 0, bIsOnPlatform_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsOnPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bIsOnPlatform");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsOnPlatform_Offset), 0, bIsOnPlatform_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Spider")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:bIsFalling")]
	private bool bIsFalling
	{
		get
		{
			CheckDestroyed();
			if (!bIsFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bIsFalling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsFalling_Offset), 0, bIsFalling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsFalling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bIsFalling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsFalling_Offset), 0, bIsFalling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Spider")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:bStartJump")]
	private bool bStartJump
	{
		get
		{
			CheckDestroyed();
			if (!bStartJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bStartJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStartJump_Offset), 0, bStartJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStartJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bStartJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStartJump_Offset), 0, bStartJump_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Spider")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:bIsAISpiderMove")]
	private bool bIsAISpiderMove
	{
		get
		{
			CheckDestroyed();
			if (!bIsAISpiderMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bIsAISpiderMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsAISpiderMove_Offset), 0, bIsAISpiderMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsAISpiderMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bIsAISpiderMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsAISpiderMove_Offset), 0, bIsAISpiderMove_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PoseSnapshot")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:bUsePoseOverride")]
	public bool bUsePoseOverride
	{
		get
		{
			CheckDestroyed();
			if (!bUsePoseOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bUsePoseOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUsePoseOverride_Offset), 0, bUsePoseOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUsePoseOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:bUsePoseOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUsePoseOverride_Offset), 0, bUsePoseOverride_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PoseSnapshot")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:PoseSnapshot")]
	public FPoseSnapshot PoseSnapshot
	{
		get
		{
			CheckDestroyed();
			if (!PoseSnapshot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:PoseSnapshot");
				return default(FPoseSnapshot);
			}
			return FPoseSnapshot.FromNative(IntPtr.Add(base.Address, PoseSnapshot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PoseSnapshot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:PoseSnapshot");
			}
			else
			{
				FPoseSnapshot.ToNative(IntPtr.Add(base.Address, PoseSnapshot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PoseSnapshot")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:EnableSnapshotBlendTime")]
	public float EnableSnapshotBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!EnableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:EnableSnapshotBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EnableSnapshotBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:EnableSnapshotBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EnableSnapshotBlendTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PoseSnapshot")]
	[USharpPath("/Script/b1-Managed.BGAnimSpider:DisableSnapshotBlendTime")]
	public float DisableSnapshotBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!DisableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:DisableSnapshotBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DisableSnapshotBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DisableSnapshotBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGAnimSpider:DisableSnapshotBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DisableSnapshotBlendTime_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGAnimSpider:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		Owner = GetOwningActor();
		Mesh = GetOwningComponent();
		MovementComp = (GetOwningActor() as ABGUCharacter)?.GetMovementComponent() as UBGUCharacterMovementComponent;
		LegCount = 8;
		for (int i = 0; i < LegCount; i++)
		{
			LegTargetCS.Add(FVector.ZeroVector);
			LegLastTargetCS.Add(FVector.ZeroVector);
			LegRatio.Add(0f);
			LegRecordTargetCS.Add(FVector.ZeroVector);
			LegLastTargetWS.Add(FVector.ZeroVector);
			LegCurTargetWS.Add(FVector.ZeroVector);
			LegTargetWS.Add(FVector.ZeroVector);
			LegMoveSpeed.Add(0f);
			IsMovingLeg.Add(item: false);
		}
		bShouldLeftMove = true;
		if (ABPSetting != null)
		{
			FAnimHumanoidSetting_Spider spiderSetting = ABPSetting.SpiderSetting;
			DefaultIdle = spiderSetting.AnimSeqIdle;
			JumpStart = spiderSetting.JumpStart;
			JumpLoop = spiderSetting.JumpLoop;
			JumpEndLight = spiderSetting.JumpEndLight;
			JumpEndHeavy = spiderSetting.JumpEndHeavy;
			LegMoveDistance = spiderSetting.LegMoveDistance;
			LegForwardDistance = spiderSetting.LegForwardDistance;
			LegNames = spiderSetting.LegNames;
			RelativeScale = spiderSetting.RelativeScale;
		}
		bIsAISpiderMove = false;
		for (int j = 0; j < LegCount; j++)
		{
			FTransform item = ((!(DefaultIdle != null)) ? UGSE_SkeletalMeshFuncLib.GetRefPoseTransform(Mesh, Mesh.GetBoneIndex(LegNames[j]), bIsLocal: false) : UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(DefaultIdle, 0f, LegNames[j], bExtractRootMotion: true));
			LegInitBoneCS.Add(item);
			LegLastTargetWS[j] = Mesh.GetSocketLocation(LegNames[j]);
			LegTargetWS[j] = LegLastTargetWS[j];
		}
	}

	[USharpPath("/Script/b1-Managed.BGAnimSpider:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaSeconds)
	{
		if (Owner == null || Mesh == null || Owner as ACharacter == null || MovementComp == null || !UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(Owner))
		{
			return;
		}
		bIsAISpiderMove = AINodeData != null && AINodeData.ActionType == EAINodeActionType.SpiderMoveTo;
		if (MovementComp as UBGUSpiderMovementComponent != null)
		{
			bIsOnPlatform = (MovementComp as UBGUSpiderMovementComponent).IsOnPlatform;
		}
		else
		{
			bIsOnPlatform = false;
		}
		FTransform worldTransform = Mesh.GetWorldTransform();
		FVector fVector = new FVector(0.0, 0.0, 1.0);
		if (MovementComp.IsInNavWalkOptMode())
		{
			fVector = MovementComp.CurNavOptFloorNormal;
		}
		else
		{
			fVector.X = (float)MovementComp.CurrentFloor.HitResult.Normal.X;
			fVector.Y = (float)MovementComp.CurrentFloor.HitResult.Normal.Y;
			fVector.Z = (float)MovementComp.CurrentFloor.HitResult.Normal.Z;
		}
		FVector vector = new FVector(fVector.X, fVector.Y, fVector.Z);
		if (!vector.IsNearlyZero())
		{
			FVector vector2 = GetOwningActor().GetActorTransform().TransformVector(FVector.UpVector);
			SpineTargetRot = (GetOwningActor().GetActorTransform() * new FTransform(FQuat.FindBetween(vector2, vector)) * worldTransform.Inverse()).Rotator();
			SpineCurRot = FMath.RInterpConstantTo(SpineCurRot, SpineTargetRot, DeltaSeconds, SpineLerpSpeed);
		}
		if (GSGameplayCVar.CVar_SpiderDrawTarget.GetValueInGameThread() == 1)
		{
			_ = "bShouldLeftMove : " + bShouldLeftMove;
			for (int i = 0; i < LegCount; i++)
			{
				_ = $"{i}:{LegRatio[i]}, IsMovingLeg:{IsMovingLeg[i]}, LastTarget:{LegLastTargetWS[i].ToString()}, CurTarget:{LegTargetWS[i].ToString()}";
			}
		}
		for (int j = 0; j < LegCount; j++)
		{
			if (ShouldTransition(j))
			{
				DoTransition(j);
			}
			DoState(j);
		}
		bIsFalling = MovementComp.IsFalling();
		if (SimpleJumpData != null)
		{
			bStartJump = SimpleJumpData.bStartJump;
		}
		if (ABPSetting != null && bIsFalling)
		{
			FVector lineTraceStart = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FVector lineTraceEnd = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - FVector.UpVector * ABPSetting.SpiderSetting.FallingHeightThreshold;
			bUseJumpEndLight = BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(Owner, lineTraceStart, lineTraceEnd, out var _);
		}
		if (PoseSnapshotData != null)
		{
			bUsePoseOverride = PoseSnapshotData.bUsePoseOverride;
			PoseSnapshot = PoseSnapshotData.PoseSnapshot;
			EnableSnapshotBlendTime = PoseSnapshotData.EnableSnapshotBlendTime;
			DisableSnapshotBlendTime = PoseSnapshotData.DisableSnapshotBlendTime;
		}
	}

	public bool IsLeftGroup(int i)
	{
		if (i != 0 && i != 2 && i != 5)
		{
			return i == 7;
		}
		return true;
	}

	public bool ShouldTransition(int i)
	{
		USkeletalMeshComponent owningComponent = GetOwningComponent();
		GetOwningActor().GetRootComponent();
		FVector safeNormal = Owner.GetVelocity().GetSafeNormal();
		FVector fVector = ((!safeNormal.IsZero()) ? safeNormal : Owner.GetActorForwardVector());
		FName inSocketName = new FName("VB root_" + LegNames[i].ToString());
		FTransform worldTransform = owningComponent.GetWorldTransform();
		FVector fVector2 = (LegInitBoneCS[i] * worldTransform).GetLocation() + worldTransform.GetScale3D() * (fVector * LegForwardDistance[i]);
		bool flag = GSGameplayCVar.CVar_SpiderDrawTarget.GetValueInGameThread() == 1;
		FVector fVector3 = worldTransform.TransformDirection(-FVector.UpVector);
		USystemLibrary.LineTraceSingleByProfile(this, fVector2 + fVector3 * (0f - StandardUnit) * worldTransform.Scale3D.GetMax() * RelativeScale, fVector2 + fVector3 * StandardUnit * RelativeScale, B1GlobalFNames.Pawn, bTraceComplex: true, null, flag ? EDrawDebugTrace.ForOneFrame : EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, new FLinearColor(1f, 0f, 0f), new FLinearColor(1f, 0f, 0f), 2f);
		if (OutHit.BlockingHit)
		{
			LegCurTargetWS[i] = new FVector(OutHit.Location.X, OutHit.Location.Y, OutHit.Location.Z);
		}
		else
		{
			LegCurTargetWS[i] = fVector2;
		}
		LegCurTargetWS[i] += new FVector(0.0, 0.0, (owningComponent.GetSocketTransform(inSocketName) * owningComponent.GetWorldTransform().Inverse()).GetLocation().Z);
		if (!IsMovingLeg[i])
		{
			float num = FVector.Dist(LegLastTargetWS[i], LegCurTargetWS[i]);
			bool flag2 = bShouldLeftMove == IsLeftGroup(i) || safeNormal.IsZero();
			if ((double)num > worldTransform.GetMaximumAxisScale() * (double)LegMoveDistance[i] && !IsMovingLeg[(i + 4) % 8] && flag2)
			{
				IsMovingLeg[i] = true;
				return true;
			}
		}
		else if (LegRatio[i] == 1f)
		{
			IsMovingLeg[i] = false;
			return true;
		}
		return false;
	}

	public void DoTransition(int i)
	{
		bool flag = GSGameplayCVar.CVar_SpiderDrawTarget.GetValueInGameThread() == 1;
		if (IsMovingLeg[i])
		{
			float maxWalkSpeed = ((Owner as ACharacter).GetMovementComponent() as UCharacterMovementComponent).MaxWalkSpeed;
			FTransform worldTransform = GetOwningComponent().GetWorldTransform();
			LegMoveSpeed[i] = 1f / (LegForwardDistance[i] * (float)worldTransform.GetMaximumAxisScale() / maxWalkSpeed);
			LegTargetWS[i] = LegCurTargetWS[i];
			LegRecordTargetCS[i] = (new FTransform(LegCurTargetWS[i]) * worldTransform.Inverse()).GetLocation();
			if (flag)
			{
				USystemLibrary.DrawDebugSphere(Owner, LegCurTargetWS[i], 5f, 12, FLinearColor.White, 1f, 0f);
			}
			LegRatio[i] = 0f;
		}
		else
		{
			bShouldLeftMove = !IsLeftGroup(i);
			LegLastTargetWS[i] = LegCurTargetWS[i];
			if (flag)
			{
				USystemLibrary.DrawDebugSphere(Owner, LegLastTargetWS[i], 5f, 12, FLinearColor.Red, 1f, 0f);
			}
			LegRatio[i] = 0f;
		}
	}

	public void DoState(int i)
	{
		FTransform worldTransform = Mesh.GetWorldTransform();
		if (IsMovingLeg[i])
		{
			float num = 0.5f * StandardUnit;
			float num2 = FMath.Sin(LegRatio[i] * (float)Math.PI) * num * RelativeScale;
			LegTargetCS[i] = LegRecordTargetCS[i] + new FVector(0.0, 0.0, num2);
			LegRatio[i] = FMath.FInterpConstantTo(LegRatio[i], 1f, GetDeltaSeconds(), LegMoveSpeed[i]);
		}
		else if (Owner.GetVelocity().IsZero())
		{
			LegTargetWS[i] = LegCurTargetWS[i];
			LegLastTargetWS[i] = LegCurTargetWS[i];
		}
		else
		{
			LegTargetCS[i] = (new FTransform(LegTargetWS[i]) * worldTransform.Inverse()).GetLocation();
		}
		LegLastTargetCS[i] = (new FTransform(LegLastTargetWS[i]) * worldTransform.Inverse()).GetLocation();
	}

	private void AttachEvent()
	{
		BUC_ABPEventCollection.Get(this);
	}

	private void UnAttachEvent()
	{
		BUC_ABPEventCollection.Get(this);
	}

	private void InitData()
	{
		SimpleJumpData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleJumpData, BUC_SimpleJumpData>(Owner);
		AINodeData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AINodeData, BUC_AINodeData>(Owner);
		PoseSnapshotData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPPoseSnapshotData, BUC_ABPPoseSnapshotData>(Owner);
	}

	public void OnEntityInitFinish()
	{
		AttachEvent();
		InitData();
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
		UnAttachEvent();
	}

	static BGAnimSpider()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BGAnimSpider)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BGAnimSpider));
		StandardUnit = 5f;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGAnimSpider:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BGAnimSpider bGAnimSpider = GCHelper.Find<b1.BGU.BUAnim.BGAnimSpider>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaSeconds_Offset));
		bGAnimSpider.BlueprintUpdateAnimation_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGAnimSpider:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BGAnimSpider bGAnimSpider = GCHelper.Find<b1.BGU.BUAnim.BGAnimSpider>(obj);
		bGAnimSpider.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGAnimSpider");
		ABPSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPSetting");
		ABPSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPSetting", Classes.FObjectProperty);
		DefaultIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultIdle");
		DefaultIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultIdle", Classes.FObjectProperty);
		JumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpStart");
		JumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpStart", Classes.FObjectProperty);
		JumpLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpLoop");
		JumpLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpLoop", Classes.FObjectProperty);
		JumpEndLight_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpEndLight");
		JumpEndLight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpEndLight", Classes.FObjectProperty);
		JumpEndHeavy_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpEndHeavy");
		JumpEndHeavy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpEndHeavy", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bUseJumpEndLight_PropertyAddress, intPtr, "bUseJumpEndLight");
		bUseJumpEndLight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseJumpEndLight");
		bUseJumpEndLight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseJumpEndLight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LegTargetCS_PropertyAddress, intPtr, "LegTargetCS");
		LegTargetCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegTargetCS");
		LegTargetCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegTargetCS", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegRecordTargetCS_PropertyAddress, intPtr, "LegRecordTargetCS");
		LegRecordTargetCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegRecordTargetCS");
		LegRecordTargetCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegRecordTargetCS", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegLastTargetCS_PropertyAddress, intPtr, "LegLastTargetCS");
		LegLastTargetCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegLastTargetCS");
		LegLastTargetCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegLastTargetCS", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegRatio_PropertyAddress, intPtr, "LegRatio");
		LegRatio_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegRatio");
		LegRatio_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegRatio", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegCurTargetWS_PropertyAddress, intPtr, "LegCurTargetWS");
		LegCurTargetWS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegCurTargetWS");
		LegCurTargetWS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegCurTargetWS", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegLastTargetWS_PropertyAddress, intPtr, "LegLastTargetWS");
		LegLastTargetWS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegLastTargetWS");
		LegLastTargetWS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegLastTargetWS", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegTargetWS_PropertyAddress, intPtr, "LegTargetWS");
		LegTargetWS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegTargetWS");
		LegTargetWS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegTargetWS", Classes.FArrayProperty);
		SpineTargetRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpineTargetRot");
		SpineTargetRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpineTargetRot", Classes.FStructProperty);
		SpineLerpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpineLerpSpeed");
		SpineLerpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpineLerpSpeed", Classes.FFloatProperty);
		SpineCurRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpineCurRot");
		SpineCurRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpineCurRot", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bIsOnPlatform_PropertyAddress, intPtr, "bIsOnPlatform");
		bIsOnPlatform_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsOnPlatform");
		bIsOnPlatform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsOnPlatform", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIsFalling_PropertyAddress, intPtr, "bIsFalling");
		bIsFalling_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsFalling");
		bIsFalling_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsFalling", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStartJump_PropertyAddress, intPtr, "bStartJump");
		bStartJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStartJump");
		bStartJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStartJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIsAISpiderMove_PropertyAddress, intPtr, "bIsAISpiderMove");
		bIsAISpiderMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsAISpiderMove");
		bIsAISpiderMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsAISpiderMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUsePoseOverride_PropertyAddress, intPtr, "bUsePoseOverride");
		bUsePoseOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUsePoseOverride");
		bUsePoseOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUsePoseOverride", Classes.FBoolProperty);
		PoseSnapshot_Offset = NativeReflection.GetPropertyOffset(intPtr, "PoseSnapshot");
		PoseSnapshot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PoseSnapshot", Classes.FStructProperty);
		EnableSnapshotBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableSnapshotBlendTime");
		EnableSnapshotBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableSnapshotBlendTime", Classes.FFloatProperty);
		DisableSnapshotBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableSnapshotBlendTime");
		DisableSnapshotBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableSnapshotBlendTime", Classes.FFloatProperty);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaSeconds");
		BlueprintUpdateAnimation_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGAnimSpider:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGAnimSpider:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}
}
