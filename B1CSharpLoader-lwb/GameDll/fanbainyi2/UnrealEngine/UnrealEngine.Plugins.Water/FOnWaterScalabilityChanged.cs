using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UDelegate]
[UMetaPath("/Script/Water.OnWaterScalabilityChanged__DelegateSignature")]
public class FOnWaterScalabilityChanged : FMulticastDelegate<FOnWaterScalabilityChanged.Signature>
{
	public delegate void Signature();

	private static bool OnWaterScalabilityChanged__DelegateSignature_IsValid;

	private static IntPtr OnWaterScalabilityChanged__DelegateSignature_FunctionAddress;

	private static int OnWaterScalabilityChanged__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnWaterScalabilityChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnWaterScalabilityChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Water.OnWaterScalabilityChanged__DelegateSignature");
		OnWaterScalabilityChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWaterScalabilityChanged__DelegateSignature_FunctionAddress);
		OnWaterScalabilityChanged__DelegateSignature_IsValid = OnWaterScalabilityChanged__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Water.OnWaterScalabilityChanged__DelegateSignature", OnWaterScalabilityChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnWaterScalabilityChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.OnWaterScalabilityChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnWaterScalabilityChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWaterScalabilityChanged__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
