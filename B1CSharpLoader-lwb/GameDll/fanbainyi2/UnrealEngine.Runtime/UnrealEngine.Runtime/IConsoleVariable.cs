using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class IConsoleVariable : IConsoleObject
{
	public IConsoleVariable(IntPtr address)
		: base(address)
	{
	}

	public int GetInt()
	{
		return Native_IConsoleVariable.GetInt(base.Address);
	}

	public float GetFloat()
	{
		return Native_IConsoleVariable.GetFloat(base.Address);
	}

	public string GetString()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_IConsoleVariable.GetString(base.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void Set(int value, EConsoleVariableFlags setBy = EConsoleVariableFlags.SetByCode)
	{
		Native_IConsoleVariable.SetInt(base.Address, value, setBy);
	}

	public void Set(float value, EConsoleVariableFlags setBy = EConsoleVariableFlags.SetByCode)
	{
		Native_IConsoleVariable.SetFloat(base.Address, value, setBy);
	}

	public void Set(string value, EConsoleVariableFlags setBy = EConsoleVariableFlags.SetByCode)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
		Native_IConsoleVariable.SetString(base.Address, ref fStringUnsafe.Array, setBy);
	}

	public void SetOnChangedCallback(Native_IConsoleVariable.FConsoleVariableDelegate callback)
	{
		IConsoleManager.Get().SetOnChangedCallback(this, callback);
	}
}
