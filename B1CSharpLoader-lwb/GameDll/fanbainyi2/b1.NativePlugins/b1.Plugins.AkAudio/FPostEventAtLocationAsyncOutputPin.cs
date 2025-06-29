using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.PostEventAtLocationAsyncOutputPin__DelegateSignature")]
public class FPostEventAtLocationAsyncOutputPin : FMulticastDelegate<FPostEventAtLocationAsyncOutputPin.Signature>
{
	public delegate void Signature(int PlayingID);

	private static bool PostEventAtLocationAsyncOutputPin__DelegateSignature_IsValid;

	private static IntPtr PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress;

	private static int PostEventAtLocationAsyncOutputPin__DelegateSignature_ParamsSize;

	private static bool PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_IsValid;

	private static FFieldAddress PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_PropertyAddress;

	private static int PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPostEventAtLocationAsyncOutputPin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.PostEventAtLocationAsyncOutputPin__DelegateSignature");
		PostEventAtLocationAsyncOutputPin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_PropertyAddress, PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress, "PlayingID");
		PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress, "PlayingID");
		PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress, "PlayingID", Classes.FIntProperty);
		PostEventAtLocationAsyncOutputPin__DelegateSignature_IsValid = PostEventAtLocationAsyncOutputPin__DelegateSignature_FunctionAddress != IntPtr.Zero && PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.PostEventAtLocationAsyncOutputPin__DelegateSignature", PostEventAtLocationAsyncOutputPin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int PlayingID)
	{
		if (!PostEventAtLocationAsyncOutputPin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.PostEventAtLocationAsyncOutputPin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PostEventAtLocationAsyncOutputPin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEventAtLocationAsyncOutputPin__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_Offset), 0, PostEventAtLocationAsyncOutputPin__DelegateSignature_PlayingID_PropertyAddress.Address, PlayingID);
			ProcessDelegate(intPtr);
		}
	}
}
