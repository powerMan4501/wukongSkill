using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnOverallLoudnessResults__DelegateSignature")]
public class FOnOverallLoudnessResults : FMulticastDelegate<FOnOverallLoudnessResults.Signature>
{
	public delegate void Signature(List<FLoudnessResults> OverallLoudnessResults);

	private static bool OnOverallLoudnessResults__DelegateSignature_IsValid;

	private static IntPtr OnOverallLoudnessResults__DelegateSignature_FunctionAddress;

	private static int OnOverallLoudnessResults__DelegateSignature_ParamsSize;

	private static bool OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_IsValid;

	private static FFieldAddress OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_PropertyAddress;

	private static int OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnOverallLoudnessResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnOverallLoudnessResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnOverallLoudnessResults__DelegateSignature");
		OnOverallLoudnessResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnOverallLoudnessResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_PropertyAddress, OnOverallLoudnessResults__DelegateSignature_FunctionAddress, "OverallLoudnessResults");
		OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(OnOverallLoudnessResults__DelegateSignature_FunctionAddress, "OverallLoudnessResults");
		OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnOverallLoudnessResults__DelegateSignature_FunctionAddress, "OverallLoudnessResults", Classes.FArrayProperty);
		OnOverallLoudnessResults__DelegateSignature_IsValid = OnOverallLoudnessResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnOverallLoudnessResults__DelegateSignature", OnOverallLoudnessResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FLoudnessResults> OverallLoudnessResults)
	{
		if (!OnOverallLoudnessResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnOverallLoudnessResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnOverallLoudnessResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOverallLoudnessResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FLoudnessResults>(1, OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_PropertyAddress, CachedMarshalingDelegates<FLoudnessResults, FLoudnessResults>.FromNative, CachedMarshalingDelegates<FLoudnessResults, FLoudnessResults>.ToNative).ToNative(IntPtr.Add(intPtr, OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_Offset), OverallLoudnessResults);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnOverallLoudnessResults__DelegateSignature_OverallLoudnessResults_PropertyAddress.Address, intPtr);
		}
	}
}
