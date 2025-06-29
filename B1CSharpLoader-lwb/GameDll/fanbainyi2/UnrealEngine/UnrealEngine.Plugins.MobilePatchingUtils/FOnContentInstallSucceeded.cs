using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UDelegate]
[UMetaPath("/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature")]
public class FOnContentInstallSucceeded : FDelegate<FOnContentInstallSucceeded.Signature>
{
	public delegate void Signature();

	private static bool OnContentInstallSucceeded__DelegateSignature_IsValid;

	private static IntPtr OnContentInstallSucceeded__DelegateSignature_FunctionAddress;

	private static int OnContentInstallSucceeded__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnContentInstallSucceeded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnContentInstallSucceeded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature");
		OnContentInstallSucceeded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnContentInstallSucceeded__DelegateSignature_FunctionAddress);
		OnContentInstallSucceeded__DelegateSignature_IsValid = OnContentInstallSucceeded__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature", OnContentInstallSucceeded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnContentInstallSucceeded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.OnContentInstallSucceeded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnContentInstallSucceeded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnContentInstallSucceeded__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
