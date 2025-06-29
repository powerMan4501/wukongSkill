using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Calliope.CalliopeInteractor", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeInteractor : UObject
{
	private static IntPtr classAddress;

	private static bool UnregisterInstance_IsValid;

	private static IntPtr UnregisterInstance_FunctionAddress;

	private static int UnregisterInstance_ParamsSize;

	private static bool SetCustomOutputNodeEventName_IsValid;

	private IntPtr SetCustomOutputNodeEventName_InstanceFunctionAddress;

	private static IntPtr SetCustomOutputNodeEventName_FunctionAddress;

	private static int SetCustomOutputNodeEventName_ParamsSize;

	private static bool SetCustomOutputNodeEventName_Node_IsValid;

	private static FFieldAddress SetCustomOutputNodeEventName_Node_PropertyAddress;

	private static int SetCustomOutputNodeEventName_Node_Offset;

	private static bool SetCustomOutputNodeEventName_InEventName_IsValid;

	private static FFieldAddress SetCustomOutputNodeEventName_InEventName_PropertyAddress;

	private static int SetCustomOutputNodeEventName_InEventName_Offset;

	private static bool SetCustomOutputNodeEventName_ReturnValue_IsValid;

	private static FFieldAddress SetCustomOutputNodeEventName_ReturnValue_PropertyAddress;

	private static int SetCustomOutputNodeEventName_ReturnValue_Offset;

	private static bool SetCustomInputNodeEventName_IsValid;

	private IntPtr SetCustomInputNodeEventName_InstanceFunctionAddress;

	private static IntPtr SetCustomInputNodeEventName_FunctionAddress;

	private static int SetCustomInputNodeEventName_ParamsSize;

	private static bool SetCustomInputNodeEventName_Node_IsValid;

	private static FFieldAddress SetCustomInputNodeEventName_Node_PropertyAddress;

	private static int SetCustomInputNodeEventName_Node_Offset;

	private static bool SetCustomInputNodeEventName_InEventName_IsValid;

	private static FFieldAddress SetCustomInputNodeEventName_InEventName_PropertyAddress;

	private static int SetCustomInputNodeEventName_InEventName_Offset;

	private static bool SetCustomInputNodeEventName_ReturnValue_IsValid;

	private static FFieldAddress SetCustomInputNodeEventName_ReturnValue_PropertyAddress;

	private static int SetCustomInputNodeEventName_ReturnValue_Offset;

	private static bool RegisterInstance_IsValid;

	private static IntPtr RegisterInstance_FunctionAddress;

	private static int RegisterInstance_ParamsSize;

	private static bool RegisterInstance_Instance_IsValid;

	private static FFieldAddress RegisterInstance_Instance_PropertyAddress;

	private static int RegisterInstance_Instance_Offset;

	private static bool GetSubGraphNodeClasses_IsValid;

	private IntPtr GetSubGraphNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetSubGraphNodeClasses_FunctionAddress;

	private static int GetSubGraphNodeClasses_ParamsSize;

	private static bool GetSubGraphNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetSubGraphNodeClasses_OutClasses_PropertyAddress;

	private static int GetSubGraphNodeClasses_OutClasses_Offset;

	private static bool GetSubGraphNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetSubGraphNodeClasses_ReturnValue_PropertyAddress;

	private static int GetSubGraphNodeClasses_ReturnValue_Offset;

	private static bool GetStartNodeClasses_IsValid;

	private IntPtr GetStartNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetStartNodeClasses_FunctionAddress;

	private static int GetStartNodeClasses_ParamsSize;

	private static bool GetStartNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetStartNodeClasses_OutClasses_PropertyAddress;

	private static int GetStartNodeClasses_OutClasses_Offset;

	private static bool GetStartNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetStartNodeClasses_ReturnValue_PropertyAddress;

	private static int GetStartNodeClasses_ReturnValue_Offset;

	private static bool GetRerouteNodeClasses_IsValid;

	private IntPtr GetRerouteNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetRerouteNodeClasses_FunctionAddress;

	private static int GetRerouteNodeClasses_ParamsSize;

	private static bool GetRerouteNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetRerouteNodeClasses_OutClasses_PropertyAddress;

	private static int GetRerouteNodeClasses_OutClasses_Offset;

	private static bool GetRerouteNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetRerouteNodeClasses_ReturnValue_PropertyAddress;

	private static int GetRerouteNodeClasses_ReturnValue_Offset;

	private static bool GetInstanceChecked_IsValid;

	private static IntPtr GetInstanceChecked_FunctionAddress;

	private static int GetInstanceChecked_ParamsSize;

	private static bool GetInstanceChecked_ReturnValue_IsValid;

	private static FFieldAddress GetInstanceChecked_ReturnValue_PropertyAddress;

	private static int GetInstanceChecked_ReturnValue_Offset;

	private static bool GetFinishNodeClasses_IsValid;

	private IntPtr GetFinishNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetFinishNodeClasses_FunctionAddress;

	private static int GetFinishNodeClasses_ParamsSize;

	private static bool GetFinishNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetFinishNodeClasses_OutClasses_PropertyAddress;

	private static int GetFinishNodeClasses_OutClasses_Offset;

	private static bool GetFinishNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetFinishNodeClasses_ReturnValue_PropertyAddress;

	private static int GetFinishNodeClasses_ReturnValue_Offset;

	private static bool GetExecutionSequenceNodeClasses_IsValid;

	private IntPtr GetExecutionSequenceNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetExecutionSequenceNodeClasses_FunctionAddress;

	private static int GetExecutionSequenceNodeClasses_ParamsSize;

	private static bool GetExecutionSequenceNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress;

	private static int GetExecutionSequenceNodeClasses_OutClasses_Offset;

	private static bool GetExecutionSequenceNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetExecutionSequenceNodeClasses_ReturnValue_PropertyAddress;

	private static int GetExecutionSequenceNodeClasses_ReturnValue_Offset;

	private static bool GetExecutionMultiGateNodeClasses_IsValid;

	private IntPtr GetExecutionMultiGateNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetExecutionMultiGateNodeClasses_FunctionAddress;

	private static int GetExecutionMultiGateNodeClasses_ParamsSize;

	private static bool GetExecutionMultiGateNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress;

	private static int GetExecutionMultiGateNodeClasses_OutClasses_Offset;

	private static bool GetExecutionMultiGateNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetExecutionMultiGateNodeClasses_ReturnValue_PropertyAddress;

	private static int GetExecutionMultiGateNodeClasses_ReturnValue_Offset;

	private static bool GetCustomOutputNodeEventName_IsValid;

	private IntPtr GetCustomOutputNodeEventName_InstanceFunctionAddress;

	private static IntPtr GetCustomOutputNodeEventName_FunctionAddress;

	private static int GetCustomOutputNodeEventName_ParamsSize;

	private static bool GetCustomOutputNodeEventName_Node_IsValid;

	private static FFieldAddress GetCustomOutputNodeEventName_Node_PropertyAddress;

	private static int GetCustomOutputNodeEventName_Node_Offset;

	private static bool GetCustomOutputNodeEventName_OutEventName_IsValid;

	private static FFieldAddress GetCustomOutputNodeEventName_OutEventName_PropertyAddress;

	private static int GetCustomOutputNodeEventName_OutEventName_Offset;

	private static bool GetCustomOutputNodeEventName_ReturnValue_IsValid;

	private static FFieldAddress GetCustomOutputNodeEventName_ReturnValue_PropertyAddress;

	private static int GetCustomOutputNodeEventName_ReturnValue_Offset;

	private static bool GetCustomOutputNodeClasses_IsValid;

	private IntPtr GetCustomOutputNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetCustomOutputNodeClasses_FunctionAddress;

	private static int GetCustomOutputNodeClasses_ParamsSize;

	private static bool GetCustomOutputNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetCustomOutputNodeClasses_OutClasses_PropertyAddress;

	private static int GetCustomOutputNodeClasses_OutClasses_Offset;

	private static bool GetCustomOutputNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetCustomOutputNodeClasses_ReturnValue_PropertyAddress;

	private static int GetCustomOutputNodeClasses_ReturnValue_Offset;

	private static bool GetCustomInputNodeEventName_IsValid;

	private IntPtr GetCustomInputNodeEventName_InstanceFunctionAddress;

	private static IntPtr GetCustomInputNodeEventName_FunctionAddress;

	private static int GetCustomInputNodeEventName_ParamsSize;

	private static bool GetCustomInputNodeEventName_Node_IsValid;

	private static FFieldAddress GetCustomInputNodeEventName_Node_PropertyAddress;

	private static int GetCustomInputNodeEventName_Node_Offset;

	private static bool GetCustomInputNodeEventName_OutEventName_IsValid;

	private static FFieldAddress GetCustomInputNodeEventName_OutEventName_PropertyAddress;

	private static int GetCustomInputNodeEventName_OutEventName_Offset;

	private static bool GetCustomInputNodeEventName_ReturnValue_IsValid;

	private static FFieldAddress GetCustomInputNodeEventName_ReturnValue_PropertyAddress;

	private static int GetCustomInputNodeEventName_ReturnValue_Offset;

	private static bool GetCustomInputNodeClasses_IsValid;

	private IntPtr GetCustomInputNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetCustomInputNodeClasses_FunctionAddress;

	private static int GetCustomInputNodeClasses_ParamsSize;

	private static bool GetCustomInputNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetCustomInputNodeClasses_OutClasses_PropertyAddress;

	private static int GetCustomInputNodeClasses_OutClasses_Offset;

	private static bool GetCustomInputNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetCustomInputNodeClasses_ReturnValue_PropertyAddress;

	private static int GetCustomInputNodeClasses_ReturnValue_Offset;

	private static bool GetComponentObserverNodeClasses_IsValid;

	private IntPtr GetComponentObserverNodeClasses_InstanceFunctionAddress;

	private static IntPtr GetComponentObserverNodeClasses_FunctionAddress;

	private static int GetComponentObserverNodeClasses_ParamsSize;

	private static bool GetComponentObserverNodeClasses_OutClasses_IsValid;

	private static FFieldAddress GetComponentObserverNodeClasses_OutClasses_PropertyAddress;

	private static int GetComponentObserverNodeClasses_OutClasses_Offset;

	private static bool GetComponentObserverNodeClasses_ReturnValue_IsValid;

	private static FFieldAddress GetComponentObserverNodeClasses_ReturnValue_PropertyAddress;

	private static int GetComponentObserverNodeClasses_ReturnValue_Offset;

	private static bool GetAssetClass_IsValid;

	private static IntPtr GetAssetClass_FunctionAddress;

	private static int GetAssetClass_ParamsSize;

	private static bool GetAssetClass_InViewType_IsValid;

	private static FFieldAddress GetAssetClass_InViewType_PropertyAddress;

	private static int GetAssetClass_InViewType_Offset;

	private static bool GetAssetClass_ReturnValue_IsValid;

	private static FFieldAddress GetAssetClass_ReturnValue_PropertyAddress;

	private static int GetAssetClass_ReturnValue_Offset;

	private static bool ConvertCalliopeGuidToGuid_IsValid;

	private static IntPtr ConvertCalliopeGuidToGuid_FunctionAddress;

	private static int ConvertCalliopeGuidToGuid_ParamsSize;

	private static bool ConvertCalliopeGuidToGuid_InCalliopeGuid_IsValid;

	private static FFieldAddress ConvertCalliopeGuidToGuid_InCalliopeGuid_PropertyAddress;

	private static int ConvertCalliopeGuidToGuid_InCalliopeGuid_Offset;

	private static bool ConvertCalliopeGuidToGuid_ReturnValue_IsValid;

	private static FFieldAddress ConvertCalliopeGuidToGuid_ReturnValue_PropertyAddress;

	private static int ConvertCalliopeGuidToGuid_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:UnregisterInstance")]
	public unsafe static void UnregisterInstance()
	{
		if (!UnregisterInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:UnregisterInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterInstance_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: UnregisterInstance_FunctionAddress, argsSize: UnregisterInstance_ParamsSize);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:SetCustomOutputNodeEventName")]
	public unsafe bool SetCustomOutputNodeEventName(UCalliopeNode Node, FName InEventName)
	{
		CheckDestroyed();
		if (!SetCustomOutputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:SetCustomOutputNodeEventName");
			return false;
		}
		if (SetCustomOutputNodeEventName_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetCustomOutputNodeEventName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetCustomOutputNodeEventName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomOutputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomOutputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, SetCustomOutputNodeEventName_Node_Offset), 0, SetCustomOutputNodeEventName_Node_PropertyAddress.Address, Node);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCustomOutputNodeEventName_InEventName_Offset), 0, SetCustomOutputNodeEventName_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomOutputNodeEventName_InstanceFunctionAddress, intPtr, SetCustomOutputNodeEventName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomOutputNodeEventName_ReturnValue_Offset), 0, SetCustomOutputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool SetCustomOutputNodeEventName_Implementation(UCalliopeNode Node, FName InEventName)
	{
		CheckDestroyed();
		if (!SetCustomOutputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:SetCustomOutputNodeEventName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomOutputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomOutputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, SetCustomOutputNodeEventName_Node_Offset), 0, SetCustomOutputNodeEventName_Node_PropertyAddress.Address, Node);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCustomOutputNodeEventName_InEventName_Offset), 0, SetCustomOutputNodeEventName_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomOutputNodeEventName_FunctionAddress, intPtr, SetCustomOutputNodeEventName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomOutputNodeEventName_ReturnValue_Offset), 0, SetCustomOutputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:SetCustomInputNodeEventName")]
	public unsafe bool SetCustomInputNodeEventName(UCalliopeNode Node, FName InEventName)
	{
		CheckDestroyed();
		if (!SetCustomInputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:SetCustomInputNodeEventName");
			return false;
		}
		if (SetCustomInputNodeEventName_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetCustomInputNodeEventName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetCustomInputNodeEventName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomInputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomInputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, SetCustomInputNodeEventName_Node_Offset), 0, SetCustomInputNodeEventName_Node_PropertyAddress.Address, Node);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCustomInputNodeEventName_InEventName_Offset), 0, SetCustomInputNodeEventName_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomInputNodeEventName_InstanceFunctionAddress, intPtr, SetCustomInputNodeEventName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomInputNodeEventName_ReturnValue_Offset), 0, SetCustomInputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool SetCustomInputNodeEventName_Implementation(UCalliopeNode Node, FName InEventName)
	{
		CheckDestroyed();
		if (!SetCustomInputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:SetCustomInputNodeEventName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomInputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomInputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, SetCustomInputNodeEventName_Node_Offset), 0, SetCustomInputNodeEventName_Node_PropertyAddress.Address, Node);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCustomInputNodeEventName_InEventName_Offset), 0, SetCustomInputNodeEventName_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomInputNodeEventName_FunctionAddress, intPtr, SetCustomInputNodeEventName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomInputNodeEventName_ReturnValue_Offset), 0, SetCustomInputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:RegisterInstance")]
	public unsafe static void RegisterInstance(UCalliopeInteractor Instance)
	{
		if (!RegisterInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:RegisterInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeInteractor>.ToNative(IntPtr.Add(intPtr, RegisterInstance_Instance_Offset), 0, RegisterInstance_Instance_PropertyAddress.Address, Instance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterInstance_FunctionAddress, intPtr, RegisterInstance_ParamsSize);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetSubGraphNodeClasses")]
	public unsafe int GetSubGraphNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetSubGraphNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetSubGraphNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetSubGraphNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSubGraphNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSubGraphNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubGraphNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubGraphNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSubGraphNodeClasses_InstanceFunctionAddress, intPtr, GetSubGraphNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetSubGraphNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSubGraphNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetSubGraphNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSubGraphNodeClasses_ReturnValue_Offset), 0, GetSubGraphNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetSubGraphNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetSubGraphNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetSubGraphNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubGraphNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubGraphNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSubGraphNodeClasses_FunctionAddress, intPtr, GetSubGraphNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetSubGraphNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSubGraphNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetSubGraphNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSubGraphNodeClasses_ReturnValue_Offset), 0, GetSubGraphNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetStartNodeClasses")]
	public unsafe int GetStartNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetStartNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetStartNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetStartNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStartNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStartNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartNodeClasses_InstanceFunctionAddress, intPtr, GetStartNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetStartNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStartNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetStartNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStartNodeClasses_ReturnValue_Offset), 0, GetStartNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetStartNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetStartNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetStartNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartNodeClasses_FunctionAddress, intPtr, GetStartNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetStartNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStartNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetStartNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStartNodeClasses_ReturnValue_Offset), 0, GetStartNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetRerouteNodeClasses")]
	public unsafe int GetRerouteNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetRerouteNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetRerouteNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetRerouteNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRerouteNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRerouteNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRerouteNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRerouteNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRerouteNodeClasses_InstanceFunctionAddress, intPtr, GetRerouteNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetRerouteNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRerouteNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetRerouteNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRerouteNodeClasses_ReturnValue_Offset), 0, GetRerouteNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetRerouteNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetRerouteNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetRerouteNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRerouteNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRerouteNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRerouteNodeClasses_FunctionAddress, intPtr, GetRerouteNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetRerouteNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRerouteNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetRerouteNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRerouteNodeClasses_ReturnValue_Offset), 0, GetRerouteNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetInstanceChecked")]
	public unsafe static UCalliopeInteractor GetInstanceChecked()
	{
		if (!GetInstanceChecked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetInstanceChecked");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstanceChecked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstanceChecked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInstanceChecked_FunctionAddress, intPtr, GetInstanceChecked_ParamsSize);
		return UObjectMarshaler<UCalliopeInteractor>.FromNative(IntPtr.Add(intPtr, GetInstanceChecked_ReturnValue_Offset), 0, GetInstanceChecked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetFinishNodeClasses")]
	public unsafe int GetFinishNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetFinishNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetFinishNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetFinishNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetFinishNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetFinishNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFinishNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFinishNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFinishNodeClasses_InstanceFunctionAddress, intPtr, GetFinishNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetFinishNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFinishNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetFinishNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFinishNodeClasses_ReturnValue_Offset), 0, GetFinishNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetFinishNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetFinishNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetFinishNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFinishNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFinishNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFinishNodeClasses_FunctionAddress, intPtr, GetFinishNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetFinishNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFinishNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetFinishNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFinishNodeClasses_ReturnValue_Offset), 0, GetFinishNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetExecutionSequenceNodeClasses")]
	public unsafe int GetExecutionSequenceNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExecutionSequenceNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetExecutionSequenceNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetExecutionSequenceNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetExecutionSequenceNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetExecutionSequenceNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExecutionSequenceNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExecutionSequenceNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExecutionSequenceNodeClasses_InstanceFunctionAddress, intPtr, GetExecutionSequenceNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExecutionSequenceNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExecutionSequenceNodeClasses_ReturnValue_Offset), 0, GetExecutionSequenceNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetExecutionSequenceNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExecutionSequenceNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetExecutionSequenceNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExecutionSequenceNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExecutionSequenceNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExecutionSequenceNodeClasses_FunctionAddress, intPtr, GetExecutionSequenceNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExecutionSequenceNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExecutionSequenceNodeClasses_ReturnValue_Offset), 0, GetExecutionSequenceNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetExecutionMultiGateNodeClasses")]
	public unsafe int GetExecutionMultiGateNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExecutionMultiGateNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetExecutionMultiGateNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetExecutionMultiGateNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetExecutionMultiGateNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetExecutionMultiGateNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExecutionMultiGateNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExecutionMultiGateNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExecutionMultiGateNodeClasses_InstanceFunctionAddress, intPtr, GetExecutionMultiGateNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExecutionMultiGateNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExecutionMultiGateNodeClasses_ReturnValue_Offset), 0, GetExecutionMultiGateNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetExecutionMultiGateNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExecutionMultiGateNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetExecutionMultiGateNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExecutionMultiGateNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExecutionMultiGateNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExecutionMultiGateNodeClasses_FunctionAddress, intPtr, GetExecutionMultiGateNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExecutionMultiGateNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExecutionMultiGateNodeClasses_ReturnValue_Offset), 0, GetExecutionMultiGateNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeEventName")]
	public unsafe bool GetCustomOutputNodeEventName(UCalliopeNode Node, out FName OutEventName)
	{
		CheckDestroyed();
		if (!GetCustomOutputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeEventName");
			OutEventName = default(FName);
			return false;
		}
		if (GetCustomOutputNodeEventName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCustomOutputNodeEventName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCustomOutputNodeEventName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomOutputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomOutputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, GetCustomOutputNodeEventName_Node_Offset), 0, GetCustomOutputNodeEventName_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomOutputNodeEventName_InstanceFunctionAddress, intPtr, GetCustomOutputNodeEventName_ParamsSize);
		OutEventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeEventName_OutEventName_Offset), 0, GetCustomOutputNodeEventName_OutEventName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeEventName_ReturnValue_Offset), 0, GetCustomOutputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetCustomOutputNodeEventName_Implementation(UCalliopeNode Node, out FName OutEventName)
	{
		CheckDestroyed();
		if (!GetCustomOutputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeEventName");
			OutEventName = default(FName);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomOutputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomOutputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, GetCustomOutputNodeEventName_Node_Offset), 0, GetCustomOutputNodeEventName_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomOutputNodeEventName_FunctionAddress, intPtr, GetCustomOutputNodeEventName_ParamsSize);
		OutEventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeEventName_OutEventName_Offset), 0, GetCustomOutputNodeEventName_OutEventName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeEventName_ReturnValue_Offset), 0, GetCustomOutputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeClasses")]
	public unsafe int GetCustomOutputNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetCustomOutputNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetCustomOutputNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCustomOutputNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCustomOutputNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomOutputNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomOutputNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomOutputNodeClasses_InstanceFunctionAddress, intPtr, GetCustomOutputNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetCustomOutputNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomOutputNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeClasses_ReturnValue_Offset), 0, GetCustomOutputNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetCustomOutputNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetCustomOutputNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomOutputNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomOutputNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomOutputNodeClasses_FunctionAddress, intPtr, GetCustomOutputNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetCustomOutputNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomOutputNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomOutputNodeClasses_ReturnValue_Offset), 0, GetCustomOutputNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeEventName")]
	public unsafe bool GetCustomInputNodeEventName(UCalliopeNode Node, out FName OutEventName)
	{
		CheckDestroyed();
		if (!GetCustomInputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeEventName");
			OutEventName = default(FName);
			return false;
		}
		if (GetCustomInputNodeEventName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCustomInputNodeEventName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCustomInputNodeEventName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomInputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomInputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, GetCustomInputNodeEventName_Node_Offset), 0, GetCustomInputNodeEventName_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomInputNodeEventName_InstanceFunctionAddress, intPtr, GetCustomInputNodeEventName_ParamsSize);
		OutEventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCustomInputNodeEventName_OutEventName_Offset), 0, GetCustomInputNodeEventName_OutEventName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomInputNodeEventName_ReturnValue_Offset), 0, GetCustomInputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetCustomInputNodeEventName_Implementation(UCalliopeNode Node, out FName OutEventName)
	{
		CheckDestroyed();
		if (!GetCustomInputNodeEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeEventName");
			OutEventName = default(FName);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomInputNodeEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomInputNodeEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, GetCustomInputNodeEventName_Node_Offset), 0, GetCustomInputNodeEventName_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomInputNodeEventName_FunctionAddress, intPtr, GetCustomInputNodeEventName_ParamsSize);
		OutEventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCustomInputNodeEventName_OutEventName_Offset), 0, GetCustomInputNodeEventName_OutEventName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomInputNodeEventName_ReturnValue_Offset), 0, GetCustomInputNodeEventName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeClasses")]
	public unsafe int GetCustomInputNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetCustomInputNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetCustomInputNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCustomInputNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCustomInputNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomInputNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomInputNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomInputNodeClasses_InstanceFunctionAddress, intPtr, GetCustomInputNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetCustomInputNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomInputNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomInputNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomInputNodeClasses_ReturnValue_Offset), 0, GetCustomInputNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetCustomInputNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetCustomInputNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomInputNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomInputNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomInputNodeClasses_FunctionAddress, intPtr, GetCustomInputNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetCustomInputNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomInputNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomInputNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomInputNodeClasses_ReturnValue_Offset), 0, GetCustomInputNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetComponentObserverNodeClasses")]
	public unsafe int GetComponentObserverNodeClasses(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetComponentObserverNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetComponentObserverNodeClasses");
			OutClasses = null;
			return 0;
		}
		if (GetComponentObserverNodeClasses_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetComponentObserverNodeClasses_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetComponentObserverNodeClasses");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentObserverNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentObserverNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentObserverNodeClasses_InstanceFunctionAddress, intPtr, GetComponentObserverNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetComponentObserverNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetComponentObserverNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetComponentObserverNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetComponentObserverNodeClasses_ReturnValue_Offset), 0, GetComponentObserverNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetComponentObserverNodeClasses_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetComponentObserverNodeClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetComponentObserverNodeClasses");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentObserverNodeClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentObserverNodeClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentObserverNodeClasses_FunctionAddress, intPtr, GetComponentObserverNodeClasses_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetComponentObserverNodeClasses_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetComponentObserverNodeClasses_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetComponentObserverNodeClasses_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetComponentObserverNodeClasses_ReturnValue_Offset), 0, GetComponentObserverNodeClasses_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:GetAssetClass")]
	public unsafe TSubclassOf<UObject> GetAssetClass(ECalliopeViewType InViewType)
	{
		CheckDestroyed();
		if (!GetAssetClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:GetAssetClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(intPtr, GetAssetClass_InViewType_Offset), 0, GetAssetClass_InViewType_PropertyAddress.Address, InViewType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetClass_FunctionAddress, intPtr, GetAssetClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAssetClass_ReturnValue_Offset), 0, GetAssetClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Calliope.CalliopeInteractor:ConvertCalliopeGuidToGuid")]
	public unsafe static Guid ConvertCalliopeGuidToGuid(FCalliopeGuid InCalliopeGuid)
	{
		if (!ConvertCalliopeGuidToGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeInteractor:ConvertCalliopeGuidToGuid");
			return default(Guid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertCalliopeGuidToGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertCalliopeGuidToGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertCalliopeGuidToGuid_InCalliopeGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, ConvertCalliopeGuidToGuid_InCalliopeGuid_Offset), 0, ConvertCalliopeGuidToGuid_InCalliopeGuid_PropertyAddress.Address, InCalliopeGuid);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertCalliopeGuidToGuid_FunctionAddress, intPtr, ConvertCalliopeGuidToGuid_ParamsSize);
		return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, ConvertCalliopeGuidToGuid_ReturnValue_Offset), 0, ConvertCalliopeGuidToGuid_ReturnValue_PropertyAddress.Address);
	}

	static UCalliopeInteractor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeInteractor));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Calliope.CalliopeInteractor");
		UnregisterInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterInstance");
		UnregisterInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterInstance_FunctionAddress);
		UnregisterInstance_IsValid = UnregisterInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:UnregisterInstance", UnregisterInstance_IsValid);
		SetCustomOutputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCustomOutputNodeEventName");
		SetCustomOutputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomOutputNodeEventName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomOutputNodeEventName_Node_PropertyAddress, SetCustomOutputNodeEventName_FunctionAddress, "Node");
		SetCustomOutputNodeEventName_Node_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomOutputNodeEventName_FunctionAddress, "Node");
		SetCustomOutputNodeEventName_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomOutputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomOutputNodeEventName_InEventName_PropertyAddress, SetCustomOutputNodeEventName_FunctionAddress, "InEventName");
		SetCustomOutputNodeEventName_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomOutputNodeEventName_FunctionAddress, "InEventName");
		SetCustomOutputNodeEventName_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomOutputNodeEventName_FunctionAddress, "InEventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomOutputNodeEventName_ReturnValue_PropertyAddress, SetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomOutputNodeEventName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomOutputNodeEventName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomOutputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomOutputNodeEventName_IsValid = SetCustomOutputNodeEventName_FunctionAddress != IntPtr.Zero && SetCustomOutputNodeEventName_Node_IsValid && SetCustomOutputNodeEventName_InEventName_IsValid && SetCustomOutputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:SetCustomOutputNodeEventName", SetCustomOutputNodeEventName_IsValid);
		SetCustomInputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCustomInputNodeEventName");
		SetCustomInputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomInputNodeEventName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomInputNodeEventName_Node_PropertyAddress, SetCustomInputNodeEventName_FunctionAddress, "Node");
		SetCustomInputNodeEventName_Node_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomInputNodeEventName_FunctionAddress, "Node");
		SetCustomInputNodeEventName_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomInputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomInputNodeEventName_InEventName_PropertyAddress, SetCustomInputNodeEventName_FunctionAddress, "InEventName");
		SetCustomInputNodeEventName_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomInputNodeEventName_FunctionAddress, "InEventName");
		SetCustomInputNodeEventName_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomInputNodeEventName_FunctionAddress, "InEventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomInputNodeEventName_ReturnValue_PropertyAddress, SetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomInputNodeEventName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		SetCustomInputNodeEventName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomInputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomInputNodeEventName_IsValid = SetCustomInputNodeEventName_FunctionAddress != IntPtr.Zero && SetCustomInputNodeEventName_Node_IsValid && SetCustomInputNodeEventName_InEventName_IsValid && SetCustomInputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:SetCustomInputNodeEventName", SetCustomInputNodeEventName_IsValid);
		RegisterInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterInstance");
		RegisterInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterInstance_Instance_PropertyAddress, RegisterInstance_FunctionAddress, "Instance");
		RegisterInstance_Instance_Offset = NativeReflectionCached.GetPropertyOffset(RegisterInstance_FunctionAddress, "Instance");
		RegisterInstance_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterInstance_FunctionAddress, "Instance", Classes.FObjectProperty);
		RegisterInstance_IsValid = RegisterInstance_FunctionAddress != IntPtr.Zero && RegisterInstance_Instance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:RegisterInstance", RegisterInstance_IsValid);
		GetSubGraphNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubGraphNodeClasses");
		GetSubGraphNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubGraphNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubGraphNodeClasses_OutClasses_PropertyAddress, GetSubGraphNodeClasses_FunctionAddress, "OutClasses");
		GetSubGraphNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetSubGraphNodeClasses_FunctionAddress, "OutClasses");
		GetSubGraphNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubGraphNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubGraphNodeClasses_ReturnValue_PropertyAddress, GetSubGraphNodeClasses_FunctionAddress, "ReturnValue");
		GetSubGraphNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubGraphNodeClasses_FunctionAddress, "ReturnValue");
		GetSubGraphNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubGraphNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSubGraphNodeClasses_IsValid = GetSubGraphNodeClasses_FunctionAddress != IntPtr.Zero && GetSubGraphNodeClasses_OutClasses_IsValid && GetSubGraphNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetSubGraphNodeClasses", GetSubGraphNodeClasses_IsValid);
		GetStartNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartNodeClasses");
		GetStartNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartNodeClasses_OutClasses_PropertyAddress, GetStartNodeClasses_FunctionAddress, "OutClasses");
		GetStartNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetStartNodeClasses_FunctionAddress, "OutClasses");
		GetStartNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartNodeClasses_ReturnValue_PropertyAddress, GetStartNodeClasses_FunctionAddress, "ReturnValue");
		GetStartNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartNodeClasses_FunctionAddress, "ReturnValue");
		GetStartNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStartNodeClasses_IsValid = GetStartNodeClasses_FunctionAddress != IntPtr.Zero && GetStartNodeClasses_OutClasses_IsValid && GetStartNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetStartNodeClasses", GetStartNodeClasses_IsValid);
		GetRerouteNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRerouteNodeClasses");
		GetRerouteNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRerouteNodeClasses_OutClasses_PropertyAddress, GetRerouteNodeClasses_FunctionAddress, "OutClasses");
		GetRerouteNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetRerouteNodeClasses_FunctionAddress, "OutClasses");
		GetRerouteNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRerouteNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRerouteNodeClasses_ReturnValue_PropertyAddress, GetRerouteNodeClasses_FunctionAddress, "ReturnValue");
		GetRerouteNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRerouteNodeClasses_FunctionAddress, "ReturnValue");
		GetRerouteNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRerouteNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRerouteNodeClasses_IsValid = GetRerouteNodeClasses_FunctionAddress != IntPtr.Zero && GetRerouteNodeClasses_OutClasses_IsValid && GetRerouteNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetRerouteNodeClasses", GetRerouteNodeClasses_IsValid);
		GetInstanceChecked_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInstanceChecked");
		GetInstanceChecked_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstanceChecked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceChecked_ReturnValue_PropertyAddress, GetInstanceChecked_FunctionAddress, "ReturnValue");
		GetInstanceChecked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceChecked_FunctionAddress, "ReturnValue");
		GetInstanceChecked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceChecked_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInstanceChecked_IsValid = GetInstanceChecked_FunctionAddress != IntPtr.Zero && GetInstanceChecked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetInstanceChecked", GetInstanceChecked_IsValid);
		GetFinishNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFinishNodeClasses");
		GetFinishNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFinishNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFinishNodeClasses_OutClasses_PropertyAddress, GetFinishNodeClasses_FunctionAddress, "OutClasses");
		GetFinishNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetFinishNodeClasses_FunctionAddress, "OutClasses");
		GetFinishNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFinishNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFinishNodeClasses_ReturnValue_PropertyAddress, GetFinishNodeClasses_FunctionAddress, "ReturnValue");
		GetFinishNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFinishNodeClasses_FunctionAddress, "ReturnValue");
		GetFinishNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFinishNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFinishNodeClasses_IsValid = GetFinishNodeClasses_FunctionAddress != IntPtr.Zero && GetFinishNodeClasses_OutClasses_IsValid && GetFinishNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetFinishNodeClasses", GetFinishNodeClasses_IsValid);
		GetExecutionSequenceNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExecutionSequenceNodeClasses");
		GetExecutionSequenceNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExecutionSequenceNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExecutionSequenceNodeClasses_OutClasses_PropertyAddress, GetExecutionSequenceNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionSequenceNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetExecutionSequenceNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionSequenceNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExecutionSequenceNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExecutionSequenceNodeClasses_ReturnValue_PropertyAddress, GetExecutionSequenceNodeClasses_FunctionAddress, "ReturnValue");
		GetExecutionSequenceNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExecutionSequenceNodeClasses_FunctionAddress, "ReturnValue");
		GetExecutionSequenceNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExecutionSequenceNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExecutionSequenceNodeClasses_IsValid = GetExecutionSequenceNodeClasses_FunctionAddress != IntPtr.Zero && GetExecutionSequenceNodeClasses_OutClasses_IsValid && GetExecutionSequenceNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetExecutionSequenceNodeClasses", GetExecutionSequenceNodeClasses_IsValid);
		GetExecutionMultiGateNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExecutionMultiGateNodeClasses");
		GetExecutionMultiGateNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExecutionMultiGateNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExecutionMultiGateNodeClasses_OutClasses_PropertyAddress, GetExecutionMultiGateNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionMultiGateNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetExecutionMultiGateNodeClasses_FunctionAddress, "OutClasses");
		GetExecutionMultiGateNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExecutionMultiGateNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExecutionMultiGateNodeClasses_ReturnValue_PropertyAddress, GetExecutionMultiGateNodeClasses_FunctionAddress, "ReturnValue");
		GetExecutionMultiGateNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExecutionMultiGateNodeClasses_FunctionAddress, "ReturnValue");
		GetExecutionMultiGateNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExecutionMultiGateNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExecutionMultiGateNodeClasses_IsValid = GetExecutionMultiGateNodeClasses_FunctionAddress != IntPtr.Zero && GetExecutionMultiGateNodeClasses_OutClasses_IsValid && GetExecutionMultiGateNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetExecutionMultiGateNodeClasses", GetExecutionMultiGateNodeClasses_IsValid);
		GetCustomOutputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomOutputNodeEventName");
		GetCustomOutputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomOutputNodeEventName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomOutputNodeEventName_Node_PropertyAddress, GetCustomOutputNodeEventName_FunctionAddress, "Node");
		GetCustomOutputNodeEventName_Node_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomOutputNodeEventName_FunctionAddress, "Node");
		GetCustomOutputNodeEventName_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomOutputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomOutputNodeEventName_OutEventName_PropertyAddress, GetCustomOutputNodeEventName_FunctionAddress, "OutEventName");
		GetCustomOutputNodeEventName_OutEventName_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomOutputNodeEventName_FunctionAddress, "OutEventName");
		GetCustomOutputNodeEventName_OutEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomOutputNodeEventName_FunctionAddress, "OutEventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomOutputNodeEventName_ReturnValue_PropertyAddress, GetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeEventName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomOutputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeEventName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomOutputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomOutputNodeEventName_IsValid = GetCustomOutputNodeEventName_FunctionAddress != IntPtr.Zero && GetCustomOutputNodeEventName_Node_IsValid && GetCustomOutputNodeEventName_OutEventName_IsValid && GetCustomOutputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeEventName", GetCustomOutputNodeEventName_IsValid);
		GetCustomOutputNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomOutputNodeClasses");
		GetCustomOutputNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomOutputNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomOutputNodeClasses_OutClasses_PropertyAddress, GetCustomOutputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomOutputNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomOutputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomOutputNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomOutputNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomOutputNodeClasses_ReturnValue_PropertyAddress, GetCustomOutputNodeClasses_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomOutputNodeClasses_FunctionAddress, "ReturnValue");
		GetCustomOutputNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomOutputNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCustomOutputNodeClasses_IsValid = GetCustomOutputNodeClasses_FunctionAddress != IntPtr.Zero && GetCustomOutputNodeClasses_OutClasses_IsValid && GetCustomOutputNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetCustomOutputNodeClasses", GetCustomOutputNodeClasses_IsValid);
		GetCustomInputNodeEventName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomInputNodeEventName");
		GetCustomInputNodeEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomInputNodeEventName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomInputNodeEventName_Node_PropertyAddress, GetCustomInputNodeEventName_FunctionAddress, "Node");
		GetCustomInputNodeEventName_Node_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomInputNodeEventName_FunctionAddress, "Node");
		GetCustomInputNodeEventName_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomInputNodeEventName_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomInputNodeEventName_OutEventName_PropertyAddress, GetCustomInputNodeEventName_FunctionAddress, "OutEventName");
		GetCustomInputNodeEventName_OutEventName_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomInputNodeEventName_FunctionAddress, "OutEventName");
		GetCustomInputNodeEventName_OutEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomInputNodeEventName_FunctionAddress, "OutEventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomInputNodeEventName_ReturnValue_PropertyAddress, GetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomInputNodeEventName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomInputNodeEventName_FunctionAddress, "ReturnValue");
		GetCustomInputNodeEventName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomInputNodeEventName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomInputNodeEventName_IsValid = GetCustomInputNodeEventName_FunctionAddress != IntPtr.Zero && GetCustomInputNodeEventName_Node_IsValid && GetCustomInputNodeEventName_OutEventName_IsValid && GetCustomInputNodeEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeEventName", GetCustomInputNodeEventName_IsValid);
		GetCustomInputNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomInputNodeClasses");
		GetCustomInputNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomInputNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomInputNodeClasses_OutClasses_PropertyAddress, GetCustomInputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomInputNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomInputNodeClasses_FunctionAddress, "OutClasses");
		GetCustomInputNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomInputNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomInputNodeClasses_ReturnValue_PropertyAddress, GetCustomInputNodeClasses_FunctionAddress, "ReturnValue");
		GetCustomInputNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomInputNodeClasses_FunctionAddress, "ReturnValue");
		GetCustomInputNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomInputNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCustomInputNodeClasses_IsValid = GetCustomInputNodeClasses_FunctionAddress != IntPtr.Zero && GetCustomInputNodeClasses_OutClasses_IsValid && GetCustomInputNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetCustomInputNodeClasses", GetCustomInputNodeClasses_IsValid);
		GetComponentObserverNodeClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetComponentObserverNodeClasses");
		GetComponentObserverNodeClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentObserverNodeClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentObserverNodeClasses_OutClasses_PropertyAddress, GetComponentObserverNodeClasses_FunctionAddress, "OutClasses");
		GetComponentObserverNodeClasses_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentObserverNodeClasses_FunctionAddress, "OutClasses");
		GetComponentObserverNodeClasses_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentObserverNodeClasses_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponentObserverNodeClasses_ReturnValue_PropertyAddress, GetComponentObserverNodeClasses_FunctionAddress, "ReturnValue");
		GetComponentObserverNodeClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentObserverNodeClasses_FunctionAddress, "ReturnValue");
		GetComponentObserverNodeClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentObserverNodeClasses_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetComponentObserverNodeClasses_IsValid = GetComponentObserverNodeClasses_FunctionAddress != IntPtr.Zero && GetComponentObserverNodeClasses_OutClasses_IsValid && GetComponentObserverNodeClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetComponentObserverNodeClasses", GetComponentObserverNodeClasses_IsValid);
		GetAssetClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetClass");
		GetAssetClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetClass_InViewType_PropertyAddress, GetAssetClass_FunctionAddress, "InViewType");
		GetAssetClass_InViewType_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetClass_FunctionAddress, "InViewType");
		GetAssetClass_InViewType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetClass_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetClass_ReturnValue_PropertyAddress, GetAssetClass_FunctionAddress, "ReturnValue");
		GetAssetClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetClass_FunctionAddress, "ReturnValue");
		GetAssetClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetAssetClass_IsValid = GetAssetClass_FunctionAddress != IntPtr.Zero && GetAssetClass_InViewType_IsValid && GetAssetClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:GetAssetClass", GetAssetClass_IsValid);
		ConvertCalliopeGuidToGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertCalliopeGuidToGuid");
		ConvertCalliopeGuidToGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertCalliopeGuidToGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertCalliopeGuidToGuid_InCalliopeGuid_PropertyAddress, ConvertCalliopeGuidToGuid_FunctionAddress, "InCalliopeGuid");
		ConvertCalliopeGuidToGuid_InCalliopeGuid_Offset = NativeReflectionCached.GetPropertyOffset(ConvertCalliopeGuidToGuid_FunctionAddress, "InCalliopeGuid");
		ConvertCalliopeGuidToGuid_InCalliopeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertCalliopeGuidToGuid_FunctionAddress, "InCalliopeGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertCalliopeGuidToGuid_ReturnValue_PropertyAddress, ConvertCalliopeGuidToGuid_FunctionAddress, "ReturnValue");
		ConvertCalliopeGuidToGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertCalliopeGuidToGuid_FunctionAddress, "ReturnValue");
		ConvertCalliopeGuidToGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertCalliopeGuidToGuid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertCalliopeGuidToGuid_IsValid = ConvertCalliopeGuidToGuid_FunctionAddress != IntPtr.Zero && ConvertCalliopeGuidToGuid_InCalliopeGuid_IsValid && ConvertCalliopeGuidToGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeInteractor:ConvertCalliopeGuidToGuid", ConvertCalliopeGuidToGuid_IsValid);
	}
}
