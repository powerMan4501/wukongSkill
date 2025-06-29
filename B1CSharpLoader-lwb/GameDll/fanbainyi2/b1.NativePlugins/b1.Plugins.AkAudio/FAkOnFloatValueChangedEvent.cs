using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.AkOnFloatValueChangedEvent__DelegateSignature")]
public class FAkOnFloatValueChangedEvent : FMulticastDelegate<FAkOnFloatValueChangedEvent.Signature>
{
	public delegate void Signature(float Value);

	private static bool AkOnFloatValueChangedEvent__DelegateSignature_IsValid;

	private static IntPtr AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress;

	private static int AkOnFloatValueChangedEvent__DelegateSignature_ParamsSize;

	private static bool AkOnFloatValueChangedEvent__DelegateSignature_Value_IsValid;

	private static FFieldAddress AkOnFloatValueChangedEvent__DelegateSignature_Value_PropertyAddress;

	private static int AkOnFloatValueChangedEvent__DelegateSignature_Value_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAkOnFloatValueChangedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.AkOnFloatValueChangedEvent__DelegateSignature");
		AkOnFloatValueChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AkOnFloatValueChangedEvent__DelegateSignature_Value_PropertyAddress, AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress, "Value");
		AkOnFloatValueChangedEvent__DelegateSignature_Value_Offset = NativeReflectionCached.GetPropertyOffset(AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress, "Value");
		AkOnFloatValueChangedEvent__DelegateSignature_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress, "Value", Classes.FFloatProperty);
		AkOnFloatValueChangedEvent__DelegateSignature_IsValid = AkOnFloatValueChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && AkOnFloatValueChangedEvent__DelegateSignature_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkOnFloatValueChangedEvent__DelegateSignature", AkOnFloatValueChangedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Value)
	{
		if (!AkOnFloatValueChangedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkOnFloatValueChangedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AkOnFloatValueChangedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AkOnFloatValueChangedEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AkOnFloatValueChangedEvent__DelegateSignature_Value_Offset), 0, AkOnFloatValueChangedEvent__DelegateSignature_Value_PropertyAddress.Address, Value);
			ProcessDelegate(intPtr);
		}
	}
}
