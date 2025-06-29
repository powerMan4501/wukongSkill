using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UDelegate]
[UMetaPath("/Script/MovieRenderPipelineCore.OnMoviePipelineExecutorFinished__DelegateSignature")]
public class FOnMoviePipelineExecutorFinished : FMulticastDelegate<FOnMoviePipelineExecutorFinished.Signature>
{
	public delegate void Signature(UMoviePipelineExecutorBase PipelineExecutor, bool bSuccess);

	private static bool OnMoviePipelineExecutorFinished__DelegateSignature_IsValid;

	private static IntPtr OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress;

	private static int OnMoviePipelineExecutorFinished__DelegateSignature_ParamsSize;

	private static bool OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_IsValid;

	private static FFieldAddress OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_PropertyAddress;

	private static int OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_Offset;

	private static bool OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMoviePipelineExecutorFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieRenderPipelineCore.OnMoviePipelineExecutorFinished__DelegateSignature");
		OnMoviePipelineExecutorFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_PropertyAddress, OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress, "PipelineExecutor");
		OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_Offset = NativeReflectionCached.GetPropertyOffset(OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress, "PipelineExecutor");
		OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress, "PipelineExecutor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_PropertyAddress, OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress, "bSuccess");
		OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress, "bSuccess");
		OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnMoviePipelineExecutorFinished__DelegateSignature_IsValid = OnMoviePipelineExecutorFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_IsValid && OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.OnMoviePipelineExecutorFinished__DelegateSignature", OnMoviePipelineExecutorFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UMoviePipelineExecutorBase PipelineExecutor, bool bSuccess)
	{
		if (!OnMoviePipelineExecutorFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.OnMoviePipelineExecutorFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMoviePipelineExecutorFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMoviePipelineExecutorFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UMoviePipelineExecutorBase>.ToNative(IntPtr.Add(intPtr, OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_Offset), 0, OnMoviePipelineExecutorFinished__DelegateSignature_PipelineExecutor_PropertyAddress.Address, PipelineExecutor);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_Offset), 0, OnMoviePipelineExecutorFinished__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
