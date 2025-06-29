using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SwapAudioOutputResult", "AudioMixer", UnrealModuleType.Engine)]
public struct FSwapAudioOutputResult
{
	private static bool CurrentDeviceId_IsValid;

	private static int CurrentDeviceId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AudioMixer.SwapAudioOutputResult:CurrentDeviceId")]
	public string CurrentDeviceId;

	private static bool RequestedDeviceId_IsValid;

	private static int RequestedDeviceId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AudioMixer.SwapAudioOutputResult:RequestedDeviceId")]
	public string RequestedDeviceId;

	private static bool Result_IsValid;

	private static FFieldAddress Result_PropertyAddress;

	private static int Result_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioMixer.SwapAudioOutputResult:Result")]
	public ESwapAudioOutputDeviceResultState Result;

	private static bool FSwapAudioOutputResult_IsValid;

	private static int FSwapAudioOutputResult_StructSize;

	public FSwapAudioOutputResult Copy()
	{
		return this;
	}

	public static FSwapAudioOutputResult FromNative(IntPtr nativeBuffer)
	{
		return new FSwapAudioOutputResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSwapAudioOutputResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSwapAudioOutputResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSwapAudioOutputResult(nativeBuffer + arrayIndex * FSwapAudioOutputResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSwapAudioOutputResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSwapAudioOutputResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSwapAudioOutputResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SwapAudioOutputResult");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CurrentDeviceId_Offset), CurrentDeviceId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, RequestedDeviceId_Offset), RequestedDeviceId);
		EnumMarshaler<ESwapAudioOutputDeviceResultState>.ToNative(IntPtr.Add(nativeStruct, Result_Offset), 0, Result_PropertyAddress.Address, Result);
	}

	public FSwapAudioOutputResult(IntPtr nativeStruct)
	{
		if (!FSwapAudioOutputResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SwapAudioOutputResult");
			CurrentDeviceId = FStringMarshaler.DefaultString;
			RequestedDeviceId = FStringMarshaler.DefaultString;
			Result = ESwapAudioOutputDeviceResultState.Failure;
		}
		else
		{
			CurrentDeviceId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CurrentDeviceId_Offset));
			RequestedDeviceId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, RequestedDeviceId_Offset));
			Result = EnumMarshaler<ESwapAudioOutputDeviceResultState>.FromNative(IntPtr.Add(nativeStruct, Result_Offset), 0, Result_PropertyAddress.Address);
		}
	}

	static FSwapAudioOutputResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSwapAudioOutputResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSwapAudioOutputResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.SwapAudioOutputResult");
		FSwapAudioOutputResult_StructSize = NativeReflection.GetStructSize(intPtr);
		CurrentDeviceId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentDeviceId");
		CurrentDeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentDeviceId", Classes.FStrProperty);
		RequestedDeviceId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequestedDeviceId");
		RequestedDeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequestedDeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Result_PropertyAddress, intPtr, "Result");
		Result_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Result", Classes.FEnumProperty);
		FSwapAudioOutputResult_IsValid = intPtr != IntPtr.Zero && CurrentDeviceId_IsValid && RequestedDeviceId_IsValid && Result_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.SwapAudioOutputResult", FSwapAudioOutputResult_IsValid);
	}
}
