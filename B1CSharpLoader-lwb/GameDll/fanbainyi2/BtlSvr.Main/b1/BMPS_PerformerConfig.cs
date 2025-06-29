using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BMPS_PerformerConfig")]
public class BMPS_PerformerConfig : BMPS_Base
{
	private static bool PerformerTagMapping_IsValid;

	private static int PerformerTagMapping_Offset;

	private static bool GetDisplayTextCS_IsValid;

	private static IntPtr GetDisplayTextCS_FunctionAddress;

	private static int GetDisplayTextCS_ParamsSize;

	private static bool GetDisplayTextCS_ReturnValue_IsValid;

	private static int GetDisplayTextCS_ReturnValue_Offset;

	private static FFieldAddress GetDisplayTextCS_ReturnValue_PropertyAddress;

	private static bool AfterLevelSequenceActorInitializedCS_IsValid;

	private static IntPtr AfterLevelSequenceActorInitializedCS_FunctionAddress;

	private static int AfterLevelSequenceActorInitializedCS_ParamsSize;

	private static bool AfterLevelSequenceActorInitializedCS_InPipeline_IsValid;

	private static int AfterLevelSequenceActorInitializedCS_InPipeline_Offset;

	[BlueprintReadWrite]
	[DisplayName("演员映射配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BMPS_PerformerConfig:PerformerTagMapping")]
	public BUC_PerformerMappingConfigDataAsset PerformerTagMapping
	{
		get
		{
			CheckDestroyed();
			if (!PerformerTagMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_PerformerConfig:PerformerTagMapping");
				return null;
			}
			return UObjectMarshaler<BUC_PerformerMappingConfigDataAsset>.FromNative(IntPtr.Add(base.Address, PerformerTagMapping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerTagMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_PerformerConfig:PerformerTagMapping");
			}
			else
			{
				UObjectMarshaler<BUC_PerformerMappingConfigDataAsset>.ToNative(IntPtr.Add(base.Address, PerformerTagMapping_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_PerformerConfig:AfterLevelSequenceActorInitializedCS")]
	protected override void AfterLevelSequenceActorInitializedCS_Implementation(UMoviePipeline InPipeline)
	{
		if (GetSequenceBindingTags(InPipeline, out var OutBindingTags) <= 0)
		{
			return;
		}
		Dictionary<FName, TSubclassOf<BGUPerformerActorCS>> dictionary = new Dictionary<FName, TSubclassOf<BGUPerformerActorCS>>();
		foreach (KeyValuePair<TSubclassOf<BGUPerformerActorCS>, FPerformerTag> item in PerformerTagMapping.PerformerTagMapping)
		{
			FPerformerTag value = item.Value;
			List<FName> list = new List<FName>();
			list.AddRange(value.Name);
			foreach (FGameplayTag gameplayTag in value.GameplayTagContainer.GameplayTags)
			{
				list.Add(gameplayTag.TagName);
			}
			foreach (FName item2 in list)
			{
				dictionary[item2] = item.Key;
			}
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(InPipeline);
		Dictionary<FName, AActor> dictionary2 = new Dictionary<FName, AActor>();
		foreach (FName item3 in OutBindingTags)
		{
			if (dictionary.TryGetValue(item3, out var value2) && value2 != null && value2.Value != null)
			{
				AActor value3 = BGUFunctionLibraryCS.BGUSpawnActor(worldFromObj, value2.Value, FVector.ZeroVector, FRotator.ZeroRotator);
				dictionary2[item3] = value3;
			}
		}
		SequenceBindActorsByTag(InPipeline, dictionary2);
	}

	[USharpPath("/Script/b1-Managed.BMPS_PerformerConfig:GetDisplayTextCS")]
	protected override string GetDisplayTextCS_Implementation()
	{
		return "演员配置";
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_PerformerConfig:GetDisplayTextCS")]
	private static void GetDisplayTextCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_PerformerConfig bMPS_PerformerConfig = GCHelper.Find<BMPS_PerformerConfig>(obj);
		string displayTextCS_Implementation = bMPS_PerformerConfig.GetDisplayTextCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayTextCS_ReturnValue_Offset), displayTextCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_PerformerConfig:AfterLevelSequenceActorInitializedCS")]
	private static void AfterLevelSequenceActorInitializedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_PerformerConfig bMPS_PerformerConfig = GCHelper.Find<BMPS_PerformerConfig>(obj);
		UMoviePipeline inPipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(buffer, AfterLevelSequenceActorInitializedCS_InPipeline_Offset));
		bMPS_PerformerConfig.AfterLevelSequenceActorInitializedCS_Implementation(inPipeline);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BMPS_PerformerConfig");
		PerformerTagMapping_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformerTagMapping");
		PerformerTagMapping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformerTagMapping", Classes.FObjectProperty);
		GetDisplayTextCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayTextCS");
		GetDisplayTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayTextCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayTextCS_ReturnValue_PropertyAddress, GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayTextCS_IsValid = GetDisplayTextCS_FunctionAddress != IntPtr.Zero && GetDisplayTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_PerformerConfig:GetDisplayTextCS", GetDisplayTextCS_IsValid);
		AfterLevelSequenceActorInitializedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AfterLevelSequenceActorInitializedCS");
		AfterLevelSequenceActorInitializedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AfterLevelSequenceActorInitializedCS_FunctionAddress);
		AfterLevelSequenceActorInitializedCS_InPipeline_Offset = NativeReflection.GetPropertyOffset(AfterLevelSequenceActorInitializedCS_FunctionAddress, "InPipeline");
		AfterLevelSequenceActorInitializedCS_InPipeline_IsValid = NativeReflection.ValidatePropertyClass(AfterLevelSequenceActorInitializedCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		AfterLevelSequenceActorInitializedCS_IsValid = AfterLevelSequenceActorInitializedCS_FunctionAddress != IntPtr.Zero && AfterLevelSequenceActorInitializedCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_PerformerConfig:AfterLevelSequenceActorInitializedCS", AfterLevelSequenceActorInitializedCS_IsValid);
	}

	static BMPS_PerformerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BMPS_PerformerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BMPS_PerformerConfig));
	}
}
