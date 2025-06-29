using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ReplicationGraph;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline")]
public class B1ReplicationGraphOnline : B1ReplicationGraphCS
{
	private static bool AddNetworkActorCS_IsValid;

	private static IntPtr AddNetworkActorCS_FunctionAddress;

	private static int AddNetworkActorCS_ParamsSize;

	private static bool AddNetworkActorCS_Actor_IsValid;

	private static int AddNetworkActorCS_Actor_Offset;

	private static bool GSNetworkRemapPathCS_IsValid;

	private static IntPtr GSNetworkRemapPathCS_FunctionAddress;

	private static int GSNetworkRemapPathCS_ParamsSize;

	private static bool GSNetworkRemapPathCS_Outer_IsValid;

	private static int GSNetworkRemapPathCS_Outer_Offset;

	private static bool GSNetworkRemapPathCS_OriginName_IsValid;

	private static int GSNetworkRemapPathCS_OriginName_Offset;

	private static FFieldAddress GSNetworkRemapPathCS_OriginName_PropertyAddress;

	private static bool GSNetworkRemapPathCS_Name_IsValid;

	private static int GSNetworkRemapPathCS_Name_Offset;

	private static FFieldAddress GSNetworkRemapPathCS_Name_PropertyAddress;

	private static bool RemoveNetworkActorCS_IsValid;

	private static IntPtr RemoveNetworkActorCS_FunctionAddress;

	private static int RemoveNetworkActorCS_ParamsSize;

	private static bool RemoveNetworkActorCS_Actor_IsValid;

	private static int RemoveNetworkActorCS_Actor_Offset;

	private static bool InitConnectionGraphNodesCS_IsValid;

	private static IntPtr InitConnectionGraphNodesCS_FunctionAddress;

	private static int InitConnectionGraphNodesCS_ParamsSize;

	private static bool InitConnectionGraphNodesCS_RepGraphConnection_IsValid;

	private static int InitConnectionGraphNodesCS_RepGraphConnection_Offset;

	private static bool InitGlobalActorClassSettingsCS_IsValid;

	private static IntPtr InitGlobalActorClassSettingsCS_FunctionAddress;

	private static int InitGlobalActorClassSettingsCS_ParamsSize;

	private static bool ShouldServerMultiCastRPCForPlayerCS_IsValid;

	private static IntPtr ShouldServerMultiCastRPCForPlayerCS_FunctionAddress;

	private static int ShouldServerMultiCastRPCForPlayerCS_ParamsSize;

	private static bool ShouldServerMultiCastRPCForPlayerCS_Controller_IsValid;

	private static int ShouldServerMultiCastRPCForPlayerCS_Controller_Offset;

	private static bool ShouldServerMultiCastRPCForPlayerCS_Actor_IsValid;

	private static int ShouldServerMultiCastRPCForPlayerCS_Actor_Offset;

	private static bool ShouldServerMultiCastRPCForPlayerCS_FuncAddr_IsValid;

	private static int ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset;

	private static bool ShouldServerMultiCastRPCForPlayerCS_ReturnValue_IsValid;

	private static int ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset;

