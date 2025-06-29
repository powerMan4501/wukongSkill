using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnEditCutActorsBegin__DelegateSignature")]
public class FOnEditCutActorsBegin : FMulticastDelegate<FOnEditCutActorsBegin.Signature>
{
	public delegate void Signature();

	private static bool OnEditCutActorsBegin__DelegateSignature_IsValid;

	private static IntPtr OnEditCutActorsBegin__DelegateSignature_FunctionAddress;

	private static int OnEditCutActorsBegin__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditCutActorsBegin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditCutActorsBegin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnEditCutActorsBegin__DelegateSignature");
		OnEditCutActorsBegin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditCutActorsBegin__DelegateSignature_FunctionAddress);
		OnEditCutActorsBegin__DelegateSignature_IsValid = OnEditCutActorsBegin__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnEditCutActorsBegin__DelegateSignature", OnEditCutActorsBegin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnEditCutActorsBegin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnEditCutActorsBegin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditCutActorsBegin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditCutActorsBegin__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
