using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.AsyncDelayComplete__DelegateSignature")]
public class FAsyncDelayComplete : FMulticastDelegate<FAsyncDelayComplete.Signature>
{
	public delegate void Signature();

	private static bool AsyncDelayComplete__DelegateSignature_IsValid;

	private static IntPtr AsyncDelayComplete__DelegateSignature_FunctionAddress;

	private static int AsyncDelayComplete__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAsyncDelayComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AsyncDelayComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.AsyncDelayComplete__DelegateSignature");
		AsyncDelayComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AsyncDelayComplete__DelegateSignature_FunctionAddress);
		AsyncDelayComplete__DelegateSignature_IsValid = AsyncDelayComplete__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.AsyncDelayComplete__DelegateSignature", AsyncDelayComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!AsyncDelayComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.AsyncDelayComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AsyncDelayComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsyncDelayComplete__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
