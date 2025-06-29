using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Set Interact State")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState")]
public class BED_QuestNode_SetInteractState : BED_QuestNode
{
	private static bool InteractState_IsValid;

	private static int InteractState_Offset;

	private static FFieldAddress InteractState_PropertyAddress;

	private static bool NotifySceneActor_IsValid;

	private static int NotifySceneActor_Offset;

	private static bool ByChallengeLevel_IsValid;

	private static int ByChallengeLevel_Offset;

	private static FFieldAddress ByChallengeLevel_PropertyAddress;

	private static bool ChallengeId_IsValid;

	private static int ChallengeId_Offset;

	private static bool InteractorList_IsValid;

	private static int InteractorList_Offset;

	private static bool IngoreHideLogic_IsValid;

	private static int IngoreHideLogic_Offset;

	private static FFieldAddress IngoreHideLogic_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:InteractState")]
	public bool InteractState
	{
		get
		{
			CheckDestroyed();
			if (!InteractState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:InteractState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InteractState_Offset), 0, InteractState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InteractState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:InteractState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InteractState_Offset), 0, InteractState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("NotifyActor")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:NotifySceneActor")]
	public FGsSmartParam NotifySceneActor
	{
		get
		{
			CheckDestroyed();
			if (!NotifySceneActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:NotifySceneActor");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, NotifySceneActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifySceneActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:NotifySceneActor");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, NotifySceneActor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:ByChallengeLevel")]
	public bool ByChallengeLevel
	{
		get
		{
			CheckDestroyed();
			if (!ByChallengeLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:ByChallengeLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ByChallengeLevel_Offset), 0, ByChallengeLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ByChallengeLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:ByChallengeLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ByChallengeLevel_Offset), 0, ByChallengeLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "UseChallengeLevel == True")]
	[Category("ByChallengeLevel")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:ChallengeId")]
	public int ChallengeId
	{
		get
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:ChallengeId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChallengeId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:ChallengeId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChallengeId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseChallengeLevel == True")]
	[Category("ByChallengeLevel")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:InteractorList")]
	public FGsSmartParamArray InteractorList
	{
		get
		{
			CheckDestroyed();
			if (!InteractorList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:InteractorList");
				return default(FGsSmartParamArray);
			}
			return FGsSmartParamArray.FromNative(IntPtr.Add(base.Address, InteractorList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractorList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:InteractorList");
			}
			else
			{
				FGsSmartParamArray.ToNative(IntPtr.Add(base.Address, InteractorList_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:IngoreHideLogic")]
	public bool IngoreHideLogic
	{
		get
		{
			CheckDestroyed();
			if (!IngoreHideLogic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:IngoreHideLogic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IngoreHideLogic_Offset), 0, IngoreHideLogic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IngoreHideLogic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetInteractState:IngoreHideLogic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IngoreHideLogic_Offset), 0, IngoreHideLogic_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SetInteractState;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_SetInteractState questCustom_SetInteractState = new QuestCustom_SetInteractState();
		questCustom_SetInteractState.InteractState = InteractState;
		GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(NotifySceneActor.ConfigGuid), out var OutActorGuid);
		questCustom_SetInteractState.NotifyActorGuid = OutActorGuid;
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		foreach (Guid configGuide in InteractorList.ConfigGuides)
		{
			assetInCS.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(configGuide), out var OutActorGuid2);
			questCustom_SetInteractState.NotifyActorGuidList.Add(OutActorGuid2);
		}
		questCustom_SetInteractState.ByChallengeLevel = ByChallengeLevel;
		questCustom_SetInteractState.ChallengeId = ChallengeId;
		questCustom_SetInteractState.IngoreHideLogic = IngoreHideLogic;
		return questCustom_SetInteractState.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetInteractState:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_SetInteractState:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_SetInteractState bED_QuestNode_SetInteractState = GCHelper.Find<BED_QuestNode_SetInteractState>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_SetInteractState.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_SetInteractState");
		NativeReflection.GetPropertyRef(ref InteractState_PropertyAddress, intPtr, "InteractState");
		InteractState_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractState");
		InteractState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractState", Classes.FBoolProperty);
		NotifySceneActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifySceneActor");
		NotifySceneActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifySceneActor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ByChallengeLevel_PropertyAddress, intPtr, "ByChallengeLevel");
		ByChallengeLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ByChallengeLevel");
		ByChallengeLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ByChallengeLevel", Classes.FBoolProperty);
		ChallengeId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChallengeId");
		ChallengeId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChallengeId", Classes.FIntProperty);
		InteractorList_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractorList");
		InteractorList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractorList", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IngoreHideLogic_PropertyAddress, intPtr, "IngoreHideLogic");
		IngoreHideLogic_Offset = NativeReflection.GetPropertyOffset(intPtr, "IngoreHideLogic");
		IngoreHideLogic_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IngoreHideLogic", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_SetInteractState:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_SetInteractState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_SetInteractState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_SetInteractState));
	}
}
