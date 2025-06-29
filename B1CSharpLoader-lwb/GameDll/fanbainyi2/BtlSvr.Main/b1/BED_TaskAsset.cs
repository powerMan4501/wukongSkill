using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BED_TaskAsset")]
public class BED_TaskAsset : BED_CalliopeAssetBase
{
	private static bool ManagedObjectsForTask_IsValid;

	private static int ManagedObjectsForTask_Offset;

	private static bool GetViewType_IsValid;

	private static IntPtr GetViewType_FunctionAddress;

	private static int GetViewType_ParamsSize;

	private static bool GetViewType_ReturnValue_IsValid;

	private static int GetViewType_ReturnValue_Offset;

	private static FFieldAddress GetViewType_ReturnValue_PropertyAddress;

	private static bool IsEditorOnlyCS_IsValid;

	private static IntPtr IsEditorOnlyCS_FunctionAddress;

	private static int IsEditorOnlyCS_ParamsSize;

	private static bool IsEditorOnlyCS_ReturnValue_IsValid;

	private static int IsEditorOnlyCS_ReturnValue_Offset;

	private static FFieldAddress IsEditorOnlyCS_ReturnValue_PropertyAddress;

	private static bool GetStartNodeClass_IsValid;

	private static IntPtr GetStartNodeClass_FunctionAddress;

	private static int GetStartNodeClass_ParamsSize;

	private static bool GetStartNodeClass_ReturnValue_IsValid;

	private static int GetStartNodeClass_ReturnValue_Offset;

	private static bool GetActorGuidOptions_IsValid;

	private static IntPtr GetActorGuidOptions_FunctionAddress;

	private static int GetActorGuidOptions_ParamsSize;

	private static bool GetActorGuidOptions_PropertyName_IsValid;

	private static int GetActorGuidOptions_PropertyName_Offset;

	private static FFieldAddress GetActorGuidOptions_PropertyName_PropertyAddress;

	private static bool GetActorGuidOptions_OutOptions_IsValid;

	private static int GetActorGuidOptions_OutOptions_Offset;

	private static FFieldAddress GetActorGuidOptions_OutOptions_PropertyAddress;

	private static bool GetActorGuidOptions_ReturnValue_IsValid;

	private static int GetActorGuidOptions_ReturnValue_Offset;

	private static bool GetRerouteNodeClass_IsValid;

	private static IntPtr GetRerouteNodeClass_FunctionAddress;

	private static int GetRerouteNodeClass_ParamsSize;

	private static bool GetRerouteNodeClass_ReturnValue_IsValid;

	private static int GetRerouteNodeClass_ReturnValue_Offset;

	private static bool GetExtraDefaultInputNodes_IsValid;

	private static IntPtr GetExtraDefaultInputNodes_FunctionAddress;

	private static int GetExtraDefaultInputNodes_ParamsSize;

	private static bool GetExtraDefaultInputNodes_OutClasses_IsValid;

	private static int GetExtraDefaultInputNodes_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultInputNodes_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultInputNodes_ReturnValue_IsValid;

	private static int GetExtraDefaultInputNodes_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodes_IsValid;

	private static IntPtr GetExtraDefaultOutputNodes_FunctionAddress;

	private static int GetExtraDefaultOutputNodes_ParamsSize;

	private static bool GetExtraDefaultOutputNodes_OutClasses_IsValid;

	private static int GetExtraDefaultOutputNodes_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultOutputNodes_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultOutputNodes_ReturnValue_IsValid;

	private static int GetExtraDefaultOutputNodes_ReturnValue_Offset;

	private static bool GetStartNodeClassInBranchGraph_IsValid;

	private static IntPtr GetStartNodeClassInBranchGraph_FunctionAddress;

	private static int GetStartNodeClassInBranchGraph_ParamsSize;

	private static bool GetStartNodeClassInBranchGraph_ReturnValue_IsValid;

	private static int GetStartNodeClassInBranchGraph_ReturnValue_Offset;

	private static bool GetRerouteNodeClassInBranchGraph_IsValid;

	private static IntPtr GetRerouteNodeClassInBranchGraph_FunctionAddress;

	private static int GetRerouteNodeClassInBranchGraph_ParamsSize;

	private static bool GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;

	private static int GetRerouteNodeClassInBranchGraph_ReturnValue_Offset;

	private static bool GetExtraDefaultInputNodesInBranchGraph_IsValid;

	private static IntPtr GetExtraDefaultInputNodesInBranchGraph_FunctionAddress;

	private static int GetExtraDefaultInputNodesInBranchGraph_ParamsSize;

	private static bool GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid;

	private static int GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;

	private static int GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_IsValid;

	private static IntPtr GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress;

	private static int GetExtraDefaultOutputNodesInBranchGraph_ParamsSize;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid;

