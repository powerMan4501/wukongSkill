using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.GSAkAudioLibrary", "AkAudio", UnrealModuleType.GamePlugin)]
public class UGSAkAudioLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetAkGameObjects_IsValid;

	private static IntPtr GetAkGameObjects_FunctionAddress;

	private static int GetAkGameObjects_ParamsSize;

	private static bool GetAkGameObjects_InWorldContext_IsValid;

	private static FFieldAddress GetAkGameObjects_InWorldContext_PropertyAddress;

	private static int GetAkGameObjects_InWorldContext_Offset;

	private static bool GetAkGameObjects_ShowDebugDurationTime_IsValid;

	private static FFieldAddress GetAkGameObjects_ShowDebugDurationTime_PropertyAddress;

	private static int GetAkGameObjects_ShowDebugDurationTime_Offset;

	private static bool GetActiveAkGameObjects_IsValid;

	private static IntPtr GetActiveAkGameObjects_FunctionAddress;

	private static int GetActiveAkGameObjects_ParamsSize;

	private static bool GetActiveAkGameObjects_OutGameObjectInfos_IsValid;

	private static FFieldAddress GetActiveAkGameObjects_OutGameObjectInfos_PropertyAddress;

	private static int GetActiveAkGameObjects_OutGameObjectInfos_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.GSAkAudioLibrary:GetAkGameObjects")]
	public unsafe static void GetAkGameObjects(UObject InWorldContext, float ShowDebugDurationTime = 2f)
	{
		if (!GetAkGameObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.GSAkAudioLibrary:GetAkGameObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkGameObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkGameObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAkGameObjects_InWorldContext_Offset), 0, GetAkGameObjects_InWorldContext_PropertyAddress.Address, InWorldContext);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAkGameObjects_ShowDebugDurationTime_Offset), 0, GetAkGameObjects_ShowDebugDurationTime_PropertyAddress.Address, ShowDebugDurationTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAkGameObjects_FunctionAddress, intPtr, GetAkGameObjects_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.GSAkAudioLibrary:GetActiveAkGameObjects")]
	public unsafe static void GetActiveAkGameObjects(out List<FAkGameObjectDebugInfo> OutGameObjectInfos)
	{
		if (!GetActiveAkGameObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.GSAkAudioLibrary:GetActiveAkGameObjects");
			OutGameObjectInfos = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveAkGameObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveAkGameObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActiveAkGameObjects_FunctionAddress, intPtr, GetActiveAkGameObjects_ParamsSize);
		OutGameObjectInfos = new TArrayCopyMarshaler<FAkGameObjectDebugInfo>(1, GetActiveAkGameObjects_OutGameObjectInfos_PropertyAddress, CachedMarshalingDelegates<FAkGameObjectDebugInfo, FAkGameObjectDebugInfo>.FromNative, CachedMarshalingDelegates<FAkGameObjectDebugInfo, FAkGameObjectDebugInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetActiveAkGameObjects_OutGameObjectInfos_Offset));
		NativeReflection.DestroyValue_InContainer(GetActiveAkGameObjects_OutGameObjectInfos_PropertyAddress.Address, intPtr);
	}

	static UGSAkAudioLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSAkAudioLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSAkAudioLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.GSAkAudioLibrary");
		GetAkGameObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAkGameObjects");
		GetAkGameObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkGameObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkGameObjects_InWorldContext_PropertyAddress, GetAkGameObjects_FunctionAddress, "InWorldContext");
		GetAkGameObjects_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetAkGameObjects_FunctionAddress, "InWorldContext");
		GetAkGameObjects_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkGameObjects_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkGameObjects_ShowDebugDurationTime_PropertyAddress, GetAkGameObjects_FunctionAddress, "ShowDebugDurationTime");
		GetAkGameObjects_ShowDebugDurationTime_Offset = NativeReflectionCached.GetPropertyOffset(GetAkGameObjects_FunctionAddress, "ShowDebugDurationTime");
		GetAkGameObjects_ShowDebugDurationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkGameObjects_FunctionAddress, "ShowDebugDurationTime", Classes.FFloatProperty);
		GetAkGameObjects_IsValid = GetAkGameObjects_FunctionAddress != IntPtr.Zero && GetAkGameObjects_InWorldContext_IsValid && GetAkGameObjects_ShowDebugDurationTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.GSAkAudioLibrary:GetAkGameObjects", GetAkGameObjects_IsValid);
		GetActiveAkGameObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActiveAkGameObjects");
		GetActiveAkGameObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveAkGameObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveAkGameObjects_OutGameObjectInfos_PropertyAddress, GetActiveAkGameObjects_FunctionAddress, "OutGameObjectInfos");
		GetActiveAkGameObjects_OutGameObjectInfos_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveAkGameObjects_FunctionAddress, "OutGameObjectInfos");
		GetActiveAkGameObjects_OutGameObjectInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveAkGameObjects_FunctionAddress, "OutGameObjectInfos", Classes.FArrayProperty);
		GetActiveAkGameObjects_IsValid = GetActiveAkGameObjects_FunctionAddress != IntPtr.Zero && GetActiveAkGameObjects_OutGameObjectInfos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.GSAkAudioLibrary:GetActiveAkGameObjects", GetActiveAkGameObjects_IsValid);
	}
}
