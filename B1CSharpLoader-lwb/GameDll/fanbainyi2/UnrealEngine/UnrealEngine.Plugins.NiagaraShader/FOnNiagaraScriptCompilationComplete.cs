using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraShader;

[UDelegate]
[UMetaPath("/Script/NiagaraShader.OnNiagaraScriptCompilationComplete__DelegateSignature")]
public class FOnNiagaraScriptCompilationComplete : FMulticastDelegate<FOnNiagaraScriptCompilationComplete.Signature>
{
	public delegate void Signature();

	private static bool OnNiagaraScriptCompilationComplete__DelegateSignature_IsValid;

	private static IntPtr OnNiagaraScriptCompilationComplete__DelegateSignature_FunctionAddress;

	private static int OnNiagaraScriptCompilationComplete__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnNiagaraScriptCompilationComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnNiagaraScriptCompilationComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/NiagaraShader.OnNiagaraScriptCompilationComplete__DelegateSignature");
		OnNiagaraScriptCompilationComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNiagaraScriptCompilationComplete__DelegateSignature_FunctionAddress);
		OnNiagaraScriptCompilationComplete__DelegateSignature_IsValid = OnNiagaraScriptCompilationComplete__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraShader.OnNiagaraScriptCompilationComplete__DelegateSignature", OnNiagaraScriptCompilationComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnNiagaraScriptCompilationComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraShader.OnNiagaraScriptCompilationComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnNiagaraScriptCompilationComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNiagaraScriptCompilationComplete__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
