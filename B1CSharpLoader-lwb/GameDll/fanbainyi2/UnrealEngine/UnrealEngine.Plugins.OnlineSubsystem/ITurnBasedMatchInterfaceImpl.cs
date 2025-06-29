using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystem;

public sealed class ITurnBasedMatchInterfaceImpl : IInterfaceImpl, ITurnBasedMatchInterface, IInterface
{
	private static bool OnMatchReceivedTurn_IsValid;

	private IntPtr OnMatchReceivedTurn_InstanceFunctionAddress;

	private static IntPtr OnMatchReceivedTurn_FunctionAddress;

	private static int OnMatchReceivedTurn_ParamsSize;

	private static bool OnMatchReceivedTurn_Match_IsValid;

	private static FFieldAddress OnMatchReceivedTurn_Match_PropertyAddress;

	private static int OnMatchReceivedTurn_Match_Offset;

	private static bool OnMatchReceivedTurn_bDidBecomeActive_IsValid;

	private static FFieldAddress OnMatchReceivedTurn_bDidBecomeActive_PropertyAddress;

	private static int OnMatchReceivedTurn_bDidBecomeActive_Offset;

	private static bool OnMatchEnded_IsValid;

	private IntPtr OnMatchEnded_InstanceFunctionAddress;

	private static IntPtr OnMatchEnded_FunctionAddress;

	private static int OnMatchEnded_ParamsSize;

	private static bool OnMatchEnded_Match_IsValid;

	private static FFieldAddress OnMatchEnded_Match_PropertyAddress;

	private static int OnMatchEnded_Match_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchReceivedTurn")]
	public unsafe void OnMatchReceivedTurn(string Match, bool bDidBecomeActive)
	{
		CheckDestroyed();
		if (!OnMatchReceivedTurn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchReceivedTurn");
			return;
		}
		if (OnMatchReceivedTurn_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMatchReceivedTurn_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMatchReceivedTurn");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMatchReceivedTurn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMatchReceivedTurn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnMatchReceivedTurn_Match_Offset), 0, OnMatchReceivedTurn_Match_PropertyAddress.Address, Match);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnMatchReceivedTurn_bDidBecomeActive_Offset), 0, OnMatchReceivedTurn_bDidBecomeActive_PropertyAddress.Address, bDidBecomeActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMatchReceivedTurn_InstanceFunctionAddress, intPtr, OnMatchReceivedTurn_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMatchReceivedTurn_Match_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchEnded")]
	public unsafe void OnMatchEnded(string Match)
	{
		CheckDestroyed();
		if (!OnMatchEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchEnded");
			return;
		}
		if (OnMatchEnded_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMatchEnded_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMatchEnded");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMatchEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMatchEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnMatchEnded_Match_Offset), 0, OnMatchEnded_Match_PropertyAddress.Address, Match);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMatchEnded_InstanceFunctionAddress, intPtr, OnMatchEnded_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMatchEnded_Match_PropertyAddress.Address, intPtr);
	}

	public override void ResetInterface()
	{
		OnMatchReceivedTurn_InstanceFunctionAddress = IntPtr.Zero;
		OnMatchEnded_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITurnBasedMatchInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITurnBasedMatchInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITurnBasedMatchInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/OnlineSubsystem.TurnBasedMatchInterface");
		OnMatchReceivedTurn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMatchReceivedTurn");
		OnMatchReceivedTurn_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMatchReceivedTurn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMatchReceivedTurn_Match_PropertyAddress, OnMatchReceivedTurn_FunctionAddress, "Match");
		OnMatchReceivedTurn_Match_Offset = NativeReflectionCached.GetPropertyOffset(OnMatchReceivedTurn_FunctionAddress, "Match");
		OnMatchReceivedTurn_Match_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMatchReceivedTurn_FunctionAddress, "Match", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMatchReceivedTurn_bDidBecomeActive_PropertyAddress, OnMatchReceivedTurn_FunctionAddress, "bDidBecomeActive");
		OnMatchReceivedTurn_bDidBecomeActive_Offset = NativeReflectionCached.GetPropertyOffset(OnMatchReceivedTurn_FunctionAddress, "bDidBecomeActive");
		OnMatchReceivedTurn_bDidBecomeActive_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMatchReceivedTurn_FunctionAddress, "bDidBecomeActive", Classes.FBoolProperty);
		OnMatchReceivedTurn_IsValid = OnMatchReceivedTurn_FunctionAddress != IntPtr.Zero && OnMatchReceivedTurn_Match_IsValid && OnMatchReceivedTurn_bDidBecomeActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchReceivedTurn", OnMatchReceivedTurn_IsValid);
		OnMatchEnded_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMatchEnded");
		OnMatchEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMatchEnded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMatchEnded_Match_PropertyAddress, OnMatchEnded_FunctionAddress, "Match");
		OnMatchEnded_Match_Offset = NativeReflectionCached.GetPropertyOffset(OnMatchEnded_FunctionAddress, "Match");
		OnMatchEnded_Match_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMatchEnded_FunctionAddress, "Match", Classes.FStrProperty);
		OnMatchEnded_IsValid = OnMatchEnded_FunctionAddress != IntPtr.Zero && OnMatchEnded_Match_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystem.TurnBasedMatchInterface:OnMatchEnded", OnMatchEnded_IsValid);
	}
}
