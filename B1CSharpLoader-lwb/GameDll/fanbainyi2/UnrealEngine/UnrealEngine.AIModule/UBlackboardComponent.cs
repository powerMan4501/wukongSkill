using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.BlackboardComponent", "AIModule", UnrealModuleType.Engine)]
public class UBlackboardComponent : UActorComponent
{
	private static bool SetValueAsVector_IsValid;

	private static IntPtr SetValueAsVector_FunctionAddress;

	private static int SetValueAsVector_ParamsSize;

	private static bool SetValueAsVector_KeyName_IsValid;

	private static FFieldAddress SetValueAsVector_KeyName_PropertyAddress;

	private static int SetValueAsVector_KeyName_Offset;

	private static bool SetValueAsVector_VectorValue_IsValid;

	private static FFieldAddress SetValueAsVector_VectorValue_PropertyAddress;

	private static int SetValueAsVector_VectorValue_Offset;

	private static bool SetValueAsString_IsValid;

	private static IntPtr SetValueAsString_FunctionAddress;

	private static int SetValueAsString_ParamsSize;

	private static bool SetValueAsString_KeyName_IsValid;

	private static FFieldAddress SetValueAsString_KeyName_PropertyAddress;

	private static int SetValueAsString_KeyName_Offset;

	private static bool SetValueAsString_StringValue_IsValid;

	private static FFieldAddress SetValueAsString_StringValue_PropertyAddress;

	private static int SetValueAsString_StringValue_Offset;

	private static bool SetValueAsRotator_IsValid;

	private static IntPtr SetValueAsRotator_FunctionAddress;

	private static int SetValueAsRotator_ParamsSize;

	private static bool SetValueAsRotator_KeyName_IsValid;

	private static FFieldAddress SetValueAsRotator_KeyName_PropertyAddress;

	private static int SetValueAsRotator_KeyName_Offset;

	private static bool SetValueAsRotator_VectorValue_IsValid;

	private static FFieldAddress SetValueAsRotator_VectorValue_PropertyAddress;

	private static int SetValueAsRotator_VectorValue_Offset;

	private static bool SetValueAsObject_IsValid;

	private static IntPtr SetValueAsObject_FunctionAddress;

	private static int SetValueAsObject_ParamsSize;

	private static bool SetValueAsObject_KeyName_IsValid;

	private static FFieldAddress SetValueAsObject_KeyName_PropertyAddress;

	private static int SetValueAsObject_KeyName_Offset;

	private static bool SetValueAsObject_ObjectValue_IsValid;

	private static FFieldAddress SetValueAsObject_ObjectValue_PropertyAddress;

	private static int SetValueAsObject_ObjectValue_Offset;

	private static bool SetValueAsName_IsValid;

	private static IntPtr SetValueAsName_FunctionAddress;

	private static int SetValueAsName_ParamsSize;

	private static bool SetValueAsName_KeyName_IsValid;

	private static FFieldAddress SetValueAsName_KeyName_PropertyAddress;

	private static int SetValueAsName_KeyName_Offset;

	private static bool SetValueAsName_NameValue_IsValid;

	private static FFieldAddress SetValueAsName_NameValue_PropertyAddress;

	private static int SetValueAsName_NameValue_Offset;

	private static bool SetValueAsInt_IsValid;

	private static IntPtr SetValueAsInt_FunctionAddress;

	private static int SetValueAsInt_ParamsSize;

	private static bool SetValueAsInt_KeyName_IsValid;

	private static FFieldAddress SetValueAsInt_KeyName_PropertyAddress;

	private static int SetValueAsInt_KeyName_Offset;

	private static bool SetValueAsInt_IntValue_IsValid;

	private static FFieldAddress SetValueAsInt_IntValue_PropertyAddress;

	private static int SetValueAsInt_IntValue_Offset;

	private static bool SetValueAsFloat_IsValid;

	private static IntPtr SetValueAsFloat_FunctionAddress;

	private static int SetValueAsFloat_ParamsSize;

	private static bool SetValueAsFloat_KeyName_IsValid;

	private static FFieldAddress SetValueAsFloat_KeyName_PropertyAddress;

	private static int SetValueAsFloat_KeyName_Offset;

	private static bool SetValueAsFloat_FloatValue_IsValid;

	private static FFieldAddress SetValueAsFloat_FloatValue_PropertyAddress;

	private static int SetValueAsFloat_FloatValue_Offset;

	private static bool SetValueAsEnum_IsValid;

	private static IntPtr SetValueAsEnum_FunctionAddress;

	private static int SetValueAsEnum_ParamsSize;

	private static bool SetValueAsEnum_KeyName_IsValid;

	private static FFieldAddress SetValueAsEnum_KeyName_PropertyAddress;

	private static int SetValueAsEnum_KeyName_Offset;

	private static bool SetValueAsEnum_EnumValue_IsValid;

	private static FFieldAddress SetValueAsEnum_EnumValue_PropertyAddress;

	private static int SetValueAsEnum_EnumValue_Offset;

	private static bool SetValueAsClass_IsValid;

	private static IntPtr SetValueAsClass_FunctionAddress;

	private static int SetValueAsClass_ParamsSize;

	private static bool SetValueAsClass_KeyName_IsValid;

	private static FFieldAddress SetValueAsClass_KeyName_PropertyAddress;

	private static int SetValueAsClass_KeyName_Offset;

	private static bool SetValueAsClass_ClassValue_IsValid;

