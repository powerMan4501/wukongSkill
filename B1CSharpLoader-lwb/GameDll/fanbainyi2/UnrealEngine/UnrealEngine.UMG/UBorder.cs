using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Border", "UMG", UnrealModuleType.Engine)]
public class UBorder : UContentWidget
{
	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool ShowEffectWhenDisabled_IsValid;

	private static FFieldAddress ShowEffectWhenDisabled_PropertyAddress;

	private static int ShowEffectWhenDisabled_Offset;

	private static bool ContentColorAndOpacity_IsValid;

	private static int ContentColorAndOpacity_Offset;

	private static bool Padding_IsValid;

	private static int Padding_Offset;

	private static bool Background_IsValid;

	private static int Background_Offset;

	private static bool BrushColor_IsValid;

	private static int BrushColor_Offset;

	private static bool DesiredSizeScale_IsValid;

	private static int DesiredSizeScale_Offset;

	private static bool OnMouseButtonDownEvent_IsValid;

	private static int OnMouseButtonDownEvent_Offset;

	private FOnPointerEvent OnMouseButtonDownEvent_DelegateCached;

	private static bool OnMouseButtonUpEvent_IsValid;

	private static int OnMouseButtonUpEvent_Offset;

	private FOnPointerEvent OnMouseButtonUpEvent_DelegateCached;

	private static bool OnMouseMoveEvent_IsValid;

	private static int OnMouseMoveEvent_Offset;

	private FOnPointerEvent OnMouseMoveEvent_DelegateCached;

	private static bool OnMouseDoubleClickEvent_IsValid;

	private static int OnMouseDoubleClickEvent_Offset;

	private FOnPointerEvent OnMouseDoubleClickEvent_DelegateCached;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_InVerticalAlignment_IsValid;

	private static FFieldAddress SetVerticalAlignment_InVerticalAlignment_PropertyAddress;

	private static int SetVerticalAlignment_InVerticalAlignment_Offset;

	private static bool SetPadding_IsValid;

	private static IntPtr SetPadding_FunctionAddress;

	private static int SetPadding_ParamsSize;

	private static bool SetPadding_InPadding_IsValid;

	private static FFieldAddress SetPadding_InPadding_PropertyAddress;

	private static int SetPadding_InPadding_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool SetDesiredSizeScale_IsValid;

	private static IntPtr SetDesiredSizeScale_FunctionAddress;

	private static int SetDesiredSizeScale_ParamsSize;

	private static bool SetDesiredSizeScale_InScale_IsValid;

	private static FFieldAddress SetDesiredSizeScale_InScale_PropertyAddress;

	private static int SetDesiredSizeScale_InScale_Offset;

	private static bool SetContentColorAndOpacity_IsValid;

	private static IntPtr SetContentColorAndOpacity_FunctionAddress;

	private static int SetContentColorAndOpacity_ParamsSize;

	private static bool SetContentColorAndOpacity_InContentColorAndOpacity_IsValid;

	private static FFieldAddress SetContentColorAndOpacity_InContentColorAndOpacity_PropertyAddress;

	private static int SetContentColorAndOpacity_InContentColorAndOpacity_Offset;

	private static bool SetBrushFromTexture_IsValid;

	private static IntPtr SetBrushFromTexture_FunctionAddress;

	private static int SetBrushFromTexture_ParamsSize;

	private static bool SetBrushFromTexture_Texture_IsValid;

	private static FFieldAddress SetBrushFromTexture_Texture_PropertyAddress;

	private static int SetBrushFromTexture_Texture_Offset;

	private static bool SetBrushFromMaterial_IsValid;

	private static IntPtr SetBrushFromMaterial_FunctionAddress;

	private static int SetBrushFromMaterial_ParamsSize;

	private static bool SetBrushFromMaterial_Material_IsValid;

	private static FFieldAddress SetBrushFromMaterial_Material_PropertyAddress;

	private static int SetBrushFromMaterial_Material_Offset;

	private static bool SetBrushFromAsset_IsValid;

	private static IntPtr SetBrushFromAsset_FunctionAddress;

	private static int SetBrushFromAsset_ParamsSize;

	private static bool SetBrushFromAsset_Asset_IsValid;

