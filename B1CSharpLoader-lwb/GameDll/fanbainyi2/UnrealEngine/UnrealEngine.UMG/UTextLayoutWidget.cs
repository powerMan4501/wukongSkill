using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)821035169uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.TextLayoutWidget", "UMG", UnrealModuleType.Engine)]
public class UTextLayoutWidget : UWidget
{
	private static bool ShapedTextOptions_IsValid;

	private static int ShapedTextOptions_Offset;

	private static bool Justification_IsValid;

	private static FFieldAddress Justification_PropertyAddress;

	private static int Justification_Offset;

	private static bool WrappingPolicy_IsValid;

	private static FFieldAddress WrappingPolicy_PropertyAddress;

	private static int WrappingPolicy_Offset;

	private static bool AutoWrapText_IsValid;

	private static FFieldAddress AutoWrapText_PropertyAddress;

	private static int AutoWrapText_Offset;

	private static bool WrapTextAt_IsValid;

	private static int WrapTextAt_Offset;

	private static bool Margin_IsValid;

	private static int Margin_Offset;

	private static bool LineHeightPercentage_IsValid;

	private static int LineHeightPercentage_Offset;

	private static bool SetJustification_IsValid;

	private static IntPtr SetJustification_FunctionAddress;

	private static int SetJustification_ParamsSize;

	private static bool SetJustification_InJustification_IsValid;

	private static FFieldAddress SetJustification_InJustification_PropertyAddress;

	private static int SetJustification_InJustification_Offset;

	[UProperty(Flags = (PropFlags)9020462113751061uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:ShapedTextOptions")]
	protected FShapedTextOptions ShapedTextOptions
	{
		get
		{
			CheckDestroyed();
			if (!ShapedTextOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:ShapedTextOptions");
				return default(FShapedTextOptions);
			}
			return FShapedTextOptions.FromNative(IntPtr.Add(base.Address, ShapedTextOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShapedTextOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:ShapedTextOptions");
			}
			else
			{
				FShapedTextOptions.ToNative(IntPtr.Add(base.Address, ShapedTextOptions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:Justification")]
	protected ETextJustify Justification
	{
		get
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:Justification");
				return ETextJustify.Left;
			}
			return EnumMarshaler<ETextJustify>.FromNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:Justification");
			}
			else
			{
				EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272263001178645uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:WrappingPolicy")]
	protected ETextWrappingPolicy WrappingPolicy
	{
		get
		{
			CheckDestroyed();
			if (!WrappingPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:WrappingPolicy");
				return ETextWrappingPolicy.DefaultWrapping;
			}
			return EnumMarshaler<ETextWrappingPolicy>.FromNative(IntPtr.Add(base.Address, WrappingPolicy_Offset), 0, WrappingPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WrappingPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:WrappingPolicy");
			}
			else
			{
				EnumMarshaler<ETextWrappingPolicy>.ToNative(IntPtr.Add(base.Address, WrappingPolicy_Offset), 0, WrappingPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:AutoWrapText")]
	protected bool AutoWrapText
	{
		get
		{
			CheckDestroyed();
			if (!AutoWrapText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:AutoWrapText");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoWrapText_Offset), 0, AutoWrapText_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoWrapText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:AutoWrapText");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoWrapText_Offset), 0, AutoWrapText_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:WrapTextAt")]
	protected float WrapTextAt
	{
		get
		{
			CheckDestroyed();
			if (!WrapTextAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:WrapTextAt");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WrapTextAt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WrapTextAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:WrapTextAt");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WrapTextAt_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9020463187493397uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:Margin")]
	protected FMargin Margin
	{
		get
		{
			CheckDestroyed();
			if (!Margin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:Margin");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Margin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Margin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:Margin");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Margin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272263001178645uL)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:LineHeightPercentage")]
	protected float LineHeightPercentage
	{
		get
		{
			CheckDestroyed();
			if (!LineHeightPercentage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:LineHeightPercentage");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineHeightPercentage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineHeightPercentage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TextLayoutWidget:LineHeightPercentage");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineHeightPercentage_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.TextLayoutWidget:SetJustification")]
	public unsafe void SetJustification(ETextJustify InJustification)
	{
		CheckDestroyed();
		if (!SetJustification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TextLayoutWidget:SetJustification");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetJustification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetJustification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(intPtr, SetJustification_InJustification_Offset), 0, SetJustification_InJustification_PropertyAddress.Address, InJustification);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetJustification_FunctionAddress, intPtr, SetJustification_ParamsSize);
	}

	static UTextLayoutWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextLayoutWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextLayoutWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.TextLayoutWidget");
		ShapedTextOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapedTextOptions");
		ShapedTextOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapedTextOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Justification_PropertyAddress, intPtr, "Justification");
		Justification_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Justification");
		Justification_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Justification", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref WrappingPolicy_PropertyAddress, intPtr, "WrappingPolicy");
		WrappingPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WrappingPolicy");
		WrappingPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WrappingPolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoWrapText_PropertyAddress, intPtr, "AutoWrapText");
		AutoWrapText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoWrapText");
		AutoWrapText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoWrapText", Classes.FBoolProperty);
		WrapTextAt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WrapTextAt");
		WrapTextAt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WrapTextAt", Classes.FFloatProperty);
		Margin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Margin");
		Margin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Margin", Classes.FStructProperty);
		LineHeightPercentage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LineHeightPercentage");
		LineHeightPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LineHeightPercentage", Classes.FFloatProperty);
		SetJustification_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetJustification");
		SetJustification_ParamsSize = NativeReflection.GetFunctionParamsSize(SetJustification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetJustification_InJustification_PropertyAddress, SetJustification_FunctionAddress, "InJustification");
		SetJustification_InJustification_Offset = NativeReflectionCached.GetPropertyOffset(SetJustification_FunctionAddress, "InJustification");
		SetJustification_InJustification_IsValid = NativeReflectionCached.ValidatePropertyClass(SetJustification_FunctionAddress, "InJustification", Classes.FByteProperty);
		SetJustification_IsValid = SetJustification_FunctionAddress != IntPtr.Zero && SetJustification_InJustification_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TextLayoutWidget:SetJustification", SetJustification_IsValid);
	}
}
