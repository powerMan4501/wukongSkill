using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct WorldTimeHelper
{
	public IntPtr WorldAddress;

	private static int timeSecondsOffset;

	private static int unpausedTimeSecondsOffset;

	private static int realTimeSecondsOffset;

	private static int deltaTimeSecondsOffset;

	private static int pauseDelayOffset;

	public bool IsValid => WorldAddress != IntPtr.Zero;

	public TimeSpan Time => TimeSpan.FromSeconds(TimeSeconds);

	public TimeSpan UnpausedTime => TimeSpan.FromSeconds(UnpausedTimeSeconds);

	public TimeSpan DeltaTime => TimeSpan.FromSeconds(DeltaTimeSeconds);

	public TimeSpan PauseDelayTime => TimeSpan.FromSeconds(PauseDelay);

	public unsafe float TimeSeconds
	{
		get
		{
			if (IsValid)
			{
				return *(float*)(void*)(WorldAddress + timeSecondsOffset);
			}
			return 0f;
		}
	}

	public unsafe float UnpausedTimeSeconds
	{
		get
		{
			if (IsValid)
			{
				return *(float*)(void*)(WorldAddress + unpausedTimeSecondsOffset);
			}
			return 0f;
		}
	}

	public unsafe float RealTimeSeconds
	{
		get
		{
			if (IsValid)
			{
				return *(float*)(void*)(WorldAddress + realTimeSecondsOffset);
			}
			return 0f;
		}
	}

	public unsafe float DeltaTimeSeconds
	{
		get
		{
			if (IsValid)
			{
				return *(float*)(void*)(WorldAddress + deltaTimeSecondsOffset);
			}
			return 0f;
		}
	}

	public unsafe float PauseDelay
	{
		get
		{
			if (IsValid)
			{
				return *(float*)(void*)(WorldAddress + pauseDelayOffset);
			}
			return 0f;
		}
	}

	public bool DebugPauseExecution
	{
		get
		{
			if (IsValid)
			{
				return Native_UWorld.Get_bDebugPauseExecution(WorldAddress);
			}
			return false;
		}
	}

	public bool IsPaused
	{
		get
		{
			if (IsValid)
			{
				return Native_UWorld.IsPaused(WorldAddress);
			}
			return true;
		}
	}

	public WorldTimeHelper(IntPtr worldAddress)
	{
		WorldAddress = worldAddress;
	}

	internal static void OnNativeFunctionsRegistered()
	{
		timeSecondsOffset = Native_UWorld.Offset_TimeSeconds();
		unpausedTimeSecondsOffset = Native_UWorld.Offset_UnpausedTimeSeconds();
		realTimeSecondsOffset = Native_UWorld.Offset_RealTimeSeconds();
		deltaTimeSecondsOffset = Native_UWorld.Offset_DeltaTimeSeconds();
		pauseDelayOffset = Native_UWorld.Offset_PauseDelay();
	}

	public static TimeSpan GetTimeChecked(IntPtr world)
	{
		return GetTime(GetWorldChecked(world));
	}

	public static TimeSpan GetTime(IntPtr world)
	{
		return new WorldTimeHelper(world).Time;
	}

	public static TimeSpan GetUnpausedTimeChecked(IntPtr world)
	{
		return GetUnpausedTime(GetWorldChecked(world));
	}

	public static TimeSpan GetUnpausedTime(IntPtr world)
	{
		return new WorldTimeHelper(world).UnpausedTime;
	}

	public static TimeSpan GetDeltaTimeChecked(IntPtr world)
	{
		return GetDeltaTime(GetWorldChecked(world));
	}

	public static TimeSpan GetDeltaTime(IntPtr world)
	{
		return new WorldTimeHelper(world).DeltaTime;
	}

	public static float GetTimeSecondsChecked(IntPtr world)
	{
		return GetTimeSeconds(GetWorldChecked(world));
	}

	public static float GetTimeSeconds(IntPtr world)
	{
		return new WorldTimeHelper(world).TimeSeconds;
	}

	public static float GetUnpausedTimeSecondsChecked(IntPtr world)
	{
		return GetUnpausedTimeSeconds(GetWorldChecked(world));
	}

	public static float GetUnpausedTimeSeconds(IntPtr world)
	{
		return new WorldTimeHelper(world).UnpausedTimeSeconds;
	}

	public static float GetDeltaTimeSecondsChecked(IntPtr world)
	{
		return GetDeltaTimeSeconds(GetWorldChecked(world));
	}

	public static float GetDeltaTimeSeconds(IntPtr world)
	{
		return new WorldTimeHelper(world).DeltaTimeSeconds;
	}

	private static IntPtr GetWorldChecked(IntPtr world)
	{
		if (world == IntPtr.Zero)
		{
			world = EngineLoop.WorldTime.WorldAddress;
		}
		return world;
	}
}
