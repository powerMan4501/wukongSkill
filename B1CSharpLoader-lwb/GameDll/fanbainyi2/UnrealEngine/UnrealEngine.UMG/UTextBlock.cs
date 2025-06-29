using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.TextBlock", "UMG", UnrealModuleType.Engine)]
public class UTextBlock : UTextLayoutWidget
{
	private static bool ColorAndOpacity_IsValid;

	private static int ColorAndOpacity_Offset;

	private static bool OverrideLetterSpacing_IsValid;

	private static int OverrideLetterSpacing_Offset;

	private static bool Font_IsValid;

	private static int Font_Offset;

	private static bool StrikeBrush_IsValid;

	private static int StrikeBrush_Offset;

	private static bool ShadowOffset_IsValid;

	private static int ShadowOffset_Offset;

	private static bool ShadowColorAndOpacity_IsValid;

	private static int ShadowColorAndOpacity_Offset;

	private static bool MinDesiredWidth_IsValid;

	private static int MinDesiredWidth_Offset;

	private static bool WrapWithInvalidationPanel_IsValid;

	private static FFieldAddress WrapWithInvalidationPanel_PropertyAddress;

	private static int WrapWithInvalidationPanel_Offset;

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

	private static bool SimpleTextMode_IsValid;

	private static FFieldAddress SimpleTextMode_PropertyAddress;

	private static int SimpleTextMode_Offset;

	private static bool SetTextTransformPolicy_IsValid;

	private static IntPtr SetTextTransformPolicy_FunctionAddress;

	private static int SetTextTransformPolicy_ParamsSize;

	private static bool SetTextTransformPolicy_InTransformPolicy_IsValid;

	private static FFieldAddress SetTextTransformPolicy_InTransformPolicy_PropertyAddress;

	private static int SetTextTransformPolicy_InTransformPolicy_Offset;

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

	private static bool SetStrikeBrush_IsValid;

	private static IntPtr SetStrikeBrush_FunctionAddress;

	private static int SetStrikeBrush_ParamsSize;

	private static bool SetStrikeBrush_InStrikeBrush_IsValid;

	private static FFieldAddress SetStrikeBrush_InStrikeBrush_PropertyAddress;

	private static int SetStrikeBrush_InStrikeBrush_Offset;

	private static bool SetShadowOffset_IsValid;

	private static IntPtr SetShadowOffset_FunctionAddress;

	private static int SetShadowOffset_ParamsSize;

	private static bool SetShadowOffset_InShadowOffset_IsValid;

	private static FFieldAddress SetShadowOffset_InShadowOffset_PropertyAddress;

	private static int SetShadowOffset_InShadowOffset_Offset;

	private static bool SetShadowColorAndOpacity_IsValid;

	private static IntPtr SetShadowColorAndOpacity_FunctionAddress;

	private static int SetShadowColorAndOpacity_ParamsSize;

	private static bool SetShadowColorAndOpacity_InShadowColorAndOpacity_IsValid;

	private static FFieldAddress SetShadowColorAndOpacity_InShadowColorAndOpacity_PropertyAddress;

	private static int SetShadowColorAndOpacity_InShadowColorAndOpacity_Offset;

	private static bool SetOverrideLetterSpacing_IsValid;

	private static IntPtr SetOverrideLetterSpacing_FunctionAddress;

	private static int SetOverrideLetterSpacing_ParamsSize;

	private static bool SetOverrideLetterSpacing_InOverrideLetterSpacing_IsValid;

	private static FFieldAddress SetOverrideLetterSpacing_InOverrideLetterSpacing_PropertyAddress;

	private static int SetOverrideLetterSpacing_InOverrideLetterSpacing_Offset;

	private static bool SetOpacity_IsValid;

	private static IntPtr SetOpacity_FunctionAddress;

	private static int SetOpacity_ParamsSize;

	private static bool SetOpacity_InOpacity_IsValid;

	private static FFieldAddress SetOpacity_InOpacity_PropertyAddress;

	private static int SetOpacity_InOpacity_Offset;

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

	private static bool SetFont_IsValid;

	private static IntPtr SetFont_FunctionAddress;

	private static int SetFont_ParamsSize;

