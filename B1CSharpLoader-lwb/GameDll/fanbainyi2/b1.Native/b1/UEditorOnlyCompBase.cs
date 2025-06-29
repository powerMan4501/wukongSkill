using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.EditorOnlyCompBase", "b1", UnrealModuleType.Game)]
public class UEditorOnlyCompBase : UActorComponent, IGsSmartParamObject, IInterface
{
	private static bool PreSaveCS_IsValid;

	private IntPtr PreSaveCS_InstanceFunctionAddress;

	private static IntPtr PreSaveCS_FunctionAddress;

	private static int PreSaveCS_ParamsSize;

	private static bool GetPossibleParamsCS_IsValid;

	private IntPtr GetPossibleParamsCS_InstanceFunctionAddress;

	private static IntPtr GetPossibleParamsCS_FunctionAddress;

	private static int GetPossibleParamsCS_ParamsSize;

	private static bool GetPossibleParamsCS_ParentPropertyName_IsValid;

	private static FFieldAddress GetPossibleParamsCS_ParentPropertyName_PropertyAddress;

	private static int GetPossibleParamsCS_ParentPropertyName_Offset;

	private static bool GetPossibleParamsCS_PropertyName_IsValid;

	private static FFieldAddress GetPossibleParamsCS_PropertyName_PropertyAddress;

	private static int GetPossibleParamsCS_PropertyName_Offset;

	private static bool GetPossibleParamsCS_OutParamArray_IsValid;

	private static FFieldAddress GetPossibleParamsCS_OutParamArray_PropertyAddress;

	private static int GetPossibleParamsCS_OutParamArray_Offset;

	private static bool GetParamDisplayNameCS_IsValid;

	private IntPtr GetParamDisplayNameCS_InstanceFunctionAddress;

	private static IntPtr GetParamDisplayNameCS_FunctionAddress;

	private static int GetParamDisplayNameCS_ParamsSize;

	private static bool GetParamDisplayNameCS_PropertyName_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_PropertyName_PropertyAddress;

	private static int GetParamDisplayNameCS_PropertyName_Offset;

	private static bool GetParamDisplayNameCS_ConfigGuid_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_ConfigGuid_PropertyAddress;

	private static int GetParamDisplayNameCS_ConfigGuid_Offset;

	private static bool GetParamDisplayNameCS_ReturnValue_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_ReturnValue_PropertyAddress;

	private static int GetParamDisplayNameCS_ReturnValue_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.EditorOnlyCompBase:PreSaveCS")]
	public unsafe void PreSaveCS()
	{
		CheckDestroyed();
		if (!PreSaveCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EditorOnlyCompBase:PreSaveCS");
			return;
		}
		if (PreSaveCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreSaveCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreSaveCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreSaveCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreSaveCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreSaveCS_InstanceFunctionAddress, argsSize: PreSaveCS_ParamsSize);
	}

