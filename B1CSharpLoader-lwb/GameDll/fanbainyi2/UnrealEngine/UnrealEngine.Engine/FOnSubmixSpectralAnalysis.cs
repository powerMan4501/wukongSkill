using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnSubmixSpectralAnalysis__DelegateSignature")]
public class FOnSubmixSpectralAnalysis : FMulticastDelegate<FOnSubmixSpectralAnalysis.Signature>
{
	public delegate void Signature(List<float> Magnitudes);

	private static bool OnSubmixSpectralAnalysis__DelegateSignature_IsValid;

	private static IntPtr OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress;

	private static int OnSubmixSpectralAnalysis__DelegateSignature_ParamsSize;

	private static bool OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_IsValid;

	private static FFieldAddress OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_PropertyAddress;

	private static int OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSubmixSpectralAnalysis()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnSubmixSpectralAnalysis__DelegateSignature");
		OnSubmixSpectralAnalysis__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_PropertyAddress, OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress, "Magnitudes");
		OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_Offset = NativeReflectionCached.GetPropertyOffset(OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress, "Magnitudes");
		OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress, "Magnitudes", Classes.FArrayProperty);
		OnSubmixSpectralAnalysis__DelegateSignature_IsValid = OnSubmixSpectralAnalysis__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnSubmixSpectralAnalysis__DelegateSignature", OnSubmixSpectralAnalysis__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<float> Magnitudes)
	{
		if (!OnSubmixSpectralAnalysis__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnSubmixSpectralAnalysis__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSubmixSpectralAnalysis__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSubmixSpectralAnalysis__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<float>(1, OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_Offset), Magnitudes);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnSubmixSpectralAnalysis__DelegateSignature_Magnitudes_PropertyAddress.Address, intPtr);
		}
	}
}
