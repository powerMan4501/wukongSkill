using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("Observe Player")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition")]
public class BED_QuestNode_ObserveOnlineCondition : BED_QuestNode
{
	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool ObservedPlayerOrUnit_IsValid;

	private static int ObservedPlayerOrUnit_Offset;

	private static bool PlayerCount_IsValid;

	private static int PlayerCount_Offset;

	private static bool KillMonsterCount_IsValid;

	private static int KillMonsterCount_Offset;

	private static bool GainItemCount_IsValid;

	private static int GainItemCount_Offset;

	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	private static bool TraceDistance_IsValid;

	private static int TraceDistance_Offset;

	private static bool EventId_IsValid;

	private static int EventId_Offset;

	private static bool RandomCount_IsValid;

	private static int RandomCount_Offset;

	private static bool ObservedActor_IsValid;

	private static int ObservedActor_Offset;

	private static bool bPlayerAsObserveUnit_IsValid;

	private static int bPlayerAsObserveUnit_Offset;

	private static FFieldAddress bPlayerAsObserveUnit_PropertyAddress;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Observe Condition Config")]
	[Tooltip("监视条件")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ConditionType")]
	public EObserveOnlineConditionType ConditionType
	{
		get
		{
			CheckDestroyed();
			if (!ConditionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ConditionType");
				return EObserveOnlineConditionType.None;
			}
			return EnumMarshaler<EObserveOnlineConditionType>.FromNative(IntPtr.Add(base.Address, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConditionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ConditionType");
			}
			else
			{
				EnumMarshaler<EObserveOnlineConditionType>.ToNative(IntPtr.Add(base.Address, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("最大可触发次数，默认：1")]
	[Category("Observe Condition Config")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:SuccessLimit")]
	protected int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Observe Condition Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ObservedPlayerOrUnit")]
	public FGsSmartParam ObservedPlayerOrUnit
	{
		get
		{
			CheckDestroyed();
			if (!ObservedPlayerOrUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ObservedPlayerOrUnit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, ObservedPlayerOrUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedPlayerOrUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ObservedPlayerOrUnit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, ObservedPlayerOrUnit_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Observe Condition Config")]
	[Tooltip("限定玩家人数，默认：0")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:PlayerCount")]
	protected int PlayerCount
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:PlayerCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayerCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:PlayerCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayerCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Observe Condition Config")]
	[Tooltip("击杀怪物数量")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:KillMonsterCount")]
	protected int KillMonsterCount
	{
		get
		{
			CheckDestroyed();
			if (!KillMonsterCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:KillMonsterCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, KillMonsterCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KillMonsterCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:KillMonsterCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, KillMonsterCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Tooltip("累计获取道具数量")]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:GainItemCount")]
	protected int GainItemCount
	{
		get
		{
			CheckDestroyed();
			if (!GainItemCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:GainItemCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GainItemCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GainItemCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:GainItemCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GainItemCount_Offset), value);
			}
		}
	}

	[Tooltip("累计获取道具ID")]
	[UProperty]
	[EditDefaultsOnly]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ItemId")]
	protected int ItemId
	{
		get
		{
			CheckDestroyed();
			if (!ItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ItemId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ItemId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemId_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[UProperty]
	[Category("Observe Condition Config")]
	[Tooltip("距离踪迹的距离")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:TraceDistance")]
	protected int TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:TraceDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[Tooltip("事件ID")]
	[Category("Observe Condition Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:EventId")]
	protected int EventId
	{
		get
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:EventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:EventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventId_Offset), value);
			}
		}
	}

	[Tooltip("抽奖次数")]
	[Category("Observe Condition Config")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:RandomCount")]
	protected int RandomCount
	{
		get
		{
			CheckDestroyed();
			if (!RandomCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:RandomCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RandomCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:RandomCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RandomCount_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[Tooltip("与触发角色放在同一个关卡中，所以直接使用角色引用")]
	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ObservedActor")]
	public TSoftObject<BGUActorBaseCS> ObservedActor
	{
		get
		{
			CheckDestroyed();
			if (!ObservedActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ObservedActor");
				return default(TSoftObject<BGUActorBaseCS>);
			}
			return TSoftObjectMarshaler<BGUActorBaseCS>.FromNative(IntPtr.Add(base.Address, ObservedActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:ObservedActor");
			}
			else
			{
				TSoftObjectMarshaler<BGUActorBaseCS>.ToNative(IntPtr.Add(base.Address, ObservedActor_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Deprecated")]
	[DisplayName("选择玩家作为观察")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:bPlayerAsObserveUnit")]
	public bool bPlayerAsObserveUnit
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:bPlayerAsObserveUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:bPlayerAsObserveUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Notifies");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enable
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disable
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Completed
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
		SuccessLimit = 1;
		PlayerCount = 0;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("ConditionType"))
		{
			ForceRefreshDetailView();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObservedPlayerOrUnit.ConfigGuid), "ObservedPlayerOrUnit", out var OutDisplayName);
		return $"{OutDisplayName}\r\n{GetObserveConditionString()}\r\nSuccessLimit:{SuccessLimit}";
	}

	protected string GetObserveConditionString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(ConditionType.ToString());
		stringBuilder.Append(" ");
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_ObserveOnlineCondition questCustom_ObserveOnlineCondition = new QuestCustom_ObserveOnlineCondition();
		questCustom_ObserveOnlineCondition.ConditionType = (int)ConditionType;
		questCustom_ObserveOnlineCondition.SuccessLimit = SuccessLimit;
		if (ObservedPlayerOrUnit.ConfigGuid == Guid.Empty)
		{
			questCustom_ObserveOnlineCondition.ObserveActorGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObservedPlayerOrUnit.ConfigGuid), out var OutActorGuid);
			questCustom_ObserveOnlineCondition.ObserveActorGuid = OutActorGuid;
		}
		questCustom_ObserveOnlineCondition.PlayerCount = PlayerCount;
		questCustom_ObserveOnlineCondition.GainItemCount = GainItemCount;
		questCustom_ObserveOnlineCondition.KillMonsterCount = KillMonsterCount;
		questCustom_ObserveOnlineCondition.TraceDistance = TraceDistance;
		questCustom_ObserveOnlineCondition.ItemId = ItemId;
		questCustom_ObserveOnlineCondition.EventId = EventId;
		questCustom_ObserveOnlineCondition.RandomCount = RandomCount;
		return questCustom_ObserveOnlineCondition.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.ObserveOnlineCondition;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_ObserveOnlineCondition bED_QuestNode_ObserveOnlineCondition = GCHelper.Find<BED_QuestNode_ObserveOnlineCondition>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_QuestNode_ObserveOnlineCondition.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_ObserveOnlineCondition bED_QuestNode_ObserveOnlineCondition = GCHelper.Find<BED_QuestNode_ObserveOnlineCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_ObserveOnlineCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition");
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		ObservedPlayerOrUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedPlayerOrUnit");
		ObservedPlayerOrUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedPlayerOrUnit", Classes.FStructProperty);
		PlayerCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerCount");
		PlayerCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerCount", Classes.FIntProperty);
		KillMonsterCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "KillMonsterCount");
		KillMonsterCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KillMonsterCount", Classes.FIntProperty);
		GainItemCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "GainItemCount");
		GainItemCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GainItemCount", Classes.FIntProperty);
		ItemId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemId", Classes.FIntProperty);
		TraceDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceDistance");
		TraceDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceDistance", Classes.FIntProperty);
		EventId_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventId");
		EventId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventId", Classes.FIntProperty);
		RandomCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomCount");
		RandomCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomCount", Classes.FIntProperty);
		ObservedActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedActor");
		ObservedActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedActor", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsObserveUnit_PropertyAddress, intPtr, "bPlayerAsObserveUnit");
		bPlayerAsObserveUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsObserveUnit");
		bPlayerAsObserveUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsObserveUnit", Classes.FBoolProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_ObserveOnlineCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_ObserveOnlineCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_ObserveOnlineCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_ObserveOnlineCondition));
	}
}