	private static FFieldAddress SetValueAsClass_ClassValue_PropertyAddress;

	private static int SetValueAsClass_ClassValue_Offset;

	private static bool SetValueAsBool_IsValid;

	private static IntPtr SetValueAsBool_FunctionAddress;

	private static int SetValueAsBool_ParamsSize;

	private static bool SetValueAsBool_KeyName_IsValid;

	private static FFieldAddress SetValueAsBool_KeyName_PropertyAddress;

	private static int SetValueAsBool_KeyName_Offset;

	private static bool SetValueAsBool_BoolValue_IsValid;

	private static FFieldAddress SetValueAsBool_BoolValue_PropertyAddress;

	private static int SetValueAsBool_BoolValue_Offset;

	private static bool IsVectorValueSet_IsValid;

	private static IntPtr IsVectorValueSet_FunctionAddress;

	private static int IsVectorValueSet_ParamsSize;

	private static bool IsVectorValueSet_KeyName_IsValid;

	private static FFieldAddress IsVectorValueSet_KeyName_PropertyAddress;

	private static int IsVectorValueSet_KeyName_Offset;

	private static bool IsVectorValueSet_ReturnValue_IsValid;

	private static FFieldAddress IsVectorValueSet_ReturnValue_PropertyAddress;

	private static int IsVectorValueSet_ReturnValue_Offset;

	private static bool GetValueAsVector_IsValid;

	private static IntPtr GetValueAsVector_FunctionAddress;

	private static int GetValueAsVector_ParamsSize;

	private static bool GetValueAsVector_KeyName_IsValid;

	private static FFieldAddress GetValueAsVector_KeyName_PropertyAddress;

	private static int GetValueAsVector_KeyName_Offset;

	private static bool GetValueAsVector_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsVector_ReturnValue_PropertyAddress;

	private static int GetValueAsVector_ReturnValue_Offset;

	private static bool GetValueAsString_IsValid;

	private static IntPtr GetValueAsString_FunctionAddress;

	private static int GetValueAsString_ParamsSize;

	private static bool GetValueAsString_KeyName_IsValid;

	private static FFieldAddress GetValueAsString_KeyName_PropertyAddress;

	private static int GetValueAsString_KeyName_Offset;

	private static bool GetValueAsString_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsString_ReturnValue_PropertyAddress;

	private static int GetValueAsString_ReturnValue_Offset;

	private static bool GetValueAsRotator_IsValid;

	private static IntPtr GetValueAsRotator_FunctionAddress;

	private static int GetValueAsRotator_ParamsSize;

	private static bool GetValueAsRotator_KeyName_IsValid;

	private static FFieldAddress GetValueAsRotator_KeyName_PropertyAddress;

	private static int GetValueAsRotator_KeyName_Offset;

	private static bool GetValueAsRotator_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsRotator_ReturnValue_PropertyAddress;

	private static int GetValueAsRotator_ReturnValue_Offset;

	private static bool GetValueAsObject_IsValid;

	private static IntPtr GetValueAsObject_FunctionAddress;

	private static int GetValueAsObject_ParamsSize;

	private static bool GetValueAsObject_KeyName_IsValid;

	private static FFieldAddress GetValueAsObject_KeyName_PropertyAddress;

	private static int GetValueAsObject_KeyName_Offset;

	private static bool GetValueAsObject_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsObject_ReturnValue_PropertyAddress;

	private static int GetValueAsObject_ReturnValue_Offset;

	private static bool GetValueAsName_IsValid;

	private static IntPtr GetValueAsName_FunctionAddress;

	private static int GetValueAsName_ParamsSize;

	private static bool GetValueAsName_KeyName_IsValid;

	private static FFieldAddress GetValueAsName_KeyName_PropertyAddress;

	private static int GetValueAsName_KeyName_Offset;

	private static bool GetValueAsName_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsName_ReturnValue_PropertyAddress;

	private static int GetValueAsName_ReturnValue_Offset;

	private static bool GetValueAsInt_IsValid;

	private static IntPtr GetValueAsInt_FunctionAddress;

	private static int GetValueAsInt_ParamsSize;

	private static bool GetValueAsInt_KeyName_IsValid;

	private static FFieldAddress GetValueAsInt_KeyName_PropertyAddress;

	private static int GetValueAsInt_KeyName_Offset;

	private static bool GetValueAsInt_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsInt_ReturnValue_PropertyAddress;

	private static int GetValueAsInt_ReturnValue_Offset;

	private static bool GetValueAsFloat_IsValid;

	private static IntPtr GetValueAsFloat_FunctionAddress;

	private static int GetValueAsFloat_ParamsSize;

	private static bool GetValueAsFloat_KeyName_IsValid;

	private static FFieldAddress GetValueAsFloat_KeyName_PropertyAddress;

	private static int GetValueAsFloat_KeyName_Offset;

	private static bool GetValueAsFloat_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsFloat_ReturnValue_PropertyAddress;

	private static int GetValueAsFloat_ReturnValue_Offset;

	private static bool GetValueAsEnum_IsValid;

	private static IntPtr GetValueAsEnum_FunctionAddress;

	private static int GetValueAsEnum_ParamsSize;

	private static bool GetValueAsEnum_KeyName_IsValid;

	private static FFieldAddress GetValueAsEnum_KeyName_PropertyAddress;

	private static int GetValueAsEnum_KeyName_Offset;

	private static bool GetValueAsEnum_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsEnum_ReturnValue_PropertyAddress;

	private static int GetValueAsEnum_ReturnValue_Offset;

