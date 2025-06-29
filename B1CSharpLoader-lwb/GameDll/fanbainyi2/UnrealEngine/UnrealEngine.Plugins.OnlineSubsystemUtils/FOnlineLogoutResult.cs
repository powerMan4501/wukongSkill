using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.OnlineLogoutResult__DelegateSignature")]
public class FOnlineLogoutResult : FMulticastDelegate<FOnlineLogoutResult.Signature>
{
	public delegate void Signature(APlayerController PlayerController);

	private static bool OnlineLogoutResult__DelegateSignature_IsValid;

	private static IntPtr OnlineLogoutResult__DelegateSignature_FunctionAddress;

	private static int OnlineLogoutResult__DelegateSignature_ParamsSize;

	private static bool OnlineLogoutResult__DelegateSignature_PlayerController_IsValid;

	private static FFieldAddress OnlineLogoutResult__DelegateSignature_PlayerController_PropertyAddress;

	private static int OnlineLogoutResult__DelegateSignature_PlayerController_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnlineLogoutResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnlineLogoutResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.OnlineLogoutResult__DelegateSignature");
		OnlineLogoutResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnlineLogoutResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnlineLogoutResult__DelegateSignature_PlayerController_PropertyAddress, OnlineLogoutResult__DelegateSignature_FunctionAddress, "PlayerController");
		OnlineLogoutResult__DelegateSignature_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(OnlineLogoutResult__DelegateSignature_FunctionAddress, "PlayerController");
		OnlineLogoutResult__DelegateSignature_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(OnlineLogoutResult__DelegateSignature_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		OnlineLogoutResult__DelegateSignature_IsValid = OnlineLogoutResult__DelegateSignature_FunctionAddress != IntPtr.Zero && OnlineLogoutResult__DelegateSignature_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.OnlineLogoutResult__DelegateSignature", OnlineLogoutResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APlayerController PlayerController)
	{
		if (!OnlineLogoutResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.OnlineLogoutResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnlineLogoutResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnlineLogoutResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnlineLogoutResult__DelegateSignature_PlayerController_Offset), 0, OnlineLogoutResult__DelegateSignature_PlayerController_PropertyAddress.Address, PlayerController);
			ProcessDelegate(intPtr);
		}
	}
}
