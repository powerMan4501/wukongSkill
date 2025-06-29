using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig")]
public class BGWDataAsset_CricketInteractConfig : UBGWDataAsset
{
	private static bool CricketSocketName_IsValid;

	private static int CricketSocketName_Offset;

	private static bool DummyMeshSocketName_IsValid;

	private static int DummyMeshSocketName_Offset;

	private static bool CameraAttachSocketName1_IsValid;

	private static int CameraAttachSocketName1_Offset;

	private static bool CameraAttachSocketName2_IsValid;

	private static int CameraAttachSocketName2_Offset;

	private static bool CameraBlendInTime_IsValid;

	private static int CameraBlendInTime_Offset;

	private static bool CameraBlendOutTime_IsValid;

	private static int CameraBlendOutTime_Offset;

	private static bool FallDownCameraBlendOutTime_IsValid;

	private static int FallDownCameraBlendOutTime_Offset;

	private static bool AMCricketPrepareInteract_IsValid;

	private static int AMCricketPrepareInteract_Offset;

	private static bool AMPlayerPrepareInteract_IsValid;

	private static int AMPlayerPrepareInteract_Offset;

	private static bool AnimDummyMeshPrepareInteract_IsValid;

	private static int AnimDummyMeshPrepareInteract_Offset;

	private static bool JumpAnimConfig_IsValid;

	private static int JumpAnimConfig_Offset;

	private static FFieldAddress JumpAnimConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FCricketJumpPlayerAnimConfig> JumpAnimConfig_Marshaler;

	private static bool AMPlayerFinishInteract_IsValid;

	private static int AMPlayerFinishInteract_Offset;

	private static bool AnimDummyMeshFinishInteract_IsValid;

	private static int AnimDummyMeshFinishInteract_Offset;

	private static bool AMPlayerFallDown_IsValid;

	private static int AMPlayerFallDown_Offset;

	private static bool AMCricketPrepareInteractLoop_IsValid;

	private static int AMCricketPrepareInteractLoop_Offset;

	private static bool AMPlayerPrepareInteractLoop_IsValid;

	private static int AMPlayerPrepareInteractLoop_Offset;

	private static bool AnimDummyMeshPrepareInteractLoop_IsValid;

	private static int AnimDummyMeshPrepareInteractLoop_Offset;

	private static bool AMCricketPrepareInteractBreak_IsValid;

	private static int AMCricketPrepareInteractBreak_Offset;

	private static bool AMPlayerPrepareInteractBreak_IsValid;

	private static int AMPlayerPrepareInteractBreak_Offset;

	private static bool InteractFailCameraSequenceID_IsValid;

	private static int InteractFailCameraSequenceID_Offset;

	private static bool AMCricketInteractFail_IsValid;

