using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSOfflineFontBox", "UnrealExtent", UnrealModuleType.Game)]
public class UGSOfflineFontBox : UWidget
{
	private static bool BrushArray_IsValid;

	private static FFieldAddress BrushArray_PropertyAddress;

	private static int BrushArray_Offset;

	private TArrayReadOnlyMarshaler<FSlateBrush> BrushArray_MarshalerCached;

	private static bool Font_IsValid;

	private static int Font_Offset;

	private static bool Text_IsValid;

	private static int Text_Offset;

	private FText Text_TextCached;

	private static bool FontScaleFactor_IsValid;

	private static int FontScaleFactor_Offset;

	private static bool UVPadding_IsValid;

	private static int UVPadding_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/UnrealExtent.GSOfflineFontBox:BrushArray")]
	public TArrayReadOnly<FSlateBrush> BrushArray
	{
		get
		{
			CheckDestroyed();
			if (!BrushArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:BrushArray");
				return null;
			}
			if (BrushArray_MarshalerCached == null)
			{
				BrushArray_MarshalerCached = new TArrayReadOnlyMarshaler<FSlateBrush>(1, BrushArray_PropertyAddress, CachedMarshalingDelegates<FSlateBrush, FSlateBrush>.FromNative, CachedMarshalingDelegates<FSlateBrush, FSlateBrush>.ToNative);
			}
			return BrushArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, BrushArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSOfflineFontBox:Font")]
	public UFont Font
	{
		get
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:Font");
				return null;
			}
			return UObjectMarshaler<UFont>.FromNative(IntPtr.Add(base.Address, Font_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:Font");
			}
			else
			{
				UObjectMarshaler<UFont>.ToNative(IntPtr.Add(base.Address, Font_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UnrealExtent.GSOfflineFontBox:Text")]
	public FText Text
	{
		get
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:Text");
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
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:Text");
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
	[UMetaPath("/Script/UnrealExtent.GSOfflineFontBox:FontScaleFactor")]
	public FIntPoint FontScaleFactor
	{
		get
		{
			CheckDestroyed();
			if (!FontScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:FontScaleFactor");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, FontScaleFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FontScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:FontScaleFactor");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, FontScaleFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSOfflineFontBox:UVPadding")]
	public FIntPoint UVPadding
	{
		get
		{
			CheckDestroyed();
			if (!UVPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:UVPadding");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, UVPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UVPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSOfflineFontBox:UVPadding");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, UVPadding_Offset), value);
			}
		}
	}

	static UGSOfflineFontBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSOfflineFontBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSOfflineFontBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSOfflineFontBox");
		NativeReflectionCached.GetPropertyRef(ref BrushArray_PropertyAddress, unrealStruct, "BrushArray");
		BrushArray_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BrushArray");
		BrushArray_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BrushArray", Classes.FArrayProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Font", Classes.FObjectProperty);
		Text_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Text", Classes.FTextProperty);
		FontScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FontScaleFactor");
		FontScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FontScaleFactor", Classes.FStructProperty);
		UVPadding_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UVPadding");
		UVPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UVPadding", Classes.FStructProperty);
	}
}
