using System;
using UnrealEngine.Runtime.Native;
using UnrealEngine.Slate;

namespace UnrealEngine.Engine;

public struct FInputKeyBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public EInputEventType KeyEvent
	{
		get
		{
			return (EInputEventType)Native_FInputKeyBinding.Get_KeyEvent(Address);
		}
		set
		{
			Native_FInputKeyBinding.Set_KeyEvent(Address, (byte)value);
		}
	}

	public FInputChord Chord
	{
		get
		{
			Native_FInputKeyBinding.Get_ChordEx(Address, out var key, out var shift, out var ctrl, out var alt, out var cmd);
			return new FInputChord
			{
				Key = key,
				Shift = shift,
				Ctrl = ctrl,
				Alt = alt,
				Cmd = cmd
			};
		}
		set
		{
			Native_FInputKeyBinding.Set_ChordEx(Address, ref value.Key, value.Shift, value.Ctrl, value.Alt, value.Cmd);
		}
	}

	public FInputActionUnifiedDelegateHandle KeyDelegate => (FInputActionUnifiedDelegateHandle)Native_FInputKeyBinding.Get_KeyDelegate(Address);

	public FInputKeyBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputKeyBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputKeyBindingHandle(IntPtr address)
	{
		return new FInputKeyBindingHandle(address);
	}
}
