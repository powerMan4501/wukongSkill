using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using Google.Protobuf;
using GurCalliopeFsm;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("TransactionTask")]
[Placeable(true)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask")]
public class BED_FSMNode_PS_Transaction_TransactionTask : BED_FSMNode_PS_TransactionBase
{
	private static bool TransactionTaskType_IsValid;

	private static int TransactionTaskType_Offset;

	private static FFieldAddress TransactionTaskType_PropertyAddress;

	private static bool AcceptEvents_IsValid;

	private static int AcceptEvents_Offset;

	private static FFieldAddress AcceptEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<EPS_Transaction> AcceptEvents_Marshaler;

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
	[EditAnywhere]
	[DisplayName("事务子任务类型")]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:TransactionTaskType")]
	private ETransactionTaskType TransactionTaskType
	{
		get
		{
			CheckDestroyed();
			if (!TransactionTaskType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:TransactionTaskType");
				return ETransactionTaskType.Interact_RequestInteractObjLock;
			}
			return EnumMarshaler<ETransactionTaskType>.FromNative(IntPtr.Add(base.Address, TransactionTaskType_Offset), 0, TransactionTaskType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TransactionTaskType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:TransactionTaskType");
			}
			else
			{
				EnumMarshaler<ETransactionTaskType>.ToNative(IntPtr.Add(base.Address, TransactionTaskType_Offset), 0, TransactionTaskType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:AcceptEvents")]
	public TArrayReadWrite<EPS_Transaction> AcceptEvents
	{
		get
		{
			CheckDestroyed();
			if (!AcceptEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:AcceptEvents");
				return null;
			}
			if (AcceptEvents_Marshaler == null)
			{
				AcceptEvents_Marshaler = new TArrayReadWriteMarshaler<EPS_Transaction>(1, AcceptEvents_PropertyAddress, CachedMarshalingDelegates<EPS_Transaction, EnumMarshaler<EPS_Transaction>>.FromNative, CachedMarshalingDelegates<EPS_Transaction, EnumMarshaler<EPS_Transaction>>.ToNative);
			}
			return AcceptEvents_Marshaler.FromNative(IntPtr.Add(base.Address, AcceptEvents_Offset));
		}
	}

	public override byte[] GetCustomData()
	{
		return new PS_Transaction_TransactionTask
		{
			TransactionTaskType = (int)TransactionTaskType
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("事务子任务类型:" + UEnum.GetEnum<ETransactionTaskType>().GetDisplayNameTextStringByIndex((int)TransactionTaskType));
		return stringBuilder.ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FreshOutPutPins();
		SetNodeCategory("PS_Transaction State");
	}

	protected void FreshOutPutPins()
	{
		base.OutputPins.Clear();
		List<EPS_Transaction> list = new List<EPS_Transaction>();
		foreach (EPS_Transaction acceptEvent in AcceptEvents)
		{
			if (!list.Contains(acceptEvent))
			{
				base.OutputPins.Add(new FCalliopePin
				{
					PinName = new FName(acceptEvent.ToString())
				});
				list.Add(acceptEvent);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.PostPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName.Equals("AcceptEvents"))
		{
			FreshOutPutPins();
			ExecuteOnReconstructionRequested();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_PS_Transaction_TransactionTask bED_FSMNode_PS_Transaction_TransactionTask = GCHelper.Find<BED_FSMNode_PS_Transaction_TransactionTask>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_FSMNode_PS_Transaction_TransactionTask.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_PS_Transaction_TransactionTask bED_FSMNode_PS_Transaction_TransactionTask = GCHelper.Find<BED_FSMNode_PS_Transaction_TransactionTask>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_PS_Transaction_TransactionTask.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask");
		NativeReflection.GetPropertyRef(ref TransactionTaskType_PropertyAddress, intPtr, "TransactionTaskType");
		TransactionTaskType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransactionTaskType");
		TransactionTaskType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransactionTaskType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AcceptEvents_PropertyAddress, intPtr, "AcceptEvents");
		AcceptEvents_Offset = NativeReflection.GetPropertyOffset(intPtr, "AcceptEvents");
		AcceptEvents_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AcceptEvents", Classes.FArrayProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_PS_Transaction_TransactionTask:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_PS_Transaction_TransactionTask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_PS_Transaction_TransactionTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_PS_Transaction_TransactionTask));
	}
}
