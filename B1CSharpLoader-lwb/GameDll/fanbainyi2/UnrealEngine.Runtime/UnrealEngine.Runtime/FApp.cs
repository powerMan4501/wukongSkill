using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FApp
{
	public static bool UseFixedSeed
	{
		get
		{
			return Native_FApp.Get_UseFixedSeed();
		}
		set
		{
			Native_FApp.Set_UseFixedSeed(value);
		}
	}

	public static string GetBranchName()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetBranchName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static EBuildConfiguration GetBuildConfiguration()
	{
		return Native_FApp.GetBuildConfiguration();
	}

	public static string GetBuildVersion()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetBuildVersion(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetBuildDate()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetBuildDate(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool GetEngineIsPromotedBuild()
	{
		return Native_FApp.GetEngineIsPromotedBuild();
	}

	public static string GetEpicProductIdentifier()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetEpicProductIdentifier(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetProjectName()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetProjectName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetName()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool HasProjectName()
	{
		return Native_FApp.HasProjectName();
	}

	public static bool IsGame()
	{
		return Native_FApp.IsGame();
	}

	public static bool IsProjectNameEmpty()
	{
		return Native_FApp.IsProjectNameEmpty();
	}

	public static void SetProjectName(string projectName)
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New(projectName);
		Native_FApp.SetProjectName(ref fStringUnsafe.Array);
	}

	public static void AuthorizeUser(string userName)
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New(userName);
		Native_FApp.AuthorizeUser(ref fStringUnsafe.Array);
	}

	public static void DenyAllUsers()
	{
		Native_FApp.DenyAllUsers();
	}

	public static void DenyUser(string userName)
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New(userName);
		Native_FApp.DenyUser(ref fStringUnsafe.Array);
	}

	public static Guid GetInstanceId()
	{
		Native_FApp.GetInstanceId(out var result);
		return result;
	}

	public static string GetInstanceName()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetInstanceName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static Guid GetSessionId()
	{
		Native_FApp.GetSessionId(out var result);
		return result;
	}

	public static string GetSessionName()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetSessionName(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetSessionOwner()
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New();
		Native_FApp.GetSessionOwner(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static void InitializeSession()
	{
		Native_FApp.InitializeSession();
	}

	public static bool IsAuthorizedUser(string userName)
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New(userName);
		return Native_FApp.IsAuthorizedUser(ref fStringUnsafe.Array);
	}

	public static bool IsStandalone()
	{
		return Native_FApp.IsStandalone();
	}

	public static bool IsThisInstance(Guid instanceId)
	{
		return Native_FApp.IsThisInstance(ref instanceId);
	}

	public static void SetSessionName(string newName)
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New(newName);
		Native_FApp.SetSessionName(ref fStringUnsafe.Array);
	}

	public static void SetSessionOwner(string newOwner)
	{
		using FStringUnsafe fStringUnsafe = FStringPool.New(newOwner);
		Native_FApp.SetSessionOwner(ref fStringUnsafe.Array);
	}

	public static bool CanEverRender()
	{
		return Native_FApp.CanEverRender();
	}

	public static bool IsInstalled()
	{
		return Native_FApp.IsInstalled();
	}

	public static bool IsEngineInstalled()
	{
		return Native_FApp.IsEngineInstalled();
	}

	public static bool IsUnattended()
	{
		return Native_FApp.IsUnattended();
	}

	public static bool ShouldUseThreadingForPerformance()
	{
		return Native_FApp.ShouldUseThreadingForPerformance();
	}

	public static bool IsBenchmarking()
	{
		return Native_FApp.IsBenchmarking();
	}

	public static void SetBenchmarking(bool val)
	{
		Native_FApp.SetBenchmarking(val);
	}

	public static double GetFixedDeltaTime()
	{
		return Native_FApp.GetFixedDeltaTime();
	}

	public static void SetFixedDeltaTime(double seconds)
	{
		Native_FApp.SetFixedDeltaTime(seconds);
	}

	public static bool UseFixedTimeStep()
	{
		return Native_FApp.UseFixedTimeStep();
	}

	public static void SetUseFixedTimeStep(bool val)
	{
		Native_FApp.SetUseFixedTimeStep(val);
	}

	public static double GetCurrentTime()
	{
		return Native_FApp.GetCurrentTime();
	}

	public static void SetCurrentTime(double seconds)
	{
		Native_FApp.SetCurrentTime(seconds);
	}

	public static double GetLastTime()
	{
		return Native_FApp.GetLastTime();
	}

	public static void UpdateLastTime()
	{
		Native_FApp.UpdateLastTime();
	}

	public static double GetDeltaTime()
	{
		return Native_FApp.GetDeltaTime();
	}

	public static void SetDeltaTime(double seconds)
	{
		Native_FApp.SetDeltaTime(seconds);
	}

	public static double GetIdleTime()
	{
		return Native_FApp.GetIdleTime();
	}

	public static void SetIdleTime(double seconds)
	{
		Native_FApp.SetIdleTime(seconds);
	}

	public static float GetVolumeMultiplier()
	{
		return Native_FApp.GetVolumeMultiplier();
	}

	public static void SetVolumeMultiplier(float volumeMultiplier)
	{
		Native_FApp.SetVolumeMultiplier(volumeMultiplier);
	}

	public static float GetUnfocusedVolumeMultiplier()
	{
		return Native_FApp.GetUnfocusedVolumeMultiplier();
	}

	public static void SetUnfocusedVolumeMultiplier(float volumeMultiplier)
	{
		Native_FApp.SetUnfocusedVolumeMultiplier(volumeMultiplier);
	}

	public static void SetUseVRFocus(bool useVRFocus)
	{
		Native_FApp.SetUseVRFocus(useVRFocus);
	}

	public static bool UseVRFocus()
	{
		return Native_FApp.UseVRFocus();
	}

	public static void SetHasVRFocus(bool hasVRFocus)
	{
		Native_FApp.SetHasVRFocus(hasVRFocus);
	}

	public static bool HasVRFocus()
	{
		return Native_FApp.HasVRFocus();
	}
}
