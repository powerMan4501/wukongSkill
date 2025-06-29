using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnDuplicateActorsEnd__DelegateSignature")]
public class FOnDuplicateActorsEnd : FMulticastDelegate<FOnDuplicateActorsEnd.Signature>
{
	public delegate void Signature();

	private static bool OnDuplicateActorsEnd__DelegateSignature_IsValid;

	private static IntPtr OnDuplicateActorsEnd__DelegateSignature_FunctionAddress;

	private static int OnDuplicateActorsEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDuplicateActorsEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDuplicateActorsEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnDuplicateActorsEnd__DelegateSignature");
		OnDuplicateActorsEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDuplicateActorsEnd__DelegateSignature_FunctionAddress);
		OnDuplicateActorsEnd__DelegateSignature_IsValid = OnDuplicateActorsEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnDuplicateActorsEnd__DelegateSignature", OnDuplicateActorsEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnDuplicateActorsEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnDuplicateActorsEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDuplicateActorsEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDuplicateActorsEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
