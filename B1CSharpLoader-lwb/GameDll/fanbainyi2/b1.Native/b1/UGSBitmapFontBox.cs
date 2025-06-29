using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox", "UnrealExtent", UnrealModuleType.Game)]
public class UGSBitmapFontBox : UWidget
{
	private static bool Brush_IsValid;

	private static int Brush_Offset;

	private static bool Font_IsValid;

	private static int Font_Offset;

	private static bool Text_IsValid;

	private static int Text_Offset;

	private FText Text_TextCached;

	private static bool FontScaleFactor_IsValid;

	private static int FontScaleFactor_Offset;

	private static bool CharSpacing_IsValid;

	private static int CharSpacing_Offset;

	private static bool Justification_IsValid;

	private static FFieldAddress Justification_PropertyAddress;

	private static int Justification_Offset;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_InText_IsValid;

	private static FFieldAddress SetText_InText_PropertyAddress;

	private static int SetText_InText_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:Brush")]
	public FSlateBrush Brush
	{
		get
		{
			CheckDestroyed();
			if (!Brush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Brush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, Brush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Brush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Brush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, Brush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:Font")]
	public UFont Font
	{
		get
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Font");
				return null;
			}
			return UObjectMarshaler<UFont>.FromNative(IntPtr.Add(base.Address, Font_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Font");
			}
			else
			{
				UObjectMarshaler<UFont>.ToNative(IntPtr.Add(base.Address, Font_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:Text")]
	public FText Text
	{
		get
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Text");
				return null;
			}
			if (Text_TextCached == null)
			{
				Text_TextCached = new FText(IntPtr.Add(base.Address, Text_Offset), createReference: false);
			}
			return Text_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Text");
				return;
			}
			if (Text_TextCached == null)
			{
				Text_TextCached = new FText(IntPtr.Add(base.Address, Text_Offset), createReference: false);
			}
			Text_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:FontScaleFactor")]
	public float FontScaleFactor
	{
		get
		{
			CheckDestroyed();
			if (!FontScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:FontScaleFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FontScaleFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FontScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:FontScaleFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FontScaleFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:CharSpacing")]
	public float CharSpacing
	{
		get
		{
			CheckDestroyed();
			if (!CharSpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:CharSpacing");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CharSpacing_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharSpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:CharSpacing");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CharSpacing_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:Justification")]
	public EGSBitmapJustification Justification
	{
		get
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Justification");
				return EGSBitmapJustification.Left;
			}
			return EnumMarshaler<EGSBitmapJustification>.FromNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSBitmapFontBox:Justification");
			}
			else
			{
				EnumMarshaler<EGSBitmapJustification>.ToNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UnrealExtent.GSBitmapFontBox:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSBitmapFontBox:SetText");
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

	static UGSBitmapFontBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSBitmapFontBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSBitmapFontBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.GSBitmapFontBox");
		Brush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Brush");
		Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Brush", Classes.FStructProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FObjectProperty);
		Text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Text", Classes.FTextProperty);
		FontScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FontScaleFactor");
		FontScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FontScaleFactor", Classes.FFloatProperty);
		CharSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CharSpacing");
		CharSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CharSpacing", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Justification_PropertyAddress, intPtr, "Justification");
		Justification_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Justification");
		Justification_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Justification", Classes.FEnumProperty);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSBitmapFontBox:SetText", SetText_IsValid);
	}
}
