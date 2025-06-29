using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnDuplicateActorsBegin__DelegateSignature")]
public class FOnDuplicateActorsBegin : FMulticastDelegate<FOnDuplicateActorsBegin.Signature>
{
	public delegate void Signature();

	private static bool OnDuplicateActorsBegin__DelegateSignature_IsValid;

	private static IntPtr OnDuplicateActorsBegin__DelegateSignature_FunctionAddress;

	private static int OnDuplicateActorsBegin__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDuplicateActorsBegin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDuplicateActorsBegin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnDuplicateActorsBegin__DelegateSignature");
		OnDuplicateActorsBegin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDuplicateActorsBegin__DelegateSignature_FunctionAddress);
		OnDuplicateActorsBegin__DelegateSignature_IsValid = OnDuplicateActorsBegin__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnDuplicateActorsBegin__DelegateSignature", OnDuplicateActorsBegin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnDuplicateActorsBegin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnDuplicateActorsBegin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDuplicateActorsBegin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDuplicateActorsBegin__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
