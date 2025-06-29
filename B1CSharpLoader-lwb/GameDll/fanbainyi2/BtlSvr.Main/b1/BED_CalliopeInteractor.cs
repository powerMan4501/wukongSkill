using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor")]
public class BED_CalliopeInteractor : UCalliopeInteractor
{
	private static bool GetStartNodeClasses_IsValid;

	private static IntPtr GetStartNodeClasses_FunctionAddress;

	private static int GetStartNodeClasses_ParamsSize;

	private static bool GetStartNodeClasses_OutClasses_IsValid;

	private static int GetStartNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetStartNodeClasses_OutClasses_PropertyAddress;

	private static bool GetStartNodeClasses_ReturnValue_IsValid;

	private static int GetStartNodeClasses_ReturnValue_Offset;

	private static bool GetFinishNodeClasses_IsValid;

	private static IntPtr GetFinishNodeClasses_FunctionAddress;

	private static int GetFinishNodeClasses_ParamsSize;

	private static bool GetFinishNodeClasses_OutClasses_IsValid;

	private static int GetFinishNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetFinishNodeClasses_OutClasses_PropertyAddress;

	private static bool GetFinishNodeClasses_ReturnValue_IsValid;

	private static int GetFinishNodeClasses_ReturnValue_Offset;

	private static bool GetRerouteNodeClasses_IsValid;

	private static IntPtr GetRerouteNodeClasses_FunctionAddress;

	private static int GetRerouteNodeClasses_ParamsSize;

	private static bool GetRerouteNodeClasses_OutClasses_IsValid;

	private static int GetRerouteNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetRerouteNodeClasses_OutClasses_PropertyAddress;

	private static bool GetRerouteNodeClasses_ReturnValue_IsValid;

	private static int GetRerouteNodeClasses_ReturnValue_Offset;

	private static bool GetSubGraphNodeClasses_IsValid;

	private static IntPtr GetSubGraphNodeClasses_FunctionAddress;

	private static int GetSubGraphNodeClasses_ParamsSize;

	private static bool GetSubGraphNodeClasses_OutClasses_IsValid;

	private static int GetSubGraphNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetSubGraphNodeClasses_OutClasses_PropertyAddress;

	private static bool GetSubGraphNodeClasses_ReturnValue_IsValid;

	private static int GetSubGraphNodeClasses_ReturnValue_Offset;

	private static bool GetCustomInputNodeClasses_IsValid;

	private static IntPtr GetCustomInputNodeClasses_FunctionAddress;

	private static int GetCustomInputNodeClasses_ParamsSize;

	private static bool GetCustomInputNodeClasses_OutClasses_IsValid;

	private static int GetCustomInputNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetCustomInputNodeClasses_OutClasses_PropertyAddress;

	private static bool GetCustomInputNodeClasses_ReturnValue_IsValid;

	private static int GetCustomInputNodeClasses_ReturnValue_Offset;

	private static bool GetCustomOutputNodeClasses_IsValid;

	private static IntPtr GetCustomOutputNodeClasses_FunctionAddress;

	private static int GetCustomOutputNodeClasses_ParamsSize;

	private static bool GetCustomOutputNodeClasses_OutClasses_IsValid;

	private static int GetCustomOutputNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetCustomOutputNodeClasses_OutClasses_PropertyAddress;

	private static bool GetCustomOutputNodeClasses_ReturnValue_IsValid;

	private static int GetCustomOutputNodeClasses_ReturnValue_Offset;

	private static bool SetCustomInputNodeEventName_IsValid;

	private static IntPtr SetCustomInputNodeEventName_FunctionAddress;

	private static int SetCustomInputNodeEventName_ParamsSize;

	private static bool SetCustomInputNodeEventName_Node_IsValid;

	private static int SetCustomInputNodeEventName_Node_Offset;

	private static bool SetCustomInputNodeEventName_InEventName_IsValid;

