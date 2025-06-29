using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnPerChannelLoudnessResults__DelegateSignature")]
public class FOnPerChannelLoudnessResults : FMulticastDelegate<FOnPerChannelLoudnessResults.Signature>
{
	public delegate void Signature(int ChannelIndex, List<FLoudnessResults> LoudnessResults);

	private static bool OnPerChannelLoudnessResults__DelegateSignature_IsValid;

	private static IntPtr OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress;

	private static int OnPerChannelLoudnessResults__DelegateSignature_ParamsSize;

	private static bool OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_IsValid;

	private static FFieldAddress OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_PropertyAddress;

	private static int OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_Offset;

	private static bool OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_IsValid;

	private static FFieldAddress OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_PropertyAddress;

	private static int OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPerChannelLoudnessResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnPerChannelLoudnessResults__DelegateSignature");
		OnPerChannelLoudnessResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_PropertyAddress, OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "ChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_PropertyAddress, OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "LoudnessResults");
		OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "LoudnessResults");
		OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "LoudnessResults", Classes.FArrayProperty);
		OnPerChannelLoudnessResults__DelegateSignature_IsValid = OnPerChannelLoudnessResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_IsValid && OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnPerChannelLoudnessResults__DelegateSignature", OnPerChannelLoudnessResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ChannelIndex, List<FLoudnessResults> LoudnessResults)
	{
		if (!OnPerChannelLoudnessResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnPerChannelLoudnessResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPerChannelLoudnessResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPerChannelLoudnessResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_Offset), 0, OnPerChannelLoudnessResults__DelegateSignature_ChannelIndex_PropertyAddress.Address, ChannelIndex);
			new TArrayCopyMarshaler<FLoudnessResults>(1, OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_PropertyAddress, CachedMarshalingDelegates<FLoudnessResults, FLoudnessResults>.FromNative, CachedMarshalingDelegates<FLoudnessResults, FLoudnessResults>.ToNative).ToNative(IntPtr.Add(intPtr, OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_Offset), LoudnessResults);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPerChannelLoudnessResults__DelegateSignature_LoudnessResults_PropertyAddress.Address, intPtr);
		}
	}
}
