using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorSceneCaptureLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetSceneCaptureComponentShowOnlyActors_IsValid;

	private static IntPtr SetSceneCaptureComponentShowOnlyActors_FunctionAddress;

	private static int SetSceneCaptureComponentShowOnlyActors_ParamsSize;

	private static bool SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_IsValid;

	private static FFieldAddress SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_PropertyAddress;

	private static int SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_Offset;

	private static bool SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_IsValid;

	private static FFieldAddress SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_PropertyAddress;

	private static int SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_Offset;

	private static bool SetSceneCaptureComponentShowOnlyActors_ReturnValue_IsValid;

	private static FFieldAddress SetSceneCaptureComponentShowOnlyActors_ReturnValue_PropertyAddress;

	private static int SetSceneCaptureComponentShowOnlyActors_ReturnValue_Offset;

	private static bool SetSceneCaptureComponentHiddenActors_IsValid;

	private static IntPtr SetSceneCaptureComponentHiddenActors_FunctionAddress;

	private static int SetSceneCaptureComponentHiddenActors_ParamsSize;

	private static bool SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_IsValid;

	private static FFieldAddress SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_PropertyAddress;

	private static int SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_Offset;

	private static bool SetSceneCaptureComponentHiddenActors_InHiddenActors_IsValid;

	private static FFieldAddress SetSceneCaptureComponentHiddenActors_InHiddenActors_PropertyAddress;

	private static int SetSceneCaptureComponentHiddenActors_InHiddenActors_Offset;

	private static bool SetSceneCaptureComponentHiddenActors_ReturnValue_IsValid;

	private static FFieldAddress SetSceneCaptureComponentHiddenActors_ReturnValue_PropertyAddress;

	private static int SetSceneCaptureComponentHiddenActors_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary:SetSceneCaptureComponentShowOnlyActors")]
	public unsafe static bool SetSceneCaptureComponentShowOnlyActors(USceneCaptureComponent InSceneCaptureCaptureComponent, List<AActor> InShowOnlyActors)
	{
		if (!SetSceneCaptureComponentShowOnlyActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary:SetSceneCaptureComponentShowOnlyActors");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSceneCaptureComponentShowOnlyActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSceneCaptureComponentShowOnlyActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneCaptureComponent>.ToNative(IntPtr.Add(intPtr, SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_Offset), 0, SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_PropertyAddress.Address, InSceneCaptureCaptureComponent);
		new TArrayCopyMarshaler<AActor>(1, SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_Offset), InShowOnlyActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSceneCaptureComponentShowOnlyActors_FunctionAddress, intPtr, SetSceneCaptureComponentShowOnlyActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSceneCaptureComponentShowOnlyActors_ReturnValue_Offset), 0, SetSceneCaptureComponentShowOnlyActors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary:SetSceneCaptureComponentHiddenActors")]
	public unsafe static bool SetSceneCaptureComponentHiddenActors(USceneCaptureComponent InSceneCaptureCaptureComponent, List<AActor> InHiddenActors)
	{
		if (!SetSceneCaptureComponentHiddenActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary:SetSceneCaptureComponentHiddenActors");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSceneCaptureComponentHiddenActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSceneCaptureComponentHiddenActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneCaptureComponent>.ToNative(IntPtr.Add(intPtr, SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_Offset), 0, SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_PropertyAddress.Address, InSceneCaptureCaptureComponent);
		new TArrayCopyMarshaler<AActor>(1, SetSceneCaptureComponentHiddenActors_InHiddenActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSceneCaptureComponentHiddenActors_InHiddenActors_Offset), InHiddenActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSceneCaptureComponentHiddenActors_FunctionAddress, intPtr, SetSceneCaptureComponentHiddenActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSceneCaptureComponentHiddenActors_InHiddenActors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSceneCaptureComponentHiddenActors_ReturnValue_Offset), 0, SetSceneCaptureComponentHiddenActors_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorSceneCaptureLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorSceneCaptureLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorSceneCaptureLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary");
		SetSceneCaptureComponentShowOnlyActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSceneCaptureComponentShowOnlyActors");
		SetSceneCaptureComponentShowOnlyActors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSceneCaptureComponentShowOnlyActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_PropertyAddress, SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "InSceneCaptureCaptureComponent");
		SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "InSceneCaptureCaptureComponent");
		SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "InSceneCaptureCaptureComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_PropertyAddress, SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "InShowOnlyActors");
		SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "InShowOnlyActors");
		SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "InShowOnlyActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSceneCaptureComponentShowOnlyActors_ReturnValue_PropertyAddress, SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "ReturnValue");
		SetSceneCaptureComponentShowOnlyActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "ReturnValue");
		SetSceneCaptureComponentShowOnlyActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneCaptureComponentShowOnlyActors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSceneCaptureComponentShowOnlyActors_IsValid = SetSceneCaptureComponentShowOnlyActors_FunctionAddress != IntPtr.Zero && SetSceneCaptureComponentShowOnlyActors_InSceneCaptureCaptureComponent_IsValid && SetSceneCaptureComponentShowOnlyActors_InShowOnlyActors_IsValid && SetSceneCaptureComponentShowOnlyActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary:SetSceneCaptureComponentShowOnlyActors", SetSceneCaptureComponentShowOnlyActors_IsValid);
		SetSceneCaptureComponentHiddenActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSceneCaptureComponentHiddenActors");
		SetSceneCaptureComponentHiddenActors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSceneCaptureComponentHiddenActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_PropertyAddress, SetSceneCaptureComponentHiddenActors_FunctionAddress, "InSceneCaptureCaptureComponent");
		SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneCaptureComponentHiddenActors_FunctionAddress, "InSceneCaptureCaptureComponent");
		SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneCaptureComponentHiddenActors_FunctionAddress, "InSceneCaptureCaptureComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSceneCaptureComponentHiddenActors_InHiddenActors_PropertyAddress, SetSceneCaptureComponentHiddenActors_FunctionAddress, "InHiddenActors");
		SetSceneCaptureComponentHiddenActors_InHiddenActors_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneCaptureComponentHiddenActors_FunctionAddress, "InHiddenActors");
		SetSceneCaptureComponentHiddenActors_InHiddenActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneCaptureComponentHiddenActors_FunctionAddress, "InHiddenActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSceneCaptureComponentHiddenActors_ReturnValue_PropertyAddress, SetSceneCaptureComponentHiddenActors_FunctionAddress, "ReturnValue");
		SetSceneCaptureComponentHiddenActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneCaptureComponentHiddenActors_FunctionAddress, "ReturnValue");
		SetSceneCaptureComponentHiddenActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneCaptureComponentHiddenActors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSceneCaptureComponentHiddenActors_IsValid = SetSceneCaptureComponentHiddenActors_FunctionAddress != IntPtr.Zero && SetSceneCaptureComponentHiddenActors_InSceneCaptureCaptureComponent_IsValid && SetSceneCaptureComponentHiddenActors_InHiddenActors_IsValid && SetSceneCaptureComponentHiddenActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSceneCaptureLibrary:SetSceneCaptureComponentHiddenActors", SetSceneCaptureComponentHiddenActors_IsValid);
	}
}
