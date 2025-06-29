using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.PlayerTransactionEventCollection")]
public class UPlayerTransactionEventCollection : UActorComponentCS
{
	private static bool InteractTransactionStart_IsValid;

	private static IntPtr InteractTransactionStart_FunctionAddress;

	private static int InteractTransactionStart_ParamsSize;

	private static bool InteractTransactionStart_Param_IsValid;

	private static int InteractTransactionStart_Param_Offset;

	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.PlayerTransactionEventCollection:InteractTransactionStart")]
	public unsafe void InteractTransactionStart(PlayerTransactionInteractStartParams Param)
	{
		CheckDestroyed();
		if (!InteractTransactionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.PlayerTransactionEventCollection:InteractTransactionStart");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)InteractTransactionStart_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, InteractTransactionStart_ParamsSize);
		PlayerTransactionInteractStartParams.ToNative(IntPtr.Add(intPtr, InteractTransactionStart_Param_Offset), Param);
		NativeReflection.InvokeFunction(base.Address, InteractTransactionStart_FunctionAddress, intPtr, InteractTransactionStart_ParamsSize);
	}

	[UFunction]
	public void InteractTransactionStart_Implementation(PlayerTransactionInteractStartParams Param)
	{
		PlayerTransactionInteract playerTransactionInteract = new PlayerTransactionInteract();
		playerTransactionInteract.Start(Param);
		if (playerTransactionInteract.TransactionState == ETransactionState.Starting || playerTransactionInteract.TransactionState == ETransactionState.Runing)
		{
			BPS_EventCollectionCS.Get(GetOwner() as APlayerState).Evt_BPS_StartTransaction.Invoke(playerTransactionInteract);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.PlayerTransactionEventCollection:InteractTransactionStart")]
	private static void InteractTransactionStart__Invoker(IntPtr buffer, IntPtr obj)
	{
		UPlayerTransactionEventCollection uPlayerTransactionEventCollection = GCHelper.Find<UPlayerTransactionEventCollection>(obj);
		PlayerTransactionInteractStartParams param = PlayerTransactionInteractStartParams.FromNative(IntPtr.Add(buffer, InteractTransactionStart_Param_Offset));
		uPlayerTransactionEventCollection.InteractTransactionStart_Implementation(param);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.PlayerTransactionEventCollection");
		InteractTransactionStart_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InteractTransactionStart");
		InteractTransactionStart_ParamsSize = NativeReflection.GetFunctionParamsSize(InteractTransactionStart_FunctionAddress);
		InteractTransactionStart_Param_Offset = NativeReflection.GetPropertyOffset(InteractTransactionStart_FunctionAddress, "Param");
		InteractTransactionStart_Param_IsValid = NativeReflection.ValidatePropertyClass(InteractTransactionStart_FunctionAddress, "Param", Classes.FStructProperty);
		InteractTransactionStart_IsValid = InteractTransactionStart_FunctionAddress != IntPtr.Zero && InteractTransactionStart_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.PlayerTransactionEventCollection:InteractTransactionStart", InteractTransactionStart_IsValid);
	}

	static UPlayerTransactionEventCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPlayerTransactionEventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlayerTransactionEventCollection));
	}
}
