using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UDelegate]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSocketMessageRecieved__DelegateSignature")]
public class FMoviePipelineSocketMessageRecieved : FMulticastDelegate<FMoviePipelineSocketMessageRecieved.Signature>
{
	public delegate void Signature(string Message);

	private static bool MoviePipelineSocketMessageRecieved__DelegateSignature_IsValid;

	private static IntPtr MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress;

	private static int MoviePipelineSocketMessageRecieved__DelegateSignature_ParamsSize;

	private static bool MoviePipelineSocketMessageRecieved__DelegateSignature_Message_IsValid;

	private static FFieldAddress MoviePipelineSocketMessageRecieved__DelegateSignature_Message_PropertyAddress;

	private static int MoviePipelineSocketMessageRecieved__DelegateSignature_Message_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMoviePipelineSocketMessageRecieved()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieRenderPipelineCore.MoviePipelineSocketMessageRecieved__DelegateSignature");
		MoviePipelineSocketMessageRecieved__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineSocketMessageRecieved__DelegateSignature_Message_PropertyAddress, MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress, "Message");
		MoviePipelineSocketMessageRecieved__DelegateSignature_Message_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress, "Message");
		MoviePipelineSocketMessageRecieved__DelegateSignature_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress, "Message", Classes.FStrProperty);
		MoviePipelineSocketMessageRecieved__DelegateSignature_IsValid = MoviePipelineSocketMessageRecieved__DelegateSignature_FunctionAddress != IntPtr.Zero && MoviePipelineSocketMessageRecieved__DelegateSignature_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSocketMessageRecieved__DelegateSignature", MoviePipelineSocketMessageRecieved__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string Message)
	{
		if (!MoviePipelineSocketMessageRecieved__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSocketMessageRecieved__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MoviePipelineSocketMessageRecieved__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoviePipelineSocketMessageRecieved__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoviePipelineSocketMessageRecieved__DelegateSignature_Message_Offset), 0, MoviePipelineSocketMessageRecieved__DelegateSignature_Message_PropertyAddress.Address, Message);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(MoviePipelineSocketMessageRecieved__DelegateSignature_Message_PropertyAddress.Address, intPtr);
		}
	}
}
