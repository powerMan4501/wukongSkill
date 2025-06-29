using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnButtonClickedEvent__DelegateSignature")]
public class FOnButtonClickedEvent : FMulticastDelegate<FOnButtonClickedEvent.Signature>
{
	public delegate void Signature();

	private static bool OnButtonClickedEvent__DelegateSignature_IsValid;

	private static IntPtr OnButtonClickedEvent__DelegateSignature_FunctionAddress;

	private static int OnButtonClickedEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnButtonClickedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnButtonClickedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnButtonClickedEvent__DelegateSignature");
		OnButtonClickedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnButtonClickedEvent__DelegateSignature_FunctionAddress);
		OnButtonClickedEvent__DelegateSignature_IsValid = OnButtonClickedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnButtonClickedEvent__DelegateSignature", OnButtonClickedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnButtonClickedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnButtonClickedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnButtonClickedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnButtonClickedEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
