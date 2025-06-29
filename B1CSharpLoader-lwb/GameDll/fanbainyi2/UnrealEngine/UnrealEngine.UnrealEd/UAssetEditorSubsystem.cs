using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealEd.AssetEditorSubsystem", "UnrealEd", UnrealModuleType.Engine)]
public class UAssetEditorSubsystem : UEditorSubsystem
{
	private static bool OpenEditorForAssets_IsValid;

	private static IntPtr OpenEditorForAssets_FunctionAddress;

	private static int OpenEditorForAssets_ParamsSize;

	private static bool OpenEditorForAssets_Assets_IsValid;

	private static FFieldAddress OpenEditorForAssets_Assets_PropertyAddress;

	private static int OpenEditorForAssets_Assets_Offset;

	private static bool OpenEditorForAssets_ReturnValue_IsValid;

	private static FFieldAddress OpenEditorForAssets_ReturnValue_PropertyAddress;

	private static int OpenEditorForAssets_ReturnValue_Offset;

	private static bool CloseAllEditorsForAsset_IsValid;

	private static IntPtr CloseAllEditorsForAsset_FunctionAddress;

	private static int CloseAllEditorsForAsset_ParamsSize;

	private static bool CloseAllEditorsForAsset_Asset_IsValid;

	private static FFieldAddress CloseAllEditorsForAsset_Asset_PropertyAddress;

	private static int CloseAllEditorsForAsset_Asset_Offset;

	private static bool CloseAllEditorsForAsset_ReturnValue_IsValid;

	private static FFieldAddress CloseAllEditorsForAsset_ReturnValue_PropertyAddress;

	private static int CloseAllEditorsForAsset_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealEd.AssetEditorSubsystem:OpenEditorForAssets")]
	public unsafe bool OpenEditorForAssets(List<UObject> Assets)
	{
		CheckDestroyed();
		if (!OpenEditorForAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.AssetEditorSubsystem:OpenEditorForAssets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenEditorForAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenEditorForAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, OpenEditorForAssets_Assets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OpenEditorForAssets_Assets_Offset), Assets);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenEditorForAssets_FunctionAddress, intPtr, OpenEditorForAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenEditorForAssets_Assets_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenEditorForAssets_ReturnValue_Offset), 0, OpenEditorForAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.AssetEditorSubsystem:CloseAllEditorsForAsset")]
	public unsafe int CloseAllEditorsForAsset(UObject Asset)
	{
		CheckDestroyed();
		if (!CloseAllEditorsForAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.AssetEditorSubsystem:CloseAllEditorsForAsset");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseAllEditorsForAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseAllEditorsForAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CloseAllEditorsForAsset_Asset_Offset), 0, CloseAllEditorsForAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, CloseAllEditorsForAsset_FunctionAddress, intPtr, CloseAllEditorsForAsset_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CloseAllEditorsForAsset_ReturnValue_Offset), 0, CloseAllEditorsForAsset_ReturnValue_PropertyAddress.Address);
	}

	static UAssetEditorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetEditorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetEditorSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealEd.AssetEditorSubsystem");
		OpenEditorForAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OpenEditorForAssets");
		OpenEditorForAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenEditorForAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenEditorForAssets_Assets_PropertyAddress, OpenEditorForAssets_FunctionAddress, "Assets");
		OpenEditorForAssets_Assets_Offset = NativeReflectionCached.GetPropertyOffset(OpenEditorForAssets_FunctionAddress, "Assets");
		OpenEditorForAssets_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenEditorForAssets_FunctionAddress, "Assets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenEditorForAssets_ReturnValue_PropertyAddress, OpenEditorForAssets_FunctionAddress, "ReturnValue");
		OpenEditorForAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenEditorForAssets_FunctionAddress, "ReturnValue");
		OpenEditorForAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenEditorForAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenEditorForAssets_IsValid = OpenEditorForAssets_FunctionAddress != IntPtr.Zero && OpenEditorForAssets_Assets_IsValid && OpenEditorForAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.AssetEditorSubsystem:OpenEditorForAssets", OpenEditorForAssets_IsValid);
		CloseAllEditorsForAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CloseAllEditorsForAsset");
		CloseAllEditorsForAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseAllEditorsForAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseAllEditorsForAsset_Asset_PropertyAddress, CloseAllEditorsForAsset_FunctionAddress, "Asset");
		CloseAllEditorsForAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(CloseAllEditorsForAsset_FunctionAddress, "Asset");
		CloseAllEditorsForAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseAllEditorsForAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseAllEditorsForAsset_ReturnValue_PropertyAddress, CloseAllEditorsForAsset_FunctionAddress, "ReturnValue");
		CloseAllEditorsForAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloseAllEditorsForAsset_FunctionAddress, "ReturnValue");
		CloseAllEditorsForAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseAllEditorsForAsset_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CloseAllEditorsForAsset_IsValid = CloseAllEditorsForAsset_FunctionAddress != IntPtr.Zero && CloseAllEditorsForAsset_Asset_IsValid && CloseAllEditorsForAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.AssetEditorSubsystem:CloseAllEditorsForAsset", CloseAllEditorsForAsset_IsValid);
	}
}
