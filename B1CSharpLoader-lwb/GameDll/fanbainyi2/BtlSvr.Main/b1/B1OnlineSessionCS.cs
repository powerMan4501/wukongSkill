using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1OnlineSessionCS")]
public class B1OnlineSessionCS : UB1OnlineSession
{
	private static bool HandleDisconnectCS_IsValid;

	private static IntPtr HandleDisconnectCS_FunctionAddress;

	private static int HandleDisconnectCS_ParamsSize;

	private static bool HandleDisconnectCS_World_IsValid;

	private static int HandleDisconnectCS_World_Offset;

	private static bool HandleDisconnectCS_NetDriver_IsValid;

	private static int HandleDisconnectCS_NetDriver_Offset;

	[USharpPath("/Script/b1-Managed.B1OnlineSessionCS:HandleDisconnectCS")]
	protected override void HandleDisconnectCS_Implementation(UWorld World, UNetDriver NetDriver)
	{
		base.HandleDisconnectCS_Implementation(World, NetDriver);
		BGW_EventCollection.Get(this).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.ClientDisconnect);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1OnlineSessionCS:HandleDisconnectCS")]
	private static void HandleDisconnectCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1OnlineSessionCS b1OnlineSessionCS = GCHelper.Find<B1OnlineSessionCS>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, HandleDisconnectCS_World_Offset));
		UNetDriver netDriver = UObjectMarshaler<UNetDriver>.FromNative(IntPtr.Add(buffer, HandleDisconnectCS_NetDriver_Offset));
		b1OnlineSessionCS.HandleDisconnectCS_Implementation(world, netDriver);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1OnlineSessionCS");
		HandleDisconnectCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleDisconnectCS");
		HandleDisconnectCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleDisconnectCS_FunctionAddress);
		HandleDisconnectCS_World_Offset = NativeReflection.GetPropertyOffset(HandleDisconnectCS_FunctionAddress, "World");
		HandleDisconnectCS_World_IsValid = NativeReflection.ValidatePropertyClass(HandleDisconnectCS_FunctionAddress, "World", Classes.FObjectProperty);
		HandleDisconnectCS_NetDriver_Offset = NativeReflection.GetPropertyOffset(HandleDisconnectCS_FunctionAddress, "NetDriver");
		HandleDisconnectCS_NetDriver_IsValid = NativeReflection.ValidatePropertyClass(HandleDisconnectCS_FunctionAddress, "NetDriver", Classes.FObjectProperty);
		HandleDisconnectCS_IsValid = HandleDisconnectCS_FunctionAddress != IntPtr.Zero && HandleDisconnectCS_World_IsValid && HandleDisconnectCS_NetDriver_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1OnlineSessionCS:HandleDisconnectCS", HandleDisconnectCS_IsValid);
	}

	static B1OnlineSessionCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1OnlineSessionCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1OnlineSessionCS));
	}
}
