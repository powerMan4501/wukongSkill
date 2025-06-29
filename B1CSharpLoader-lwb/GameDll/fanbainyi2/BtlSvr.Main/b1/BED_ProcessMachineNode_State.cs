using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("State")]
[UClass]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State")]
public class BED_ProcessMachineNode_State : BED_ProcessMachineNode
{
	private static bool StateList_IsValid;

	private static int StateList_Offset;

	private static FFieldAddress StateList_PropertyAddress;

	private TMapReadWriteMarshaler<FName, bool> StateList_Marshaler;

	private static bool EventList_IsValid;

	private static int EventList_Offset;

	private static FFieldAddress EventList_PropertyAddress;

	private TMapReadWriteMarshaler<FName, bool> EventList_Marshaler;

	private static bool CurrentState_IsValid;

	private static int CurrentState_Offset;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

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

	private static bool GetBranchGraphToEditInCS_IsValid;

	private static IntPtr GetBranchGraphToEditInCS_FunctionAddress;

	private static int GetBranchGraphToEditInCS_ParamsSize;

	private static bool GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid;

	private static int GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset;

	private static FFieldAddress GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress;

	private static bool GetBranchGraphToEditInCS_ReturnValue_IsValid;

	private static int GetBranchGraphToEditInCS_ReturnValue_Offset;

	private static FFieldAddress GetBranchGraphToEditInCS_ReturnValue_PropertyAddress;

