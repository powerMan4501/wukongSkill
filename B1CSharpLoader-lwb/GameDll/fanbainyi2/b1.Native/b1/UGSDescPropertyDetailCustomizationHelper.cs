using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.GSDescPropertyDetailCustomizationHelper", "b1", UnrealModuleType.Game)]
public class UGSDescPropertyDetailCustomizationHelper : UObject
{
	private static bool OnGetRowStrings_IsValid;

	private IntPtr OnGetRowStrings_InstanceFunctionAddress;

	private static IntPtr OnGetRowStrings_FunctionAddress;

	private static int OnGetRowStrings_ParamsSize;

	private static bool OnGetRowStrings_OutStrings_IsValid;

	private static FFieldAddress OnGetRowStrings_OutStrings_PropertyAddress;

	private static int OnGetRowStrings_OutStrings_Offset;

	private static bool OnGetRowStrings_OutRestrictedItems_IsValid;

	private static FFieldAddress OnGetRowStrings_OutRestrictedItems_PropertyAddress;

	private static int OnGetRowStrings_OutRestrictedItems_Offset;

	private static bool GetRowNameByDescId_IsValid;

	private IntPtr GetRowNameByDescId_InstanceFunctionAddress;

	private static IntPtr GetRowNameByDescId_FunctionAddress;

	private static int GetRowNameByDescId_ParamsSize;

	private static bool GetRowNameByDescId_DescID_IsValid;

	private static FFieldAddress GetRowNameByDescId_DescID_PropertyAddress;

	private static int GetRowNameByDescId_DescID_Offset;

	private static bool GetRowNameByDescId_RowName_IsValid;

	private static FFieldAddress GetRowNameByDescId_RowName_PropertyAddress;

	private static int GetRowNameByDescId_RowName_Offset;

	private static bool GetRowNameByDescId_ReturnValue_IsValid;

	private static FFieldAddress GetRowNameByDescId_ReturnValue_PropertyAddress;

	private static int GetRowNameByDescId_ReturnValue_Offset;

	private static bool FindDescIdByRowName_IsValid;

	private IntPtr FindDescIdByRowName_InstanceFunctionAddress;

	private static IntPtr FindDescIdByRowName_FunctionAddress;

	private static int FindDescIdByRowName_ParamsSize;

	private static bool FindDescIdByRowName_RowName_IsValid;

	private static FFieldAddress FindDescIdByRowName_RowName_PropertyAddress;

	private static int FindDescIdByRowName_RowName_Offset;

	private static bool FindDescIdByRowName_ReturnValue_IsValid;

	private static FFieldAddress FindDescIdByRowName_ReturnValue_PropertyAddress;

