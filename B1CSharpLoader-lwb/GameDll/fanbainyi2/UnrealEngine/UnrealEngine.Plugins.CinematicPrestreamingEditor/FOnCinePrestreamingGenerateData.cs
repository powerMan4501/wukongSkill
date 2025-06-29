using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreamingEditor;

[UDelegate]
[UMetaPath("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateData__DelegateSignature")]
public class FOnCinePrestreamingGenerateData : FMulticastDelegate<FOnCinePrestreamingGenerateData.Signature>
{
	public delegate void Signature(List<FMoviePipelineCinePrestreamingGeneratedData> GeneratedData);

	private static bool OnCinePrestreamingGenerateData__DelegateSignature_IsValid;

	private static IntPtr OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress;

	private static int OnCinePrestreamingGenerateData__DelegateSignature_ParamsSize;

	private static bool OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_IsValid;

	private static FFieldAddress OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_PropertyAddress;

	private static int OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnCinePrestreamingGenerateData()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateData__DelegateSignature");
		OnCinePrestreamingGenerateData__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_PropertyAddress, OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress, "GeneratedData");
		OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_Offset = NativeReflectionCached.GetPropertyOffset(OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress, "GeneratedData");
		OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress, "GeneratedData", Classes.FArrayProperty);
		OnCinePrestreamingGenerateData__DelegateSignature_IsValid = OnCinePrestreamingGenerateData__DelegateSignature_FunctionAddress != IntPtr.Zero && OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateData__DelegateSignature", OnCinePrestreamingGenerateData__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FMoviePipelineCinePrestreamingGeneratedData> GeneratedData)
	{
		if (!OnCinePrestreamingGenerateData__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateData__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnCinePrestreamingGenerateData__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCinePrestreamingGenerateData__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FMoviePipelineCinePrestreamingGeneratedData>(1, OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_PropertyAddress, CachedMarshalingDelegates<FMoviePipelineCinePrestreamingGeneratedData, FMoviePipelineCinePrestreamingGeneratedData>.FromNative, CachedMarshalingDelegates<FMoviePipelineCinePrestreamingGeneratedData, FMoviePipelineCinePrestreamingGeneratedData>.ToNative).ToNative(IntPtr.Add(intPtr, OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_Offset), GeneratedData);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnCinePrestreamingGenerateData__DelegateSignature_GeneratedData_PropertyAddress.Address, intPtr);
		}
	}
}
