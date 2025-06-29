using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting")]
public struct TreeImposter_OverrideTexSetting
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:TexName")]
	public FName TexName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:SRGB")]
	public bool SRGB;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:CompressionSettings")]
	public ETextureCompressionSettings CompressionSettings;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:LODGroup")]
	public ETextureGroup LODGroup;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:CompressionNoAlpha")]
	public bool CompressionNoAlpha;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:Filter")]
	public ETextureFilter Filter;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideTexSetting:isVT")]
	public bool isVT;

	private static int TreeImposter_OverrideTexSetting_StructSize;

	private static int TreeImposter_OverrideTexSetting_IsValid;

	private static bool TexName_IsValid;

	private static int TexName_Offset;

	private static bool SRGB_IsValid;

	private static int SRGB_Offset;

	private static FFieldAddress SRGB_PropertyAddress;

	private static bool CompressionSettings_IsValid;

	private static int CompressionSettings_Offset;

	private static FFieldAddress CompressionSettings_PropertyAddress;

	private static bool LODGroup_IsValid;

	private static int LODGroup_Offset;

	private static FFieldAddress LODGroup_PropertyAddress;

	private static bool CompressionNoAlpha_IsValid;

	private static int CompressionNoAlpha_Offset;

	private static FFieldAddress CompressionNoAlpha_PropertyAddress;

	private static bool Filter_IsValid;

	private static int Filter_Offset;

	private static FFieldAddress Filter_PropertyAddress;

	private static bool isVT_IsValid;

	private static int isVT_Offset;

	private static FFieldAddress isVT_PropertyAddress;

	public TreeImposter_OverrideTexSetting(FName _TexName, bool _SRGB, ETextureCompressionSettings _CompressionSettings, ETextureGroup _LODGroup, bool _CompressionNoAlpha, ETextureFilter _Filter, bool _isVT)
	{
		TexName = _TexName;
		SRGB = _SRGB;
		CompressionSettings = _CompressionSettings;
		LODGroup = _LODGroup;
		CompressionNoAlpha = _CompressionNoAlpha;
		Filter = _Filter;
		isVT = _isVT;
	}

	public TreeImposter_OverrideTexSetting Copy()
	{
		return this;
	}

	public static TreeImposter_OverrideTexSetting FromNative(IntPtr nativeBuffer)
	{
		return new TreeImposter_OverrideTexSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TreeImposter_OverrideTexSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TreeImposter_OverrideTexSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TreeImposter_OverrideTexSetting(IntPtr.Add(nativeBuffer, arrayIndex * TreeImposter_OverrideTexSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TreeImposter_OverrideTexSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TreeImposter_OverrideTexSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TreeImposter_OverrideTexSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeImposter_OverrideTexSetting");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TexName_Offset), TexName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SRGB_Offset), 0, SRGB_PropertyAddress.Address, SRGB);
		EnumMarshaler<ETextureCompressionSettings>.ToNative(IntPtr.Add(nativeStruct, CompressionSettings_Offset), 0, CompressionSettings_PropertyAddress.Address, CompressionSettings);
		EnumMarshaler<ETextureGroup>.ToNative(IntPtr.Add(nativeStruct, LODGroup_Offset), 0, LODGroup_PropertyAddress.Address, LODGroup);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CompressionNoAlpha_Offset), 0, CompressionNoAlpha_PropertyAddress.Address, CompressionNoAlpha);
		EnumMarshaler<ETextureFilter>.ToNative(IntPtr.Add(nativeStruct, Filter_Offset), 0, Filter_PropertyAddress.Address, Filter);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, isVT_Offset), 0, isVT_PropertyAddress.Address, isVT);
	}

	public TreeImposter_OverrideTexSetting(IntPtr nativeStruct)
	{
		if (TreeImposter_OverrideTexSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeImposter_OverrideTexSetting");
			TexName = default(FName);
			SRGB = false;
			CompressionSettings = ETextureCompressionSettings.TC_Default;
			LODGroup = ETextureGroup.TEXTUREGROUP_World;
			CompressionNoAlpha = false;
			Filter = ETextureFilter.TF_Nearest;
			isVT = false;
		}
		else
		{
			TexName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TexName_Offset));
			SRGB = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SRGB_Offset), 0, SRGB_PropertyAddress.Address);
			CompressionSettings = EnumMarshaler<ETextureCompressionSettings>.FromNative(IntPtr.Add(nativeStruct, CompressionSettings_Offset), 0, CompressionSettings_PropertyAddress.Address);
			LODGroup = EnumMarshaler<ETextureGroup>.FromNative(IntPtr.Add(nativeStruct, LODGroup_Offset), 0, LODGroup_PropertyAddress.Address);
			CompressionNoAlpha = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CompressionNoAlpha_Offset), 0, CompressionNoAlpha_PropertyAddress.Address);
			Filter = EnumMarshaler<ETextureFilter>.FromNative(IntPtr.Add(nativeStruct, Filter_Offset), 0, Filter_PropertyAddress.Address);
			isVT = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, isVT_Offset), 0, isVT_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TreeImposter_OverrideTexSetting");
		TreeImposter_OverrideTexSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		TexName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TexName");
		TexName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TexName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SRGB_PropertyAddress, intPtr, "SRGB");
		SRGB_Offset = NativeReflection.GetPropertyOffset(intPtr, "SRGB");
		SRGB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SRGB", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CompressionSettings_PropertyAddress, intPtr, "CompressionSettings");
		CompressionSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompressionSettings");
		CompressionSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompressionSettings", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LODGroup_PropertyAddress, intPtr, "LODGroup");
		LODGroup_Offset = NativeReflection.GetPropertyOffset(intPtr, "LODGroup");
		LODGroup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LODGroup", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompressionNoAlpha_PropertyAddress, intPtr, "CompressionNoAlpha");
		CompressionNoAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompressionNoAlpha");
		CompressionNoAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompressionNoAlpha", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Filter_PropertyAddress, intPtr, "Filter");
		Filter_Offset = NativeReflection.GetPropertyOffset(intPtr, "Filter");
		Filter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Filter", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref isVT_PropertyAddress, intPtr, "isVT");
		isVT_Offset = NativeReflection.GetPropertyOffset(intPtr, "isVT");
		isVT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "isVT", Classes.FBoolProperty);
		TreeImposter_OverrideTexSetting_IsValid = ((intPtr != IntPtr.Zero && TexName_IsValid && SRGB_IsValid && CompressionSettings_IsValid && LODGroup_IsValid && CompressionNoAlpha_IsValid && Filter_IsValid && isVT_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TreeImposter_OverrideTexSetting", (byte)TreeImposter_OverrideTexSetting_IsValid != 0);
	}

	static TreeImposter_OverrideTexSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TreeImposter_OverrideTexSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TreeImposter_OverrideTexSetting));
	}
}
