using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnButtonHoverEvent__DelegateSignature")]
public class FOnButtonHoverEvent : FMulticastDelegate<FOnButtonHoverEvent.Signature>
{
	public delegate void Signature();

	private static bool OnButtonHoverEvent__DelegateSignature_IsValid;

	private static IntPtr OnButtonHoverEvent__DelegateSignature_FunctionAddress;

	private static int OnButtonHoverEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnButtonHoverEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnButtonHoverEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnButtonHoverEvent__DelegateSignature");
		OnButtonHoverEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnButtonHoverEvent__DelegateSignature_FunctionAddress);
		OnButtonHoverEvent__DelegateSignature_IsValid = OnButtonHoverEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnButtonHoverEvent__DelegateSignature", OnButtonHoverEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnButtonHoverEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnButtonHoverEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnButtonHoverEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnButtonHoverEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
