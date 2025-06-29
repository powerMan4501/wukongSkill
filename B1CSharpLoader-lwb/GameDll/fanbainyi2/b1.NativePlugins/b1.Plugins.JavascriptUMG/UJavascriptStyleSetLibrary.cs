using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptStyleSetLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetVector_IsValid;

	private static IntPtr GetVector_FunctionAddress;

	private static int GetVector_ParamsSize;

	private static bool GetVector_Handle_IsValid;

	private static FFieldAddress GetVector_Handle_PropertyAddress;

	private static int GetVector_Handle_Offset;

	private static bool GetVector_StyleName_IsValid;

	private static FFieldAddress GetVector_StyleName_PropertyAddress;

	private static int GetVector_StyleName_Offset;

	private static bool GetVector_ReturnValue_IsValid;

	private static FFieldAddress GetVector_ReturnValue_PropertyAddress;

	private static int GetVector_ReturnValue_Offset;

	private static bool GetTextBlockStyle_IsValid;

	private static IntPtr GetTextBlockStyle_FunctionAddress;

	private static int GetTextBlockStyle_ParamsSize;

	private static bool GetTextBlockStyle_Handle_IsValid;

	private static FFieldAddress GetTextBlockStyle_Handle_PropertyAddress;

	private static int GetTextBlockStyle_Handle_Offset;

	private static bool GetTextBlockStyle_StyleName_IsValid;

	private static FFieldAddress GetTextBlockStyle_StyleName_PropertyAddress;

	private static int GetTextBlockStyle_StyleName_Offset;

	private static bool GetTextBlockStyle_ReturnValue_IsValid;

	private static FFieldAddress GetTextBlockStyle_ReturnValue_PropertyAddress;

	private static int GetTextBlockStyle_ReturnValue_Offset;

	private static bool GetSound_IsValid;

	private static IntPtr GetSound_FunctionAddress;

	private static int GetSound_ParamsSize;

	private static bool GetSound_Handle_IsValid;

	private static FFieldAddress GetSound_Handle_PropertyAddress;

	private static int GetSound_Handle_Offset;

	private static bool GetSound_StyleName_IsValid;

	private static FFieldAddress GetSound_StyleName_PropertyAddress;

	private static int GetSound_StyleName_Offset;

	private static bool GetSound_ReturnValue_IsValid;

	private static FFieldAddress GetSound_ReturnValue_PropertyAddress;

	private static int GetSound_ReturnValue_Offset;

	private static bool GetSlateColor_IsValid;

	private static IntPtr GetSlateColor_FunctionAddress;

	private static int GetSlateColor_ParamsSize;

	private static bool GetSlateColor_Handle_IsValid;

	private static FFieldAddress GetSlateColor_Handle_PropertyAddress;

	private static int GetSlateColor_Handle_Offset;

	private static bool GetSlateColor_StyleName_IsValid;

	private static FFieldAddress GetSlateColor_StyleName_PropertyAddress;

	private static int GetSlateColor_StyleName_Offset;

	private static bool GetSlateColor_ReturnValue_IsValid;

	private static FFieldAddress GetSlateColor_ReturnValue_PropertyAddress;

	private static int GetSlateColor_ReturnValue_Offset;

	private static bool GetProgressBarStyle_IsValid;

	private static IntPtr GetProgressBarStyle_FunctionAddress;

	private static int GetProgressBarStyle_ParamsSize;

	private static bool GetProgressBarStyle_Handle_IsValid;

	private static FFieldAddress GetProgressBarStyle_Handle_PropertyAddress;

	private static int GetProgressBarStyle_Handle_Offset;

	private static bool GetProgressBarStyle_StyleName_IsValid;

	private static FFieldAddress GetProgressBarStyle_StyleName_PropertyAddress;

	private static int GetProgressBarStyle_StyleName_Offset;

	private static bool GetProgressBarStyle_ReturnValue_IsValid;

	private static FFieldAddress GetProgressBarStyle_ReturnValue_PropertyAddress;

	private static int GetProgressBarStyle_ReturnValue_Offset;

	private static bool GetMargin_IsValid;

	private static IntPtr GetMargin_FunctionAddress;

	private static int GetMargin_ParamsSize;

	private static bool GetMargin_Handle_IsValid;

	private static FFieldAddress GetMargin_Handle_PropertyAddress;

	private static int GetMargin_Handle_Offset;

	private static bool GetMargin_StyleName_IsValid;

	private static FFieldAddress GetMargin_StyleName_PropertyAddress;

	private static int GetMargin_StyleName_Offset;

	private static bool GetMargin_ReturnValue_IsValid;

	private static FFieldAddress GetMargin_ReturnValue_PropertyAddress;

	private static int GetMargin_ReturnValue_Offset;

	private static bool GetFontStyle_IsValid;

	private static IntPtr GetFontStyle_FunctionAddress;

	private static int GetFontStyle_ParamsSize;

	private static bool GetFontStyle_Handle_IsValid;

	private static FFieldAddress GetFontStyle_Handle_PropertyAddress;

	private static int GetFontStyle_Handle_Offset;

	private static bool GetFontStyle_StyleName_IsValid;

	private static FFieldAddress GetFontStyle_StyleName_PropertyAddress;

	private static int GetFontStyle_StyleName_Offset;

	private static bool GetFontStyle_ReturnValue_IsValid;

	private static FFieldAddress GetFontStyle_ReturnValue_PropertyAddress;

	private static int GetFontStyle_ReturnValue_Offset;

	private static bool GetFloat_IsValid;

	private static IntPtr GetFloat_FunctionAddress;

	private static int GetFloat_ParamsSize;

	private static bool GetFloat_Handle_IsValid;

	private static FFieldAddress GetFloat_Handle_PropertyAddress;

	private static int GetFloat_Handle_Offset;

	private static bool GetFloat_StyleName_IsValid;

	private static FFieldAddress GetFloat_StyleName_PropertyAddress;

	private static int GetFloat_StyleName_Offset;

	private static bool GetFloat_ReturnValue_IsValid;

	private static FFieldAddress GetFloat_ReturnValue_PropertyAddress;

	private static int GetFloat_ReturnValue_Offset;

	private static bool GetEditableTextStyle_IsValid;

	private static IntPtr GetEditableTextStyle_FunctionAddress;

	private static int GetEditableTextStyle_ParamsSize;

	private static bool GetEditableTextStyle_Handle_IsValid;

	private static FFieldAddress GetEditableTextStyle_Handle_PropertyAddress;

	private static int GetEditableTextStyle_Handle_Offset;

	private static bool GetEditableTextStyle_StyleName_IsValid;

	private static FFieldAddress GetEditableTextStyle_StyleName_PropertyAddress;

	private static int GetEditableTextStyle_StyleName_Offset;

	private static bool GetEditableTextStyle_ReturnValue_IsValid;

	private static FFieldAddress GetEditableTextStyle_ReturnValue_PropertyAddress;

	private static int GetEditableTextStyle_ReturnValue_Offset;

	private static bool GetEditableTextBoxStyle_IsValid;

	private static IntPtr GetEditableTextBoxStyle_FunctionAddress;

	private static int GetEditableTextBoxStyle_ParamsSize;

	private static bool GetEditableTextBoxStyle_Handle_IsValid;

	private static FFieldAddress GetEditableTextBoxStyle_Handle_PropertyAddress;

	private static int GetEditableTextBoxStyle_Handle_Offset;

	private static bool GetEditableTextBoxStyle_StyleName_IsValid;

	private static FFieldAddress GetEditableTextBoxStyle_StyleName_PropertyAddress;

	private static int GetEditableTextBoxStyle_StyleName_Offset;

	private static bool GetEditableTextBoxStyle_ReturnValue_IsValid;

	private static FFieldAddress GetEditableTextBoxStyle_ReturnValue_PropertyAddress;

	private static int GetEditableTextBoxStyle_ReturnValue_Offset;

	private static bool GetComboButtonStyle_IsValid;

	private static IntPtr GetComboButtonStyle_FunctionAddress;

	private static int GetComboButtonStyle_ParamsSize;

	private static bool GetComboButtonStyle_Handle_IsValid;

	private static FFieldAddress GetComboButtonStyle_Handle_PropertyAddress;

	private static int GetComboButtonStyle_Handle_Offset;

	private static bool GetComboButtonStyle_StyleName_IsValid;

	private static FFieldAddress GetComboButtonStyle_StyleName_PropertyAddress;

	private static int GetComboButtonStyle_StyleName_Offset;

	private static bool GetComboButtonStyle_ReturnValue_IsValid;

	private static FFieldAddress GetComboButtonStyle_ReturnValue_PropertyAddress;

	private static int GetComboButtonStyle_ReturnValue_Offset;

	private static bool GetComboBoxStyle_IsValid;

	private static IntPtr GetComboBoxStyle_FunctionAddress;

	private static int GetComboBoxStyle_ParamsSize;

	private static bool GetComboBoxStyle_Handle_IsValid;

	private static FFieldAddress GetComboBoxStyle_Handle_PropertyAddress;

	private static int GetComboBoxStyle_Handle_Offset;

	private static bool GetComboBoxStyle_StyleName_IsValid;

	private static FFieldAddress GetComboBoxStyle_StyleName_PropertyAddress;

	private static int GetComboBoxStyle_StyleName_Offset;

	private static bool GetComboBoxStyle_ReturnValue_IsValid;

	private static FFieldAddress GetComboBoxStyle_ReturnValue_PropertyAddress;

	private static int GetComboBoxStyle_ReturnValue_Offset;

	private static bool GetColor_IsValid;

	private static IntPtr GetColor_FunctionAddress;

	private static int GetColor_ParamsSize;

	private static bool GetColor_Handle_IsValid;

	private static FFieldAddress GetColor_Handle_PropertyAddress;

	private static int GetColor_Handle_Offset;

	private static bool GetColor_StyleName_IsValid;

	private static FFieldAddress GetColor_StyleName_PropertyAddress;

	private static int GetColor_StyleName_Offset;

	private static bool GetColor_ReturnValue_IsValid;

	private static FFieldAddress GetColor_ReturnValue_PropertyAddress;

	private static int GetColor_ReturnValue_Offset;

	private static bool GetCheckBoxStyle_IsValid;

	private static IntPtr GetCheckBoxStyle_FunctionAddress;

	private static int GetCheckBoxStyle_ParamsSize;

	private static bool GetCheckBoxStyle_Handle_IsValid;

	private static FFieldAddress GetCheckBoxStyle_Handle_PropertyAddress;

	private static int GetCheckBoxStyle_Handle_Offset;

	private static bool GetCheckBoxStyle_StyleName_IsValid;

	private static FFieldAddress GetCheckBoxStyle_StyleName_PropertyAddress;

	private static int GetCheckBoxStyle_StyleName_Offset;

	private static bool GetCheckBoxStyle_ReturnValue_IsValid;

	private static FFieldAddress GetCheckBoxStyle_ReturnValue_PropertyAddress;

	private static int GetCheckBoxStyle_ReturnValue_Offset;

	private static bool GetButtonStyle_IsValid;

	private static IntPtr GetButtonStyle_FunctionAddress;

	private static int GetButtonStyle_ParamsSize;

	private static bool GetButtonStyle_Handle_IsValid;

	private static FFieldAddress GetButtonStyle_Handle_PropertyAddress;

	private static int GetButtonStyle_Handle_Offset;

	private static bool GetButtonStyle_StyleName_IsValid;

	private static FFieldAddress GetButtonStyle_StyleName_PropertyAddress;

	private static int GetButtonStyle_StyleName_Offset;

	private static bool GetButtonStyle_ReturnValue_IsValid;

	private static FFieldAddress GetButtonStyle_ReturnValue_PropertyAddress;

	private static int GetButtonStyle_ReturnValue_Offset;

	private static bool GetBrush_IsValid;

	private static IntPtr GetBrush_FunctionAddress;

	private static int GetBrush_ParamsSize;

	private static bool GetBrush_Handle_IsValid;

	private static FFieldAddress GetBrush_Handle_PropertyAddress;

	private static int GetBrush_Handle_Offset;

	private static bool GetBrush_StyleName_IsValid;

	private static FFieldAddress GetBrush_StyleName_PropertyAddress;

	private static int GetBrush_StyleName_Offset;

	private static bool GetBrush_ReturnValue_IsValid;

	private static FFieldAddress GetBrush_ReturnValue_PropertyAddress;

	private static int GetBrush_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetVector")]
	public unsafe static FVector2D GetVector(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetVector");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVector_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetVector_Handle_Offset), 0, GetVector_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVector_StyleName_Offset), 0, GetVector_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector_FunctionAddress, intPtr, GetVector_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVector_ReturnValue_Offset), 0, GetVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetTextBlockStyle")]
	public unsafe static FTextBlockStyle GetTextBlockStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetTextBlockStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetTextBlockStyle");
			return default(FTextBlockStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextBlockStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextBlockStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTextBlockStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetTextBlockStyle_Handle_Offset), 0, GetTextBlockStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTextBlockStyle_StyleName_Offset), 0, GetTextBlockStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTextBlockStyle_FunctionAddress, intPtr, GetTextBlockStyle_ParamsSize);
		FTextBlockStyle result = FTextBlockStyle.FromNative(IntPtr.Add(intPtr, GetTextBlockStyle_ReturnValue_Offset), 0, GetTextBlockStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTextBlockStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetSound")]
	public unsafe static FSlateSound GetSound(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetSound");
			return default(FSlateSound);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSound_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetSound_Handle_Offset), 0, GetSound_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSound_StyleName_Offset), 0, GetSound_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSound_FunctionAddress, intPtr, GetSound_ParamsSize);
		return FSlateSound.FromNative(IntPtr.Add(intPtr, GetSound_ReturnValue_Offset), 0, GetSound_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetSlateColor")]
	public unsafe static FSlateColor GetSlateColor(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetSlateColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetSlateColor");
			return default(FSlateColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSlateColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSlateColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSlateColor_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetSlateColor_Handle_Offset), 0, GetSlateColor_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSlateColor_StyleName_Offset), 0, GetSlateColor_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSlateColor_FunctionAddress, intPtr, GetSlateColor_ParamsSize);
		FSlateColor result = FSlateColor.FromNative(IntPtr.Add(intPtr, GetSlateColor_ReturnValue_Offset), 0, GetSlateColor_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSlateColor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetProgressBarStyle")]
	public unsafe static FProgressBarStyle GetProgressBarStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetProgressBarStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetProgressBarStyle");
			return default(FProgressBarStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProgressBarStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProgressBarStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetProgressBarStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetProgressBarStyle_Handle_Offset), 0, GetProgressBarStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetProgressBarStyle_StyleName_Offset), 0, GetProgressBarStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProgressBarStyle_FunctionAddress, intPtr, GetProgressBarStyle_ParamsSize);
		FProgressBarStyle result = FProgressBarStyle.FromNative(IntPtr.Add(intPtr, GetProgressBarStyle_ReturnValue_Offset), 0, GetProgressBarStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetProgressBarStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetMargin")]
	public unsafe static FMargin GetMargin(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetMargin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetMargin");
			return default(FMargin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMargin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMargin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMargin_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetMargin_Handle_Offset), 0, GetMargin_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMargin_StyleName_Offset), 0, GetMargin_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMargin_FunctionAddress, intPtr, GetMargin_ParamsSize);
		return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(intPtr, GetMargin_ReturnValue_Offset), 0, GetMargin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetFontStyle")]
	public unsafe static FSlateFontInfo GetFontStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetFontStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetFontStyle");
			return default(FSlateFontInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFontStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFontStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFontStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetFontStyle_Handle_Offset), 0, GetFontStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFontStyle_StyleName_Offset), 0, GetFontStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFontStyle_FunctionAddress, intPtr, GetFontStyle_ParamsSize);
		FSlateFontInfo result = FSlateFontInfo.FromNative(IntPtr.Add(intPtr, GetFontStyle_ReturnValue_Offset), 0, GetFontStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFontStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetFloat")]
	public unsafe static float GetFloat(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFloat_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetFloat_Handle_Offset), 0, GetFloat_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloat_StyleName_Offset), 0, GetFloat_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloat_FunctionAddress, intPtr, GetFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloat_ReturnValue_Offset), 0, GetFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetEditableTextStyle")]
	public unsafe static FEditableTextStyle GetEditableTextStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetEditableTextStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetEditableTextStyle");
			return default(FEditableTextStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditableTextStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditableTextStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEditableTextStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetEditableTextStyle_Handle_Offset), 0, GetEditableTextStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetEditableTextStyle_StyleName_Offset), 0, GetEditableTextStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditableTextStyle_FunctionAddress, intPtr, GetEditableTextStyle_ParamsSize);
		FEditableTextStyle result = FEditableTextStyle.FromNative(IntPtr.Add(intPtr, GetEditableTextStyle_ReturnValue_Offset), 0, GetEditableTextStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetEditableTextStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetEditableTextBoxStyle")]
	public unsafe static FEditableTextBoxStyle GetEditableTextBoxStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetEditableTextBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetEditableTextBoxStyle");
			return default(FEditableTextBoxStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditableTextBoxStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditableTextBoxStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEditableTextBoxStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetEditableTextBoxStyle_Handle_Offset), 0, GetEditableTextBoxStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetEditableTextBoxStyle_StyleName_Offset), 0, GetEditableTextBoxStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditableTextBoxStyle_FunctionAddress, intPtr, GetEditableTextBoxStyle_ParamsSize);
		FEditableTextBoxStyle result = FEditableTextBoxStyle.FromNative(IntPtr.Add(intPtr, GetEditableTextBoxStyle_ReturnValue_Offset), 0, GetEditableTextBoxStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetEditableTextBoxStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetComboButtonStyle")]
	public unsafe static FComboButtonStyle GetComboButtonStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetComboButtonStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetComboButtonStyle");
			return default(FComboButtonStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComboButtonStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComboButtonStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetComboButtonStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetComboButtonStyle_Handle_Offset), 0, GetComboButtonStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetComboButtonStyle_StyleName_Offset), 0, GetComboButtonStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetComboButtonStyle_FunctionAddress, intPtr, GetComboButtonStyle_ParamsSize);
		FComboButtonStyle result = FComboButtonStyle.FromNative(IntPtr.Add(intPtr, GetComboButtonStyle_ReturnValue_Offset), 0, GetComboButtonStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetComboButtonStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetComboBoxStyle")]
	public unsafe static FComboBoxStyle GetComboBoxStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetComboBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetComboBoxStyle");
			return default(FComboBoxStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComboBoxStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComboBoxStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetComboBoxStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetComboBoxStyle_Handle_Offset), 0, GetComboBoxStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetComboBoxStyle_StyleName_Offset), 0, GetComboBoxStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetComboBoxStyle_FunctionAddress, intPtr, GetComboBoxStyle_ParamsSize);
		FComboBoxStyle result = FComboBoxStyle.FromNative(IntPtr.Add(intPtr, GetComboBoxStyle_ReturnValue_Offset), 0, GetComboBoxStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetComboBoxStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetColor")]
	public unsafe static FLinearColor GetColor(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetColor_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetColor_Handle_Offset), 0, GetColor_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetColor_StyleName_Offset), 0, GetColor_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColor_FunctionAddress, intPtr, GetColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetColor_ReturnValue_Offset), 0, GetColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetCheckBoxStyle")]
	public unsafe static FCheckBoxStyle GetCheckBoxStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetCheckBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetCheckBoxStyle");
			return default(FCheckBoxStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCheckBoxStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCheckBoxStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCheckBoxStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetCheckBoxStyle_Handle_Offset), 0, GetCheckBoxStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCheckBoxStyle_StyleName_Offset), 0, GetCheckBoxStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCheckBoxStyle_FunctionAddress, intPtr, GetCheckBoxStyle_ParamsSize);
		FCheckBoxStyle result = FCheckBoxStyle.FromNative(IntPtr.Add(intPtr, GetCheckBoxStyle_ReturnValue_Offset), 0, GetCheckBoxStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCheckBoxStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetButtonStyle")]
	public unsafe static FButtonStyle GetButtonStyle(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetButtonStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetButtonStyle");
			return default(FButtonStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetButtonStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetButtonStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetButtonStyle_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetButtonStyle_Handle_Offset), 0, GetButtonStyle_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetButtonStyle_StyleName_Offset), 0, GetButtonStyle_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetButtonStyle_FunctionAddress, intPtr, GetButtonStyle_ParamsSize);
		FButtonStyle result = FButtonStyle.FromNative(IntPtr.Add(intPtr, GetButtonStyle_ReturnValue_Offset), 0, GetButtonStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetButtonStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetBrush")]
	public unsafe static FSlateBrush GetBrush(FJavascriptStyleSet Handle, FName StyleName)
	{
		if (!GetBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetBrush");
			return default(FSlateBrush);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBrush_Handle_PropertyAddress.Address, intPtr);
		FJavascriptStyleSet.ToNative(IntPtr.Add(intPtr, GetBrush_Handle_Offset), 0, GetBrush_Handle_PropertyAddress.Address, Handle);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBrush_StyleName_Offset), 0, GetBrush_StyleName_PropertyAddress.Address, StyleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBrush_FunctionAddress, intPtr, GetBrush_ParamsSize);
		FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, GetBrush_ReturnValue_Offset), 0, GetBrush_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBrush_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UJavascriptStyleSetLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptStyleSetLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptStyleSetLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptStyleSetLibrary");
		GetVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector");
		GetVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector_Handle_PropertyAddress, GetVector_FunctionAddress, "Handle");
		GetVector_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "Handle");
		GetVector_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector_StyleName_PropertyAddress, GetVector_FunctionAddress, "StyleName");
		GetVector_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "StyleName");
		GetVector_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector_ReturnValue_PropertyAddress, GetVector_FunctionAddress, "ReturnValue");
		GetVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector_FunctionAddress, "ReturnValue");
		GetVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector_IsValid = GetVector_FunctionAddress != IntPtr.Zero && GetVector_Handle_IsValid && GetVector_StyleName_IsValid && GetVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetVector", GetVector_IsValid);
		GetTextBlockStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTextBlockStyle");
		GetTextBlockStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextBlockStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextBlockStyle_Handle_PropertyAddress, GetTextBlockStyle_FunctionAddress, "Handle");
		GetTextBlockStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetTextBlockStyle_FunctionAddress, "Handle");
		GetTextBlockStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextBlockStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextBlockStyle_StyleName_PropertyAddress, GetTextBlockStyle_FunctionAddress, "StyleName");
		GetTextBlockStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetTextBlockStyle_FunctionAddress, "StyleName");
		GetTextBlockStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextBlockStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextBlockStyle_ReturnValue_PropertyAddress, GetTextBlockStyle_FunctionAddress, "ReturnValue");
		GetTextBlockStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextBlockStyle_FunctionAddress, "ReturnValue");
		GetTextBlockStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextBlockStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTextBlockStyle_IsValid = GetTextBlockStyle_FunctionAddress != IntPtr.Zero && GetTextBlockStyle_Handle_IsValid && GetTextBlockStyle_StyleName_IsValid && GetTextBlockStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetTextBlockStyle", GetTextBlockStyle_IsValid);
		GetSound_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSound");
		GetSound_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSound_Handle_PropertyAddress, GetSound_FunctionAddress, "Handle");
		GetSound_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetSound_FunctionAddress, "Handle");
		GetSound_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSound_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSound_StyleName_PropertyAddress, GetSound_FunctionAddress, "StyleName");
		GetSound_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetSound_FunctionAddress, "StyleName");
		GetSound_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSound_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSound_ReturnValue_PropertyAddress, GetSound_FunctionAddress, "ReturnValue");
		GetSound_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSound_FunctionAddress, "ReturnValue");
		GetSound_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSound_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSound_IsValid = GetSound_FunctionAddress != IntPtr.Zero && GetSound_Handle_IsValid && GetSound_StyleName_IsValid && GetSound_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetSound", GetSound_IsValid);
		GetSlateColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSlateColor");
		GetSlateColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSlateColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSlateColor_Handle_PropertyAddress, GetSlateColor_FunctionAddress, "Handle");
		GetSlateColor_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetSlateColor_FunctionAddress, "Handle");
		GetSlateColor_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSlateColor_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSlateColor_StyleName_PropertyAddress, GetSlateColor_FunctionAddress, "StyleName");
		GetSlateColor_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetSlateColor_FunctionAddress, "StyleName");
		GetSlateColor_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSlateColor_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSlateColor_ReturnValue_PropertyAddress, GetSlateColor_FunctionAddress, "ReturnValue");
		GetSlateColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSlateColor_FunctionAddress, "ReturnValue");
		GetSlateColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSlateColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSlateColor_IsValid = GetSlateColor_FunctionAddress != IntPtr.Zero && GetSlateColor_Handle_IsValid && GetSlateColor_StyleName_IsValid && GetSlateColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetSlateColor", GetSlateColor_IsValid);
		GetProgressBarStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProgressBarStyle");
		GetProgressBarStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProgressBarStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProgressBarStyle_Handle_PropertyAddress, GetProgressBarStyle_FunctionAddress, "Handle");
		GetProgressBarStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetProgressBarStyle_FunctionAddress, "Handle");
		GetProgressBarStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProgressBarStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProgressBarStyle_StyleName_PropertyAddress, GetProgressBarStyle_FunctionAddress, "StyleName");
		GetProgressBarStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetProgressBarStyle_FunctionAddress, "StyleName");
		GetProgressBarStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProgressBarStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProgressBarStyle_ReturnValue_PropertyAddress, GetProgressBarStyle_FunctionAddress, "ReturnValue");
		GetProgressBarStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProgressBarStyle_FunctionAddress, "ReturnValue");
		GetProgressBarStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProgressBarStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetProgressBarStyle_IsValid = GetProgressBarStyle_FunctionAddress != IntPtr.Zero && GetProgressBarStyle_Handle_IsValid && GetProgressBarStyle_StyleName_IsValid && GetProgressBarStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetProgressBarStyle", GetProgressBarStyle_IsValid);
		GetMargin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMargin");
		GetMargin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMargin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMargin_Handle_PropertyAddress, GetMargin_FunctionAddress, "Handle");
		GetMargin_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetMargin_FunctionAddress, "Handle");
		GetMargin_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMargin_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMargin_StyleName_PropertyAddress, GetMargin_FunctionAddress, "StyleName");
		GetMargin_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetMargin_FunctionAddress, "StyleName");
		GetMargin_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMargin_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMargin_ReturnValue_PropertyAddress, GetMargin_FunctionAddress, "ReturnValue");
		GetMargin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMargin_FunctionAddress, "ReturnValue");
		GetMargin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMargin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMargin_IsValid = GetMargin_FunctionAddress != IntPtr.Zero && GetMargin_Handle_IsValid && GetMargin_StyleName_IsValid && GetMargin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetMargin", GetMargin_IsValid);
		GetFontStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFontStyle");
		GetFontStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFontStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFontStyle_Handle_PropertyAddress, GetFontStyle_FunctionAddress, "Handle");
		GetFontStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetFontStyle_FunctionAddress, "Handle");
		GetFontStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFontStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFontStyle_StyleName_PropertyAddress, GetFontStyle_FunctionAddress, "StyleName");
		GetFontStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetFontStyle_FunctionAddress, "StyleName");
		GetFontStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFontStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFontStyle_ReturnValue_PropertyAddress, GetFontStyle_FunctionAddress, "ReturnValue");
		GetFontStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFontStyle_FunctionAddress, "ReturnValue");
		GetFontStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFontStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFontStyle_IsValid = GetFontStyle_FunctionAddress != IntPtr.Zero && GetFontStyle_Handle_IsValid && GetFontStyle_StyleName_IsValid && GetFontStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetFontStyle", GetFontStyle_IsValid);
		GetFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloat");
		GetFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_Handle_PropertyAddress, GetFloat_FunctionAddress, "Handle");
		GetFloat_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "Handle");
		GetFloat_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_StyleName_PropertyAddress, GetFloat_FunctionAddress, "StyleName");
		GetFloat_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "StyleName");
		GetFloat_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_ReturnValue_PropertyAddress, GetFloat_FunctionAddress, "ReturnValue");
		GetFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "ReturnValue");
		GetFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloat_IsValid = GetFloat_FunctionAddress != IntPtr.Zero && GetFloat_Handle_IsValid && GetFloat_StyleName_IsValid && GetFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetFloat", GetFloat_IsValid);
		GetEditableTextStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditableTextStyle");
		GetEditableTextStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditableTextStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditableTextStyle_Handle_PropertyAddress, GetEditableTextStyle_FunctionAddress, "Handle");
		GetEditableTextStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetEditableTextStyle_FunctionAddress, "Handle");
		GetEditableTextStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditableTextStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEditableTextStyle_StyleName_PropertyAddress, GetEditableTextStyle_FunctionAddress, "StyleName");
		GetEditableTextStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetEditableTextStyle_FunctionAddress, "StyleName");
		GetEditableTextStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditableTextStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEditableTextStyle_ReturnValue_PropertyAddress, GetEditableTextStyle_FunctionAddress, "ReturnValue");
		GetEditableTextStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditableTextStyle_FunctionAddress, "ReturnValue");
		GetEditableTextStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditableTextStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEditableTextStyle_IsValid = GetEditableTextStyle_FunctionAddress != IntPtr.Zero && GetEditableTextStyle_Handle_IsValid && GetEditableTextStyle_StyleName_IsValid && GetEditableTextStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetEditableTextStyle", GetEditableTextStyle_IsValid);
		GetEditableTextBoxStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditableTextBoxStyle");
		GetEditableTextBoxStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditableTextBoxStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditableTextBoxStyle_Handle_PropertyAddress, GetEditableTextBoxStyle_FunctionAddress, "Handle");
		GetEditableTextBoxStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetEditableTextBoxStyle_FunctionAddress, "Handle");
		GetEditableTextBoxStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditableTextBoxStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEditableTextBoxStyle_StyleName_PropertyAddress, GetEditableTextBoxStyle_FunctionAddress, "StyleName");
		GetEditableTextBoxStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetEditableTextBoxStyle_FunctionAddress, "StyleName");
		GetEditableTextBoxStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditableTextBoxStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEditableTextBoxStyle_ReturnValue_PropertyAddress, GetEditableTextBoxStyle_FunctionAddress, "ReturnValue");
		GetEditableTextBoxStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditableTextBoxStyle_FunctionAddress, "ReturnValue");
		GetEditableTextBoxStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditableTextBoxStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEditableTextBoxStyle_IsValid = GetEditableTextBoxStyle_FunctionAddress != IntPtr.Zero && GetEditableTextBoxStyle_Handle_IsValid && GetEditableTextBoxStyle_StyleName_IsValid && GetEditableTextBoxStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetEditableTextBoxStyle", GetEditableTextBoxStyle_IsValid);
		GetComboButtonStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetComboButtonStyle");
		GetComboButtonStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComboButtonStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComboButtonStyle_Handle_PropertyAddress, GetComboButtonStyle_FunctionAddress, "Handle");
		GetComboButtonStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetComboButtonStyle_FunctionAddress, "Handle");
		GetComboButtonStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComboButtonStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComboButtonStyle_StyleName_PropertyAddress, GetComboButtonStyle_FunctionAddress, "StyleName");
		GetComboButtonStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetComboButtonStyle_FunctionAddress, "StyleName");
		GetComboButtonStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComboButtonStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComboButtonStyle_ReturnValue_PropertyAddress, GetComboButtonStyle_FunctionAddress, "ReturnValue");
		GetComboButtonStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComboButtonStyle_FunctionAddress, "ReturnValue");
		GetComboButtonStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComboButtonStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetComboButtonStyle_IsValid = GetComboButtonStyle_FunctionAddress != IntPtr.Zero && GetComboButtonStyle_Handle_IsValid && GetComboButtonStyle_StyleName_IsValid && GetComboButtonStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetComboButtonStyle", GetComboButtonStyle_IsValid);
		GetComboBoxStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetComboBoxStyle");
		GetComboBoxStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComboBoxStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComboBoxStyle_Handle_PropertyAddress, GetComboBoxStyle_FunctionAddress, "Handle");
		GetComboBoxStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetComboBoxStyle_FunctionAddress, "Handle");
		GetComboBoxStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComboBoxStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComboBoxStyle_StyleName_PropertyAddress, GetComboBoxStyle_FunctionAddress, "StyleName");
		GetComboBoxStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetComboBoxStyle_FunctionAddress, "StyleName");
		GetComboBoxStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComboBoxStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComboBoxStyle_ReturnValue_PropertyAddress, GetComboBoxStyle_FunctionAddress, "ReturnValue");
		GetComboBoxStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComboBoxStyle_FunctionAddress, "ReturnValue");
		GetComboBoxStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComboBoxStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetComboBoxStyle_IsValid = GetComboBoxStyle_FunctionAddress != IntPtr.Zero && GetComboBoxStyle_Handle_IsValid && GetComboBoxStyle_StyleName_IsValid && GetComboBoxStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetComboBoxStyle", GetComboBoxStyle_IsValid);
		GetColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColor");
		GetColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColor_Handle_PropertyAddress, GetColor_FunctionAddress, "Handle");
		GetColor_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "Handle");
		GetColor_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColor_StyleName_PropertyAddress, GetColor_FunctionAddress, "StyleName");
		GetColor_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "StyleName");
		GetColor_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColor_ReturnValue_PropertyAddress, GetColor_FunctionAddress, "ReturnValue");
		GetColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColor_FunctionAddress, "ReturnValue");
		GetColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetColor_IsValid = GetColor_FunctionAddress != IntPtr.Zero && GetColor_Handle_IsValid && GetColor_StyleName_IsValid && GetColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetColor", GetColor_IsValid);
		GetCheckBoxStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCheckBoxStyle");
		GetCheckBoxStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCheckBoxStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCheckBoxStyle_Handle_PropertyAddress, GetCheckBoxStyle_FunctionAddress, "Handle");
		GetCheckBoxStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckBoxStyle_FunctionAddress, "Handle");
		GetCheckBoxStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckBoxStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCheckBoxStyle_StyleName_PropertyAddress, GetCheckBoxStyle_FunctionAddress, "StyleName");
		GetCheckBoxStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckBoxStyle_FunctionAddress, "StyleName");
		GetCheckBoxStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckBoxStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCheckBoxStyle_ReturnValue_PropertyAddress, GetCheckBoxStyle_FunctionAddress, "ReturnValue");
		GetCheckBoxStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckBoxStyle_FunctionAddress, "ReturnValue");
		GetCheckBoxStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckBoxStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCheckBoxStyle_IsValid = GetCheckBoxStyle_FunctionAddress != IntPtr.Zero && GetCheckBoxStyle_Handle_IsValid && GetCheckBoxStyle_StyleName_IsValid && GetCheckBoxStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetCheckBoxStyle", GetCheckBoxStyle_IsValid);
		GetButtonStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetButtonStyle");
		GetButtonStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetButtonStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetButtonStyle_Handle_PropertyAddress, GetButtonStyle_FunctionAddress, "Handle");
		GetButtonStyle_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetButtonStyle_FunctionAddress, "Handle");
		GetButtonStyle_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetButtonStyle_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetButtonStyle_StyleName_PropertyAddress, GetButtonStyle_FunctionAddress, "StyleName");
		GetButtonStyle_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetButtonStyle_FunctionAddress, "StyleName");
		GetButtonStyle_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetButtonStyle_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetButtonStyle_ReturnValue_PropertyAddress, GetButtonStyle_FunctionAddress, "ReturnValue");
		GetButtonStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetButtonStyle_FunctionAddress, "ReturnValue");
		GetButtonStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetButtonStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetButtonStyle_IsValid = GetButtonStyle_FunctionAddress != IntPtr.Zero && GetButtonStyle_Handle_IsValid && GetButtonStyle_StyleName_IsValid && GetButtonStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetButtonStyle", GetButtonStyle_IsValid);
		GetBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBrush");
		GetBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBrush_Handle_PropertyAddress, GetBrush_FunctionAddress, "Handle");
		GetBrush_Handle_Offset = NativeReflectionCached.GetPropertyOffset(GetBrush_FunctionAddress, "Handle");
		GetBrush_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrush_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBrush_StyleName_PropertyAddress, GetBrush_FunctionAddress, "StyleName");
		GetBrush_StyleName_Offset = NativeReflectionCached.GetPropertyOffset(GetBrush_FunctionAddress, "StyleName");
		GetBrush_StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrush_FunctionAddress, "StyleName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBrush_ReturnValue_PropertyAddress, GetBrush_FunctionAddress, "ReturnValue");
		GetBrush_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBrush_FunctionAddress, "ReturnValue");
		GetBrush_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrush_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBrush_IsValid = GetBrush_FunctionAddress != IntPtr.Zero && GetBrush_Handle_IsValid && GetBrush_StyleName_IsValid && GetBrush_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptStyleSetLibrary:GetBrush", GetBrush_IsValid);
	}
}
