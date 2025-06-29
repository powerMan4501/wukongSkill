using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ReplicationGraph;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500840uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase", "b1", UnrealModuleType.Game)]
public class UB1ReplicationGraphNode_CSBase : UReplicationGraphNode
{
	private static bool CachedRepActors_IsValid;

	private static FFieldAddress CachedRepActors_PropertyAddress;

	private static int CachedRepActors_Offset;

	private TArrayReadWriteMarshaler<AActor> CachedRepActors_MarshalerCached;

	private static bool CachedUpdateRepFrameActors_IsValid;

	private static FFieldAddress CachedUpdateRepFrameActors_PropertyAddress;

	private static int CachedUpdateRepFrameActors_Offset;

	private TArrayReadWriteMarshaler<AActor> CachedUpdateRepFrameActors_MarshalerCached;

	private static bool PrepareForReplicationCS_IsValid;

	private IntPtr PrepareForReplicationCS_InstanceFunctionAddress;

	private static IntPtr PrepareForReplicationCS_FunctionAddress;

	private static int PrepareForReplicationCS_ParamsSize;

	private static bool PostServerReplicateActorCS_IsValid;

	private IntPtr PostServerReplicateActorCS_InstanceFunctionAddress;

	private static IntPtr PostServerReplicateActorCS_FunctionAddress;

	private static int PostServerReplicateActorCS_ParamsSize;

	private static bool NotifyResetAllNetworkActorsCS_IsValid;

	private IntPtr NotifyResetAllNetworkActorsCS_InstanceFunctionAddress;

	private static IntPtr NotifyResetAllNetworkActorsCS_FunctionAddress;

	private static int NotifyResetAllNetworkActorsCS_ParamsSize;

	private static bool NotifyRemoveNetworkActorCS_IsValid;

	private IntPtr NotifyRemoveNetworkActorCS_InstanceFunctionAddress;

	private static IntPtr NotifyRemoveNetworkActorCS_FunctionAddress;

	private static int NotifyRemoveNetworkActorCS_ParamsSize;

	private static bool NotifyRemoveNetworkActorCS_Actor_IsValid;

	private static FFieldAddress NotifyRemoveNetworkActorCS_Actor_PropertyAddress;

	private static int NotifyRemoveNetworkActorCS_Actor_Offset;

	private static bool NotifyRemoveNetworkActorCS_bWarnIfNotFound_IsValid;

	private static FFieldAddress NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress;

	private static int NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset;

	private static bool NotifyRemoveNetworkActorCS_ReturnValue_IsValid;

	private static FFieldAddress NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress;

	private static int NotifyRemoveNetworkActorCS_ReturnValue_Offset;

	private static bool NotifyAddNetworkActorCS_IsValid;

	private IntPtr NotifyAddNetworkActorCS_InstanceFunctionAddress;

	private static IntPtr NotifyAddNetworkActorCS_FunctionAddress;

	private static int NotifyAddNetworkActorCS_ParamsSize;

	private static bool NotifyAddNetworkActorCS_Actor_IsValid;

	private static FFieldAddress NotifyAddNetworkActorCS_Actor_PropertyAddress;

	private static int NotifyAddNetworkActorCS_Actor_Offset;

	private static bool LogNodeCS_IsValid;

	private IntPtr LogNodeCS_InstanceFunctionAddress;

	private static IntPtr LogNodeCS_FunctionAddress;

	private static int LogNodeCS_ParamsSize;

	private static bool LogNodeCS_Flag_IsValid;

	private static FFieldAddress LogNodeCS_Flag_PropertyAddress;

	private static int LogNodeCS_Flag_Offset;

	private static bool LogNodeCS_NodeName_IsValid;

	private static FFieldAddress LogNodeCS_NodeName_PropertyAddress;

	private static int LogNodeCS_NodeName_Offset;

	private static bool GatherActorListsForConnectionCS_IsValid;

	private IntPtr GatherActorListsForConnectionCS_InstanceFunctionAddress;

	private static IntPtr GatherActorListsForConnectionCS_FunctionAddress;

	private static int GatherActorListsForConnectionCS_ParamsSize;

	private static bool GatherActorListsForConnectionCS_PlayerController_IsValid;

	private static FFieldAddress GatherActorListsForConnectionCS_PlayerController_PropertyAddress;

	private static int GatherActorListsForConnectionCS_PlayerController_Offset;

