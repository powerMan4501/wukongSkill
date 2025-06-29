using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Run Process Graph")]
[Placeable(false)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_RunProcessGraph")]
public class BED_QuestNode_RunProcessGraph : BED_QuestNode
{
	private static bool Asset_IsValid;

	private static int Asset_Offset;

	private static bool GetAssetToEditInCS_IsValid;

	private static IntPtr GetAssetToEditInCS_FunctionAddress;

	private static int GetAssetToEditInCS_ParamsSize;

	private static bool GetAssetToEditInCS_ReturnValue_IsValid;

	private static int GetAssetToEditInCS_ReturnValue_Offset;

	private static bool PrePropertyChanged_IsValid;

	private static IntPtr PrePropertyChanged_FunctionAddress;

	private static int PrePropertyChanged_ParamsSize;

	private static bool PrePropertyChanged_PropertyName_IsValid;

	private static int PrePropertyChanged_PropertyName_Offset;

	private static FFieldAddress PrePropertyChanged_PropertyName_PropertyAddress;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:Asset")]
	public TSoftObject<BED_ProcessAsset> Asset
	{
		get
		{
			CheckDestroyed();
			if (!Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:Asset");
				return default(TSoftObject<BED_ProcessAsset>);
			}
			return TSoftObjectMarshaler<BED_ProcessAsset>.FromNative(IntPtr.Add(base.Address, Asset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:Asset");
			}
			else
			{
				TSoftObjectMarshaler<BED_ProcessAsset>.ToNative(IntPtr.Add(base.Address, Asset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.SubGraph);
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Finish
		});
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (!Asset.IsNull)
		{
			return FPaths.GetBaseFilename(Asset.AssetPathName, removePath: false);
		}
		return "";
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:GetAssetToEditInCS")]
	protected override UObject GetAssetToEditInCS_Implementation()
	{
		if (!Asset.IsNull)
		{
			return Asset.LoadSynchronous();
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:PrePropertyChanged")]
	protected override void PrePropertyChanged_Implementation(string PropertyName)
	{
		if (PropertyName.Equals("Asset") && !Asset.IsNull)
		{
			UnBindAssetOnSubGraphReconstructionRequested(Asset.Value);
		}
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("Asset"))
		{
			ExecuteOnReconstructionRequested();
			SubscribeToAssetChanges();
		}
	}

	private void SubscribeToAssetChanges()
	{
		if (!Asset.IsNull)
		{
			BindAssetOnSubGraphReconstructionRequested(Asset.Value);
		}
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_RunProcessGraph questCustom_RunProcessGraph = new QuestCustom_RunProcessGraph();
		if (Asset.ObjectPath.IsValid)
		{
			if (!Asset.IsValid)
			{
				UBGWAssetLoader.SyncLoadObject(Asset.ObjectPath);
			}
			if (Asset.IsValid)
			{
				questCustom_RunProcessGraph.AssetPath = Asset.LongPackageName;
			}
		}
		return questCustom_RunProcessGraph.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.RunProcessGraph;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:GetAssetToEditInCS")]
	private static void GetAssetToEditInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_RunProcessGraph bED_QuestNode_RunProcessGraph = GCHelper.Find<BED_QuestNode_RunProcessGraph>(obj);
		UObject assetToEditInCS_Implementation = bED_QuestNode_RunProcessGraph.GetAssetToEditInCS_Implementation();
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetAssetToEditInCS_ReturnValue_Offset), assetToEditInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:PrePropertyChanged")]
	private static void PrePropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_RunProcessGraph bED_QuestNode_RunProcessGraph = GCHelper.Find<BED_QuestNode_RunProcessGraph>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PrePropertyChanged_PropertyName_Offset));
		bED_QuestNode_RunProcessGraph.PrePropertyChanged_Implementation(propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_RunProcessGraph bED_QuestNode_RunProcessGraph = GCHelper.Find<BED_QuestNode_RunProcessGraph>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_QuestNode_RunProcessGraph.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_RunProcessGraph bED_QuestNode_RunProcessGraph = GCHelper.Find<BED_QuestNode_RunProcessGraph>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_RunProcessGraph.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_RunProcessGraph");
		Asset_Offset = NativeReflection.GetPropertyOffset(intPtr, "Asset");
		Asset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Asset", Classes.FSoftObjectProperty);
		GetAssetToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetToEditInCS");
		GetAssetToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetToEditInCS_FunctionAddress);
		GetAssetToEditInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAssetToEditInCS_FunctionAddress, "ReturnValue");
		GetAssetToEditInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAssetToEditInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetToEditInCS_IsValid = GetAssetToEditInCS_FunctionAddress != IntPtr.Zero && GetAssetToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:GetAssetToEditInCS", GetAssetToEditInCS_IsValid);
		PrePropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrePropertyChanged");
		PrePropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PrePropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrePropertyChanged_PropertyName_PropertyAddress, PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PrePropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PrePropertyChanged_IsValid = PrePropertyChanged_FunctionAddress != IntPtr.Zero && PrePropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:PrePropertyChanged", PrePropertyChanged_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_RunProcessGraph:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_RunProcessGraph()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_RunProcessGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_RunProcessGraph));
	}
}
