using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnLatestPerChannelMeterResults__DelegateSignature")]
public class FOnLatestPerChannelMeterResults : FMulticastDelegate<FOnLatestPerChannelMeterResults.Signature>
{
	public delegate void Signature(int ChannelIndex, FMeterResults LatestMeterResults);

	private static bool OnLatestPerChannelMeterResults__DelegateSignature_IsValid;

	private static IntPtr OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress;

	private static int OnLatestPerChannelMeterResults__DelegateSignature_ParamsSize;

	private static bool OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_IsValid;

	private static FFieldAddress OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_PropertyAddress;

	private static int OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_Offset;

	private static bool OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_IsValid;

	private static FFieldAddress OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_PropertyAddress;

	private static int OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnLatestPerChannelMeterResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnLatestPerChannelMeterResults__DelegateSignature");
		OnLatestPerChannelMeterResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_PropertyAddress, OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress, "ChannelIndex");
		OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress, "ChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_PropertyAddress, OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress, "LatestMeterResults");
		OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_Offset = NativeReflectionCached.GetPropertyOffset(OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress, "LatestMeterResults");
		OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress, "LatestMeterResults", Classes.FStructProperty);
		OnLatestPerChannelMeterResults__DelegateSignature_IsValid = OnLatestPerChannelMeterResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_IsValid && OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnLatestPerChannelMeterResults__DelegateSignature", OnLatestPerChannelMeterResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ChannelIndex, FMeterResults LatestMeterResults)
	{
		if (!OnLatestPerChannelMeterResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnLatestPerChannelMeterResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnLatestPerChannelMeterResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLatestPerChannelMeterResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_Offset), 0, OnLatestPerChannelMeterResults__DelegateSignature_ChannelIndex_PropertyAddress.Address, ChannelIndex);
			NativeReflection.InitializeValue_InContainer(OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_PropertyAddress.Address, intPtr);
			FMeterResults.ToNative(IntPtr.Add(intPtr, OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_Offset), 0, OnLatestPerChannelMeterResults__DelegateSignature_LatestMeterResults_PropertyAddress.Address, LatestMeterResults);
			ProcessDelegate(intPtr);
		}
	}
}
