using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

public struct FActionKeyMapping
{
	public UInputAction InputAction { get; private set; }

	public FKey Key { get; private set; }

	public UInputAction ChordAction { get; }

	public FActionKeyMapping(UInputAction InputAction, FKey Key, UInputAction ChordAction)
	{
		this.InputAction = InputAction;
		this.Key = Key;
		this.ChordAction = ChordAction;
	}

	public bool IsChord()
	{
		return ChordAction != null;
	}
}