	private static int SetCustomInputNodeEventName_InEventName_Offset;

	private static bool SetCustomInputNodeEventName_ReturnValue_IsValid;

	private static int SetCustomInputNodeEventName_ReturnValue_Offset;

	private static FFieldAddress SetCustomInputNodeEventName_ReturnValue_PropertyAddress;

	private static bool GetCustomInputNodeEventName_IsValid;

	private static IntPtr GetCustomInputNodeEventName_FunctionAddress;

	private static int GetCustomInputNodeEventName_ParamsSize;

	private static bool GetCustomInputNodeEventName_Node_IsValid;

	private static int GetCustomInputNodeEventName_Node_Offset;

	private static bool GetCustomInputNodeEventName_OutEventName_IsValid;

	private static int GetCustomInputNodeEventName_OutEventName_Offset;

	private static bool GetCustomInputNodeEventName_ReturnValue_IsValid;

	private static int GetCustomInputNodeEventName_ReturnValue_Offset;

	private static FFieldAddress GetCustomInputNodeEventName_ReturnValue_PropertyAddress;

	private static bool SetCustomOutputNodeEventName_IsValid;

	private static IntPtr SetCustomOutputNodeEventName_FunctionAddress;

	private static int SetCustomOutputNodeEventName_ParamsSize;

	private static bool SetCustomOutputNodeEventName_Node_IsValid;

	private static int SetCustomOutputNodeEventName_Node_Offset;

	private static bool SetCustomOutputNodeEventName_InEventName_IsValid;

	private static int SetCustomOutputNodeEventName_InEventName_Offset;

	private static bool SetCustomOutputNodeEventName_ReturnValue_IsValid;

	private static int SetCustomOutputNodeEventName_ReturnValue_Offset;

	private static FFieldAddress SetCustomOutputNodeEventName_ReturnValue_PropertyAddress;

	private static bool GetCustomOutputNodeEventName_IsValid;

	private static IntPtr GetCustomOutputNodeEventName_FunctionAddress;

	private static int GetCustomOutputNodeEventName_ParamsSize;

	private static bool GetCustomOutputNodeEventName_Node_IsValid;

	private static int GetCustomOutputNodeEventName_Node_Offset;

	private static bool GetCustomOutputNodeEventName_OutEventName_IsValid;

	private static int GetCustomOutputNodeEventName_OutEventName_Offset;

	private static bool GetCustomOutputNodeEventName_ReturnValue_IsValid;

	private static int GetCustomOutputNodeEventName_ReturnValue_Offset;

	private static FFieldAddress GetCustomOutputNodeEventName_ReturnValue_PropertyAddress;

	private static bool GetComponentObserverNodeClasses_IsValid;

	private static IntPtr GetComponentObserverNodeClasses_FunctionAddress;

	private static int GetComponentObserverNodeClasses_ParamsSize;

	private static bool GetComponentObserverNodeClasses_OutClasses_IsValid;

	private static int GetComponentObserverNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetComponentObserverNodeClasses_OutClasses_PropertyAddress;

	private static bool GetComponentObserverNodeClasses_ReturnValue_IsValid;

	private static int GetComponentObserverNodeClasses_ReturnValue_Offset;

	private static bool GetExecutionSequenceNodeClasses_IsValid;

	private static IntPtr GetExecutionSequenceNodeClasses_FunctionAddress;

	private static int GetExecutionSequenceNodeClasses_ParamsSize;

	private static bool GetExecutionSequenceNodeClasses_OutClasses_IsValid;

	private static int GetExecutionSequenceNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress;

	private static bool GetExecutionSequenceNodeClasses_ReturnValue_IsValid;

	private static int GetExecutionSequenceNodeClasses_ReturnValue_Offset;

	private static bool GetExecutionMultiGateNodeClasses_IsValid;

	private static IntPtr GetExecutionMultiGateNodeClasses_FunctionAddress;

