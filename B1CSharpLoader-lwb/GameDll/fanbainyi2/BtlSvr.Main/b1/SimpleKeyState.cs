using System;
using UnrealEngine.Runtime;

namespace b1;

internal class SimpleKeyState
{
	public uint[] Events;

	public bool bDown;

	public FVector2D Position;

	public FVector2D Position2;

	public float DownTime;

	public SimpleKeyState()
	{
		Events = new uint[3];
		bDown = true;
		Position = FVector2D.ZeroVector;
		Position2 = FVector2D.ZeroVector;
		DownTime = 0f;
	}

	public void ClearEvents()
	{
		Array.Clear(Events, 0, Events.Length);
	}
}
