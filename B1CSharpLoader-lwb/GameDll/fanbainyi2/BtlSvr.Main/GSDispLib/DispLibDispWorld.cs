using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.DispLibDispWorld")]
public class DispLibDispWorld : DispLibEntityBase
{
	protected static Dictionary<AGameStateBase, DispLibDispWorld> s_instance;

	public static FName MasterComp;

	public static FName NonTag;

	private static bool WEFMManager_IsValid;

	private static int WEFMManager_Offset;

	private static bool WEFM_VisualDebugFX_IsValid;

	private static int WEFM_VisualDebugFX_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLibDispWorld:WEFMManager")]
	public UNiagaraComponent WEFMManager
	{
		get
		{
			CheckDestroyed();
			if (!WEFMManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibDispWorld:WEFMManager");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, WEFMManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFMManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibDispWorld:WEFMManager");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, WEFMManager_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLibDispWorld:WEFM_VisualDebugFX")]
	public UNiagaraComponent WEFM_VisualDebugFX
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_VisualDebugFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibDispWorld:WEFM_VisualDebugFX");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, WEFM_VisualDebugFX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_VisualDebugFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibDispWorld:WEFM_VisualDebugFX");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, WEFM_VisualDebugFX_Offset), value);
			}
		}
	}

	public override int ECSArcheType => 11;

	public static DispLibDispWorld GetInstance(UObject WorldCtx)
	{
		if (WorldCtx.IsNullOrDestroyed())
		{
			return null;
		}
		if (UGameplayStatics.GetGameInstance(WorldCtx) == null)
		{
			return null;
		}
		AGameStateBase gameState = UEngine.GEngine.GetWorldFromContextObject(WorldCtx).GetGameState();
		if (!s_instance.TryGetValue(gameState, out var value))
		{
			return null;
		}
		if (value.IsNullOrDestroyed())
		{
			s_instance.Remove(gameState);
			return null;
		}
		return value;
	}

	public static DispLibPlayingEnv GetPlayingEnv(AActor Actor)
	{
		return DispLibPlayingEnv.Real;
	}

	public static DispLibDispWorld InstanceInit(UObject WorldContext)
	{
		AGameStateBase key = UEngine.GEngine.GetWorldFromContextObject(WorldContext)?.GetGameState();
		s_instance.TryGetValue(key, out var value);
		if (!value.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[DispLib] Multi Init DLDWorld");
			BGU_UnrealWorldUtil.DestroyActor(value);
		}
		if (BGW_DispLibGameDB.GameDBDataAsset.IsNullOrDestroyed())
		{
			return null;
		}
		if (BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.IsNullOrDestroyed() || BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DLDWorld_BP == default(TSubclassOf<DispLibDispWorld>))
		{
			return null;
		}
		DispLibDispWorld dispLibDispWorld = BGU_UnrealWorldUtil.SpawnActor(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DLDWorld_BP.Value) as DispLibDispWorld;
		if (dispLibDispWorld != null)
		{
			dispLibDispWorld.Tags.Add(B1GlobalFNames.DispLibWorld);
			dispLibDispWorld.Init();
			s_instance[key] = dispLibDispWorld;
		}
		return dispLibDispWorld;
	}

	private void Init()
	{
		if (!BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.UseWEFM)
		{
			return;
		}
		string currentLevelName = UGameplayStatics.GetCurrentLevelName(this);
		TArrayReadWrite<FName> enableWEFMLevel = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.EnableWEFMLevel;
		bool flag = false;
		for (int i = 0; i < enableWEFMLevel.Count; i++)
		{
			if (enableWEFMLevel[i].PlainName == currentLevelName)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			UNiagaraSystem wEFMManager = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMManager;
			WEFMManager = UNiagaraFunctionLibrary.SpawnSystemAtLocation(this, wEFMManager, FVector.ZeroVector, FRotator.ZeroRotator, FVector.OneVector, bAutoDestroy: false, bAutoActivate: true, ENCPoolMethod.None, bPreCullCheck: false);
			WEFMManager?.SetTickBehavior(ENiagaraTickBehavior.ForceTickFirst);
		}
	}

	private void RespawnCameraEnvFX()
	{
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		if (bGW_ECSWorld == null)
		{
			return;
		}
		BWC_DispLibDispWorldGlobalData bWC_DispLibDispWorldGlobalData = bGW_ECSWorld.GetObject<BWC_DispLibDispWorldGlobalData>(base.ECSEntity);
		if (bWC_DispLibDispWorldGlobalData == null)
		{
			return;
		}
		if (!bWC_DispLibDispWorldGlobalData.CameraEnvFXComp.IsNullOrDestroyed())
		{
			bWC_DispLibDispWorldGlobalData.CameraEnvFXComp.DestroyComponent(this);
		}
		if (BGW_DispLibGameDB.GameDBDataAsset.IsNullOrDestroyed() || BGW_DispLibGameDB.GameDBDataAsset.CameraEnvFXDA.IsNullOrDestroyed() || !BGW_DispLibGameDB.GameDBDataAsset.CameraEnvFXDA.UseCameraEnvFX)
		{
			return;
		}
		string currentLevelName = UGameplayStatics.GetCurrentLevelName(this);
		UNiagaraSystem uNiagaraSystem = null;
		TArrayReadWrite<BUC_DispLibDBC_CameraEnvFXInfo> cameraEnvFXConfig = BGW_DispLibGameDB.GameDBDataAsset.CameraEnvFXDA.CameraEnvFXConfig;
		for (int i = 0; i < cameraEnvFXConfig.Count; i++)
		{
			if (cameraEnvFXConfig[i].LevelName.PlainName == currentLevelName)
			{
				uNiagaraSystem = cameraEnvFXConfig[i].NiagaraSystem;
				break;
			}
		}
		if (!uNiagaraSystem.IsNullOrDestroyed())
		{
			UNiagaraComponent uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAtLocation(this, uNiagaraSystem, FVector.ZeroVector, FRotator.ZeroRotator, FVector.OneVector, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.None, bPreCullCheck: false);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				bWC_DispLibDispWorldGlobalData.CameraEnvFXComp = uNiagaraComponent;
				uNiagaraComponent.SetTickBehavior(ENiagaraTickBehavior.ForceTickLast);
			}
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<DispLibDispWorldDataComp>(this, B1GlobalFNames.DispLibDispWorldDataComp);
	}

	[USharpPath("/Script/b1-Managed.DispLibDispWorld:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.DispLibDispWorld:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		AGameStateBase key = UEngine.GEngine.GetWorldFromContextObject(this)?.GetGameState();
		if (s_instance.TryGetValue(key, out var _))
		{
			s_instance.Remove(key);
		}
	}

	public override void InitAllComp()
	{
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		if (bGW_ECSWorld != null)
		{
			bGW_ECSWorld.GetObject<BWC_DispLibCameraData>(base.ECSEntity).Init(this);
			bGW_ECSWorld.GetObject<BWC_DispLibDispWorldGlobalData>(base.ECSEntity).Init(this, 0);
			bGW_ECSWorld.GetObject<BUC_DispLibDBCBaseData>(base.ECSEntity).Init(GetRootComponent(), DispLibDBCActorGroup.DLDWorld, this);
			bGW_ECSWorld.GetObject<BWC_DispLibDispWorldDBCQueueData>(base.ECSEntity).Init(this);
			bGW_ECSWorld.GetObject<BUC_DispLibDBCQueueData>(base.ECSEntity).Init();
		}
		base.InitAllComp();
		if (bGW_ECSWorld != null)
		{
			bGW_ECSWorld.SetObject(GetECSEntity(), new BWS_DispLibEventCollection());
			if (!UGSE_EngineFuncLib.IsDedicateServer(base.World))
			{
				base.ActorCompContainerCS.AddComp(new BWS_DispLibDBCManageComp());
			}
		}
	}

	public override void AfterInitAllComp()
	{
		base.AfterInitAllComp();
		RespawnCameraEnvFX();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	static DispLibDispWorld()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLibDispWorld)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLibDispWorld));
		s_instance = new Dictionary<AGameStateBase, DispLibDispWorld>();
		MasterComp = B1GlobalFNames.master;
		NonTag = B1GlobalFNames.nontag;
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibDispWorld:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibDispWorld dispLibDispWorld = GCHelper.Find<DispLibDispWorld>(obj);
		dispLibDispWorld.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibDispWorld:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibDispWorld dispLibDispWorld = GCHelper.Find<DispLibDispWorld>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		dispLibDispWorld.ReceiveEndPlay_Implementation(endPlayReason);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLibDispWorld");
		WEFMManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "WEFMManager");
		WEFMManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WEFMManager", Classes.FObjectProperty);
		WEFM_VisualDebugFX_Offset = NativeReflection.GetPropertyOffset(intPtr, "WEFM_VisualDebugFX");
		WEFM_VisualDebugFX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WEFM_VisualDebugFX", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibDispWorld:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibDispWorld:ReceiveEndPlay", ReceiveEndPlay_IsValid);
	}
}
