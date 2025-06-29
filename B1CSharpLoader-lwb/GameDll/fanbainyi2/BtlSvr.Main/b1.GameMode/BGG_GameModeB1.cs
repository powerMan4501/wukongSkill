using System;
using b1.GameState;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.GameMode;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameModeB1")]
public class BGG_GameModeB1 : BGG_GameMode
{
	private static bool DefaultPawnClassBeforeRoleData_IsValid;

	private static int DefaultPawnClassBeforeRoleData_Offset;

	private static bool PreLoginCS_IsValid;

	private static IntPtr PreLoginCS_FunctionAddress;

	private static int PreLoginCS_ParamsSize;

	private static bool PreLoginCS_Options_IsValid;

	private static int PreLoginCS_Options_Offset;

	private static FFieldAddress PreLoginCS_Options_PropertyAddress;

	private static bool PreLoginCS_LoginAddress_IsValid;

	private static int PreLoginCS_LoginAddress_Offset;

	private static FFieldAddress PreLoginCS_LoginAddress_PropertyAddress;

	private static bool PreLoginCS_UniqueId_IsValid;

	private static int PreLoginCS_UniqueId_Offset;

	private static FFieldAddress PreLoginCS_UniqueId_PropertyAddress;

	private static bool PreLoginCS_ErrorMessage_IsValid;

	private static int PreLoginCS_ErrorMessage_Offset;

	private static FFieldAddress PreLoginCS_ErrorMessage_PropertyAddress;

	private static bool LoginOutCS_IsValid;

	private static IntPtr LoginOutCS_FunctionAddress;

	private static int LoginOutCS_ParamsSize;

	private static bool LoginOutCS_Exiting_IsValid;

	private static int LoginOutCS_Exiting_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool PostLoginCS_IsValid;

	private static IntPtr PostLoginCS_FunctionAddress;

	private static int PostLoginCS_ParamsSize;

	private static bool PostLoginCS_NewPlayer_IsValid;

	private static int PostLoginCS_NewPlayer_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool HandleMatchIsWaitingToStartCS_IsValid;

	private static IntPtr HandleMatchIsWaitingToStartCS_FunctionAddress;

	private static int HandleMatchIsWaitingToStartCS_ParamsSize;

	private static bool GetDefaultPawnClassForController_IsValid;

	private static IntPtr GetDefaultPawnClassForController_FunctionAddress;

	private static int GetDefaultPawnClassForController_ParamsSize;

	private static bool GetDefaultPawnClassForController_InController_IsValid;

	private static int GetDefaultPawnClassForController_InController_Offset;

	private static bool GetDefaultPawnClassForController_ReturnValue_IsValid;

