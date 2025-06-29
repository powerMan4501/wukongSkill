using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PostEvaluateAnimEvent__DelegateSignature")]
public class FPostEvaluateAnimEvent : FDelegate<FPostEvaluateAnimEvent.Signature>
{
	public delegate void Signature();

	private static bool PostEvaluateAnimEvent__DelegateSignature_IsValid;

	private static IntPtr PostEvaluateAnimEvent__DelegateSignature_FunctionAddress;

	private static int PostEvaluateAnimEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPostEvaluateAnimEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PostEvaluateAnimEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PostEvaluateAnimEvent__DelegateSignature");
		PostEvaluateAnimEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEvaluateAnimEvent__DelegateSignature_FunctionAddress);
		PostEvaluateAnimEvent__DelegateSignature_IsValid = PostEvaluateAnimEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PostEvaluateAnimEvent__DelegateSignature", PostEvaluateAnimEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!PostEvaluateAnimEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PostEvaluateAnimEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PostEvaluateAnimEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEvaluateAnimEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
