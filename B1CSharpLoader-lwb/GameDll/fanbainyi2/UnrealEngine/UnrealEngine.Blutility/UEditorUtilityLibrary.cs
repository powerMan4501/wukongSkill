using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Blutility.EditorUtilityLibrary", "Blutility", UnrealModuleType.Engine)]
public class UEditorUtilityLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RenameAsset_IsValid;

	private static IntPtr RenameAsset_FunctionAddress;

	private static int RenameAsset_ParamsSize;

	private static bool RenameAsset_Asset_IsValid;

	private static FFieldAddress RenameAsset_Asset_PropertyAddress;

	private static int RenameAsset_Asset_Offset;

	private static bool RenameAsset_NewName_IsValid;

	private static FFieldAddress RenameAsset_NewName_PropertyAddress;

	private static int RenameAsset_NewName_Offset;

	private static bool GetSelectionSet_IsValid;

	private static IntPtr GetSelectionSet_FunctionAddress;

	private static int GetSelectionSet_ParamsSize;

	private static bool GetSelectionSet_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionSet_ReturnValue_PropertyAddress;

	private static int GetSelectionSet_ReturnValue_Offset;

	private static bool GetSelectionBounds_IsValid;

	private static IntPtr GetSelectionBounds_FunctionAddress;

	private static int GetSelectionBounds_ParamsSize;

	private static bool GetSelectionBounds_Origin_IsValid;

	private static FFieldAddress GetSelectionBounds_Origin_PropertyAddress;

	private static int GetSelectionBounds_Origin_Offset;

	private static bool GetSelectionBounds_BoxExtent_IsValid;

	private static FFieldAddress GetSelectionBounds_BoxExtent_PropertyAddress;

	private static int GetSelectionBounds_BoxExtent_Offset;

	private static bool GetSelectionBounds_SphereRadius_IsValid;

	private static FFieldAddress GetSelectionBounds_SphereRadius_PropertyAddress;

	private static int GetSelectionBounds_SphereRadius_Offset;

	private static bool GetSelectedBlueprintClasses_IsValid;

	private static IntPtr GetSelectedBlueprintClasses_FunctionAddress;

	private static int GetSelectedBlueprintClasses_ParamsSize;

	private static bool GetSelectedBlueprintClasses_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedBlueprintClasses_ReturnValue_PropertyAddress;

	private static int GetSelectedBlueprintClasses_ReturnValue_Offset;

	private static bool GetSelectedAssets_IsValid;

	private static IntPtr GetSelectedAssets_FunctionAddress;

	private static int GetSelectedAssets_ParamsSize;

	private static bool GetSelectedAssets_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedAssets_ReturnValue_PropertyAddress;

	private static int GetSelectedAssets_ReturnValue_Offset;

	private static bool GetSelectedAssetData_IsValid;

	private static IntPtr GetSelectedAssetData_FunctionAddress;

	private static int GetSelectedAssetData_ParamsSize;

	private static bool GetSelectedAssetData_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedAssetData_ReturnValue_PropertyAddress;

	private static int GetSelectedAssetData_ReturnValue_Offset;

	private static bool GetCurrentContentBrowserPath_IsValid;

	private static IntPtr GetCurrentContentBrowserPath_FunctionAddress;

	private static int GetCurrentContentBrowserPath_ParamsSize;

	private static bool GetCurrentContentBrowserPath_OutPath_IsValid;

	private static FFieldAddress GetCurrentContentBrowserPath_OutPath_PropertyAddress;

	private static int GetCurrentContentBrowserPath_OutPath_Offset;

	private static bool GetCurrentContentBrowserPath_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentContentBrowserPath_ReturnValue_PropertyAddress;

	private static int GetCurrentContentBrowserPath_ReturnValue_Offset;

	private static bool GetActorReference_IsValid;

	private static IntPtr GetActorReference_FunctionAddress;

	private static int GetActorReference_ParamsSize;

	private static bool GetActorReference_PathToActor_IsValid;

	private static FFieldAddress GetActorReference_PathToActor_PropertyAddress;

	private static int GetActorReference_PathToActor_Offset;

	private static bool GetActorReference_ReturnValue_IsValid;

	private static FFieldAddress GetActorReference_ReturnValue_PropertyAddress;

	private static int GetActorReference_ReturnValue_Offset;

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:RenameAsset")]
	public unsafe static void RenameAsset(UObject Asset, string NewName)
	{
		if (!RenameAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:RenameAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RenameAsset_Asset_Offset), 0, RenameAsset_Asset_PropertyAddress.Address, Asset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameAsset_NewName_Offset), 0, RenameAsset_NewName_PropertyAddress.Address, NewName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameAsset_FunctionAddress, intPtr, RenameAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameAsset_NewName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetSelectionSet")]
	public unsafe static List<AActor> GetSelectionSet()
	{
		if (!GetSelectionSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetSelectionSet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectionSet_FunctionAddress, intPtr, GetSelectionSet_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetSelectionSet_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectionSet_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectionSet_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 616702977u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetSelectionBounds")]
	public unsafe static void GetSelectionBounds(out FVector Origin, out FVector BoxExtent, out float SphereRadius)
	{
		if (!GetSelectionBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetSelectionBounds");
			Origin = default(FVector);
			BoxExtent = default(FVector);
			SphereRadius = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectionBounds_FunctionAddress, intPtr, GetSelectionBounds_ParamsSize);
		Origin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSelectionBounds_Origin_Offset), 0, GetSelectionBounds_Origin_PropertyAddress.Address);
		BoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSelectionBounds_BoxExtent_Offset), 0, GetSelectionBounds_BoxExtent_PropertyAddress.Address);
		SphereRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSelectionBounds_SphereRadius_Offset), 0, GetSelectionBounds_SphereRadius_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetSelectedBlueprintClasses")]
	public unsafe static List<TSubclassOf<UObject>> GetSelectedBlueprintClasses()
	{
		if (!GetSelectedBlueprintClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetSelectedBlueprintClasses");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedBlueprintClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedBlueprintClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedBlueprintClasses_FunctionAddress, intPtr, GetSelectedBlueprintClasses_ParamsSize);
		List<TSubclassOf<UObject>> result = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetSelectedBlueprintClasses_ReturnValue_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedBlueprintClasses_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedBlueprintClasses_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetSelectedAssets")]
	public unsafe static List<UObject> GetSelectedAssets()
	{
		if (!GetSelectedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetSelectedAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedAssets_FunctionAddress, intPtr, GetSelectedAssets_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetSelectedAssets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedAssets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedAssets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetSelectedAssetData")]
	public unsafe static List<FAssetData> GetSelectedAssetData()
	{
		if (!GetSelectedAssetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetSelectedAssetData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedAssetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedAssetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedAssetData_FunctionAddress, intPtr, GetSelectedAssetData_ParamsSize);
		List<FAssetData> result = new TArrayCopyMarshaler<FAssetData>(1, GetSelectedAssetData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedAssetData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedAssetData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 876749825u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetCurrentContentBrowserPath")]
	public unsafe static bool GetCurrentContentBrowserPath(out string OutPath)
	{
		if (!GetCurrentContentBrowserPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetCurrentContentBrowserPath");
			OutPath = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentContentBrowserPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentContentBrowserPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentContentBrowserPath_FunctionAddress, intPtr, GetCurrentContentBrowserPath_ParamsSize);
		OutPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentContentBrowserPath_OutPath_Offset), 0, GetCurrentContentBrowserPath_OutPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentContentBrowserPath_OutPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentContentBrowserPath_ReturnValue_Offset), 0, GetCurrentContentBrowserPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 872547329u)]
	[UMetaPath("/Script/Blutility.EditorUtilityLibrary:GetActorReference")]
	public unsafe AActor GetActorReference(string PathToActor)
	{
		CheckDestroyed();
		if (!GetActorReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityLibrary:GetActorReference");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetActorReference_PathToActor_Offset), 0, GetActorReference_PathToActor_PropertyAddress.Address, PathToActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorReference_FunctionAddress, intPtr, GetActorReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetActorReference_PathToActor_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActorReference_ReturnValue_Offset), 0, GetActorReference_ReturnValue_PropertyAddress.Address);
	}

	static UEditorUtilityLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorUtilityLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorUtilityLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Blutility.EditorUtilityLibrary");
		RenameAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameAsset");
		RenameAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameAsset_Asset_PropertyAddress, RenameAsset_FunctionAddress, "Asset");
		RenameAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(RenameAsset_FunctionAddress, "Asset");
		RenameAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAsset_NewName_PropertyAddress, RenameAsset_FunctionAddress, "NewName");
		RenameAsset_NewName_Offset = NativeReflectionCached.GetPropertyOffset(RenameAsset_FunctionAddress, "NewName");
		RenameAsset_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAsset_FunctionAddress, "NewName", Classes.FStrProperty);
		RenameAsset_IsValid = RenameAsset_FunctionAddress != IntPtr.Zero && RenameAsset_Asset_IsValid && RenameAsset_NewName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:RenameAsset", RenameAsset_IsValid);
		GetSelectionSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectionSet");
		GetSelectionSet_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionSet_ReturnValue_PropertyAddress, GetSelectionSet_FunctionAddress, "ReturnValue");
		GetSelectionSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionSet_FunctionAddress, "ReturnValue");
		GetSelectionSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionSet_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectionSet_IsValid = GetSelectionSet_FunctionAddress != IntPtr.Zero && GetSelectionSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetSelectionSet", GetSelectionSet_IsValid);
		GetSelectionBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectionBounds");
		GetSelectionBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionBounds_Origin_PropertyAddress, GetSelectionBounds_FunctionAddress, "Origin");
		GetSelectionBounds_Origin_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionBounds_FunctionAddress, "Origin");
		GetSelectionBounds_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionBounds_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionBounds_BoxExtent_PropertyAddress, GetSelectionBounds_FunctionAddress, "BoxExtent");
		GetSelectionBounds_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionBounds_FunctionAddress, "BoxExtent");
		GetSelectionBounds_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionBounds_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionBounds_SphereRadius_PropertyAddress, GetSelectionBounds_FunctionAddress, "SphereRadius");
		GetSelectionBounds_SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionBounds_FunctionAddress, "SphereRadius");
		GetSelectionBounds_SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionBounds_FunctionAddress, "SphereRadius", Classes.FFloatProperty);
		GetSelectionBounds_IsValid = GetSelectionBounds_FunctionAddress != IntPtr.Zero && GetSelectionBounds_Origin_IsValid && GetSelectionBounds_BoxExtent_IsValid && GetSelectionBounds_SphereRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetSelectionBounds", GetSelectionBounds_IsValid);
		GetSelectedBlueprintClasses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedBlueprintClasses");
		GetSelectedBlueprintClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedBlueprintClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedBlueprintClasses_ReturnValue_PropertyAddress, GetSelectedBlueprintClasses_FunctionAddress, "ReturnValue");
		GetSelectedBlueprintClasses_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedBlueprintClasses_FunctionAddress, "ReturnValue");
		GetSelectedBlueprintClasses_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedBlueprintClasses_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedBlueprintClasses_IsValid = GetSelectedBlueprintClasses_FunctionAddress != IntPtr.Zero && GetSelectedBlueprintClasses_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetSelectedBlueprintClasses", GetSelectedBlueprintClasses_IsValid);
		GetSelectedAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedAssets");
		GetSelectedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedAssets_ReturnValue_PropertyAddress, GetSelectedAssets_FunctionAddress, "ReturnValue");
		GetSelectedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedAssets_FunctionAddress, "ReturnValue");
		GetSelectedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedAssets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedAssets_IsValid = GetSelectedAssets_FunctionAddress != IntPtr.Zero && GetSelectedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetSelectedAssets", GetSelectedAssets_IsValid);
		GetSelectedAssetData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedAssetData");
		GetSelectedAssetData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedAssetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedAssetData_ReturnValue_PropertyAddress, GetSelectedAssetData_FunctionAddress, "ReturnValue");
		GetSelectedAssetData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedAssetData_FunctionAddress, "ReturnValue");
		GetSelectedAssetData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedAssetData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedAssetData_IsValid = GetSelectedAssetData_FunctionAddress != IntPtr.Zero && GetSelectedAssetData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetSelectedAssetData", GetSelectedAssetData_IsValid);
		GetCurrentContentBrowserPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentContentBrowserPath");
		GetCurrentContentBrowserPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentContentBrowserPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentContentBrowserPath_OutPath_PropertyAddress, GetCurrentContentBrowserPath_FunctionAddress, "OutPath");
		GetCurrentContentBrowserPath_OutPath_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentContentBrowserPath_FunctionAddress, "OutPath");
		GetCurrentContentBrowserPath_OutPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentContentBrowserPath_FunctionAddress, "OutPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentContentBrowserPath_ReturnValue_PropertyAddress, GetCurrentContentBrowserPath_FunctionAddress, "ReturnValue");
		GetCurrentContentBrowserPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentContentBrowserPath_FunctionAddress, "ReturnValue");
		GetCurrentContentBrowserPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentContentBrowserPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCurrentContentBrowserPath_IsValid = GetCurrentContentBrowserPath_FunctionAddress != IntPtr.Zero && GetCurrentContentBrowserPath_OutPath_IsValid && GetCurrentContentBrowserPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetCurrentContentBrowserPath", GetCurrentContentBrowserPath_IsValid);
		GetActorReference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorReference");
		GetActorReference_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_PathToActor_PropertyAddress, GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "PathToActor", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_ReturnValue_PropertyAddress, GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorReference_IsValid = GetActorReference_FunctionAddress != IntPtr.Zero && GetActorReference_PathToActor_IsValid && GetActorReference_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityLibrary:GetActorReference", GetActorReference_IsValid);
	}
}
