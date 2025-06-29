using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnTimelineEvent__DelegateSignature")]
public class FOnTimelineEvent : FDelegate<FOnTimelineEvent.Signature>
{
	public delegate void Signature();

	private static bool OnTimelineEvent__DelegateSignature_IsValid;

	private static IntPtr OnTimelineEvent__DelegateSignature_FunctionAddress;

	private static int OnTimelineEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnTimelineEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnTimelineEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnTimelineEvent__DelegateSignature");
		OnTimelineEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTimelineEvent__DelegateSignature_FunctionAddress);
		OnTimelineEvent__DelegateSignature_IsValid = OnTimelineEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnTimelineEvent__DelegateSignature", OnTimelineEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnTimelineEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnTimelineEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnTimelineEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTimelineEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
