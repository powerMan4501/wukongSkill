using System;
using System.Text;
using b1.Plugins.Calliope;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Observe Actor")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition")]
public class BED_QuestNode_ObserveByCondition : BED_QuestNode
{
	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool ObservedPlayerOrUnitOrActor_IsValid;

	private static int ObservedPlayerOrUnitOrActor_Offset;

	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	private static bool Buff_IsValid;

	private static int Buff_Offset;

	private static bool ItemNumOnline_IsValid;

	private static int ItemNumOnline_Offset;

	private static bool Reversal_IsValid;

	private static int Reversal_Offset;

	private static FFieldAddress Reversal_PropertyAddress;

	private static bool ChallengeLevel_IsValid;

	private static int ChallengeLevel_Offset;

	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool ObservedActor_IsValid;

	private static int ObservedActor_Offset;

	private static bool ObservedUnit_IsValid;

	private static int ObservedUnit_Offset;

	private static bool ObservedActorGuid_IsValid;

	private static int ObservedActorGuid_Offset;

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

	[EditAnywhere]
	[UProperty]
	[Category("Observe Condition Config")]
	[Tooltip("监视条件")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ConditionType")]
	public EObserveConditionType ConditionType
	{
		get
		{
			CheckDestroyed();
			if (!ConditionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ConditionType");
				return EObserveConditionType.None;
			}
			return EnumMarshaler<EObserveConditionType>.FromNative(IntPtr.Add(base.Address, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConditionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ConditionType");
			}
			else
			{
				EnumMarshaler<EObserveConditionType>.ToNative(IntPtr.Add(base.Address, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("最大可触发次数，默认：1")]
	[Category("Observe Condition Config")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:SuccessLimit")]
	protected int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
			}
		}
	}

	[Category("Observe Condition Config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedPlayerOrUnitOrActor")]
	public FGsSmartParam ObservedPlayerOrUnitOrActor
	{
		get
		{
			CheckDestroyed();
			if (!ObservedPlayerOrUnitOrActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedPlayerOrUnitOrActor");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, ObservedPlayerOrUnitOrActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedPlayerOrUnitOrActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedPlayerOrUnitOrActor");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, ObservedPlayerOrUnitOrActor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Observe Condition Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:UnitState")]
	public EBGUUnitState UnitState
	{
		get
		{
			CheckDestroyed();
			if (!UnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:UnitState");
				return EBGUUnitState.None;
			}
			return EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(base.Address, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:UnitState");
			}
			else
			{
				EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(base.Address, UnitState_Offset), 0, UnitState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Observe Condition Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:SimpleState")]
	public EBGUSimpleState SimpleState
	{
		get
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:SimpleState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:SimpleState");
			}
			else
			{
				EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Observe Condition Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType
	{
		get
		{
			CheckDestroyed();
			if (!AttrFloatType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:AttrFloatType");
				return EBGUAttrFloat.None;
			}
			return EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(base.Address, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttrFloatType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:AttrFloatType");
			}
			else
			{
				EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(base.Address, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:CompareOperation")]
	public EValueCompareOperations CompareOperation
	{
		get
		{
			CheckDestroyed();
			if (!CompareOperation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:CompareOperation");
				return EValueCompareOperations.EqualTo;
			}
			return EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(base.Address, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareOperation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:CompareOperation");
			}
			else
			{
				EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(base.Address, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Observe Condition Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:CompareValue")]
	public float CompareValue
	{
		get
		{
			CheckDestroyed();
			if (!CompareValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:CompareValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CompareValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompareValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:CompareValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CompareValue_Offset), value);
			}
		}
	}

	[Category("Observe Condition Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:Buff")]
	public FGsSmartParam Buff
	{
		get
		{
			CheckDestroyed();
			if (!Buff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:Buff");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Buff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Buff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:Buff");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Buff_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ItemNumOnline")]
	public int ItemNumOnline
	{
		get
		{
			CheckDestroyed();
			if (!ItemNumOnline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ItemNumOnline");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemNumOnline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemNumOnline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ItemNumOnline");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemNumOnline_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:Reversal")]
	public bool Reversal
	{
		get
		{
			CheckDestroyed();
			if (!Reversal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:Reversal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Reversal_Offset), 0, Reversal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Reversal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:Reversal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Reversal_Offset), 0, Reversal_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Observe Condition Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ChallengeLevel")]
	public int ChallengeLevel
	{
		get
		{
			CheckDestroyed();
			if (!ChallengeLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ChallengeLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChallengeLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChallengeLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ChallengeLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChallengeLevel_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:BuffId")]
	public int BuffId
	{
		get
		{
			CheckDestroyed();
			if (!BuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:BuffId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:BuffId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffId_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[Tooltip("与触发角色放在同一个关卡中，所以直接使用角色引用")]
	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedActor")]
	public TSoftObject<BGUActorBaseCS> ObservedActor
	{
		get
		{
			CheckDestroyed();
			if (!ObservedActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedActor");
				return default(TSoftObject<BGUActorBaseCS>);
			}
			return TSoftObjectMarshaler<BGUActorBaseCS>.FromNative(IntPtr.Add(base.Address, ObservedActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedActor");
			}
			else
			{
				TSoftObjectMarshaler<BGUActorBaseCS>.ToNative(IntPtr.Add(base.Address, ObservedActor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Deprecated")]
	[Tooltip("与触发角色放在同一个关卡中，所以直接使用角色引用")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedUnit")]
	public TSoftObject<BGUCharacterCS> ObservedUnit
	{
		get
		{
			CheckDestroyed();
			if (!ObservedUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedUnit");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, ObservedUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedUnit");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, ObservedUnit_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[VisibleAnywhere]
	[UProperty]
	[Tooltip("针对动态创建的角色，触发角色Guid")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedActorGuid")]
	public string ObservedActorGuid
	{
		get
		{
			CheckDestroyed();
			if (!ObservedActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedActorGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ObservedActorGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:ObservedActorGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ObservedActorGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[Category("Deprecated")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:bPlayerAsObserveUnit")]
	public bool bPlayerAsObserveUnit
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:bPlayerAsObserveUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:bPlayerAsObserveUnit");
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
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("ConditionType"))
		{
			ForceRefreshDetailView();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObservedPlayerOrUnitOrActor.ConfigGuid), "ObservedPlayerOrUnitOrActor", out var OutDisplayName);
		return $"{OutDisplayName}\r\n{GetObserveConditionString()}\r\nSuccessLimit:{SuccessLimit}";
	}

	protected string GetObserveConditionString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(ConditionType.ToString());
		switch (ConditionType)
		{
		case EObserveConditionType.UnitAttr:
			stringBuilder.Append($" {AttrFloatType} {CompareOperation} {CompareValue}");
			break;
		case EObserveConditionType.SimpleState:
			stringBuilder.Append($"SimpleState is {SimpleState}");
			break;
		case EObserveConditionType.UnitState:
			stringBuilder.Append($"SimpleState is {UnitState}");
			break;
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_ObserveByCondition questCustom_ObserveByCondition = new QuestCustom_ObserveByCondition();
		questCustom_ObserveByCondition.ConditionType = (int)ConditionType;
		questCustom_ObserveByCondition.SuccessLimit = SuccessLimit;
		if (ObservedPlayerOrUnitOrActor.ConfigGuid == Guid.Empty)
		{
			questCustom_ObserveByCondition.ObserveActorGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObservedPlayerOrUnitOrActor.ConfigGuid), out var OutActorGuid);
			questCustom_ObserveByCondition.ObserveActorGuid = OutActorGuid;
		}
		questCustom_ObserveByCondition.UnitState = (int)UnitState;
		questCustom_ObserveByCondition.SimpleState = (int)SimpleState;
		questCustom_ObserveByCondition.AttrFloatType = (int)AttrFloatType;
		questCustom_ObserveByCondition.CompareOperation = (int)CompareOperation;
		questCustom_ObserveByCondition.CompareValue = CompareValue;
		GetAssetInCS().GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Buff.ConfigGuid), out var OutBuffID);
		questCustom_ObserveByCondition.BuffId = OutBuffID;
		questCustom_ObserveByCondition.ItemNumOnline = ItemNumOnline;
		questCustom_ObserveByCondition.Reversal = Reversal;
		questCustom_ObserveByCondition.ChallengeLevel = ChallengeLevel;
		return questCustom_ObserveByCondition.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.ObserveByCondition;
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		if (ConditionType == EObserveConditionType.None)
		{
			OutErrorMessage = "ObserveActor: ConditionType不能为None";
			return false;
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_ObserveByCondition bED_QuestNode_ObserveByCondition = GCHelper.Find<BED_QuestNode_ObserveByCondition>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_QuestNode_ObserveByCondition.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_ObserveByCondition bED_QuestNode_ObserveByCondition = GCHelper.Find<BED_QuestNode_ObserveByCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_ObserveByCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_ObserveByCondition");
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		ObservedPlayerOrUnitOrActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedPlayerOrUnitOrActor");
		ObservedPlayerOrUnitOrActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedPlayerOrUnitOrActor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, intPtr, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		Buff_Offset = NativeReflection.GetPropertyOffset(intPtr, "Buff");
		Buff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Buff", Classes.FStructProperty);
		ItemNumOnline_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemNumOnline");
		ItemNumOnline_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemNumOnline", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref Reversal_PropertyAddress, intPtr, "Reversal");
		Reversal_Offset = NativeReflection.GetPropertyOffset(intPtr, "Reversal");
		Reversal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Reversal", Classes.FBoolProperty);
		ChallengeLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChallengeLevel");
		ChallengeLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChallengeLevel", Classes.FIntProperty);
		BuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffId", Classes.FIntProperty);
		ObservedActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedActor");
		ObservedActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedActor", Classes.FSoftObjectProperty);
		ObservedUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedUnit");
		ObservedUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedUnit", Classes.FSoftObjectProperty);
		ObservedActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedActorGuid");
		ObservedActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedActorGuid", Classes.FStrProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_ObserveByCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_ObserveByCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_ObserveByCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_ObserveByCondition));
	}
}
