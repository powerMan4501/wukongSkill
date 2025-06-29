using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnSamplePlaybackProgress__DelegateSignature")]
public class FOnSamplePlaybackProgress : FMulticastDelegate<FOnSamplePlaybackProgress.Signature>
{
	public delegate void Signature(float ProgressPercent, float ProgressTimeSeconds);

	private static bool OnSamplePlaybackProgress__DelegateSignature_IsValid;

	private static IntPtr OnSamplePlaybackProgress__DelegateSignature_FunctionAddress;

	private static int OnSamplePlaybackProgress__DelegateSignature_ParamsSize;

	private static bool OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_IsValid;

	private static FFieldAddress OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_PropertyAddress;

	private static int OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_Offset;

	private static bool OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_IsValid;

	private static FFieldAddress OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_PropertyAddress;

	private static int OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSamplePlaybackProgress()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSamplePlaybackProgress__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnSamplePlaybackProgress__DelegateSignature");
		OnSamplePlaybackProgress__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSamplePlaybackProgress__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_PropertyAddress, OnSamplePlaybackProgress__DelegateSignature_FunctionAddress, "ProgressPercent");
		OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_Offset = NativeReflectionCached.GetPropertyOffset(OnSamplePlaybackProgress__DelegateSignature_FunctionAddress, "ProgressPercent");
		OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSamplePlaybackProgress__DelegateSignature_FunctionAddress, "ProgressPercent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_PropertyAddress, OnSamplePlaybackProgress__DelegateSignature_FunctionAddress, "ProgressTimeSeconds");
		OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_Offset = NativeReflectionCached.GetPropertyOffset(OnSamplePlaybackProgress__DelegateSignature_FunctionAddress, "ProgressTimeSeconds");
		OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSamplePlaybackProgress__DelegateSignature_FunctionAddress, "ProgressTimeSeconds", Classes.FFloatProperty);
		OnSamplePlaybackProgress__DelegateSignature_IsValid = OnSamplePlaybackProgress__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_IsValid && OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnSamplePlaybackProgress__DelegateSignature", OnSamplePlaybackProgress__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float ProgressPercent, float ProgressTimeSeconds)
	{
		if (!OnSamplePlaybackProgress__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnSamplePlaybackProgress__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSamplePlaybackProgress__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSamplePlaybackProgress__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_Offset), 0, OnSamplePlaybackProgress__DelegateSignature_ProgressPercent_PropertyAddress.Address, ProgressPercent);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_Offset), 0, OnSamplePlaybackProgress__DelegateSignature_ProgressTimeSeconds_PropertyAddress.Address, ProgressTimeSeconds);
			ProcessDelegate(intPtr);
		}
	}
}
