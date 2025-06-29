using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Play AnimMontage")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage")]
public class BED_QuestNode_PlayAnimMontage : BED_QuestNode
{
	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool AM_IsValid;

	private static int AM_Offset;

	private static bool Caster_IsValid;

	private static int Caster_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[Category("PlayAM")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:Unit")]
	public FGsSmartParam Unit
	{
		get
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:Unit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Unit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:Unit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Unit_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("PlayAM")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:AM")]
	public TSoftObject<UAnimMontage> AM
	{
		get
		{
			CheckDestroyed();
			if (!AM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:AM");
				return default(TSoftObject<UAnimMontage>);
			}
			return TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:AM");
			}
			else
			{
				TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AM_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:Caster")]
	public TSoftObject<BGUCharacterCS> Caster
	{
		get
		{
			CheckDestroyed();
			if (!Caster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:Caster");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, Caster_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Caster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:Caster");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, Caster_Offset), value);
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
		return B1CalliopeDef.QuestNode.PlayAnimMontage;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		_ = AM;
		return "";
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_PlayAnimMontage questCustom_PlayAnimMontage = new QuestCustom_PlayAnimMontage();
		GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Unit.ConfigGuid), out var OutActorGuid);
		questCustom_PlayAnimMontage.CasterGuid = OutActorGuid;
		if (!AM.IsNull)
		{
			questCustom_PlayAnimMontage.AmPath = AM.LongPackageName;
		}
		return questCustom_PlayAnimMontage.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_PlayAnimMontage bED_QuestNode_PlayAnimMontage = GCHelper.Find<BED_QuestNode_PlayAnimMontage>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayAnimMontage.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage");
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		AM_Offset = NativeReflection.GetPropertyOffset(intPtr, "AM");
		AM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AM", Classes.FSoftObjectProperty);
		Caster_Offset = NativeReflection.GetPropertyOffset(intPtr, "Caster");
		Caster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Caster", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayAnimMontage:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayAnimMontage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_PlayAnimMontage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_PlayAnimMontage));
	}
}
