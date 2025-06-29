using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FBuild
{
	public static bool BuildDebug { get; private set; }

	public static bool BuildDevelopment { get; private set; }

	public static bool BuildTest { get; private set; }

	public static bool BuildShipping { get; private set; }

	public static bool Game { get; private set; }

	public static bool Editor { get; private set; }

	public static bool Server { get; private set; }

	public static bool WithEditor { get; private set; }

	public static bool WithEngine { get; private set; }

	public static bool WithUnrealDeveloperTools { get; private set; }

	public static bool WithPluginSupport { get; private set; }

	public static bool WithPerfCounters { get; private set; }

	public static bool HackHeaderGenerator { get; private set; }

	public static bool WithAutomationWorker { get; private set; }

	public static bool BuildMinimal { get; private set; }

	public static bool IsMonolithic { get; private set; }

	public static bool IsProgram { get; private set; }

	public static bool WithHotReload { get; private set; }

	public static bool CheckPureVirtuals { get; private set; }

	public static bool NullRHI { get; private set; }

	public static bool UseLoggingInShipping { get; private set; }

	public static bool UseChecksInShipping { get; private set; }

	public static bool DoGuardSlow { get; private set; }

	public static bool DoCheck { get; private set; }

	public static bool Stats { get; private set; }

	public static bool AllowDebugFiles { get; private set; }

	public static bool NoLogging { get; private set; }

	public static bool LookingForPerfIssues { get; private set; }

	public static bool UseNetworkProfiler { get; private set; }

	public static bool UseUberGraphPersistentFrame { get; private set; }

	public static bool BlueprintEventgraphFastcalls { get; private set; }

	public static bool UseServerPerfCounters { get; private set; }

	public static bool UseCircularDependencyLoadDeferring { get; private set; }

	public static bool UseDeferredDependencyCheckVerificationTests { get; private set; }

	public static bool AllowProfileGPUInTest { get; private set; }

	public static bool WithProfileGPU { get; private set; }

	public static bool WithMetaData { get; private set; }

	public static bool WithServerCode { get; private set; }

	public static bool WithEditorOnlyData { get; private set; }

	public static bool WithCoreUObject { get; private set; }

	public static bool UseStatsWithoutEngine { get; private set; }

	public static bool WithLoggingToMemory { get; private set; }

	public static bool UseCacheFreedOSAllocs { get; private set; }

	public static bool WithCEF3 { get; private set; }

	public static bool WithXGEController { get; private set; }

	public static bool WithDevAutomationTests { get; private set; }

	public static bool WithPerfAutomationTests { get; private set; }

	public static int EngineMajorVersion { get; private set; }

	public static int EngineMinorVersion { get; private set; }

	public static int EnginePatchVersion { get; private set; }

	internal static void OnNativeFunctionsRegistered()
	{
		BuildDebug = Native_FBuildGlobals.UE_BUILD_DEBUG();
		BuildDevelopment = Native_FBuildGlobals.UE_BUILD_DEVELOPMENT();
		BuildTest = Native_FBuildGlobals.UE_BUILD_TEST();
		BuildShipping = Native_FBuildGlobals.UE_BUILD_SHIPPING();
		Game = Native_FBuildGlobals.UE_GAME();
		Editor = Native_FBuildGlobals.UE_EDITOR();
		Server = Native_FBuildGlobals.UE_SERVER();
		WithEditor = Native_FBuildGlobals.WITH_EDITOR();
		WithEngine = Native_FBuildGlobals.WITH_ENGINE();
		WithUnrealDeveloperTools = Native_FBuildGlobals.WITH_UNREAL_DEVELOPER_TOOLS();
		WithPluginSupport = Native_FBuildGlobals.WITH_PLUGIN_SUPPORT();
		WithPerfCounters = Native_FBuildGlobals.WITH_PERFCOUNTERS();
		HackHeaderGenerator = Native_FBuildGlobals.HACK_HEADER_GENERATOR();
		WithAutomationWorker = Native_FBuildGlobals.WITH_AUTOMATION_WORKER();
		BuildMinimal = Native_FBuildGlobals.UE_BUILD_MINIMAL();
		IsMonolithic = Native_FBuildGlobals.IS_MONOLITHIC();
		IsProgram = Native_FBuildGlobals.IS_PROGRAM();
		WithHotReload = Native_FBuildGlobals.WITH_HOT_RELOAD();
		CheckPureVirtuals = Native_FBuildGlobals.CHECK_PUREVIRTUALS();
		NullRHI = Native_FBuildGlobals.USE_NULL_RHI();
		UseLoggingInShipping = Native_FBuildGlobals.USE_LOGGING_IN_SHIPPING();
		UseChecksInShipping = Native_FBuildGlobals.USE_CHECKS_IN_SHIPPING();
		DoGuardSlow = Native_FBuildGlobals.DO_GUARD_SLOW();
		DoCheck = Native_FBuildGlobals.DO_CHECK();
		Stats = Native_FBuildGlobals.STATS();
		AllowDebugFiles = Native_FBuildGlobals.ALLOW_DEBUG_FILES();
		NoLogging = Native_FBuildGlobals.NO_LOGGING();
		LookingForPerfIssues = Native_FBuildGlobals.LOOKING_FOR_PERF_ISSUES();
		UseNetworkProfiler = Native_FBuildGlobals.USE_NETWORK_PROFILER();
		UseUberGraphPersistentFrame = Native_FBuildGlobals.USE_UBER_GRAPH_PERSISTENT_FRAME();
		BlueprintEventgraphFastcalls = Native_FBuildGlobals.UE_BLUEPRINT_EVENTGRAPH_FASTCALLS();
		UseServerPerfCounters = Native_FBuildGlobals.USE_SERVER_PERF_COUNTERS();
		UseCircularDependencyLoadDeferring = Native_FBuildGlobals.USE_CIRCULAR_DEPENDENCY_LOAD_DEFERRING();
		UseDeferredDependencyCheckVerificationTests = Native_FBuildGlobals.USE_DEFERRED_DEPENDENCY_CHECK_VERIFICATION_TESTS();
		AllowProfileGPUInTest = Native_FBuildGlobals.ALLOW_PROFILEGPU_IN_TEST();
		WithProfileGPU = Native_FBuildGlobals.WITH_PROFILEGPU();
		WithMetaData = Native_FBuildGlobals.WITH_METADATA();
		WithServerCode = Native_FBuildGlobals.WITH_SERVER_CODE();
		WithEditorOnlyData = Native_FBuildGlobals.WITH_EDITORONLY_DATA();
		WithCoreUObject = Native_FBuildGlobals.WITH_COREUOBJECT();
		UseStatsWithoutEngine = Native_FBuildGlobals.USE_STATS_WITHOUT_ENGINE();
		WithLoggingToMemory = Native_FBuildGlobals.WITH_LOGGING_TO_MEMORY();
		UseCacheFreedOSAllocs = Native_FBuildGlobals.USE_CACHE_FREED_OS_ALLOCS();
		WithCEF3 = Native_FBuildGlobals.WITH_CEF3();
		WithDevAutomationTests = Native_FBuildGlobals.WITH_DEV_AUTOMATION_TESTS();
		WithPerfAutomationTests = Native_FBuildGlobals.WITH_PERF_AUTOMATION_TESTS();
		EngineMajorVersion = Native_FBuildGlobals.ENGINE_MAJOR_VERSION();
		EngineMinorVersion = Native_FBuildGlobals.ENGINE_MINOR_VERSION();
		EnginePatchVersion = Native_FBuildGlobals.ENGINE_PATCH_VERSION();
	}
}
