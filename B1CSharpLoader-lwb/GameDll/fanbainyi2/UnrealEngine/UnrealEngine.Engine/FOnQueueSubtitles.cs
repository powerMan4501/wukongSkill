using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnQueueSubtitles__DelegateSignature")]
public class FOnQueueSubtitles : FDelegate<FOnQueueSubtitles.Signature>
{
	public delegate void Signature(List<FSubtitleCue> Subtitles, float CueDuration);

	private static bool OnQueueSubtitles__DelegateSignature_IsValid;

	private static IntPtr OnQueueSubtitles__DelegateSignature_FunctionAddress;

	private static int OnQueueSubtitles__DelegateSignature_ParamsSize;

	private static bool OnQueueSubtitles__DelegateSignature_Subtitles_IsValid;

	private static FFieldAddress OnQueueSubtitles__DelegateSignature_Subtitles_PropertyAddress;

	private static int OnQueueSubtitles__DelegateSignature_Subtitles_Offset;

	private static bool OnQueueSubtitles__DelegateSignature_CueDuration_IsValid;

	private static FFieldAddress OnQueueSubtitles__DelegateSignature_CueDuration_PropertyAddress;

	private static int OnQueueSubtitles__DelegateSignature_CueDuration_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnQueueSubtitles()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnQueueSubtitles__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnQueueSubtitles__DelegateSignature");
		OnQueueSubtitles__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQueueSubtitles__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQueueSubtitles__DelegateSignature_Subtitles_PropertyAddress, OnQueueSubtitles__DelegateSignature_FunctionAddress, "Subtitles");
		OnQueueSubtitles__DelegateSignature_Subtitles_Offset = NativeReflectionCached.GetPropertyOffset(OnQueueSubtitles__DelegateSignature_FunctionAddress, "Subtitles");
		OnQueueSubtitles__DelegateSignature_Subtitles_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQueueSubtitles__DelegateSignature_FunctionAddress, "Subtitles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQueueSubtitles__DelegateSignature_CueDuration_PropertyAddress, OnQueueSubtitles__DelegateSignature_FunctionAddress, "CueDuration");
		OnQueueSubtitles__DelegateSignature_CueDuration_Offset = NativeReflectionCached.GetPropertyOffset(OnQueueSubtitles__DelegateSignature_FunctionAddress, "CueDuration");
		OnQueueSubtitles__DelegateSignature_CueDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQueueSubtitles__DelegateSignature_FunctionAddress, "CueDuration", Classes.FFloatProperty);
		OnQueueSubtitles__DelegateSignature_IsValid = OnQueueSubtitles__DelegateSignature_FunctionAddress != IntPtr.Zero && OnQueueSubtitles__DelegateSignature_Subtitles_IsValid && OnQueueSubtitles__DelegateSignature_CueDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnQueueSubtitles__DelegateSignature", OnQueueSubtitles__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FSubtitleCue> Subtitles, float CueDuration)
	{
		if (!OnQueueSubtitles__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnQueueSubtitles__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnQueueSubtitles__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQueueSubtitles__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FSubtitleCue>(1, OnQueueSubtitles__DelegateSignature_Subtitles_PropertyAddress, CachedMarshalingDelegates<FSubtitleCue, FSubtitleCue>.FromNative, CachedMarshalingDelegates<FSubtitleCue, FSubtitleCue>.ToNative).ToNative(IntPtr.Add(intPtr, OnQueueSubtitles__DelegateSignature_Subtitles_Offset), Subtitles);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnQueueSubtitles__DelegateSignature_CueDuration_Offset), 0, OnQueueSubtitles__DelegateSignature_CueDuration_PropertyAddress.Address, CueDuration);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnQueueSubtitles__DelegateSignature_Subtitles_PropertyAddress.Address, intPtr);
		}
	}
}
