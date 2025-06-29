using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class IConsoleCommand : IConsoleObject
{
	public IConsoleCommand(IntPtr address)
		: base(address)
	{
	}

	public void Execute(string[] args, UObject world)
	{
		Execute(args, world, FGlobals.GLog);
	}

	public void Execute(string[] args, UObject world, IntPtr outputDevice)
	{
		using TArrayUnsafe<string> tArrayUnsafe = new TArrayUnsafe<string>();
		tArrayUnsafe.AddRange(args);
		Native_IConsoleCommand.Execute(base.Address, tArrayUnsafe.Address, (world == null) ? IntPtr.Zero : world.Address, outputDevice);
	}
}
