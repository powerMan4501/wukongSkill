using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnInputAction__DelegateSignature")]
public class FOnInputAction : FDelegate<FOnInputAction.Signature>
{
	public delegate void Signature();

	private static bool OnInputAction__DelegateSignature_IsValid;

	private static IntPtr OnInputAction__DelegateSignature_FunctionAddress;

	private static int OnInputAction__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnInputAction()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnInputAction__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnInputAction__DelegateSignature");
		OnInputAction__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputAction__DelegateSignature_FunctionAddress);
		OnInputAction__DelegateSignature_IsValid = OnInputAction__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnInputAction__DelegateSignature", OnInputAction__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnInputAction__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnInputAction__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnInputAction__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAction__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
