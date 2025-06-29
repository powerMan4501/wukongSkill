using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.OnlineShowLoginUIResult__DelegateSignature")]
public class FOnlineShowLoginUIResult : FMulticastDelegate<FOnlineShowLoginUIResult.Signature>
{
	public delegate void Signature(APlayerController PlayerController);

	private static bool OnlineShowLoginUIResult__DelegateSignature_IsValid;

	private static IntPtr OnlineShowLoginUIResult__DelegateSignature_FunctionAddress;

	private static int OnlineShowLoginUIResult__DelegateSignature_ParamsSize;

	private static bool OnlineShowLoginUIResult__DelegateSignature_PlayerController_IsValid;

	private static FFieldAddress OnlineShowLoginUIResult__DelegateSignature_PlayerController_PropertyAddress;

	private static int OnlineShowLoginUIResult__DelegateSignature_PlayerController_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnlineShowLoginUIResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnlineShowLoginUIResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.OnlineShowLoginUIResult__DelegateSignature");
		OnlineShowLoginUIResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnlineShowLoginUIResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnlineShowLoginUIResult__DelegateSignature_PlayerController_PropertyAddress, OnlineShowLoginUIResult__DelegateSignature_FunctionAddress, "PlayerController");
		OnlineShowLoginUIResult__DelegateSignature_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(OnlineShowLoginUIResult__DelegateSignature_FunctionAddress, "PlayerController");
		OnlineShowLoginUIResult__DelegateSignature_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(OnlineShowLoginUIResult__DelegateSignature_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		OnlineShowLoginUIResult__DelegateSignature_IsValid = OnlineShowLoginUIResult__DelegateSignature_FunctionAddress != IntPtr.Zero && OnlineShowLoginUIResult__DelegateSignature_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.OnlineShowLoginUIResult__DelegateSignature", OnlineShowLoginUIResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APlayerController PlayerController)
	{
		if (!OnlineShowLoginUIResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.OnlineShowLoginUIResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnlineShowLoginUIResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnlineShowLoginUIResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnlineShowLoginUIResult__DelegateSignature_PlayerController_Offset), 0, OnlineShowLoginUIResult__DelegateSignature_PlayerController_PropertyAddress.Address, PlayerController);
			ProcessDelegate(intPtr);
		}
	}
}
