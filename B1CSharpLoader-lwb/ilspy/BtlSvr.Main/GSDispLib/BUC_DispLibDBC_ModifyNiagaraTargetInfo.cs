using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo")]
public struct BUC_DispLibDBC_ModifyNiagaraTargetInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("过滤模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo:FilterMode")]
	public DispLibDBCNiagaraFilterMode FilterMode;

	[UMeta(MD.ToolTip, "")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("目标字符")]
	[UMeta(MDProp.EditCondition, "FilterMode == DispLibDBCNiagaraFilterMode::ByTags || FilterMode == DispLibDBCNiagaraFilterMode::ByExcludeTags || FilterMode == DispLibDBCNiagaraFilterMode::ByName || FilterMode == DispLibDBCNiagaraFilterMode::ByExcludeName")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo:TargetString")]
	public List<FName> TargetString;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "FilterMode == DispLibDBCNiagaraFilterMode::BySystemAsset || FilterMode == DispLibDBCNiagaraFilterMode::ByExcludeSystemAsset")]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("目标模板")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo:TargetSystem")]
	public UNiagaraSystem TargetSystem;

	private static int BUC_DispLibDBC_ModifyNiagaraTargetInfo_StructSize;

	private static int BUC_DispLibDBC_ModifyNiagaraTargetInfo_IsValid;

	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static FFieldAddress FilterMode_PropertyAddress;

	private static bool TargetString_IsValid;

	private static int TargetString_Offset;

	private static FFieldAddress TargetString_PropertyAddress;

	private static bool TargetSystem_IsValid;

	private static int TargetSystem_Offset;

	public bool isVaild()
	{
		switch (FilterMode)
		{
		case DispLibDBCNiagaraFilterMode.ByName:
		case DispLibDBCNiagaraFilterMode.ByExcludeName:
		case DispLibDBCNiagaraFilterMode.ByTags:
		case DispLibDBCNiagaraFilterMode.ByExcludeTags:
			if (TargetString.Count == 0)
			{
				return false;
			}
			break;
		case DispLibDBCNiagaraFilterMode.BySystemAsset:
		case DispLibDBCNiagaraFilterMode.ByExcludeSystemAsset:
			if (TargetSystem.IsNullOrDestroyed())
			{
				return false;
			}
			break;
		}
		return true;
	}

	public BUC_DispLibDBC_ModifyNiagaraTargetInfo Copy()
	{
		BUC_DispLibDBC_ModifyNiagaraTargetInfo result = this;
		if (TargetString != null)
		{
			result.TargetString = new List<FName>(TargetString);
		}
		return result;
	}

	public static BUC_DispLibDBC_ModifyNiagaraTargetInfo FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_ModifyNiagaraTargetInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_ModifyNiagaraTargetInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_ModifyNiagaraTargetInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_ModifyNiagaraTargetInfo(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyNiagaraTargetInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_ModifyNiagaraTargetInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ModifyNiagaraTargetInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyNiagaraTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo");
			return;
		}
		EnumMarshaler<DispLibDBCNiagaraFilterMode>.ToNative(IntPtr.Add(nativeStruct, FilterMode_Offset), 0, FilterMode_PropertyAddress.Address, FilterMode);
		new TArrayCopyMarshaler<FName>(1, TargetString_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TargetString_Offset), TargetString);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, TargetSystem_Offset), TargetSystem);
	}

	public BUC_DispLibDBC_ModifyNiagaraTargetInfo(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ModifyNiagaraTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo");
			FilterMode = DispLibDBCNiagaraFilterMode.AllNiagara;
			TargetString = null;
			TargetSystem = null;
		}
		else
		{
			FilterMode = EnumMarshaler<DispLibDBCNiagaraFilterMode>.FromNative(IntPtr.Add(nativeStruct, FilterMode_Offset), 0, FilterMode_PropertyAddress.Address);
			TargetString = new TArrayCopyMarshaler<FName>(1, TargetString_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TargetString_Offset));
			TargetSystem = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, TargetSystem_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo");
		BUC_DispLibDBC_ModifyNiagaraTargetInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref FilterMode_PropertyAddress, intPtr, "FilterMode");
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TargetString_PropertyAddress, intPtr, "TargetString");
		TargetString_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetString");
		TargetString_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetString", Classes.FArrayProperty);
		TargetSystem_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSystem");
		TargetSystem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSystem", Classes.FObjectProperty);
		BUC_DispLibDBC_ModifyNiagaraTargetInfo_IsValid = ((intPtr != IntPtr.Zero && FilterMode_IsValid && TargetString_IsValid && TargetSystem_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_ModifyNiagaraTargetInfo", (byte)BUC_DispLibDBC_ModifyNiagaraTargetInfo_IsValid != 0);
	}

	static BUC_DispLibDBC_ModifyNiagaraTargetInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_ModifyNiagaraTargetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_ModifyNiagaraTargetInfo));
	}
}
