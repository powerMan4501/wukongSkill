using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Set Award State")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState")]
public class BED_QuestNode_SetAwardState : BED_QuestNode
{
	private static bool EventId_IsValid;

	private static int EventId_Offset;

	private static bool Distance_IsValid;

	private static int Distance_Offset;

	private static bool CenterDistance_IsValid;

	private static int CenterDistance_Offset;

	private static bool CenterPoint_IsValid;

	private static int CenterPoint_Offset;

	private static bool ConditionList_IsValid;

	private static int ConditionList_Offset;

	private static FFieldAddress ConditionList_PropertyAddress;

	private TArrayReadWriteMarshaler<EAwardStateConditionType> ConditionList_Marshaler;

	private static bool UnitOrPlayer_IsValid;

	private static int UnitOrPlayer_Offset;

	private static bool bPlayerAsObserveUnit_IsValid;

	private static int bPlayerAsObserveUnit_Offset;

	private static FFieldAddress bPlayerAsObserveUnit_PropertyAddress;

	private static bool ObservedActor_IsValid;

	private static int ObservedActor_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:EventId")]
	public int EventId
	{
		get
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:EventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:EventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventId_Offset), value);
			}
		}
	}

	[DisplayName("判断Boss在踪迹点附近的距离")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:Distance")]
	public int Distance
	{
		get
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:Distance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Distance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:Distance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Distance_Offset), value);
			}
		}
	}

	[DisplayName("距离祭坛的距离")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:CenterDistance")]
	public int CenterDistance
	{
		get
		{
			CheckDestroyed();
			if (!CenterDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:CenterDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CenterDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:CenterDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CenterDistance_Offset), value);
			}
		}
	}

	[DisplayName("祭坛的坐标")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:CenterPoint")]
	public FVector CenterPoint
	{
		get
		{
			CheckDestroyed();
			if (!CenterPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:CenterPoint");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CenterPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:CenterPoint");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CenterPoint_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("前置条件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:ConditionList")]
	public TArrayReadWrite<EAwardStateConditionType> ConditionList
	{
		get
		{
			CheckDestroyed();
			if (!ConditionList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:ConditionList");
				return null;
			}
			if (ConditionList_Marshaler == null)
			{
				ConditionList_Marshaler = new TArrayReadWriteMarshaler<EAwardStateConditionType>(1, ConditionList_PropertyAddress, CachedMarshalingDelegates<EAwardStateConditionType, EnumMarshaler<EAwardStateConditionType>>.FromNative, CachedMarshalingDelegates<EAwardStateConditionType, EnumMarshaler<EAwardStateConditionType>>.ToNative);
			}
			return ConditionList_Marshaler.FromNative(IntPtr.Add(base.Address, ConditionList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:UnitOrPlayer")]
	public FGsSmartParam UnitOrPlayer
	{
		get
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:UnitOrPlayer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:UnitOrPlayer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("选择玩家作为观察")]
	[Category("Deprecated")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:bPlayerAsObserveUnit")]
	public bool bPlayerAsObserveUnit
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:bPlayerAsObserveUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:bPlayerAsObserveUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Deprecated")]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[Tooltip("与触发角色放在同一个关卡中，所以直接使用角色引用")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:ObservedActor")]
	public TSoftObject<BGUCharacterCS> ObservedActor
	{
		get
		{
			CheckDestroyed();
			if (!ObservedActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:ObservedActor");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, ObservedActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservedActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetAwardState:ObservedActor");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, ObservedActor_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SetAwardState;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_SetAwardState questCustom_SetAwardState = new QuestCustom_SetAwardState();
		questCustom_SetAwardState.EventId = EventId;
		questCustom_SetAwardState.Distance = Distance;
		questCustom_SetAwardState.CenterDistance = CenterDistance;
		questCustom_SetAwardState.CenterPointX = CenterPoint.X;
		questCustom_SetAwardState.CenterPointY = CenterPoint.Y;
		questCustom_SetAwardState.CenterPointZ = CenterPoint.Z;
		if (UnitOrPlayer.ConfigGuid == Guid.Empty)
		{
			questCustom_SetAwardState.ObservedActorGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitOrPlayer.ConfigGuid), out var OutActorGuid);
			questCustom_SetAwardState.ObservedActorGuid = OutActorGuid;
		}
		foreach (EAwardStateConditionType condition in ConditionList)
		{
			questCustom_SetAwardState.ConditionList.Add((int)condition);
		}
		return questCustom_SetAwardState.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetAwardState:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_SetAwardState:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_SetAwardState bED_QuestNode_SetAwardState = GCHelper.Find<BED_QuestNode_SetAwardState>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_SetAwardState.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_SetAwardState");
		EventId_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventId");
		EventId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventId", Classes.FIntProperty);
		Distance_Offset = NativeReflection.GetPropertyOffset(intPtr, "Distance");
		Distance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Distance", Classes.FIntProperty);
		CenterDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "CenterDistance");
		CenterDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CenterDistance", Classes.FIntProperty);
		CenterPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "CenterPoint");
		CenterPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CenterPoint", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ConditionList_PropertyAddress, intPtr, "ConditionList");
		ConditionList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionList");
		ConditionList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionList", Classes.FArrayProperty);
		UnitOrPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitOrPlayer");
		UnitOrPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitOrPlayer", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsObserveUnit_PropertyAddress, intPtr, "bPlayerAsObserveUnit");
		bPlayerAsObserveUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsObserveUnit");
		bPlayerAsObserveUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsObserveUnit", Classes.FBoolProperty);
		ObservedActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedActor");
		ObservedActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedActor", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_SetAwardState:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_SetAwardState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_SetAwardState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_SetAwardState));
	}
}
