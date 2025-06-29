using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.OnAsyncCaptureSceneComplete__DelegateSignature")]
public class FOnAsyncCaptureSceneComplete : FMulticastDelegate<FOnAsyncCaptureSceneComplete.Signature>
{
	public delegate void Signature(UTextureRenderTarget2D Texture);

	private static bool OnAsyncCaptureSceneComplete__DelegateSignature_IsValid;

	private static IntPtr OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress;

	private static int OnAsyncCaptureSceneComplete__DelegateSignature_ParamsSize;

	private static bool OnAsyncCaptureSceneComplete__DelegateSignature_Texture_IsValid;

	private static FFieldAddress OnAsyncCaptureSceneComplete__DelegateSignature_Texture_PropertyAddress;

	private static int OnAsyncCaptureSceneComplete__DelegateSignature_Texture_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAsyncCaptureSceneComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.OnAsyncCaptureSceneComplete__DelegateSignature");
		OnAsyncCaptureSceneComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAsyncCaptureSceneComplete__DelegateSignature_Texture_PropertyAddress, OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress, "Texture");
		OnAsyncCaptureSceneComplete__DelegateSignature_Texture_Offset = NativeReflectionCached.GetPropertyOffset(OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress, "Texture");
		OnAsyncCaptureSceneComplete__DelegateSignature_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress, "Texture", Classes.FObjectProperty);
		OnAsyncCaptureSceneComplete__DelegateSignature_IsValid = OnAsyncCaptureSceneComplete__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAsyncCaptureSceneComplete__DelegateSignature_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.OnAsyncCaptureSceneComplete__DelegateSignature", OnAsyncCaptureSceneComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UTextureRenderTarget2D Texture)
	{
		if (!OnAsyncCaptureSceneComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.OnAsyncCaptureSceneComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAsyncCaptureSceneComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAsyncCaptureSceneComplete__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, OnAsyncCaptureSceneComplete__DelegateSignature_Texture_Offset), 0, OnAsyncCaptureSceneComplete__DelegateSignature_Texture_PropertyAddress.Address, Texture);
			ProcessDelegate(intPtr);
		}
	}
}
