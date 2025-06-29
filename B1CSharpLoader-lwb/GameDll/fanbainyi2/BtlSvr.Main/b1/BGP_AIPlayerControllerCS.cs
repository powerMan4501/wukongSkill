using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerCS")]
public abstract class BGP_AIPlayerControllerCS : ABGUAIPlayerController, IGSRpcController, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private Action<List<byte>> OnServerReceiveMessageHandler;

	private Action<List<byte>> OnClientReceiveMessageHandler;

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
	[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerCS:DataComp")]
	public UActorDataContainer DataComp
	{
		get
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:DataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, DataComp_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:DataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, DataComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerCS:EventCollection")]
	private BPS_GSEventCollection EventCollection
	{
		get
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:EventCollection");
				return null;
			}
			return UObjectMarshaler<BPS_GSEventCollection>.FromNative(IntPtr.Add(base.Address, EventCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:EventCollection");
			}
			else
			{
				UObjectMarshaler<BPS_GSEventCollection>.ToNative(IntPtr.Add(base.Address, EventCollection_Offset), value);
			}
		}
	}

	private string UniqueNetIdStr { get; set; }

	public int ECSArcheType => 3;

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	public sealed override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		CreateDataContainer(initializer);
	}

	public Entity GetECSEntity()
	{
		return ECSEntity;
	}

	protected abstract void CreateDataContainer(FObjectInitializer initializer);

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

	public void AfterInitAllComp()
	{
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	public void RegisterRpcMessageHandler(Action<List<byte>> ServerReceiveMessageHandler)
	{
		OnServerReceiveMessageHandler = ServerReceiveMessageHandler;
	}

	public void UnRegisterRpcMessageHandler()
	{
		OnServerReceiveMessageHandler = null;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendServer")]
	public unsafe void GSRpcSendServer(List<byte> SendData)
	{
		CheckDestroyed();
		if (!GSRpcSendServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendServer");
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
		OnServerReceiveMessageHandler?.Invoke(RecvData);
	}

	public void RegisterClientMessageHandler(Action<List<byte>> ClientReceiveMessageHandler)
	{
		OnClientReceiveMessageHandler = ClientReceiveMessageHandler;
	}

	public void UnRegisterClientMessageHandler()
	{
		OnClientReceiveMessageHandler = null;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Client, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendClient")]
	public unsafe void GSRpcSendClient(List<byte> SendData)
	{
		CheckDestroyed();
		if (!GSRpcSendClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendClient");
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
		OnClientReceiveMessageHandler?.Invoke(RecvData);
	}

	public APlayerState GetPlayerState()
	{
		return base.PlayerState;
	}

	public string GetUniqueNetIdStr()
	{
		return UniqueNetIdStr;
	}

	public void SetUniqueNetIdStr(string NewUniqueNetIdStr)
	{
		UniqueNetIdStr = NewUniqueNetIdStr;
	}

	public BPC_PlayerRoleData GetReadOnlyDataTodoRemove()
	{
		return BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(this);
	}

	bool IGSRpcController.HasAuthority()
	{
		return HasAuthority();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendServer")]
	private static void GSRpcSendServer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_AIPlayerControllerCS bGP_AIPlayerControllerCS = GCHelper.Find<BGP_AIPlayerControllerCS>(obj);
		List<byte> recvData = new TArrayCopyMarshaler<byte>(1, GSRpcSendServer_SendData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, GSRpcSendServer_SendData_Offset));
		bGP_AIPlayerControllerCS.GSRpcSendServer_Implementation(recvData);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendClient")]
	private static void GSRpcSendClient__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_AIPlayerControllerCS bGP_AIPlayerControllerCS = GCHelper.Find<BGP_AIPlayerControllerCS>(obj);
		List<byte> recvData = new TArrayCopyMarshaler<byte>(1, GSRpcSendClient_SendData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, GSRpcSendClient_SendData_Offset));
		bGP_AIPlayerControllerCS.GSRpcSendClient_Implementation(recvData);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGP_AIPlayerControllerCS");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendServer", GSRpcSendServer_IsValid);
		GSRpcSendClient_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSRpcSendClient");
		GSRpcSendClient_ParamsSize = NativeReflection.GetFunctionParamsSize(GSRpcSendClient_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSRpcSendClient_SendData_PropertyAddress, GSRpcSendClient_FunctionAddress, "SendData");
		GSRpcSendClient_SendData_Offset = NativeReflection.GetPropertyOffset(GSRpcSendClient_FunctionAddress, "SendData");
		GSRpcSendClient_SendData_IsValid = NativeReflection.ValidatePropertyClass(GSRpcSendClient_FunctionAddress, "SendData", Classes.FArrayProperty);
		GSRpcSendClient_IsValid = GSRpcSendClient_FunctionAddress != IntPtr.Zero && GSRpcSendClient_SendData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_AIPlayerControllerCS:GSRpcSendClient", GSRpcSendClient_IsValid);
	}

	static BGP_AIPlayerControllerCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_AIPlayerControllerCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_AIPlayerControllerCS));
	}
}
