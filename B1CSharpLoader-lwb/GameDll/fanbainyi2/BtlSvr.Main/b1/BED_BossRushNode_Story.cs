using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("剧情动画 (Story)")]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story")]
public class BED_BossRushNode_Story : BED_BossRushNode_TemplateBase
{
	private static bool MatchPositionType_IsValid;

	private static int MatchPositionType_Offset;

	private static FFieldAddress MatchPositionType_PropertyAddress;

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	private static bool bWaitPlayFinish_IsValid;

	private static int bWaitPlayFinish_Offset;

	private static FFieldAddress bWaitPlayFinish_PropertyAddress;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	private static bool bGainItemWhenFinish_IsValid;

	private static int bGainItemWhenFinish_Offset;

	private static FFieldAddress bGainItemWhenFinish_PropertyAddress;

	private static bool GainItems_IsValid;

	private static int GainItems_Offset;

	private static FFieldAddress GainItems_PropertyAddress;

	private TArrayReadWriteMarshaler<FGainItemConfig> GainItems_Marshaler;

	private static bool bChapterEndStory_IsValid;

	private static int bChapterEndStory_Offset;

	private static FFieldAddress bChapterEndStory_PropertyAddress;

	private static bool ChapterID_IsValid;

	private static int ChapterID_Offset;

	private static bool bTriggerTransBack_IsValid;

	private static int bTriggerTransBack_Offset;

	private static FFieldAddress bTriggerTransBack_PropertyAddress;

	private static bool bTriggerMonsterGoHome_IsValid;

	private static int bTriggerMonsterGoHome_Offset;

	private static FFieldAddress bTriggerMonsterGoHome_PropertyAddress;

	private static bool bDisablePlayerControl_IsValid;

	private static int bDisablePlayerControl_Offset;

	private static FFieldAddress bDisablePlayerControl_PropertyAddress;

	private static bool bDisableMovementInput_IsValid;

	private static int bDisableMovementInput_Offset;

	private static FFieldAddress bDisableMovementInput_PropertyAddress;

	private static bool bDisableLookAtInput_IsValid;

	private static int bDisableLookAtInput_Offset;

	private static FFieldAddress bDisableLookAtInput_PropertyAddress;

	private static bool bHidePlayer_IsValid;

	private static int bHidePlayer_Offset;

	private static FFieldAddress bHidePlayer_PropertyAddress;

	private static bool bHideHud_IsValid;

	private static int bHideHud_Offset;

