using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.AkOnCheckBoxComponentStateChanged__DelegateSignature")]
public class FAkOnCheckBoxComponentStateChanged : FMulticastDelegate<FAkOnCheckBoxComponentStateChanged.Signature>
{
	public delegate void Signature(bool bIsChecked);

	private static bool AkOnCheckBoxComponentStateChanged__DelegateSignature_IsValid;

	private static IntPtr AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress;

	private static int AkOnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize;

	private static bool AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_IsValid;

	private static FFieldAddress AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_PropertyAddress;

	private static int AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAkOnCheckBoxComponentStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.AkOnCheckBoxComponentStateChanged__DelegateSignature");
		AkOnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_PropertyAddress, AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress, "bIsChecked");
		AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_Offset = NativeReflectionCached.GetPropertyOffset(AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress, "bIsChecked");
		AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress, "bIsChecked", Classes.FBoolProperty);
		AkOnCheckBoxComponentStateChanged__DelegateSignature_IsValid = AkOnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkOnCheckBoxComponentStateChanged__DelegateSignature", AkOnCheckBoxComponentStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bIsChecked)
	{
		if (!AkOnCheckBoxComponentStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkOnCheckBoxComponentStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AkOnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AkOnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_Offset), 0, AkOnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_PropertyAddress.Address, bIsChecked);
			ProcessDelegate(intPtr);
		}
	}
}
