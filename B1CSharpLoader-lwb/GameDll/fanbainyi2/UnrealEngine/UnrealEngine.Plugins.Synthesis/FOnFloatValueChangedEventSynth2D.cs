using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnFloatValueChangedEventSynth2D__DelegateSignature")]
public class FOnFloatValueChangedEventSynth2D : FMulticastDelegate<FOnFloatValueChangedEventSynth2D.Signature>
{
	public delegate void Signature(float Value);

	private static bool OnFloatValueChangedEventSynth2D__DelegateSignature_IsValid;

	private static IntPtr OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress;

	private static int OnFloatValueChangedEventSynth2D__DelegateSignature_ParamsSize;

	private static bool OnFloatValueChangedEventSynth2D__DelegateSignature_Value_IsValid;

	private static FFieldAddress OnFloatValueChangedEventSynth2D__DelegateSignature_Value_PropertyAddress;

	private static int OnFloatValueChangedEventSynth2D__DelegateSignature_Value_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnFloatValueChangedEventSynth2D()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnFloatValueChangedEventSynth2D__DelegateSignature");
		OnFloatValueChangedEventSynth2D__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFloatValueChangedEventSynth2D__DelegateSignature_Value_PropertyAddress, OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress, "Value");
		OnFloatValueChangedEventSynth2D__DelegateSignature_Value_Offset = NativeReflectionCached.GetPropertyOffset(OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress, "Value");
		OnFloatValueChangedEventSynth2D__DelegateSignature_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress, "Value", Classes.FFloatProperty);
		OnFloatValueChangedEventSynth2D__DelegateSignature_IsValid = OnFloatValueChangedEventSynth2D__DelegateSignature_FunctionAddress != IntPtr.Zero && OnFloatValueChangedEventSynth2D__DelegateSignature_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnFloatValueChangedEventSynth2D__DelegateSignature", OnFloatValueChangedEventSynth2D__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Value)
	{
		if (!OnFloatValueChangedEventSynth2D__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnFloatValueChangedEventSynth2D__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnFloatValueChangedEventSynth2D__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFloatValueChangedEventSynth2D__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnFloatValueChangedEventSynth2D__DelegateSignature_Value_Offset), 0, OnFloatValueChangedEventSynth2D__DelegateSignature_Value_PropertyAddress.Address, Value);
			ProcessDelegate(intPtr);
		}
	}
}