	private static FFieldAddress bHideHud_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[Category("BlendIn")]
	[DisplayName("对位类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:MatchPositionType")]
	public ESequenceBlendInMatchPositionType MatchPositionType
	{
		get
		{
			CheckDestroyed();
			if (!MatchPositionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:MatchPositionType");
				return ESequenceBlendInMatchPositionType.None;
			}
			return EnumMarshaler<ESequenceBlendInMatchPositionType>.FromNative(IntPtr.Add(base.Address, MatchPositionType_Offset), 0, MatchPositionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MatchPositionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:MatchPositionType");
			}
			else
			{
				EnumMarshaler<ESequenceBlendInMatchPositionType>.ToNative(IntPtr.Add(base.Address, MatchPositionType_Offset), 0, MatchPositionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BlendIn")]
	[DisplayName("异常判定盒")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:Overlap")]
	public FGsSmartParam Overlap
	{
		get
		{
			CheckDestroyed();
			if (!Overlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:Overlap");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Overlap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Overlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:Overlap");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Overlap_Offset), value);
			}
		}
	}

	[Category("Play")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否播放完成后跳转")]
	[Tooltip("不勾选播放后直接跳转，勾选等待播放完成跳转")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bWaitPlayFinish")]
	public bool bWaitPlayFinish
	{
		get
		{
			CheckDestroyed();
			if (!bWaitPlayFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bWaitPlayFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWaitPlayFinish_Offset), 0, bWaitPlayFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWaitPlayFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bWaitPlayFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWaitPlayFinish_Offset), 0, bWaitPlayFinish_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Play")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:Sequence")]
	public FGsSmartParam Sequence
	{
		get
		{
			CheckDestroyed();
			if (!Sequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:Sequence");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Sequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:Sequence");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Sequence_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Play")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:SequenceID")]
	public int SequenceID
	{
		get
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:SequenceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SequenceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:SequenceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SequenceID_Offset), value);
			}
		}
	}

	[DisplayName("结束后获得物品")]
	[Category("Play")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bGainItemWhenFinish")]
	public bool bGainItemWhenFinish
	{
		get
		{
			CheckDestroyed();
			if (!bGainItemWhenFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bGainItemWhenFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGainItemWhenFinish_Offset), 0, bGainItemWhenFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGainItemWhenFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bGainItemWhenFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGainItemWhenFinish_Offset), 0, bGainItemWhenFinish_PropertyAddress.Address, value);
			}
		}
	}

	[VisibleAnywhere]
	[Category("Play")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("获得的物品")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:GainItems")]
	public TArrayReadWrite<FGainItemConfig> GainItems
	{
		get
		{
			CheckDestroyed();
			if (!GainItems_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:GainItems");
				return null;
			}
			if (GainItems_Marshaler == null)
			{
				GainItems_Marshaler = new TArrayReadWriteMarshaler<FGainItemConfig>(1, GainItems_PropertyAddress, CachedMarshalingDelegates<FGainItemConfig, BlittableTypeMarshaler<FGainItemConfig>>.FromNative, CachedMarshalingDelegates<FGainItemConfig, BlittableTypeMarshaler<FGainItemConfig>>.ToNative);
			}
			return GainItems_Marshaler.FromNative(IntPtr.Add(base.Address, GainItems_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Play")]
	[DisplayName("是否章节结束的剧情")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bChapterEndStory")]
	public bool bChapterEndStory
	{
		get
		{
			CheckDestroyed();
			if (!bChapterEndStory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bChapterEndStory");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bChapterEndStory_Offset), 0, bChapterEndStory_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bChapterEndStory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bChapterEndStory");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bChapterEndStory_Offset), 0, bChapterEndStory_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bChapterEndStory")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Play")]
	[DisplayName("结束的章节ID")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:ChapterID")]
	public int ChapterID
	{
		get
		{
			CheckDestroyed();
			if (!ChapterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:ChapterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChapterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChapterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:ChapterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChapterID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("是否姿态回归")]
	[EditAnywhere]
	[UProperty]
	[Category("Play")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bTriggerTransBack")]
	public bool bTriggerTransBack
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerTransBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bTriggerTransBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerTransBack_Offset), 0, bTriggerTransBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerTransBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bTriggerTransBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerTransBack_Offset), 0, bTriggerTransBack_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否触发怪物回家")]
	[Category("Play")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bTriggerMonsterGoHome")]
	public bool bTriggerMonsterGoHome
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerMonsterGoHome_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bTriggerMonsterGoHome");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerMonsterGoHome_Offset), 0, bTriggerMonsterGoHome_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerMonsterGoHome_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bTriggerMonsterGoHome");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerMonsterGoHome_Offset), 0, bTriggerMonsterGoHome_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Camera")]
	[UProperty]
	[DisplayName("是否剥夺主角操作")]
	[Tooltip("不使用Sequence内的摄像机")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bDisablePlayerControl")]
	public bool bDisablePlayerControl
	{
		get
		{
			CheckDestroyed();
			if (!bDisablePlayerControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bDisablePlayerControl");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisablePlayerControl_Offset), 0, bDisablePlayerControl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisablePlayerControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bDisablePlayerControl");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisablePlayerControl_Offset), 0, bDisablePlayerControl_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bDisablePlayerControl")]
	[Category("Camera")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bDisableMovementInput")]
	public bool bDisableMovementInput
	{
		get
		{
			CheckDestroyed();
			if (!bDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bDisableMovementInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableMovementInput_Offset), 0, bDisableMovementInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bDisableMovementInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableMovementInput_Offset), 0, bDisableMovementInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "bDisablePlayerControl")]
	[Category("Camera")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bDisableLookAtInput")]
	public bool bDisableLookAtInput
	{
		get
		{
			CheckDestroyed();
			if (!bDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bDisableLookAtInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableLookAtInput_Offset), 0, bDisableLookAtInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bDisableLookAtInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableLookAtInput_Offset), 0, bDisableLookAtInput_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "bDisablePlayerControl")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bHidePlayer")]
	public bool bHidePlayer
	{
		get
		{
			CheckDestroyed();
			if (!bHidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bHidePlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHidePlayer_Offset), 0, bHidePlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bHidePlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHidePlayer_Offset), 0, bHidePlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "bDisablePlayerControl")]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:bHideHud")]
	public bool bHideHud
	{
		get
		{
			CheckDestroyed();
			if (!bHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bHideHud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHideHud_Offset), 0, bHideHud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_Story:bHideHud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHideHud_Offset), 0, bHideHud_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bWaitPlayFinish = true;
		bDisableMovementInput = true;
		bDisableLookAtInput = true;
		bHidePlayer = false;
		bHideHud = true;
		bTriggerTransBack = true;
		bTriggerMonsterGoHome = true;
		bDisablePlayerControl = true;
		base.SupportsContextPins = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BossRushNode.Story;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushNode_Story:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(bWaitPlayFinish ? "Sequence播放完成后跳转" : "Sequence开始播放后即跳转");
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		ProcessCustom_Story processCustom_Story = new ProcessCustom_Story();
		processCustom_Story.IsWaitPlayFinish = bWaitPlayFinish;
		processCustom_Story.SequenceId = Sequence.ConfigGuid.ToString();
		processCustom_Story.IsGainItemWhenFinish = bGainItemWhenFinish;
		foreach (FGainItemConfig gainItem in GainItems)
		{
			processCustom_Story.GainItems.Add(new CalliopeCustom_GainItem
			{
				ItemId = gainItem.ItemID,
				ItemCount = gainItem.ItemCount
			});
		}
		processCustom_Story.IsChapterEndStory = bChapterEndStory;
		processCustom_Story.ChapterId = ChapterID;
		processCustom_Story.IsTriggerTransback = bTriggerTransBack;
		processCustom_Story.IsTriggerMonsterGoHome = bTriggerMonsterGoHome;
		processCustom_Story.IsDisablePlayerControl = bDisablePlayerControl;
		processCustom_Story.IsDisableMovementInput = bDisableMovementInput;
		processCustom_Story.IsDisableLookAtInput = bDisableLookAtInput;
		processCustom_Story.IsHidePlayer = bHidePlayer;
		processCustom_Story.IsHideHud = bHideHud;
		processCustom_Story.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		processCustom_Story.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		processCustom_Story.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		processCustom_Story.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		processCustom_Story.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		processCustom_Story.MatchType = (int)MatchPositionType;
		processCustom_Story.MatchOverlapBox = Overlap.ConfigGuid.ToString();
		return processCustom_Story.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushNode_Story:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushNode_Story bED_BossRushNode_Story = GCHelper.Find<BED_BossRushNode_Story>(obj);
		string nodeDescriptionInCS_Implementation = bED_BossRushNode_Story.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushNode_Story");
		NativeReflection.GetPropertyRef(ref MatchPositionType_PropertyAddress, intPtr, "MatchPositionType");
		MatchPositionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchPositionType");
		MatchPositionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchPositionType", Classes.FEnumProperty);
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bWaitPlayFinish_PropertyAddress, intPtr, "bWaitPlayFinish");
		bWaitPlayFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWaitPlayFinish");
		bWaitPlayFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWaitPlayFinish", Classes.FBoolProperty);
		Sequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sequence", Classes.FStructProperty);
		SequenceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bGainItemWhenFinish_PropertyAddress, intPtr, "bGainItemWhenFinish");
		bGainItemWhenFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGainItemWhenFinish");
		bGainItemWhenFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGainItemWhenFinish", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GainItems_PropertyAddress, intPtr, "GainItems");
		GainItems_Offset = NativeReflection.GetPropertyOffset(intPtr, "GainItems");
		GainItems_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GainItems", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bChapterEndStory_PropertyAddress, intPtr, "bChapterEndStory");
		bChapterEndStory_Offset = NativeReflection.GetPropertyOffset(intPtr, "bChapterEndStory");
		bChapterEndStory_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bChapterEndStory", Classes.FBoolProperty);
		ChapterID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChapterID");
		ChapterID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChapterID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bTriggerTransBack_PropertyAddress, intPtr, "bTriggerTransBack");
		bTriggerTransBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerTransBack");
		bTriggerTransBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerTransBack", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bTriggerMonsterGoHome_PropertyAddress, intPtr, "bTriggerMonsterGoHome");
		bTriggerMonsterGoHome_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerMonsterGoHome");
		bTriggerMonsterGoHome_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerMonsterGoHome", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisablePlayerControl_PropertyAddress, intPtr, "bDisablePlayerControl");
		bDisablePlayerControl_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisablePlayerControl");
		bDisablePlayerControl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisablePlayerControl", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableMovementInput_PropertyAddress, intPtr, "bDisableMovementInput");
		bDisableMovementInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableMovementInput");
		bDisableMovementInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableMovementInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableLookAtInput_PropertyAddress, intPtr, "bDisableLookAtInput");
		bDisableLookAtInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableLookAtInput");
		bDisableLookAtInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableLookAtInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHidePlayer_PropertyAddress, intPtr, "bHidePlayer");
		bHidePlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHidePlayer");
		bHidePlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHidePlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHideHud_PropertyAddress, intPtr, "bHideHud");
		bHideHud_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHideHud");
		bHideHud_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHideHud", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushNode_Story:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BossRushNode_Story()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushNode_Story)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushNode_Story));
	}
}
