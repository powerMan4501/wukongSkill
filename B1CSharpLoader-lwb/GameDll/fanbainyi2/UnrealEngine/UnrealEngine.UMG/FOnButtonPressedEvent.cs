using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnButtonPressedEvent__DelegateSignature")]
public class FOnButtonPressedEvent : FMulticastDelegate<FOnButtonPressedEvent.Signature>
{
	public delegate void Signature();

	private static bool OnButtonPressedEvent__DelegateSignature_IsValid;

	private static IntPtr OnButtonPressedEvent__DelegateSignature_FunctionAddress;

	private static int OnButtonPressedEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnButtonPressedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnButtonPressedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnButtonPressedEvent__DelegateSignature");
		OnButtonPressedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnButtonPressedEvent__DelegateSignature_FunctionAddress);
		OnButtonPressedEvent__DelegateSignature_IsValid = OnButtonPressedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnButtonPressedEvent__DelegateSignature", OnButtonPressedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnButtonPressedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnButtonPressedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnButtonPressedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnButtonPressedEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
