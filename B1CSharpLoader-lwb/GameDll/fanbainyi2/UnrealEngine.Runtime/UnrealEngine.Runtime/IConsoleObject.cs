using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class IConsoleObject : IEquatable<IConsoleObject>
{
	public IntPtr Address { get; private set; }

	public IConsoleObject(IntPtr address)
	{
		Address = address;
	}

	public string GetHelp()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_IConsoleObject.GetHelp(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void SetHelp(string help)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(help);
		Native_IConsoleObject.SetHelp(Address, ref fStringUnsafe.Array);
	}

	public EConsoleVariableFlags GetFlags()
	{
		return Native_IConsoleObject.GetFlags(Address);
	}

	public void SetFlags(EConsoleVariableFlags flags)
	{
		Native_IConsoleObject.SetFlags(Address, flags);
	}

	public void ClearFlags(EConsoleVariableFlags flags)
	{
		Native_IConsoleObject.ClearFlags(Address, flags);
	}

	public bool TestFlags(EConsoleVariableFlags flags)
	{
		return Native_IConsoleObject.TestFlags(Address, flags);
	}

	public IConsoleVariable AsVariable()
	{
		IntPtr intPtr = Native_IConsoleObject.AsVariable(Address);
		if (!(intPtr == IntPtr.Zero))
		{
			return new IConsoleVariable(intPtr);
		}
		return null;
	}

	public IConsoleCommand AsCommand()
	{
		IntPtr intPtr = Native_IConsoleObject.AsCommand(Address);
		if (!(intPtr == IntPtr.Zero))
		{
			return new IConsoleCommand(intPtr);
		}
		return null;
	}

	public static bool operator ==(IConsoleObject a, IConsoleObject b)
	{
		if ((object)a == null)
		{
			if ((object)b == null)
			{
				return true;
			}
			return false;
		}
		return a.Equals(b);
	}

	public static bool operator !=(IConsoleObject a, IConsoleObject b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as IConsoleObject);
	}

	public bool Equals(IConsoleObject other)
	{
		if ((object)other == null)
		{
			return false;
		}
		return Address.Equals(other.Address);
	}

	public override int GetHashCode()
	{
		return Address.GetHashCode();
	}
}
