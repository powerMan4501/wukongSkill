using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UDelegate]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneActorPredictionResult__DelegateSignature")]
public class FMovieSceneActorPredictionResult : FMulticastDelegate<FMovieSceneActorPredictionResult.Signature>
{
	public delegate void Signature(FTransform PredictedTransform);

	private static bool MovieSceneActorPredictionResult__DelegateSignature_IsValid;

	private static IntPtr MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress;

	private static int MovieSceneActorPredictionResult__DelegateSignature_ParamsSize;

	private static bool MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_IsValid;

	private static FFieldAddress MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_PropertyAddress;

	private static int MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMovieSceneActorPredictionResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieSceneTracks.MovieSceneActorPredictionResult__DelegateSignature");
		MovieSceneActorPredictionResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_PropertyAddress, MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress, "PredictedTransform");
		MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_Offset = NativeReflectionCached.GetPropertyOffset(MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress, "PredictedTransform");
		MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress, "PredictedTransform", Classes.FStructProperty);
		MovieSceneActorPredictionResult__DelegateSignature_IsValid = MovieSceneActorPredictionResult__DelegateSignature_FunctionAddress != IntPtr.Zero && MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneActorPredictionResult__DelegateSignature", MovieSceneActorPredictionResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FTransform PredictedTransform)
	{
		if (!MovieSceneActorPredictionResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneActorPredictionResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MovieSceneActorPredictionResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MovieSceneActorPredictionResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_PropertyAddress.Address, intPtr);
			BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_Offset), 0, MovieSceneActorPredictionResult__DelegateSignature_PredictedTransform_PropertyAddress.Address, PredictedTransform);
			ProcessDelegate(intPtr);
		}
	}
}
