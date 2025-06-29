using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AIModule.BTFunctionLibrary", "AIModule", UnrealModuleType.Engine)]
public class UBTFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetBlackboardValueAsVector_IsValid;

	private static IntPtr SetBlackboardValueAsVector_FunctionAddress;

	private static int SetBlackboardValueAsVector_ParamsSize;

	private static bool SetBlackboardValueAsVector_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsVector_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsVector_NodeOwner_Offset;

	private static bool SetBlackboardValueAsVector_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsVector_Key_PropertyAddress;

	private static int SetBlackboardValueAsVector_Key_Offset;

	private static bool SetBlackboardValueAsVector_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsVector_Value_PropertyAddress;

	private static int SetBlackboardValueAsVector_Value_Offset;

	private static bool SetBlackboardValueAsString_IsValid;

	private static IntPtr SetBlackboardValueAsString_FunctionAddress;

	private static int SetBlackboardValueAsString_ParamsSize;

	private static bool SetBlackboardValueAsString_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsString_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsString_NodeOwner_Offset;

	private static bool SetBlackboardValueAsString_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsString_Key_PropertyAddress;

	private static int SetBlackboardValueAsString_Key_Offset;

	private static bool SetBlackboardValueAsString_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsString_Value_PropertyAddress;

	private static int SetBlackboardValueAsString_Value_Offset;

	private static bool SetBlackboardValueAsRotator_IsValid;

	private static IntPtr SetBlackboardValueAsRotator_FunctionAddress;

	private static int SetBlackboardValueAsRotator_ParamsSize;

	private static bool SetBlackboardValueAsRotator_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsRotator_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsRotator_NodeOwner_Offset;

	private static bool SetBlackboardValueAsRotator_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsRotator_Key_PropertyAddress;

	private static int SetBlackboardValueAsRotator_Key_Offset;

	private static bool SetBlackboardValueAsRotator_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsRotator_Value_PropertyAddress;

	private static int SetBlackboardValueAsRotator_Value_Offset;

	private static bool SetBlackboardValueAsObject_IsValid;

	private static IntPtr SetBlackboardValueAsObject_FunctionAddress;

	private static int SetBlackboardValueAsObject_ParamsSize;

	private static bool SetBlackboardValueAsObject_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsObject_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsObject_NodeOwner_Offset;

	private static bool SetBlackboardValueAsObject_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsObject_Key_PropertyAddress;

	private static int SetBlackboardValueAsObject_Key_Offset;

	private static bool SetBlackboardValueAsObject_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsObject_Value_PropertyAddress;

	private static int SetBlackboardValueAsObject_Value_Offset;

	private static bool SetBlackboardValueAsName_IsValid;

	private static IntPtr SetBlackboardValueAsName_FunctionAddress;

	private static int SetBlackboardValueAsName_ParamsSize;

	private static bool SetBlackboardValueAsName_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsName_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsName_NodeOwner_Offset;

	private static bool SetBlackboardValueAsName_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsName_Key_PropertyAddress;

	private static int SetBlackboardValueAsName_Key_Offset;

	private static bool SetBlackboardValueAsName_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsName_Value_PropertyAddress;

	private static int SetBlackboardValueAsName_Value_Offset;

	private static bool SetBlackboardValueAsInt_IsValid;

	private static IntPtr SetBlackboardValueAsInt_FunctionAddress;

	private static int SetBlackboardValueAsInt_ParamsSize;

	private static bool SetBlackboardValueAsInt_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsInt_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsInt_NodeOwner_Offset;

	private static bool SetBlackboardValueAsInt_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsInt_Key_PropertyAddress;

	private static int SetBlackboardValueAsInt_Key_Offset;

	private static bool SetBlackboardValueAsInt_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsInt_Value_PropertyAddress;

	private static int SetBlackboardValueAsInt_Value_Offset;

	private static bool SetBlackboardValueAsFloat_IsValid;

	private static IntPtr SetBlackboardValueAsFloat_FunctionAddress;

	private static int SetBlackboardValueAsFloat_ParamsSize;

	private static bool SetBlackboardValueAsFloat_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsFloat_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsFloat_NodeOwner_Offset;

	private static bool SetBlackboardValueAsFloat_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsFloat_Key_PropertyAddress;

	private static int SetBlackboardValueAsFloat_Key_Offset;

	private static bool SetBlackboardValueAsFloat_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsFloat_Value_PropertyAddress;

	private static int SetBlackboardValueAsFloat_Value_Offset;

	private static bool SetBlackboardValueAsEnum_IsValid;

	private static IntPtr SetBlackboardValueAsEnum_FunctionAddress;

	private static int SetBlackboardValueAsEnum_ParamsSize;

	private static bool SetBlackboardValueAsEnum_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsEnum_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsEnum_NodeOwner_Offset;

	private static bool SetBlackboardValueAsEnum_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsEnum_Key_PropertyAddress;

	private static int SetBlackboardValueAsEnum_Key_Offset;

	private static bool SetBlackboardValueAsEnum_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsEnum_Value_PropertyAddress;

	private static int SetBlackboardValueAsEnum_Value_Offset;

	private static bool SetBlackboardValueAsClass_IsValid;

	private static IntPtr SetBlackboardValueAsClass_FunctionAddress;

	private static int SetBlackboardValueAsClass_ParamsSize;

	private static bool SetBlackboardValueAsClass_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsClass_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsClass_NodeOwner_Offset;

	private static bool SetBlackboardValueAsClass_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsClass_Key_PropertyAddress;

	private static int SetBlackboardValueAsClass_Key_Offset;

	private static bool SetBlackboardValueAsClass_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsClass_Value_PropertyAddress;

	private static int SetBlackboardValueAsClass_Value_Offset;

	private static bool SetBlackboardValueAsBool_IsValid;

	private static IntPtr SetBlackboardValueAsBool_FunctionAddress;

	private static int SetBlackboardValueAsBool_ParamsSize;

	private static bool SetBlackboardValueAsBool_NodeOwner_IsValid;

	private static FFieldAddress SetBlackboardValueAsBool_NodeOwner_PropertyAddress;

	private static int SetBlackboardValueAsBool_NodeOwner_Offset;

	private static bool SetBlackboardValueAsBool_Key_IsValid;

	private static FFieldAddress SetBlackboardValueAsBool_Key_PropertyAddress;

	private static int SetBlackboardValueAsBool_Key_Offset;

	private static bool SetBlackboardValueAsBool_Value_IsValid;

	private static FFieldAddress SetBlackboardValueAsBool_Value_PropertyAddress;

	private static int SetBlackboardValueAsBool_Value_Offset;

	private static bool GetOwnersBlackboard_IsValid;

	private static IntPtr GetOwnersBlackboard_FunctionAddress;

	private static int GetOwnersBlackboard_ParamsSize;

	private static bool GetOwnersBlackboard_NodeOwner_IsValid;

	private static FFieldAddress GetOwnersBlackboard_NodeOwner_PropertyAddress;

	private static int GetOwnersBlackboard_NodeOwner_Offset;

	private static bool GetOwnersBlackboard_ReturnValue_IsValid;

	private static FFieldAddress GetOwnersBlackboard_ReturnValue_PropertyAddress;

	private static int GetOwnersBlackboard_ReturnValue_Offset;

	private static bool GetOwnerComponent_IsValid;

	private static IntPtr GetOwnerComponent_FunctionAddress;

	private static int GetOwnerComponent_ParamsSize;

	private static bool GetOwnerComponent_NodeOwner_IsValid;

	private static FFieldAddress GetOwnerComponent_NodeOwner_PropertyAddress;

	private static int GetOwnerComponent_NodeOwner_Offset;

	private static bool GetOwnerComponent_ReturnValue_IsValid;

	private static FFieldAddress GetOwnerComponent_ReturnValue_PropertyAddress;

	private static int GetOwnerComponent_ReturnValue_Offset;

	private static bool GetBlackboardValueAsVector_IsValid;

	private static IntPtr GetBlackboardValueAsVector_FunctionAddress;

	private static int GetBlackboardValueAsVector_ParamsSize;

	private static bool GetBlackboardValueAsVector_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsVector_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsVector_NodeOwner_Offset;

	private static bool GetBlackboardValueAsVector_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsVector_Key_PropertyAddress;

	private static int GetBlackboardValueAsVector_Key_Offset;

	private static bool GetBlackboardValueAsVector_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsVector_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsVector_ReturnValue_Offset;

	private static bool GetBlackboardValueAsString_IsValid;

	private static IntPtr GetBlackboardValueAsString_FunctionAddress;

	private static int GetBlackboardValueAsString_ParamsSize;

	private static bool GetBlackboardValueAsString_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsString_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsString_NodeOwner_Offset;

	private static bool GetBlackboardValueAsString_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsString_Key_PropertyAddress;

	private static int GetBlackboardValueAsString_Key_Offset;

	private static bool GetBlackboardValueAsString_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsString_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsString_ReturnValue_Offset;

	private static bool GetBlackboardValueAsRotator_IsValid;

	private static IntPtr GetBlackboardValueAsRotator_FunctionAddress;

	private static int GetBlackboardValueAsRotator_ParamsSize;

	private static bool GetBlackboardValueAsRotator_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsRotator_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsRotator_NodeOwner_Offset;

	private static bool GetBlackboardValueAsRotator_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsRotator_Key_PropertyAddress;

	private static int GetBlackboardValueAsRotator_Key_Offset;

	private static bool GetBlackboardValueAsRotator_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsRotator_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsRotator_ReturnValue_Offset;

	private static bool GetBlackboardValueAsObject_IsValid;

	private static IntPtr GetBlackboardValueAsObject_FunctionAddress;

	private static int GetBlackboardValueAsObject_ParamsSize;

	private static bool GetBlackboardValueAsObject_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsObject_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsObject_NodeOwner_Offset;

	private static bool GetBlackboardValueAsObject_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsObject_Key_PropertyAddress;

	private static int GetBlackboardValueAsObject_Key_Offset;

	private static bool GetBlackboardValueAsObject_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsObject_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsObject_ReturnValue_Offset;

	private static bool GetBlackboardValueAsName_IsValid;

	private static IntPtr GetBlackboardValueAsName_FunctionAddress;

	private static int GetBlackboardValueAsName_ParamsSize;

	private static bool GetBlackboardValueAsName_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsName_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsName_NodeOwner_Offset;

	private static bool GetBlackboardValueAsName_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsName_Key_PropertyAddress;

	private static int GetBlackboardValueAsName_Key_Offset;

	private static bool GetBlackboardValueAsName_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsName_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsName_ReturnValue_Offset;

	private static bool GetBlackboardValueAsInt_IsValid;

	private static IntPtr GetBlackboardValueAsInt_FunctionAddress;

	private static int GetBlackboardValueAsInt_ParamsSize;

	private static bool GetBlackboardValueAsInt_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsInt_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsInt_NodeOwner_Offset;

	private static bool GetBlackboardValueAsInt_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsInt_Key_PropertyAddress;

	private static int GetBlackboardValueAsInt_Key_Offset;

	private static bool GetBlackboardValueAsInt_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsInt_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsInt_ReturnValue_Offset;

	private static bool GetBlackboardValueAsFloat_IsValid;

	private static IntPtr GetBlackboardValueAsFloat_FunctionAddress;

	private static int GetBlackboardValueAsFloat_ParamsSize;

	private static bool GetBlackboardValueAsFloat_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsFloat_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsFloat_NodeOwner_Offset;

	private static bool GetBlackboardValueAsFloat_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsFloat_Key_PropertyAddress;

	private static int GetBlackboardValueAsFloat_Key_Offset;

	private static bool GetBlackboardValueAsFloat_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsFloat_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsFloat_ReturnValue_Offset;

	private static bool GetBlackboardValueAsEnum_IsValid;

	private static IntPtr GetBlackboardValueAsEnum_FunctionAddress;

	private static int GetBlackboardValueAsEnum_ParamsSize;

	private static bool GetBlackboardValueAsEnum_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsEnum_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsEnum_NodeOwner_Offset;

	private static bool GetBlackboardValueAsEnum_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsEnum_Key_PropertyAddress;

	private static int GetBlackboardValueAsEnum_Key_Offset;

	private static bool GetBlackboardValueAsEnum_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsEnum_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsEnum_ReturnValue_Offset;

	private static bool GetBlackboardValueAsClass_IsValid;

	private static IntPtr GetBlackboardValueAsClass_FunctionAddress;

	private static int GetBlackboardValueAsClass_ParamsSize;

	private static bool GetBlackboardValueAsClass_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsClass_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsClass_NodeOwner_Offset;

	private static bool GetBlackboardValueAsClass_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsClass_Key_PropertyAddress;

	private static int GetBlackboardValueAsClass_Key_Offset;

	private static bool GetBlackboardValueAsClass_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsClass_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsClass_ReturnValue_Offset;

	private static bool GetBlackboardValueAsBool_IsValid;

	private static IntPtr GetBlackboardValueAsBool_FunctionAddress;

	private static int GetBlackboardValueAsBool_ParamsSize;

	private static bool GetBlackboardValueAsBool_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsBool_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsBool_NodeOwner_Offset;

	private static bool GetBlackboardValueAsBool_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsBool_Key_PropertyAddress;

	private static int GetBlackboardValueAsBool_Key_Offset;

	private static bool GetBlackboardValueAsBool_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsBool_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsBool_ReturnValue_Offset;

	private static bool GetBlackboardValueAsActor_IsValid;

	private static IntPtr GetBlackboardValueAsActor_FunctionAddress;

	private static int GetBlackboardValueAsActor_ParamsSize;

	private static bool GetBlackboardValueAsActor_NodeOwner_IsValid;

	private static FFieldAddress GetBlackboardValueAsActor_NodeOwner_PropertyAddress;

	private static int GetBlackboardValueAsActor_NodeOwner_Offset;

	private static bool GetBlackboardValueAsActor_Key_IsValid;

	private static FFieldAddress GetBlackboardValueAsActor_Key_PropertyAddress;

	private static int GetBlackboardValueAsActor_Key_Offset;

	private static bool GetBlackboardValueAsActor_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboardValueAsActor_ReturnValue_PropertyAddress;

	private static int GetBlackboardValueAsActor_ReturnValue_Offset;

	private static bool ClearBlackboardValue_IsValid;

	private static IntPtr ClearBlackboardValue_FunctionAddress;

	private static int ClearBlackboardValue_ParamsSize;

	private static bool ClearBlackboardValue_NodeOwner_IsValid;

	private static FFieldAddress ClearBlackboardValue_NodeOwner_PropertyAddress;

	private static int ClearBlackboardValue_NodeOwner_Offset;

	private static bool ClearBlackboardValue_Key_IsValid;

	private static FFieldAddress ClearBlackboardValue_Key_PropertyAddress;

	private static int ClearBlackboardValue_Key_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsVector")]
	public unsafe static void SetBlackboardValueAsVector(UBTNode NodeOwner, FBlackboardKeySelector Key, FVector Value)
	{
		if (!SetBlackboardValueAsVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsVector_NodeOwner_Offset), 0, SetBlackboardValueAsVector_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsVector_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsVector_Key_Offset), 0, SetBlackboardValueAsVector_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsVector_Value_Offset), 0, SetBlackboardValueAsVector_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsVector_FunctionAddress, intPtr, SetBlackboardValueAsVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsVector_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsString")]
	public unsafe static void SetBlackboardValueAsString(UBTNode NodeOwner, FBlackboardKeySelector Key, string Value)
	{
		if (!SetBlackboardValueAsString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsString_NodeOwner_Offset), 0, SetBlackboardValueAsString_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsString_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsString_Key_Offset), 0, SetBlackboardValueAsString_Key_PropertyAddress.Address, Key);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsString_Value_Offset), 0, SetBlackboardValueAsString_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsString_FunctionAddress, intPtr, SetBlackboardValueAsString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsString_Key_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsString_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsRotator")]
	public unsafe static void SetBlackboardValueAsRotator(UBTNode NodeOwner, FBlackboardKeySelector Key, FRotator Value)
	{
		if (!SetBlackboardValueAsRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsRotator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsRotator_NodeOwner_Offset), 0, SetBlackboardValueAsRotator_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsRotator_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsRotator_Key_Offset), 0, SetBlackboardValueAsRotator_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsRotator_Value_Offset), 0, SetBlackboardValueAsRotator_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsRotator_FunctionAddress, intPtr, SetBlackboardValueAsRotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsRotator_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsObject")]
	public unsafe static void SetBlackboardValueAsObject(UBTNode NodeOwner, FBlackboardKeySelector Key, UObject Value)
	{
		if (!SetBlackboardValueAsObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsObject_NodeOwner_Offset), 0, SetBlackboardValueAsObject_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsObject_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsObject_Key_Offset), 0, SetBlackboardValueAsObject_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsObject_Value_Offset), 0, SetBlackboardValueAsObject_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsObject_FunctionAddress, intPtr, SetBlackboardValueAsObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsObject_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsName")]
	public unsafe static void SetBlackboardValueAsName(UBTNode NodeOwner, FBlackboardKeySelector Key, FName Value)
	{
		if (!SetBlackboardValueAsName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsName_NodeOwner_Offset), 0, SetBlackboardValueAsName_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsName_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsName_Key_Offset), 0, SetBlackboardValueAsName_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsName_Value_Offset), 0, SetBlackboardValueAsName_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsName_FunctionAddress, intPtr, SetBlackboardValueAsName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsName_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsInt")]
	public unsafe static void SetBlackboardValueAsInt(UBTNode NodeOwner, FBlackboardKeySelector Key, int Value)
	{
		if (!SetBlackboardValueAsInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsInt_NodeOwner_Offset), 0, SetBlackboardValueAsInt_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsInt_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsInt_Key_Offset), 0, SetBlackboardValueAsInt_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsInt_Value_Offset), 0, SetBlackboardValueAsInt_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsInt_FunctionAddress, intPtr, SetBlackboardValueAsInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsInt_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsFloat")]
	public unsafe static void SetBlackboardValueAsFloat(UBTNode NodeOwner, FBlackboardKeySelector Key, float Value)
	{
		if (!SetBlackboardValueAsFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsFloat_NodeOwner_Offset), 0, SetBlackboardValueAsFloat_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsFloat_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsFloat_Key_Offset), 0, SetBlackboardValueAsFloat_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsFloat_Value_Offset), 0, SetBlackboardValueAsFloat_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsFloat_FunctionAddress, intPtr, SetBlackboardValueAsFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsFloat_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsEnum")]
	public unsafe static void SetBlackboardValueAsEnum(UBTNode NodeOwner, FBlackboardKeySelector Key, byte Value)
	{
		if (!SetBlackboardValueAsEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsEnum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsEnum_NodeOwner_Offset), 0, SetBlackboardValueAsEnum_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsEnum_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsEnum_Key_Offset), 0, SetBlackboardValueAsEnum_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsEnum_Value_Offset), 0, SetBlackboardValueAsEnum_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsEnum_FunctionAddress, intPtr, SetBlackboardValueAsEnum_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsEnum_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsClass")]
	public unsafe static void SetBlackboardValueAsClass(UBTNode NodeOwner, FBlackboardKeySelector Key, TSubclassOf<UObject> Value)
	{
		if (!SetBlackboardValueAsClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsClass_NodeOwner_Offset), 0, SetBlackboardValueAsClass_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsClass_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsClass_Key_Offset), 0, SetBlackboardValueAsClass_Key_PropertyAddress.Address, Key);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsClass_Value_Offset), 0, SetBlackboardValueAsClass_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsClass_FunctionAddress, intPtr, SetBlackboardValueAsClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsClass_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsBool")]
	public unsafe static void SetBlackboardValueAsBool(UBTNode NodeOwner, FBlackboardKeySelector Key, bool Value)
	{
		if (!SetBlackboardValueAsBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlackboardValueAsBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlackboardValueAsBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsBool_NodeOwner_Offset), 0, SetBlackboardValueAsBool_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(SetBlackboardValueAsBool_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsBool_Key_Offset), 0, SetBlackboardValueAsBool_Key_PropertyAddress.Address, Key);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBlackboardValueAsBool_Value_Offset), 0, SetBlackboardValueAsBool_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlackboardValueAsBool_FunctionAddress, intPtr, SetBlackboardValueAsBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBlackboardValueAsBool_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetOwnersBlackboard")]
	public unsafe static UBlackboardComponent GetOwnersBlackboard(UBTNode NodeOwner)
	{
		if (!GetOwnersBlackboard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetOwnersBlackboard");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnersBlackboard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnersBlackboard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetOwnersBlackboard_NodeOwner_Offset), 0, GetOwnersBlackboard_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOwnersBlackboard_FunctionAddress, intPtr, GetOwnersBlackboard_ParamsSize);
		return UObjectMarshaler<UBlackboardComponent>.FromNative(IntPtr.Add(intPtr, GetOwnersBlackboard_ReturnValue_Offset), 0, GetOwnersBlackboard_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetOwnerComponent")]
	public unsafe static UBehaviorTreeComponent GetOwnerComponent(UBTNode NodeOwner)
	{
		if (!GetOwnerComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetOwnerComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnerComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnerComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetOwnerComponent_NodeOwner_Offset), 0, GetOwnerComponent_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOwnerComponent_FunctionAddress, intPtr, GetOwnerComponent_ParamsSize);
		return UObjectMarshaler<UBehaviorTreeComponent>.FromNative(IntPtr.Add(intPtr, GetOwnerComponent_ReturnValue_Offset), 0, GetOwnerComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsVector")]
	public unsafe static FVector GetBlackboardValueAsVector(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsVector_NodeOwner_Offset), 0, GetBlackboardValueAsVector_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsVector_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsVector_Key_Offset), 0, GetBlackboardValueAsVector_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsVector_FunctionAddress, intPtr, GetBlackboardValueAsVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsVector_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsVector_ReturnValue_Offset), 0, GetBlackboardValueAsVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsString")]
	public unsafe static string GetBlackboardValueAsString(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsString_NodeOwner_Offset), 0, GetBlackboardValueAsString_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsString_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsString_Key_Offset), 0, GetBlackboardValueAsString_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsString_FunctionAddress, intPtr, GetBlackboardValueAsString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsString_Key_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsString_ReturnValue_Offset), 0, GetBlackboardValueAsString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsRotator")]
	public unsafe static FRotator GetBlackboardValueAsRotator(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsRotator");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsRotator_NodeOwner_Offset), 0, GetBlackboardValueAsRotator_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsRotator_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsRotator_Key_Offset), 0, GetBlackboardValueAsRotator_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsRotator_FunctionAddress, intPtr, GetBlackboardValueAsRotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsRotator_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsRotator_ReturnValue_Offset), 0, GetBlackboardValueAsRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsObject")]
	public unsafe static UObject GetBlackboardValueAsObject(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsObject_NodeOwner_Offset), 0, GetBlackboardValueAsObject_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsObject_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsObject_Key_Offset), 0, GetBlackboardValueAsObject_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsObject_FunctionAddress, intPtr, GetBlackboardValueAsObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsObject_Key_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsObject_ReturnValue_Offset), 0, GetBlackboardValueAsObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsName")]
	public unsafe static FName GetBlackboardValueAsName(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsName_NodeOwner_Offset), 0, GetBlackboardValueAsName_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsName_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsName_Key_Offset), 0, GetBlackboardValueAsName_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsName_FunctionAddress, intPtr, GetBlackboardValueAsName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsName_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsName_ReturnValue_Offset), 0, GetBlackboardValueAsName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsInt")]
	public unsafe static int GetBlackboardValueAsInt(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsInt_NodeOwner_Offset), 0, GetBlackboardValueAsInt_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsInt_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsInt_Key_Offset), 0, GetBlackboardValueAsInt_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsInt_FunctionAddress, intPtr, GetBlackboardValueAsInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsInt_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsInt_ReturnValue_Offset), 0, GetBlackboardValueAsInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsFloat")]
	public unsafe static float GetBlackboardValueAsFloat(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsFloat_NodeOwner_Offset), 0, GetBlackboardValueAsFloat_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsFloat_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsFloat_Key_Offset), 0, GetBlackboardValueAsFloat_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsFloat_FunctionAddress, intPtr, GetBlackboardValueAsFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsFloat_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsFloat_ReturnValue_Offset), 0, GetBlackboardValueAsFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsEnum")]
	public unsafe static byte GetBlackboardValueAsEnum(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsEnum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsEnum_NodeOwner_Offset), 0, GetBlackboardValueAsEnum_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsEnum_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsEnum_Key_Offset), 0, GetBlackboardValueAsEnum_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsEnum_FunctionAddress, intPtr, GetBlackboardValueAsEnum_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsEnum_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsEnum_ReturnValue_Offset), 0, GetBlackboardValueAsEnum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsClass")]
	public unsafe static TSubclassOf<UObject> GetBlackboardValueAsClass(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsClass_NodeOwner_Offset), 0, GetBlackboardValueAsClass_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsClass_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsClass_Key_Offset), 0, GetBlackboardValueAsClass_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsClass_FunctionAddress, intPtr, GetBlackboardValueAsClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsClass_Key_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsClass_ReturnValue_Offset), 0, GetBlackboardValueAsClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsBool")]
	public unsafe static bool GetBlackboardValueAsBool(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsBool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsBool_NodeOwner_Offset), 0, GetBlackboardValueAsBool_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsBool_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsBool_Key_Offset), 0, GetBlackboardValueAsBool_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsBool_FunctionAddress, intPtr, GetBlackboardValueAsBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsBool_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsBool_ReturnValue_Offset), 0, GetBlackboardValueAsBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsActor")]
	public unsafe static AActor GetBlackboardValueAsActor(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!GetBlackboardValueAsActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboardValueAsActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboardValueAsActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsActor_NodeOwner_Offset), 0, GetBlackboardValueAsActor_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(GetBlackboardValueAsActor_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, GetBlackboardValueAsActor_Key_Offset), 0, GetBlackboardValueAsActor_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboardValueAsActor_FunctionAddress, intPtr, GetBlackboardValueAsActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlackboardValueAsActor_Key_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetBlackboardValueAsActor_ReturnValue_Offset), 0, GetBlackboardValueAsActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AIModule.BTFunctionLibrary:ClearBlackboardValue")]
	public unsafe static void ClearBlackboardValue(UBTNode NodeOwner, FBlackboardKeySelector Key)
	{
		if (!ClearBlackboardValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTFunctionLibrary:ClearBlackboardValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearBlackboardValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearBlackboardValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTNode>.ToNative(IntPtr.Add(intPtr, ClearBlackboardValue_NodeOwner_Offset), 0, ClearBlackboardValue_NodeOwner_PropertyAddress.Address, NodeOwner);
		NativeReflection.InitializeValue_InContainer(ClearBlackboardValue_Key_PropertyAddress.Address, intPtr);
		FBlackboardKeySelector.ToNative(IntPtr.Add(intPtr, ClearBlackboardValue_Key_Offset), 0, ClearBlackboardValue_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearBlackboardValue_FunctionAddress, intPtr, ClearBlackboardValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClearBlackboardValue_Key_PropertyAddress.Address, intPtr);
	}

	static UBTFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBTFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBTFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AIModule.BTFunctionLibrary");
		SetBlackboardValueAsVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsVector");
		SetBlackboardValueAsVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsVector_NodeOwner_PropertyAddress, SetBlackboardValueAsVector_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsVector_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsVector_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsVector_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsVector_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsVector_Key_PropertyAddress, SetBlackboardValueAsVector_FunctionAddress, "Key");
		SetBlackboardValueAsVector_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsVector_FunctionAddress, "Key");
		SetBlackboardValueAsVector_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsVector_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsVector_Value_PropertyAddress, SetBlackboardValueAsVector_FunctionAddress, "Value");
		SetBlackboardValueAsVector_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsVector_FunctionAddress, "Value");
		SetBlackboardValueAsVector_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsVector_FunctionAddress, "Value", Classes.FStructProperty);
		SetBlackboardValueAsVector_IsValid = SetBlackboardValueAsVector_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsVector_NodeOwner_IsValid && SetBlackboardValueAsVector_Key_IsValid && SetBlackboardValueAsVector_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsVector", SetBlackboardValueAsVector_IsValid);
		SetBlackboardValueAsString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsString");
		SetBlackboardValueAsString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsString_NodeOwner_PropertyAddress, SetBlackboardValueAsString_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsString_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsString_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsString_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsString_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsString_Key_PropertyAddress, SetBlackboardValueAsString_FunctionAddress, "Key");
		SetBlackboardValueAsString_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsString_FunctionAddress, "Key");
		SetBlackboardValueAsString_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsString_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsString_Value_PropertyAddress, SetBlackboardValueAsString_FunctionAddress, "Value");
		SetBlackboardValueAsString_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsString_FunctionAddress, "Value");
		SetBlackboardValueAsString_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsString_FunctionAddress, "Value", Classes.FStrProperty);
		SetBlackboardValueAsString_IsValid = SetBlackboardValueAsString_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsString_NodeOwner_IsValid && SetBlackboardValueAsString_Key_IsValid && SetBlackboardValueAsString_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsString", SetBlackboardValueAsString_IsValid);
		SetBlackboardValueAsRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsRotator");
		SetBlackboardValueAsRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsRotator_NodeOwner_PropertyAddress, SetBlackboardValueAsRotator_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsRotator_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsRotator_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsRotator_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsRotator_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsRotator_Key_PropertyAddress, SetBlackboardValueAsRotator_FunctionAddress, "Key");
		SetBlackboardValueAsRotator_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsRotator_FunctionAddress, "Key");
		SetBlackboardValueAsRotator_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsRotator_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsRotator_Value_PropertyAddress, SetBlackboardValueAsRotator_FunctionAddress, "Value");
		SetBlackboardValueAsRotator_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsRotator_FunctionAddress, "Value");
		SetBlackboardValueAsRotator_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsRotator_FunctionAddress, "Value", Classes.FStructProperty);
		SetBlackboardValueAsRotator_IsValid = SetBlackboardValueAsRotator_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsRotator_NodeOwner_IsValid && SetBlackboardValueAsRotator_Key_IsValid && SetBlackboardValueAsRotator_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsRotator", SetBlackboardValueAsRotator_IsValid);
		SetBlackboardValueAsObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsObject");
		SetBlackboardValueAsObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsObject_NodeOwner_PropertyAddress, SetBlackboardValueAsObject_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsObject_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsObject_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsObject_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsObject_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsObject_Key_PropertyAddress, SetBlackboardValueAsObject_FunctionAddress, "Key");
		SetBlackboardValueAsObject_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsObject_FunctionAddress, "Key");
		SetBlackboardValueAsObject_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsObject_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsObject_Value_PropertyAddress, SetBlackboardValueAsObject_FunctionAddress, "Value");
		SetBlackboardValueAsObject_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsObject_FunctionAddress, "Value");
		SetBlackboardValueAsObject_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsObject_FunctionAddress, "Value", Classes.FObjectProperty);
		SetBlackboardValueAsObject_IsValid = SetBlackboardValueAsObject_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsObject_NodeOwner_IsValid && SetBlackboardValueAsObject_Key_IsValid && SetBlackboardValueAsObject_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsObject", SetBlackboardValueAsObject_IsValid);
		SetBlackboardValueAsName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsName");
		SetBlackboardValueAsName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsName_NodeOwner_PropertyAddress, SetBlackboardValueAsName_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsName_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsName_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsName_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsName_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsName_Key_PropertyAddress, SetBlackboardValueAsName_FunctionAddress, "Key");
		SetBlackboardValueAsName_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsName_FunctionAddress, "Key");
		SetBlackboardValueAsName_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsName_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsName_Value_PropertyAddress, SetBlackboardValueAsName_FunctionAddress, "Value");
		SetBlackboardValueAsName_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsName_FunctionAddress, "Value");
		SetBlackboardValueAsName_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsName_FunctionAddress, "Value", Classes.FNameProperty);
		SetBlackboardValueAsName_IsValid = SetBlackboardValueAsName_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsName_NodeOwner_IsValid && SetBlackboardValueAsName_Key_IsValid && SetBlackboardValueAsName_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsName", SetBlackboardValueAsName_IsValid);
		SetBlackboardValueAsInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsInt");
		SetBlackboardValueAsInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsInt_NodeOwner_PropertyAddress, SetBlackboardValueAsInt_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsInt_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsInt_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsInt_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsInt_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsInt_Key_PropertyAddress, SetBlackboardValueAsInt_FunctionAddress, "Key");
		SetBlackboardValueAsInt_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsInt_FunctionAddress, "Key");
		SetBlackboardValueAsInt_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsInt_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsInt_Value_PropertyAddress, SetBlackboardValueAsInt_FunctionAddress, "Value");
		SetBlackboardValueAsInt_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsInt_FunctionAddress, "Value");
		SetBlackboardValueAsInt_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsInt_FunctionAddress, "Value", Classes.FIntProperty);
		SetBlackboardValueAsInt_IsValid = SetBlackboardValueAsInt_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsInt_NodeOwner_IsValid && SetBlackboardValueAsInt_Key_IsValid && SetBlackboardValueAsInt_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsInt", SetBlackboardValueAsInt_IsValid);
		SetBlackboardValueAsFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsFloat");
		SetBlackboardValueAsFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsFloat_NodeOwner_PropertyAddress, SetBlackboardValueAsFloat_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsFloat_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsFloat_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsFloat_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsFloat_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsFloat_Key_PropertyAddress, SetBlackboardValueAsFloat_FunctionAddress, "Key");
		SetBlackboardValueAsFloat_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsFloat_FunctionAddress, "Key");
		SetBlackboardValueAsFloat_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsFloat_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsFloat_Value_PropertyAddress, SetBlackboardValueAsFloat_FunctionAddress, "Value");
		SetBlackboardValueAsFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsFloat_FunctionAddress, "Value");
		SetBlackboardValueAsFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		SetBlackboardValueAsFloat_IsValid = SetBlackboardValueAsFloat_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsFloat_NodeOwner_IsValid && SetBlackboardValueAsFloat_Key_IsValid && SetBlackboardValueAsFloat_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsFloat", SetBlackboardValueAsFloat_IsValid);
		SetBlackboardValueAsEnum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsEnum");
		SetBlackboardValueAsEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsEnum_NodeOwner_PropertyAddress, SetBlackboardValueAsEnum_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsEnum_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsEnum_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsEnum_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsEnum_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsEnum_Key_PropertyAddress, SetBlackboardValueAsEnum_FunctionAddress, "Key");
		SetBlackboardValueAsEnum_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsEnum_FunctionAddress, "Key");
		SetBlackboardValueAsEnum_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsEnum_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsEnum_Value_PropertyAddress, SetBlackboardValueAsEnum_FunctionAddress, "Value");
		SetBlackboardValueAsEnum_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsEnum_FunctionAddress, "Value");
		SetBlackboardValueAsEnum_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsEnum_FunctionAddress, "Value", Classes.FByteProperty);
		SetBlackboardValueAsEnum_IsValid = SetBlackboardValueAsEnum_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsEnum_NodeOwner_IsValid && SetBlackboardValueAsEnum_Key_IsValid && SetBlackboardValueAsEnum_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsEnum", SetBlackboardValueAsEnum_IsValid);
		SetBlackboardValueAsClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsClass");
		SetBlackboardValueAsClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsClass_NodeOwner_PropertyAddress, SetBlackboardValueAsClass_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsClass_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsClass_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsClass_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsClass_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsClass_Key_PropertyAddress, SetBlackboardValueAsClass_FunctionAddress, "Key");
		SetBlackboardValueAsClass_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsClass_FunctionAddress, "Key");
		SetBlackboardValueAsClass_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsClass_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsClass_Value_PropertyAddress, SetBlackboardValueAsClass_FunctionAddress, "Value");
		SetBlackboardValueAsClass_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsClass_FunctionAddress, "Value");
		SetBlackboardValueAsClass_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsClass_FunctionAddress, "Value", Classes.FClassProperty);
		SetBlackboardValueAsClass_IsValid = SetBlackboardValueAsClass_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsClass_NodeOwner_IsValid && SetBlackboardValueAsClass_Key_IsValid && SetBlackboardValueAsClass_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsClass", SetBlackboardValueAsClass_IsValid);
		SetBlackboardValueAsBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlackboardValueAsBool");
		SetBlackboardValueAsBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlackboardValueAsBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsBool_NodeOwner_PropertyAddress, SetBlackboardValueAsBool_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsBool_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsBool_FunctionAddress, "NodeOwner");
		SetBlackboardValueAsBool_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsBool_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsBool_Key_PropertyAddress, SetBlackboardValueAsBool_FunctionAddress, "Key");
		SetBlackboardValueAsBool_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsBool_FunctionAddress, "Key");
		SetBlackboardValueAsBool_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsBool_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlackboardValueAsBool_Value_PropertyAddress, SetBlackboardValueAsBool_FunctionAddress, "Value");
		SetBlackboardValueAsBool_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBlackboardValueAsBool_FunctionAddress, "Value");
		SetBlackboardValueAsBool_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlackboardValueAsBool_FunctionAddress, "Value", Classes.FBoolProperty);
		SetBlackboardValueAsBool_IsValid = SetBlackboardValueAsBool_FunctionAddress != IntPtr.Zero && SetBlackboardValueAsBool_NodeOwner_IsValid && SetBlackboardValueAsBool_Key_IsValid && SetBlackboardValueAsBool_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:SetBlackboardValueAsBool", SetBlackboardValueAsBool_IsValid);
		GetOwnersBlackboard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOwnersBlackboard");
		GetOwnersBlackboard_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnersBlackboard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnersBlackboard_NodeOwner_PropertyAddress, GetOwnersBlackboard_FunctionAddress, "NodeOwner");
		GetOwnersBlackboard_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnersBlackboard_FunctionAddress, "NodeOwner");
		GetOwnersBlackboard_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnersBlackboard_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOwnersBlackboard_ReturnValue_PropertyAddress, GetOwnersBlackboard_FunctionAddress, "ReturnValue");
		GetOwnersBlackboard_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnersBlackboard_FunctionAddress, "ReturnValue");
		GetOwnersBlackboard_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnersBlackboard_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwnersBlackboard_IsValid = GetOwnersBlackboard_FunctionAddress != IntPtr.Zero && GetOwnersBlackboard_NodeOwner_IsValid && GetOwnersBlackboard_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetOwnersBlackboard", GetOwnersBlackboard_IsValid);
		GetOwnerComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOwnerComponent");
		GetOwnerComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnerComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerComponent_NodeOwner_PropertyAddress, GetOwnerComponent_FunctionAddress, "NodeOwner");
		GetOwnerComponent_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerComponent_FunctionAddress, "NodeOwner");
		GetOwnerComponent_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerComponent_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerComponent_ReturnValue_PropertyAddress, GetOwnerComponent_FunctionAddress, "ReturnValue");
		GetOwnerComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerComponent_FunctionAddress, "ReturnValue");
		GetOwnerComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwnerComponent_IsValid = GetOwnerComponent_FunctionAddress != IntPtr.Zero && GetOwnerComponent_NodeOwner_IsValid && GetOwnerComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetOwnerComponent", GetOwnerComponent_IsValid);
		GetBlackboardValueAsVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsVector");
		GetBlackboardValueAsVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsVector_NodeOwner_PropertyAddress, GetBlackboardValueAsVector_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsVector_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsVector_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsVector_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsVector_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsVector_Key_PropertyAddress, GetBlackboardValueAsVector_FunctionAddress, "Key");
		GetBlackboardValueAsVector_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsVector_FunctionAddress, "Key");
		GetBlackboardValueAsVector_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsVector_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsVector_ReturnValue_PropertyAddress, GetBlackboardValueAsVector_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsVector_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBlackboardValueAsVector_IsValid = GetBlackboardValueAsVector_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsVector_NodeOwner_IsValid && GetBlackboardValueAsVector_Key_IsValid && GetBlackboardValueAsVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsVector", GetBlackboardValueAsVector_IsValid);
		GetBlackboardValueAsString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsString");
		GetBlackboardValueAsString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsString_NodeOwner_PropertyAddress, GetBlackboardValueAsString_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsString_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsString_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsString_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsString_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsString_Key_PropertyAddress, GetBlackboardValueAsString_FunctionAddress, "Key");
		GetBlackboardValueAsString_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsString_FunctionAddress, "Key");
		GetBlackboardValueAsString_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsString_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsString_ReturnValue_PropertyAddress, GetBlackboardValueAsString_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsString_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetBlackboardValueAsString_IsValid = GetBlackboardValueAsString_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsString_NodeOwner_IsValid && GetBlackboardValueAsString_Key_IsValid && GetBlackboardValueAsString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsString", GetBlackboardValueAsString_IsValid);
		GetBlackboardValueAsRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsRotator");
		GetBlackboardValueAsRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsRotator_NodeOwner_PropertyAddress, GetBlackboardValueAsRotator_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsRotator_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsRotator_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsRotator_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsRotator_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsRotator_Key_PropertyAddress, GetBlackboardValueAsRotator_FunctionAddress, "Key");
		GetBlackboardValueAsRotator_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsRotator_FunctionAddress, "Key");
		GetBlackboardValueAsRotator_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsRotator_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsRotator_ReturnValue_PropertyAddress, GetBlackboardValueAsRotator_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsRotator_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBlackboardValueAsRotator_IsValid = GetBlackboardValueAsRotator_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsRotator_NodeOwner_IsValid && GetBlackboardValueAsRotator_Key_IsValid && GetBlackboardValueAsRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsRotator", GetBlackboardValueAsRotator_IsValid);
		GetBlackboardValueAsObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsObject");
		GetBlackboardValueAsObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsObject_NodeOwner_PropertyAddress, GetBlackboardValueAsObject_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsObject_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsObject_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsObject_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsObject_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsObject_Key_PropertyAddress, GetBlackboardValueAsObject_FunctionAddress, "Key");
		GetBlackboardValueAsObject_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsObject_FunctionAddress, "Key");
		GetBlackboardValueAsObject_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsObject_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsObject_ReturnValue_PropertyAddress, GetBlackboardValueAsObject_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsObject_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlackboardValueAsObject_IsValid = GetBlackboardValueAsObject_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsObject_NodeOwner_IsValid && GetBlackboardValueAsObject_Key_IsValid && GetBlackboardValueAsObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsObject", GetBlackboardValueAsObject_IsValid);
		GetBlackboardValueAsName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsName");
		GetBlackboardValueAsName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsName_NodeOwner_PropertyAddress, GetBlackboardValueAsName_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsName_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsName_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsName_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsName_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsName_Key_PropertyAddress, GetBlackboardValueAsName_FunctionAddress, "Key");
		GetBlackboardValueAsName_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsName_FunctionAddress, "Key");
		GetBlackboardValueAsName_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsName_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsName_ReturnValue_PropertyAddress, GetBlackboardValueAsName_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsName_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetBlackboardValueAsName_IsValid = GetBlackboardValueAsName_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsName_NodeOwner_IsValid && GetBlackboardValueAsName_Key_IsValid && GetBlackboardValueAsName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsName", GetBlackboardValueAsName_IsValid);
		GetBlackboardValueAsInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsInt");
		GetBlackboardValueAsInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsInt_NodeOwner_PropertyAddress, GetBlackboardValueAsInt_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsInt_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsInt_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsInt_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsInt_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsInt_Key_PropertyAddress, GetBlackboardValueAsInt_FunctionAddress, "Key");
		GetBlackboardValueAsInt_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsInt_FunctionAddress, "Key");
		GetBlackboardValueAsInt_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsInt_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsInt_ReturnValue_PropertyAddress, GetBlackboardValueAsInt_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsInt_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBlackboardValueAsInt_IsValid = GetBlackboardValueAsInt_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsInt_NodeOwner_IsValid && GetBlackboardValueAsInt_Key_IsValid && GetBlackboardValueAsInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsInt", GetBlackboardValueAsInt_IsValid);
		GetBlackboardValueAsFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsFloat");
		GetBlackboardValueAsFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsFloat_NodeOwner_PropertyAddress, GetBlackboardValueAsFloat_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsFloat_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsFloat_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsFloat_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsFloat_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsFloat_Key_PropertyAddress, GetBlackboardValueAsFloat_FunctionAddress, "Key");
		GetBlackboardValueAsFloat_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsFloat_FunctionAddress, "Key");
		GetBlackboardValueAsFloat_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsFloat_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsFloat_ReturnValue_PropertyAddress, GetBlackboardValueAsFloat_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsFloat_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBlackboardValueAsFloat_IsValid = GetBlackboardValueAsFloat_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsFloat_NodeOwner_IsValid && GetBlackboardValueAsFloat_Key_IsValid && GetBlackboardValueAsFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsFloat", GetBlackboardValueAsFloat_IsValid);
		GetBlackboardValueAsEnum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsEnum");
		GetBlackboardValueAsEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsEnum_NodeOwner_PropertyAddress, GetBlackboardValueAsEnum_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsEnum_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsEnum_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsEnum_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsEnum_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsEnum_Key_PropertyAddress, GetBlackboardValueAsEnum_FunctionAddress, "Key");
		GetBlackboardValueAsEnum_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsEnum_FunctionAddress, "Key");
		GetBlackboardValueAsEnum_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsEnum_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsEnum_ReturnValue_PropertyAddress, GetBlackboardValueAsEnum_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsEnum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsEnum_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsEnum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsEnum_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetBlackboardValueAsEnum_IsValid = GetBlackboardValueAsEnum_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsEnum_NodeOwner_IsValid && GetBlackboardValueAsEnum_Key_IsValid && GetBlackboardValueAsEnum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsEnum", GetBlackboardValueAsEnum_IsValid);
		GetBlackboardValueAsClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsClass");
		GetBlackboardValueAsClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsClass_NodeOwner_PropertyAddress, GetBlackboardValueAsClass_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsClass_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsClass_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsClass_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsClass_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsClass_Key_PropertyAddress, GetBlackboardValueAsClass_FunctionAddress, "Key");
		GetBlackboardValueAsClass_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsClass_FunctionAddress, "Key");
		GetBlackboardValueAsClass_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsClass_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsClass_ReturnValue_PropertyAddress, GetBlackboardValueAsClass_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsClass_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetBlackboardValueAsClass_IsValid = GetBlackboardValueAsClass_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsClass_NodeOwner_IsValid && GetBlackboardValueAsClass_Key_IsValid && GetBlackboardValueAsClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsClass", GetBlackboardValueAsClass_IsValid);
		GetBlackboardValueAsBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsBool");
		GetBlackboardValueAsBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsBool_NodeOwner_PropertyAddress, GetBlackboardValueAsBool_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsBool_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsBool_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsBool_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsBool_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsBool_Key_PropertyAddress, GetBlackboardValueAsBool_FunctionAddress, "Key");
		GetBlackboardValueAsBool_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsBool_FunctionAddress, "Key");
		GetBlackboardValueAsBool_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsBool_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsBool_ReturnValue_PropertyAddress, GetBlackboardValueAsBool_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsBool_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBlackboardValueAsBool_IsValid = GetBlackboardValueAsBool_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsBool_NodeOwner_IsValid && GetBlackboardValueAsBool_Key_IsValid && GetBlackboardValueAsBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsBool", GetBlackboardValueAsBool_IsValid);
		GetBlackboardValueAsActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboardValueAsActor");
		GetBlackboardValueAsActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboardValueAsActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsActor_NodeOwner_PropertyAddress, GetBlackboardValueAsActor_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsActor_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsActor_FunctionAddress, "NodeOwner");
		GetBlackboardValueAsActor_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsActor_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsActor_Key_PropertyAddress, GetBlackboardValueAsActor_FunctionAddress, "Key");
		GetBlackboardValueAsActor_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsActor_FunctionAddress, "Key");
		GetBlackboardValueAsActor_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsActor_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboardValueAsActor_ReturnValue_PropertyAddress, GetBlackboardValueAsActor_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboardValueAsActor_FunctionAddress, "ReturnValue");
		GetBlackboardValueAsActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboardValueAsActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlackboardValueAsActor_IsValid = GetBlackboardValueAsActor_FunctionAddress != IntPtr.Zero && GetBlackboardValueAsActor_NodeOwner_IsValid && GetBlackboardValueAsActor_Key_IsValid && GetBlackboardValueAsActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:GetBlackboardValueAsActor", GetBlackboardValueAsActor_IsValid);
		ClearBlackboardValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearBlackboardValue");
		ClearBlackboardValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearBlackboardValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearBlackboardValue_NodeOwner_PropertyAddress, ClearBlackboardValue_FunctionAddress, "NodeOwner");
		ClearBlackboardValue_NodeOwner_Offset = NativeReflectionCached.GetPropertyOffset(ClearBlackboardValue_FunctionAddress, "NodeOwner");
		ClearBlackboardValue_NodeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearBlackboardValue_FunctionAddress, "NodeOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearBlackboardValue_Key_PropertyAddress, ClearBlackboardValue_FunctionAddress, "Key");
		ClearBlackboardValue_Key_Offset = NativeReflectionCached.GetPropertyOffset(ClearBlackboardValue_FunctionAddress, "Key");
		ClearBlackboardValue_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearBlackboardValue_FunctionAddress, "Key", Classes.FStructProperty);
		ClearBlackboardValue_IsValid = ClearBlackboardValue_FunctionAddress != IntPtr.Zero && ClearBlackboardValue_NodeOwner_IsValid && ClearBlackboardValue_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTFunctionLibrary:ClearBlackboardValue", ClearBlackboardValue_IsValid);
	}
}
