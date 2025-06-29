using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo")]
public struct BUC_DispLibDBC_MaterialEffectTargetInfo
{
	[DisplayName("影响Comps")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo:CompsFilterMode")]
	public DispLibDBCCompsFilterMode CompsFilterMode;

	[DisplayName("CompTags")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "包含其中之一即匹配")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo:CompTags")]
	public List<FName> CompTags;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响材质")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo:MatsFilterMode")]
	public DispLibDBCMaterialsFilterMode MatsFilterMode;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质插槽名")]
	[UMeta(MD.ToolTip, "")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo:MatSlotNames")]
	public List<FName> MatSlotNames;

	[EditAnywhere]
	[DisplayName("材质Index")]
	[UProperty]
	[UMeta(MD.ToolTip, "")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo:MatIndexes")]
	public List<int> MatIndexes;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质Shader")]
	[UMeta(MD.ToolTip, "")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo:MatShaders")]
	public List<UMaterial> MatShaders;

	public static BUC_DispLibDBC_MaterialEffectTargetInfo AllCompsAllMats;

	public static BUC_DispLibDBC_MaterialEffectTargetInfo CompsByTagAllMats_CreateMIDOnBeginPlay;

	private static int BUC_DispLibDBC_MaterialEffectTargetInfo_StructSize;

	private static int BUC_DispLibDBC_MaterialEffectTargetInfo_IsValid;

	private static bool CompsFilterMode_IsValid;

	private static int CompsFilterMode_Offset;

	private static FFieldAddress CompsFilterMode_PropertyAddress;

	private static bool CompTags_IsValid;

	private static int CompTags_Offset;

	private static FFieldAddress CompTags_PropertyAddress;

	private static bool MatsFilterMode_IsValid;

	private static int MatsFilterMode_Offset;

	private static FFieldAddress MatsFilterMode_PropertyAddress;

	private static bool MatSlotNames_IsValid;

	private static int MatSlotNames_Offset;

	private static FFieldAddress MatSlotNames_PropertyAddress;

	private static bool MatIndexes_IsValid;

	private static int MatIndexes_Offset;

	private static FFieldAddress MatIndexes_PropertyAddress;

	private static bool MatShaders_IsValid;

	private static int MatShaders_Offset;

	private static FFieldAddress MatShaders_PropertyAddress;

	public bool isVaild()
	{
		if (CompsFilterMode == DispLibDBCCompsFilterMode.ByTags && CompTags.Count == 0)
		{
			return false;
		}
		switch (MatsFilterMode)
		{
		case DispLibDBCMaterialsFilterMode.ByIndexes:
			if (MatIndexes.Count == 0)
			{
				return false;
			}
			break;
		case DispLibDBCMaterialsFilterMode.BySlotNames:
			if (MatSlotNames.Count == 0)
			{
				return false;
			}
			break;
		case DispLibDBCMaterialsFilterMode.ByUMaterial:
			if (MatShaders.Count == 0)
			{
				return false;
			}
			break;
		}
		return true;
	}

	public BUC_DispLibDBC_MaterialEffectTargetInfo(DispLibDBCCompsFilterMode _CompsFilterMode, List<FName> _CompTags, DispLibDBCMaterialsFilterMode _MatsFilterMode, List<FName> _MatSlotNames, List<int> _MatIndexes, List<UMaterial> _MatShaders)
	{
		CompsFilterMode = _CompsFilterMode;
		CompTags = _CompTags;
		MatsFilterMode = _MatsFilterMode;
		MatSlotNames = _MatSlotNames;
		MatIndexes = _MatIndexes;
		MatShaders = _MatShaders;
	}

	static BUC_DispLibDBC_MaterialEffectTargetInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_MaterialEffectTargetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_MaterialEffectTargetInfo));
		AllCompsAllMats = new BUC_DispLibDBC_MaterialEffectTargetInfo(DispLibDBCCompsFilterMode.AllComps, null, DispLibDBCMaterialsFilterMode.AllMats, null, null, null);
		CompsByTagAllMats_CreateMIDOnBeginPlay = new BUC_DispLibDBC_MaterialEffectTargetInfo(DispLibDBCCompsFilterMode.ByTags, new List<FName> { B1GlobalFNames.CreateMIDOnBeginPlay }, DispLibDBCMaterialsFilterMode.AllMats, null, null, null);
	}

	public BUC_DispLibDBC_MaterialEffectTargetInfo Copy()
	{
		BUC_DispLibDBC_MaterialEffectTargetInfo result = this;
		if (CompTags != null)
		{
			result.CompTags = new List<FName>(CompTags);
		}
		if (MatSlotNames != null)
		{
			result.MatSlotNames = new List<FName>(MatSlotNames);
		}
		if (MatIndexes != null)
		{
			result.MatIndexes = new List<int>(MatIndexes);
		}
		if (MatShaders != null)
		{
			result.MatShaders = new List<UMaterial>(MatShaders);
		}
		return result;
	}

	public static BUC_DispLibDBC_MaterialEffectTargetInfo FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_MaterialEffectTargetInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_MaterialEffectTargetInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_MaterialEffectTargetInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_MaterialEffectTargetInfo(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_MaterialEffectTargetInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_MaterialEffectTargetInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_MaterialEffectTargetInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_MaterialEffectTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo");
			return;
		}
		EnumMarshaler<DispLibDBCCompsFilterMode>.ToNative(IntPtr.Add(nativeStruct, CompsFilterMode_Offset), 0, CompsFilterMode_PropertyAddress.Address, CompsFilterMode);
		new TArrayCopyMarshaler<FName>(1, CompTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CompTags_Offset), CompTags);
		EnumMarshaler<DispLibDBCMaterialsFilterMode>.ToNative(IntPtr.Add(nativeStruct, MatsFilterMode_Offset), 0, MatsFilterMode_PropertyAddress.Address, MatsFilterMode);
		new TArrayCopyMarshaler<FName>(1, MatSlotNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatSlotNames_Offset), MatSlotNames);
		new TArrayCopyMarshaler<int>(1, MatIndexes_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatIndexes_Offset), MatIndexes);
		new TArrayCopyMarshaler<UMaterial>(1, MatShaders_PropertyAddress, CachedMarshalingDelegates<UMaterial, UObjectMarshaler<UMaterial>>.FromNative, CachedMarshalingDelegates<UMaterial, UObjectMarshaler<UMaterial>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatShaders_Offset), MatShaders);
	}

	public BUC_DispLibDBC_MaterialEffectTargetInfo(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_MaterialEffectTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo");
			CompsFilterMode = DispLibDBCCompsFilterMode.AllComps;
			CompTags = null;
			MatsFilterMode = DispLibDBCMaterialsFilterMode.AllMats;
			MatSlotNames = null;
			MatIndexes = null;
			MatShaders = null;
		}
		else
		{
			CompsFilterMode = EnumMarshaler<DispLibDBCCompsFilterMode>.FromNative(IntPtr.Add(nativeStruct, CompsFilterMode_Offset), 0, CompsFilterMode_PropertyAddress.Address);
			CompTags = new TArrayCopyMarshaler<FName>(1, CompTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CompTags_Offset));
			MatsFilterMode = EnumMarshaler<DispLibDBCMaterialsFilterMode>.FromNative(IntPtr.Add(nativeStruct, MatsFilterMode_Offset), 0, MatsFilterMode_PropertyAddress.Address);
			MatSlotNames = new TArrayCopyMarshaler<FName>(1, MatSlotNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatSlotNames_Offset));
			MatIndexes = new TArrayCopyMarshaler<int>(1, MatIndexes_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatIndexes_Offset));
			MatShaders = new TArrayCopyMarshaler<UMaterial>(1, MatShaders_PropertyAddress, CachedMarshalingDelegates<UMaterial, UObjectMarshaler<UMaterial>>.FromNative, CachedMarshalingDelegates<UMaterial, UObjectMarshaler<UMaterial>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatShaders_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo");
		BUC_DispLibDBC_MaterialEffectTargetInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CompsFilterMode_PropertyAddress, intPtr, "CompsFilterMode");
		CompsFilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompsFilterMode");
		CompsFilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompsFilterMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompTags_PropertyAddress, intPtr, "CompTags");
		CompTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTags");
		CompTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MatsFilterMode_PropertyAddress, intPtr, "MatsFilterMode");
		MatsFilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatsFilterMode");
		MatsFilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatsFilterMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MatSlotNames_PropertyAddress, intPtr, "MatSlotNames");
		MatSlotNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatSlotNames");
		MatSlotNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatSlotNames", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MatIndexes_PropertyAddress, intPtr, "MatIndexes");
		MatIndexes_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatIndexes");
		MatIndexes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatIndexes", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MatShaders_PropertyAddress, intPtr, "MatShaders");
		MatShaders_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatShaders");
		MatShaders_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatShaders", Classes.FArrayProperty);
		BUC_DispLibDBC_MaterialEffectTargetInfo_IsValid = ((intPtr != IntPtr.Zero && CompsFilterMode_IsValid && CompTags_IsValid && MatsFilterMode_IsValid && MatSlotNames_IsValid && MatIndexes_IsValid && MatShaders_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_MaterialEffectTargetInfo", (byte)BUC_DispLibDBC_MaterialEffectTargetInfo_IsValid != 0);
	}
}
