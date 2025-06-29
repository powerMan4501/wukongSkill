using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper")]
public class UGSSuperArmorDescCustomizationHelper : UGSDescPropertyDetailCustomizationHelper
{
	private static bool OnGetRowStrings_IsValid;

	private static IntPtr OnGetRowStrings_FunctionAddress;

	private static int OnGetRowStrings_ParamsSize;

	private static bool OnGetRowStrings_OutStrings_IsValid;

	private static int OnGetRowStrings_OutStrings_Offset;

	private static FFieldAddress OnGetRowStrings_OutStrings_PropertyAddress;

	private static bool OnGetRowStrings_OutRestrictedItems_IsValid;

	private static int OnGetRowStrings_OutRestrictedItems_Offset;

	private static FFieldAddress OnGetRowStrings_OutRestrictedItems_PropertyAddress;

	private static bool GetRowNameByDescId_IsValid;

	private static IntPtr GetRowNameByDescId_FunctionAddress;

	private static int GetRowNameByDescId_ParamsSize;

	private static bool GetRowNameByDescId_DescID_IsValid;

	private static int GetRowNameByDescId_DescID_Offset;

	private static bool GetRowNameByDescId_RowName_IsValid;

	private static int GetRowNameByDescId_RowName_Offset;

	private static bool GetRowNameByDescId_ReturnValue_IsValid;

	private static int GetRowNameByDescId_ReturnValue_Offset;

	private static FFieldAddress GetRowNameByDescId_ReturnValue_PropertyAddress;

	private static bool FindDescIdByRowName_IsValid;

	private static IntPtr FindDescIdByRowName_FunctionAddress;

	private static int FindDescIdByRowName_ParamsSize;

	private static bool FindDescIdByRowName_RowName_IsValid;

	private static int FindDescIdByRowName_RowName_Offset;

	private static bool FindDescIdByRowName_ReturnValue_IsValid;

	private static int FindDescIdByRowName_ReturnValue_Offset;

	[USharpPath("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:OnGetRowStrings")]
	protected override void OnGetRowStrings_Implementation(out List<string> OutStrings, out List<bool> OutRestrictedItems)
	{
		OutStrings = new List<string>();
		OutRestrictedItems = null;
	}

	[USharpPath("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:FindDescIdByRowName")]
	protected override int FindDescIdByRowName_Implementation(FName RowName)
	{
		foreach (KeyValuePair<int, FUStSuperArmorLevelDesc> item in BGW_GameDB.GetAllSuperArmorLevelDesc())
		{
			if (RowName.ToString() == item.Value.SuperArmorLevelName)
			{
				return item.Key;
			}
		}
		return -1;
	}

