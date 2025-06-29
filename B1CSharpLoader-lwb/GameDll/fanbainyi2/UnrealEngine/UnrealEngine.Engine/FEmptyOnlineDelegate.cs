using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.EmptyOnlineDelegate__DelegateSignature")]
public class FEmptyOnlineDelegate : FMulticastDelegate<FEmptyOnlineDelegate.Signature>
{
	public delegate void Signature();

	private static bool EmptyOnlineDelegate__DelegateSignature_IsValid;

	private static IntPtr EmptyOnlineDelegate__DelegateSignature_FunctionAddress;

	private static int EmptyOnlineDelegate__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FEmptyOnlineDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		EmptyOnlineDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.EmptyOnlineDelegate__DelegateSignature");
		EmptyOnlineDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(EmptyOnlineDelegate__DelegateSignature_FunctionAddress);
		EmptyOnlineDelegate__DelegateSignature_IsValid = EmptyOnlineDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.EmptyOnlineDelegate__DelegateSignature", EmptyOnlineDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!EmptyOnlineDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.EmptyOnlineDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(EmptyOnlineDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EmptyOnlineDelegate__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
