using System;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime.Native;

public struct FActorSpawnParametersInterop
{
	public FName Name;

	public IntPtr Template;

	public IntPtr Owner;

	public IntPtr Instigator;

	public IntPtr OverrideLevel;

	public IntPtr OverrideParentComponent;

	public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingOverride;

	public byte PackedBools;

	public ESpawnActorNameMode NameMode;

	public EObjectFlags ObjectFlags;

	public bool RemoteOwned
	{
		get
		{
			return GetBit(0);
		}
		set
		{
			SetBit(value, 0);
		}
	}

	public bool NoFail
	{
		get
		{
			return GetBit(1);
		}
		set
		{
			SetBit(value, 1);
		}
	}

	public bool DeferConstruction
	{
		get
		{
			return GetBit(2);
		}
		set
		{
			SetBit(value, 2);
		}
	}

	public bool AllowDuringConstructionScript
	{
		get
		{
			return GetBit(3);
		}
		set
		{
			SetBit(value, 3);
		}
	}

	private bool GetBit(int index)
	{
		return (PackedBools & (1 << index)) != 0;
	}

	private void SetBit(bool value, int index)
	{
		if (value)
		{
			PackedBools |= (byte)(1 << index);
		}
		else
		{
			PackedBools &= (byte)(~(1 << index));
		}
	}
}
