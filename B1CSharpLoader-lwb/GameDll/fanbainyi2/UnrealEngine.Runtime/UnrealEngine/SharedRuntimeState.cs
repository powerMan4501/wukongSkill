using System;
using System.IO;
using System.Runtime.InteropServices;
using AOT;

namespace UnrealEngine;

public struct SharedRuntimeState
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr MallocDel(IntPtr count, uint alignment = 0u);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr ReallocDel(IntPtr original, IntPtr count, uint alignment = 0u);

	[MonoNativeFunctionWrapper]
	public delegate void FreeDel(IntPtr original);

	[MonoNativeFunctionWrapper]
	public delegate void MessageBoxDel([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string title);

	[MonoNativeFunctionWrapper]
	public delegate void LogMsgDel(byte verbosity, [MarshalAs(UnmanagedType.LPStr)] string message);

	private EDotNetRuntime DesiredRuntimes;

	private EDotNetRuntime InitializedRuntimes;

	private EDotNetRuntime LoadedRuntimes;

	public EDotNetRuntime ActiveRuntime;

	public EDotNetRuntime NextRuntime;

	public int IsActiveRuntimeComplete;

	public int IsAOTRuntime;

	public uint RuntimeCounter;

	public int Reload;

	private int HotReloadDataLen;

	private int HotReloadDataLenInMemory;

	private IntPtr HotReloadData;

	private int HotReloadAssemblyPathsLen;

	private int HotReloadAssemblyPathsLenInMemory;

	private IntPtr HotReloadAssemblyPaths;

	private IntPtr MallocFuncPtr;

	private IntPtr ReallocFuncPtr;

	private IntPtr FreeFuncPtr;

	private IntPtr MessageBoxPtr;

	private IntPtr LogPtr;

	private int StructSize;

	public static MallocDel Malloc;

	public static ReallocDel Realloc;

	public static FreeDel Free;

	public static MessageBoxDel MessageBox;

	public static LogMsgDel LogMsg;

	private static IntPtr Address;

	public unsafe static bool IsActiveRuntime => CurrentRuntime == Instance->ActiveRuntime;

	public unsafe static bool IsShutdown => Instance->LoadedRuntimes == EDotNetRuntime.None;

	public static EDotNetRuntime CurrentRuntime => GetInitializedRuntimes();

	public static bool Initialized => Address != IntPtr.Zero;

	internal unsafe static SharedRuntimeState* Instance => (SharedRuntimeState*)(void*)Address;

	public unsafe static bool IsAOT
	{
		get
		{
			if (Instance == null)
			{
				return false;
			}
			return Instance->IsAOTRuntime > 0;
		}
	}

	static SharedRuntimeState()
	{
	}

	public unsafe static void Initialize(IntPtr address)
	{
		Address = address;
		Malloc = (MallocDel)Marshal.GetDelegateForFunctionPointer(Instance->MallocFuncPtr, typeof(MallocDel));
		Realloc = (ReallocDel)Marshal.GetDelegateForFunctionPointer(Instance->ReallocFuncPtr, typeof(ReallocDel));
		Free = (FreeDel)Marshal.GetDelegateForFunctionPointer(Instance->FreeFuncPtr, typeof(FreeDel));
		MessageBox = (MessageBoxDel)Marshal.GetDelegateForFunctionPointer(Instance->MessageBoxPtr, typeof(MessageBoxDel));
		LogMsg = (LogMsgDel)Marshal.GetDelegateForFunctionPointer(Instance->LogPtr, typeof(LogMsgDel));
	}

	public unsafe static bool HaveMultipleRuntimesInitialized()
	{
		if (Instance == null)
		{
			return false;
		}
		return HasMoreThanOneFlag(Instance->InitializedRuntimes);
	}

	public unsafe static bool HaveMultipleRuntimesLoaded()
	{
		if (Instance == null)
		{
			return false;
		}
		return HasMoreThanOneFlag(Instance->LoadedRuntimes);
	}

	private static bool HasMoreThanOneFlag(EDotNetRuntime flags)
	{
		return (flags & (flags - 1)) != 0;
	}

	public unsafe static bool IsRuntimeInitialized(EDotNetRuntime runtime)
	{
		if (Instance == null)
		{
			return false;
		}
		return (Instance->InitializedRuntimes & runtime) == runtime;
	}

	public unsafe static bool IsRuntimeLoaded(EDotNetRuntime runtime)
	{
		if (Instance == null)
		{
			return false;
		}
		return (Instance->LoadedRuntimes & runtime) == runtime;
	}

	public unsafe static EDotNetRuntime GetInitializedRuntimes()
	{
		if (Instance == null)
		{
			return EDotNetRuntime.None;
		}
		return Instance->InitializedRuntimes;
	}

	public unsafe static EDotNetRuntime GetLoadedRuntimes()
	{
		if (Instance == null)
		{
			return EDotNetRuntime.None;
		}
		return Instance->LoadedRuntimes;
	}

	public unsafe static byte[] GetHotReloadData()
	{
		return GetData(Instance->HotReloadData, Instance->HotReloadDataLen);
	}

	public unsafe static string[] GetHotReloadAssemblyPaths()
	{
		byte[] data = GetData(Instance->HotReloadAssemblyPaths, Instance->HotReloadAssemblyPathsLen);
		if (data != null && data.Length != 0)
		{
			using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(data)))
			{
				int num = binaryReader.ReadInt32();
				string[] array = new string[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = binaryReader.ReadString();
				}
				return array;
			}
		}
		return new string[0];
	}

	public unsafe static void SetHotReloadData(byte[] data)
	{
		SetData(data, &Instance->HotReloadData, &Instance->HotReloadDataLenInMemory, &Instance->HotReloadDataLen);
	}

	public unsafe static void SetHotReloadAssemblyPaths(string[] assemblyPaths)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		if (assemblyPaths == null)
		{
			binaryWriter.Write(0);
		}
		else
		{
			binaryWriter.Write(assemblyPaths.Length);
			foreach (string text in assemblyPaths)
			{
				binaryWriter.Write((text == null) ? string.Empty : text);
			}
		}
		binaryWriter.Flush();
		SetData(memoryStream.ToArray(), &Instance->HotReloadAssemblyPaths, &Instance->HotReloadAssemblyPathsLenInMemory, &Instance->HotReloadAssemblyPathsLen);
	}

	private static byte[] GetData(IntPtr dataPtr, int dataLen)
	{
		byte[] array = new byte[dataLen];
		if (dataPtr != IntPtr.Zero)
		{
			Marshal.Copy(dataPtr, array, 0, dataLen);
		}
		return array;
	}

	private unsafe static void SetData(byte[] data, IntPtr* dataPtr, int* dataLenInMemory, int* dataLen)
	{
		if (data != null && data.Length != 0)
		{
			if (*dataPtr == IntPtr.Zero)
			{
				*dataPtr = Malloc((IntPtr)data.Length);
				*dataLenInMemory = data.Length;
			}
			else if (*dataLenInMemory < data.Length)
			{
				*dataPtr = Realloc(*dataPtr, (IntPtr)data.Length);
				*dataLenInMemory = data.Length;
			}
			*dataLen = data.Length;
			Marshal.Copy(data, 0, *dataPtr, data.Length);
		}
		else if (*dataPtr != IntPtr.Zero)
		{
			*dataLen = 0;
		}
	}

	public static string GetRuntimeInfo(bool loadedRuntimesInfo)
	{
		string empty = string.Empty;
		empty = ((CurrentRuntime == EDotNetRuntime.IL2CPP) ? "IL2CPP" : ((CurrentRuntime == EDotNetRuntime.Mono) ? "Mono" : ((CurrentRuntime != EDotNetRuntime.CoreCLR) ? "CLR" : "CoreCLR")));
		if (loadedRuntimesInfo)
		{
			if (HaveMultipleRuntimesLoaded())
			{
				empty = empty + " (" + GetLoadedRuntimes().ToString() + " are loaded)";
			}
		}
		else if (HaveMultipleRuntimesInitialized())
		{
			empty = empty + " (" + GetInitializedRuntimes().ToString() + " are initialized)";
		}
		return empty;
	}

	public static void Log(byte verbosity, string message)
	{
		LogMsg(verbosity, message);
	}

	public static void Log(string message)
	{
		Log(5, message);
	}

	public static void LogWarning(string message)
	{
		Log(3, message);
	}

	public static void LogError(string message)
	{
		Log(2, message);
	}
}
