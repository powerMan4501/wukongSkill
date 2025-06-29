using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FGlobals
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GMalloc();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GFixedMallocLocationPtr();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GLog();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GConfig();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GUndo();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GLogConsole();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GError();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GWarn();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsGameAgnosticExe();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GForceLoadEditorOnly();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GVerifyObjectReferencesOnly();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GFastPathUniqueNameGeneration();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GAllowActorScriptExecutionInEditor();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GCompilingBlueprint();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsReconstructingBlueprintInstances();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsReinstancing();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsEditor();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsTransacting();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIntraFrameDebuggingGameThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GFirstFrameIntraFrameDebugging();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRunningCommandlet();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAllowCommandletRendering();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAllowCommandletAudio();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GEdSelectionLock();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsClient();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsServer();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsCriticalError();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GIsCriticalError(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsRunning();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsDuplicatingClassForReinstancing();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsBuildMachine();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsSilent();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsSlowTask();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GSlowTaskOccurred();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsGuarded();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsRequestingExit();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Set_GIsRequestingExit(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GAreScreenMessagesEnabled();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsDumpingMovie();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsHighResScreenshot();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GEngineIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GEditorIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GEditorKeyBindingsIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GEditorLayoutIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GEditorSettingsIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GEditorPerProjectIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GCompatIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GLightmassIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GScalabilityIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GHardwareIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GInputIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GGameIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GGameUserSettingsIni(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_GNearClippingPlane();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GNearClippingPlane(float value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GExitPurge();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GInternalProjectName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GForeignEngineDir(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GDebugToolExec();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAsyncLoading();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SuspendAsyncLoading();

	[MonoNativeFunctionWrapper]
	public delegate void Del_ResumeAsyncLoading();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAsyncLoadingMultithreaded();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsEditorLoadingPackage();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsCookerLoadingPackage();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsPlayInEditorWorld();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_GPlayInEditorID();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsPIEUsingPlayerStart();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GPlatformNeedsPowerOfTwoTextures();

	[MonoNativeFunctionWrapper]
	public delegate double Del_Get_GStartTime();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GSystemStartTime(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsInitialLoad();

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_Get_GFrameCounter();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GFrameCounterPtr();

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_Get_GLastGCFrame();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GLastGCFramePtr();

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GFrameNumber();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GFrameNumberPtr();

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GFrameNumberRenderThread();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GFrameNumberRenderThreadPtr();

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_GHitchThresholdMS();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_GSavingCompressionChunkSize();

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GGameThreadId();

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GRenderThreadId();

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GSlateLoadingThreadId();

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GAudioThreadId();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsGameThreadIdInitialized();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GEmitDrawEvents();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GShouldSuspendRenderingThread();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GCurrentTraceName(out FName result);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_GPrintLogTimes();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GPrintLogTimes(int value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GPrintLogCategory();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GPrintLogCategory(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsDemoMode();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GLongCorePackageName(out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_GLongCoreUObjectPackageName(out FName result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GPumpingMessagesOutsideOfMainLoop();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GEnableVREditorHacks();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GEnableVREditorHacks(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GEngine();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GEditor();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GDisallowNetworkTravel();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GDisallowNetworkTravel(csbool value);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_GGPUFrameTime();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GGPUFrameTimePtr();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRunningDedicatedServer();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRunningGame();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRunningClientOnly();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GWorldPtr();

	public static Del_Get_GMalloc Get_GMalloc;

	public static Del_Get_GFixedMallocLocationPtr Get_GFixedMallocLocationPtr;

	public static Del_Get_GLog Get_GLog;

	public static Del_Get_GConfig Get_GConfig;

	public static Del_Get_GUndo Get_GUndo;

	public static Del_Get_GLogConsole Get_GLogConsole;

	public static Del_Get_GError Get_GError;

	public static Del_Get_GWarn Get_GWarn;

	public static Del_Get_GIsGameAgnosticExe Get_GIsGameAgnosticExe;

	public static Del_Get_GForceLoadEditorOnly Get_GForceLoadEditorOnly;

	public static Del_Get_GVerifyObjectReferencesOnly Get_GVerifyObjectReferencesOnly;

	public static Del_Get_GFastPathUniqueNameGeneration Get_GFastPathUniqueNameGeneration;

	public static Del_Get_GAllowActorScriptExecutionInEditor Get_GAllowActorScriptExecutionInEditor;

	public static Del_Get_GCompilingBlueprint Get_GCompilingBlueprint;

	public static Del_Get_GIsReconstructingBlueprintInstances Get_GIsReconstructingBlueprintInstances;

	public static Del_Get_GIsReinstancing Get_GIsReinstancing;

	public static Del_Get_GIsEditor Get_GIsEditor;

	public static Del_Get_GIsTransacting Get_GIsTransacting;

	public static Del_Get_GIntraFrameDebuggingGameThread Get_GIntraFrameDebuggingGameThread;

	public static Del_Get_GFirstFrameIntraFrameDebugging Get_GFirstFrameIntraFrameDebugging;

	public static Del_IsRunningCommandlet IsRunningCommandlet;

	public static Del_IsAllowCommandletRendering IsAllowCommandletRendering;

	public static Del_IsAllowCommandletAudio IsAllowCommandletAudio;

	public static Del_Get_GEdSelectionLock Get_GEdSelectionLock;

	public static Del_Get_GIsClient Get_GIsClient;

	public static Del_Get_GIsServer Get_GIsServer;

	public static Del_Get_GIsCriticalError Get_GIsCriticalError;

	public static Del_Set_GIsCriticalError Set_GIsCriticalError;

	public static Del_Get_GIsRunning Get_GIsRunning;

	public static Del_Get_GIsDuplicatingClassForReinstancing Get_GIsDuplicatingClassForReinstancing;

	public static Del_Get_GIsBuildMachine Get_GIsBuildMachine;

	public static Del_Get_GIsSilent Get_GIsSilent;

	public static Del_Get_GIsSlowTask Get_GIsSlowTask;

	public static Del_Get_GSlowTaskOccurred Get_GSlowTaskOccurred;

	public static Del_Get_GIsGuarded Get_GIsGuarded;

	public static Del_Get_GIsRequestingExit Get_GIsRequestingExit;

	public static Del_Set_GIsRequestingExit Set_GIsRequestingExit;

	public static Del_Get_GAreScreenMessagesEnabled Get_GAreScreenMessagesEnabled;

	public static Del_Get_GIsDumpingMovie Get_GIsDumpingMovie;

	public static Del_Get_GIsHighResScreenshot Get_GIsHighResScreenshot;

	public static Del_Get_GEngineIni Get_GEngineIni;

	public static Del_Get_GEditorIni Get_GEditorIni;

	public static Del_Get_GEditorKeyBindingsIni Get_GEditorKeyBindingsIni;

	public static Del_Get_GEditorLayoutIni Get_GEditorLayoutIni;

	public static Del_Get_GEditorSettingsIni Get_GEditorSettingsIni;

	public static Del_Get_GEditorPerProjectIni Get_GEditorPerProjectIni;

	public static Del_Get_GCompatIni Get_GCompatIni;

	public static Del_Get_GLightmassIni Get_GLightmassIni;

	public static Del_Get_GScalabilityIni Get_GScalabilityIni;

	public static Del_Get_GHardwareIni Get_GHardwareIni;

	public static Del_Get_GInputIni Get_GInputIni;

	public static Del_Get_GGameIni Get_GGameIni;

	public static Del_Get_GGameUserSettingsIni Get_GGameUserSettingsIni;

	public static Del_Get_GNearClippingPlane Get_GNearClippingPlane;

	public static Del_Set_GNearClippingPlane Set_GNearClippingPlane;

	public static Del_Get_GExitPurge Get_GExitPurge;

	public static Del_Get_GInternalProjectName Get_GInternalProjectName;

	public static Del_Get_GForeignEngineDir Get_GForeignEngineDir;

	public static Del_Get_GDebugToolExec Get_GDebugToolExec;

	public static Del_IsAsyncLoading IsAsyncLoading;

	public static Del_SuspendAsyncLoading SuspendAsyncLoading;

	public static Del_ResumeAsyncLoading ResumeAsyncLoading;

	public static Del_IsAsyncLoadingMultithreaded IsAsyncLoadingMultithreaded;

	public static Del_Get_GIsEditorLoadingPackage Get_GIsEditorLoadingPackage;

	public static Del_Get_GIsCookerLoadingPackage Get_GIsCookerLoadingPackage;

	public static Del_Get_GIsPlayInEditorWorld Get_GIsPlayInEditorWorld;

	public static Del_Get_GPlayInEditorID Get_GPlayInEditorID;

	public static Del_Get_GIsPIEUsingPlayerStart Get_GIsPIEUsingPlayerStart;

	public static Del_Get_GPlatformNeedsPowerOfTwoTextures Get_GPlatformNeedsPowerOfTwoTextures;

	public static Del_Get_GStartTime Get_GStartTime;

	public static Del_Get_GSystemStartTime Get_GSystemStartTime;

	public static Del_Get_GIsInitialLoad Get_GIsInitialLoad;

	public static Del_Get_GFrameCounter Get_GFrameCounter;

	public static Del_Get_GFrameCounterPtr Get_GFrameCounterPtr;

	public static Del_Get_GLastGCFrame Get_GLastGCFrame;

	public static Del_Get_GLastGCFramePtr Get_GLastGCFramePtr;

	public static Del_Get_GFrameNumber Get_GFrameNumber;

	public static Del_Get_GFrameNumberPtr Get_GFrameNumberPtr;

	public static Del_Get_GFrameNumberRenderThread Get_GFrameNumberRenderThread;

	public static Del_Get_GFrameNumberRenderThreadPtr Get_GFrameNumberRenderThreadPtr;

	public static Del_Get_GHitchThresholdMS Get_GHitchThresholdMS;

	public static Del_Get_GSavingCompressionChunkSize Get_GSavingCompressionChunkSize;

	public static Del_Get_GGameThreadId Get_GGameThreadId;

	public static Del_Get_GRenderThreadId Get_GRenderThreadId;

	public static Del_Get_GSlateLoadingThreadId Get_GSlateLoadingThreadId;

	public static Del_Get_GAudioThreadId Get_GAudioThreadId;

	public static Del_Get_GIsGameThreadIdInitialized Get_GIsGameThreadIdInitialized;

	public static Del_Get_GEmitDrawEvents Get_GEmitDrawEvents;

	public static Del_Get_GShouldSuspendRenderingThread Get_GShouldSuspendRenderingThread;

	public static Del_Get_GCurrentTraceName Get_GCurrentTraceName;

	public static Del_Get_GPrintLogTimes Get_GPrintLogTimes;

	public static Del_Set_GPrintLogTimes Set_GPrintLogTimes;

	public static Del_Get_GPrintLogCategory Get_GPrintLogCategory;

	public static Del_Set_GPrintLogCategory Set_GPrintLogCategory;

	public static Del_Get_GIsDemoMode Get_GIsDemoMode;

	public static Del_Get_GLongCorePackageName Get_GLongCorePackageName;

	public static Del_Get_GLongCoreUObjectPackageName Get_GLongCoreUObjectPackageName;

	public static Del_Get_GPumpingMessagesOutsideOfMainLoop Get_GPumpingMessagesOutsideOfMainLoop;

	public static Del_Get_GEnableVREditorHacks Get_GEnableVREditorHacks;

	public static Del_Set_GEnableVREditorHacks Set_GEnableVREditorHacks;

	public static Del_Get_GEngine Get_GEngine;

	public static Del_Get_GEditor Get_GEditor;

	public static Del_Get_GDisallowNetworkTravel Get_GDisallowNetworkTravel;

	public static Del_Set_GDisallowNetworkTravel Set_GDisallowNetworkTravel;

	public static Del_Get_GGPUFrameTime Get_GGPUFrameTime;

	public static Del_Get_GGPUFrameTimePtr Get_GGPUFrameTimePtr;

	public static Del_IsRunningDedicatedServer IsRunningDedicatedServer;

	public static Del_IsRunningGame IsRunningGame;

	public static Del_IsRunningClientOnly IsRunningClientOnly;

	public static Del_Get_GWorldPtr Get_GWorldPtr;
}
