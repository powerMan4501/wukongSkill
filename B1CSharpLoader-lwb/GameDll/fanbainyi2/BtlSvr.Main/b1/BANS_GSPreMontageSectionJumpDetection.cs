using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Pre Montage Section Jump Detection")]
[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection")]
internal class BANS_GSPreMontageSectionJumpDetection : BANS_GSBase
{
	private static bool OverlayDetectTargetType_IsValid;

	private static int OverlayDetectTargetType_Offset;

	private static FFieldAddress OverlayDetectTargetType_PropertyAddress;

	private static bool SectionJumpType_IsValid;

	private static int SectionJumpType_Offset;

	private static FFieldAddress SectionJumpType_PropertyAddress;

	private static bool IgnoreSimplateState_IsValid;

	private static int IgnoreSimplateState_Offset;

	private static FFieldAddress IgnoreSimplateState_PropertyAddress;

	private static bool BuffsToAddWhenSectionJumpApproved_IsValid;

	private static int BuffsToAddWhenSectionJumpApproved_Offset;

	private static FFieldAddress BuffsToAddWhenSectionJumpApproved_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BuffsToAddWhenSectionJumpApproved_Marshaler;

	private static bool bForceSuccess_IsValid;

	private static int bForceSuccess_Offset;

	private static FFieldAddress bForceSuccess_PropertyAddress;

	private static bool DetectionCenterSocketName_IsValid;

	private static int DetectionCenterSocketName_Offset;

	private static bool DetectionRadius_IsValid;

	private static int DetectionRadius_Offset;

	private static bool AdditionalDetectionConfig_IsValid;

	private static int AdditionalDetectionConfig_Offset;

	private static FFieldAddress AdditionalDetectionConfig_PropertyAddress;

	private TMapReadWriteMarshaler<FName, float> AdditionalDetectionConfig_Marshaler;

	private static bool DetectOnlyAtStart_IsValid;

	private static int DetectOnlyAtStart_Offset;

	private static FFieldAddress DetectOnlyAtStart_PropertyAddress;

	private static bool bEnableDebugDraw_IsValid;

	private static int bEnableDebugDraw_Offset;

	private static FFieldAddress bEnableDebugDraw_PropertyAddress;

	private static bool AnimationSyncMontage_IsValid;

	private static int AnimationSyncMontage_Offset;

	private static bool bReversePreDetectionResult_IsValid;

	private static int bReversePreDetectionResult_Offset;

	private static FFieldAddress bReversePreDetectionResult_PropertyAddress;

	private static bool bJumpImmediately_IsValid;

	private static int bJumpImmediately_Offset;

	private static FFieldAddress bJumpImmediately_PropertyAddress;

	private static bool JumpToSectionName_IsValid;

	private static int JumpToSectionName_Offset;

	private static bool JumpableSectionPrefix_IsValid;

	private static int JumpableSectionPrefix_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GetJumpableSectionPrefix_IsValid;

	private static IntPtr GetJumpableSectionPrefix_FunctionAddress;

	private static int GetJumpableSectionPrefix_ParamsSize;

	private static bool GetJumpableSectionPrefix_ReturnValue_IsValid;

	private static int GetJumpableSectionPrefix_ReturnValue_Offset;

	private static FFieldAddress GetJumpableSectionPrefix_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[Tooltip("【已废弃】")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:OverlayDetectTargetType")]
	public EChangeTargetType OverlayDetectTargetType
	{
		get
		{
			CheckDestroyed();
			if (!OverlayDetectTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:OverlayDetectTargetType");
				return EChangeTargetType.None;
			}
			return EnumMarshaler<EChangeTargetType>.FromNative(IntPtr.Add(base.Address, OverlayDetectTargetType_Offset), 0, OverlayDetectTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverlayDetectTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:OverlayDetectTargetType");
			}
			else
			{
				EnumMarshaler<EChangeTargetType>.ToNative(IntPtr.Add(base.Address, OverlayDetectTargetType_Offset), 0, OverlayDetectTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[Tooltip("【已废弃】")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:SectionJumpType")]
	public MontageSectionJumpType SectionJumpType
	{
		get
		{
			CheckDestroyed();
			if (!SectionJumpType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:SectionJumpType");
				return MontageSectionJumpType.None;
			}
			return EnumMarshaler<MontageSectionJumpType>.FromNative(IntPtr.Add(base.Address, SectionJumpType_Offset), 0, SectionJumpType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SectionJumpType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:SectionJumpType");
			}
			else
			{
				EnumMarshaler<MontageSectionJumpType>.ToNative(IntPtr.Add(base.Address, SectionJumpType_Offset), 0, SectionJumpType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Tooltip("【已废弃】如果该SimpleState存在，检测将不会触发；默认设为Max")]
	[Category("PreDetection")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:IgnoreSimplateState")]
	public EBGUSimpleState IgnoreSimplateState
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreSimplateState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:IgnoreSimplateState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, IgnoreSimplateState_Offset), 0, IgnoreSimplateState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreSimplateState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:IgnoreSimplateState");
			}
			else
			{
				EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(base.Address, IgnoreSimplateState_Offset), 0, IgnoreSimplateState_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[Tooltip("【已废弃】")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:BuffsToAddWhenSectionJumpApproved")]
	public TArrayReadWrite<int> BuffsToAddWhenSectionJumpApproved
	{
		get
		{
			CheckDestroyed();
			if (!BuffsToAddWhenSectionJumpApproved_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:BuffsToAddWhenSectionJumpApproved");
				return null;
			}
			if (BuffsToAddWhenSectionJumpApproved_Marshaler == null)
			{
				BuffsToAddWhenSectionJumpApproved_Marshaler = new TArrayReadWriteMarshaler<int>(1, BuffsToAddWhenSectionJumpApproved_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BuffsToAddWhenSectionJumpApproved_Marshaler.FromNative(IntPtr.Add(base.Address, BuffsToAddWhenSectionJumpApproved_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[Tooltip("强制抓投成功，不会跳转fail，适用于抓投之后接seq强表演类型")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bForceSuccess")]
	public bool bForceSuccess
	{
		get
		{
			CheckDestroyed();
			if (!bForceSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bForceSuccess");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bForceSuccess_Offset), 0, bForceSuccess_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bForceSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bForceSuccess");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bForceSuccess_Offset), 0, bForceSuccess_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!bForceSuccess")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectionCenterSocketName")]
	public FName DetectionCenterSocketName
	{
		get
		{
			CheckDestroyed();
			if (!DetectionCenterSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectionCenterSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DetectionCenterSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DetectionCenterSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectionCenterSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DetectionCenterSocketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!bForceSuccess")]
	[EditAnywhere]
	[UProperty]
	[Category("PreDetection")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectionRadius")]
	public float DetectionRadius
	{
		get
		{
			CheckDestroyed();
			if (!DetectionRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectionRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DetectionRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DetectionRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectionRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DetectionRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[Tooltip("Key为Socket名，Value为半径")]
	[UMeta(MDProp.EditCondition, "!bForceSuccess")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:AdditionalDetectionConfig")]
	public TMapReadWrite<FName, float> AdditionalDetectionConfig
	{
		get
		{
			CheckDestroyed();
			if (!AdditionalDetectionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:AdditionalDetectionConfig");
				return null;
			}
			if (AdditionalDetectionConfig_Marshaler == null)
			{
				AdditionalDetectionConfig_Marshaler = new TMapReadWriteMarshaler<FName, float>(1, AdditionalDetectionConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return AdditionalDetectionConfig_Marshaler.FromNative(IntPtr.Add(base.Address, AdditionalDetectionConfig_Offset));
		}
	}

	[Tooltip("【已废弃】只在Begin时候检测或者每帧检测")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("PreDetection")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectOnlyAtStart")]
	public bool DetectOnlyAtStart
	{
		get
		{
			CheckDestroyed();
			if (!DetectOnlyAtStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectOnlyAtStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DetectOnlyAtStart_Offset), 0, DetectOnlyAtStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetectOnlyAtStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:DetectOnlyAtStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DetectOnlyAtStart_Offset), 0, DetectOnlyAtStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("PreDetection")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!bForceSuccess")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bEnableDebugDraw")]
	public bool bEnableDebugDraw
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bEnableDebugDraw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebugDraw_Offset), 0, bEnableDebugDraw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bEnableDebugDraw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebugDraw_Offset), 0, bEnableDebugDraw_PropertyAddress.Address, value);
			}
		}
	}

	[Category("PreDetection")]
	[Tooltip("BANS_SyncAnimation所在的montage，用于抓投需要跳转montage的特殊情况（e.g. XGX）")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:AnimationSyncMontage")]
	public UAnimMontage AnimationSyncMontage
	{
		get
		{
			CheckDestroyed();
			if (!AnimationSyncMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:AnimationSyncMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AnimationSyncMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationSyncMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:AnimationSyncMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AnimationSyncMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("JumpSection")]
	[Tooltip("【已废弃】若为true，预检测结果不通过时跳转到指定Section；否则通过时跳转到指定Section")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bReversePreDetectionResult")]
	public bool bReversePreDetectionResult
	{
		get
		{
			CheckDestroyed();
			if (!bReversePreDetectionResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bReversePreDetectionResult");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bReversePreDetectionResult_Offset), 0, bReversePreDetectionResult_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bReversePreDetectionResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bReversePreDetectionResult");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bReversePreDetectionResult_Offset), 0, bReversePreDetectionResult_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("JumpSection")]
	[Tooltip("【已废弃】若为true，该Notify触发时立即跳转到指定Section；否则等待当前Section结束再跳转")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bJumpImmediately")]
	public bool bJumpImmediately
	{
		get
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bJumpImmediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:bJumpImmediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bForceSuccess")]
	[Tooltip("跳转到的Section名，若为None则不会发生跳转")]
	[Category("JumpSection")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:JumpToSectionName")]
	public FName JumpToSectionName
	{
		get
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:JumpToSectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, JumpToSectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:JumpToSectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, JumpToSectionName_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("所有可跳转的Section名的前缀")]
	[EditAnywhere]
	[Category("JumpSection")]
	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:JumpableSectionPrefix")]
	public string JumpableSectionPrefix
	{
		get
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:JumpableSectionPrefix");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:JumpableSectionPrefix");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		Dictionary<FName, float> dictionary = AdditionalDetectionConfig.ToDictionary();
		if (DetectionCenterSocketName != FName.None)
		{
			dictionary.Add(DetectionCenterSocketName, DetectionRadius);
		}
		BGS_GSEventCollection.Get(owner)?.Evt_BGS_BeginAnimationSyncPreCheck.Invoke(owner, bForceSuccess, dictionary, JumpToSectionName, bEnableDebugDraw, AnimationSyncMontage);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		BGS_GSEventCollection.Get(owner)?.Evt_BGS_EndAnimationSyncPreCheck.Invoke(owner);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.MontageJumpToSection;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GetJumpableSectionPrefix")]
	protected override string GetJumpableSectionPrefix_Implementation()
	{
		return JumpableSectionPrefix;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPreMontageSectionJumpDetection bANS_GSPreMontageSectionJumpDetection = GCHelper.Find<b1.BANS_GSPreMontageSectionJumpDetection>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSPreMontageSectionJumpDetection.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPreMontageSectionJumpDetection bANS_GSPreMontageSectionJumpDetection = GCHelper.Find<b1.BANS_GSPreMontageSectionJumpDetection>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSPreMontageSectionJumpDetection.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPreMontageSectionJumpDetection bANS_GSPreMontageSectionJumpDetection = GCHelper.Find<b1.BANS_GSPreMontageSectionJumpDetection>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSPreMontageSectionJumpDetection.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GetJumpableSectionPrefix")]
	private static void GetJumpableSectionPrefix__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPreMontageSectionJumpDetection bANS_GSPreMontageSectionJumpDetection = GCHelper.Find<b1.BANS_GSPreMontageSectionJumpDetection>(obj);
		string jumpableSectionPrefix_Implementation = bANS_GSPreMontageSectionJumpDetection.GetJumpableSectionPrefix_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetJumpableSectionPrefix_ReturnValue_Offset), jumpableSectionPrefix_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection");
		NativeReflection.GetPropertyRef(ref OverlayDetectTargetType_PropertyAddress, intPtr, "OverlayDetectTargetType");
		OverlayDetectTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlayDetectTargetType");
		OverlayDetectTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlayDetectTargetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SectionJumpType_PropertyAddress, intPtr, "SectionJumpType");
		SectionJumpType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectionJumpType");
		SectionJumpType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectionJumpType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IgnoreSimplateState_PropertyAddress, intPtr, "IgnoreSimplateState");
		IgnoreSimplateState_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreSimplateState");
		IgnoreSimplateState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreSimplateState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BuffsToAddWhenSectionJumpApproved_PropertyAddress, intPtr, "BuffsToAddWhenSectionJumpApproved");
		BuffsToAddWhenSectionJumpApproved_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffsToAddWhenSectionJumpApproved");
		BuffsToAddWhenSectionJumpApproved_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffsToAddWhenSectionJumpApproved", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bForceSuccess_PropertyAddress, intPtr, "bForceSuccess");
		bForceSuccess_Offset = NativeReflection.GetPropertyOffset(intPtr, "bForceSuccess");
		bForceSuccess_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bForceSuccess", Classes.FBoolProperty);
		DetectionCenterSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetectionCenterSocketName");
		DetectionCenterSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetectionCenterSocketName", Classes.FNameProperty);
		DetectionRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetectionRadius");
		DetectionRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetectionRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AdditionalDetectionConfig_PropertyAddress, intPtr, "AdditionalDetectionConfig");
		AdditionalDetectionConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdditionalDetectionConfig");
		AdditionalDetectionConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdditionalDetectionConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref DetectOnlyAtStart_PropertyAddress, intPtr, "DetectOnlyAtStart");
		DetectOnlyAtStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetectOnlyAtStart");
		DetectOnlyAtStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetectOnlyAtStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebugDraw_PropertyAddress, intPtr, "bEnableDebugDraw");
		bEnableDebugDraw_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableDebugDraw");
		bEnableDebugDraw_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableDebugDraw", Classes.FBoolProperty);
		AnimationSyncMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationSyncMontage");
		AnimationSyncMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationSyncMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bReversePreDetectionResult_PropertyAddress, intPtr, "bReversePreDetectionResult");
		bReversePreDetectionResult_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReversePreDetectionResult");
		bReversePreDetectionResult_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReversePreDetectionResult", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bJumpImmediately_PropertyAddress, intPtr, "bJumpImmediately");
		bJumpImmediately_Offset = NativeReflection.GetPropertyOffset(intPtr, "bJumpImmediately");
		bJumpImmediately_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bJumpImmediately", Classes.FBoolProperty);
		JumpToSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpToSectionName");
		JumpToSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpToSectionName", Classes.FNameProperty);
		JumpableSectionPrefix_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpableSectionPrefix");
		JumpableSectionPrefix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpableSectionPrefix", Classes.FStrProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GetJumpableSectionPrefix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetJumpableSectionPrefix");
		GetJumpableSectionPrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJumpableSectionPrefix_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetJumpableSectionPrefix_ReturnValue_PropertyAddress, GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetJumpableSectionPrefix_IsValid = GetJumpableSectionPrefix_FunctionAddress != IntPtr.Zero && GetJumpableSectionPrefix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPreMontageSectionJumpDetection:GetJumpableSectionPrefix", GetJumpableSectionPrefix_IsValid);
	}

	static BANS_GSPreMontageSectionJumpDetection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSPreMontageSectionJumpDetection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSPreMontageSectionJumpDetection));
	}
}