	private static int AMCricketInteractFail_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CricketSocketName")]
	public string CricketSocketName
	{
		get
		{
			CheckDestroyed();
			if (!CricketSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CricketSocketName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CricketSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CricketSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CricketSocketName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CricketSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:DummyMeshSocketName")]
	public string DummyMeshSocketName
	{
		get
		{
			CheckDestroyed();
			if (!DummyMeshSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:DummyMeshSocketName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DummyMeshSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummyMeshSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:DummyMeshSocketName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DummyMeshSocketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraAttachSocketName1")]
	public string CameraAttachSocketName1
	{
		get
		{
			CheckDestroyed();
			if (!CameraAttachSocketName1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraAttachSocketName1");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CameraAttachSocketName1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraAttachSocketName1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraAttachSocketName1");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CameraAttachSocketName1_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraAttachSocketName2")]
	public string CameraAttachSocketName2
	{
		get
		{
			CheckDestroyed();
			if (!CameraAttachSocketName2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraAttachSocketName2");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CameraAttachSocketName2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraAttachSocketName2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraAttachSocketName2");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CameraAttachSocketName2_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraBlendInTime")]
	public float CameraBlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraBlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraBlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendInTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraBlendOutTime")]
	public float CameraBlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraBlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:CameraBlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendOutTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:FallDownCameraBlendOutTime")]
	public float FallDownCameraBlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!FallDownCameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:FallDownCameraBlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FallDownCameraBlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallDownCameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:FallDownCameraBlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FallDownCameraBlendOutTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteract")]
	public UAnimMontage AMCricketPrepareInteract
	{
		get
		{
			CheckDestroyed();
			if (!AMCricketPrepareInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteract");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMCricketPrepareInteract_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMCricketPrepareInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteract");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMCricketPrepareInteract_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteract")]
	public UAnimMontage AMPlayerPrepareInteract
	{
		get
		{
			CheckDestroyed();
			if (!AMPlayerPrepareInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteract");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMPlayerPrepareInteract_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMPlayerPrepareInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteract");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMPlayerPrepareInteract_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshPrepareInteract")]
	public UAnimationAsset AnimDummyMeshPrepareInteract
	{
		get
		{
			CheckDestroyed();
			if (!AnimDummyMeshPrepareInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshPrepareInteract");
				return null;
			}
			return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(base.Address, AnimDummyMeshPrepareInteract_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimDummyMeshPrepareInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshPrepareInteract");
			}
			else
			{
				UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(base.Address, AnimDummyMeshPrepareInteract_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:JumpAnimConfig")]
	public TArrayReadWrite<FCricketJumpPlayerAnimConfig> JumpAnimConfig
	{
		get
		{
			CheckDestroyed();
			if (!JumpAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:JumpAnimConfig");
				return null;
			}
			if (JumpAnimConfig_Marshaler == null)
			{
				JumpAnimConfig_Marshaler = new TArrayReadWriteMarshaler<FCricketJumpPlayerAnimConfig>(1, JumpAnimConfig_PropertyAddress, CachedMarshalingDelegates<FCricketJumpPlayerAnimConfig, FCricketJumpPlayerAnimConfig>.FromNative, CachedMarshalingDelegates<FCricketJumpPlayerAnimConfig, FCricketJumpPlayerAnimConfig>.ToNative);
			}
			return JumpAnimConfig_Marshaler.FromNative(IntPtr.Add(base.Address, JumpAnimConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerFinishInteract")]
	public UAnimMontage AMPlayerFinishInteract
	{
		get
		{
			CheckDestroyed();
			if (!AMPlayerFinishInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerFinishInteract");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMPlayerFinishInteract_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMPlayerFinishInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerFinishInteract");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMPlayerFinishInteract_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshFinishInteract")]
	public UAnimationAsset AnimDummyMeshFinishInteract
	{
		get
		{
			CheckDestroyed();
			if (!AnimDummyMeshFinishInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshFinishInteract");
				return null;
			}
			return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(base.Address, AnimDummyMeshFinishInteract_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimDummyMeshFinishInteract_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshFinishInteract");
			}
			else
			{
				UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(base.Address, AnimDummyMeshFinishInteract_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerFallDown")]
	public UAnimMontage AMPlayerFallDown
	{
		get
		{
			CheckDestroyed();
			if (!AMPlayerFallDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerFallDown");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMPlayerFallDown_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMPlayerFallDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerFallDown");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMPlayerFallDown_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteractLoop")]
	public UAnimMontage AMCricketPrepareInteractLoop
	{
		get
		{
			CheckDestroyed();
			if (!AMCricketPrepareInteractLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteractLoop");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMCricketPrepareInteractLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMCricketPrepareInteractLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteractLoop");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMCricketPrepareInteractLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteractLoop")]
	public UAnimMontage AMPlayerPrepareInteractLoop
	{
		get
		{
			CheckDestroyed();
			if (!AMPlayerPrepareInteractLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteractLoop");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMPlayerPrepareInteractLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMPlayerPrepareInteractLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteractLoop");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMPlayerPrepareInteractLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshPrepareInteractLoop")]
	public UAnimationAsset AnimDummyMeshPrepareInteractLoop
	{
		get
		{
			CheckDestroyed();
			if (!AnimDummyMeshPrepareInteractLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshPrepareInteractLoop");
				return null;
			}
			return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(base.Address, AnimDummyMeshPrepareInteractLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimDummyMeshPrepareInteractLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AnimDummyMeshPrepareInteractLoop");
			}
			else
			{
				UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(base.Address, AnimDummyMeshPrepareInteractLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteractBreak")]
	public UAnimMontage AMCricketPrepareInteractBreak
	{
		get
		{
			CheckDestroyed();
			if (!AMCricketPrepareInteractBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteractBreak");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMCricketPrepareInteractBreak_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMCricketPrepareInteractBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketPrepareInteractBreak");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMCricketPrepareInteractBreak_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteractBreak")]
	public UAnimMontage AMPlayerPrepareInteractBreak
	{
		get
		{
			CheckDestroyed();
			if (!AMPlayerPrepareInteractBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteractBreak");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMPlayerPrepareInteractBreak_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMPlayerPrepareInteractBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMPlayerPrepareInteractBreak");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMPlayerPrepareInteractBreak_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:InteractFailCameraSequenceID")]
	public int InteractFailCameraSequenceID
	{
		get
		{
			CheckDestroyed();
			if (!InteractFailCameraSequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:InteractFailCameraSequenceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteractFailCameraSequenceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractFailCameraSequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:InteractFailCameraSequenceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteractFailCameraSequenceID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketInteractFail")]
	public UAnimMontage AMCricketInteractFail
	{
		get
		{
			CheckDestroyed();
			if (!AMCricketInteractFail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketInteractFail");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMCricketInteractFail_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMCricketInteractFail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig:AMCricketInteractFail");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMCricketInteractFail_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_CricketInteractConfig");
		CricketSocketName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketSocketName");
		CricketSocketName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketSocketName", Classes.FStrProperty);
		DummyMeshSocketName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DummyMeshSocketName");
		DummyMeshSocketName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DummyMeshSocketName", Classes.FStrProperty);
		CameraAttachSocketName1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraAttachSocketName1");
		CameraAttachSocketName1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraAttachSocketName1", Classes.FStrProperty);
		CameraAttachSocketName2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraAttachSocketName2");
		CameraAttachSocketName2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraAttachSocketName2", Classes.FStrProperty);
		CameraBlendInTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendInTime");
		CameraBlendInTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendInTime", Classes.FFloatProperty);
		CameraBlendOutTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendOutTime");
		CameraBlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendOutTime", Classes.FFloatProperty);
		FallDownCameraBlendOutTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FallDownCameraBlendOutTime");
		FallDownCameraBlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FallDownCameraBlendOutTime", Classes.FFloatProperty);
		AMCricketPrepareInteract_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMCricketPrepareInteract");
		AMCricketPrepareInteract_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMCricketPrepareInteract", Classes.FObjectProperty);
		AMPlayerPrepareInteract_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMPlayerPrepareInteract");
		AMPlayerPrepareInteract_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMPlayerPrepareInteract", Classes.FObjectProperty);
		AnimDummyMeshPrepareInteract_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimDummyMeshPrepareInteract");
		AnimDummyMeshPrepareInteract_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimDummyMeshPrepareInteract", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref JumpAnimConfig_PropertyAddress, unrealStruct, "JumpAnimConfig");
		JumpAnimConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JumpAnimConfig");
		JumpAnimConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JumpAnimConfig", Classes.FArrayProperty);
		AMPlayerFinishInteract_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMPlayerFinishInteract");
		AMPlayerFinishInteract_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMPlayerFinishInteract", Classes.FObjectProperty);
		AnimDummyMeshFinishInteract_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimDummyMeshFinishInteract");
		AnimDummyMeshFinishInteract_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimDummyMeshFinishInteract", Classes.FObjectProperty);
		AMPlayerFallDown_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMPlayerFallDown");
		AMPlayerFallDown_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMPlayerFallDown", Classes.FObjectProperty);
		AMCricketPrepareInteractLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMCricketPrepareInteractLoop");
		AMCricketPrepareInteractLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMCricketPrepareInteractLoop", Classes.FObjectProperty);
		AMPlayerPrepareInteractLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMPlayerPrepareInteractLoop");
		AMPlayerPrepareInteractLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMPlayerPrepareInteractLoop", Classes.FObjectProperty);
		AnimDummyMeshPrepareInteractLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimDummyMeshPrepareInteractLoop");
		AnimDummyMeshPrepareInteractLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimDummyMeshPrepareInteractLoop", Classes.FObjectProperty);
		AMCricketPrepareInteractBreak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMCricketPrepareInteractBreak");
		AMCricketPrepareInteractBreak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMCricketPrepareInteractBreak", Classes.FObjectProperty);
		AMPlayerPrepareInteractBreak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMPlayerPrepareInteractBreak");
		AMPlayerPrepareInteractBreak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMPlayerPrepareInteractBreak", Classes.FObjectProperty);
		InteractFailCameraSequenceID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractFailCameraSequenceID");
		InteractFailCameraSequenceID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractFailCameraSequenceID", Classes.FIntProperty);
		AMCricketInteractFail_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AMCricketInteractFail");
		AMCricketInteractFail_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AMCricketInteractFail", Classes.FObjectProperty);
	}

	static BGWDataAsset_CricketInteractConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_CricketInteractConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_CricketInteractConfig));
	}
}
