using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/DatasmithContent.DatasmithContentBlueprintLibrary", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public class UDatasmithContentLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetDatasmithUserDataValueForKey_IsValid;

	private static IntPtr GetDatasmithUserDataValueForKey_FunctionAddress;

	private static int GetDatasmithUserDataValueForKey_ParamsSize;

	private static bool GetDatasmithUserDataValueForKey_Object_IsValid;

	private static FFieldAddress GetDatasmithUserDataValueForKey_Object_PropertyAddress;

	private static int GetDatasmithUserDataValueForKey_Object_Offset;

	private static bool GetDatasmithUserDataValueForKey_Key_IsValid;

	private static FFieldAddress GetDatasmithUserDataValueForKey_Key_PropertyAddress;

	private static int GetDatasmithUserDataValueForKey_Key_Offset;

	private static bool GetDatasmithUserDataValueForKey_ReturnValue_IsValid;

	private static FFieldAddress GetDatasmithUserDataValueForKey_ReturnValue_PropertyAddress;

	private static int GetDatasmithUserDataValueForKey_ReturnValue_Offset;

	private static bool GetDatasmithUserDataKeysAndValuesForValue_IsValid;

	private static IntPtr GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress;

	private static int GetDatasmithUserDataKeysAndValuesForValue_ParamsSize;

	private static bool GetDatasmithUserDataKeysAndValuesForValue_Object_IsValid;

	private static FFieldAddress GetDatasmithUserDataKeysAndValuesForValue_Object_PropertyAddress;

	private static int GetDatasmithUserDataKeysAndValuesForValue_Object_Offset;

	private static bool GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_IsValid;

	private static FFieldAddress GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_PropertyAddress;

	private static int GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_Offset;

	private static bool GetDatasmithUserDataKeysAndValuesForValue_OutKeys_IsValid;

	private static FFieldAddress GetDatasmithUserDataKeysAndValuesForValue_OutKeys_PropertyAddress;

	private static int GetDatasmithUserDataKeysAndValuesForValue_OutKeys_Offset;

	private static bool GetDatasmithUserDataKeysAndValuesForValue_OutValues_IsValid;

	private static FFieldAddress GetDatasmithUserDataKeysAndValuesForValue_OutValues_PropertyAddress;

	private static int GetDatasmithUserDataKeysAndValuesForValue_OutValues_Offset;

	private static bool GetDatasmithUserData_IsValid;

	private static IntPtr GetDatasmithUserData_FunctionAddress;

	private static int GetDatasmithUserData_ParamsSize;

	private static bool GetDatasmithUserData_Object_IsValid;

	private static FFieldAddress GetDatasmithUserData_Object_PropertyAddress;

	private static int GetDatasmithUserData_Object_Offset;

	private static bool GetDatasmithUserData_ReturnValue_IsValid;

	private static FFieldAddress GetDatasmithUserData_ReturnValue_PropertyAddress;

	private static int GetDatasmithUserData_ReturnValue_Offset;

	private static bool GetAllObjectsAndValuesForKey_IsValid;

	private static IntPtr GetAllObjectsAndValuesForKey_FunctionAddress;

	private static int GetAllObjectsAndValuesForKey_ParamsSize;

	private static bool GetAllObjectsAndValuesForKey_Key_IsValid;

	private static FFieldAddress GetAllObjectsAndValuesForKey_Key_PropertyAddress;

	private static int GetAllObjectsAndValuesForKey_Key_Offset;

	private static bool GetAllObjectsAndValuesForKey_ObjectClass_IsValid;

	private static FFieldAddress GetAllObjectsAndValuesForKey_ObjectClass_PropertyAddress;

	private static int GetAllObjectsAndValuesForKey_ObjectClass_Offset;

	private static bool GetAllObjectsAndValuesForKey_OutObjects_IsValid;

	private static FFieldAddress GetAllObjectsAndValuesForKey_OutObjects_PropertyAddress;

	private static int GetAllObjectsAndValuesForKey_OutObjects_Offset;

	private static bool GetAllObjectsAndValuesForKey_OutValues_IsValid;

	private static FFieldAddress GetAllObjectsAndValuesForKey_OutValues_PropertyAddress;

	private static int GetAllObjectsAndValuesForKey_OutValues_Offset;

	private static bool GetAllDatasmithUserData_IsValid;

	private static IntPtr GetAllDatasmithUserData_FunctionAddress;

	private static int GetAllDatasmithUserData_ParamsSize;

	private static bool GetAllDatasmithUserData_ObjectClass_IsValid;

	private static FFieldAddress GetAllDatasmithUserData_ObjectClass_PropertyAddress;

	private static int GetAllDatasmithUserData_ObjectClass_Offset;

	private static bool GetAllDatasmithUserData_OutUserData_IsValid;

	private static FFieldAddress GetAllDatasmithUserData_OutUserData_PropertyAddress;

	private static int GetAllDatasmithUserData_OutUserData_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserDataValueForKey")]
	public unsafe static string GetDatasmithUserDataValueForKey(UObject Object, FName Key)
	{
		if (!GetDatasmithUserDataValueForKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserDataValueForKey");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDatasmithUserDataValueForKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDatasmithUserDataValueForKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDatasmithUserDataValueForKey_Object_Offset), 0, GetDatasmithUserDataValueForKey_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDatasmithUserDataValueForKey_Key_Offset), 0, GetDatasmithUserDataValueForKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDatasmithUserDataValueForKey_FunctionAddress, intPtr, GetDatasmithUserDataValueForKey_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDatasmithUserDataValueForKey_ReturnValue_Offset), 0, GetDatasmithUserDataValueForKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDatasmithUserDataValueForKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserDataKeysAndValuesForValue")]
	public unsafe static void GetDatasmithUserDataKeysAndValuesForValue(UObject Object, string StringToMatch, out List<FName> OutKeys, out List<string> OutValues)
	{
		if (!GetDatasmithUserDataKeysAndValuesForValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserDataKeysAndValuesForValue");
			OutKeys = null;
			OutValues = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDatasmithUserDataKeysAndValuesForValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDatasmithUserDataKeysAndValuesForValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDatasmithUserDataKeysAndValuesForValue_Object_Offset), 0, GetDatasmithUserDataKeysAndValuesForValue_Object_PropertyAddress.Address, Object);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_Offset), 0, GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_PropertyAddress.Address, StringToMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, intPtr, GetDatasmithUserDataKeysAndValuesForValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_PropertyAddress.Address, intPtr);
		OutKeys = new TArrayCopyMarshaler<FName>(1, GetDatasmithUserDataKeysAndValuesForValue_OutKeys_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDatasmithUserDataKeysAndValuesForValue_OutKeys_Offset));
		NativeReflection.DestroyValue_InContainer(GetDatasmithUserDataKeysAndValuesForValue_OutKeys_PropertyAddress.Address, intPtr);
		OutValues = new TArrayCopyMarshaler<string>(1, GetDatasmithUserDataKeysAndValuesForValue_OutValues_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetDatasmithUserDataKeysAndValuesForValue_OutValues_Offset));
		NativeReflection.DestroyValue_InContainer(GetDatasmithUserDataKeysAndValuesForValue_OutValues_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserData")]
	public unsafe static UDatasmithUserData GetDatasmithUserData(UObject Object)
	{
		if (!GetDatasmithUserData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDatasmithUserData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDatasmithUserData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDatasmithUserData_Object_Offset), 0, GetDatasmithUserData_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDatasmithUserData_FunctionAddress, intPtr, GetDatasmithUserData_ParamsSize);
		return UObjectMarshaler<UDatasmithUserData>.FromNative(IntPtr.Add(intPtr, GetDatasmithUserData_ReturnValue_Offset), 0, GetDatasmithUserData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetAllObjectsAndValuesForKey")]
	public unsafe static void GetAllObjectsAndValuesForKey(FName Key, TSubclassOf<UObject> ObjectClass, out List<UObject> OutObjects, out List<string> OutValues)
	{
		if (!GetAllObjectsAndValuesForKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetAllObjectsAndValuesForKey");
			OutObjects = null;
			OutValues = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllObjectsAndValuesForKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllObjectsAndValuesForKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAllObjectsAndValuesForKey_Key_Offset), 0, GetAllObjectsAndValuesForKey_Key_PropertyAddress.Address, Key);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllObjectsAndValuesForKey_ObjectClass_Offset), 0, GetAllObjectsAndValuesForKey_ObjectClass_PropertyAddress.Address, ObjectClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllObjectsAndValuesForKey_FunctionAddress, intPtr, GetAllObjectsAndValuesForKey_ParamsSize);
		OutObjects = new TArrayCopyMarshaler<UObject>(1, GetAllObjectsAndValuesForKey_OutObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllObjectsAndValuesForKey_OutObjects_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllObjectsAndValuesForKey_OutObjects_PropertyAddress.Address, intPtr);
		OutValues = new TArrayCopyMarshaler<string>(1, GetAllObjectsAndValuesForKey_OutValues_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllObjectsAndValuesForKey_OutValues_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllObjectsAndValuesForKey_OutValues_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetAllDatasmithUserData")]
	public unsafe static void GetAllDatasmithUserData(TSubclassOf<UObject> ObjectClass, out List<UDatasmithUserData> OutUserData)
	{
		if (!GetAllDatasmithUserData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetAllDatasmithUserData");
			OutUserData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllDatasmithUserData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllDatasmithUserData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllDatasmithUserData_ObjectClass_Offset), 0, GetAllDatasmithUserData_ObjectClass_PropertyAddress.Address, ObjectClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllDatasmithUserData_FunctionAddress, intPtr, GetAllDatasmithUserData_ParamsSize);
		OutUserData = new TArrayCopyMarshaler<UDatasmithUserData>(1, GetAllDatasmithUserData_OutUserData_PropertyAddress, CachedMarshalingDelegates<UDatasmithUserData, UObjectMarshaler<UDatasmithUserData>>.FromNative, CachedMarshalingDelegates<UDatasmithUserData, UObjectMarshaler<UDatasmithUserData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllDatasmithUserData_OutUserData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllDatasmithUserData_OutUserData_PropertyAddress.Address, intPtr);
	}

	static UDatasmithContentLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDatasmithContentLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDatasmithContentLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/DatasmithContent.DatasmithContentBlueprintLibrary");
		GetDatasmithUserDataValueForKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDatasmithUserDataValueForKey");
		GetDatasmithUserDataValueForKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDatasmithUserDataValueForKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataValueForKey_Object_PropertyAddress, GetDatasmithUserDataValueForKey_FunctionAddress, "Object");
		GetDatasmithUserDataValueForKey_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataValueForKey_FunctionAddress, "Object");
		GetDatasmithUserDataValueForKey_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataValueForKey_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataValueForKey_Key_PropertyAddress, GetDatasmithUserDataValueForKey_FunctionAddress, "Key");
		GetDatasmithUserDataValueForKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataValueForKey_FunctionAddress, "Key");
		GetDatasmithUserDataValueForKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataValueForKey_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataValueForKey_ReturnValue_PropertyAddress, GetDatasmithUserDataValueForKey_FunctionAddress, "ReturnValue");
		GetDatasmithUserDataValueForKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataValueForKey_FunctionAddress, "ReturnValue");
		GetDatasmithUserDataValueForKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataValueForKey_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDatasmithUserDataValueForKey_IsValid = GetDatasmithUserDataValueForKey_FunctionAddress != IntPtr.Zero && GetDatasmithUserDataValueForKey_Object_IsValid && GetDatasmithUserDataValueForKey_Key_IsValid && GetDatasmithUserDataValueForKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserDataValueForKey", GetDatasmithUserDataValueForKey_IsValid);
		GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDatasmithUserDataKeysAndValuesForValue");
		GetDatasmithUserDataKeysAndValuesForValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataKeysAndValuesForValue_Object_PropertyAddress, GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "Object");
		GetDatasmithUserDataKeysAndValuesForValue_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "Object");
		GetDatasmithUserDataKeysAndValuesForValue_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_PropertyAddress, GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "StringToMatch");
		GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "StringToMatch");
		GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "StringToMatch", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataKeysAndValuesForValue_OutKeys_PropertyAddress, GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "OutKeys");
		GetDatasmithUserDataKeysAndValuesForValue_OutKeys_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "OutKeys");
		GetDatasmithUserDataKeysAndValuesForValue_OutKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "OutKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserDataKeysAndValuesForValue_OutValues_PropertyAddress, GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "OutValues");
		GetDatasmithUserDataKeysAndValuesForValue_OutValues_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "OutValues");
		GetDatasmithUserDataKeysAndValuesForValue_OutValues_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress, "OutValues", Classes.FArrayProperty);
		GetDatasmithUserDataKeysAndValuesForValue_IsValid = GetDatasmithUserDataKeysAndValuesForValue_FunctionAddress != IntPtr.Zero && GetDatasmithUserDataKeysAndValuesForValue_Object_IsValid && GetDatasmithUserDataKeysAndValuesForValue_StringToMatch_IsValid && GetDatasmithUserDataKeysAndValuesForValue_OutKeys_IsValid && GetDatasmithUserDataKeysAndValuesForValue_OutValues_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserDataKeysAndValuesForValue", GetDatasmithUserDataKeysAndValuesForValue_IsValid);
		GetDatasmithUserData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDatasmithUserData");
		GetDatasmithUserData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDatasmithUserData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserData_Object_PropertyAddress, GetDatasmithUserData_FunctionAddress, "Object");
		GetDatasmithUserData_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserData_FunctionAddress, "Object");
		GetDatasmithUserData_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserData_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDatasmithUserData_ReturnValue_PropertyAddress, GetDatasmithUserData_FunctionAddress, "ReturnValue");
		GetDatasmithUserData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDatasmithUserData_FunctionAddress, "ReturnValue");
		GetDatasmithUserData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDatasmithUserData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDatasmithUserData_IsValid = GetDatasmithUserData_FunctionAddress != IntPtr.Zero && GetDatasmithUserData_Object_IsValid && GetDatasmithUserData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetDatasmithUserData", GetDatasmithUserData_IsValid);
		GetAllObjectsAndValuesForKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllObjectsAndValuesForKey");
		GetAllObjectsAndValuesForKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllObjectsAndValuesForKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllObjectsAndValuesForKey_Key_PropertyAddress, GetAllObjectsAndValuesForKey_FunctionAddress, "Key");
		GetAllObjectsAndValuesForKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetAllObjectsAndValuesForKey_FunctionAddress, "Key");
		GetAllObjectsAndValuesForKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllObjectsAndValuesForKey_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllObjectsAndValuesForKey_ObjectClass_PropertyAddress, GetAllObjectsAndValuesForKey_FunctionAddress, "ObjectClass");
		GetAllObjectsAndValuesForKey_ObjectClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllObjectsAndValuesForKey_FunctionAddress, "ObjectClass");
		GetAllObjectsAndValuesForKey_ObjectClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllObjectsAndValuesForKey_FunctionAddress, "ObjectClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllObjectsAndValuesForKey_OutObjects_PropertyAddress, GetAllObjectsAndValuesForKey_FunctionAddress, "OutObjects");
		GetAllObjectsAndValuesForKey_OutObjects_Offset = NativeReflectionCached.GetPropertyOffset(GetAllObjectsAndValuesForKey_FunctionAddress, "OutObjects");
		GetAllObjectsAndValuesForKey_OutObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllObjectsAndValuesForKey_FunctionAddress, "OutObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllObjectsAndValuesForKey_OutValues_PropertyAddress, GetAllObjectsAndValuesForKey_FunctionAddress, "OutValues");
		GetAllObjectsAndValuesForKey_OutValues_Offset = NativeReflectionCached.GetPropertyOffset(GetAllObjectsAndValuesForKey_FunctionAddress, "OutValues");
		GetAllObjectsAndValuesForKey_OutValues_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllObjectsAndValuesForKey_FunctionAddress, "OutValues", Classes.FArrayProperty);
		GetAllObjectsAndValuesForKey_IsValid = GetAllObjectsAndValuesForKey_FunctionAddress != IntPtr.Zero && GetAllObjectsAndValuesForKey_Key_IsValid && GetAllObjectsAndValuesForKey_ObjectClass_IsValid && GetAllObjectsAndValuesForKey_OutObjects_IsValid && GetAllObjectsAndValuesForKey_OutValues_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetAllObjectsAndValuesForKey", GetAllObjectsAndValuesForKey_IsValid);
		GetAllDatasmithUserData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllDatasmithUserData");
		GetAllDatasmithUserData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllDatasmithUserData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllDatasmithUserData_ObjectClass_PropertyAddress, GetAllDatasmithUserData_FunctionAddress, "ObjectClass");
		GetAllDatasmithUserData_ObjectClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllDatasmithUserData_FunctionAddress, "ObjectClass");
		GetAllDatasmithUserData_ObjectClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllDatasmithUserData_FunctionAddress, "ObjectClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllDatasmithUserData_OutUserData_PropertyAddress, GetAllDatasmithUserData_FunctionAddress, "OutUserData");
		GetAllDatasmithUserData_OutUserData_Offset = NativeReflectionCached.GetPropertyOffset(GetAllDatasmithUserData_FunctionAddress, "OutUserData");
		GetAllDatasmithUserData_OutUserData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllDatasmithUserData_FunctionAddress, "OutUserData", Classes.FArrayProperty);
		GetAllDatasmithUserData_IsValid = GetAllDatasmithUserData_FunctionAddress != IntPtr.Zero && GetAllDatasmithUserData_ObjectClass_IsValid && GetAllDatasmithUserData_OutUserData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DatasmithContent.DatasmithContentBlueprintLibrary:GetAllDatasmithUserData", GetAllDatasmithUserData_IsValid);
	}
}
