using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Add Buff")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff")]
internal class BED_QuestNode_AddBuff : BED_QuestNode
{
	private static bool UnitOrPlayer_IsValid;

	private static int UnitOrPlayer_Offset;

	private static bool Buff_IsValid;

	private static int Buff_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffDuration_IsValid;

	private static int BuffDuration_Offset;

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

	[BlueprintReadWrite]
	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:UnitOrPlayer")]
	public FGsSmartParam UnitOrPlayer
	{
		get
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:UnitOrPlayer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, UnitOrPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitOrPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:UnitOrPlayer");
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
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:Buff")]
	public FGsSmartParam Buff
	{
		get
		{
			CheckDestroyed();
			if (!Buff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:Buff");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Buff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Buff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:Buff");
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
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[Category("Config")]
	[DisplayName("Buff持续时间(毫秒)")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffDuration")]
	public int BuffDuration
	{
		get
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffDuration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffDuration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Deprecated")]
	[UMeta(MDProp.EditCondition, "!bPlayerAsObserveUnit")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:Unit")]
	public TSoftObject<BGUCharacterCS> Unit
	{
		get
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:Unit");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, Unit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:Unit");
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
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:UnitGuid")]
	public string UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:UnitGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:UnitGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[DisplayName("使用主角作为Unit")]
	[Category("Deprecated")]
	[BlueprintReadWrite]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:bPlayerAsObserveUnit")]
	public bool bPlayerAsObserveUnit
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:bPlayerAsObserveUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsObserveUnit_Offset), 0, bPlayerAsObserveUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsObserveUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AddBuff:bPlayerAsObserveUnit");
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
		return B1CalliopeDef.QuestNode.AddBuff;
	}

	public override byte[] GetCustomData()
	{
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		QuestCustom_AddBuff questCustom_AddBuff = new QuestCustom_AddBuff();
		assetInCS.GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Buff.ConfigGuid), out var OutBuffID);
		questCustom_AddBuff.BuffId = OutBuffID;
		questCustom_AddBuff.BuffLayer = BuffLayer;
		questCustom_AddBuff.BuffDuration = BuffDuration;
		if (UnitOrPlayer.ConfigGuid == Guid.Empty)
		{
			questCustom_AddBuff.UnitGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitOrPlayer.ConfigGuid), out var OutActorGuid);
			questCustom_AddBuff.UnitGuid = OutActorGuid;
		}
		return questCustom_AddBuff.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_AddBuff:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(UnitOrPlayer.ConfigGuid), "UnitOrPlayer", out var OutDisplayName);
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Buff.ConfigGuid), "Buff", out var OutDisplayName2);
		return $"{OutDisplayName}\r\n BuffID: {OutDisplayName2} BuffLayer: {BuffLayer} BuffDuration：{BuffDuration}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_AddBuff:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_AddBuff bED_QuestNode_AddBuff = GCHelper.Find<b1.BED_QuestNode_AddBuff>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_AddBuff.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_AddBuff");
		UnitOrPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitOrPlayer");
		UnitOrPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitOrPlayer", Classes.FStructProperty);
		Buff_Offset = NativeReflection.GetPropertyOffset(intPtr, "Buff");
		Buff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Buff", Classes.FStructProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BuffDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffDuration");
		BuffDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffDuration", Classes.FIntProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_AddBuff:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_AddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_AddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_AddBuff));
	}
}
