using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.LeaderboardQueryResult__DelegateSignature")]
public class FLeaderboardQueryResult : FMulticastDelegate<FLeaderboardQueryResult.Signature>
{
	public delegate void Signature(int LeaderboardValue);

	private static bool LeaderboardQueryResult__DelegateSignature_IsValid;

	private static IntPtr LeaderboardQueryResult__DelegateSignature_FunctionAddress;

	private static int LeaderboardQueryResult__DelegateSignature_ParamsSize;

	private static bool LeaderboardQueryResult__DelegateSignature_LeaderboardValue_IsValid;

	private static FFieldAddress LeaderboardQueryResult__DelegateSignature_LeaderboardValue_PropertyAddress;

	private static int LeaderboardQueryResult__DelegateSignature_LeaderboardValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FLeaderboardQueryResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		LeaderboardQueryResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.LeaderboardQueryResult__DelegateSignature");
		LeaderboardQueryResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(LeaderboardQueryResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LeaderboardQueryResult__DelegateSignature_LeaderboardValue_PropertyAddress, LeaderboardQueryResult__DelegateSignature_FunctionAddress, "LeaderboardValue");
		LeaderboardQueryResult__DelegateSignature_LeaderboardValue_Offset = NativeReflectionCached.GetPropertyOffset(LeaderboardQueryResult__DelegateSignature_FunctionAddress, "LeaderboardValue");
		LeaderboardQueryResult__DelegateSignature_LeaderboardValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LeaderboardQueryResult__DelegateSignature_FunctionAddress, "LeaderboardValue", Classes.FIntProperty);
		LeaderboardQueryResult__DelegateSignature_IsValid = LeaderboardQueryResult__DelegateSignature_FunctionAddress != IntPtr.Zero && LeaderboardQueryResult__DelegateSignature_LeaderboardValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.LeaderboardQueryResult__DelegateSignature", LeaderboardQueryResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int LeaderboardValue)
	{
		if (!LeaderboardQueryResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.LeaderboardQueryResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(LeaderboardQueryResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LeaderboardQueryResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LeaderboardQueryResult__DelegateSignature_LeaderboardValue_Offset), 0, LeaderboardQueryResult__DelegateSignature_LeaderboardValue_PropertyAddress.Address, LeaderboardValue);
			ProcessDelegate(intPtr);
		}
	}
}
