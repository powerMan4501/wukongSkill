using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnLatestOverallLoudnessResults__DelegateSignature")]
public class FOnLatestOverallLoudnessResults : FMulticastDelegate<FOnLatestOverallLoudnessResults.Signature>
{
	public delegate void Signature(FLoudnessResults LatestOverallLoudnessResults);

	private static bool OnLatestOverallLoudnessResults__DelegateSignature_IsValid;

	private static IntPtr OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress;

	private static int OnLatestOverallLoudnessResults__DelegateSignature_ParamsSize;

	private static bool OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_IsValid;

	private static FFieldAddress OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_PropertyAddress;

	private static int OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnLatestOverallLoudnessResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnLatestOverallLoudnessResults__DelegateSignature");
		OnLatestOverallLoudnessResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_PropertyAddress, OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress, "LatestOverallLoudnessResults");
		OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress, "LatestOverallLoudnessResults");
		OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress, "LatestOverallLoudnessResults", Classes.FStructProperty);
		OnLatestOverallLoudnessResults__DelegateSignature_IsValid = OnLatestOverallLoudnessResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnLatestOverallLoudnessResults__DelegateSignature", OnLatestOverallLoudnessResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FLoudnessResults LatestOverallLoudnessResults)
	{
		if (!OnLatestOverallLoudnessResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnLatestOverallLoudnessResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnLatestOverallLoudnessResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLatestOverallLoudnessResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_PropertyAddress.Address, intPtr);
			FLoudnessResults.ToNative(IntPtr.Add(intPtr, OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_Offset), 0, OnLatestOverallLoudnessResults__DelegateSignature_LatestOverallLoudnessResults_PropertyAddress.Address, LatestOverallLoudnessResults);
			ProcessDelegate(intPtr);
		}
	}
}
