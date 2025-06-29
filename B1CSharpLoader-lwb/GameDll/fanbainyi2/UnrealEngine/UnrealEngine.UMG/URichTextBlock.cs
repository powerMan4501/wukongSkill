using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.RichTextBlock", "UMG", UnrealModuleType.Engine)]
public class URichTextBlock : UTextLayoutWidget
{
	private static bool MinDesiredWidth_IsValid;

	private static int MinDesiredWidth_Offset;

	private static bool TextTransformPolicy_IsValid;

	private static FFieldAddress TextTransformPolicy_PropertyAddress;

	private static int TextTransformPolicy_Offset;

	private static bool TextOverflowPolicy_IsValid;

	private static FFieldAddress TextOverflowPolicy_PropertyAddress;

	private static int TextOverflowPolicy_Offset;

	private static bool GSTextWrapping_IsValid;

	private static FFieldAddress GSTextWrapping_PropertyAddress;

	private static int GSTextWrapping_Offset;

	private static bool ForceCache_IsValid;

	private static FFieldAddress ForceCache_PropertyAddress;

	private static int ForceCache_Offset;

	private static bool SetTextTransformPolicy_IsValid;

	private static IntPtr SetTextTransformPolicy_FunctionAddress;

	private static int SetTextTransformPolicy_ParamsSize;

	private static bool SetTextTransformPolicy_InTransformPolicy_IsValid;

	private static FFieldAddress SetTextTransformPolicy_InTransformPolicy_PropertyAddress;

	private static int SetTextTransformPolicy_InTransformPolicy_Offset;

	private static bool SetTextStyleSet_IsValid;

	private static IntPtr SetTextStyleSet_FunctionAddress;

	private static int SetTextStyleSet_ParamsSize;

	private static bool SetTextStyleSet_NewTextStyleSet_IsValid;

	private static FFieldAddress SetTextStyleSet_NewTextStyleSet_PropertyAddress;

	private static int SetTextStyleSet_NewTextStyleSet_Offset;

	private static bool SetTextOverflowPolicy_IsValid;

	private static IntPtr SetTextOverflowPolicy_FunctionAddress;

	private static int SetTextOverflowPolicy_ParamsSize;

	private static bool SetTextOverflowPolicy_InOverflowPolicy_IsValid;

	private static FFieldAddress SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress;

	private static int SetTextOverflowPolicy_InOverflowPolicy_Offset;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_InText_IsValid;

	private static FFieldAddress SetText_InText_PropertyAddress;

	private static int SetText_InText_Offset;

	private static bool SetMinDesiredWidth_IsValid;

	private static IntPtr SetMinDesiredWidth_FunctionAddress;

	private static int SetMinDesiredWidth_ParamsSize;

	private static bool SetMinDesiredWidth_InMinDesiredWidth_IsValid;

	private static FFieldAddress SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress;

	private static int SetMinDesiredWidth_InMinDesiredWidth_Offset;

	private static bool SetGSTextWrapping_IsValid;

	private static IntPtr SetGSTextWrapping_FunctionAddress;

	private static int SetGSTextWrapping_ParamsSize;

	private static bool SetGSTextWrapping_InGSTextWrapping_IsValid;

	private static FFieldAddress SetGSTextWrapping_InGSTextWrapping_PropertyAddress;

	private static int SetGSTextWrapping_InGSTextWrapping_Offset;

	private static bool SetForceCache_IsValid;

	private static IntPtr SetForceCache_FunctionAddress;

	private static int SetForceCache_ParamsSize;

	private static bool SetForceCache_InForceCache_IsValid;

	private static FFieldAddress SetForceCache_InForceCache_PropertyAddress;

	private static int SetForceCache_InForceCache_Offset;

	private static bool SetDefaultTextStyle_IsValid;

	private static IntPtr SetDefaultTextStyle_FunctionAddress;

	private static int SetDefaultTextStyle_ParamsSize;

	private static bool SetDefaultTextStyle_InDefaultTextStyle_IsValid;

	private static FFieldAddress SetDefaultTextStyle_InDefaultTextStyle_PropertyAddress;

	private static int SetDefaultTextStyle_InDefaultTextStyle_Offset;

	private static bool SetDefaultStrikeBrush_IsValid;

	private static IntPtr SetDefaultStrikeBrush_FunctionAddress;

	private static int SetDefaultStrikeBrush_ParamsSize;

