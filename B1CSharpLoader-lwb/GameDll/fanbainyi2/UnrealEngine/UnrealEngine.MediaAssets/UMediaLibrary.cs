using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/MediaAssets.MediaBlueprintFunctionLibrary", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool EnumerateWebcamCaptureDevices_IsValid;

	private static IntPtr EnumerateWebcamCaptureDevices_FunctionAddress;

	private static int EnumerateWebcamCaptureDevices_ParamsSize;

	private static bool EnumerateWebcamCaptureDevices_OutDevices_IsValid;

	private static FFieldAddress EnumerateWebcamCaptureDevices_OutDevices_PropertyAddress;

	private static int EnumerateWebcamCaptureDevices_OutDevices_Offset;

	private static bool EnumerateWebcamCaptureDevices_Filter_IsValid;

	private static FFieldAddress EnumerateWebcamCaptureDevices_Filter_PropertyAddress;

	private static int EnumerateWebcamCaptureDevices_Filter_Offset;

	private static bool EnumerateVideoCaptureDevices_IsValid;

	private static IntPtr EnumerateVideoCaptureDevices_FunctionAddress;

	private static int EnumerateVideoCaptureDevices_ParamsSize;

	private static bool EnumerateVideoCaptureDevices_OutDevices_IsValid;

	private static FFieldAddress EnumerateVideoCaptureDevices_OutDevices_PropertyAddress;

	private static int EnumerateVideoCaptureDevices_OutDevices_Offset;

	private static bool EnumerateVideoCaptureDevices_Filter_IsValid;

	private static FFieldAddress EnumerateVideoCaptureDevices_Filter_PropertyAddress;

	private static int EnumerateVideoCaptureDevices_Filter_Offset;

	private static bool EnumerateAudioCaptureDevices_IsValid;

	private static IntPtr EnumerateAudioCaptureDevices_FunctionAddress;

	private static int EnumerateAudioCaptureDevices_ParamsSize;

	private static bool EnumerateAudioCaptureDevices_OutDevices_IsValid;

	private static FFieldAddress EnumerateAudioCaptureDevices_OutDevices_PropertyAddress;

	private static int EnumerateAudioCaptureDevices_OutDevices_Offset;

	private static bool EnumerateAudioCaptureDevices_Filter_IsValid;

	private static FFieldAddress EnumerateAudioCaptureDevices_Filter_PropertyAddress;

	private static int EnumerateAudioCaptureDevices_Filter_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateWebcamCaptureDevices")]
	public unsafe static void EnumerateWebcamCaptureDevices(out List<FMediaCaptureDevice> OutDevices, int Filter = -1)
	{
		if (!EnumerateWebcamCaptureDevices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateWebcamCaptureDevices");
			OutDevices = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnumerateWebcamCaptureDevices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnumerateWebcamCaptureDevices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnumerateWebcamCaptureDevices_Filter_Offset), 0, EnumerateWebcamCaptureDevices_Filter_PropertyAddress.Address, Filter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnumerateWebcamCaptureDevices_FunctionAddress, intPtr, EnumerateWebcamCaptureDevices_ParamsSize);
		OutDevices = new TArrayCopyMarshaler<FMediaCaptureDevice>(1, EnumerateWebcamCaptureDevices_OutDevices_PropertyAddress, CachedMarshalingDelegates<FMediaCaptureDevice, FMediaCaptureDevice>.FromNative, CachedMarshalingDelegates<FMediaCaptureDevice, FMediaCaptureDevice>.ToNative).FromNative(IntPtr.Add(intPtr, EnumerateWebcamCaptureDevices_OutDevices_Offset));
		NativeReflection.DestroyValue_InContainer(EnumerateWebcamCaptureDevices_OutDevices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateVideoCaptureDevices")]
	public unsafe static void EnumerateVideoCaptureDevices(out List<FMediaCaptureDevice> OutDevices, int Filter = -1)
	{
		if (!EnumerateVideoCaptureDevices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateVideoCaptureDevices");
			OutDevices = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnumerateVideoCaptureDevices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnumerateVideoCaptureDevices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnumerateVideoCaptureDevices_Filter_Offset), 0, EnumerateVideoCaptureDevices_Filter_PropertyAddress.Address, Filter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnumerateVideoCaptureDevices_FunctionAddress, intPtr, EnumerateVideoCaptureDevices_ParamsSize);
		OutDevices = new TArrayCopyMarshaler<FMediaCaptureDevice>(1, EnumerateVideoCaptureDevices_OutDevices_PropertyAddress, CachedMarshalingDelegates<FMediaCaptureDevice, FMediaCaptureDevice>.FromNative, CachedMarshalingDelegates<FMediaCaptureDevice, FMediaCaptureDevice>.ToNative).FromNative(IntPtr.Add(intPtr, EnumerateVideoCaptureDevices_OutDevices_Offset));
		NativeReflection.DestroyValue_InContainer(EnumerateVideoCaptureDevices_OutDevices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateAudioCaptureDevices")]
	public unsafe static void EnumerateAudioCaptureDevices(out List<FMediaCaptureDevice> OutDevices, int Filter = -1)
	{
		if (!EnumerateAudioCaptureDevices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateAudioCaptureDevices");
			OutDevices = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnumerateAudioCaptureDevices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnumerateAudioCaptureDevices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnumerateAudioCaptureDevices_Filter_Offset), 0, EnumerateAudioCaptureDevices_Filter_PropertyAddress.Address, Filter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnumerateAudioCaptureDevices_FunctionAddress, intPtr, EnumerateAudioCaptureDevices_ParamsSize);
		OutDevices = new TArrayCopyMarshaler<FMediaCaptureDevice>(1, EnumerateAudioCaptureDevices_OutDevices_PropertyAddress, CachedMarshalingDelegates<FMediaCaptureDevice, FMediaCaptureDevice>.FromNative, CachedMarshalingDelegates<FMediaCaptureDevice, FMediaCaptureDevice>.ToNative).FromNative(IntPtr.Add(intPtr, EnumerateAudioCaptureDevices_OutDevices_Offset));
		NativeReflection.DestroyValue_InContainer(EnumerateAudioCaptureDevices_OutDevices_PropertyAddress.Address, intPtr);
	}

	static UMediaLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MediaAssets.MediaBlueprintFunctionLibrary");
		EnumerateWebcamCaptureDevices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnumerateWebcamCaptureDevices");
		EnumerateWebcamCaptureDevices_ParamsSize = NativeReflection.GetFunctionParamsSize(EnumerateWebcamCaptureDevices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnumerateWebcamCaptureDevices_OutDevices_PropertyAddress, EnumerateWebcamCaptureDevices_FunctionAddress, "OutDevices");
		EnumerateWebcamCaptureDevices_OutDevices_Offset = NativeReflectionCached.GetPropertyOffset(EnumerateWebcamCaptureDevices_FunctionAddress, "OutDevices");
		EnumerateWebcamCaptureDevices_OutDevices_IsValid = NativeReflectionCached.ValidatePropertyClass(EnumerateWebcamCaptureDevices_FunctionAddress, "OutDevices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnumerateWebcamCaptureDevices_Filter_PropertyAddress, EnumerateWebcamCaptureDevices_FunctionAddress, "Filter");
		EnumerateWebcamCaptureDevices_Filter_Offset = NativeReflectionCached.GetPropertyOffset(EnumerateWebcamCaptureDevices_FunctionAddress, "Filter");
		EnumerateWebcamCaptureDevices_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(EnumerateWebcamCaptureDevices_FunctionAddress, "Filter", Classes.FIntProperty);
		EnumerateWebcamCaptureDevices_IsValid = EnumerateWebcamCaptureDevices_FunctionAddress != IntPtr.Zero && EnumerateWebcamCaptureDevices_OutDevices_IsValid && EnumerateWebcamCaptureDevices_Filter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateWebcamCaptureDevices", EnumerateWebcamCaptureDevices_IsValid);
		EnumerateVideoCaptureDevices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnumerateVideoCaptureDevices");
		EnumerateVideoCaptureDevices_ParamsSize = NativeReflection.GetFunctionParamsSize(EnumerateVideoCaptureDevices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnumerateVideoCaptureDevices_OutDevices_PropertyAddress, EnumerateVideoCaptureDevices_FunctionAddress, "OutDevices");
		EnumerateVideoCaptureDevices_OutDevices_Offset = NativeReflectionCached.GetPropertyOffset(EnumerateVideoCaptureDevices_FunctionAddress, "OutDevices");
		EnumerateVideoCaptureDevices_OutDevices_IsValid = NativeReflectionCached.ValidatePropertyClass(EnumerateVideoCaptureDevices_FunctionAddress, "OutDevices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnumerateVideoCaptureDevices_Filter_PropertyAddress, EnumerateVideoCaptureDevices_FunctionAddress, "Filter");
		EnumerateVideoCaptureDevices_Filter_Offset = NativeReflectionCached.GetPropertyOffset(EnumerateVideoCaptureDevices_FunctionAddress, "Filter");
		EnumerateVideoCaptureDevices_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(EnumerateVideoCaptureDevices_FunctionAddress, "Filter", Classes.FIntProperty);
		EnumerateVideoCaptureDevices_IsValid = EnumerateVideoCaptureDevices_FunctionAddress != IntPtr.Zero && EnumerateVideoCaptureDevices_OutDevices_IsValid && EnumerateVideoCaptureDevices_Filter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateVideoCaptureDevices", EnumerateVideoCaptureDevices_IsValid);
		EnumerateAudioCaptureDevices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnumerateAudioCaptureDevices");
		EnumerateAudioCaptureDevices_ParamsSize = NativeReflection.GetFunctionParamsSize(EnumerateAudioCaptureDevices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnumerateAudioCaptureDevices_OutDevices_PropertyAddress, EnumerateAudioCaptureDevices_FunctionAddress, "OutDevices");
		EnumerateAudioCaptureDevices_OutDevices_Offset = NativeReflectionCached.GetPropertyOffset(EnumerateAudioCaptureDevices_FunctionAddress, "OutDevices");
		EnumerateAudioCaptureDevices_OutDevices_IsValid = NativeReflectionCached.ValidatePropertyClass(EnumerateAudioCaptureDevices_FunctionAddress, "OutDevices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnumerateAudioCaptureDevices_Filter_PropertyAddress, EnumerateAudioCaptureDevices_FunctionAddress, "Filter");
		EnumerateAudioCaptureDevices_Filter_Offset = NativeReflectionCached.GetPropertyOffset(EnumerateAudioCaptureDevices_FunctionAddress, "Filter");
		EnumerateAudioCaptureDevices_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(EnumerateAudioCaptureDevices_FunctionAddress, "Filter", Classes.FIntProperty);
		EnumerateAudioCaptureDevices_IsValid = EnumerateAudioCaptureDevices_FunctionAddress != IntPtr.Zero && EnumerateAudioCaptureDevices_OutDevices_IsValid && EnumerateAudioCaptureDevices_Filter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaBlueprintFunctionLibrary:EnumerateAudioCaptureDevices", EnumerateAudioCaptureDevices_IsValid);
	}
}
