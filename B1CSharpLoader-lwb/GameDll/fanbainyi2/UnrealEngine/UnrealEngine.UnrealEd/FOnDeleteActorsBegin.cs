using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnDeleteActorsBegin__DelegateSignature")]
public class FOnDeleteActorsBegin : FMulticastDelegate<FOnDeleteActorsBegin.Signature>
{
	public delegate void Signature();

	private static bool OnDeleteActorsBegin__DelegateSignature_IsValid;

	private static IntPtr OnDeleteActorsBegin__DelegateSignature_FunctionAddress;

	private static int OnDeleteActorsBegin__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDeleteActorsBegin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDeleteActorsBegin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnDeleteActorsBegin__DelegateSignature");
		OnDeleteActorsBegin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDeleteActorsBegin__DelegateSignature_FunctionAddress);
		OnDeleteActorsBegin__DelegateSignature_IsValid = OnDeleteActorsBegin__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnDeleteActorsBegin__DelegateSignature", OnDeleteActorsBegin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnDeleteActorsBegin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnDeleteActorsBegin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDeleteActorsBegin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDeleteActorsBegin__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
