using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ImageConfig")]
public struct FImageConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Brush")]
	[USharpPath("/Script/b1-Managed.ImageConfig:ImgBrush")]
	public FSlateBrush ImgBrush;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("启用图片尺寸配置")]
	[USharpPath("/Script/b1-Managed.ImageConfig:UseImgSize")]
	public bool UseImgSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseImgSize")]
	[DisplayName("图片尺寸")]
	[USharpPath("/Script/b1-Managed.ImageConfig:ImgSize")]
	public FVector2D ImgSize;

	[DisplayName("启用图片位置配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ImageConfig:UseImgPos")]
	public bool UseImgPos;

	[UProperty]
	[DisplayName("图片位置")]
	[UMeta(MDProp.EditCondition, "UseImgPos")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ImageConfig:ImgPos")]
	public FVector2D ImgPos;

	[Tooltip("同步材质参数类型，仅BrushObj为材质时生效")]
	[DisplayName("同步类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ImageConfig:MatSyncType")]
	public EMatSyncType MatSyncType;

	[Tooltip("同步材质参数拓展列表，仅BrushObj为材质时生效")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("额外同步配置")]
	[USharpPath("/Script/b1-Managed.ImageConfig:ExMatSyncList")]
	public List<FMatSyncConfig> ExMatSyncList;

	[BlueprintReadWrite]
	[DisplayName("是否使用图集")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ImageConfig:UseAtlas")]
	public bool UseAtlas;

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否同步Sprite")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ImageConfig:SyncSprite")]
	public bool SyncSprite;

	[DisplayName("图集")]
	[UMeta(MDProp.EditCondition, "UseAtlas && !SyncSprite")]
	[UMeta(MDProp.AllowedClasses, "SlateTextureAtlasInterface")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ImageConfig:Sprite")]
	public UObject Sprite;

	private static int ImageConfig_StructSize;

	private static int ImageConfig_IsValid;

	private static bool ImgBrush_IsValid;

	private static int ImgBrush_Offset;

	private static bool UseImgSize_IsValid;

	private static int UseImgSize_Offset;

	private static FFieldAddress UseImgSize_PropertyAddress;

	private static bool ImgSize_IsValid;

	private static int ImgSize_Offset;

	private static bool UseImgPos_IsValid;

	private static int UseImgPos_Offset;

	private static FFieldAddress UseImgPos_PropertyAddress;

	private static bool ImgPos_IsValid;

	private static int ImgPos_Offset;

	private static bool MatSyncType_IsValid;

	private static int MatSyncType_Offset;

	private static FFieldAddress MatSyncType_PropertyAddress;

	private static bool ExMatSyncList_IsValid;

	private static int ExMatSyncList_Offset;

	private static FFieldAddress ExMatSyncList_PropertyAddress;

	private static bool UseAtlas_IsValid;

	private static int UseAtlas_Offset;

	private static FFieldAddress UseAtlas_PropertyAddress;

	private static bool SyncSprite_IsValid;

	private static int SyncSprite_Offset;

	private static FFieldAddress SyncSprite_PropertyAddress;

	private static bool Sprite_IsValid;

	private static int Sprite_Offset;

	public FImageConfig Copy()
	{
		FImageConfig result = this;
		if (ExMatSyncList != null)
		{
			result.ExMatSyncList = new List<FMatSyncConfig>(ExMatSyncList);
		}
		return result;
	}

	public static FImageConfig FromNative(IntPtr nativeBuffer)
	{
		return new FImageConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FImageConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FImageConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FImageConfig(IntPtr.Add(nativeBuffer, arrayIndex * ImageConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FImageConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ImageConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ImageConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ImageConfig");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ImgBrush_Offset), ImgBrush);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseImgSize_Offset), 0, UseImgSize_PropertyAddress.Address, UseImgSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ImgSize_Offset), ImgSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseImgPos_Offset), 0, UseImgPos_PropertyAddress.Address, UseImgPos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ImgPos_Offset), ImgPos);
		EnumMarshaler<EMatSyncType>.ToNative(IntPtr.Add(nativeStruct, MatSyncType_Offset), 0, MatSyncType_PropertyAddress.Address, MatSyncType);
		new TArrayCopyMarshaler<FMatSyncConfig>(1, ExMatSyncList_PropertyAddress, CachedMarshalingDelegates<FMatSyncConfig, FMatSyncConfig>.FromNative, CachedMarshalingDelegates<FMatSyncConfig, FMatSyncConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, ExMatSyncList_Offset), ExMatSyncList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseAtlas_Offset), 0, UseAtlas_PropertyAddress.Address, UseAtlas);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SyncSprite_Offset), 0, SyncSprite_PropertyAddress.Address, SyncSprite);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, Sprite_Offset), Sprite);
	}

	public FImageConfig(IntPtr nativeStruct)
	{
		if (ImageConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ImageConfig");
			ImgBrush = default(FSlateBrush);
			UseImgSize = false;
			ImgSize = default(FVector2D);
			UseImgPos = false;
			ImgPos = default(FVector2D);
			MatSyncType = EMatSyncType.UnSync;
			ExMatSyncList = null;
			UseAtlas = false;
			SyncSprite = false;
			Sprite = null;
		}
		else
		{
			ImgBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ImgBrush_Offset));
			UseImgSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseImgSize_Offset), 0, UseImgSize_PropertyAddress.Address);
			ImgSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ImgSize_Offset));
			UseImgPos = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseImgPos_Offset), 0, UseImgPos_PropertyAddress.Address);
			ImgPos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ImgPos_Offset));
			MatSyncType = EnumMarshaler<EMatSyncType>.FromNative(IntPtr.Add(nativeStruct, MatSyncType_Offset), 0, MatSyncType_PropertyAddress.Address);
			ExMatSyncList = new TArrayCopyMarshaler<FMatSyncConfig>(1, ExMatSyncList_PropertyAddress, CachedMarshalingDelegates<FMatSyncConfig, FMatSyncConfig>.FromNative, CachedMarshalingDelegates<FMatSyncConfig, FMatSyncConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, ExMatSyncList_Offset));
			UseAtlas = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseAtlas_Offset), 0, UseAtlas_PropertyAddress.Address);
			SyncSprite = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SyncSprite_Offset), 0, SyncSprite_PropertyAddress.Address);
			Sprite = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, Sprite_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ImageConfig");
		ImageConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ImgBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgBrush");
		ImgBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgBrush", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseImgSize_PropertyAddress, intPtr, "UseImgSize");
		UseImgSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseImgSize");
		UseImgSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseImgSize", Classes.FBoolProperty);
		ImgSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgSize");
		ImgSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseImgPos_PropertyAddress, intPtr, "UseImgPos");
		UseImgPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseImgPos");
		UseImgPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseImgPos", Classes.FBoolProperty);
		ImgPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgPos");
		ImgPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgPos", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref MatSyncType_PropertyAddress, intPtr, "MatSyncType");
		MatSyncType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatSyncType");
		MatSyncType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatSyncType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ExMatSyncList_PropertyAddress, intPtr, "ExMatSyncList");
		ExMatSyncList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExMatSyncList");
		ExMatSyncList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExMatSyncList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseAtlas_PropertyAddress, intPtr, "UseAtlas");
		UseAtlas_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseAtlas");
		UseAtlas_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseAtlas", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SyncSprite_PropertyAddress, intPtr, "SyncSprite");
		SyncSprite_Offset = NativeReflection.GetPropertyOffset(intPtr, "SyncSprite");
		SyncSprite_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SyncSprite", Classes.FBoolProperty);
		Sprite_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sprite");
		Sprite_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sprite", Classes.FObjectProperty);
		ImageConfig_IsValid = ((intPtr != IntPtr.Zero && ImgBrush_IsValid && UseImgSize_IsValid && ImgSize_IsValid && UseImgPos_IsValid && ImgPos_IsValid && MatSyncType_IsValid && ExMatSyncList_IsValid && UseAtlas_IsValid && SyncSprite_IsValid && Sprite_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ImageConfig", (byte)ImageConfig_IsValid != 0);
	}

	static FImageConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FImageConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FImageConfig));
	}
}