	[UProperty(Flags = (PropFlags)9015995347763717uL)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:CachedRepActors")]
	protected TArrayReadWrite<AActor> CachedRepActors
	{
		get
		{
			CheckDestroyed();
			if (!CachedRepActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:CachedRepActors");
				return null;
			}
			if (CachedRepActors_MarshalerCached == null)
			{
				CachedRepActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, CachedRepActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return CachedRepActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, CachedRepActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763717uL)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:CachedUpdateRepFrameActors")]
	protected TArrayReadWrite<AActor> CachedUpdateRepFrameActors
	{
		get
		{
			CheckDestroyed();
			if (!CachedUpdateRepFrameActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:CachedUpdateRepFrameActors");
				return null;
			}
			if (CachedUpdateRepFrameActors_MarshalerCached == null)
			{
				CachedUpdateRepFrameActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, CachedUpdateRepFrameActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return CachedUpdateRepFrameActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, CachedUpdateRepFrameActors_Offset));
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:PrepareForReplicationCS")]
	public unsafe void PrepareForReplicationCS()
	{
		CheckDestroyed();
		if (!PrepareForReplicationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:PrepareForReplicationCS");
			return;
		}
		if (PrepareForReplicationCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PrepareForReplicationCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PrepareForReplicationCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrepareForReplicationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrepareForReplicationCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PrepareForReplicationCS_InstanceFunctionAddress, argsSize: PrepareForReplicationCS_ParamsSize);
	}

	protected unsafe virtual void PrepareForReplicationCS_Implementation()
	{
		CheckDestroyed();
		if (!PrepareForReplicationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:PrepareForReplicationCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrepareForReplicationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrepareForReplicationCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PrepareForReplicationCS_FunctionAddress, argsSize: PrepareForReplicationCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:PostServerReplicateActorCS")]
	public unsafe void PostServerReplicateActorCS()
	{
		CheckDestroyed();
		if (!PostServerReplicateActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:PostServerReplicateActorCS");
			return;
		}
		if (PostServerReplicateActorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostServerReplicateActorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostServerReplicateActorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostServerReplicateActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostServerReplicateActorCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostServerReplicateActorCS_InstanceFunctionAddress, argsSize: PostServerReplicateActorCS_ParamsSize);
	}

	protected unsafe virtual void PostServerReplicateActorCS_Implementation()
	{
		CheckDestroyed();
		if (!PostServerReplicateActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:PostServerReplicateActorCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostServerReplicateActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostServerReplicateActorCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostServerReplicateActorCS_FunctionAddress, argsSize: PostServerReplicateActorCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyResetAllNetworkActorsCS")]
	public unsafe void NotifyResetAllNetworkActorsCS()
	{
		CheckDestroyed();
		if (!NotifyResetAllNetworkActorsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyResetAllNetworkActorsCS");
			return;
		}
		if (NotifyResetAllNetworkActorsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyResetAllNetworkActorsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyResetAllNetworkActorsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyResetAllNetworkActorsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyResetAllNetworkActorsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: NotifyResetAllNetworkActorsCS_InstanceFunctionAddress, argsSize: NotifyResetAllNetworkActorsCS_ParamsSize);
	}

	protected unsafe virtual void NotifyResetAllNetworkActorsCS_Implementation()
	{
		CheckDestroyed();
		if (!NotifyResetAllNetworkActorsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyResetAllNetworkActorsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyResetAllNetworkActorsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyResetAllNetworkActorsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: NotifyResetAllNetworkActorsCS_FunctionAddress, argsSize: NotifyResetAllNetworkActorsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyRemoveNetworkActorCS")]
	public unsafe bool NotifyRemoveNetworkActorCS(AActor Actor, bool bWarnIfNotFound)
	{
		CheckDestroyed();
		if (!NotifyRemoveNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyRemoveNetworkActorCS");
			return false;
		}
		if (NotifyRemoveNetworkActorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyRemoveNetworkActorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyRemoveNetworkActorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyRemoveNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyRemoveNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyRemoveNetworkActorCS_Actor_Offset), 0, NotifyRemoveNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset), 0, NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress.Address, bWarnIfNotFound);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyRemoveNetworkActorCS_InstanceFunctionAddress, intPtr, NotifyRemoveNetworkActorCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotifyRemoveNetworkActorCS_ReturnValue_Offset), 0, NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool NotifyRemoveNetworkActorCS_Implementation(AActor Actor, bool bWarnIfNotFound)
	{
		CheckDestroyed();
		if (!NotifyRemoveNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyRemoveNetworkActorCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyRemoveNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyRemoveNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyRemoveNetworkActorCS_Actor_Offset), 0, NotifyRemoveNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset), 0, NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress.Address, bWarnIfNotFound);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyRemoveNetworkActorCS_FunctionAddress, intPtr, NotifyRemoveNetworkActorCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotifyRemoveNetworkActorCS_ReturnValue_Offset), 0, NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyAddNetworkActorCS")]
	public unsafe void NotifyAddNetworkActorCS(AActor Actor)
	{
		CheckDestroyed();
		if (!NotifyAddNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyAddNetworkActorCS");
			return;
		}
		if (NotifyAddNetworkActorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyAddNetworkActorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyAddNetworkActorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyAddNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyAddNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyAddNetworkActorCS_Actor_Offset), 0, NotifyAddNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyAddNetworkActorCS_InstanceFunctionAddress, intPtr, NotifyAddNetworkActorCS_ParamsSize);
	}

	protected unsafe virtual void NotifyAddNetworkActorCS_Implementation(AActor Actor)
	{
		CheckDestroyed();
		if (!NotifyAddNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyAddNetworkActorCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyAddNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyAddNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyAddNetworkActorCS_Actor_Offset), 0, NotifyAddNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyAddNetworkActorCS_FunctionAddress, intPtr, NotifyAddNetworkActorCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:LogNodeCS")]
	public unsafe void LogNodeCS(int Flag, string NodeName)
	{
		CheckDestroyed();
		if (!LogNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:LogNodeCS");
			return;
		}
		if (LogNodeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			LogNodeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "LogNodeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LogNodeCS_Flag_Offset), 0, LogNodeCS_Flag_PropertyAddress.Address, Flag);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogNodeCS_NodeName_Offset), 0, LogNodeCS_NodeName_PropertyAddress.Address, NodeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogNodeCS_InstanceFunctionAddress, intPtr, LogNodeCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogNodeCS_NodeName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void LogNodeCS_Implementation(int Flag, string NodeName)
	{
		CheckDestroyed();
		if (!LogNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:LogNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LogNodeCS_Flag_Offset), 0, LogNodeCS_Flag_PropertyAddress.Address, Flag);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogNodeCS_NodeName_Offset), 0, LogNodeCS_NodeName_PropertyAddress.Address, NodeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogNodeCS_FunctionAddress, intPtr, LogNodeCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogNodeCS_NodeName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraphNode_CSBase:GatherActorListsForConnectionCS")]
	public unsafe void GatherActorListsForConnectionCS(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!GatherActorListsForConnectionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:GatherActorListsForConnectionCS");
			return;
		}
		if (GatherActorListsForConnectionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GatherActorListsForConnectionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GatherActorListsForConnectionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherActorListsForConnectionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherActorListsForConnectionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GatherActorListsForConnectionCS_PlayerController_Offset), 0, GatherActorListsForConnectionCS_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, GatherActorListsForConnectionCS_InstanceFunctionAddress, intPtr, GatherActorListsForConnectionCS_ParamsSize);
	}

	protected unsafe virtual void GatherActorListsForConnectionCS_Implementation(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!GatherActorListsForConnectionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraphNode_CSBase:GatherActorListsForConnectionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherActorListsForConnectionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherActorListsForConnectionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GatherActorListsForConnectionCS_PlayerController_Offset), 0, GatherActorListsForConnectionCS_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, GatherActorListsForConnectionCS_FunctionAddress, intPtr, GatherActorListsForConnectionCS_ParamsSize);
	}

	static UB1ReplicationGraphNode_CSBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UB1ReplicationGraphNode_CSBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UB1ReplicationGraphNode_CSBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.B1ReplicationGraphNode_CSBase");
		NativeReflectionCached.GetPropertyRef(ref CachedRepActors_PropertyAddress, intPtr, "CachedRepActors");
		CachedRepActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachedRepActors");
		CachedRepActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachedRepActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CachedUpdateRepFrameActors_PropertyAddress, intPtr, "CachedUpdateRepFrameActors");
		CachedUpdateRepFrameActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachedUpdateRepFrameActors");
		CachedUpdateRepFrameActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachedUpdateRepFrameActors", Classes.FArrayProperty);
		PrepareForReplicationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrepareForReplicationCS");
		PrepareForReplicationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PrepareForReplicationCS_FunctionAddress);
		PrepareForReplicationCS_IsValid = PrepareForReplicationCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:PrepareForReplicationCS", PrepareForReplicationCS_IsValid);
		PostServerReplicateActorCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostServerReplicateActorCS");
		PostServerReplicateActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostServerReplicateActorCS_FunctionAddress);
		PostServerReplicateActorCS_IsValid = PostServerReplicateActorCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:PostServerReplicateActorCS", PostServerReplicateActorCS_IsValid);
		NotifyResetAllNetworkActorsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NotifyResetAllNetworkActorsCS");
		NotifyResetAllNetworkActorsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyResetAllNetworkActorsCS_FunctionAddress);
		NotifyResetAllNetworkActorsCS_IsValid = NotifyResetAllNetworkActorsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyResetAllNetworkActorsCS", NotifyResetAllNetworkActorsCS_IsValid);
		NotifyRemoveNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NotifyRemoveNetworkActorCS");
		NotifyRemoveNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyRemoveNetworkActorCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyRemoveNetworkActorCS_Actor_PropertyAddress, NotifyRemoveNetworkActorCS_FunctionAddress, "Actor");
		NotifyRemoveNetworkActorCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(NotifyRemoveNetworkActorCS_FunctionAddress, "Actor");
		NotifyRemoveNetworkActorCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyRemoveNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress, NotifyRemoveNetworkActorCS_FunctionAddress, "bWarnIfNotFound");
		NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset = NativeReflectionCached.GetPropertyOffset(NotifyRemoveNetworkActorCS_FunctionAddress, "bWarnIfNotFound");
		NotifyRemoveNetworkActorCS_bWarnIfNotFound_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyRemoveNetworkActorCS_FunctionAddress, "bWarnIfNotFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress, NotifyRemoveNetworkActorCS_FunctionAddress, "ReturnValue");
		NotifyRemoveNetworkActorCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotifyRemoveNetworkActorCS_FunctionAddress, "ReturnValue");
		NotifyRemoveNetworkActorCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyRemoveNetworkActorCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotifyRemoveNetworkActorCS_IsValid = NotifyRemoveNetworkActorCS_FunctionAddress != IntPtr.Zero && NotifyRemoveNetworkActorCS_Actor_IsValid && NotifyRemoveNetworkActorCS_bWarnIfNotFound_IsValid && NotifyRemoveNetworkActorCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyRemoveNetworkActorCS", NotifyRemoveNetworkActorCS_IsValid);
		NotifyAddNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NotifyAddNetworkActorCS");
		NotifyAddNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyAddNetworkActorCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyAddNetworkActorCS_Actor_PropertyAddress, NotifyAddNetworkActorCS_FunctionAddress, "Actor");
		NotifyAddNetworkActorCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(NotifyAddNetworkActorCS_FunctionAddress, "Actor");
		NotifyAddNetworkActorCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyAddNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NotifyAddNetworkActorCS_IsValid = NotifyAddNetworkActorCS_FunctionAddress != IntPtr.Zero && NotifyAddNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:NotifyAddNetworkActorCS", NotifyAddNetworkActorCS_IsValid);
		LogNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogNodeCS");
		LogNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(LogNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogNodeCS_Flag_PropertyAddress, LogNodeCS_FunctionAddress, "Flag");
		LogNodeCS_Flag_Offset = NativeReflectionCached.GetPropertyOffset(LogNodeCS_FunctionAddress, "Flag");
		LogNodeCS_Flag_IsValid = NativeReflectionCached.ValidatePropertyClass(LogNodeCS_FunctionAddress, "Flag", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LogNodeCS_NodeName_PropertyAddress, LogNodeCS_FunctionAddress, "NodeName");
		LogNodeCS_NodeName_Offset = NativeReflectionCached.GetPropertyOffset(LogNodeCS_FunctionAddress, "NodeName");
		LogNodeCS_NodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(LogNodeCS_FunctionAddress, "NodeName", Classes.FStrProperty);
		LogNodeCS_IsValid = LogNodeCS_FunctionAddress != IntPtr.Zero && LogNodeCS_Flag_IsValid && LogNodeCS_NodeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:LogNodeCS", LogNodeCS_IsValid);
		GatherActorListsForConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GatherActorListsForConnectionCS");
		GatherActorListsForConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherActorListsForConnectionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GatherActorListsForConnectionCS_PlayerController_PropertyAddress, GatherActorListsForConnectionCS_FunctionAddress, "PlayerController");
		GatherActorListsForConnectionCS_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController");
		GatherActorListsForConnectionCS_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		GatherActorListsForConnectionCS_IsValid = GatherActorListsForConnectionCS_FunctionAddress != IntPtr.Zero && GatherActorListsForConnectionCS_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraphNode_CSBase:GatherActorListsForConnectionCS", GatherActorListsForConnectionCS_IsValid);
	}
}
