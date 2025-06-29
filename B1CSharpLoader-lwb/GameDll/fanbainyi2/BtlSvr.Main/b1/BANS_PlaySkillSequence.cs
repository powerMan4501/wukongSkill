using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Play Skill Sequence")]
[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence")]
internal class BANS_PlaySkillSequence : BANS_GSBase
{
	private static bool SequenceList_IsValid;

	private static int SequenceList_Offset;

	private static FFieldAddress SequenceList_PropertyAddress;

	private TArrayReadWriteMarshaler<FLevelSequenceConfig> SequenceList_Marshaler;

	private static bool RotationType_IsValid;

	private static int RotationType_Offset;

	private static FFieldAddress RotationType_PropertyAddress;

	private static bool bAttachToUnit_IsValid;

	private static int bAttachToUnit_Offset;

	private static FFieldAddress bAttachToUnit_PropertyAddress;

	private static bool DummyMeshAttachSocketName_IsValid;

	private static int DummyMeshAttachSocketName_Offset;

	private static bool ExtraCameraForSeqBindTag_IsValid;

	private static int ExtraCameraForSeqBindTag_Offset;

	private static bool bMoveCameraSpringArmRotToNearestAfterAS_IsValid;

	private static int bMoveCameraSpringArmRotToNearestAfterAS_Offset;

	private static FFieldAddress bMoveCameraSpringArmRotToNearestAfterAS_PropertyAddress;

	private static bool TeleportAngleDeg_IsValid;

	private static int TeleportAngleDeg_Offset;

	private static bool bInCameraBlendTimeUseNotifyStateLength_IsValid;

	private static int bInCameraBlendTimeUseNotifyStateLength_Offset;

	private static FFieldAddress bInCameraBlendTimeUseNotifyStateLength_PropertyAddress;

	private static bool InCameraBlendTime_IsValid;

	private static int InCameraBlendTime_Offset;

	private static bool InCameraBlendFactor_IsValid;

	private static int InCameraBlendFactor_Offset;

	private static bool bEnableCameraAutoBlendOut_IsValid;

	private static int bEnableCameraAutoBlendOut_Offset;

	private static FFieldAddress bEnableCameraAutoBlendOut_PropertyAddress;

	private static bool OutCameraBlendTime_IsValid;

	private static int OutCameraBlendTime_Offset;

	private static bool OutCameraBlendFactor_IsValid;

	private static int OutCameraBlendFactor_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[Category("Skill Sequence")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头列表")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:SequenceList")]
	public TArrayReadWrite<FLevelSequenceConfig> SequenceList
	{
		get
		{
			CheckDestroyed();
			if (!SequenceList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:SequenceList");
				return null;
			}
			if (SequenceList_Marshaler == null)
			{
				SequenceList_Marshaler = new TArrayReadWriteMarshaler<FLevelSequenceConfig>(1, SequenceList_PropertyAddress, CachedMarshalingDelegates<FLevelSequenceConfig, FLevelSequenceConfig>.FromNative, CachedMarshalingDelegates<FLevelSequenceConfig, FLevelSequenceConfig>.ToNative);
			}
			return SequenceList_Marshaler.FromNative(IntPtr.Add(base.Address, SequenceList_Offset));
		}
	}

	[Category("Skill Sequence")]
	[BlueprintReadWrite]
	[DisplayName("镜头旋转参考类型")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:RotationType")]
	public ESkillCameraRotationType RotationType
	{
		get
		{
			CheckDestroyed();
			if (!RotationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:RotationType");
				return ESkillCameraRotationType.UseUnitRotation;
			}
			return EnumMarshaler<ESkillCameraRotationType>.FromNative(IntPtr.Add(base.Address, RotationType_Offset), 0, RotationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:RotationType");
			}
			else
			{
				EnumMarshaler<ESkillCameraRotationType>.ToNative(IntPtr.Add(base.Address, RotationType_Offset), 0, RotationType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Skill Sequence")]
	[BlueprintReadWrite]
	[DisplayName("镜头附加到Unit上")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:bAttachToUnit")]
	public bool bAttachToUnit
	{
		get
		{
			CheckDestroyed();
			if (!bAttachToUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bAttachToUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAttachToUnit_Offset), 0, bAttachToUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAttachToUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bAttachToUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAttachToUnit_Offset), 0, bAttachToUnit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头附加到的IBM插槽名")]
	[UMeta(MDProp.EditCondition, "bAttachToUnit")]
	[Tooltip("当这个非None且未配置任何sequence时，ibm相机持续时间 = 该notify时长-OutCameraBlendTime")]
	[Category("Skill Sequence")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:DummyMeshAttachSocketName")]
	public FName DummyMeshAttachSocketName
	{
		get
		{
			CheckDestroyed();
			if (!DummyMeshAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:DummyMeshAttachSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DummyMeshAttachSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummyMeshAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:DummyMeshAttachSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DummyMeshAttachSocketName_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bAttachToUnit")]
	[Category("Skill Sequence")]
	[EditAnywhere]
	[DisplayName("附加镜头绑定Sequence Tag")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("用于抓投附加镜头，该tag需与Sequence里加的tag一致")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:ExtraCameraForSeqBindTag")]
	public FName ExtraCameraForSeqBindTag
	{
		get
		{
			CheckDestroyed();
			if (!ExtraCameraForSeqBindTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:ExtraCameraForSeqBindTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ExtraCameraForSeqBindTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtraCameraForSeqBindTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:ExtraCameraForSeqBindTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ExtraCameraForSeqBindTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("抓投结束是否将相机旋转至最近")]
	[UMeta(MDProp.EditCondition, "bAttachToUnit")]
	[Category("Skill Sequence")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:bMoveCameraSpringArmRotToNearestAfterAS")]
	public bool bMoveCameraSpringArmRotToNearestAfterAS
	{
		get
		{
			CheckDestroyed();
			if (!bMoveCameraSpringArmRotToNearestAfterAS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bMoveCameraSpringArmRotToNearestAfterAS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMoveCameraSpringArmRotToNearestAfterAS_Offset), 0, bMoveCameraSpringArmRotToNearestAfterAS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMoveCameraSpringArmRotToNearestAfterAS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bMoveCameraSpringArmRotToNearestAfterAS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMoveCameraSpringArmRotToNearestAfterAS_Offset), 0, bMoveCameraSpringArmRotToNearestAfterAS_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Skill Sequence")]
	[Tooltip("如果选择的最近的镜头Blend过去旋转的角度超过这个值，就会瞬切镜头")]
	[DisplayName("镜头瞬切阈值(角度）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:TeleportAngleDeg")]
	public float TeleportAngleDeg
	{
		get
		{
			CheckDestroyed();
			if (!TeleportAngleDeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:TeleportAngleDeg");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TeleportAngleDeg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportAngleDeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:TeleportAngleDeg");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TeleportAngleDeg_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Blend In时间使用Notify时长")]
	[Tooltip("与Blend In时间互斥")]
	[Category("Skill Sequence")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:bInCameraBlendTimeUseNotifyStateLength")]
	public bool bInCameraBlendTimeUseNotifyStateLength
	{
		get
		{
			CheckDestroyed();
			if (!bInCameraBlendTimeUseNotifyStateLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bInCameraBlendTimeUseNotifyStateLength");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bInCameraBlendTimeUseNotifyStateLength_Offset), 0, bInCameraBlendTimeUseNotifyStateLength_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bInCameraBlendTimeUseNotifyStateLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bInCameraBlendTimeUseNotifyStateLength");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bInCameraBlendTimeUseNotifyStateLength_Offset), 0, bInCameraBlendTimeUseNotifyStateLength_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Skill Sequence")]
	[UMeta(MDProp.EditCondition, "!bInCameraBlendTimeUseNotifyStateLength")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend In时间")]
	[Tooltip("与上面的勾选互斥")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:InCameraBlendTime")]
	public float InCameraBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:InCameraBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:InCameraBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraBlendTime_Offset), value);
			}
		}
	}

	[DisplayName("Blend In加速系数")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Skill Sequence")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:InCameraBlendFactor")]
	public float InCameraBlendFactor
	{
		get
		{
			CheckDestroyed();
			if (!InCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:InCameraBlendFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InCameraBlendFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:InCameraBlendFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InCameraBlendFactor_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Skill Sequence")]
	[EditAnywhere]
	[DisplayName("是否自动Blend Out相机")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:bEnableCameraAutoBlendOut")]
	public bool bEnableCameraAutoBlendOut
	{
		get
		{
			CheckDestroyed();
			if (!bEnableCameraAutoBlendOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bEnableCameraAutoBlendOut");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableCameraAutoBlendOut_Offset), 0, bEnableCameraAutoBlendOut_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableCameraAutoBlendOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:bEnableCameraAutoBlendOut");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableCameraAutoBlendOut_Offset), 0, bEnableCameraAutoBlendOut_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend Out时间")]
	[Category("Skill Sequence")]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:OutCameraBlendTime")]
	public float OutCameraBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!OutCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:OutCameraBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutCameraBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutCameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:OutCameraBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutCameraBlendTime_Offset), value);
			}
		}
	}

	[DisplayName("Blend Out加速系数")]
	[Category("Skill Sequence")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:OutCameraBlendFactor")]
	public float OutCameraBlendFactor
	{
		get
		{
			CheckDestroyed();
			if (!OutCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:OutCameraBlendFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutCameraBlendFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutCameraBlendFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlaySkillSequence:OutCameraBlendFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutCameraBlendFactor_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bInCameraBlendTimeUseNotifyStateLength = false;
		InCameraBlendFactor = 1.5f;
		InCameraBlendTime = 1f;
		bEnableCameraAutoBlendOut = true;
		OutCameraBlendFactor = 1.5f;
		OutCameraBlendTime = 1f;
		RotationType = ESkillCameraRotationType.UseUnitRotation;
		TeleportAngleDeg = 180f;
		bAttachToUnit = false;
		bMoveCameraSpringArmRotToNearestAfterAS = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		List<FSoftObjectPath> list = new List<FSoftObjectPath>();
		foreach (FLevelSequenceConfig sequence2 in SequenceList)
		{
			TSoftObject<ULevelSequence> sequence = sequence2.Sequence;
			if (!sequence.IsNull)
			{
				sequence = sequence2.Sequence;
				list.Add(sequence.ObjectPath);
			}
		}
		return list;
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		foreach (FLevelSequenceConfig sequence2 in SequenceList)
		{
			TSoftObject<ULevelSequence> sequence = sequence2.Sequence;
			if (!sequence.IsNull)
			{
				HashSet<FSoftObjectPath> obj = SoftPathSet;
				sequence = sequence2.Sequence;
				obj.Add(sequence.ObjectPath);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_PlaySkillSequence:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner.World))
		{
			return;
		}
		float inCameraBlendTime = InCameraBlendTime;
		if (bInCameraBlendTimeUseNotifyStateLength)
		{
			inCameraBlendTime = TotalDuration;
		}
		FSkillSequencePlaySettings playSettings = new FSkillSequencePlaySettings
		{
			SequenceList = new List<ULevelSequence>(),
			SequenceCameraTransforms = new List<FTransform>(),
			RotationType = RotationType,
			bAttachToUnit = bAttachToUnit,
			DummyMeshAttachSocketName = DummyMeshAttachSocketName,
			ExtraCameraForSeqBindTag = ExtraCameraForSeqBindTag,
			TeleportAngleDeg = TeleportAngleDeg,
			InCameraBlendTime = inCameraBlendTime,
			InCameraBlendFactor = InCameraBlendFactor,
			bEnableCameraAutoBlendOut = bEnableCameraAutoBlendOut,
			bStopWhenMontageInterrupted = true,
			OutCameraBlendTime = OutCameraBlendTime,
			OutCameraBlendFactor = OutCameraBlendFactor,
			TotalDuration = TotalDuration
		};
		foreach (FLevelSequenceConfig sequence2 in SequenceList)
		{
			TSoftObject<ULevelSequence> sequence = sequence2.Sequence;
			ULevelSequence uLevelSequence = sequence.Value;
			if (uLevelSequence == null)
			{
				BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(owner);
				sequence = sequence2.Sequence;
				uLevelSequence = bGW_PreloadAssetMgr.TryGetCachedResourceObj<ULevelSequence>(sequence.AssetPathName, ELoadResourceType.SyncLoadAndCache);
			}
			playSettings.SequenceList.Add(uLevelSequence);
			playSettings.SequenceCameraTransforms.Add(sequence2.CameraStartTransform);
		}
		BUS_EventCollectionCS.Get(owner)?.Evt_PlaySkillSequence.Invoke(playSettings);
		BGS_EventCollectionCS.Get(owner)?.Evt_BGS_SetMoveCameraSpringArmRotToNearestAfterAS.Invoke(bMoveCameraSpringArmRotToNearestAfterAS);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlaySkillSequence:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlaySkillSequence bANS_PlaySkillSequence = GCHelper.Find<b1.BANS_PlaySkillSequence>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_PlaySkillSequence.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlaySkillSequence:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlaySkillSequence bANS_PlaySkillSequence = GCHelper.Find<b1.BANS_PlaySkillSequence>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bANS_PlaySkillSequence.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_PlaySkillSequence");
		NativeReflection.GetPropertyRef(ref SequenceList_PropertyAddress, intPtr, "SequenceList");
		SequenceList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceList");
		SequenceList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RotationType_PropertyAddress, intPtr, "RotationType");
		RotationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationType");
		RotationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bAttachToUnit_PropertyAddress, intPtr, "bAttachToUnit");
		bAttachToUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAttachToUnit");
		bAttachToUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAttachToUnit", Classes.FBoolProperty);
		DummyMeshAttachSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DummyMeshAttachSocketName");
		DummyMeshAttachSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DummyMeshAttachSocketName", Classes.FNameProperty);
		ExtraCameraForSeqBindTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraCameraForSeqBindTag");
		ExtraCameraForSeqBindTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraCameraForSeqBindTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bMoveCameraSpringArmRotToNearestAfterAS_PropertyAddress, intPtr, "bMoveCameraSpringArmRotToNearestAfterAS");
		bMoveCameraSpringArmRotToNearestAfterAS_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMoveCameraSpringArmRotToNearestAfterAS");
		bMoveCameraSpringArmRotToNearestAfterAS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMoveCameraSpringArmRotToNearestAfterAS", Classes.FBoolProperty);
		TeleportAngleDeg_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportAngleDeg");
		TeleportAngleDeg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportAngleDeg", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bInCameraBlendTimeUseNotifyStateLength_PropertyAddress, intPtr, "bInCameraBlendTimeUseNotifyStateLength");
		bInCameraBlendTimeUseNotifyStateLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInCameraBlendTimeUseNotifyStateLength");
		bInCameraBlendTimeUseNotifyStateLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInCameraBlendTimeUseNotifyStateLength", Classes.FBoolProperty);
		InCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendTime");
		InCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendTime", Classes.FFloatProperty);
		InCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFactor");
		InCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFactor", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableCameraAutoBlendOut_PropertyAddress, intPtr, "bEnableCameraAutoBlendOut");
		bEnableCameraAutoBlendOut_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableCameraAutoBlendOut");
		bEnableCameraAutoBlendOut_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableCameraAutoBlendOut", Classes.FBoolProperty);
		OutCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OutCameraBlendTime");
		OutCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OutCameraBlendTime", Classes.FFloatProperty);
		OutCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "OutCameraBlendFactor");
		OutCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OutCameraBlendFactor", Classes.FFloatProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlaySkillSequence:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlaySkillSequence:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BANS_PlaySkillSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_PlaySkillSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_PlaySkillSequence));
	}
}
