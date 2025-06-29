using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ReplicationGraph;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500844uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.B1ReplicationGraph", "b1", UnrealModuleType.Game)]
public class UB1ReplicationGraph : UReplicationGraph
{
	private static bool ShouldServerMultiCastRPCForPlayerCS_IsValid;

	private IntPtr ShouldServerMultiCastRPCForPlayerCS_InstanceFunctionAddress;

	private static IntPtr ShouldServerMultiCastRPCForPlayerCS_FunctionAddress;

	private static int ShouldServerMultiCastRPCForPlayerCS_ParamsSize;

	private static bool ShouldServerMultiCastRPCForPlayerCS_Controller_IsValid;

	private static FFieldAddress ShouldServerMultiCastRPCForPlayerCS_Controller_PropertyAddress;

	private static int ShouldServerMultiCastRPCForPlayerCS_Controller_Offset;

	private static bool ShouldServerMultiCastRPCForPlayerCS_Actor_IsValid;

	private static FFieldAddress ShouldServerMultiCastRPCForPlayerCS_Actor_PropertyAddress;

	private static int ShouldServerMultiCastRPCForPlayerCS_Actor_Offset;

	private static bool ShouldServerMultiCastRPCForPlayerCS_FuncAddr_IsValid;

	private static FFieldAddress ShouldServerMultiCastRPCForPlayerCS_FuncAddr_PropertyAddress;

	private static int ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset;

	private static bool ShouldServerMultiCastRPCForPlayerCS_ReturnValue_IsValid;

	private static FFieldAddress ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress;

	private static int ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset;

	private static bool SetRoleSwapOnReplicateCS_IsValid;

	private static IntPtr SetRoleSwapOnReplicateCS_FunctionAddress;

	private static int SetRoleSwapOnReplicateCS_ParamsSize;

	private static bool SetRoleSwapOnReplicateCS_Actor_IsValid;

	private static FFieldAddress SetRoleSwapOnReplicateCS_Actor_PropertyAddress;

	private static int SetRoleSwapOnReplicateCS_Actor_Offset;

	private static bool SetRoleSwapOnReplicateCS_Swap_IsValid;

	private static FFieldAddress SetRoleSwapOnReplicateCS_Swap_PropertyAddress;

	private static int SetRoleSwapOnReplicateCS_Swap_Offset;

	private static bool SetGlobalReplicationClassInfo_IsValid;

	private static IntPtr SetGlobalReplicationClassInfo_FunctionAddress;

	private static int SetGlobalReplicationClassInfo_ParamsSize;

	private static bool SetGlobalReplicationClassInfo_ReplicatedClass_IsValid;

	private static FFieldAddress SetGlobalReplicationClassInfo_ReplicatedClass_PropertyAddress;

	private static int SetGlobalReplicationClassInfo_ReplicatedClass_Offset;

	private static bool SetGlobalReplicationClassInfo_CullDistanceSquared_IsValid;

	private static FFieldAddress SetGlobalReplicationClassInfo_CullDistanceSquared_PropertyAddress;

	private static int SetGlobalReplicationClassInfo_CullDistanceSquared_Offset;

	private static bool SetGlobalReplicationClassInfo_ReplicationPeriodFrame_IsValid;

	private static FFieldAddress SetGlobalReplicationClassInfo_ReplicationPeriodFrame_PropertyAddress;

	private static int SetGlobalReplicationClassInfo_ReplicationPeriodFrame_Offset;

	private static bool SetAlwaysRelevantNodeCS_IsValid;

	private static IntPtr SetAlwaysRelevantNodeCS_FunctionAddress;

	private static int SetAlwaysRelevantNodeCS_ParamsSize;

	private static bool SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_IsValid;

	private static FFieldAddress SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_PropertyAddress;

	private static int SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_Offset;

	private static bool RouteRemoveNetworkActorToNodesCS_IsValid;

	private IntPtr RouteRemoveNetworkActorToNodesCS_InstanceFunctionAddress;

	private static IntPtr RouteRemoveNetworkActorToNodesCS_FunctionAddress;

	private static int RouteRemoveNetworkActorToNodesCS_ParamsSize;

	private static bool RouteRemoveNetworkActorToNodesCS_Actor_IsValid;

	private static FFieldAddress RouteRemoveNetworkActorToNodesCS_Actor_PropertyAddress;

	private static int RouteRemoveNetworkActorToNodesCS_Actor_Offset;

	private static bool RouteAddNetworkActorToNodesCS_IsValid;

	private IntPtr RouteAddNetworkActorToNodesCS_InstanceFunctionAddress;

	private static IntPtr RouteAddNetworkActorToNodesCS_FunctionAddress;

	private static int RouteAddNetworkActorToNodesCS_ParamsSize;

	private static bool RouteAddNetworkActorToNodesCS_Actor_IsValid;

	private static FFieldAddress RouteAddNetworkActorToNodesCS_Actor_PropertyAddress;

	private static int RouteAddNetworkActorToNodesCS_Actor_Offset;

	private static bool RouteAddNetworkActorToNodesCS_WorldLocation_IsValid;

	private static FFieldAddress RouteAddNetworkActorToNodesCS_WorldLocation_PropertyAddress;

	private static int RouteAddNetworkActorToNodesCS_WorldLocation_Offset;

	private static bool ResetGameWorldStateCS_IsValid;

	private IntPtr ResetGameWorldStateCS_InstanceFunctionAddress;

	private static IntPtr ResetGameWorldStateCS_FunctionAddress;

	private static int ResetGameWorldStateCS_ParamsSize;

	private static bool RemoveNetworkActorCS_IsValid;

	private IntPtr RemoveNetworkActorCS_InstanceFunctionAddress;

	private static IntPtr RemoveNetworkActorCS_FunctionAddress;

	private static int RemoveNetworkActorCS_ParamsSize;

	private static bool RemoveNetworkActorCS_Actor_IsValid;

	private static FFieldAddress RemoveNetworkActorCS_Actor_PropertyAddress;

	private static int RemoveNetworkActorCS_Actor_Offset;

	private static bool RemoveConnectionGraphNodeCS_IsValid;

	private static IntPtr RemoveConnectionGraphNodeCS_FunctionAddress;

	private static int RemoveConnectionGraphNodeCS_ParamsSize;

	private static bool RemoveConnectionGraphNodeCS_GraphNode_IsValid;

	private static FFieldAddress RemoveConnectionGraphNodeCS_GraphNode_PropertyAddress;

	private static int RemoveConnectionGraphNodeCS_GraphNode_Offset;

	private static bool RemoveConnectionGraphNodeCS_ConnectionManager_IsValid;

	private static FFieldAddress RemoveConnectionGraphNodeCS_ConnectionManager_PropertyAddress;

	private static int RemoveConnectionGraphNodeCS_ConnectionManager_Offset;

	private static bool RemoveBGUCharacterFromAlwaysRelevantNodeCS_IsValid;

	private static IntPtr RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress;

	private static int RemoveBGUCharacterFromAlwaysRelevantNodeCS_ParamsSize;

	private static bool RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_IsValid;

