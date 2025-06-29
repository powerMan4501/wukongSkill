using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FApp
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetBranchName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate EBuildConfiguration Del_GetBuildConfiguration();

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetBuildVersion(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetBuildDate(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetEngineIsPromotedBuild();

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetEpicProductIdentifier(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetProjectName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasProjectName();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsGame();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsProjectNameEmpty();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetProjectName(ref FScriptArray projectName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AuthorizeUser(ref FScriptArray userName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DenyAllUsers();

	[MonoNativeFunctionWrapper]
	public delegate void Del_DenyUser(ref FScriptArray userName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetInstanceId(out Guid result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetInstanceName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetSessionId(out Guid result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetSessionName(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetSessionOwner(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InitializeSession();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAuthorizedUser(ref FScriptArray userName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsStandalone();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsThisInstance(ref Guid instanceId);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetSessionName(ref FScriptArray newName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetSessionOwner(ref FScriptArray newOwner);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CanEverRender();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInstalled();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEngineInstalled();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsUnattended();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldUseThreadingForPerformance();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsBenchmarking();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetBenchmarking(csbool val);

	[MonoNativeFunctionWrapper]
	public delegate double Del_GetFixedDeltaTime();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFixedDeltaTime(double seconds);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_UseFixedTimeStep();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetUseFixedTimeStep(csbool val);

	[MonoNativeFunctionWrapper]
	public delegate double Del_GetCurrentTime();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetCurrentTime(double seconds);

	[MonoNativeFunctionWrapper]
	public delegate double Del_GetLastTime();

	[MonoNativeFunctionWrapper]
	public delegate void Del_UpdateLastTime();

	[MonoNativeFunctionWrapper]
	public delegate double Del_GetDeltaTime();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetDeltaTime(double seconds);

	[MonoNativeFunctionWrapper]
	public delegate double Del_GetIdleTime();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetIdleTime(double seconds);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetVolumeMultiplier();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetVolumeMultiplier(float volumeMultiplier);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetUnfocusedVolumeMultiplier();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetUnfocusedVolumeMultiplier(float volumeMultiplier);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetUseVRFocus(csbool useVRFocus);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_UseVRFocus();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetHasVRFocus(csbool hasVRFocus);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasVRFocus();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_UseFixedSeed();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_UseFixedSeed(csbool value);

	public static Del_GetBranchName GetBranchName;

	public static Del_GetBuildConfiguration GetBuildConfiguration;

	public static Del_GetBuildVersion GetBuildVersion;

	public static Del_GetBuildDate GetBuildDate;

	public static Del_GetEngineIsPromotedBuild GetEngineIsPromotedBuild;

	public static Del_GetEpicProductIdentifier GetEpicProductIdentifier;

	public static Del_GetProjectName GetProjectName;

	public static Del_GetName GetName;

	public static Del_HasProjectName HasProjectName;

	public static Del_IsGame IsGame;

	public static Del_IsProjectNameEmpty IsProjectNameEmpty;

	public static Del_SetProjectName SetProjectName;

	public static Del_AuthorizeUser AuthorizeUser;

	public static Del_DenyAllUsers DenyAllUsers;

	public static Del_DenyUser DenyUser;

	public static Del_GetInstanceId GetInstanceId;

	public static Del_GetInstanceName GetInstanceName;

	public static Del_GetSessionId GetSessionId;

	public static Del_GetSessionName GetSessionName;

	public static Del_GetSessionOwner GetSessionOwner;

	public static Del_InitializeSession InitializeSession;

	public static Del_IsAuthorizedUser IsAuthorizedUser;

	public static Del_IsStandalone IsStandalone;

	public static Del_IsThisInstance IsThisInstance;

	public static Del_SetSessionName SetSessionName;

	public static Del_SetSessionOwner SetSessionOwner;

	public static Del_CanEverRender CanEverRender;

	public static Del_IsInstalled IsInstalled;

	public static Del_IsEngineInstalled IsEngineInstalled;

	public static Del_IsUnattended IsUnattended;

	public static Del_ShouldUseThreadingForPerformance ShouldUseThreadingForPerformance;

	public static Del_IsBenchmarking IsBenchmarking;

	public static Del_SetBenchmarking SetBenchmarking;

	public static Del_GetFixedDeltaTime GetFixedDeltaTime;

	public static Del_SetFixedDeltaTime SetFixedDeltaTime;

	public static Del_UseFixedTimeStep UseFixedTimeStep;

	public static Del_SetUseFixedTimeStep SetUseFixedTimeStep;

	public static Del_GetCurrentTime GetCurrentTime;

	public static Del_SetCurrentTime SetCurrentTime;

	public static Del_GetLastTime GetLastTime;

	public static Del_UpdateLastTime UpdateLastTime;

	public static Del_GetDeltaTime GetDeltaTime;

	public static Del_SetDeltaTime SetDeltaTime;

	public static Del_GetIdleTime GetIdleTime;

	public static Del_SetIdleTime SetIdleTime;

	public static Del_GetVolumeMultiplier GetVolumeMultiplier;

	public static Del_SetVolumeMultiplier SetVolumeMultiplier;

	public static Del_GetUnfocusedVolumeMultiplier GetUnfocusedVolumeMultiplier;

	public static Del_SetUnfocusedVolumeMultiplier SetUnfocusedVolumeMultiplier;

	public static Del_SetUseVRFocus SetUseVRFocus;

	public static Del_UseVRFocus UseVRFocus;

	public static Del_SetHasVRFocus SetHasVRFocus;

	public static Del_HasVRFocus HasVRFocus;

	public static Del_Get_UseFixedSeed Get_UseFixedSeed;

	public static Del_Set_UseFixedSeed Set_UseFixedSeed;
}
