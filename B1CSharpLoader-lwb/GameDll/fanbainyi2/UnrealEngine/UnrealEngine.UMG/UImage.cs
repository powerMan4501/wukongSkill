using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Image", "UMG", UnrealModuleType.Engine)]
public class UImage : UWidget
{
	private static bool Brush_IsValid;

	private static int Brush_Offset;

	private static bool UseAtlas_IsValid;

	private static FFieldAddress UseAtlas_PropertyAddress;

	private static int UseAtlas_Offset;

	private static bool AtlasedSprite_IsValid;

	private static int AtlasedSprite_Offset;

	private static bool ColorAndOpacity_IsValid;

	private static int ColorAndOpacity_Offset;

	private static bool OnMouseButtonDownEvent_IsValid;

	private static int OnMouseButtonDownEvent_Offset;

	private FOnPointerEvent OnMouseButtonDownEvent_DelegateCached;

	private static bool UpdateSpriteRendering_IsValid;

	private static IntPtr UpdateSpriteRendering_FunctionAddress;

	private static int UpdateSpriteRendering_ParamsSize;

	private static bool SetSpriteRenderingEnabled_IsValid;

	private static IntPtr SetSpriteRenderingEnabled_FunctionAddress;

	private static int SetSpriteRenderingEnabled_ParamsSize;

	private static bool SetSpriteRenderingEnabled_bEnableSpriteRendering_IsValid;

	private static FFieldAddress SetSpriteRenderingEnabled_bEnableSpriteRendering_PropertyAddress;

	private static int SetSpriteRenderingEnabled_bEnableSpriteRendering_Offset;

	private static bool SetOpacity_IsValid;

	private static IntPtr SetOpacity_FunctionAddress;

	private static int SetOpacity_ParamsSize;

	private static bool SetOpacity_InOpacity_IsValid;

	private static FFieldAddress SetOpacity_InOpacity_PropertyAddress;

	private static int SetOpacity_InOpacity_Offset;

	private static bool SetImageSprite_IsValid;

	private static IntPtr SetImageSprite_FunctionAddress;

	private static int SetImageSprite_ParamsSize;

	private static bool SetImageSprite_InSpriteObject_IsValid;

	private static FFieldAddress SetImageSprite_InSpriteObject_PropertyAddress;

	private static int SetImageSprite_InSpriteObject_Offset;

	private static bool SetImageSprite_InIndex_IsValid;

	private static FFieldAddress SetImageSprite_InIndex_PropertyAddress;

	private static int SetImageSprite_InIndex_Offset;

	private static bool SetDesiredSizeOverride_IsValid;

	private static IntPtr SetDesiredSizeOverride_FunctionAddress;

	private static int SetDesiredSizeOverride_ParamsSize;

	private static bool SetDesiredSizeOverride_DesiredSize_IsValid;

	private static FFieldAddress SetDesiredSizeOverride_DesiredSize_PropertyAddress;

	private static int SetDesiredSizeOverride_DesiredSize_Offset;

	private static bool SetColorAndOpacity_IsValid;

	private static IntPtr SetColorAndOpacity_FunctionAddress;

	private static int SetColorAndOpacity_ParamsSize;

	private static bool SetColorAndOpacity_InColorAndOpacity_IsValid;

	private static FFieldAddress SetColorAndOpacity_InColorAndOpacity_PropertyAddress;

	private static int SetColorAndOpacity_InColorAndOpacity_Offset;

	private static bool SetBrushTintColor_IsValid;

	private static IntPtr SetBrushTintColor_FunctionAddress;

	private static int SetBrushTintColor_ParamsSize;

	private static bool SetBrushTintColor_TintColor_IsValid;

	private static FFieldAddress SetBrushTintColor_TintColor_PropertyAddress;

	private static int SetBrushTintColor_TintColor_Offset;

	private static bool SetBrushResourceObject_IsValid;

	private static IntPtr SetBrushResourceObject_FunctionAddress;

	private static int SetBrushResourceObject_ParamsSize;

