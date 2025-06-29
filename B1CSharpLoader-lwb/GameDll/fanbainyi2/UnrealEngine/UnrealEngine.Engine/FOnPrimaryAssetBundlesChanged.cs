using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPrimaryAssetBundlesChanged__DelegateSignature")]
public class FOnPrimaryAssetBundlesChanged : FMulticastDelegate<FOnPrimaryAssetBundlesChanged.Signature>
{
	public delegate void Signature();

	private static bool OnPrimaryAssetBundlesChanged__DelegateSignature_IsValid;

	private static IntPtr OnPrimaryAssetBundlesChanged__DelegateSignature_FunctionAddress;

	private static int OnPrimaryAssetBundlesChanged__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPrimaryAssetBundlesChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPrimaryAssetBundlesChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPrimaryAssetBundlesChanged__DelegateSignature");
		OnPrimaryAssetBundlesChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPrimaryAssetBundlesChanged__DelegateSignature_FunctionAddress);
		OnPrimaryAssetBundlesChanged__DelegateSignature_IsValid = OnPrimaryAssetBundlesChanged__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPrimaryAssetBundlesChanged__DelegateSignature", OnPrimaryAssetBundlesChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnPrimaryAssetBundlesChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPrimaryAssetBundlesChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPrimaryAssetBundlesChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPrimaryAssetBundlesChanged__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
