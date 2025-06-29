using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnMatineeEvent__DelegateSignature")]
public class FOnMatineeEvent : FMulticastDelegate<FOnMatineeEvent.Signature>
{
	public delegate void Signature();

	private static bool OnMatineeEvent__DelegateSignature_IsValid;

	private static IntPtr OnMatineeEvent__DelegateSignature_FunctionAddress;

	private static int OnMatineeEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMatineeEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMatineeEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnMatineeEvent__DelegateSignature");
		OnMatineeEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMatineeEvent__DelegateSignature_FunctionAddress);
		OnMatineeEvent__DelegateSignature_IsValid = OnMatineeEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnMatineeEvent__DelegateSignature", OnMatineeEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMatineeEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnMatineeEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMatineeEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMatineeEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
