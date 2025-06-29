using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptTextBlock", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptTextBlock : UTextBlock
{
	private static bool HighlightText_IsValid;

	private static int HighlightText_Offset;

	private FText HighlightText_TextCached;

	private static bool SetHighlightText_IsValid;

	private static IntPtr SetHighlightText_FunctionAddress;

	private static int SetHighlightText_ParamsSize;

	private static bool SetHighlightText_InHighlightText_IsValid;

	private static FFieldAddress SetHighlightText_InHighlightText_PropertyAddress;

	private static int SetHighlightText_InHighlightText_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTextBlock:HighlightText")]
	public FText HighlightText
	{
		get
		{
			CheckDestroyed();
			if (!HighlightText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTextBlock:HighlightText");
				return null;
			}
			if (HighlightText_TextCached == null)
			{
				HighlightText_TextCached = new FText(IntPtr.Add(base.Address, HighlightText_Offset), createReference: false);
			}
			return HighlightText_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!HighlightText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTextBlock:HighlightText");
				return;
			}
			if (HighlightText_TextCached == null)
			{
				HighlightText_TextCached = new FText(IntPtr.Add(base.Address, HighlightText_Offset), createReference: false);
			}
			HighlightText_TextCached.CopyFrom(value);
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTextBlock:SetHighlightText")]
	public unsafe void SetHighlightText(FText InHighlightText)
	{
		CheckDestroyed();
		if (!SetHighlightText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTextBlock:SetHighlightText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHighlightText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHighlightText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetHighlightText_InHighlightText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetHighlightText_InHighlightText_Offset), 0, SetHighlightText_InHighlightText_PropertyAddress.Address, InHighlightText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHighlightText_FunctionAddress, intPtr, SetHighlightText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetHighlightText_InHighlightText_PropertyAddress.Address, intPtr);
	}

	static UJavascriptTextBlock()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptTextBlock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptTextBlock));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptTextBlock");
		HighlightText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighlightText");
		HighlightText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighlightText", Classes.FTextProperty);
		SetHighlightText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHighlightText");
		SetHighlightText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHighlightText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHighlightText_InHighlightText_PropertyAddress, SetHighlightText_FunctionAddress, "InHighlightText");
		SetHighlightText_InHighlightText_Offset = NativeReflectionCached.GetPropertyOffset(SetHighlightText_FunctionAddress, "InHighlightText");
		SetHighlightText_InHighlightText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHighlightText_FunctionAddress, "InHighlightText", Classes.FTextProperty);
		SetHighlightText_IsValid = SetHighlightText_FunctionAddress != IntPtr.Zero && SetHighlightText_InHighlightText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTextBlock:SetHighlightText", SetHighlightText_IsValid);
	}
}
