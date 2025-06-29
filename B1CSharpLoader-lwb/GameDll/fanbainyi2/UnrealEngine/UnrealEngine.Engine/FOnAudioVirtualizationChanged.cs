using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioVirtualizationChanged__DelegateSignature")]
public class FOnAudioVirtualizationChanged : FMulticastDelegate<FOnAudioVirtualizationChanged.Signature>
{
	public delegate void Signature(bool bIsVirtualized);

	private static bool OnAudioVirtualizationChanged__DelegateSignature_IsValid;

	private static IntPtr OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress;

	private static int OnAudioVirtualizationChanged__DelegateSignature_ParamsSize;

	private static bool OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_IsValid;

	private static FFieldAddress OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_PropertyAddress;

	private static int OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioVirtualizationChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioVirtualizationChanged__DelegateSignature");
		OnAudioVirtualizationChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_PropertyAddress, OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress, "bIsVirtualized");
		OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress, "bIsVirtualized");
		OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress, "bIsVirtualized", Classes.FBoolProperty);
		OnAudioVirtualizationChanged__DelegateSignature_IsValid = OnAudioVirtualizationChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioVirtualizationChanged__DelegateSignature", OnAudioVirtualizationChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bIsVirtualized)
	{
		if (!OnAudioVirtualizationChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioVirtualizationChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioVirtualizationChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioVirtualizationChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_Offset), 0, OnAudioVirtualizationChanged__DelegateSignature_bIsVirtualized_PropertyAddress.Address, bIsVirtualized);
			ProcessDelegate(intPtr);
		}
	}
}
