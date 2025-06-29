using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BWE_DemoTianJiangBorn__DelegateSignature")]
public class FBWE_DemoTianJiangBorn : FMulticastDelegate<FBWE_DemoTianJiangBorn.Signature>
{
	public delegate void Signature();

	private static bool BWE_DemoTianJiangBorn__DelegateSignature_IsValid;

	private static IntPtr BWE_DemoTianJiangBorn__DelegateSignature_FunctionAddress;

	private static int BWE_DemoTianJiangBorn__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBWE_DemoTianJiangBorn()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BWE_DemoTianJiangBorn__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BWE_DemoTianJiangBorn__DelegateSignature");
		BWE_DemoTianJiangBorn__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BWE_DemoTianJiangBorn__DelegateSignature_FunctionAddress);
		BWE_DemoTianJiangBorn__DelegateSignature_IsValid = BWE_DemoTianJiangBorn__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWE_DemoTianJiangBorn__DelegateSignature", BWE_DemoTianJiangBorn__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!BWE_DemoTianJiangBorn__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWE_DemoTianJiangBorn__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BWE_DemoTianJiangBorn__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BWE_DemoTianJiangBorn__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
