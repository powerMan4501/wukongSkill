using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature")]
public class FOnGameUserSettingsUINeedsUpdate : FMulticastDelegate<FOnGameUserSettingsUINeedsUpdate.Signature>
{
	public delegate void Signature();

	private static bool OnGameUserSettingsUINeedsUpdate__DelegateSignature_IsValid;

	private static IntPtr OnGameUserSettingsUINeedsUpdate__DelegateSignature_FunctionAddress;

	private static int OnGameUserSettingsUINeedsUpdate__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnGameUserSettingsUINeedsUpdate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnGameUserSettingsUINeedsUpdate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature");
		OnGameUserSettingsUINeedsUpdate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGameUserSettingsUINeedsUpdate__DelegateSignature_FunctionAddress);
		OnGameUserSettingsUINeedsUpdate__DelegateSignature_IsValid = OnGameUserSettingsUINeedsUpdate__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature", OnGameUserSettingsUINeedsUpdate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnGameUserSettingsUINeedsUpdate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnGameUserSettingsUINeedsUpdate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGameUserSettingsUINeedsUpdate__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
