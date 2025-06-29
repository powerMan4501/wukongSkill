using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_SubGraph")]
public class BED_FSMNode_SubGraph : BED_FSMNode
{
	private static bool SubGraphAsset_IsValid;

	private static int SubGraphAsset_Offset;

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

	[EditDefaultsOnly]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_SubGraph:SubGraphAsset")]
	public TSoftObject<BED_FSMAsset> SubGraphAsset
	{
		get
		{
			CheckDestroyed();
			if (!SubGraphAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_SubGraph:SubGraphAsset");
				return default(TSoftObject<BED_FSMAsset>);
			}
			return TSoftObjectMarshaler<BED_FSMAsset>.FromNative(IntPtr.Add(base.Address, SubGraphAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubGraphAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_SubGraph:SubGraphAsset");
			}
			else
			{
				TSoftObjectMarshaler<BED_FSMAsset>.ToNative(IntPtr.Add(base.Address, SubGraphAsset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeStyle(GetNodeStyle());
	}

	protected virtual ECalliopeNodeStyle GetNodeStyle()
	{
		return ECalliopeNodeStyle.SubGraph;
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_SubGraph:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (!SubGraphAsset.IsNull)
		{
			return FPaths.GetBaseFilename(SubGraphAsset.AssetPathName, removePath: false);
		}
		return "";
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_SubGraph:GetAssetToEditInCS")]
	protected override UObject GetAssetToEditInCS_Implementation()
	{
		if (!SubGraphAsset.IsNull)
		{
			return SubGraphAsset.LoadSynchronous();
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_SubGraph:PrePropertyChanged")]
	protected override void PrePropertyChanged_Implementation(string PropertyName)
	{
		if (PropertyName.Equals("SubGraphAsset") && !SubGraphAsset.IsNull)
		{
			UnBindAssetOnSubGraphReconstructionRequested(SubGraphAsset.Value);
		}
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_SubGraph:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("SubGraphAsset"))
		{
			ExecuteOnReconstructionRequested();
			SubscribeToAssetChanges();
		}
	}

	private void SubscribeToAssetChanges()
	{
		if (!SubGraphAsset.IsNull)
		{
			BindAssetOnSubGraphReconstructionRequested(SubGraphAsset.Value);
		}
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		if (SubGraphAsset.IsNull)
		{
			OutErrorMessage = "SubGraph: Asset不能为空";
			return false;
		}
		return base.CorrectnessCheck(out OutErrorMessage);
	}

	protected virtual bool TryOverrideOutputPins(out List<FCalliopePin> OverrideOutputPins)
	{
		OverrideOutputPins = new List<FCalliopePin>();
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_SubGraph:GetAssetToEditInCS")]
	private static void GetAssetToEditInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_SubGraph bED_FSMNode_SubGraph = GCHelper.Find<BED_FSMNode_SubGraph>(obj);
		UObject assetToEditInCS_Implementation = bED_FSMNode_SubGraph.GetAssetToEditInCS_Implementation();
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetAssetToEditInCS_ReturnValue_Offset), assetToEditInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_SubGraph:PrePropertyChanged")]
	private static void PrePropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_SubGraph bED_FSMNode_SubGraph = GCHelper.Find<BED_FSMNode_SubGraph>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PrePropertyChanged_PropertyName_Offset));
		bED_FSMNode_SubGraph.PrePropertyChanged_Implementation(propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_SubGraph:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_SubGraph bED_FSMNode_SubGraph = GCHelper.Find<BED_FSMNode_SubGraph>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_FSMNode_SubGraph.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_SubGraph:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_SubGraph bED_FSMNode_SubGraph = GCHelper.Find<BED_FSMNode_SubGraph>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_SubGraph.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_SubGraph");
		SubGraphAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SubGraphAsset");
		SubGraphAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SubGraphAsset", Classes.FSoftObjectProperty);
		GetAssetToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetToEditInCS");
		GetAssetToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetToEditInCS_FunctionAddress);
		GetAssetToEditInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAssetToEditInCS_FunctionAddress, "ReturnValue");
		GetAssetToEditInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAssetToEditInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetToEditInCS_IsValid = GetAssetToEditInCS_FunctionAddress != IntPtr.Zero && GetAssetToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_SubGraph:GetAssetToEditInCS", GetAssetToEditInCS_IsValid);
		PrePropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrePropertyChanged");
		PrePropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PrePropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrePropertyChanged_PropertyName_PropertyAddress, PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PrePropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PrePropertyChanged_IsValid = PrePropertyChanged_FunctionAddress != IntPtr.Zero && PrePropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_SubGraph:PrePropertyChanged", PrePropertyChanged_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_SubGraph:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_SubGraph:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_SubGraph()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_SubGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_SubGraph));
	}
}