	private static int GetExecutionMultiGateNodeClasses_ParamsSize;

	private static bool GetExecutionMultiGateNodeClasses_OutClasses_IsValid;

	private static int GetExecutionMultiGateNodeClasses_OutClasses_Offset;

	private static FFieldAddress GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress;

	private static bool GetExecutionMultiGateNodeClasses_ReturnValue_IsValid;

	private static int GetExecutionMultiGateNodeClasses_ReturnValue_Offset;

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:SetCustomInputNodeEventName")]
	protected override bool SetCustomInputNodeEventName_Implementation(UCalliopeNode Node, FName InEventName)
	{
		BED_QuestNode_CustomInput bED_QuestNode_CustomInput = Node.Cast<BED_QuestNode_CustomInput>();
		if (bED_QuestNode_CustomInput == null)
		{
			return false;
		}
		bED_QuestNode_CustomInput.EventName = InEventName;
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:SetCustomOutputNodeEventName")]
	protected override bool SetCustomOutputNodeEventName_Implementation(UCalliopeNode Node, FName InEventName)
	{
		BED_QuestNode_CustomOutput bED_QuestNode_CustomOutput = Node.Cast<BED_QuestNode_CustomOutput>();
		if (bED_QuestNode_CustomOutput == null)
		{
			return false;
		}
		bED_QuestNode_CustomOutput.EventName = InEventName;
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomOutputNodeEventName")]
	protected override bool GetCustomOutputNodeEventName_Implementation(UCalliopeNode Node, out FName OutEventName)
	{
		OutEventName = FName.None;
		BED_QuestNode_CustomOutput bED_QuestNode_CustomOutput = Node.Cast<BED_QuestNode_CustomOutput>();
		if (bED_QuestNode_CustomOutput == null)
		{
			return false;
		}
		OutEventName = bED_QuestNode_CustomOutput.EventName;
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomInputNodeEventName")]
	protected override bool GetCustomInputNodeEventName_Implementation(UCalliopeNode Node, out FName OutEventName)
	{
		OutEventName = FName.None;
		BED_QuestNode_CustomInput bED_QuestNode_CustomInput = Node.Cast<BED_QuestNode_CustomInput>();
		if (bED_QuestNode_CustomInput == null)
		{
			return false;
		}
		OutEventName = bED_QuestNode_CustomInput.EventName;
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetComponentObserverNodeClasses")]
	protected override int GetComponentObserverNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>> { UClass.GetClass(typeof(BED_QuestNode_ObserveByCondition)) };
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomInputNodeClasses")]
	protected override int GetCustomInputNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>> { UClass.GetClass(typeof(BED_QuestNode_CustomInput)) };
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomOutputNodeClasses")]
	protected override int GetCustomOutputNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>> { UClass.GetClass(typeof(BED_QuestNode_CustomOutput)) };
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetExecutionMultiGateNodeClasses")]
	protected override int GetExecutionMultiGateNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>> { UClass.GetClass(typeof(BED_QuestNode_ExecutionMultiGate)) };
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetExecutionSequenceNodeClasses")]
	protected override int GetExecutionSequenceNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>> { UClass.GetClass(typeof(BED_QuestNode_ExecutionSequence)) };
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetFinishNodeClasses")]
	protected override int GetFinishNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>
		{
			UClass.GetClass(typeof(BED_QuestNode_Finish)),
			UClass.GetClass(typeof(b1.BED_MovieNode_PlayEnd)),
			UClass.GetClass(typeof(b1.BED_MovieNode_Finish)),
			UClass.GetClass(typeof(BED_ProcessMachineNode_Final)),
			UClass.GetClass(typeof(BED_ProcessMachineNode_Terminate))
		};
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetRerouteNodeClasses")]
	protected override int GetRerouteNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>
		{
			UClass.GetClass(typeof(BED_QuestNode_Reroute)),
			UClass.GetClass(typeof(BED_ComboNode_Reroute)),
			UClass.GetClass(typeof(BED_StateNode_Reroute)),
			UClass.GetClass(typeof(BED_ProcessMachineNode_Reroute)),
			UClass.GetClass(typeof(BED_ProcessStateNode_Reroute)),
			UClass.GetClass(typeof(BED_FSMNode_Reroute)),
			UClass.GetClass(typeof(BED_GuideNode_Reroute)),
			UClass.GetClass(typeof(BED_BossRushNode_Reroute))
		};
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetStartNodeClasses")]
	protected override int GetStartNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>
		{
			UClass.GetClass(typeof(BED_QuestNode_Start)),
			UClass.GetClass(typeof(BED_ComboNode_Start)),
			UClass.GetClass(typeof(BED_StateNode_Initial)),
			UClass.GetClass(typeof(b1.BED_BehaviorNode_Start)),
			UClass.GetClass(typeof(b1.BED_SkillNode_Start)),
			UClass.GetClass(typeof(b1.BED_MovieNode_Start)),
			UClass.GetClass(typeof(b1.BED_MovieNode_BeforePlay)),
			UClass.GetClass(typeof(b1.BED_MovieNode_AfterPlay)),
			UClass.GetClass(typeof(b1.BED_MovieNode_OnSkipping)),
			UClass.GetClass(typeof(BED_ProcessMachineNode_Initial)),
			UClass.GetClass(typeof(BED_ProcessStateNode_EnterAction)),
			UClass.GetClass(typeof(BED_ProcessStateNode_ExitAction)),
			UClass.GetClass(typeof(BED_ProcessStateNode_TickAction)),
			UClass.GetClass(typeof(BED_TaskNode_Start))
		};
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeInteractor:GetSubGraphNodeClasses")]
	protected override int GetSubGraphNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>
		{
			UClass.GetClass(typeof(BED_QuestNode_SubGraph)),
			UClass.GetClass(typeof(BED_StateNode_Single))
		};
		return OutClasses.Count;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetStartNodeClasses")]
	private static void GetStartNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetStartNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetStartNodeClasses_OutClasses_Offset));
		int startNodeClasses_Implementation = bED_CalliopeInteractor.GetStartNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetStartNodeClasses_ReturnValue_Offset), startNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetStartNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetFinishNodeClasses")]
	private static void GetFinishNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetFinishNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetFinishNodeClasses_OutClasses_Offset));
		int finishNodeClasses_Implementation = bED_CalliopeInteractor.GetFinishNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetFinishNodeClasses_ReturnValue_Offset), finishNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetFinishNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetRerouteNodeClasses")]
	private static void GetRerouteNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetRerouteNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetRerouteNodeClasses_OutClasses_Offset));
		int rerouteNodeClasses_Implementation = bED_CalliopeInteractor.GetRerouteNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClasses_ReturnValue_Offset), rerouteNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetRerouteNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetSubGraphNodeClasses")]
	private static void GetSubGraphNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetSubGraphNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetSubGraphNodeClasses_OutClasses_Offset));
		int subGraphNodeClasses_Implementation = bED_CalliopeInteractor.GetSubGraphNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetSubGraphNodeClasses_ReturnValue_Offset), subGraphNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSubGraphNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomInputNodeClasses")]
	private static void GetCustomInputNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetCustomInputNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetCustomInputNodeClasses_OutClasses_Offset));
		int customInputNodeClasses_Implementation = bED_CalliopeInteractor.GetCustomInputNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetCustomInputNodeClasses_ReturnValue_Offset), customInputNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetCustomInputNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomOutputNodeClasses")]
	private static void GetCustomOutputNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetCustomOutputNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetCustomOutputNodeClasses_OutClasses_Offset));
		int customOutputNodeClasses_Implementation = bED_CalliopeInteractor.GetCustomOutputNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetCustomOutputNodeClasses_ReturnValue_Offset), customOutputNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetCustomOutputNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:SetCustomInputNodeEventName")]
	private static void SetCustomInputNodeEventName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		UCalliopeNode node = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, SetCustomInputNodeEventName_Node_Offset));
		FName inEventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, SetCustomInputNodeEventName_InEventName_Offset));
		bool value = bED_CalliopeInteractor.SetCustomInputNodeEventName_Implementation(node, inEventName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, SetCustomInputNodeEventName_ReturnValue_Offset), 0, SetCustomInputNodeEventName_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomInputNodeEventName")]
	private static void GetCustomInputNodeEventName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		UCalliopeNode node = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, GetCustomInputNodeEventName_Node_Offset));
		FName OutEventName;
		bool customInputNodeEventName_Implementation = bED_CalliopeInteractor.GetCustomInputNodeEventName_Implementation(node, out OutEventName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetCustomInputNodeEventName_ReturnValue_Offset), 0, GetCustomInputNodeEventName_ReturnValue_PropertyAddress.Address, customInputNodeEventName_Implementation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, GetCustomInputNodeEventName_OutEventName_Offset), OutEventName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:SetCustomOutputNodeEventName")]
	private static void SetCustomOutputNodeEventName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		UCalliopeNode node = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, SetCustomOutputNodeEventName_Node_Offset));
		FName inEventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, SetCustomOutputNodeEventName_InEventName_Offset));
		bool value = bED_CalliopeInteractor.SetCustomOutputNodeEventName_Implementation(node, inEventName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, SetCustomOutputNodeEventName_ReturnValue_Offset), 0, SetCustomOutputNodeEventName_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomOutputNodeEventName")]
	private static void GetCustomOutputNodeEventName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		UCalliopeNode node = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, GetCustomOutputNodeEventName_Node_Offset));
		FName OutEventName;
		bool customOutputNodeEventName_Implementation = bED_CalliopeInteractor.GetCustomOutputNodeEventName_Implementation(node, out OutEventName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetCustomOutputNodeEventName_ReturnValue_Offset), 0, GetCustomOutputNodeEventName_ReturnValue_PropertyAddress.Address, customOutputNodeEventName_Implementation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, GetCustomOutputNodeEventName_OutEventName_Offset), OutEventName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetComponentObserverNodeClasses")]
	private static void GetComponentObserverNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetComponentObserverNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetComponentObserverNodeClasses_OutClasses_Offset));
		int componentObserverNodeClasses_Implementation = bED_CalliopeInteractor.GetComponentObserverNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetComponentObserverNodeClasses_ReturnValue_Offset), componentObserverNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetComponentObserverNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetExecutionSequenceNodeClasses")]
	private static void GetExecutionSequenceNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExecutionSequenceNodeClasses_OutClasses_Offset));
		int executionSequenceNodeClasses_Implementation = bED_CalliopeInteractor.GetExecutionSequenceNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExecutionSequenceNodeClasses_ReturnValue_Offset), executionSequenceNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExecutionSequenceNodeClasses_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeInteractor:GetExecutionMultiGateNodeClasses")]
	private static void GetExecutionMultiGateNodeClasses__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeInteractor bED_CalliopeInteractor = GCHelper.Find<BED_CalliopeInteractor>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExecutionMultiGateNodeClasses_OutClasses_Offset));
		int executionMultiGateNodeClasses_Implementation = bED_CalliopeInteractor.GetExecutionMultiGateNodeClasses_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExecutionMultiGateNodeClasses_ReturnValue_Offset), executionMultiGateNodeClasses_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExecutionMultiGateNodeClasses_OutClasses_Offset), OutClasses);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_CalliopeInteractor");
		GetStartNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartNodeClasses");
		GetStartNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetStartNodeClasses_OutClasses_PropertyAddress, GetStartNodeClasses_FunctionAddress, "OutClasses");
		GetStartNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClasses_FunctionAddress, "OutClasses");
		GetStartNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetStartNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClasses_FunctionAddress, "ReturnValue");
		GetStartNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStartNodeClasses_IsValid = GetStartNodeClasses_FunctionAddress != IntPtr.Zero && GetStartNodeClasses_OutClasses_IsValid && GetStartNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetStartNodeClasses", GetStartNodeClasses_IsValid);
		GetFinishNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFinishNodeClasses");
		GetFinishNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFinishNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetFinishNodeClasses_OutClasses_PropertyAddress, GetFinishNodeClasses_FunctionAddress, "OutClasses");
		GetFinishNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetFinishNodeClasses_FunctionAddress, "OutClasses");
		GetFinishNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetFinishNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetFinishNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetFinishNodeClasses_FunctionAddress, "ReturnValue");
		GetFinishNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetFinishNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFinishNodeClasses_IsValid = GetFinishNodeClasses_FunctionAddress != IntPtr.Zero && GetFinishNodeClasses_OutClasses_IsValid && GetFinishNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetFinishNodeClasses", GetFinishNodeClasses_IsValid);
		GetRerouteNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRerouteNodeClasses");
		GetRerouteNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetRerouteNodeClasses_OutClasses_PropertyAddress, GetRerouteNodeClasses_FunctionAddress, "OutClasses");
		GetRerouteNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClasses_FunctionAddress, "OutClasses");
		GetRerouteNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetRerouteNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClasses_FunctionAddress, "ReturnValue");
		GetRerouteNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRerouteNodeClasses_IsValid = GetRerouteNodeClasses_FunctionAddress != IntPtr.Zero && GetRerouteNodeClasses_OutClasses_IsValid && GetRerouteNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetRerouteNodeClasses", GetRerouteNodeClasses_IsValid);
		GetSubGraphNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSubGraphNodeClasses");
		GetSubGraphNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubGraphNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSubGraphNodeClasses_OutClasses_PropertyAddress, GetSubGraphNodeClasses_FunctionAddress, "OutClasses");
		GetSubGraphNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetSubGraphNodeClasses_FunctionAddress, "OutClasses");
		GetSubGraphNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetSubGraphNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetSubGraphNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSubGraphNodeClasses_FunctionAddress, "ReturnValue");
		GetSubGraphNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSubGraphNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSubGraphNodeClasses_IsValid = GetSubGraphNodeClasses_FunctionAddress != IntPtr.Zero && GetSubGraphNodeClasses_OutClasses_IsValid && GetSubGraphNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetSubGraphNodeClasses", GetSubGraphNodeClasses_IsValid);
		GetCustomInputNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomInputNodeClasses");
		GetCustomInputNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomInputNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCustomInputNodeClasses_OutClasses_PropertyAddress, GetCustomInputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomInputNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetCustomInputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomInputNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetCustomInputNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetCustomInputNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCustomInputNodeClasses_FunctionAddress, "ReturnValue");
		GetCustomInputNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCustomInputNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCustomInputNodeClasses_IsValid = GetCustomInputNodeClasses_FunctionAddress != IntPtr.Zero && GetCustomInputNodeClasses_OutClasses_IsValid && GetCustomInputNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomInputNodeClasses", GetCustomInputNodeClasses_IsValid);
		GetCustomOutputNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomOutputNodeClasses");
		GetCustomOutputNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomOutputNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCustomOutputNodeClasses_OutClasses_PropertyAddress, GetCustomOutputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomOutputNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetCustomOutputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomOutputNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetCustomOutputNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetCustomOutputNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCustomOutputNodeClasses_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCustomOutputNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCustomOutputNodeClasses_IsValid = GetCustomOutputNodeClasses_FunctionAddress != IntPtr.Zero && GetCustomOutputNodeClasses_OutClasses_IsValid && GetCustomOutputNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomOutputNodeClasses", GetCustomOutputNodeClasses_IsValid);
		SetCustomInputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomInputNodeEventName");
		SetCustomInputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomInputNodeEventName_FunctionAddress);
		SetCustomInputNodeEventName_Node_Offset = NativeReflection.GetPropertyOffset(SetCustomInputNodeEventName_FunctionAddress, "Node");
		SetCustomInputNodeEventName_Node_IsValid = NativeReflection.ValidatePropertyClass(SetCustomInputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		SetCustomInputNodeEventName_InEventName_Offset = NativeReflection.GetPropertyOffset(SetCustomInputNodeEventName_FunctionAddress, "InEventName");
		SetCustomInputNodeEventName_InEventName_IsValid = NativeReflection.ValidatePropertyClass(SetCustomInputNodeEventName_FunctionAddress, "InEventName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SetCustomInputNodeEventName_ReturnValue_PropertyAddress, SetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomInputNodeEventName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomInputNodeEventName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SetCustomInputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomInputNodeEventName_IsValid = SetCustomInputNodeEventName_FunctionAddress != IntPtr.Zero && SetCustomInputNodeEventName_Node_IsValid && SetCustomInputNodeEventName_InEventName_IsValid && SetCustomInputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:SetCustomInputNodeEventName", SetCustomInputNodeEventName_IsValid);
		GetCustomInputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomInputNodeEventName");
		GetCustomInputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomInputNodeEventName_FunctionAddress);
		GetCustomInputNodeEventName_Node_Offset = NativeReflection.GetPropertyOffset(GetCustomInputNodeEventName_FunctionAddress, "Node");
		GetCustomInputNodeEventName_Node_IsValid = NativeReflection.ValidatePropertyClass(GetCustomInputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		GetCustomInputNodeEventName_OutEventName_Offset = NativeReflection.GetPropertyOffset(GetCustomInputNodeEventName_FunctionAddress, "OutEventName");
		GetCustomInputNodeEventName_OutEventName_IsValid = NativeReflection.ValidatePropertyClass(GetCustomInputNodeEventName_FunctionAddress, "OutEventName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref GetCustomInputNodeEventName_ReturnValue_PropertyAddress, GetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomInputNodeEventName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomInputNodeEventName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCustomInputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomInputNodeEventName_IsValid = GetCustomInputNodeEventName_FunctionAddress != IntPtr.Zero && GetCustomInputNodeEventName_Node_IsValid && GetCustomInputNodeEventName_OutEventName_IsValid && GetCustomInputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomInputNodeEventName", GetCustomInputNodeEventName_IsValid);
		SetCustomOutputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomOutputNodeEventName");
		SetCustomOutputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomOutputNodeEventName_FunctionAddress);
		SetCustomOutputNodeEventName_Node_Offset = NativeReflection.GetPropertyOffset(SetCustomOutputNodeEventName_FunctionAddress, "Node");
		SetCustomOutputNodeEventName_Node_IsValid = NativeReflection.ValidatePropertyClass(SetCustomOutputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		SetCustomOutputNodeEventName_InEventName_Offset = NativeReflection.GetPropertyOffset(SetCustomOutputNodeEventName_FunctionAddress, "InEventName");
		SetCustomOutputNodeEventName_InEventName_IsValid = NativeReflection.ValidatePropertyClass(SetCustomOutputNodeEventName_FunctionAddress, "InEventName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SetCustomOutputNodeEventName_ReturnValue_PropertyAddress, SetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomOutputNodeEventName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomOutputNodeEventName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SetCustomOutputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomOutputNodeEventName_IsValid = SetCustomOutputNodeEventName_FunctionAddress != IntPtr.Zero && SetCustomOutputNodeEventName_Node_IsValid && SetCustomOutputNodeEventName_InEventName_IsValid && SetCustomOutputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:SetCustomOutputNodeEventName", SetCustomOutputNodeEventName_IsValid);
		GetCustomOutputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomOutputNodeEventName");
		GetCustomOutputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomOutputNodeEventName_FunctionAddress);
		GetCustomOutputNodeEventName_Node_Offset = NativeReflection.GetPropertyOffset(GetCustomOutputNodeEventName_FunctionAddress, "Node");
		GetCustomOutputNodeEventName_Node_IsValid = NativeReflection.ValidatePropertyClass(GetCustomOutputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		GetCustomOutputNodeEventName_OutEventName_Offset = NativeReflection.GetPropertyOffset(GetCustomOutputNodeEventName_FunctionAddress, "OutEventName");
		GetCustomOutputNodeEventName_OutEventName_IsValid = NativeReflection.ValidatePropertyClass(GetCustomOutputNodeEventName_FunctionAddress, "OutEventName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref GetCustomOutputNodeEventName_ReturnValue_PropertyAddress, GetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeEventName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeEventName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCustomOutputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomOutputNodeEventName_IsValid = GetCustomOutputNodeEventName_FunctionAddress != IntPtr.Zero && GetCustomOutputNodeEventName_Node_IsValid && GetCustomOutputNodeEventName_OutEventName_IsValid && GetCustomOutputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetCustomOutputNodeEventName", GetCustomOutputNodeEventName_IsValid);
		GetComponentObserverNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetComponentObserverNodeClasses");
		GetComponentObserverNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentObserverNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetComponentObserverNodeClasses_OutClasses_PropertyAddress, GetComponentObserverNodeClasses_FunctionAddress, "OutClasses");
		GetComponentObserverNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetComponentObserverNodeClasses_FunctionAddress, "OutClasses");
		GetComponentObserverNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetComponentObserverNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetComponentObserverNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetComponentObserverNodeClasses_FunctionAddress, "ReturnValue");
		GetComponentObserverNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetComponentObserverNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetComponentObserverNodeClasses_IsValid = GetComponentObserverNodeClasses_FunctionAddress != IntPtr.Zero && GetComponentObserverNodeClasses_OutClasses_IsValid && GetComponentObserverNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetComponentObserverNodeClasses", GetComponentObserverNodeClasses_IsValid);
		GetExecutionSequenceNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExecutionSequenceNodeClasses");
		GetExecutionSequenceNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExecutionSequenceNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress, GetExecutionSequenceNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionSequenceNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExecutionSequenceNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionSequenceNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExecutionSequenceNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExecutionSequenceNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExecutionSequenceNodeClasses_FunctionAddress, "ReturnValue");
		GetExecutionSequenceNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExecutionSequenceNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExecutionSequenceNodeClasses_IsValid = GetExecutionSequenceNodeClasses_FunctionAddress != IntPtr.Zero && GetExecutionSequenceNodeClasses_OutClasses_IsValid && GetExecutionSequenceNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetExecutionSequenceNodeClasses", GetExecutionSequenceNodeClasses_IsValid);
		GetExecutionMultiGateNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExecutionMultiGateNodeClasses");
		GetExecutionMultiGateNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExecutionMultiGateNodeClasses_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress, GetExecutionMultiGateNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionMultiGateNodeClasses_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExecutionMultiGateNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionMultiGateNodeClasses_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExecutionMultiGateNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExecutionMultiGateNodeClasses_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExecutionMultiGateNodeClasses_FunctionAddress, "ReturnValue");
		GetExecutionMultiGateNodeClasses_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExecutionMultiGateNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExecutionMultiGateNodeClasses_IsValid = GetExecutionMultiGateNodeClasses_FunctionAddress != IntPtr.Zero && GetExecutionMultiGateNodeClasses_OutClasses_IsValid && GetExecutionMultiGateNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeInteractor:GetExecutionMultiGateNodeClasses", GetExecutionMultiGateNodeClasses_IsValid);
	}

	static BED_CalliopeInteractor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_CalliopeInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_CalliopeInteractor));
	}
}
