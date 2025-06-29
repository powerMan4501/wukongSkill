using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.GameModeBase", "Engine", UnrealModuleType.Engine)]
public class AGameModeBase : AInfo
{
	private static bool OptionsString_IsValid;

	private static int OptionsString_Offset;

	private static bool GameSessionClass_IsValid;

	private static int GameSessionClass_Offset;

	private static bool GameStateClass_IsValid;

	private static int GameStateClass_Offset;

	private static bool PlayerControllerClass_IsValid;

	private static int PlayerControllerClass_Offset;

	private static bool PlayerStateClass_IsValid;

	private static int PlayerStateClass_Offset;

	private static bool HUDClass_IsValid;

	private static int HUDClass_Offset;

	private static bool DefaultPawnClass_IsValid;

	private static int DefaultPawnClass_Offset;

	private static bool SpectatorClass_IsValid;

	private static int SpectatorClass_Offset;

	private static bool ReplaySpectatorPlayerControllerClass_IsValid;

	private static int ReplaySpectatorPlayerControllerClass_Offset;

	private static bool ServerStatReplicatorClass_IsValid;

	private static int ServerStatReplicatorClass_Offset;

	private static bool UseSeamlessTravel_IsValid;

	private static FFieldAddress UseSeamlessTravel_PropertyAddress;

	private static int UseSeamlessTravel_Offset;

	private static bool StartPlayersAsSpectators_IsValid;

	private static FFieldAddress StartPlayersAsSpectators_PropertyAddress;

	private static int StartPlayersAsSpectators_Offset;

	private static bool Pauseable_IsValid;

	private static FFieldAddress Pauseable_PropertyAddress;

	private static int Pauseable_Offset;

	private static bool StartPlay_IsValid;

	private static IntPtr StartPlay_FunctionAddress;

	private static int StartPlay_ParamsSize;

	private static bool SpawnDefaultPawnFor_IsValid;

	private IntPtr SpawnDefaultPawnFor_InstanceFunctionAddress;

	private static IntPtr SpawnDefaultPawnFor_FunctionAddress;

	private static int SpawnDefaultPawnFor_ParamsSize;

	private static bool SpawnDefaultPawnFor_NewPlayer_IsValid;

	private static FFieldAddress SpawnDefaultPawnFor_NewPlayer_PropertyAddress;

	private static int SpawnDefaultPawnFor_NewPlayer_Offset;

	private static bool SpawnDefaultPawnFor_StartSpot_IsValid;

	private static FFieldAddress SpawnDefaultPawnFor_StartSpot_PropertyAddress;

	private static int SpawnDefaultPawnFor_StartSpot_Offset;

	private static bool SpawnDefaultPawnFor_ReturnValue_IsValid;

	private static FFieldAddress SpawnDefaultPawnFor_ReturnValue_PropertyAddress;

	private static int SpawnDefaultPawnFor_ReturnValue_Offset;

	private static bool SpawnDefaultPawnAtTransform_IsValid;

	private IntPtr SpawnDefaultPawnAtTransform_InstanceFunctionAddress;

	private static IntPtr SpawnDefaultPawnAtTransform_FunctionAddress;

	private static int SpawnDefaultPawnAtTransform_ParamsSize;

	private static bool SpawnDefaultPawnAtTransform_NewPlayer_IsValid;

	private static FFieldAddress SpawnDefaultPawnAtTransform_NewPlayer_PropertyAddress;

	private static int SpawnDefaultPawnAtTransform_NewPlayer_Offset;

	private static bool SpawnDefaultPawnAtTransform_SpawnTransform_IsValid;

	private static FFieldAddress SpawnDefaultPawnAtTransform_SpawnTransform_PropertyAddress;

	private static int SpawnDefaultPawnAtTransform_SpawnTransform_Offset;

	private static bool SpawnDefaultPawnAtTransform_ReturnValue_IsValid;

	private static FFieldAddress SpawnDefaultPawnAtTransform_ReturnValue_PropertyAddress;

	private static int SpawnDefaultPawnAtTransform_ReturnValue_Offset;

	private static bool ShouldReset_IsValid;

	private IntPtr ShouldReset_InstanceFunctionAddress;

	private static IntPtr ShouldReset_FunctionAddress;

	private static int ShouldReset_ParamsSize;

	private static bool ShouldReset_ActorToReset_IsValid;

	private static FFieldAddress ShouldReset_ActorToReset_PropertyAddress;

	private static int ShouldReset_ActorToReset_Offset;

	private static bool ShouldReset_ReturnValue_IsValid;

	private static FFieldAddress ShouldReset_ReturnValue_PropertyAddress;

	private static int ShouldReset_ReturnValue_Offset;

	private static bool ReturnToMainMenuHost_IsValid;

	private static IntPtr ReturnToMainMenuHost_FunctionAddress;

	private static int ReturnToMainMenuHost_ParamsSize;

	private static bool RestartPlayerAtTransform_IsValid;

	private static IntPtr RestartPlayerAtTransform_FunctionAddress;

	private static int RestartPlayerAtTransform_ParamsSize;

	private static bool RestartPlayerAtTransform_NewPlayer_IsValid;

	private static FFieldAddress RestartPlayerAtTransform_NewPlayer_PropertyAddress;

	private static int RestartPlayerAtTransform_NewPlayer_Offset;

	private static bool RestartPlayerAtTransform_SpawnTransform_IsValid;

	private static FFieldAddress RestartPlayerAtTransform_SpawnTransform_PropertyAddress;

	private static int RestartPlayerAtTransform_SpawnTransform_Offset;

	private static bool RestartPlayerAtPlayerStart_IsValid;

	private static IntPtr RestartPlayerAtPlayerStart_FunctionAddress;

	private static int RestartPlayerAtPlayerStart_ParamsSize;

	private static bool RestartPlayerAtPlayerStart_NewPlayer_IsValid;

	private static FFieldAddress RestartPlayerAtPlayerStart_NewPlayer_PropertyAddress;

	private static int RestartPlayerAtPlayerStart_NewPlayer_Offset;

	private static bool RestartPlayerAtPlayerStart_StartSpot_IsValid;

	private static FFieldAddress RestartPlayerAtPlayerStart_StartSpot_PropertyAddress;

	private static int RestartPlayerAtPlayerStart_StartSpot_Offset;

	private static bool RestartPlayer_IsValid;

	private static IntPtr RestartPlayer_FunctionAddress;

	private static int RestartPlayer_ParamsSize;

	private static bool RestartPlayer_NewPlayer_IsValid;

	private static FFieldAddress RestartPlayer_NewPlayer_PropertyAddress;

	private static int RestartPlayer_NewPlayer_Offset;

	private static bool ResetLevel_IsValid;

	private static IntPtr ResetLevel_FunctionAddress;

	private static int ResetLevel_ParamsSize;

	private static bool PlayerCanRestart_IsValid;

	private IntPtr PlayerCanRestart_InstanceFunctionAddress;

	private static IntPtr PlayerCanRestart_FunctionAddress;

	private static int PlayerCanRestart_ParamsSize;

	private static bool PlayerCanRestart_Player_IsValid;

	private static FFieldAddress PlayerCanRestart_Player_PropertyAddress;

	private static int PlayerCanRestart_Player_Offset;

	private static bool PlayerCanRestart_ReturnValue_IsValid;

	private static FFieldAddress PlayerCanRestart_ReturnValue_PropertyAddress;

	private static int PlayerCanRestart_ReturnValue_Offset;

	private static bool MustSpectate_IsValid;

	private IntPtr MustSpectate_InstanceFunctionAddress;

	private static IntPtr MustSpectate_FunctionAddress;

	private static int MustSpectate_ParamsSize;

	private static bool MustSpectate_NewPlayerController_IsValid;

	private static FFieldAddress MustSpectate_NewPlayerController_PropertyAddress;

	private static int MustSpectate_NewPlayerController_Offset;

	private static bool MustSpectate_ReturnValue_IsValid;

	private static FFieldAddress MustSpectate_ReturnValue_PropertyAddress;

	private static int MustSpectate_ReturnValue_Offset;

	private static bool OnPostLogin_IsValid;

	private IntPtr OnPostLogin_InstanceFunctionAddress;

	private static IntPtr OnPostLogin_FunctionAddress;

	private static int OnPostLogin_ParamsSize;

	private static bool OnPostLogin_NewPlayer_IsValid;

	private static FFieldAddress OnPostLogin_NewPlayer_PropertyAddress;

	private static int OnPostLogin_NewPlayer_Offset;

	private static bool OnSwapPlayerControllers_IsValid;

	private IntPtr OnSwapPlayerControllers_InstanceFunctionAddress;

	private static IntPtr OnSwapPlayerControllers_FunctionAddress;

	private static int OnSwapPlayerControllers_ParamsSize;

	private static bool OnSwapPlayerControllers_OldPC_IsValid;

	private static FFieldAddress OnSwapPlayerControllers_OldPC_PropertyAddress;

	private static int OnSwapPlayerControllers_OldPC_Offset;

	private static bool OnSwapPlayerControllers_NewPC_IsValid;

	private static FFieldAddress OnSwapPlayerControllers_NewPC_PropertyAddress;

	private static int OnSwapPlayerControllers_NewPC_Offset;

	private static bool OnRestartPlayer_IsValid;

	private IntPtr OnRestartPlayer_InstanceFunctionAddress;

	private static IntPtr OnRestartPlayer_FunctionAddress;

	private static int OnRestartPlayer_ParamsSize;

	private static bool OnRestartPlayer_NewPlayer_IsValid;

	private static FFieldAddress OnRestartPlayer_NewPlayer_PropertyAddress;

	private static int OnRestartPlayer_NewPlayer_Offset;

	private static bool OnLogout_IsValid;

	private IntPtr OnLogout_InstanceFunctionAddress;

	private static IntPtr OnLogout_FunctionAddress;

	private static int OnLogout_ParamsSize;

	private static bool OnLogout_ExitingController_IsValid;

	private static FFieldAddress OnLogout_ExitingController_PropertyAddress;

	private static int OnLogout_ExitingController_Offset;

	private static bool OnChangeName_IsValid;

	private IntPtr OnChangeName_InstanceFunctionAddress;

