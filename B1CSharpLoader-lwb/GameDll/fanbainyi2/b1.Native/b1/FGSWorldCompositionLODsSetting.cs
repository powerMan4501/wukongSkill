using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSWorldCompositionLODsSetting", "FuncLibEditor", UnrealModuleType.Game)]
public struct FGSWorldCompositionLODsSetting
{
	private static bool TextureSize_IsValid;

	private static int TextureSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWorldCompositionLODsSetting:TextureSize")]
	public FIntPoint TextureSize;

	private static bool EnableNormalMap_IsValid;

	private static FFieldAddress EnableNormalMap_PropertyAddress;

	private static int EnableNormalMap_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWorldCompositionLODsSetting:EnableNormalMap")]
	public bool EnableNormalMap;

	private static bool EnableSpecularMap_IsValid;

	private static FFieldAddress EnableSpecularMap_PropertyAddress;

	private static int EnableSpecularMap_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWorldCompositionLODsSetting:EnableSpecularMap")]
	public bool EnableSpecularMap;

	private static bool EnableRoughnessMap_IsValid;

	private static FFieldAddress EnableRoughnessMap_PropertyAddress;

	private static int EnableRoughnessMap_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWorldCompositionLODsSetting:EnableRoughnessMap")]
	public bool EnableRoughnessMap;

	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWorldCompositionLODsSetting:ScreenSize")]
	public int ScreenSize;

	private static bool FGSWorldCompositionLODsSetting_IsValid;

	private static int FGSWorldCompositionLODsSetting_StructSize;

	public FGSWorldCompositionLODsSetting Copy()
	{
		return this;
	}

	public static FGSWorldCompositionLODsSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSWorldCompositionLODsSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSWorldCompositionLODsSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSWorldCompositionLODsSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSWorldCompositionLODsSetting(nativeBuffer + arrayIndex * FGSWorldCompositionLODsSetting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSWorldCompositionLODsSetting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSWorldCompositionLODsSetting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSWorldCompositionLODsSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSWorldCompositionLODsSetting");
			return;
		}
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, TextureSize_Offset), TextureSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableNormalMap_Offset), 0, EnableNormalMap_PropertyAddress.Address, EnableNormalMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableSpecularMap_Offset), 0, EnableSpecularMap_PropertyAddress.Address, EnableSpecularMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRoughnessMap_Offset), 0, EnableRoughnessMap_PropertyAddress.Address, EnableRoughnessMap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ScreenSize_Offset), ScreenSize);
	}

	public FGSWorldCompositionLODsSetting(IntPtr nativeStruct)
	{
		if (!FGSWorldCompositionLODsSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSWorldCompositionLODsSetting");
			TextureSize = default(FIntPoint);
			EnableNormalMap = false;
			EnableSpecularMap = false;
			EnableRoughnessMap = false;
			ScreenSize = 0;
		}
		else
		{
			TextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, TextureSize_Offset));
			EnableNormalMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableNormalMap_Offset), 0, EnableNormalMap_PropertyAddress.Address);
			EnableSpecularMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableSpecularMap_Offset), 0, EnableSpecularMap_PropertyAddress.Address);
			EnableRoughnessMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRoughnessMap_Offset), 0, EnableRoughnessMap_PropertyAddress.Address);
			ScreenSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ScreenSize_Offset));
		}
	}

	static FGSWorldCompositionLODsSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSWorldCompositionLODsSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSWorldCompositionLODsSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.GSWorldCompositionLODsSetting");
		FGSWorldCompositionLODsSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		TextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureSize");
		TextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNormalMap_PropertyAddress, intPtr, "EnableNormalMap");
		EnableNormalMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableNormalMap");
		EnableNormalMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableNormalMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSpecularMap_PropertyAddress, intPtr, "EnableSpecularMap");
		EnableSpecularMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableSpecularMap");
		EnableSpecularMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableSpecularMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRoughnessMap_PropertyAddress, intPtr, "EnableRoughnessMap");
		EnableRoughnessMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableRoughnessMap");
		EnableRoughnessMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableRoughnessMap", Classes.FBoolProperty);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FIntProperty);
		FGSWorldCompositionLODsSetting_IsValid = intPtr != IntPtr.Zero && TextureSize_IsValid && EnableNormalMap_IsValid && EnableSpecularMap_IsValid && EnableRoughnessMap_IsValid && ScreenSize_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.GSWorldCompositionLODsSetting", FGSWorldCompositionLODsSetting_IsValid);
	}
}
