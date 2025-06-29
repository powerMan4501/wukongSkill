using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptUMGLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Unregister_IsValid;

	private static IntPtr Unregister_FunctionAddress;

	private static int Unregister_ParamsSize;

	private static bool Unregister_StyleSet_IsValid;

	private static FFieldAddress Unregister_StyleSet_PropertyAddress;

	private static int Unregister_StyleSet_Offset;

	private static bool TakeWidget_IsValid;

	private static IntPtr TakeWidget_FunctionAddress;

	private static int TakeWidget_ParamsSize;

	private static bool TakeWidget_Widget_IsValid;

	private static FFieldAddress TakeWidget_Widget_PropertyAddress;

	private static int TakeWidget_Widget_Offset;

	private static bool TakeWidget_ReturnValue_IsValid;

	private static FFieldAddress TakeWidget_ReturnValue_PropertyAddress;

	private static int TakeWidget_ReturnValue_Offset;

	private static bool ShowWindow_IsValid;

	private static IntPtr ShowWindow_FunctionAddress;

	private static int ShowWindow_ParamsSize;

	private static bool ShowWindow_NewWindow_IsValid;

	private static FFieldAddress ShowWindow_NewWindow_PropertyAddress;

	private static int ShowWindow_NewWindow_Offset;

	private static bool SetCoreContentRoot_IsValid;

	private static IntPtr SetCoreContentRoot_FunctionAddress;

	private static int SetCoreContentRoot_ParamsSize;

	private static bool SetCoreContentRoot_StyleSet_IsValid;

	private static FFieldAddress SetCoreContentRoot_StyleSet_PropertyAddress;

	private static int SetCoreContentRoot_StyleSet_Offset;

	private static bool SetCoreContentRoot_InCoreContentRootDir_IsValid;

	private static FFieldAddress SetCoreContentRoot_InCoreContentRootDir_PropertyAddress;

	private static int SetCoreContentRoot_InCoreContentRootDir_Offset;

	private static bool SetContentRoot_IsValid;

	private static IntPtr SetContentRoot_FunctionAddress;

	private static int SetContentRoot_ParamsSize;

	private static bool SetContentRoot_StyleSet_IsValid;

	private static FFieldAddress SetContentRoot_StyleSet_PropertyAddress;

	private static int SetContentRoot_StyleSet_Offset;

	private static bool SetContentRoot_InContentRootDir_IsValid;

	private static FFieldAddress SetContentRoot_InContentRootDir_PropertyAddress;

	private static int SetContentRoot_InContentRootDir_Offset;

	private static bool SetContent_IsValid;

	private static IntPtr SetContent_FunctionAddress;

	private static int SetContent_ParamsSize;

	private static bool SetContent_TargetWidget_IsValid;

	private static FFieldAddress SetContent_TargetWidget_PropertyAddress;

	private static int SetContent_TargetWidget_Offset;

	private static bool SetContent_SlateWidget_IsValid;

	private static FFieldAddress SetContent_SlateWidget_PropertyAddress;

	private static int SetContent_SlateWidget_Offset;

	private static bool SetContent_ReturnValue_IsValid;

	private static FFieldAddress SetContent_ReturnValue_PropertyAddress;

	private static int SetContent_ReturnValue_Offset;

	private static bool RootToCoreContentDir_IsValid;

	private static IntPtr RootToCoreContentDir_FunctionAddress;

	private static int RootToCoreContentDir_ParamsSize;

	private static bool RootToCoreContentDir_StyleSet_IsValid;

	private static FFieldAddress RootToCoreContentDir_StyleSet_PropertyAddress;

	private static int RootToCoreContentDir_StyleSet_Offset;

	private static bool RootToCoreContentDir_RelativePath_IsValid;

	private static FFieldAddress RootToCoreContentDir_RelativePath_PropertyAddress;

	private static int RootToCoreContentDir_RelativePath_Offset;

	private static bool RootToCoreContentDir_ReturnValue_IsValid;

	private static FFieldAddress RootToCoreContentDir_ReturnValue_PropertyAddress;

	private static int RootToCoreContentDir_ReturnValue_Offset;

	private static bool RootToContentDir_IsValid;

	private static IntPtr RootToContentDir_FunctionAddress;

	private static int RootToContentDir_ParamsSize;

	private static bool RootToContentDir_StyleSet_IsValid;

	private static FFieldAddress RootToContentDir_StyleSet_PropertyAddress;

	private static int RootToContentDir_StyleSet_Offset;

	private static bool RootToContentDir_RelativePath_IsValid;

	private static FFieldAddress RootToContentDir_RelativePath_PropertyAddress;

	private static int RootToContentDir_RelativePath_Offset;

	private static bool RootToContentDir_ReturnValue_IsValid;

	private static FFieldAddress RootToContentDir_ReturnValue_PropertyAddress;

	private static int RootToContentDir_ReturnValue_Offset;

	private static bool Register_IsValid;

	private static IntPtr Register_FunctionAddress;

	private static int Register_ParamsSize;

	private static bool Register_StyleSet_IsValid;

	private static FFieldAddress Register_StyleSet_PropertyAddress;

	private static int Register_StyleSet_Offset;

	private static bool GetRootWindow_IsValid;

	private static IntPtr GetRootWindow_FunctionAddress;

	private static int GetRootWindow_ParamsSize;

	private static bool GetRootWindow_ReturnValue_IsValid;

	private static FFieldAddress GetRootWindow_ReturnValue_PropertyAddress;

	private static int GetRootWindow_ReturnValue_Offset;

	private static bool GenerateDynamicImageResource_IsValid;

	private static IntPtr GenerateDynamicImageResource_FunctionAddress;

	private static int GenerateDynamicImageResource_ParamsSize;

	private static bool GenerateDynamicImageResource_InDynamicBrushName_IsValid;

	private static FFieldAddress GenerateDynamicImageResource_InDynamicBrushName_PropertyAddress;

	private static int GenerateDynamicImageResource_InDynamicBrushName_Offset;

	private static bool GenerateDynamicImageResource_ReturnValue_IsValid;

	private static FFieldAddress GenerateDynamicImageResource_ReturnValue_PropertyAddress;

	private static int GenerateDynamicImageResource_ReturnValue_Offset;

	private static bool CreateSlateStyle_IsValid;

	private static IntPtr CreateSlateStyle_FunctionAddress;

	private static int CreateSlateStyle_ParamsSize;

	private static bool CreateSlateStyle_InStyleSetName_IsValid;

	private static FFieldAddress CreateSlateStyle_InStyleSetName_PropertyAddress;

	private static int CreateSlateStyle_InStyleSetName_Offset;

	private static bool CreateSlateStyle_ReturnValue_IsValid;

	private static FFieldAddress CreateSlateStyle_ReturnValue_PropertyAddress;

	private static int CreateSlateStyle_ReturnValue_Offset;

	private static bool AddWindowAsNativeChild_IsValid;

	private static IntPtr AddWindowAsNativeChild_FunctionAddress;

	private static int AddWindowAsNativeChild_ParamsSize;

	private static bool AddWindowAsNativeChild_NewWindow_IsValid;

	private static FFieldAddress AddWindowAsNativeChild_NewWindow_PropertyAddress;

	private static int AddWindowAsNativeChild_NewWindow_Offset;

	private static bool AddWindowAsNativeChild_RootWindow_IsValid;

	private static FFieldAddress AddWindowAsNativeChild_RootWindow_PropertyAddress;

	private static int AddWindowAsNativeChild_RootWindow_Offset;

	private static bool AddWindow_IsValid;

	private static IntPtr AddWindow_FunctionAddress;

	private static int AddWindow_ParamsSize;

	private static bool AddWindow_NewWindow_IsValid;

	private static FFieldAddress AddWindow_NewWindow_PropertyAddress;

	private static int AddWindow_NewWindow_Offset;

	private static bool AddWindow_bShowImmediately_IsValid;

	private static FFieldAddress AddWindow_bShowImmediately_PropertyAddress;

	private static int AddWindow_bShowImmediately_Offset;

	private static bool AddSound_IsValid;

	private static IntPtr AddSound_FunctionAddress;

	private static int AddSound_ParamsSize;

	private static bool AddSound_StyleSet_IsValid;

	private static FFieldAddress AddSound_StyleSet_PropertyAddress;

	private static int AddSound_StyleSet_Offset;

	private static bool AddSound_PropertyName_IsValid;

	private static FFieldAddress AddSound_PropertyName_PropertyAddress;

	private static int AddSound_PropertyName_Offset;

	private static bool AddSound_Sound_IsValid;

	private static FFieldAddress AddSound_Sound_PropertyAddress;

	private static int AddSound_Sound_Offset;

	private static bool AddImageBrush_IsValid;

	private static IntPtr AddImageBrush_FunctionAddress;

	private static int AddImageBrush_ParamsSize;

	private static bool AddImageBrush_StyleSet_IsValid;

	private static FFieldAddress AddImageBrush_StyleSet_PropertyAddress;

	private static int AddImageBrush_StyleSet_Offset;

	private static bool AddImageBrush_PropertyName_IsValid;

	private static FFieldAddress AddImageBrush_PropertyName_PropertyAddress;

	private static int AddImageBrush_PropertyName_Offset;

	private static bool AddImageBrush_InImageName_IsValid;

	private static FFieldAddress AddImageBrush_InImageName_PropertyAddress;

	private static int AddImageBrush_InImageName_Offset;

	private static bool AddImageBrush_InImageSize_IsValid;

	private static FFieldAddress AddImageBrush_InImageSize_PropertyAddress;

	private static int AddImageBrush_InImageSize_Offset;

	private static bool AddImageBrush_InTint_IsValid;

	private static FFieldAddress AddImageBrush_InTint_PropertyAddress;

	private static int AddImageBrush_InTint_Offset;

	private static bool AddImageBrush_InTiling_IsValid;

	private static FFieldAddress AddImageBrush_InTiling_PropertyAddress;

	private static int AddImageBrush_InTiling_Offset;

	private static bool AddImageBrush_InImageType_IsValid;

	private static FFieldAddress AddImageBrush_InImageType_PropertyAddress;

	private static int AddImageBrush_InImageType_Offset;

	private static bool AddFontInfo_IsValid;

	private static IntPtr AddFontInfo_FunctionAddress;

	private static int AddFontInfo_ParamsSize;

	private static bool AddFontInfo_StyleSet_IsValid;

	private static FFieldAddress AddFontInfo_StyleSet_PropertyAddress;

	private static int AddFontInfo_StyleSet_Offset;

	private static bool AddFontInfo_PropertyName_IsValid;

	private static FFieldAddress AddFontInfo_PropertyName_PropertyAddress;

	private static int AddFontInfo_PropertyName_Offset;

	private static bool AddFontInfo_FontInfo_IsValid;

	private static FFieldAddress AddFontInfo_FontInfo_PropertyAddress;

	private static int AddFontInfo_FontInfo_Offset;

	private static bool AddBoxBrush_IsValid;

	private static IntPtr AddBoxBrush_FunctionAddress;

	private static int AddBoxBrush_ParamsSize;

	private static bool AddBoxBrush_StyleSet_IsValid;

	private static FFieldAddress AddBoxBrush_StyleSet_PropertyAddress;

	private static int AddBoxBrush_StyleSet_Offset;

	private static bool AddBoxBrush_PropertyName_IsValid;

	private static FFieldAddress AddBoxBrush_PropertyName_PropertyAddress;

	private static int AddBoxBrush_PropertyName_Offset;

	private static bool AddBoxBrush_InImageName_IsValid;

	private static FFieldAddress AddBoxBrush_InImageName_PropertyAddress;

	private static int AddBoxBrush_InImageName_Offset;

	private static bool AddBoxBrush_InMargin_IsValid;

	private static FFieldAddress AddBoxBrush_InMargin_PropertyAddress;

	private static int AddBoxBrush_InMargin_Offset;

	private static bool AddBoxBrush_InColorAndOpacity_IsValid;

	private static FFieldAddress AddBoxBrush_InColorAndOpacity_PropertyAddress;

	private static int AddBoxBrush_InColorAndOpacity_Offset;

	private static bool AddBoxBrush_InImageType_IsValid;

	private static FFieldAddress AddBoxBrush_InImageType_PropertyAddress;

	private static int AddBoxBrush_InImageType_Offset;

	private static bool AddBorderBrush_IsValid;

	private static IntPtr AddBorderBrush_FunctionAddress;

	private static int AddBorderBrush_ParamsSize;

	private static bool AddBorderBrush_StyleSet_IsValid;

	private static FFieldAddress AddBorderBrush_StyleSet_PropertyAddress;

	private static int AddBorderBrush_StyleSet_Offset;

	private static bool AddBorderBrush_PropertyName_IsValid;

	private static FFieldAddress AddBorderBrush_PropertyName_PropertyAddress;

	private static int AddBorderBrush_PropertyName_Offset;

	private static bool AddBorderBrush_InImageName_IsValid;

	private static FFieldAddress AddBorderBrush_InImageName_PropertyAddress;

	private static int AddBorderBrush_InImageName_Offset;

	private static bool AddBorderBrush_InMargin_IsValid;

	private static FFieldAddress AddBorderBrush_InMargin_PropertyAddress;

	private static int AddBorderBrush_InMargin_Offset;

	private static bool AddBorderBrush_InColorAndOpacity_IsValid;

	private static FFieldAddress AddBorderBrush_InColorAndOpacity_PropertyAddress;

	private static int AddBorderBrush_InColorAndOpacity_Offset;

	private static bool AddBorderBrush_InImageType_IsValid;

	private static FFieldAddress AddBorderBrush_InImageType_PropertyAddress;

	private static int AddBorderBrush_InImageType_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:Unregister")]
	public unsafe static void Unregister(FJavascriptSlateStyle StyleSet)
	{
		if (!Unregister_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:Unregister");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Unregister_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Unregister_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Unregister_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, Unregister_StyleSet_Offset), 0, Unregister_StyleSet_PropertyAddress.Address, StyleSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Unregister_FunctionAddress, intPtr, Unregister_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Unregister_StyleSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:TakeWidget")]
	public unsafe static FJavascriptSlateWidget TakeWidget(UWidget Widget)
	{
		if (!TakeWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:TakeWidget");
			return default(FJavascriptSlateWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, TakeWidget_Widget_Offset), 0, TakeWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TakeWidget_FunctionAddress, intPtr, TakeWidget_ParamsSize);
		FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, TakeWidget_ReturnValue_Offset), 0, TakeWidget_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(TakeWidget_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:ShowWindow")]
	public unsafe static void ShowWindow(FJavascriptSlateWidget NewWindow)
	{
		if (!ShowWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:ShowWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ShowWindow_NewWindow_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, ShowWindow_NewWindow_Offset), 0, ShowWindow_NewWindow_PropertyAddress.Address, NewWindow);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowWindow_FunctionAddress, intPtr, ShowWindow_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowWindow_NewWindow_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:SetCoreContentRoot")]
	public unsafe static void SetCoreContentRoot(FJavascriptSlateStyle StyleSet, string InCoreContentRootDir)
	{
		if (!SetCoreContentRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:SetCoreContentRoot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCoreContentRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCoreContentRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCoreContentRoot_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, SetCoreContentRoot_StyleSet_Offset), 0, SetCoreContentRoot_StyleSet_PropertyAddress.Address, StyleSet);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCoreContentRoot_InCoreContentRootDir_Offset), 0, SetCoreContentRoot_InCoreContentRootDir_PropertyAddress.Address, InCoreContentRootDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCoreContentRoot_FunctionAddress, intPtr, SetCoreContentRoot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCoreContentRoot_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetCoreContentRoot_InCoreContentRootDir_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:SetContentRoot")]
	public unsafe static void SetContentRoot(FJavascriptSlateStyle StyleSet, string InContentRootDir)
	{
		if (!SetContentRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:SetContentRoot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContentRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContentRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetContentRoot_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, SetContentRoot_StyleSet_Offset), 0, SetContentRoot_StyleSet_PropertyAddress.Address, StyleSet);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetContentRoot_InContentRootDir_Offset), 0, SetContentRoot_InContentRootDir_PropertyAddress.Address, InContentRootDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetContentRoot_FunctionAddress, intPtr, SetContentRoot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetContentRoot_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetContentRoot_InContentRootDir_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:SetContent")]
	public unsafe static UWidget SetContent(UNativeWidgetHost TargetWidget, FJavascriptSlateWidget SlateWidget)
	{
		if (!SetContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:SetContent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNativeWidgetHost>.ToNative(IntPtr.Add(intPtr, SetContent_TargetWidget_Offset), 0, SetContent_TargetWidget_PropertyAddress.Address, TargetWidget);
		NativeReflection.InitializeValue_InContainer(SetContent_SlateWidget_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, SetContent_SlateWidget_Offset), 0, SetContent_SlateWidget_PropertyAddress.Address, SlateWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetContent_FunctionAddress, intPtr, SetContent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetContent_SlateWidget_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, SetContent_ReturnValue_Offset), 0, SetContent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:RootToCoreContentDir")]
	public unsafe static string RootToCoreContentDir(FJavascriptSlateStyle StyleSet, string RelativePath)
	{
		if (!RootToCoreContentDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:RootToCoreContentDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RootToCoreContentDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RootToCoreContentDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RootToCoreContentDir_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, RootToCoreContentDir_StyleSet_Offset), 0, RootToCoreContentDir_StyleSet_PropertyAddress.Address, StyleSet);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RootToCoreContentDir_RelativePath_Offset), 0, RootToCoreContentDir_RelativePath_PropertyAddress.Address, RelativePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RootToCoreContentDir_FunctionAddress, intPtr, RootToCoreContentDir_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RootToCoreContentDir_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RootToCoreContentDir_RelativePath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RootToCoreContentDir_ReturnValue_Offset), 0, RootToCoreContentDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RootToCoreContentDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:RootToContentDir")]
	public unsafe static string RootToContentDir(FJavascriptSlateStyle StyleSet, string RelativePath)
	{
		if (!RootToContentDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:RootToContentDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RootToContentDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RootToContentDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RootToContentDir_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, RootToContentDir_StyleSet_Offset), 0, RootToContentDir_StyleSet_PropertyAddress.Address, StyleSet);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RootToContentDir_RelativePath_Offset), 0, RootToContentDir_RelativePath_PropertyAddress.Address, RelativePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RootToContentDir_FunctionAddress, intPtr, RootToContentDir_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RootToContentDir_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RootToContentDir_RelativePath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RootToContentDir_ReturnValue_Offset), 0, RootToContentDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RootToContentDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:Register")]
	public unsafe static void Register(FJavascriptSlateStyle StyleSet)
	{
		if (!Register_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:Register");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Register_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, Register_StyleSet_Offset), 0, Register_StyleSet_PropertyAddress.Address, StyleSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_FunctionAddress, intPtr, Register_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Register_StyleSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:GetRootWindow")]
	public unsafe static FJavascriptSlateWidget GetRootWindow()
	{
		if (!GetRootWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:GetRootWindow");
			return default(FJavascriptSlateWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRootWindow_FunctionAddress, intPtr, GetRootWindow_ParamsSize);
		FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, GetRootWindow_ReturnValue_Offset), 0, GetRootWindow_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRootWindow_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:GenerateDynamicImageResource")]
	public unsafe static FVector2D GenerateDynamicImageResource(FName InDynamicBrushName)
	{
		if (!GenerateDynamicImageResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:GenerateDynamicImageResource");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateDynamicImageResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateDynamicImageResource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GenerateDynamicImageResource_InDynamicBrushName_Offset), 0, GenerateDynamicImageResource_InDynamicBrushName_PropertyAddress.Address, InDynamicBrushName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateDynamicImageResource_FunctionAddress, intPtr, GenerateDynamicImageResource_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GenerateDynamicImageResource_ReturnValue_Offset), 0, GenerateDynamicImageResource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:CreateSlateStyle")]
	public unsafe static FJavascriptSlateStyle CreateSlateStyle(FName InStyleSetName)
	{
		if (!CreateSlateStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:CreateSlateStyle");
			return default(FJavascriptSlateStyle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateSlateStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateSlateStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateSlateStyle_InStyleSetName_Offset), 0, CreateSlateStyle_InStyleSetName_PropertyAddress.Address, InStyleSetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateSlateStyle_FunctionAddress, intPtr, CreateSlateStyle_ParamsSize);
		FJavascriptSlateStyle result = FJavascriptSlateStyle.FromNative(IntPtr.Add(intPtr, CreateSlateStyle_ReturnValue_Offset), 0, CreateSlateStyle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateSlateStyle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddWindowAsNativeChild")]
	public unsafe static void AddWindowAsNativeChild(FJavascriptSlateWidget NewWindow, FJavascriptSlateWidget RootWindow)
	{
		if (!AddWindowAsNativeChild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddWindowAsNativeChild");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWindowAsNativeChild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWindowAsNativeChild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddWindowAsNativeChild_NewWindow_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, AddWindowAsNativeChild_NewWindow_Offset), 0, AddWindowAsNativeChild_NewWindow_PropertyAddress.Address, NewWindow);
		NativeReflection.InitializeValue_InContainer(AddWindowAsNativeChild_RootWindow_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, AddWindowAsNativeChild_RootWindow_Offset), 0, AddWindowAsNativeChild_RootWindow_PropertyAddress.Address, RootWindow);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddWindowAsNativeChild_FunctionAddress, intPtr, AddWindowAsNativeChild_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddWindowAsNativeChild_NewWindow_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddWindowAsNativeChild_RootWindow_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddWindow")]
	public unsafe static void AddWindow(FJavascriptSlateWidget NewWindow, bool bShowImmediately = true)
	{
		if (!AddWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddWindow_NewWindow_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, AddWindow_NewWindow_Offset), 0, AddWindow_NewWindow_PropertyAddress.Address, NewWindow);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWindow_bShowImmediately_Offset), 0, AddWindow_bShowImmediately_PropertyAddress.Address, bShowImmediately);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddWindow_FunctionAddress, intPtr, AddWindow_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddWindow_NewWindow_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddSound")]
	public unsafe static void AddSound(FJavascriptSlateStyle StyleSet, FName PropertyName, FSlateSound Sound)
	{
		if (!AddSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddSound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddSound_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, AddSound_StyleSet_Offset), 0, AddSound_StyleSet_PropertyAddress.Address, StyleSet);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSound_PropertyName_Offset), 0, AddSound_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(AddSound_Sound_PropertyAddress.Address, intPtr);
		FSlateSound.ToNative(IntPtr.Add(intPtr, AddSound_Sound_Offset), 0, AddSound_Sound_PropertyAddress.Address, Sound);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSound_FunctionAddress, intPtr, AddSound_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSound_StyleSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79963137u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddImageBrush")]
	public unsafe static void AddImageBrush(FJavascriptSlateStyle StyleSet, FName PropertyName, string InImageName, FVector2D InImageSize, FLinearColor InTint, ESlateBrushTileType InTiling, ESlateBrushImageType InImageType)
	{
		if (!AddImageBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddImageBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddImageBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddImageBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddImageBrush_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, AddImageBrush_StyleSet_Offset), 0, AddImageBrush_StyleSet_PropertyAddress.Address, StyleSet);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddImageBrush_PropertyName_Offset), 0, AddImageBrush_PropertyName_PropertyAddress.Address, PropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddImageBrush_InImageName_Offset), 0, AddImageBrush_InImageName_PropertyAddress.Address, InImageName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddImageBrush_InImageSize_Offset), 0, AddImageBrush_InImageSize_PropertyAddress.Address, InImageSize);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddImageBrush_InTint_Offset), 0, AddImageBrush_InTint_PropertyAddress.Address, InTint);
		EnumMarshaler<ESlateBrushTileType>.ToNative(IntPtr.Add(intPtr, AddImageBrush_InTiling_Offset), 0, AddImageBrush_InTiling_PropertyAddress.Address, InTiling);
		EnumMarshaler<ESlateBrushImageType>.ToNative(IntPtr.Add(intPtr, AddImageBrush_InImageType_Offset), 0, AddImageBrush_InImageType_PropertyAddress.Address, InImageType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddImageBrush_FunctionAddress, intPtr, AddImageBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddImageBrush_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddImageBrush_InImageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddFontInfo")]
	public unsafe static void AddFontInfo(FJavascriptSlateStyle StyleSet, FName PropertyName, FSlateFontInfo FontInfo)
	{
		if (!AddFontInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddFontInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFontInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFontInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddFontInfo_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, AddFontInfo_StyleSet_Offset), 0, AddFontInfo_StyleSet_PropertyAddress.Address, StyleSet);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFontInfo_PropertyName_Offset), 0, AddFontInfo_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(AddFontInfo_FontInfo_PropertyAddress.Address, intPtr);
		FSlateFontInfo.ToNative(IntPtr.Add(intPtr, AddFontInfo_FontInfo_Offset), 0, AddFontInfo_FontInfo_PropertyAddress.Address, FontInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFontInfo_FunctionAddress, intPtr, AddFontInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFontInfo_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddFontInfo_FontInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79963137u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddBoxBrush")]
	public unsafe static void AddBoxBrush(FJavascriptSlateStyle StyleSet, FName PropertyName, string InImageName, FMargin InMargin, FLinearColor InColorAndOpacity, ESlateBrushImageType InImageType)
	{
		if (!AddBoxBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddBoxBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBoxBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBoxBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddBoxBrush_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, AddBoxBrush_StyleSet_Offset), 0, AddBoxBrush_StyleSet_PropertyAddress.Address, StyleSet);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoxBrush_PropertyName_Offset), 0, AddBoxBrush_PropertyName_PropertyAddress.Address, PropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddBoxBrush_InImageName_Offset), 0, AddBoxBrush_InImageName_PropertyAddress.Address, InImageName);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, AddBoxBrush_InMargin_Offset), 0, AddBoxBrush_InMargin_PropertyAddress.Address, InMargin);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddBoxBrush_InColorAndOpacity_Offset), 0, AddBoxBrush_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		EnumMarshaler<ESlateBrushImageType>.ToNative(IntPtr.Add(intPtr, AddBoxBrush_InImageType_Offset), 0, AddBoxBrush_InImageType_PropertyAddress.Address, InImageType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBoxBrush_FunctionAddress, intPtr, AddBoxBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBoxBrush_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddBoxBrush_InImageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79963137u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptUMGLibrary:AddBorderBrush")]
	public unsafe static void AddBorderBrush(FJavascriptSlateStyle StyleSet, FName PropertyName, string InImageName, FMargin InMargin, FLinearColor InColorAndOpacity, ESlateBrushImageType InImageType)
	{
		if (!AddBorderBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptUMGLibrary:AddBorderBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBorderBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBorderBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddBorderBrush_StyleSet_PropertyAddress.Address, intPtr);
		FJavascriptSlateStyle.ToNative(IntPtr.Add(intPtr, AddBorderBrush_StyleSet_Offset), 0, AddBorderBrush_StyleSet_PropertyAddress.Address, StyleSet);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBorderBrush_PropertyName_Offset), 0, AddBorderBrush_PropertyName_PropertyAddress.Address, PropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddBorderBrush_InImageName_Offset), 0, AddBorderBrush_InImageName_PropertyAddress.Address, InImageName);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, AddBorderBrush_InMargin_Offset), 0, AddBorderBrush_InMargin_PropertyAddress.Address, InMargin);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddBorderBrush_InColorAndOpacity_Offset), 0, AddBorderBrush_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		EnumMarshaler<ESlateBrushImageType>.ToNative(IntPtr.Add(intPtr, AddBorderBrush_InImageType_Offset), 0, AddBorderBrush_InImageType_PropertyAddress.Address, InImageType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBorderBrush_FunctionAddress, intPtr, AddBorderBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBorderBrush_StyleSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddBorderBrush_InImageName_PropertyAddress.Address, intPtr);
	}

	static UJavascriptUMGLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptUMGLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptUMGLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptUMGLibrary");
		Unregister_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Unregister");
		Unregister_ParamsSize = NativeReflection.GetFunctionParamsSize(Unregister_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Unregister_StyleSet_PropertyAddress, Unregister_FunctionAddress, "StyleSet");
		Unregister_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(Unregister_FunctionAddress, "StyleSet");
		Unregister_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Unregister_FunctionAddress, "StyleSet", Classes.FStructProperty);
		Unregister_IsValid = Unregister_FunctionAddress != IntPtr.Zero && Unregister_StyleSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:Unregister", Unregister_IsValid);
		TakeWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TakeWidget");
		TakeWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeWidget_Widget_PropertyAddress, TakeWidget_FunctionAddress, "Widget");
		TakeWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(TakeWidget_FunctionAddress, "Widget");
		TakeWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeWidget_ReturnValue_PropertyAddress, TakeWidget_FunctionAddress, "ReturnValue");
		TakeWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TakeWidget_FunctionAddress, "ReturnValue");
		TakeWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeWidget_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TakeWidget_IsValid = TakeWidget_FunctionAddress != IntPtr.Zero && TakeWidget_Widget_IsValid && TakeWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:TakeWidget", TakeWidget_IsValid);
		ShowWindow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowWindow");
		ShowWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowWindow_NewWindow_PropertyAddress, ShowWindow_FunctionAddress, "NewWindow");
		ShowWindow_NewWindow_Offset = NativeReflectionCached.GetPropertyOffset(ShowWindow_FunctionAddress, "NewWindow");
		ShowWindow_NewWindow_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowWindow_FunctionAddress, "NewWindow", Classes.FStructProperty);
		ShowWindow_IsValid = ShowWindow_FunctionAddress != IntPtr.Zero && ShowWindow_NewWindow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:ShowWindow", ShowWindow_IsValid);
		SetCoreContentRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCoreContentRoot");
		SetCoreContentRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCoreContentRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCoreContentRoot_StyleSet_PropertyAddress, SetCoreContentRoot_FunctionAddress, "StyleSet");
		SetCoreContentRoot_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(SetCoreContentRoot_FunctionAddress, "StyleSet");
		SetCoreContentRoot_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCoreContentRoot_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCoreContentRoot_InCoreContentRootDir_PropertyAddress, SetCoreContentRoot_FunctionAddress, "InCoreContentRootDir");
		SetCoreContentRoot_InCoreContentRootDir_Offset = NativeReflectionCached.GetPropertyOffset(SetCoreContentRoot_FunctionAddress, "InCoreContentRootDir");
		SetCoreContentRoot_InCoreContentRootDir_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCoreContentRoot_FunctionAddress, "InCoreContentRootDir", Classes.FStrProperty);
		SetCoreContentRoot_IsValid = SetCoreContentRoot_FunctionAddress != IntPtr.Zero && SetCoreContentRoot_StyleSet_IsValid && SetCoreContentRoot_InCoreContentRootDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:SetCoreContentRoot", SetCoreContentRoot_IsValid);
		SetContentRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetContentRoot");
		SetContentRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContentRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContentRoot_StyleSet_PropertyAddress, SetContentRoot_FunctionAddress, "StyleSet");
		SetContentRoot_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(SetContentRoot_FunctionAddress, "StyleSet");
		SetContentRoot_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContentRoot_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetContentRoot_InContentRootDir_PropertyAddress, SetContentRoot_FunctionAddress, "InContentRootDir");
		SetContentRoot_InContentRootDir_Offset = NativeReflectionCached.GetPropertyOffset(SetContentRoot_FunctionAddress, "InContentRootDir");
		SetContentRoot_InContentRootDir_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContentRoot_FunctionAddress, "InContentRootDir", Classes.FStrProperty);
		SetContentRoot_IsValid = SetContentRoot_FunctionAddress != IntPtr.Zero && SetContentRoot_StyleSet_IsValid && SetContentRoot_InContentRootDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:SetContentRoot", SetContentRoot_IsValid);
		SetContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetContent");
		SetContent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContent_TargetWidget_PropertyAddress, SetContent_FunctionAddress, "TargetWidget");
		SetContent_TargetWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetContent_FunctionAddress, "TargetWidget");
		SetContent_TargetWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContent_FunctionAddress, "TargetWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetContent_SlateWidget_PropertyAddress, SetContent_FunctionAddress, "SlateWidget");
		SetContent_SlateWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetContent_FunctionAddress, "SlateWidget");
		SetContent_SlateWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContent_FunctionAddress, "SlateWidget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetContent_ReturnValue_PropertyAddress, SetContent_FunctionAddress, "ReturnValue");
		SetContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetContent_FunctionAddress, "ReturnValue");
		SetContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetContent_IsValid = SetContent_FunctionAddress != IntPtr.Zero && SetContent_TargetWidget_IsValid && SetContent_SlateWidget_IsValid && SetContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:SetContent", SetContent_IsValid);
		RootToCoreContentDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RootToCoreContentDir");
		RootToCoreContentDir_ParamsSize = NativeReflection.GetFunctionParamsSize(RootToCoreContentDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RootToCoreContentDir_StyleSet_PropertyAddress, RootToCoreContentDir_FunctionAddress, "StyleSet");
		RootToCoreContentDir_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(RootToCoreContentDir_FunctionAddress, "StyleSet");
		RootToCoreContentDir_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(RootToCoreContentDir_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RootToCoreContentDir_RelativePath_PropertyAddress, RootToCoreContentDir_FunctionAddress, "RelativePath");
		RootToCoreContentDir_RelativePath_Offset = NativeReflectionCached.GetPropertyOffset(RootToCoreContentDir_FunctionAddress, "RelativePath");
		RootToCoreContentDir_RelativePath_IsValid = NativeReflectionCached.ValidatePropertyClass(RootToCoreContentDir_FunctionAddress, "RelativePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RootToCoreContentDir_ReturnValue_PropertyAddress, RootToCoreContentDir_FunctionAddress, "ReturnValue");
		RootToCoreContentDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RootToCoreContentDir_FunctionAddress, "ReturnValue");
		RootToCoreContentDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RootToCoreContentDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RootToCoreContentDir_IsValid = RootToCoreContentDir_FunctionAddress != IntPtr.Zero && RootToCoreContentDir_StyleSet_IsValid && RootToCoreContentDir_RelativePath_IsValid && RootToCoreContentDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:RootToCoreContentDir", RootToCoreContentDir_IsValid);
		RootToContentDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RootToContentDir");
		RootToContentDir_ParamsSize = NativeReflection.GetFunctionParamsSize(RootToContentDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RootToContentDir_StyleSet_PropertyAddress, RootToContentDir_FunctionAddress, "StyleSet");
		RootToContentDir_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(RootToContentDir_FunctionAddress, "StyleSet");
		RootToContentDir_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(RootToContentDir_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RootToContentDir_RelativePath_PropertyAddress, RootToContentDir_FunctionAddress, "RelativePath");
		RootToContentDir_RelativePath_Offset = NativeReflectionCached.GetPropertyOffset(RootToContentDir_FunctionAddress, "RelativePath");
		RootToContentDir_RelativePath_IsValid = NativeReflectionCached.ValidatePropertyClass(RootToContentDir_FunctionAddress, "RelativePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RootToContentDir_ReturnValue_PropertyAddress, RootToContentDir_FunctionAddress, "ReturnValue");
		RootToContentDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RootToContentDir_FunctionAddress, "ReturnValue");
		RootToContentDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RootToContentDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RootToContentDir_IsValid = RootToContentDir_FunctionAddress != IntPtr.Zero && RootToContentDir_StyleSet_IsValid && RootToContentDir_RelativePath_IsValid && RootToContentDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:RootToContentDir", RootToContentDir_IsValid);
		Register_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register");
		Register_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_StyleSet_PropertyAddress, Register_FunctionAddress, "StyleSet");
		Register_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(Register_FunctionAddress, "StyleSet");
		Register_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_FunctionAddress, "StyleSet", Classes.FStructProperty);
		Register_IsValid = Register_FunctionAddress != IntPtr.Zero && Register_StyleSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:Register", Register_IsValid);
		GetRootWindow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRootWindow");
		GetRootWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootWindow_ReturnValue_PropertyAddress, GetRootWindow_FunctionAddress, "ReturnValue");
		GetRootWindow_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootWindow_FunctionAddress, "ReturnValue");
		GetRootWindow_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootWindow_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRootWindow_IsValid = GetRootWindow_FunctionAddress != IntPtr.Zero && GetRootWindow_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:GetRootWindow", GetRootWindow_IsValid);
		GenerateDynamicImageResource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateDynamicImageResource");
		GenerateDynamicImageResource_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateDynamicImageResource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateDynamicImageResource_InDynamicBrushName_PropertyAddress, GenerateDynamicImageResource_FunctionAddress, "InDynamicBrushName");
		GenerateDynamicImageResource_InDynamicBrushName_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDynamicImageResource_FunctionAddress, "InDynamicBrushName");
		GenerateDynamicImageResource_InDynamicBrushName_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDynamicImageResource_FunctionAddress, "InDynamicBrushName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDynamicImageResource_ReturnValue_PropertyAddress, GenerateDynamicImageResource_FunctionAddress, "ReturnValue");
		GenerateDynamicImageResource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDynamicImageResource_FunctionAddress, "ReturnValue");
		GenerateDynamicImageResource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDynamicImageResource_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GenerateDynamicImageResource_IsValid = GenerateDynamicImageResource_FunctionAddress != IntPtr.Zero && GenerateDynamicImageResource_InDynamicBrushName_IsValid && GenerateDynamicImageResource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:GenerateDynamicImageResource", GenerateDynamicImageResource_IsValid);
		CreateSlateStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateSlateStyle");
		CreateSlateStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateSlateStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateSlateStyle_InStyleSetName_PropertyAddress, CreateSlateStyle_FunctionAddress, "InStyleSetName");
		CreateSlateStyle_InStyleSetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlateStyle_FunctionAddress, "InStyleSetName");
		CreateSlateStyle_InStyleSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlateStyle_FunctionAddress, "InStyleSetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlateStyle_ReturnValue_PropertyAddress, CreateSlateStyle_FunctionAddress, "ReturnValue");
		CreateSlateStyle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlateStyle_FunctionAddress, "ReturnValue");
		CreateSlateStyle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlateStyle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateSlateStyle_IsValid = CreateSlateStyle_FunctionAddress != IntPtr.Zero && CreateSlateStyle_InStyleSetName_IsValid && CreateSlateStyle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:CreateSlateStyle", CreateSlateStyle_IsValid);
		AddWindowAsNativeChild_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddWindowAsNativeChild");
		AddWindowAsNativeChild_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWindowAsNativeChild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWindowAsNativeChild_NewWindow_PropertyAddress, AddWindowAsNativeChild_FunctionAddress, "NewWindow");
		AddWindowAsNativeChild_NewWindow_Offset = NativeReflectionCached.GetPropertyOffset(AddWindowAsNativeChild_FunctionAddress, "NewWindow");
		AddWindowAsNativeChild_NewWindow_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWindowAsNativeChild_FunctionAddress, "NewWindow", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWindowAsNativeChild_RootWindow_PropertyAddress, AddWindowAsNativeChild_FunctionAddress, "RootWindow");
		AddWindowAsNativeChild_RootWindow_Offset = NativeReflectionCached.GetPropertyOffset(AddWindowAsNativeChild_FunctionAddress, "RootWindow");
		AddWindowAsNativeChild_RootWindow_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWindowAsNativeChild_FunctionAddress, "RootWindow", Classes.FStructProperty);
		AddWindowAsNativeChild_IsValid = AddWindowAsNativeChild_FunctionAddress != IntPtr.Zero && AddWindowAsNativeChild_NewWindow_IsValid && AddWindowAsNativeChild_RootWindow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddWindowAsNativeChild", AddWindowAsNativeChild_IsValid);
		AddWindow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddWindow");
		AddWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWindow_NewWindow_PropertyAddress, AddWindow_FunctionAddress, "NewWindow");
		AddWindow_NewWindow_Offset = NativeReflectionCached.GetPropertyOffset(AddWindow_FunctionAddress, "NewWindow");
		AddWindow_NewWindow_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWindow_FunctionAddress, "NewWindow", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWindow_bShowImmediately_PropertyAddress, AddWindow_FunctionAddress, "bShowImmediately");
		AddWindow_bShowImmediately_Offset = NativeReflectionCached.GetPropertyOffset(AddWindow_FunctionAddress, "bShowImmediately");
		AddWindow_bShowImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWindow_FunctionAddress, "bShowImmediately", Classes.FBoolProperty);
		AddWindow_IsValid = AddWindow_FunctionAddress != IntPtr.Zero && AddWindow_NewWindow_IsValid && AddWindow_bShowImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddWindow", AddWindow_IsValid);
		AddSound_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSound");
		AddSound_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSound_StyleSet_PropertyAddress, AddSound_FunctionAddress, "StyleSet");
		AddSound_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(AddSound_FunctionAddress, "StyleSet");
		AddSound_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSound_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSound_PropertyName_PropertyAddress, AddSound_FunctionAddress, "PropertyName");
		AddSound_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(AddSound_FunctionAddress, "PropertyName");
		AddSound_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSound_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSound_Sound_PropertyAddress, AddSound_FunctionAddress, "Sound");
		AddSound_Sound_Offset = NativeReflectionCached.GetPropertyOffset(AddSound_FunctionAddress, "Sound");
		AddSound_Sound_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSound_FunctionAddress, "Sound", Classes.FStructProperty);
		AddSound_IsValid = AddSound_FunctionAddress != IntPtr.Zero && AddSound_StyleSet_IsValid && AddSound_PropertyName_IsValid && AddSound_Sound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddSound", AddSound_IsValid);
		AddImageBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddImageBrush");
		AddImageBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(AddImageBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_StyleSet_PropertyAddress, AddImageBrush_FunctionAddress, "StyleSet");
		AddImageBrush_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "StyleSet");
		AddImageBrush_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_PropertyName_PropertyAddress, AddImageBrush_FunctionAddress, "PropertyName");
		AddImageBrush_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "PropertyName");
		AddImageBrush_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_InImageName_PropertyAddress, AddImageBrush_FunctionAddress, "InImageName");
		AddImageBrush_InImageName_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "InImageName");
		AddImageBrush_InImageName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "InImageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_InImageSize_PropertyAddress, AddImageBrush_FunctionAddress, "InImageSize");
		AddImageBrush_InImageSize_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "InImageSize");
		AddImageBrush_InImageSize_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "InImageSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_InTint_PropertyAddress, AddImageBrush_FunctionAddress, "InTint");
		AddImageBrush_InTint_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "InTint");
		AddImageBrush_InTint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "InTint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_InTiling_PropertyAddress, AddImageBrush_FunctionAddress, "InTiling");
		AddImageBrush_InTiling_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "InTiling");
		AddImageBrush_InTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "InTiling", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImageBrush_InImageType_PropertyAddress, AddImageBrush_FunctionAddress, "InImageType");
		AddImageBrush_InImageType_Offset = NativeReflectionCached.GetPropertyOffset(AddImageBrush_FunctionAddress, "InImageType");
		AddImageBrush_InImageType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImageBrush_FunctionAddress, "InImageType", Classes.FByteProperty);
		AddImageBrush_IsValid = AddImageBrush_FunctionAddress != IntPtr.Zero && AddImageBrush_StyleSet_IsValid && AddImageBrush_PropertyName_IsValid && AddImageBrush_InImageName_IsValid && AddImageBrush_InImageSize_IsValid && AddImageBrush_InTint_IsValid && AddImageBrush_InTiling_IsValid && AddImageBrush_InImageType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddImageBrush", AddImageBrush_IsValid);
		AddFontInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFontInfo");
		AddFontInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFontInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFontInfo_StyleSet_PropertyAddress, AddFontInfo_FunctionAddress, "StyleSet");
		AddFontInfo_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(AddFontInfo_FunctionAddress, "StyleSet");
		AddFontInfo_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFontInfo_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFontInfo_PropertyName_PropertyAddress, AddFontInfo_FunctionAddress, "PropertyName");
		AddFontInfo_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(AddFontInfo_FunctionAddress, "PropertyName");
		AddFontInfo_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFontInfo_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFontInfo_FontInfo_PropertyAddress, AddFontInfo_FunctionAddress, "FontInfo");
		AddFontInfo_FontInfo_Offset = NativeReflectionCached.GetPropertyOffset(AddFontInfo_FunctionAddress, "FontInfo");
		AddFontInfo_FontInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFontInfo_FunctionAddress, "FontInfo", Classes.FStructProperty);
		AddFontInfo_IsValid = AddFontInfo_FunctionAddress != IntPtr.Zero && AddFontInfo_StyleSet_IsValid && AddFontInfo_PropertyName_IsValid && AddFontInfo_FontInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddFontInfo", AddFontInfo_IsValid);
		AddBoxBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBoxBrush");
		AddBoxBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBoxBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBoxBrush_StyleSet_PropertyAddress, AddBoxBrush_FunctionAddress, "StyleSet");
		AddBoxBrush_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(AddBoxBrush_FunctionAddress, "StyleSet");
		AddBoxBrush_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoxBrush_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoxBrush_PropertyName_PropertyAddress, AddBoxBrush_FunctionAddress, "PropertyName");
		AddBoxBrush_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoxBrush_FunctionAddress, "PropertyName");
		AddBoxBrush_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoxBrush_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoxBrush_InImageName_PropertyAddress, AddBoxBrush_FunctionAddress, "InImageName");
		AddBoxBrush_InImageName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoxBrush_FunctionAddress, "InImageName");
		AddBoxBrush_InImageName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoxBrush_FunctionAddress, "InImageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoxBrush_InMargin_PropertyAddress, AddBoxBrush_FunctionAddress, "InMargin");
		AddBoxBrush_InMargin_Offset = NativeReflectionCached.GetPropertyOffset(AddBoxBrush_FunctionAddress, "InMargin");
		AddBoxBrush_InMargin_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoxBrush_FunctionAddress, "InMargin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoxBrush_InColorAndOpacity_PropertyAddress, AddBoxBrush_FunctionAddress, "InColorAndOpacity");
		AddBoxBrush_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(AddBoxBrush_FunctionAddress, "InColorAndOpacity");
		AddBoxBrush_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoxBrush_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoxBrush_InImageType_PropertyAddress, AddBoxBrush_FunctionAddress, "InImageType");
		AddBoxBrush_InImageType_Offset = NativeReflectionCached.GetPropertyOffset(AddBoxBrush_FunctionAddress, "InImageType");
		AddBoxBrush_InImageType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoxBrush_FunctionAddress, "InImageType", Classes.FByteProperty);
		AddBoxBrush_IsValid = AddBoxBrush_FunctionAddress != IntPtr.Zero && AddBoxBrush_StyleSet_IsValid && AddBoxBrush_PropertyName_IsValid && AddBoxBrush_InImageName_IsValid && AddBoxBrush_InMargin_IsValid && AddBoxBrush_InColorAndOpacity_IsValid && AddBoxBrush_InImageType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddBoxBrush", AddBoxBrush_IsValid);
		AddBorderBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBorderBrush");
		AddBorderBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBorderBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBorderBrush_StyleSet_PropertyAddress, AddBorderBrush_FunctionAddress, "StyleSet");
		AddBorderBrush_StyleSet_Offset = NativeReflectionCached.GetPropertyOffset(AddBorderBrush_FunctionAddress, "StyleSet");
		AddBorderBrush_StyleSet_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBorderBrush_FunctionAddress, "StyleSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBorderBrush_PropertyName_PropertyAddress, AddBorderBrush_FunctionAddress, "PropertyName");
		AddBorderBrush_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(AddBorderBrush_FunctionAddress, "PropertyName");
		AddBorderBrush_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBorderBrush_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBorderBrush_InImageName_PropertyAddress, AddBorderBrush_FunctionAddress, "InImageName");
		AddBorderBrush_InImageName_Offset = NativeReflectionCached.GetPropertyOffset(AddBorderBrush_FunctionAddress, "InImageName");
		AddBorderBrush_InImageName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBorderBrush_FunctionAddress, "InImageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBorderBrush_InMargin_PropertyAddress, AddBorderBrush_FunctionAddress, "InMargin");
		AddBorderBrush_InMargin_Offset = NativeReflectionCached.GetPropertyOffset(AddBorderBrush_FunctionAddress, "InMargin");
		AddBorderBrush_InMargin_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBorderBrush_FunctionAddress, "InMargin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBorderBrush_InColorAndOpacity_PropertyAddress, AddBorderBrush_FunctionAddress, "InColorAndOpacity");
		AddBorderBrush_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(AddBorderBrush_FunctionAddress, "InColorAndOpacity");
		AddBorderBrush_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBorderBrush_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBorderBrush_InImageType_PropertyAddress, AddBorderBrush_FunctionAddress, "InImageType");
		AddBorderBrush_InImageType_Offset = NativeReflectionCached.GetPropertyOffset(AddBorderBrush_FunctionAddress, "InImageType");
		AddBorderBrush_InImageType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBorderBrush_FunctionAddress, "InImageType", Classes.FByteProperty);
		AddBorderBrush_IsValid = AddBorderBrush_FunctionAddress != IntPtr.Zero && AddBorderBrush_StyleSet_IsValid && AddBorderBrush_PropertyName_IsValid && AddBorderBrush_InImageName_IsValid && AddBorderBrush_InMargin_IsValid && AddBorderBrush_InColorAndOpacity_IsValid && AddBorderBrush_InImageType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptUMGLibrary:AddBorderBrush", AddBorderBrush_IsValid);
	}
}
