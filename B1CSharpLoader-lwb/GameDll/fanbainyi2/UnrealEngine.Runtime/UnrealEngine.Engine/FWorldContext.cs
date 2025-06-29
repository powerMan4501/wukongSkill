using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FWorldContext
{
	public IntPtr Address;

	public bool IsNull => Address == IntPtr.Zero;

	public EWorldType WorldType => (EWorldType)Native_FWorldContext.Get_WorldType(Address);

	public FName ContextHandle
	{
		get
		{
			Native_FWorldContext.Get_ContextHandle(Address, out var result);
			return result;
		}
	}

	public string TravelURL
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FWorldContext.Get_TravelURL(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public ETravelType TravelType => (ETravelType)Native_FWorldContext.Get_TravelType(Address);

	public IntPtr GameViewport => Native_FWorldContext.Get_GameViewport(Address);

	public IntPtr OwningGameInstance => Native_FWorldContext.Get_OwningGameInstance(Address);

	public int PIEInstance => Native_FWorldContext.Get_PIEInstance(Address);

	public string PIEPrefix
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FWorldContext.Get_PIEPrefix(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public bool RunAsDedicated => Native_FWorldContext.Get_RunAsDedicated(Address);

	public bool WaitingOnOnlineSubsystem => Native_FWorldContext.Get_bWaitingOnOnlineSubsystem(Address);

	public uint AudioDeviceHandle => Native_FWorldContext.Get_AudioDeviceHandle(Address);

	public IntPtr CurrentWorld => Native_FWorldContext.World(Address);

	public void SetCurrentWorld(IntPtr world)
	{
		Native_FWorldContext.SetCurrentWorld(Address, world);
	}

	public FWorldContext(IntPtr address)
	{
		Address = address;
	}
}
