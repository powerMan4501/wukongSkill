using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1ReplicationGraphCS")]
public class B1ReplicationGraphCS : UB1ReplicationGraph
{
	private static bool AddNetworkActorCS_IsValid;

	private static IntPtr AddNetworkActorCS_FunctionAddress;

	private static int AddNetworkActorCS_ParamsSize;

	private static bool AddNetworkActorCS_Actor_IsValid;

	private static int AddNetworkActorCS_Actor_Offset;

	private static bool RemoveNetworkActorCS_IsValid;

	private static IntPtr RemoveNetworkActorCS_FunctionAddress;

	private static int RemoveNetworkActorCS_ParamsSize;

	private static bool RemoveNetworkActorCS_Actor_IsValid;

	private static int RemoveNetworkActorCS_Actor_Offset;

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphCS:AddNetworkActorCS")]
	protected override void AddNetworkActorCS_Implementation(AActor Actor)
	{
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphCS:RemoveNetworkActorCS")]
	protected override void RemoveNetworkActorCS_Implementation(AActor Actor)
	{
	}

	protected T CreateNodeCS<T>() where T : UB1ReplicationGraphNode_CSBase
	{
		T val = UObject.NewObject<T>();
		InitNodeCS(val);
		return val;
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphCS:AddNetworkActorCS")]
	private static void AddNetworkActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphCS b1ReplicationGraphCS = GCHelper.Find<B1ReplicationGraphCS>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, AddNetworkActorCS_Actor_Offset));
		b1ReplicationGraphCS.AddNetworkActorCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphCS:RemoveNetworkActorCS")]
	private static void RemoveNetworkActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphCS b1ReplicationGraphCS = GCHelper.Find<B1ReplicationGraphCS>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, RemoveNetworkActorCS_Actor_Offset));
		b1ReplicationGraphCS.RemoveNetworkActorCS_Implementation(actor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1ReplicationGraphCS");
		AddNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddNetworkActorCS");
		AddNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNetworkActorCS_FunctionAddress);
		AddNetworkActorCS_Actor_Offset = NativeReflection.GetPropertyOffset(AddNetworkActorCS_FunctionAddress, "Actor");
		AddNetworkActorCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(AddNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		AddNetworkActorCS_IsValid = AddNetworkActorCS_FunctionAddress != IntPtr.Zero && AddNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphCS:AddNetworkActorCS", AddNetworkActorCS_IsValid);
		RemoveNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveNetworkActorCS");
		RemoveNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNetworkActorCS_FunctionAddress);
		RemoveNetworkActorCS_Actor_Offset = NativeReflection.GetPropertyOffset(RemoveNetworkActorCS_FunctionAddress, "Actor");
		RemoveNetworkActorCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(RemoveNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		RemoveNetworkActorCS_IsValid = RemoveNetworkActorCS_FunctionAddress != IntPtr.Zero && RemoveNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphCS:RemoveNetworkActorCS", RemoveNetworkActorCS_IsValid);
	}

	static B1ReplicationGraphCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1ReplicationGraphCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1ReplicationGraphCS));
	}
}
