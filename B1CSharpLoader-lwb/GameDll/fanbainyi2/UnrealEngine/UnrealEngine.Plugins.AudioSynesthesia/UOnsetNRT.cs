using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.OnsetNRT", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UOnsetNRT : UAudioSynesthesiaNRT
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool GetNormalizedChannelOnsetsBetweenTimes_IsValid;

	private static IntPtr GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress;

	private static int GetNormalizedChannelOnsetsBetweenTimes_ParamsSize;

	private static bool GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_IsValid;

	private static FFieldAddress GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_PropertyAddress;

	private static int GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_Offset;

	private static bool GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_IsValid;

	private static FFieldAddress GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_PropertyAddress;

	private static int GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_Offset;

	private static bool GetNormalizedChannelOnsetsBetweenTimes_InChannel_IsValid;

	private static FFieldAddress GetNormalizedChannelOnsetsBetweenTimes_InChannel_PropertyAddress;

	private static int GetNormalizedChannelOnsetsBetweenTimes_InChannel_Offset;

	private static bool GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_IsValid;

	private static FFieldAddress GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress;

	private static int GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_Offset;

	private static bool GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_IsValid;

	private static FFieldAddress GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress;

	private static int GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_Offset;

	private static bool GetChannelOnsetsBetweenTimes_IsValid;

	private static IntPtr GetChannelOnsetsBetweenTimes_FunctionAddress;

	private static int GetChannelOnsetsBetweenTimes_ParamsSize;

	private static bool GetChannelOnsetsBetweenTimes_InStartSeconds_IsValid;

	private static FFieldAddress GetChannelOnsetsBetweenTimes_InStartSeconds_PropertyAddress;

	private static int GetChannelOnsetsBetweenTimes_InStartSeconds_Offset;

	private static bool GetChannelOnsetsBetweenTimes_InEndSeconds_IsValid;

	private static FFieldAddress GetChannelOnsetsBetweenTimes_InEndSeconds_PropertyAddress;

	private static int GetChannelOnsetsBetweenTimes_InEndSeconds_Offset;

	private static bool GetChannelOnsetsBetweenTimes_InChannel_IsValid;

	private static FFieldAddress GetChannelOnsetsBetweenTimes_InChannel_PropertyAddress;

	private static int GetChannelOnsetsBetweenTimes_InChannel_Offset;

	private static bool GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_IsValid;

	private static FFieldAddress GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress;

	private static int GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_Offset;

	private static bool GetChannelOnsetsBetweenTimes_OutOnsetStrengths_IsValid;

	private static FFieldAddress GetChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress;

	private static int GetChannelOnsetsBetweenTimes_OutOnsetStrengths_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRT:Settings")]
	public UOnsetNRTSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRT:Settings");
				return null;
			}
			return UObjectMarshaler<UOnsetNRTSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRT:Settings");
			}
			else
			{
				UObjectMarshaler<UOnsetNRTSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRT:GetNormalizedChannelOnsetsBetweenTimes")]
	public unsafe void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, out List<float> OutOnsetTimestamps, out List<float> OutOnsetStrengths)
	{
		CheckDestroyed();
		if (!GetNormalizedChannelOnsetsBetweenTimes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnsetNRT:GetNormalizedChannelOnsetsBetweenTimes");
			OutOnsetTimestamps = null;
			OutOnsetStrengths = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedChannelOnsetsBetweenTimes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedChannelOnsetsBetweenTimes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_Offset), 0, GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_PropertyAddress.Address, InStartSeconds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_Offset), 0, GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_PropertyAddress.Address, InEndSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelOnsetsBetweenTimes_InChannel_Offset), 0, GetNormalizedChannelOnsetsBetweenTimes_InChannel_PropertyAddress.Address, InChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, intPtr, GetNormalizedChannelOnsetsBetweenTimes_ParamsSize);
		OutOnsetTimestamps = new TArrayCopyMarshaler<float>(1, GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_Offset));
		NativeReflection.DestroyValue_InContainer(GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress.Address, intPtr);
		OutOnsetStrengths = new TArrayCopyMarshaler<float>(1, GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_Offset));
		NativeReflection.DestroyValue_InContainer(GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRT:GetChannelOnsetsBetweenTimes")]
	public unsafe void GetChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, out List<float> OutOnsetTimestamps, out List<float> OutOnsetStrengths)
	{
		CheckDestroyed();
		if (!GetChannelOnsetsBetweenTimes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnsetNRT:GetChannelOnsetsBetweenTimes");
			OutOnsetTimestamps = null;
			OutOnsetStrengths = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannelOnsetsBetweenTimes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannelOnsetsBetweenTimes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetChannelOnsetsBetweenTimes_InStartSeconds_Offset), 0, GetChannelOnsetsBetweenTimes_InStartSeconds_PropertyAddress.Address, InStartSeconds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetChannelOnsetsBetweenTimes_InEndSeconds_Offset), 0, GetChannelOnsetsBetweenTimes_InEndSeconds_PropertyAddress.Address, InEndSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetChannelOnsetsBetweenTimes_InChannel_Offset), 0, GetChannelOnsetsBetweenTimes_InChannel_PropertyAddress.Address, InChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChannelOnsetsBetweenTimes_FunctionAddress, intPtr, GetChannelOnsetsBetweenTimes_ParamsSize);
		OutOnsetTimestamps = new TArrayCopyMarshaler<float>(1, GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_Offset));
		NativeReflection.DestroyValue_InContainer(GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress.Address, intPtr);
		OutOnsetStrengths = new TArrayCopyMarshaler<float>(1, GetChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChannelOnsetsBetweenTimes_OutOnsetStrengths_Offset));
		NativeReflection.DestroyValue_InContainer(GetChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress.Address, intPtr);
	}

	static UOnsetNRT()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOnsetNRT)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOnsetNRT));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AudioSynesthesia.OnsetNRT");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FObjectProperty);
		GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormalizedChannelOnsetsBetweenTimes");
		GetNormalizedChannelOnsetsBetweenTimes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_PropertyAddress, GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InStartSeconds");
		GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InStartSeconds");
		GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InStartSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_PropertyAddress, GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InEndSeconds");
		GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InEndSeconds");
		GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InEndSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelOnsetsBetweenTimes_InChannel_PropertyAddress, GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InChannel");
		GetNormalizedChannelOnsetsBetweenTimes_InChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InChannel");
		GetNormalizedChannelOnsetsBetweenTimes_InChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "InChannel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress, GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetTimestamps");
		GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetTimestamps");
		GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetTimestamps", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress, GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetStrengths");
		GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetStrengths");
		GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetStrengths", Classes.FArrayProperty);
		GetNormalizedChannelOnsetsBetweenTimes_IsValid = GetNormalizedChannelOnsetsBetweenTimes_FunctionAddress != IntPtr.Zero && GetNormalizedChannelOnsetsBetweenTimes_InStartSeconds_IsValid && GetNormalizedChannelOnsetsBetweenTimes_InEndSeconds_IsValid && GetNormalizedChannelOnsetsBetweenTimes_InChannel_IsValid && GetNormalizedChannelOnsetsBetweenTimes_OutOnsetTimestamps_IsValid && GetNormalizedChannelOnsetsBetweenTimes_OutOnsetStrengths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnsetNRT:GetNormalizedChannelOnsetsBetweenTimes", GetNormalizedChannelOnsetsBetweenTimes_IsValid);
		GetChannelOnsetsBetweenTimes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetChannelOnsetsBetweenTimes");
		GetChannelOnsetsBetweenTimes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannelOnsetsBetweenTimes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannelOnsetsBetweenTimes_InStartSeconds_PropertyAddress, GetChannelOnsetsBetweenTimes_FunctionAddress, "InStartSeconds");
		GetChannelOnsetsBetweenTimes_InStartSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelOnsetsBetweenTimes_FunctionAddress, "InStartSeconds");
		GetChannelOnsetsBetweenTimes_InStartSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelOnsetsBetweenTimes_FunctionAddress, "InStartSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelOnsetsBetweenTimes_InEndSeconds_PropertyAddress, GetChannelOnsetsBetweenTimes_FunctionAddress, "InEndSeconds");
		GetChannelOnsetsBetweenTimes_InEndSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelOnsetsBetweenTimes_FunctionAddress, "InEndSeconds");
		GetChannelOnsetsBetweenTimes_InEndSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelOnsetsBetweenTimes_FunctionAddress, "InEndSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelOnsetsBetweenTimes_InChannel_PropertyAddress, GetChannelOnsetsBetweenTimes_FunctionAddress, "InChannel");
		GetChannelOnsetsBetweenTimes_InChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelOnsetsBetweenTimes_FunctionAddress, "InChannel");
		GetChannelOnsetsBetweenTimes_InChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelOnsetsBetweenTimes_FunctionAddress, "InChannel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_PropertyAddress, GetChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetTimestamps");
		GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetTimestamps");
		GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetTimestamps", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelOnsetsBetweenTimes_OutOnsetStrengths_PropertyAddress, GetChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetStrengths");
		GetChannelOnsetsBetweenTimes_OutOnsetStrengths_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetStrengths");
		GetChannelOnsetsBetweenTimes_OutOnsetStrengths_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelOnsetsBetweenTimes_FunctionAddress, "OutOnsetStrengths", Classes.FArrayProperty);
		GetChannelOnsetsBetweenTimes_IsValid = GetChannelOnsetsBetweenTimes_FunctionAddress != IntPtr.Zero && GetChannelOnsetsBetweenTimes_InStartSeconds_IsValid && GetChannelOnsetsBetweenTimes_InEndSeconds_IsValid && GetChannelOnsetsBetweenTimes_InChannel_IsValid && GetChannelOnsetsBetweenTimes_OutOnsetTimestamps_IsValid && GetChannelOnsetsBetweenTimes_OutOnsetStrengths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnsetNRT:GetChannelOnsetsBetweenTimes", GetChannelOnsetsBetweenTimes_IsValid);
	}
}
