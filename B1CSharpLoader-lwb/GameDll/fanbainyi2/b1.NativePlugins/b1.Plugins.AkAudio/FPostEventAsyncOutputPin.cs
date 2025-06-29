using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.PostEventAsyncOutputPin__DelegateSignature")]
public class FPostEventAsyncOutputPin : FMulticastDelegate<FPostEventAsyncOutputPin.Signature>
{
	public delegate void Signature(int PlayingID);

	private static bool PostEventAsyncOutputPin__DelegateSignature_IsValid;

	private static IntPtr PostEventAsyncOutputPin__DelegateSignature_FunctionAddress;

	private static int PostEventAsyncOutputPin__DelegateSignature_ParamsSize;

	private static bool PostEventAsyncOutputPin__DelegateSignature_PlayingID_IsValid;

	private static FFieldAddress PostEventAsyncOutputPin__DelegateSignature_PlayingID_PropertyAddress;

	private static int PostEventAsyncOutputPin__DelegateSignature_PlayingID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPostEventAsyncOutputPin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PostEventAsyncOutputPin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.PostEventAsyncOutputPin__DelegateSignature");
		PostEventAsyncOutputPin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEventAsyncOutputPin__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostEventAsyncOutputPin__DelegateSignature_PlayingID_PropertyAddress, PostEventAsyncOutputPin__DelegateSignature_FunctionAddress, "PlayingID");
		PostEventAsyncOutputPin__DelegateSignature_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAsyncOutputPin__DelegateSignature_FunctionAddress, "PlayingID");
		PostEventAsyncOutputPin__DelegateSignature_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAsyncOutputPin__DelegateSignature_FunctionAddress, "PlayingID", Classes.FIntProperty);
		PostEventAsyncOutputPin__DelegateSignature_IsValid = PostEventAsyncOutputPin__DelegateSignature_FunctionAddress != IntPtr.Zero && PostEventAsyncOutputPin__DelegateSignature_PlayingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.PostEventAsyncOutputPin__DelegateSignature", PostEventAsyncOutputPin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int PlayingID)
	{
		if (!PostEventAsyncOutputPin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.PostEventAsyncOutputPin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PostEventAsyncOutputPin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEventAsyncOutputPin__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostEventAsyncOutputPin__DelegateSignature_PlayingID_Offset), 0, PostEventAsyncOutputPin__DelegateSignature_PlayingID_PropertyAddress.Address, PlayingID);
			ProcessDelegate(intPtr);
		}
	}
}