	private static bool GetValueAsClass_IsValid;

	private static IntPtr GetValueAsClass_FunctionAddress;

	private static int GetValueAsClass_ParamsSize;

	private static bool GetValueAsClass_KeyName_IsValid;

	private static FFieldAddress GetValueAsClass_KeyName_PropertyAddress;

	private static int GetValueAsClass_KeyName_Offset;

	private static bool GetValueAsClass_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsClass_ReturnValue_PropertyAddress;

	private static int GetValueAsClass_ReturnValue_Offset;

	private static bool GetValueAsBool_IsValid;

	private static IntPtr GetValueAsBool_FunctionAddress;

	private static int GetValueAsBool_ParamsSize;

	private static bool GetValueAsBool_KeyName_IsValid;

	private static FFieldAddress GetValueAsBool_KeyName_PropertyAddress;

	private static int GetValueAsBool_KeyName_Offset;

	private static bool GetValueAsBool_ReturnValue_IsValid;

	private static FFieldAddress GetValueAsBool_ReturnValue_PropertyAddress;

	private static int GetValueAsBool_ReturnValue_Offset;

	private static bool GetRotationFromEntry_IsValid;

	private static IntPtr GetRotationFromEntry_FunctionAddress;

	private static int GetRotationFromEntry_ParamsSize;

	private static bool GetRotationFromEntry_KeyName_IsValid;

	private static FFieldAddress GetRotationFromEntry_KeyName_PropertyAddress;

	private static int GetRotationFromEntry_KeyName_Offset;

	private static bool GetRotationFromEntry_ResultRotation_IsValid;

	private static FFieldAddress GetRotationFromEntry_ResultRotation_PropertyAddress;

	private static int GetRotationFromEntry_ResultRotation_Offset;

	private static bool GetRotationFromEntry_ReturnValue_IsValid;

	private static FFieldAddress GetRotationFromEntry_ReturnValue_PropertyAddress;

	private static int GetRotationFromEntry_ReturnValue_Offset;

	private static bool GetLocationFromEntry_IsValid;

	private static IntPtr GetLocationFromEntry_FunctionAddress;

	private static int GetLocationFromEntry_ParamsSize;

	private static bool GetLocationFromEntry_KeyName_IsValid;

	private static FFieldAddress GetLocationFromEntry_KeyName_PropertyAddress;

	private static int GetLocationFromEntry_KeyName_Offset;

	private static bool GetLocationFromEntry_ResultLocation_IsValid;

	private static FFieldAddress GetLocationFromEntry_ResultLocation_PropertyAddress;

	private static int GetLocationFromEntry_ResultLocation_Offset;

	private static bool GetLocationFromEntry_ReturnValue_IsValid;

	private static FFieldAddress GetLocationFromEntry_ReturnValue_PropertyAddress;

	private static int GetLocationFromEntry_ReturnValue_Offset;

	private static bool ClearValue_IsValid;

	private static IntPtr ClearValue_FunctionAddress;

	private static int ClearValue_ParamsSize;

	private static bool ClearValue_KeyName_IsValid;

	private static FFieldAddress ClearValue_KeyName_PropertyAddress;

