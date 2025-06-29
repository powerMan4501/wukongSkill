using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineEditor;

[UDelegate]
[UMetaPath("/Script/MovieRenderPipelineEditor.OnMoviePipelineIndividualJobFinished__DelegateSignature")]
public class FOnMoviePipelineIndividualJobFinished : FMulticastDelegate<FOnMoviePipelineIndividualJobFinished.Signature>
{
	public delegate void Signature(UMoviePipelineExecutorJob FinishedJob, bool bSuccess);

	private static bool OnMoviePipelineIndividualJobFinished__DelegateSignature_IsValid;

	private static IntPtr OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress;

	private static int OnMoviePipelineIndividualJobFinished__DelegateSignature_ParamsSize;

	private static bool OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_IsValid;

	private static FFieldAddress OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_PropertyAddress;

	private static int OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_Offset;

	private static bool OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMoviePipelineIndividualJobFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieRenderPipelineEditor.OnMoviePipelineIndividualJobFinished__DelegateSignature");
		OnMoviePipelineIndividualJobFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_PropertyAddress, OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress, "FinishedJob");
		OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_Offset = NativeReflectionCached.GetPropertyOffset(OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress, "FinishedJob");
		OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress, "FinishedJob", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_PropertyAddress, OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress, "bSuccess");
		OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress, "bSuccess");
		OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnMoviePipelineIndividualJobFinished__DelegateSignature_IsValid = OnMoviePipelineIndividualJobFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_IsValid && OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.OnMoviePipelineIndividualJobFinished__DelegateSignature", OnMoviePipelineIndividualJobFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UMoviePipelineExecutorJob FinishedJob, bool bSuccess)
	{
		if (!OnMoviePipelineIndividualJobFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.OnMoviePipelineIndividualJobFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMoviePipelineIndividualJobFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMoviePipelineIndividualJobFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_Offset), 0, OnMoviePipelineIndividualJobFinished__DelegateSignature_FinishedJob_PropertyAddress.Address, FinishedJob);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_Offset), 0, OnMoviePipelineIndividualJobFinished__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