	private static bool SetDefaultStrikeBrush_InStrikeBrush_IsValid;

	private static FFieldAddress SetDefaultStrikeBrush_InStrikeBrush_PropertyAddress;

	private static int SetDefaultStrikeBrush_InStrikeBrush_Offset;

	private static bool SetDefaultShadowOffset_IsValid;

	private static IntPtr SetDefaultShadowOffset_FunctionAddress;

	private static int SetDefaultShadowOffset_ParamsSize;

	private static bool SetDefaultShadowOffset_InShadowOffset_IsValid;

	private static FFieldAddress SetDefaultShadowOffset_InShadowOffset_PropertyAddress;

	private static int SetDefaultShadowOffset_InShadowOffset_Offset;

	private static bool SetDefaultShadowColorAndOpacity_IsValid;

	private static IntPtr SetDefaultShadowColorAndOpacity_FunctionAddress;

	private static int SetDefaultShadowColorAndOpacity_ParamsSize;

	private static bool SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_IsValid;

	private static FFieldAddress SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_PropertyAddress;

	private static int SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_Offset;

	private static bool SetDefaultFont_IsValid;

	private static IntPtr SetDefaultFont_FunctionAddress;

	private static int SetDefaultFont_ParamsSize;

	private static bool SetDefaultFont_InFontInfo_IsValid;

	private static FFieldAddress SetDefaultFont_InFontInfo_PropertyAddress;

	private static int SetDefaultFont_InFontInfo_Offset;

	private static bool SetDefaultColorAndOpacity_IsValid;

	private static IntPtr SetDefaultColorAndOpacity_FunctionAddress;

	private static int SetDefaultColorAndOpacity_ParamsSize;

	private static bool SetDefaultColorAndOpacity_InColorAndOpacity_IsValid;

	private static FFieldAddress SetDefaultColorAndOpacity_InColorAndOpacity_PropertyAddress;

	private static int SetDefaultColorAndOpacity_InColorAndOpacity_Offset;

	private static bool SetAutoWrapText_IsValid;

	private static IntPtr SetAutoWrapText_FunctionAddress;

	private static int SetAutoWrapText_ParamsSize;

	private static bool SetAutoWrapText_InAutoTextWrap_IsValid;

	private static FFieldAddress SetAutoWrapText_InAutoTextWrap_PropertyAddress;

	private static int SetAutoWrapText_InAutoTextWrap_Offset;

	private static bool RefreshTextLayout_IsValid;

	private static IntPtr RefreshTextLayout_FunctionAddress;

	private static int RefreshTextLayout_ParamsSize;

	private static bool GetTextOccupiedWidth_IsValid;

	private static IntPtr GetTextOccupiedWidth_FunctionAddress;

	private static int GetTextOccupiedWidth_ParamsSize;

	private static bool GetTextOccupiedWidth_InTextContent_IsValid;

	private static FFieldAddress GetTextOccupiedWidth_InTextContent_PropertyAddress;

	private static int GetTextOccupiedWidth_InTextContent_Offset;

	private static bool GetTextOccupiedWidth_ReturnValue_IsValid;

	private static FFieldAddress GetTextOccupiedWidth_ReturnValue_PropertyAddress;

	private static int GetTextOccupiedWidth_ReturnValue_Offset;

	private static bool GetTextLineCount_IsValid;

	private static IntPtr GetTextLineCount_FunctionAddress;

	private static int GetTextLineCount_ParamsSize;

	private static bool GetTextLineCount_ReturnValue_IsValid;

	private static FFieldAddress GetTextLineCount_ReturnValue_PropertyAddress;

	private static int GetTextLineCount_ReturnValue_Offset;

	private static bool GetText_IsValid;

	private static IntPtr GetText_FunctionAddress;

	private static int GetText_ParamsSize;

	private static bool GetText_ReturnValue_IsValid;

	private static FFieldAddress GetText_ReturnValue_PropertyAddress;

	private static int GetText_ReturnValue_Offset;

	private static bool GetDefaultDynamicMaterial_IsValid;

	private static IntPtr GetDefaultDynamicMaterial_FunctionAddress;

	private static int GetDefaultDynamicMaterial_ParamsSize;

	private static bool GetDefaultDynamicMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultDynamicMaterial_ReturnValue_PropertyAddress;

