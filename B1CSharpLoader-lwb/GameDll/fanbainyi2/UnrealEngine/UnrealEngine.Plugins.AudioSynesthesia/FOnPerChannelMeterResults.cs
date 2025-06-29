using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnPerChannelMeterResults__DelegateSignature")]
public class FOnPerChannelMeterResults : FMulticastDelegate<FOnPerChannelMeterResults.Signature>
{
	public delegate void Signature(int ChannelIndex, List<FMeterResults> MeterResults);

	private static bool OnPerChannelMeterResults__DelegateSignature_IsValid;

	private static IntPtr OnPerChannelMeterResults__DelegateSignature_FunctionAddress;

	private static int OnPerChannelMeterResults__DelegateSignature_ParamsSize;

	private static bool OnPerChannelMeterResults__DelegateSignature_ChannelIndex_IsValid;

	private static FFieldAddress OnPerChannelMeterResults__DelegateSignature_ChannelIndex_PropertyAddress;

	private static int OnPerChannelMeterResults__DelegateSignature_ChannelIndex_Offset;

	private static bool OnPerChannelMeterResults__DelegateSignature_MeterResults_IsValid;

	private static FFieldAddress OnPerChannelMeterResults__DelegateSignature_MeterResults_PropertyAddress;

	private static int OnPerChannelMeterResults__DelegateSignature_MeterResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPerChannelMeterResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPerChannelMeterResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnPerChannelMeterResults__DelegateSignature");
		OnPerChannelMeterResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPerChannelMeterResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPerChannelMeterResults__DelegateSignature_ChannelIndex_PropertyAddress, OnPerChannelMeterResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnPerChannelMeterResults__DelegateSignature_ChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnPerChannelMeterResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnPerChannelMeterResults__DelegateSignature_ChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPerChannelMeterResults__DelegateSignature_FunctionAddress, "ChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPerChannelMeterResults__DelegateSignature_MeterResults_PropertyAddress, OnPerChannelMeterResults__DelegateSignature_FunctionAddress, "MeterResults");
		OnPerChannelMeterResults__DelegateSignature_MeterResults_Offset = NativeReflectionCached.GetPropertyOffset(OnPerChannelMeterResults__DelegateSignature_FunctionAddress, "MeterResults");
		OnPerChannelMeterResults__DelegateSignature_MeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPerChannelMeterResults__DelegateSignature_FunctionAddress, "MeterResults", Classes.FArrayProperty);
		OnPerChannelMeterResults__DelegateSignature_IsValid = OnPerChannelMeterResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPerChannelMeterResults__DelegateSignature_ChannelIndex_IsValid && OnPerChannelMeterResults__DelegateSignature_MeterResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnPerChannelMeterResults__DelegateSignature", OnPerChannelMeterResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ChannelIndex, List<FMeterResults> MeterResults)
	{
		if (!OnPerChannelMeterResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnPerChannelMeterResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPerChannelMeterResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPerChannelMeterResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPerChannelMeterResults__DelegateSignature_ChannelIndex_Offset), 0, OnPerChannelMeterResults__DelegateSignature_ChannelIndex_PropertyAddress.Address, ChannelIndex);
			new TArrayCopyMarshaler<FMeterResults>(1, OnPerChannelMeterResults__DelegateSignature_MeterResults_PropertyAddress, CachedMarshalingDelegates<FMeterResults, FMeterResults>.FromNative, CachedMarshalingDelegates<FMeterResults, FMeterResults>.ToNative).ToNative(IntPtr.Add(intPtr, OnPerChannelMeterResults__DelegateSignature_MeterResults_Offset), MeterResults);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPerChannelMeterResults__DelegateSignature_MeterResults_PropertyAddress.Address, intPtr);
		}
	}
}
