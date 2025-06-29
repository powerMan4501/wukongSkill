using System;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UClass]
[USharpPath("/Script/b1-Managed.ReplicationTest")]
public class ReplicationTest : ADefaultPawn
{
	private static bool PrintInServer_IsValid;

	private static IntPtr PrintInServer_FunctionAddress;

	private static int PrintInServer_ParamsSize;

	private static bool PrintMulticast_IsValid;

	private static IntPtr PrintMulticast_FunctionAddress;

	private static int PrintMulticast_ParamsSize;

	private static bool RunPrintInServer_IsValid;

	private static IntPtr RunPrintInServer_FunctionAddress;

	private static int RunPrintInServer_ParamsSize;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.ReplicationTest:RunPrintInServer")]
	private void RunPrintInServer()
	{
		PrintInServer();
	}

	[UFunction]
	[BlueprintCallable]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.ReplicationTest:PrintInServer")]
	private unsafe void PrintInServer()
	{
		CheckDestroyed();
		if (!PrintInServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.ReplicationTest:PrintInServer");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)PrintInServer_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, PrintInServer_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, PrintInServer_FunctionAddress, intPtr, PrintInServer_ParamsSize);
	}

	[UFunction]
	private void PrintInServer_Implementation()
	{
		UClass cls = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UClass>("/Game/NewBlueprint1.NewBlueprint1_C", ELoadResourceType.SyncLoadAndCache);
		BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(base.World, cls, GetActorLocation(), UMathLibrary.RandomRotator());
		BGW_LogUtil.SetLogEnable(bEnableDbg: true, bEnableDbgDisplay: true, bEnableInfo: true);
	}

	[UFunction]
	[BlueprintCallable]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.ReplicationTest:PrintMulticast")]
	private unsafe void PrintMulticast()
	{
		CheckDestroyed();
		if (!PrintMulticast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.ReplicationTest:PrintMulticast");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)PrintMulticast_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, PrintMulticast_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, PrintMulticast_FunctionAddress, intPtr, PrintMulticast_ParamsSize);
	}

	[UFunction]
	private void PrintMulticast_Implementation()
	{
		UClass cls = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UClass>("/Game/NewBlueprint1.NewBlueprint1_C", ELoadResourceType.SyncLoadAndCache);
		BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(base.World, cls, GetActorLocation(), UMathLibrary.RandomRotator());
		BGW_LogUtil.SetLogEnable(bEnableDbg: true, bEnableDbgDisplay: true, bEnableInfo: true);
	}

	[UFunctionInvoker("/Script/b1-Managed.ReplicationTest:PrintInServer")]
	private static void PrintInServer__Invoker(IntPtr buffer, IntPtr obj)
	{
		ReplicationTest replicationTest = GCHelper.Find<ReplicationTest>(obj);
		replicationTest.PrintInServer_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.ReplicationTest:PrintMulticast")]
	private static void PrintMulticast__Invoker(IntPtr buffer, IntPtr obj)
	{
		ReplicationTest replicationTest = GCHelper.Find<ReplicationTest>(obj);
		replicationTest.PrintMulticast_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.ReplicationTest:RunPrintInServer")]
	private static void RunPrintInServer__Invoker(IntPtr buffer, IntPtr obj)
	{
		ReplicationTest replicationTest = GCHelper.Find<ReplicationTest>(obj);
		replicationTest.RunPrintInServer();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.ReplicationTest");
		PrintInServer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrintInServer");
		PrintInServer_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintInServer_FunctionAddress);
		PrintInServer_IsValid = PrintInServer_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ReplicationTest:PrintInServer", PrintInServer_IsValid);
		PrintMulticast_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrintMulticast");
		PrintMulticast_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintMulticast_FunctionAddress);
		PrintMulticast_IsValid = PrintMulticast_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ReplicationTest:PrintMulticast", PrintMulticast_IsValid);
		RunPrintInServer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunPrintInServer");
		RunPrintInServer_ParamsSize = NativeReflection.GetFunctionParamsSize(RunPrintInServer_FunctionAddress);
		RunPrintInServer_IsValid = RunPrintInServer_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ReplicationTest:RunPrintInServer", RunPrintInServer_IsValid);
	}

	static ReplicationTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ReplicationTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ReplicationTest));
	}
}
