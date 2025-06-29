using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSSlateUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSSlateUtils.GSSlateUtilsBPLibrary", "GSSlateUtils", UnrealModuleType.GamePlugin)]
public class UGSSlateUtilsBPLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetChildrenWidgetByUTextBlock_STextBlock_IsValid;

	private static IntPtr SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress;

	private static int SetChildrenWidgetByUTextBlock_STextBlock_ParamsSize;

	private static bool SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_IsValid;

	private static FFieldAddress SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_PropertyAddress;

	private static int SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_Offset;

	private static bool SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_IsValid;

	private static FFieldAddress SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_PropertyAddress;

	private static int SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_Offset;

	private static bool SetChildrenWidgetByUTextBlock_STextBlock_TextContent_IsValid;

	private static FFieldAddress SetChildrenWidgetByUTextBlock_STextBlock_TextContent_PropertyAddress;

	private static int SetChildrenWidgetByUTextBlock_STextBlock_TextContent_Offset;

	private static bool SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_IsValid;

	private static FFieldAddress SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_PropertyAddress;

	private static int SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_Offset;

	private static bool SetChildrenWidgetByUImage_SImage_IsValid;

	private static IntPtr SetChildrenWidgetByUImage_SImage_FunctionAddress;

	private static int SetChildrenWidgetByUImage_SImage_ParamsSize;

	private static bool SetChildrenWidgetByUImage_SImage_TargetUserWidget_IsValid;

	private static FFieldAddress SetChildrenWidgetByUImage_SImage_TargetUserWidget_PropertyAddress;

	private static int SetChildrenWidgetByUImage_SImage_TargetUserWidget_Offset;

	private static bool SetChildrenWidgetByUImage_SImage_TargetUImage_IsValid;

	private static FFieldAddress SetChildrenWidgetByUImage_SImage_TargetUImage_PropertyAddress;

	private static int SetChildrenWidgetByUImage_SImage_TargetUImage_Offset;

	private static bool SetChildrenWidgetByUImage_SImage_Texture_IsValid;

	private static FFieldAddress SetChildrenWidgetByUImage_SImage_Texture_PropertyAddress;

	private static int SetChildrenWidgetByUImage_SImage_Texture_Offset;

	private static bool SetChildrenWidgetByUImage_SImage_ReturnValue_IsValid;

	private static FFieldAddress SetChildrenWidgetByUImage_SImage_ReturnValue_PropertyAddress;

	private static int SetChildrenWidgetByUImage_SImage_ReturnValue_Offset;

	private static bool SetChildrenWidgetByName_STextBlock_IsValid;

	private static IntPtr SetChildrenWidgetByName_STextBlock_FunctionAddress;

	private static int SetChildrenWidgetByName_STextBlock_ParamsSize;

	private static bool SetChildrenWidgetByName_STextBlock_TargetUserWidget_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_STextBlock_TargetUserWidget_PropertyAddress;

	private static int SetChildrenWidgetByName_STextBlock_TargetUserWidget_Offset;

	private static bool SetChildrenWidgetByName_STextBlock_TargetName_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_STextBlock_TargetName_PropertyAddress;

	private static int SetChildrenWidgetByName_STextBlock_TargetName_Offset;

	private static bool SetChildrenWidgetByName_STextBlock_TextContent_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_STextBlock_TextContent_PropertyAddress;

	private static int SetChildrenWidgetByName_STextBlock_TextContent_Offset;

	private static bool SetChildrenWidgetByName_STextBlock_ReturnValue_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_STextBlock_ReturnValue_PropertyAddress;

	private static int SetChildrenWidgetByName_STextBlock_ReturnValue_Offset;

	private static bool SetChildrenWidgetByName_SImage_IsValid;

	private static IntPtr SetChildrenWidgetByName_SImage_FunctionAddress;

	private static int SetChildrenWidgetByName_SImage_ParamsSize;

	private static bool SetChildrenWidgetByName_SImage_TargetUserWidget_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_SImage_TargetUserWidget_PropertyAddress;

	private static int SetChildrenWidgetByName_SImage_TargetUserWidget_Offset;

	private static bool SetChildrenWidgetByName_SImage_TargetName_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_SImage_TargetName_PropertyAddress;

	private static int SetChildrenWidgetByName_SImage_TargetName_Offset;

	private static bool SetChildrenWidgetByName_SImage_Texture_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_SImage_Texture_PropertyAddress;

	private static int SetChildrenWidgetByName_SImage_Texture_Offset;

	private static bool SetChildrenWidgetByName_SImage_ReturnValue_IsValid;

	private static FFieldAddress SetChildrenWidgetByName_SImage_ReturnValue_PropertyAddress;

	private static int SetChildrenWidgetByName_SImage_ReturnValue_Offset;

	private static bool ClearCacheSlateBrush_IsValid;

	private static IntPtr ClearCacheSlateBrush_FunctionAddress;

	private static int ClearCacheSlateBrush_ParamsSize;

	private static bool ClearCacheSlateBrush_TargetUserWidget_IsValid;

	private static FFieldAddress ClearCacheSlateBrush_TargetUserWidget_PropertyAddress;

	private static int ClearCacheSlateBrush_TargetUserWidget_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByUTextBlock_STextBlock")]
	public unsafe static bool SetChildrenWidgetByUTextBlock_STextBlock(UUserWidget TargetUserWidget, UTextBlock TargetUTextBlock, FText TextContent)
	{
		if (!SetChildrenWidgetByUTextBlock_STextBlock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByUTextBlock_STextBlock");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChildrenWidgetByUTextBlock_STextBlock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChildrenWidgetByUTextBlock_STextBlock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_Offset), 0, SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_PropertyAddress.Address, TargetUserWidget);
		UObjectMarshaler<UTextBlock>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_Offset), 0, SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_PropertyAddress.Address, TargetUTextBlock);
		NativeReflection.InitializeValue_InContainer(SetChildrenWidgetByUTextBlock_STextBlock_TextContent_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByUTextBlock_STextBlock_TextContent_Offset), 0, SetChildrenWidgetByUTextBlock_STextBlock_TextContent_PropertyAddress.Address, TextContent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, intPtr, SetChildrenWidgetByUTextBlock_STextBlock_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetChildrenWidgetByUTextBlock_STextBlock_TextContent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_Offset), 0, SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByUImage_SImage")]
	public unsafe static bool SetChildrenWidgetByUImage_SImage(UUserWidget TargetUserWidget, UImage TargetUImage, UTexture2D Texture)
	{
		if (!SetChildrenWidgetByUImage_SImage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByUImage_SImage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChildrenWidgetByUImage_SImage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChildrenWidgetByUImage_SImage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByUImage_SImage_TargetUserWidget_Offset), 0, SetChildrenWidgetByUImage_SImage_TargetUserWidget_PropertyAddress.Address, TargetUserWidget);
		UObjectMarshaler<UImage>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByUImage_SImage_TargetUImage_Offset), 0, SetChildrenWidgetByUImage_SImage_TargetUImage_PropertyAddress.Address, TargetUImage);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByUImage_SImage_Texture_Offset), 0, SetChildrenWidgetByUImage_SImage_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetChildrenWidgetByUImage_SImage_FunctionAddress, intPtr, SetChildrenWidgetByUImage_SImage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetChildrenWidgetByUImage_SImage_ReturnValue_Offset), 0, SetChildrenWidgetByUImage_SImage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByName_STextBlock")]
	public unsafe static bool SetChildrenWidgetByName_STextBlock(UUserWidget TargetUserWidget, FName TargetName, FText TextContent)
	{
		if (!SetChildrenWidgetByName_STextBlock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByName_STextBlock");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChildrenWidgetByName_STextBlock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChildrenWidgetByName_STextBlock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_STextBlock_TargetUserWidget_Offset), 0, SetChildrenWidgetByName_STextBlock_TargetUserWidget_PropertyAddress.Address, TargetUserWidget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_STextBlock_TargetName_Offset), 0, SetChildrenWidgetByName_STextBlock_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InitializeValue_InContainer(SetChildrenWidgetByName_STextBlock_TextContent_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_STextBlock_TextContent_Offset), 0, SetChildrenWidgetByName_STextBlock_TextContent_PropertyAddress.Address, TextContent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetChildrenWidgetByName_STextBlock_FunctionAddress, intPtr, SetChildrenWidgetByName_STextBlock_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetChildrenWidgetByName_STextBlock_TextContent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_STextBlock_ReturnValue_Offset), 0, SetChildrenWidgetByName_STextBlock_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByName_SImage")]
	public unsafe static bool SetChildrenWidgetByName_SImage(UUserWidget TargetUserWidget, FName TargetName, UTexture2D Texture)
	{
		if (!SetChildrenWidgetByName_SImage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByName_SImage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChildrenWidgetByName_SImage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChildrenWidgetByName_SImage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_SImage_TargetUserWidget_Offset), 0, SetChildrenWidgetByName_SImage_TargetUserWidget_PropertyAddress.Address, TargetUserWidget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_SImage_TargetName_Offset), 0, SetChildrenWidgetByName_SImage_TargetName_PropertyAddress.Address, TargetName);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_SImage_Texture_Offset), 0, SetChildrenWidgetByName_SImage_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetChildrenWidgetByName_SImage_FunctionAddress, intPtr, SetChildrenWidgetByName_SImage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetChildrenWidgetByName_SImage_ReturnValue_Offset), 0, SetChildrenWidgetByName_SImage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:ClearCacheSlateBrush")]
	public unsafe static void ClearCacheSlateBrush(UUserWidget TargetUserWidget)
	{
		if (!ClearCacheSlateBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:ClearCacheSlateBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearCacheSlateBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearCacheSlateBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, ClearCacheSlateBrush_TargetUserWidget_Offset), 0, ClearCacheSlateBrush_TargetUserWidget_PropertyAddress.Address, TargetUserWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearCacheSlateBrush_FunctionAddress, intPtr, ClearCacheSlateBrush_ParamsSize);
	}

	static UGSSlateUtilsBPLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSSlateUtilsBPLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSSlateUtilsBPLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSSlateUtils.GSSlateUtilsBPLibrary");
		SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetChildrenWidgetByUTextBlock_STextBlock");
		SetChildrenWidgetByUTextBlock_STextBlock_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_PropertyAddress, SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TargetUserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_PropertyAddress, SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TargetUTextBlock");
		SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TargetUTextBlock");
		SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TargetUTextBlock", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUTextBlock_STextBlock_TextContent_PropertyAddress, SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TextContent");
		SetChildrenWidgetByUTextBlock_STextBlock_TextContent_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TextContent");
		SetChildrenWidgetByUTextBlock_STextBlock_TextContent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "TextContent", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_PropertyAddress, SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetChildrenWidgetByUTextBlock_STextBlock_IsValid = SetChildrenWidgetByUTextBlock_STextBlock_FunctionAddress != IntPtr.Zero && SetChildrenWidgetByUTextBlock_STextBlock_TargetUserWidget_IsValid && SetChildrenWidgetByUTextBlock_STextBlock_TargetUTextBlock_IsValid && SetChildrenWidgetByUTextBlock_STextBlock_TextContent_IsValid && SetChildrenWidgetByUTextBlock_STextBlock_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByUTextBlock_STextBlock", SetChildrenWidgetByUTextBlock_STextBlock_IsValid);
		SetChildrenWidgetByUImage_SImage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetChildrenWidgetByUImage_SImage");
		SetChildrenWidgetByUImage_SImage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChildrenWidgetByUImage_SImage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUImage_SImage_TargetUserWidget_PropertyAddress, SetChildrenWidgetByUImage_SImage_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByUImage_SImage_TargetUserWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUImage_SImage_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByUImage_SImage_TargetUserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUImage_SImage_FunctionAddress, "TargetUserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUImage_SImage_TargetUImage_PropertyAddress, SetChildrenWidgetByUImage_SImage_FunctionAddress, "TargetUImage");
		SetChildrenWidgetByUImage_SImage_TargetUImage_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUImage_SImage_FunctionAddress, "TargetUImage");
		SetChildrenWidgetByUImage_SImage_TargetUImage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUImage_SImage_FunctionAddress, "TargetUImage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUImage_SImage_Texture_PropertyAddress, SetChildrenWidgetByUImage_SImage_FunctionAddress, "Texture");
		SetChildrenWidgetByUImage_SImage_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUImage_SImage_FunctionAddress, "Texture");
		SetChildrenWidgetByUImage_SImage_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUImage_SImage_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByUImage_SImage_ReturnValue_PropertyAddress, SetChildrenWidgetByUImage_SImage_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByUImage_SImage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByUImage_SImage_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByUImage_SImage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByUImage_SImage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetChildrenWidgetByUImage_SImage_IsValid = SetChildrenWidgetByUImage_SImage_FunctionAddress != IntPtr.Zero && SetChildrenWidgetByUImage_SImage_TargetUserWidget_IsValid && SetChildrenWidgetByUImage_SImage_TargetUImage_IsValid && SetChildrenWidgetByUImage_SImage_Texture_IsValid && SetChildrenWidgetByUImage_SImage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByUImage_SImage", SetChildrenWidgetByUImage_SImage_IsValid);
		SetChildrenWidgetByName_STextBlock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetChildrenWidgetByName_STextBlock");
		SetChildrenWidgetByName_STextBlock_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChildrenWidgetByName_STextBlock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_STextBlock_TargetUserWidget_PropertyAddress, SetChildrenWidgetByName_STextBlock_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByName_STextBlock_TargetUserWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_STextBlock_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByName_STextBlock_TargetUserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_STextBlock_FunctionAddress, "TargetUserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_STextBlock_TargetName_PropertyAddress, SetChildrenWidgetByName_STextBlock_FunctionAddress, "TargetName");
		SetChildrenWidgetByName_STextBlock_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_STextBlock_FunctionAddress, "TargetName");
		SetChildrenWidgetByName_STextBlock_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_STextBlock_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_STextBlock_TextContent_PropertyAddress, SetChildrenWidgetByName_STextBlock_FunctionAddress, "TextContent");
		SetChildrenWidgetByName_STextBlock_TextContent_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_STextBlock_FunctionAddress, "TextContent");
		SetChildrenWidgetByName_STextBlock_TextContent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_STextBlock_FunctionAddress, "TextContent", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_STextBlock_ReturnValue_PropertyAddress, SetChildrenWidgetByName_STextBlock_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByName_STextBlock_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_STextBlock_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByName_STextBlock_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_STextBlock_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetChildrenWidgetByName_STextBlock_IsValid = SetChildrenWidgetByName_STextBlock_FunctionAddress != IntPtr.Zero && SetChildrenWidgetByName_STextBlock_TargetUserWidget_IsValid && SetChildrenWidgetByName_STextBlock_TargetName_IsValid && SetChildrenWidgetByName_STextBlock_TextContent_IsValid && SetChildrenWidgetByName_STextBlock_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByName_STextBlock", SetChildrenWidgetByName_STextBlock_IsValid);
		SetChildrenWidgetByName_SImage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetChildrenWidgetByName_SImage");
		SetChildrenWidgetByName_SImage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChildrenWidgetByName_SImage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_SImage_TargetUserWidget_PropertyAddress, SetChildrenWidgetByName_SImage_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByName_SImage_TargetUserWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_SImage_FunctionAddress, "TargetUserWidget");
		SetChildrenWidgetByName_SImage_TargetUserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_SImage_FunctionAddress, "TargetUserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_SImage_TargetName_PropertyAddress, SetChildrenWidgetByName_SImage_FunctionAddress, "TargetName");
		SetChildrenWidgetByName_SImage_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_SImage_FunctionAddress, "TargetName");
		SetChildrenWidgetByName_SImage_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_SImage_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_SImage_Texture_PropertyAddress, SetChildrenWidgetByName_SImage_FunctionAddress, "Texture");
		SetChildrenWidgetByName_SImage_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_SImage_FunctionAddress, "Texture");
		SetChildrenWidgetByName_SImage_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_SImage_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetChildrenWidgetByName_SImage_ReturnValue_PropertyAddress, SetChildrenWidgetByName_SImage_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByName_SImage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetChildrenWidgetByName_SImage_FunctionAddress, "ReturnValue");
		SetChildrenWidgetByName_SImage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildrenWidgetByName_SImage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetChildrenWidgetByName_SImage_IsValid = SetChildrenWidgetByName_SImage_FunctionAddress != IntPtr.Zero && SetChildrenWidgetByName_SImage_TargetUserWidget_IsValid && SetChildrenWidgetByName_SImage_TargetName_IsValid && SetChildrenWidgetByName_SImage_Texture_IsValid && SetChildrenWidgetByName_SImage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:SetChildrenWidgetByName_SImage", SetChildrenWidgetByName_SImage_IsValid);
		ClearCacheSlateBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearCacheSlateBrush");
		ClearCacheSlateBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearCacheSlateBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearCacheSlateBrush_TargetUserWidget_PropertyAddress, ClearCacheSlateBrush_FunctionAddress, "TargetUserWidget");
		ClearCacheSlateBrush_TargetUserWidget_Offset = NativeReflectionCached.GetPropertyOffset(ClearCacheSlateBrush_FunctionAddress, "TargetUserWidget");
		ClearCacheSlateBrush_TargetUserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearCacheSlateBrush_FunctionAddress, "TargetUserWidget", Classes.FObjectProperty);
		ClearCacheSlateBrush_IsValid = ClearCacheSlateBrush_FunctionAddress != IntPtr.Zero && ClearCacheSlateBrush_TargetUserWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSSlateUtils.GSSlateUtilsBPLibrary:ClearCacheSlateBrush", ClearCacheSlateBrush_IsValid);
	}
}