	private static int FindDescIdByRowName_ReturnValue_Offset;

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.GSDescPropertyDetailCustomizationHelper:OnGetRowStrings")]
	public unsafe void OnGetRowStrings(out List<string> OutStrings, out List<bool> OutRestrictedItems)
	{
		CheckDestroyed();
		if (!OnGetRowStrings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSDescPropertyDetailCustomizationHelper:OnGetRowStrings");
			OutStrings = null;
			OutRestrictedItems = null;
			return;
		}
		if (OnGetRowStrings_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnGetRowStrings_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnGetRowStrings");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGetRowStrings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetRowStrings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGetRowStrings_InstanceFunctionAddress, intPtr, OnGetRowStrings_ParamsSize);
		OutStrings = new TArrayCopyMarshaler<string>(1, OnGetRowStrings_OutStrings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OnGetRowStrings_OutStrings_Offset));
		NativeReflection.DestroyValue_InContainer(OnGetRowStrings_OutStrings_PropertyAddress.Address, intPtr);
		OutRestrictedItems = new TArrayCopyMarshaler<bool>(1, OnGetRowStrings_OutRestrictedItems_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OnGetRowStrings_OutRestrictedItems_Offset));
		NativeReflection.DestroyValue_InContainer(OnGetRowStrings_OutRestrictedItems_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnGetRowStrings_Implementation(out List<string> OutStrings, out List<bool> OutRestrictedItems)
	{
		CheckDestroyed();
		if (!OnGetRowStrings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSDescPropertyDetailCustomizationHelper:OnGetRowStrings");
			OutStrings = null;
			OutRestrictedItems = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGetRowStrings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetRowStrings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGetRowStrings_FunctionAddress, intPtr, OnGetRowStrings_ParamsSize);
		OutStrings = new TArrayCopyMarshaler<string>(1, OnGetRowStrings_OutStrings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OnGetRowStrings_OutStrings_Offset));
		NativeReflection.DestroyValue_InContainer(OnGetRowStrings_OutStrings_PropertyAddress.Address, intPtr);
		OutRestrictedItems = new TArrayCopyMarshaler<bool>(1, OnGetRowStrings_OutRestrictedItems_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OnGetRowStrings_OutRestrictedItems_Offset));
		NativeReflection.DestroyValue_InContainer(OnGetRowStrings_OutRestrictedItems_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.GSDescPropertyDetailCustomizationHelper:GetRowNameByDescId")]
	public unsafe bool GetRowNameByDescId(int DescID, out FName RowName)
	{
		CheckDestroyed();
		if (!GetRowNameByDescId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSDescPropertyDetailCustomizationHelper:GetRowNameByDescId");
			RowName = default(FName);
			return false;
		}
		if (GetRowNameByDescId_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRowNameByDescId_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRowNameByDescId");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRowNameByDescId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRowNameByDescId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRowNameByDescId_DescID_Offset), 0, GetRowNameByDescId_DescID_PropertyAddress.Address, DescID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRowNameByDescId_InstanceFunctionAddress, intPtr, GetRowNameByDescId_ParamsSize);
		RowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetRowNameByDescId_RowName_Offset), 0, GetRowNameByDescId_RowName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRowNameByDescId_ReturnValue_Offset), 0, GetRowNameByDescId_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetRowNameByDescId_Implementation(int DescID, out FName RowName)
	{
		CheckDestroyed();
		if (!GetRowNameByDescId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSDescPropertyDetailCustomizationHelper:GetRowNameByDescId");
			RowName = default(FName);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRowNameByDescId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRowNameByDescId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRowNameByDescId_DescID_Offset), 0, GetRowNameByDescId_DescID_PropertyAddress.Address, DescID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRowNameByDescId_FunctionAddress, intPtr, GetRowNameByDescId_ParamsSize);
		RowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetRowNameByDescId_RowName_Offset), 0, GetRowNameByDescId_RowName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRowNameByDescId_ReturnValue_Offset), 0, GetRowNameByDescId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.GSDescPropertyDetailCustomizationHelper:FindDescIdByRowName")]
	public unsafe int FindDescIdByRowName(FName RowName)
	{
		CheckDestroyed();
		if (!FindDescIdByRowName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSDescPropertyDetailCustomizationHelper:FindDescIdByRowName");
			return 0;
		}
		if (FindDescIdByRowName_InstanceFunctionAddress == IntPtr.Zero)
		{
			FindDescIdByRowName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "FindDescIdByRowName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindDescIdByRowName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindDescIdByRowName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindDescIdByRowName_RowName_Offset), 0, FindDescIdByRowName_RowName_PropertyAddress.Address, RowName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindDescIdByRowName_InstanceFunctionAddress, intPtr, FindDescIdByRowName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindDescIdByRowName_ReturnValue_Offset), 0, FindDescIdByRowName_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int FindDescIdByRowName_Implementation(FName RowName)
	{
		CheckDestroyed();
		if (!FindDescIdByRowName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSDescPropertyDetailCustomizationHelper:FindDescIdByRowName");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindDescIdByRowName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindDescIdByRowName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindDescIdByRowName_RowName_Offset), 0, FindDescIdByRowName_RowName_PropertyAddress.Address, RowName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindDescIdByRowName_FunctionAddress, intPtr, FindDescIdByRowName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindDescIdByRowName_ReturnValue_Offset), 0, FindDescIdByRowName_ReturnValue_PropertyAddress.Address);
	}

	static UGSDescPropertyDetailCustomizationHelper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSDescPropertyDetailCustomizationHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSDescPropertyDetailCustomizationHelper));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.GSDescPropertyDetailCustomizationHelper");
		OnGetRowStrings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGetRowStrings");
		OnGetRowStrings_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetRowStrings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGetRowStrings_OutStrings_PropertyAddress, OnGetRowStrings_FunctionAddress, "OutStrings");
		OnGetRowStrings_OutStrings_Offset = NativeReflectionCached.GetPropertyOffset(OnGetRowStrings_FunctionAddress, "OutStrings");
		OnGetRowStrings_OutStrings_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetRowStrings_FunctionAddress, "OutStrings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGetRowStrings_OutRestrictedItems_PropertyAddress, OnGetRowStrings_FunctionAddress, "OutRestrictedItems");
		OnGetRowStrings_OutRestrictedItems_Offset = NativeReflectionCached.GetPropertyOffset(OnGetRowStrings_FunctionAddress, "OutRestrictedItems");
		OnGetRowStrings_OutRestrictedItems_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetRowStrings_FunctionAddress, "OutRestrictedItems", Classes.FArrayProperty);
		OnGetRowStrings_IsValid = OnGetRowStrings_FunctionAddress != IntPtr.Zero && OnGetRowStrings_OutStrings_IsValid && OnGetRowStrings_OutRestrictedItems_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSDescPropertyDetailCustomizationHelper:OnGetRowStrings", OnGetRowStrings_IsValid);
		GetRowNameByDescId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRowNameByDescId");
		GetRowNameByDescId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRowNameByDescId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRowNameByDescId_DescID_PropertyAddress, GetRowNameByDescId_FunctionAddress, "DescID");
		GetRowNameByDescId_DescID_Offset = NativeReflectionCached.GetPropertyOffset(GetRowNameByDescId_FunctionAddress, "DescID");
		GetRowNameByDescId_DescID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRowNameByDescId_FunctionAddress, "DescID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRowNameByDescId_RowName_PropertyAddress, GetRowNameByDescId_FunctionAddress, "RowName");
		GetRowNameByDescId_RowName_Offset = NativeReflectionCached.GetPropertyOffset(GetRowNameByDescId_FunctionAddress, "RowName");
		GetRowNameByDescId_RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRowNameByDescId_FunctionAddress, "RowName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRowNameByDescId_ReturnValue_PropertyAddress, GetRowNameByDescId_FunctionAddress, "ReturnValue");
		GetRowNameByDescId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRowNameByDescId_FunctionAddress, "ReturnValue");
		GetRowNameByDescId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRowNameByDescId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRowNameByDescId_IsValid = GetRowNameByDescId_FunctionAddress != IntPtr.Zero && GetRowNameByDescId_DescID_IsValid && GetRowNameByDescId_RowName_IsValid && GetRowNameByDescId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSDescPropertyDetailCustomizationHelper:GetRowNameByDescId", GetRowNameByDescId_IsValid);
		FindDescIdByRowName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindDescIdByRowName");
		FindDescIdByRowName_ParamsSize = NativeReflection.GetFunctionParamsSize(FindDescIdByRowName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindDescIdByRowName_RowName_PropertyAddress, FindDescIdByRowName_FunctionAddress, "RowName");
		FindDescIdByRowName_RowName_Offset = NativeReflectionCached.GetPropertyOffset(FindDescIdByRowName_FunctionAddress, "RowName");
		FindDescIdByRowName_RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDescIdByRowName_FunctionAddress, "RowName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindDescIdByRowName_ReturnValue_PropertyAddress, FindDescIdByRowName_FunctionAddress, "ReturnValue");
		FindDescIdByRowName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindDescIdByRowName_FunctionAddress, "ReturnValue");
		FindDescIdByRowName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDescIdByRowName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindDescIdByRowName_IsValid = FindDescIdByRowName_FunctionAddress != IntPtr.Zero && FindDescIdByRowName_RowName_IsValid && FindDescIdByRowName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSDescPropertyDetailCustomizationHelper:FindDescIdByRowName", FindDescIdByRowName_IsValid);
	}
}