	protected unsafe virtual void PreSaveCS_Implementation()
	{
		CheckDestroyed();
		if (!PreSaveCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EditorOnlyCompBase:PreSaveCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreSaveCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreSaveCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreSaveCS_FunctionAddress, argsSize: PreSaveCS_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.EditorOnlyCompBase:GetPossibleParamsCS")]
	public unsafe void GetPossibleParamsCS(string ParentPropertyName, string PropertyName, out List<FCalliopeGuid> OutParamArray)
	{
		CheckDestroyed();
		if (!GetPossibleParamsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EditorOnlyCompBase:GetPossibleParamsCS");
			OutParamArray = null;
			return;
		}
		if (GetPossibleParamsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetPossibleParamsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetPossibleParamsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPossibleParamsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPossibleParamsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_ParentPropertyName_Offset), 0, GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_PropertyName_Offset), 0, GetPossibleParamsCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPossibleParamsCS_InstanceFunctionAddress, intPtr, GetPossibleParamsCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_PropertyName_PropertyAddress.Address, intPtr);
		OutParamArray = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetPossibleParamsCS_OutParamArray_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative).FromNative(IntPtr.Add(intPtr, GetPossibleParamsCS_OutParamArray_Offset));
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_OutParamArray_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GetPossibleParamsCS_Implementation(string ParentPropertyName, string PropertyName, out List<FCalliopeGuid> OutParamArray)
	{
		CheckDestroyed();
		if (!GetPossibleParamsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EditorOnlyCompBase:GetPossibleParamsCS");
			OutParamArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPossibleParamsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPossibleParamsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_ParentPropertyName_Offset), 0, GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_PropertyName_Offset), 0, GetPossibleParamsCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPossibleParamsCS_FunctionAddress, intPtr, GetPossibleParamsCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_PropertyName_PropertyAddress.Address, intPtr);
		OutParamArray = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetPossibleParamsCS_OutParamArray_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative).FromNative(IntPtr.Add(intPtr, GetPossibleParamsCS_OutParamArray_Offset));
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_OutParamArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.EditorOnlyCompBase:GetParamDisplayNameCS")]
	public unsafe string GetParamDisplayNameCS(string PropertyName, FCalliopeGuid ConfigGuid)
	{
		CheckDestroyed();
		if (!GetParamDisplayNameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EditorOnlyCompBase:GetParamDisplayNameCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetParamDisplayNameCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetParamDisplayNameCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetParamDisplayNameCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParamDisplayNameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParamDisplayNameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_PropertyName_Offset), 0, GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(GetParamDisplayNameCS_ConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_ConfigGuid_Offset), 0, GetParamDisplayNameCS_ConfigGuid_PropertyAddress.Address, ConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParamDisplayNameCS_InstanceFunctionAddress, intPtr, GetParamDisplayNameCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_ReturnValue_Offset), 0, GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetParamDisplayNameCS_Implementation(string PropertyName, FCalliopeGuid ConfigGuid)
	{
		CheckDestroyed();
		if (!GetParamDisplayNameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EditorOnlyCompBase:GetParamDisplayNameCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParamDisplayNameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParamDisplayNameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_PropertyName_Offset), 0, GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(GetParamDisplayNameCS_ConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_ConfigGuid_Offset), 0, GetParamDisplayNameCS_ConfigGuid_PropertyAddress.Address, ConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParamDisplayNameCS_FunctionAddress, intPtr, GetParamDisplayNameCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_ReturnValue_Offset), 0, GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UEditorOnlyCompBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorOnlyCompBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorOnlyCompBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.EditorOnlyCompBase");
		PreSaveCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreSaveCS");
		PreSaveCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreSaveCS_FunctionAddress);
		PreSaveCS_IsValid = PreSaveCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.EditorOnlyCompBase:PreSaveCS", PreSaveCS_IsValid);
		GetPossibleParamsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPossibleParamsCS");
		GetPossibleParamsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPossibleParamsCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_ParentPropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_PropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_OutParamArray_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "OutParamArray", Classes.FArrayProperty);
		GetPossibleParamsCS_IsValid = GetPossibleParamsCS_FunctionAddress != IntPtr.Zero && GetPossibleParamsCS_ParentPropertyName_IsValid && GetPossibleParamsCS_PropertyName_IsValid && GetPossibleParamsCS_OutParamArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.EditorOnlyCompBase:GetPossibleParamsCS", GetPossibleParamsCS_IsValid);
		GetParamDisplayNameCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParamDisplayNameCS");
		GetParamDisplayNameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParamDisplayNameCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_PropertyName_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_ConfigGuid_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "ConfigGuid");
		GetParamDisplayNameCS_ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "ConfigGuid");
		GetParamDisplayNameCS_ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "ConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_ReturnValue_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetParamDisplayNameCS_IsValid = GetParamDisplayNameCS_FunctionAddress != IntPtr.Zero && GetParamDisplayNameCS_PropertyName_IsValid && GetParamDisplayNameCS_ConfigGuid_IsValid && GetParamDisplayNameCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.EditorOnlyCompBase:GetParamDisplayNameCS", GetParamDisplayNameCS_IsValid);
	}
}
