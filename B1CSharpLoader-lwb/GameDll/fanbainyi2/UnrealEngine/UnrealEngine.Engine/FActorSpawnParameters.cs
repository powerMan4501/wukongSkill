using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public struct FActorSpawnParameters
{
	public FName Name;

	public AActor Template;

	public AActor Owner;

	public APawn Instigator;

	public UObject OverrideLevel;

	public UPackage OverridePackage;

	public UChildActorComponent OverrideParentComponent;

	public Guid OverrideActorGuid;

	public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingOverride;

	public byte PackedBools;

	public EObjectFlags ObjectFlags;

	public ESpawnActorNameMode NameMode;

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

	public bool TemporaryEditorActor
	{
		get
		{
			return GetBit(4);
		}
		set
		{
			SetBit(value, 4);
		}
	}

	public bool HideFromSceneOutliner
	{
		get
		{
			return GetBit(5);
		}
		set
		{
			SetBit(value, 5);
		}
	}

	public bool CreateActorPackage
	{
		get
		{
			return GetBit(6);
		}
		set
		{
			SetBit(value, 6);
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
