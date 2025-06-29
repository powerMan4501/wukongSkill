using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.GSE_OnlineFuncLib", "b1", UnrealModuleType.Game)]
public class UGSE_OnlineFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SlowMakeUniqueObjectName_IsValid;

	private static IntPtr SlowMakeUniqueObjectName_FunctionAddress;

	private static int SlowMakeUniqueObjectName_ParamsSize;

	private static bool SlowMakeUniqueObjectName_Parent_IsValid;

	private static FFieldAddress SlowMakeUniqueObjectName_Parent_PropertyAddress;

	private static int SlowMakeUniqueObjectName_Parent_Offset;

	private static bool SlowMakeUniqueObjectName_Class_IsValid;

	private static FFieldAddress SlowMakeUniqueObjectName_Class_PropertyAddress;

	private static int SlowMakeUniqueObjectName_Class_Offset;

	private static bool SlowMakeUniqueObjectName_InBaseName_IsValid;

	private static FFieldAddress SlowMakeUniqueObjectName_InBaseName_PropertyAddress;

	private static int SlowMakeUniqueObjectName_InBaseName_Offset;

	private static bool SlowMakeUniqueObjectName_ReturnValue_IsValid;

	private static FFieldAddress SlowMakeUniqueObjectName_ReturnValue_PropertyAddress;

	private static int SlowMakeUniqueObjectName_ReturnValue_Offset;

	private static bool SetGameDefaultMap_IsValid;

	private static IntPtr SetGameDefaultMap_FunctionAddress;

	private static int SetGameDefaultMap_ParamsSize;

	private static bool SetGameDefaultMap_NewMap_IsValid;

	private static FFieldAddress SetGameDefaultMap_NewMap_PropertyAddress;

	private static int SetGameDefaultMap_NewMap_Offset;

	private static bool ServerReplicateOneActorToPlayer_IsValid;

	private static IntPtr ServerReplicateOneActorToPlayer_FunctionAddress;

	private static int ServerReplicateOneActorToPlayer_ParamsSize;

	private static bool ServerReplicateOneActorToPlayer_Actor_IsValid;

	private static FFieldAddress ServerReplicateOneActorToPlayer_Actor_PropertyAddress;

	private static int ServerReplicateOneActorToPlayer_Actor_Offset;

	private static bool ServerReplicateOneActorToPlayer_PlayerController_IsValid;

	private static FFieldAddress ServerReplicateOneActorToPlayer_PlayerController_PropertyAddress;

	private static int ServerReplicateOneActorToPlayer_PlayerController_Offset;

	private static bool ServerReplicateOneActorToPlayer_ReturnValue_IsValid;

	private static FFieldAddress ServerReplicateOneActorToPlayer_ReturnValue_PropertyAddress;

	private static int ServerReplicateOneActorToPlayer_ReturnValue_Offset;

	private static bool ResetNetGuidAckStat_IsValid;

	private static IntPtr ResetNetGuidAckStat_FunctionAddress;

	private static int ResetNetGuidAckStat_ParamsSize;

	private static bool ResetNetGuidAckStat_Guid_IsValid;

	private static FFieldAddress ResetNetGuidAckStat_Guid_PropertyAddress;

	private static int ResetNetGuidAckStat_Guid_Offset;

	private static bool ResetNetGuidAckStat_NetConnection_IsValid;

	private static FFieldAddress ResetNetGuidAckStat_NetConnection_PropertyAddress;

	private static int ResetNetGuidAckStat_NetConnection_Offset;

	private static bool RegisterNetGuid_IsValid;

	private static IntPtr RegisterNetGuid_FunctionAddress;

	private static int RegisterNetGuid_ParamsSize;

	private static bool RegisterNetGuid_Guid_IsValid;

	private static FFieldAddress RegisterNetGuid_Guid_PropertyAddress;

	private static int RegisterNetGuid_Guid_Offset;

	private static bool RegisterNetGuid_Obj_IsValid;

	private static FFieldAddress RegisterNetGuid_Obj_PropertyAddress;

	private static int RegisterNetGuid_Obj_Offset;

	private static bool MarkActorRoleDirty_IsValid;

	private static IntPtr MarkActorRoleDirty_FunctionAddress;

	private static int MarkActorRoleDirty_ParamsSize;

	private static bool MarkActorRoleDirty_Actor_IsValid;

	private static FFieldAddress MarkActorRoleDirty_Actor_PropertyAddress;

	private static int MarkActorRoleDirty_Actor_Offset;

	private static bool IsActorChannelReadyForServer_IsValid;

	private static IntPtr IsActorChannelReadyForServer_FunctionAddress;

	private static int IsActorChannelReadyForServer_ParamsSize;

	private static bool IsActorChannelReadyForServer_Actor_IsValid;

	private static FFieldAddress IsActorChannelReadyForServer_Actor_PropertyAddress;

	private static int IsActorChannelReadyForServer_Actor_Offset;

	private static bool IsActorChannelReadyForServer_PlayerController_IsValid;

	private static FFieldAddress IsActorChannelReadyForServer_PlayerController_PropertyAddress;

	private static int IsActorChannelReadyForServer_PlayerController_Offset;

	private static bool IsActorChannelReadyForServer_ReturnValue_IsValid;

	private static FFieldAddress IsActorChannelReadyForServer_ReturnValue_PropertyAddress;

	private static int IsActorChannelReadyForServer_ReturnValue_Offset;

	private static bool IsActorChannelReadyForClient_IsValid;

	private static IntPtr IsActorChannelReadyForClient_FunctionAddress;

	private static int IsActorChannelReadyForClient_ParamsSize;

	private static bool IsActorChannelReadyForClient_Actor_IsValid;

	private static FFieldAddress IsActorChannelReadyForClient_Actor_PropertyAddress;

	private static int IsActorChannelReadyForClient_Actor_Offset;

	private static bool IsActorChannelReadyForClient_ReturnValue_IsValid;

	private static FFieldAddress IsActorChannelReadyForClient_ReturnValue_PropertyAddress;

	private static int IsActorChannelReadyForClient_ReturnValue_Offset;

	private static bool InServerReal_IsValid;

	private static IntPtr InServerReal_FunctionAddress;

	private static int InServerReal_ParamsSize;

	private static bool InServerReal_WorldCtx_IsValid;

	private static FFieldAddress InServerReal_WorldCtx_PropertyAddress;

	private static int InServerReal_WorldCtx_Offset;

	private static bool InServerReal_ReturnValue_IsValid;

	private static FFieldAddress InServerReal_ReturnValue_PropertyAddress;

	private static int InServerReal_ReturnValue_Offset;

	private static bool GetUniqueNetIdStringByPlayerState_IsValid;

	private static IntPtr GetUniqueNetIdStringByPlayerState_FunctionAddress;

	private static int GetUniqueNetIdStringByPlayerState_ParamsSize;

	private static bool GetUniqueNetIdStringByPlayerState_PlayerState_IsValid;

	private static FFieldAddress GetUniqueNetIdStringByPlayerState_PlayerState_PropertyAddress;

	private static int GetUniqueNetIdStringByPlayerState_PlayerState_Offset;

	private static bool GetUniqueNetIdStringByPlayerState_ReturnValue_IsValid;

	private static FFieldAddress GetUniqueNetIdStringByPlayerState_ReturnValue_PropertyAddress;

	private static int GetUniqueNetIdStringByPlayerState_ReturnValue_Offset;

	private static bool GetUniqueNetIdStringByPlayerController_IsValid;

	private static IntPtr GetUniqueNetIdStringByPlayerController_FunctionAddress;

	private static int GetUniqueNetIdStringByPlayerController_ParamsSize;

	private static bool GetUniqueNetIdStringByPlayerController_Controller_IsValid;

	private static FFieldAddress GetUniqueNetIdStringByPlayerController_Controller_PropertyAddress;

	private static int GetUniqueNetIdStringByPlayerController_Controller_Offset;

	private static bool GetUniqueNetIdStringByPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetUniqueNetIdStringByPlayerController_ReturnValue_PropertyAddress;

	private static int GetUniqueNetIdStringByPlayerController_ReturnValue_Offset;

	private static bool GetUniqueNetIdStringByFUniqueNetIdRepl_IsValid;

	private static IntPtr GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress;

	private static int GetUniqueNetIdStringByFUniqueNetIdRepl_ParamsSize;

	private static bool GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_IsValid;

	private static FFieldAddress GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_PropertyAddress;

	private static int GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_Offset;

	private static bool GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_IsValid;

	private static FFieldAddress GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_PropertyAddress;

	private static int GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_Offset;

	private static bool GetReplicationGraph_IsValid;

	private static IntPtr GetReplicationGraph_FunctionAddress;

	private static int GetReplicationGraph_ParamsSize;

	private static bool GetReplicationGraph_WorldCtx_IsValid;

	private static FFieldAddress GetReplicationGraph_WorldCtx_PropertyAddress;

	private static int GetReplicationGraph_WorldCtx_Offset;

	private static bool GetReplicationGraph_ReturnValue_IsValid;

	private static FFieldAddress GetReplicationGraph_ReturnValue_PropertyAddress;

	private static int GetReplicationGraph_ReturnValue_Offset;

	private static bool GetObjNetGuidByChannel_IsValid;

	private static IntPtr GetObjNetGuidByChannel_FunctionAddress;

	private static int GetObjNetGuidByChannel_ParamsSize;

	private static bool GetObjNetGuidByChannel_Channel_IsValid;

	private static FFieldAddress GetObjNetGuidByChannel_Channel_PropertyAddress;

	private static int GetObjNetGuidByChannel_Channel_Offset;

	private static bool GetObjNetGuidByChannel_ReturnValue_IsValid;

	private static FFieldAddress GetObjNetGuidByChannel_ReturnValue_PropertyAddress;

	private static int GetObjNetGuidByChannel_ReturnValue_Offset;

	private static bool GetObjNetGuid_IsValid;

	private static IntPtr GetObjNetGuid_FunctionAddress;

	private static int GetObjNetGuid_ParamsSize;

	private static bool GetObjNetGuid_Obj_IsValid;

	private static FFieldAddress GetObjNetGuid_Obj_PropertyAddress;

	private static int GetObjNetGuid_Obj_Offset;

	private static bool GetObjNetGuid_ReturnValue_IsValid;

	private static FFieldAddress GetObjNetGuid_ReturnValue_PropertyAddress;

	private static int GetObjNetGuid_ReturnValue_Offset;

	private static bool GetObjByNetGuid_IsValid;

	private static IntPtr GetObjByNetGuid_FunctionAddress;

	private static int GetObjByNetGuid_ParamsSize;

	private static bool GetObjByNetGuid_WorldCtx_IsValid;

	private static FFieldAddress GetObjByNetGuid_WorldCtx_PropertyAddress;

	private static int GetObjByNetGuid_WorldCtx_Offset;

	private static bool GetObjByNetGuid_GUID_IsValid;

	private static FFieldAddress GetObjByNetGuid_GUID_PropertyAddress;

	private static int GetObjByNetGuid_GUID_Offset;

	private static bool GetObjByNetGuid_ReturnValue_IsValid;

	private static FFieldAddress GetObjByNetGuid_ReturnValue_PropertyAddress;

	private static int GetObjByNetGuid_ReturnValue_Offset;

	private static bool GetGameDefaultMap_IsValid;

	private static IntPtr GetGameDefaultMap_FunctionAddress;

	private static int GetGameDefaultMap_ParamsSize;

	private static bool GetGameDefaultMap_ReturnValue_IsValid;

	private static FFieldAddress GetGameDefaultMap_ReturnValue_PropertyAddress;

	private static int GetGameDefaultMap_ReturnValue_Offset;

	private static bool GetActorChannelActor_IsValid;

	private static IntPtr GetActorChannelActor_FunctionAddress;

	private static int GetActorChannelActor_ParamsSize;

	private static bool GetActorChannelActor_Channel_IsValid;

	private static FFieldAddress GetActorChannelActor_Channel_PropertyAddress;

	private static int GetActorChannelActor_Channel_Offset;

	private static bool GetActorChannelActor_ReturnValue_IsValid;

	private static FFieldAddress GetActorChannelActor_ReturnValue_PropertyAddress;

	private static int GetActorChannelActor_ReturnValue_Offset;

	private static bool GEngineHandleDisconnect_IsValid;

	private static IntPtr GEngineHandleDisconnect_FunctionAddress;

	private static int GEngineHandleDisconnect_ParamsSize;

	private static bool GEngineHandleDisconnect_World_IsValid;

	private static FFieldAddress GEngineHandleDisconnect_World_PropertyAddress;

	private static int GEngineHandleDisconnect_World_Offset;

	private static bool ForceRemoveNetGuid_IsValid;

	private static IntPtr ForceRemoveNetGuid_FunctionAddress;

	private static int ForceRemoveNetGuid_ParamsSize;

	private static bool ForceRemoveNetGuid_Obj_IsValid;

	private static FFieldAddress ForceRemoveNetGuid_Obj_PropertyAddress;

	private static int ForceRemoveNetGuid_Obj_Offset;

	private static bool ForceRemoveNetGuid_ReturnValue_IsValid;

	private static FFieldAddress ForceRemoveNetGuid_ReturnValue_PropertyAddress;

	private static int ForceRemoveNetGuid_ReturnValue_Offset;

	private static bool CloseServerConnection_IsValid;

	private static IntPtr CloseServerConnection_FunctionAddress;

	private static int CloseServerConnection_ParamsSize;

	private static bool CloseServerConnection_CloseResult_IsValid;

	private static FFieldAddress CloseServerConnection_CloseResult_PropertyAddress;

	private static int CloseServerConnection_CloseResult_Offset;

	private static bool CloseServerConnection_WorldContext_IsValid;

	private static FFieldAddress CloseServerConnection_WorldContext_PropertyAddress;

	private static int CloseServerConnection_WorldContext_Offset;

	private static bool CloseClientConnection_IsValid;

	private static IntPtr CloseClientConnection_FunctionAddress;

	private static int CloseClientConnection_ParamsSize;

	private static bool CloseClientConnection_CloseResult_IsValid;

	private static FFieldAddress CloseClientConnection_CloseResult_PropertyAddress;

	private static int CloseClientConnection_CloseResult_Offset;

	private static bool CloseClientConnection_ClientPlayerController_IsValid;

	private static FFieldAddress CloseClientConnection_ClientPlayerController_PropertyAddress;

	private static int CloseClientConnection_ClientPlayerController_Offset;

	private static bool CloseActorChannelByActorAndPlayerController_IsValid;

	private static IntPtr CloseActorChannelByActorAndPlayerController_FunctionAddress;

	private static int CloseActorChannelByActorAndPlayerController_ParamsSize;

	private static bool CloseActorChannelByActorAndPlayerController_Actor_IsValid;

	private static FFieldAddress CloseActorChannelByActorAndPlayerController_Actor_PropertyAddress;

	private static int CloseActorChannelByActorAndPlayerController_Actor_Offset;

	private static bool CloseActorChannelByActorAndPlayerController_PlayerController_IsValid;

	private static FFieldAddress CloseActorChannelByActorAndPlayerController_PlayerController_PropertyAddress;

	private static int CloseActorChannelByActorAndPlayerController_PlayerController_Offset;

	private static bool CloseActorChannelByActorAndPlayerController_CloseReason_IsValid;

	private static FFieldAddress CloseActorChannelByActorAndPlayerController_CloseReason_PropertyAddress;

	private static int CloseActorChannelByActorAndPlayerController_CloseReason_Offset;

	private static bool CloseActorChannelByActorAndPlayerController_ReturnValue_IsValid;

	private static FFieldAddress CloseActorChannelByActorAndPlayerController_ReturnValue_PropertyAddress;

	private static int CloseActorChannelByActorAndPlayerController_ReturnValue_Offset;

	private static bool ActorChannelValid_IsValid;

	private static IntPtr ActorChannelValid_FunctionAddress;

	private static int ActorChannelValid_ParamsSize;

	private static bool ActorChannelValid_Actor_IsValid;

	private static FFieldAddress ActorChannelValid_Actor_PropertyAddress;

	private static int ActorChannelValid_Actor_Offset;

	private static bool ActorChannelValid_PlayerController_IsValid;

	private static FFieldAddress ActorChannelValid_PlayerController_PropertyAddress;

	private static int ActorChannelValid_PlayerController_Offset;

	private static bool ActorChannelValid_ReturnValue_IsValid;

	private static FFieldAddress ActorChannelValid_ReturnValue_PropertyAddress;

	private static int ActorChannelValid_ReturnValue_Offset;

	private static bool ActorChannelOpenAcked_IsValid;

	private static IntPtr ActorChannelOpenAcked_FunctionAddress;

	private static int ActorChannelOpenAcked_ParamsSize;

	private static bool ActorChannelOpenAcked_Actor_IsValid;

	private static FFieldAddress ActorChannelOpenAcked_Actor_PropertyAddress;

	private static int ActorChannelOpenAcked_Actor_Offset;

	private static bool ActorChannelOpenAcked_PlayerController_IsValid;

	private static FFieldAddress ActorChannelOpenAcked_PlayerController_PropertyAddress;

	private static int ActorChannelOpenAcked_PlayerController_Offset;

	private static bool ActorChannelOpenAcked_ReturnValue_IsValid;

	private static FFieldAddress ActorChannelOpenAcked_ReturnValue_PropertyAddress;

	private static int ActorChannelOpenAcked_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:SlowMakeUniqueObjectName")]
	public unsafe static FName SlowMakeUniqueObjectName(UObject Parent, TSubclassOf<UObject> Class, FName InBaseName)
	{
		if (!SlowMakeUniqueObjectName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:SlowMakeUniqueObjectName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlowMakeUniqueObjectName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlowMakeUniqueObjectName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SlowMakeUniqueObjectName_Parent_Offset), 0, SlowMakeUniqueObjectName_Parent_PropertyAddress.Address, Parent);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SlowMakeUniqueObjectName_Class_Offset), 0, SlowMakeUniqueObjectName_Class_PropertyAddress.Address, Class);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SlowMakeUniqueObjectName_InBaseName_Offset), 0, SlowMakeUniqueObjectName_InBaseName_PropertyAddress.Address, InBaseName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlowMakeUniqueObjectName_FunctionAddress, intPtr, SlowMakeUniqueObjectName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, SlowMakeUniqueObjectName_ReturnValue_Offset), 0, SlowMakeUniqueObjectName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:SetGameDefaultMap")]
	public unsafe static void SetGameDefaultMap(string NewMap)
	{
		if (!SetGameDefaultMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:SetGameDefaultMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGameDefaultMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGameDefaultMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetGameDefaultMap_NewMap_Offset), 0, SetGameDefaultMap_NewMap_PropertyAddress.Address, NewMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetGameDefaultMap_FunctionAddress, intPtr, SetGameDefaultMap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetGameDefaultMap_NewMap_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:ServerReplicateOneActorToPlayer")]
	public unsafe static long ServerReplicateOneActorToPlayer(AActor Actor, APlayerController PlayerController)
	{
		if (!ServerReplicateOneActorToPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:ServerReplicateOneActorToPlayer");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ServerReplicateOneActorToPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ServerReplicateOneActorToPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ServerReplicateOneActorToPlayer_Actor_Offset), 0, ServerReplicateOneActorToPlayer_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ServerReplicateOneActorToPlayer_PlayerController_Offset), 0, ServerReplicateOneActorToPlayer_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ServerReplicateOneActorToPlayer_FunctionAddress, intPtr, ServerReplicateOneActorToPlayer_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, ServerReplicateOneActorToPlayer_ReturnValue_Offset), 0, ServerReplicateOneActorToPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:ResetNetGuidAckStat")]
	public unsafe static void ResetNetGuidAckStat(long Guid, UNetConnection NetConnection)
	{
		if (!ResetNetGuidAckStat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:ResetNetGuidAckStat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetNetGuidAckStat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetNetGuidAckStat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, ResetNetGuidAckStat_Guid_Offset), 0, ResetNetGuidAckStat_Guid_PropertyAddress.Address, Guid);
		UObjectMarshaler<UNetConnection>.ToNative(IntPtr.Add(intPtr, ResetNetGuidAckStat_NetConnection_Offset), 0, ResetNetGuidAckStat_NetConnection_PropertyAddress.Address, NetConnection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetNetGuidAckStat_FunctionAddress, intPtr, ResetNetGuidAckStat_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:RegisterNetGuid")]
	public unsafe static void RegisterNetGuid(long Guid, UObject Obj)
	{
		if (!RegisterNetGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:RegisterNetGuid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterNetGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterNetGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, RegisterNetGuid_Guid_Offset), 0, RegisterNetGuid_Guid_PropertyAddress.Address, Guid);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RegisterNetGuid_Obj_Offset), 0, RegisterNetGuid_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterNetGuid_FunctionAddress, intPtr, RegisterNetGuid_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:MarkActorRoleDirty")]
	public unsafe static void MarkActorRoleDirty(AActor Actor)
	{
		if (!MarkActorRoleDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:MarkActorRoleDirty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkActorRoleDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkActorRoleDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, MarkActorRoleDirty_Actor_Offset), 0, MarkActorRoleDirty_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkActorRoleDirty_FunctionAddress, intPtr, MarkActorRoleDirty_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:IsActorChannelReadyForServer")]
	public unsafe static bool IsActorChannelReadyForServer(AActor Actor, APlayerController PlayerController)
	{
		if (!IsActorChannelReadyForServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:IsActorChannelReadyForServer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorChannelReadyForServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorChannelReadyForServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsActorChannelReadyForServer_Actor_Offset), 0, IsActorChannelReadyForServer_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, IsActorChannelReadyForServer_PlayerController_Offset), 0, IsActorChannelReadyForServer_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsActorChannelReadyForServer_FunctionAddress, intPtr, IsActorChannelReadyForServer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorChannelReadyForServer_ReturnValue_Offset), 0, IsActorChannelReadyForServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:IsActorChannelReadyForClient")]
	public unsafe static bool IsActorChannelReadyForClient(AActor Actor)
	{
		if (!IsActorChannelReadyForClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:IsActorChannelReadyForClient");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorChannelReadyForClient_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorChannelReadyForClient_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsActorChannelReadyForClient_Actor_Offset), 0, IsActorChannelReadyForClient_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsActorChannelReadyForClient_FunctionAddress, intPtr, IsActorChannelReadyForClient_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorChannelReadyForClient_ReturnValue_Offset), 0, IsActorChannelReadyForClient_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:InServerReal")]
	public unsafe static bool InServerReal(UObject WorldCtx)
	{
		if (!InServerReal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:InServerReal");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InServerReal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InServerReal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, InServerReal_WorldCtx_Offset), 0, InServerReal_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InServerReal_FunctionAddress, intPtr, InServerReal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InServerReal_ReturnValue_Offset), 0, InServerReal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByPlayerState")]
	public unsafe static string GetUniqueNetIdStringByPlayerState(APlayerState PlayerState)
	{
		if (!GetUniqueNetIdStringByPlayerState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByPlayerState");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueNetIdStringByPlayerState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueNetIdStringByPlayerState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, GetUniqueNetIdStringByPlayerState_PlayerState_Offset), 0, GetUniqueNetIdStringByPlayerState_PlayerState_PropertyAddress.Address, PlayerState);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUniqueNetIdStringByPlayerState_FunctionAddress, intPtr, GetUniqueNetIdStringByPlayerState_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUniqueNetIdStringByPlayerState_ReturnValue_Offset), 0, GetUniqueNetIdStringByPlayerState_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUniqueNetIdStringByPlayerState_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByPlayerController")]
	public unsafe static string GetUniqueNetIdStringByPlayerController(APlayerController Controller)
	{
		if (!GetUniqueNetIdStringByPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByPlayerController");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueNetIdStringByPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueNetIdStringByPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetUniqueNetIdStringByPlayerController_Controller_Offset), 0, GetUniqueNetIdStringByPlayerController_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUniqueNetIdStringByPlayerController_FunctionAddress, intPtr, GetUniqueNetIdStringByPlayerController_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUniqueNetIdStringByPlayerController_ReturnValue_Offset), 0, GetUniqueNetIdStringByPlayerController_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUniqueNetIdStringByPlayerController_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByFUniqueNetIdRepl")]
	public unsafe static string GetUniqueNetIdStringByFUniqueNetIdRepl(FUniqueNetIdRepl UniqueId)
	{
		if (!GetUniqueNetIdStringByFUniqueNetIdRepl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByFUniqueNetIdRepl");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueNetIdStringByFUniqueNetIdRepl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueNetIdStringByFUniqueNetIdRepl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_PropertyAddress.Address, intPtr);
		FUniqueNetIdRepl.ToNative(IntPtr.Add(intPtr, GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_Offset), 0, GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_PropertyAddress.Address, UniqueId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, intPtr, GetUniqueNetIdStringByFUniqueNetIdRepl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_Offset), 0, GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetReplicationGraph")]
	public unsafe static UObject GetReplicationGraph(UObject WorldCtx)
	{
		if (!GetReplicationGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetReplicationGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReplicationGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReplicationGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetReplicationGraph_WorldCtx_Offset), 0, GetReplicationGraph_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReplicationGraph_FunctionAddress, intPtr, GetReplicationGraph_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetReplicationGraph_ReturnValue_Offset), 0, GetReplicationGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetObjNetGuidByChannel")]
	public unsafe static long GetObjNetGuidByChannel(UActorChannel Channel)
	{
		if (!GetObjNetGuidByChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetObjNetGuidByChannel");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjNetGuidByChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjNetGuidByChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorChannel>.ToNative(IntPtr.Add(intPtr, GetObjNetGuidByChannel_Channel_Offset), 0, GetObjNetGuidByChannel_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjNetGuidByChannel_FunctionAddress, intPtr, GetObjNetGuidByChannel_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetObjNetGuidByChannel_ReturnValue_Offset), 0, GetObjNetGuidByChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetObjNetGuid")]
	public unsafe static long GetObjNetGuid(UObject Obj)
	{
		if (!GetObjNetGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetObjNetGuid");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjNetGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjNetGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetObjNetGuid_Obj_Offset), 0, GetObjNetGuid_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjNetGuid_FunctionAddress, intPtr, GetObjNetGuid_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetObjNetGuid_ReturnValue_Offset), 0, GetObjNetGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetObjByNetGuid")]
	public unsafe static UObject GetObjByNetGuid(UObject WorldCtx, long GUID)
	{
		if (!GetObjByNetGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetObjByNetGuid");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjByNetGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjByNetGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetObjByNetGuid_WorldCtx_Offset), 0, GetObjByNetGuid_WorldCtx_PropertyAddress.Address, WorldCtx);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetObjByNetGuid_GUID_Offset), 0, GetObjByNetGuid_GUID_PropertyAddress.Address, GUID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjByNetGuid_FunctionAddress, intPtr, GetObjByNetGuid_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObjByNetGuid_ReturnValue_Offset), 0, GetObjByNetGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetGameDefaultMap")]
	public unsafe static string GetGameDefaultMap()
	{
		if (!GetGameDefaultMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetGameDefaultMap");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameDefaultMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameDefaultMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameDefaultMap_FunctionAddress, intPtr, GetGameDefaultMap_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGameDefaultMap_ReturnValue_Offset), 0, GetGameDefaultMap_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGameDefaultMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GetActorChannelActor")]
	public unsafe static AActor GetActorChannelActor(UActorChannel Channel)
	{
		if (!GetActorChannelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GetActorChannelActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorChannelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorChannelActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorChannel>.ToNative(IntPtr.Add(intPtr, GetActorChannelActor_Channel_Offset), 0, GetActorChannelActor_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorChannelActor_FunctionAddress, intPtr, GetActorChannelActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActorChannelActor_ReturnValue_Offset), 0, GetActorChannelActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:GEngineHandleDisconnect")]
	public unsafe static void GEngineHandleDisconnect(UWorld World)
	{
		if (!GEngineHandleDisconnect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:GEngineHandleDisconnect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEngineHandleDisconnect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEngineHandleDisconnect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GEngineHandleDisconnect_World_Offset), 0, GEngineHandleDisconnect_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEngineHandleDisconnect_FunctionAddress, intPtr, GEngineHandleDisconnect_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:ForceRemoveNetGuid")]
	public unsafe static bool ForceRemoveNetGuid(UObject Obj)
	{
		if (!ForceRemoveNetGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:ForceRemoveNetGuid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRemoveNetGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRemoveNetGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ForceRemoveNetGuid_Obj_Offset), 0, ForceRemoveNetGuid_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ForceRemoveNetGuid_FunctionAddress, intPtr, ForceRemoveNetGuid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ForceRemoveNetGuid_ReturnValue_Offset), 0, ForceRemoveNetGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:CloseServerConnection")]
	public unsafe static void CloseServerConnection(EGSNetCloseResult CloseResult, UObject WorldContext)
	{
		if (!CloseServerConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:CloseServerConnection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseServerConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseServerConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSNetCloseResult>.ToNative(IntPtr.Add(intPtr, CloseServerConnection_CloseResult_Offset), 0, CloseServerConnection_CloseResult_PropertyAddress.Address, CloseResult);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CloseServerConnection_WorldContext_Offset), 0, CloseServerConnection_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloseServerConnection_FunctionAddress, intPtr, CloseServerConnection_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:CloseClientConnection")]
	public unsafe static void CloseClientConnection(EGSNetCloseResult CloseResult, APlayerController ClientPlayerController)
	{
		if (!CloseClientConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:CloseClientConnection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseClientConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseClientConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSNetCloseResult>.ToNative(IntPtr.Add(intPtr, CloseClientConnection_CloseResult_Offset), 0, CloseClientConnection_CloseResult_PropertyAddress.Address, CloseResult);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, CloseClientConnection_ClientPlayerController_Offset), 0, CloseClientConnection_ClientPlayerController_PropertyAddress.Address, ClientPlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloseClientConnection_FunctionAddress, intPtr, CloseClientConnection_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:CloseActorChannelByActorAndPlayerController")]
	public unsafe static bool CloseActorChannelByActorAndPlayerController(AActor Actor, APlayerController PlayerController, int CloseReason)
	{
		if (!CloseActorChannelByActorAndPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:CloseActorChannelByActorAndPlayerController");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseActorChannelByActorAndPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseActorChannelByActorAndPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CloseActorChannelByActorAndPlayerController_Actor_Offset), 0, CloseActorChannelByActorAndPlayerController_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, CloseActorChannelByActorAndPlayerController_PlayerController_Offset), 0, CloseActorChannelByActorAndPlayerController_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CloseActorChannelByActorAndPlayerController_CloseReason_Offset), 0, CloseActorChannelByActorAndPlayerController_CloseReason_PropertyAddress.Address, CloseReason);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloseActorChannelByActorAndPlayerController_FunctionAddress, intPtr, CloseActorChannelByActorAndPlayerController_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CloseActorChannelByActorAndPlayerController_ReturnValue_Offset), 0, CloseActorChannelByActorAndPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:ActorChannelValid")]
	public unsafe static bool ActorChannelValid(AActor Actor, APlayerController PlayerController)
	{
		if (!ActorChannelValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:ActorChannelValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActorChannelValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorChannelValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorChannelValid_Actor_Offset), 0, ActorChannelValid_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ActorChannelValid_PlayerController_Offset), 0, ActorChannelValid_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ActorChannelValid_FunctionAddress, intPtr, ActorChannelValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ActorChannelValid_ReturnValue_Offset), 0, ActorChannelValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.GSE_OnlineFuncLib:ActorChannelOpenAcked")]
	public unsafe static bool ActorChannelOpenAcked(AActor Actor, APlayerController PlayerController)
	{
		if (!ActorChannelOpenAcked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSE_OnlineFuncLib:ActorChannelOpenAcked");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActorChannelOpenAcked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorChannelOpenAcked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorChannelOpenAcked_Actor_Offset), 0, ActorChannelOpenAcked_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ActorChannelOpenAcked_PlayerController_Offset), 0, ActorChannelOpenAcked_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ActorChannelOpenAcked_FunctionAddress, intPtr, ActorChannelOpenAcked_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ActorChannelOpenAcked_ReturnValue_Offset), 0, ActorChannelOpenAcked_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_OnlineFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_OnlineFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_OnlineFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.GSE_OnlineFuncLib");
		SlowMakeUniqueObjectName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlowMakeUniqueObjectName");
		SlowMakeUniqueObjectName_ParamsSize = NativeReflection.GetFunctionParamsSize(SlowMakeUniqueObjectName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlowMakeUniqueObjectName_Parent_PropertyAddress, SlowMakeUniqueObjectName_FunctionAddress, "Parent");
		SlowMakeUniqueObjectName_Parent_Offset = NativeReflectionCached.GetPropertyOffset(SlowMakeUniqueObjectName_FunctionAddress, "Parent");
		SlowMakeUniqueObjectName_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(SlowMakeUniqueObjectName_FunctionAddress, "Parent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlowMakeUniqueObjectName_Class_PropertyAddress, SlowMakeUniqueObjectName_FunctionAddress, "Class");
		SlowMakeUniqueObjectName_Class_Offset = NativeReflectionCached.GetPropertyOffset(SlowMakeUniqueObjectName_FunctionAddress, "Class");
		SlowMakeUniqueObjectName_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(SlowMakeUniqueObjectName_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SlowMakeUniqueObjectName_InBaseName_PropertyAddress, SlowMakeUniqueObjectName_FunctionAddress, "InBaseName");
		SlowMakeUniqueObjectName_InBaseName_Offset = NativeReflectionCached.GetPropertyOffset(SlowMakeUniqueObjectName_FunctionAddress, "InBaseName");
		SlowMakeUniqueObjectName_InBaseName_IsValid = NativeReflectionCached.ValidatePropertyClass(SlowMakeUniqueObjectName_FunctionAddress, "InBaseName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SlowMakeUniqueObjectName_ReturnValue_PropertyAddress, SlowMakeUniqueObjectName_FunctionAddress, "ReturnValue");
		SlowMakeUniqueObjectName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlowMakeUniqueObjectName_FunctionAddress, "ReturnValue");
		SlowMakeUniqueObjectName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlowMakeUniqueObjectName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		SlowMakeUniqueObjectName_IsValid = SlowMakeUniqueObjectName_FunctionAddress != IntPtr.Zero && SlowMakeUniqueObjectName_Parent_IsValid && SlowMakeUniqueObjectName_Class_IsValid && SlowMakeUniqueObjectName_InBaseName_IsValid && SlowMakeUniqueObjectName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:SlowMakeUniqueObjectName", SlowMakeUniqueObjectName_IsValid);
		SetGameDefaultMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGameDefaultMap");
		SetGameDefaultMap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGameDefaultMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGameDefaultMap_NewMap_PropertyAddress, SetGameDefaultMap_FunctionAddress, "NewMap");
		SetGameDefaultMap_NewMap_Offset = NativeReflectionCached.GetPropertyOffset(SetGameDefaultMap_FunctionAddress, "NewMap");
		SetGameDefaultMap_NewMap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameDefaultMap_FunctionAddress, "NewMap", Classes.FStrProperty);
		SetGameDefaultMap_IsValid = SetGameDefaultMap_FunctionAddress != IntPtr.Zero && SetGameDefaultMap_NewMap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:SetGameDefaultMap", SetGameDefaultMap_IsValid);
		ServerReplicateOneActorToPlayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ServerReplicateOneActorToPlayer");
		ServerReplicateOneActorToPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(ServerReplicateOneActorToPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ServerReplicateOneActorToPlayer_Actor_PropertyAddress, ServerReplicateOneActorToPlayer_FunctionAddress, "Actor");
		ServerReplicateOneActorToPlayer_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ServerReplicateOneActorToPlayer_FunctionAddress, "Actor");
		ServerReplicateOneActorToPlayer_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ServerReplicateOneActorToPlayer_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ServerReplicateOneActorToPlayer_PlayerController_PropertyAddress, ServerReplicateOneActorToPlayer_FunctionAddress, "PlayerController");
		ServerReplicateOneActorToPlayer_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ServerReplicateOneActorToPlayer_FunctionAddress, "PlayerController");
		ServerReplicateOneActorToPlayer_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ServerReplicateOneActorToPlayer_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ServerReplicateOneActorToPlayer_ReturnValue_PropertyAddress, ServerReplicateOneActorToPlayer_FunctionAddress, "ReturnValue");
		ServerReplicateOneActorToPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ServerReplicateOneActorToPlayer_FunctionAddress, "ReturnValue");
		ServerReplicateOneActorToPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ServerReplicateOneActorToPlayer_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		ServerReplicateOneActorToPlayer_IsValid = ServerReplicateOneActorToPlayer_FunctionAddress != IntPtr.Zero && ServerReplicateOneActorToPlayer_Actor_IsValid && ServerReplicateOneActorToPlayer_PlayerController_IsValid && ServerReplicateOneActorToPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:ServerReplicateOneActorToPlayer", ServerReplicateOneActorToPlayer_IsValid);
		ResetNetGuidAckStat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetNetGuidAckStat");
		ResetNetGuidAckStat_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetNetGuidAckStat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetNetGuidAckStat_Guid_PropertyAddress, ResetNetGuidAckStat_FunctionAddress, "Guid");
		ResetNetGuidAckStat_Guid_Offset = NativeReflectionCached.GetPropertyOffset(ResetNetGuidAckStat_FunctionAddress, "Guid");
		ResetNetGuidAckStat_Guid_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetNetGuidAckStat_FunctionAddress, "Guid", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref ResetNetGuidAckStat_NetConnection_PropertyAddress, ResetNetGuidAckStat_FunctionAddress, "NetConnection");
		ResetNetGuidAckStat_NetConnection_Offset = NativeReflectionCached.GetPropertyOffset(ResetNetGuidAckStat_FunctionAddress, "NetConnection");
		ResetNetGuidAckStat_NetConnection_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetNetGuidAckStat_FunctionAddress, "NetConnection", Classes.FObjectProperty);
		ResetNetGuidAckStat_IsValid = ResetNetGuidAckStat_FunctionAddress != IntPtr.Zero && ResetNetGuidAckStat_Guid_IsValid && ResetNetGuidAckStat_NetConnection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:ResetNetGuidAckStat", ResetNetGuidAckStat_IsValid);
		RegisterNetGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterNetGuid");
		RegisterNetGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNetGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterNetGuid_Guid_PropertyAddress, RegisterNetGuid_FunctionAddress, "Guid");
		RegisterNetGuid_Guid_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNetGuid_FunctionAddress, "Guid");
		RegisterNetGuid_Guid_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNetGuid_FunctionAddress, "Guid", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref RegisterNetGuid_Obj_PropertyAddress, RegisterNetGuid_FunctionAddress, "Obj");
		RegisterNetGuid_Obj_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNetGuid_FunctionAddress, "Obj");
		RegisterNetGuid_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNetGuid_FunctionAddress, "Obj", Classes.FObjectProperty);
		RegisterNetGuid_IsValid = RegisterNetGuid_FunctionAddress != IntPtr.Zero && RegisterNetGuid_Guid_IsValid && RegisterNetGuid_Obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:RegisterNetGuid", RegisterNetGuid_IsValid);
		MarkActorRoleDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkActorRoleDirty");
		MarkActorRoleDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkActorRoleDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkActorRoleDirty_Actor_PropertyAddress, MarkActorRoleDirty_FunctionAddress, "Actor");
		MarkActorRoleDirty_Actor_Offset = NativeReflectionCached.GetPropertyOffset(MarkActorRoleDirty_FunctionAddress, "Actor");
		MarkActorRoleDirty_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkActorRoleDirty_FunctionAddress, "Actor", Classes.FObjectProperty);
		MarkActorRoleDirty_IsValid = MarkActorRoleDirty_FunctionAddress != IntPtr.Zero && MarkActorRoleDirty_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:MarkActorRoleDirty", MarkActorRoleDirty_IsValid);
		IsActorChannelReadyForServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsActorChannelReadyForServer");
		IsActorChannelReadyForServer_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorChannelReadyForServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorChannelReadyForServer_Actor_PropertyAddress, IsActorChannelReadyForServer_FunctionAddress, "Actor");
		IsActorChannelReadyForServer_Actor_Offset = NativeReflectionCached.GetPropertyOffset(IsActorChannelReadyForServer_FunctionAddress, "Actor");
		IsActorChannelReadyForServer_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorChannelReadyForServer_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorChannelReadyForServer_PlayerController_PropertyAddress, IsActorChannelReadyForServer_FunctionAddress, "PlayerController");
		IsActorChannelReadyForServer_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(IsActorChannelReadyForServer_FunctionAddress, "PlayerController");
		IsActorChannelReadyForServer_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorChannelReadyForServer_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorChannelReadyForServer_ReturnValue_PropertyAddress, IsActorChannelReadyForServer_FunctionAddress, "ReturnValue");
		IsActorChannelReadyForServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorChannelReadyForServer_FunctionAddress, "ReturnValue");
		IsActorChannelReadyForServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorChannelReadyForServer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorChannelReadyForServer_IsValid = IsActorChannelReadyForServer_FunctionAddress != IntPtr.Zero && IsActorChannelReadyForServer_Actor_IsValid && IsActorChannelReadyForServer_PlayerController_IsValid && IsActorChannelReadyForServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:IsActorChannelReadyForServer", IsActorChannelReadyForServer_IsValid);
		IsActorChannelReadyForClient_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsActorChannelReadyForClient");
		IsActorChannelReadyForClient_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorChannelReadyForClient_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorChannelReadyForClient_Actor_PropertyAddress, IsActorChannelReadyForClient_FunctionAddress, "Actor");
		IsActorChannelReadyForClient_Actor_Offset = NativeReflectionCached.GetPropertyOffset(IsActorChannelReadyForClient_FunctionAddress, "Actor");
		IsActorChannelReadyForClient_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorChannelReadyForClient_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorChannelReadyForClient_ReturnValue_PropertyAddress, IsActorChannelReadyForClient_FunctionAddress, "ReturnValue");
		IsActorChannelReadyForClient_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorChannelReadyForClient_FunctionAddress, "ReturnValue");
		IsActorChannelReadyForClient_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorChannelReadyForClient_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorChannelReadyForClient_IsValid = IsActorChannelReadyForClient_FunctionAddress != IntPtr.Zero && IsActorChannelReadyForClient_Actor_IsValid && IsActorChannelReadyForClient_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:IsActorChannelReadyForClient", IsActorChannelReadyForClient_IsValid);
		InServerReal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InServerReal");
		InServerReal_ParamsSize = NativeReflection.GetFunctionParamsSize(InServerReal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InServerReal_WorldCtx_PropertyAddress, InServerReal_FunctionAddress, "WorldCtx");
		InServerReal_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(InServerReal_FunctionAddress, "WorldCtx");
		InServerReal_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(InServerReal_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InServerReal_ReturnValue_PropertyAddress, InServerReal_FunctionAddress, "ReturnValue");
		InServerReal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InServerReal_FunctionAddress, "ReturnValue");
		InServerReal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InServerReal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InServerReal_IsValid = InServerReal_FunctionAddress != IntPtr.Zero && InServerReal_WorldCtx_IsValid && InServerReal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:InServerReal", InServerReal_IsValid);
		GetUniqueNetIdStringByPlayerState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUniqueNetIdStringByPlayerState");
		GetUniqueNetIdStringByPlayerState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueNetIdStringByPlayerState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueNetIdStringByPlayerState_PlayerState_PropertyAddress, GetUniqueNetIdStringByPlayerState_FunctionAddress, "PlayerState");
		GetUniqueNetIdStringByPlayerState_PlayerState_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueNetIdStringByPlayerState_FunctionAddress, "PlayerState");
		GetUniqueNetIdStringByPlayerState_PlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueNetIdStringByPlayerState_FunctionAddress, "PlayerState", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueNetIdStringByPlayerState_ReturnValue_PropertyAddress, GetUniqueNetIdStringByPlayerState_FunctionAddress, "ReturnValue");
		GetUniqueNetIdStringByPlayerState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueNetIdStringByPlayerState_FunctionAddress, "ReturnValue");
		GetUniqueNetIdStringByPlayerState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueNetIdStringByPlayerState_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUniqueNetIdStringByPlayerState_IsValid = GetUniqueNetIdStringByPlayerState_FunctionAddress != IntPtr.Zero && GetUniqueNetIdStringByPlayerState_PlayerState_IsValid && GetUniqueNetIdStringByPlayerState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByPlayerState", GetUniqueNetIdStringByPlayerState_IsValid);
		GetUniqueNetIdStringByPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUniqueNetIdStringByPlayerController");
		GetUniqueNetIdStringByPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueNetIdStringByPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueNetIdStringByPlayerController_Controller_PropertyAddress, GetUniqueNetIdStringByPlayerController_FunctionAddress, "Controller");
		GetUniqueNetIdStringByPlayerController_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueNetIdStringByPlayerController_FunctionAddress, "Controller");
		GetUniqueNetIdStringByPlayerController_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueNetIdStringByPlayerController_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueNetIdStringByPlayerController_ReturnValue_PropertyAddress, GetUniqueNetIdStringByPlayerController_FunctionAddress, "ReturnValue");
		GetUniqueNetIdStringByPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueNetIdStringByPlayerController_FunctionAddress, "ReturnValue");
		GetUniqueNetIdStringByPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueNetIdStringByPlayerController_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUniqueNetIdStringByPlayerController_IsValid = GetUniqueNetIdStringByPlayerController_FunctionAddress != IntPtr.Zero && GetUniqueNetIdStringByPlayerController_Controller_IsValid && GetUniqueNetIdStringByPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByPlayerController", GetUniqueNetIdStringByPlayerController_IsValid);
		GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUniqueNetIdStringByFUniqueNetIdRepl");
		GetUniqueNetIdStringByFUniqueNetIdRepl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_PropertyAddress, GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, "UniqueId");
		GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, "UniqueId");
		GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, "UniqueId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_PropertyAddress, GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, "ReturnValue");
		GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, "ReturnValue");
		GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUniqueNetIdStringByFUniqueNetIdRepl_IsValid = GetUniqueNetIdStringByFUniqueNetIdRepl_FunctionAddress != IntPtr.Zero && GetUniqueNetIdStringByFUniqueNetIdRepl_UniqueId_IsValid && GetUniqueNetIdStringByFUniqueNetIdRepl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetUniqueNetIdStringByFUniqueNetIdRepl", GetUniqueNetIdStringByFUniqueNetIdRepl_IsValid);
		GetReplicationGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReplicationGraph");
		GetReplicationGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReplicationGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReplicationGraph_WorldCtx_PropertyAddress, GetReplicationGraph_FunctionAddress, "WorldCtx");
		GetReplicationGraph_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(GetReplicationGraph_FunctionAddress, "WorldCtx");
		GetReplicationGraph_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReplicationGraph_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReplicationGraph_ReturnValue_PropertyAddress, GetReplicationGraph_FunctionAddress, "ReturnValue");
		GetReplicationGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReplicationGraph_FunctionAddress, "ReturnValue");
		GetReplicationGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReplicationGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReplicationGraph_IsValid = GetReplicationGraph_FunctionAddress != IntPtr.Zero && GetReplicationGraph_WorldCtx_IsValid && GetReplicationGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetReplicationGraph", GetReplicationGraph_IsValid);
		GetObjNetGuidByChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjNetGuidByChannel");
		GetObjNetGuidByChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjNetGuidByChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjNetGuidByChannel_Channel_PropertyAddress, GetObjNetGuidByChannel_FunctionAddress, "Channel");
		GetObjNetGuidByChannel_Channel_Offset = NativeReflectionCached.GetPropertyOffset(GetObjNetGuidByChannel_FunctionAddress, "Channel");
		GetObjNetGuidByChannel_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjNetGuidByChannel_FunctionAddress, "Channel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjNetGuidByChannel_ReturnValue_PropertyAddress, GetObjNetGuidByChannel_FunctionAddress, "ReturnValue");
		GetObjNetGuidByChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjNetGuidByChannel_FunctionAddress, "ReturnValue");
		GetObjNetGuidByChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjNetGuidByChannel_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetObjNetGuidByChannel_IsValid = GetObjNetGuidByChannel_FunctionAddress != IntPtr.Zero && GetObjNetGuidByChannel_Channel_IsValid && GetObjNetGuidByChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetObjNetGuidByChannel", GetObjNetGuidByChannel_IsValid);
		GetObjNetGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjNetGuid");
		GetObjNetGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjNetGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjNetGuid_Obj_PropertyAddress, GetObjNetGuid_FunctionAddress, "Obj");
		GetObjNetGuid_Obj_Offset = NativeReflectionCached.GetPropertyOffset(GetObjNetGuid_FunctionAddress, "Obj");
		GetObjNetGuid_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjNetGuid_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjNetGuid_ReturnValue_PropertyAddress, GetObjNetGuid_FunctionAddress, "ReturnValue");
		GetObjNetGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjNetGuid_FunctionAddress, "ReturnValue");
		GetObjNetGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjNetGuid_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetObjNetGuid_IsValid = GetObjNetGuid_FunctionAddress != IntPtr.Zero && GetObjNetGuid_Obj_IsValid && GetObjNetGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetObjNetGuid", GetObjNetGuid_IsValid);
		GetObjByNetGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjByNetGuid");
		GetObjByNetGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjByNetGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjByNetGuid_WorldCtx_PropertyAddress, GetObjByNetGuid_FunctionAddress, "WorldCtx");
		GetObjByNetGuid_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(GetObjByNetGuid_FunctionAddress, "WorldCtx");
		GetObjByNetGuid_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjByNetGuid_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjByNetGuid_GUID_PropertyAddress, GetObjByNetGuid_FunctionAddress, "GUID");
		GetObjByNetGuid_GUID_Offset = NativeReflectionCached.GetPropertyOffset(GetObjByNetGuid_FunctionAddress, "GUID");
		GetObjByNetGuid_GUID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjByNetGuid_FunctionAddress, "GUID", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetObjByNetGuid_ReturnValue_PropertyAddress, GetObjByNetGuid_FunctionAddress, "ReturnValue");
		GetObjByNetGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjByNetGuid_FunctionAddress, "ReturnValue");
		GetObjByNetGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjByNetGuid_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetObjByNetGuid_IsValid = GetObjByNetGuid_FunctionAddress != IntPtr.Zero && GetObjByNetGuid_WorldCtx_IsValid && GetObjByNetGuid_GUID_IsValid && GetObjByNetGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetObjByNetGuid", GetObjByNetGuid_IsValid);
		GetGameDefaultMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameDefaultMap");
		GetGameDefaultMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameDefaultMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameDefaultMap_ReturnValue_PropertyAddress, GetGameDefaultMap_FunctionAddress, "ReturnValue");
		GetGameDefaultMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameDefaultMap_FunctionAddress, "ReturnValue");
		GetGameDefaultMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameDefaultMap_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGameDefaultMap_IsValid = GetGameDefaultMap_FunctionAddress != IntPtr.Zero && GetGameDefaultMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetGameDefaultMap", GetGameDefaultMap_IsValid);
		GetActorChannelActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorChannelActor");
		GetActorChannelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorChannelActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorChannelActor_Channel_PropertyAddress, GetActorChannelActor_FunctionAddress, "Channel");
		GetActorChannelActor_Channel_Offset = NativeReflectionCached.GetPropertyOffset(GetActorChannelActor_FunctionAddress, "Channel");
		GetActorChannelActor_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorChannelActor_FunctionAddress, "Channel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorChannelActor_ReturnValue_PropertyAddress, GetActorChannelActor_FunctionAddress, "ReturnValue");
		GetActorChannelActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorChannelActor_FunctionAddress, "ReturnValue");
		GetActorChannelActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorChannelActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorChannelActor_IsValid = GetActorChannelActor_FunctionAddress != IntPtr.Zero && GetActorChannelActor_Channel_IsValid && GetActorChannelActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GetActorChannelActor", GetActorChannelActor_IsValid);
		GEngineHandleDisconnect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEngineHandleDisconnect");
		GEngineHandleDisconnect_ParamsSize = NativeReflection.GetFunctionParamsSize(GEngineHandleDisconnect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEngineHandleDisconnect_World_PropertyAddress, GEngineHandleDisconnect_FunctionAddress, "World");
		GEngineHandleDisconnect_World_Offset = NativeReflectionCached.GetPropertyOffset(GEngineHandleDisconnect_FunctionAddress, "World");
		GEngineHandleDisconnect_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GEngineHandleDisconnect_FunctionAddress, "World", Classes.FObjectProperty);
		GEngineHandleDisconnect_IsValid = GEngineHandleDisconnect_FunctionAddress != IntPtr.Zero && GEngineHandleDisconnect_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:GEngineHandleDisconnect", GEngineHandleDisconnect_IsValid);
		ForceRemoveNetGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceRemoveNetGuid");
		ForceRemoveNetGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRemoveNetGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceRemoveNetGuid_Obj_PropertyAddress, ForceRemoveNetGuid_FunctionAddress, "Obj");
		ForceRemoveNetGuid_Obj_Offset = NativeReflectionCached.GetPropertyOffset(ForceRemoveNetGuid_FunctionAddress, "Obj");
		ForceRemoveNetGuid_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceRemoveNetGuid_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceRemoveNetGuid_ReturnValue_PropertyAddress, ForceRemoveNetGuid_FunctionAddress, "ReturnValue");
		ForceRemoveNetGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ForceRemoveNetGuid_FunctionAddress, "ReturnValue");
		ForceRemoveNetGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceRemoveNetGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ForceRemoveNetGuid_IsValid = ForceRemoveNetGuid_FunctionAddress != IntPtr.Zero && ForceRemoveNetGuid_Obj_IsValid && ForceRemoveNetGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:ForceRemoveNetGuid", ForceRemoveNetGuid_IsValid);
		CloseServerConnection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloseServerConnection");
		CloseServerConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseServerConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseServerConnection_CloseResult_PropertyAddress, CloseServerConnection_FunctionAddress, "CloseResult");
		CloseServerConnection_CloseResult_Offset = NativeReflectionCached.GetPropertyOffset(CloseServerConnection_FunctionAddress, "CloseResult");
		CloseServerConnection_CloseResult_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseServerConnection_FunctionAddress, "CloseResult", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseServerConnection_WorldContext_PropertyAddress, CloseServerConnection_FunctionAddress, "WorldContext");
		CloseServerConnection_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CloseServerConnection_FunctionAddress, "WorldContext");
		CloseServerConnection_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseServerConnection_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		CloseServerConnection_IsValid = CloseServerConnection_FunctionAddress != IntPtr.Zero && CloseServerConnection_CloseResult_IsValid && CloseServerConnection_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:CloseServerConnection", CloseServerConnection_IsValid);
		CloseClientConnection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloseClientConnection");
		CloseClientConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseClientConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseClientConnection_CloseResult_PropertyAddress, CloseClientConnection_FunctionAddress, "CloseResult");
		CloseClientConnection_CloseResult_Offset = NativeReflectionCached.GetPropertyOffset(CloseClientConnection_FunctionAddress, "CloseResult");
		CloseClientConnection_CloseResult_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseClientConnection_FunctionAddress, "CloseResult", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseClientConnection_ClientPlayerController_PropertyAddress, CloseClientConnection_FunctionAddress, "ClientPlayerController");
		CloseClientConnection_ClientPlayerController_Offset = NativeReflectionCached.GetPropertyOffset(CloseClientConnection_FunctionAddress, "ClientPlayerController");
		CloseClientConnection_ClientPlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseClientConnection_FunctionAddress, "ClientPlayerController", Classes.FObjectProperty);
		CloseClientConnection_IsValid = CloseClientConnection_FunctionAddress != IntPtr.Zero && CloseClientConnection_CloseResult_IsValid && CloseClientConnection_ClientPlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:CloseClientConnection", CloseClientConnection_IsValid);
		CloseActorChannelByActorAndPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloseActorChannelByActorAndPlayerController");
		CloseActorChannelByActorAndPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseActorChannelByActorAndPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseActorChannelByActorAndPlayerController_Actor_PropertyAddress, CloseActorChannelByActorAndPlayerController_FunctionAddress, "Actor");
		CloseActorChannelByActorAndPlayerController_Actor_Offset = NativeReflectionCached.GetPropertyOffset(CloseActorChannelByActorAndPlayerController_FunctionAddress, "Actor");
		CloseActorChannelByActorAndPlayerController_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseActorChannelByActorAndPlayerController_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseActorChannelByActorAndPlayerController_PlayerController_PropertyAddress, CloseActorChannelByActorAndPlayerController_FunctionAddress, "PlayerController");
		CloseActorChannelByActorAndPlayerController_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(CloseActorChannelByActorAndPlayerController_FunctionAddress, "PlayerController");
		CloseActorChannelByActorAndPlayerController_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseActorChannelByActorAndPlayerController_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseActorChannelByActorAndPlayerController_CloseReason_PropertyAddress, CloseActorChannelByActorAndPlayerController_FunctionAddress, "CloseReason");
		CloseActorChannelByActorAndPlayerController_CloseReason_Offset = NativeReflectionCached.GetPropertyOffset(CloseActorChannelByActorAndPlayerController_FunctionAddress, "CloseReason");
		CloseActorChannelByActorAndPlayerController_CloseReason_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseActorChannelByActorAndPlayerController_FunctionAddress, "CloseReason", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseActorChannelByActorAndPlayerController_ReturnValue_PropertyAddress, CloseActorChannelByActorAndPlayerController_FunctionAddress, "ReturnValue");
		CloseActorChannelByActorAndPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloseActorChannelByActorAndPlayerController_FunctionAddress, "ReturnValue");
		CloseActorChannelByActorAndPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseActorChannelByActorAndPlayerController_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CloseActorChannelByActorAndPlayerController_IsValid = CloseActorChannelByActorAndPlayerController_FunctionAddress != IntPtr.Zero && CloseActorChannelByActorAndPlayerController_Actor_IsValid && CloseActorChannelByActorAndPlayerController_PlayerController_IsValid && CloseActorChannelByActorAndPlayerController_CloseReason_IsValid && CloseActorChannelByActorAndPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:CloseActorChannelByActorAndPlayerController", CloseActorChannelByActorAndPlayerController_IsValid);
		ActorChannelValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ActorChannelValid");
		ActorChannelValid_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorChannelValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorChannelValid_Actor_PropertyAddress, ActorChannelValid_FunctionAddress, "Actor");
		ActorChannelValid_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ActorChannelValid_FunctionAddress, "Actor");
		ActorChannelValid_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorChannelValid_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorChannelValid_PlayerController_PropertyAddress, ActorChannelValid_FunctionAddress, "PlayerController");
		ActorChannelValid_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ActorChannelValid_FunctionAddress, "PlayerController");
		ActorChannelValid_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorChannelValid_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorChannelValid_ReturnValue_PropertyAddress, ActorChannelValid_FunctionAddress, "ReturnValue");
		ActorChannelValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ActorChannelValid_FunctionAddress, "ReturnValue");
		ActorChannelValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorChannelValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ActorChannelValid_IsValid = ActorChannelValid_FunctionAddress != IntPtr.Zero && ActorChannelValid_Actor_IsValid && ActorChannelValid_PlayerController_IsValid && ActorChannelValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:ActorChannelValid", ActorChannelValid_IsValid);
		ActorChannelOpenAcked_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ActorChannelOpenAcked");
		ActorChannelOpenAcked_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorChannelOpenAcked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorChannelOpenAcked_Actor_PropertyAddress, ActorChannelOpenAcked_FunctionAddress, "Actor");
		ActorChannelOpenAcked_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ActorChannelOpenAcked_FunctionAddress, "Actor");
		ActorChannelOpenAcked_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorChannelOpenAcked_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorChannelOpenAcked_PlayerController_PropertyAddress, ActorChannelOpenAcked_FunctionAddress, "PlayerController");
		ActorChannelOpenAcked_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ActorChannelOpenAcked_FunctionAddress, "PlayerController");
		ActorChannelOpenAcked_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorChannelOpenAcked_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorChannelOpenAcked_ReturnValue_PropertyAddress, ActorChannelOpenAcked_FunctionAddress, "ReturnValue");
		ActorChannelOpenAcked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ActorChannelOpenAcked_FunctionAddress, "ReturnValue");
		ActorChannelOpenAcked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorChannelOpenAcked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ActorChannelOpenAcked_IsValid = ActorChannelOpenAcked_FunctionAddress != IntPtr.Zero && ActorChannelOpenAcked_Actor_IsValid && ActorChannelOpenAcked_PlayerController_IsValid && ActorChannelOpenAcked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSE_OnlineFuncLib:ActorChannelOpenAcked", ActorChannelOpenAcked_IsValid);
	}
}