	[VisibleAnywhere]
	[UProperty]
	[DisplayName("状态列表")]
	[Category("State")]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:StateList")]
	public TMapReadWrite<FName, bool> StateList
	{
		get
		{
			CheckDestroyed();
			if (!StateList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_State:StateList");
				return null;
			}
			if (StateList_Marshaler == null)
			{
				StateList_Marshaler = new TMapReadWriteMarshaler<FName, bool>(1, StateList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return StateList_Marshaler.FromNative(IntPtr.Add(base.Address, StateList_Offset));
		}
	}

	[Category("State")]
	[UProperty]
	[VisibleAnywhere]
	[DisplayName("事件列表")]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:EventList")]
	public TMapReadWrite<FName, bool> EventList
	{
		get
		{
			CheckDestroyed();
			if (!EventList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_State:EventList");
				return null;
			}
			if (EventList_Marshaler == null)
			{
				EventList_Marshaler = new TMapReadWriteMarshaler<FName, bool>(1, EventList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return EventList_Marshaler.FromNative(IntPtr.Add(base.Address, EventList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:CurrentState")]
	public FName CurrentState
	{
		get
		{
			CheckDestroyed();
			if (!CurrentState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_State:CurrentState");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurrentState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_State:CurrentState");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurrentState_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Machine Nodes";
		base.NodeStyle = ECalliopeNodeStyle.SubGraph;
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Reset
		});
		base.SupportsContextPins = true;
		SyncStateDataWithAsset();
	}

	public override byte[] GetCustomData()
	{
		return new ProcessCustom_State
		{
			StateName = CurrentState.PlainName
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.State;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("State: " + CurrentState.PlainName + "\n");
		return stringBuilder.ToString();
	}

	private void SyncStateDataWithAsset()
	{
		BED_ProcessAsset bED_ProcessAsset = GetCalliopeAsset() as BED_ProcessAsset;
		if (!(bED_ProcessAsset != null))
		{
			return;
		}
		List<FGameplayTag> gameplayTags = bED_ProcessAsset.StateTags.GameplayTags;
		List<FGameplayTag> gameplayTags2 = bED_ProcessAsset.EventTags.GameplayTags;
		List<FName> list = new List<FName>();
		foreach (KeyValuePair<FName, bool> KvPair in StateList)
		{
			if (!gameplayTags.Any((FGameplayTag p) => GameplayTagExtension.EqualTo(p, KvPair.Key.PlainName)))
			{
				list.Add(KvPair.Key);
			}
		}
		foreach (FName item in list)
		{
			if (CurrentState == item)
			{
				CurrentState = FName.None;
			}
			StateList.Remove(item);
		}
		list.Clear();
		foreach (FGameplayTag item2 in gameplayTags)
		{
			FName tagName = item2.TagName;
			if (!StateList.ContainsKey(tagName))
			{
				StateList.Add(tagName, value: false);
			}
		}
		foreach (KeyValuePair<FName, bool> KvPair2 in EventList)
		{
			if (!gameplayTags2.Any((FGameplayTag p) => GameplayTagExtension.EqualTo(p, KvPair2.Key.PlainName)))
			{
				list.Add(KvPair2.Key);
			}
		}
		foreach (FName item3 in list)
		{
			EventList.Remove(item3);
		}
		list.Clear();
		foreach (FGameplayTag item4 in gameplayTags2)
		{
			FName tagName2 = item4.TagName;
			if (!EventList.ContainsKey(tagName2))
			{
				EventList.Add(tagName2, value: false);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		SyncStateDataWithAsset();
		foreach (KeyValuePair<FName, bool> @event in EventList)
		{
			if (@event.Value)
			{
				list.Add(@event.Key);
			}
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("StateList"))
		{
			if (CurrentState == FName.None)
			{
				foreach (KeyValuePair<FName, bool> state in StateList)
				{
					if (state.Value)
					{
						CurrentState = state.Key;
						break;
					}
				}
			}
			else
			{
				StateList[CurrentState] = false;
				bool flag = true;
				foreach (KeyValuePair<FName, bool> state2 in StateList)
				{
					if (state2.Value)
					{
						flag = false;
						CurrentState = state2.Key;
						break;
					}
				}
				if (flag)
				{
					StateList[CurrentState] = true;
				}
			}
		}
		if (PropertyName.Equals("EventList"))
		{
			ExecuteOnReconstructionRequested();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_State:GetBranchGraphToEditInCS")]
	protected override bool GetBranchGraphToEditInCS_Implementation(out string OutBranchGraphIdentifier)
	{
		OutBranchGraphIdentifier = CurrentState.PlainName;
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_State:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_State bED_ProcessMachineNode_State = GCHelper.Find<BED_ProcessMachineNode_State>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_ProcessMachineNode_State.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_State:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_State bED_ProcessMachineNode_State = GCHelper.Find<BED_ProcessMachineNode_State>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessMachineNode_State.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_State:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_State bED_ProcessMachineNode_State = GCHelper.Find<BED_ProcessMachineNode_State>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessMachineNode_State.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_State:GetBranchGraphToEditInCS")]
	private static void GetBranchGraphToEditInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_State bED_ProcessMachineNode_State = GCHelper.Find<BED_ProcessMachineNode_State>(obj);
		string OutBranchGraphIdentifier;
		bool branchGraphToEditInCS_Implementation = bED_ProcessMachineNode_State.GetBranchGraphToEditInCS_Implementation(out OutBranchGraphIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetBranchGraphToEditInCS_ReturnValue_Offset), 0, GetBranchGraphToEditInCS_ReturnValue_PropertyAddress.Address, branchGraphToEditInCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset), OutBranchGraphIdentifier);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_State");
		NativeReflection.GetPropertyRef(ref StateList_PropertyAddress, intPtr, "StateList");
		StateList_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateList");
		StateList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateList", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref EventList_PropertyAddress, intPtr, "EventList");
		EventList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventList");
		EventList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventList", Classes.FMapProperty);
		CurrentState_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentState");
		CurrentState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentState", Classes.FNameProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_State:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_State:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_State:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
		GetBranchGraphToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBranchGraphToEditInCS");
		GetBranchGraphToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBranchGraphToEditInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress, GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier");
		GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset = NativeReflection.GetPropertyOffset(GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier");
		GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid = NativeReflection.ValidatePropertyClass(GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetBranchGraphToEditInCS_ReturnValue_PropertyAddress, GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue");
		GetBranchGraphToEditInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue");
		GetBranchGraphToEditInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBranchGraphToEditInCS_IsValid = GetBranchGraphToEditInCS_FunctionAddress != IntPtr.Zero && GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid && GetBranchGraphToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_State:GetBranchGraphToEditInCS", GetBranchGraphToEditInCS_IsValid);
	}

	static BED_ProcessMachineNode_State()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_State)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_State));
	}
}
