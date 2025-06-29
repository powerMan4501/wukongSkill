using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS")]
public abstract class BGP_PlayerControllerCS : ABGPPlayerController, IGSRpcController, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private Action<List<byte>> OnReceiveRpcMessageHandler;

	private static bool DataComp_IsValid;

	private static int DataComp_Offset;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool EventCollection_IsValid;

	private static int EventCollection_Offset;

	private static bool GSRpcSendServer_IsValid;

	private static IntPtr GSRpcSendServer_FunctionAddress;

	private static int GSRpcSendServer_ParamsSize;

	private static bool GSRpcSendServer_SendData_IsValid;

	private static int GSRpcSendServer_SendData_Offset;

	private static FFieldAddress GSRpcSendServer_SendData_PropertyAddress;

	private static bool GSRpcSendClient_IsValid;

	private static IntPtr GSRpcSendClient_FunctionAddress;

	private static int GSRpcSendClient_ParamsSize;

	private static bool GSRpcSendClient_SendData_IsValid;

	private static int GSRpcSendClient_SendData_Offset;

	private static FFieldAddress GSRpcSendClient_SendData_PropertyAddress;

	private static bool OnControlledPawnChange_IsValid;

	private static IntPtr OnControlledPawnChange_FunctionAddress;

	private static int OnControlledPawnChange_ParamsSize;

	private static bool OnControlledPawnChange_OldPawn_IsValid;

	private static int OnControlledPawnChange_OldPawn_Offset;

	private static bool OnControlledPawnChange_NewPawn_IsValid;

	private static int OnControlledPawnChange_NewPawn_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ConsoleCommandCS_IsValid;

	private static IntPtr ConsoleCommandCS_FunctionAddress;

	private static int ConsoleCommandCS_ParamsSize;

	private static bool ConsoleCommandCS_Command_IsValid;

	private static int ConsoleCommandCS_Command_Offset;

	private static FFieldAddress ConsoleCommandCS_Command_PropertyAddress;

	private static bool InitInputSystemCS_IsValid;

	private static IntPtr InitInputSystemCS_FunctionAddress;

	private static int InitInputSystemCS_ParamsSize;

	private static bool OnRep_PlayerStateCS_IsValid;

	private static IntPtr OnRep_PlayerStateCS_FunctionAddress;

	private static int OnRep_PlayerStateCS_ParamsSize;

	private static bool GetPlayerViewPointCS_IsValid;

	private static IntPtr GetPlayerViewPointCS_FunctionAddress;

	private static int GetPlayerViewPointCS_ParamsSize;

	private static bool GetPlayerViewPointCS_out_Location_IsValid;

	private static int GetPlayerViewPointCS_out_Location_Offset;

	private static FFieldAddress GetPlayerViewPointCS_out_Location_PropertyAddress;

	private static bool GetPlayerViewPointCS_out_Rotation_IsValid;

	private static int GetPlayerViewPointCS_out_Rotation_Offset;

	private static FFieldAddress GetPlayerViewPointCS_out_Rotation_PropertyAddress;

	private static bool GetPlayerViewPointCS_ReturnValue_IsValid;

	private static int GetPlayerViewPointCS_ReturnValue_Offset;

	private static FFieldAddress GetPlayerViewPointCS_ReturnValue_PropertyAddress;

	private static bool GetSeamlessTravelActorListCS_IsValid;

	private static IntPtr GetSeamlessTravelActorListCS_FunctionAddress;

	private static int GetSeamlessTravelActorListCS_ParamsSize;

	private static bool GetSeamlessTravelActorListCS_bToEntry_IsValid;

	private static int GetSeamlessTravelActorListCS_bToEntry_Offset;

	private static FFieldAddress GetSeamlessTravelActorListCS_bToEntry_PropertyAddress;

	private static bool GetSeamlessTravelActorListCS_ActorList_IsValid;

	private static int GetSeamlessTravelActorListCS_ActorList_Offset;

	private static FFieldAddress GetSeamlessTravelActorListCS_ActorList_PropertyAddress;

	public Entity ECSEntity
	{
		get
		{
			return mECSEntity;
		}
		set
		{
			mECSEntity = value;
		}
	}

	public Chunk ECSChunk
	{
		get
		{
			return mECSChunk;
		}
		set
		{
			mECSChunk = value;
		}
	}

	public int ECSIndexInChunk
	{
		get
		{
			return mECSIndexInChunk;
		}
		set
		{
			mECSIndexInChunk = value;
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:DataComp")]
	public UActorDataContainer DataComp
	{
		get
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:DataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, DataComp_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:DataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, DataComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:EventCollection")]
	protected BPS_GSEventCollection EventCollection
	{
		get
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:EventCollection");
				return null;
			}
			return UObjectMarshaler<BPS_GSEventCollection>.FromNative(IntPtr.Add(base.Address, EventCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:EventCollection");
			}
			else
			{
				UObjectMarshaler<BPS_GSEventCollection>.ToNative(IntPtr.Add(base.Address, EventCollection_Offset), value);
			}
		}
	}

	public int ECSArcheType => 3;

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:GetSeamlessTravelActorListCS")]
	protected override void GetSeamlessTravelActorListCS_Implementation(bool bToEntry, out List<AActor> ActorList)
	{
		base.GetSeamlessTravelActorListCS_Implementation(bToEntry, out ActorList);
	}

	public sealed override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		CreateDataContainer(initializer);
		base.PlayerCameraManagerClass = UClass.GetClass<BGP_PlayerCameraManagerCS>();
	}

	public Entity GetECSEntity()
	{
		return ECSEntity;
	}

	protected abstract void CreateDataContainer(FObjectInitializer initializer);

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:OnRep_PlayerStateCS")]
	protected override void OnRep_PlayerStateCS_Implementation()
	{
		base.OnRep_PlayerStateCS_Implementation();
		BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(this);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.OnPossessedPawnChanged.Bind(OnControlledPawnChange);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		base.OnPossessedPawnChanged.Unbind(OnControlledPawnChange);
		BGW_EventCollection.Get(this).Evt_PostPlayerInputDispose();
	}

	public object GetEventCollection()
	{
		if (EventCollection == null)
		{
			EventCollection = (base.PlayerState as BGP_PlayerStateCS)?.PlayerEventCollection;
		}
		return EventCollection;
	}

	public virtual void InitAllComp()
	{
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:GetPlayerViewPointCS")]
	protected override bool GetPlayerViewPointCS_Implementation(out FVector out_Location, out FRotator out_Rotation)
	{
		BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(GetControlledPawn());
		if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Teleporting))
		{
			out_Location = GetControlledPawn().GetActorLocation();
			out_Rotation = GetControlledPawn().GetActorRotation();
			return true;
		}
		out_Location = FVector.ZeroVector;
		out_Rotation = FRotator.ZeroRotator;
		return false;
	}

	public void AfterInitAllComp()
	{
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:InitInputSystemCS")]
	protected override void InitInputSystemCS_Implementation()
	{
		BGW_EventCollection.Get(this).Evt_PostInitPlayerInputFinish(this);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:ConsoleCommandCS")]
	protected override void ConsoleCommandCS_Implementation(string Command)
	{
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	public void RegisterRpcMessageHandler(Action<List<byte>> RpcMessageHandler)
	{
		OnReceiveRpcMessageHandler = RpcMessageHandler;
	}

	public void UnRegisterRpcMessageHandler()
	{
		OnReceiveRpcMessageHandler = null;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendServer")]
	public unsafe void GSRpcSendServer(List<byte> SendData)
	{
		CheckDestroyed();
		if (!GSRpcSendServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendServer");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)GSRpcSendServer_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, GSRpcSendServer_ParamsSize);
		TArrayCopyMarshaler<byte> tArrayCopyMarshaler = new TArrayCopyMarshaler<byte>(1, GSRpcSendServer_SendData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, GSRpcSendServer_SendData_Offset), SendData);
		NativeReflection.InvokeFunction(base.Address, GSRpcSendServer_FunctionAddress, intPtr, GSRpcSendServer_ParamsSize);
		SendData = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, GSRpcSendServer_SendData_Offset));
		NativeReflection.DestroyValue_InContainer(GSRpcSendServer_SendData_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void GSRpcSendServer_Implementation(List<byte> RecvData)
	{
		OnReceiveRpcMessageHandler?.Invoke(RecvData);
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Client, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendClient")]
	public unsafe void GSRpcSendClient(List<byte> SendData)
	{
		CheckDestroyed();
		if (!GSRpcSendClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendClient");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)GSRpcSendClient_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, GSRpcSendClient_ParamsSize);
		TArrayCopyMarshaler<byte> tArrayCopyMarshaler = new TArrayCopyMarshaler<byte>(1, GSRpcSendClient_SendData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, GSRpcSendClient_SendData_Offset), SendData);
		NativeReflection.InvokeFunction(base.Address, GSRpcSendClient_FunctionAddress, intPtr, GSRpcSendClient_ParamsSize);
		SendData = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, GSRpcSendClient_SendData_Offset));
		NativeReflection.DestroyValue_InContainer(GSRpcSendClient_SendData_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void GSRpcSendClient_Implementation(List<byte> RecvData)
	{
		OnReceiveRpcMessageHandler?.Invoke(RecvData);
	}

	public APlayerState GetPlayerState()
	{
		return base.PlayerState;
	}

	public string GetUniqueNetIdStr()
	{
		return UGSE_OnlineFuncLib.GetUniqueNetIdStringByPlayerController(this);
	}

	public BPC_PlayerRoleData GetReadOnlyDataTodoRemove()
	{
		return BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(this);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerCS:OnControlledPawnChange")]
	public virtual void OnControlledPawnChange(AActor OldPawn, AActor NewPawn)
	{
		GetEventCollection();
		if (EventCollection != null)
		{
			EventCollection.Evt_OnControlledPawnChange_Local.Invoke(OldPawn, NewPawn);
		}
	}

	bool IGSRpcController.HasAuthority()
	{
		return HasAuthority();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendServer")]
	private static void GSRpcSendServer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		List<byte> recvData = new TArrayCopyMarshaler<byte>(1, GSRpcSendServer_SendData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, GSRpcSendServer_SendData_Offset));
		bGP_PlayerControllerCS.GSRpcSendServer_Implementation(recvData);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendClient")]
	private static void GSRpcSendClient__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		List<byte> recvData = new TArrayCopyMarshaler<byte>(1, GSRpcSendClient_SendData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, GSRpcSendClient_SendData_Offset));
		bGP_PlayerControllerCS.GSRpcSendClient_Implementation(recvData);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:OnControlledPawnChange")]
	private static void OnControlledPawnChange__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		AActor oldPawn = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnControlledPawnChange_OldPawn_Offset));
		AActor newPawn = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnControlledPawnChange_NewPawn_Offset));
		bGP_PlayerControllerCS.OnControlledPawnChange(oldPawn, newPawn);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		bGP_PlayerControllerCS.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGP_PlayerControllerCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:ConsoleCommandCS")]
	private static void ConsoleCommandCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		string command = FStringMarshaler.FromNative(IntPtr.Add(buffer, ConsoleCommandCS_Command_Offset));
		bGP_PlayerControllerCS.ConsoleCommandCS_Implementation(command);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:InitInputSystemCS")]
	private static void InitInputSystemCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		bGP_PlayerControllerCS.InitInputSystemCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:OnRep_PlayerStateCS")]
	private static void OnRep_PlayerStateCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		bGP_PlayerControllerCS.OnRep_PlayerStateCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:GetPlayerViewPointCS")]
	private static void GetPlayerViewPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		FVector out_Location;
		FRotator out_Rotation;
		bool playerViewPointCS_Implementation = bGP_PlayerControllerCS.GetPlayerViewPointCS_Implementation(out out_Location, out out_Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetPlayerViewPointCS_ReturnValue_Offset), 0, GetPlayerViewPointCS_ReturnValue_PropertyAddress.Address, playerViewPointCS_Implementation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, GetPlayerViewPointCS_out_Location_Offset), out_Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(buffer, GetPlayerViewPointCS_out_Rotation_Offset), out_Rotation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerCS:GetSeamlessTravelActorListCS")]
	private static void GetSeamlessTravelActorListCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GCHelper.Find<BGP_PlayerControllerCS>(obj);
		bool bToEntry = BoolMarshaler.FromNative(IntPtr.Add(buffer, GetSeamlessTravelActorListCS_bToEntry_Offset), 0, GetSeamlessTravelActorListCS_bToEntry_PropertyAddress.Address);
		TArrayCopyMarshaler<AActor> tArrayCopyMarshaler = new TArrayCopyMarshaler<AActor>(1, GetSeamlessTravelActorListCS_ActorList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
		List<AActor> ActorList = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetSeamlessTravelActorListCS_ActorList_Offset));
		bGP_PlayerControllerCS.GetSeamlessTravelActorListCS_Implementation(bToEntry, out ActorList);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSeamlessTravelActorListCS_ActorList_Offset), ActorList);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGP_PlayerControllerCS");
		DataComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataComp");
		DataComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataComp", Classes.FObjectProperty);
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		EventCollection_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventCollection");
		EventCollection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventCollection", Classes.FObjectProperty);
		GSRpcSendServer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSRpcSendServer");
		GSRpcSendServer_ParamsSize = NativeReflection.GetFunctionParamsSize(GSRpcSendServer_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSRpcSendServer_SendData_PropertyAddress, GSRpcSendServer_FunctionAddress, "SendData");
		GSRpcSendServer_SendData_Offset = NativeReflection.GetPropertyOffset(GSRpcSendServer_FunctionAddress, "SendData");
		GSRpcSendServer_SendData_IsValid = NativeReflection.ValidatePropertyClass(GSRpcSendServer_FunctionAddress, "SendData", Classes.FArrayProperty);
		GSRpcSendServer_IsValid = GSRpcSendServer_FunctionAddress != IntPtr.Zero && GSRpcSendServer_SendData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendServer", GSRpcSendServer_IsValid);
		GSRpcSendClient_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSRpcSendClient");
		GSRpcSendClient_ParamsSize = NativeReflection.GetFunctionParamsSize(GSRpcSendClient_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSRpcSendClient_SendData_PropertyAddress, GSRpcSendClient_FunctionAddress, "SendData");
		GSRpcSendClient_SendData_Offset = NativeReflection.GetPropertyOffset(GSRpcSendClient_FunctionAddress, "SendData");
		GSRpcSendClient_SendData_IsValid = NativeReflection.ValidatePropertyClass(GSRpcSendClient_FunctionAddress, "SendData", Classes.FArrayProperty);
		GSRpcSendClient_IsValid = GSRpcSendClient_FunctionAddress != IntPtr.Zero && GSRpcSendClient_SendData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:GSRpcSendClient", GSRpcSendClient_IsValid);
		OnControlledPawnChange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnControlledPawnChange");
		OnControlledPawnChange_ParamsSize = NativeReflection.GetFunctionParamsSize(OnControlledPawnChange_FunctionAddress);
		OnControlledPawnChange_OldPawn_Offset = NativeReflection.GetPropertyOffset(OnControlledPawnChange_FunctionAddress, "OldPawn");
		OnControlledPawnChange_OldPawn_IsValid = NativeReflection.ValidatePropertyClass(OnControlledPawnChange_FunctionAddress, "OldPawn", Classes.FObjectProperty);
		OnControlledPawnChange_NewPawn_Offset = NativeReflection.GetPropertyOffset(OnControlledPawnChange_FunctionAddress, "NewPawn");
		OnControlledPawnChange_NewPawn_IsValid = NativeReflection.ValidatePropertyClass(OnControlledPawnChange_FunctionAddress, "NewPawn", Classes.FObjectProperty);
		OnControlledPawnChange_IsValid = OnControlledPawnChange_FunctionAddress != IntPtr.Zero && OnControlledPawnChange_OldPawn_IsValid && OnControlledPawnChange_NewPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:OnControlledPawnChange", OnControlledPawnChange_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ConsoleCommandCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConsoleCommandCS");
		ConsoleCommandCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsoleCommandCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ConsoleCommandCS_Command_PropertyAddress, ConsoleCommandCS_FunctionAddress, "Command");
		ConsoleCommandCS_Command_Offset = NativeReflection.GetPropertyOffset(ConsoleCommandCS_FunctionAddress, "Command");
		ConsoleCommandCS_Command_IsValid = NativeReflection.ValidatePropertyClass(ConsoleCommandCS_FunctionAddress, "Command", Classes.FStrProperty);
		ConsoleCommandCS_IsValid = ConsoleCommandCS_FunctionAddress != IntPtr.Zero && ConsoleCommandCS_Command_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:ConsoleCommandCS", ConsoleCommandCS_IsValid);
		InitInputSystemCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitInputSystemCS");
		InitInputSystemCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitInputSystemCS_FunctionAddress);
		InitInputSystemCS_IsValid = InitInputSystemCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:InitInputSystemCS", InitInputSystemCS_IsValid);
		OnRep_PlayerStateCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRep_PlayerStateCS");
		OnRep_PlayerStateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PlayerStateCS_FunctionAddress);
		OnRep_PlayerStateCS_IsValid = OnRep_PlayerStateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:OnRep_PlayerStateCS", OnRep_PlayerStateCS_IsValid);
		GetPlayerViewPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerViewPointCS");
		GetPlayerViewPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetPlayerViewPointCS_out_Location_PropertyAddress, GetPlayerViewPointCS_FunctionAddress, "out_Location");
		GetPlayerViewPointCS_out_Location_Offset = NativeReflection.GetPropertyOffset(GetPlayerViewPointCS_FunctionAddress, "out_Location");
		GetPlayerViewPointCS_out_Location_IsValid = NativeReflection.ValidatePropertyClass(GetPlayerViewPointCS_FunctionAddress, "out_Location", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetPlayerViewPointCS_out_Rotation_PropertyAddress, GetPlayerViewPointCS_FunctionAddress, "out_Rotation");
		GetPlayerViewPointCS_out_Rotation_Offset = NativeReflection.GetPropertyOffset(GetPlayerViewPointCS_FunctionAddress, "out_Rotation");
		GetPlayerViewPointCS_out_Rotation_IsValid = NativeReflection.ValidatePropertyClass(GetPlayerViewPointCS_FunctionAddress, "out_Rotation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetPlayerViewPointCS_ReturnValue_PropertyAddress, GetPlayerViewPointCS_FunctionAddress, "ReturnValue");
		GetPlayerViewPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetPlayerViewPointCS_FunctionAddress, "ReturnValue");
		GetPlayerViewPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetPlayerViewPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPlayerViewPointCS_IsValid = GetPlayerViewPointCS_FunctionAddress != IntPtr.Zero && GetPlayerViewPointCS_out_Location_IsValid && GetPlayerViewPointCS_out_Rotation_IsValid && GetPlayerViewPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:GetPlayerViewPointCS", GetPlayerViewPointCS_IsValid);
		GetSeamlessTravelActorListCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSeamlessTravelActorListCS");
		GetSeamlessTravelActorListCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSeamlessTravelActorListCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSeamlessTravelActorListCS_bToEntry_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "bToEntry");
		GetSeamlessTravelActorListCS_bToEntry_Offset = NativeReflection.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "bToEntry");
		GetSeamlessTravelActorListCS_bToEntry_IsValid = NativeReflection.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "bToEntry", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GetSeamlessTravelActorListCS_ActorList_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_Offset = NativeReflection.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_IsValid = NativeReflection.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList", Classes.FArrayProperty);
		GetSeamlessTravelActorListCS_IsValid = GetSeamlessTravelActorListCS_FunctionAddress != IntPtr.Zero && GetSeamlessTravelActorListCS_bToEntry_IsValid && GetSeamlessTravelActorListCS_ActorList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerCS:GetSeamlessTravelActorListCS", GetSeamlessTravelActorListCS_IsValid);
	}

	static BGP_PlayerControllerCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_PlayerControllerCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_PlayerControllerCS));
	}
}
