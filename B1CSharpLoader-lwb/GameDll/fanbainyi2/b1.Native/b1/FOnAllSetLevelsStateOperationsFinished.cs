using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.OnAllSetLevelsStateOperationsFinished__DelegateSignature")]
public class FOnAllSetLevelsStateOperationsFinished : FMulticastDelegate<FOnAllSetLevelsStateOperationsFinished.Signature>
{
	public delegate void Signature();

	private static bool OnAllSetLevelsStateOperationsFinished__DelegateSignature_IsValid;

	private static IntPtr OnAllSetLevelsStateOperationsFinished__DelegateSignature_FunctionAddress;

	private static int OnAllSetLevelsStateOperationsFinished__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAllSetLevelsStateOperationsFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAllSetLevelsStateOperationsFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.OnAllSetLevelsStateOperationsFinished__DelegateSignature");
		OnAllSetLevelsStateOperationsFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAllSetLevelsStateOperationsFinished__DelegateSignature_FunctionAddress);
		OnAllSetLevelsStateOperationsFinished__DelegateSignature_IsValid = OnAllSetLevelsStateOperationsFinished__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.OnAllSetLevelsStateOperationsFinished__DelegateSignature", OnAllSetLevelsStateOperationsFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnAllSetLevelsStateOperationsFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.OnAllSetLevelsStateOperationsFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAllSetLevelsStateOperationsFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAllSetLevelsStateOperationsFinished__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