	private static bool SetBrushResourceObject_ResourceObject_IsValid;

	private static FFieldAddress SetBrushResourceObject_ResourceObject_PropertyAddress;

	private static int SetBrushResourceObject_ResourceObject_Offset;

	private static bool SetBrushFromTextureDynamic_IsValid;

	private static IntPtr SetBrushFromTextureDynamic_FunctionAddress;

	private static int SetBrushFromTextureDynamic_ParamsSize;

	private static bool SetBrushFromTextureDynamic_Texture_IsValid;

	private static FFieldAddress SetBrushFromTextureDynamic_Texture_PropertyAddress;

	private static int SetBrushFromTextureDynamic_Texture_Offset;

	private static bool SetBrushFromTextureDynamic_bMatchSize_IsValid;

	private static FFieldAddress SetBrushFromTextureDynamic_bMatchSize_PropertyAddress;

	private static int SetBrushFromTextureDynamic_bMatchSize_Offset;

	private static bool SetBrushFromTexture_IsValid;

	private static IntPtr SetBrushFromTexture_FunctionAddress;

	private static int SetBrushFromTexture_ParamsSize;

	private static bool SetBrushFromTexture_Texture_IsValid;

	private static FFieldAddress SetBrushFromTexture_Texture_PropertyAddress;

	private static int SetBrushFromTexture_Texture_Offset;

	private static bool SetBrushFromTexture_bMatchSize_IsValid;

	private static FFieldAddress SetBrushFromTexture_bMatchSize_PropertyAddress;

	private static int SetBrushFromTexture_bMatchSize_Offset;

	private static bool SetBrushFromSoftTexture_IsValid;

	private static IntPtr SetBrushFromSoftTexture_FunctionAddress;

	private static int SetBrushFromSoftTexture_ParamsSize;

	private static bool SetBrushFromSoftTexture_SoftTexture_IsValid;

	private static FFieldAddress SetBrushFromSoftTexture_SoftTexture_PropertyAddress;

	private static int SetBrushFromSoftTexture_SoftTexture_Offset;

	private static bool SetBrushFromSoftTexture_bMatchSize_IsValid;

	private static FFieldAddress SetBrushFromSoftTexture_bMatchSize_PropertyAddress;

	private static int SetBrushFromSoftTexture_bMatchSize_Offset;

	private static bool SetBrushFromSoftMaterial_IsValid;

	private static IntPtr SetBrushFromSoftMaterial_FunctionAddress;

	private static int SetBrushFromSoftMaterial_ParamsSize;

	private static bool SetBrushFromSoftMaterial_SoftMaterial_IsValid;

	private static FFieldAddress SetBrushFromSoftMaterial_SoftMaterial_PropertyAddress;

	private static int SetBrushFromSoftMaterial_SoftMaterial_Offset;

	private static bool SetBrushFromMaterial_IsValid;

	private static IntPtr SetBrushFromMaterial_FunctionAddress;

	private static int SetBrushFromMaterial_ParamsSize;

	private static bool SetBrushFromMaterial_Material_IsValid;

	private static FFieldAddress SetBrushFromMaterial_Material_PropertyAddress;

	private static int SetBrushFromMaterial_Material_Offset;

	private static bool SetBrushFromAtlasInterface_IsValid;

	private static IntPtr SetBrushFromAtlasInterface_FunctionAddress;

	private static int SetBrushFromAtlasInterface_ParamsSize;

	private static bool SetBrushFromAtlasInterface_AtlasRegion_IsValid;

	private static FFieldAddress SetBrushFromAtlasInterface_AtlasRegion_PropertyAddress;

	private static int SetBrushFromAtlasInterface_AtlasRegion_Offset;

	private static bool SetBrushFromAtlasInterface_bMatchSize_IsValid;

	private static FFieldAddress SetBrushFromAtlasInterface_bMatchSize_PropertyAddress;

	private static int SetBrushFromAtlasInterface_bMatchSize_Offset;

	private static bool SetBrushFromAsset_IsValid;

	private static IntPtr SetBrushFromAsset_FunctionAddress;

