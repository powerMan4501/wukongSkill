using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Start Wave Spawn By Challenge")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge")]
public class BED_QuestNode_StartWaveSpawnByChallenge : BED_QuestNode
{
	private static bool SpawnerList_IsValid;

	private static int SpawnerList_Offset;

	private static bool ChallengeId_IsValid;

	private static int ChallengeId_Offset;

	private static bool NeedPlayMontage_IsValid;

	private static int NeedPlayMontage_Offset;

	private static FFieldAddress NeedPlayMontage_PropertyAddress;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool AMEasy_IsValid;

	private static int AMEasy_Offset;

	private static bool AMNoraml_IsValid;

	private static int AMNoraml_Offset;

	private static bool AMHard_IsValid;

	private static int AMHard_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Observe Unit Guid")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:SpawnerList")]
	public FGsSmartParamArray SpawnerList
	{
		get
		{
			CheckDestroyed();
			if (!SpawnerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:SpawnerList");
				return default(FGsSmartParamArray);
			}
			return FGsSmartParamArray.FromNative(IntPtr.Add(base.Address, SpawnerList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:SpawnerList");
			}
			else
			{
				FGsSmartParamArray.ToNative(IntPtr.Add(base.Address, SpawnerList_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Observe Unit Guid")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:ChallengeId")]
	public int ChallengeId
	{
		get
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:ChallengeId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChallengeId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:ChallengeId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChallengeId_Offset), value);
			}
		}
	}

	[Category("PlayAM")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:NeedPlayMontage")]
	public bool NeedPlayMontage
	{
		get
		{
			CheckDestroyed();
			if (!NeedPlayMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:NeedPlayMontage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedPlayMontage_Offset), 0, NeedPlayMontage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedPlayMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:NeedPlayMontage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedPlayMontage_Offset), 0, NeedPlayMontage_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "NeedPlayMontage == True")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("PlayAM")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:Unit")]
	public FGsSmartParam Unit
	{
		get
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:Unit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Unit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:Unit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Unit_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "NeedPlayMontage == True")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("PlayAM")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMEasy")]
	public TSoftObject<UAnimMontage> AMEasy
	{
		get
		{
			CheckDestroyed();
			if (!AMEasy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMEasy");
				return default(TSoftObject<UAnimMontage>);
			}
			return TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMEasy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMEasy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMEasy");
			}
			else
			{
				TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMEasy_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "NeedPlayMontage == True")]
	[BlueprintReadWrite]
	[Category("PlayAM")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMNoraml")]
	public TSoftObject<UAnimMontage> AMNoraml
	{
		get
		{
			CheckDestroyed();
			if (!AMNoraml_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMNoraml");
				return default(TSoftObject<UAnimMontage>);
			}
			return TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMNoraml_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMNoraml_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMNoraml");
			}
			else
			{
				TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMNoraml_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayAM")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedPlayMontage == True")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMHard")]
	public TSoftObject<UAnimMontage> AMHard
	{
		get
		{
			CheckDestroyed();
			if (!AMHard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMHard");
				return default(TSoftObject<UAnimMontage>);
			}
			return TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AMHard_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AMHard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:AMHard");
			}
			else
			{
				TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AMHard_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.StartWaveSpawnByChallenge;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_StartWaveSpawnByChallenge questCustom_StartWaveSpawnByChallenge = new QuestCustom_StartWaveSpawnByChallenge();
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		foreach (Guid configGuide in SpawnerList.ConfigGuides)
		{
			assetInCS.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(configGuide), out var OutActorGuid);
			questCustom_StartWaveSpawnByChallenge.ObserveActorGuid.Add(OutActorGuid);
		}
		GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Unit.ConfigGuid), out var OutActorGuid2);
		questCustom_StartWaveSpawnByChallenge.ChallengeId = ChallengeId;
		questCustom_StartWaveSpawnByChallenge.NeedPlayMontage = NeedPlayMontage;
		questCustom_StartWaveSpawnByChallenge.PlayMontageActorGuid = OutActorGuid2;
		_ = AMEasy;
		questCustom_StartWaveSpawnByChallenge.AmPathEasy = AMEasy.LongPackageName;
		_ = AMNoraml;
		questCustom_StartWaveSpawnByChallenge.AmPathNormal = AMNoraml.LongPackageName;
		_ = AMHard;
		questCustom_StartWaveSpawnByChallenge.AmPathHard = AMHard.LongPackageName;
		return questCustom_StartWaveSpawnByChallenge.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_StartWaveSpawnByChallenge bED_QuestNode_StartWaveSpawnByChallenge = GCHelper.Find<BED_QuestNode_StartWaveSpawnByChallenge>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_StartWaveSpawnByChallenge.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge");
		SpawnerList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnerList");
		SpawnerList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnerList", Classes.FStructProperty);
		ChallengeId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChallengeId");
		ChallengeId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChallengeId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedPlayMontage_PropertyAddress, intPtr, "NeedPlayMontage");
		NeedPlayMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedPlayMontage");
		NeedPlayMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedPlayMontage", Classes.FBoolProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		AMEasy_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMEasy");
		AMEasy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMEasy", Classes.FSoftObjectProperty);
		AMNoraml_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMNoraml");
		AMNoraml_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMNoraml", Classes.FSoftObjectProperty);
		AMHard_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMHard");
		AMHard_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMHard", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_StartWaveSpawnByChallenge:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_StartWaveSpawnByChallenge()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_StartWaveSpawnByChallenge)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_StartWaveSpawnByChallenge));
	}
}
