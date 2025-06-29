using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Remove Buff")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff")]
internal class BED_QuestNode_RemoveBuff : BED_QuestNode
{
	private static bool UnitOrPlayer_IsValid;

	private static int UnitOrPlayer_Offset;

	private static bool Buff_IsValid;

	private static int Buff_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool bPlayerAsObserveUnit_IsValid;

	private static int bPlayerAsObserveUnit_Offset;

	private static FFieldAddress bPlayerAsObserveUnit_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[Category("Config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:UnitOrPlayer")]
	public FGsSmartParam UnitOrPlayer
	{
		get
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:UnitOrPlayer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:UnitOrPlayer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:Buff")]
	public FGsSmartParam Buff
	{
		get
		{
			CheckDestroyed();
			if (!Buff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:Buff");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Buff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Buff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:Buff");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Buff_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[Category("Deprecated")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Deprecated")]
	[UMeta(MDProp.EditCondition, "!bPlayerAsObserveUnit")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:Unit")]
	public TSoftObject<BGUCharacterCS> Unit
	{
		get
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:Unit");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, Unit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:Unit");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, Unit_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Deprecated")]
	[UMeta(MDProp.EditCondition, "!bPlayerAsObserveUnit")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:UnitGuid")]
	public string UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:UnitGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:UnitGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[UProperty]
	[DisplayName("使用主角作为Unit")]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:bPlayerAsObserveUnit")]
	public bool bPlayerAsObserveUnit
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:bPlayerAsObserveUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RemoveBuff:bPlayerAsObserveUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		BuffLayer = 1;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.RemoveBuff;
	}

	public override byte[] GetCustomData()
	{
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		QuestCustom_RemoveBuff questCustom_RemoveBuff = new QuestCustom_RemoveBuff();
		assetInCS.GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Buff.ConfigGuid), out var OutBuffID);
		questCustom_RemoveBuff.BuffId = OutBuffID;
		questCustom_RemoveBuff.BuffLayer = BuffLayer;
		if (UnitOrPlayer.ConfigGuid == Guid.Empty)
		{
			questCustom_RemoveBuff.UnitGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			assetInCS.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitOrPlayer.ConfigGuid), out var OutActorGuid);
			questCustom_RemoveBuff.UnitGuid = OutActorGuid;
		}
		return questCustom_RemoveBuff.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_RemoveBuff:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitOrPlayer.ConfigGuid), "UnitOrPlayer", out var OutDisplayName);
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Buff.ConfigGuid), "Buff", out var OutDisplayName2);
		return $"{OutDisplayName}\r\n BuffID: {OutDisplayName2} BuffLayer: {BuffLayer}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_RemoveBuff:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_RemoveBuff bED_QuestNode_RemoveBuff = GCHelper.Find<b1.BED_QuestNode_RemoveBuff>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_RemoveBuff.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_RemoveBuff");
		UnitOrPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitOrPlayer");
		UnitOrPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitOrPlayer", Classes.FStructProperty);
		Buff_Offset = NativeReflection.GetPropertyOffset(intPtr, "Buff");
		Buff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Buff", Classes.FStructProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FSoftObjectProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsObserveUnit_PropertyAddress, intPtr, "bPlayerAsObserveUnit");
		bPlayerAsObserveUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsObserveUnit");
		bPlayerAsObserveUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsObserveUnit", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_RemoveBuff:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_RemoveBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_RemoveBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_RemoveBuff));
	}
}
