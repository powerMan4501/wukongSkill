using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BED_DialogueAsset")]
public class BED_DialogueAsset : BED_CalliopeAssetBase
{
	private static bool GetViewType_IsValid;

	private static IntPtr GetViewType_FunctionAddress;

	private static int GetViewType_ParamsSize;

	private static bool GetViewType_ReturnValue_IsValid;

	private static int GetViewType_ReturnValue_Offset;

	private static FFieldAddress GetViewType_ReturnValue_PropertyAddress;

	private static bool GetStartNodeClass_IsValid;

	private static IntPtr GetStartNodeClass_FunctionAddress;

	private static int GetStartNodeClass_ParamsSize;

	private static bool GetStartNodeClass_ReturnValue_IsValid;

	private static int GetStartNodeClass_ReturnValue_Offset;

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

	public override bool IsStartNodeNecessary()
	{
		return false;
	}

	protected override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		new List<FGameplayTag>();
		new List<FGameplayTag>();
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> node in base.Nodes)
		{
			if (node.Value.NodeHasError)
			{
				node.Value.NodeHasError = false;
			}
			BED_BehaviorNode bED_BehaviorNode = node.Value as BED_BehaviorNode;
			if (!(bED_BehaviorNode != null))
			{
				continue;
			}
			foreach (FCalliopePin outputPin in bED_BehaviorNode.GetOutputPins())
			{
				FCalliopeConnectedPin connection = bED_BehaviorNode.GetConnection(outputPin.PinName);
				BED_BehaviorNode bED_BehaviorNode2 = base.Nodes[connection.NodeGuid] as BED_BehaviorNode;
				if (!(bED_BehaviorNode2 == null) && ((bED_BehaviorNode.NodeSide == EBehaviorNodeSide.RightNode && bED_BehaviorNode2.NodeSide == EBehaviorNodeSide.LeftNode) || (bED_BehaviorNode is BED_BehaviorNode_ListenerTrigger && bED_BehaviorNode2.NodeSide == EBehaviorNodeSide.LeftNode)))
				{
					bED_BehaviorNode.NodeHasError = true;
					bED_BehaviorNode2.NodeHasError = true;
					flag = true;
					stringBuilder.AppendLine(bED_BehaviorNode.GetNodeName() + " 右侧不能连接 " + bED_BehaviorNode2.GetNodeName());
				}
			}
		}
		OutErrorMessage = stringBuilder.ToString();
		if (flag)
		{
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetViewType")]
	protected override ECalliopeViewType GetViewType_Implementation()
	{
		return ECalliopeViewType.Dialogue;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetRerouteNodeClass")]
	protected override TSubclassOf<UObject> GetRerouteNodeClass_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetStartNodeClass")]
	protected override TSubclassOf<UObject> GetStartNodeClass_Implementation()
	{
		return UClass.GetClass<b1.BED_BehaviorNode_Start>();
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultInputNodes")]
	protected override int GetExtraDefaultInputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultOutputNodes")]
	protected override int GetExtraDefaultOutputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetRerouteNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetRerouteNodeClassInBranchGraph_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetStartNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetStartNodeClassInBranchGraph_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultInputNodesInBranchGraph")]
	protected override int GetExtraDefaultInputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	protected override int GetExtraDefaultOutputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetViewType")]
	private static void GetViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		ECalliopeViewType viewType_Implementation = bED_DialogueAsset.GetViewType_Implementation();
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(buffer, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address, viewType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetStartNodeClass")]
	private static void GetStartNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TSubclassOf<UObject> startNodeClass_Implementation = bED_DialogueAsset.GetStartNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClass_ReturnValue_Offset), startNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetRerouteNodeClass")]
	private static void GetRerouteNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClass_Implementation = bED_DialogueAsset.GetRerouteNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClass_ReturnValue_Offset), rerouteNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultInputNodes")]
	private static void GetExtraDefaultInputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset));
		int extraDefaultInputNodes_Implementation = bED_DialogueAsset.GetExtraDefaultInputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_ReturnValue_Offset), extraDefaultInputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultOutputNodes")]
	private static void GetExtraDefaultOutputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset));
		int extraDefaultOutputNodes_Implementation = bED_DialogueAsset.GetExtraDefaultOutputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_ReturnValue_Offset), extraDefaultOutputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetStartNodeClassInBranchGraph")]
	private static void GetStartNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TSubclassOf<UObject> startNodeClassInBranchGraph_Implementation = bED_DialogueAsset.GetStartNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClassInBranchGraph_ReturnValue_Offset), startNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetRerouteNodeClassInBranchGraph")]
	private static void GetRerouteNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClassInBranchGraph_Implementation = bED_DialogueAsset.GetRerouteNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClassInBranchGraph_ReturnValue_Offset), rerouteNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultInputNodesInBranchGraph")]
	private static void GetExtraDefaultInputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultInputNodesInBranchGraph_Implementation = bED_DialogueAsset.GetExtraDefaultInputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset), extraDefaultInputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	private static void GetExtraDefaultOutputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_DialogueAsset bED_DialogueAsset = GCHelper.Find<BED_DialogueAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultOutputNodesInBranchGraph_Implementation = bED_DialogueAsset.GetExtraDefaultOutputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset), extraDefaultOutputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_DialogueAsset");
		GetViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewType");
		GetViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetViewType_ReturnValue_PropertyAddress, GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetViewType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetViewType_IsValid = GetViewType_FunctionAddress != IntPtr.Zero && GetViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetViewType", GetViewType_IsValid);
		GetStartNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartNodeClass");
		GetStartNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClass_FunctionAddress);
		GetStartNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClass_IsValid = GetStartNodeClass_FunctionAddress != IntPtr.Zero && GetStartNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetStartNodeClass", GetStartNodeClass_IsValid);
		GetRerouteNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRerouteNodeClass");
		GetRerouteNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClass_FunctionAddress);
		GetRerouteNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClass_IsValid = GetRerouteNodeClass_FunctionAddress != IntPtr.Zero && GetRerouteNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetRerouteNodeClass", GetRerouteNodeClass_IsValid);
		GetExtraDefaultInputNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultInputNodes");
		GetExtraDefaultInputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodes_OutClasses_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodes_IsValid = GetExtraDefaultInputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodes_OutClasses_IsValid && GetExtraDefaultInputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultInputNodes", GetExtraDefaultInputNodes_IsValid);
		GetExtraDefaultOutputNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultOutputNodes");
		GetExtraDefaultOutputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodes_IsValid = GetExtraDefaultOutputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodes_OutClasses_IsValid && GetExtraDefaultOutputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultOutputNodes", GetExtraDefaultOutputNodes_IsValid);
		GetStartNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartNodeClassInBranchGraph");
		GetStartNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClassInBranchGraph_FunctionAddress);
		GetStartNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetStartNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClassInBranchGraph_IsValid = GetStartNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetStartNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetStartNodeClassInBranchGraph", GetStartNodeClassInBranchGraph_IsValid);
		GetRerouteNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRerouteNodeClassInBranchGraph");
		GetRerouteNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClassInBranchGraph_FunctionAddress);
		GetRerouteNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClassInBranchGraph_IsValid = GetRerouteNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetRerouteNodeClassInBranchGraph", GetRerouteNodeClassInBranchGraph_IsValid);
		GetExtraDefaultInputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultInputNodesInBranchGraph");
		GetExtraDefaultInputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodesInBranchGraph_IsValid = GetExtraDefaultInputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultInputNodesInBranchGraph", GetExtraDefaultInputNodesInBranchGraph_IsValid);
		GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultOutputNodesInBranchGraph");
		GetExtraDefaultOutputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodesInBranchGraph_IsValid = GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_DialogueAsset:GetExtraDefaultOutputNodesInBranchGraph", GetExtraDefaultOutputNodesInBranchGraph_IsValid);
	}

	static BED_DialogueAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_DialogueAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_DialogueAsset));
	}
}