	private static FFieldAddress ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline:GSNetworkRemapPathCS")]
	protected override void GSNetworkRemapPathCS_Implementation(UObject Outer, string OriginName, out string Name)
	{
		if (Outer is ULevel && OriginName.Contains("@"))
		{
			string[] array = OriginName.Split('@');
			TamerCharacterNameAllocator orAllocTamerCharacterNameAllocator = BGU_DataUtil.GetOrAllocTamerCharacterNameAllocator(this, array[0]);
			if (orAllocTamerCharacterNameAllocator != null)
			{
				Name = orAllocTamerCharacterNameAllocator.GetCurrentName();
				if (DebugConfig.DebugGSRepRole)
				{
					BGW_LogUtil.LogError("GSNetworkRemapPathCS_Implementation 0 PathName:" + Name);
				}
				return;
			}
			Name = array[0] + "@_0";
		}
		else
		{
			Name = OriginName;
		}
		if (DebugConfig.DebugGSRepRole)
		{
			BGW_LogUtil.LogError("GSNetworkRemapPathCS_Implementation 2 PathName:" + Name);
		}
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline:AddNetworkActorCS")]
	protected override void AddNetworkActorCS_Implementation(AActor Actor)
	{
		base.AddNetworkActorCS_Implementation(Actor);
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline:RemoveNetworkActorCS")]
	protected override void RemoveNetworkActorCS_Implementation(AActor Actor)
	{
		base.RemoveNetworkActorCS_Implementation(Actor);
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline:ShouldServerMultiCastRPCForPlayerCS")]
	protected override bool ShouldServerMultiCastRPCForPlayerCS_Implementation(APlayerController Controller, AActor Actor, long FuncAddr)
	{
		BGC_ServerTamerAuthData gameModeReadonlyData = BGU_DataUtil.GetGameModeReadonlyData<BGC_ServerTamerAuthData>(Controller);
		BGC_PredictionKeyData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_PredictionKeyData>(Controller);
		if (gameStateReadonlyData == null)
		{
			BGW_LogUtil.LogError("BGCPredictionData == null !!!");
			return false;
		}
		if (gameModeReadonlyData != null)
		{
			BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
			BGUProjectileBaseActor bGUProjectileBaseActor = Actor as BGUProjectileBaseActor;
			if (bGUCharacterCS == null && bGUProjectileBaseActor == null)
			{
				return true;
			}
			if (gameStateReadonlyData.PridictOriginator == Controller.PlayerState && gameStateReadonlyData.ActiveFunctionAddr.ToInt64() == FuncAddr)
			{
				gameStateReadonlyData.PridictOriginator = null;
				gameStateReadonlyData.ActiveFunctionAddr = IntPtr.Zero;
				return false;
			}
			if (bGUProjectileBaseActor != null)
			{
				if (bGUProjectileBaseActor is BGUBulletBaseCS)
				{
					return false;
				}
				BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
				if (readOnlyData != null)
				{
					bGUCharacterCS = readOnlyData.GetMaster() as BGUCharacterCS;
					if (bGUCharacterCS == null)
					{
						return false;
					}
				}
			}
			if (bGUCharacterCS is BGUPlayerCharacterCS)
			{
				if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(bGUCharacterCS))
				{
					return bGUCharacterCS.ActorCompContainerCS.HasLateBeginPlay;
				}
				return false;
			}
			FTamerRef fTamerRef = (bGUCharacterCS?.GetTamerOwner() as BUTamerActor)?.CurrentRef;
			if ((ABGPPlayerController)Controller != null && fTamerRef != null && fTamerRef.Phase == ETamerPhase.Spawned && BGUFunctionLibraryCS.GetCharacterAuthorityPlayerController(bGUCharacterCS) != Controller)
			{
				return gameModeReadonlyData.GetOrAllocActiveTamersInServer(Controller.GetName()).Contains(fTamerRef);
			}
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline:InitGlobalActorClassSettingsCS")]
	protected override void InitGlobalActorClassSettingsCS_Implementation()
	{
		base.InitGlobalActorClassSettingsCS_Implementation();
		if (GetServerConnectionCS() != null)
		{
			SetAlwaysRelevantNodeCS(CreateNodeCS<B1ReplicationGraphNode_ClientAlwaysRelevant>());
		}
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphOnline:InitConnectionGraphNodesCS")]
	protected override void InitConnectionGraphNodesCS_Implementation(UNetReplicationGraphConnection RepGraphConnection)
	{
		if (GetServerConnectionCS() == null)
		{
			AddConnectionGraphNodeCS(CreateNodeCS<B1ReplicationGraphNode_TamerMonster>(), RepGraphConnection);
			AddConnectionGraphNodeCS(CreateNodeCS<B1ReplicationGraphNode_PlayerRelatedActor>(), RepGraphConnection);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphOnline:AddNetworkActorCS")]
	private static void AddNetworkActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphOnline b1ReplicationGraphOnline = GCHelper.Find<B1ReplicationGraphOnline>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, AddNetworkActorCS_Actor_Offset));
		b1ReplicationGraphOnline.AddNetworkActorCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphOnline:GSNetworkRemapPathCS")]
	private static void GSNetworkRemapPathCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphOnline b1ReplicationGraphOnline = GCHelper.Find<B1ReplicationGraphOnline>(obj);
		UObject outer = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GSNetworkRemapPathCS_Outer_Offset));
		string originName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GSNetworkRemapPathCS_OriginName_Offset));
		b1ReplicationGraphOnline.GSNetworkRemapPathCS_Implementation(outer, originName, out var Name);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GSNetworkRemapPathCS_Name_Offset), Name);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphOnline:RemoveNetworkActorCS")]
	private static void RemoveNetworkActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphOnline b1ReplicationGraphOnline = GCHelper.Find<B1ReplicationGraphOnline>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, RemoveNetworkActorCS_Actor_Offset));
		b1ReplicationGraphOnline.RemoveNetworkActorCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphOnline:InitConnectionGraphNodesCS")]
	private static void InitConnectionGraphNodesCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphOnline b1ReplicationGraphOnline = GCHelper.Find<B1ReplicationGraphOnline>(obj);
		UNetReplicationGraphConnection repGraphConnection = UObjectMarshaler<UNetReplicationGraphConnection>.FromNative(IntPtr.Add(buffer, InitConnectionGraphNodesCS_RepGraphConnection_Offset));
		b1ReplicationGraphOnline.InitConnectionGraphNodesCS_Implementation(repGraphConnection);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphOnline:InitGlobalActorClassSettingsCS")]
	private static void InitGlobalActorClassSettingsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphOnline b1ReplicationGraphOnline = GCHelper.Find<B1ReplicationGraphOnline>(obj);
		b1ReplicationGraphOnline.InitGlobalActorClassSettingsCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphOnline:ShouldServerMultiCastRPCForPlayerCS")]
	private static void ShouldServerMultiCastRPCForPlayerCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphOnline b1ReplicationGraphOnline = GCHelper.Find<B1ReplicationGraphOnline>(obj);
		APlayerController controller = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, ShouldServerMultiCastRPCForPlayerCS_Controller_Offset));
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ShouldServerMultiCastRPCForPlayerCS_Actor_Offset));
		long funcAddr = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(buffer, ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset));
		bool value = b1ReplicationGraphOnline.ShouldServerMultiCastRPCForPlayerCS_Implementation(controller, actor, funcAddr);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset), 0, ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1ReplicationGraphOnline");
		AddNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddNetworkActorCS");
		AddNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNetworkActorCS_FunctionAddress);
		AddNetworkActorCS_Actor_Offset = NativeReflection.GetPropertyOffset(AddNetworkActorCS_FunctionAddress, "Actor");
		AddNetworkActorCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(AddNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		AddNetworkActorCS_IsValid = AddNetworkActorCS_FunctionAddress != IntPtr.Zero && AddNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphOnline:AddNetworkActorCS", AddNetworkActorCS_IsValid);
		GSNetworkRemapPathCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNetworkRemapPathCS");
		GSNetworkRemapPathCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNetworkRemapPathCS_FunctionAddress);
		GSNetworkRemapPathCS_Outer_Offset = NativeReflection.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Outer");
		GSNetworkRemapPathCS_Outer_IsValid = NativeReflection.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GSNetworkRemapPathCS_OriginName_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_Offset = NativeReflection.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_IsValid = NativeReflection.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "OriginName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GSNetworkRemapPathCS_Name_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_Offset = NativeReflection.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_IsValid = NativeReflection.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Name", Classes.FStrProperty);
		GSNetworkRemapPathCS_IsValid = GSNetworkRemapPathCS_FunctionAddress != IntPtr.Zero && GSNetworkRemapPathCS_Outer_IsValid && GSNetworkRemapPathCS_OriginName_IsValid && GSNetworkRemapPathCS_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphOnline:GSNetworkRemapPathCS", GSNetworkRemapPathCS_IsValid);
		RemoveNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveNetworkActorCS");
		RemoveNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNetworkActorCS_FunctionAddress);
		RemoveNetworkActorCS_Actor_Offset = NativeReflection.GetPropertyOffset(RemoveNetworkActorCS_FunctionAddress, "Actor");
		RemoveNetworkActorCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(RemoveNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		RemoveNetworkActorCS_IsValid = RemoveNetworkActorCS_FunctionAddress != IntPtr.Zero && RemoveNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphOnline:RemoveNetworkActorCS", RemoveNetworkActorCS_IsValid);
		InitConnectionGraphNodesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitConnectionGraphNodesCS");
		InitConnectionGraphNodesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitConnectionGraphNodesCS_FunctionAddress);
		InitConnectionGraphNodesCS_RepGraphConnection_Offset = NativeReflection.GetPropertyOffset(InitConnectionGraphNodesCS_FunctionAddress, "RepGraphConnection");
		InitConnectionGraphNodesCS_RepGraphConnection_IsValid = NativeReflection.ValidatePropertyClass(InitConnectionGraphNodesCS_FunctionAddress, "RepGraphConnection", Classes.FObjectProperty);
		InitConnectionGraphNodesCS_IsValid = InitConnectionGraphNodesCS_FunctionAddress != IntPtr.Zero && InitConnectionGraphNodesCS_RepGraphConnection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphOnline:InitConnectionGraphNodesCS", InitConnectionGraphNodesCS_IsValid);
		InitGlobalActorClassSettingsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitGlobalActorClassSettingsCS");
		InitGlobalActorClassSettingsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitGlobalActorClassSettingsCS_FunctionAddress);
		InitGlobalActorClassSettingsCS_IsValid = InitGlobalActorClassSettingsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphOnline:InitGlobalActorClassSettingsCS", InitGlobalActorClassSettingsCS_IsValid);
		ShouldServerMultiCastRPCForPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ShouldServerMultiCastRPCForPlayerCS");
		ShouldServerMultiCastRPCForPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress);
		ShouldServerMultiCastRPCForPlayerCS_Controller_Offset = NativeReflection.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Controller");
		ShouldServerMultiCastRPCForPlayerCS_Controller_IsValid = NativeReflection.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Controller", Classes.FObjectProperty);
		ShouldServerMultiCastRPCForPlayerCS_Actor_Offset = NativeReflection.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Actor");
		ShouldServerMultiCastRPCForPlayerCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		ShouldServerMultiCastRPCForPlayerCS_FuncAddr_Offset = NativeReflection.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "FuncAddr");
		ShouldServerMultiCastRPCForPlayerCS_FuncAddr_IsValid = NativeReflection.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "FuncAddr", Classes.FInt64Property);
		NativeReflection.GetPropertyRef(ref ShouldServerMultiCastRPCForPlayerCS_ReturnValue_PropertyAddress, ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "ReturnValue");
		ShouldServerMultiCastRPCForPlayerCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "ReturnValue");
		ShouldServerMultiCastRPCForPlayerCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldServerMultiCastRPCForPlayerCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldServerMultiCastRPCForPlayerCS_IsValid = ShouldServerMultiCastRPCForPlayerCS_FunctionAddress != IntPtr.Zero && ShouldServerMultiCastRPCForPlayerCS_Controller_IsValid && ShouldServerMultiCastRPCForPlayerCS_Actor_IsValid && ShouldServerMultiCastRPCForPlayerCS_FuncAddr_IsValid && ShouldServerMultiCastRPCForPlayerCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphOnline:ShouldServerMultiCastRPCForPlayerCS", ShouldServerMultiCastRPCForPlayerCS_IsValid);
	}

	static B1ReplicationGraphOnline()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1ReplicationGraphOnline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1ReplicationGraphOnline));
	}
}