	private static int GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;

	private static int GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_TaskAsset:ManagedObjectsForTask")]
	public FManagedObjectsForTask ManagedObjectsForTask
	{
		get
		{
			CheckDestroyed();
			if (!ManagedObjectsForTask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskAsset:ManagedObjectsForTask");
				return default(FManagedObjectsForTask);
			}
			return FManagedObjectsForTask.FromNative(IntPtr.Add(base.Address, ManagedObjectsForTask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ManagedObjectsForTask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskAsset:ManagedObjectsForTask");
			}
			else
			{
				FManagedObjectsForTask.ToNative(IntPtr.Add(base.Address, ManagedObjectsForTask_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetActorGuidOptions")]
	public override int GetActorGuidOptions_Implementation(string PropertyName, out List<FActorGuidOption> OutOptions)
	{
		OutOptions = new List<FActorGuidOption>();
		if (PropertyName == "ObserveUnitGuid" || PropertyName == "QueryUnitGuid")
		{
			foreach (FManagedTaskUnit item in ManagedObjectsForTask.TaskUnitCollection)
			{
				OutOptions.Add(new FActorGuidOption
				{
					ActorGuid = item.ActorGuid,
					DisplayName = item.GetDisplayName()
				});
			}
		}
		if (PropertyName == "ObserveObjGuid")
		{
			foreach (FManagedTaskObj item2 in ManagedObjectsForTask.TaskObjCollection)
			{
				OutOptions.Add(new FActorGuidOption
				{
					ActorGuid = item2.ActorGuid,
					DisplayName = item2.GetDisplayName()
				});
			}
		}
		return OutOptions.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:IsEditorOnlyCS")]
	protected override bool IsEditorOnlyCS_Implementation()
	{
		return true;
	}

	public override bool HasDeleteNodeLimit()
	{
		return true;
	}

	protected override bool CanCalliopeAssetNodeLog()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetViewType")]
	protected override ECalliopeViewType GetViewType_Implementation()
	{
		return ECalliopeViewType.Task;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetRerouteNodeClass")]
	protected override TSubclassOf<UObject> GetRerouteNodeClass_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetStartNodeClass")]
	protected override TSubclassOf<UObject> GetStartNodeClass_Implementation()
	{
		return UClass.GetClass<BED_TaskNode_Start>();
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultInputNodes")]
	protected override int GetExtraDefaultInputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultOutputNodes")]
	protected override int GetExtraDefaultOutputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetRerouteNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetRerouteNodeClassInBranchGraph_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetStartNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetStartNodeClassInBranchGraph_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultInputNodesInBranchGraph")]
	protected override int GetExtraDefaultInputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	protected override int GetExtraDefaultOutputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetViewType")]
	private static void GetViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		ECalliopeViewType viewType_Implementation = bED_TaskAsset.GetViewType_Implementation();
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(buffer, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address, viewType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:IsEditorOnlyCS")]
	private static void IsEditorOnlyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		bool value = bED_TaskAsset.IsEditorOnlyCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsEditorOnlyCS_ReturnValue_Offset), 0, IsEditorOnlyCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetStartNodeClass")]
	private static void GetStartNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TSubclassOf<UObject> startNodeClass_Implementation = bED_TaskAsset.GetStartNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClass_ReturnValue_Offset), startNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetActorGuidOptions")]
	private static void GetActorGuidOptions__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetActorGuidOptions_PropertyName_Offset));
		TArrayCopyMarshaler<FActorGuidOption> tArrayCopyMarshaler = new TArrayCopyMarshaler<FActorGuidOption>(1, GetActorGuidOptions_OutOptions_PropertyAddress, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.FromNative, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.ToNative);
		List<FActorGuidOption> OutOptions = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetActorGuidOptions_OutOptions_Offset));
		int actorGuidOptions_Implementation = bED_TaskAsset.GetActorGuidOptions_Implementation(propertyName, out OutOptions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetActorGuidOptions_ReturnValue_Offset), actorGuidOptions_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidOptions_OutOptions_Offset), OutOptions);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetRerouteNodeClass")]
	private static void GetRerouteNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClass_Implementation = bED_TaskAsset.GetRerouteNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClass_ReturnValue_Offset), rerouteNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultInputNodes")]
	private static void GetExtraDefaultInputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset));
		int extraDefaultInputNodes_Implementation = bED_TaskAsset.GetExtraDefaultInputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_ReturnValue_Offset), extraDefaultInputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultOutputNodes")]
	private static void GetExtraDefaultOutputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset));
		int extraDefaultOutputNodes_Implementation = bED_TaskAsset.GetExtraDefaultOutputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_ReturnValue_Offset), extraDefaultOutputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetStartNodeClassInBranchGraph")]
	private static void GetStartNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TSubclassOf<UObject> startNodeClassInBranchGraph_Implementation = bED_TaskAsset.GetStartNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClassInBranchGraph_ReturnValue_Offset), startNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetRerouteNodeClassInBranchGraph")]
	private static void GetRerouteNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClassInBranchGraph_Implementation = bED_TaskAsset.GetRerouteNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClassInBranchGraph_ReturnValue_Offset), rerouteNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultInputNodesInBranchGraph")]
	private static void GetExtraDefaultInputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultInputNodesInBranchGraph_Implementation = bED_TaskAsset.GetExtraDefaultInputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset), extraDefaultInputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	private static void GetExtraDefaultOutputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskAsset bED_TaskAsset = GCHelper.Find<BED_TaskAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultOutputNodesInBranchGraph_Implementation = bED_TaskAsset.GetExtraDefaultOutputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset), extraDefaultOutputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskAsset");
		ManagedObjectsForTask_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManagedObjectsForTask");
		ManagedObjectsForTask_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManagedObjectsForTask", Classes.FStructProperty);
		GetViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewType");
		GetViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetViewType_ReturnValue_PropertyAddress, GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetViewType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetViewType_IsValid = GetViewType_FunctionAddress != IntPtr.Zero && GetViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetViewType", GetViewType_IsValid);
		IsEditorOnlyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEditorOnlyCS");
		IsEditorOnlyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditorOnlyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsEditorOnlyCS_ReturnValue_PropertyAddress, IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsEditorOnlyCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditorOnlyCS_IsValid = IsEditorOnlyCS_FunctionAddress != IntPtr.Zero && IsEditorOnlyCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:IsEditorOnlyCS", IsEditorOnlyCS_IsValid);
		GetStartNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartNodeClass");
		GetStartNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClass_FunctionAddress);
		GetStartNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClass_IsValid = GetStartNodeClass_FunctionAddress != IntPtr.Zero && GetStartNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetStartNodeClass", GetStartNodeClass_IsValid);
		GetActorGuidOptions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidOptions");
		GetActorGuidOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidOptions_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidOptions_PropertyName_PropertyAddress, GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidOptions_OutOptions_PropertyAddress, GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "OutOptions", Classes.FArrayProperty);
		GetActorGuidOptions_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "ReturnValue");
		GetActorGuidOptions_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActorGuidOptions_IsValid = GetActorGuidOptions_FunctionAddress != IntPtr.Zero && GetActorGuidOptions_PropertyName_IsValid && GetActorGuidOptions_OutOptions_IsValid && GetActorGuidOptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetActorGuidOptions", GetActorGuidOptions_IsValid);
		GetRerouteNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRerouteNodeClass");
		GetRerouteNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClass_FunctionAddress);
		GetRerouteNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClass_IsValid = GetRerouteNodeClass_FunctionAddress != IntPtr.Zero && GetRerouteNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetRerouteNodeClass", GetRerouteNodeClass_IsValid);
		GetExtraDefaultInputNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultInputNodes");
		GetExtraDefaultInputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodes_OutClasses_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodes_IsValid = GetExtraDefaultInputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodes_OutClasses_IsValid && GetExtraDefaultInputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultInputNodes", GetExtraDefaultInputNodes_IsValid);
		GetExtraDefaultOutputNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultOutputNodes");
		GetExtraDefaultOutputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodes_IsValid = GetExtraDefaultOutputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodes_OutClasses_IsValid && GetExtraDefaultOutputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultOutputNodes", GetExtraDefaultOutputNodes_IsValid);
		GetStartNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartNodeClassInBranchGraph");
		GetStartNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClassInBranchGraph_FunctionAddress);
		GetStartNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetStartNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClassInBranchGraph_IsValid = GetStartNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetStartNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetStartNodeClassInBranchGraph", GetStartNodeClassInBranchGraph_IsValid);
		GetRerouteNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRerouteNodeClassInBranchGraph");
		GetRerouteNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClassInBranchGraph_FunctionAddress);
		GetRerouteNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClassInBranchGraph_IsValid = GetRerouteNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetRerouteNodeClassInBranchGraph", GetRerouteNodeClassInBranchGraph_IsValid);
		GetExtraDefaultInputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultInputNodesInBranchGraph");
		GetExtraDefaultInputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodesInBranchGraph_IsValid = GetExtraDefaultInputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultInputNodesInBranchGraph", GetExtraDefaultInputNodesInBranchGraph_IsValid);
		GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultOutputNodesInBranchGraph");
		GetExtraDefaultOutputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodesInBranchGraph_IsValid = GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskAsset:GetExtraDefaultOutputNodesInBranchGraph", GetExtraDefaultOutputNodesInBranchGraph_IsValid);
	}

	static BED_TaskAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskAsset));
	}
}