	private static int GetDefaultPawnClassForController_ReturnValue_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[Category("Classes")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:DefaultPawnClassBeforeRoleData")]
	public TSubclassOf<APawn> DefaultPawnClassBeforeRoleData
	{
		get
		{
			CheckDestroyed();
			if (!DefaultPawnClassBeforeRoleData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameModeB1:DefaultPawnClassBeforeRoleData");
				return default(TSubclassOf<APawn>);
			}
			return TSubclassOfMarshaler<APawn>.FromNative(IntPtr.Add(base.Address, DefaultPawnClassBeforeRoleData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultPawnClassBeforeRoleData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameModeB1:DefaultPawnClassBeforeRoleData");
			}
			else
			{
				TSubclassOfMarshaler<APawn>.ToNative(IntPtr.Add(base.Address, DefaultPawnClassBeforeRoleData_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.GameStateClass = UClass.GetClass<BGGGameStateB1>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BGG_GameModeDataCompB1>(this, B1GlobalFNames.GameModeDataCompB1);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:GetDefaultPawnClassForController")]
	protected override TSubclassOf<UObject> GetDefaultPawnClassForController_Implementation(AController InController)
	{
		return DefaultPawnClassBeforeRoleData.Value;
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:HandleMatchIsWaitingToStartCS")]
	protected override void HandleMatchIsWaitingToStartCS_Implementation()
	{
		BGW_LogUtil.LogError("");
		base.HandleMatchIsWaitingToStartCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:PreLoginCS")]
	protected override void PreLoginCS_Implementation(string Options, string LoginAddress, string UniqueId, out string ErrorMessage)
	{
		base.PreLoginCS_Implementation(Options, LoginAddress, UniqueId, out ErrorMessage);
		if (ErrorMessage != null)
		{
			_ = ErrorMessage.Length;
		}
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BGS_StartUpGMSystem(), 2);
		base.ActorCompContainerCS.AddComp(new BGS_OnlineScreenMsgSystem(), 2);
		base.ActorCompContainerCS.AddComp(new BGS_OSSCollectionMgrSystem(), 2);
		base.ActorCompContainerCS.AddComp(new BGS_AudioSystem());
		base.ActorCompContainerCS.AddComp(new BGS_GameDifficultySystem());
		base.ActorCompContainerCS.AddComp(new BGS_DSDebugSystem(), 4);
		base.ActorCompContainerCS.AddComp(new BGS_TamerAuthManageSystemServer(), 4);
		base.ActorCompContainerCS.AddComp(new BGS_PlayerGuideSystem());
		base.ActorCompContainerCS.AddComp(new BGS_PlayerDeathSystem());
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:PostLoginCS")]
	protected override void PostLoginCS_Implementation(APlayerController NewPlayer)
	{
		base.PostLoginCS_Implementation(NewPlayer);
		if (!NewPlayer.IsLocalPlayerController())
		{
			BGW_EventCollection.Get(this).Evt_BGW_CFSMGStart("/Game/00Main/DataAsset/CFSMG/GI_Loading/CFSMG_GI_Loading_ServerLogin.CFSMG_GI_Loading_ServerLogin", new FSMContext_GI_Loading(BGWGameInstanceCS.Get(this))
			{
				Controller = NewPlayer
			}, BGWGameInstanceCS.Get(this), null, null, null, new FSMInputData_GI_Global_SubG_GI_Loading_ServerLogin
			{
				PlayerController = NewPlayer
			});
		}
		BGW_EventCollection.Get(this).Evt_OnPlayerPostLogin();
		BGS_GSEventCollection bGS_GSEventCollection = (UGameplayStatics.GetGameState(base.World) as BGGGameStateCS)?.GameEventCollection;
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_OnPlayerPostLogin.Invoke(NewPlayer);
			bGS_GSEventCollection.Evt_BGS_PlayerJoin.Invoke(NewPlayer?.PlayerState);
		}
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:LoginOutCS")]
	protected override void LoginOutCS_Implementation(AController Exiting)
	{
		base.LoginOutCS_Implementation(Exiting);
		BGS_GSEventCollection bGS_GSEventCollection = (UGameplayStatics.GetGameState(base.World) as BGGGameStateCS)?.GameEventCollection;
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_OnPlayerLogOut.Invoke(Exiting);
			bGS_GSEventCollection.Evt_BGS_PlayerLogOut.Invoke(Exiting?.PlayerState);
		}
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:PreLoginCS")]
	private static void PreLoginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		string options = FStringMarshaler.FromNative(IntPtr.Add(buffer, PreLoginCS_Options_Offset));
		string loginAddress = FStringMarshaler.FromNative(IntPtr.Add(buffer, PreLoginCS_LoginAddress_Offset));
		string uniqueId = FStringMarshaler.FromNative(IntPtr.Add(buffer, PreLoginCS_UniqueId_Offset));
		bGG_GameModeB.PreLoginCS_Implementation(options, loginAddress, uniqueId, out var ErrorMessage);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, PreLoginCS_ErrorMessage_Offset), ErrorMessage);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:LoginOutCS")]
	private static void LoginOutCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		AController exiting = UObjectMarshaler<AController>.FromNative(IntPtr.Add(buffer, LoginOutCS_Exiting_Offset));
		bGG_GameModeB.LoginOutCS_Implementation(exiting);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGG_GameModeB.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:PostLoginCS")]
	private static void PostLoginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		APlayerController newPlayer = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, PostLoginCS_NewPlayer_Offset));
		bGG_GameModeB.PostLoginCS_Implementation(newPlayer);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		bGG_GameModeB.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGG_GameModeB.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:HandleMatchIsWaitingToStartCS")]
	private static void HandleMatchIsWaitingToStartCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		bGG_GameModeB.HandleMatchIsWaitingToStartCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1:GetDefaultPawnClassForController")]
	private static void GetDefaultPawnClassForController__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1 bGG_GameModeB = GCHelper.Find<BGG_GameModeB1>(obj);
		AController inController = UObjectMarshaler<AController>.FromNative(IntPtr.Add(buffer, GetDefaultPawnClassForController_InController_Offset));
		TSubclassOf<UObject> defaultPawnClassForController_Implementation = bGG_GameModeB.GetDefaultPawnClassForController_Implementation(inController);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetDefaultPawnClassForController_ReturnValue_Offset), defaultPawnClassForController_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameModeB1");
		DefaultPawnClassBeforeRoleData_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultPawnClassBeforeRoleData");
		DefaultPawnClassBeforeRoleData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultPawnClassBeforeRoleData", Classes.FClassProperty);
		PreLoginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreLoginCS");
		PreLoginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreLoginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PreLoginCS_Options_PropertyAddress, PreLoginCS_FunctionAddress, "Options");
		PreLoginCS_Options_Offset = NativeReflection.GetPropertyOffset(PreLoginCS_FunctionAddress, "Options");
		PreLoginCS_Options_IsValid = NativeReflection.ValidatePropertyClass(PreLoginCS_FunctionAddress, "Options", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PreLoginCS_LoginAddress_PropertyAddress, PreLoginCS_FunctionAddress, "LoginAddress");
		PreLoginCS_LoginAddress_Offset = NativeReflection.GetPropertyOffset(PreLoginCS_FunctionAddress, "LoginAddress");
		PreLoginCS_LoginAddress_IsValid = NativeReflection.ValidatePropertyClass(PreLoginCS_FunctionAddress, "LoginAddress", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PreLoginCS_UniqueId_PropertyAddress, PreLoginCS_FunctionAddress, "UniqueId");
		PreLoginCS_UniqueId_Offset = NativeReflection.GetPropertyOffset(PreLoginCS_FunctionAddress, "UniqueId");
		PreLoginCS_UniqueId_IsValid = NativeReflection.ValidatePropertyClass(PreLoginCS_FunctionAddress, "UniqueId", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PreLoginCS_ErrorMessage_PropertyAddress, PreLoginCS_FunctionAddress, "ErrorMessage");
		PreLoginCS_ErrorMessage_Offset = NativeReflection.GetPropertyOffset(PreLoginCS_FunctionAddress, "ErrorMessage");
		PreLoginCS_ErrorMessage_IsValid = NativeReflection.ValidatePropertyClass(PreLoginCS_FunctionAddress, "ErrorMessage", Classes.FStrProperty);
		PreLoginCS_IsValid = PreLoginCS_FunctionAddress != IntPtr.Zero && PreLoginCS_Options_IsValid && PreLoginCS_LoginAddress_IsValid && PreLoginCS_UniqueId_IsValid && PreLoginCS_ErrorMessage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:PreLoginCS", PreLoginCS_IsValid);
		LoginOutCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoginOutCS");
		LoginOutCS_ParamsSize = NativeReflection.GetFunctionParamsSize(LoginOutCS_FunctionAddress);
		LoginOutCS_Exiting_Offset = NativeReflection.GetPropertyOffset(LoginOutCS_FunctionAddress, "Exiting");
		LoginOutCS_Exiting_IsValid = NativeReflection.ValidatePropertyClass(LoginOutCS_FunctionAddress, "Exiting", Classes.FObjectProperty);
		LoginOutCS_IsValid = LoginOutCS_FunctionAddress != IntPtr.Zero && LoginOutCS_Exiting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:LoginOutCS", LoginOutCS_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:ReceiveTick", ReceiveTick_IsValid);
		PostLoginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostLoginCS");
		PostLoginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostLoginCS_FunctionAddress);
		PostLoginCS_NewPlayer_Offset = NativeReflection.GetPropertyOffset(PostLoginCS_FunctionAddress, "NewPlayer");
		PostLoginCS_NewPlayer_IsValid = NativeReflection.ValidatePropertyClass(PostLoginCS_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		PostLoginCS_IsValid = PostLoginCS_FunctionAddress != IntPtr.Zero && PostLoginCS_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:PostLoginCS", PostLoginCS_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		HandleMatchIsWaitingToStartCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchIsWaitingToStartCS");
		HandleMatchIsWaitingToStartCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchIsWaitingToStartCS_FunctionAddress);
		HandleMatchIsWaitingToStartCS_IsValid = HandleMatchIsWaitingToStartCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:HandleMatchIsWaitingToStartCS", HandleMatchIsWaitingToStartCS_IsValid);
		GetDefaultPawnClassForController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultPawnClassForController");
		GetDefaultPawnClassForController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultPawnClassForController_FunctionAddress);
		GetDefaultPawnClassForController_InController_Offset = NativeReflection.GetPropertyOffset(GetDefaultPawnClassForController_FunctionAddress, "InController");
		GetDefaultPawnClassForController_InController_IsValid = NativeReflection.ValidatePropertyClass(GetDefaultPawnClassForController_FunctionAddress, "InController", Classes.FObjectProperty);
		GetDefaultPawnClassForController_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDefaultPawnClassForController_FunctionAddress, "ReturnValue");
		GetDefaultPawnClassForController_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDefaultPawnClassForController_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetDefaultPawnClassForController_IsValid = GetDefaultPawnClassForController_FunctionAddress != IntPtr.Zero && GetDefaultPawnClassForController_InController_IsValid && GetDefaultPawnClassForController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1:GetDefaultPawnClassForController", GetDefaultPawnClassForController_IsValid);
	}

	static BGG_GameModeB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameModeB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameModeB1));
	}
}