	private static int GetDefaultDynamicMaterial_ReturnValue_Offset;

	private static bool GetDecoratorByClass_IsValid;

	private static IntPtr GetDecoratorByClass_FunctionAddress;

	private static int GetDecoratorByClass_ParamsSize;

	private static bool GetDecoratorByClass_DecoratorClass_IsValid;

	private static FFieldAddress GetDecoratorByClass_DecoratorClass_PropertyAddress;

	private static int GetDecoratorByClass_DecoratorClass_Offset;

	private static bool GetDecoratorByClass_ReturnValue_IsValid;

	private static FFieldAddress GetDecoratorByClass_ReturnValue_PropertyAddress;

	private static int GetDecoratorByClass_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.RichTextBlock:MinDesiredWidth")]
	protected float MinDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:MinDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:MinDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.RichTextBlock:TextTransformPolicy")]
	protected ETextTransformPolicy TextTransformPolicy
	{
		get
		{
			CheckDestroyed();
			if (!TextTransformPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:TextTransformPolicy");
				return ETextTransformPolicy.None;
			}
			return EnumMarshaler<ETextTransformPolicy>.FromNative(IntPtr.Add(base.Address, TextTransformPolicy_Offset), 0, TextTransformPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TextTransformPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:TextTransformPolicy");
			}
			else
			{
				EnumMarshaler<ETextTransformPolicy>.ToNative(IntPtr.Add(base.Address, TextTransformPolicy_Offset), 0, TextTransformPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272263001178629uL)]
	[UMetaPath("/Script/UMG.RichTextBlock:TextOverflowPolicy")]
	protected ETextOverflowPolicy TextOverflowPolicy
	{
		get
		{
			CheckDestroyed();
			if (!TextOverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:TextOverflowPolicy");
				return ETextOverflowPolicy.Clip;
			}
			return EnumMarshaler<ETextOverflowPolicy>.FromNative(IntPtr.Add(base.Address, TextOverflowPolicy_Offset), 0, TextOverflowPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TextOverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:TextOverflowPolicy");
			}
			else
			{
				EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(base.Address, TextOverflowPolicy_Offset), 0, TextOverflowPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.RichTextBlock:GSTextWrapping")]
	protected bool GSTextWrapping
	{
		get
		{
			CheckDestroyed();
			if (!GSTextWrapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:GSTextWrapping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSTextWrapping_Offset), 0, GSTextWrapping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSTextWrapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:GSTextWrapping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSTextWrapping_Offset), 0, GSTextWrapping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.RichTextBlock:ForceCache")]
	protected bool ForceCache
	{
		get
		{
			CheckDestroyed();
			if (!ForceCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:ForceCache");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceCache_Offset), 0, ForceCache_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.RichTextBlock:ForceCache");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceCache_Offset), 0, ForceCache_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetTextTransformPolicy")]
	public unsafe void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
	{
		CheckDestroyed();
		if (!SetTextTransformPolicy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetTextTransformPolicy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextTransformPolicy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextTransformPolicy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETextTransformPolicy>.ToNative(IntPtr.Add(intPtr, SetTextTransformPolicy_InTransformPolicy_Offset), 0, SetTextTransformPolicy_InTransformPolicy_PropertyAddress.Address, InTransformPolicy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextTransformPolicy_FunctionAddress, intPtr, SetTextTransformPolicy_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetTextStyleSet")]
	public unsafe void SetTextStyleSet(UDataTable NewTextStyleSet)
	{
		CheckDestroyed();
		if (!SetTextStyleSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetTextStyleSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextStyleSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextStyleSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, SetTextStyleSet_NewTextStyleSet_Offset), 0, SetTextStyleSet_NewTextStyleSet_PropertyAddress.Address, NewTextStyleSet);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextStyleSet_FunctionAddress, intPtr, SetTextStyleSet_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetTextOverflowPolicy")]
	public unsafe void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy)
	{
		CheckDestroyed();
		if (!SetTextOverflowPolicy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetTextOverflowPolicy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextOverflowPolicy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextOverflowPolicy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(intPtr, SetTextOverflowPolicy_InOverflowPolicy_Offset), 0, SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress.Address, InOverflowPolicy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextOverflowPolicy_FunctionAddress, intPtr, SetTextOverflowPolicy_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetText_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetText_InText_Offset), 0, SetText_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetText_FunctionAddress, intPtr, SetText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetText_InText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetMinDesiredWidth")]
	public unsafe void SetMinDesiredWidth(float InMinDesiredWidth)
	{
		CheckDestroyed();
		if (!SetMinDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetMinDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinDesiredWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinDesiredWidth_InMinDesiredWidth_Offset), 0, SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress.Address, InMinDesiredWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinDesiredWidth_FunctionAddress, intPtr, SetMinDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetGSTextWrapping")]
	public unsafe void SetGSTextWrapping(bool InGSTextWrapping)
	{
		CheckDestroyed();
		if (!SetGSTextWrapping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetGSTextWrapping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSTextWrapping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSTextWrapping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGSTextWrapping_InGSTextWrapping_Offset), 0, SetGSTextWrapping_InGSTextWrapping_PropertyAddress.Address, InGSTextWrapping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSTextWrapping_FunctionAddress, intPtr, SetGSTextWrapping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetForceCache")]
	public unsafe void SetForceCache(bool InForceCache)
	{
		CheckDestroyed();
		if (!SetForceCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetForceCache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceCache_InForceCache_Offset), 0, SetForceCache_InForceCache_PropertyAddress.Address, InForceCache);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceCache_FunctionAddress, intPtr, SetForceCache_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetDefaultTextStyle")]
	public unsafe void SetDefaultTextStyle(FTextBlockStyle InDefaultTextStyle)
	{
		CheckDestroyed();
		if (!SetDefaultTextStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetDefaultTextStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultTextStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultTextStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultTextStyle_InDefaultTextStyle_PropertyAddress.Address, intPtr);
		FTextBlockStyle.ToNative(IntPtr.Add(intPtr, SetDefaultTextStyle_InDefaultTextStyle_Offset), 0, SetDefaultTextStyle_InDefaultTextStyle_PropertyAddress.Address, InDefaultTextStyle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultTextStyle_FunctionAddress, intPtr, SetDefaultTextStyle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDefaultTextStyle_InDefaultTextStyle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetDefaultStrikeBrush")]
	public unsafe void SetDefaultStrikeBrush(out FSlateBrush InStrikeBrush)
	{
		CheckDestroyed();
		if (!SetDefaultStrikeBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetDefaultStrikeBrush");
			InStrikeBrush = default(FSlateBrush);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultStrikeBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultStrikeBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultStrikeBrush_InStrikeBrush_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultStrikeBrush_FunctionAddress, intPtr, SetDefaultStrikeBrush_ParamsSize);
		InStrikeBrush = FSlateBrush.FromNative(IntPtr.Add(intPtr, SetDefaultStrikeBrush_InStrikeBrush_Offset), 0, SetDefaultStrikeBrush_InStrikeBrush_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetDefaultStrikeBrush_InStrikeBrush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetDefaultShadowOffset")]
	public unsafe void SetDefaultShadowOffset(FVector2D InShadowOffset)
	{
		CheckDestroyed();
		if (!SetDefaultShadowOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetDefaultShadowOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultShadowOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultShadowOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetDefaultShadowOffset_InShadowOffset_Offset), 0, SetDefaultShadowOffset_InShadowOffset_PropertyAddress.Address, InShadowOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultShadowOffset_FunctionAddress, intPtr, SetDefaultShadowOffset_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetDefaultShadowColorAndOpacity")]
	public unsafe void SetDefaultShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetDefaultShadowColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetDefaultShadowColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultShadowColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultShadowColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_Offset), 0, SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_PropertyAddress.Address, InShadowColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultShadowColorAndOpacity_FunctionAddress, intPtr, SetDefaultShadowColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetDefaultFont")]
	public unsafe void SetDefaultFont(FSlateFontInfo InFontInfo)
	{
		CheckDestroyed();
		if (!SetDefaultFont_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetDefaultFont");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultFont_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultFont_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultFont_InFontInfo_PropertyAddress.Address, intPtr);
		FSlateFontInfo.ToNative(IntPtr.Add(intPtr, SetDefaultFont_InFontInfo_Offset), 0, SetDefaultFont_InFontInfo_PropertyAddress.Address, InFontInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultFont_FunctionAddress, intPtr, SetDefaultFont_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDefaultFont_InFontInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetDefaultColorAndOpacity")]
	public unsafe void SetDefaultColorAndOpacity(FSlateColor InColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetDefaultColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetDefaultColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, intPtr);
		FSlateColor.ToNative(IntPtr.Add(intPtr, SetDefaultColorAndOpacity_InColorAndOpacity_Offset), 0, SetDefaultColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultColorAndOpacity_FunctionAddress, intPtr, SetDefaultColorAndOpacity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDefaultColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:SetAutoWrapText")]
	public unsafe void SetAutoWrapText(bool InAutoTextWrap)
	{
		CheckDestroyed();
		if (!SetAutoWrapText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:SetAutoWrapText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoWrapText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoWrapText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAutoWrapText_InAutoTextWrap_Offset), 0, SetAutoWrapText_InAutoTextWrap_PropertyAddress.Address, InAutoTextWrap);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoWrapText_FunctionAddress, intPtr, SetAutoWrapText_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:RefreshTextLayout")]
	public unsafe void RefreshTextLayout()
	{
		CheckDestroyed();
		if (!RefreshTextLayout_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:RefreshTextLayout");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshTextLayout_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshTextLayout_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshTextLayout_FunctionAddress, argsSize: RefreshTextLayout_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.RichTextBlock:GetTextOccupiedWidth")]
	public unsafe float GetTextOccupiedWidth(string InTextContent)
	{
		CheckDestroyed();
		if (!GetTextOccupiedWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:GetTextOccupiedWidth");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextOccupiedWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextOccupiedWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTextOccupiedWidth_InTextContent_Offset), 0, GetTextOccupiedWidth_InTextContent_PropertyAddress.Address, InTextContent);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextOccupiedWidth_FunctionAddress, intPtr, GetTextOccupiedWidth_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTextOccupiedWidth_InTextContent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTextOccupiedWidth_ReturnValue_Offset), 0, GetTextOccupiedWidth_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.RichTextBlock:GetTextLineCount")]
	public unsafe int GetTextLineCount()
	{
		CheckDestroyed();
		if (!GetTextLineCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:GetTextLineCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextLineCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextLineCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextLineCount_FunctionAddress, intPtr, GetTextLineCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextLineCount_ReturnValue_Offset), 0, GetTextLineCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.RichTextBlock:GetText")]
	public unsafe string GetText()
	{
		CheckDestroyed();
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:GetText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetText_FunctionAddress, intPtr, GetText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetText_ReturnValue_Offset), 0, GetText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:GetDefaultDynamicMaterial")]
	public unsafe UMaterialInstanceDynamic GetDefaultDynamicMaterial()
	{
		CheckDestroyed();
		if (!GetDefaultDynamicMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:GetDefaultDynamicMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultDynamicMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultDynamicMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultDynamicMaterial_FunctionAddress, intPtr, GetDefaultDynamicMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetDefaultDynamicMaterial_ReturnValue_Offset), 0, GetDefaultDynamicMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.RichTextBlock:GetDecoratorByClass")]
	public unsafe URichTextBlockDecorator GetDecoratorByClass(TSubclassOf<URichTextBlockDecorator> DecoratorClass)
	{
		CheckDestroyed();
		if (!GetDecoratorByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.RichTextBlock:GetDecoratorByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDecoratorByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDecoratorByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<URichTextBlockDecorator>.ToNative(IntPtr.Add(intPtr, GetDecoratorByClass_DecoratorClass_Offset), 0, GetDecoratorByClass_DecoratorClass_PropertyAddress.Address, DecoratorClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDecoratorByClass_FunctionAddress, intPtr, GetDecoratorByClass_ParamsSize);
		return UObjectMarshaler<URichTextBlockDecorator>.FromNative(IntPtr.Add(intPtr, GetDecoratorByClass_ReturnValue_Offset), 0, GetDecoratorByClass_ReturnValue_PropertyAddress.Address);
	}

	static URichTextBlock()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URichTextBlock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URichTextBlock));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.RichTextBlock");
		MinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredWidth");
		MinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TextTransformPolicy_PropertyAddress, intPtr, "TextTransformPolicy");
		TextTransformPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextTransformPolicy");
		TextTransformPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextTransformPolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TextOverflowPolicy_PropertyAddress, intPtr, "TextOverflowPolicy");
		TextOverflowPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextOverflowPolicy");
		TextOverflowPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextOverflowPolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GSTextWrapping_PropertyAddress, intPtr, "GSTextWrapping");
		GSTextWrapping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSTextWrapping");
		GSTextWrapping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSTextWrapping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceCache_PropertyAddress, intPtr, "ForceCache");
		ForceCache_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceCache");
		ForceCache_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceCache", Classes.FBoolProperty);
		SetTextTransformPolicy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextTransformPolicy");
		SetTextTransformPolicy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextTransformPolicy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextTransformPolicy_InTransformPolicy_PropertyAddress, SetTextTransformPolicy_FunctionAddress, "InTransformPolicy");
		SetTextTransformPolicy_InTransformPolicy_Offset = NativeReflectionCached.GetPropertyOffset(SetTextTransformPolicy_FunctionAddress, "InTransformPolicy");
		SetTextTransformPolicy_InTransformPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextTransformPolicy_FunctionAddress, "InTransformPolicy", Classes.FEnumProperty);
		SetTextTransformPolicy_IsValid = SetTextTransformPolicy_FunctionAddress != IntPtr.Zero && SetTextTransformPolicy_InTransformPolicy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetTextTransformPolicy", SetTextTransformPolicy_IsValid);
		SetTextStyleSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextStyleSet");
		SetTextStyleSet_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextStyleSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextStyleSet_NewTextStyleSet_PropertyAddress, SetTextStyleSet_FunctionAddress, "NewTextStyleSet");
		SetTextStyleSet_NewTextStyleSet_Offset = NativeReflectionCached.GetPropertyOffset(SetTextStyleSet_FunctionAddress, "NewTextStyleSet");
		SetTextStyleSet_NewTextStyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextStyleSet_FunctionAddress, "NewTextStyleSet", Classes.FObjectProperty);
		SetTextStyleSet_IsValid = SetTextStyleSet_FunctionAddress != IntPtr.Zero && SetTextStyleSet_NewTextStyleSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetTextStyleSet", SetTextStyleSet_IsValid);
		SetTextOverflowPolicy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextOverflowPolicy");
		SetTextOverflowPolicy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextOverflowPolicy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress, SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy");
		SetTextOverflowPolicy_InOverflowPolicy_Offset = NativeReflectionCached.GetPropertyOffset(SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy");
		SetTextOverflowPolicy_InOverflowPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy", Classes.FEnumProperty);
		SetTextOverflowPolicy_IsValid = SetTextOverflowPolicy_FunctionAddress != IntPtr.Zero && SetTextOverflowPolicy_InOverflowPolicy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetTextOverflowPolicy", SetTextOverflowPolicy_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetText", SetText_IsValid);
		SetMinDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinDesiredWidth");
		SetMinDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinDesiredWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress, SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth");
		SetMinDesiredWidth_InMinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth");
		SetMinDesiredWidth_InMinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth", Classes.FFloatProperty);
		SetMinDesiredWidth_IsValid = SetMinDesiredWidth_FunctionAddress != IntPtr.Zero && SetMinDesiredWidth_InMinDesiredWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetMinDesiredWidth", SetMinDesiredWidth_IsValid);
		SetGSTextWrapping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSTextWrapping");
		SetGSTextWrapping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSTextWrapping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSTextWrapping_InGSTextWrapping_PropertyAddress, SetGSTextWrapping_FunctionAddress, "InGSTextWrapping");
		SetGSTextWrapping_InGSTextWrapping_Offset = NativeReflectionCached.GetPropertyOffset(SetGSTextWrapping_FunctionAddress, "InGSTextWrapping");
		SetGSTextWrapping_InGSTextWrapping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSTextWrapping_FunctionAddress, "InGSTextWrapping", Classes.FBoolProperty);
		SetGSTextWrapping_IsValid = SetGSTextWrapping_FunctionAddress != IntPtr.Zero && SetGSTextWrapping_InGSTextWrapping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetGSTextWrapping", SetGSTextWrapping_IsValid);
		SetForceCache_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceCache");
		SetForceCache_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceCache_InForceCache_PropertyAddress, SetForceCache_FunctionAddress, "InForceCache");
		SetForceCache_InForceCache_Offset = NativeReflectionCached.GetPropertyOffset(SetForceCache_FunctionAddress, "InForceCache");
		SetForceCache_InForceCache_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceCache_FunctionAddress, "InForceCache", Classes.FBoolProperty);
		SetForceCache_IsValid = SetForceCache_FunctionAddress != IntPtr.Zero && SetForceCache_InForceCache_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetForceCache", SetForceCache_IsValid);
		SetDefaultTextStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultTextStyle");
		SetDefaultTextStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultTextStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultTextStyle_InDefaultTextStyle_PropertyAddress, SetDefaultTextStyle_FunctionAddress, "InDefaultTextStyle");
		SetDefaultTextStyle_InDefaultTextStyle_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultTextStyle_FunctionAddress, "InDefaultTextStyle");
		SetDefaultTextStyle_InDefaultTextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultTextStyle_FunctionAddress, "InDefaultTextStyle", Classes.FStructProperty);
		SetDefaultTextStyle_IsValid = SetDefaultTextStyle_FunctionAddress != IntPtr.Zero && SetDefaultTextStyle_InDefaultTextStyle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetDefaultTextStyle", SetDefaultTextStyle_IsValid);
		SetDefaultStrikeBrush_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultStrikeBrush");
		SetDefaultStrikeBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultStrikeBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultStrikeBrush_InStrikeBrush_PropertyAddress, SetDefaultStrikeBrush_FunctionAddress, "InStrikeBrush");
		SetDefaultStrikeBrush_InStrikeBrush_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultStrikeBrush_FunctionAddress, "InStrikeBrush");
		SetDefaultStrikeBrush_InStrikeBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultStrikeBrush_FunctionAddress, "InStrikeBrush", Classes.FStructProperty);
		SetDefaultStrikeBrush_IsValid = SetDefaultStrikeBrush_FunctionAddress != IntPtr.Zero && SetDefaultStrikeBrush_InStrikeBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetDefaultStrikeBrush", SetDefaultStrikeBrush_IsValid);
		SetDefaultShadowOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultShadowOffset");
		SetDefaultShadowOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultShadowOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultShadowOffset_InShadowOffset_PropertyAddress, SetDefaultShadowOffset_FunctionAddress, "InShadowOffset");
		SetDefaultShadowOffset_InShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultShadowOffset_FunctionAddress, "InShadowOffset");
		SetDefaultShadowOffset_InShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultShadowOffset_FunctionAddress, "InShadowOffset", Classes.FStructProperty);
		SetDefaultShadowOffset_IsValid = SetDefaultShadowOffset_FunctionAddress != IntPtr.Zero && SetDefaultShadowOffset_InShadowOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetDefaultShadowOffset", SetDefaultShadowOffset_IsValid);
		SetDefaultShadowColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultShadowColorAndOpacity");
		SetDefaultShadowColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultShadowColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_PropertyAddress, SetDefaultShadowColorAndOpacity_FunctionAddress, "InShadowColorAndOpacity");
		SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultShadowColorAndOpacity_FunctionAddress, "InShadowColorAndOpacity");
		SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultShadowColorAndOpacity_FunctionAddress, "InShadowColorAndOpacity", Classes.FStructProperty);
		SetDefaultShadowColorAndOpacity_IsValid = SetDefaultShadowColorAndOpacity_FunctionAddress != IntPtr.Zero && SetDefaultShadowColorAndOpacity_InShadowColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetDefaultShadowColorAndOpacity", SetDefaultShadowColorAndOpacity_IsValid);
		SetDefaultFont_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultFont");
		SetDefaultFont_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultFont_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultFont_InFontInfo_PropertyAddress, SetDefaultFont_FunctionAddress, "InFontInfo");
		SetDefaultFont_InFontInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultFont_FunctionAddress, "InFontInfo");
		SetDefaultFont_InFontInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultFont_FunctionAddress, "InFontInfo", Classes.FStructProperty);
		SetDefaultFont_IsValid = SetDefaultFont_FunctionAddress != IntPtr.Zero && SetDefaultFont_InFontInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetDefaultFont", SetDefaultFont_IsValid);
		SetDefaultColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultColorAndOpacity");
		SetDefaultColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultColorAndOpacity_InColorAndOpacity_PropertyAddress, SetDefaultColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetDefaultColorAndOpacity_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetDefaultColorAndOpacity_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultColorAndOpacity_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		SetDefaultColorAndOpacity_IsValid = SetDefaultColorAndOpacity_FunctionAddress != IntPtr.Zero && SetDefaultColorAndOpacity_InColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetDefaultColorAndOpacity", SetDefaultColorAndOpacity_IsValid);
		SetAutoWrapText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoWrapText");
		SetAutoWrapText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoWrapText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoWrapText_InAutoTextWrap_PropertyAddress, SetAutoWrapText_FunctionAddress, "InAutoTextWrap");
		SetAutoWrapText_InAutoTextWrap_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoWrapText_FunctionAddress, "InAutoTextWrap");
		SetAutoWrapText_InAutoTextWrap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoWrapText_FunctionAddress, "InAutoTextWrap", Classes.FBoolProperty);
		SetAutoWrapText_IsValid = SetAutoWrapText_FunctionAddress != IntPtr.Zero && SetAutoWrapText_InAutoTextWrap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:SetAutoWrapText", SetAutoWrapText_IsValid);
		RefreshTextLayout_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshTextLayout");
		RefreshTextLayout_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshTextLayout_FunctionAddress);
		RefreshTextLayout_IsValid = RefreshTextLayout_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:RefreshTextLayout", RefreshTextLayout_IsValid);
		GetTextOccupiedWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextOccupiedWidth");
		GetTextOccupiedWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextOccupiedWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextOccupiedWidth_InTextContent_PropertyAddress, GetTextOccupiedWidth_FunctionAddress, "InTextContent");
		GetTextOccupiedWidth_InTextContent_Offset = NativeReflectionCached.GetPropertyOffset(GetTextOccupiedWidth_FunctionAddress, "InTextContent");
		GetTextOccupiedWidth_InTextContent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextOccupiedWidth_FunctionAddress, "InTextContent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextOccupiedWidth_ReturnValue_PropertyAddress, GetTextOccupiedWidth_FunctionAddress, "ReturnValue");
		GetTextOccupiedWidth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextOccupiedWidth_FunctionAddress, "ReturnValue");
		GetTextOccupiedWidth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextOccupiedWidth_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTextOccupiedWidth_IsValid = GetTextOccupiedWidth_FunctionAddress != IntPtr.Zero && GetTextOccupiedWidth_InTextContent_IsValid && GetTextOccupiedWidth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:GetTextOccupiedWidth", GetTextOccupiedWidth_IsValid);
		GetTextLineCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextLineCount");
		GetTextLineCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextLineCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextLineCount_ReturnValue_PropertyAddress, GetTextLineCount_FunctionAddress, "ReturnValue");
		GetTextLineCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextLineCount_FunctionAddress, "ReturnValue");
		GetTextLineCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextLineCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTextLineCount_IsValid = GetTextLineCount_FunctionAddress != IntPtr.Zero && GetTextLineCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:GetTextLineCount", GetTextLineCount_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:GetText", GetText_IsValid);
		GetDefaultDynamicMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultDynamicMaterial");
		GetDefaultDynamicMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultDynamicMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultDynamicMaterial_ReturnValue_PropertyAddress, GetDefaultDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDefaultDynamicMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDefaultDynamicMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultDynamicMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultDynamicMaterial_IsValid = GetDefaultDynamicMaterial_FunctionAddress != IntPtr.Zero && GetDefaultDynamicMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:GetDefaultDynamicMaterial", GetDefaultDynamicMaterial_IsValid);
		GetDecoratorByClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDecoratorByClass");
		GetDecoratorByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDecoratorByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDecoratorByClass_DecoratorClass_PropertyAddress, GetDecoratorByClass_FunctionAddress, "DecoratorClass");
		GetDecoratorByClass_DecoratorClass_Offset = NativeReflectionCached.GetPropertyOffset(GetDecoratorByClass_FunctionAddress, "DecoratorClass");
		GetDecoratorByClass_DecoratorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDecoratorByClass_FunctionAddress, "DecoratorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDecoratorByClass_ReturnValue_PropertyAddress, GetDecoratorByClass_FunctionAddress, "ReturnValue");
		GetDecoratorByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDecoratorByClass_FunctionAddress, "ReturnValue");
		GetDecoratorByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDecoratorByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDecoratorByClass_IsValid = GetDecoratorByClass_FunctionAddress != IntPtr.Zero && GetDecoratorByClass_DecoratorClass_IsValid && GetDecoratorByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.RichTextBlock:GetDecoratorByClass", GetDecoratorByClass_IsValid);
	}
}
