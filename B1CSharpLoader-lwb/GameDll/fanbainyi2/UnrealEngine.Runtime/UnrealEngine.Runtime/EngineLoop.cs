using System;
using System.Diagnostics;
using AOT;

namespace UnrealEngine.Runtime;

public static class EngineLoop
{
	private class EngineLoopHotReloadData : HotReload.DataItem
	{
		public DateTime ReloadDateTime;

		public TimeSpan Time;

		public double TimeByDeltaTime;

		public override void Load()
		{
			ReloadDateTime = ReadDateTime();
			Time = ReadTimeSpan();
			TimeByDeltaTime = ReadDouble();
		}

		public override void Save()
		{
			WriteDateTime(ReloadDateTime);
			WriteTimeSpan(Time);
			WriteDouble(TimeByDeltaTime);
		}
	}

	private static Stopwatch stopwatch;

	private static TimeSpan startTime;

	private static ulong lastTickCounter;

	private static uint lastFrameNumber;

	private static uint lastFrameNumberRenderThread;

	public static WorldTimeHelper WorldTime;

	public static TimeSpan TickTime { get; private set; }

	public static double TimeByDeltaTime { get; private set; }

	public static TimeSpan Time => startTime + stopwatch.Elapsed;

	public static ulong LastTickCounter { get; private set; }

	public static ulong TickCounter { get; private set; }

	public static ulong LastFrameNumber { get; private set; }

	public static ulong FrameNumber { get; private set; }

	public static ulong LastFrameNumberRenderThread { get; private set; }

	public static ulong FrameNumberRenderThread { get; private set; }

	public static ulong WorldTickCounter { get; private set; }

	public static ulong WorldFrameNumber { get; private set; }

	static EngineLoop()
	{
		stopwatch = new Stopwatch();
		stopwatch.Start();
	}

	internal static void OnNativeFunctionsRegistered()
	{
		FTicker.AddTicker(Tick);
		FCoreDelegates.OnBeginFrame.Bind(OnBeginFrame);
		FCoreDelegates.OnEndFrame.Bind(OnEndFrame);
	}

	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void OnBeginFrame()
	{
		try
		{
			TickTime = Time;
			UpdateCounters();
			Coroutine.ProcessCoroutines(CoroutineGroup.BeginFrame);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void OnEndFrame()
	{
		try
		{
			TickTime = Time;
			UpdateCounters();
			Coroutine.ProcessCoroutines(CoroutineGroup.EndFrame);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	private static bool Tick(float deltaTime)
	{
		TickTime = Time;
		TimeByDeltaTime += deltaTime;
		UpdateCounters();
		Coroutine.ProcessCoroutines(CoroutineGroup.Tick);
		return true;
	}

	private static void UpdateCounters()
	{
		LastTickCounter = TickCounter;
		ulong frameCounter = FGlobals.FrameCounter;
		ulong num = frameCounter - lastTickCounter;
		lastTickCounter = frameCounter;
		TickCounter = frameCounter;
		LastFrameNumber = FrameNumber;
		uint frameNumber = FGlobals.FrameNumber;
		uint num2 = frameNumber - lastFrameNumber;
		lastFrameNumber = frameNumber;
		FrameNumber = frameNumber;
		LastFrameNumberRenderThread = FrameNumberRenderThread;
		uint frameNumberRenderThread = FGlobals.FrameNumberRenderThread;
		_ = lastFrameNumberRenderThread;
		lastFrameNumberRenderThread = frameNumberRenderThread;
		FrameNumberRenderThread = frameNumberRenderThread;
		WorldTime.WorldAddress = FGlobals.GWorld;
		if (WorldTime.IsValid && !WorldTime.IsPaused)
		{
			WorldTickCounter += num;
			WorldFrameNumber += num2;
		}
	}

	internal static void OnUnload()
	{
		EngineLoopHotReloadData engineLoopHotReloadData = HotReload.Data.Create<EngineLoopHotReloadData>();
		engineLoopHotReloadData.ReloadDateTime = DateTime.Now;
		engineLoopHotReloadData.Time = Time;
		engineLoopHotReloadData.TimeByDeltaTime = TimeByDeltaTime;
	}

	internal static void OnReload()
	{
		EngineLoopHotReloadData engineLoopHotReloadData = HotReload.Data.Get<EngineLoopHotReloadData>();
		if (engineLoopHotReloadData != null)
		{
			startTime = engineLoopHotReloadData.Time + (DateTime.Now - engineLoopHotReloadData.ReloadDateTime);
			TimeByDeltaTime = engineLoopHotReloadData.TimeByDeltaTime;
		}
	}
}
