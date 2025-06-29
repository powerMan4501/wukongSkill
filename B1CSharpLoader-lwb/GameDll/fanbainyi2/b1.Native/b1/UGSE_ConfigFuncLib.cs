using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_ConfigFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVector4_IsValid;

	private static IntPtr SetVector4_FunctionAddress;

	private static int SetVector4_ParamsSize;

	private static bool SetVector4_ConfigFile_IsValid;

	private static FFieldAddress SetVector4_ConfigFile_PropertyAddress;

	private static int SetVector4_ConfigFile_Offset;

	private static bool SetVector4_SectionName_IsValid;

	private static FFieldAddress SetVector4_SectionName_PropertyAddress;

	private static int SetVector4_SectionName_Offset;

	private static bool SetVector4_PropertyName_IsValid;

	private static FFieldAddress SetVector4_PropertyName_PropertyAddress;

	private static int SetVector4_PropertyName_Offset;

	private static bool SetVector4_Vector4Value_IsValid;

	private static FFieldAddress SetVector4_Vector4Value_PropertyAddress;

	private static int SetVector4_Vector4Value_Offset;

	private static bool SetVector2D_IsValid;

	private static IntPtr SetVector2D_FunctionAddress;

	private static int SetVector2D_ParamsSize;

	private static bool SetVector2D_ConfigFile_IsValid;

	private static FFieldAddress SetVector2D_ConfigFile_PropertyAddress;

	private static int SetVector2D_ConfigFile_Offset;

	private static bool SetVector2D_SectionName_IsValid;

	private static FFieldAddress SetVector2D_SectionName_PropertyAddress;

	private static int SetVector2D_SectionName_Offset;

	private static bool SetVector2D_PropertyName_IsValid;

	private static FFieldAddress SetVector2D_PropertyName_PropertyAddress;

	private static int SetVector2D_PropertyName_Offset;

	private static bool SetVector2D_Vector2DValue_IsValid;

	private static FFieldAddress SetVector2D_Vector2DValue_PropertyAddress;

	private static int SetVector2D_Vector2DValue_Offset;

	private static bool SetVector_IsValid;

	private static IntPtr SetVector_FunctionAddress;

	private static int SetVector_ParamsSize;

	private static bool SetVector_ConfigFile_IsValid;

	private static FFieldAddress SetVector_ConfigFile_PropertyAddress;

	private static int SetVector_ConfigFile_Offset;

	private static bool SetVector_SectionName_IsValid;

	private static FFieldAddress SetVector_SectionName_PropertyAddress;

	private static int SetVector_SectionName_Offset;

	private static bool SetVector_PropertyName_IsValid;

	private static FFieldAddress SetVector_PropertyName_PropertyAddress;

	private static int SetVector_PropertyName_Offset;

	private static bool SetVector_VectorValue_IsValid;

	private static FFieldAddress SetVector_VectorValue_PropertyAddress;

	private static int SetVector_VectorValue_Offset;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_ConfigFile_IsValid;

	private static FFieldAddress SetText_ConfigFile_PropertyAddress;

	private static int SetText_ConfigFile_Offset;

	private static bool SetText_SectionName_IsValid;

	private static FFieldAddress SetText_SectionName_PropertyAddress;

	private static int SetText_SectionName_Offset;

	private static bool SetText_PropertyName_IsValid;

	private static FFieldAddress SetText_PropertyName_PropertyAddress;

	private static int SetText_PropertyName_Offset;

	private static bool SetText_TextValue_IsValid;

	private static FFieldAddress SetText_TextValue_PropertyAddress;

	private static int SetText_TextValue_Offset;

	private static bool SetString_IsValid;

	private static IntPtr SetString_FunctionAddress;

	private static int SetString_ParamsSize;

	private static bool SetString_ConfigFile_IsValid;

	private static FFieldAddress SetString_ConfigFile_PropertyAddress;

	private static int SetString_ConfigFile_Offset;

	private static bool SetString_SectionName_IsValid;

	private static FFieldAddress SetString_SectionName_PropertyAddress;

	private static int SetString_SectionName_Offset;

	private static bool SetString_PropertyName_IsValid;

	private static FFieldAddress SetString_PropertyName_PropertyAddress;

	private static int SetString_PropertyName_Offset;

	private static bool SetString_StringValue_IsValid;

	private static FFieldAddress SetString_StringValue_PropertyAddress;

	private static int SetString_StringValue_Offset;

	private static bool SetRotator_IsValid;

	private static IntPtr SetRotator_FunctionAddress;

	private static int SetRotator_ParamsSize;

	private static bool SetRotator_ConfigFile_IsValid;

	private static FFieldAddress SetRotator_ConfigFile_PropertyAddress;

	private static int SetRotator_ConfigFile_Offset;

	private static bool SetRotator_SectionName_IsValid;

	private static FFieldAddress SetRotator_SectionName_PropertyAddress;

	private static int SetRotator_SectionName_Offset;

	private static bool SetRotator_PropertyName_IsValid;

	private static FFieldAddress SetRotator_PropertyName_PropertyAddress;

	private static int SetRotator_PropertyName_Offset;

	private static bool SetRotator_RotatorValue_IsValid;

	private static FFieldAddress SetRotator_RotatorValue_PropertyAddress;

	private static int SetRotator_RotatorValue_Offset;

	private static bool SetInt_IsValid;

	private static IntPtr SetInt_FunctionAddress;

	private static int SetInt_ParamsSize;

	private static bool SetInt_ConfigFile_IsValid;

	private static FFieldAddress SetInt_ConfigFile_PropertyAddress;

	private static int SetInt_ConfigFile_Offset;

	private static bool SetInt_SectionName_IsValid;

	private static FFieldAddress SetInt_SectionName_PropertyAddress;

	private static int SetInt_SectionName_Offset;

	private static bool SetInt_PropertyName_IsValid;

	private static FFieldAddress SetInt_PropertyName_PropertyAddress;

	private static int SetInt_PropertyName_Offset;

	private static bool SetInt_IntValue_IsValid;

	private static FFieldAddress SetInt_IntValue_PropertyAddress;

	private static int SetInt_IntValue_Offset;

	private static bool SetFloat_IsValid;

	private static IntPtr SetFloat_FunctionAddress;

	private static int SetFloat_ParamsSize;

	private static bool SetFloat_ConfigFile_IsValid;

	private static FFieldAddress SetFloat_ConfigFile_PropertyAddress;

	private static int SetFloat_ConfigFile_Offset;

	private static bool SetFloat_SectionName_IsValid;

	private static FFieldAddress SetFloat_SectionName_PropertyAddress;

	private static int SetFloat_SectionName_Offset;

	private static bool SetFloat_PropertyName_IsValid;

	private static FFieldAddress SetFloat_PropertyName_PropertyAddress;

	private static int SetFloat_PropertyName_Offset;

	private static bool SetFloat_FloatValue_IsValid;

	private static FFieldAddress SetFloat_FloatValue_PropertyAddress;

	private static int SetFloat_FloatValue_Offset;

	private static bool SetColor_IsValid;

	private static IntPtr SetColor_FunctionAddress;

	private static int SetColor_ParamsSize;

	private static bool SetColor_ConfigFile_IsValid;

	private static FFieldAddress SetColor_ConfigFile_PropertyAddress;

	private static int SetColor_ConfigFile_Offset;

	private static bool SetColor_SectionName_IsValid;

	private static FFieldAddress SetColor_SectionName_PropertyAddress;

	private static int SetColor_SectionName_Offset;

	private static bool SetColor_PropertyName_IsValid;

	private static FFieldAddress SetColor_PropertyName_PropertyAddress;

	private static int SetColor_PropertyName_Offset;

	private static bool SetColor_ColorValue_IsValid;

	private static FFieldAddress SetColor_ColorValue_PropertyAddress;

	private static int SetColor_ColorValue_Offset;

	private static bool SetBool_IsValid;

	private static IntPtr SetBool_FunctionAddress;

	private static int SetBool_ParamsSize;

	private static bool SetBool_ConfigFile_IsValid;

	private static FFieldAddress SetBool_ConfigFile_PropertyAddress;

	private static int SetBool_ConfigFile_Offset;

	private static bool SetBool_SectionName_IsValid;

	private static FFieldAddress SetBool_SectionName_PropertyAddress;

	private static int SetBool_SectionName_Offset;

	private static bool SetBool_PropertyName_IsValid;

	private static FFieldAddress SetBool_PropertyName_PropertyAddress;

	private static int SetBool_PropertyName_Offset;

	private static bool SetBool_BoolValue_IsValid;

	private static FFieldAddress SetBool_BoolValue_PropertyAddress;

	private static int SetBool_BoolValue_Offset;

	private static bool SetArray_IsValid;

	private static IntPtr SetArray_FunctionAddress;

	private static int SetArray_ParamsSize;

	private static bool SetArray_ConfigFile_IsValid;

	private static FFieldAddress SetArray_ConfigFile_PropertyAddress;

	private static int SetArray_ConfigFile_Offset;

	private static bool SetArray_SectionName_IsValid;

	private static FFieldAddress SetArray_SectionName_PropertyAddress;

	private static int SetArray_SectionName_Offset;

	private static bool SetArray_PropertyName_IsValid;

	private static FFieldAddress SetArray_PropertyName_PropertyAddress;

	private static int SetArray_PropertyName_Offset;

	private static bool SetArray_ArrayValue_IsValid;

	private static FFieldAddress SetArray_ArrayValue_PropertyAddress;

	private static int SetArray_ArrayValue_Offset;

	private static bool GetVector4_IsValid;

	private static IntPtr GetVector4_FunctionAddress;

	private static int GetVector4_ParamsSize;

	private static bool GetVector4_ConfigFile_IsValid;

	private static FFieldAddress GetVector4_ConfigFile_PropertyAddress;

	private static int GetVector4_ConfigFile_Offset;

	private static bool GetVector4_SectionName_IsValid;

	private static FFieldAddress GetVector4_SectionName_PropertyAddress;

	private static int GetVector4_SectionName_Offset;

	private static bool GetVector4_PropertyName_IsValid;

	private static FFieldAddress GetVector4_PropertyName_PropertyAddress;

	private static int GetVector4_PropertyName_Offset;

	private static bool GetVector4_bWasFound_IsValid;

	private static FFieldAddress GetVector4_bWasFound_PropertyAddress;

	private static int GetVector4_bWasFound_Offset;

	private static bool GetVector4_ReturnValue_IsValid;

	private static FFieldAddress GetVector4_ReturnValue_PropertyAddress;

	private static int GetVector4_ReturnValue_Offset;

	private static bool GetVector2D_IsValid;

	private static IntPtr GetVector2D_FunctionAddress;

	private static int GetVector2D_ParamsSize;

	private static bool GetVector2D_ConfigFile_IsValid;

	private static FFieldAddress GetVector2D_ConfigFile_PropertyAddress;

	private static int GetVector2D_ConfigFile_Offset;

	private static bool GetVector2D_SectionName_IsValid;

	private static FFieldAddress GetVector2D_SectionName_PropertyAddress;

	private static int GetVector2D_SectionName_Offset;

	private static bool GetVector2D_PropertyName_IsValid;

	private static FFieldAddress GetVector2D_PropertyName_PropertyAddress;

	private static int GetVector2D_PropertyName_Offset;

	private static bool GetVector2D_bWasFound_IsValid;

	private static FFieldAddress GetVector2D_bWasFound_PropertyAddress;

	private static int GetVector2D_bWasFound_Offset;

	private static bool GetVector2D_ReturnValue_IsValid;

	private static FFieldAddress GetVector2D_ReturnValue_PropertyAddress;

	private static int GetVector2D_ReturnValue_Offset;

	private static bool GetVector_IsValid;

	private static IntPtr GetVector_FunctionAddress;

	private static int GetVector_ParamsSize;

	private static bool GetVector_ConfigFile_IsValid;

	private static FFieldAddress GetVector_ConfigFile_PropertyAddress;

	private static int GetVector_ConfigFile_Offset;

	private static bool GetVector_SectionName_IsValid;

	private static FFieldAddress GetVector_SectionName_PropertyAddress;

	private static int GetVector_SectionName_Offset;

	private static bool GetVector_PropertyName_IsValid;

	private static FFieldAddress GetVector_PropertyName_PropertyAddress;

	private static int GetVector_PropertyName_Offset;

	private static bool GetVector_bWasFound_IsValid;

	private static FFieldAddress GetVector_bWasFound_PropertyAddress;

	private static int GetVector_bWasFound_Offset;

	private static bool GetVector_ReturnValue_IsValid;

	private static FFieldAddress GetVector_ReturnValue_PropertyAddress;

	private static int GetVector_ReturnValue_Offset;

	private static bool GetText_IsValid;

	private static IntPtr GetText_FunctionAddress;

	private static int GetText_ParamsSize;

	private static bool GetText_ConfigFile_IsValid;

	private static FFieldAddress GetText_ConfigFile_PropertyAddress;

	private static int GetText_ConfigFile_Offset;

	private static bool GetText_SectionName_IsValid;

	private static FFieldAddress GetText_SectionName_PropertyAddress;

	private static int GetText_SectionName_Offset;

	private static bool GetText_PropertyName_IsValid;

	private static FFieldAddress GetText_PropertyName_PropertyAddress;

	private static int GetText_PropertyName_Offset;

	private static bool GetText_bWasFound_IsValid;

	private static FFieldAddress GetText_bWasFound_PropertyAddress;

	private static int GetText_bWasFound_Offset;

	private static bool GetText_ReturnValue_IsValid;

	private static FFieldAddress GetText_ReturnValue_PropertyAddress;

	private static int GetText_ReturnValue_Offset;

	private static bool GetString_IsValid;

	private static IntPtr GetString_FunctionAddress;

	private static int GetString_ParamsSize;

	private static bool GetString_ConfigFile_IsValid;

	private static FFieldAddress GetString_ConfigFile_PropertyAddress;

	private static int GetString_ConfigFile_Offset;

	private static bool GetString_SectionName_IsValid;

	private static FFieldAddress GetString_SectionName_PropertyAddress;

	private static int GetString_SectionName_Offset;

	private static bool GetString_PropertyName_IsValid;

	private static FFieldAddress GetString_PropertyName_PropertyAddress;

	private static int GetString_PropertyName_Offset;

	private static bool GetString_bWasFound_IsValid;

	private static FFieldAddress GetString_bWasFound_PropertyAddress;

	private static int GetString_bWasFound_Offset;

	private static bool GetString_ReturnValue_IsValid;

	private static FFieldAddress GetString_ReturnValue_PropertyAddress;

	private static int GetString_ReturnValue_Offset;

	private static bool GetRotator_IsValid;

	private static IntPtr GetRotator_FunctionAddress;

	private static int GetRotator_ParamsSize;

	private static bool GetRotator_ConfigFile_IsValid;

	private static FFieldAddress GetRotator_ConfigFile_PropertyAddress;

	private static int GetRotator_ConfigFile_Offset;

	private static bool GetRotator_SectionName_IsValid;

	private static FFieldAddress GetRotator_SectionName_PropertyAddress;

	private static int GetRotator_SectionName_Offset;

	private static bool GetRotator_PropertyName_IsValid;

	private static FFieldAddress GetRotator_PropertyName_PropertyAddress;

	private static int GetRotator_PropertyName_Offset;

	private static bool GetRotator_bWasFound_IsValid;

	private static FFieldAddress GetRotator_bWasFound_PropertyAddress;

	private static int GetRotator_bWasFound_Offset;

	private static bool GetRotator_ReturnValue_IsValid;

	private static FFieldAddress GetRotator_ReturnValue_PropertyAddress;

	private static int GetRotator_ReturnValue_Offset;

	private static bool GetInt_IsValid;

	private static IntPtr GetInt_FunctionAddress;

	private static int GetInt_ParamsSize;

	private static bool GetInt_ConfigFile_IsValid;

	private static FFieldAddress GetInt_ConfigFile_PropertyAddress;

	private static int GetInt_ConfigFile_Offset;

	private static bool GetInt_SectionName_IsValid;

	private static FFieldAddress GetInt_SectionName_PropertyAddress;

	private static int GetInt_SectionName_Offset;

	private static bool GetInt_PropertyName_IsValid;

	private static FFieldAddress GetInt_PropertyName_PropertyAddress;

	private static int GetInt_PropertyName_Offset;

	private static bool GetInt_bWasFound_IsValid;

	private static FFieldAddress GetInt_bWasFound_PropertyAddress;

	private static int GetInt_bWasFound_Offset;

	private static bool GetInt_ReturnValue_IsValid;

	private static FFieldAddress GetInt_ReturnValue_PropertyAddress;

	private static int GetInt_ReturnValue_Offset;

	private static bool GetFloat_IsValid;

	private static IntPtr GetFloat_FunctionAddress;

	private static int GetFloat_ParamsSize;

	private static bool GetFloat_ConfigFile_IsValid;

	private static FFieldAddress GetFloat_ConfigFile_PropertyAddress;

	private static int GetFloat_ConfigFile_Offset;

	private static bool GetFloat_SectionName_IsValid;

	private static FFieldAddress GetFloat_SectionName_PropertyAddress;

	private static int GetFloat_SectionName_Offset;

	private static bool GetFloat_PropertyName_IsValid;

	private static FFieldAddress GetFloat_PropertyName_PropertyAddress;

	private static int GetFloat_PropertyName_Offset;

	private static bool GetFloat_bWasFound_IsValid;

	private static FFieldAddress GetFloat_bWasFound_PropertyAddress;

	private static int GetFloat_bWasFound_Offset;

	private static bool GetFloat_ReturnValue_IsValid;

	private static FFieldAddress GetFloat_ReturnValue_PropertyAddress;

	private static int GetFloat_ReturnValue_Offset;

	private static bool GetColor_IsValid;

	private static IntPtr GetColor_FunctionAddress;

	private static int GetColor_ParamsSize;

	private static bool GetColor_ConfigFile_IsValid;

	private static FFieldAddress GetColor_ConfigFile_PropertyAddress;

	private static int GetColor_ConfigFile_Offset;

	private static bool GetColor_SectionName_IsValid;

	private static FFieldAddress GetColor_SectionName_PropertyAddress;

	private static int GetColor_SectionName_Offset;

	private static bool GetColor_PropertyName_IsValid;

	private static FFieldAddress GetColor_PropertyName_PropertyAddress;

	private static int GetColor_PropertyName_Offset;

	private static bool GetColor_bWasFound_IsValid;

	private static FFieldAddress GetColor_bWasFound_PropertyAddress;

	private static int GetColor_bWasFound_Offset;

	private static bool GetColor_ReturnValue_IsValid;

	private static FFieldAddress GetColor_ReturnValue_PropertyAddress;

	private static int GetColor_ReturnValue_Offset;

	private static bool GetBool_IsValid;

	private static IntPtr GetBool_FunctionAddress;

	private static int GetBool_ParamsSize;

	private static bool GetBool_ConfigFile_IsValid;

	private static FFieldAddress GetBool_ConfigFile_PropertyAddress;

	private static int GetBool_ConfigFile_Offset;

	private static bool GetBool_SectionName_IsValid;

	private static FFieldAddress GetBool_SectionName_PropertyAddress;

	private static int GetBool_SectionName_Offset;

	private static bool GetBool_PropertyName_IsValid;

	private static FFieldAddress GetBool_PropertyName_PropertyAddress;

	private static int GetBool_PropertyName_Offset;

	private static bool GetBool_bWasFound_IsValid;

	private static FFieldAddress GetBool_bWasFound_PropertyAddress;

	private static int GetBool_bWasFound_Offset;

	private static bool GetBool_ReturnValue_IsValid;

	private static FFieldAddress GetBool_ReturnValue_PropertyAddress;

	private static int GetBool_ReturnValue_Offset;

	private static bool GetArray_IsValid;

	private static IntPtr GetArray_FunctionAddress;

	private static int GetArray_ParamsSize;

	private static bool GetArray_ConfigFile_IsValid;

	private static FFieldAddress GetArray_ConfigFile_PropertyAddress;

	private static int GetArray_ConfigFile_Offset;

	private static bool GetArray_SectionName_IsValid;

	private static FFieldAddress GetArray_SectionName_PropertyAddress;

	private static int GetArray_SectionName_Offset;

	private static bool GetArray_PropertyName_IsValid;

	private static FFieldAddress GetArray_PropertyName_PropertyAddress;

	private static int GetArray_PropertyName_Offset;

	private static bool GetArray_bWasFound_IsValid;

	private static FFieldAddress GetArray_bWasFound_PropertyAddress;

	private static int GetArray_bWasFound_Offset;

	private static bool GetArray_ReturnValue_IsValid;

	private static FFieldAddress GetArray_ReturnValue_PropertyAddress;

	private static int GetArray_ReturnValue_Offset;

	private static bool Flush_IsValid;

	private static IntPtr Flush_FunctionAddress;

	private static int Flush_ParamsSize;

	private static bool Flush_ConfigFile_IsValid;

	private static FFieldAddress Flush_ConfigFile_PropertyAddress;

	private static int Flush_ConfigFile_Offset;

	private static bool Flush_bRefreshInConfigSystem_IsValid;

	private static FFieldAddress Flush_bRefreshInConfigSystem_PropertyAddress;

	private static int Flush_bRefreshInConfigSystem_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector4")]
	public unsafe static void SetVector4(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, FVector4 Vector4Value)
	{
		if (!SetVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetVector4_ConfigFile_Offset), 0, SetVector4_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector4_SectionName_Offset), 0, SetVector4_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector4_PropertyName_Offset), 0, SetVector4_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVector4_Vector4Value_Offset), 0, SetVector4_Vector4Value_PropertyAddress.Address, Vector4Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector4_FunctionAddress, intPtr, SetVector4_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVector4_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetVector4_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector2D")]
	public unsafe static void SetVector2D(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, FVector2D Vector2DValue)
	{
		if (!SetVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetVector2D_ConfigFile_Offset), 0, SetVector2D_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector2D_SectionName_Offset), 0, SetVector2D_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector2D_PropertyName_Offset), 0, SetVector2D_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVector2D_Vector2DValue_Offset), 0, SetVector2D_Vector2DValue_PropertyAddress.Address, Vector2DValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector2D_FunctionAddress, intPtr, SetVector2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVector2D_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetVector2D_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector")]
	public unsafe static void SetVector(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, FVector VectorValue)
	{
		if (!SetVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetVector_ConfigFile_Offset), 0, SetVector_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector_SectionName_Offset), 0, SetVector_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector_PropertyName_Offset), 0, SetVector_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVector_VectorValue_Offset), 0, SetVector_VectorValue_PropertyAddress.Address, VectorValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector_FunctionAddress, intPtr, SetVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVector_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetVector_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetText")]
	public unsafe static void SetText(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, FText TextValue)
	{
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetText_ConfigFile_Offset), 0, SetText_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetText_SectionName_Offset), 0, SetText_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetText_PropertyName_Offset), 0, SetText_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(SetText_TextValue_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetText_TextValue_Offset), 0, SetText_TextValue_PropertyAddress.Address, TextValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetText_FunctionAddress, intPtr, SetText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetText_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetText_PropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetText_TextValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetString")]
	public unsafe static void SetString(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, string StringValue)
	{
		if (!SetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetString_ConfigFile_Offset), 0, SetString_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetString_SectionName_Offset), 0, SetString_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetString_PropertyName_Offset), 0, SetString_PropertyName_PropertyAddress.Address, PropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetString_StringValue_Offset), 0, SetString_StringValue_PropertyAddress.Address, StringValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetString_FunctionAddress, intPtr, SetString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetString_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetString_PropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetString_StringValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetRotator")]
	public unsafe static void SetRotator(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, FRotator RotatorValue)
	{
		if (!SetRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetRotator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetRotator_ConfigFile_Offset), 0, SetRotator_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetRotator_SectionName_Offset), 0, SetRotator_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetRotator_PropertyName_Offset), 0, SetRotator_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRotator_RotatorValue_Offset), 0, SetRotator_RotatorValue_PropertyAddress.Address, RotatorValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRotator_FunctionAddress, intPtr, SetRotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRotator_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetRotator_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetInt")]
	public unsafe static void SetInt(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, int IntValue)
	{
		if (!SetInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetInt_ConfigFile_Offset), 0, SetInt_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetInt_SectionName_Offset), 0, SetInt_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetInt_PropertyName_Offset), 0, SetInt_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetInt_IntValue_Offset), 0, SetInt_IntValue_PropertyAddress.Address, IntValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInt_FunctionAddress, intPtr, SetInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetInt_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetInt_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetFloat")]
	public unsafe static void SetFloat(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, float FloatValue)
	{
		if (!SetFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetFloat_ConfigFile_Offset), 0, SetFloat_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFloat_SectionName_Offset), 0, SetFloat_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFloat_PropertyName_Offset), 0, SetFloat_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloat_FloatValue_Offset), 0, SetFloat_FloatValue_PropertyAddress.Address, FloatValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFloat_FunctionAddress, intPtr, SetFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFloat_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetFloat_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetColor")]
	public unsafe static void SetColor(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, FColor ColorValue)
	{
		if (!SetColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetColor_ConfigFile_Offset), 0, SetColor_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetColor_SectionName_Offset), 0, SetColor_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetColor_PropertyName_Offset), 0, SetColor_PropertyName_PropertyAddress.Address, PropertyName);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetColor_ColorValue_Offset), 0, SetColor_ColorValue_PropertyAddress.Address, ColorValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetColor_FunctionAddress, intPtr, SetColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetColor_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetColor_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetBool")]
	public unsafe static void SetBool(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, bool BoolValue)
	{
		if (!SetBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetBool_ConfigFile_Offset), 0, SetBool_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBool_SectionName_Offset), 0, SetBool_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBool_PropertyName_Offset), 0, SetBool_PropertyName_PropertyAddress.Address, PropertyName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBool_BoolValue_Offset), 0, SetBool_BoolValue_PropertyAddress.Address, BoolValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBool_FunctionAddress, intPtr, SetBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBool_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetBool_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:SetArray")]
	public unsafe static void SetArray(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, List<string> ArrayValue)
	{
		if (!SetArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:SetArray");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, SetArray_ConfigFile_Offset), 0, SetArray_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetArray_SectionName_Offset), 0, SetArray_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetArray_PropertyName_Offset), 0, SetArray_PropertyName_PropertyAddress.Address, PropertyName);
		new TArrayCopyMarshaler<string>(1, SetArray_ArrayValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetArray_ArrayValue_Offset), ArrayValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetArray_FunctionAddress, intPtr, SetArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetArray_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArray_PropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArray_ArrayValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector4")]
	public unsafe static FVector4 GetVector4(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector4");
			bWasFound = false;
			return default(FVector4);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetVector4_ConfigFile_Offset), 0, GetVector4_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector4_SectionName_Offset), 0, GetVector4_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector4_PropertyName_Offset), 0, GetVector4_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector4_FunctionAddress, intPtr, GetVector4_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVector4_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetVector4_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVector4_bWasFound_Offset), 0, GetVector4_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetVector4_ReturnValue_Offset), 0, GetVector4_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector2D")]
	public unsafe static FVector2D GetVector2D(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector2D");
			bWasFound = false;
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetVector2D_ConfigFile_Offset), 0, GetVector2D_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector2D_SectionName_Offset), 0, GetVector2D_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector2D_PropertyName_Offset), 0, GetVector2D_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector2D_FunctionAddress, intPtr, GetVector2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVector2D_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetVector2D_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVector2D_bWasFound_Offset), 0, GetVector2D_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVector2D_ReturnValue_Offset), 0, GetVector2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector")]
	public unsafe static FVector GetVector(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector");
			bWasFound = false;
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetVector_ConfigFile_Offset), 0, GetVector_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector_SectionName_Offset), 0, GetVector_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector_PropertyName_Offset), 0, GetVector_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector_FunctionAddress, intPtr, GetVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVector_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetVector_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVector_bWasFound_Offset), 0, GetVector_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVector_ReturnValue_Offset), 0, GetVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetText")]
	public unsafe static string GetText(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetText");
			bWasFound = false;
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetText_ConfigFile_Offset), 0, GetText_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetText_SectionName_Offset), 0, GetText_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetText_PropertyName_Offset), 0, GetText_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetText_FunctionAddress, intPtr, GetText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetText_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetText_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetText_bWasFound_Offset), 0, GetText_bWasFound_PropertyAddress.Address);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetText_ReturnValue_Offset), 0, GetText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetString")]
	public unsafe static string GetString(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetString");
			bWasFound = false;
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetString_ConfigFile_Offset), 0, GetString_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetString_SectionName_Offset), 0, GetString_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetString_PropertyName_Offset), 0, GetString_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetString_FunctionAddress, intPtr, GetString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetString_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetString_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetString_bWasFound_Offset), 0, GetString_bWasFound_PropertyAddress.Address);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetString_ReturnValue_Offset), 0, GetString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetRotator")]
	public unsafe static FRotator GetRotator(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetRotator");
			bWasFound = false;
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetRotator_ConfigFile_Offset), 0, GetRotator_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetRotator_SectionName_Offset), 0, GetRotator_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetRotator_PropertyName_Offset), 0, GetRotator_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRotator_FunctionAddress, intPtr, GetRotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRotator_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetRotator_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRotator_bWasFound_Offset), 0, GetRotator_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotator_ReturnValue_Offset), 0, GetRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetInt")]
	public unsafe static int GetInt(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetInt");
			bWasFound = false;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetInt_ConfigFile_Offset), 0, GetInt_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetInt_SectionName_Offset), 0, GetInt_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetInt_PropertyName_Offset), 0, GetInt_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInt_FunctionAddress, intPtr, GetInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInt_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetInt_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInt_bWasFound_Offset), 0, GetInt_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInt_ReturnValue_Offset), 0, GetInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetFloat")]
	public unsafe static float GetFloat(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetFloat");
			bWasFound = false;
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetFloat_ConfigFile_Offset), 0, GetFloat_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFloat_SectionName_Offset), 0, GetFloat_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFloat_PropertyName_Offset), 0, GetFloat_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloat_FunctionAddress, intPtr, GetFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFloat_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetFloat_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFloat_bWasFound_Offset), 0, GetFloat_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloat_ReturnValue_Offset), 0, GetFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetColor")]
	public unsafe static FColor GetColor(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetColor");
			bWasFound = false;
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetColor_ConfigFile_Offset), 0, GetColor_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetColor_SectionName_Offset), 0, GetColor_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetColor_PropertyName_Offset), 0, GetColor_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColor_FunctionAddress, intPtr, GetColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetColor_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetColor_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetColor_bWasFound_Offset), 0, GetColor_bWasFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, GetColor_ReturnValue_Offset), 0, GetColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetBool")]
	public unsafe static bool GetBool(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetBool");
			bWasFound = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetBool_ConfigFile_Offset), 0, GetBool_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetBool_SectionName_Offset), 0, GetBool_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetBool_PropertyName_Offset), 0, GetBool_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBool_FunctionAddress, intPtr, GetBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBool_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetBool_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBool_bWasFound_Offset), 0, GetBool_bWasFound_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBool_ReturnValue_Offset), 0, GetBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:GetArray")]
	public unsafe static List<string> GetArray(EConfigIniFileNames ConfigFile, string SectionName, string PropertyName, out bool bWasFound)
	{
		if (!GetArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:GetArray");
			bWasFound = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, GetArray_ConfigFile_Offset), 0, GetArray_ConfigFile_PropertyAddress.Address, ConfigFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetArray_SectionName_Offset), 0, GetArray_SectionName_PropertyAddress.Address, SectionName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetArray_PropertyName_Offset), 0, GetArray_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetArray_FunctionAddress, intPtr, GetArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetArray_SectionName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetArray_PropertyName_PropertyAddress.Address, intPtr);
		bWasFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetArray_bWasFound_Offset), 0, GetArray_bWasFound_PropertyAddress.Address);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetArray_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetArray_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetArray_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ConfigFuncLib:Flush")]
	public unsafe static void Flush(EConfigIniFileNames ConfigFile, bool bRefreshInConfigSystem)
	{
		if (!Flush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ConfigFuncLib:Flush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Flush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Flush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConfigIniFileNames>.ToNative(IntPtr.Add(intPtr, Flush_ConfigFile_Offset), 0, Flush_ConfigFile_PropertyAddress.Address, ConfigFile);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Flush_bRefreshInConfigSystem_Offset), 0, Flush_bRefreshInConfigSystem_PropertyAddress.Address, bRefreshInConfigSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Flush_FunctionAddress, intPtr, Flush_ParamsSize);
	}

	static UGSE_ConfigFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_ConfigFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_ConfigFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_ConfigFuncLib");
		SetVector4_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector4");
		SetVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector4_ConfigFile_PropertyAddress, SetVector4_FunctionAddress, "ConfigFile");
		SetVector4_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4_FunctionAddress, "ConfigFile");
		SetVector4_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4_SectionName_PropertyAddress, SetVector4_FunctionAddress, "SectionName");
		SetVector4_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4_FunctionAddress, "SectionName");
		SetVector4_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4_PropertyName_PropertyAddress, SetVector4_FunctionAddress, "PropertyName");
		SetVector4_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4_FunctionAddress, "PropertyName");
		SetVector4_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4_Vector4Value_PropertyAddress, SetVector4_FunctionAddress, "Vector4Value");
		SetVector4_Vector4Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4_FunctionAddress, "Vector4Value");
		SetVector4_Vector4Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4_FunctionAddress, "Vector4Value", Classes.FStructProperty);
		SetVector4_IsValid = SetVector4_FunctionAddress != IntPtr.Zero && SetVector4_ConfigFile_IsValid && SetVector4_SectionName_IsValid && SetVector4_PropertyName_IsValid && SetVector4_Vector4Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector4", SetVector4_IsValid);
		SetVector2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector2D");
		SetVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector2D_ConfigFile_PropertyAddress, SetVector2D_FunctionAddress, "ConfigFile");
		SetVector2D_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2D_FunctionAddress, "ConfigFile");
		SetVector2D_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2D_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2D_SectionName_PropertyAddress, SetVector2D_FunctionAddress, "SectionName");
		SetVector2D_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2D_FunctionAddress, "SectionName");
		SetVector2D_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2D_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2D_PropertyName_PropertyAddress, SetVector2D_FunctionAddress, "PropertyName");
		SetVector2D_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2D_FunctionAddress, "PropertyName");
		SetVector2D_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2D_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2D_Vector2DValue_PropertyAddress, SetVector2D_FunctionAddress, "Vector2DValue");
		SetVector2D_Vector2DValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2D_FunctionAddress, "Vector2DValue");
		SetVector2D_Vector2DValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2D_FunctionAddress, "Vector2DValue", Classes.FStructProperty);
		SetVector2D_IsValid = SetVector2D_FunctionAddress != IntPtr.Zero && SetVector2D_ConfigFile_IsValid && SetVector2D_SectionName_IsValid && SetVector2D_PropertyName_IsValid && SetVector2D_Vector2DValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector2D", SetVector2D_IsValid);
		SetVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector");
		SetVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector_ConfigFile_PropertyAddress, SetVector_FunctionAddress, "ConfigFile");
		SetVector_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetVector_FunctionAddress, "ConfigFile");
		SetVector_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector_SectionName_PropertyAddress, SetVector_FunctionAddress, "SectionName");
		SetVector_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector_FunctionAddress, "SectionName");
		SetVector_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector_PropertyName_PropertyAddress, SetVector_FunctionAddress, "PropertyName");
		SetVector_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector_FunctionAddress, "PropertyName");
		SetVector_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector_VectorValue_PropertyAddress, SetVector_FunctionAddress, "VectorValue");
		SetVector_VectorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVector_FunctionAddress, "VectorValue");
		SetVector_VectorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector_FunctionAddress, "VectorValue", Classes.FStructProperty);
		SetVector_IsValid = SetVector_FunctionAddress != IntPtr.Zero && SetVector_ConfigFile_IsValid && SetVector_SectionName_IsValid && SetVector_PropertyName_IsValid && SetVector_VectorValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetVector", SetVector_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_ConfigFile_PropertyAddress, SetText_FunctionAddress, "ConfigFile");
		SetText_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "ConfigFile");
		SetText_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetText_SectionName_PropertyAddress, SetText_FunctionAddress, "SectionName");
		SetText_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "SectionName");
		SetText_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetText_PropertyName_PropertyAddress, SetText_FunctionAddress, "PropertyName");
		SetText_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "PropertyName");
		SetText_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetText_TextValue_PropertyAddress, SetText_FunctionAddress, "TextValue");
		SetText_TextValue_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "TextValue");
		SetText_TextValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "TextValue", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_ConfigFile_IsValid && SetText_SectionName_IsValid && SetText_PropertyName_IsValid && SetText_TextValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetText", SetText_IsValid);
		SetString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetString");
		SetString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetString_ConfigFile_PropertyAddress, SetString_FunctionAddress, "ConfigFile");
		SetString_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetString_FunctionAddress, "ConfigFile");
		SetString_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetString_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetString_SectionName_PropertyAddress, SetString_FunctionAddress, "SectionName");
		SetString_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetString_FunctionAddress, "SectionName");
		SetString_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetString_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetString_PropertyName_PropertyAddress, SetString_FunctionAddress, "PropertyName");
		SetString_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetString_FunctionAddress, "PropertyName");
		SetString_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetString_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetString_StringValue_PropertyAddress, SetString_FunctionAddress, "StringValue");
		SetString_StringValue_Offset = NativeReflectionCached.GetPropertyOffset(SetString_FunctionAddress, "StringValue");
		SetString_StringValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetString_FunctionAddress, "StringValue", Classes.FStrProperty);
		SetString_IsValid = SetString_FunctionAddress != IntPtr.Zero && SetString_ConfigFile_IsValid && SetString_SectionName_IsValid && SetString_PropertyName_IsValid && SetString_StringValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetString", SetString_IsValid);
		SetRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRotator");
		SetRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRotator_ConfigFile_PropertyAddress, SetRotator_FunctionAddress, "ConfigFile");
		SetRotator_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetRotator_FunctionAddress, "ConfigFile");
		SetRotator_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotator_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotator_SectionName_PropertyAddress, SetRotator_FunctionAddress, "SectionName");
		SetRotator_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetRotator_FunctionAddress, "SectionName");
		SetRotator_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotator_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotator_PropertyName_PropertyAddress, SetRotator_FunctionAddress, "PropertyName");
		SetRotator_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetRotator_FunctionAddress, "PropertyName");
		SetRotator_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotator_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotator_RotatorValue_PropertyAddress, SetRotator_FunctionAddress, "RotatorValue");
		SetRotator_RotatorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRotator_FunctionAddress, "RotatorValue");
		SetRotator_RotatorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotator_FunctionAddress, "RotatorValue", Classes.FStructProperty);
		SetRotator_IsValid = SetRotator_FunctionAddress != IntPtr.Zero && SetRotator_ConfigFile_IsValid && SetRotator_SectionName_IsValid && SetRotator_PropertyName_IsValid && SetRotator_RotatorValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetRotator", SetRotator_IsValid);
		SetInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInt");
		SetInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInt_ConfigFile_PropertyAddress, SetInt_FunctionAddress, "ConfigFile");
		SetInt_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetInt_FunctionAddress, "ConfigFile");
		SetInt_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt_SectionName_PropertyAddress, SetInt_FunctionAddress, "SectionName");
		SetInt_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetInt_FunctionAddress, "SectionName");
		SetInt_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt_PropertyName_PropertyAddress, SetInt_FunctionAddress, "PropertyName");
		SetInt_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetInt_FunctionAddress, "PropertyName");
		SetInt_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInt_IntValue_PropertyAddress, SetInt_FunctionAddress, "IntValue");
		SetInt_IntValue_Offset = NativeReflectionCached.GetPropertyOffset(SetInt_FunctionAddress, "IntValue");
		SetInt_IntValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInt_FunctionAddress, "IntValue", Classes.FIntProperty);
		SetInt_IsValid = SetInt_FunctionAddress != IntPtr.Zero && SetInt_ConfigFile_IsValid && SetInt_SectionName_IsValid && SetInt_PropertyName_IsValid && SetInt_IntValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetInt", SetInt_IsValid);
		SetFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFloat");
		SetFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloat_ConfigFile_PropertyAddress, SetFloat_FunctionAddress, "ConfigFile");
		SetFloat_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetFloat_FunctionAddress, "ConfigFile");
		SetFloat_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloat_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloat_SectionName_PropertyAddress, SetFloat_FunctionAddress, "SectionName");
		SetFloat_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloat_FunctionAddress, "SectionName");
		SetFloat_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloat_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloat_PropertyName_PropertyAddress, SetFloat_FunctionAddress, "PropertyName");
		SetFloat_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloat_FunctionAddress, "PropertyName");
		SetFloat_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloat_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloat_FloatValue_PropertyAddress, SetFloat_FunctionAddress, "FloatValue");
		SetFloat_FloatValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFloat_FunctionAddress, "FloatValue");
		SetFloat_FloatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloat_FunctionAddress, "FloatValue", Classes.FFloatProperty);
		SetFloat_IsValid = SetFloat_FunctionAddress != IntPtr.Zero && SetFloat_ConfigFile_IsValid && SetFloat_SectionName_IsValid && SetFloat_PropertyName_IsValid && SetFloat_FloatValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetFloat", SetFloat_IsValid);
		SetColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetColor");
		SetColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColor_ConfigFile_PropertyAddress, SetColor_FunctionAddress, "ConfigFile");
		SetColor_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetColor_FunctionAddress, "ConfigFile");
		SetColor_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColor_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColor_SectionName_PropertyAddress, SetColor_FunctionAddress, "SectionName");
		SetColor_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetColor_FunctionAddress, "SectionName");
		SetColor_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColor_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColor_PropertyName_PropertyAddress, SetColor_FunctionAddress, "PropertyName");
		SetColor_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetColor_FunctionAddress, "PropertyName");
		SetColor_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColor_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColor_ColorValue_PropertyAddress, SetColor_FunctionAddress, "ColorValue");
		SetColor_ColorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetColor_FunctionAddress, "ColorValue");
		SetColor_ColorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColor_FunctionAddress, "ColorValue", Classes.FStructProperty);
		SetColor_IsValid = SetColor_FunctionAddress != IntPtr.Zero && SetColor_ConfigFile_IsValid && SetColor_SectionName_IsValid && SetColor_PropertyName_IsValid && SetColor_ColorValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetColor", SetColor_IsValid);
		SetBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBool");
		SetBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBool_ConfigFile_PropertyAddress, SetBool_FunctionAddress, "ConfigFile");
		SetBool_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetBool_FunctionAddress, "ConfigFile");
		SetBool_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBool_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBool_SectionName_PropertyAddress, SetBool_FunctionAddress, "SectionName");
		SetBool_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetBool_FunctionAddress, "SectionName");
		SetBool_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBool_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBool_PropertyName_PropertyAddress, SetBool_FunctionAddress, "PropertyName");
		SetBool_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetBool_FunctionAddress, "PropertyName");
		SetBool_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBool_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBool_BoolValue_PropertyAddress, SetBool_FunctionAddress, "BoolValue");
		SetBool_BoolValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBool_FunctionAddress, "BoolValue");
		SetBool_BoolValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBool_FunctionAddress, "BoolValue", Classes.FBoolProperty);
		SetBool_IsValid = SetBool_FunctionAddress != IntPtr.Zero && SetBool_ConfigFile_IsValid && SetBool_SectionName_IsValid && SetBool_PropertyName_IsValid && SetBool_BoolValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetBool", SetBool_IsValid);
		SetArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetArray");
		SetArray_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArray_ConfigFile_PropertyAddress, SetArray_FunctionAddress, "ConfigFile");
		SetArray_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(SetArray_FunctionAddress, "ConfigFile");
		SetArray_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArray_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArray_SectionName_PropertyAddress, SetArray_FunctionAddress, "SectionName");
		SetArray_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(SetArray_FunctionAddress, "SectionName");
		SetArray_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArray_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArray_PropertyName_PropertyAddress, SetArray_FunctionAddress, "PropertyName");
		SetArray_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetArray_FunctionAddress, "PropertyName");
		SetArray_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArray_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArray_ArrayValue_PropertyAddress, SetArray_FunctionAddress, "ArrayValue");
		SetArray_ArrayValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArray_FunctionAddress, "ArrayValue");
		SetArray_ArrayValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArray_FunctionAddress, "ArrayValue", Classes.FArrayProperty);
		SetArray_IsValid = SetArray_FunctionAddress != IntPtr.Zero && SetArray_ConfigFile_IsValid && SetArray_SectionName_IsValid && SetArray_PropertyName_IsValid && SetArray_ArrayValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:SetArray", SetArray_IsValid);
		GetVector4_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector4");
		GetVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector4_ConfigFile_PropertyAddress, GetVector4_FunctionAddress, "ConfigFile");
		GetVector4_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4_FunctionAddress, "ConfigFile");
		GetVector4_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4_SectionName_PropertyAddress, GetVector4_FunctionAddress, "SectionName");
		GetVector4_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4_FunctionAddress, "SectionName");
		GetVector4_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4_PropertyName_PropertyAddress, GetVector4_FunctionAddress, "PropertyName");
		GetVector4_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4_FunctionAddress, "PropertyName");
		GetVector4_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4_bWasFound_PropertyAddress, GetVector4_FunctionAddress, "bWasFound");
		GetVector4_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4_FunctionAddress, "bWasFound");
		GetVector4_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4_ReturnValue_PropertyAddress, GetVector4_FunctionAddress, "ReturnValue");
		GetVector4_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4_FunctionAddress, "ReturnValue");
		GetVector4_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector4_IsValid = GetVector4_FunctionAddress != IntPtr.Zero && GetVector4_ConfigFile_IsValid && GetVector4_SectionName_IsValid && GetVector4_PropertyName_IsValid && GetVector4_bWasFound_IsValid && GetVector4_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector4", GetVector4_IsValid);
		GetVector2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector2D");
		GetVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector2D_ConfigFile_PropertyAddress, GetVector2D_FunctionAddress, "ConfigFile");
		GetVector2D_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2D_FunctionAddress, "ConfigFile");
		GetVector2D_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2D_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2D_SectionName_PropertyAddress, GetVector2D_FunctionAddress, "SectionName");
		GetVector2D_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2D_FunctionAddress, "SectionName");
		GetVector2D_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2D_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2D_PropertyName_PropertyAddress, GetVector2D_FunctionAddress, "PropertyName");
		GetVector2D_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2D_FunctionAddress, "PropertyName");
		GetVector2D_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2D_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2D_bWasFound_PropertyAddress, GetVector2D_FunctionAddress, "bWasFound");
		GetVector2D_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2D_FunctionAddress, "bWasFound");
		GetVector2D_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2D_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2D_ReturnValue_PropertyAddress, GetVector2D_FunctionAddress, "ReturnValue");
		GetVector2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2D_FunctionAddress, "ReturnValue");
		GetVector2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector2D_IsValid = GetVector2D_FunctionAddress != IntPtr.Zero && GetVector2D_ConfigFile_IsValid && GetVector2D_SectionName_IsValid && GetVector2D_PropertyName_IsValid && GetVector2D_bWasFound_IsValid && GetVector2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector2D", GetVector2D_IsValid);
		GetVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector");
		GetVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector_ConfigFile_PropertyAddress, GetVector_FunctionAddress, "ConfigFile");
		GetVector_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "ConfigFile");
		GetVector_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector_SectionName_PropertyAddress, GetVector_FunctionAddress, "SectionName");
		GetVector_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "SectionName");
		GetVector_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector_PropertyName_PropertyAddress, GetVector_FunctionAddress, "PropertyName");
		GetVector_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "PropertyName");
		GetVector_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector_bWasFound_PropertyAddress, GetVector_FunctionAddress, "bWasFound");
		GetVector_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "bWasFound");
		GetVector_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector_ReturnValue_PropertyAddress, GetVector_FunctionAddress, "ReturnValue");
		GetVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "ReturnValue");
		GetVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector_IsValid = GetVector_FunctionAddress != IntPtr.Zero && GetVector_ConfigFile_IsValid && GetVector_SectionName_IsValid && GetVector_PropertyName_IsValid && GetVector_bWasFound_IsValid && GetVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetVector", GetVector_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ConfigFile_PropertyAddress, GetText_FunctionAddress, "ConfigFile");
		GetText_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ConfigFile");
		GetText_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetText_SectionName_PropertyAddress, GetText_FunctionAddress, "SectionName");
		GetText_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "SectionName");
		GetText_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetText_PropertyName_PropertyAddress, GetText_FunctionAddress, "PropertyName");
		GetText_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "PropertyName");
		GetText_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetText_bWasFound_PropertyAddress, GetText_FunctionAddress, "bWasFound");
		GetText_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "bWasFound");
		GetText_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ConfigFile_IsValid && GetText_SectionName_IsValid && GetText_PropertyName_IsValid && GetText_bWasFound_IsValid && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetText", GetText_IsValid);
		GetString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetString");
		GetString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetString_ConfigFile_PropertyAddress, GetString_FunctionAddress, "ConfigFile");
		GetString_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "ConfigFile");
		GetString_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_SectionName_PropertyAddress, GetString_FunctionAddress, "SectionName");
		GetString_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "SectionName");
		GetString_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_PropertyName_PropertyAddress, GetString_FunctionAddress, "PropertyName");
		GetString_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "PropertyName");
		GetString_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_bWasFound_PropertyAddress, GetString_FunctionAddress, "bWasFound");
		GetString_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "bWasFound");
		GetString_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_ReturnValue_PropertyAddress, GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetString_IsValid = GetString_FunctionAddress != IntPtr.Zero && GetString_ConfigFile_IsValid && GetString_SectionName_IsValid && GetString_PropertyName_IsValid && GetString_bWasFound_IsValid && GetString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetString", GetString_IsValid);
		GetRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRotator");
		GetRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotator_ConfigFile_PropertyAddress, GetRotator_FunctionAddress, "ConfigFile");
		GetRotator_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetRotator_FunctionAddress, "ConfigFile");
		GetRotator_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotator_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotator_SectionName_PropertyAddress, GetRotator_FunctionAddress, "SectionName");
		GetRotator_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetRotator_FunctionAddress, "SectionName");
		GetRotator_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotator_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotator_PropertyName_PropertyAddress, GetRotator_FunctionAddress, "PropertyName");
		GetRotator_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetRotator_FunctionAddress, "PropertyName");
		GetRotator_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotator_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotator_bWasFound_PropertyAddress, GetRotator_FunctionAddress, "bWasFound");
		GetRotator_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetRotator_FunctionAddress, "bWasFound");
		GetRotator_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotator_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotator_ReturnValue_PropertyAddress, GetRotator_FunctionAddress, "ReturnValue");
		GetRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotator_FunctionAddress, "ReturnValue");
		GetRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotator_IsValid = GetRotator_FunctionAddress != IntPtr.Zero && GetRotator_ConfigFile_IsValid && GetRotator_SectionName_IsValid && GetRotator_PropertyName_IsValid && GetRotator_bWasFound_IsValid && GetRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetRotator", GetRotator_IsValid);
		GetInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInt");
		GetInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInt_ConfigFile_PropertyAddress, GetInt_FunctionAddress, "ConfigFile");
		GetInt_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetInt_FunctionAddress, "ConfigFile");
		GetInt_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt_SectionName_PropertyAddress, GetInt_FunctionAddress, "SectionName");
		GetInt_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetInt_FunctionAddress, "SectionName");
		GetInt_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt_PropertyName_PropertyAddress, GetInt_FunctionAddress, "PropertyName");
		GetInt_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetInt_FunctionAddress, "PropertyName");
		GetInt_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt_bWasFound_PropertyAddress, GetInt_FunctionAddress, "bWasFound");
		GetInt_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetInt_FunctionAddress, "bWasFound");
		GetInt_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt_ReturnValue_PropertyAddress, GetInt_FunctionAddress, "ReturnValue");
		GetInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt_FunctionAddress, "ReturnValue");
		GetInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetInt_IsValid = GetInt_FunctionAddress != IntPtr.Zero && GetInt_ConfigFile_IsValid && GetInt_SectionName_IsValid && GetInt_PropertyName_IsValid && GetInt_bWasFound_IsValid && GetInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetInt", GetInt_IsValid);
		GetFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloat");
		GetFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_ConfigFile_PropertyAddress, GetFloat_FunctionAddress, "ConfigFile");
		GetFloat_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "ConfigFile");
		GetFloat_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_SectionName_PropertyAddress, GetFloat_FunctionAddress, "SectionName");
		GetFloat_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "SectionName");
		GetFloat_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_PropertyName_PropertyAddress, GetFloat_FunctionAddress, "PropertyName");
		GetFloat_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "PropertyName");
		GetFloat_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_bWasFound_PropertyAddress, GetFloat_FunctionAddress, "bWasFound");
		GetFloat_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "bWasFound");
		GetFloat_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_ReturnValue_PropertyAddress, GetFloat_FunctionAddress, "ReturnValue");
		GetFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "ReturnValue");
		GetFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloat_IsValid = GetFloat_FunctionAddress != IntPtr.Zero && GetFloat_ConfigFile_IsValid && GetFloat_SectionName_IsValid && GetFloat_PropertyName_IsValid && GetFloat_bWasFound_IsValid && GetFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetFloat", GetFloat_IsValid);
		GetColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColor");
		GetColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColor_ConfigFile_PropertyAddress, GetColor_FunctionAddress, "ConfigFile");
		GetColor_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "ConfigFile");
		GetColor_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColor_SectionName_PropertyAddress, GetColor_FunctionAddress, "SectionName");
		GetColor_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "SectionName");
		GetColor_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColor_PropertyName_PropertyAddress, GetColor_FunctionAddress, "PropertyName");
		GetColor_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "PropertyName");
		GetColor_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColor_bWasFound_PropertyAddress, GetColor_FunctionAddress, "bWasFound");
		GetColor_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "bWasFound");
		GetColor_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColor_ReturnValue_PropertyAddress, GetColor_FunctionAddress, "ReturnValue");
		GetColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "ReturnValue");
		GetColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetColor_IsValid = GetColor_FunctionAddress != IntPtr.Zero && GetColor_ConfigFile_IsValid && GetColor_SectionName_IsValid && GetColor_PropertyName_IsValid && GetColor_bWasFound_IsValid && GetColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetColor", GetColor_IsValid);
		GetBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBool");
		GetBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBool_ConfigFile_PropertyAddress, GetBool_FunctionAddress, "ConfigFile");
		GetBool_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "ConfigFile");
		GetBool_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_SectionName_PropertyAddress, GetBool_FunctionAddress, "SectionName");
		GetBool_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "SectionName");
		GetBool_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_PropertyName_PropertyAddress, GetBool_FunctionAddress, "PropertyName");
		GetBool_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "PropertyName");
		GetBool_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_bWasFound_PropertyAddress, GetBool_FunctionAddress, "bWasFound");
		GetBool_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "bWasFound");
		GetBool_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_ReturnValue_PropertyAddress, GetBool_FunctionAddress, "ReturnValue");
		GetBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "ReturnValue");
		GetBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBool_IsValid = GetBool_FunctionAddress != IntPtr.Zero && GetBool_ConfigFile_IsValid && GetBool_SectionName_IsValid && GetBool_PropertyName_IsValid && GetBool_bWasFound_IsValid && GetBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetBool", GetBool_IsValid);
		GetArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetArray");
		GetArray_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArray_ConfigFile_PropertyAddress, GetArray_FunctionAddress, "ConfigFile");
		GetArray_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(GetArray_FunctionAddress, "ConfigFile");
		GetArray_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArray_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArray_SectionName_PropertyAddress, GetArray_FunctionAddress, "SectionName");
		GetArray_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetArray_FunctionAddress, "SectionName");
		GetArray_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArray_FunctionAddress, "SectionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArray_PropertyName_PropertyAddress, GetArray_FunctionAddress, "PropertyName");
		GetArray_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetArray_FunctionAddress, "PropertyName");
		GetArray_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArray_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArray_bWasFound_PropertyAddress, GetArray_FunctionAddress, "bWasFound");
		GetArray_bWasFound_Offset = NativeReflectionCached.GetPropertyOffset(GetArray_FunctionAddress, "bWasFound");
		GetArray_bWasFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArray_FunctionAddress, "bWasFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArray_ReturnValue_PropertyAddress, GetArray_FunctionAddress, "ReturnValue");
		GetArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArray_FunctionAddress, "ReturnValue");
		GetArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArray_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetArray_IsValid = GetArray_FunctionAddress != IntPtr.Zero && GetArray_ConfigFile_IsValid && GetArray_SectionName_IsValid && GetArray_PropertyName_IsValid && GetArray_bWasFound_IsValid && GetArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:GetArray", GetArray_IsValid);
		Flush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Flush");
		Flush_ParamsSize = NativeReflection.GetFunctionParamsSize(Flush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Flush_ConfigFile_PropertyAddress, Flush_FunctionAddress, "ConfigFile");
		Flush_ConfigFile_Offset = NativeReflectionCached.GetPropertyOffset(Flush_FunctionAddress, "ConfigFile");
		Flush_ConfigFile_IsValid = NativeReflectionCached.ValidatePropertyClass(Flush_FunctionAddress, "ConfigFile", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Flush_bRefreshInConfigSystem_PropertyAddress, Flush_FunctionAddress, "bRefreshInConfigSystem");
		Flush_bRefreshInConfigSystem_Offset = NativeReflectionCached.GetPropertyOffset(Flush_FunctionAddress, "bRefreshInConfigSystem");
		Flush_bRefreshInConfigSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(Flush_FunctionAddress, "bRefreshInConfigSystem", Classes.FBoolProperty);
		Flush_IsValid = Flush_FunctionAddress != IntPtr.Zero && Flush_ConfigFile_IsValid && Flush_bRefreshInConfigSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ConfigFuncLib:Flush", Flush_IsValid);
	}
}
