using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnLatestPerChannelLoudnessResults__DelegateSignature")]
public class FOnLatestPerChannelLoudnessResults : FMulticastDelegate<FOnLatestPerChannelLoudnessResults.Signature>
{
	public delegate void Signature(int ChannelIndex, FLoudnessResults LatestLoudnessResults);

	private static bool OnLatestPerChannelLoudnessResults__DelegateSignature_IsValid;

	private static IntPtr OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress;

	private static int OnLatestPerChannelLoudnessResults__DelegateSignature_ParamsSize;

	private static bool OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_IsValid;

	private static FFieldAddress OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_PropertyAddress;

	private static int OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_Offset;

	private static bool OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_IsValid;

	private static FFieldAddress OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_PropertyAddress;

	private static int OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnLatestPerChannelLoudnessResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnLatestPerChannelLoudnessResults__DelegateSignature");
		OnLatestPerChannelLoudnessResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_PropertyAddress, OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "ChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_PropertyAddress, OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "LatestLoudnessResults");
		OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "LatestLoudnessResults");
		OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress, "LatestLoudnessResults", Classes.FStructProperty);
		OnLatestPerChannelLoudnessResults__DelegateSignature_IsValid = OnLatestPerChannelLoudnessResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_IsValid && OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnLatestPerChannelLoudnessResults__DelegateSignature", OnLatestPerChannelLoudnessResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ChannelIndex, FLoudnessResults LatestLoudnessResults)
	{
		if (!OnLatestPerChannelLoudnessResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnLatestPerChannelLoudnessResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnLatestPerChannelLoudnessResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLatestPerChannelLoudnessResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_Offset), 0, OnLatestPerChannelLoudnessResults__DelegateSignature_ChannelIndex_PropertyAddress.Address, ChannelIndex);
			NativeReflection.InitializeValue_InContainer(OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_PropertyAddress.Address, intPtr);
			FLoudnessResults.ToNative(IntPtr.Add(intPtr, OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_Offset), 0, OnLatestPerChannelLoudnessResults__DelegateSignature_LatestLoudnessResults_PropertyAddress.Address, LatestLoudnessResults);
			ProcessDelegate(intPtr);
		}
	}
}
