using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FGlobals
{
	private unsafe static ulong* frameCounterPtr = null;

	private unsafe static ulong* lastGCFramePtr = null;

	private unsafe static uint* frameNumberPtr = null;

	public unsafe static uint* frameNumberRenderThreadPtr = null;

	private unsafe static uint* gpuFrameTimePtr = null;

	private unsafe static IntPtr* worldPtr;

	public static IntPtr GMalloc => Native_FGlobals.Get_GMalloc();

	public static IntPtr GFixedMallocLocationPtr => Native_FGlobals.Get_GFixedMallocLocationPtr();

	public static IntPtr GLog => Native_FGlobals.Get_GLog();

	public static IntPtr GConfig => Native_FGlobals.Get_GConfig();

	public static IntPtr GUndo => Native_FGlobals.Get_GUndo();

	public static IntPtr GLogConsole => Native_FGlobals.Get_GLogConsole();

	public static IntPtr GError => Native_FGlobals.Get_GError();

	public static IntPtr GWarn => Native_FGlobals.Get_GWarn();

	public static bool IsGameAgnosticExe => Native_FGlobals.Get_GIsGameAgnosticExe();

	public static bool ForceLoadEditorOnly => Native_FGlobals.Get_GForceLoadEditorOnly();

	public static bool VerifyObjectReferencesOnly => Native_FGlobals.Get_GVerifyObjectReferencesOnly();

	public static bool FastPathUniqueNameGeneration => Native_FGlobals.Get_GFastPathUniqueNameGeneration();

	public static bool AllowActorScriptExecutionInEditor => Native_FGlobals.Get_GAllowActorScriptExecutionInEditor();

	public static bool CompilingBlueprint => Native_FGlobals.Get_GCompilingBlueprint();

	public static bool IsReconstructingBlueprintInstances => Native_FGlobals.Get_GIsReconstructingBlueprintInstances();

	public static bool IsReinstancing => Native_FGlobals.Get_GIsReinstancing();

	public static bool IsEditor => Native_FGlobals.Get_GIsEditor();

	public static bool IsTransacting
	{
		get
		{
			if (Native_FGlobals.Get_GIsTransacting == null)
			{
				return false;
			}
			return Native_FGlobals.Get_GIsTransacting();
		}
	}

	public static bool IntraFrameDebuggingGameThread => Native_FGlobals.Get_GIntraFrameDebuggingGameThread();

	public static bool FirstFrameIntraFrameDebugging => Native_FGlobals.Get_GFirstFrameIntraFrameDebugging();

	public static bool IsRunningCommandlet => Native_FGlobals.IsRunningCommandlet();

	public static bool IsAllowCommandletRendering => Native_FGlobals.IsAllowCommandletRendering();

	public static bool IsAllowCommandletAudio => Native_FGlobals.IsAllowCommandletAudio();

	public static bool EdSelectionLock => Native_FGlobals.Get_GEdSelectionLock();

	public static bool IsClient => Native_FGlobals.Get_GIsClient();

	public static bool IsServer => Native_FGlobals.Get_GIsServer();

	public static bool IsCriticalError
	{
		get
		{
			return Native_FGlobals.Get_GIsCriticalError();
		}
		set
		{
			Native_FGlobals.Set_GIsCriticalError(value);
		}
	}

	public static bool IsRunning => Native_FGlobals.Get_GIsRunning();

	public static bool IsDuplicatingClassForReinstancing => Native_FGlobals.Get_GIsDuplicatingClassForReinstancing();

	public static bool IsBuildMachine => Native_FGlobals.Get_GIsBuildMachine();

	public static bool IsSilent => Native_FGlobals.Get_GIsSilent();

	public static bool IsSlowTask => Native_FGlobals.Get_GIsSlowTask();

	public static bool SlowTaskOccurred => Native_FGlobals.Get_GSlowTaskOccurred();

	public static bool IsGuarded => Native_FGlobals.Get_GIsGuarded();

	public static bool IsRequestingExit
	{
		get
		{
			return Native_FGlobals.Get_GIsRequestingExit();
		}
		set
		{
			Native_FGlobals.Set_GIsRequestingExit(value);
		}
	}

	public static bool AreScreenMessagesEnabled => Native_FGlobals.Get_GAreScreenMessagesEnabled();

	public static bool IsDumpingMovie => Native_FGlobals.Get_GIsDumpingMovie();

	public static bool IsHighResScreenshot => Native_FGlobals.Get_GIsHighResScreenshot();

	public static string EngineIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GEngineIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EditorIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GEditorIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EditorKeyBindingsIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GEditorKeyBindingsIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EditorLayoutIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GEditorLayoutIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EditorSettingsIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GEditorSettingsIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string EditorPerProjectIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GEditorPerProjectIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string CompatIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GCompatIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string LightmassIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GLightmassIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ScalabilityIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GScalabilityIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string HardwareIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GHardwareIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string InputIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GInputIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GameIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GGameIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string GameUserSettingsIni
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GGameUserSettingsIni(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static float NearClippingPlane
	{
		get
		{
			return Native_FGlobals.Get_GNearClippingPlane();
		}
		set
		{
			Native_FGlobals.Set_GNearClippingPlane(value);
		}
	}

	public static bool ExitPurge => Native_FGlobals.Get_GExitPurge();

	public static string InternalProjectName
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GInternalProjectName(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static string ForeignEngineDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GForeignEngineDir(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static IntPtr GDebugToolExec => Native_FGlobals.Get_GDebugToolExec();

	public static bool IsEditorLoadingPackage => Native_FGlobals.Get_GIsEditorLoadingPackage();

	public static bool IsCookerLoadingPackage => Native_FGlobals.Get_GIsCookerLoadingPackage();

	public static bool IsPlayInEditorWorld => Native_FGlobals.Get_GIsPlayInEditorWorld();

	public static int PlayInEditorID => Native_FGlobals.Get_GPlayInEditorID();

	public static bool IsPIEUsingPlayerStart => Native_FGlobals.Get_GIsPIEUsingPlayerStart();

	public static bool PlatformNeedsPowerOfTwoTextures => Native_FGlobals.Get_GPlatformNeedsPowerOfTwoTextures();

	public static double StartTime => Native_FGlobals.Get_GStartTime();

	public static string SystemStartTime
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FGlobals.Get_GSystemStartTime(ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public static bool IsInitialLoad => Native_FGlobals.Get_GIsInitialLoad();

	public unsafe static ulong FrameCounter => *frameCounterPtr;

	public unsafe static ulong LastGCFrame => *lastGCFramePtr;

	public unsafe static uint FrameNumber => *frameNumberPtr;

	public unsafe static uint FrameNumberRenderThread => *frameNumberRenderThreadPtr;

	public static float HitchThresholdMS => Native_FGlobals.Get_GHitchThresholdMS();

	public static int SavingCompressionChunkSize => Native_FGlobals.Get_GSavingCompressionChunkSize();

	public static uint GameThreadId => Native_FGlobals.Get_GGameThreadId();

	public static uint RenderThreadId => Native_FGlobals.Get_GRenderThreadId();

	public static uint SlateLoadingThreadId => Native_FGlobals.Get_GSlateLoadingThreadId();

	public static uint AudioThreadId => Native_FGlobals.Get_GAudioThreadId();

	public static bool IsGameThreadIdInitialized => Native_FGlobals.Get_GIsGameThreadIdInitialized();

	public static bool EmitDrawEvents => Native_FGlobals.Get_GEmitDrawEvents();

	public static bool ShouldSuspendRenderingThread => Native_FGlobals.Get_GShouldSuspendRenderingThread();

	public static FName CurrentTraceName
	{
		get
		{
			Native_FGlobals.Get_GCurrentTraceName(out var result);
			return result;
		}
	}

	public static ELogTimes PrintLogTimes
	{
		get
		{
			return (ELogTimes)Native_FGlobals.Get_GPrintLogTimes();
		}
		set
		{
			Native_FGlobals.Set_GPrintLogTimes((int)value);
		}
	}

	public static bool PrintLogCategory
	{
		get
		{
			return Native_FGlobals.Get_GPrintLogCategory();
		}
		set
		{
			Native_FGlobals.Set_GPrintLogCategory(value);
		}
	}

	public static bool IsDemoMode => Native_FGlobals.Get_GIsDemoMode();

	public static FName LongCorePackageName
	{
		get
		{
			Native_FGlobals.Get_GLongCorePackageName(out var result);
			return result;
		}
	}

	public static FName LongCoreUObjectPackageName
	{
		get
		{
			Native_FGlobals.Get_GLongCoreUObjectPackageName(out var result);
			return result;
		}
	}

	public static bool PumpingMessagesOutsideOfMainLoop => Native_FGlobals.Get_GPumpingMessagesOutsideOfMainLoop();

	public static bool EnableVREditorHacks
	{
		get
		{
			return Native_FGlobals.Get_GEnableVREditorHacks();
		}
		set
		{
			Native_FGlobals.Set_GEnableVREditorHacks(value);
		}
	}

	public static IntPtr GEngine => Native_FGlobals.Get_GEngine();

	public static IntPtr GEditor => IntPtr.Zero;

	public static bool DisallowNetworkTravel
	{
		get
		{
			return Native_FGlobals.Get_GDisallowNetworkTravel();
		}
		set
		{
			Native_FGlobals.Set_GDisallowNetworkTravel(value);
		}
	}

	public unsafe static uint GPUFrameTime => *gpuFrameTimePtr;

	public static bool IsRunningDedicatedServer => Native_FGlobals.IsRunningDedicatedServer();

	public static bool IsRunningGame => Native_FGlobals.IsRunningGame();

	public static bool IsRunningClientOnly => Native_FGlobals.IsRunningClientOnly();

	public unsafe static IntPtr GWorld => *worldPtr;

	public static bool IsAsyncLoading()
	{
		return Native_FGlobals.IsAsyncLoading();
	}

	public static void SuspendAsyncLoading()
	{
		Native_FGlobals.SuspendAsyncLoading();
	}

	public static void ResumeAsyncLoading()
	{
		Native_FGlobals.ResumeAsyncLoading();
	}

	public static bool IsAsyncLoadingMultithreaded()
	{
		return Native_FGlobals.IsAsyncLoadingMultithreaded();
	}

	internal unsafe static void OnNativeFunctionsRegistered()
	{
		lastGCFramePtr = (ulong*)(void*)Native_FGlobals.Get_GLastGCFramePtr();
		frameNumberRenderThreadPtr = (uint*)(void*)Native_FGlobals.Get_GFrameNumberRenderThreadPtr();
		frameCounterPtr = (ulong*)(void*)Native_FGlobals.Get_GFrameCounterPtr();
		frameNumberPtr = (uint*)(void*)Native_FGlobals.Get_GFrameNumberPtr();
		gpuFrameTimePtr = (uint*)(void*)Native_FGlobals.Get_GGPUFrameTimePtr();
		worldPtr = (IntPtr*)(void*)Native_FGlobals.Get_GWorldPtr();
	}
}
