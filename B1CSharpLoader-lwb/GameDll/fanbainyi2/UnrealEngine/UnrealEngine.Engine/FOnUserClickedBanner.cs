using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnUserClickedBanner__DelegateSignature")]
public class FOnUserClickedBanner : FDelegate<FOnUserClickedBanner.Signature>
{
	public delegate void Signature();

	private static bool OnUserClickedBanner__DelegateSignature_IsValid;

	private static IntPtr OnUserClickedBanner__DelegateSignature_FunctionAddress;

	private static int OnUserClickedBanner__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnUserClickedBanner()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnUserClickedBanner__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnUserClickedBanner__DelegateSignature");
		OnUserClickedBanner__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUserClickedBanner__DelegateSignature_FunctionAddress);
		OnUserClickedBanner__DelegateSignature_IsValid = OnUserClickedBanner__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnUserClickedBanner__DelegateSignature", OnUserClickedBanner__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnUserClickedBanner__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnUserClickedBanner__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnUserClickedBanner__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUserClickedBanner__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
