using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UDelegate]
[UMetaPath("/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature")]
public class FOnMovieSceneSequencePlayerEvent : FMulticastDelegate<FOnMovieSceneSequencePlayerEvent.Signature>
{
	public delegate void Signature();

	private static bool OnMovieSceneSequencePlayerEvent__DelegateSignature_IsValid;

	private static IntPtr OnMovieSceneSequencePlayerEvent__DelegateSignature_FunctionAddress;

	private static int OnMovieSceneSequencePlayerEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMovieSceneSequencePlayerEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMovieSceneSequencePlayerEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature");
		OnMovieSceneSequencePlayerEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMovieSceneSequencePlayerEvent__DelegateSignature_FunctionAddress);
		OnMovieSceneSequencePlayerEvent__DelegateSignature_IsValid = OnMovieSceneSequencePlayerEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature", OnMovieSceneSequencePlayerEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMovieSceneSequencePlayerEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.OnMovieSceneSequencePlayerEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMovieSceneSequencePlayerEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMovieSceneSequencePlayerEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
