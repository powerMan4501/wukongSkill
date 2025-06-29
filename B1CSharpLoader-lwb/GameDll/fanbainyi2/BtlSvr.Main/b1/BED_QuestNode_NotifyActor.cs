using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[UClass]
[DisplayName("Notify Actor")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor")]
public class BED_QuestNode_NotifyActor : BED_QuestNode
{
	private static bool NotifySceneActor_IsValid;

	private static int NotifySceneActor_Offset;

	private static bool NotifyTags_IsValid;

	private static int NotifyTags_Offset;

	private static bool NotifyActor_IsValid;

	private static int NotifyActor_Offset;

	private static bool NotifyUnit_IsValid;

	private static int NotifyUnit_Offset;

	private static bool NotifyActorGuid_IsValid;

	private static int NotifyActorGuid_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("NotifyActor")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifySceneActor")]
	public FGsSmartParam NotifySceneActor
	{
		get
		{
			CheckDestroyed();
			if (!NotifySceneActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifySceneActor");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, NotifySceneActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifySceneActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifySceneActor");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, NotifySceneActor_Offset), value);
			}
		}
	}

	[Category("NotifyActor")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyTags")]
	protected FGameplayTagContainer NotifyTags
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, NotifyTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, NotifyTags_Offset), value);
			}
		}
	}

	[UMeta("MustBeLevelActor", true)]
	[Category("Deprecated")]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyActor")]
	public TSoftObject<BGUActorBaseCS> NotifyActor
	{
		get
		{
			CheckDestroyed();
			if (!NotifyActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyActor");
				return default(TSoftObject<BGUActorBaseCS>);
			}
			return TSoftObjectMarshaler<BGUActorBaseCS>.FromNative(IntPtr.Add(base.Address, NotifyActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyActor");
			}
			else
			{
				TSoftObjectMarshaler<BGUActorBaseCS>.ToNative(IntPtr.Add(base.Address, NotifyActor_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Deprecated")]
	[VisibleAnywhere]
	[UMeta("MustBeLevelUnit", true)]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyUnit")]
	public TSoftObject<BGUCharacterCS> NotifyUnit
	{
		get
		{
			CheckDestroyed();
			if (!NotifyUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyUnit");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, NotifyUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyUnit");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, NotifyUnit_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[Category("Deprecated")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyActorGuid")]
	public string NotifyActorGuid
	{
		get
		{
			CheckDestroyed();
			if (!NotifyActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyActorGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, NotifyActorGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_NotifyActor:NotifyActorGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, NotifyActorGuid_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_NotifyActor:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(NotifySceneActor.ConfigGuid), "NotifySceneActor", out var OutDisplayName);
		return OutDisplayName + "\r\n" + GetNotifyTagsDescription(NotifyTags);
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_NotifyActor questCustom_NotifyActor = new QuestCustom_NotifyActor();
		GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(NotifySceneActor.ConfigGuid), out var OutActorGuid);
		questCustom_NotifyActor.NotifyActorGuid = OutActorGuid;
		string[] array = new string[NotifyTags.GameplayTags.Count];
		for (int i = 0; i < NotifyTags.GameplayTags.Count; i++)
		{
			array[i] = NotifyTags.GameplayTags[i].TagName.PlainName;
		}
		questCustom_NotifyActor.NotifyTagStrings.AddRange(array);
		return questCustom_NotifyActor.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.NotifyActor;
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		if (NotifyTags.GameplayTags.Count == 0)
		{
			OutErrorMessage = "未配置需要通知的内容";
			return false;
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_NotifyActor:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_NotifyActor bED_QuestNode_NotifyActor = GCHelper.Find<BED_QuestNode_NotifyActor>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_NotifyActor.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_NotifyActor");
		NotifySceneActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifySceneActor");
		NotifySceneActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifySceneActor", Classes.FStructProperty);
		NotifyTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTags");
		NotifyTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTags", Classes.FStructProperty);
		NotifyActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyActor");
		NotifyActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyActor", Classes.FSoftObjectProperty);
		NotifyUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyUnit");
		NotifyUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyUnit", Classes.FSoftObjectProperty);
		NotifyActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyActorGuid");
		NotifyActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyActorGuid", Classes.FStrProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_NotifyActor:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_NotifyActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_NotifyActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_NotifyActor));
	}
}
