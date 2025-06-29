using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine;

public class EntryPoint
{
	public static string[] HotReloadAssemblyPaths;

	public static bool Preloading { get; private set; }

	public static bool Preloaded { get; private set; }

	public unsafe static int DllMain(string arg)
	{
		try
		{
			Args args = new Args(arg);
			if (!SharedRuntimeState.Initialized)
			{
				SharedRuntimeState.Initialize((IntPtr)args.GetInt64("RuntimeState"));
				AssemblyContextRef.TryParse(args.GetString("AssemblyContext"), out var value);
				AssemblyContext.Initialize(value);
				CurrentAssemblyContext.Initialize(value);
			}
			if (args.GetBool("Preloading"))
			{
				Preloading = true;
				IntPtr intPtr = (IntPtr)args.GetInt64("RegisterFuncs");
				if (intPtr != IntPtr.Zero)
				{
					NativeFunctions.RegisterFunctions(intPtr);
					Preloaded = true;
				}
				Preloading = false;
				return 0;
			}
			SharedRuntimeState.Instance->ActiveRuntime = SharedRuntimeState.CurrentRuntime;
			bool isReload = false;
			using (HotReload.Timing.Create("TotalLoadTime"))
			{
				using (HotReload.Timing.Create("HotReload.DataStore.Load"))
				{
					HotReload.Data = HotReload.DataStore.Load(SharedRuntimeState.GetHotReloadData());
				}
				HotReload.IsReloading = args.GetBool("Reloading");
				isReload = HotReload.IsReloading;
				IntPtr intPtr2 = (IntPtr)args.GetInt64("RegisterFuncs");
				if (intPtr2 != IntPtr.Zero)
				{
					NativeFunctions.RegisterFunctions(intPtr2);
				}
			}
			SharedRuntimeState.SetHotReloadAssemblyPaths(HotReloadAssemblyPaths);
			HotReload.Timing.Print(isReload);
			HotReload.Timing.PrintAll();
			return 0;
		}
		catch (Exception ex)
		{
			string text = "Entry point exception (UnrealEngine.Runtime): " + ex;
			if (SharedRuntimeState.Initialized)
			{
				SharedRuntimeState.LogError(text);
				SharedRuntimeState.MessageBox(text, "Error");
			}
			return 1005;
		}
	}

	public static void Unload()
	{
		DateTime now = DateTime.Now;
		HotReload.OnUnload();
		HotReload.Data.BeginUnloadTime = now;
		byte[] hotReloadData = HotReload.Data.Save();
		HotReload.Data.Close();
		SharedRuntimeState.SetHotReloadData(hotReloadData);
		_ = DateTime.Now.TimeOfDay;
	}
}
