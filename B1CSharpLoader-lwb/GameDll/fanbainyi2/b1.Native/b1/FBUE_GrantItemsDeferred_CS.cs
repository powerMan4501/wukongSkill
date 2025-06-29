using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_GrantItemsDeferred_CS__DelegateSignature")]
public class FBUE_GrantItemsDeferred_CS : FDelegate<FBUE_GrantItemsDeferred_CS.Signature>
{
	public delegate void Signature();

	private static bool BUE_GrantItemsDeferred_CS__DelegateSignature_IsValid;

	private static IntPtr BUE_GrantItemsDeferred_CS__DelegateSignature_FunctionAddress;

	private static int BUE_GrantItemsDeferred_CS__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_GrantItemsDeferred_CS()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_GrantItemsDeferred_CS__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_GrantItemsDeferred_CS__DelegateSignature");
		BUE_GrantItemsDeferred_CS__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_GrantItemsDeferred_CS__DelegateSignature_FunctionAddress);
		BUE_GrantItemsDeferred_CS__DelegateSignature_IsValid = BUE_GrantItemsDeferred_CS__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_GrantItemsDeferred_CS__DelegateSignature", BUE_GrantItemsDeferred_CS__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!BUE_GrantItemsDeferred_CS__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_GrantItemsDeferred_CS__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_GrantItemsDeferred_CS__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_GrantItemsDeferred_CS__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
