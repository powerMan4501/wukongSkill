using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnCompletedDeviceSwap__DelegateSignature")]
public class FOnCompletedDeviceSwap : FDelegate<FOnCompletedDeviceSwap.Signature>
{
	public delegate void Signature(FSwapAudioOutputResult SwapResult);

	private static bool OnCompletedDeviceSwap__DelegateSignature_IsValid;

	private static IntPtr OnCompletedDeviceSwap__DelegateSignature_FunctionAddress;

	private static int OnCompletedDeviceSwap__DelegateSignature_ParamsSize;

	private static bool OnCompletedDeviceSwap__DelegateSignature_SwapResult_IsValid;

	private static FFieldAddress OnCompletedDeviceSwap__DelegateSignature_SwapResult_PropertyAddress;

	private static int OnCompletedDeviceSwap__DelegateSignature_SwapResult_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnCompletedDeviceSwap()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnCompletedDeviceSwap__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnCompletedDeviceSwap__DelegateSignature");
		OnCompletedDeviceSwap__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCompletedDeviceSwap__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCompletedDeviceSwap__DelegateSignature_SwapResult_PropertyAddress, OnCompletedDeviceSwap__DelegateSignature_FunctionAddress, "SwapResult");
		OnCompletedDeviceSwap__DelegateSignature_SwapResult_Offset = NativeReflectionCached.GetPropertyOffset(OnCompletedDeviceSwap__DelegateSignature_FunctionAddress, "SwapResult");
		OnCompletedDeviceSwap__DelegateSignature_SwapResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCompletedDeviceSwap__DelegateSignature_FunctionAddress, "SwapResult", Classes.FStructProperty);
		OnCompletedDeviceSwap__DelegateSignature_IsValid = OnCompletedDeviceSwap__DelegateSignature_FunctionAddress != IntPtr.Zero && OnCompletedDeviceSwap__DelegateSignature_SwapResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnCompletedDeviceSwap__DelegateSignature", OnCompletedDeviceSwap__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FSwapAudioOutputResult SwapResult)
	{
		if (!OnCompletedDeviceSwap__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnCompletedDeviceSwap__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnCompletedDeviceSwap__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCompletedDeviceSwap__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnCompletedDeviceSwap__DelegateSignature_SwapResult_PropertyAddress.Address, intPtr);
			FSwapAudioOutputResult.ToNative(IntPtr.Add(intPtr, OnCompletedDeviceSwap__DelegateSignature_SwapResult_Offset), 0, OnCompletedDeviceSwap__DelegateSignature_SwapResult_PropertyAddress.Address, SwapResult);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnCompletedDeviceSwap__DelegateSignature_SwapResult_PropertyAddress.Address, intPtr);
		}
	}
}
