using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.ConstantQNRT", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UConstantQNRT : UAudioSynesthesiaNRT
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool GetNormalizedChannelConstantQAtTime_IsValid;

	private static IntPtr GetNormalizedChannelConstantQAtTime_FunctionAddress;

	private static int GetNormalizedChannelConstantQAtTime_ParamsSize;

	private static bool GetNormalizedChannelConstantQAtTime_InSeconds_IsValid;

	private static FFieldAddress GetNormalizedChannelConstantQAtTime_InSeconds_PropertyAddress;

	private static int GetNormalizedChannelConstantQAtTime_InSeconds_Offset;

	private static bool GetNormalizedChannelConstantQAtTime_InChannel_IsValid;

	private static FFieldAddress GetNormalizedChannelConstantQAtTime_InChannel_PropertyAddress;

	private static int GetNormalizedChannelConstantQAtTime_InChannel_Offset;

	private static bool GetNormalizedChannelConstantQAtTime_OutConstantQ_IsValid;

	private static FFieldAddress GetNormalizedChannelConstantQAtTime_OutConstantQ_PropertyAddress;

	private static int GetNormalizedChannelConstantQAtTime_OutConstantQ_Offset;

	private static bool GetChannelConstantQAtTime_IsValid;

	private static IntPtr GetChannelConstantQAtTime_FunctionAddress;

	private static int GetChannelConstantQAtTime_ParamsSize;

	private static bool GetChannelConstantQAtTime_InSeconds_IsValid;

	private static FFieldAddress GetChannelConstantQAtTime_InSeconds_PropertyAddress;

	private static int GetChannelConstantQAtTime_InSeconds_Offset;

	private static bool GetChannelConstantQAtTime_InChannel_IsValid;

	private static FFieldAddress GetChannelConstantQAtTime_InChannel_PropertyAddress;

	private static int GetChannelConstantQAtTime_InChannel_Offset;

	private static bool GetChannelConstantQAtTime_OutConstantQ_IsValid;

	private static FFieldAddress GetChannelConstantQAtTime_OutConstantQ_PropertyAddress;

	private static int GetChannelConstantQAtTime_OutConstantQ_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRT:Settings")]
	public UConstantQNRTSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRT:Settings");
				return null;
			}
			return UObjectMarshaler<UConstantQNRTSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRT:Settings");
			}
			else
			{
				UObjectMarshaler<UConstantQNRTSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRT:GetNormalizedChannelConstantQAtTime")]
	public unsafe void GetNormalizedChannelConstantQAtTime(float InSeconds, int InChannel, out List<float> OutConstantQ)
	{
		CheckDestroyed();
		if (!GetNormalizedChannelConstantQAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.ConstantQNRT:GetNormalizedChannelConstantQAtTime");
			OutConstantQ = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedChannelConstantQAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedChannelConstantQAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelConstantQAtTime_InSeconds_Offset), 0, GetNormalizedChannelConstantQAtTime_InSeconds_PropertyAddress.Address, InSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelConstantQAtTime_InChannel_Offset), 0, GetNormalizedChannelConstantQAtTime_InChannel_PropertyAddress.Address, InChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedChannelConstantQAtTime_FunctionAddress, intPtr, GetNormalizedChannelConstantQAtTime_ParamsSize);
		OutConstantQ = new TArrayCopyMarshaler<float>(1, GetNormalizedChannelConstantQAtTime_OutConstantQ_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNormalizedChannelConstantQAtTime_OutConstantQ_Offset));
		NativeReflection.DestroyValue_InContainer(GetNormalizedChannelConstantQAtTime_OutConstantQ_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRT:GetChannelConstantQAtTime")]
	public unsafe void GetChannelConstantQAtTime(float InSeconds, int InChannel, out List<float> OutConstantQ)
	{
		CheckDestroyed();
		if (!GetChannelConstantQAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.ConstantQNRT:GetChannelConstantQAtTime");
			OutConstantQ = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannelConstantQAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannelConstantQAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetChannelConstantQAtTime_InSeconds_Offset), 0, GetChannelConstantQAtTime_InSeconds_PropertyAddress.Address, InSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetChannelConstantQAtTime_InChannel_Offset), 0, GetChannelConstantQAtTime_InChannel_PropertyAddress.Address, InChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChannelConstantQAtTime_FunctionAddress, intPtr, GetChannelConstantQAtTime_ParamsSize);
		OutConstantQ = new TArrayCopyMarshaler<float>(1, GetChannelConstantQAtTime_OutConstantQ_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChannelConstantQAtTime_OutConstantQ_Offset));
		NativeReflection.DestroyValue_InContainer(GetChannelConstantQAtTime_OutConstantQ_PropertyAddress.Address, intPtr);
	}

	static UConstantQNRT()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UConstantQNRT)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UConstantQNRT));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AudioSynesthesia.ConstantQNRT");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FObjectProperty);
		GetNormalizedChannelConstantQAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormalizedChannelConstantQAtTime");
		GetNormalizedChannelConstantQAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedChannelConstantQAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelConstantQAtTime_InSeconds_PropertyAddress, GetNormalizedChannelConstantQAtTime_FunctionAddress, "InSeconds");
		GetNormalizedChannelConstantQAtTime_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelConstantQAtTime_FunctionAddress, "InSeconds");
		GetNormalizedChannelConstantQAtTime_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelConstantQAtTime_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelConstantQAtTime_InChannel_PropertyAddress, GetNormalizedChannelConstantQAtTime_FunctionAddress, "InChannel");
		GetNormalizedChannelConstantQAtTime_InChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelConstantQAtTime_FunctionAddress, "InChannel");
		GetNormalizedChannelConstantQAtTime_InChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelConstantQAtTime_FunctionAddress, "InChannel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelConstantQAtTime_OutConstantQ_PropertyAddress, GetNormalizedChannelConstantQAtTime_FunctionAddress, "OutConstantQ");
		GetNormalizedChannelConstantQAtTime_OutConstantQ_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelConstantQAtTime_FunctionAddress, "OutConstantQ");
		GetNormalizedChannelConstantQAtTime_OutConstantQ_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelConstantQAtTime_FunctionAddress, "OutConstantQ", Classes.FArrayProperty);
		GetNormalizedChannelConstantQAtTime_IsValid = GetNormalizedChannelConstantQAtTime_FunctionAddress != IntPtr.Zero && GetNormalizedChannelConstantQAtTime_InSeconds_IsValid && GetNormalizedChannelConstantQAtTime_InChannel_IsValid && GetNormalizedChannelConstantQAtTime_OutConstantQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.ConstantQNRT:GetNormalizedChannelConstantQAtTime", GetNormalizedChannelConstantQAtTime_IsValid);
		GetChannelConstantQAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetChannelConstantQAtTime");
		GetChannelConstantQAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannelConstantQAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannelConstantQAtTime_InSeconds_PropertyAddress, GetChannelConstantQAtTime_FunctionAddress, "InSeconds");
		GetChannelConstantQAtTime_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelConstantQAtTime_FunctionAddress, "InSeconds");
		GetChannelConstantQAtTime_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelConstantQAtTime_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelConstantQAtTime_InChannel_PropertyAddress, GetChannelConstantQAtTime_FunctionAddress, "InChannel");
		GetChannelConstantQAtTime_InChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelConstantQAtTime_FunctionAddress, "InChannel");
		GetChannelConstantQAtTime_InChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelConstantQAtTime_FunctionAddress, "InChannel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelConstantQAtTime_OutConstantQ_PropertyAddress, GetChannelConstantQAtTime_FunctionAddress, "OutConstantQ");
		GetChannelConstantQAtTime_OutConstantQ_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelConstantQAtTime_FunctionAddress, "OutConstantQ");
		GetChannelConstantQAtTime_OutConstantQ_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelConstantQAtTime_FunctionAddress, "OutConstantQ", Classes.FArrayProperty);
		GetChannelConstantQAtTime_IsValid = GetChannelConstantQAtTime_FunctionAddress != IntPtr.Zero && GetChannelConstantQAtTime_InSeconds_IsValid && GetChannelConstantQAtTime_InChannel_IsValid && GetChannelConstantQAtTime_OutConstantQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.ConstantQNRT:GetChannelConstantQAtTime", GetChannelConstantQAtTime_IsValid);
	}
}
