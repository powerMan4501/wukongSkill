using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnFloatValueChangedEvent__DelegateSignature")]
public class FOnFloatValueChangedEvent : FMulticastDelegate<FOnFloatValueChangedEvent.Signature>
{
	public delegate void Signature(float Value);

	private static bool OnFloatValueChangedEvent__DelegateSignature_IsValid;

	private static IntPtr OnFloatValueChangedEvent__DelegateSignature_FunctionAddress;

	private static int OnFloatValueChangedEvent__DelegateSignature_ParamsSize;

	private static bool OnFloatValueChangedEvent__DelegateSignature_Value_IsValid;

	private static FFieldAddress OnFloatValueChangedEvent__DelegateSignature_Value_PropertyAddress;

	private static int OnFloatValueChangedEvent__DelegateSignature_Value_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnFloatValueChangedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnFloatValueChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnFloatValueChangedEvent__DelegateSignature");
		OnFloatValueChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFloatValueChangedEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFloatValueChangedEvent__DelegateSignature_Value_PropertyAddress, OnFloatValueChangedEvent__DelegateSignature_FunctionAddress, "Value");
		OnFloatValueChangedEvent__DelegateSignature_Value_Offset = NativeReflectionCached.GetPropertyOffset(OnFloatValueChangedEvent__DelegateSignature_FunctionAddress, "Value");
		OnFloatValueChangedEvent__DelegateSignature_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFloatValueChangedEvent__DelegateSignature_FunctionAddress, "Value", Classes.FFloatProperty);
		OnFloatValueChangedEvent__DelegateSignature_IsValid = OnFloatValueChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnFloatValueChangedEvent__DelegateSignature_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnFloatValueChangedEvent__DelegateSignature", OnFloatValueChangedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Value)
	{
		if (!OnFloatValueChangedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnFloatValueChangedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnFloatValueChangedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFloatValueChangedEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnFloatValueChangedEvent__DelegateSignature_Value_Offset), 0, OnFloatValueChangedEvent__DelegateSignature_Value_PropertyAddress.Address, Value);
			ProcessDelegate(intPtr);
		}
	}
}
