using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnForceFeedbackFinished__DelegateSignature")]
public class FOnForceFeedbackFinished : FMulticastDelegate<FOnForceFeedbackFinished.Signature>
{
	public delegate void Signature(UForceFeedbackComponent ForceFeedbackComponent);

	private static bool OnForceFeedbackFinished__DelegateSignature_IsValid;

	private static IntPtr OnForceFeedbackFinished__DelegateSignature_FunctionAddress;

	private static int OnForceFeedbackFinished__DelegateSignature_ParamsSize;

	private static bool OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_IsValid;

	private static FFieldAddress OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_PropertyAddress;

	private static int OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnForceFeedbackFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnForceFeedbackFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnForceFeedbackFinished__DelegateSignature");
		OnForceFeedbackFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnForceFeedbackFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_PropertyAddress, OnForceFeedbackFinished__DelegateSignature_FunctionAddress, "ForceFeedbackComponent");
		OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnForceFeedbackFinished__DelegateSignature_FunctionAddress, "ForceFeedbackComponent");
		OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnForceFeedbackFinished__DelegateSignature_FunctionAddress, "ForceFeedbackComponent", Classes.FObjectProperty);
		OnForceFeedbackFinished__DelegateSignature_IsValid = OnForceFeedbackFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnForceFeedbackFinished__DelegateSignature", OnForceFeedbackFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UForceFeedbackComponent ForceFeedbackComponent)
	{
		if (!OnForceFeedbackFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnForceFeedbackFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnForceFeedbackFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnForceFeedbackFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UForceFeedbackComponent>.ToNative(IntPtr.Add(intPtr, OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_Offset), 0, OnForceFeedbackFinished__DelegateSignature_ForceFeedbackComponent_PropertyAddress.Address, ForceFeedbackComponent);
			ProcessDelegate(intPtr);
		}
	}
}
