using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnConstructEvent__DelegateSignature")]
public class FOnConstructEvent : FMulticastDelegate<FOnConstructEvent.Signature>
{
	public delegate void Signature();

	private static bool OnConstructEvent__DelegateSignature_IsValid;

	private static IntPtr OnConstructEvent__DelegateSignature_FunctionAddress;

	private static int OnConstructEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnConstructEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnConstructEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnConstructEvent__DelegateSignature");
		OnConstructEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructEvent__DelegateSignature_FunctionAddress);
		OnConstructEvent__DelegateSignature_IsValid = OnConstructEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnConstructEvent__DelegateSignature", OnConstructEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnConstructEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnConstructEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnConstructEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
