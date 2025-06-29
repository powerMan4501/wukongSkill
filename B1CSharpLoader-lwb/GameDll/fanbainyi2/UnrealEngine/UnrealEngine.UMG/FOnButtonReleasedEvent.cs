using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnButtonReleasedEvent__DelegateSignature")]
public class FOnButtonReleasedEvent : FMulticastDelegate<FOnButtonReleasedEvent.Signature>
{
	public delegate void Signature();

	private static bool OnButtonReleasedEvent__DelegateSignature_IsValid;

	private static IntPtr OnButtonReleasedEvent__DelegateSignature_FunctionAddress;

	private static int OnButtonReleasedEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnButtonReleasedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnButtonReleasedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnButtonReleasedEvent__DelegateSignature");
		OnButtonReleasedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnButtonReleasedEvent__DelegateSignature_FunctionAddress);
		OnButtonReleasedEvent__DelegateSignature_IsValid = OnButtonReleasedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnButtonReleasedEvent__DelegateSignature", OnButtonReleasedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnButtonReleasedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnButtonReleasedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnButtonReleasedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnButtonReleasedEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
