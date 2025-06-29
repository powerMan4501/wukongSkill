using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class IConsoleManager
{
	private class ManagedCommand
	{
		public Delegate Command { get; set; }

		public IConsoleCommand NativeCommand { get; set; }

		public ManagedCommand(Delegate command, IConsoleCommand nativeCommand)
		{
			Command = command;
			NativeCommand = nativeCommand;
		}
	}

	private static IConsoleManager singleton;

	private static Dictionary<IntPtr, Native_IConsoleVariable.FConsoleVariableDelegate> managedVariableOnChangedHandlers = new Dictionary<IntPtr, Native_IConsoleVariable.FConsoleVariableDelegate>();

	private static Dictionary<FDelegateHandle, FConsoleCommandDelegate> managedVariableSinkHandlers = new Dictionary<FDelegateHandle, FConsoleCommandDelegate>();

	private static Dictionary<IntPtr, ManagedCommand> managedCommands = new Dictionary<IntPtr, ManagedCommand>();

	public IntPtr Address { get; private set; }

	public IConsoleManager(IntPtr address)
	{
		Address = address;
	}

	public static IConsoleManager Get()
	{
		IntPtr intPtr = Native_IConsoleManager.Get();
		if (singleton == null || singleton.Address != intPtr)
		{
			singleton = new IConsoleManager(intPtr);
		}
		return singleton;
	}

	public IConsoleVariable RegisterConsoleVariable(string name, int defaultValue, string help, EConsoleVariableFlags flags = EConsoleVariableFlags.Default)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(help);
		IntPtr intPtr = Native_IConsoleManager.RegisterConsoleVariableInt(Address, ref fStringUnsafe.Array, defaultValue, ref fStringUnsafe2.Array, flags);
		return (intPtr == IntPtr.Zero) ? null : new IConsoleVariable(intPtr);
	}

	public IConsoleVariable RegisterConsoleVariable(string name, float defaultValue, string help, EConsoleVariableFlags flags = EConsoleVariableFlags.Default)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(help);
		IntPtr intPtr = Native_IConsoleManager.RegisterConsoleVariableFloat(Address, ref fStringUnsafe.Array, defaultValue, ref fStringUnsafe2.Array, flags);
		return (intPtr == IntPtr.Zero) ? null : new IConsoleVariable(intPtr);
	}

	public IConsoleVariable RegisterConsoleVariable(string name, string defaultValue, string help, EConsoleVariableFlags flags = EConsoleVariableFlags.Default)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(help);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe(defaultValue);
		IntPtr intPtr = Native_IConsoleManager.RegisterConsoleVariableString(Address, ref fStringUnsafe.Array, ref fStringUnsafe3.Array, ref fStringUnsafe2.Array, flags);
		return (intPtr == IntPtr.Zero) ? null : new IConsoleVariable(intPtr);
	}

	public void CallAllConsoleVariableSinks()
	{
		Native_IConsoleManager.CallAllConsoleVariableSinks(Address);
	}

	public FDelegateHandle RegisterConsoleVariableSink(FConsoleCommandDelegate handler)
	{
		FDelegateHandle outHandle = default(FDelegateHandle);
		Native_IConsoleManager.RegisterConsoleVariableSink_Handle(Address, handler, ref outHandle);
		managedVariableSinkHandlers[outHandle] = handler;
		return outHandle;
	}

	public void UnregisterConsoleVariableSink(FDelegateHandle handle)
	{
		managedVariableSinkHandlers.Remove(handle);
		Native_IConsoleManager.UnregisterConsoleVariableSink_Handle(Address, ref handle);
	}

	public IConsoleCommand RegisterConsoleCommand(string name, string help, FConsoleCommandDelegate command)
	{
		return RegisterConsoleCommand(name, help, command, CommandDelegateType.Default);
	}

	public IConsoleCommand RegisterConsoleCommandWithArgs(string name, string help, FConsoleCommandWithArgsDelegate command)
	{
		return RegisterConsoleCommand(name, help, command, CommandDelegateType.WithArgs);
	}

	public IConsoleCommand RegisterConsoleCommandWithWorld(string name, string help, FConsoleCommandWithWorldDelegate command)
	{
		return RegisterConsoleCommand(name, help, command, CommandDelegateType.WithWorld);
	}

	public IConsoleCommand RegisterConsoleCommandWithOutputDevice(string name, string help, FConsoleCommandWithOutputDeviceDelegate command)
	{
		return RegisterConsoleCommand(name, help, command, CommandDelegateType.WithOutputDevice);
	}

	public IConsoleCommand RegisterConsoleCommandWithWorldAndArgs(string name, string help, FConsoleCommandWithWorldAndArgsDelegate command)
	{
		return RegisterConsoleCommand(name, help, command, CommandDelegateType.WithWorldAndArgs);
	}

	private bool CheckCommandIsValid(string name, Delegate command, CommandDelegateType type, out string errorMsg)
	{
		if (command.Target != null)
		{
			errorMsg = "failed to register console command: " + name + ", reason: command is not static";
			return false;
		}
		CustomAttributeData customAttribute = command.Method.CustomAttributes.FirstOrDefault((CustomAttributeData item) => item.ToString().Contains("MonoPInvokeCallbackAttribute"));
		if (customAttribute == null)
		{
			errorMsg = "failed to register console command: " + name + ", reason: command does not have attribute MonoPInvokeCallbackAttribute";
			return false;
		}
		switch (type)
		{
		case CommandDelegateType.Default:
			if (!HasDelegate("Del_Void", command, 0))
			{
				errorMsg = "failed to register console command: " + name + ", reason: please use Del_Void and make sure parameter is (Void)";
				return false;
			}
			break;
		case CommandDelegateType.WithArgs:
		case CommandDelegateType.WithWorld:
		case CommandDelegateType.WithOutputDevice:
			if (!HasDelegate("Del_VoidIntPtr", command, 1))
			{
				errorMsg = "failed to register console command: " + name + ", reason: please use Del_VoidIntPtr and make sure parameter is (IntPtr)";
				return false;
			}
			break;
		case CommandDelegateType.WithWorldAndArgs:
			if (!HasDelegate("Del_VoidIntPtrIntPtr", command, 2))
			{
				errorMsg = "failed to register console command: " + name + ", reason: please use Del_VoidIntPtrIntPtr and make sure parameter is (IntPtr, IntPtr)";
				return false;
			}
			break;
		}
		errorMsg = string.Empty;
		return true;
		bool HasDelegate(string delegateName, Delegate CmdDel, int ParamCount)
		{
			return customAttribute.ConstructorArguments.Any((CustomAttributeTypedArgument argument) => (argument.Value as Type).Name.EndsWith(delegateName)) & (CmdDel.Method.GetParameters().Length == ParamCount);
		}
	}

	private IConsoleCommand RegisterConsoleCommand(string name, string help, Delegate command, CommandDelegateType type, EConsoleVariableFlags flags = EConsoleVariableFlags.Default)
	{
		if (!CheckCommandIsValid(name, command, type, out var _))
		{
			return null;
		}
		if (Native_IConsoleManager.RegisterConsoleCommandDefault != null)
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
			using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(help);
			IntPtr intPtr = IntPtr.Zero;
			switch (type)
			{
			case CommandDelegateType.Default:
				intPtr = Native_IConsoleManager.RegisterConsoleCommandDefault(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, Marshal.GetFunctionPointerForDelegate(command), flags);
				break;
			case CommandDelegateType.IL2CPPNative:
				intPtr = Native_IConsoleManager.RegisterConsoleCommandWithArgs(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, Marshal.GetFunctionPointerForDelegate(command), flags);
				break;
			case CommandDelegateType.WithArgs:
				intPtr = Native_IConsoleManager.RegisterConsoleCommandWithArgs(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, Marshal.GetFunctionPointerForDelegate(command), flags);
				break;
			case CommandDelegateType.WithWorld:
				intPtr = Native_IConsoleManager.RegisterConsoleCommandWithWorld(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, Marshal.GetFunctionPointerForDelegate(command), flags);
				break;
			case CommandDelegateType.WithWorldAndArgs:
				intPtr = Native_IConsoleManager.RegisterConsoleCommandWithWorldAndArgs(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, Marshal.GetFunctionPointerForDelegate(command), flags);
				break;
			case CommandDelegateType.WithOutputDevice:
				intPtr = Native_IConsoleManager.RegisterConsoleCommandWithOutputDevice(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, Marshal.GetFunctionPointerForDelegate(command), flags);
				break;
			}
			if (intPtr != IntPtr.Zero)
			{
				IConsoleCommand consoleCommand = new IConsoleCommand(intPtr);
				ManagedCommand value = new ManagedCommand(command, consoleCommand);
				managedCommands[intPtr] = value;
				return consoleCommand;
			}
		}
		return null;
	}

	public IConsoleCommand RegisterConsoleCommandExec(string name, string help, EConsoleVariableFlags flags = EConsoleVariableFlags.Default)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(help);
		IntPtr intPtr = Native_IConsoleManager.RegisterConsoleCommandExec(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, flags);
		return (intPtr == IntPtr.Zero) ? null : new IConsoleCommand(intPtr);
	}

	public void UnregisterConsoleObject(IConsoleObject consoleObject, bool keepState = true)
	{
		if (!(consoleObject == null))
		{
			if (managedVariableOnChangedHandlers.TryGetValue(consoleObject.Address, out var _))
			{
				Native_IConsoleVariable.ClearOnChangedCallback(consoleObject.Address);
				managedVariableOnChangedHandlers.Remove(consoleObject.Address);
			}
			if (managedCommands.ContainsKey(consoleObject.Address))
			{
				managedCommands.Remove(consoleObject.Address);
			}
			Native_IConsoleManager.UnregisterConsoleObject(Address, consoleObject.Address, keepState);
		}
	}

	public IConsoleVariable FindConsoleVariable(string name)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		IntPtr intPtr = Native_IConsoleManager.FindConsoleVariable(Address, ref fStringUnsafe.Array);
		return (intPtr == IntPtr.Zero) ? null : new IConsoleVariable(intPtr);
	}

	public IConsoleObject FindConsoleObject(string name)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		IntPtr intPtr = Native_IConsoleManager.FindConsoleObject(Address, ref fStringUnsafe.Array);
		if (intPtr != IntPtr.Zero)
		{
			IConsoleObject consoleObject = new IConsoleObject(intPtr);
			IConsoleObject consoleObject2 = consoleObject.AsVariable();
			if (consoleObject2 != null)
			{
				return consoleObject2;
			}
			IConsoleCommand consoleCommand = consoleObject.AsCommand();
			if (consoleCommand != null)
			{
				return consoleCommand;
			}
			return consoleObject;
		}
		return null;
	}

	public void ForEachConsoleObjectThatStartsWith(FConsoleObjectVisitor visitor, string startsWith = "")
	{
		ForEachConsoleObject(visitor, startsWith, startsWith: true);
	}

	public void ForEachConsoleObjectThatContains(FConsoleObjectVisitor visitor, string contains)
	{
		ForEachConsoleObject(visitor, contains, startsWith: false);
	}

	public Dictionary<string, IConsoleObject> GetConsoleObjectsThatStartsWith(string startsWith = "")
	{
		return GetConsoleObjects(startsWith, startsWith: true);
	}

	public Dictionary<string, IConsoleObject> GetConsoleObjectsThatContains(string contains)
	{
		return GetConsoleObjects(contains, startsWith: false);
	}

	private Dictionary<string, IConsoleObject> GetConsoleObjects(string str, bool startsWith)
	{
		Dictionary<string, IConsoleObject> result = new Dictionary<string, IConsoleObject>();
		FConsoleObjectVisitor visitor = delegate(string name, IConsoleObject consoleObject)
		{
			result[name] = consoleObject;
		};
		ForEachConsoleObject(visitor, str, startsWith);
		return result;
	}

	private void ForEachConsoleObject(FConsoleObjectVisitor visitor, string str, bool startsWith)
	{
		if (visitor == null)
		{
			return;
		}
		Native_IConsoleManager.FConsoleObjectVisitor visitor2 = delegate(IntPtr namePtr, IntPtr consoleObjectAddress)
		{
			string name = FStringMarshaler.FromCharPtr(namePtr);
			IConsoleObject consoleObject = new IConsoleObject(consoleObjectAddress);
			visitor(name, consoleObject);
		};
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		if (startsWith)
		{
			Native_IConsoleManager.ForEachConsoleObjectThatStartsWith(Address, visitor2, ref fStringUnsafe.Array);
		}
		else
		{
			Native_IConsoleManager.ForEachConsoleObjectThatContains(Address, visitor2, ref fStringUnsafe.Array);
		}
	}

	public bool ProcessUserConsoleInput(string input, UObject world)
	{
		return ProcessUserConsoleInput(input, world, FGlobals.GLog);
	}

	public bool ProcessUserConsoleInput(string input, UObject world, IntPtr outputDevice)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(input);
		return Native_IConsoleManager.ProcessUserConsoleInput(Address, ref fStringUnsafe.Array, outputDevice, (world == null) ? IntPtr.Zero : world.Address);
	}

	public void AddConsoleHistoryEntry(string key, string input)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(input);
		Native_IConsoleManager.AddConsoleHistoryEntry(Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public string[] GetConsoleHistory(string key)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		using TArrayUnsafe<string> tArrayUnsafe = new TArrayUnsafe<string>();
		Native_IConsoleManager.GetConsoleHistory(Address, ref fStringUnsafe.Array, tArrayUnsafe.Address);
		return tArrayUnsafe.ToArray();
	}

	public bool IsNameRegistered(string name)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return Native_IConsoleManager.IsNameRegistered(Address, ref fStringUnsafe.Array);
	}

	internal void SetOnChangedCallback(IConsoleVariable consoleVariable, Native_IConsoleVariable.FConsoleVariableDelegate callback)
	{
		if (!(consoleVariable == null) && callback != null && CheckCallbackIsValid(callback, out var _))
		{
			managedVariableOnChangedHandlers[consoleVariable.Address] = callback;
			Native_IConsoleVariable.SetOnChangedCallback(consoleVariable.Address, callback);
		}
	}

	private bool CheckCallbackIsValid(Native_IConsoleVariable.FConsoleVariableDelegate callback, out string errorMsg)
	{
		if (callback.Target != null)
		{
			errorMsg = "failed to SetOnChangedCallback, reason: callback is not static";
			return false;
		}
		if (callback.Method.CustomAttributes.FirstOrDefault((CustomAttributeData item) => item.ToString().Contains("MonoPInvokeCallbackAttribute")) == null)
		{
			errorMsg = "failed to SetOnChangedCallback, reason: callback does not have attribute MonoPInvokeCallbackAttribute";
			return false;
		}
		errorMsg = string.Empty;
		return true;
	}

	internal static void OnUnload()
	{
		IConsoleManager consoleManager = Get();
		foreach (KeyValuePair<IntPtr, ManagedCommand> item in managedCommands.ToList())
		{
			consoleManager.UnregisterConsoleObject(item.Value.NativeCommand);
		}
		foreach (KeyValuePair<FDelegateHandle, FConsoleCommandDelegate> item2 in new Dictionary<FDelegateHandle, FConsoleCommandDelegate>(managedVariableSinkHandlers))
		{
			consoleManager.UnregisterConsoleVariableSink(item2.Key);
		}
		foreach (KeyValuePair<IntPtr, Native_IConsoleVariable.FConsoleVariableDelegate> item3 in new Dictionary<IntPtr, Native_IConsoleVariable.FConsoleVariableDelegate>(managedVariableOnChangedHandlers))
		{
			consoleManager.UnregisterConsoleObject(new IConsoleVariable(item3.Key));
		}
		managedVariableOnChangedHandlers.Clear();
		managedVariableSinkHandlers.Clear();
		managedCommands.Clear();
	}

	public static string[] GetArgsHelper(IntPtr argsPtr)
	{
		string[] array = null;
		if (argsPtr == IntPtr.Zero)
		{
			return new string[0];
		}
		return new TArrayUnsafeRef<string>(argsPtr).ToArray();
	}

	public static UObject GetWorldHelper(IntPtr worldPtr)
	{
		return GCHelper.Find<UObject>(worldPtr);
	}
}