	private static bool SetFont_InFontInfo_IsValid;

	private static FFieldAddress SetFont_InFontInfo_PropertyAddress;

	private static int SetFont_InFontInfo_Offset;

	private static bool SetColorAndOpacity_IsValid;

	private static IntPtr SetColorAndOpacity_FunctionAddress;

	private static int SetColorAndOpacity_ParamsSize;

	private static bool SetColorAndOpacity_InColorAndOpacity_IsValid;

	private static FFieldAddress SetColorAndOpacity_InColorAndOpacity_PropertyAddress;

	private static int SetColorAndOpacity_InColorAndOpacity_Offset;

	private static bool SetAutoWrapText_IsValid;

	private static IntPtr SetAutoWrapText_FunctionAddress;

	private static int SetAutoWrapText_ParamsSize;

	private static bool SetAutoWrapText_InAutoTextWrap_IsValid;

	private static FFieldAddress SetAutoWrapText_InAutoTextWrap_PropertyAddress;

	private static int SetAutoWrapText_InAutoTextWrap_Offset;

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

	private static bool GetDynamicOutlineMaterial_IsValid;

	private static IntPtr GetDynamicOutlineMaterial_FunctionAddress;

	private static int GetDynamicOutlineMaterial_ParamsSize;

	private static bool GetDynamicOutlineMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDynamicOutlineMaterial_ReturnValue_PropertyAddress;

	private static int GetDynamicOutlineMaterial_ReturnValue_Offset;

	private static bool GetDynamicFontMaterial_IsValid;

	private static IntPtr GetDynamicFontMaterial_FunctionAddress;

	private static int GetDynamicFontMaterial_ParamsSize;

	private static bool GetDynamicFontMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDynamicFontMaterial_ReturnValue_PropertyAddress;

