using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnUserClosedAdvertisement__DelegateSignature")]
public class FOnUserClosedAdvertisement : FDelegate<FOnUserClosedAdvertisement.Signature>
{
	public delegate void Signature();

	private static bool OnUserClosedAdvertisement__DelegateSignature_IsValid;

	private static IntPtr OnUserClosedAdvertisement__DelegateSignature_FunctionAddress;

	private static int OnUserClosedAdvertisement__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnUserClosedAdvertisement()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnUserClosedAdvertisement__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnUserClosedAdvertisement__DelegateSignature");
		OnUserClosedAdvertisement__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUserClosedAdvertisement__DelegateSignature_FunctionAddress);
		OnUserClosedAdvertisement__DelegateSignature_IsValid = OnUserClosedAdvertisement__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnUserClosedAdvertisement__DelegateSignature", OnUserClosedAdvertisement__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnUserClosedAdvertisement__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnUserClosedAdvertisement__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnUserClosedAdvertisement__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUserClosedAdvertisement__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
