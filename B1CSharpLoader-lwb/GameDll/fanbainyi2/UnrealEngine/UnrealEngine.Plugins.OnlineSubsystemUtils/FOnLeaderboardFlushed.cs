using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.OnLeaderboardFlushed__DelegateSignature")]
public class FOnLeaderboardFlushed : FMulticastDelegate<FOnLeaderboardFlushed.Signature>
{
	public delegate void Signature(FName SessionName);

	private static bool OnLeaderboardFlushed__DelegateSignature_IsValid;

	private static IntPtr OnLeaderboardFlushed__DelegateSignature_FunctionAddress;

	private static int OnLeaderboardFlushed__DelegateSignature_ParamsSize;

	private static bool OnLeaderboardFlushed__DelegateSignature_SessionName_IsValid;

	private static FFieldAddress OnLeaderboardFlushed__DelegateSignature_SessionName_PropertyAddress;

	private static int OnLeaderboardFlushed__DelegateSignature_SessionName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnLeaderboardFlushed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnLeaderboardFlushed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.OnLeaderboardFlushed__DelegateSignature");
		OnLeaderboardFlushed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLeaderboardFlushed__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLeaderboardFlushed__DelegateSignature_SessionName_PropertyAddress, OnLeaderboardFlushed__DelegateSignature_FunctionAddress, "SessionName");
		OnLeaderboardFlushed__DelegateSignature_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(OnLeaderboardFlushed__DelegateSignature_FunctionAddress, "SessionName");
		OnLeaderboardFlushed__DelegateSignature_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLeaderboardFlushed__DelegateSignature_FunctionAddress, "SessionName", Classes.FNameProperty);
		OnLeaderboardFlushed__DelegateSignature_IsValid = OnLeaderboardFlushed__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLeaderboardFlushed__DelegateSignature_SessionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.OnLeaderboardFlushed__DelegateSignature", OnLeaderboardFlushed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName SessionName)
	{
		if (!OnLeaderboardFlushed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.OnLeaderboardFlushed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnLeaderboardFlushed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLeaderboardFlushed__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnLeaderboardFlushed__DelegateSignature_SessionName_Offset), 0, OnLeaderboardFlushed__DelegateSignature_SessionName_PropertyAddress.Address, SessionName);
			ProcessDelegate(intPtr);
		}
	}
}