	private static FFieldAddress SetBrushFromAsset_Asset_PropertyAddress;

	private static int SetBrushFromAsset_Asset_Offset;

	private static bool SetBrushColor_IsValid;

	private static IntPtr SetBrushColor_FunctionAddress;

	private static int SetBrushColor_ParamsSize;

	private static bool SetBrushColor_InBrushColor_IsValid;

	private static FFieldAddress SetBrushColor_InBrushColor_PropertyAddress;

	private static int SetBrushColor_InBrushColor_Offset;

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

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Border:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Border:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/UMG.Border:bShowEffectWhenDisabled")]
	public bool ShowEffectWhenDisabled
	{
		get
		{
			CheckDestroyed();
			if (!ShowEffectWhenDisabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:bShowEffectWhenDisabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowEffectWhenDisabled_Offset), 0, ShowEffectWhenDisabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowEffectWhenDisabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:bShowEffectWhenDisabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowEffectWhenDisabled_Offset), 0, ShowEffectWhenDisabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Border:ContentColorAndOpacity")]
	public FLinearColor ContentColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!ContentColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:ContentColorAndOpacity");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ContentColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContentColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:ContentColorAndOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ContentColorAndOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.Border:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.Border:Background")]
	public FSlateBrush Background
	{
		get
		{
			CheckDestroyed();
			if (!Background_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:Background");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, Background_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Background_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:Background");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, Background_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Border:BrushColor")]
	public FLinearColor BrushColor
	{
		get
		{
			CheckDestroyed();
			if (!BrushColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:BrushColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, BrushColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:BrushColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, BrushColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Border:DesiredSizeScale")]
	public FVector2D DesiredSizeScale
	{
		get
		{
			CheckDestroyed();
			if (!DesiredSizeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:DesiredSizeScale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DesiredSizeScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DesiredSizeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:DesiredSizeScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DesiredSizeScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.Border:OnMouseButtonDownEvent")]
	public FOnPointerEvent OnMouseButtonDownEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonDownEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:OnMouseButtonDownEvent");
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

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.Border:OnMouseButtonUpEvent")]
	public FOnPointerEvent OnMouseButtonUpEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonUpEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:OnMouseButtonUpEvent");
				return new FOnPointerEvent();
			}
			if (OnMouseButtonUpEvent_DelegateCached == null)
			{
				OnMouseButtonUpEvent_DelegateCached = new FOnPointerEvent();
				OnMouseButtonUpEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseButtonUpEvent_Offset));
			}
			return OnMouseButtonUpEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.Border:OnMouseMoveEvent")]
	public FOnPointerEvent OnMouseMoveEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseMoveEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:OnMouseMoveEvent");
				return new FOnPointerEvent();
			}
			if (OnMouseMoveEvent_DelegateCached == null)
			{
				OnMouseMoveEvent_DelegateCached = new FOnPointerEvent();
				OnMouseMoveEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseMoveEvent_Offset));
			}
			return OnMouseMoveEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.Border:OnMouseDoubleClickEvent")]
	public FOnPointerEvent OnMouseDoubleClickEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseDoubleClickEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Border:OnMouseDoubleClickEvent");
				return new FOnPointerEvent();
			}
			if (OnMouseDoubleClickEvent_DelegateCached == null)
			{
				OnMouseDoubleClickEvent_DelegateCached = new FOnPointerEvent();
				OnMouseDoubleClickEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseDoubleClickEvent_Offset));
			}
			return OnMouseDoubleClickEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Border:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetVerticalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVerticalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVerticalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(intPtr, SetVerticalAlignment_InVerticalAlignment_Offset), 0, SetVerticalAlignment_InVerticalAlignment_PropertyAddress.Address, InVerticalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVerticalAlignment_FunctionAddress, intPtr, SetVerticalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Border:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetPadding_InPadding_Offset), 0, SetPadding_InPadding_PropertyAddress.Address, InPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPadding_FunctionAddress, intPtr, SetPadding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Border:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetHorizontalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizontalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizontalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(intPtr, SetHorizontalAlignment_InHorizontalAlignment_Offset), 0, SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress.Address, InHorizontalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizontalAlignment_FunctionAddress, intPtr, SetHorizontalAlignment_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Border:SetDesiredSizeScale")]
	public unsafe void SetDesiredSizeScale(FVector2D InScale)
	{
		CheckDestroyed();
		if (!SetDesiredSizeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetDesiredSizeScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredSizeScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredSizeScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetDesiredSizeScale_InScale_Offset), 0, SetDesiredSizeScale_InScale_PropertyAddress.Address, InScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDesiredSizeScale_FunctionAddress, intPtr, SetDesiredSizeScale_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Border:SetContentColorAndOpacity")]
	public unsafe void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetContentColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetContentColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContentColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContentColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetContentColorAndOpacity_InContentColorAndOpacity_Offset), 0, SetContentColorAndOpacity_InContentColorAndOpacity_PropertyAddress.Address, InContentColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetContentColorAndOpacity_FunctionAddress, intPtr, SetContentColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Border:SetBrushFromTexture")]
	public unsafe void SetBrushFromTexture(UTexture2D Texture)
	{
		CheckDestroyed();
		if (!SetBrushFromTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetBrushFromTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushFromTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushFromTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetBrushFromTexture_Texture_Offset), 0, SetBrushFromTexture_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushFromTexture_FunctionAddress, intPtr, SetBrushFromTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Border:SetBrushFromMaterial")]
	public unsafe void SetBrushFromMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetBrushFromMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetBrushFromMaterial");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Border:SetBrushFromAsset")]
	public unsafe void SetBrushFromAsset(USlateBrushAsset Asset)
	{
		CheckDestroyed();
		if (!SetBrushFromAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetBrushFromAsset");
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

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Border:SetBrushColor")]
	public unsafe void SetBrushColor(FLinearColor InBrushColor)
	{
		CheckDestroyed();
		if (!SetBrushColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetBrushColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetBrushColor_InBrushColor_Offset), 0, SetBrushColor_InBrushColor_PropertyAddress.Address, InBrushColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBrushColor_FunctionAddress, intPtr, SetBrushColor_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.Border:SetBrush")]
	public unsafe void SetBrush(FSlateBrush InBrush)
	{
		CheckDestroyed();
		if (!SetBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:SetBrush");
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
	[UMetaPath("/Script/UMG.Border:GetDynamicMaterial")]
	public unsafe UMaterialInstanceDynamic GetDynamicMaterial()
	{
		CheckDestroyed();
		if (!GetDynamicMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Border:GetDynamicMaterial");
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

	static UBorder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBorder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBorder));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Border");
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowEffectWhenDisabled_PropertyAddress, intPtr, "bShowEffectWhenDisabled");
		ShowEffectWhenDisabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowEffectWhenDisabled");
		ShowEffectWhenDisabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowEffectWhenDisabled", Classes.FBoolProperty);
		ContentColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContentColorAndOpacity");
		ContentColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContentColorAndOpacity", Classes.FStructProperty);
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		Background_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Background");
		Background_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Background", Classes.FStructProperty);
		BrushColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushColor");
		BrushColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushColor", Classes.FStructProperty);
		DesiredSizeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredSizeScale");
		DesiredSizeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredSizeScale", Classes.FStructProperty);
		OnMouseButtonDownEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseButtonDownEvent");
		OnMouseButtonDownEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseButtonDownEvent", Classes.FDelegateProperty);
		OnMouseButtonUpEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseButtonUpEvent");
		OnMouseButtonUpEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseButtonUpEvent", Classes.FDelegateProperty);
		OnMouseMoveEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseMoveEvent");
		OnMouseMoveEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseMoveEvent", Classes.FDelegateProperty);
		OnMouseDoubleClickEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseDoubleClickEvent");
		OnMouseDoubleClickEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseDoubleClickEvent", Classes.FDelegateProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetPadding", SetPadding_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetDesiredSizeScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDesiredSizeScale");
		SetDesiredSizeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredSizeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredSizeScale_InScale_PropertyAddress, SetDesiredSizeScale_FunctionAddress, "InScale");
		SetDesiredSizeScale_InScale_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredSizeScale_FunctionAddress, "InScale");
		SetDesiredSizeScale_InScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredSizeScale_FunctionAddress, "InScale", Classes.FStructProperty);
		SetDesiredSizeScale_IsValid = SetDesiredSizeScale_FunctionAddress != IntPtr.Zero && SetDesiredSizeScale_InScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetDesiredSizeScale", SetDesiredSizeScale_IsValid);
		SetContentColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetContentColorAndOpacity");
		SetContentColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContentColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContentColorAndOpacity_InContentColorAndOpacity_PropertyAddress, SetContentColorAndOpacity_FunctionAddress, "InContentColorAndOpacity");
		SetContentColorAndOpacity_InContentColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetContentColorAndOpacity_FunctionAddress, "InContentColorAndOpacity");
		SetContentColorAndOpacity_InContentColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContentColorAndOpacity_FunctionAddress, "InContentColorAndOpacity", Classes.FStructProperty);
		SetContentColorAndOpacity_IsValid = SetContentColorAndOpacity_FunctionAddress != IntPtr.Zero && SetContentColorAndOpacity_InContentColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetContentColorAndOpacity", SetContentColorAndOpacity_IsValid);
		SetBrushFromTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromTexture");
		SetBrushFromTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromTexture_Texture_PropertyAddress, SetBrushFromTexture_FunctionAddress, "Texture");
		SetBrushFromTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromTexture_FunctionAddress, "Texture");
		SetBrushFromTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		SetBrushFromTexture_IsValid = SetBrushFromTexture_FunctionAddress != IntPtr.Zero && SetBrushFromTexture_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetBrushFromTexture", SetBrushFromTexture_IsValid);
		SetBrushFromMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromMaterial");
		SetBrushFromMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromMaterial_Material_PropertyAddress, SetBrushFromMaterial_FunctionAddress, "Material");
		SetBrushFromMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromMaterial_FunctionAddress, "Material");
		SetBrushFromMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetBrushFromMaterial_IsValid = SetBrushFromMaterial_FunctionAddress != IntPtr.Zero && SetBrushFromMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetBrushFromMaterial", SetBrushFromMaterial_IsValid);
		SetBrushFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushFromAsset");
		SetBrushFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushFromAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushFromAsset_Asset_PropertyAddress, SetBrushFromAsset_FunctionAddress, "Asset");
		SetBrushFromAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushFromAsset_FunctionAddress, "Asset");
		SetBrushFromAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushFromAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		SetBrushFromAsset_IsValid = SetBrushFromAsset_FunctionAddress != IntPtr.Zero && SetBrushFromAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetBrushFromAsset", SetBrushFromAsset_IsValid);
		SetBrushColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrushColor");
		SetBrushColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushColor_InBrushColor_PropertyAddress, SetBrushColor_FunctionAddress, "InBrushColor");
		SetBrushColor_InBrushColor_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushColor_FunctionAddress, "InBrushColor");
		SetBrushColor_InBrushColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushColor_FunctionAddress, "InBrushColor", Classes.FStructProperty);
		SetBrushColor_IsValid = SetBrushColor_FunctionAddress != IntPtr.Zero && SetBrushColor_InBrushColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetBrushColor", SetBrushColor_IsValid);
		SetBrush_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBrush");
		SetBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrush_InBrush_PropertyAddress, SetBrush_FunctionAddress, "InBrush");
		SetBrush_InBrush_Offset = NativeReflectionCached.GetPropertyOffset(SetBrush_FunctionAddress, "InBrush");
		SetBrush_InBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrush_FunctionAddress, "InBrush", Classes.FStructProperty);
		SetBrush_IsValid = SetBrush_FunctionAddress != IntPtr.Zero && SetBrush_InBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:SetBrush", SetBrush_IsValid);
		GetDynamicMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDynamicMaterial");
		GetDynamicMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicMaterial_ReturnValue_PropertyAddress, GetDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDynamicMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDynamicMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicMaterial_IsValid = GetDynamicMaterial_FunctionAddress != IntPtr.Zero && GetDynamicMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Border:GetDynamicMaterial", GetDynamicMaterial_IsValid);
	}
}
