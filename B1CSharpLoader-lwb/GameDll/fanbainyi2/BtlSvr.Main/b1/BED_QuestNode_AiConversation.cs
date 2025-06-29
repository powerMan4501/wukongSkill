using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("AiConversation")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_AiConversation")]
public class BED_QuestNode_AiConversation : BED_QuestNode
{
	private static bool UnitOrPlayer_IsValid;

	private static int UnitOrPlayer_Offset;

	private static bool AiConversationContentIDList_IsValid;

	private static int AiConversationContentIDList_Offset;

	private static FFieldAddress AiConversationContentIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> AiConversationContentIDList_Marshaler;

	private static bool Caster_IsValid;

	private static int Caster_Offset;

	private static bool bUseLocalPlayerAsCaster_IsValid;

	private static int bUseLocalPlayerAsCaster_Offset;

	private static FFieldAddress bUseLocalPlayerAsCaster_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AiConversation")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AiConversation:UnitOrPlayer")]
	public FGsSmartParam UnitOrPlayer
	{
		get
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:UnitOrPlayer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:UnitOrPlayer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AiConversation")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AiConversation:AiConversationContentIDList")]
	public TArrayReadWrite<int> AiConversationContentIDList
	{
		get
		{
			CheckDestroyed();
			if (!AiConversationContentIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:AiConversationContentIDList");
				return null;
			}
			if (AiConversationContentIDList_Marshaler == null)
			{
				AiConversationContentIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, AiConversationContentIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AiConversationContentIDList_Marshaler.FromNative(IntPtr.Add(base.Address, AiConversationContentIDList_Offset));
		}
	}

	[Category("Deprecated")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AiConversation:Caster")]
	public TSoftObject<BGUCharacterCS> Caster
	{
		get
		{
			CheckDestroyed();
			if (!Caster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:Caster");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, Caster_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Caster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:Caster");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, Caster_Offset), value);
			}
		}
	}

	[DisplayName("使用LocalPlayer作为Caster")]
	[Category("Deprecated")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AiConversation:bUseLocalPlayerAsCaster")]
	public bool bUseLocalPlayerAsCaster
	{
		get
		{
			CheckDestroyed();
			if (!bUseLocalPlayerAsCaster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:bUseLocalPlayerAsCaster");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseLocalPlayerAsCaster_Offset), 0, bUseLocalPlayerAsCaster_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseLocalPlayerAsCaster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AiConversation:bUseLocalPlayerAsCaster");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseLocalPlayerAsCaster_Offset), 0, bUseLocalPlayerAsCaster_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.AiConversation;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_AiConversation:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (AiConversationContentIDList == null || AiConversationContentIDList.Count < 1)
		{
			return "未配置";
		}
		return AiConversationContentIDList.ToString();
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_AiConversation questCustom_AiConversation = new QuestCustom_AiConversation();
		if (UnitOrPlayer.ConfigGuid == Guid.Empty)
		{
			questCustom_AiConversation.CasterGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitOrPlayer.ConfigGuid), out var OutActorGuid);
			questCustom_AiConversation.CasterGuid = OutActorGuid;
		}
		questCustom_AiConversation.ContentIds.AddRange(AiConversationContentIDList);
		if (AiConversationContentIDList.Count > 0)
		{
			int[] array = new int[AiConversationContentIDList.Count];
			for (int i = 0; i < AiConversationContentIDList.Count; i++)
			{
				array[i] = AiConversationContentIDList[i];
			}
			questCustom_AiConversation.ContentIds.Clear();
			questCustom_AiConversation.ContentIds.AddRange(array);
		}
		questCustom_AiConversation.UsePlayerAsCaster = false;
		return questCustom_AiConversation.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_AiConversation:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_AiConversation bED_QuestNode_AiConversation = GCHelper.Find<BED_QuestNode_AiConversation>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_AiConversation.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_AiConversation");
		UnitOrPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitOrPlayer");
		UnitOrPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitOrPlayer", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AiConversationContentIDList_PropertyAddress, intPtr, "AiConversationContentIDList");
		AiConversationContentIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AiConversationContentIDList");
		AiConversationContentIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AiConversationContentIDList", Classes.FArrayProperty);
		Caster_Offset = NativeReflection.GetPropertyOffset(intPtr, "Caster");
		Caster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Caster", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref bUseLocalPlayerAsCaster_PropertyAddress, intPtr, "bUseLocalPlayerAsCaster");
		bUseLocalPlayerAsCaster_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseLocalPlayerAsCaster");
		bUseLocalPlayerAsCaster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseLocalPlayerAsCaster", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_AiConversation:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_AiConversation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_AiConversation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_AiConversation));
	}
}
