using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Play DBCEfx To Interact")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract")]
public class BED_QuestNode_PlayDBCEfxToInteract : BED_QuestNode
{
	private static bool Interactor_IsValid;

	private static int Interactor_Offset;

	private static bool B1DBC_IsValid;

	private static int B1DBC_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Observe Unit Guid")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:Interactor")]
	public FGsSmartParam Interactor
	{
		get
		{
			CheckDestroyed();
			if (!Interactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:Interactor");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Interactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:Interactor");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Interactor_Offset), value);
			}
		}
	}

	[Category("Observe Unit Guid")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:B1DBC")]
	public TSoftObject<BGWDataAsset_B1DBC> B1DBC
	{
		get
		{
			CheckDestroyed();
			if (!B1DBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:B1DBC");
				return default(TSoftObject<BGWDataAsset_B1DBC>);
			}
			return TSoftObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, B1DBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!B1DBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:B1DBC");
			}
			else
			{
				TSoftObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, B1DBC_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PlayDBCEfxToInteract;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_PlayDBCEfxToInteract questCustom_PlayDBCEfxToInteract = new QuestCustom_PlayDBCEfxToInteract();
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		assetInCS.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Interactor.ConfigGuid), out var OutActorGuid);
		questCustom_PlayDBCEfxToInteract.ObserveActorGuid = OutActorGuid;
		questCustom_PlayDBCEfxToInteract.DbcEfxPath = B1DBC.LongPackageName;
		return questCustom_PlayDBCEfxToInteract.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_PlayDBCEfxToInteract bED_QuestNode_PlayDBCEfxToInteract = GCHelper.Find<BED_QuestNode_PlayDBCEfxToInteract>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayDBCEfxToInteract.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract");
		Interactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Interactor");
		Interactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Interactor", Classes.FStructProperty);
		B1DBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "B1DBC");
		B1DBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "B1DBC", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayDBCEfxToInteract:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayDBCEfxToInteract()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_PlayDBCEfxToInteract)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_PlayDBCEfxToInteract));
	}
}
