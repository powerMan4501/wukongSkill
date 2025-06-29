using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UDelegate]
[UMetaPath("/Script/FunctionalTesting.FunctionalTestEventSignature__DelegateSignature")]
public class FFunctionalTestEventSignature : FMulticastDelegate<FFunctionalTestEventSignature.Signature>
{
	public delegate void Signature();

	private static bool FunctionalTestEventSignature__DelegateSignature_IsValid;

	private static IntPtr FunctionalTestEventSignature__DelegateSignature_FunctionAddress;

	private static int FunctionalTestEventSignature__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FFunctionalTestEventSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		FunctionalTestEventSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/FunctionalTesting.FunctionalTestEventSignature__DelegateSignature");
		FunctionalTestEventSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(FunctionalTestEventSignature__DelegateSignature_FunctionAddress);
		FunctionalTestEventSignature__DelegateSignature_IsValid = FunctionalTestEventSignature__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTestEventSignature__DelegateSignature", FunctionalTestEventSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!FunctionalTestEventSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTestEventSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(FunctionalTestEventSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FunctionalTestEventSignature__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
