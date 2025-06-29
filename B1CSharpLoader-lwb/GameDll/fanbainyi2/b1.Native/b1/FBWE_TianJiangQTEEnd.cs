using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BWE_TianJiangQTEEnd__DelegateSignature")]
public class FBWE_TianJiangQTEEnd : FMulticastDelegate<FBWE_TianJiangQTEEnd.Signature>
{
	public delegate void Signature();

	private static bool BWE_TianJiangQTEEnd__DelegateSignature_IsValid;

	private static IntPtr BWE_TianJiangQTEEnd__DelegateSignature_FunctionAddress;

	private static int BWE_TianJiangQTEEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBWE_TianJiangQTEEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BWE_TianJiangQTEEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BWE_TianJiangQTEEnd__DelegateSignature");
		BWE_TianJiangQTEEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BWE_TianJiangQTEEnd__DelegateSignature_FunctionAddress);
		BWE_TianJiangQTEEnd__DelegateSignature_IsValid = BWE_TianJiangQTEEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWE_TianJiangQTEEnd__DelegateSignature", BWE_TianJiangQTEEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!BWE_TianJiangQTEEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWE_TianJiangQTEEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BWE_TianJiangQTEEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BWE_TianJiangQTEEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