	[USharpPath("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:GetRowNameByDescId")]
	protected override bool GetRowNameByDescId_Implementation(int DescID, out FName RowName)
	{
		FUStSuperArmorLevelDesc superArmorLevelDescByID = BGW_GameDB.GetSuperArmorLevelDescByID(DescID);
		if (superArmorLevelDescByID != null)
		{
			RowName = new FName(superArmorLevelDescByID.SuperArmorLevelName);
		}
		else
		{
			RowName = B1GlobalFNames.None;
		}
		return superArmorLevelDescByID != null;
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:OnGetRowStrings")]
	private static void OnGetRowStrings__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSSuperArmorDescCustomizationHelper uGSSuperArmorDescCustomizationHelper = GCHelper.Find<UGSSuperArmorDescCustomizationHelper>(obj);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, OnGetRowStrings_OutStrings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> OutStrings = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, OnGetRowStrings_OutStrings_Offset));
		TArrayCopyMarshaler<bool> tArrayCopyMarshaler2 = new TArrayCopyMarshaler<bool>(1, OnGetRowStrings_OutRestrictedItems_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
		List<bool> OutRestrictedItems = tArrayCopyMarshaler2.FromNative(IntPtr.Add(buffer, OnGetRowStrings_OutRestrictedItems_Offset));
		uGSSuperArmorDescCustomizationHelper.OnGetRowStrings_Implementation(out OutStrings, out OutRestrictedItems);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, OnGetRowStrings_OutStrings_Offset), OutStrings);
		tArrayCopyMarshaler2.ToNative(IntPtr.Add(buffer, OnGetRowStrings_OutRestrictedItems_Offset), OutRestrictedItems);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:GetRowNameByDescId")]
	private static void GetRowNameByDescId__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSSuperArmorDescCustomizationHelper uGSSuperArmorDescCustomizationHelper = GCHelper.Find<UGSSuperArmorDescCustomizationHelper>(obj);
		int descID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GetRowNameByDescId_DescID_Offset));
		FName RowName;
		bool rowNameByDescId_Implementation = uGSSuperArmorDescCustomizationHelper.GetRowNameByDescId_Implementation(descID, out RowName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetRowNameByDescId_ReturnValue_Offset), 0, GetRowNameByDescId_ReturnValue_PropertyAddress.Address, rowNameByDescId_Implementation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, GetRowNameByDescId_RowName_Offset), RowName);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:FindDescIdByRowName")]
	private static void FindDescIdByRowName__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSSuperArmorDescCustomizationHelper uGSSuperArmorDescCustomizationHelper = GCHelper.Find<UGSSuperArmorDescCustomizationHelper>(obj);
		FName rowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, FindDescIdByRowName_RowName_Offset));
		int value = uGSSuperArmorDescCustomizationHelper.FindDescIdByRowName_Implementation(rowName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, FindDescIdByRowName_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper");
		OnGetRowStrings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGetRowStrings");
		OnGetRowStrings_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetRowStrings_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnGetRowStrings_OutStrings_PropertyAddress, OnGetRowStrings_FunctionAddress, "OutStrings");
		OnGetRowStrings_OutStrings_Offset = NativeReflection.GetPropertyOffset(OnGetRowStrings_FunctionAddress, "OutStrings");
		OnGetRowStrings_OutStrings_IsValid = NativeReflection.ValidatePropertyClass(OnGetRowStrings_FunctionAddress, "OutStrings", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OnGetRowStrings_OutRestrictedItems_PropertyAddress, OnGetRowStrings_FunctionAddress, "OutRestrictedItems");
		OnGetRowStrings_OutRestrictedItems_Offset = NativeReflection.GetPropertyOffset(OnGetRowStrings_FunctionAddress, "OutRestrictedItems");
		OnGetRowStrings_OutRestrictedItems_IsValid = NativeReflection.ValidatePropertyClass(OnGetRowStrings_FunctionAddress, "OutRestrictedItems", Classes.FArrayProperty);
		OnGetRowStrings_IsValid = OnGetRowStrings_FunctionAddress != IntPtr.Zero && OnGetRowStrings_OutStrings_IsValid && OnGetRowStrings_OutRestrictedItems_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:OnGetRowStrings", OnGetRowStrings_IsValid);
		GetRowNameByDescId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRowNameByDescId");
		GetRowNameByDescId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRowNameByDescId_FunctionAddress);
		GetRowNameByDescId_DescID_Offset = NativeReflection.GetPropertyOffset(GetRowNameByDescId_FunctionAddress, "DescID");
		GetRowNameByDescId_DescID_IsValid = NativeReflection.ValidatePropertyClass(GetRowNameByDescId_FunctionAddress, "DescID", Classes.FIntProperty);
		GetRowNameByDescId_RowName_Offset = NativeReflection.GetPropertyOffset(GetRowNameByDescId_FunctionAddress, "RowName");
		GetRowNameByDescId_RowName_IsValid = NativeReflection.ValidatePropertyClass(GetRowNameByDescId_FunctionAddress, "RowName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref GetRowNameByDescId_ReturnValue_PropertyAddress, GetRowNameByDescId_FunctionAddress, "ReturnValue");
		GetRowNameByDescId_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRowNameByDescId_FunctionAddress, "ReturnValue");
		GetRowNameByDescId_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRowNameByDescId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRowNameByDescId_IsValid = GetRowNameByDescId_FunctionAddress != IntPtr.Zero && GetRowNameByDescId_DescID_IsValid && GetRowNameByDescId_RowName_IsValid && GetRowNameByDescId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:GetRowNameByDescId", GetRowNameByDescId_IsValid);
		FindDescIdByRowName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindDescIdByRowName");
		FindDescIdByRowName_ParamsSize = NativeReflection.GetFunctionParamsSize(FindDescIdByRowName_FunctionAddress);
		FindDescIdByRowName_RowName_Offset = NativeReflection.GetPropertyOffset(FindDescIdByRowName_FunctionAddress, "RowName");
		FindDescIdByRowName_RowName_IsValid = NativeReflection.ValidatePropertyClass(FindDescIdByRowName_FunctionAddress, "RowName", Classes.FNameProperty);
		FindDescIdByRowName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindDescIdByRowName_FunctionAddress, "ReturnValue");
		FindDescIdByRowName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindDescIdByRowName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindDescIdByRowName_IsValid = FindDescIdByRowName_FunctionAddress != IntPtr.Zero && FindDescIdByRowName_RowName_IsValid && FindDescIdByRowName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSSuperArmorDescCustomizationHelper:FindDescIdByRowName", FindDescIdByRowName_IsValid);
	}

	static UGSSuperArmorDescCustomizationHelper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSSuperArmorDescCustomizationHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSSuperArmorDescCustomizationHelper));
	}
}
