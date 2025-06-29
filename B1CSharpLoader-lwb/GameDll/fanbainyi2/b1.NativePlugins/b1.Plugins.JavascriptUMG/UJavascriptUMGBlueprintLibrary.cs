using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptUMGBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SlateColor_UseSubduedForeground_IsValid;

	private static IntPtr SlateColor_UseSubduedForeground_FunctionAddress;

	private static int SlateColor_UseSubduedForeground_ParamsSize;

	private static bool SlateColor_UseSubduedForeground_ReturnValue_IsValid;

	private static FFieldAddress SlateColor_UseSubduedForeground_ReturnValue_PropertyAddress;

	private static int SlateColor_UseSubduedForeground_ReturnValue_Offset;

	private static bool SlateColor_UseForeground_IsValid;

	private static IntPtr SlateColor_UseForeground_FunctionAddress;

	private static int SlateColor_UseForeground_ParamsSize;

	private static bool SlateColor_UseForeground_ReturnValue_IsValid;

	private static FFieldAddress SlateColor_UseForeground_ReturnValue_PropertyAddress;

	private static int SlateColor_UseForeground_ReturnValue_Offset;

	private static bool GetLineLength_IsValid;

	private static IntPtr GetLineLength_FunctionAddress;

	private static int GetLineLength_ParamsSize;

	private static bool GetLineLength_TargetTextLayout_IsValid;

	private static FFieldAddress GetLineLength_TargetTextLayout_PropertyAddress;

	private static int GetLineLength_TargetTextLayout_Offset;

	private static bool GetLineLength_ReturnValue_IsValid;

	private static FFieldAddress GetLineLength_ReturnValue_PropertyAddress;

	private static int GetLineLength_ReturnValue_Offset;

	private static bool GetAsText_IsValid;

	private static IntPtr GetAsText_FunctionAddress;

	private static int GetAsText_ParamsSize;

	private static bool GetAsText_TextLayout_IsValid;

	private static FFieldAddress GetAsText_TextLayout_PropertyAddress;

	private static int GetAsText_TextLayout_Offset;

	private static bool GetAsText_ReturnValue_IsValid;

	private static FFieldAddress GetAsText_ReturnValue_PropertyAddress;

	private static int GetAsText_ReturnValue_Offset;

	private static bool DrawSpaceSpline_IsValid;

	private static IntPtr DrawSpaceSpline_FunctionAddress;

	private static int DrawSpaceSpline_ParamsSize;

	private static bool DrawSpaceSpline_Context_IsValid;

	private static FFieldAddress DrawSpaceSpline_Context_PropertyAddress;

	private static int DrawSpaceSpline_Context_Offset;

	private static bool DrawSpaceSpline_InStart_IsValid;

	private static FFieldAddress DrawSpaceSpline_InStart_PropertyAddress;

	private static int DrawSpaceSpline_InStart_Offset;

	private static bool DrawSpaceSpline_InStartDir_IsValid;

	private static FFieldAddress DrawSpaceSpline_InStartDir_PropertyAddress;

	private static int DrawSpaceSpline_InStartDir_Offset;

	private static bool DrawSpaceSpline_InEnd_IsValid;

	private static FFieldAddress DrawSpaceSpline_InEnd_PropertyAddress;

	private static int DrawSpaceSpline_InEnd_Offset;

	private static bool DrawSpaceSpline_InEndDir_IsValid;

	private static FFieldAddress DrawSpaceSpline_InEndDir_PropertyAddress;

	private static int DrawSpaceSpline_InEndDir_Offset;

	private static bool DrawSpaceSpline_InThickness_IsValid;

	private static FFieldAddress DrawSpaceSpline_InThickness_PropertyAddress;

	private static int DrawSpaceSpline_InThickness_Offset;

	private static bool DrawSpaceSpline_InTint_IsValid;

	private static FFieldAddress DrawSpaceSpline_InTint_PropertyAddress;

	private static int DrawSpaceSpline_InTint_Offset;

	private static bool ClearLines_IsValid;

	private static IntPtr ClearLines_FunctionAddress;

	private static int ClearLines_ParamsSize;

	private static bool ClearLines_TextLayout_IsValid;

	private static FFieldAddress ClearLines_TextLayout_PropertyAddress;

	private static int ClearLines_TextLayout_Offset;

	private static bool AddLine_IsValid;

	private static IntPtr AddLine_FunctionAddress;

	private static int AddLine_ParamsSize;

	private static bool AddLine_TextLayout_IsValid;

	private static FFieldAddress AddLine_TextLayout_PropertyAddress;

	private static int AddLine_TextLayout_Offset;

	private static bool AddLine_Model_IsValid;

	private static FFieldAddress AddLine_Model_PropertyAddress;

	private static int AddLine_Model_Offset;

	private static bool AddLine_Runs_IsValid;

	private static FFieldAddress AddLine_Runs_PropertyAddress;

	private static int AddLine_Runs_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:SlateColor_UseSubduedForeground")]
	public unsafe static FSlateColor SlateColor_UseSubduedForeground()
	{
		if (!SlateColor_UseSubduedForeground_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:SlateColor_UseSubduedForeground");
			return default(FSlateColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlateColor_UseSubduedForeground_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlateColor_UseSubduedForeground_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlateColor_UseSubduedForeground_FunctionAddress, intPtr, SlateColor_UseSubduedForeground_ParamsSize);
		FSlateColor result = FSlateColor.FromNative(IntPtr.Add(intPtr, SlateColor_UseSubduedForeground_ReturnValue_Offset), 0, SlateColor_UseSubduedForeground_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SlateColor_UseSubduedForeground_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:SlateColor_UseForeground")]
	public unsafe static FSlateColor SlateColor_UseForeground()
	{
		if (!SlateColor_UseForeground_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:SlateColor_UseForeground");
			return default(FSlateColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlateColor_UseForeground_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlateColor_UseForeground_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlateColor_UseForeground_FunctionAddress, intPtr, SlateColor_UseForeground_ParamsSize);
		FSlateColor result = FSlateColor.FromNative(IntPtr.Add(intPtr, SlateColor_UseForeground_ReturnValue_Offset), 0, SlateColor_UseForeground_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SlateColor_UseForeground_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:GetLineLength")]
	public unsafe static int GetLineLength(FJavascriptTextLayout TargetTextLayout)
	{
		if (!GetLineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:GetLineLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLineLength_TargetTextLayout_PropertyAddress.Address, intPtr);
		FJavascriptTextLayout.ToNative(IntPtr.Add(intPtr, GetLineLength_TargetTextLayout_Offset), 0, GetLineLength_TargetTextLayout_PropertyAddress.Address, TargetTextLayout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLineLength_FunctionAddress, intPtr, GetLineLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLineLength_TargetTextLayout_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLineLength_ReturnValue_Offset), 0, GetLineLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:GetAsText")]
	public unsafe static string GetAsText(FJavascriptTextLayout TextLayout)
	{
		if (!GetAsText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:GetAsText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAsText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAsText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAsText_TextLayout_PropertyAddress.Address, intPtr);
		FJavascriptTextLayout.ToNative(IntPtr.Add(intPtr, GetAsText_TextLayout_Offset), 0, GetAsText_TextLayout_PropertyAddress.Address, TextLayout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAsText_FunctionAddress, intPtr, GetAsText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAsText_TextLayout_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAsText_ReturnValue_Offset), 0, GetAsText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAsText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:DrawSpaceSpline")]
	public unsafe static void DrawSpaceSpline(ref FPaintContext Context, FVector2D InStart, FVector2D InStartDir, FVector2D InEnd, FVector2D InEndDir, float InThickness, FLinearColor InTint)
	{
		if (!DrawSpaceSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:DrawSpaceSpline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawSpaceSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawSpaceSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawSpaceSpline_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_Context_Offset), 0, DrawSpaceSpline_Context_PropertyAddress.Address, Context);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_InStart_Offset), 0, DrawSpaceSpline_InStart_PropertyAddress.Address, InStart);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_InStartDir_Offset), 0, DrawSpaceSpline_InStartDir_PropertyAddress.Address, InStartDir);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_InEnd_Offset), 0, DrawSpaceSpline_InEnd_PropertyAddress.Address, InEnd);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_InEndDir_Offset), 0, DrawSpaceSpline_InEndDir_PropertyAddress.Address, InEndDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_InThickness_Offset), 0, DrawSpaceSpline_InThickness_PropertyAddress.Address, InThickness);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawSpaceSpline_InTint_Offset), 0, DrawSpaceSpline_InTint_PropertyAddress.Address, InTint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawSpaceSpline_FunctionAddress, intPtr, DrawSpaceSpline_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, DrawSpaceSpline_Context_Offset), 0, DrawSpaceSpline_Context_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:ClearLines")]
	public unsafe static void ClearLines(ref FJavascriptTextLayout TextLayout)
	{
		if (!ClearLines_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:ClearLines");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearLines_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearLines_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearLines_TextLayout_PropertyAddress.Address, intPtr);
		FJavascriptTextLayout.ToNative(IntPtr.Add(intPtr, ClearLines_TextLayout_Offset), 0, ClearLines_TextLayout_PropertyAddress.Address, TextLayout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearLines_FunctionAddress, intPtr, ClearLines_ParamsSize);
		TextLayout = FJavascriptTextLayout.FromNative(IntPtr.Add(intPtr, ClearLines_TextLayout_Offset), 0, ClearLines_TextLayout_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearLines_TextLayout_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:AddLine")]
	public unsafe static void AddLine(ref FJavascriptTextLayout TextLayout, UJavascriptTextModel Model, List<FJavascriptSlateTextRun> Runs)
	{
		if (!AddLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:AddLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddLine_TextLayout_PropertyAddress.Address, intPtr);
		FJavascriptTextLayout.ToNative(IntPtr.Add(intPtr, AddLine_TextLayout_Offset), 0, AddLine_TextLayout_PropertyAddress.Address, TextLayout);
		UObjectMarshaler<UJavascriptTextModel>.ToNative(IntPtr.Add(intPtr, AddLine_Model_Offset), 0, AddLine_Model_PropertyAddress.Address, Model);
		new TArrayCopyMarshaler<FJavascriptSlateTextRun>(1, AddLine_Runs_PropertyAddress, CachedMarshalingDelegates<FJavascriptSlateTextRun, FJavascriptSlateTextRun>.FromNative, CachedMarshalingDelegates<FJavascriptSlateTextRun, FJavascriptSlateTextRun>.ToNative).ToNative(IntPtr.Add(intPtr, AddLine_Runs_Offset), Runs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddLine_FunctionAddress, intPtr, AddLine_ParamsSize);
		TextLayout = FJavascriptTextLayout.FromNative(IntPtr.Add(intPtr, AddLine_TextLayout_Offset), 0, AddLine_TextLayout_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddLine_TextLayout_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddLine_Runs_PropertyAddress.Address, intPtr);
	}

	static UJavascriptUMGBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptUMGBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptUMGBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary");
		SlateColor_UseSubduedForeground_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlateColor_UseSubduedForeground");
		SlateColor_UseSubduedForeground_ParamsSize = NativeReflection.GetFunctionParamsSize(SlateColor_UseSubduedForeground_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlateColor_UseSubduedForeground_ReturnValue_PropertyAddress, SlateColor_UseSubduedForeground_FunctionAddress, "ReturnValue");
		SlateColor_UseSubduedForeground_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlateColor_UseSubduedForeground_FunctionAddress, "ReturnValue");
		SlateColor_UseSubduedForeground_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateColor_UseSubduedForeground_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SlateColor_UseSubduedForeground_IsValid = SlateColor_UseSubduedForeground_FunctionAddress != IntPtr.Zero && SlateColor_UseSubduedForeground_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:SlateColor_UseSubduedForeground", SlateColor_UseSubduedForeground_IsValid);
		SlateColor_UseForeground_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlateColor_UseForeground");
		SlateColor_UseForeground_ParamsSize = NativeReflection.GetFunctionParamsSize(SlateColor_UseForeground_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlateColor_UseForeground_ReturnValue_PropertyAddress, SlateColor_UseForeground_FunctionAddress, "ReturnValue");
		SlateColor_UseForeground_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlateColor_UseForeground_FunctionAddress, "ReturnValue");
		SlateColor_UseForeground_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateColor_UseForeground_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SlateColor_UseForeground_IsValid = SlateColor_UseForeground_FunctionAddress != IntPtr.Zero && SlateColor_UseForeground_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:SlateColor_UseForeground", SlateColor_UseForeground_IsValid);
		GetLineLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLineLength");
		GetLineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLineLength_TargetTextLayout_PropertyAddress, GetLineLength_FunctionAddress, "TargetTextLayout");
		GetLineLength_TargetTextLayout_Offset = NativeReflectionCached.GetPropertyOffset(GetLineLength_FunctionAddress, "TargetTextLayout");
		GetLineLength_TargetTextLayout_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLineLength_FunctionAddress, "TargetTextLayout", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLineLength_ReturnValue_PropertyAddress, GetLineLength_FunctionAddress, "ReturnValue");
		GetLineLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLineLength_FunctionAddress, "ReturnValue");
		GetLineLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLineLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLineLength_IsValid = GetLineLength_FunctionAddress != IntPtr.Zero && GetLineLength_TargetTextLayout_IsValid && GetLineLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:GetLineLength", GetLineLength_IsValid);
		GetAsText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAsText");
		GetAsText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAsText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAsText_TextLayout_PropertyAddress, GetAsText_FunctionAddress, "TextLayout");
		GetAsText_TextLayout_Offset = NativeReflectionCached.GetPropertyOffset(GetAsText_FunctionAddress, "TextLayout");
		GetAsText_TextLayout_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsText_FunctionAddress, "TextLayout", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAsText_ReturnValue_PropertyAddress, GetAsText_FunctionAddress, "ReturnValue");
		GetAsText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAsText_FunctionAddress, "ReturnValue");
		GetAsText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAsText_IsValid = GetAsText_FunctionAddress != IntPtr.Zero && GetAsText_TextLayout_IsValid && GetAsText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:GetAsText", GetAsText_IsValid);
		DrawSpaceSpline_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawSpaceSpline");
		DrawSpaceSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawSpaceSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_Context_PropertyAddress, DrawSpaceSpline_FunctionAddress, "Context");
		DrawSpaceSpline_Context_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "Context");
		DrawSpaceSpline_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_InStart_PropertyAddress, DrawSpaceSpline_FunctionAddress, "InStart");
		DrawSpaceSpline_InStart_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "InStart");
		DrawSpaceSpline_InStart_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "InStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_InStartDir_PropertyAddress, DrawSpaceSpline_FunctionAddress, "InStartDir");
		DrawSpaceSpline_InStartDir_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "InStartDir");
		DrawSpaceSpline_InStartDir_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "InStartDir", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_InEnd_PropertyAddress, DrawSpaceSpline_FunctionAddress, "InEnd");
		DrawSpaceSpline_InEnd_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "InEnd");
		DrawSpaceSpline_InEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "InEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_InEndDir_PropertyAddress, DrawSpaceSpline_FunctionAddress, "InEndDir");
		DrawSpaceSpline_InEndDir_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "InEndDir");
		DrawSpaceSpline_InEndDir_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "InEndDir", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_InThickness_PropertyAddress, DrawSpaceSpline_FunctionAddress, "InThickness");
		DrawSpaceSpline_InThickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "InThickness");
		DrawSpaceSpline_InThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "InThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSpaceSpline_InTint_PropertyAddress, DrawSpaceSpline_FunctionAddress, "InTint");
		DrawSpaceSpline_InTint_Offset = NativeReflectionCached.GetPropertyOffset(DrawSpaceSpline_FunctionAddress, "InTint");
		DrawSpaceSpline_InTint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSpaceSpline_FunctionAddress, "InTint", Classes.FStructProperty);
		DrawSpaceSpline_IsValid = DrawSpaceSpline_FunctionAddress != IntPtr.Zero && DrawSpaceSpline_Context_IsValid && DrawSpaceSpline_InStart_IsValid && DrawSpaceSpline_InStartDir_IsValid && DrawSpaceSpline_InEnd_IsValid && DrawSpaceSpline_InEndDir_IsValid && DrawSpaceSpline_InThickness_IsValid && DrawSpaceSpline_InTint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:DrawSpaceSpline", DrawSpaceSpline_IsValid);
		ClearLines_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearLines");
		ClearLines_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearLines_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearLines_TextLayout_PropertyAddress, ClearLines_FunctionAddress, "TextLayout");
		ClearLines_TextLayout_Offset = NativeReflectionCached.GetPropertyOffset(ClearLines_FunctionAddress, "TextLayout");
		ClearLines_TextLayout_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearLines_FunctionAddress, "TextLayout", Classes.FStructProperty);
		ClearLines_IsValid = ClearLines_FunctionAddress != IntPtr.Zero && ClearLines_TextLayout_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:ClearLines", ClearLines_IsValid);
		AddLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddLine");
		AddLine_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLine_TextLayout_PropertyAddress, AddLine_FunctionAddress, "TextLayout");
		AddLine_TextLayout_Offset = NativeReflectionCached.GetPropertyOffset(AddLine_FunctionAddress, "TextLayout");
		AddLine_TextLayout_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLine_FunctionAddress, "TextLayout", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLine_Model_PropertyAddress, AddLine_FunctionAddress, "Model");
		AddLine_Model_Offset = NativeReflectionCached.GetPropertyOffset(AddLine_FunctionAddress, "Model");
		AddLine_Model_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLine_FunctionAddress, "Model", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLine_Runs_PropertyAddress, AddLine_FunctionAddress, "Runs");
		AddLine_Runs_Offset = NativeReflectionCached.GetPropertyOffset(AddLine_FunctionAddress, "Runs");
		AddLine_Runs_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLine_FunctionAddress, "Runs", Classes.FArrayProperty);
		AddLine_IsValid = AddLine_FunctionAddress != IntPtr.Zero && AddLine_TextLayout_IsValid && AddLine_Model_IsValid && AddLine_Runs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGBlueprintLibrary:AddLine", AddLine_IsValid);
	}
}
