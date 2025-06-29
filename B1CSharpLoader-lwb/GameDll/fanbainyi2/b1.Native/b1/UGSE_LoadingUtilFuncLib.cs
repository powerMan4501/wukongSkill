using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_LoadingUtilFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_LoadingUtilFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SyncLoadObject_IsValid;

	private static IntPtr SyncLoadObject_FunctionAddress;

	private static int SyncLoadObject_ParamsSize;

	private static bool SyncLoadObject_Path_IsValid;

	private static FFieldAddress SyncLoadObject_Path_PropertyAddress;

	private static int SyncLoadObject_Path_Offset;

	private static bool SyncLoadObject_ReturnValue_IsValid;

	private static FFieldAddress SyncLoadObject_ReturnValue_PropertyAddress;

	private static int SyncLoadObject_ReturnValue_Offset;

	private static bool ClientSetBlockOnAsyncLoading_IsValid;

	private static IntPtr ClientSetBlockOnAsyncLoading_FunctionAddress;

	private static int ClientSetBlockOnAsyncLoading_ParamsSize;

	private static bool ClientSetBlockOnAsyncLoading_PlayerController_IsValid;

	private static FFieldAddress ClientSetBlockOnAsyncLoading_PlayerController_PropertyAddress;

	private static int ClientSetBlockOnAsyncLoading_PlayerController_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LoadingUtilFuncLib:SyncLoadObject")]
	public unsafe static UObject SyncLoadObject(string Path)
	{
		if (!SyncLoadObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LoadingUtilFuncLib:SyncLoadObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncLoadObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncLoadObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SyncLoadObject_Path_Offset), 0, SyncLoadObject_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SyncLoadObject_FunctionAddress, intPtr, SyncLoadObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SyncLoadObject_Path_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, SyncLoadObject_ReturnValue_Offset), 0, SyncLoadObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LoadingUtilFuncLib:ClientSetBlockOnAsyncLoading")]
	public unsafe static void ClientSetBlockOnAsyncLoading(APlayerController PlayerController)
	{
		if (!ClientSetBlockOnAsyncLoading_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LoadingUtilFuncLib:ClientSetBlockOnAsyncLoading");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientSetBlockOnAsyncLoading_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientSetBlockOnAsyncLoading_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ClientSetBlockOnAsyncLoading_PlayerController_Offset), 0, ClientSetBlockOnAsyncLoading_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClientSetBlockOnAsyncLoading_FunctionAddress, intPtr, ClientSetBlockOnAsyncLoading_ParamsSize);
	}

	static UGSE_LoadingUtilFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_LoadingUtilFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_LoadingUtilFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_LoadingUtilFuncLib");
		SyncLoadObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SyncLoadObject");
		SyncLoadObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncLoadObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObject_Path_PropertyAddress, SyncLoadObject_FunctionAddress, "Path");
		SyncLoadObject_Path_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObject_FunctionAddress, "Path");
		SyncLoadObject_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObject_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SyncLoadObject_ReturnValue_PropertyAddress, SyncLoadObject_FunctionAddress, "ReturnValue");
		SyncLoadObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SyncLoadObject_FunctionAddress, "ReturnValue");
		SyncLoadObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncLoadObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SyncLoadObject_IsValid = SyncLoadObject_FunctionAddress != IntPtr.Zero && SyncLoadObject_Path_IsValid && SyncLoadObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LoadingUtilFuncLib:SyncLoadObject", SyncLoadObject_IsValid);
		ClientSetBlockOnAsyncLoading_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClientSetBlockOnAsyncLoading");
		ClientSetBlockOnAsyncLoading_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientSetBlockOnAsyncLoading_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientSetBlockOnAsyncLoading_PlayerController_PropertyAddress, ClientSetBlockOnAsyncLoading_FunctionAddress, "PlayerController");
		ClientSetBlockOnAsyncLoading_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ClientSetBlockOnAsyncLoading_FunctionAddress, "PlayerController");
		ClientSetBlockOnAsyncLoading_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientSetBlockOnAsyncLoading_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		ClientSetBlockOnAsyncLoading_IsValid = ClientSetBlockOnAsyncLoading_FunctionAddress != IntPtr.Zero && ClientSetBlockOnAsyncLoading_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LoadingUtilFuncLib:ClientSetBlockOnAsyncLoading", ClientSetBlockOnAsyncLoading_IsValid);
	}
}
