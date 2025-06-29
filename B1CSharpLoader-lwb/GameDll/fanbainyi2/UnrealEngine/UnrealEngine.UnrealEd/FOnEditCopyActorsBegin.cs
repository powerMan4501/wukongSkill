using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnEditCopyActorsBegin__DelegateSignature")]
public class FOnEditCopyActorsBegin : FMulticastDelegate<FOnEditCopyActorsBegin.Signature>
{
	public delegate void Signature();

	private static bool OnEditCopyActorsBegin__DelegateSignature_IsValid;

	private static IntPtr OnEditCopyActorsBegin__DelegateSignature_FunctionAddress;

	private static int OnEditCopyActorsBegin__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditCopyActorsBegin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditCopyActorsBegin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnEditCopyActorsBegin__DelegateSignature");
		OnEditCopyActorsBegin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditCopyActorsBegin__DelegateSignature_FunctionAddress);
		OnEditCopyActorsBegin__DelegateSignature_IsValid = OnEditCopyActorsBegin__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnEditCopyActorsBegin__DelegateSignature", OnEditCopyActorsBegin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnEditCopyActorsBegin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnEditCopyActorsBegin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditCopyActorsBegin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditCopyActorsBegin__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