	private static IntPtr OnChangeName_FunctionAddress;

	private static int OnChangeName_ParamsSize;

	private static bool OnChangeName_Other_IsValid;

	private static FFieldAddress OnChangeName_Other_PropertyAddress;

	private static int OnChangeName_Other_Offset;

	private static bool OnChangeName_NewName_IsValid;

	private static FFieldAddress OnChangeName_NewName_PropertyAddress;

	private static int OnChangeName_NewName_Offset;

	private static bool OnChangeName_bNameChange_IsValid;

	private static FFieldAddress OnChangeName_bNameChange_PropertyAddress;

	private static int OnChangeName_bNameChange_Offset;

	private static bool FindPlayerStart_94A92F01_IsValid;

	private static IntPtr FindPlayerStart_94A92F01_FunctionAddress;

	private static int FindPlayerStart_94A92F01_ParamsSize;

	private static bool FindPlayerStart_94A92F01_Player_IsValid;

	private static FFieldAddress FindPlayerStart_94A92F01_Player_PropertyAddress;

	private static int FindPlayerStart_94A92F01_Player_Offset;

	private static bool FindPlayerStart_94A92F01_IncomingName_IsValid;

	private static FFieldAddress FindPlayerStart_94A92F01_IncomingName_PropertyAddress;

	private static int FindPlayerStart_94A92F01_IncomingName_Offset;

	private static bool FindPlayerStart_94A92F01_ReturnValue_IsValid;

	private static FFieldAddress FindPlayerStart_94A92F01_ReturnValue_PropertyAddress;

	private static int FindPlayerStart_94A92F01_ReturnValue_Offset;

	private static bool InitStartSpot_IsValid;

	private IntPtr InitStartSpot_InstanceFunctionAddress;

	private static IntPtr InitStartSpot_FunctionAddress;

	private static int InitStartSpot_ParamsSize;

	private static bool InitStartSpot_StartSpot_IsValid;

	private static FFieldAddress InitStartSpot_StartSpot_PropertyAddress;

	private static int InitStartSpot_StartSpot_Offset;

	private static bool InitStartSpot_NewPlayer_IsValid;

	private static FFieldAddress InitStartSpot_NewPlayer_PropertyAddress;

	private static int InitStartSpot_NewPlayer_Offset;

	private static bool InitializeHUDForPlayer_IsValid;

	private IntPtr InitializeHUDForPlayer_InstanceFunctionAddress;

	private static IntPtr InitializeHUDForPlayer_FunctionAddress;

	private static int InitializeHUDForPlayer_ParamsSize;

	private static bool InitializeHUDForPlayer_NewPlayer_IsValid;

	private static FFieldAddress InitializeHUDForPlayer_NewPlayer_PropertyAddress;

	private static int InitializeHUDForPlayer_NewPlayer_Offset;

	private static bool HasMatchStarted_IsValid;

	private static IntPtr HasMatchStarted_FunctionAddress;

	private static int HasMatchStarted_ParamsSize;

	private static bool HasMatchStarted_ReturnValue_IsValid;

	private static FFieldAddress HasMatchStarted_ReturnValue_PropertyAddress;

	private static int HasMatchStarted_ReturnValue_Offset;

	private static bool HasMatchEnded_IsValid;

	private static IntPtr HasMatchEnded_FunctionAddress;

	private static int HasMatchEnded_ParamsSize;

	private static bool HasMatchEnded_ReturnValue_IsValid;

	private static FFieldAddress HasMatchEnded_ReturnValue_PropertyAddress;

	private static int HasMatchEnded_ReturnValue_Offset;

	private static bool HandleStartingNewPlayer_IsValid;

	private IntPtr HandleStartingNewPlayer_InstanceFunctionAddress;

	private static IntPtr HandleStartingNewPlayer_FunctionAddress;

	private static int HandleStartingNewPlayer_ParamsSize;

	private static bool HandleStartingNewPlayer_NewPlayer_IsValid;

	private static FFieldAddress HandleStartingNewPlayer_NewPlayer_PropertyAddress;

	private static int HandleStartingNewPlayer_NewPlayer_Offset;

	private static bool GetNumSpectators_IsValid;

	private static IntPtr GetNumSpectators_FunctionAddress;

	private static int GetNumSpectators_ParamsSize;

	private static bool GetNumSpectators_ReturnValue_IsValid;

	private static FFieldAddress GetNumSpectators_ReturnValue_PropertyAddress;

	private static int GetNumSpectators_ReturnValue_Offset;

	private static bool GetNumPlayers_IsValid;

	private static IntPtr GetNumPlayers_FunctionAddress;

	private static int GetNumPlayers_ParamsSize;

	private static bool GetNumPlayers_ReturnValue_IsValid;

	private static FFieldAddress GetNumPlayers_ReturnValue_PropertyAddress;

	private static int GetNumPlayers_ReturnValue_Offset;

	private static bool GetDefaultPawnClassForController_IsValid;

	private IntPtr GetDefaultPawnClassForController_InstanceFunctionAddress;

	private static IntPtr GetDefaultPawnClassForController_FunctionAddress;

	private static int GetDefaultPawnClassForController_ParamsSize;

	private static bool GetDefaultPawnClassForController_InController_IsValid;

	private static FFieldAddress GetDefaultPawnClassForController_InController_PropertyAddress;

	private static int GetDefaultPawnClassForController_InController_Offset;

	private static bool GetDefaultPawnClassForController_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultPawnClassForController_ReturnValue_PropertyAddress;

	private static int GetDefaultPawnClassForController_ReturnValue_Offset;

	private static bool FindPlayerStart_8D0CD897_IsValid;

	private IntPtr FindPlayerStart_8D0CD897_InstanceFunctionAddress;

	private static IntPtr FindPlayerStart_8D0CD897_FunctionAddress;

	private static int FindPlayerStart_8D0CD897_ParamsSize;

	private static bool FindPlayerStart_8D0CD897_Player_IsValid;

	private static FFieldAddress FindPlayerStart_8D0CD897_Player_PropertyAddress;

	private static int FindPlayerStart_8D0CD897_Player_Offset;

	private static bool FindPlayerStart_8D0CD897_IncomingName_IsValid;

	private static FFieldAddress FindPlayerStart_8D0CD897_IncomingName_PropertyAddress;

	private static int FindPlayerStart_8D0CD897_IncomingName_Offset;

	private static bool FindPlayerStart_8D0CD897_ReturnValue_IsValid;

	private static FFieldAddress FindPlayerStart_8D0CD897_ReturnValue_PropertyAddress;

	private static int FindPlayerStart_8D0CD897_ReturnValue_Offset;

	private static bool ChoosePlayerStart_IsValid;

	private IntPtr ChoosePlayerStart_InstanceFunctionAddress;

	private static IntPtr ChoosePlayerStart_FunctionAddress;

	private static int ChoosePlayerStart_ParamsSize;

	private static bool ChoosePlayerStart_Player_IsValid;

	private static FFieldAddress ChoosePlayerStart_Player_PropertyAddress;

	private static int ChoosePlayerStart_Player_Offset;

	private static bool ChoosePlayerStart_ReturnValue_IsValid;

	private static FFieldAddress ChoosePlayerStart_ReturnValue_PropertyAddress;

	private static int ChoosePlayerStart_ReturnValue_Offset;

	private static bool ChangeName_IsValid;

	private static IntPtr ChangeName_FunctionAddress;

	private static int ChangeName_ParamsSize;

	private static bool ChangeName_Controller_IsValid;

	private static FFieldAddress ChangeName_Controller_PropertyAddress;

	private static int ChangeName_Controller_Offset;

	private static bool ChangeName_NewName_IsValid;

	private static FFieldAddress ChangeName_NewName_PropertyAddress;

	private static int ChangeName_NewName_Offset;

	private static bool ChangeName_bNameChange_IsValid;

	private static FFieldAddress ChangeName_bNameChange_PropertyAddress;

	private static int ChangeName_bNameChange_Offset;

	private static bool CanSpectate_IsValid;

	private IntPtr CanSpectate_InstanceFunctionAddress;

	private static IntPtr CanSpectate_FunctionAddress;

	private static int CanSpectate_ParamsSize;

	private static bool CanSpectate_Viewer_IsValid;

	private static FFieldAddress CanSpectate_Viewer_PropertyAddress;

	private static int CanSpectate_Viewer_Offset;

	private static bool CanSpectate_ViewTarget_IsValid;

	private static FFieldAddress CanSpectate_ViewTarget_PropertyAddress;

	private static int CanSpectate_ViewTarget_Offset;

	private static bool CanSpectate_ReturnValue_IsValid;

	private static FFieldAddress CanSpectate_ReturnValue_PropertyAddress;