	private static int GetDynamicFontMaterial_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.TextBlock:ColorAndOpacity")]
	public FSlateColor ColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ColorAndOpacity");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ColorAndOpacity");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:OverrideLetterSpacing")]
	public float OverrideLetterSpacing
	{
		get
		{
			CheckDestroyed();
			if (!OverrideLetterSpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:OverrideLetterSpacing");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideLetterSpacing_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideLetterSpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:OverrideLetterSpacing");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideLetterSpacing_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055765uL)]
	[UMetaPath("/Script/UMG.TextBlock:Font")]
	public FSlateFontInfo Font
	{
		get
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:Font");
				return default(FSlateFontInfo);
			}
			return FSlateFontInfo.FromNative(IntPtr.Add(base.Address, Font_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:Font");
			}
			else
			{
				FSlateFontInfo.ToNative(IntPtr.Add(base.Address, Font_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.TextBlock:StrikeBrush")]
	public FSlateBrush StrikeBrush
	{
		get
		{
			CheckDestroyed();
			if (!StrikeBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:StrikeBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, StrikeBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrikeBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:StrikeBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, StrikeBrush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:ShadowOffset")]
	public FVector2D ShadowOffset
	{
		get
		{
			CheckDestroyed();
			if (!ShadowOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ShadowOffset");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, ShadowOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ShadowOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, ShadowOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:ShadowColorAndOpacity")]
	public FLinearColor ShadowColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!ShadowColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ShadowColorAndOpacity");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ShadowColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ShadowColorAndOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ShadowColorAndOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:MinDesiredWidth")]
	public float MinDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:MinDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:MinDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.TextBlock:bWrapWithInvalidationPanel")]
	public bool WrapWithInvalidationPanel
	{
		get
		{
			CheckDestroyed();
			if (!WrapWithInvalidationPanel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:bWrapWithInvalidationPanel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WrapWithInvalidationPanel_Offset), 0, WrapWithInvalidationPanel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WrapWithInvalidationPanel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:bWrapWithInvalidationPanel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WrapWithInvalidationPanel_Offset), 0, WrapWithInvalidationPanel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:TextTransformPolicy")]
	public ETextTransformPolicy TextTransformPolicy
	{
		get
		{
			CheckDestroyed();
			if (!TextTransformPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:TextTransformPolicy");
				return ETextTransformPolicy.None;
			}
			return EnumMarshaler<ETextTransformPolicy>.FromNative(IntPtr.Add(base.Address, TextTransformPolicy_Offset), 0, TextTransformPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TextTransformPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:TextTransformPolicy");
			}
			else
			{
				EnumMarshaler<ETextTransformPolicy>.ToNative(IntPtr.Add(base.Address, TextTransformPolicy_Offset), 0, TextTransformPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UMG.TextBlock:TextOverflowPolicy")]
	public ETextOverflowPolicy TextOverflowPolicy
	{
		get
		{
			CheckDestroyed();
			if (!TextOverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:TextOverflowPolicy");
				return ETextOverflowPolicy.Clip;
			}
			return EnumMarshaler<ETextOverflowPolicy>.FromNative(IntPtr.Add(base.Address, TextOverflowPolicy_Offset), 0, TextOverflowPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TextOverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:TextOverflowPolicy");
			}
			else
			{
				EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(base.Address, TextOverflowPolicy_Offset), 0, TextOverflowPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:GSTextWrapping")]
	public bool GSTextWrapping
	{
		get
		{
			CheckDestroyed();
			if (!GSTextWrapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:GSTextWrapping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSTextWrapping_Offset), 0, GSTextWrapping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSTextWrapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:GSTextWrapping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSTextWrapping_Offset), 0, GSTextWrapping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.TextBlock:ForceCache")]
	public bool ForceCache
	{
		get
		{
			CheckDestroyed();
			if (!ForceCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ForceCache");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceCache_Offset), 0, ForceCache_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:ForceCache");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceCache_Offset), 0, ForceCache_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272263001178645uL)]
	[UMetaPath("/Script/UMG.TextBlock:bSimpleTextMode")]
	protected bool SimpleTextMode
	{
		get
		{
			CheckDestroyed();
			if (!SimpleTextMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:bSimpleTextMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimpleTextMode_Offset), 0, SimpleTextMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimpleTextMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextBlock:bSimpleTextMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimpleTextMode_Offset), 0, SimpleTextMode_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:SetTextTransformPolicy")]
	public unsafe void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
	{
		CheckDestroyed();
		if (!SetTextTransformPolicy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetTextTransformPolicy");
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
	[UMetaPath("/Script/UMG.TextBlock:SetTextOverflowPolicy")]
	public unsafe void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy)
	{
		CheckDestroyed();
		if (!SetTextOverflowPolicy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetTextOverflowPolicy");
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

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.TextBlock:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetText");
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
	[UMetaPath("/Script/UMG.TextBlock:SetStrikeBrush")]
	public unsafe void SetStrikeBrush(FSlateBrush InStrikeBrush)
	{
		CheckDestroyed();
		if (!SetStrikeBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetStrikeBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStrikeBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStrikeBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStrikeBrush_InStrikeBrush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, SetStrikeBrush_InStrikeBrush_Offset), 0, SetStrikeBrush_InStrikeBrush_PropertyAddress.Address, InStrikeBrush);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStrikeBrush_FunctionAddress, intPtr, SetStrikeBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStrikeBrush_InStrikeBrush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.TextBlock:SetShadowOffset")]
	public unsafe void SetShadowOffset(FVector2D InShadowOffset)
	{
		CheckDestroyed();
		if (!SetShadowOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetShadowOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetShadowOffset_InShadowOffset_Offset), 0, SetShadowOffset_InShadowOffset_PropertyAddress.Address, InShadowOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowOffset_FunctionAddress, intPtr, SetShadowOffset_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.TextBlock:SetShadowColorAndOpacity")]
	public unsafe void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetShadowColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetShadowColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetShadowColorAndOpacity_InShadowColorAndOpacity_Offset), 0, SetShadowColorAndOpacity_InShadowColorAndOpacity_PropertyAddress.Address, InShadowColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowColorAndOpacity_FunctionAddress, intPtr, SetShadowColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:SetOverrideLetterSpacing")]
	public unsafe void SetOverrideLetterSpacing(float InOverrideLetterSpacing)
	{
		CheckDestroyed();
		if (!SetOverrideLetterSpacing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetOverrideLetterSpacing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverrideLetterSpacing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverrideLetterSpacing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOverrideLetterSpacing_InOverrideLetterSpacing_Offset), 0, SetOverrideLetterSpacing_InOverrideLetterSpacing_PropertyAddress.Address, InOverrideLetterSpacing);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOverrideLetterSpacing_FunctionAddress, intPtr, SetOverrideLetterSpacing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:SetOpacity")]
	public unsafe void SetOpacity(float InOpacity)
	{
		CheckDestroyed();
		if (!SetOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetOpacity");
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
	[UMetaPath("/Script/UMG.TextBlock:SetMinDesiredWidth")]
	public unsafe void SetMinDesiredWidth(float InMinDesiredWidth)
	{
		CheckDestroyed();
		if (!SetMinDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetMinDesiredWidth");
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
	[UMetaPath("/Script/UMG.TextBlock:SetGSTextWrapping")]
	public unsafe void SetGSTextWrapping(bool InGSTextWrapping)
	{
		CheckDestroyed();
		if (!SetGSTextWrapping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetGSTextWrapping");
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
	[UMetaPath("/Script/UMG.TextBlock:SetForceCache")]
	public unsafe void SetForceCache(bool InForceCache)
	{
		CheckDestroyed();
		if (!SetForceCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetForceCache");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:SetFont")]
	public unsafe void SetFont(FSlateFontInfo InFontInfo)
	{
		CheckDestroyed();
		if (!SetFont_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetFont");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFont_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFont_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetFont_InFontInfo_PropertyAddress.Address, intPtr);
		FSlateFontInfo.ToNative(IntPtr.Add(intPtr, SetFont_InFontInfo_Offset), 0, SetFont_InFontInfo_PropertyAddress.Address, InFontInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFont_FunctionAddress, intPtr, SetFont_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFont_InFontInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:SetColorAndOpacity")]
	public unsafe void SetColorAndOpacity(FSlateColor InColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, intPtr);
		FSlateColor.ToNative(IntPtr.Add(intPtr, SetColorAndOpacity_InColorAndOpacity_Offset), 0, SetColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorAndOpacity_FunctionAddress, intPtr, SetColorAndOpacity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:SetAutoWrapText")]
	public unsafe void SetAutoWrapText(bool InAutoTextWrap)
	{
		CheckDestroyed();
		if (!SetAutoWrapText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:SetAutoWrapText");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.TextBlock:GetTextOccupiedWidth")]
	public unsafe float GetTextOccupiedWidth(string InTextContent)
	{
		CheckDestroyed();
		if (!GetTextOccupiedWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:GetTextOccupiedWidth");
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
	[UMetaPath("/Script/UMG.TextBlock:GetTextLineCount")]
	public unsafe int GetTextLineCount()
	{
		CheckDestroyed();
		if (!GetTextLineCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:GetTextLineCount");
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
	[UMetaPath("/Script/UMG.TextBlock:GetText")]
	public unsafe string GetText()
	{
		CheckDestroyed();
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:GetText");
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
	[UMetaPath("/Script/UMG.TextBlock:GetDynamicOutlineMaterial")]
	public unsafe UMaterialInstanceDynamic GetDynamicOutlineMaterial()
	{
		CheckDestroyed();
		if (!GetDynamicOutlineMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:GetDynamicOutlineMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDynamicOutlineMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDynamicOutlineMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDynamicOutlineMaterial_FunctionAddress, intPtr, GetDynamicOutlineMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetDynamicOutlineMaterial_ReturnValue_Offset), 0, GetDynamicOutlineMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TextBlock:GetDynamicFontMaterial")]
	public unsafe UMaterialInstanceDynamic GetDynamicFontMaterial()
	{
		CheckDestroyed();
		if (!GetDynamicFontMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextBlock:GetDynamicFontMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDynamicFontMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDynamicFontMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDynamicFontMaterial_FunctionAddress, intPtr, GetDynamicFontMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetDynamicFontMaterial_ReturnValue_Offset), 0, GetDynamicFontMaterial_ReturnValue_PropertyAddress.Address);
	}

	static UTextBlock()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextBlock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextBlock));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.TextBlock");
		ColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorAndOpacity");
		ColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorAndOpacity", Classes.FStructProperty);
		OverrideLetterSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverrideLetterSpacing");
		OverrideLetterSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverrideLetterSpacing", Classes.FFloatProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FStructProperty);
		StrikeBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrikeBrush");
		StrikeBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrikeBrush", Classes.FStructProperty);
		ShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowOffset");
		ShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowOffset", Classes.FStructProperty);
		ShadowColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowColorAndOpacity");
		ShadowColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowColorAndOpacity", Classes.FStructProperty);
		MinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredWidth");
		MinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref WrapWithInvalidationPanel_PropertyAddress, intPtr, "bWrapWithInvalidationPanel");
		WrapWithInvalidationPanel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWrapWithInvalidationPanel");
		WrapWithInvalidationPanel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWrapWithInvalidationPanel", Classes.FBoolProperty);
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
		NativeReflectionCached.GetPropertyRef(ref SimpleTextMode_PropertyAddress, intPtr, "bSimpleTextMode");
		SimpleTextMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimpleTextMode");
		SimpleTextMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimpleTextMode", Classes.FBoolProperty);
		SetTextTransformPolicy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextTransformPolicy");
		SetTextTransformPolicy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextTransformPolicy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextTransformPolicy_InTransformPolicy_PropertyAddress, SetTextTransformPolicy_FunctionAddress, "InTransformPolicy");
		SetTextTransformPolicy_InTransformPolicy_Offset = NativeReflectionCached.GetPropertyOffset(SetTextTransformPolicy_FunctionAddress, "InTransformPolicy");
		SetTextTransformPolicy_InTransformPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextTransformPolicy_FunctionAddress, "InTransformPolicy", Classes.FEnumProperty);
		SetTextTransformPolicy_IsValid = SetTextTransformPolicy_FunctionAddress != IntPtr.Zero && SetTextTransformPolicy_InTransformPolicy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetTextTransformPolicy", SetTextTransformPolicy_IsValid);
		SetTextOverflowPolicy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextOverflowPolicy");
		SetTextOverflowPolicy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextOverflowPolicy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress, SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy");
		SetTextOverflowPolicy_InOverflowPolicy_Offset = NativeReflectionCached.GetPropertyOffset(SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy");
		SetTextOverflowPolicy_InOverflowPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy", Classes.FEnumProperty);
		SetTextOverflowPolicy_IsValid = SetTextOverflowPolicy_FunctionAddress != IntPtr.Zero && SetTextOverflowPolicy_InOverflowPolicy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetTextOverflowPolicy", SetTextOverflowPolicy_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetText", SetText_IsValid);
		SetStrikeBrush_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStrikeBrush");
		SetStrikeBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStrikeBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStrikeBrush_InStrikeBrush_PropertyAddress, SetStrikeBrush_FunctionAddress, "InStrikeBrush");
		SetStrikeBrush_InStrikeBrush_Offset = NativeReflectionCached.GetPropertyOffset(SetStrikeBrush_FunctionAddress, "InStrikeBrush");
		SetStrikeBrush_InStrikeBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStrikeBrush_FunctionAddress, "InStrikeBrush", Classes.FStructProperty);
		SetStrikeBrush_IsValid = SetStrikeBrush_FunctionAddress != IntPtr.Zero && SetStrikeBrush_InStrikeBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetStrikeBrush", SetStrikeBrush_IsValid);
		SetShadowOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowOffset");
		SetShadowOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowOffset_InShadowOffset_PropertyAddress, SetShadowOffset_FunctionAddress, "InShadowOffset");
		SetShadowOffset_InShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowOffset_FunctionAddress, "InShadowOffset");
		SetShadowOffset_InShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowOffset_FunctionAddress, "InShadowOffset", Classes.FStructProperty);
		SetShadowOffset_IsValid = SetShadowOffset_FunctionAddress != IntPtr.Zero && SetShadowOffset_InShadowOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetShadowOffset", SetShadowOffset_IsValid);
		SetShadowColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowColorAndOpacity");
		SetShadowColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowColorAndOpacity_InShadowColorAndOpacity_PropertyAddress, SetShadowColorAndOpacity_FunctionAddress, "InShadowColorAndOpacity");
		SetShadowColorAndOpacity_InShadowColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowColorAndOpacity_FunctionAddress, "InShadowColorAndOpacity");
		SetShadowColorAndOpacity_InShadowColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowColorAndOpacity_FunctionAddress, "InShadowColorAndOpacity", Classes.FStructProperty);
		SetShadowColorAndOpacity_IsValid = SetShadowColorAndOpacity_FunctionAddress != IntPtr.Zero && SetShadowColorAndOpacity_InShadowColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetShadowColorAndOpacity", SetShadowColorAndOpacity_IsValid);
		SetOverrideLetterSpacing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOverrideLetterSpacing");
		SetOverrideLetterSpacing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverrideLetterSpacing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLetterSpacing_InOverrideLetterSpacing_PropertyAddress, SetOverrideLetterSpacing_FunctionAddress, "InOverrideLetterSpacing");
		SetOverrideLetterSpacing_InOverrideLetterSpacing_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLetterSpacing_FunctionAddress, "InOverrideLetterSpacing");
		SetOverrideLetterSpacing_InOverrideLetterSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLetterSpacing_FunctionAddress, "InOverrideLetterSpacing", Classes.FFloatProperty);
		SetOverrideLetterSpacing_IsValid = SetOverrideLetterSpacing_FunctionAddress != IntPtr.Zero && SetOverrideLetterSpacing_InOverrideLetterSpacing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetOverrideLetterSpacing", SetOverrideLetterSpacing_IsValid);
		SetOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOpacity");
		SetOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOpacity_InOpacity_PropertyAddress, SetOpacity_FunctionAddress, "InOpacity");
		SetOpacity_InOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetOpacity_FunctionAddress, "InOpacity");
		SetOpacity_InOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOpacity_FunctionAddress, "InOpacity", Classes.FFloatProperty);
		SetOpacity_IsValid = SetOpacity_FunctionAddress != IntPtr.Zero && SetOpacity_InOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetOpacity", SetOpacity_IsValid);
		SetMinDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinDesiredWidth");
		SetMinDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinDesiredWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress, SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth");
		SetMinDesiredWidth_InMinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth");
		SetMinDesiredWidth_InMinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth", Classes.FFloatProperty);
		SetMinDesiredWidth_IsValid = SetMinDesiredWidth_FunctionAddress != IntPtr.Zero && SetMinDesiredWidth_InMinDesiredWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetMinDesiredWidth", SetMinDesiredWidth_IsValid);
		SetGSTextWrapping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSTextWrapping");
		SetGSTextWrapping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSTextWrapping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSTextWrapping_InGSTextWrapping_PropertyAddress, SetGSTextWrapping_FunctionAddress, "InGSTextWrapping");
		SetGSTextWrapping_InGSTextWrapping_Offset = NativeReflectionCached.GetPropertyOffset(SetGSTextWrapping_FunctionAddress, "InGSTextWrapping");
		SetGSTextWrapping_InGSTextWrapping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSTextWrapping_FunctionAddress, "InGSTextWrapping", Classes.FBoolProperty);
		SetGSTextWrapping_IsValid = SetGSTextWrapping_FunctionAddress != IntPtr.Zero && SetGSTextWrapping_InGSTextWrapping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetGSTextWrapping", SetGSTextWrapping_IsValid);
		SetForceCache_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceCache");
		SetForceCache_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceCache_InForceCache_PropertyAddress, SetForceCache_FunctionAddress, "InForceCache");
		SetForceCache_InForceCache_Offset = NativeReflectionCached.GetPropertyOffset(SetForceCache_FunctionAddress, "InForceCache");
		SetForceCache_InForceCache_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceCache_FunctionAddress, "InForceCache", Classes.FBoolProperty);
		SetForceCache_IsValid = SetForceCache_FunctionAddress != IntPtr.Zero && SetForceCache_InForceCache_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetForceCache", SetForceCache_IsValid);
		SetFont_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFont");
		SetFont_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFont_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFont_InFontInfo_PropertyAddress, SetFont_FunctionAddress, "InFontInfo");
		SetFont_InFontInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetFont_FunctionAddress, "InFontInfo");
		SetFont_InFontInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFont_FunctionAddress, "InFontInfo", Classes.FStructProperty);
		SetFont_IsValid = SetFont_FunctionAddress != IntPtr.Zero && SetFont_InFontInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetFont", SetFont_IsValid);
		SetColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColorAndOpacity");
		SetColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorAndOpacity_InColorAndOpacity_PropertyAddress, SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		SetColorAndOpacity_IsValid = SetColorAndOpacity_FunctionAddress != IntPtr.Zero && SetColorAndOpacity_InColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetColorAndOpacity", SetColorAndOpacity_IsValid);
		SetAutoWrapText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoWrapText");
		SetAutoWrapText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoWrapText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoWrapText_InAutoTextWrap_PropertyAddress, SetAutoWrapText_FunctionAddress, "InAutoTextWrap");
		SetAutoWrapText_InAutoTextWrap_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoWrapText_FunctionAddress, "InAutoTextWrap");
		SetAutoWrapText_InAutoTextWrap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoWrapText_FunctionAddress, "InAutoTextWrap", Classes.FBoolProperty);
		SetAutoWrapText_IsValid = SetAutoWrapText_FunctionAddress != IntPtr.Zero && SetAutoWrapText_InAutoTextWrap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:SetAutoWrapText", SetAutoWrapText_IsValid);
		GetTextOccupiedWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextOccupiedWidth");
		GetTextOccupiedWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextOccupiedWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextOccupiedWidth_InTextContent_PropertyAddress, GetTextOccupiedWidth_FunctionAddress, "InTextContent");
		GetTextOccupiedWidth_InTextContent_Offset = NativeReflectionCached.GetPropertyOffset(GetTextOccupiedWidth_FunctionAddress, "InTextContent");
		GetTextOccupiedWidth_InTextContent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextOccupiedWidth_FunctionAddress, "InTextContent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextOccupiedWidth_ReturnValue_PropertyAddress, GetTextOccupiedWidth_FunctionAddress, "ReturnValue");
		GetTextOccupiedWidth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextOccupiedWidth_FunctionAddress, "ReturnValue");
		GetTextOccupiedWidth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextOccupiedWidth_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTextOccupiedWidth_IsValid = GetTextOccupiedWidth_FunctionAddress != IntPtr.Zero && GetTextOccupiedWidth_InTextContent_IsValid && GetTextOccupiedWidth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:GetTextOccupiedWidth", GetTextOccupiedWidth_IsValid);
		GetTextLineCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextLineCount");
		GetTextLineCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextLineCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextLineCount_ReturnValue_PropertyAddress, GetTextLineCount_FunctionAddress, "ReturnValue");
		GetTextLineCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextLineCount_FunctionAddress, "ReturnValue");
		GetTextLineCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextLineCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTextLineCount_IsValid = GetTextLineCount_FunctionAddress != IntPtr.Zero && GetTextLineCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:GetTextLineCount", GetTextLineCount_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:GetText", GetText_IsValid);
		GetDynamicOutlineMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDynamicOutlineMaterial");
		GetDynamicOutlineMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicOutlineMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicOutlineMaterial_ReturnValue_PropertyAddress, GetDynamicOutlineMaterial_FunctionAddress, "ReturnValue");
		GetDynamicOutlineMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicOutlineMaterial_FunctionAddress, "ReturnValue");
		GetDynamicOutlineMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicOutlineMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicOutlineMaterial_IsValid = GetDynamicOutlineMaterial_FunctionAddress != IntPtr.Zero && GetDynamicOutlineMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:GetDynamicOutlineMaterial", GetDynamicOutlineMaterial_IsValid);
		GetDynamicFontMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDynamicFontMaterial");
		GetDynamicFontMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicFontMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicFontMaterial_ReturnValue_PropertyAddress, GetDynamicFontMaterial_FunctionAddress, "ReturnValue");
		GetDynamicFontMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicFontMaterial_FunctionAddress, "ReturnValue");
		GetDynamicFontMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicFontMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicFontMaterial_IsValid = GetDynamicFontMaterial_FunctionAddress != IntPtr.Zero && GetDynamicFontMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextBlock:GetDynamicFontMaterial", GetDynamicFontMaterial_IsValid);
	}
}
