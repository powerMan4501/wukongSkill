using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnDeleteActorsEnd__DelegateSignature")]
public class FOnDeleteActorsEnd : FMulticastDelegate<FOnDeleteActorsEnd.Signature>
{
	public delegate void Signature();

	private static bool OnDeleteActorsEnd__DelegateSignature_IsValid;

	private static IntPtr OnDeleteActorsEnd__DelegateSignature_FunctionAddress;

	private static int OnDeleteActorsEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDeleteActorsEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDeleteActorsEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnDeleteActorsEnd__DelegateSignature");
		OnDeleteActorsEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDeleteActorsEnd__DelegateSignature_FunctionAddress);
		OnDeleteActorsEnd__DelegateSignature_IsValid = OnDeleteActorsEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnDeleteActorsEnd__DelegateSignature", OnDeleteActorsEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnDeleteActorsEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnDeleteActorsEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDeleteActorsEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDeleteActorsEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