	private static int CanSpectate_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/Engine.GameModeBase:OptionsString")]
	public string OptionsString
	{
		get
		{
			CheckDestroyed();
			if (!OptionsString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:OptionsString");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, OptionsString_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OptionsString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:OptionsString");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, OptionsString_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.GameModeBase:GameSessionClass")]
	public TSubclassOf<AGameSession> GameSessionClass
	{
		get
		{
			CheckDestroyed();
			if (!GameSessionClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:GameSessionClass");
				return default(TSubclassOf<AGameSession>);
			}
			return TSubclassOfMarshaler<AGameSession>.FromNative(IntPtr.Add(base.Address, GameSessionClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameSessionClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:GameSessionClass");
			}
			else
			{
				TSubclassOfMarshaler<AGameSession>.ToNative(IntPtr.Add(base.Address, GameSessionClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/Engine.GameModeBase:GameStateClass")]
	public TSubclassOf<AGameStateBase> GameStateClass
	{
		get
		{
			CheckDestroyed();
			if (!GameStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:GameStateClass");
				return default(TSubclassOf<AGameStateBase>);
			}
			return TSubclassOfMarshaler<AGameStateBase>.FromNative(IntPtr.Add(base.Address, GameStateClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:GameStateClass");
			}
			else
			{
				TSubclassOfMarshaler<AGameStateBase>.ToNative(IntPtr.Add(base.Address, GameStateClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/Engine.GameModeBase:PlayerControllerClass")]
	public TSubclassOf<APlayerController> PlayerControllerClass
	{
		get
		{
			CheckDestroyed();
			if (!PlayerControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:PlayerControllerClass");
				return default(TSubclassOf<APlayerController>);
			}
			return TSubclassOfMarshaler<APlayerController>.FromNative(IntPtr.Add(base.Address, PlayerControllerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:PlayerControllerClass");
			}
			else
			{
				TSubclassOfMarshaler<APlayerController>.ToNative(IntPtr.Add(base.Address, PlayerControllerClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/Engine.GameModeBase:PlayerStateClass")]
	public TSubclassOf<APlayerState> PlayerStateClass
	{
		get
		{
			CheckDestroyed();
			if (!PlayerStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:PlayerStateClass");
				return default(TSubclassOf<APlayerState>);
			}
			return TSubclassOfMarshaler<APlayerState>.FromNative(IntPtr.Add(base.Address, PlayerStateClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:PlayerStateClass");
			}
			else
			{
				TSubclassOfMarshaler<APlayerState>.ToNative(IntPtr.Add(base.Address, PlayerStateClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.GameModeBase:HUDClass")]
	public TSubclassOf<AHUD> HUDClass
	{
		get
		{
			CheckDestroyed();
			if (!HUDClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:HUDClass");
				return default(TSubclassOf<AHUD>);
			}
			return TSubclassOfMarshaler<AHUD>.FromNative(IntPtr.Add(base.Address, HUDClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HUDClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:HUDClass");
			}
			else
			{
				TSubclassOfMarshaler<AHUD>.ToNative(IntPtr.Add(base.Address, HUDClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.GameModeBase:DefaultPawnClass")]
	public TSubclassOf<APawn> DefaultPawnClass
	{
		get
		{
			CheckDestroyed();
			if (!DefaultPawnClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:DefaultPawnClass");
				return default(TSubclassOf<APawn>);
			}
			return TSubclassOfMarshaler<APawn>.FromNative(IntPtr.Add(base.Address, DefaultPawnClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultPawnClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:DefaultPawnClass");
			}
			else
			{
				TSubclassOfMarshaler<APawn>.ToNative(IntPtr.Add(base.Address, DefaultPawnClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/Engine.GameModeBase:SpectatorClass")]
	public TSubclassOf<ASpectatorPawn> SpectatorClass
	{
		get
		{
			CheckDestroyed();
			if (!SpectatorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:SpectatorClass");
				return default(TSubclassOf<ASpectatorPawn>);
			}
			return TSubclassOfMarshaler<ASpectatorPawn>.FromNative(IntPtr.Add(base.Address, SpectatorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpectatorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:SpectatorClass");
			}
			else
			{
				TSubclassOfMarshaler<ASpectatorPawn>.ToNative(IntPtr.Add(base.Address, SpectatorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/Engine.GameModeBase:ReplaySpectatorPlayerControllerClass")]
	public TSubclassOf<APlayerController> ReplaySpectatorPlayerControllerClass
	{
		get
		{
			CheckDestroyed();
			if (!ReplaySpectatorPlayerControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:ReplaySpectatorPlayerControllerClass");
				return default(TSubclassOf<APlayerController>);
			}
			return TSubclassOfMarshaler<APlayerController>.FromNative(IntPtr.Add(base.Address, ReplaySpectatorPlayerControllerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReplaySpectatorPlayerControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:ReplaySpectatorPlayerControllerClass");
			}
			else
			{
				TSubclassOfMarshaler<APlayerController>.ToNative(IntPtr.Add(base.Address, ReplaySpectatorPlayerControllerClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/Engine.GameModeBase:ServerStatReplicatorClass")]
	public TSubclassOf<AServerStatReplicator> ServerStatReplicatorClass
	{
		get
		{
			CheckDestroyed();
			if (!ServerStatReplicatorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:ServerStatReplicatorClass");
				return default(TSubclassOf<AServerStatReplicator>);
			}
			return TSubclassOfMarshaler<AServerStatReplicator>.FromNative(IntPtr.Add(base.Address, ServerStatReplicatorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ServerStatReplicatorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:ServerStatReplicatorClass");
			}
			else
			{
				TSubclassOfMarshaler<AServerStatReplicator>.ToNative(IntPtr.Add(base.Address, ServerStatReplicatorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.GameModeBase:bUseSeamlessTravel")]
	public bool UseSeamlessTravel
	{
		get
		{
			CheckDestroyed();
			if (!UseSeamlessTravel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:bUseSeamlessTravel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSeamlessTravel_Offset), 0, UseSeamlessTravel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSeamlessTravel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:bUseSeamlessTravel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSeamlessTravel_Offset), 0, UseSeamlessTravel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/Engine.GameModeBase:bStartPlayersAsSpectators")]
	protected bool StartPlayersAsSpectators
	{
		get
		{
			CheckDestroyed();
			if (!StartPlayersAsSpectators_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:bStartPlayersAsSpectators");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StartPlayersAsSpectators_Offset), 0, StartPlayersAsSpectators_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StartPlayersAsSpectators_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:bStartPlayersAsSpectators");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StartPlayersAsSpectators_Offset), 0, StartPlayersAsSpectators_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925189uL)]
	[UMetaPath("/Script/Engine.GameModeBase:bPauseable")]
	protected bool Pauseable
	{
		get
		{
			CheckDestroyed();
			if (!Pauseable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:bPauseable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Pauseable_Offset), 0, Pauseable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Pauseable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameModeBase:bPauseable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Pauseable_Offset), 0, Pauseable_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:StartPlay")]
	public unsafe void StartPlay()
	{
		CheckDestroyed();
		if (!StartPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:StartPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPlay_FunctionAddress, argsSize: StartPlay_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:SpawnDefaultPawnFor")]
	public unsafe APawn SpawnDefaultPawnFor(AController NewPlayer, AActor StartSpot)
	{
		CheckDestroyed();
		if (!SpawnDefaultPawnFor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:SpawnDefaultPawnFor");
			return null;
		}
		if (SpawnDefaultPawnFor_InstanceFunctionAddress == IntPtr.Zero)
		{
			SpawnDefaultPawnFor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SpawnDefaultPawnFor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnDefaultPawnFor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnDefaultPawnFor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnFor_NewPlayer_Offset), 0, SpawnDefaultPawnFor_NewPlayer_PropertyAddress.Address, NewPlayer);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnFor_StartSpot_Offset), 0, SpawnDefaultPawnFor_StartSpot_PropertyAddress.Address, StartSpot);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnDefaultPawnFor_InstanceFunctionAddress, intPtr, SpawnDefaultPawnFor_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, SpawnDefaultPawnFor_ReturnValue_Offset), 0, SpawnDefaultPawnFor_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual APawn SpawnDefaultPawnFor_Implementation(AController NewPlayer, AActor StartSpot)
	{
		CheckDestroyed();
		if (!SpawnDefaultPawnFor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:SpawnDefaultPawnFor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnDefaultPawnFor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnDefaultPawnFor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnFor_NewPlayer_Offset), 0, SpawnDefaultPawnFor_NewPlayer_PropertyAddress.Address, NewPlayer);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnFor_StartSpot_Offset), 0, SpawnDefaultPawnFor_StartSpot_PropertyAddress.Address, StartSpot);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnDefaultPawnFor_FunctionAddress, intPtr, SpawnDefaultPawnFor_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, SpawnDefaultPawnFor_ReturnValue_Offset), 0, SpawnDefaultPawnFor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 146934784u)]
	[UMetaPath("/Script/Engine.GameModeBase:SpawnDefaultPawnAtTransform")]
	public unsafe APawn SpawnDefaultPawnAtTransform(AController NewPlayer, FTransform SpawnTransform)
	{
		CheckDestroyed();
		if (!SpawnDefaultPawnAtTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:SpawnDefaultPawnAtTransform");
			return null;
		}
		if (SpawnDefaultPawnAtTransform_InstanceFunctionAddress == IntPtr.Zero)
		{
			SpawnDefaultPawnAtTransform_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SpawnDefaultPawnAtTransform");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnDefaultPawnAtTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnDefaultPawnAtTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnAtTransform_NewPlayer_Offset), 0, SpawnDefaultPawnAtTransform_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InitializeValue_InContainer(SpawnDefaultPawnAtTransform_SpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnAtTransform_SpawnTransform_Offset), 0, SpawnDefaultPawnAtTransform_SpawnTransform_PropertyAddress.Address, SpawnTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnDefaultPawnAtTransform_InstanceFunctionAddress, intPtr, SpawnDefaultPawnAtTransform_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, SpawnDefaultPawnAtTransform_ReturnValue_Offset), 0, SpawnDefaultPawnAtTransform_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual APawn SpawnDefaultPawnAtTransform_Implementation(AController NewPlayer, FTransform SpawnTransform)
	{
		CheckDestroyed();
		if (!SpawnDefaultPawnAtTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:SpawnDefaultPawnAtTransform");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnDefaultPawnAtTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnDefaultPawnAtTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnAtTransform_NewPlayer_Offset), 0, SpawnDefaultPawnAtTransform_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InitializeValue_InContainer(SpawnDefaultPawnAtTransform_SpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SpawnDefaultPawnAtTransform_SpawnTransform_Offset), 0, SpawnDefaultPawnAtTransform_SpawnTransform_PropertyAddress.Address, SpawnTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnDefaultPawnAtTransform_FunctionAddress, intPtr, SpawnDefaultPawnAtTransform_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, SpawnDefaultPawnAtTransform_ReturnValue_Offset), 0, SpawnDefaultPawnAtTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:ShouldReset")]
	public unsafe bool ShouldReset(AActor ActorToReset)
	{
		CheckDestroyed();
		if (!ShouldReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ShouldReset");
			return false;
		}
		if (ShouldReset_InstanceFunctionAddress == IntPtr.Zero)
		{
			ShouldReset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ShouldReset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldReset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ShouldReset_ActorToReset_Offset), 0, ShouldReset_ActorToReset_PropertyAddress.Address, ActorToReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldReset_InstanceFunctionAddress, intPtr, ShouldReset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldReset_ReturnValue_Offset), 0, ShouldReset_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ShouldReset_Implementation(AActor ActorToReset)
	{
		CheckDestroyed();
		if (!ShouldReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ShouldReset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldReset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ShouldReset_ActorToReset_Offset), 0, ShouldReset_ActorToReset_PropertyAddress.Address, ActorToReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldReset_FunctionAddress, intPtr, ShouldReset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldReset_ReturnValue_Offset), 0, ShouldReset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:ReturnToMainMenuHost")]
	public unsafe void ReturnToMainMenuHost()
	{
		CheckDestroyed();
		if (!ReturnToMainMenuHost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ReturnToMainMenuHost");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReturnToMainMenuHost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReturnToMainMenuHost_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReturnToMainMenuHost_FunctionAddress, argsSize: ReturnToMainMenuHost_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.GameModeBase:RestartPlayerAtTransform")]
	public unsafe void RestartPlayerAtTransform(AController NewPlayer, FTransform SpawnTransform)
	{
		CheckDestroyed();
		if (!RestartPlayerAtTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:RestartPlayerAtTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartPlayerAtTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartPlayerAtTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, RestartPlayerAtTransform_NewPlayer_Offset), 0, RestartPlayerAtTransform_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InitializeValue_InContainer(RestartPlayerAtTransform_SpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, RestartPlayerAtTransform_SpawnTransform_Offset), 0, RestartPlayerAtTransform_SpawnTransform_PropertyAddress.Address, SpawnTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestartPlayerAtTransform_FunctionAddress, intPtr, RestartPlayerAtTransform_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:RestartPlayerAtPlayerStart")]
	public unsafe void RestartPlayerAtPlayerStart(AController NewPlayer, AActor StartSpot)
	{
		CheckDestroyed();
		if (!RestartPlayerAtPlayerStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:RestartPlayerAtPlayerStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartPlayerAtPlayerStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartPlayerAtPlayerStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, RestartPlayerAtPlayerStart_NewPlayer_Offset), 0, RestartPlayerAtPlayerStart_NewPlayer_PropertyAddress.Address, NewPlayer);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RestartPlayerAtPlayerStart_StartSpot_Offset), 0, RestartPlayerAtPlayerStart_StartSpot_PropertyAddress.Address, StartSpot);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestartPlayerAtPlayerStart_FunctionAddress, intPtr, RestartPlayerAtPlayerStart_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:RestartPlayer")]
	public unsafe void RestartPlayer(AController NewPlayer)
	{
		CheckDestroyed();
		if (!RestartPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:RestartPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, RestartPlayer_NewPlayer_Offset), 0, RestartPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestartPlayer_FunctionAddress, intPtr, RestartPlayer_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:ResetLevel")]
	public unsafe void ResetLevel()
	{
		CheckDestroyed();
		if (!ResetLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ResetLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetLevel_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetLevel_FunctionAddress, argsSize: ResetLevel_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/Engine.GameModeBase:PlayerCanRestart")]
	public unsafe bool PlayerCanRestart(APlayerController Player)
	{
		CheckDestroyed();
		if (!PlayerCanRestart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:PlayerCanRestart");
			return false;
		}
		if (PlayerCanRestart_InstanceFunctionAddress == IntPtr.Zero)
		{
			PlayerCanRestart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PlayerCanRestart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayerCanRestart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayerCanRestart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, PlayerCanRestart_Player_Offset), 0, PlayerCanRestart_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayerCanRestart_InstanceFunctionAddress, intPtr, PlayerCanRestart_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PlayerCanRestart_ReturnValue_Offset), 0, PlayerCanRestart_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool PlayerCanRestart_Implementation(APlayerController Player)
	{
		CheckDestroyed();
		if (!PlayerCanRestart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:PlayerCanRestart");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayerCanRestart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayerCanRestart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, PlayerCanRestart_Player_Offset), 0, PlayerCanRestart_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayerCanRestart_FunctionAddress, intPtr, PlayerCanRestart_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PlayerCanRestart_ReturnValue_Offset), 0, PlayerCanRestart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.GameModeBase:MustSpectate")]
	public unsafe bool MustSpectate(APlayerController NewPlayerController)
	{
		CheckDestroyed();
		if (!MustSpectate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:MustSpectate");
			return false;
		}
		if (MustSpectate_InstanceFunctionAddress == IntPtr.Zero)
		{
			MustSpectate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "MustSpectate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(MustSpectate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MustSpectate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, MustSpectate_NewPlayerController_Offset), 0, MustSpectate_NewPlayerController_PropertyAddress.Address, NewPlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, MustSpectate_InstanceFunctionAddress, intPtr, MustSpectate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MustSpectate_ReturnValue_Offset), 0, MustSpectate_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool MustSpectate_Implementation(APlayerController NewPlayerController)
	{
		CheckDestroyed();
		if (!MustSpectate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:MustSpectate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MustSpectate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MustSpectate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, MustSpectate_NewPlayerController_Offset), 0, MustSpectate_NewPlayerController_PropertyAddress.Address, NewPlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, MustSpectate_FunctionAddress, intPtr, MustSpectate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MustSpectate_ReturnValue_Offset), 0, MustSpectate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_PostLogin")]
	[UMetaPath("/Script/Engine.GameModeBase:K2_PostLogin")]
	public unsafe void OnPostLogin(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!OnPostLogin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_PostLogin");
			return;
		}
		if (OnPostLogin_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostLogin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_PostLogin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostLogin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostLogin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnPostLogin_NewPlayer_Offset), 0, OnPostLogin_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostLogin_InstanceFunctionAddress, intPtr, OnPostLogin_ParamsSize);
	}

	protected unsafe virtual void OnPostLogin_Implementation(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!OnPostLogin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_PostLogin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostLogin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostLogin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnPostLogin_NewPlayer_Offset), 0, OnPostLogin_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostLogin_FunctionAddress, intPtr, OnPostLogin_ParamsSize);
	}

	[UFunction(Flags = 134744064u, OriginalName = "K2_OnSwapPlayerControllers")]
	[UMetaPath("/Script/Engine.GameModeBase:K2_OnSwapPlayerControllers")]
	protected unsafe void OnSwapPlayerControllers(APlayerController OldPC, APlayerController NewPC)
	{
		CheckDestroyed();
		if (!OnSwapPlayerControllers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnSwapPlayerControllers");
			return;
		}
		if (OnSwapPlayerControllers_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSwapPlayerControllers_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnSwapPlayerControllers");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSwapPlayerControllers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSwapPlayerControllers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnSwapPlayerControllers_OldPC_Offset), 0, OnSwapPlayerControllers_OldPC_PropertyAddress.Address, OldPC);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnSwapPlayerControllers_NewPC_Offset), 0, OnSwapPlayerControllers_NewPC_PropertyAddress.Address, NewPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSwapPlayerControllers_InstanceFunctionAddress, intPtr, OnSwapPlayerControllers_ParamsSize);
	}

	protected unsafe virtual void OnSwapPlayerControllers_Implementation(APlayerController OldPC, APlayerController NewPC)
	{
		CheckDestroyed();
		if (!OnSwapPlayerControllers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnSwapPlayerControllers");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSwapPlayerControllers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSwapPlayerControllers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnSwapPlayerControllers_OldPC_Offset), 0, OnSwapPlayerControllers_OldPC_PropertyAddress.Address, OldPC);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnSwapPlayerControllers_NewPC_Offset), 0, OnSwapPlayerControllers_NewPC_PropertyAddress.Address, NewPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSwapPlayerControllers_FunctionAddress, intPtr, OnSwapPlayerControllers_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnRestartPlayer")]
	[UMetaPath("/Script/Engine.GameModeBase:K2_OnRestartPlayer")]
	public unsafe void OnRestartPlayer(AController NewPlayer)
	{
		CheckDestroyed();
		if (!OnRestartPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnRestartPlayer");
			return;
		}
		if (OnRestartPlayer_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRestartPlayer_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnRestartPlayer");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRestartPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRestartPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnRestartPlayer_NewPlayer_Offset), 0, OnRestartPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRestartPlayer_InstanceFunctionAddress, intPtr, OnRestartPlayer_ParamsSize);
	}

	protected unsafe virtual void OnRestartPlayer_Implementation(AController NewPlayer)
	{
		CheckDestroyed();
		if (!OnRestartPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnRestartPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRestartPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRestartPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnRestartPlayer_NewPlayer_Offset), 0, OnRestartPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRestartPlayer_FunctionAddress, intPtr, OnRestartPlayer_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnLogout")]
	[UMetaPath("/Script/Engine.GameModeBase:K2_OnLogout")]
	public unsafe void OnLogout(AController ExitingController)
	{
		CheckDestroyed();
		if (!OnLogout_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnLogout");
			return;
		}
		if (OnLogout_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLogout_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnLogout");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLogout_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLogout_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnLogout_ExitingController_Offset), 0, OnLogout_ExitingController_PropertyAddress.Address, ExitingController);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLogout_InstanceFunctionAddress, intPtr, OnLogout_ParamsSize);
	}

	protected unsafe virtual void OnLogout_Implementation(AController ExitingController)
	{
		CheckDestroyed();
		if (!OnLogout_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnLogout");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLogout_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLogout_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnLogout_ExitingController_Offset), 0, OnLogout_ExitingController_PropertyAddress.Address, ExitingController);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLogout_FunctionAddress, intPtr, OnLogout_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnChangeName")]
	[UMetaPath("/Script/Engine.GameModeBase:K2_OnChangeName")]
	public unsafe void OnChangeName(AController Other, string NewName, bool bNameChange)
	{
		CheckDestroyed();
		if (!OnChangeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnChangeName");
			return;
		}
		if (OnChangeName_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnChangeName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnChangeName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnChangeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChangeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnChangeName_Other_Offset), 0, OnChangeName_Other_PropertyAddress.Address, Other);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnChangeName_NewName_Offset), 0, OnChangeName_NewName_PropertyAddress.Address, NewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnChangeName_bNameChange_Offset), 0, OnChangeName_bNameChange_PropertyAddress.Address, bNameChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnChangeName_InstanceFunctionAddress, intPtr, OnChangeName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnChangeName_NewName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnChangeName_Implementation(AController Other, string NewName, bool bNameChange)
	{
		CheckDestroyed();
		if (!OnChangeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_OnChangeName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnChangeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChangeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnChangeName_Other_Offset), 0, OnChangeName_Other_PropertyAddress.Address, Other);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnChangeName_NewName_Offset), 0, OnChangeName_NewName_PropertyAddress.Address, NewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnChangeName_bNameChange_Offset), 0, OnChangeName_bNameChange_PropertyAddress.Address, bNameChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnChangeName_FunctionAddress, intPtr, OnChangeName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnChangeName_NewName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335676417u, OriginalName = "K2_FindPlayerStart")]
	[UMetaPath("/Script/Engine.GameModeBase:K2_FindPlayerStart")]
	public unsafe AActor FindPlayerStart_94A92F01(AController Player, string IncomingName)
	{
		CheckDestroyed();
		if (!FindPlayerStart_94A92F01_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:K2_FindPlayerStart");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPlayerStart_94A92F01_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPlayerStart_94A92F01_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, FindPlayerStart_94A92F01_Player_Offset), 0, FindPlayerStart_94A92F01_Player_PropertyAddress.Address, Player);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPlayerStart_94A92F01_IncomingName_Offset), 0, FindPlayerStart_94A92F01_IncomingName_PropertyAddress.Address, IncomingName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindPlayerStart_94A92F01_FunctionAddress, intPtr, FindPlayerStart_94A92F01_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPlayerStart_94A92F01_IncomingName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, FindPlayerStart_94A92F01_ReturnValue_Offset), 0, FindPlayerStart_94A92F01_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:InitStartSpot")]
	public unsafe void InitStartSpot(AActor StartSpot, AController NewPlayer)
	{
		CheckDestroyed();
		if (!InitStartSpot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:InitStartSpot");
			return;
		}
		if (InitStartSpot_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitStartSpot_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitStartSpot");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitStartSpot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitStartSpot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, InitStartSpot_StartSpot_Offset), 0, InitStartSpot_StartSpot_PropertyAddress.Address, StartSpot);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, InitStartSpot_NewPlayer_Offset), 0, InitStartSpot_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitStartSpot_InstanceFunctionAddress, intPtr, InitStartSpot_ParamsSize);
	}

	protected unsafe virtual void InitStartSpot_Implementation(AActor StartSpot, AController NewPlayer)
	{
		CheckDestroyed();
		if (!InitStartSpot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:InitStartSpot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitStartSpot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitStartSpot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, InitStartSpot_StartSpot_Offset), 0, InitStartSpot_StartSpot_PropertyAddress.Address, StartSpot);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, InitStartSpot_NewPlayer_Offset), 0, InitStartSpot_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitStartSpot_FunctionAddress, intPtr, InitStartSpot_ParamsSize);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/Engine.GameModeBase:InitializeHUDForPlayer")]
	protected unsafe void InitializeHUDForPlayer(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!InitializeHUDForPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:InitializeHUDForPlayer");
			return;
		}
		if (InitializeHUDForPlayer_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitializeHUDForPlayer_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitializeHUDForPlayer");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeHUDForPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeHUDForPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, InitializeHUDForPlayer_NewPlayer_Offset), 0, InitializeHUDForPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeHUDForPlayer_InstanceFunctionAddress, intPtr, InitializeHUDForPlayer_ParamsSize);
	}

	protected unsafe virtual void InitializeHUDForPlayer_Implementation(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!InitializeHUDForPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:InitializeHUDForPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeHUDForPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeHUDForPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, InitializeHUDForPlayer_NewPlayer_Offset), 0, InitializeHUDForPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeHUDForPlayer_FunctionAddress, intPtr, InitializeHUDForPlayer_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameModeBase:HasMatchStarted")]
	public unsafe bool HasMatchStarted()
	{
		CheckDestroyed();
		if (!HasMatchStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:HasMatchStarted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMatchStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMatchStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMatchStarted_FunctionAddress, intPtr, HasMatchStarted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMatchStarted_ReturnValue_Offset), 0, HasMatchStarted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameModeBase:HasMatchEnded")]
	public unsafe bool HasMatchEnded()
	{
		CheckDestroyed();
		if (!HasMatchEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:HasMatchEnded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMatchEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMatchEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMatchEnded_FunctionAddress, intPtr, HasMatchEnded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMatchEnded_ReturnValue_Offset), 0, HasMatchEnded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:HandleStartingNewPlayer")]
	public unsafe void HandleStartingNewPlayer(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!HandleStartingNewPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:HandleStartingNewPlayer");
			return;
		}
		if (HandleStartingNewPlayer_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleStartingNewPlayer_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleStartingNewPlayer");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleStartingNewPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleStartingNewPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, HandleStartingNewPlayer_NewPlayer_Offset), 0, HandleStartingNewPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleStartingNewPlayer_InstanceFunctionAddress, intPtr, HandleStartingNewPlayer_ParamsSize);
	}

	protected unsafe virtual void HandleStartingNewPlayer_Implementation(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!HandleStartingNewPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:HandleStartingNewPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleStartingNewPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleStartingNewPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, HandleStartingNewPlayer_NewPlayer_Offset), 0, HandleStartingNewPlayer_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleStartingNewPlayer_FunctionAddress, intPtr, HandleStartingNewPlayer_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:GetNumSpectators")]
	public unsafe int GetNumSpectators()
	{
		CheckDestroyed();
		if (!GetNumSpectators_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:GetNumSpectators");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumSpectators_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumSpectators_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumSpectators_FunctionAddress, intPtr, GetNumSpectators_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumSpectators_ReturnValue_Offset), 0, GetNumSpectators_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:GetNumPlayers")]
	public unsafe int GetNumPlayers()
	{
		CheckDestroyed();
		if (!GetNumPlayers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:GetNumPlayers");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumPlayers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumPlayers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumPlayers_FunctionAddress, intPtr, GetNumPlayers_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumPlayers_ReturnValue_Offset), 0, GetNumPlayers_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/Engine.GameModeBase:GetDefaultPawnClassForController")]
	public unsafe TSubclassOf<UObject> GetDefaultPawnClassForController(AController InController)
	{
		CheckDestroyed();
		if (!GetDefaultPawnClassForController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:GetDefaultPawnClassForController");
			return default(TSubclassOf<UObject>);
		}
		if (GetDefaultPawnClassForController_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDefaultPawnClassForController_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDefaultPawnClassForController");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultPawnClassForController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultPawnClassForController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetDefaultPawnClassForController_InController_Offset), 0, GetDefaultPawnClassForController_InController_PropertyAddress.Address, InController);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultPawnClassForController_InstanceFunctionAddress, intPtr, GetDefaultPawnClassForController_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetDefaultPawnClassForController_ReturnValue_Offset), 0, GetDefaultPawnClassForController_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UObject> GetDefaultPawnClassForController_Implementation(AController InController)
	{
		CheckDestroyed();
		if (!GetDefaultPawnClassForController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:GetDefaultPawnClassForController");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultPawnClassForController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultPawnClassForController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetDefaultPawnClassForController_InController_Offset), 0, GetDefaultPawnClassForController_InController_PropertyAddress.Address, InController);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultPawnClassForController_FunctionAddress, intPtr, GetDefaultPawnClassForController_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetDefaultPawnClassForController_ReturnValue_Offset), 0, GetDefaultPawnClassForController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:FindPlayerStart")]
	public unsafe AActor FindPlayerStart_8D0CD897(AController Player, string IncomingName)
	{
		CheckDestroyed();
		if (!FindPlayerStart_8D0CD897_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:FindPlayerStart");
			return null;
		}
		if (FindPlayerStart_8D0CD897_InstanceFunctionAddress == IntPtr.Zero)
		{
			FindPlayerStart_8D0CD897_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "FindPlayerStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPlayerStart_8D0CD897_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPlayerStart_8D0CD897_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, FindPlayerStart_8D0CD897_Player_Offset), 0, FindPlayerStart_8D0CD897_Player_PropertyAddress.Address, Player);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPlayerStart_8D0CD897_IncomingName_Offset), 0, FindPlayerStart_8D0CD897_IncomingName_PropertyAddress.Address, IncomingName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindPlayerStart_8D0CD897_InstanceFunctionAddress, intPtr, FindPlayerStart_8D0CD897_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPlayerStart_8D0CD897_IncomingName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, FindPlayerStart_8D0CD897_ReturnValue_Offset), 0, FindPlayerStart_8D0CD897_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual AActor FindPlayerStart_8D0CD897_Implementation(AController Player, string IncomingName)
	{
		CheckDestroyed();
		if (!FindPlayerStart_8D0CD897_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:FindPlayerStart");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPlayerStart_8D0CD897_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPlayerStart_8D0CD897_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, FindPlayerStart_8D0CD897_Player_Offset), 0, FindPlayerStart_8D0CD897_Player_PropertyAddress.Address, Player);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPlayerStart_8D0CD897_IncomingName_Offset), 0, FindPlayerStart_8D0CD897_IncomingName_PropertyAddress.Address, IncomingName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindPlayerStart_8D0CD897_FunctionAddress, intPtr, FindPlayerStart_8D0CD897_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPlayerStart_8D0CD897_IncomingName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, FindPlayerStart_8D0CD897_ReturnValue_Offset), 0, FindPlayerStart_8D0CD897_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:ChoosePlayerStart")]
	public unsafe AActor ChoosePlayerStart(AController Player)
	{
		CheckDestroyed();
		if (!ChoosePlayerStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ChoosePlayerStart");
			return null;
		}
		if (ChoosePlayerStart_InstanceFunctionAddress == IntPtr.Zero)
		{
			ChoosePlayerStart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ChoosePlayerStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChoosePlayerStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChoosePlayerStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ChoosePlayerStart_Player_Offset), 0, ChoosePlayerStart_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChoosePlayerStart_InstanceFunctionAddress, intPtr, ChoosePlayerStart_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, ChoosePlayerStart_ReturnValue_Offset), 0, ChoosePlayerStart_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual AActor ChoosePlayerStart_Implementation(AController Player)
	{
		CheckDestroyed();
		if (!ChoosePlayerStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ChoosePlayerStart");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChoosePlayerStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChoosePlayerStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ChoosePlayerStart_Player_Offset), 0, ChoosePlayerStart_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChoosePlayerStart_FunctionAddress, intPtr, ChoosePlayerStart_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, ChoosePlayerStart_ReturnValue_Offset), 0, ChoosePlayerStart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameModeBase:ChangeName")]
	public unsafe void ChangeName(AController Controller, string NewName, bool bNameChange)
	{
		CheckDestroyed();
		if (!ChangeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:ChangeName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ChangeName_Controller_Offset), 0, ChangeName_Controller_PropertyAddress.Address, Controller);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeName_NewName_Offset), 0, ChangeName_NewName_PropertyAddress.Address, NewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeName_bNameChange_Offset), 0, ChangeName_bNameChange_PropertyAddress.Address, bNameChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChangeName_FunctionAddress, intPtr, ChangeName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ChangeName_NewName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.GameModeBase:CanSpectate")]
	public unsafe bool CanSpectate(APlayerController Viewer, APlayerState ViewTarget)
	{
		CheckDestroyed();
		if (!CanSpectate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:CanSpectate");
			return false;
		}
		if (CanSpectate_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanSpectate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanSpectate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanSpectate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanSpectate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, CanSpectate_Viewer_Offset), 0, CanSpectate_Viewer_PropertyAddress.Address, Viewer);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, CanSpectate_ViewTarget_Offset), 0, CanSpectate_ViewTarget_PropertyAddress.Address, ViewTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanSpectate_InstanceFunctionAddress, intPtr, CanSpectate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanSpectate_ReturnValue_Offset), 0, CanSpectate_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanSpectate_Implementation(APlayerController Viewer, APlayerState ViewTarget)
	{
		CheckDestroyed();
		if (!CanSpectate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameModeBase:CanSpectate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanSpectate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanSpectate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, CanSpectate_Viewer_Offset), 0, CanSpectate_Viewer_PropertyAddress.Address, Viewer);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, CanSpectate_ViewTarget_Offset), 0, CanSpectate_ViewTarget_PropertyAddress.Address, ViewTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanSpectate_FunctionAddress, intPtr, CanSpectate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanSpectate_ReturnValue_Offset), 0, CanSpectate_ReturnValue_PropertyAddress.Address);
	}

	static AGameModeBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGameModeBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGameModeBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.GameModeBase");
		OptionsString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptionsString");
		OptionsString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptionsString", Classes.FStrProperty);
		GameSessionClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameSessionClass");
		GameSessionClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameSessionClass", Classes.FClassProperty);
		GameStateClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameStateClass");
		GameStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameStateClass", Classes.FClassProperty);
		PlayerControllerClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerControllerClass");
		PlayerControllerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerControllerClass", Classes.FClassProperty);
		PlayerStateClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerStateClass");
		PlayerStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerStateClass", Classes.FClassProperty);
		HUDClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HUDClass");
		HUDClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HUDClass", Classes.FClassProperty);
		DefaultPawnClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultPawnClass");
		DefaultPawnClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultPawnClass", Classes.FClassProperty);
		SpectatorClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpectatorClass");
		SpectatorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpectatorClass", Classes.FClassProperty);
		ReplaySpectatorPlayerControllerClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReplaySpectatorPlayerControllerClass");
		ReplaySpectatorPlayerControllerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReplaySpectatorPlayerControllerClass", Classes.FClassProperty);
		ServerStatReplicatorClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ServerStatReplicatorClass");
		ServerStatReplicatorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ServerStatReplicatorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSeamlessTravel_PropertyAddress, intPtr, "bUseSeamlessTravel");
		UseSeamlessTravel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSeamlessTravel");
		UseSeamlessTravel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSeamlessTravel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartPlayersAsSpectators_PropertyAddress, intPtr, "bStartPlayersAsSpectators");
		StartPlayersAsSpectators_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStartPlayersAsSpectators");
		StartPlayersAsSpectators_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStartPlayersAsSpectators", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Pauseable_PropertyAddress, intPtr, "bPauseable");
		Pauseable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPauseable");
		Pauseable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPauseable", Classes.FBoolProperty);
		StartPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartPlay");
		StartPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPlay_FunctionAddress);
		StartPlay_IsValid = StartPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:StartPlay", StartPlay_IsValid);
		SpawnDefaultPawnFor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnDefaultPawnFor");
		SpawnDefaultPawnFor_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnDefaultPawnFor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnDefaultPawnFor_NewPlayer_PropertyAddress, SpawnDefaultPawnFor_FunctionAddress, "NewPlayer");
		SpawnDefaultPawnFor_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(SpawnDefaultPawnFor_FunctionAddress, "NewPlayer");
		SpawnDefaultPawnFor_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnDefaultPawnFor_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnDefaultPawnFor_StartSpot_PropertyAddress, SpawnDefaultPawnFor_FunctionAddress, "StartSpot");
		SpawnDefaultPawnFor_StartSpot_Offset = NativeReflectionCached.GetPropertyOffset(SpawnDefaultPawnFor_FunctionAddress, "StartSpot");
		SpawnDefaultPawnFor_StartSpot_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnDefaultPawnFor_FunctionAddress, "StartSpot", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnDefaultPawnFor_ReturnValue_PropertyAddress, SpawnDefaultPawnFor_FunctionAddress, "ReturnValue");
		SpawnDefaultPawnFor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnDefaultPawnFor_FunctionAddress, "ReturnValue");
		SpawnDefaultPawnFor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnDefaultPawnFor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnDefaultPawnFor_IsValid = SpawnDefaultPawnFor_FunctionAddress != IntPtr.Zero && SpawnDefaultPawnFor_NewPlayer_IsValid && SpawnDefaultPawnFor_StartSpot_IsValid && SpawnDefaultPawnFor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:SpawnDefaultPawnFor", SpawnDefaultPawnFor_IsValid);
		SpawnDefaultPawnAtTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnDefaultPawnAtTransform");
		SpawnDefaultPawnAtTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnDefaultPawnAtTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnDefaultPawnAtTransform_NewPlayer_PropertyAddress, SpawnDefaultPawnAtTransform_FunctionAddress, "NewPlayer");
		SpawnDefaultPawnAtTransform_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(SpawnDefaultPawnAtTransform_FunctionAddress, "NewPlayer");
		SpawnDefaultPawnAtTransform_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnDefaultPawnAtTransform_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnDefaultPawnAtTransform_SpawnTransform_PropertyAddress, SpawnDefaultPawnAtTransform_FunctionAddress, "SpawnTransform");
		SpawnDefaultPawnAtTransform_SpawnTransform_Offset = NativeReflectionCached.GetPropertyOffset(SpawnDefaultPawnAtTransform_FunctionAddress, "SpawnTransform");
		SpawnDefaultPawnAtTransform_SpawnTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnDefaultPawnAtTransform_FunctionAddress, "SpawnTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnDefaultPawnAtTransform_ReturnValue_PropertyAddress, SpawnDefaultPawnAtTransform_FunctionAddress, "ReturnValue");
		SpawnDefaultPawnAtTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnDefaultPawnAtTransform_FunctionAddress, "ReturnValue");
		SpawnDefaultPawnAtTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnDefaultPawnAtTransform_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnDefaultPawnAtTransform_IsValid = SpawnDefaultPawnAtTransform_FunctionAddress != IntPtr.Zero && SpawnDefaultPawnAtTransform_NewPlayer_IsValid && SpawnDefaultPawnAtTransform_SpawnTransform_IsValid && SpawnDefaultPawnAtTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:SpawnDefaultPawnAtTransform", SpawnDefaultPawnAtTransform_IsValid);
		ShouldReset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldReset");
		ShouldReset_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldReset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldReset_ActorToReset_PropertyAddress, ShouldReset_FunctionAddress, "ActorToReset");
		ShouldReset_ActorToReset_Offset = NativeReflectionCached.GetPropertyOffset(ShouldReset_FunctionAddress, "ActorToReset");
		ShouldReset_ActorToReset_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldReset_FunctionAddress, "ActorToReset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldReset_ReturnValue_PropertyAddress, ShouldReset_FunctionAddress, "ReturnValue");
		ShouldReset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldReset_FunctionAddress, "ReturnValue");
		ShouldReset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldReset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldReset_IsValid = ShouldReset_FunctionAddress != IntPtr.Zero && ShouldReset_ActorToReset_IsValid && ShouldReset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:ShouldReset", ShouldReset_IsValid);
		ReturnToMainMenuHost_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReturnToMainMenuHost");
		ReturnToMainMenuHost_ParamsSize = NativeReflection.GetFunctionParamsSize(ReturnToMainMenuHost_FunctionAddress);
		ReturnToMainMenuHost_IsValid = ReturnToMainMenuHost_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:ReturnToMainMenuHost", ReturnToMainMenuHost_IsValid);
		RestartPlayerAtTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestartPlayerAtTransform");
		RestartPlayerAtTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartPlayerAtTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestartPlayerAtTransform_NewPlayer_PropertyAddress, RestartPlayerAtTransform_FunctionAddress, "NewPlayer");
		RestartPlayerAtTransform_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(RestartPlayerAtTransform_FunctionAddress, "NewPlayer");
		RestartPlayerAtTransform_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartPlayerAtTransform_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RestartPlayerAtTransform_SpawnTransform_PropertyAddress, RestartPlayerAtTransform_FunctionAddress, "SpawnTransform");
		RestartPlayerAtTransform_SpawnTransform_Offset = NativeReflectionCached.GetPropertyOffset(RestartPlayerAtTransform_FunctionAddress, "SpawnTransform");
		RestartPlayerAtTransform_SpawnTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartPlayerAtTransform_FunctionAddress, "SpawnTransform", Classes.FStructProperty);
		RestartPlayerAtTransform_IsValid = RestartPlayerAtTransform_FunctionAddress != IntPtr.Zero && RestartPlayerAtTransform_NewPlayer_IsValid && RestartPlayerAtTransform_SpawnTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:RestartPlayerAtTransform", RestartPlayerAtTransform_IsValid);
		RestartPlayerAtPlayerStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestartPlayerAtPlayerStart");
		RestartPlayerAtPlayerStart_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartPlayerAtPlayerStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestartPlayerAtPlayerStart_NewPlayer_PropertyAddress, RestartPlayerAtPlayerStart_FunctionAddress, "NewPlayer");
		RestartPlayerAtPlayerStart_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(RestartPlayerAtPlayerStart_FunctionAddress, "NewPlayer");
		RestartPlayerAtPlayerStart_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartPlayerAtPlayerStart_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RestartPlayerAtPlayerStart_StartSpot_PropertyAddress, RestartPlayerAtPlayerStart_FunctionAddress, "StartSpot");
		RestartPlayerAtPlayerStart_StartSpot_Offset = NativeReflectionCached.GetPropertyOffset(RestartPlayerAtPlayerStart_FunctionAddress, "StartSpot");
		RestartPlayerAtPlayerStart_StartSpot_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartPlayerAtPlayerStart_FunctionAddress, "StartSpot", Classes.FObjectProperty);
		RestartPlayerAtPlayerStart_IsValid = RestartPlayerAtPlayerStart_FunctionAddress != IntPtr.Zero && RestartPlayerAtPlayerStart_NewPlayer_IsValid && RestartPlayerAtPlayerStart_StartSpot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:RestartPlayerAtPlayerStart", RestartPlayerAtPlayerStart_IsValid);
		RestartPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestartPlayer");
		RestartPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestartPlayer_NewPlayer_PropertyAddress, RestartPlayer_FunctionAddress, "NewPlayer");
		RestartPlayer_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(RestartPlayer_FunctionAddress, "NewPlayer");
		RestartPlayer_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartPlayer_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		RestartPlayer_IsValid = RestartPlayer_FunctionAddress != IntPtr.Zero && RestartPlayer_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:RestartPlayer", RestartPlayer_IsValid);
		ResetLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetLevel");
		ResetLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetLevel_FunctionAddress);
		ResetLevel_IsValid = ResetLevel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:ResetLevel", ResetLevel_IsValid);
		PlayerCanRestart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayerCanRestart");
		PlayerCanRestart_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayerCanRestart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayerCanRestart_Player_PropertyAddress, PlayerCanRestart_FunctionAddress, "Player");
		PlayerCanRestart_Player_Offset = NativeReflectionCached.GetPropertyOffset(PlayerCanRestart_FunctionAddress, "Player");
		PlayerCanRestart_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayerCanRestart_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayerCanRestart_ReturnValue_PropertyAddress, PlayerCanRestart_FunctionAddress, "ReturnValue");
		PlayerCanRestart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayerCanRestart_FunctionAddress, "ReturnValue");
		PlayerCanRestart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayerCanRestart_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PlayerCanRestart_IsValid = PlayerCanRestart_FunctionAddress != IntPtr.Zero && PlayerCanRestart_Player_IsValid && PlayerCanRestart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:PlayerCanRestart", PlayerCanRestart_IsValid);
		MustSpectate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MustSpectate");
		MustSpectate_ParamsSize = NativeReflection.GetFunctionParamsSize(MustSpectate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MustSpectate_NewPlayerController_PropertyAddress, MustSpectate_FunctionAddress, "NewPlayerController");
		MustSpectate_NewPlayerController_Offset = NativeReflectionCached.GetPropertyOffset(MustSpectate_FunctionAddress, "NewPlayerController");
		MustSpectate_NewPlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(MustSpectate_FunctionAddress, "NewPlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MustSpectate_ReturnValue_PropertyAddress, MustSpectate_FunctionAddress, "ReturnValue");
		MustSpectate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MustSpectate_FunctionAddress, "ReturnValue");
		MustSpectate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MustSpectate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MustSpectate_IsValid = MustSpectate_FunctionAddress != IntPtr.Zero && MustSpectate_NewPlayerController_IsValid && MustSpectate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:MustSpectate", MustSpectate_IsValid);
		OnPostLogin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_PostLogin");
		OnPostLogin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostLogin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostLogin_NewPlayer_PropertyAddress, OnPostLogin_FunctionAddress, "NewPlayer");
		OnPostLogin_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(OnPostLogin_FunctionAddress, "NewPlayer");
		OnPostLogin_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostLogin_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		OnPostLogin_IsValid = OnPostLogin_FunctionAddress != IntPtr.Zero && OnPostLogin_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:K2_PostLogin", OnPostLogin_IsValid);
		OnSwapPlayerControllers_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnSwapPlayerControllers");
		OnSwapPlayerControllers_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSwapPlayerControllers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSwapPlayerControllers_OldPC_PropertyAddress, OnSwapPlayerControllers_FunctionAddress, "OldPC");
		OnSwapPlayerControllers_OldPC_Offset = NativeReflectionCached.GetPropertyOffset(OnSwapPlayerControllers_FunctionAddress, "OldPC");
		OnSwapPlayerControllers_OldPC_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSwapPlayerControllers_FunctionAddress, "OldPC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnSwapPlayerControllers_NewPC_PropertyAddress, OnSwapPlayerControllers_FunctionAddress, "NewPC");
		OnSwapPlayerControllers_NewPC_Offset = NativeReflectionCached.GetPropertyOffset(OnSwapPlayerControllers_FunctionAddress, "NewPC");
		OnSwapPlayerControllers_NewPC_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSwapPlayerControllers_FunctionAddress, "NewPC", Classes.FObjectProperty);
		OnSwapPlayerControllers_IsValid = OnSwapPlayerControllers_FunctionAddress != IntPtr.Zero && OnSwapPlayerControllers_OldPC_IsValid && OnSwapPlayerControllers_NewPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:K2_OnSwapPlayerControllers", OnSwapPlayerControllers_IsValid);
		OnRestartPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnRestartPlayer");
		OnRestartPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRestartPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRestartPlayer_NewPlayer_PropertyAddress, OnRestartPlayer_FunctionAddress, "NewPlayer");
		OnRestartPlayer_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(OnRestartPlayer_FunctionAddress, "NewPlayer");
		OnRestartPlayer_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRestartPlayer_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		OnRestartPlayer_IsValid = OnRestartPlayer_FunctionAddress != IntPtr.Zero && OnRestartPlayer_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:K2_OnRestartPlayer", OnRestartPlayer_IsValid);
		OnLogout_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnLogout");
		OnLogout_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLogout_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLogout_ExitingController_PropertyAddress, OnLogout_FunctionAddress, "ExitingController");
		OnLogout_ExitingController_Offset = NativeReflectionCached.GetPropertyOffset(OnLogout_FunctionAddress, "ExitingController");
		OnLogout_ExitingController_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLogout_FunctionAddress, "ExitingController", Classes.FObjectProperty);
		OnLogout_IsValid = OnLogout_FunctionAddress != IntPtr.Zero && OnLogout_ExitingController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:K2_OnLogout", OnLogout_IsValid);
		OnChangeName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnChangeName");
		OnChangeName_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChangeName_Other_PropertyAddress, OnChangeName_FunctionAddress, "Other");
		OnChangeName_Other_Offset = NativeReflectionCached.GetPropertyOffset(OnChangeName_FunctionAddress, "Other");
		OnChangeName_Other_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChangeName_FunctionAddress, "Other", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnChangeName_NewName_PropertyAddress, OnChangeName_FunctionAddress, "NewName");
		OnChangeName_NewName_Offset = NativeReflectionCached.GetPropertyOffset(OnChangeName_FunctionAddress, "NewName");
		OnChangeName_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChangeName_FunctionAddress, "NewName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnChangeName_bNameChange_PropertyAddress, OnChangeName_FunctionAddress, "bNameChange");
		OnChangeName_bNameChange_Offset = NativeReflectionCached.GetPropertyOffset(OnChangeName_FunctionAddress, "bNameChange");
		OnChangeName_bNameChange_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChangeName_FunctionAddress, "bNameChange", Classes.FBoolProperty);
		OnChangeName_IsValid = OnChangeName_FunctionAddress != IntPtr.Zero && OnChangeName_Other_IsValid && OnChangeName_NewName_IsValid && OnChangeName_bNameChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:K2_OnChangeName", OnChangeName_IsValid);
		FindPlayerStart_94A92F01_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_FindPlayerStart");
		FindPlayerStart_94A92F01_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPlayerStart_94A92F01_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPlayerStart_94A92F01_Player_PropertyAddress, FindPlayerStart_94A92F01_FunctionAddress, "Player");
		FindPlayerStart_94A92F01_Player_Offset = NativeReflectionCached.GetPropertyOffset(FindPlayerStart_94A92F01_FunctionAddress, "Player");
		FindPlayerStart_94A92F01_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPlayerStart_94A92F01_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPlayerStart_94A92F01_IncomingName_PropertyAddress, FindPlayerStart_94A92F01_FunctionAddress, "IncomingName");
		FindPlayerStart_94A92F01_IncomingName_Offset = NativeReflectionCached.GetPropertyOffset(FindPlayerStart_94A92F01_FunctionAddress, "IncomingName");
		FindPlayerStart_94A92F01_IncomingName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPlayerStart_94A92F01_FunctionAddress, "IncomingName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPlayerStart_94A92F01_ReturnValue_PropertyAddress, FindPlayerStart_94A92F01_FunctionAddress, "ReturnValue");
		FindPlayerStart_94A92F01_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPlayerStart_94A92F01_FunctionAddress, "ReturnValue");
		FindPlayerStart_94A92F01_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPlayerStart_94A92F01_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindPlayerStart_94A92F01_IsValid = FindPlayerStart_94A92F01_FunctionAddress != IntPtr.Zero && FindPlayerStart_94A92F01_Player_IsValid && FindPlayerStart_94A92F01_IncomingName_IsValid && FindPlayerStart_94A92F01_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:K2_FindPlayerStart", FindPlayerStart_94A92F01_IsValid);
		InitStartSpot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitStartSpot");
		InitStartSpot_ParamsSize = NativeReflection.GetFunctionParamsSize(InitStartSpot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitStartSpot_StartSpot_PropertyAddress, InitStartSpot_FunctionAddress, "StartSpot");
		InitStartSpot_StartSpot_Offset = NativeReflectionCached.GetPropertyOffset(InitStartSpot_FunctionAddress, "StartSpot");
		InitStartSpot_StartSpot_IsValid = NativeReflectionCached.ValidatePropertyClass(InitStartSpot_FunctionAddress, "StartSpot", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitStartSpot_NewPlayer_PropertyAddress, InitStartSpot_FunctionAddress, "NewPlayer");
		InitStartSpot_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(InitStartSpot_FunctionAddress, "NewPlayer");
		InitStartSpot_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(InitStartSpot_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		InitStartSpot_IsValid = InitStartSpot_FunctionAddress != IntPtr.Zero && InitStartSpot_StartSpot_IsValid && InitStartSpot_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:InitStartSpot", InitStartSpot_IsValid);
		InitializeHUDForPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitializeHUDForPlayer");
		InitializeHUDForPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeHUDForPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeHUDForPlayer_NewPlayer_PropertyAddress, InitializeHUDForPlayer_FunctionAddress, "NewPlayer");
		InitializeHUDForPlayer_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(InitializeHUDForPlayer_FunctionAddress, "NewPlayer");
		InitializeHUDForPlayer_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeHUDForPlayer_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		InitializeHUDForPlayer_IsValid = InitializeHUDForPlayer_FunctionAddress != IntPtr.Zero && InitializeHUDForPlayer_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:InitializeHUDForPlayer", InitializeHUDForPlayer_IsValid);
		HasMatchStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMatchStarted");
		HasMatchStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMatchStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMatchStarted_ReturnValue_PropertyAddress, HasMatchStarted_FunctionAddress, "ReturnValue");
		HasMatchStarted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMatchStarted_FunctionAddress, "ReturnValue");
		HasMatchStarted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMatchStarted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMatchStarted_IsValid = HasMatchStarted_FunctionAddress != IntPtr.Zero && HasMatchStarted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:HasMatchStarted", HasMatchStarted_IsValid);
		HasMatchEnded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMatchEnded");
		HasMatchEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMatchEnded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMatchEnded_ReturnValue_PropertyAddress, HasMatchEnded_FunctionAddress, "ReturnValue");
		HasMatchEnded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMatchEnded_FunctionAddress, "ReturnValue");
		HasMatchEnded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMatchEnded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMatchEnded_IsValid = HasMatchEnded_FunctionAddress != IntPtr.Zero && HasMatchEnded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:HasMatchEnded", HasMatchEnded_IsValid);
		HandleStartingNewPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleStartingNewPlayer");
		HandleStartingNewPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleStartingNewPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleStartingNewPlayer_NewPlayer_PropertyAddress, HandleStartingNewPlayer_FunctionAddress, "NewPlayer");
		HandleStartingNewPlayer_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(HandleStartingNewPlayer_FunctionAddress, "NewPlayer");
		HandleStartingNewPlayer_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleStartingNewPlayer_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		HandleStartingNewPlayer_IsValid = HandleStartingNewPlayer_FunctionAddress != IntPtr.Zero && HandleStartingNewPlayer_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:HandleStartingNewPlayer", HandleStartingNewPlayer_IsValid);
		GetNumSpectators_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumSpectators");
		GetNumSpectators_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumSpectators_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumSpectators_ReturnValue_PropertyAddress, GetNumSpectators_FunctionAddress, "ReturnValue");
		GetNumSpectators_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSpectators_FunctionAddress, "ReturnValue");
		GetNumSpectators_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSpectators_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumSpectators_IsValid = GetNumSpectators_FunctionAddress != IntPtr.Zero && GetNumSpectators_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:GetNumSpectators", GetNumSpectators_IsValid);
		GetNumPlayers_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumPlayers");
		GetNumPlayers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumPlayers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumPlayers_ReturnValue_PropertyAddress, GetNumPlayers_FunctionAddress, "ReturnValue");
		GetNumPlayers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPlayers_FunctionAddress, "ReturnValue");
		GetNumPlayers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPlayers_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumPlayers_IsValid = GetNumPlayers_FunctionAddress != IntPtr.Zero && GetNumPlayers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:GetNumPlayers", GetNumPlayers_IsValid);
		GetDefaultPawnClassForController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultPawnClassForController");
		GetDefaultPawnClassForController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultPawnClassForController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultPawnClassForController_InController_PropertyAddress, GetDefaultPawnClassForController_FunctionAddress, "InController");
		GetDefaultPawnClassForController_InController_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultPawnClassForController_FunctionAddress, "InController");
		GetDefaultPawnClassForController_InController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultPawnClassForController_FunctionAddress, "InController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultPawnClassForController_ReturnValue_PropertyAddress, GetDefaultPawnClassForController_FunctionAddress, "ReturnValue");
		GetDefaultPawnClassForController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultPawnClassForController_FunctionAddress, "ReturnValue");
		GetDefaultPawnClassForController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultPawnClassForController_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetDefaultPawnClassForController_IsValid = GetDefaultPawnClassForController_FunctionAddress != IntPtr.Zero && GetDefaultPawnClassForController_InController_IsValid && GetDefaultPawnClassForController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:GetDefaultPawnClassForController", GetDefaultPawnClassForController_IsValid);
		FindPlayerStart_8D0CD897_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindPlayerStart");
		FindPlayerStart_8D0CD897_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPlayerStart_8D0CD897_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPlayerStart_8D0CD897_Player_PropertyAddress, FindPlayerStart_8D0CD897_FunctionAddress, "Player");
		FindPlayerStart_8D0CD897_Player_Offset = NativeReflectionCached.GetPropertyOffset(FindPlayerStart_8D0CD897_FunctionAddress, "Player");
		FindPlayerStart_8D0CD897_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPlayerStart_8D0CD897_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPlayerStart_8D0CD897_IncomingName_PropertyAddress, FindPlayerStart_8D0CD897_FunctionAddress, "IncomingName");
		FindPlayerStart_8D0CD897_IncomingName_Offset = NativeReflectionCached.GetPropertyOffset(FindPlayerStart_8D0CD897_FunctionAddress, "IncomingName");
		FindPlayerStart_8D0CD897_IncomingName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPlayerStart_8D0CD897_FunctionAddress, "IncomingName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPlayerStart_8D0CD897_ReturnValue_PropertyAddress, FindPlayerStart_8D0CD897_FunctionAddress, "ReturnValue");
		FindPlayerStart_8D0CD897_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPlayerStart_8D0CD897_FunctionAddress, "ReturnValue");
		FindPlayerStart_8D0CD897_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPlayerStart_8D0CD897_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindPlayerStart_8D0CD897_IsValid = FindPlayerStart_8D0CD897_FunctionAddress != IntPtr.Zero && FindPlayerStart_8D0CD897_Player_IsValid && FindPlayerStart_8D0CD897_IncomingName_IsValid && FindPlayerStart_8D0CD897_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:FindPlayerStart", FindPlayerStart_8D0CD897_IsValid);
		ChoosePlayerStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChoosePlayerStart");
		ChoosePlayerStart_ParamsSize = NativeReflection.GetFunctionParamsSize(ChoosePlayerStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChoosePlayerStart_Player_PropertyAddress, ChoosePlayerStart_FunctionAddress, "Player");
		ChoosePlayerStart_Player_Offset = NativeReflectionCached.GetPropertyOffset(ChoosePlayerStart_FunctionAddress, "Player");
		ChoosePlayerStart_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(ChoosePlayerStart_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ChoosePlayerStart_ReturnValue_PropertyAddress, ChoosePlayerStart_FunctionAddress, "ReturnValue");
		ChoosePlayerStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ChoosePlayerStart_FunctionAddress, "ReturnValue");
		ChoosePlayerStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChoosePlayerStart_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ChoosePlayerStart_IsValid = ChoosePlayerStart_FunctionAddress != IntPtr.Zero && ChoosePlayerStart_Player_IsValid && ChoosePlayerStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:ChoosePlayerStart", ChoosePlayerStart_IsValid);
		ChangeName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangeName");
		ChangeName_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeName_Controller_PropertyAddress, ChangeName_FunctionAddress, "Controller");
		ChangeName_Controller_Offset = NativeReflectionCached.GetPropertyOffset(ChangeName_FunctionAddress, "Controller");
		ChangeName_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeName_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeName_NewName_PropertyAddress, ChangeName_FunctionAddress, "NewName");
		ChangeName_NewName_Offset = NativeReflectionCached.GetPropertyOffset(ChangeName_FunctionAddress, "NewName");
		ChangeName_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeName_FunctionAddress, "NewName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeName_bNameChange_PropertyAddress, ChangeName_FunctionAddress, "bNameChange");
		ChangeName_bNameChange_Offset = NativeReflectionCached.GetPropertyOffset(ChangeName_FunctionAddress, "bNameChange");
		ChangeName_bNameChange_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeName_FunctionAddress, "bNameChange", Classes.FBoolProperty);
		ChangeName_IsValid = ChangeName_FunctionAddress != IntPtr.Zero && ChangeName_Controller_IsValid && ChangeName_NewName_IsValid && ChangeName_bNameChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:ChangeName", ChangeName_IsValid);
		CanSpectate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanSpectate");
		CanSpectate_ParamsSize = NativeReflection.GetFunctionParamsSize(CanSpectate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanSpectate_Viewer_PropertyAddress, CanSpectate_FunctionAddress, "Viewer");
		CanSpectate_Viewer_Offset = NativeReflectionCached.GetPropertyOffset(CanSpectate_FunctionAddress, "Viewer");
		CanSpectate_Viewer_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSpectate_FunctionAddress, "Viewer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSpectate_ViewTarget_PropertyAddress, CanSpectate_FunctionAddress, "ViewTarget");
		CanSpectate_ViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(CanSpectate_FunctionAddress, "ViewTarget");
		CanSpectate_ViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSpectate_FunctionAddress, "ViewTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSpectate_ReturnValue_PropertyAddress, CanSpectate_FunctionAddress, "ReturnValue");
		CanSpectate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanSpectate_FunctionAddress, "ReturnValue");
		CanSpectate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSpectate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanSpectate_IsValid = CanSpectate_FunctionAddress != IntPtr.Zero && CanSpectate_Viewer_IsValid && CanSpectate_ViewTarget_IsValid && CanSpectate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameModeBase:CanSpectate", CanSpectate_IsValid);
	}
}
