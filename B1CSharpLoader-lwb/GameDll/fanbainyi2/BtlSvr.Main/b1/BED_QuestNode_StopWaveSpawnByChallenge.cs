using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Stop Wave Spawn By Challenge")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge")]
public class BED_QuestNode_StopWaveSpawnByChallenge : BED_QuestNode
{
	private static bool SpawnerList_IsValid;

	private static int SpawnerList_Offset;

	private static bool ChallengeId_IsValid;

	private static int ChallengeId_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Observe Unit Guid")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:SpawnerList")]
	public FGsSmartParamArray SpawnerList
	{
		get
		{
			CheckDestroyed();
			if (!SpawnerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:SpawnerList");
				return default(FGsSmartParamArray);
			}
			return FGsSmartParamArray.FromNative(IntPtr.Add(base.Address, SpawnerList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:SpawnerList");
			}
			else
			{
				FGsSmartParamArray.ToNative(IntPtr.Add(base.Address, SpawnerList_Offset), value);
			}
		}
	}

	[Category("Observe Unit Guid")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:ChallengeId")]
	public int ChallengeId
	{
		get
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:ChallengeId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChallengeId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:ChallengeId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChallengeId_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.StopWaveSpawnByChallenge;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_StopWaveSpawnByChallenge questCustom_StopWaveSpawnByChallenge = new QuestCustom_StopWaveSpawnByChallenge();
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		foreach (Guid configGuide in SpawnerList.ConfigGuides)
		{
			assetInCS.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(configGuide), out var OutActorGuid);
			questCustom_StopWaveSpawnByChallenge.ObserveActorGuid.Add(OutActorGuid);
		}
		questCustom_StopWaveSpawnByChallenge.ChallengeId = ChallengeId;
		return questCustom_StopWaveSpawnByChallenge.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_StopWaveSpawnByChallenge bED_QuestNode_StopWaveSpawnByChallenge = GCHelper.Find<BED_QuestNode_StopWaveSpawnByChallenge>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_StopWaveSpawnByChallenge.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge");
		SpawnerList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnerList");
		SpawnerList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnerList", Classes.FStructProperty);
		ChallengeId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChallengeId");
		ChallengeId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChallengeId", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_StopWaveSpawnByChallenge:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_StopWaveSpawnByChallenge()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_StopWaveSpawnByChallenge)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_StopWaveSpawnByChallenge));
	}
}
