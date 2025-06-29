using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UDelegate]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineHttpResponseRecieved__DelegateSignature")]
public class FMoviePipelineHttpResponseRecieved : FMulticastDelegate<FMoviePipelineHttpResponseRecieved.Signature>
{
	public delegate void Signature(int RequestIndex, int ResponseCode, string Message);

	private static bool MoviePipelineHttpResponseRecieved__DelegateSignature_IsValid;

	private static IntPtr MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress;

	private static int MoviePipelineHttpResponseRecieved__DelegateSignature_ParamsSize;

	private static bool MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_IsValid;

	private static FFieldAddress MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_PropertyAddress;

	private static int MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_Offset;

	private static bool MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_IsValid;

	private static FFieldAddress MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_PropertyAddress;

	private static int MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_Offset;

	private static bool MoviePipelineHttpResponseRecieved__DelegateSignature_Message_IsValid;

	private static FFieldAddress MoviePipelineHttpResponseRecieved__DelegateSignature_Message_PropertyAddress;

	private static int MoviePipelineHttpResponseRecieved__DelegateSignature_Message_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMoviePipelineHttpResponseRecieved()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MovieRenderPipelineCore.MoviePipelineHttpResponseRecieved__DelegateSignature");
		MoviePipelineHttpResponseRecieved__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_PropertyAddress, MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "RequestIndex");
		MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "RequestIndex");
		MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "RequestIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_PropertyAddress, MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "ResponseCode");
		MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "ResponseCode");
		MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "ResponseCode", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MoviePipelineHttpResponseRecieved__DelegateSignature_Message_PropertyAddress, MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "Message");
		MoviePipelineHttpResponseRecieved__DelegateSignature_Message_Offset = NativeReflectionCached.GetPropertyOffset(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "Message");
		MoviePipelineHttpResponseRecieved__DelegateSignature_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress, "Message", Classes.FStrProperty);
		MoviePipelineHttpResponseRecieved__DelegateSignature_IsValid = MoviePipelineHttpResponseRecieved__DelegateSignature_FunctionAddress != IntPtr.Zero && MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_IsValid && MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_IsValid && MoviePipelineHttpResponseRecieved__DelegateSignature_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineHttpResponseRecieved__DelegateSignature", MoviePipelineHttpResponseRecieved__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int RequestIndex, int ResponseCode, string Message)
	{
		if (!MoviePipelineHttpResponseRecieved__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineHttpResponseRecieved__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MoviePipelineHttpResponseRecieved__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoviePipelineHttpResponseRecieved__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_Offset), 0, MoviePipelineHttpResponseRecieved__DelegateSignature_RequestIndex_PropertyAddress.Address, RequestIndex);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_Offset), 0, MoviePipelineHttpResponseRecieved__DelegateSignature_ResponseCode_PropertyAddress.Address, ResponseCode);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoviePipelineHttpResponseRecieved__DelegateSignature_Message_Offset), 0, MoviePipelineHttpResponseRecieved__DelegateSignature_Message_PropertyAddress.Address, Message);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(MoviePipelineHttpResponseRecieved__DelegateSignature_Message_PropertyAddress.Address, intPtr);
		}
	}
}