	private static int ClearValue_KeyName_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsVector")]
	public unsafe void SetValueAsVector(FName KeyName, FVector VectorValue)
	{
		CheckDestroyed();
		if (!SetValueAsVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsVector_KeyName_Offset), 0, SetValueAsVector_KeyName_PropertyAddress.Address, KeyName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetValueAsVector_VectorValue_Offset), 0, SetValueAsVector_VectorValue_PropertyAddress.Address, VectorValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsVector_FunctionAddress, intPtr, SetValueAsVector_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsString")]
	public unsafe void SetValueAsString(FName KeyName, string StringValue)
	{
		CheckDestroyed();
		if (!SetValueAsString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsString_KeyName_Offset), 0, SetValueAsString_KeyName_PropertyAddress.Address, KeyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetValueAsString_StringValue_Offset), 0, SetValueAsString_StringValue_PropertyAddress.Address, StringValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsString_FunctionAddress, intPtr, SetValueAsString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetValueAsString_StringValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsRotator")]
	public unsafe void SetValueAsRotator(FName KeyName, FRotator VectorValue)
	{
		CheckDestroyed();
		if (!SetValueAsRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsRotator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsRotator_KeyName_Offset), 0, SetValueAsRotator_KeyName_PropertyAddress.Address, KeyName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetValueAsRotator_VectorValue_Offset), 0, SetValueAsRotator_VectorValue_PropertyAddress.Address, VectorValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsRotator_FunctionAddress, intPtr, SetValueAsRotator_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsObject")]
	public unsafe void SetValueAsObject(FName KeyName, UObject ObjectValue)
	{
		CheckDestroyed();
		if (!SetValueAsObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsObject_KeyName_Offset), 0, SetValueAsObject_KeyName_PropertyAddress.Address, KeyName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetValueAsObject_ObjectValue_Offset), 0, SetValueAsObject_ObjectValue_PropertyAddress.Address, ObjectValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsObject_FunctionAddress, intPtr, SetValueAsObject_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsName")]
	public unsafe void SetValueAsName(FName KeyName, FName NameValue)
	{
		CheckDestroyed();
		if (!SetValueAsName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsName_KeyName_Offset), 0, SetValueAsName_KeyName_PropertyAddress.Address, KeyName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsName_NameValue_Offset), 0, SetValueAsName_NameValue_PropertyAddress.Address, NameValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsName_FunctionAddress, intPtr, SetValueAsName_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsInt")]
	public unsafe void SetValueAsInt(FName KeyName, int IntValue)
	{
		CheckDestroyed();
		if (!SetValueAsInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsInt_KeyName_Offset), 0, SetValueAsInt_KeyName_PropertyAddress.Address, KeyName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetValueAsInt_IntValue_Offset), 0, SetValueAsInt_IntValue_PropertyAddress.Address, IntValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsInt_FunctionAddress, intPtr, SetValueAsInt_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsFloat")]
	public unsafe void SetValueAsFloat(FName KeyName, float FloatValue)
	{
		CheckDestroyed();
		if (!SetValueAsFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsFloat_KeyName_Offset), 0, SetValueAsFloat_KeyName_PropertyAddress.Address, KeyName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetValueAsFloat_FloatValue_Offset), 0, SetValueAsFloat_FloatValue_PropertyAddress.Address, FloatValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsFloat_FunctionAddress, intPtr, SetValueAsFloat_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsEnum")]
	public unsafe void SetValueAsEnum(FName KeyName, byte EnumValue)
	{
		CheckDestroyed();
		if (!SetValueAsEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsEnum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsEnum_KeyName_Offset), 0, SetValueAsEnum_KeyName_PropertyAddress.Address, KeyName);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetValueAsEnum_EnumValue_Offset), 0, SetValueAsEnum_EnumValue_PropertyAddress.Address, EnumValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsEnum_FunctionAddress, intPtr, SetValueAsEnum_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsClass")]
	public unsafe void SetValueAsClass(FName KeyName, TSubclassOf<UObject> ClassValue)
	{
		CheckDestroyed();
		if (!SetValueAsClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsClass_KeyName_Offset), 0, SetValueAsClass_KeyName_PropertyAddress.Address, KeyName);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetValueAsClass_ClassValue_Offset), 0, SetValueAsClass_ClassValue_PropertyAddress.Address, ClassValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsClass_FunctionAddress, intPtr, SetValueAsClass_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:SetValueAsBool")]
	public unsafe void SetValueAsBool(FName KeyName, bool BoolValue)
	{
		CheckDestroyed();
		if (!SetValueAsBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:SetValueAsBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValueAsBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValueAsBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetValueAsBool_KeyName_Offset), 0, SetValueAsBool_KeyName_PropertyAddress.Address, KeyName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetValueAsBool_BoolValue_Offset), 0, SetValueAsBool_BoolValue_PropertyAddress.Address, BoolValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValueAsBool_FunctionAddress, intPtr, SetValueAsBool_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:IsVectorValueSet")]
	public unsafe bool IsVectorValueSet(FName KeyName)
	{
		CheckDestroyed();
		if (!IsVectorValueSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:IsVectorValueSet");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVectorValueSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVectorValueSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsVectorValueSet_KeyName_Offset), 0, IsVectorValueSet_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVectorValueSet_FunctionAddress, intPtr, IsVectorValueSet_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVectorValueSet_ReturnValue_Offset), 0, IsVectorValueSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsVector")]
	public unsafe FVector GetValueAsVector(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsVector_KeyName_Offset), 0, GetValueAsVector_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsVector_FunctionAddress, intPtr, GetValueAsVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetValueAsVector_ReturnValue_Offset), 0, GetValueAsVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsString")]
	public unsafe string GetValueAsString(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsString_KeyName_Offset), 0, GetValueAsString_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsString_FunctionAddress, intPtr, GetValueAsString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetValueAsString_ReturnValue_Offset), 0, GetValueAsString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetValueAsString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsRotator")]
	public unsafe FRotator GetValueAsRotator(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsRotator");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsRotator_KeyName_Offset), 0, GetValueAsRotator_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsRotator_FunctionAddress, intPtr, GetValueAsRotator_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetValueAsRotator_ReturnValue_Offset), 0, GetValueAsRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsObject")]
	public unsafe UObject GetValueAsObject(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsObject_KeyName_Offset), 0, GetValueAsObject_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsObject_FunctionAddress, intPtr, GetValueAsObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetValueAsObject_ReturnValue_Offset), 0, GetValueAsObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsName")]
	public unsafe FName GetValueAsName(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsName_KeyName_Offset), 0, GetValueAsName_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsName_FunctionAddress, intPtr, GetValueAsName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetValueAsName_ReturnValue_Offset), 0, GetValueAsName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsInt")]
	public unsafe int GetValueAsInt(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsInt_KeyName_Offset), 0, GetValueAsInt_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsInt_FunctionAddress, intPtr, GetValueAsInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetValueAsInt_ReturnValue_Offset), 0, GetValueAsInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsFloat")]
	public unsafe float GetValueAsFloat(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsFloat_KeyName_Offset), 0, GetValueAsFloat_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsFloat_FunctionAddress, intPtr, GetValueAsFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValueAsFloat_ReturnValue_Offset), 0, GetValueAsFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsEnum")]
	public unsafe byte GetValueAsEnum(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsEnum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsEnum_KeyName_Offset), 0, GetValueAsEnum_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsEnum_FunctionAddress, intPtr, GetValueAsEnum_ParamsSize);
		return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetValueAsEnum_ReturnValue_Offset), 0, GetValueAsEnum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsClass")]
	public unsafe TSubclassOf<UObject> GetValueAsClass(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsClass_KeyName_Offset), 0, GetValueAsClass_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsClass_FunctionAddress, intPtr, GetValueAsClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetValueAsClass_ReturnValue_Offset), 0, GetValueAsClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetValueAsBool")]
	public unsafe bool GetValueAsBool(FName KeyName)
	{
		CheckDestroyed();
		if (!GetValueAsBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetValueAsBool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueAsBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueAsBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetValueAsBool_KeyName_Offset), 0, GetValueAsBool_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueAsBool_FunctionAddress, intPtr, GetValueAsBool_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetValueAsBool_ReturnValue_Offset), 0, GetValueAsBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetRotationFromEntry")]
	public unsafe bool GetRotationFromEntry(FName KeyName, out FRotator ResultRotation)
	{
		CheckDestroyed();
		if (!GetRotationFromEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetRotationFromEntry");
			ResultRotation = default(FRotator);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationFromEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationFromEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRotationFromEntry_KeyName_Offset), 0, GetRotationFromEntry_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationFromEntry_FunctionAddress, intPtr, GetRotationFromEntry_ParamsSize);
		ResultRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotationFromEntry_ResultRotation_Offset), 0, GetRotationFromEntry_ResultRotation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRotationFromEntry_ReturnValue_Offset), 0, GetRotationFromEntry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:GetLocationFromEntry")]
	public unsafe bool GetLocationFromEntry(FName KeyName, out FVector ResultLocation)
	{
		CheckDestroyed();
		if (!GetLocationFromEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:GetLocationFromEntry");
			ResultLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationFromEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationFromEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLocationFromEntry_KeyName_Offset), 0, GetLocationFromEntry_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationFromEntry_FunctionAddress, intPtr, GetLocationFromEntry_ParamsSize);
		ResultLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationFromEntry_ResultLocation_Offset), 0, GetLocationFromEntry_ResultLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLocationFromEntry_ReturnValue_Offset), 0, GetLocationFromEntry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.BlackboardComponent:ClearValue")]
	public unsafe void ClearValue(FName KeyName)
	{
		CheckDestroyed();
		if (!ClearValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BlackboardComponent:ClearValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClearValue_KeyName_Offset), 0, ClearValue_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearValue_FunctionAddress, intPtr, ClearValue_ParamsSize);
	}

	static UBlackboardComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBlackboardComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBlackboardComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.BlackboardComponent");
		SetValueAsVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsVector");
		SetValueAsVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsVector_KeyName_PropertyAddress, SetValueAsVector_FunctionAddress, "KeyName");
		SetValueAsVector_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsVector_FunctionAddress, "KeyName");
		SetValueAsVector_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsVector_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsVector_VectorValue_PropertyAddress, SetValueAsVector_FunctionAddress, "VectorValue");
		SetValueAsVector_VectorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsVector_FunctionAddress, "VectorValue");
		SetValueAsVector_VectorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsVector_FunctionAddress, "VectorValue", Classes.FStructProperty);
		SetValueAsVector_IsValid = SetValueAsVector_FunctionAddress != IntPtr.Zero && SetValueAsVector_KeyName_IsValid && SetValueAsVector_VectorValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsVector", SetValueAsVector_IsValid);
		SetValueAsString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsString");
		SetValueAsString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsString_KeyName_PropertyAddress, SetValueAsString_FunctionAddress, "KeyName");
		SetValueAsString_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsString_FunctionAddress, "KeyName");
		SetValueAsString_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsString_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsString_StringValue_PropertyAddress, SetValueAsString_FunctionAddress, "StringValue");
		SetValueAsString_StringValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsString_FunctionAddress, "StringValue");
		SetValueAsString_StringValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsString_FunctionAddress, "StringValue", Classes.FStrProperty);
		SetValueAsString_IsValid = SetValueAsString_FunctionAddress != IntPtr.Zero && SetValueAsString_KeyName_IsValid && SetValueAsString_StringValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsString", SetValueAsString_IsValid);
		SetValueAsRotator_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsRotator");
		SetValueAsRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsRotator_KeyName_PropertyAddress, SetValueAsRotator_FunctionAddress, "KeyName");
		SetValueAsRotator_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsRotator_FunctionAddress, "KeyName");
		SetValueAsRotator_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsRotator_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsRotator_VectorValue_PropertyAddress, SetValueAsRotator_FunctionAddress, "VectorValue");
		SetValueAsRotator_VectorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsRotator_FunctionAddress, "VectorValue");
		SetValueAsRotator_VectorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsRotator_FunctionAddress, "VectorValue", Classes.FStructProperty);
		SetValueAsRotator_IsValid = SetValueAsRotator_FunctionAddress != IntPtr.Zero && SetValueAsRotator_KeyName_IsValid && SetValueAsRotator_VectorValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsRotator", SetValueAsRotator_IsValid);
		SetValueAsObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsObject");
		SetValueAsObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsObject_KeyName_PropertyAddress, SetValueAsObject_FunctionAddress, "KeyName");
		SetValueAsObject_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsObject_FunctionAddress, "KeyName");
		SetValueAsObject_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsObject_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsObject_ObjectValue_PropertyAddress, SetValueAsObject_FunctionAddress, "ObjectValue");
		SetValueAsObject_ObjectValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsObject_FunctionAddress, "ObjectValue");
		SetValueAsObject_ObjectValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsObject_FunctionAddress, "ObjectValue", Classes.FObjectProperty);
		SetValueAsObject_IsValid = SetValueAsObject_FunctionAddress != IntPtr.Zero && SetValueAsObject_KeyName_IsValid && SetValueAsObject_ObjectValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsObject", SetValueAsObject_IsValid);
		SetValueAsName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsName");
		SetValueAsName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsName_KeyName_PropertyAddress, SetValueAsName_FunctionAddress, "KeyName");
		SetValueAsName_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsName_FunctionAddress, "KeyName");
		SetValueAsName_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsName_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsName_NameValue_PropertyAddress, SetValueAsName_FunctionAddress, "NameValue");
		SetValueAsName_NameValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsName_FunctionAddress, "NameValue");
		SetValueAsName_NameValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsName_FunctionAddress, "NameValue", Classes.FNameProperty);
		SetValueAsName_IsValid = SetValueAsName_FunctionAddress != IntPtr.Zero && SetValueAsName_KeyName_IsValid && SetValueAsName_NameValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsName", SetValueAsName_IsValid);
		SetValueAsInt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsInt");
		SetValueAsInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsInt_KeyName_PropertyAddress, SetValueAsInt_FunctionAddress, "KeyName");
		SetValueAsInt_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsInt_FunctionAddress, "KeyName");
		SetValueAsInt_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsInt_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsInt_IntValue_PropertyAddress, SetValueAsInt_FunctionAddress, "IntValue");
		SetValueAsInt_IntValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsInt_FunctionAddress, "IntValue");
		SetValueAsInt_IntValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsInt_FunctionAddress, "IntValue", Classes.FIntProperty);
		SetValueAsInt_IsValid = SetValueAsInt_FunctionAddress != IntPtr.Zero && SetValueAsInt_KeyName_IsValid && SetValueAsInt_IntValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsInt", SetValueAsInt_IsValid);
		SetValueAsFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsFloat");
		SetValueAsFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsFloat_KeyName_PropertyAddress, SetValueAsFloat_FunctionAddress, "KeyName");
		SetValueAsFloat_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsFloat_FunctionAddress, "KeyName");
		SetValueAsFloat_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsFloat_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsFloat_FloatValue_PropertyAddress, SetValueAsFloat_FunctionAddress, "FloatValue");
		SetValueAsFloat_FloatValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsFloat_FunctionAddress, "FloatValue");
		SetValueAsFloat_FloatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsFloat_FunctionAddress, "FloatValue", Classes.FFloatProperty);
		SetValueAsFloat_IsValid = SetValueAsFloat_FunctionAddress != IntPtr.Zero && SetValueAsFloat_KeyName_IsValid && SetValueAsFloat_FloatValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsFloat", SetValueAsFloat_IsValid);
		SetValueAsEnum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsEnum");
		SetValueAsEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsEnum_KeyName_PropertyAddress, SetValueAsEnum_FunctionAddress, "KeyName");
		SetValueAsEnum_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsEnum_FunctionAddress, "KeyName");
		SetValueAsEnum_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsEnum_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsEnum_EnumValue_PropertyAddress, SetValueAsEnum_FunctionAddress, "EnumValue");
		SetValueAsEnum_EnumValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsEnum_FunctionAddress, "EnumValue");
		SetValueAsEnum_EnumValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsEnum_FunctionAddress, "EnumValue", Classes.FByteProperty);
		SetValueAsEnum_IsValid = SetValueAsEnum_FunctionAddress != IntPtr.Zero && SetValueAsEnum_KeyName_IsValid && SetValueAsEnum_EnumValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsEnum", SetValueAsEnum_IsValid);
		SetValueAsClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsClass");
		SetValueAsClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsClass_KeyName_PropertyAddress, SetValueAsClass_FunctionAddress, "KeyName");
		SetValueAsClass_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsClass_FunctionAddress, "KeyName");
		SetValueAsClass_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsClass_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsClass_ClassValue_PropertyAddress, SetValueAsClass_FunctionAddress, "ClassValue");
		SetValueAsClass_ClassValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsClass_FunctionAddress, "ClassValue");
		SetValueAsClass_ClassValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsClass_FunctionAddress, "ClassValue", Classes.FClassProperty);
		SetValueAsClass_IsValid = SetValueAsClass_FunctionAddress != IntPtr.Zero && SetValueAsClass_KeyName_IsValid && SetValueAsClass_ClassValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsClass", SetValueAsClass_IsValid);
		SetValueAsBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValueAsBool");
		SetValueAsBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValueAsBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsBool_KeyName_PropertyAddress, SetValueAsBool_FunctionAddress, "KeyName");
		SetValueAsBool_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsBool_FunctionAddress, "KeyName");
		SetValueAsBool_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsBool_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetValueAsBool_BoolValue_PropertyAddress, SetValueAsBool_FunctionAddress, "BoolValue");
		SetValueAsBool_BoolValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValueAsBool_FunctionAddress, "BoolValue");
		SetValueAsBool_BoolValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValueAsBool_FunctionAddress, "BoolValue", Classes.FBoolProperty);
		SetValueAsBool_IsValid = SetValueAsBool_FunctionAddress != IntPtr.Zero && SetValueAsBool_KeyName_IsValid && SetValueAsBool_BoolValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:SetValueAsBool", SetValueAsBool_IsValid);
		IsVectorValueSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsVectorValueSet");
		IsVectorValueSet_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVectorValueSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVectorValueSet_KeyName_PropertyAddress, IsVectorValueSet_FunctionAddress, "KeyName");
		IsVectorValueSet_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(IsVectorValueSet_FunctionAddress, "KeyName");
		IsVectorValueSet_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVectorValueSet_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsVectorValueSet_ReturnValue_PropertyAddress, IsVectorValueSet_FunctionAddress, "ReturnValue");
		IsVectorValueSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVectorValueSet_FunctionAddress, "ReturnValue");
		IsVectorValueSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVectorValueSet_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVectorValueSet_IsValid = IsVectorValueSet_FunctionAddress != IntPtr.Zero && IsVectorValueSet_KeyName_IsValid && IsVectorValueSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:IsVectorValueSet", IsVectorValueSet_IsValid);
		GetValueAsVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsVector");
		GetValueAsVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsVector_KeyName_PropertyAddress, GetValueAsVector_FunctionAddress, "KeyName");
		GetValueAsVector_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsVector_FunctionAddress, "KeyName");
		GetValueAsVector_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsVector_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsVector_ReturnValue_PropertyAddress, GetValueAsVector_FunctionAddress, "ReturnValue");
		GetValueAsVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsVector_FunctionAddress, "ReturnValue");
		GetValueAsVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetValueAsVector_IsValid = GetValueAsVector_FunctionAddress != IntPtr.Zero && GetValueAsVector_KeyName_IsValid && GetValueAsVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsVector", GetValueAsVector_IsValid);
		GetValueAsString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsString");
		GetValueAsString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsString_KeyName_PropertyAddress, GetValueAsString_FunctionAddress, "KeyName");
		GetValueAsString_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsString_FunctionAddress, "KeyName");
		GetValueAsString_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsString_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsString_ReturnValue_PropertyAddress, GetValueAsString_FunctionAddress, "ReturnValue");
		GetValueAsString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsString_FunctionAddress, "ReturnValue");
		GetValueAsString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetValueAsString_IsValid = GetValueAsString_FunctionAddress != IntPtr.Zero && GetValueAsString_KeyName_IsValid && GetValueAsString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsString", GetValueAsString_IsValid);
		GetValueAsRotator_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsRotator");
		GetValueAsRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsRotator_KeyName_PropertyAddress, GetValueAsRotator_FunctionAddress, "KeyName");
		GetValueAsRotator_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsRotator_FunctionAddress, "KeyName");
		GetValueAsRotator_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsRotator_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsRotator_ReturnValue_PropertyAddress, GetValueAsRotator_FunctionAddress, "ReturnValue");
		GetValueAsRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsRotator_FunctionAddress, "ReturnValue");
		GetValueAsRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetValueAsRotator_IsValid = GetValueAsRotator_FunctionAddress != IntPtr.Zero && GetValueAsRotator_KeyName_IsValid && GetValueAsRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsRotator", GetValueAsRotator_IsValid);
		GetValueAsObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsObject");
		GetValueAsObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsObject_KeyName_PropertyAddress, GetValueAsObject_FunctionAddress, "KeyName");
		GetValueAsObject_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsObject_FunctionAddress, "KeyName");
		GetValueAsObject_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsObject_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsObject_ReturnValue_PropertyAddress, GetValueAsObject_FunctionAddress, "ReturnValue");
		GetValueAsObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsObject_FunctionAddress, "ReturnValue");
		GetValueAsObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetValueAsObject_IsValid = GetValueAsObject_FunctionAddress != IntPtr.Zero && GetValueAsObject_KeyName_IsValid && GetValueAsObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsObject", GetValueAsObject_IsValid);
		GetValueAsName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsName");
		GetValueAsName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsName_KeyName_PropertyAddress, GetValueAsName_FunctionAddress, "KeyName");
		GetValueAsName_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsName_FunctionAddress, "KeyName");
		GetValueAsName_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsName_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsName_ReturnValue_PropertyAddress, GetValueAsName_FunctionAddress, "ReturnValue");
		GetValueAsName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsName_FunctionAddress, "ReturnValue");
		GetValueAsName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetValueAsName_IsValid = GetValueAsName_FunctionAddress != IntPtr.Zero && GetValueAsName_KeyName_IsValid && GetValueAsName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsName", GetValueAsName_IsValid);
		GetValueAsInt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsInt");
		GetValueAsInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsInt_KeyName_PropertyAddress, GetValueAsInt_FunctionAddress, "KeyName");
		GetValueAsInt_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsInt_FunctionAddress, "KeyName");
		GetValueAsInt_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsInt_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsInt_ReturnValue_PropertyAddress, GetValueAsInt_FunctionAddress, "ReturnValue");
		GetValueAsInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsInt_FunctionAddress, "ReturnValue");
		GetValueAsInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetValueAsInt_IsValid = GetValueAsInt_FunctionAddress != IntPtr.Zero && GetValueAsInt_KeyName_IsValid && GetValueAsInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsInt", GetValueAsInt_IsValid);
		GetValueAsFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsFloat");
		GetValueAsFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsFloat_KeyName_PropertyAddress, GetValueAsFloat_FunctionAddress, "KeyName");
		GetValueAsFloat_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsFloat_FunctionAddress, "KeyName");
		GetValueAsFloat_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsFloat_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsFloat_ReturnValue_PropertyAddress, GetValueAsFloat_FunctionAddress, "ReturnValue");
		GetValueAsFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsFloat_FunctionAddress, "ReturnValue");
		GetValueAsFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetValueAsFloat_IsValid = GetValueAsFloat_FunctionAddress != IntPtr.Zero && GetValueAsFloat_KeyName_IsValid && GetValueAsFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsFloat", GetValueAsFloat_IsValid);
		GetValueAsEnum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsEnum");
		GetValueAsEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsEnum_KeyName_PropertyAddress, GetValueAsEnum_FunctionAddress, "KeyName");
		GetValueAsEnum_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsEnum_FunctionAddress, "KeyName");
		GetValueAsEnum_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsEnum_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsEnum_ReturnValue_PropertyAddress, GetValueAsEnum_FunctionAddress, "ReturnValue");
		GetValueAsEnum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsEnum_FunctionAddress, "ReturnValue");
		GetValueAsEnum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsEnum_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetValueAsEnum_IsValid = GetValueAsEnum_FunctionAddress != IntPtr.Zero && GetValueAsEnum_KeyName_IsValid && GetValueAsEnum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsEnum", GetValueAsEnum_IsValid);
		GetValueAsClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsClass");
		GetValueAsClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsClass_KeyName_PropertyAddress, GetValueAsClass_FunctionAddress, "KeyName");
		GetValueAsClass_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsClass_FunctionAddress, "KeyName");
		GetValueAsClass_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsClass_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsClass_ReturnValue_PropertyAddress, GetValueAsClass_FunctionAddress, "ReturnValue");
		GetValueAsClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsClass_FunctionAddress, "ReturnValue");
		GetValueAsClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetValueAsClass_IsValid = GetValueAsClass_FunctionAddress != IntPtr.Zero && GetValueAsClass_KeyName_IsValid && GetValueAsClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsClass", GetValueAsClass_IsValid);
		GetValueAsBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueAsBool");
		GetValueAsBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueAsBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsBool_KeyName_PropertyAddress, GetValueAsBool_FunctionAddress, "KeyName");
		GetValueAsBool_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsBool_FunctionAddress, "KeyName");
		GetValueAsBool_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsBool_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueAsBool_ReturnValue_PropertyAddress, GetValueAsBool_FunctionAddress, "ReturnValue");
		GetValueAsBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueAsBool_FunctionAddress, "ReturnValue");
		GetValueAsBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueAsBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetValueAsBool_IsValid = GetValueAsBool_FunctionAddress != IntPtr.Zero && GetValueAsBool_KeyName_IsValid && GetValueAsBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetValueAsBool", GetValueAsBool_IsValid);
		GetRotationFromEntry_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRotationFromEntry");
		GetRotationFromEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationFromEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationFromEntry_KeyName_PropertyAddress, GetRotationFromEntry_FunctionAddress, "KeyName");
		GetRotationFromEntry_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationFromEntry_FunctionAddress, "KeyName");
		GetRotationFromEntry_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationFromEntry_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationFromEntry_ResultRotation_PropertyAddress, GetRotationFromEntry_FunctionAddress, "ResultRotation");
		GetRotationFromEntry_ResultRotation_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationFromEntry_FunctionAddress, "ResultRotation");
		GetRotationFromEntry_ResultRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationFromEntry_FunctionAddress, "ResultRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationFromEntry_ReturnValue_PropertyAddress, GetRotationFromEntry_FunctionAddress, "ReturnValue");
		GetRotationFromEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationFromEntry_FunctionAddress, "ReturnValue");
		GetRotationFromEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationFromEntry_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRotationFromEntry_IsValid = GetRotationFromEntry_FunctionAddress != IntPtr.Zero && GetRotationFromEntry_KeyName_IsValid && GetRotationFromEntry_ResultRotation_IsValid && GetRotationFromEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetRotationFromEntry", GetRotationFromEntry_IsValid);
		GetLocationFromEntry_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLocationFromEntry");
		GetLocationFromEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationFromEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationFromEntry_KeyName_PropertyAddress, GetLocationFromEntry_FunctionAddress, "KeyName");
		GetLocationFromEntry_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationFromEntry_FunctionAddress, "KeyName");
		GetLocationFromEntry_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationFromEntry_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationFromEntry_ResultLocation_PropertyAddress, GetLocationFromEntry_FunctionAddress, "ResultLocation");
		GetLocationFromEntry_ResultLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationFromEntry_FunctionAddress, "ResultLocation");
		GetLocationFromEntry_ResultLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationFromEntry_FunctionAddress, "ResultLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationFromEntry_ReturnValue_PropertyAddress, GetLocationFromEntry_FunctionAddress, "ReturnValue");
		GetLocationFromEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationFromEntry_FunctionAddress, "ReturnValue");
		GetLocationFromEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationFromEntry_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLocationFromEntry_IsValid = GetLocationFromEntry_FunctionAddress != IntPtr.Zero && GetLocationFromEntry_KeyName_IsValid && GetLocationFromEntry_ResultLocation_IsValid && GetLocationFromEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:GetLocationFromEntry", GetLocationFromEntry_IsValid);
		ClearValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearValue");
		ClearValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearValue_KeyName_PropertyAddress, ClearValue_FunctionAddress, "KeyName");
		ClearValue_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(ClearValue_FunctionAddress, "KeyName");
		ClearValue_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearValue_FunctionAddress, "KeyName", Classes.FNameProperty);
		ClearValue_IsValid = ClearValue_FunctionAddress != IntPtr.Zero && ClearValue_KeyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BlackboardComponent:ClearValue", ClearValue_IsValid);
	}
}
