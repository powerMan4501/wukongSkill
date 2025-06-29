using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWAssetLoader", "b1", UnrealModuleType.Game)]
public class UBGWAssetLoader : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SyncLoadObjects_IsValid;

	private static IntPtr SyncLoadObjects_FunctionAddress;

	private static int SyncLoadObjects_ParamsSize;

	private static bool SyncLoadObjects_LoadList_IsValid;

	private static FFieldAddress SyncLoadObjects_LoadList_PropertyAddress;

	private static int SyncLoadObjects_LoadList_Offset;

	private static bool SyncLoadObjects_outObjList_IsValid;

	private static FFieldAddress SyncLoadObjects_outObjList_PropertyAddress;

	private static int SyncLoadObjects_outObjList_Offset;

	private static bool SyncLoadObjects_ReturnValue_IsValid;

	private static FFieldAddress SyncLoadObjects_ReturnValue_PropertyAddress;

	private static int SyncLoadObjects_ReturnValue_Offset;

	private static bool SyncLoadObject_IsValid;

	private static IntPtr SyncLoadObject_FunctionAddress;

	private static int SyncLoadObject_ParamsSize;

	private static bool SyncLoadObject_path_IsValid;

	private static FFieldAddress SyncLoadObject_path_PropertyAddress;

	private static int SyncLoadObject_path_Offset;

	private static bool SyncLoadObject_ReturnValue_IsValid;

	private static FFieldAddress SyncLoadObject_ReturnValue_PropertyAddress;

	private static int SyncLoadObject_ReturnValue_Offset;

	private static bool AsyncLoadObjects_IsValid;

	private static IntPtr AsyncLoadObjects_FunctionAddress;

	private static int AsyncLoadObjects_ParamsSize;

	private static bool AsyncLoadObjects_LoadList_IsValid;

	private static FFieldAddress AsyncLoadObjects_LoadList_PropertyAddress;

	private static int AsyncLoadObjects_LoadList_Offset;

	private static bool AsyncLoadObjects_request_IsValid;

	private static FFieldAddress AsyncLoadObjects_request_PropertyAddress;

	private static int AsyncLoadObjects_request_Offset;

	private static bool AsyncLoadObjects_Priority_IsValid;

	private static FFieldAddress AsyncLoadObjects_Priority_PropertyAddress;

	private static int AsyncLoadObjects_Priority_Offset;

	private static bool AsyncLoadObject_IsValid;

	private static IntPtr AsyncLoadObject_FunctionAddress;

	private static int AsyncLoadObject_ParamsSize;

	private static bool AsyncLoadObject_LoadPath_IsValid;

	private static FFieldAddress AsyncLoadObject_LoadPath_PropertyAddress;

	private static int AsyncLoadObject_LoadPath_Offset;

	private static bool AsyncLoadObject_request_IsValid;

	private static FFieldAddress AsyncLoadObject_request_PropertyAddress;

	private static int AsyncLoadObject_request_Offset;

	private static bool AsyncLoadObject_Priority_IsValid;

	private static FFieldAddress AsyncLoadObject_Priority_PropertyAddress;

	private static int AsyncLoadObject_Priority_Offset;

	private static bool AsyncLoadClass_IsValid;

	private static IntPtr AsyncLoadClass_FunctionAddress;

	private static int AsyncLoadClass_ParamsSize;

	private static bool AsyncLoadClass_LoadPath_IsValid;

	private static FFieldAddress AsyncLoadClass_LoadPath_PropertyAddress;

	private static int AsyncLoadClass_LoadPath_Offset;

	private static bool AsyncLoadClass_request_IsValid;

	private static FFieldAddress AsyncLoadClass_request_PropertyAddress;

	private static int AsyncLoadClass_request_Offset;

	private static bool AsyncLoadClass_Priority_IsValid;

	private static FFieldAddress AsyncLoadClass_Priority_PropertyAddress;

	private static int AsyncLoadClass_Priority_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGWAssetLoader:SyncLoadObjects")]
	public unsafe static int SyncLoadObjects(List<FSoftObjectPath> LoadList, out List<UObject> outObjList)
	{
		if (!SyncLoadObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoader:SyncLoadObjects");
			outObjList = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncLoadObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncLoadObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSoftObjectPath>(1, SyncLoadObjects_LoadList_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(intPtr, SyncLoadObjects_LoadList_Offset), LoadList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SyncLoadObjects_FunctionAddress, intPtr, SyncLoadObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SyncLoadObjects_LoadList_PropertyAddress.Address, intPtr);
		outObjList = new TArrayCopyMarshaler<UObject>(1, SyncLoadObjects_outObjList_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SyncLoadObjects_outObjList_Offset));
		NativeReflection.DestroyValue_InContainer(SyncLoadObjects_outObjList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SyncLoadObjects_ReturnValue_Offset), 0, SyncLoadObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGWAssetLoader:SyncLoadObject")]
	public unsafe static UObject SyncLoadObject(FSoftObjectPath path)
	{
		if (!SyncLoadObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoader:SyncLoadObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncLoadObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncLoadObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftObjectPath.ToNative(IntPtr.Add(intPtr, SyncLoadObject_path_Offset), 0, SyncLoadObject_path_PropertyAddress.Address, path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SyncLoadObject_FunctionAddress, intPtr, SyncLoadObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SyncLoadObject_path_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, SyncLoadObject_ReturnValue_Offset), 0, SyncLoadObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWAssetLoader:AsyncLoadObjects")]
	public unsafe static void AsyncLoadObjects(List<FSoftObjectPath> LoadList, UBGWAssetLoaderRequest request, int Priority = 0)
	{
		if (!AsyncLoadObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoader:AsyncLoadObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsyncLoadObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsyncLoadObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSoftObjectPath>(1, AsyncLoadObjects_LoadList_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(intPtr, AsyncLoadObjects_LoadList_Offset), LoadList);
		UObjectMarshaler<UBGWAssetLoaderRequest>.ToNative(IntPtr.Add(intPtr, AsyncLoadObjects_request_Offset), 0, AsyncLoadObjects_request_PropertyAddress.Address, request);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsyncLoadObjects_Priority_Offset), 0, AsyncLoadObjects_Priority_PropertyAddress.Address, Priority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsyncLoadObjects_FunctionAddress, intPtr, AsyncLoadObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsyncLoadObjects_LoadList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGWAssetLoader:AsyncLoadObject")]
	public unsafe static void AsyncLoadObject(FSoftObjectPath LoadPath, UBGWAssetLoaderRequest request, int Priority = 0)
	{
		if (!AsyncLoadObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoader:AsyncLoadObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsyncLoadObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsyncLoadObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftObjectPath.ToNative(IntPtr.Add(intPtr, AsyncLoadObject_LoadPath_Offset), 0, AsyncLoadObject_LoadPath_PropertyAddress.Address, LoadPath);
		UObjectMarshaler<UBGWAssetLoaderRequest>.ToNative(IntPtr.Add(intPtr, AsyncLoadObject_request_Offset), 0, AsyncLoadObject_request_PropertyAddress.Address, request);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsyncLoadObject_Priority_Offset), 0, AsyncLoadObject_Priority_PropertyAddress.Address, Priority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsyncLoadObject_FunctionAddress, intPtr, AsyncLoadObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsyncLoadObject_LoadPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGWAssetLoader:AsyncLoadClass")]
	public unsafe static void AsyncLoadClass(FSoftClassPath LoadPath, UBGWAssetLoaderRequest request, int Priority = 0)
	{
		if (!AsyncLoadClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoader:AsyncLoadClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsyncLoadClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsyncLoadClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftClassPath.ToNative(IntPtr.Add(intPtr, AsyncLoadClass_LoadPath_Offset), 0, AsyncLoadClass_LoadPath_PropertyAddress.Address, LoadPath);
		UObjectMarshaler<UBGWAssetLoaderRequest>.ToNative(IntPtr.Add(intPtr, AsyncLoadClass_request_Offset), 0, AsyncLoadClass_request_PropertyAddress.Address, request);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsyncLoadClass_Priority_Offset), 0, AsyncLoadClass_Priority_PropertyAddress.Address, Priority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsyncLoadClass_FunctionAddress, intPtr, AsyncLoadClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsyncLoadClass_LoadPath_PropertyAddress.Address, intPtr);
	}

	static UBGWAssetLoader()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWAssetLoader)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWAssetLoader));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWAssetLoader");
		SyncLoadObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SyncLoadObjects");
		SyncLoadObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncLoadObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObjects_LoadList_PropertyAddress, SyncLoadObjects_FunctionAddress, "LoadList");
		SyncLoadObjects_LoadList_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObjects_FunctionAddress, "LoadList");
		SyncLoadObjects_LoadList_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObjects_FunctionAddress, "LoadList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObjects_outObjList_PropertyAddress, SyncLoadObjects_FunctionAddress, "outObjList");
		SyncLoadObjects_outObjList_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObjects_FunctionAddress, "outObjList");
		SyncLoadObjects_outObjList_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObjects_FunctionAddress, "outObjList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObjects_ReturnValue_PropertyAddress, SyncLoadObjects_FunctionAddress, "ReturnValue");
		SyncLoadObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObjects_FunctionAddress, "ReturnValue");
		SyncLoadObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObjects_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SyncLoadObjects_IsValid = SyncLoadObjects_FunctionAddress != IntPtr.Zero && SyncLoadObjects_LoadList_IsValid && SyncLoadObjects_outObjList_IsValid && SyncLoadObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoader:SyncLoadObjects", SyncLoadObjects_IsValid);
		SyncLoadObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SyncLoadObject");
		SyncLoadObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncLoadObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObject_path_PropertyAddress, SyncLoadObject_FunctionAddress, "path");
		SyncLoadObject_path_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObject_FunctionAddress, "path");
		SyncLoadObject_path_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObject_FunctionAddress, "path", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObject_ReturnValue_PropertyAddress, SyncLoadObject_FunctionAddress, "ReturnValue");
		SyncLoadObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObject_FunctionAddress, "ReturnValue");
		SyncLoadObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SyncLoadObject_IsValid = SyncLoadObject_FunctionAddress != IntPtr.Zero && SyncLoadObject_path_IsValid && SyncLoadObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoader:SyncLoadObject", SyncLoadObject_IsValid);
		AsyncLoadObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsyncLoadObjects");
		AsyncLoadObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(AsyncLoadObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadObjects_LoadList_PropertyAddress, AsyncLoadObjects_FunctionAddress, "LoadList");
		AsyncLoadObjects_LoadList_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadObjects_FunctionAddress, "LoadList");
		AsyncLoadObjects_LoadList_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadObjects_FunctionAddress, "LoadList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadObjects_request_PropertyAddress, AsyncLoadObjects_FunctionAddress, "request");
		AsyncLoadObjects_request_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadObjects_FunctionAddress, "request");
		AsyncLoadObjects_request_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadObjects_FunctionAddress, "request", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadObjects_Priority_PropertyAddress, AsyncLoadObjects_FunctionAddress, "Priority");
		AsyncLoadObjects_Priority_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadObjects_FunctionAddress, "Priority");
		AsyncLoadObjects_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadObjects_FunctionAddress, "Priority", Classes.FIntProperty);
		AsyncLoadObjects_IsValid = AsyncLoadObjects_FunctionAddress != IntPtr.Zero && AsyncLoadObjects_LoadList_IsValid && AsyncLoadObjects_request_IsValid && AsyncLoadObjects_Priority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoader:AsyncLoadObjects", AsyncLoadObjects_IsValid);
		AsyncLoadObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsyncLoadObject");
		AsyncLoadObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AsyncLoadObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadObject_LoadPath_PropertyAddress, AsyncLoadObject_FunctionAddress, "LoadPath");
		AsyncLoadObject_LoadPath_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadObject_FunctionAddress, "LoadPath");
		AsyncLoadObject_LoadPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadObject_FunctionAddress, "LoadPath", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadObject_request_PropertyAddress, AsyncLoadObject_FunctionAddress, "request");
		AsyncLoadObject_request_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadObject_FunctionAddress, "request");
		AsyncLoadObject_request_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadObject_FunctionAddress, "request", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadObject_Priority_PropertyAddress, AsyncLoadObject_FunctionAddress, "Priority");
		AsyncLoadObject_Priority_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadObject_FunctionAddress, "Priority");
		AsyncLoadObject_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadObject_FunctionAddress, "Priority", Classes.FIntProperty);
		AsyncLoadObject_IsValid = AsyncLoadObject_FunctionAddress != IntPtr.Zero && AsyncLoadObject_LoadPath_IsValid && AsyncLoadObject_request_IsValid && AsyncLoadObject_Priority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoader:AsyncLoadObject", AsyncLoadObject_IsValid);
		AsyncLoadClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsyncLoadClass");
		AsyncLoadClass_ParamsSize = NativeReflection.GetFunctionParamsSize(AsyncLoadClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadClass_LoadPath_PropertyAddress, AsyncLoadClass_FunctionAddress, "LoadPath");
		AsyncLoadClass_LoadPath_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadClass_FunctionAddress, "LoadPath");
		AsyncLoadClass_LoadPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadClass_FunctionAddress, "LoadPath", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadClass_request_PropertyAddress, AsyncLoadClass_FunctionAddress, "request");
		AsyncLoadClass_request_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadClass_FunctionAddress, "request");
		AsyncLoadClass_request_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadClass_FunctionAddress, "request", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncLoadClass_Priority_PropertyAddress, AsyncLoadClass_FunctionAddress, "Priority");
		AsyncLoadClass_Priority_Offset = NativeReflectionCached.GetPropertyOffset(AsyncLoadClass_FunctionAddress, "Priority");
		AsyncLoadClass_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncLoadClass_FunctionAddress, "Priority", Classes.FIntProperty);
		AsyncLoadClass_IsValid = AsyncLoadClass_FunctionAddress != IntPtr.Zero && AsyncLoadClass_LoadPath_IsValid && AsyncLoadClass_request_IsValid && AsyncLoadClass_Priority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoader:AsyncLoadClass", AsyncLoadClass_IsValid);
	}
}
