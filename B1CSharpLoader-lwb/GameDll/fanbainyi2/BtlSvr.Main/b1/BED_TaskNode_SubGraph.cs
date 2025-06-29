using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Sub Graph")]
[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph")]
public class BED_TaskNode_SubGraph : BED_TaskNode
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

	private static bool GetContextInputsInCS_IsValid;

	private static IntPtr GetContextInputsInCS_FunctionAddress;

	private static int GetContextInputsInCS_ParamsSize;

	private static bool GetContextInputsInCS_ReturnValue_IsValid;

	private static int GetContextInputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextInputsInCS_ReturnValue_PropertyAddress;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	private static FName StartPin { get; }

	private static FName FinishPin { get; }

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:Asset")]
	public TSoftObject<BED_TaskAsset> Asset
	{
		get
		{
			CheckDestroyed();
			if (!Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_SubGraph:Asset");
				return default(TSoftObject<BED_TaskAsset>);
			}
			return TSoftObjectMarshaler<BED_TaskAsset>.FromNative(IntPtr.Add(base.Address, Asset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_SubGraph:Asset");
			}
			else
			{
				TSoftObjectMarshaler<BED_TaskAsset>.ToNative(IntPtr.Add(base.Address, Asset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.SubGraph);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = StartPin
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = FinishPin
		});
		base.SupportsContextPins = true;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (!Asset.IsNull)
		{
			return FPaths.GetBaseFilename(Asset.AssetPathName, removePath: false);
		}
		return "";
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:GetAssetToEditInCS")]
	protected override UObject GetAssetToEditInCS_Implementation()
	{
		if (!Asset.IsNull)
		{
			return Asset.LoadSynchronous();
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:GetContextInputsInCS")]
	protected override List<FName> GetContextInputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		UCalliopeAsset uCalliopeAsset = GetAssetToEditInCS() as UCalliopeAsset;
		if (uCalliopeAsset != null)
		{
			foreach (FName customInput in uCalliopeAsset.GetCustomInputs())
			{
				list.Add(customInput);
			}
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		UCalliopeAsset uCalliopeAsset = GetAssetToEditInCS() as UCalliopeAsset;
		if (uCalliopeAsset != null)
		{
			foreach (FName customOutput in uCalliopeAsset.GetCustomOutputs())
			{
				list.Add(customOutput);
			}
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:PrePropertyChanged")]
	protected override void PrePropertyChanged_Implementation(string PropertyName)
	{
		if (PropertyName.Equals("Asset") && !Asset.IsNull)
		{
			UnBindAssetOnSubGraphReconstructionRequested(Asset.Value);
		}
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_SubGraph:PostPropertyChanged")]
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
		QuestCustom_SubGraph questCustom_SubGraph = new QuestCustom_SubGraph();
		if (Asset.ObjectPath.IsValid)
		{
			if (!Asset.IsValid)
			{
				UBGWAssetLoader.SyncLoadObject(Asset.ObjectPath);
			}
			if (Asset.IsValid)
			{
				Asset.Value.ExportToData();
				questCustom_SubGraph.AssetPath = Asset.LongPackageName;
			}
		}
		return questCustom_SubGraph.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SubGraph;
	}

	static BED_TaskNode_SubGraph()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_SubGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_SubGraph));
		StartPin = B1GlobalFNames.Start;
		FinishPin = B1GlobalFNames.Finish;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_SubGraph:GetAssetToEditInCS")]
	private static void GetAssetToEditInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_SubGraph bED_TaskNode_SubGraph = GCHelper.Find<BED_TaskNode_SubGraph>(obj);
		UObject assetToEditInCS_Implementation = bED_TaskNode_SubGraph.GetAssetToEditInCS_Implementation();
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetAssetToEditInCS_ReturnValue_Offset), assetToEditInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_SubGraph:PrePropertyChanged")]
	private static void PrePropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_SubGraph bED_TaskNode_SubGraph = GCHelper.Find<BED_TaskNode_SubGraph>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PrePropertyChanged_PropertyName_Offset));
		bED_TaskNode_SubGraph.PrePropertyChanged_Implementation(propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_SubGraph:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_SubGraph bED_TaskNode_SubGraph = GCHelper.Find<BED_TaskNode_SubGraph>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_TaskNode_SubGraph.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_SubGraph:GetContextInputsInCS")]
	private static void GetContextInputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_SubGraph bED_TaskNode_SubGraph = GCHelper.Find<BED_TaskNode_SubGraph>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextInputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextInputsInCS_Implementation = bED_TaskNode_SubGraph.GetContextInputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextInputsInCS_ReturnValue_Offset), contextInputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_SubGraph:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_SubGraph bED_TaskNode_SubGraph = GCHelper.Find<BED_TaskNode_SubGraph>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_TaskNode_SubGraph.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_SubGraph:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_SubGraph bED_TaskNode_SubGraph = GCHelper.Find<BED_TaskNode_SubGraph>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_SubGraph.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_SubGraph");
		Asset_Offset = NativeReflection.GetPropertyOffset(intPtr, "Asset");
		Asset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Asset", Classes.FSoftObjectProperty);
		GetAssetToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetToEditInCS");
		GetAssetToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetToEditInCS_FunctionAddress);
		GetAssetToEditInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAssetToEditInCS_FunctionAddress, "ReturnValue");
		GetAssetToEditInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAssetToEditInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetToEditInCS_IsValid = GetAssetToEditInCS_FunctionAddress != IntPtr.Zero && GetAssetToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_SubGraph:GetAssetToEditInCS", GetAssetToEditInCS_IsValid);
		PrePropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrePropertyChanged");
		PrePropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PrePropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrePropertyChanged_PropertyName_PropertyAddress, PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PrePropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PrePropertyChanged_IsValid = PrePropertyChanged_FunctionAddress != IntPtr.Zero && PrePropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_SubGraph:PrePropertyChanged", PrePropertyChanged_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_SubGraph:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextInputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextInputsInCS");
		GetContextInputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextInputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextInputsInCS_ReturnValue_PropertyAddress, GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextInputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextInputsInCS_IsValid = GetContextInputsInCS_FunctionAddress != IntPtr.Zero && GetContextInputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_SubGraph:GetContextInputsInCS", GetContextInputsInCS_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_SubGraph:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_SubGraph:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}
}
