using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnSubmixSpectralAnalysisBP__DelegateSignature")]
public class FOnSubmixSpectralAnalysisBP : FDelegate<FOnSubmixSpectralAnalysisBP.Signature>
{
	public delegate void Signature(List<float> Magnitude);

	private static bool OnSubmixSpectralAnalysisBP__DelegateSignature_IsValid;

	private static IntPtr OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress;

	private static int OnSubmixSpectralAnalysisBP__DelegateSignature_ParamsSize;

	private static bool OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_IsValid;

	private static FFieldAddress OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_PropertyAddress;

	private static int OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSubmixSpectralAnalysisBP()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnSubmixSpectralAnalysisBP__DelegateSignature");
		OnSubmixSpectralAnalysisBP__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_PropertyAddress, OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress, "Magnitude");
		OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress, "Magnitude");
		OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress, "Magnitude", Classes.FArrayProperty);
		OnSubmixSpectralAnalysisBP__DelegateSignature_IsValid = OnSubmixSpectralAnalysisBP__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnSubmixSpectralAnalysisBP__DelegateSignature", OnSubmixSpectralAnalysisBP__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<float> Magnitude)
	{
		if (!OnSubmixSpectralAnalysisBP__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnSubmixSpectralAnalysisBP__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSubmixSpectralAnalysisBP__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSubmixSpectralAnalysisBP__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<float>(1, OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_Offset), Magnitude);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnSubmixSpectralAnalysisBP__DelegateSignature_Magnitude_PropertyAddress.Address, intPtr);
		}
	}
}
