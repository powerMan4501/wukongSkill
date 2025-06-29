using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("条件检测")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_DetectStart")]
public class BED_ProcessStateNode_DetectStart : BED_ProcessStateNode
{
	private static bool DetectConditionList_IsValid;

	private static int DetectConditionList_Offset;

	private static FFieldAddress DetectConditionList_PropertyAddress;

	private TMapReadWriteMarshaler<FName, bool> DetectConditionList_Marshaler;

	private static bool CurrentCondition_IsValid;

	private static int CurrentCondition_Offset;

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

	[UProperty]
	[VisibleAnywhere]
	[DisplayName("可重写条件列表")]
	[Category("State")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:DetectConditionList")]
	public TMapReadWrite<FName, bool> DetectConditionList
	{
		get
		{
			CheckDestroyed();
			if (!DetectConditionList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:DetectConditionList");
				return null;
			}
			if (DetectConditionList_Marshaler == null)
			{
				DetectConditionList_Marshaler = new TMapReadWriteMarshaler<FName, bool>(1, DetectConditionList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return DetectConditionList_Marshaler.FromNative(IntPtr.Add(base.Address, DetectConditionList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:CurrentCondition")]
	public FName CurrentCondition
	{
		get
		{
			CheckDestroyed();
			if (!CurrentCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:CurrentCondition");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurrentCondition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:CurrentCondition");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurrentCondition_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Detect";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.SupportsContextPins = true;
		base.InputPins.Clear();
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
		SyncDataWithAsset();
	}

	public override string GetNodeName()
	{
		return "Process.State.DetectStart";
	}

	public override byte[] GetCustomData()
	{
		return new ProcessStateCustom_DetectStart
		{
			DetectCondition = CurrentCondition.PlainName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("检测条件: " + CurrentCondition.PlainName + "\n");
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> result = new List<FName>();
		SyncDataWithAsset();
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (!PropertyName.Equals("DetectConditionList"))
		{
			return;
		}
		if (CurrentCondition == FName.None)
		{
			foreach (KeyValuePair<FName, bool> detectCondition in DetectConditionList)
			{
				if (detectCondition.Value)
				{
					CurrentCondition = detectCondition.Key;
					break;
				}
			}
			return;
		}
		DetectConditionList[CurrentCondition] = false;
		bool flag = true;
		foreach (KeyValuePair<FName, bool> detectCondition2 in DetectConditionList)
		{
			if (detectCondition2.Value)
			{
				flag = false;
				CurrentCondition = detectCondition2.Key;
				break;
			}
		}
		if (flag)
		{
			DetectConditionList[CurrentCondition] = true;
		}
	}

	private void SyncDataWithAsset()
	{
		BED_ProcessAsset bED_ProcessAsset = GetCalliopeAsset() as BED_ProcessAsset;
		if (!(bED_ProcessAsset != null))
		{
			return;
		}
		List<FName> list = bED_ProcessAsset.CustomDetectConditions.ToList();
		List<FName> list2 = new List<FName>();
		foreach (KeyValuePair<FName, bool> KvPair in DetectConditionList)
		{
			if (!list.Any((FName p) => p.Equals(KvPair.Key)))
			{
				list2.Add(KvPair.Key);
			}
		}
		foreach (FName item in list2)
		{
			if (CurrentCondition == item)
			{
				CurrentCondition = FName.None;
			}
			DetectConditionList.Remove(item);
		}
		list2.Clear();
		foreach (FName item2 in list)
		{
			if (!DetectConditionList.ContainsKey(item2))
			{
				DetectConditionList.Add(item2, value: false);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_DetectStart bED_ProcessStateNode_DetectStart = GCHelper.Find<BED_ProcessStateNode_DetectStart>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_ProcessStateNode_DetectStart.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_DetectStart bED_ProcessStateNode_DetectStart = GCHelper.Find<BED_ProcessStateNode_DetectStart>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessStateNode_DetectStart.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_DetectStart bED_ProcessStateNode_DetectStart = GCHelper.Find<BED_ProcessStateNode_DetectStart>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_DetectStart.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_DetectStart");
		NativeReflection.GetPropertyRef(ref DetectConditionList_PropertyAddress, intPtr, "DetectConditionList");
		DetectConditionList_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetectConditionList");
		DetectConditionList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetectConditionList", Classes.FMapProperty);
		CurrentCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentCondition");
		CurrentCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentCondition", Classes.FNameProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_DetectStart:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_DetectStart()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_DetectStart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_DetectStart));
	}
}
