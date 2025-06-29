using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnLatestOverallMeterResults__DelegateSignature")]
public class FOnLatestOverallMeterResults : FMulticastDelegate<FOnLatestOverallMeterResults.Signature>
{
	public delegate void Signature(FMeterResults LatestOverallMeterResults);

	private static bool OnLatestOverallMeterResults__DelegateSignature_IsValid;

	private static IntPtr OnLatestOverallMeterResults__DelegateSignature_FunctionAddress;

	private static int OnLatestOverallMeterResults__DelegateSignature_ParamsSize;

	private static bool OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_IsValid;

	private static FFieldAddress OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_PropertyAddress;

	private static int OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnLatestOverallMeterResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnLatestOverallMeterResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnLatestOverallMeterResults__DelegateSignature");
		OnLatestOverallMeterResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLatestOverallMeterResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_PropertyAddress, OnLatestOverallMeterResults__DelegateSignature_FunctionAddress, "LatestOverallMeterResults");
		OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_Offset = NativeReflectionCached.GetPropertyOffset(OnLatestOverallMeterResults__DelegateSignature_FunctionAddress, "LatestOverallMeterResults");
		OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLatestOverallMeterResults__DelegateSignature_FunctionAddress, "LatestOverallMeterResults", Classes.FStructProperty);
		OnLatestOverallMeterResults__DelegateSignature_IsValid = OnLatestOverallMeterResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnLatestOverallMeterResults__DelegateSignature", OnLatestOverallMeterResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FMeterResults LatestOverallMeterResults)
	{
		if (!OnLatestOverallMeterResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnLatestOverallMeterResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnLatestOverallMeterResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLatestOverallMeterResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_PropertyAddress.Address, intPtr);
			FMeterResults.ToNative(IntPtr.Add(intPtr, OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_Offset), 0, OnLatestOverallMeterResults__DelegateSignature_LatestOverallMeterResults_PropertyAddress.Address, LatestOverallMeterResults);
			ProcessDelegate(intPtr);
		}
	}
}
