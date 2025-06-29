using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAnimInitialized__DelegateSignature")]
public class FOnAnimInitialized : FMulticastDelegate<FOnAnimInitialized.Signature>
{
	public delegate void Signature();

	private static bool OnAnimInitialized__DelegateSignature_IsValid;

	private static IntPtr OnAnimInitialized__DelegateSignature_FunctionAddress;

	private static int OnAnimInitialized__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAnimInitialized()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAnimInitialized__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAnimInitialized__DelegateSignature");
		OnAnimInitialized__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimInitialized__DelegateSignature_FunctionAddress);
		OnAnimInitialized__DelegateSignature_IsValid = OnAnimInitialized__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAnimInitialized__DelegateSignature", OnAnimInitialized__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnAnimInitialized__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAnimInitialized__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAnimInitialized__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnimInitialized__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
