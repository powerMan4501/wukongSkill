using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature")]
public class FOnAllMontageInstancesEndedMCDelegate : FMulticastDelegate<FOnAllMontageInstancesEndedMCDelegate.Signature>
{
	public delegate void Signature();

	private static bool OnAllMontageInstancesEndedMCDelegate__DelegateSignature_IsValid;

	private static IntPtr OnAllMontageInstancesEndedMCDelegate__DelegateSignature_FunctionAddress;

	private static int OnAllMontageInstancesEndedMCDelegate__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAllMontageInstancesEndedMCDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAllMontageInstancesEndedMCDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature");
		OnAllMontageInstancesEndedMCDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAllMontageInstancesEndedMCDelegate__DelegateSignature_FunctionAddress);
		OnAllMontageInstancesEndedMCDelegate__DelegateSignature_IsValid = OnAllMontageInstancesEndedMCDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature", OnAllMontageInstancesEndedMCDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnAllMontageInstancesEndedMCDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAllMontageInstancesEndedMCDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAllMontageInstancesEndedMCDelegate__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