	private static int SetBrushFromAsset_ParamsSize;

	private static bool SetBrushFromAsset_Asset_IsValid;

	private static FFieldAddress SetBrushFromAsset_Asset_PropertyAddress;

	private static int SetBrushFromAsset_Asset_Offset;

	private static bool SetBrush_IsValid;

	private static IntPtr SetBrush_FunctionAddress;

	private static int SetBrush_ParamsSize;

	private static bool SetBrush_InBrush_IsValid;

	private static FFieldAddress SetBrush_InBrush_PropertyAddress;

	private static int SetBrush_InBrush_Offset;

	private static bool GetDynamicMaterial_IsValid;

	private static IntPtr GetDynamicMaterial_FunctionAddress;

	private static int GetDynamicMaterial_ParamsSize;

	private static bool GetDynamicMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDynamicMaterial_ReturnValue_PropertyAddress;

	private static int GetDynamicMaterial_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.Image:Brush")]
	public FSlateBrush Brush
	{
		get
		{
			CheckDestroyed();
			if (!Brush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:Brush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, Brush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Brush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:Brush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, Brush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Image:bUseAtlas")]
	public bool UseAtlas
	{
		get
		{
			CheckDestroyed();
			if (!UseAtlas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:bUseAtlas");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAtlas_Offset), 0, UseAtlas_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAtlas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:bUseAtlas");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAtlas_Offset), 0, UseAtlas_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/UMG.Image:AtlasedSprite")]
	public UObject AtlasedSprite
	{
		get
		{
			CheckDestroyed();
			if (!AtlasedSprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:AtlasedSprite");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, AtlasedSprite_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtlasedSprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:AtlasedSprite");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, AtlasedSprite_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Image:ColorAndOpacity")]
	public FLinearColor ColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:ColorAndOpacity");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:ColorAndOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.Image:OnMouseButtonDownEvent")]
	public FOnPointerEvent OnMouseButtonDownEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonDownEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Image:OnMouseButtonDownEvent");
				return new FOnPointerEvent();
			}
			if (OnMouseButtonDownEvent_DelegateCached == null)
			{
				OnMouseButtonDownEvent_DelegateCached = new FOnPointerEvent();
				OnMouseButtonDownEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseButtonDownEvent_Offset));
			}
			return OnMouseButtonDownEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:UpdateSpriteRendering")]
	public unsafe void UpdateSpriteRendering()
	{
		CheckDestroyed();
		if (!UpdateSpriteRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:UpdateSpriteRendering");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSpriteRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSpriteRendering_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateSpriteRendering_FunctionAddress, argsSize: UpdateSpriteRendering_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:SetSpriteRenderingEnabled")]
	public unsafe void SetSpriteRenderingEnabled(bool bEnableSpriteRendering)
	{
		CheckDestroyed();
		if (!SetSpriteRenderingEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetSpriteRenderingEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpriteRenderingEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpriteRenderingEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSpriteRenderingEnabled_bEnableSpriteRendering_Offset), 0, SetSpriteRenderingEnabled_bEnableSpriteRendering_PropertyAddress.Address, bEnableSpriteRendering);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpriteRenderingEnabled_FunctionAddress, intPtr, SetSpriteRenderingEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:SetOpacity")]
	public unsafe void SetOpacity(float InOpacity)
	{
		CheckDestroyed();
		if (!SetOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOpacity_InOpacity_Offset), 0, SetOpacity_InOpacity_PropertyAddress.Address, InOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOpacity_FunctionAddress, intPtr, SetOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:SetImageSprite")]
	public unsafe void SetImageSprite(UObject InSpriteObject, int InIndex = 0)
	{
		CheckDestroyed();
		if (!SetImageSprite_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetImageSprite");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetImageSprite_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetImageSprite_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetImageSprite_InSpriteObject_Offset), 0, SetImageSprite_InSpriteObject_PropertyAddress.Address, InSpriteObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetImageSprite_InIndex_Offset), 0, SetImageSprite_InIndex_PropertyAddress.Address, InIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetImageSprite_FunctionAddress, intPtr, SetImageSprite_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Image:SetDesiredSizeOverride")]
	public unsafe void SetDesiredSizeOverride(FVector2D DesiredSize)
	{
		CheckDestroyed();
		if (!SetDesiredSizeOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetDesiredSizeOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredSizeOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredSizeOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetDesiredSizeOverride_DesiredSize_Offset), 0, SetDesiredSizeOverride_DesiredSize_PropertyAddress.Address, DesiredSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDesiredSizeOverride_FunctionAddress, intPtr, SetDesiredSizeOverride_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Image:SetColorAndOpacity")]
	public unsafe void SetColorAndOpacity(FLinearColor InColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetColorAndOpacity_InColorAndOpacity_Offset), 0, SetColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorAndOpacity_FunctionAddress, intPtr, SetColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:SetBrushTintColor")]
	public unsafe void SetBrushTintColor(FSlateColor TintColor)
	{
		CheckDestroyed();
		if (!SetBrushTintColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushTintColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushTintColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushTintColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBrushTintColor_TintColor_PropertyAddress.Address, intPtr);
		FSlateColor.ToNative(IntPtr.Add(intPtr, SetBrushTintColor_TintColor_Offset), 0, SetBrushTintColor_TintColor_PropertyAddress.Address, TintColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushTintColor_FunctionAddress, intPtr, SetBrushTintColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBrushTintColor_TintColor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:SetBrushResourceObject")]
	public unsafe void SetBrushResourceObject(UObject ResourceObject)
	{
		CheckDestroyed();
		if (!SetBrushResourceObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushResourceObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushResourceObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushResourceObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetBrushResourceObject_ResourceObject_Offset), 0, SetBrushResourceObject_ResourceObject_PropertyAddress.Address, ResourceObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushResourceObject_FunctionAddress, intPtr, SetBrushResourceObject_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromTextureDynamic")]
	public unsafe void SetBrushFromTextureDynamic(UTexture2DDynamic Texture, bool bMatchSize = false)
	{
		CheckDestroyed();
		if (!SetBrushFromTextureDynamic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromTextureDynamic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromTextureDynamic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromTextureDynamic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2DDynamic>.ToNative(IntPtr.Add(intPtr, SetBrushFromTextureDynamic_Texture_Offset), 0, SetBrushFromTextureDynamic_Texture_PropertyAddress.Address, Texture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBrushFromTextureDynamic_bMatchSize_Offset), 0, SetBrushFromTextureDynamic_bMatchSize_PropertyAddress.Address, bMatchSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromTextureDynamic_FunctionAddress, intPtr, SetBrushFromTextureDynamic_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromTexture")]
	public unsafe void SetBrushFromTexture(UTexture2D Texture, bool bMatchSize = false)
	{
		CheckDestroyed();
		if (!SetBrushFromTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetBrushFromTexture_Texture_Offset), 0, SetBrushFromTexture_Texture_PropertyAddress.Address, Texture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBrushFromTexture_bMatchSize_Offset), 0, SetBrushFromTexture_bMatchSize_PropertyAddress.Address, bMatchSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromTexture_FunctionAddress, intPtr, SetBrushFromTexture_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromSoftTexture")]
	public unsafe void SetBrushFromSoftTexture(TSoftObject<UTexture2D> SoftTexture, bool bMatchSize = false)
	{
		CheckDestroyed();
		if (!SetBrushFromSoftTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromSoftTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromSoftTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromSoftTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBrushFromSoftTexture_SoftTexture_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetBrushFromSoftTexture_SoftTexture_Offset), 0, SetBrushFromSoftTexture_SoftTexture_PropertyAddress.Address, SoftTexture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBrushFromSoftTexture_bMatchSize_Offset), 0, SetBrushFromSoftTexture_bMatchSize_PropertyAddress.Address, bMatchSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromSoftTexture_FunctionAddress, intPtr, SetBrushFromSoftTexture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBrushFromSoftTexture_SoftTexture_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromSoftMaterial")]
	public unsafe void SetBrushFromSoftMaterial(TSoftObject<UMaterialInterface> SoftMaterial)
	{
		CheckDestroyed();
		if (!SetBrushFromSoftMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromSoftMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromSoftMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromSoftMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBrushFromSoftMaterial_SoftMaterial_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetBrushFromSoftMaterial_SoftMaterial_Offset), 0, SetBrushFromSoftMaterial_SoftMaterial_PropertyAddress.Address, SoftMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromSoftMaterial_FunctionAddress, intPtr, SetBrushFromSoftMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBrushFromSoftMaterial_SoftMaterial_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromMaterial")]
	public unsafe void SetBrushFromMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetBrushFromMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetBrushFromMaterial_Material_Offset), 0, SetBrushFromMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromMaterial_FunctionAddress, intPtr, SetBrushFromMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromAtlasInterface")]
	public unsafe void SetBrushFromAtlasInterface(ISlateTextureAtlasInterface AtlasRegion, bool bMatchSize = false)
	{
		CheckDestroyed();
		if (!SetBrushFromAtlasInterface_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromAtlasInterface");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromAtlasInterface_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromAtlasInterface_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<ISlateTextureAtlasInterface>.ToNative(IntPtr.Add(intPtr, SetBrushFromAtlasInterface_AtlasRegion_Offset), 0, SetBrushFromAtlasInterface_AtlasRegion_PropertyAddress.Address, AtlasRegion);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBrushFromAtlasInterface_bMatchSize_Offset), 0, SetBrushFromAtlasInterface_bMatchSize_PropertyAddress.Address, bMatchSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromAtlasInterface_FunctionAddress, intPtr, SetBrushFromAtlasInterface_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Image:SetBrushFromAsset")]
	public unsafe void SetBrushFromAsset(USlateBrushAsset Asset)
	{
		CheckDestroyed();
		if (!SetBrushFromAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrushFromAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USlateBrushAsset>.ToNative(IntPtr.Add(intPtr, SetBrushFromAsset_Asset_Offset), 0, SetBrushFromAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromAsset_FunctionAddress, intPtr, SetBrushFromAsset_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/UMG.Image:SetBrush")]
	public unsafe void SetBrush(FSlateBrush InBrush)
	{
		CheckDestroyed();
		if (!SetBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:SetBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBrush_InBrush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, SetBrush_InBrush_Offset), 0, SetBrush_InBrush_PropertyAddress.Address, InBrush);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrush_FunctionAddress, intPtr, SetBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBrush_InBrush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Image:GetDynamicMaterial")]
	public unsafe UMaterialInstanceDynamic GetDynamicMaterial()
	{
		CheckDestroyed();
		if (!GetDynamicMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Image:GetDynamicMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDynamicMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDynamicMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDynamicMaterial_FunctionAddress, intPtr, GetDynamicMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetDynamicMaterial_ReturnValue_Offset), 0, GetDynamicMaterial_ReturnValue_PropertyAddress.Address);
	}

	static UImage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UImage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UImage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Image");
		Brush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Brush");
		Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAtlas_PropertyAddress, intPtr, "bUseAtlas");
		UseAtlas_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAtlas");
		UseAtlas_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAtlas", Classes.FBoolProperty);
		AtlasedSprite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtlasedSprite");
		AtlasedSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtlasedSprite", Classes.FObjectProperty);
		ColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorAndOpacity");
		ColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorAndOpacity", Classes.FStructProperty);
		OnMouseButtonDownEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseButtonDownEvent");
		OnMouseButtonDownEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseButtonDownEvent", Classes.FDelegateProperty);
		UpdateSpriteRendering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSpriteRendering");
		UpdateSpriteRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSpriteRendering_FunctionAddress);
		UpdateSpriteRendering_IsValid = UpdateSpriteRendering_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:UpdateSpriteRendering", UpdateSpriteRendering_IsValid);
		SetSpriteRenderingEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpriteRenderingEnabled");
		SetSpriteRenderingEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpriteRenderingEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteRenderingEnabled_bEnableSpriteRendering_PropertyAddress, SetSpriteRenderingEnabled_FunctionAddress, "bEnableSpriteRendering");
		SetSpriteRenderingEnabled_bEnableSpriteRendering_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteRenderingEnabled_FunctionAddress, "bEnableSpriteRendering");
		SetSpriteRenderingEnabled_bEnableSpriteRendering_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteRenderingEnabled_FunctionAddress, "bEnableSpriteRendering", Classes.FBoolProperty);
		SetSpriteRenderingEnabled_IsValid = SetSpriteRenderingEnabled_FunctionAddress != IntPtr.Zero && SetSpriteRenderingEnabled_bEnableSpriteRendering_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetSpriteRenderingEnabled", SetSpriteRenderingEnabled_IsValid);
		SetOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOpacity");
		SetOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOpacity_InOpacity_PropertyAddress, SetOpacity_FunctionAddress, "InOpacity");
		SetOpacity_InOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetOpacity_FunctionAddress, "InOpacity");
		SetOpacity_InOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOpacity_FunctionAddress, "InOpacity", Classes.FFloatProperty);
		SetOpacity_IsValid = SetOpacity_FunctionAddress != IntPtr.Zero && SetOpacity_InOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetOpacity", SetOpacity_IsValid);
		SetImageSprite_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetImageSprite");
		SetImageSprite_ParamsSize = NativeReflection.GetFunctionParamsSize(SetImageSprite_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetImageSprite_InSpriteObject_PropertyAddress, SetImageSprite_FunctionAddress, "InSpriteObject");
		SetImageSprite_InSpriteObject_Offset = NativeReflectionCached.GetPropertyOffset(SetImageSprite_FunctionAddress, "InSpriteObject");
		SetImageSprite_InSpriteObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetImageSprite_FunctionAddress, "InSpriteObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetImageSprite_InIndex_PropertyAddress, SetImageSprite_FunctionAddress, "InIndex");
		SetImageSprite_InIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetImageSprite_FunctionAddress, "InIndex");
		SetImageSprite_InIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetImageSprite_FunctionAddress, "InIndex", Classes.FIntProperty);
		SetImageSprite_IsValid = SetImageSprite_FunctionAddress != IntPtr.Zero && SetImageSprite_InSpriteObject_IsValid && SetImageSprite_InIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetImageSprite", SetImageSprite_IsValid);
		SetDesiredSizeOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDesiredSizeOverride");
		SetDesiredSizeOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredSizeOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredSizeOverride_DesiredSize_PropertyAddress, SetDesiredSizeOverride_FunctionAddress, "DesiredSize");
		SetDesiredSizeOverride_DesiredSize_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredSizeOverride_FunctionAddress, "DesiredSize");
		SetDesiredSizeOverride_DesiredSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredSizeOverride_FunctionAddress, "DesiredSize", Classes.FStructProperty);
		SetDesiredSizeOverride_IsValid = SetDesiredSizeOverride_FunctionAddress != IntPtr.Zero && SetDesiredSizeOverride_DesiredSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetDesiredSizeOverride", SetDesiredSizeOverride_IsValid);
		SetColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColorAndOpacity");
		SetColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorAndOpacity_InColorAndOpacity_PropertyAddress, SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		SetColorAndOpacity_IsValid = SetColorAndOpacity_FunctionAddress != IntPtr.Zero && SetColorAndOpacity_InColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetColorAndOpacity", SetColorAndOpacity_IsValid);
		SetBrushTintColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushTintColor");
		SetBrushTintColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushTintColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushTintColor_TintColor_PropertyAddress, SetBrushTintColor_FunctionAddress, "TintColor");
		SetBrushTintColor_TintColor_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushTintColor_FunctionAddress, "TintColor");
		SetBrushTintColor_TintColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushTintColor_FunctionAddress, "TintColor", Classes.FStructProperty);
		SetBrushTintColor_IsValid = SetBrushTintColor_FunctionAddress != IntPtr.Zero && SetBrushTintColor_TintColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushTintColor", SetBrushTintColor_IsValid);
		SetBrushResourceObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushResourceObject");
		SetBrushResourceObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushResourceObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushResourceObject_ResourceObject_PropertyAddress, SetBrushResourceObject_FunctionAddress, "ResourceObject");
		SetBrushResourceObject_ResourceObject_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushResourceObject_FunctionAddress, "ResourceObject");
		SetBrushResourceObject_ResourceObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushResourceObject_FunctionAddress, "ResourceObject", Classes.FObjectProperty);
		SetBrushResourceObject_IsValid = SetBrushResourceObject_FunctionAddress != IntPtr.Zero && SetBrushResourceObject_ResourceObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushResourceObject", SetBrushResourceObject_IsValid);
		SetBrushFromTextureDynamic_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromTextureDynamic");
		SetBrushFromTextureDynamic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromTextureDynamic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromTextureDynamic_Texture_PropertyAddress, SetBrushFromTextureDynamic_FunctionAddress, "Texture");
		SetBrushFromTextureDynamic_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromTextureDynamic_FunctionAddress, "Texture");
		SetBrushFromTextureDynamic_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromTextureDynamic_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromTextureDynamic_bMatchSize_PropertyAddress, SetBrushFromTextureDynamic_FunctionAddress, "bMatchSize");
		SetBrushFromTextureDynamic_bMatchSize_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromTextureDynamic_FunctionAddress, "bMatchSize");
		SetBrushFromTextureDynamic_bMatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromTextureDynamic_FunctionAddress, "bMatchSize", Classes.FBoolProperty);
		SetBrushFromTextureDynamic_IsValid = SetBrushFromTextureDynamic_FunctionAddress != IntPtr.Zero && SetBrushFromTextureDynamic_Texture_IsValid && SetBrushFromTextureDynamic_bMatchSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromTextureDynamic", SetBrushFromTextureDynamic_IsValid);
		SetBrushFromTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromTexture");
		SetBrushFromTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromTexture_Texture_PropertyAddress, SetBrushFromTexture_FunctionAddress, "Texture");
		SetBrushFromTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromTexture_FunctionAddress, "Texture");
		SetBrushFromTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromTexture_bMatchSize_PropertyAddress, SetBrushFromTexture_FunctionAddress, "bMatchSize");
		SetBrushFromTexture_bMatchSize_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromTexture_FunctionAddress, "bMatchSize");
		SetBrushFromTexture_bMatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromTexture_FunctionAddress, "bMatchSize", Classes.FBoolProperty);
		SetBrushFromTexture_IsValid = SetBrushFromTexture_FunctionAddress != IntPtr.Zero && SetBrushFromTexture_Texture_IsValid && SetBrushFromTexture_bMatchSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromTexture", SetBrushFromTexture_IsValid);
		SetBrushFromSoftTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromSoftTexture");
		SetBrushFromSoftTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromSoftTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromSoftTexture_SoftTexture_PropertyAddress, SetBrushFromSoftTexture_FunctionAddress, "SoftTexture");
		SetBrushFromSoftTexture_SoftTexture_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromSoftTexture_FunctionAddress, "SoftTexture");
		SetBrushFromSoftTexture_SoftTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromSoftTexture_FunctionAddress, "SoftTexture", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromSoftTexture_bMatchSize_PropertyAddress, SetBrushFromSoftTexture_FunctionAddress, "bMatchSize");
		SetBrushFromSoftTexture_bMatchSize_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromSoftTexture_FunctionAddress, "bMatchSize");
		SetBrushFromSoftTexture_bMatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromSoftTexture_FunctionAddress, "bMatchSize", Classes.FBoolProperty);
		SetBrushFromSoftTexture_IsValid = SetBrushFromSoftTexture_FunctionAddress != IntPtr.Zero && SetBrushFromSoftTexture_SoftTexture_IsValid && SetBrushFromSoftTexture_bMatchSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromSoftTexture", SetBrushFromSoftTexture_IsValid);
		SetBrushFromSoftMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromSoftMaterial");
		SetBrushFromSoftMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromSoftMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromSoftMaterial_SoftMaterial_PropertyAddress, SetBrushFromSoftMaterial_FunctionAddress, "SoftMaterial");
		SetBrushFromSoftMaterial_SoftMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromSoftMaterial_FunctionAddress, "SoftMaterial");
		SetBrushFromSoftMaterial_SoftMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromSoftMaterial_FunctionAddress, "SoftMaterial", Classes.FSoftObjectProperty);
		SetBrushFromSoftMaterial_IsValid = SetBrushFromSoftMaterial_FunctionAddress != IntPtr.Zero && SetBrushFromSoftMaterial_SoftMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromSoftMaterial", SetBrushFromSoftMaterial_IsValid);
		SetBrushFromMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromMaterial");
		SetBrushFromMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromMaterial_Material_PropertyAddress, SetBrushFromMaterial_FunctionAddress, "Material");
		SetBrushFromMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromMaterial_FunctionAddress, "Material");
		SetBrushFromMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetBrushFromMaterial_IsValid = SetBrushFromMaterial_FunctionAddress != IntPtr.Zero && SetBrushFromMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromMaterial", SetBrushFromMaterial_IsValid);
		SetBrushFromAtlasInterface_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromAtlasInterface");
		SetBrushFromAtlasInterface_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromAtlasInterface_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromAtlasInterface_AtlasRegion_PropertyAddress, SetBrushFromAtlasInterface_FunctionAddress, "AtlasRegion");
		SetBrushFromAtlasInterface_AtlasRegion_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromAtlasInterface_FunctionAddress, "AtlasRegion");
		SetBrushFromAtlasInterface_AtlasRegion_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromAtlasInterface_FunctionAddress, "AtlasRegion", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromAtlasInterface_bMatchSize_PropertyAddress, SetBrushFromAtlasInterface_FunctionAddress, "bMatchSize");
		SetBrushFromAtlasInterface_bMatchSize_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromAtlasInterface_FunctionAddress, "bMatchSize");
		SetBrushFromAtlasInterface_bMatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromAtlasInterface_FunctionAddress, "bMatchSize", Classes.FBoolProperty);
		SetBrushFromAtlasInterface_IsValid = SetBrushFromAtlasInterface_FunctionAddress != IntPtr.Zero && SetBrushFromAtlasInterface_AtlasRegion_IsValid && SetBrushFromAtlasInterface_bMatchSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromAtlasInterface", SetBrushFromAtlasInterface_IsValid);
		SetBrushFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromAsset");
		SetBrushFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromAsset_Asset_PropertyAddress, SetBrushFromAsset_FunctionAddress, "Asset");
		SetBrushFromAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromAsset_FunctionAddress, "Asset");
		SetBrushFromAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		SetBrushFromAsset_IsValid = SetBrushFromAsset_FunctionAddress != IntPtr.Zero && SetBrushFromAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrushFromAsset", SetBrushFromAsset_IsValid);
		SetBrush_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrush");
		SetBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrush_InBrush_PropertyAddress, SetBrush_FunctionAddress, "InBrush");
		SetBrush_InBrush_Offset = NativeReflectionCached.GetPropertyOffset(SetBrush_FunctionAddress, "InBrush");
		SetBrush_InBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrush_FunctionAddress, "InBrush", Classes.FStructProperty);
		SetBrush_IsValid = SetBrush_FunctionAddress != IntPtr.Zero && SetBrush_InBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:SetBrush", SetBrush_IsValid);
		GetDynamicMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDynamicMaterial");
		GetDynamicMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicMaterial_ReturnValue_PropertyAddress, GetDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDynamicMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDynamicMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicMaterial_IsValid = GetDynamicMaterial_FunctionAddress != IntPtr.Zero && GetDynamicMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Image:GetDynamicMaterial", GetDynamicMaterial_IsValid);
	}
}
