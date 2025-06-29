using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGGraphParametersHelpers", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGGraphParametersHelpers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVectorParameter_IsValid;

	private static IntPtr SetVectorParameter_FunctionAddress;

	private static int SetVectorParameter_ParamsSize;

	private static bool SetVectorParameter_GraphInstance_IsValid;

	private static FFieldAddress SetVectorParameter_GraphInstance_PropertyAddress;

	private static int SetVectorParameter_GraphInstance_Offset;

	private static bool SetVectorParameter_Name_IsValid;

	private static FFieldAddress SetVectorParameter_Name_PropertyAddress;

	private static int SetVectorParameter_Name_Offset;

	private static bool SetVectorParameter_Value_IsValid;

	private static FFieldAddress SetVectorParameter_Value_PropertyAddress;

	private static int SetVectorParameter_Value_Offset;

	private static bool SetTransformParameter_IsValid;

	private static IntPtr SetTransformParameter_FunctionAddress;

	private static int SetTransformParameter_ParamsSize;

	private static bool SetTransformParameter_GraphInstance_IsValid;

	private static FFieldAddress SetTransformParameter_GraphInstance_PropertyAddress;

	private static int SetTransformParameter_GraphInstance_Offset;

	private static bool SetTransformParameter_Name_IsValid;

	private static FFieldAddress SetTransformParameter_Name_PropertyAddress;

	private static int SetTransformParameter_Name_Offset;

	private static bool SetTransformParameter_Value_IsValid;

	private static FFieldAddress SetTransformParameter_Value_PropertyAddress;

	private static int SetTransformParameter_Value_Offset;

	private static bool SetStringParameter_IsValid;

	private static IntPtr SetStringParameter_FunctionAddress;

	private static int SetStringParameter_ParamsSize;

	private static bool SetStringParameter_GraphInstance_IsValid;

	private static FFieldAddress SetStringParameter_GraphInstance_PropertyAddress;

	private static int SetStringParameter_GraphInstance_Offset;

	private static bool SetStringParameter_Name_IsValid;

	private static FFieldAddress SetStringParameter_Name_PropertyAddress;

	private static int SetStringParameter_Name_Offset;

	private static bool SetStringParameter_Value_IsValid;

	private static FFieldAddress SetStringParameter_Value_PropertyAddress;

	private static int SetStringParameter_Value_Offset;

	private static bool SetSoftObjectParameter_IsValid;

	private static IntPtr SetSoftObjectParameter_FunctionAddress;

	private static int SetSoftObjectParameter_ParamsSize;

	private static bool SetSoftObjectParameter_GraphInstance_IsValid;

	private static FFieldAddress SetSoftObjectParameter_GraphInstance_PropertyAddress;

	private static int SetSoftObjectParameter_GraphInstance_Offset;

	private static bool SetSoftObjectParameter_Name_IsValid;

	private static FFieldAddress SetSoftObjectParameter_Name_PropertyAddress;

	private static int SetSoftObjectParameter_Name_Offset;

	private static bool SetSoftObjectParameter_Value_IsValid;

	private static FFieldAddress SetSoftObjectParameter_Value_PropertyAddress;

	private static int SetSoftObjectParameter_Value_Offset;

	private static bool SetSoftClassParameter_IsValid;

	private static IntPtr SetSoftClassParameter_FunctionAddress;

	private static int SetSoftClassParameter_ParamsSize;

	private static bool SetSoftClassParameter_GraphInstance_IsValid;

	private static FFieldAddress SetSoftClassParameter_GraphInstance_PropertyAddress;

	private static int SetSoftClassParameter_GraphInstance_Offset;

	private static bool SetSoftClassParameter_Name_IsValid;

	private static FFieldAddress SetSoftClassParameter_Name_PropertyAddress;

	private static int SetSoftClassParameter_Name_Offset;

	private static bool SetSoftClassParameter_Value_IsValid;

	private static FFieldAddress SetSoftClassParameter_Value_PropertyAddress;

	private static int SetSoftClassParameter_Value_Offset;

	private static bool SetRotatorParameter_IsValid;

	private static IntPtr SetRotatorParameter_FunctionAddress;

	private static int SetRotatorParameter_ParamsSize;

	private static bool SetRotatorParameter_GraphInstance_IsValid;

	private static FFieldAddress SetRotatorParameter_GraphInstance_PropertyAddress;

	private static int SetRotatorParameter_GraphInstance_Offset;

	private static bool SetRotatorParameter_Name_IsValid;

	private static FFieldAddress SetRotatorParameter_Name_PropertyAddress;

	private static int SetRotatorParameter_Name_Offset;

	private static bool SetRotatorParameter_Value_IsValid;

	private static FFieldAddress SetRotatorParameter_Value_PropertyAddress;

	private static int SetRotatorParameter_Value_Offset;

	private static bool SetNameParameter_IsValid;

	private static IntPtr SetNameParameter_FunctionAddress;

	private static int SetNameParameter_ParamsSize;

	private static bool SetNameParameter_GraphInstance_IsValid;

	private static FFieldAddress SetNameParameter_GraphInstance_PropertyAddress;

	private static int SetNameParameter_GraphInstance_Offset;

	private static bool SetNameParameter_Name_IsValid;

	private static FFieldAddress SetNameParameter_Name_PropertyAddress;

	private static int SetNameParameter_Name_Offset;

	private static bool SetNameParameter_Value_IsValid;

	private static FFieldAddress SetNameParameter_Value_PropertyAddress;

	private static int SetNameParameter_Value_Offset;

	private static bool SetInt64Parameter_IsValid;

	private static IntPtr SetInt64Parameter_FunctionAddress;

	private static int SetInt64Parameter_ParamsSize;

	private static bool SetInt64Parameter_GraphInstance_IsValid;

	private static FFieldAddress SetInt64Parameter_GraphInstance_PropertyAddress;

	private static int SetInt64Parameter_GraphInstance_Offset;

	private static bool SetInt64Parameter_Name_IsValid;

	private static FFieldAddress SetInt64Parameter_Name_PropertyAddress;

	private static int SetInt64Parameter_Name_Offset;

	private static bool SetInt64Parameter_Value_IsValid;

	private static FFieldAddress SetInt64Parameter_Value_PropertyAddress;

	private static int SetInt64Parameter_Value_Offset;

	private static bool SetInt32Parameter_IsValid;

	private static IntPtr SetInt32Parameter_FunctionAddress;

	private static int SetInt32Parameter_ParamsSize;

	private static bool SetInt32Parameter_GraphInstance_IsValid;

	private static FFieldAddress SetInt32Parameter_GraphInstance_PropertyAddress;

	private static int SetInt32Parameter_GraphInstance_Offset;

	private static bool SetInt32Parameter_Name_IsValid;

	private static FFieldAddress SetInt32Parameter_Name_PropertyAddress;

	private static int SetInt32Parameter_Name_Offset;

	private static bool SetInt32Parameter_Value_IsValid;

	private static FFieldAddress SetInt32Parameter_Value_PropertyAddress;

	private static int SetInt32Parameter_Value_Offset;

	private static bool SetFloatParameter_IsValid;

	private static IntPtr SetFloatParameter_FunctionAddress;

	private static int SetFloatParameter_ParamsSize;

	private static bool SetFloatParameter_GraphInstance_IsValid;

	private static FFieldAddress SetFloatParameter_GraphInstance_PropertyAddress;

	private static int SetFloatParameter_GraphInstance_Offset;

	private static bool SetFloatParameter_Name_IsValid;

	private static FFieldAddress SetFloatParameter_Name_PropertyAddress;

	private static int SetFloatParameter_Name_Offset;

	private static bool SetFloatParameter_Value_IsValid;

	private static FFieldAddress SetFloatParameter_Value_PropertyAddress;

	private static int SetFloatParameter_Value_Offset;

	private static bool SetEnumParameter_IsValid;

	private static IntPtr SetEnumParameter_FunctionAddress;

	private static int SetEnumParameter_ParamsSize;

	private static bool SetEnumParameter_GraphInstance_IsValid;

	private static FFieldAddress SetEnumParameter_GraphInstance_PropertyAddress;

	private static int SetEnumParameter_GraphInstance_Offset;

	private static bool SetEnumParameter_Name_IsValid;

	private static FFieldAddress SetEnumParameter_Name_PropertyAddress;

	private static int SetEnumParameter_Name_Offset;

	private static bool SetEnumParameter_Enum_IsValid;

	private static FFieldAddress SetEnumParameter_Enum_PropertyAddress;

	private static int SetEnumParameter_Enum_Offset;

	private static bool SetEnumParameter_Value_IsValid;

	private static FFieldAddress SetEnumParameter_Value_PropertyAddress;

	private static int SetEnumParameter_Value_Offset;

	private static bool SetDoubleParameter_IsValid;

	private static IntPtr SetDoubleParameter_FunctionAddress;

	private static int SetDoubleParameter_ParamsSize;

	private static bool SetDoubleParameter_GraphInstance_IsValid;

	private static FFieldAddress SetDoubleParameter_GraphInstance_PropertyAddress;

	private static int SetDoubleParameter_GraphInstance_Offset;

	private static bool SetDoubleParameter_Name_IsValid;

	private static FFieldAddress SetDoubleParameter_Name_PropertyAddress;

	private static int SetDoubleParameter_Name_Offset;

	private static bool SetDoubleParameter_Value_IsValid;

	private static FFieldAddress SetDoubleParameter_Value_PropertyAddress;

	private static int SetDoubleParameter_Value_Offset;

	private static bool SetByteParameter_IsValid;

	private static IntPtr SetByteParameter_FunctionAddress;

	private static int SetByteParameter_ParamsSize;

	private static bool SetByteParameter_GraphInstance_IsValid;

	private static FFieldAddress SetByteParameter_GraphInstance_PropertyAddress;

	private static int SetByteParameter_GraphInstance_Offset;

	private static bool SetByteParameter_Name_IsValid;

	private static FFieldAddress SetByteParameter_Name_PropertyAddress;

	private static int SetByteParameter_Name_Offset;

	private static bool SetByteParameter_Value_IsValid;

	private static FFieldAddress SetByteParameter_Value_PropertyAddress;

	private static int SetByteParameter_Value_Offset;

	private static bool SetBoolParameter_IsValid;

	private static IntPtr SetBoolParameter_FunctionAddress;

	private static int SetBoolParameter_ParamsSize;

	private static bool SetBoolParameter_GraphInstance_IsValid;

	private static FFieldAddress SetBoolParameter_GraphInstance_PropertyAddress;

	private static int SetBoolParameter_GraphInstance_Offset;

	private static bool SetBoolParameter_Name_IsValid;

	private static FFieldAddress SetBoolParameter_Name_PropertyAddress;

	private static int SetBoolParameter_Name_Offset;

	private static bool SetBoolParameter_bValue_IsValid;

	private static FFieldAddress SetBoolParameter_bValue_PropertyAddress;

	private static int SetBoolParameter_bValue_Offset;

	private static bool IsOverridden_IsValid;

	private static IntPtr IsOverridden_FunctionAddress;

	private static int IsOverridden_ParamsSize;

	private static bool IsOverridden_GraphInstance_IsValid;

	private static FFieldAddress IsOverridden_GraphInstance_PropertyAddress;

	private static int IsOverridden_GraphInstance_Offset;

	private static bool IsOverridden_Name_IsValid;

	private static FFieldAddress IsOverridden_Name_PropertyAddress;

	private static int IsOverridden_Name_Offset;

	private static bool IsOverridden_ReturnValue_IsValid;

	private static FFieldAddress IsOverridden_ReturnValue_PropertyAddress;

	private static int IsOverridden_ReturnValue_Offset;

	private static bool GetVectorParameter_IsValid;

	private static IntPtr GetVectorParameter_FunctionAddress;

	private static int GetVectorParameter_ParamsSize;

	private static bool GetVectorParameter_GraphInstance_IsValid;

	private static FFieldAddress GetVectorParameter_GraphInstance_PropertyAddress;

	private static int GetVectorParameter_GraphInstance_Offset;

	private static bool GetVectorParameter_Name_IsValid;

	private static FFieldAddress GetVectorParameter_Name_PropertyAddress;

	private static int GetVectorParameter_Name_Offset;

	private static bool GetVectorParameter_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameter_ReturnValue_PropertyAddress;

	private static int GetVectorParameter_ReturnValue_Offset;

	private static bool GetTransformParameter_IsValid;

	private static IntPtr GetTransformParameter_FunctionAddress;

	private static int GetTransformParameter_ParamsSize;

	private static bool GetTransformParameter_GraphInstance_IsValid;

	private static FFieldAddress GetTransformParameter_GraphInstance_PropertyAddress;

	private static int GetTransformParameter_GraphInstance_Offset;

	private static bool GetTransformParameter_Name_IsValid;

	private static FFieldAddress GetTransformParameter_Name_PropertyAddress;

	private static int GetTransformParameter_Name_Offset;

	private static bool GetTransformParameter_ReturnValue_IsValid;

	private static FFieldAddress GetTransformParameter_ReturnValue_PropertyAddress;

	private static int GetTransformParameter_ReturnValue_Offset;

	private static bool GetStringParameter_IsValid;

	private static IntPtr GetStringParameter_FunctionAddress;

	private static int GetStringParameter_ParamsSize;

	private static bool GetStringParameter_GraphInstance_IsValid;

	private static FFieldAddress GetStringParameter_GraphInstance_PropertyAddress;

	private static int GetStringParameter_GraphInstance_Offset;

	private static bool GetStringParameter_Name_IsValid;

	private static FFieldAddress GetStringParameter_Name_PropertyAddress;

	private static int GetStringParameter_Name_Offset;

	private static bool GetStringParameter_ReturnValue_IsValid;

	private static FFieldAddress GetStringParameter_ReturnValue_PropertyAddress;

	private static int GetStringParameter_ReturnValue_Offset;

	private static bool GetSoftObjectParameter_IsValid;

	private static IntPtr GetSoftObjectParameter_FunctionAddress;

	private static int GetSoftObjectParameter_ParamsSize;

	private static bool GetSoftObjectParameter_GraphInstance_IsValid;

	private static FFieldAddress GetSoftObjectParameter_GraphInstance_PropertyAddress;

	private static int GetSoftObjectParameter_GraphInstance_Offset;

	private static bool GetSoftObjectParameter_Name_IsValid;

	private static FFieldAddress GetSoftObjectParameter_Name_PropertyAddress;

	private static int GetSoftObjectParameter_Name_Offset;

	private static bool GetSoftObjectParameter_ReturnValue_IsValid;

	private static FFieldAddress GetSoftObjectParameter_ReturnValue_PropertyAddress;

	private static int GetSoftObjectParameter_ReturnValue_Offset;

	private static bool GetSoftClassParameter_IsValid;

	private static IntPtr GetSoftClassParameter_FunctionAddress;

	private static int GetSoftClassParameter_ParamsSize;

	private static bool GetSoftClassParameter_GraphInstance_IsValid;

	private static FFieldAddress GetSoftClassParameter_GraphInstance_PropertyAddress;

	private static int GetSoftClassParameter_GraphInstance_Offset;

	private static bool GetSoftClassParameter_Name_IsValid;

	private static FFieldAddress GetSoftClassParameter_Name_PropertyAddress;

	private static int GetSoftClassParameter_Name_Offset;

	private static bool GetSoftClassParameter_ReturnValue_IsValid;

	private static FFieldAddress GetSoftClassParameter_ReturnValue_PropertyAddress;

	private static int GetSoftClassParameter_ReturnValue_Offset;

	private static bool GetRotatorParameter_IsValid;

	private static IntPtr GetRotatorParameter_FunctionAddress;

	private static int GetRotatorParameter_ParamsSize;

	private static bool GetRotatorParameter_GraphInstance_IsValid;

	private static FFieldAddress GetRotatorParameter_GraphInstance_PropertyAddress;

	private static int GetRotatorParameter_GraphInstance_Offset;

	private static bool GetRotatorParameter_Name_IsValid;

	private static FFieldAddress GetRotatorParameter_Name_PropertyAddress;

	private static int GetRotatorParameter_Name_Offset;

	private static bool GetRotatorParameter_ReturnValue_IsValid;

	private static FFieldAddress GetRotatorParameter_ReturnValue_PropertyAddress;

	private static int GetRotatorParameter_ReturnValue_Offset;

	private static bool GetNameParameter_IsValid;

	private static IntPtr GetNameParameter_FunctionAddress;

	private static int GetNameParameter_ParamsSize;

	private static bool GetNameParameter_GraphInstance_IsValid;

	private static FFieldAddress GetNameParameter_GraphInstance_PropertyAddress;

	private static int GetNameParameter_GraphInstance_Offset;

	private static bool GetNameParameter_Name_IsValid;

	private static FFieldAddress GetNameParameter_Name_PropertyAddress;

	private static int GetNameParameter_Name_Offset;

	private static bool GetNameParameter_ReturnValue_IsValid;

	private static FFieldAddress GetNameParameter_ReturnValue_PropertyAddress;

	private static int GetNameParameter_ReturnValue_Offset;

	private static bool GetInt64Parameter_IsValid;

	private static IntPtr GetInt64Parameter_FunctionAddress;

	private static int GetInt64Parameter_ParamsSize;

	private static bool GetInt64Parameter_GraphInstance_IsValid;

	private static FFieldAddress GetInt64Parameter_GraphInstance_PropertyAddress;

	private static int GetInt64Parameter_GraphInstance_Offset;

	private static bool GetInt64Parameter_Name_IsValid;

	private static FFieldAddress GetInt64Parameter_Name_PropertyAddress;

	private static int GetInt64Parameter_Name_Offset;

	private static bool GetInt64Parameter_ReturnValue_IsValid;

	private static FFieldAddress GetInt64Parameter_ReturnValue_PropertyAddress;

	private static int GetInt64Parameter_ReturnValue_Offset;

	private static bool GetInt32Parameter_IsValid;

	private static IntPtr GetInt32Parameter_FunctionAddress;

	private static int GetInt32Parameter_ParamsSize;

	private static bool GetInt32Parameter_GraphInstance_IsValid;

	private static FFieldAddress GetInt32Parameter_GraphInstance_PropertyAddress;

	private static int GetInt32Parameter_GraphInstance_Offset;

	private static bool GetInt32Parameter_Name_IsValid;

	private static FFieldAddress GetInt32Parameter_Name_PropertyAddress;

	private static int GetInt32Parameter_Name_Offset;

	private static bool GetInt32Parameter_ReturnValue_IsValid;

	private static FFieldAddress GetInt32Parameter_ReturnValue_PropertyAddress;

	private static int GetInt32Parameter_ReturnValue_Offset;

	private static bool GetFloatParameter_IsValid;

	private static IntPtr GetFloatParameter_FunctionAddress;

	private static int GetFloatParameter_ParamsSize;

	private static bool GetFloatParameter_GraphInstance_IsValid;

	private static FFieldAddress GetFloatParameter_GraphInstance_PropertyAddress;

	private static int GetFloatParameter_GraphInstance_Offset;

	private static bool GetFloatParameter_Name_IsValid;

	private static FFieldAddress GetFloatParameter_Name_PropertyAddress;

	private static int GetFloatParameter_Name_Offset;

	private static bool GetFloatParameter_ReturnValue_IsValid;

	private static FFieldAddress GetFloatParameter_ReturnValue_PropertyAddress;

	private static int GetFloatParameter_ReturnValue_Offset;

	private static bool GetDoubleParameter_IsValid;

	private static IntPtr GetDoubleParameter_FunctionAddress;

	private static int GetDoubleParameter_ParamsSize;

	private static bool GetDoubleParameter_GraphInstance_IsValid;

	private static FFieldAddress GetDoubleParameter_GraphInstance_PropertyAddress;

	private static int GetDoubleParameter_GraphInstance_Offset;

	private static bool GetDoubleParameter_Name_IsValid;

	private static FFieldAddress GetDoubleParameter_Name_PropertyAddress;

	private static int GetDoubleParameter_Name_Offset;

	private static bool GetDoubleParameter_ReturnValue_IsValid;

	private static FFieldAddress GetDoubleParameter_ReturnValue_PropertyAddress;

	private static int GetDoubleParameter_ReturnValue_Offset;

	private static bool GetByteParameter_IsValid;

	private static IntPtr GetByteParameter_FunctionAddress;

	private static int GetByteParameter_ParamsSize;

	private static bool GetByteParameter_GraphInstance_IsValid;

	private static FFieldAddress GetByteParameter_GraphInstance_PropertyAddress;

	private static int GetByteParameter_GraphInstance_Offset;

	private static bool GetByteParameter_Name_IsValid;

	private static FFieldAddress GetByteParameter_Name_PropertyAddress;

	private static int GetByteParameter_Name_Offset;

	private static bool GetByteParameter_ReturnValue_IsValid;

	private static FFieldAddress GetByteParameter_ReturnValue_PropertyAddress;

	private static int GetByteParameter_ReturnValue_Offset;

	private static bool GetBoolParameter_IsValid;

	private static IntPtr GetBoolParameter_FunctionAddress;

	private static int GetBoolParameter_ParamsSize;

	private static bool GetBoolParameter_GraphInstance_IsValid;

	private static FFieldAddress GetBoolParameter_GraphInstance_PropertyAddress;

	private static int GetBoolParameter_GraphInstance_Offset;

	private static bool GetBoolParameter_Name_IsValid;

	private static FFieldAddress GetBoolParameter_Name_PropertyAddress;

	private static int GetBoolParameter_Name_Offset;

	private static bool GetBoolParameter_ReturnValue_IsValid;

	private static FFieldAddress GetBoolParameter_ReturnValue_PropertyAddress;

	private static int GetBoolParameter_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetVectorParameter")]
	public unsafe static void SetVectorParameter(UPCGGraphInstance GraphInstance, FName Name, FVector Value)
	{
		if (!SetVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetVectorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetVectorParameter_GraphInstance_Offset), 0, SetVectorParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameter_Name_Offset), 0, SetVectorParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVectorParameter_Value_Offset), 0, SetVectorParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVectorParameter_FunctionAddress, intPtr, SetVectorParameter_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetTransformParameter")]
	public unsafe static void SetTransformParameter(UPCGGraphInstance GraphInstance, FName Name, FTransform Value)
	{
		if (!SetTransformParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetTransformParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransformParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransformParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetTransformParameter_GraphInstance_Offset), 0, SetTransformParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTransformParameter_Name_Offset), 0, SetTransformParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InitializeValue_InContainer(SetTransformParameter_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetTransformParameter_Value_Offset), 0, SetTransformParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTransformParameter_FunctionAddress, intPtr, SetTransformParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetStringParameter")]
	public unsafe static void SetStringParameter(UPCGGraphInstance GraphInstance, FName Name, string Value)
	{
		if (!SetStringParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetStringParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStringParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStringParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetStringParameter_GraphInstance_Offset), 0, SetStringParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetStringParameter_Name_Offset), 0, SetStringParameter_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStringParameter_Value_Offset), 0, SetStringParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStringParameter_FunctionAddress, intPtr, SetStringParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStringParameter_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetSoftObjectParameter")]
	public unsafe static void SetSoftObjectParameter(UPCGGraphInstance GraphInstance, FName Name, TSoftObject<UObject> Value)
	{
		if (!SetSoftObjectParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetSoftObjectParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoftObjectParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoftObjectParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetSoftObjectParameter_GraphInstance_Offset), 0, SetSoftObjectParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSoftObjectParameter_Name_Offset), 0, SetSoftObjectParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InitializeValue_InContainer(SetSoftObjectParameter_Value_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSoftObjectParameter_Value_Offset), 0, SetSoftObjectParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSoftObjectParameter_FunctionAddress, intPtr, SetSoftObjectParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSoftObjectParameter_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetSoftClassParameter")]
	public unsafe static void SetSoftClassParameter(UPCGGraphInstance GraphInstance, FName Name, TSoftClass<UObject> Value)
	{
		if (!SetSoftClassParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetSoftClassParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoftClassParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoftClassParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetSoftClassParameter_GraphInstance_Offset), 0, SetSoftClassParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSoftClassParameter_Name_Offset), 0, SetSoftClassParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InitializeValue_InContainer(SetSoftClassParameter_Value_PropertyAddress.Address, intPtr);
		TSoftClassMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSoftClassParameter_Value_Offset), 0, SetSoftClassParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSoftClassParameter_FunctionAddress, intPtr, SetSoftClassParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSoftClassParameter_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetRotatorParameter")]
	public unsafe static void SetRotatorParameter(UPCGGraphInstance GraphInstance, FName Name, FRotator Value)
	{
		if (!SetRotatorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetRotatorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRotatorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRotatorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetRotatorParameter_GraphInstance_Offset), 0, SetRotatorParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRotatorParameter_Name_Offset), 0, SetRotatorParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRotatorParameter_Value_Offset), 0, SetRotatorParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRotatorParameter_FunctionAddress, intPtr, SetRotatorParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetNameParameter")]
	public unsafe static void SetNameParameter(UPCGGraphInstance GraphInstance, FName Name, FName Value)
	{
		if (!SetNameParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetNameParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNameParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNameParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetNameParameter_GraphInstance_Offset), 0, SetNameParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNameParameter_Name_Offset), 0, SetNameParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNameParameter_Value_Offset), 0, SetNameParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNameParameter_FunctionAddress, intPtr, SetNameParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetInt64Parameter")]
	public unsafe static void SetInt64Parameter(UPCGGraphInstance GraphInstance, FName Name, long Value)
	{
		if (!SetInt64Parameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetInt64Parameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInt64Parameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInt64Parameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetInt64Parameter_GraphInstance_Offset), 0, SetInt64Parameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInt64Parameter_Name_Offset), 0, SetInt64Parameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetInt64Parameter_Value_Offset), 0, SetInt64Parameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInt64Parameter_FunctionAddress, intPtr, SetInt64Parameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetInt32Parameter")]
	public unsafe static void SetInt32Parameter(UPCGGraphInstance GraphInstance, FName Name, int Value)
	{
		if (!SetInt32Parameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetInt32Parameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInt32Parameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInt32Parameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetInt32Parameter_GraphInstance_Offset), 0, SetInt32Parameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInt32Parameter_Name_Offset), 0, SetInt32Parameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetInt32Parameter_Value_Offset), 0, SetInt32Parameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInt32Parameter_FunctionAddress, intPtr, SetInt32Parameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetFloatParameter")]
	public unsafe static void SetFloatParameter(UPCGGraphInstance GraphInstance, FName Name, float Value)
	{
		if (!SetFloatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetFloatParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_GraphInstance_Offset), 0, SetFloatParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_Name_Offset), 0, SetFloatParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_Value_Offset), 0, SetFloatParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFloatParameter_FunctionAddress, intPtr, SetFloatParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetEnumParameter")]
	public unsafe static void SetEnumParameter(UPCGGraphInstance GraphInstance, FName Name, UEnum Enum, byte Value)
	{
		if (!SetEnumParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetEnumParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnumParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnumParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetEnumParameter_GraphInstance_Offset), 0, SetEnumParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetEnumParameter_Name_Offset), 0, SetEnumParameter_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<UEnum>.ToNative(IntPtr.Add(intPtr, SetEnumParameter_Enum_Offset), 0, SetEnumParameter_Enum_PropertyAddress.Address, Enum);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetEnumParameter_Value_Offset), 0, SetEnumParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEnumParameter_FunctionAddress, intPtr, SetEnumParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetDoubleParameter")]
	public unsafe static void SetDoubleParameter(UPCGGraphInstance GraphInstance, FName Name, double Value)
	{
		if (!SetDoubleParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetDoubleParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDoubleParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDoubleParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetDoubleParameter_GraphInstance_Offset), 0, SetDoubleParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetDoubleParameter_Name_Offset), 0, SetDoubleParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, SetDoubleParameter_Value_Offset), 0, SetDoubleParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDoubleParameter_FunctionAddress, intPtr, SetDoubleParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetByteParameter")]
	public unsafe static void SetByteParameter(UPCGGraphInstance GraphInstance, FName Name, byte Value)
	{
		if (!SetByteParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetByteParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetByteParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetByteParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetByteParameter_GraphInstance_Offset), 0, SetByteParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetByteParameter_Name_Offset), 0, SetByteParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetByteParameter_Value_Offset), 0, SetByteParameter_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetByteParameter_FunctionAddress, intPtr, SetByteParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:SetBoolParameter")]
	public unsafe static void SetBoolParameter(UPCGGraphInstance GraphInstance, FName Name, bool bValue)
	{
		if (!SetBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:SetBoolParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, SetBoolParameter_GraphInstance_Offset), 0, SetBoolParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolParameter_Name_Offset), 0, SetBoolParameter_Name_PropertyAddress.Address, Name);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolParameter_bValue_Offset), 0, SetBoolParameter_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBoolParameter_FunctionAddress, intPtr, SetBoolParameter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:IsOverridden")]
	public unsafe static bool IsOverridden(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!IsOverridden_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:IsOverridden");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverridden_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverridden_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, IsOverridden_GraphInstance_Offset), 0, IsOverridden_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsOverridden_Name_Offset), 0, IsOverridden_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsOverridden_FunctionAddress, intPtr, IsOverridden_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverridden_ReturnValue_Offset), 0, IsOverridden_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetVectorParameter")]
	public unsafe static FVector GetVectorParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetVectorParameter");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetVectorParameter_GraphInstance_Offset), 0, GetVectorParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorParameter_Name_Offset), 0, GetVectorParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorParameter_FunctionAddress, intPtr, GetVectorParameter_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorParameter_ReturnValue_Offset), 0, GetVectorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetTransformParameter")]
	public unsafe static FTransform GetTransformParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetTransformParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetTransformParameter");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetTransformParameter_GraphInstance_Offset), 0, GetTransformParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTransformParameter_Name_Offset), 0, GetTransformParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformParameter_FunctionAddress, intPtr, GetTransformParameter_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformParameter_ReturnValue_Offset), 0, GetTransformParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetStringParameter")]
	public unsafe static string GetStringParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetStringParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetStringParameter");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStringParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStringParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetStringParameter_GraphInstance_Offset), 0, GetStringParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStringParameter_Name_Offset), 0, GetStringParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStringParameter_FunctionAddress, intPtr, GetStringParameter_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStringParameter_ReturnValue_Offset), 0, GetStringParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStringParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetSoftObjectParameter")]
	public unsafe static TSoftObject<UObject> GetSoftObjectParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetSoftObjectParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetSoftObjectParameter");
			return default(TSoftObject<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftObjectParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftObjectParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetSoftObjectParameter_GraphInstance_Offset), 0, GetSoftObjectParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSoftObjectParameter_Name_Offset), 0, GetSoftObjectParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSoftObjectParameter_FunctionAddress, intPtr, GetSoftObjectParameter_ParamsSize);
		TSoftObject<UObject> result = TSoftObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetSoftObjectParameter_ReturnValue_Offset), 0, GetSoftObjectParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSoftObjectParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetSoftClassParameter")]
	public unsafe static TSoftClass<UObject> GetSoftClassParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetSoftClassParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetSoftClassParameter");
			return default(TSoftClass<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftClassParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftClassParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetSoftClassParameter_GraphInstance_Offset), 0, GetSoftClassParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSoftClassParameter_Name_Offset), 0, GetSoftClassParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSoftClassParameter_FunctionAddress, intPtr, GetSoftClassParameter_ParamsSize);
		TSoftClass<UObject> result = TSoftClassMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetSoftClassParameter_ReturnValue_Offset), 0, GetSoftClassParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSoftClassParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetRotatorParameter")]
	public unsafe static FRotator GetRotatorParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetRotatorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetRotatorParameter");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotatorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotatorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetRotatorParameter_GraphInstance_Offset), 0, GetRotatorParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRotatorParameter_Name_Offset), 0, GetRotatorParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRotatorParameter_FunctionAddress, intPtr, GetRotatorParameter_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotatorParameter_ReturnValue_Offset), 0, GetRotatorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetNameParameter")]
	public unsafe static FName GetNameParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetNameParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetNameParameter");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNameParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNameParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetNameParameter_GraphInstance_Offset), 0, GetNameParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNameParameter_Name_Offset), 0, GetNameParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNameParameter_FunctionAddress, intPtr, GetNameParameter_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetNameParameter_ReturnValue_Offset), 0, GetNameParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetInt64Parameter")]
	public unsafe static long GetInt64Parameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetInt64Parameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetInt64Parameter");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInt64Parameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt64Parameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetInt64Parameter_GraphInstance_Offset), 0, GetInt64Parameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInt64Parameter_Name_Offset), 0, GetInt64Parameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInt64Parameter_FunctionAddress, intPtr, GetInt64Parameter_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetInt64Parameter_ReturnValue_Offset), 0, GetInt64Parameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetInt32Parameter")]
	public unsafe static int GetInt32Parameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetInt32Parameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetInt32Parameter");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInt32Parameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt32Parameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetInt32Parameter_GraphInstance_Offset), 0, GetInt32Parameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInt32Parameter_Name_Offset), 0, GetInt32Parameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInt32Parameter_FunctionAddress, intPtr, GetInt32Parameter_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInt32Parameter_ReturnValue_Offset), 0, GetInt32Parameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetFloatParameter")]
	public unsafe static float GetFloatParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetFloatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetFloatParameter");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetFloatParameter_GraphInstance_Offset), 0, GetFloatParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatParameter_Name_Offset), 0, GetFloatParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloatParameter_FunctionAddress, intPtr, GetFloatParameter_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatParameter_ReturnValue_Offset), 0, GetFloatParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetDoubleParameter")]
	public unsafe static double GetDoubleParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetDoubleParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetDoubleParameter");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDoubleParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDoubleParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetDoubleParameter_GraphInstance_Offset), 0, GetDoubleParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDoubleParameter_Name_Offset), 0, GetDoubleParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDoubleParameter_FunctionAddress, intPtr, GetDoubleParameter_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetDoubleParameter_ReturnValue_Offset), 0, GetDoubleParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetByteParameter")]
	public unsafe static byte GetByteParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetByteParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetByteParameter");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetByteParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetByteParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetByteParameter_GraphInstance_Offset), 0, GetByteParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetByteParameter_Name_Offset), 0, GetByteParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetByteParameter_FunctionAddress, intPtr, GetByteParameter_ParamsSize);
		return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetByteParameter_ReturnValue_Offset), 0, GetByteParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGGraphParametersHelpers:GetBoolParameter")]
	public unsafe static bool GetBoolParameter(UPCGGraphInstance GraphInstance, FName Name)
	{
		if (!GetBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphParametersHelpers:GetBoolParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(intPtr, GetBoolParameter_GraphInstance_Offset), 0, GetBoolParameter_GraphInstance_PropertyAddress.Address, GraphInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoolParameter_Name_Offset), 0, GetBoolParameter_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoolParameter_FunctionAddress, intPtr, GetBoolParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBoolParameter_ReturnValue_Offset), 0, GetBoolParameter_ReturnValue_PropertyAddress.Address);
	}

	static UPCGGraphParametersHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGGraphParametersHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGGraphParametersHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/PCG.PCGGraphParametersHelpers");
		SetVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVectorParameter");
		SetVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_GraphInstance_PropertyAddress, SetVectorParameter_FunctionAddress, "GraphInstance");
		SetVectorParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "GraphInstance");
		SetVectorParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_Name_PropertyAddress, SetVectorParameter_FunctionAddress, "Name");
		SetVectorParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "Name");
		SetVectorParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_Value_PropertyAddress, SetVectorParameter_FunctionAddress, "Value");
		SetVectorParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "Value");
		SetVectorParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorParameter_IsValid = SetVectorParameter_FunctionAddress != IntPtr.Zero && SetVectorParameter_GraphInstance_IsValid && SetVectorParameter_Name_IsValid && SetVectorParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetVectorParameter", SetVectorParameter_IsValid);
		SetTransformParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTransformParameter");
		SetTransformParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransformParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTransformParameter_GraphInstance_PropertyAddress, SetTransformParameter_FunctionAddress, "GraphInstance");
		SetTransformParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformParameter_FunctionAddress, "GraphInstance");
		SetTransformParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformParameter_Name_PropertyAddress, SetTransformParameter_FunctionAddress, "Name");
		SetTransformParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformParameter_FunctionAddress, "Name");
		SetTransformParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformParameter_Value_PropertyAddress, SetTransformParameter_FunctionAddress, "Value");
		SetTransformParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformParameter_FunctionAddress, "Value");
		SetTransformParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformParameter_FunctionAddress, "Value", Classes.FStructProperty);
		SetTransformParameter_IsValid = SetTransformParameter_FunctionAddress != IntPtr.Zero && SetTransformParameter_GraphInstance_IsValid && SetTransformParameter_Name_IsValid && SetTransformParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetTransformParameter", SetTransformParameter_IsValid);
		SetStringParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStringParameter");
		SetStringParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStringParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStringParameter_GraphInstance_PropertyAddress, SetStringParameter_FunctionAddress, "GraphInstance");
		SetStringParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetStringParameter_FunctionAddress, "GraphInstance");
		SetStringParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringParameter_Name_PropertyAddress, SetStringParameter_FunctionAddress, "Name");
		SetStringParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetStringParameter_FunctionAddress, "Name");
		SetStringParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringParameter_Value_PropertyAddress, SetStringParameter_FunctionAddress, "Value");
		SetStringParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetStringParameter_FunctionAddress, "Value");
		SetStringParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringParameter_FunctionAddress, "Value", Classes.FStrProperty);
		SetStringParameter_IsValid = SetStringParameter_FunctionAddress != IntPtr.Zero && SetStringParameter_GraphInstance_IsValid && SetStringParameter_Name_IsValid && SetStringParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetStringParameter", SetStringParameter_IsValid);
		SetSoftObjectParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSoftObjectParameter");
		SetSoftObjectParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoftObjectParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoftObjectParameter_GraphInstance_PropertyAddress, SetSoftObjectParameter_FunctionAddress, "GraphInstance");
		SetSoftObjectParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftObjectParameter_FunctionAddress, "GraphInstance");
		SetSoftObjectParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftObjectParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSoftObjectParameter_Name_PropertyAddress, SetSoftObjectParameter_FunctionAddress, "Name");
		SetSoftObjectParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftObjectParameter_FunctionAddress, "Name");
		SetSoftObjectParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftObjectParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSoftObjectParameter_Value_PropertyAddress, SetSoftObjectParameter_FunctionAddress, "Value");
		SetSoftObjectParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftObjectParameter_FunctionAddress, "Value");
		SetSoftObjectParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftObjectParameter_FunctionAddress, "Value", Classes.FSoftObjectProperty);
		SetSoftObjectParameter_IsValid = SetSoftObjectParameter_FunctionAddress != IntPtr.Zero && SetSoftObjectParameter_GraphInstance_IsValid && SetSoftObjectParameter_Name_IsValid && SetSoftObjectParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetSoftObjectParameter", SetSoftObjectParameter_IsValid);
		SetSoftClassParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSoftClassParameter");
		SetSoftClassParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoftClassParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoftClassParameter_GraphInstance_PropertyAddress, SetSoftClassParameter_FunctionAddress, "GraphInstance");
		SetSoftClassParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftClassParameter_FunctionAddress, "GraphInstance");
		SetSoftClassParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftClassParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSoftClassParameter_Name_PropertyAddress, SetSoftClassParameter_FunctionAddress, "Name");
		SetSoftClassParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftClassParameter_FunctionAddress, "Name");
		SetSoftClassParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftClassParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSoftClassParameter_Value_PropertyAddress, SetSoftClassParameter_FunctionAddress, "Value");
		SetSoftClassParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftClassParameter_FunctionAddress, "Value");
		SetSoftClassParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftClassParameter_FunctionAddress, "Value", Classes.FSoftClassProperty);
		SetSoftClassParameter_IsValid = SetSoftClassParameter_FunctionAddress != IntPtr.Zero && SetSoftClassParameter_GraphInstance_IsValid && SetSoftClassParameter_Name_IsValid && SetSoftClassParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetSoftClassParameter", SetSoftClassParameter_IsValid);
		SetRotatorParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRotatorParameter");
		SetRotatorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRotatorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorParameter_GraphInstance_PropertyAddress, SetRotatorParameter_FunctionAddress, "GraphInstance");
		SetRotatorParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorParameter_FunctionAddress, "GraphInstance");
		SetRotatorParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorParameter_Name_PropertyAddress, SetRotatorParameter_FunctionAddress, "Name");
		SetRotatorParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorParameter_FunctionAddress, "Name");
		SetRotatorParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorParameter_Value_PropertyAddress, SetRotatorParameter_FunctionAddress, "Value");
		SetRotatorParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorParameter_FunctionAddress, "Value");
		SetRotatorParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorParameter_FunctionAddress, "Value", Classes.FStructProperty);
		SetRotatorParameter_IsValid = SetRotatorParameter_FunctionAddress != IntPtr.Zero && SetRotatorParameter_GraphInstance_IsValid && SetRotatorParameter_Name_IsValid && SetRotatorParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetRotatorParameter", SetRotatorParameter_IsValid);
		SetNameParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNameParameter");
		SetNameParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNameParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNameParameter_GraphInstance_PropertyAddress, SetNameParameter_FunctionAddress, "GraphInstance");
		SetNameParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetNameParameter_FunctionAddress, "GraphInstance");
		SetNameParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNameParameter_Name_PropertyAddress, SetNameParameter_FunctionAddress, "Name");
		SetNameParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetNameParameter_FunctionAddress, "Name");
		SetNameParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNameParameter_Value_PropertyAddress, SetNameParameter_FunctionAddress, "Value");
		SetNameParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNameParameter_FunctionAddress, "Value");
		SetNameParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameParameter_FunctionAddress, "Value", Classes.FNameProperty);
		SetNameParameter_IsValid = SetNameParameter_FunctionAddress != IntPtr.Zero && SetNameParameter_GraphInstance_IsValid && SetNameParameter_Name_IsValid && SetNameParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetNameParameter", SetNameParameter_IsValid);
		SetInt64Parameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInt64Parameter");
		SetInt64Parameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInt64Parameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInt64Parameter_GraphInstance_PropertyAddress, SetInt64Parameter_FunctionAddress, "GraphInstance");
		SetInt64Parameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetInt64Parameter_FunctionAddress, "GraphInstance");
		SetInt64Parameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt64Parameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt64Parameter_Name_PropertyAddress, SetInt64Parameter_FunctionAddress, "Name");
		SetInt64Parameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetInt64Parameter_FunctionAddress, "Name");
		SetInt64Parameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt64Parameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt64Parameter_Value_PropertyAddress, SetInt64Parameter_FunctionAddress, "Value");
		SetInt64Parameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInt64Parameter_FunctionAddress, "Value");
		SetInt64Parameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt64Parameter_FunctionAddress, "Value", Classes.FInt64Property);
		SetInt64Parameter_IsValid = SetInt64Parameter_FunctionAddress != IntPtr.Zero && SetInt64Parameter_GraphInstance_IsValid && SetInt64Parameter_Name_IsValid && SetInt64Parameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetInt64Parameter", SetInt64Parameter_IsValid);
		SetInt32Parameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInt32Parameter");
		SetInt32Parameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInt32Parameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInt32Parameter_GraphInstance_PropertyAddress, SetInt32Parameter_FunctionAddress, "GraphInstance");
		SetInt32Parameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetInt32Parameter_FunctionAddress, "GraphInstance");
		SetInt32Parameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt32Parameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt32Parameter_Name_PropertyAddress, SetInt32Parameter_FunctionAddress, "Name");
		SetInt32Parameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetInt32Parameter_FunctionAddress, "Name");
		SetInt32Parameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt32Parameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt32Parameter_Value_PropertyAddress, SetInt32Parameter_FunctionAddress, "Value");
		SetInt32Parameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInt32Parameter_FunctionAddress, "Value");
		SetInt32Parameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt32Parameter_FunctionAddress, "Value", Classes.FIntProperty);
		SetInt32Parameter_IsValid = SetInt32Parameter_FunctionAddress != IntPtr.Zero && SetInt32Parameter_GraphInstance_IsValid && SetInt32Parameter_Name_IsValid && SetInt32Parameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetInt32Parameter", SetInt32Parameter_IsValid);
		SetFloatParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFloatParameter");
		SetFloatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_GraphInstance_PropertyAddress, SetFloatParameter_FunctionAddress, "GraphInstance");
		SetFloatParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "GraphInstance");
		SetFloatParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_Name_PropertyAddress, SetFloatParameter_FunctionAddress, "Name");
		SetFloatParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "Name");
		SetFloatParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_Value_PropertyAddress, SetFloatParameter_FunctionAddress, "Value");
		SetFloatParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "Value");
		SetFloatParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFloatParameter_IsValid = SetFloatParameter_FunctionAddress != IntPtr.Zero && SetFloatParameter_GraphInstance_IsValid && SetFloatParameter_Name_IsValid && SetFloatParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetFloatParameter", SetFloatParameter_IsValid);
		SetEnumParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEnumParameter");
		SetEnumParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnumParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnumParameter_GraphInstance_PropertyAddress, SetEnumParameter_FunctionAddress, "GraphInstance");
		SetEnumParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetEnumParameter_FunctionAddress, "GraphInstance");
		SetEnumParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnumParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnumParameter_Name_PropertyAddress, SetEnumParameter_FunctionAddress, "Name");
		SetEnumParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetEnumParameter_FunctionAddress, "Name");
		SetEnumParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnumParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnumParameter_Enum_PropertyAddress, SetEnumParameter_FunctionAddress, "Enum");
		SetEnumParameter_Enum_Offset = NativeReflectionCached.GetPropertyOffset(SetEnumParameter_FunctionAddress, "Enum");
		SetEnumParameter_Enum_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnumParameter_FunctionAddress, "Enum", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnumParameter_Value_PropertyAddress, SetEnumParameter_FunctionAddress, "Value");
		SetEnumParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetEnumParameter_FunctionAddress, "Value");
		SetEnumParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnumParameter_FunctionAddress, "Value", Classes.FByteProperty);
		SetEnumParameter_IsValid = SetEnumParameter_FunctionAddress != IntPtr.Zero && SetEnumParameter_GraphInstance_IsValid && SetEnumParameter_Name_IsValid && SetEnumParameter_Enum_IsValid && SetEnumParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetEnumParameter", SetEnumParameter_IsValid);
		SetDoubleParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDoubleParameter");
		SetDoubleParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDoubleParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleParameter_GraphInstance_PropertyAddress, SetDoubleParameter_FunctionAddress, "GraphInstance");
		SetDoubleParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleParameter_FunctionAddress, "GraphInstance");
		SetDoubleParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleParameter_Name_PropertyAddress, SetDoubleParameter_FunctionAddress, "Name");
		SetDoubleParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleParameter_FunctionAddress, "Name");
		SetDoubleParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleParameter_Value_PropertyAddress, SetDoubleParameter_FunctionAddress, "Value");
		SetDoubleParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleParameter_FunctionAddress, "Value");
		SetDoubleParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleParameter_FunctionAddress, "Value", Classes.FDoubleProperty);
		SetDoubleParameter_IsValid = SetDoubleParameter_FunctionAddress != IntPtr.Zero && SetDoubleParameter_GraphInstance_IsValid && SetDoubleParameter_Name_IsValid && SetDoubleParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetDoubleParameter", SetDoubleParameter_IsValid);
		SetByteParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetByteParameter");
		SetByteParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetByteParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetByteParameter_GraphInstance_PropertyAddress, SetByteParameter_FunctionAddress, "GraphInstance");
		SetByteParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetByteParameter_FunctionAddress, "GraphInstance");
		SetByteParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetByteParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetByteParameter_Name_PropertyAddress, SetByteParameter_FunctionAddress, "Name");
		SetByteParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetByteParameter_FunctionAddress, "Name");
		SetByteParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetByteParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetByteParameter_Value_PropertyAddress, SetByteParameter_FunctionAddress, "Value");
		SetByteParameter_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetByteParameter_FunctionAddress, "Value");
		SetByteParameter_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetByteParameter_FunctionAddress, "Value", Classes.FByteProperty);
		SetByteParameter_IsValid = SetByteParameter_FunctionAddress != IntPtr.Zero && SetByteParameter_GraphInstance_IsValid && SetByteParameter_Name_IsValid && SetByteParameter_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetByteParameter", SetByteParameter_IsValid);
		SetBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBoolParameter");
		SetBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_GraphInstance_PropertyAddress, SetBoolParameter_FunctionAddress, "GraphInstance");
		SetBoolParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "GraphInstance");
		SetBoolParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_Name_PropertyAddress, SetBoolParameter_FunctionAddress, "Name");
		SetBoolParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "Name");
		SetBoolParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_bValue_PropertyAddress, SetBoolParameter_FunctionAddress, "bValue");
		SetBoolParameter_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "bValue");
		SetBoolParameter_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetBoolParameter_IsValid = SetBoolParameter_FunctionAddress != IntPtr.Zero && SetBoolParameter_GraphInstance_IsValid && SetBoolParameter_Name_IsValid && SetBoolParameter_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:SetBoolParameter", SetBoolParameter_IsValid);
		IsOverridden_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsOverridden");
		IsOverridden_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverridden_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverridden_GraphInstance_PropertyAddress, IsOverridden_FunctionAddress, "GraphInstance");
		IsOverridden_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(IsOverridden_FunctionAddress, "GraphInstance");
		IsOverridden_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverridden_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOverridden_Name_PropertyAddress, IsOverridden_FunctionAddress, "Name");
		IsOverridden_Name_Offset = NativeReflectionCached.GetPropertyOffset(IsOverridden_FunctionAddress, "Name");
		IsOverridden_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverridden_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOverridden_ReturnValue_PropertyAddress, IsOverridden_FunctionAddress, "ReturnValue");
		IsOverridden_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverridden_FunctionAddress, "ReturnValue");
		IsOverridden_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverridden_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverridden_IsValid = IsOverridden_FunctionAddress != IntPtr.Zero && IsOverridden_GraphInstance_IsValid && IsOverridden_Name_IsValid && IsOverridden_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:IsOverridden", IsOverridden_IsValid);
		GetVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorParameter");
		GetVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameter_GraphInstance_PropertyAddress, GetVectorParameter_FunctionAddress, "GraphInstance");
		GetVectorParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameter_FunctionAddress, "GraphInstance");
		GetVectorParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameter_Name_PropertyAddress, GetVectorParameter_FunctionAddress, "Name");
		GetVectorParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameter_FunctionAddress, "Name");
		GetVectorParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameter_ReturnValue_PropertyAddress, GetVectorParameter_FunctionAddress, "ReturnValue");
		GetVectorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameter_FunctionAddress, "ReturnValue");
		GetVectorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameter_IsValid = GetVectorParameter_FunctionAddress != IntPtr.Zero && GetVectorParameter_GraphInstance_IsValid && GetVectorParameter_Name_IsValid && GetVectorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetVectorParameter", GetVectorParameter_IsValid);
		GetTransformParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformParameter");
		GetTransformParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformParameter_GraphInstance_PropertyAddress, GetTransformParameter_FunctionAddress, "GraphInstance");
		GetTransformParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformParameter_FunctionAddress, "GraphInstance");
		GetTransformParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformParameter_Name_PropertyAddress, GetTransformParameter_FunctionAddress, "Name");
		GetTransformParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformParameter_FunctionAddress, "Name");
		GetTransformParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformParameter_ReturnValue_PropertyAddress, GetTransformParameter_FunctionAddress, "ReturnValue");
		GetTransformParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformParameter_FunctionAddress, "ReturnValue");
		GetTransformParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformParameter_IsValid = GetTransformParameter_FunctionAddress != IntPtr.Zero && GetTransformParameter_GraphInstance_IsValid && GetTransformParameter_Name_IsValid && GetTransformParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetTransformParameter", GetTransformParameter_IsValid);
		GetStringParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStringParameter");
		GetStringParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStringParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStringParameter_GraphInstance_PropertyAddress, GetStringParameter_FunctionAddress, "GraphInstance");
		GetStringParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetStringParameter_FunctionAddress, "GraphInstance");
		GetStringParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringParameter_Name_PropertyAddress, GetStringParameter_FunctionAddress, "Name");
		GetStringParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetStringParameter_FunctionAddress, "Name");
		GetStringParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringParameter_ReturnValue_PropertyAddress, GetStringParameter_FunctionAddress, "ReturnValue");
		GetStringParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStringParameter_FunctionAddress, "ReturnValue");
		GetStringParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringParameter_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStringParameter_IsValid = GetStringParameter_FunctionAddress != IntPtr.Zero && GetStringParameter_GraphInstance_IsValid && GetStringParameter_Name_IsValid && GetStringParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetStringParameter", GetStringParameter_IsValid);
		GetSoftObjectParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSoftObjectParameter");
		GetSoftObjectParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftObjectParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSoftObjectParameter_GraphInstance_PropertyAddress, GetSoftObjectParameter_FunctionAddress, "GraphInstance");
		GetSoftObjectParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftObjectParameter_FunctionAddress, "GraphInstance");
		GetSoftObjectParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftObjectParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSoftObjectParameter_Name_PropertyAddress, GetSoftObjectParameter_FunctionAddress, "Name");
		GetSoftObjectParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftObjectParameter_FunctionAddress, "Name");
		GetSoftObjectParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftObjectParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSoftObjectParameter_ReturnValue_PropertyAddress, GetSoftObjectParameter_FunctionAddress, "ReturnValue");
		GetSoftObjectParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftObjectParameter_FunctionAddress, "ReturnValue");
		GetSoftObjectParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftObjectParameter_FunctionAddress, "ReturnValue", Classes.FSoftObjectProperty);
		GetSoftObjectParameter_IsValid = GetSoftObjectParameter_FunctionAddress != IntPtr.Zero && GetSoftObjectParameter_GraphInstance_IsValid && GetSoftObjectParameter_Name_IsValid && GetSoftObjectParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetSoftObjectParameter", GetSoftObjectParameter_IsValid);
		GetSoftClassParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSoftClassParameter");
		GetSoftClassParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftClassParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSoftClassParameter_GraphInstance_PropertyAddress, GetSoftClassParameter_FunctionAddress, "GraphInstance");
		GetSoftClassParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftClassParameter_FunctionAddress, "GraphInstance");
		GetSoftClassParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftClassParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSoftClassParameter_Name_PropertyAddress, GetSoftClassParameter_FunctionAddress, "Name");
		GetSoftClassParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftClassParameter_FunctionAddress, "Name");
		GetSoftClassParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftClassParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSoftClassParameter_ReturnValue_PropertyAddress, GetSoftClassParameter_FunctionAddress, "ReturnValue");
		GetSoftClassParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftClassParameter_FunctionAddress, "ReturnValue");
		GetSoftClassParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftClassParameter_FunctionAddress, "ReturnValue", Classes.FSoftClassProperty);
		GetSoftClassParameter_IsValid = GetSoftClassParameter_FunctionAddress != IntPtr.Zero && GetSoftClassParameter_GraphInstance_IsValid && GetSoftClassParameter_Name_IsValid && GetSoftClassParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetSoftClassParameter", GetSoftClassParameter_IsValid);
		GetRotatorParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRotatorParameter");
		GetRotatorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotatorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorParameter_GraphInstance_PropertyAddress, GetRotatorParameter_FunctionAddress, "GraphInstance");
		GetRotatorParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorParameter_FunctionAddress, "GraphInstance");
		GetRotatorParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorParameter_Name_PropertyAddress, GetRotatorParameter_FunctionAddress, "Name");
		GetRotatorParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorParameter_FunctionAddress, "Name");
		GetRotatorParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorParameter_ReturnValue_PropertyAddress, GetRotatorParameter_FunctionAddress, "ReturnValue");
		GetRotatorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorParameter_FunctionAddress, "ReturnValue");
		GetRotatorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotatorParameter_IsValid = GetRotatorParameter_FunctionAddress != IntPtr.Zero && GetRotatorParameter_GraphInstance_IsValid && GetRotatorParameter_Name_IsValid && GetRotatorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetRotatorParameter", GetRotatorParameter_IsValid);
		GetNameParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNameParameter");
		GetNameParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNameParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNameParameter_GraphInstance_PropertyAddress, GetNameParameter_FunctionAddress, "GraphInstance");
		GetNameParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetNameParameter_FunctionAddress, "GraphInstance");
		GetNameParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNameParameter_Name_PropertyAddress, GetNameParameter_FunctionAddress, "Name");
		GetNameParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetNameParameter_FunctionAddress, "Name");
		GetNameParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNameParameter_ReturnValue_PropertyAddress, GetNameParameter_FunctionAddress, "ReturnValue");
		GetNameParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNameParameter_FunctionAddress, "ReturnValue");
		GetNameParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameParameter_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetNameParameter_IsValid = GetNameParameter_FunctionAddress != IntPtr.Zero && GetNameParameter_GraphInstance_IsValid && GetNameParameter_Name_IsValid && GetNameParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetNameParameter", GetNameParameter_IsValid);
		GetInt64Parameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInt64Parameter");
		GetInt64Parameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt64Parameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInt64Parameter_GraphInstance_PropertyAddress, GetInt64Parameter_FunctionAddress, "GraphInstance");
		GetInt64Parameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64Parameter_FunctionAddress, "GraphInstance");
		GetInt64Parameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64Parameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt64Parameter_Name_PropertyAddress, GetInt64Parameter_FunctionAddress, "Name");
		GetInt64Parameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64Parameter_FunctionAddress, "Name");
		GetInt64Parameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64Parameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt64Parameter_ReturnValue_PropertyAddress, GetInt64Parameter_FunctionAddress, "ReturnValue");
		GetInt64Parameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64Parameter_FunctionAddress, "ReturnValue");
		GetInt64Parameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64Parameter_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetInt64Parameter_IsValid = GetInt64Parameter_FunctionAddress != IntPtr.Zero && GetInt64Parameter_GraphInstance_IsValid && GetInt64Parameter_Name_IsValid && GetInt64Parameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetInt64Parameter", GetInt64Parameter_IsValid);
		GetInt32Parameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInt32Parameter");
		GetInt32Parameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt32Parameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInt32Parameter_GraphInstance_PropertyAddress, GetInt32Parameter_FunctionAddress, "GraphInstance");
		GetInt32Parameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32Parameter_FunctionAddress, "GraphInstance");
		GetInt32Parameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32Parameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32Parameter_Name_PropertyAddress, GetInt32Parameter_FunctionAddress, "Name");
		GetInt32Parameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32Parameter_FunctionAddress, "Name");
		GetInt32Parameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32Parameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32Parameter_ReturnValue_PropertyAddress, GetInt32Parameter_FunctionAddress, "ReturnValue");
		GetInt32Parameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32Parameter_FunctionAddress, "ReturnValue");
		GetInt32Parameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32Parameter_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetInt32Parameter_IsValid = GetInt32Parameter_FunctionAddress != IntPtr.Zero && GetInt32Parameter_GraphInstance_IsValid && GetInt32Parameter_Name_IsValid && GetInt32Parameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetInt32Parameter", GetInt32Parameter_IsValid);
		GetFloatParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloatParameter");
		GetFloatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatParameter_GraphInstance_PropertyAddress, GetFloatParameter_FunctionAddress, "GraphInstance");
		GetFloatParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatParameter_FunctionAddress, "GraphInstance");
		GetFloatParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatParameter_Name_PropertyAddress, GetFloatParameter_FunctionAddress, "Name");
		GetFloatParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatParameter_FunctionAddress, "Name");
		GetFloatParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatParameter_ReturnValue_PropertyAddress, GetFloatParameter_FunctionAddress, "ReturnValue");
		GetFloatParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatParameter_FunctionAddress, "ReturnValue");
		GetFloatParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatParameter_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatParameter_IsValid = GetFloatParameter_FunctionAddress != IntPtr.Zero && GetFloatParameter_GraphInstance_IsValid && GetFloatParameter_Name_IsValid && GetFloatParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetFloatParameter", GetFloatParameter_IsValid);
		GetDoubleParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDoubleParameter");
		GetDoubleParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDoubleParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleParameter_GraphInstance_PropertyAddress, GetDoubleParameter_FunctionAddress, "GraphInstance");
		GetDoubleParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleParameter_FunctionAddress, "GraphInstance");
		GetDoubleParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleParameter_Name_PropertyAddress, GetDoubleParameter_FunctionAddress, "Name");
		GetDoubleParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleParameter_FunctionAddress, "Name");
		GetDoubleParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleParameter_ReturnValue_PropertyAddress, GetDoubleParameter_FunctionAddress, "ReturnValue");
		GetDoubleParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleParameter_FunctionAddress, "ReturnValue");
		GetDoubleParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleParameter_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetDoubleParameter_IsValid = GetDoubleParameter_FunctionAddress != IntPtr.Zero && GetDoubleParameter_GraphInstance_IsValid && GetDoubleParameter_Name_IsValid && GetDoubleParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetDoubleParameter", GetDoubleParameter_IsValid);
		GetByteParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetByteParameter");
		GetByteParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetByteParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetByteParameter_GraphInstance_PropertyAddress, GetByteParameter_FunctionAddress, "GraphInstance");
		GetByteParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetByteParameter_FunctionAddress, "GraphInstance");
		GetByteParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetByteParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetByteParameter_Name_PropertyAddress, GetByteParameter_FunctionAddress, "Name");
		GetByteParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetByteParameter_FunctionAddress, "Name");
		GetByteParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetByteParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetByteParameter_ReturnValue_PropertyAddress, GetByteParameter_FunctionAddress, "ReturnValue");
		GetByteParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetByteParameter_FunctionAddress, "ReturnValue");
		GetByteParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetByteParameter_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetByteParameter_IsValid = GetByteParameter_FunctionAddress != IntPtr.Zero && GetByteParameter_GraphInstance_IsValid && GetByteParameter_Name_IsValid && GetByteParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetByteParameter", GetByteParameter_IsValid);
		GetBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoolParameter");
		GetBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoolParameter_GraphInstance_PropertyAddress, GetBoolParameter_FunctionAddress, "GraphInstance");
		GetBoolParameter_GraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolParameter_FunctionAddress, "GraphInstance");
		GetBoolParameter_GraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolParameter_FunctionAddress, "GraphInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolParameter_Name_PropertyAddress, GetBoolParameter_FunctionAddress, "Name");
		GetBoolParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolParameter_FunctionAddress, "Name");
		GetBoolParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolParameter_ReturnValue_PropertyAddress, GetBoolParameter_FunctionAddress, "ReturnValue");
		GetBoolParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolParameter_FunctionAddress, "ReturnValue");
		GetBoolParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBoolParameter_IsValid = GetBoolParameter_FunctionAddress != IntPtr.Zero && GetBoolParameter_GraphInstance_IsValid && GetBoolParameter_Name_IsValid && GetBoolParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphParametersHelpers:GetBoolParameter", GetBoolParameter_IsValid);
	}
}
