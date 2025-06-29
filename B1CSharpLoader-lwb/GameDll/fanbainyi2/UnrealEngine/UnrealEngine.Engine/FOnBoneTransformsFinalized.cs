using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnBoneTransformsFinalized__DelegateSignature")]
public class FOnBoneTransformsFinalized : FMulticastDelegate<FOnBoneTransformsFinalized.Signature>
{
	public delegate void Signature();

	private static bool OnBoneTransformsFinalized__DelegateSignature_IsValid;

	private static IntPtr OnBoneTransformsFinalized__DelegateSignature_FunctionAddress;

	private static int OnBoneTransformsFinalized__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnBoneTransformsFinalized()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnBoneTransformsFinalized__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnBoneTransformsFinalized__DelegateSignature");
		OnBoneTransformsFinalized__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBoneTransformsFinalized__DelegateSignature_FunctionAddress);
		OnBoneTransformsFinalized__DelegateSignature_IsValid = OnBoneTransformsFinalized__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnBoneTransformsFinalized__DelegateSignature", OnBoneTransformsFinalized__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnBoneTransformsFinalized__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnBoneTransformsFinalized__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnBoneTransformsFinalized__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBoneTransformsFinalized__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
