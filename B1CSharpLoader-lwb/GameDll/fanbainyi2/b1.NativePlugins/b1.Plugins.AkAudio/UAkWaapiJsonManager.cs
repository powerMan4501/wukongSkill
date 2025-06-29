using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkWaapiJsonManager", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkWaapiJsonManager : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetStringField_IsValid;

	private static IntPtr SetStringField_FunctionAddress;

	private static int SetStringField_ParamsSize;

	private static bool SetStringField_FieldName_IsValid;

	private static FFieldAddress SetStringField_FieldName_PropertyAddress;

	private static int SetStringField_FieldName_Offset;

	private static bool SetStringField_FieldValue_IsValid;

	private static FFieldAddress SetStringField_FieldValue_PropertyAddress;

	private static int SetStringField_FieldValue_Offset;

	private static bool SetStringField_target_IsValid;

	private static FFieldAddress SetStringField_target_PropertyAddress;

	private static int SetStringField_target_Offset;

	private static bool SetStringField_ReturnValue_IsValid;

	private static FFieldAddress SetStringField_ReturnValue_PropertyAddress;

	private static int SetStringField_ReturnValue_Offset;

	private static bool SetObjectField_IsValid;

	private static IntPtr SetObjectField_FunctionAddress;

	private static int SetObjectField_ParamsSize;

	private static bool SetObjectField_FieldName_IsValid;

	private static FFieldAddress SetObjectField_FieldName_PropertyAddress;

	private static int SetObjectField_FieldName_Offset;

	private static bool SetObjectField_FieldValue_IsValid;

	private static FFieldAddress SetObjectField_FieldValue_PropertyAddress;

	private static int SetObjectField_FieldValue_Offset;

	private static bool SetObjectField_target_IsValid;

	private static FFieldAddress SetObjectField_target_PropertyAddress;

	private static int SetObjectField_target_Offset;

	private static bool SetObjectField_ReturnValue_IsValid;

	private static FFieldAddress SetObjectField_ReturnValue_PropertyAddress;

	private static int SetObjectField_ReturnValue_Offset;

	private static bool SetNumberField_IsValid;

	private static IntPtr SetNumberField_FunctionAddress;

	private static int SetNumberField_ParamsSize;

	private static bool SetNumberField_FieldName_IsValid;

	private static FFieldAddress SetNumberField_FieldName_PropertyAddress;

	private static int SetNumberField_FieldName_Offset;

	private static bool SetNumberField_FieldValue_IsValid;

	private static FFieldAddress SetNumberField_FieldValue_PropertyAddress;

	private static int SetNumberField_FieldValue_Offset;

	private static bool SetNumberField_target_IsValid;

	private static FFieldAddress SetNumberField_target_PropertyAddress;

	private static int SetNumberField_target_Offset;

	private static bool SetNumberField_ReturnValue_IsValid;

	private static FFieldAddress SetNumberField_ReturnValue_PropertyAddress;

	private static int SetNumberField_ReturnValue_Offset;

	private static bool SetBoolField_IsValid;

	private static IntPtr SetBoolField_FunctionAddress;

	private static int SetBoolField_ParamsSize;

	private static bool SetBoolField_FieldName_IsValid;

	private static FFieldAddress SetBoolField_FieldName_PropertyAddress;

	private static int SetBoolField_FieldName_Offset;

	private static bool SetBoolField_FieldValue_IsValid;

	private static FFieldAddress SetBoolField_FieldValue_PropertyAddress;

	private static int SetBoolField_FieldValue_Offset;

	private static bool SetBoolField_target_IsValid;

	private static FFieldAddress SetBoolField_target_PropertyAddress;

	private static int SetBoolField_target_Offset;

	private static bool SetBoolField_ReturnValue_IsValid;

	private static FFieldAddress SetBoolField_ReturnValue_PropertyAddress;

	private static int SetBoolField_ReturnValue_Offset;

	private static bool SetArrayStringFields_IsValid;

	private static IntPtr SetArrayStringFields_FunctionAddress;

	private static int SetArrayStringFields_ParamsSize;

	private static bool SetArrayStringFields_FieldName_IsValid;

	private static FFieldAddress SetArrayStringFields_FieldName_PropertyAddress;

	private static int SetArrayStringFields_FieldName_Offset;

	private static bool SetArrayStringFields_FieldStringValues_IsValid;

	private static FFieldAddress SetArrayStringFields_FieldStringValues_PropertyAddress;

	private static int SetArrayStringFields_FieldStringValues_Offset;

	private static bool SetArrayStringFields_target_IsValid;

	private static FFieldAddress SetArrayStringFields_target_PropertyAddress;

	private static int SetArrayStringFields_target_Offset;

	private static bool SetArrayStringFields_ReturnValue_IsValid;

	private static FFieldAddress SetArrayStringFields_ReturnValue_PropertyAddress;

	private static int SetArrayStringFields_ReturnValue_Offset;

	private static bool SetArrayObjectFields_IsValid;

	private static IntPtr SetArrayObjectFields_FunctionAddress;

	private static int SetArrayObjectFields_ParamsSize;

	private static bool SetArrayObjectFields_FieldName_IsValid;

	private static FFieldAddress SetArrayObjectFields_FieldName_PropertyAddress;

	private static int SetArrayObjectFields_FieldName_Offset;

	private static bool SetArrayObjectFields_FieldObjectValues_IsValid;

	private static FFieldAddress SetArrayObjectFields_FieldObjectValues_PropertyAddress;

	private static int SetArrayObjectFields_FieldObjectValues_Offset;

	private static bool SetArrayObjectFields_target_IsValid;

	private static FFieldAddress SetArrayObjectFields_target_PropertyAddress;

	private static int SetArrayObjectFields_target_Offset;

	private static bool SetArrayObjectFields_ReturnValue_IsValid;

	private static FFieldAddress SetArrayObjectFields_ReturnValue_PropertyAddress;

	private static int SetArrayObjectFields_ReturnValue_Offset;

	private static bool GetStringField_IsValid;

	private static IntPtr GetStringField_FunctionAddress;

	private static int GetStringField_ParamsSize;

	private static bool GetStringField_FieldName_IsValid;

	private static FFieldAddress GetStringField_FieldName_PropertyAddress;

	private static int GetStringField_FieldName_Offset;

	private static bool GetStringField_target_IsValid;

	private static FFieldAddress GetStringField_target_PropertyAddress;

	private static int GetStringField_target_Offset;

	private static bool GetStringField_ReturnValue_IsValid;

	private static FFieldAddress GetStringField_ReturnValue_PropertyAddress;

	private static int GetStringField_ReturnValue_Offset;

	private static bool GetObjectField_IsValid;

	private static IntPtr GetObjectField_FunctionAddress;

	private static int GetObjectField_ParamsSize;

	private static bool GetObjectField_FieldName_IsValid;

	private static FFieldAddress GetObjectField_FieldName_PropertyAddress;

	private static int GetObjectField_FieldName_Offset;

	private static bool GetObjectField_target_IsValid;

	private static FFieldAddress GetObjectField_target_PropertyAddress;

	private static int GetObjectField_target_Offset;

	private static bool GetObjectField_ReturnValue_IsValid;

	private static FFieldAddress GetObjectField_ReturnValue_PropertyAddress;

	private static int GetObjectField_ReturnValue_Offset;

	private static bool GetNumberField_IsValid;

	private static IntPtr GetNumberField_FunctionAddress;

	private static int GetNumberField_ParamsSize;

	private static bool GetNumberField_FieldName_IsValid;

	private static FFieldAddress GetNumberField_FieldName_PropertyAddress;

	private static int GetNumberField_FieldName_Offset;

	private static bool GetNumberField_target_IsValid;

	private static FFieldAddress GetNumberField_target_PropertyAddress;

	private static int GetNumberField_target_Offset;

	private static bool GetNumberField_ReturnValue_IsValid;

	private static FFieldAddress GetNumberField_ReturnValue_PropertyAddress;

	private static int GetNumberField_ReturnValue_Offset;

	private static bool GetIntegerField_IsValid;

	private static IntPtr GetIntegerField_FunctionAddress;

	private static int GetIntegerField_ParamsSize;

	private static bool GetIntegerField_FieldName_IsValid;

	private static FFieldAddress GetIntegerField_FieldName_PropertyAddress;

	private static int GetIntegerField_FieldName_Offset;

	private static bool GetIntegerField_target_IsValid;

	private static FFieldAddress GetIntegerField_target_PropertyAddress;

	private static int GetIntegerField_target_Offset;

	private static bool GetIntegerField_ReturnValue_IsValid;

	private static FFieldAddress GetIntegerField_ReturnValue_PropertyAddress;

	private static int GetIntegerField_ReturnValue_Offset;

	private static bool GetBoolField_IsValid;

	private static IntPtr GetBoolField_FunctionAddress;

	private static int GetBoolField_ParamsSize;

	private static bool GetBoolField_FieldName_IsValid;

	private static FFieldAddress GetBoolField_FieldName_PropertyAddress;

	private static int GetBoolField_FieldName_Offset;

	private static bool GetBoolField_target_IsValid;

	private static FFieldAddress GetBoolField_target_PropertyAddress;

	private static int GetBoolField_target_Offset;

	private static bool GetBoolField_ReturnValue_IsValid;

	private static FFieldAddress GetBoolField_ReturnValue_PropertyAddress;

	private static int GetBoolField_ReturnValue_Offset;

	private static bool GetArrayField_IsValid;

	private static IntPtr GetArrayField_FunctionAddress;

	private static int GetArrayField_ParamsSize;

	private static bool GetArrayField_FieldName_IsValid;

	private static FFieldAddress GetArrayField_FieldName_PropertyAddress;

	private static int GetArrayField_FieldName_Offset;

	private static bool GetArrayField_target_IsValid;

	private static FFieldAddress GetArrayField_target_PropertyAddress;

	private static int GetArrayField_target_Offset;

	private static bool GetArrayField_ReturnValue_IsValid;

	private static FFieldAddress GetArrayField_ReturnValue_PropertyAddress;

	private static int GetArrayField_ReturnValue_Offset;

	private static bool Conv_FAKWaapiJsonObjectToText_IsValid;

	private static IntPtr Conv_FAKWaapiJsonObjectToText_FunctionAddress;

	private static int Conv_FAKWaapiJsonObjectToText_ParamsSize;

	private static bool Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_IsValid;

	private static FFieldAddress Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_PropertyAddress;

	private static int Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_Offset;

	private static bool Conv_FAKWaapiJsonObjectToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAKWaapiJsonObjectToText_ReturnValue_PropertyAddress;

	private static int Conv_FAKWaapiJsonObjectToText_ReturnValue_Offset;

	private static bool Conv_FAKWaapiJsonObjectToString_IsValid;

	private static IntPtr Conv_FAKWaapiJsonObjectToString_FunctionAddress;

	private static int Conv_FAKWaapiJsonObjectToString_ParamsSize;

	private static bool Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_IsValid;

	private static FFieldAddress Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_PropertyAddress;

	private static int Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_Offset;

	private static bool Conv_FAKWaapiJsonObjectToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAKWaapiJsonObjectToString_ReturnValue_PropertyAddress;

	private static int Conv_FAKWaapiJsonObjectToString_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:SetStringField")]
	public unsafe static FAKWaapiJsonObject SetStringField(FAkWaapiFieldNames FieldName, string FieldValue, FAKWaapiJsonObject target)
	{
		if (!SetStringField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:SetStringField");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStringField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStringField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStringField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, SetStringField_FieldName_Offset), 0, SetStringField_FieldName_PropertyAddress.Address, FieldName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStringField_FieldValue_Offset), 0, SetStringField_FieldValue_PropertyAddress.Address, FieldValue);
		NativeReflection.InitializeValue_InContainer(SetStringField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetStringField_target_Offset), 0, SetStringField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStringField_FunctionAddress, intPtr, SetStringField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStringField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetStringField_FieldValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetStringField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SetStringField_ReturnValue_Offset), 0, SetStringField_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetStringField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:SetObjectField")]
	public unsafe static FAKWaapiJsonObject SetObjectField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject FieldValue, FAKWaapiJsonObject target)
	{
		if (!SetObjectField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:SetObjectField");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObjectField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObjectField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetObjectField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, SetObjectField_FieldName_Offset), 0, SetObjectField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(SetObjectField_FieldValue_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetObjectField_FieldValue_Offset), 0, SetObjectField_FieldValue_PropertyAddress.Address, FieldValue);
		NativeReflection.InitializeValue_InContainer(SetObjectField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetObjectField_target_Offset), 0, SetObjectField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetObjectField_FunctionAddress, intPtr, SetObjectField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetObjectField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetObjectField_FieldValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetObjectField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SetObjectField_ReturnValue_Offset), 0, SetObjectField_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetObjectField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:SetNumberField")]
	public unsafe static FAKWaapiJsonObject SetNumberField(FAkWaapiFieldNames FieldName, float FieldValue, FAKWaapiJsonObject target)
	{
		if (!SetNumberField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:SetNumberField");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumberField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumberField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetNumberField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, SetNumberField_FieldName_Offset), 0, SetNumberField_FieldName_PropertyAddress.Address, FieldName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNumberField_FieldValue_Offset), 0, SetNumberField_FieldValue_PropertyAddress.Address, FieldValue);
		NativeReflection.InitializeValue_InContainer(SetNumberField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetNumberField_target_Offset), 0, SetNumberField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNumberField_FunctionAddress, intPtr, SetNumberField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNumberField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetNumberField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SetNumberField_ReturnValue_Offset), 0, SetNumberField_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetNumberField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:SetBoolField")]
	public unsafe static FAKWaapiJsonObject SetBoolField(FAkWaapiFieldNames FieldName, bool FieldValue, FAKWaapiJsonObject target)
	{
		if (!SetBoolField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:SetBoolField");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBoolField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, SetBoolField_FieldName_Offset), 0, SetBoolField_FieldName_PropertyAddress.Address, FieldName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolField_FieldValue_Offset), 0, SetBoolField_FieldValue_PropertyAddress.Address, FieldValue);
		NativeReflection.InitializeValue_InContainer(SetBoolField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetBoolField_target_Offset), 0, SetBoolField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBoolField_FunctionAddress, intPtr, SetBoolField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBoolField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetBoolField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SetBoolField_ReturnValue_Offset), 0, SetBoolField_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetBoolField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:SetArrayStringFields")]
	public unsafe static FAKWaapiJsonObject SetArrayStringFields(FAkWaapiFieldNames FieldName, List<string> FieldStringValues, FAKWaapiJsonObject target)
	{
		if (!SetArrayStringFields_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:SetArrayStringFields");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArrayStringFields_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArrayStringFields_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetArrayStringFields_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, SetArrayStringFields_FieldName_Offset), 0, SetArrayStringFields_FieldName_PropertyAddress.Address, FieldName);
		new TArrayCopyMarshaler<string>(1, SetArrayStringFields_FieldStringValues_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetArrayStringFields_FieldStringValues_Offset), FieldStringValues);
		NativeReflection.InitializeValue_InContainer(SetArrayStringFields_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetArrayStringFields_target_Offset), 0, SetArrayStringFields_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetArrayStringFields_FunctionAddress, intPtr, SetArrayStringFields_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetArrayStringFields_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArrayStringFields_FieldStringValues_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArrayStringFields_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SetArrayStringFields_ReturnValue_Offset), 0, SetArrayStringFields_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetArrayStringFields_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:SetArrayObjectFields")]
	public unsafe static FAKWaapiJsonObject SetArrayObjectFields(FAkWaapiFieldNames FieldName, List<FAKWaapiJsonObject> FieldObjectValues, FAKWaapiJsonObject target)
	{
		if (!SetArrayObjectFields_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:SetArrayObjectFields");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArrayObjectFields_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArrayObjectFields_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetArrayObjectFields_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, SetArrayObjectFields_FieldName_Offset), 0, SetArrayObjectFields_FieldName_PropertyAddress.Address, FieldName);
		new TArrayCopyMarshaler<FAKWaapiJsonObject>(1, SetArrayObjectFields_FieldObjectValues_PropertyAddress, CachedMarshalingDelegates<FAKWaapiJsonObject, FAKWaapiJsonObject>.FromNative, CachedMarshalingDelegates<FAKWaapiJsonObject, FAKWaapiJsonObject>.ToNative).ToNative(IntPtr.Add(intPtr, SetArrayObjectFields_FieldObjectValues_Offset), FieldObjectValues);
		NativeReflection.InitializeValue_InContainer(SetArrayObjectFields_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SetArrayObjectFields_target_Offset), 0, SetArrayObjectFields_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetArrayObjectFields_FunctionAddress, intPtr, SetArrayObjectFields_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetArrayObjectFields_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArrayObjectFields_FieldObjectValues_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArrayObjectFields_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SetArrayObjectFields_ReturnValue_Offset), 0, SetArrayObjectFields_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetArrayObjectFields_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:GetStringField")]
	public unsafe static string GetStringField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
	{
		if (!GetStringField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:GetStringField");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStringField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStringField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetStringField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, GetStringField_FieldName_Offset), 0, GetStringField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(GetStringField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, GetStringField_target_Offset), 0, GetStringField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStringField_FunctionAddress, intPtr, GetStringField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetStringField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetStringField_target_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStringField_ReturnValue_Offset), 0, GetStringField_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStringField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:GetObjectField")]
	public unsafe static FAKWaapiJsonObject GetObjectField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
	{
		if (!GetObjectField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:GetObjectField");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetObjectField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, GetObjectField_FieldName_Offset), 0, GetObjectField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(GetObjectField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, GetObjectField_target_Offset), 0, GetObjectField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjectField_FunctionAddress, intPtr, GetObjectField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetObjectField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetObjectField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, GetObjectField_ReturnValue_Offset), 0, GetObjectField_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetObjectField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:GetNumberField")]
	public unsafe static float GetNumberField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
	{
		if (!GetNumberField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:GetNumberField");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumberField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, GetNumberField_FieldName_Offset), 0, GetNumberField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(GetNumberField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, GetNumberField_target_Offset), 0, GetNumberField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumberField_FunctionAddress, intPtr, GetNumberField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNumberField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetNumberField_target_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNumberField_ReturnValue_Offset), 0, GetNumberField_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:GetIntegerField")]
	public unsafe static int GetIntegerField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
	{
		if (!GetIntegerField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:GetIntegerField");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIntegerField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIntegerField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIntegerField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, GetIntegerField_FieldName_Offset), 0, GetIntegerField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(GetIntegerField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, GetIntegerField_target_Offset), 0, GetIntegerField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIntegerField_FunctionAddress, intPtr, GetIntegerField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIntegerField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetIntegerField_target_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIntegerField_ReturnValue_Offset), 0, GetIntegerField_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:GetBoolField")]
	public unsafe static bool GetBoolField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
	{
		if (!GetBoolField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:GetBoolField");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoolField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoolField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoolField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, GetBoolField_FieldName_Offset), 0, GetBoolField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(GetBoolField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, GetBoolField_target_Offset), 0, GetBoolField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoolField_FunctionAddress, intPtr, GetBoolField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBoolField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetBoolField_target_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBoolField_ReturnValue_Offset), 0, GetBoolField_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:GetArrayField")]
	public unsafe static List<FAKWaapiJsonObject> GetArrayField(FAkWaapiFieldNames FieldName, FAKWaapiJsonObject target)
	{
		if (!GetArrayField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:GetArrayField");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArrayField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArrayField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetArrayField_FieldName_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, GetArrayField_FieldName_Offset), 0, GetArrayField_FieldName_PropertyAddress.Address, FieldName);
		NativeReflection.InitializeValue_InContainer(GetArrayField_target_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, GetArrayField_target_Offset), 0, GetArrayField_target_PropertyAddress.Address, target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetArrayField_FunctionAddress, intPtr, GetArrayField_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetArrayField_FieldName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetArrayField_target_PropertyAddress.Address, intPtr);
		List<FAKWaapiJsonObject> result = new TArrayCopyMarshaler<FAKWaapiJsonObject>(1, GetArrayField_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAKWaapiJsonObject, FAKWaapiJsonObject>.FromNative, CachedMarshalingDelegates<FAKWaapiJsonObject, FAKWaapiJsonObject>.ToNative).FromNative(IntPtr.Add(intPtr, GetArrayField_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetArrayField_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:Conv_FAKWaapiJsonObjectToText")]
	public unsafe static string Conv_FAKWaapiJsonObjectToText(FAKWaapiJsonObject INAKWaapiJsonObject)
	{
		if (!Conv_FAKWaapiJsonObjectToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:Conv_FAKWaapiJsonObjectToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAKWaapiJsonObjectToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAKWaapiJsonObjectToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_Offset), 0, Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_PropertyAddress.Address, INAKWaapiJsonObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAKWaapiJsonObjectToText_FunctionAddress, intPtr, Conv_FAKWaapiJsonObjectToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAKWaapiJsonObjectToText_ReturnValue_Offset), 0, Conv_FAKWaapiJsonObjectToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FAKWaapiJsonObjectToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AkAudio.AkWaapiJsonManager:Conv_FAKWaapiJsonObjectToString")]
	public unsafe static string Conv_FAKWaapiJsonObjectToString(FAKWaapiJsonObject INAKWaapiJsonObject)
	{
		if (!Conv_FAKWaapiJsonObjectToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiJsonManager:Conv_FAKWaapiJsonObjectToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAKWaapiJsonObjectToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAKWaapiJsonObjectToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_Offset), 0, Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_PropertyAddress.Address, INAKWaapiJsonObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAKWaapiJsonObjectToString_FunctionAddress, intPtr, Conv_FAKWaapiJsonObjectToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAKWaapiJsonObjectToString_ReturnValue_Offset), 0, Conv_FAKWaapiJsonObjectToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_FAKWaapiJsonObjectToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAkWaapiJsonManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkWaapiJsonManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkWaapiJsonManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.AkWaapiJsonManager");
		SetStringField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStringField");
		SetStringField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStringField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStringField_FieldName_PropertyAddress, SetStringField_FunctionAddress, "FieldName");
		SetStringField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(SetStringField_FunctionAddress, "FieldName");
		SetStringField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringField_FieldValue_PropertyAddress, SetStringField_FunctionAddress, "FieldValue");
		SetStringField_FieldValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStringField_FunctionAddress, "FieldValue");
		SetStringField_FieldValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringField_FunctionAddress, "FieldValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringField_target_PropertyAddress, SetStringField_FunctionAddress, "target");
		SetStringField_target_Offset = NativeReflectionCached.GetPropertyOffset(SetStringField_FunctionAddress, "target");
		SetStringField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringField_ReturnValue_PropertyAddress, SetStringField_FunctionAddress, "ReturnValue");
		SetStringField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStringField_FunctionAddress, "ReturnValue");
		SetStringField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringField_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetStringField_IsValid = SetStringField_FunctionAddress != IntPtr.Zero && SetStringField_FieldName_IsValid && SetStringField_FieldValue_IsValid && SetStringField_target_IsValid && SetStringField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:SetStringField", SetStringField_IsValid);
		SetObjectField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetObjectField");
		SetObjectField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObjectField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObjectField_FieldName_PropertyAddress, SetObjectField_FunctionAddress, "FieldName");
		SetObjectField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectField_FunctionAddress, "FieldName");
		SetObjectField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjectField_FieldValue_PropertyAddress, SetObjectField_FunctionAddress, "FieldValue");
		SetObjectField_FieldValue_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectField_FunctionAddress, "FieldValue");
		SetObjectField_FieldValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectField_FunctionAddress, "FieldValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjectField_target_PropertyAddress, SetObjectField_FunctionAddress, "target");
		SetObjectField_target_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectField_FunctionAddress, "target");
		SetObjectField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjectField_ReturnValue_PropertyAddress, SetObjectField_FunctionAddress, "ReturnValue");
		SetObjectField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectField_FunctionAddress, "ReturnValue");
		SetObjectField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectField_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetObjectField_IsValid = SetObjectField_FunctionAddress != IntPtr.Zero && SetObjectField_FieldName_IsValid && SetObjectField_FieldValue_IsValid && SetObjectField_target_IsValid && SetObjectField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:SetObjectField", SetObjectField_IsValid);
		SetNumberField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNumberField");
		SetNumberField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumberField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumberField_FieldName_PropertyAddress, SetNumberField_FunctionAddress, "FieldName");
		SetNumberField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(SetNumberField_FunctionAddress, "FieldName");
		SetNumberField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumberField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumberField_FieldValue_PropertyAddress, SetNumberField_FunctionAddress, "FieldValue");
		SetNumberField_FieldValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNumberField_FunctionAddress, "FieldValue");
		SetNumberField_FieldValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumberField_FunctionAddress, "FieldValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumberField_target_PropertyAddress, SetNumberField_FunctionAddress, "target");
		SetNumberField_target_Offset = NativeReflectionCached.GetPropertyOffset(SetNumberField_FunctionAddress, "target");
		SetNumberField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumberField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumberField_ReturnValue_PropertyAddress, SetNumberField_FunctionAddress, "ReturnValue");
		SetNumberField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNumberField_FunctionAddress, "ReturnValue");
		SetNumberField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumberField_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetNumberField_IsValid = SetNumberField_FunctionAddress != IntPtr.Zero && SetNumberField_FieldName_IsValid && SetNumberField_FieldValue_IsValid && SetNumberField_target_IsValid && SetNumberField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:SetNumberField", SetNumberField_IsValid);
		SetBoolField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBoolField");
		SetBoolField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolField_FieldName_PropertyAddress, SetBoolField_FunctionAddress, "FieldName");
		SetBoolField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolField_FunctionAddress, "FieldName");
		SetBoolField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolField_FieldValue_PropertyAddress, SetBoolField_FunctionAddress, "FieldValue");
		SetBoolField_FieldValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolField_FunctionAddress, "FieldValue");
		SetBoolField_FieldValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolField_FunctionAddress, "FieldValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolField_target_PropertyAddress, SetBoolField_FunctionAddress, "target");
		SetBoolField_target_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolField_FunctionAddress, "target");
		SetBoolField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolField_ReturnValue_PropertyAddress, SetBoolField_FunctionAddress, "ReturnValue");
		SetBoolField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolField_FunctionAddress, "ReturnValue");
		SetBoolField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolField_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetBoolField_IsValid = SetBoolField_FunctionAddress != IntPtr.Zero && SetBoolField_FieldName_IsValid && SetBoolField_FieldValue_IsValid && SetBoolField_target_IsValid && SetBoolField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:SetBoolField", SetBoolField_IsValid);
		SetArrayStringFields_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetArrayStringFields");
		SetArrayStringFields_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArrayStringFields_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArrayStringFields_FieldName_PropertyAddress, SetArrayStringFields_FunctionAddress, "FieldName");
		SetArrayStringFields_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayStringFields_FunctionAddress, "FieldName");
		SetArrayStringFields_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayStringFields_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayStringFields_FieldStringValues_PropertyAddress, SetArrayStringFields_FunctionAddress, "FieldStringValues");
		SetArrayStringFields_FieldStringValues_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayStringFields_FunctionAddress, "FieldStringValues");
		SetArrayStringFields_FieldStringValues_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayStringFields_FunctionAddress, "FieldStringValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayStringFields_target_PropertyAddress, SetArrayStringFields_FunctionAddress, "target");
		SetArrayStringFields_target_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayStringFields_FunctionAddress, "target");
		SetArrayStringFields_target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayStringFields_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayStringFields_ReturnValue_PropertyAddress, SetArrayStringFields_FunctionAddress, "ReturnValue");
		SetArrayStringFields_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayStringFields_FunctionAddress, "ReturnValue");
		SetArrayStringFields_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayStringFields_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetArrayStringFields_IsValid = SetArrayStringFields_FunctionAddress != IntPtr.Zero && SetArrayStringFields_FieldName_IsValid && SetArrayStringFields_FieldStringValues_IsValid && SetArrayStringFields_target_IsValid && SetArrayStringFields_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:SetArrayStringFields", SetArrayStringFields_IsValid);
		SetArrayObjectFields_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetArrayObjectFields");
		SetArrayObjectFields_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArrayObjectFields_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArrayObjectFields_FieldName_PropertyAddress, SetArrayObjectFields_FunctionAddress, "FieldName");
		SetArrayObjectFields_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayObjectFields_FunctionAddress, "FieldName");
		SetArrayObjectFields_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayObjectFields_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayObjectFields_FieldObjectValues_PropertyAddress, SetArrayObjectFields_FunctionAddress, "FieldObjectValues");
		SetArrayObjectFields_FieldObjectValues_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayObjectFields_FunctionAddress, "FieldObjectValues");
		SetArrayObjectFields_FieldObjectValues_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayObjectFields_FunctionAddress, "FieldObjectValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayObjectFields_target_PropertyAddress, SetArrayObjectFields_FunctionAddress, "target");
		SetArrayObjectFields_target_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayObjectFields_FunctionAddress, "target");
		SetArrayObjectFields_target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayObjectFields_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayObjectFields_ReturnValue_PropertyAddress, SetArrayObjectFields_FunctionAddress, "ReturnValue");
		SetArrayObjectFields_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayObjectFields_FunctionAddress, "ReturnValue");
		SetArrayObjectFields_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayObjectFields_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetArrayObjectFields_IsValid = SetArrayObjectFields_FunctionAddress != IntPtr.Zero && SetArrayObjectFields_FieldName_IsValid && SetArrayObjectFields_FieldObjectValues_IsValid && SetArrayObjectFields_target_IsValid && SetArrayObjectFields_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:SetArrayObjectFields", SetArrayObjectFields_IsValid);
		GetStringField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStringField");
		GetStringField_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStringField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStringField_FieldName_PropertyAddress, GetStringField_FunctionAddress, "FieldName");
		GetStringField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(GetStringField_FunctionAddress, "FieldName");
		GetStringField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringField_target_PropertyAddress, GetStringField_FunctionAddress, "target");
		GetStringField_target_Offset = NativeReflectionCached.GetPropertyOffset(GetStringField_FunctionAddress, "target");
		GetStringField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringField_ReturnValue_PropertyAddress, GetStringField_FunctionAddress, "ReturnValue");
		GetStringField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStringField_FunctionAddress, "ReturnValue");
		GetStringField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringField_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStringField_IsValid = GetStringField_FunctionAddress != IntPtr.Zero && GetStringField_FieldName_IsValid && GetStringField_target_IsValid && GetStringField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:GetStringField", GetStringField_IsValid);
		GetObjectField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjectField");
		GetObjectField_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectField_FieldName_PropertyAddress, GetObjectField_FunctionAddress, "FieldName");
		GetObjectField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectField_FunctionAddress, "FieldName");
		GetObjectField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectField_target_PropertyAddress, GetObjectField_FunctionAddress, "target");
		GetObjectField_target_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectField_FunctionAddress, "target");
		GetObjectField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectField_ReturnValue_PropertyAddress, GetObjectField_FunctionAddress, "ReturnValue");
		GetObjectField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectField_FunctionAddress, "ReturnValue");
		GetObjectField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectField_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetObjectField_IsValid = GetObjectField_FunctionAddress != IntPtr.Zero && GetObjectField_FieldName_IsValid && GetObjectField_target_IsValid && GetObjectField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:GetObjectField", GetObjectField_IsValid);
		GetNumberField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumberField");
		GetNumberField_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberField_FieldName_PropertyAddress, GetNumberField_FunctionAddress, "FieldName");
		GetNumberField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberField_FunctionAddress, "FieldName");
		GetNumberField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberField_target_PropertyAddress, GetNumberField_FunctionAddress, "target");
		GetNumberField_target_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberField_FunctionAddress, "target");
		GetNumberField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberField_ReturnValue_PropertyAddress, GetNumberField_FunctionAddress, "ReturnValue");
		GetNumberField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberField_FunctionAddress, "ReturnValue");
		GetNumberField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberField_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNumberField_IsValid = GetNumberField_FunctionAddress != IntPtr.Zero && GetNumberField_FieldName_IsValid && GetNumberField_target_IsValid && GetNumberField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:GetNumberField", GetNumberField_IsValid);
		GetIntegerField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIntegerField");
		GetIntegerField_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIntegerField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIntegerField_FieldName_PropertyAddress, GetIntegerField_FunctionAddress, "FieldName");
		GetIntegerField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(GetIntegerField_FunctionAddress, "FieldName");
		GetIntegerField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntegerField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIntegerField_target_PropertyAddress, GetIntegerField_FunctionAddress, "target");
		GetIntegerField_target_Offset = NativeReflectionCached.GetPropertyOffset(GetIntegerField_FunctionAddress, "target");
		GetIntegerField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntegerField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIntegerField_ReturnValue_PropertyAddress, GetIntegerField_FunctionAddress, "ReturnValue");
		GetIntegerField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIntegerField_FunctionAddress, "ReturnValue");
		GetIntegerField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntegerField_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIntegerField_IsValid = GetIntegerField_FunctionAddress != IntPtr.Zero && GetIntegerField_FieldName_IsValid && GetIntegerField_target_IsValid && GetIntegerField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:GetIntegerField", GetIntegerField_IsValid);
		GetBoolField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoolField");
		GetBoolField_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoolField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoolField_FieldName_PropertyAddress, GetBoolField_FunctionAddress, "FieldName");
		GetBoolField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolField_FunctionAddress, "FieldName");
		GetBoolField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolField_target_PropertyAddress, GetBoolField_FunctionAddress, "target");
		GetBoolField_target_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolField_FunctionAddress, "target");
		GetBoolField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolField_ReturnValue_PropertyAddress, GetBoolField_FunctionAddress, "ReturnValue");
		GetBoolField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolField_FunctionAddress, "ReturnValue");
		GetBoolField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolField_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBoolField_IsValid = GetBoolField_FunctionAddress != IntPtr.Zero && GetBoolField_FieldName_IsValid && GetBoolField_target_IsValid && GetBoolField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:GetBoolField", GetBoolField_IsValid);
		GetArrayField_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetArrayField");
		GetArrayField_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArrayField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArrayField_FieldName_PropertyAddress, GetArrayField_FunctionAddress, "FieldName");
		GetArrayField_FieldName_Offset = NativeReflectionCached.GetPropertyOffset(GetArrayField_FunctionAddress, "FieldName");
		GetArrayField_FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArrayField_FunctionAddress, "FieldName", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArrayField_target_PropertyAddress, GetArrayField_FunctionAddress, "target");
		GetArrayField_target_Offset = NativeReflectionCached.GetPropertyOffset(GetArrayField_FunctionAddress, "target");
		GetArrayField_target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArrayField_FunctionAddress, "target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArrayField_ReturnValue_PropertyAddress, GetArrayField_FunctionAddress, "ReturnValue");
		GetArrayField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArrayField_FunctionAddress, "ReturnValue");
		GetArrayField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArrayField_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetArrayField_IsValid = GetArrayField_FunctionAddress != IntPtr.Zero && GetArrayField_FieldName_IsValid && GetArrayField_target_IsValid && GetArrayField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:GetArrayField", GetArrayField_IsValid);
		Conv_FAKWaapiJsonObjectToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAKWaapiJsonObjectToText");
		Conv_FAKWaapiJsonObjectToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAKWaapiJsonObjectToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_PropertyAddress, Conv_FAKWaapiJsonObjectToText_FunctionAddress, "INAKWaapiJsonObject");
		Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAKWaapiJsonObjectToText_FunctionAddress, "INAKWaapiJsonObject");
		Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAKWaapiJsonObjectToText_FunctionAddress, "INAKWaapiJsonObject", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAKWaapiJsonObjectToText_ReturnValue_PropertyAddress, Conv_FAKWaapiJsonObjectToText_FunctionAddress, "ReturnValue");
		Conv_FAKWaapiJsonObjectToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAKWaapiJsonObjectToText_FunctionAddress, "ReturnValue");
		Conv_FAKWaapiJsonObjectToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAKWaapiJsonObjectToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FAKWaapiJsonObjectToText_IsValid = Conv_FAKWaapiJsonObjectToText_FunctionAddress != IntPtr.Zero && Conv_FAKWaapiJsonObjectToText_INAKWaapiJsonObject_IsValid && Conv_FAKWaapiJsonObjectToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:Conv_FAKWaapiJsonObjectToText", Conv_FAKWaapiJsonObjectToText_IsValid);
		Conv_FAKWaapiJsonObjectToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAKWaapiJsonObjectToString");
		Conv_FAKWaapiJsonObjectToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAKWaapiJsonObjectToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_PropertyAddress, Conv_FAKWaapiJsonObjectToString_FunctionAddress, "INAKWaapiJsonObject");
		Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAKWaapiJsonObjectToString_FunctionAddress, "INAKWaapiJsonObject");
		Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAKWaapiJsonObjectToString_FunctionAddress, "INAKWaapiJsonObject", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAKWaapiJsonObjectToString_ReturnValue_PropertyAddress, Conv_FAKWaapiJsonObjectToString_FunctionAddress, "ReturnValue");
		Conv_FAKWaapiJsonObjectToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAKWaapiJsonObjectToString_FunctionAddress, "ReturnValue");
		Conv_FAKWaapiJsonObjectToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAKWaapiJsonObjectToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_FAKWaapiJsonObjectToString_IsValid = Conv_FAKWaapiJsonObjectToString_FunctionAddress != IntPtr.Zero && Conv_FAKWaapiJsonObjectToString_INAKWaapiJsonObject_IsValid && Conv_FAKWaapiJsonObjectToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiJsonManager:Conv_FAKWaapiJsonObjectToString", Conv_FAKWaapiJsonObjectToString_IsValid);
	}
}