	private static FFieldAddress RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_PropertyAddress;

	private static int RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_Offset;

	private static bool InitNodeCS_IsValid;

	private static IntPtr InitNodeCS_FunctionAddress;

	private static int InitNodeCS_ParamsSize;

	private static bool InitNodeCS_CSNode_IsValid;

	private static FFieldAddress InitNodeCS_CSNode_PropertyAddress;

	private static int InitNodeCS_CSNode_Offset;

	private static bool InitGlobalGraphNodesCS_IsValid;

	private IntPtr InitGlobalGraphNodesCS_InstanceFunctionAddress;

	private static IntPtr InitGlobalGraphNodesCS_FunctionAddress;

	private static int InitGlobalGraphNodesCS_ParamsSize;

	private static bool InitGlobalActorClassSettingsCS_IsValid;

	private IntPtr InitGlobalActorClassSettingsCS_InstanceFunctionAddress;

	private static IntPtr InitGlobalActorClassSettingsCS_FunctionAddress;

	private static int InitGlobalActorClassSettingsCS_ParamsSize;

	private static bool InitConnectionGraphNodesCS_IsValid;

	private IntPtr InitConnectionGraphNodesCS_InstanceFunctionAddress;

	private static IntPtr InitConnectionGraphNodesCS_FunctionAddress;

	private static int InitConnectionGraphNodesCS_ParamsSize;

	private static bool InitConnectionGraphNodesCS_RepGraphConnection_IsValid;

	private static FFieldAddress InitConnectionGraphNodesCS_RepGraphConnection_PropertyAddress;

	private static int InitConnectionGraphNodesCS_RepGraphConnection_Offset;

	private static bool GSNetworkRemapPathCS_IsValid;

	private IntPtr GSNetworkRemapPathCS_InstanceFunctionAddress;

	private static IntPtr GSNetworkRemapPathCS_FunctionAddress;

	private static int GSNetworkRemapPathCS_ParamsSize;

	private static bool GSNetworkRemapPathCS_Outer_IsValid;

	private static FFieldAddress GSNetworkRemapPathCS_Outer_PropertyAddress;

	private static int GSNetworkRemapPathCS_Outer_Offset;

	private static bool GSNetworkRemapPathCS_OriginName_IsValid;

	private static FFieldAddress GSNetworkRemapPathCS_OriginName_PropertyAddress;

	private static int GSNetworkRemapPathCS_OriginName_Offset;

	private static bool GSNetworkRemapPathCS_Name_IsValid;

	private static FFieldAddress GSNetworkRemapPathCS_Name_PropertyAddress;

	private static int GSNetworkRemapPathCS_Name_Offset;

	private static bool GetWorldCS_IsValid;

	private static IntPtr GetWorldCS_FunctionAddress;

	private static int GetWorldCS_ParamsSize;

	private static bool GetWorldCS_ReturnValue_IsValid;

	private static FFieldAddress GetWorldCS_ReturnValue_PropertyAddress;

	private static int GetWorldCS_ReturnValue_Offset;

	private static bool GetServerConnectionCS_IsValid;

	private static IntPtr GetServerConnectionCS_FunctionAddress;

	private static int GetServerConnectionCS_ParamsSize;

	private static bool GetServerConnectionCS_ReturnValue_IsValid;

	private static FFieldAddress GetServerConnectionCS_ReturnValue_PropertyAddress;

	private static int GetServerConnectionCS_ReturnValue_Offset;

	private static bool GetReplicationGraphConnectionByPC_IsValid;

	private static IntPtr GetReplicationGraphConnectionByPC_FunctionAddress;

	private static int GetReplicationGraphConnectionByPC_ParamsSize;

	private static bool GetReplicationGraphConnectionByPC_PlayerController_IsValid;

	private static FFieldAddress GetReplicationGraphConnectionByPC_PlayerController_PropertyAddress;

	private static int GetReplicationGraphConnectionByPC_PlayerController_Offset;

	private static bool GetReplicationGraphConnectionByPC_ReturnValue_IsValid;

	private static FFieldAddress GetReplicationGraphConnectionByPC_ReturnValue_PropertyAddress;

	private static int GetReplicationGraphConnectionByPC_ReturnValue_Offset;

	private static bool GetConnectionByIndexCS_IsValid;

	private static IntPtr GetConnectionByIndexCS_FunctionAddress;

	private static int GetConnectionByIndexCS_ParamsSize;

	private static bool GetConnectionByIndexCS_Idx_IsValid;

	private static FFieldAddress GetConnectionByIndexCS_Idx_PropertyAddress;

	private static int GetConnectionByIndexCS_Idx_Offset;

	private static bool GetConnectionByIndexCS_ReturnValue_IsValid;

	private static FFieldAddress GetConnectionByIndexCS_ReturnValue_PropertyAddress;

	private static int GetConnectionByIndexCS_ReturnValue_Offset;

	private static bool ClienResetActorChannelCS_IsValid;

	private static IntPtr ClienResetActorChannelCS_FunctionAddress;

	private static int ClienResetActorChannelCS_ParamsSize;

	private static bool ClienResetActorChannelCS_Actor_IsValid;

	private static FFieldAddress ClienResetActorChannelCS_Actor_PropertyAddress;

	private static int ClienResetActorChannelCS_Actor_Offset;

	private static bool AddNetworkActorCS_IsValid;

	private IntPtr AddNetworkActorCS_InstanceFunctionAddress;

	private static IntPtr AddNetworkActorCS_FunctionAddress;

	private static int AddNetworkActorCS_ParamsSize;

	private static bool AddNetworkActorCS_Actor_IsValid;

	private static FFieldAddress AddNetworkActorCS_Actor_PropertyAddress;

	private static int AddNetworkActorCS_Actor_Offset;

	private static bool AddConnectionGraphNodeCS_IsValid;

	private static IntPtr AddConnectionGraphNodeCS_FunctionAddress;

	private static int AddConnectionGraphNodeCS_ParamsSize;

	private static bool AddConnectionGraphNodeCS_GraphNode_IsValid;

	private static FFieldAddress AddConnectionGraphNodeCS_GraphNode_PropertyAddress;

	private static int AddConnectionGraphNodeCS_GraphNode_Offset;

	private static bool AddConnectionGraphNodeCS_ConnectionManager_IsValid;

	private static FFieldAddress AddConnectionGraphNodeCS_ConnectionManager_PropertyAddress;

	private static int AddConnectionGraphNodeCS_ConnectionManager_Offset;

	private static bool AddBGUCharacterToAlwaysRelevantNodeCS_IsValid;

	private static IntPtr AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress;

	private static int AddBGUCharacterToAlwaysRelevantNodeCS_ParamsSize;

	private static bool AddBGUCharacterToAlwaysRelevantNodeCS_Actor_IsValid;

	private static FFieldAddress AddBGUCharacterToAlwaysRelevantNodeCS_Actor_PropertyAddress;

