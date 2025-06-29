using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UDelegate]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneActorPredictionFailure__DelegateSignature")]
public class FMovieSceneActorPredictionFailure : FMulticastDelegate<FMovieSceneActorPredictionFailure.Signature>
{
	public delegate void Signature();

	private static bool MovieSceneActorPredictionFailure__DelegateSignature_IsValid;

	private static IntPtr MovieSceneActorPredictionFailure__DelegateSignature_FunctionAddress;

	private static int MovieSceneActorPredictionFailure__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMovieSceneActorPredictionFailure()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MovieSceneActorPredictionFailure__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieSceneTracks.MovieSceneActorPredictionFailure__DelegateSignature");
		MovieSceneActorPredictionFailure__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MovieSceneActorPredictionFailure__DelegateSignature_FunctionAddress);
		MovieSceneActorPredictionFailure__DelegateSignature_IsValid = MovieSceneActorPredictionFailure__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneActorPredictionFailure__DelegateSignature", MovieSceneActorPredictionFailure__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!MovieSceneActorPredictionFailure__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneActorPredictionFailure__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MovieSceneActorPredictionFailure__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MovieSceneActorPredictionFailure__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
