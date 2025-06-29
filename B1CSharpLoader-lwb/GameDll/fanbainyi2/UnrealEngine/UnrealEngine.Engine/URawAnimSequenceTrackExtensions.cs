using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.RawAnimSequenceTrackExtensions", "Engine", UnrealModuleType.Engine)]
public class URawAnimSequenceTrackExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetScaleKeys_IsValid;

	private static IntPtr GetScaleKeys_FunctionAddress;

	private static int GetScaleKeys_ParamsSize;

	private static bool GetScaleKeys_Track_IsValid;

	private static FFieldAddress GetScaleKeys_Track_PropertyAddress;

	private static int GetScaleKeys_Track_Offset;

	private static bool GetScaleKeys_ReturnValue_IsValid;

	private static FFieldAddress GetScaleKeys_ReturnValue_PropertyAddress;

	private static int GetScaleKeys_ReturnValue_Offset;

	private static bool GetRotationalKeys_IsValid;

	private static IntPtr GetRotationalKeys_FunctionAddress;

	private static int GetRotationalKeys_ParamsSize;

	private static bool GetRotationalKeys_Track_IsValid;

	private static FFieldAddress GetRotationalKeys_Track_PropertyAddress;

	private static int GetRotationalKeys_Track_Offset;

	private static bool GetRotationalKeys_ReturnValue_IsValid;

	private static FFieldAddress GetRotationalKeys_ReturnValue_PropertyAddress;

	private static int GetRotationalKeys_ReturnValue_Offset;

	private static bool GetPositionalKeys_IsValid;

	private static IntPtr GetPositionalKeys_FunctionAddress;

	private static int GetPositionalKeys_ParamsSize;

	private static bool GetPositionalKeys_Track_IsValid;

	private static FFieldAddress GetPositionalKeys_Track_PropertyAddress;

	private static int GetPositionalKeys_Track_Offset;

	private static bool GetPositionalKeys_ReturnValue_IsValid;

	private static FFieldAddress GetPositionalKeys_ReturnValue_PropertyAddress;

	private static int GetPositionalKeys_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.RawAnimSequenceTrackExtensions:GetScaleKeys")]
	public unsafe static List<FVector> GetScaleKeys(FRawAnimSequenceTrack Track)
	{
		if (!GetScaleKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RawAnimSequenceTrackExtensions:GetScaleKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaleKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaleKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetScaleKeys_Track_PropertyAddress.Address, intPtr);
		FRawAnimSequenceTrack.ToNative(IntPtr.Add(intPtr, GetScaleKeys_Track_Offset), 0, GetScaleKeys_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetScaleKeys_FunctionAddress, intPtr, GetScaleKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetScaleKeys_Track_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetScaleKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetScaleKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetScaleKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.RawAnimSequenceTrackExtensions:GetRotationalKeys")]
	public unsafe static List<FQuat> GetRotationalKeys(FRawAnimSequenceTrack Track)
	{
		if (!GetRotationalKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RawAnimSequenceTrackExtensions:GetRotationalKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationalKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationalKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRotationalKeys_Track_PropertyAddress.Address, intPtr);
		FRawAnimSequenceTrack.ToNative(IntPtr.Add(intPtr, GetRotationalKeys_Track_Offset), 0, GetRotationalKeys_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRotationalKeys_FunctionAddress, intPtr, GetRotationalKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRotationalKeys_Track_PropertyAddress.Address, intPtr);
		List<FQuat> result = new TArrayCopyMarshaler<FQuat>(1, GetRotationalKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRotationalKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetRotationalKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.RawAnimSequenceTrackExtensions:GetPositionalKeys")]
	public unsafe static List<FVector> GetPositionalKeys(FRawAnimSequenceTrack Track)
	{
		if (!GetPositionalKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RawAnimSequenceTrackExtensions:GetPositionalKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPositionalKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPositionalKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPositionalKeys_Track_PropertyAddress.Address, intPtr);
		FRawAnimSequenceTrack.ToNative(IntPtr.Add(intPtr, GetPositionalKeys_Track_Offset), 0, GetPositionalKeys_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPositionalKeys_FunctionAddress, intPtr, GetPositionalKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPositionalKeys_Track_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetPositionalKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPositionalKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPositionalKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static URawAnimSequenceTrackExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URawAnimSequenceTrackExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URawAnimSequenceTrackExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.RawAnimSequenceTrackExtensions");
		GetScaleKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScaleKeys");
		GetScaleKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaleKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaleKeys_Track_PropertyAddress, GetScaleKeys_FunctionAddress, "Track");
		GetScaleKeys_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleKeys_FunctionAddress, "Track");
		GetScaleKeys_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleKeys_FunctionAddress, "Track", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaleKeys_ReturnValue_PropertyAddress, GetScaleKeys_FunctionAddress, "ReturnValue");
		GetScaleKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleKeys_FunctionAddress, "ReturnValue");
		GetScaleKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetScaleKeys_IsValid = GetScaleKeys_FunctionAddress != IntPtr.Zero && GetScaleKeys_Track_IsValid && GetScaleKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RawAnimSequenceTrackExtensions:GetScaleKeys", GetScaleKeys_IsValid);
		GetRotationalKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRotationalKeys");
		GetRotationalKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationalKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationalKeys_Track_PropertyAddress, GetRotationalKeys_FunctionAddress, "Track");
		GetRotationalKeys_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationalKeys_FunctionAddress, "Track");
		GetRotationalKeys_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationalKeys_FunctionAddress, "Track", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationalKeys_ReturnValue_PropertyAddress, GetRotationalKeys_FunctionAddress, "ReturnValue");
		GetRotationalKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationalKeys_FunctionAddress, "ReturnValue");
		GetRotationalKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationalKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetRotationalKeys_IsValid = GetRotationalKeys_FunctionAddress != IntPtr.Zero && GetRotationalKeys_Track_IsValid && GetRotationalKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RawAnimSequenceTrackExtensions:GetRotationalKeys", GetRotationalKeys_IsValid);
		GetPositionalKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPositionalKeys");
		GetPositionalKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPositionalKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPositionalKeys_Track_PropertyAddress, GetPositionalKeys_FunctionAddress, "Track");
		GetPositionalKeys_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetPositionalKeys_FunctionAddress, "Track");
		GetPositionalKeys_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPositionalKeys_FunctionAddress, "Track", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPositionalKeys_ReturnValue_PropertyAddress, GetPositionalKeys_FunctionAddress, "ReturnValue");
		GetPositionalKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPositionalKeys_FunctionAddress, "ReturnValue");
		GetPositionalKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPositionalKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPositionalKeys_IsValid = GetPositionalKeys_FunctionAddress != IntPtr.Zero && GetPositionalKeys_Track_IsValid && GetPositionalKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RawAnimSequenceTrackExtensions:GetPositionalKeys", GetPositionalKeys_IsValid);
	}
}
