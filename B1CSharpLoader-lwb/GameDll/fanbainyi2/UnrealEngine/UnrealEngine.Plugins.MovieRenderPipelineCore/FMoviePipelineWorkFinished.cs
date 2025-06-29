using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UDelegate]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineWorkFinished__DelegateSignature")]
public class FMoviePipelineWorkFinished : FMulticastDelegate<FMoviePipelineWorkFinished.Signature>
{
	public delegate void Signature(FMoviePipelineOutputData Results);

	private static bool MoviePipelineWorkFinished__DelegateSignature_IsValid;

	private static IntPtr MoviePipelineWorkFinished__DelegateSignature_FunctionAddress;

	private static int MoviePipelineWorkFinished__DelegateSignature_ParamsSize;

	private static bool MoviePipelineWorkFinished__DelegateSignature_Results_IsValid;

	private static FFieldAddress MoviePipelineWorkFinished__DelegateSignature_Results_PropertyAddress;

	private static int MoviePipelineWorkFinished__DelegateSignature_Results_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMoviePipelineWorkFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MoviePipelineWorkFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieRenderPipelineCore.MoviePipelineWorkFinished__DelegateSignature");
		MoviePipelineWorkFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MoviePipelineWorkFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineWorkFinished__DelegateSignature_Results_PropertyAddress, MoviePipelineWorkFinished__DelegateSignature_FunctionAddress, "Results");
		MoviePipelineWorkFinished__DelegateSignature_Results_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineWorkFinished__DelegateSignature_FunctionAddress, "Results");
		MoviePipelineWorkFinished__DelegateSignature_Results_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineWorkFinished__DelegateSignature_FunctionAddress, "Results", Classes.FStructProperty);
		MoviePipelineWorkFinished__DelegateSignature_IsValid = MoviePipelineWorkFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && MoviePipelineWorkFinished__DelegateSignature_Results_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineWorkFinished__DelegateSignature", MoviePipelineWorkFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FMoviePipelineOutputData Results)
	{
		if (!MoviePipelineWorkFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineWorkFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MoviePipelineWorkFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoviePipelineWorkFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(MoviePipelineWorkFinished__DelegateSignature_Results_PropertyAddress.Address, intPtr);
			FMoviePipelineOutputData.ToNative(IntPtr.Add(intPtr, MoviePipelineWorkFinished__DelegateSignature_Results_Offset), 0, MoviePipelineWorkFinished__DelegateSignature_Results_PropertyAddress.Address, Results);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(MoviePipelineWorkFinished__DelegateSignature_Results_PropertyAddress.Address, intPtr);
		}
	}
}
