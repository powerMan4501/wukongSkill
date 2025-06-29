using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.OnlineTurnBasedMatchResult__DelegateSignature")]
public class FOnlineTurnBasedMatchResult : FMulticastDelegate<FOnlineTurnBasedMatchResult.Signature>
{
	public delegate void Signature(string MatchID);

	private static bool OnlineTurnBasedMatchResult__DelegateSignature_IsValid;

	private static IntPtr OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress;

	private static int OnlineTurnBasedMatchResult__DelegateSignature_ParamsSize;

	private static bool OnlineTurnBasedMatchResult__DelegateSignature_MatchID_IsValid;

	private static FFieldAddress OnlineTurnBasedMatchResult__DelegateSignature_MatchID_PropertyAddress;

	private static int OnlineTurnBasedMatchResult__DelegateSignature_MatchID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnlineTurnBasedMatchResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.OnlineTurnBasedMatchResult__DelegateSignature");
		OnlineTurnBasedMatchResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnlineTurnBasedMatchResult__DelegateSignature_MatchID_PropertyAddress, OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress, "MatchID");
		OnlineTurnBasedMatchResult__DelegateSignature_MatchID_Offset = NativeReflectionCached.GetPropertyOffset(OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress, "MatchID");
		OnlineTurnBasedMatchResult__DelegateSignature_MatchID_IsValid = NativeReflectionCached.ValidatePropertyClass(OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress, "MatchID", Classes.FStrProperty);
		OnlineTurnBasedMatchResult__DelegateSignature_IsValid = OnlineTurnBasedMatchResult__DelegateSignature_FunctionAddress != IntPtr.Zero && OnlineTurnBasedMatchResult__DelegateSignature_MatchID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.OnlineTurnBasedMatchResult__DelegateSignature", OnlineTurnBasedMatchResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string MatchID)
	{
		if (!OnlineTurnBasedMatchResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.OnlineTurnBasedMatchResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnlineTurnBasedMatchResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnlineTurnBasedMatchResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnlineTurnBasedMatchResult__DelegateSignature_MatchID_Offset), 0, OnlineTurnBasedMatchResult__DelegateSignature_MatchID_PropertyAddress.Address, MatchID);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnlineTurnBasedMatchResult__DelegateSignature_MatchID_PropertyAddress.Address, intPtr);
		}
	}
}
