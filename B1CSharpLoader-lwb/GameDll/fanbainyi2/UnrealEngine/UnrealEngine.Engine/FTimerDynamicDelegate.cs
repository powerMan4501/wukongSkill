using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.TimerDynamicDelegate__DelegateSignature")]
public class FTimerDynamicDelegate : FDelegate<FTimerDynamicDelegate.Signature>
{
	public delegate void Signature();

	private static bool TimerDynamicDelegate__DelegateSignature_IsValid;

	private static IntPtr TimerDynamicDelegate__DelegateSignature_FunctionAddress;

	private static int TimerDynamicDelegate__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FTimerDynamicDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		TimerDynamicDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.TimerDynamicDelegate__DelegateSignature");
		TimerDynamicDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(TimerDynamicDelegate__DelegateSignature_FunctionAddress);
		TimerDynamicDelegate__DelegateSignature_IsValid = TimerDynamicDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimerDynamicDelegate__DelegateSignature", TimerDynamicDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!TimerDynamicDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimerDynamicDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(TimerDynamicDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TimerDynamicDelegate__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
