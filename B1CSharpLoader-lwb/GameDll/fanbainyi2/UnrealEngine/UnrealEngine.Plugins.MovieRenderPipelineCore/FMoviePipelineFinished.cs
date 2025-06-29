using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UDelegate]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFinished__DelegateSignature")]
public class FMoviePipelineFinished : FMulticastDelegate<FMoviePipelineFinished.Signature>
{
	public delegate void Signature(UMoviePipeline MoviePipeline, bool bFatalError);

	private static bool MoviePipelineFinished__DelegateSignature_IsValid;

	private static IntPtr MoviePipelineFinished__DelegateSignature_FunctionAddress;

	private static int MoviePipelineFinished__DelegateSignature_ParamsSize;

	private static bool MoviePipelineFinished__DelegateSignature_MoviePipeline_IsValid;

	private static FFieldAddress MoviePipelineFinished__DelegateSignature_MoviePipeline_PropertyAddress;

	private static int MoviePipelineFinished__DelegateSignature_MoviePipeline_Offset;

	private static bool MoviePipelineFinished__DelegateSignature_bFatalError_IsValid;

	private static FFieldAddress MoviePipelineFinished__DelegateSignature_bFatalError_PropertyAddress;

	private static int MoviePipelineFinished__DelegateSignature_bFatalError_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMoviePipelineFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MoviePipelineFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieRenderPipelineCore.MoviePipelineFinished__DelegateSignature");
		MoviePipelineFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MoviePipelineFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineFinished__DelegateSignature_MoviePipeline_PropertyAddress, MoviePipelineFinished__DelegateSignature_FunctionAddress, "MoviePipeline");
		MoviePipelineFinished__DelegateSignature_MoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineFinished__DelegateSignature_FunctionAddress, "MoviePipeline");
		MoviePipelineFinished__DelegateSignature_MoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineFinished__DelegateSignature_FunctionAddress, "MoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineFinished__DelegateSignature_bFatalError_PropertyAddress, MoviePipelineFinished__DelegateSignature_FunctionAddress, "bFatalError");
		MoviePipelineFinished__DelegateSignature_bFatalError_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineFinished__DelegateSignature_FunctionAddress, "bFatalError");
		MoviePipelineFinished__DelegateSignature_bFatalError_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineFinished__DelegateSignature_FunctionAddress, "bFatalError", Classes.FBoolProperty);
		MoviePipelineFinished__DelegateSignature_IsValid = MoviePipelineFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && MoviePipelineFinished__DelegateSignature_MoviePipeline_IsValid && MoviePipelineFinished__DelegateSignature_bFatalError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineFinished__DelegateSignature", MoviePipelineFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UMoviePipeline MoviePipeline, bool bFatalError)
	{
		if (!MoviePipelineFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MoviePipelineFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoviePipelineFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, MoviePipelineFinished__DelegateSignature_MoviePipeline_Offset), 0, MoviePipelineFinished__DelegateSignature_MoviePipeline_PropertyAddress.Address, MoviePipeline);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoviePipelineFinished__DelegateSignature_bFatalError_Offset), 0, MoviePipelineFinished__DelegateSignature_bFatalError_PropertyAddress.Address, bFatalError);
			ProcessDelegate(intPtr);
		}
	}
}
