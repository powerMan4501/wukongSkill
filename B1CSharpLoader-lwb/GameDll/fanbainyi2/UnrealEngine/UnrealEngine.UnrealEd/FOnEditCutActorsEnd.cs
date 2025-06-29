using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnEditCutActorsEnd__DelegateSignature")]
public class FOnEditCutActorsEnd : FMulticastDelegate<FOnEditCutActorsEnd.Signature>
{
	public delegate void Signature();

	private static bool OnEditCutActorsEnd__DelegateSignature_IsValid;

	private static IntPtr OnEditCutActorsEnd__DelegateSignature_FunctionAddress;

	private static int OnEditCutActorsEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditCutActorsEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditCutActorsEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnEditCutActorsEnd__DelegateSignature");
		OnEditCutActorsEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditCutActorsEnd__DelegateSignature_FunctionAddress);
		OnEditCutActorsEnd__DelegateSignature_IsValid = OnEditCutActorsEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnEditCutActorsEnd__DelegateSignature", OnEditCutActorsEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnEditCutActorsEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnEditCutActorsEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditCutActorsEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditCutActorsEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