	private static int AddBGUCharacterToAlwaysRelevantNodeCS_Actor_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:ShouldServerMultiCastRPCForPlayerCS")]
	public unsafe bool ShouldServerMultiCastRPCForPlayerCS(APlayerController Controller, AActor Actor, long FuncAddr)
	{
		CheckDestroyed();
		if (!ShouldServerMultiCastRPCForPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:ShouldServerMultiCastRPCForPlayerCS");
			return false;
		}
		if (ShouldServerMultiCastRPCForPlayerCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ShouldServerMultiCastRPCForPlayerCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ShouldServerMultiCastRPCForPlayerCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldServerMultiCastRPCForPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldServerMultiCastRPCForPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_Controller_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_Controller_PropertyAddress.Address, Controller);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_Actor_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_FuncAddr_PropertyAddress.Address, FuncAddr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldServerMultiCastRPCForPlayerCS_InstanceFunctionAddress, intPtr, ShouldServerMultiCastRPCForPlayerCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ShouldServerMultiCastRPCForPlayerCS_Implementation(APlayerController Controller, AActor Actor, long FuncAddr)
	{
		CheckDestroyed();
		if (!ShouldServerMultiCastRPCForPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:ShouldServerMultiCastRPCForPlayerCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldServerMultiCastRPCForPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldServerMultiCastRPCForPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_Controller_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_Controller_PropertyAddress.Address, Controller);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_Actor_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_FuncAddr_PropertyAddress.Address, FuncAddr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, intPtr, ShouldServerMultiCastRPCForPlayerCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:SetRoleSwapOnReplicateCS")]
	public unsafe void SetRoleSwapOnReplicateCS(AActor Actor, bool Swap)
	{
		CheckDestroyed();
		if (!SetRoleSwapOnReplicateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:SetRoleSwapOnReplicateCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRoleSwapOnReplicateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRoleSwapOnReplicateCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetRoleSwapOnReplicateCS_Actor_Offset), 0, SetRoleSwapOnReplicateCS_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRoleSwapOnReplicateCS_Swap_Offset), 0, SetRoleSwapOnReplicateCS_Swap_PropertyAddress.Address, Swap);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRoleSwapOnReplicateCS_FunctionAddress, intPtr, SetRoleSwapOnReplicateCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:SetGlobalReplicationClassInfo")]
	public unsafe void SetGlobalReplicationClassInfo(TSubclassOf<UObject> ReplicatedClass, float CullDistanceSquared, int ReplicationPeriodFrame)
	{
		CheckDestroyed();
		if (!SetGlobalReplicationClassInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:SetGlobalReplicationClassInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalReplicationClassInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalReplicationClassInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetGlobalReplicationClassInfo_ReplicatedClass_Offset), 0, SetGlobalReplicationClassInfo_ReplicatedClass_PropertyAddress.Address, ReplicatedClass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGlobalReplicationClassInfo_CullDistanceSquared_Offset), 0, SetGlobalReplicationClassInfo_CullDistanceSquared_PropertyAddress.Address, CullDistanceSquared);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetGlobalReplicationClassInfo_ReplicationPeriodFrame_Offset), 0, SetGlobalReplicationClassInfo_ReplicationPeriodFrame_PropertyAddress.Address, ReplicationPeriodFrame);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGlobalReplicationClassInfo_FunctionAddress, intPtr, SetGlobalReplicationClassInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:SetAlwaysRelevantNodeCS")]
	public unsafe void SetAlwaysRelevantNodeCS(UB1ReplicationGraphNode_CSBase AlwaysRelevantNodeCS)
	{
		CheckDestroyed();
		if (!SetAlwaysRelevantNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:SetAlwaysRelevantNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAlwaysRelevantNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAlwaysRelevantNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UB1ReplicationGraphNode_CSBase>.ToNative(IntPtr.Add(intPtr, SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_Offset), 0, SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_PropertyAddress.Address, AlwaysRelevantNodeCS);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAlwaysRelevantNodeCS_FunctionAddress, intPtr, SetAlwaysRelevantNodeCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:RouteRemoveNetworkActorToNodesCS")]
	public unsafe void RouteRemoveNetworkActorToNodesCS(AActor Actor)
	{
		CheckDestroyed();
		if (!RouteRemoveNetworkActorToNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RouteRemoveNetworkActorToNodesCS");
			return;
		}
		if (RouteRemoveNetworkActorToNodesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			RouteRemoveNetworkActorToNodesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RouteRemoveNetworkActorToNodesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RouteRemoveNetworkActorToNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RouteRemoveNetworkActorToNodesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RouteRemoveNetworkActorToNodesCS_Actor_Offset), 0, RouteRemoveNetworkActorToNodesCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RouteRemoveNetworkActorToNodesCS_InstanceFunctionAddress, intPtr, RouteRemoveNetworkActorToNodesCS_ParamsSize);
	}

	protected unsafe virtual void RouteRemoveNetworkActorToNodesCS_Implementation(AActor Actor)
	{
		CheckDestroyed();
		if (!RouteRemoveNetworkActorToNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RouteRemoveNetworkActorToNodesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RouteRemoveNetworkActorToNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RouteRemoveNetworkActorToNodesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RouteRemoveNetworkActorToNodesCS_Actor_Offset), 0, RouteRemoveNetworkActorToNodesCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RouteRemoveNetworkActorToNodesCS_FunctionAddress, intPtr, RouteRemoveNetworkActorToNodesCS_ParamsSize);
	}

	[UFunction(Flags = 142739456u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:RouteAddNetworkActorToNodesCS")]
	public unsafe void RouteAddNetworkActorToNodesCS(AActor Actor, FVector WorldLocation)
	{
		CheckDestroyed();
		if (!RouteAddNetworkActorToNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RouteAddNetworkActorToNodesCS");
			return;
		}
		if (RouteAddNetworkActorToNodesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			RouteAddNetworkActorToNodesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RouteAddNetworkActorToNodesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RouteAddNetworkActorToNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RouteAddNetworkActorToNodesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RouteAddNetworkActorToNodesCS_Actor_Offset), 0, RouteAddNetworkActorToNodesCS_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RouteAddNetworkActorToNodesCS_WorldLocation_Offset), 0, RouteAddNetworkActorToNodesCS_WorldLocation_PropertyAddress.Address, WorldLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, RouteAddNetworkActorToNodesCS_InstanceFunctionAddress, intPtr, RouteAddNetworkActorToNodesCS_ParamsSize);
	}

	protected unsafe virtual void RouteAddNetworkActorToNodesCS_Implementation(AActor Actor, FVector WorldLocation)
	{
		CheckDestroyed();
		if (!RouteAddNetworkActorToNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RouteAddNetworkActorToNodesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RouteAddNetworkActorToNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RouteAddNetworkActorToNodesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RouteAddNetworkActorToNodesCS_Actor_Offset), 0, RouteAddNetworkActorToNodesCS_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RouteAddNetworkActorToNodesCS_WorldLocation_Offset), 0, RouteAddNetworkActorToNodesCS_WorldLocation_PropertyAddress.Address, WorldLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, RouteAddNetworkActorToNodesCS_FunctionAddress, intPtr, RouteAddNetworkActorToNodesCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:ResetGameWorldStateCS")]
	public unsafe void ResetGameWorldStateCS()
	{
		CheckDestroyed();
		if (!ResetGameWorldStateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:ResetGameWorldStateCS");
			return;
		}
		if (ResetGameWorldStateCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ResetGameWorldStateCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ResetGameWorldStateCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetGameWorldStateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetGameWorldStateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetGameWorldStateCS_InstanceFunctionAddress, argsSize: ResetGameWorldStateCS_ParamsSize);
	}

	protected unsafe virtual void ResetGameWorldStateCS_Implementation()
	{
		CheckDestroyed();
		if (!ResetGameWorldStateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:ResetGameWorldStateCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetGameWorldStateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetGameWorldStateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetGameWorldStateCS_FunctionAddress, argsSize: ResetGameWorldStateCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:RemoveNetworkActorCS")]
	public unsafe void RemoveNetworkActorCS(AActor Actor)
	{
		CheckDestroyed();
		if (!RemoveNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RemoveNetworkActorCS");
			return;
		}
		if (RemoveNetworkActorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			RemoveNetworkActorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RemoveNetworkActorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveNetworkActorCS_Actor_Offset), 0, RemoveNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveNetworkActorCS_InstanceFunctionAddress, intPtr, RemoveNetworkActorCS_ParamsSize);
	}

	protected unsafe virtual void RemoveNetworkActorCS_Implementation(AActor Actor)
	{
		CheckDestroyed();
		if (!RemoveNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RemoveNetworkActorCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveNetworkActorCS_Actor_Offset), 0, RemoveNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveNetworkActorCS_FunctionAddress, intPtr, RemoveNetworkActorCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:RemoveConnectionGraphNodeCS")]
	public unsafe void RemoveConnectionGraphNodeCS(UReplicationGraphNode GraphNode, UNetReplicationGraphConnection ConnectionManager)
	{
		CheckDestroyed();
		if (!RemoveConnectionGraphNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RemoveConnectionGraphNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveConnectionGraphNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveConnectionGraphNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UReplicationGraphNode>.ToNative(IntPtr.Add(intPtr, RemoveConnectionGraphNodeCS_GraphNode_Offset), 0, RemoveConnectionGraphNodeCS_GraphNode_PropertyAddress.Address, GraphNode);
		UObjectMarshaler<UNetReplicationGraphConnection>.ToNative(IntPtr.Add(intPtr, RemoveConnectionGraphNodeCS_ConnectionManager_Offset), 0, RemoveConnectionGraphNodeCS_ConnectionManager_PropertyAddress.Address, ConnectionManager);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveConnectionGraphNodeCS_FunctionAddress, intPtr, RemoveConnectionGraphNodeCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:RemoveBGUCharacterFromAlwaysRelevantNodeCS")]
	public unsafe void RemoveBGUCharacterFromAlwaysRelevantNodeCS(ABGUCharacter Actor)
	{
		CheckDestroyed();
		if (!RemoveBGUCharacterFromAlwaysRelevantNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:RemoveBGUCharacterFromAlwaysRelevantNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBGUCharacterFromAlwaysRelevantNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBGUCharacterFromAlwaysRelevantNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_Offset), 0, RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress, intPtr, RemoveBGUCharacterFromAlwaysRelevantNodeCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:InitNodeCS")]
	public unsafe void InitNodeCS(UB1ReplicationGraphNode_CSBase CSNode)
	{
		CheckDestroyed();
		if (!InitNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UB1ReplicationGraphNode_CSBase>.ToNative(IntPtr.Add(intPtr, InitNodeCS_CSNode_Offset), 0, InitNodeCS_CSNode_PropertyAddress.Address, CSNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitNodeCS_FunctionAddress, intPtr, InitNodeCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:InitGlobalGraphNodesCS")]
	public unsafe void InitGlobalGraphNodesCS()
	{
		CheckDestroyed();
		if (!InitGlobalGraphNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitGlobalGraphNodesCS");
			return;
		}
		if (InitGlobalGraphNodesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitGlobalGraphNodesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitGlobalGraphNodesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGlobalGraphNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGlobalGraphNodesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitGlobalGraphNodesCS_InstanceFunctionAddress, argsSize: InitGlobalGraphNodesCS_ParamsSize);
	}

	protected unsafe virtual void InitGlobalGraphNodesCS_Implementation()
	{
		CheckDestroyed();
		if (!InitGlobalGraphNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitGlobalGraphNodesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGlobalGraphNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGlobalGraphNodesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitGlobalGraphNodesCS_FunctionAddress, argsSize: InitGlobalGraphNodesCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:InitGlobalActorClassSettingsCS")]
	public unsafe void InitGlobalActorClassSettingsCS()
	{
		CheckDestroyed();
		if (!InitGlobalActorClassSettingsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitGlobalActorClassSettingsCS");
			return;
		}
		if (InitGlobalActorClassSettingsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitGlobalActorClassSettingsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitGlobalActorClassSettingsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGlobalActorClassSettingsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGlobalActorClassSettingsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitGlobalActorClassSettingsCS_InstanceFunctionAddress, argsSize: InitGlobalActorClassSettingsCS_ParamsSize);
	}

	protected unsafe virtual void InitGlobalActorClassSettingsCS_Implementation()
	{
		CheckDestroyed();
		if (!InitGlobalActorClassSettingsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitGlobalActorClassSettingsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGlobalActorClassSettingsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGlobalActorClassSettingsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitGlobalActorClassSettingsCS_FunctionAddress, argsSize: InitGlobalActorClassSettingsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:InitConnectionGraphNodesCS")]
	public unsafe void InitConnectionGraphNodesCS(UNetReplicationGraphConnection RepGraphConnection)
	{
		CheckDestroyed();
		if (!InitConnectionGraphNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitConnectionGraphNodesCS");
			return;
		}
		if (InitConnectionGraphNodesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitConnectionGraphNodesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitConnectionGraphNodesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitConnectionGraphNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitConnectionGraphNodesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNetReplicationGraphConnection>.ToNative(IntPtr.Add(intPtr, InitConnectionGraphNodesCS_RepGraphConnection_Offset), 0, InitConnectionGraphNodesCS_RepGraphConnection_PropertyAddress.Address, RepGraphConnection);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitConnectionGraphNodesCS_InstanceFunctionAddress, intPtr, InitConnectionGraphNodesCS_ParamsSize);
	}

	protected unsafe virtual void InitConnectionGraphNodesCS_Implementation(UNetReplicationGraphConnection RepGraphConnection)
	{
		CheckDestroyed();
		if (!InitConnectionGraphNodesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:InitConnectionGraphNodesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitConnectionGraphNodesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitConnectionGraphNodesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNetReplicationGraphConnection>.ToNative(IntPtr.Add(intPtr, InitConnectionGraphNodesCS_RepGraphConnection_Offset), 0, InitConnectionGraphNodesCS_RepGraphConnection_PropertyAddress.Address, RepGraphConnection);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitConnectionGraphNodesCS_FunctionAddress, intPtr, InitConnectionGraphNodesCS_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:GSNetworkRemapPathCS")]
	public unsafe void GSNetworkRemapPathCS(UObject Outer, string OriginName, out string Name)
	{
		CheckDestroyed();
		if (!GSNetworkRemapPathCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:GSNetworkRemapPathCS");
			Name = FStringMarshaler.DefaultString;
			return;
		}
		if (GSNetworkRemapPathCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNetworkRemapPathCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNetworkRemapPathCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNetworkRemapPathCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNetworkRemapPathCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Outer_Offset), 0, GSNetworkRemapPathCS_Outer_PropertyAddress.Address, Outer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_OriginName_Offset), 0, GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, OriginName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNetworkRemapPathCS_InstanceFunctionAddress, intPtr, GSNetworkRemapPathCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, intPtr);
		Name = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Name_Offset), 0, GSNetworkRemapPathCS_Name_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_Name_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GSNetworkRemapPathCS_Implementation(UObject Outer, string OriginName, out string Name)
	{
		CheckDestroyed();
		if (!GSNetworkRemapPathCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:GSNetworkRemapPathCS");
			Name = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNetworkRemapPathCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNetworkRemapPathCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Outer_Offset), 0, GSNetworkRemapPathCS_Outer_PropertyAddress.Address, Outer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_OriginName_Offset), 0, GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, OriginName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNetworkRemapPathCS_FunctionAddress, intPtr, GSNetworkRemapPathCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, intPtr);
		Name = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Name_Offset), 0, GSNetworkRemapPathCS_Name_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_Name_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:GetWorldCS")]
	public unsafe UWorld GetWorldCS()
	{
		CheckDestroyed();
		if (!GetWorldCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:GetWorldCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldCS_FunctionAddress, intPtr, GetWorldCS_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetWorldCS_ReturnValue_Offset), 0, GetWorldCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:GetServerConnectionCS")]
	public unsafe UNetConnection GetServerConnectionCS()
	{
		CheckDestroyed();
		if (!GetServerConnectionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:GetServerConnectionCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetServerConnectionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetServerConnectionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetServerConnectionCS_FunctionAddress, intPtr, GetServerConnectionCS_ParamsSize);
		return UObjectMarshaler<UNetConnection>.FromNative(IntPtr.Add(intPtr, GetServerConnectionCS_ReturnValue_Offset), 0, GetServerConnectionCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:GetReplicationGraphConnectionByPC")]
	public unsafe UB1NetReplicationGraphConnection GetReplicationGraphConnectionByPC(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!GetReplicationGraphConnectionByPC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:GetReplicationGraphConnectionByPC");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReplicationGraphConnectionByPC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReplicationGraphConnectionByPC_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetReplicationGraphConnectionByPC_PlayerController_Offset), 0, GetReplicationGraphConnectionByPC_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReplicationGraphConnectionByPC_FunctionAddress, intPtr, GetReplicationGraphConnectionByPC_ParamsSize);
		return UObjectMarshaler<UB1NetReplicationGraphConnection>.FromNative(IntPtr.Add(intPtr, GetReplicationGraphConnectionByPC_ReturnValue_Offset), 0, GetReplicationGraphConnectionByPC_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:GetConnectionByIndexCS")]
	public unsafe UNetReplicationGraphConnection GetConnectionByIndexCS(int Idx)
	{
		CheckDestroyed();
		if (!GetConnectionByIndexCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:GetConnectionByIndexCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConnectionByIndexCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConnectionByIndexCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetConnectionByIndexCS_Idx_Offset), 0, GetConnectionByIndexCS_Idx_PropertyAddress.Address, Idx);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConnectionByIndexCS_FunctionAddress, intPtr, GetConnectionByIndexCS_ParamsSize);
		return UObjectMarshaler<UNetReplicationGraphConnection>.FromNative(IntPtr.Add(intPtr, GetConnectionByIndexCS_ReturnValue_Offset), 0, GetConnectionByIndexCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:ClienResetActorChannelCS")]
	public unsafe void ClienResetActorChannelCS(ABGUCharacter Actor)
	{
		CheckDestroyed();
		if (!ClienResetActorChannelCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:ClienResetActorChannelCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClienResetActorChannelCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClienResetActorChannelCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, ClienResetActorChannelCS_Actor_Offset), 0, ClienResetActorChannelCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClienResetActorChannelCS_FunctionAddress, intPtr, ClienResetActorChannelCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:AddNetworkActorCS")]
	public unsafe void AddNetworkActorCS(AActor Actor)
	{
		CheckDestroyed();
		if (!AddNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:AddNetworkActorCS");
			return;
		}
		if (AddNetworkActorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			AddNetworkActorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "AddNetworkActorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddNetworkActorCS_Actor_Offset), 0, AddNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNetworkActorCS_InstanceFunctionAddress, intPtr, AddNetworkActorCS_ParamsSize);
	}

	protected unsafe virtual void AddNetworkActorCS_Implementation(AActor Actor)
	{
		CheckDestroyed();
		if (!AddNetworkActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:AddNetworkActorCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNetworkActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNetworkActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddNetworkActorCS_Actor_Offset), 0, AddNetworkActorCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNetworkActorCS_FunctionAddress, intPtr, AddNetworkActorCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:AddConnectionGraphNodeCS")]
	public unsafe void AddConnectionGraphNodeCS(UReplicationGraphNode GraphNode, UNetReplicationGraphConnection ConnectionManager)
	{
		CheckDestroyed();
		if (!AddConnectionGraphNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:AddConnectionGraphNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddConnectionGraphNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddConnectionGraphNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UReplicationGraphNode>.ToNative(IntPtr.Add(intPtr, AddConnectionGraphNodeCS_GraphNode_Offset), 0, AddConnectionGraphNodeCS_GraphNode_PropertyAddress.Address, GraphNode);
		UObjectMarshaler<UNetReplicationGraphConnection>.ToNative(IntPtr.Add(intPtr, AddConnectionGraphNodeCS_ConnectionManager_Offset), 0, AddConnectionGraphNodeCS_ConnectionManager_PropertyAddress.Address, ConnectionManager);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddConnectionGraphNodeCS_FunctionAddress, intPtr, AddConnectionGraphNodeCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1ReplicationGraph:AddBGUCharacterToAlwaysRelevantNodeCS")]
	public unsafe void AddBGUCharacterToAlwaysRelevantNodeCS(ABGUCharacter Actor)
	{
		CheckDestroyed();
		if (!AddBGUCharacterToAlwaysRelevantNodeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1ReplicationGraph:AddBGUCharacterToAlwaysRelevantNodeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBGUCharacterToAlwaysRelevantNodeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBGUCharacterToAlwaysRelevantNodeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, AddBGUCharacterToAlwaysRelevantNodeCS_Actor_Offset), 0, AddBGUCharacterToAlwaysRelevantNodeCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress, intPtr, AddBGUCharacterToAlwaysRelevantNodeCS_ParamsSize);
	}

	static UB1ReplicationGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UB1ReplicationGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UB1ReplicationGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.B1ReplicationGraph");
		ShouldServerMultiCastRPCForPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ShouldServerMultiCastRPCForPlayerCS");
		ShouldServerMultiCastRPCForPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldServerMultiCastRPCForPlayerCS_Controller_PropertyAddress, ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Controller");
		ShouldServerMultiCastRPCForPlayerCS_Controller_Offset = NativeReflectionCached.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Controller");
		ShouldServerMultiCastRPCForPlayerCS_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldServerMultiCastRPCForPlayerCS_Actor_PropertyAddress, ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Actor");
		ShouldServerMultiCastRPCForPlayerCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Actor");
		ShouldServerMultiCastRPCForPlayerCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldServerMultiCastRPCForPlayerCS_FuncAddr_PropertyAddress, ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "FuncAddr");
		ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset = NativeReflectionCached.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "FuncAddr");
		ShouldServerMultiCastRPCForPlayerCS_FuncAddr_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "FuncAddr", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress, ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "ReturnValue");
		ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "ReturnValue");
		ShouldServerMultiCastRPCForPlayerCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldServerMultiCastRPCForPlayerCS_IsValid = ShouldServerMultiCastRPCForPlayerCS_FunctionAddress != IntPtr.Zero && ShouldServerMultiCastRPCForPlayerCS_Controller_IsValid && ShouldServerMultiCastRPCForPlayerCS_Actor_IsValid && ShouldServerMultiCastRPCForPlayerCS_FuncAddr_IsValid && ShouldServerMultiCastRPCForPlayerCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:ShouldServerMultiCastRPCForPlayerCS", ShouldServerMultiCastRPCForPlayerCS_IsValid);
		SetRoleSwapOnReplicateCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRoleSwapOnReplicateCS");
		SetRoleSwapOnReplicateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRoleSwapOnReplicateCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRoleSwapOnReplicateCS_Actor_PropertyAddress, SetRoleSwapOnReplicateCS_FunctionAddress, "Actor");
		SetRoleSwapOnReplicateCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetRoleSwapOnReplicateCS_FunctionAddress, "Actor");
		SetRoleSwapOnReplicateCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoleSwapOnReplicateCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRoleSwapOnReplicateCS_Swap_PropertyAddress, SetRoleSwapOnReplicateCS_FunctionAddress, "Swap");
		SetRoleSwapOnReplicateCS_Swap_Offset = NativeReflectionCached.GetPropertyOffset(SetRoleSwapOnReplicateCS_FunctionAddress, "Swap");
		SetRoleSwapOnReplicateCS_Swap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoleSwapOnReplicateCS_FunctionAddress, "Swap", Classes.FBoolProperty);
		SetRoleSwapOnReplicateCS_IsValid = SetRoleSwapOnReplicateCS_FunctionAddress != IntPtr.Zero && SetRoleSwapOnReplicateCS_Actor_IsValid && SetRoleSwapOnReplicateCS_Swap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:SetRoleSwapOnReplicateCS", SetRoleSwapOnReplicateCS_IsValid);
		SetGlobalReplicationClassInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGlobalReplicationClassInfo");
		SetGlobalReplicationClassInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalReplicationClassInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalReplicationClassInfo_ReplicatedClass_PropertyAddress, SetGlobalReplicationClassInfo_FunctionAddress, "ReplicatedClass");
		SetGlobalReplicationClassInfo_ReplicatedClass_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalReplicationClassInfo_FunctionAddress, "ReplicatedClass");
		SetGlobalReplicationClassInfo_ReplicatedClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalReplicationClassInfo_FunctionAddress, "ReplicatedClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalReplicationClassInfo_CullDistanceSquared_PropertyAddress, SetGlobalReplicationClassInfo_FunctionAddress, "CullDistanceSquared");
		SetGlobalReplicationClassInfo_CullDistanceSquared_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalReplicationClassInfo_FunctionAddress, "CullDistanceSquared");
		SetGlobalReplicationClassInfo_CullDistanceSquared_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalReplicationClassInfo_FunctionAddress, "CullDistanceSquared", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalReplicationClassInfo_ReplicationPeriodFrame_PropertyAddress, SetGlobalReplicationClassInfo_FunctionAddress, "ReplicationPeriodFrame");
		SetGlobalReplicationClassInfo_ReplicationPeriodFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalReplicationClassInfo_FunctionAddress, "ReplicationPeriodFrame");
		SetGlobalReplicationClassInfo_ReplicationPeriodFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalReplicationClassInfo_FunctionAddress, "ReplicationPeriodFrame", Classes.FIntProperty);
		SetGlobalReplicationClassInfo_IsValid = SetGlobalReplicationClassInfo_FunctionAddress != IntPtr.Zero && SetGlobalReplicationClassInfo_ReplicatedClass_IsValid && SetGlobalReplicationClassInfo_CullDistanceSquared_IsValid && SetGlobalReplicationClassInfo_ReplicationPeriodFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:SetGlobalReplicationClassInfo", SetGlobalReplicationClassInfo_IsValid);
		SetAlwaysRelevantNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAlwaysRelevantNodeCS");
		SetAlwaysRelevantNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlwaysRelevantNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_PropertyAddress, SetAlwaysRelevantNodeCS_FunctionAddress, "AlwaysRelevantNodeCS");
		SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_Offset = NativeReflectionCached.GetPropertyOffset(SetAlwaysRelevantNodeCS_FunctionAddress, "AlwaysRelevantNodeCS");
		SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlwaysRelevantNodeCS_FunctionAddress, "AlwaysRelevantNodeCS", Classes.FObjectProperty);
		SetAlwaysRelevantNodeCS_IsValid = SetAlwaysRelevantNodeCS_FunctionAddress != IntPtr.Zero && SetAlwaysRelevantNodeCS_AlwaysRelevantNodeCS_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:SetAlwaysRelevantNodeCS", SetAlwaysRelevantNodeCS_IsValid);
		RouteRemoveNetworkActorToNodesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RouteRemoveNetworkActorToNodesCS");
		RouteRemoveNetworkActorToNodesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RouteRemoveNetworkActorToNodesCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RouteRemoveNetworkActorToNodesCS_Actor_PropertyAddress, RouteRemoveNetworkActorToNodesCS_FunctionAddress, "Actor");
		RouteRemoveNetworkActorToNodesCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(RouteRemoveNetworkActorToNodesCS_FunctionAddress, "Actor");
		RouteRemoveNetworkActorToNodesCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(RouteRemoveNetworkActorToNodesCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		RouteRemoveNetworkActorToNodesCS_IsValid = RouteRemoveNetworkActorToNodesCS_FunctionAddress != IntPtr.Zero && RouteRemoveNetworkActorToNodesCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:RouteRemoveNetworkActorToNodesCS", RouteRemoveNetworkActorToNodesCS_IsValid);
		RouteAddNetworkActorToNodesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RouteAddNetworkActorToNodesCS");
		RouteAddNetworkActorToNodesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RouteAddNetworkActorToNodesCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RouteAddNetworkActorToNodesCS_Actor_PropertyAddress, RouteAddNetworkActorToNodesCS_FunctionAddress, "Actor");
		RouteAddNetworkActorToNodesCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(RouteAddNetworkActorToNodesCS_FunctionAddress, "Actor");
		RouteAddNetworkActorToNodesCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(RouteAddNetworkActorToNodesCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RouteAddNetworkActorToNodesCS_WorldLocation_PropertyAddress, RouteAddNetworkActorToNodesCS_FunctionAddress, "WorldLocation");
		RouteAddNetworkActorToNodesCS_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(RouteAddNetworkActorToNodesCS_FunctionAddress, "WorldLocation");
		RouteAddNetworkActorToNodesCS_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(RouteAddNetworkActorToNodesCS_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		RouteAddNetworkActorToNodesCS_IsValid = RouteAddNetworkActorToNodesCS_FunctionAddress != IntPtr.Zero && RouteAddNetworkActorToNodesCS_Actor_IsValid && RouteAddNetworkActorToNodesCS_WorldLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:RouteAddNetworkActorToNodesCS", RouteAddNetworkActorToNodesCS_IsValid);
		ResetGameWorldStateCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetGameWorldStateCS");
		ResetGameWorldStateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetGameWorldStateCS_FunctionAddress);
		ResetGameWorldStateCS_IsValid = ResetGameWorldStateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:ResetGameWorldStateCS", ResetGameWorldStateCS_IsValid);
		RemoveNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveNetworkActorCS");
		RemoveNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNetworkActorCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveNetworkActorCS_Actor_PropertyAddress, RemoveNetworkActorCS_FunctionAddress, "Actor");
		RemoveNetworkActorCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNetworkActorCS_FunctionAddress, "Actor");
		RemoveNetworkActorCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		RemoveNetworkActorCS_IsValid = RemoveNetworkActorCS_FunctionAddress != IntPtr.Zero && RemoveNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:RemoveNetworkActorCS", RemoveNetworkActorCS_IsValid);
		RemoveConnectionGraphNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveConnectionGraphNodeCS");
		RemoveConnectionGraphNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveConnectionGraphNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveConnectionGraphNodeCS_GraphNode_PropertyAddress, RemoveConnectionGraphNodeCS_FunctionAddress, "GraphNode");
		RemoveConnectionGraphNodeCS_GraphNode_Offset = NativeReflectionCached.GetPropertyOffset(RemoveConnectionGraphNodeCS_FunctionAddress, "GraphNode");
		RemoveConnectionGraphNodeCS_GraphNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveConnectionGraphNodeCS_FunctionAddress, "GraphNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveConnectionGraphNodeCS_ConnectionManager_PropertyAddress, RemoveConnectionGraphNodeCS_FunctionAddress, "ConnectionManager");
		RemoveConnectionGraphNodeCS_ConnectionManager_Offset = NativeReflectionCached.GetPropertyOffset(RemoveConnectionGraphNodeCS_FunctionAddress, "ConnectionManager");
		RemoveConnectionGraphNodeCS_ConnectionManager_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveConnectionGraphNodeCS_FunctionAddress, "ConnectionManager", Classes.FObjectProperty);
		RemoveConnectionGraphNodeCS_IsValid = RemoveConnectionGraphNodeCS_FunctionAddress != IntPtr.Zero && RemoveConnectionGraphNodeCS_GraphNode_IsValid && RemoveConnectionGraphNodeCS_ConnectionManager_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:RemoveConnectionGraphNodeCS", RemoveConnectionGraphNodeCS_IsValid);
		RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveBGUCharacterFromAlwaysRelevantNodeCS");
		RemoveBGUCharacterFromAlwaysRelevantNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_PropertyAddress, RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress, "Actor");
		RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress, "Actor");
		RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		RemoveBGUCharacterFromAlwaysRelevantNodeCS_IsValid = RemoveBGUCharacterFromAlwaysRelevantNodeCS_FunctionAddress != IntPtr.Zero && RemoveBGUCharacterFromAlwaysRelevantNodeCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:RemoveBGUCharacterFromAlwaysRelevantNodeCS", RemoveBGUCharacterFromAlwaysRelevantNodeCS_IsValid);
		InitNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitNodeCS");
		InitNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitNodeCS_CSNode_PropertyAddress, InitNodeCS_FunctionAddress, "CSNode");
		InitNodeCS_CSNode_Offset = NativeReflectionCached.GetPropertyOffset(InitNodeCS_FunctionAddress, "CSNode");
		InitNodeCS_CSNode_IsValid = NativeReflectionCached.ValidatePropertyClass(InitNodeCS_FunctionAddress, "CSNode", Classes.FObjectProperty);
		InitNodeCS_IsValid = InitNodeCS_FunctionAddress != IntPtr.Zero && InitNodeCS_CSNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:InitNodeCS", InitNodeCS_IsValid);
		InitGlobalGraphNodesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitGlobalGraphNodesCS");
		InitGlobalGraphNodesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitGlobalGraphNodesCS_FunctionAddress);
		InitGlobalGraphNodesCS_IsValid = InitGlobalGraphNodesCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:InitGlobalGraphNodesCS", InitGlobalGraphNodesCS_IsValid);
		InitGlobalActorClassSettingsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitGlobalActorClassSettingsCS");
		InitGlobalActorClassSettingsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitGlobalActorClassSettingsCS_FunctionAddress);
		InitGlobalActorClassSettingsCS_IsValid = InitGlobalActorClassSettingsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:InitGlobalActorClassSettingsCS", InitGlobalActorClassSettingsCS_IsValid);
		InitConnectionGraphNodesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitConnectionGraphNodesCS");
		InitConnectionGraphNodesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitConnectionGraphNodesCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitConnectionGraphNodesCS_RepGraphConnection_PropertyAddress, InitConnectionGraphNodesCS_FunctionAddress, "RepGraphConnection");
		InitConnectionGraphNodesCS_RepGraphConnection_Offset = NativeReflectionCached.GetPropertyOffset(InitConnectionGraphNodesCS_FunctionAddress, "RepGraphConnection");
		InitConnectionGraphNodesCS_RepGraphConnection_IsValid = NativeReflectionCached.ValidatePropertyClass(InitConnectionGraphNodesCS_FunctionAddress, "RepGraphConnection", Classes.FObjectProperty);
		InitConnectionGraphNodesCS_IsValid = InitConnectionGraphNodesCS_FunctionAddress != IntPtr.Zero && InitConnectionGraphNodesCS_RepGraphConnection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:InitConnectionGraphNodesCS", InitConnectionGraphNodesCS_IsValid);
		GSNetworkRemapPathCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNetworkRemapPathCS");
		GSNetworkRemapPathCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNetworkRemapPathCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPathCS_Outer_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "Outer");
		GSNetworkRemapPathCS_Outer_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Outer");
		GSNetworkRemapPathCS_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPathCS_OriginName_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "OriginName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPathCS_Name_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Name", Classes.FStrProperty);
		GSNetworkRemapPathCS_IsValid = GSNetworkRemapPathCS_FunctionAddress != IntPtr.Zero && GSNetworkRemapPathCS_Outer_IsValid && GSNetworkRemapPathCS_OriginName_IsValid && GSNetworkRemapPathCS_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:GSNetworkRemapPathCS", GSNetworkRemapPathCS_IsValid);
		GetWorldCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorldCS");
		GetWorldCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldCS_ReturnValue_PropertyAddress, GetWorldCS_FunctionAddress, "ReturnValue");
		GetWorldCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldCS_FunctionAddress, "ReturnValue");
		GetWorldCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldCS_IsValid = GetWorldCS_FunctionAddress != IntPtr.Zero && GetWorldCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:GetWorldCS", GetWorldCS_IsValid);
		GetServerConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetServerConnectionCS");
		GetServerConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetServerConnectionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetServerConnectionCS_ReturnValue_PropertyAddress, GetServerConnectionCS_FunctionAddress, "ReturnValue");
		GetServerConnectionCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetServerConnectionCS_FunctionAddress, "ReturnValue");
		GetServerConnectionCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetServerConnectionCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetServerConnectionCS_IsValid = GetServerConnectionCS_FunctionAddress != IntPtr.Zero && GetServerConnectionCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:GetServerConnectionCS", GetServerConnectionCS_IsValid);
		GetReplicationGraphConnectionByPC_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetReplicationGraphConnectionByPC");
		GetReplicationGraphConnectionByPC_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReplicationGraphConnectionByPC_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReplicationGraphConnectionByPC_PlayerController_PropertyAddress, GetReplicationGraphConnectionByPC_FunctionAddress, "PlayerController");
		GetReplicationGraphConnectionByPC_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetReplicationGraphConnectionByPC_FunctionAddress, "PlayerController");
		GetReplicationGraphConnectionByPC_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReplicationGraphConnectionByPC_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReplicationGraphConnectionByPC_ReturnValue_PropertyAddress, GetReplicationGraphConnectionByPC_FunctionAddress, "ReturnValue");
		GetReplicationGraphConnectionByPC_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReplicationGraphConnectionByPC_FunctionAddress, "ReturnValue");
		GetReplicationGraphConnectionByPC_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReplicationGraphConnectionByPC_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReplicationGraphConnectionByPC_IsValid = GetReplicationGraphConnectionByPC_FunctionAddress != IntPtr.Zero && GetReplicationGraphConnectionByPC_PlayerController_IsValid && GetReplicationGraphConnectionByPC_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:GetReplicationGraphConnectionByPC", GetReplicationGraphConnectionByPC_IsValid);
		GetConnectionByIndexCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetConnectionByIndexCS");
		GetConnectionByIndexCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConnectionByIndexCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConnectionByIndexCS_Idx_PropertyAddress, GetConnectionByIndexCS_FunctionAddress, "Idx");
		GetConnectionByIndexCS_Idx_Offset = NativeReflectionCached.GetPropertyOffset(GetConnectionByIndexCS_FunctionAddress, "Idx");
		GetConnectionByIndexCS_Idx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConnectionByIndexCS_FunctionAddress, "Idx", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConnectionByIndexCS_ReturnValue_PropertyAddress, GetConnectionByIndexCS_FunctionAddress, "ReturnValue");
		GetConnectionByIndexCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConnectionByIndexCS_FunctionAddress, "ReturnValue");
		GetConnectionByIndexCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConnectionByIndexCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetConnectionByIndexCS_IsValid = GetConnectionByIndexCS_FunctionAddress != IntPtr.Zero && GetConnectionByIndexCS_Idx_IsValid && GetConnectionByIndexCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:GetConnectionByIndexCS", GetConnectionByIndexCS_IsValid);
		ClienResetActorChannelCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClienResetActorChannelCS");
		ClienResetActorChannelCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ClienResetActorChannelCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClienResetActorChannelCS_Actor_PropertyAddress, ClienResetActorChannelCS_FunctionAddress, "Actor");
		ClienResetActorChannelCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ClienResetActorChannelCS_FunctionAddress, "Actor");
		ClienResetActorChannelCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ClienResetActorChannelCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		ClienResetActorChannelCS_IsValid = ClienResetActorChannelCS_FunctionAddress != IntPtr.Zero && ClienResetActorChannelCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:ClienResetActorChannelCS", ClienResetActorChannelCS_IsValid);
		AddNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddNetworkActorCS");
		AddNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNetworkActorCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNetworkActorCS_Actor_PropertyAddress, AddNetworkActorCS_FunctionAddress, "Actor");
		AddNetworkActorCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddNetworkActorCS_FunctionAddress, "Actor");
		AddNetworkActorCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		AddNetworkActorCS_IsValid = AddNetworkActorCS_FunctionAddress != IntPtr.Zero && AddNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:AddNetworkActorCS", AddNetworkActorCS_IsValid);
		AddConnectionGraphNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddConnectionGraphNodeCS");
		AddConnectionGraphNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AddConnectionGraphNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddConnectionGraphNodeCS_GraphNode_PropertyAddress, AddConnectionGraphNodeCS_FunctionAddress, "GraphNode");
		AddConnectionGraphNodeCS_GraphNode_Offset = NativeReflectionCached.GetPropertyOffset(AddConnectionGraphNodeCS_FunctionAddress, "GraphNode");
		AddConnectionGraphNodeCS_GraphNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddConnectionGraphNodeCS_FunctionAddress, "GraphNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddConnectionGraphNodeCS_ConnectionManager_PropertyAddress, AddConnectionGraphNodeCS_FunctionAddress, "ConnectionManager");
		AddConnectionGraphNodeCS_ConnectionManager_Offset = NativeReflectionCached.GetPropertyOffset(AddConnectionGraphNodeCS_FunctionAddress, "ConnectionManager");
		AddConnectionGraphNodeCS_ConnectionManager_IsValid = NativeReflectionCached.ValidatePropertyClass(AddConnectionGraphNodeCS_FunctionAddress, "ConnectionManager", Classes.FObjectProperty);
		AddConnectionGraphNodeCS_IsValid = AddConnectionGraphNodeCS_FunctionAddress != IntPtr.Zero && AddConnectionGraphNodeCS_GraphNode_IsValid && AddConnectionGraphNodeCS_ConnectionManager_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:AddConnectionGraphNodeCS", AddConnectionGraphNodeCS_IsValid);
		AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBGUCharacterToAlwaysRelevantNodeCS");
		AddBGUCharacterToAlwaysRelevantNodeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBGUCharacterToAlwaysRelevantNodeCS_Actor_PropertyAddress, AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress, "Actor");
		AddBGUCharacterToAlwaysRelevantNodeCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress, "Actor");
		AddBGUCharacterToAlwaysRelevantNodeCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		AddBGUCharacterToAlwaysRelevantNodeCS_IsValid = AddBGUCharacterToAlwaysRelevantNodeCS_FunctionAddress != IntPtr.Zero && AddBGUCharacterToAlwaysRelevantNodeCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1ReplicationGraph:AddBGUCharacterToAlwaysRelevantNodeCS", AddBGUCharacterToAlwaysRelevantNodeCS_IsValid);
	}
}
