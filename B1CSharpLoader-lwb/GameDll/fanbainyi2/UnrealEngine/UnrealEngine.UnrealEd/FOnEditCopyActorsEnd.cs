using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnEditCopyActorsEnd__DelegateSignature")]
public class FOnEditCopyActorsEnd : FMulticastDelegate<FOnEditCopyActorsEnd.Signature>
{
	public delegate void Signature();

	private static bool OnEditCopyActorsEnd__DelegateSignature_IsValid;

	private static IntPtr OnEditCopyActorsEnd__DelegateSignature_FunctionAddress;

	private static int OnEditCopyActorsEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditCopyActorsEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditCopyActorsEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnEditCopyActorsEnd__DelegateSignature");
		OnEditCopyActorsEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditCopyActorsEnd__DelegateSignature_FunctionAddress);
		OnEditCopyActorsEnd__DelegateSignature_IsValid = OnEditCopyActorsEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnEditCopyActorsEnd__DelegateSignature", OnEditCopyActorsEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnEditCopyActorsEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnEditCopyActorsEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditCopyActorsEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditCopyActorsEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
