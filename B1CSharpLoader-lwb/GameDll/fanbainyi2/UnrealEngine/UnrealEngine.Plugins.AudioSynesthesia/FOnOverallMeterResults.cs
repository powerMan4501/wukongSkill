using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UDelegate]
[UMetaPath("/Script/AudioSynesthesia.OnOverallMeterResults__DelegateSignature")]
public class FOnOverallMeterResults : FMulticastDelegate<FOnOverallMeterResults.Signature>
{
	public delegate void Signature(List<FMeterResults> MeterResults);

	private static bool OnOverallMeterResults__DelegateSignature_IsValid;

	private static IntPtr OnOverallMeterResults__DelegateSignature_FunctionAddress;

	private static int OnOverallMeterResults__DelegateSignature_ParamsSize;

	private static bool OnOverallMeterResults__DelegateSignature_MeterResults_IsValid;

	private static FFieldAddress OnOverallMeterResults__DelegateSignature_MeterResults_PropertyAddress;

	private static int OnOverallMeterResults__DelegateSignature_MeterResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnOverallMeterResults()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnOverallMeterResults__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioSynesthesia.OnOverallMeterResults__DelegateSignature");
		OnOverallMeterResults__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnOverallMeterResults__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnOverallMeterResults__DelegateSignature_MeterResults_PropertyAddress, OnOverallMeterResults__DelegateSignature_FunctionAddress, "MeterResults");
		OnOverallMeterResults__DelegateSignature_MeterResults_Offset = NativeReflectionCached.GetPropertyOffset(OnOverallMeterResults__DelegateSignature_FunctionAddress, "MeterResults");
		OnOverallMeterResults__DelegateSignature_MeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(OnOverallMeterResults__DelegateSignature_FunctionAddress, "MeterResults", Classes.FArrayProperty);
		OnOverallMeterResults__DelegateSignature_IsValid = OnOverallMeterResults__DelegateSignature_FunctionAddress != IntPtr.Zero && OnOverallMeterResults__DelegateSignature_MeterResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.OnOverallMeterResults__DelegateSignature", OnOverallMeterResults__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FMeterResults> MeterResults)
	{
		if (!OnOverallMeterResults__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.OnOverallMeterResults__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnOverallMeterResults__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOverallMeterResults__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FMeterResults>(1, OnOverallMeterResults__DelegateSignature_MeterResults_PropertyAddress, CachedMarshalingDelegates<FMeterResults, FMeterResults>.FromNative, CachedMarshalingDelegates<FMeterResults, FMeterResults>.ToNative).ToNative(IntPtr.Add(intPtr, OnOverallMeterResults__DelegateSignature_MeterResults_Offset), MeterResults);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnOverallMeterResults__DelegateSignature_MeterResults_PropertyAddress.Address, intPtr);
		}
	}
}
