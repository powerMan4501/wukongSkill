using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.NumTablesChanged__DelegateSignature")]
public class FNumTablesChanged : FMulticastDelegate<FNumTablesChanged.Signature>
{
	public delegate void Signature();

	private static bool NumTablesChanged__DelegateSignature_IsValid;

	private static IntPtr NumTablesChanged__DelegateSignature_FunctionAddress;

	private static int NumTablesChanged__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FNumTablesChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		NumTablesChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.NumTablesChanged__DelegateSignature");
		NumTablesChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(NumTablesChanged__DelegateSignature_FunctionAddress);
		NumTablesChanged__DelegateSignature_IsValid = NumTablesChanged__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.NumTablesChanged__DelegateSignature", NumTablesChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!NumTablesChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.NumTablesChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(NumTablesChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NumTablesChanged__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
