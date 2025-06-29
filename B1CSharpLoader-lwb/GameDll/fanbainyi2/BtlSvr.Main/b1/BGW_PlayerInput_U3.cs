using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PlayerInput_U3")]
internal class BGW_PlayerInput_U3 : UObject
{
	public List<ActionBinding1P> ActionBindings1P = new List<ActionBinding1P>();

	public List<ActionBinding2P> ActionBindings2P = new List<ActionBinding2P>();

	private Dictionary<EGameKeyType, b1.SimpleKeyState> KeyStateMap = new Dictionary<EGameKeyType, b1.SimpleKeyState>();

	private FVector2D[] TouchAnchors = new FVector2D[2]
	{
		FVector2D.ZeroVector,
		FVector2D.ZeroVector
	};

	private float Touch0DownTime;

	private float TwoPointsDownTime;

	private float MaxPinchDistanceSq;

	private uint PrevTouchState;

	private bool bOnePointsTouch;

	private bool bTwoPointsTouch;

	private readonly float MOUSE_MOVE_MIN_DIST = 10f;

	private float MaxSwipeDistance = 400f;

	private float PinchDistanceThreshold = 200f;

	private float PinchMoveThreshold = 50f;

	public void UpdateDetection(float DeltaTime)
	{
		UpdateGameKeys(DeltaTime);
		ProcessKeyStates(DeltaTime);
	}

	private void UpdateGameKeys(float DeltaTime)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GetOuter().Cast<b1.BGW_PlayerController_U3>();
		int playerInputTouchesCount = bGW_PlayerController_U.GetPlayerInputTouchesCount();
		uint num = 0u;
		for (int i = 0; i < playerInputTouchesCount; i++)
		{
			if (bGW_PlayerController_U.GetPlayerInputTouch(i).Z != 0f)
			{
				num |= (uint)(1 << i);
			}
		}
		FVector2D fVector2D = new FVector2D(bGW_PlayerController_U.GetPlayerInputTouch(0));
		FVector2D currentPosition = new FVector2D(bGW_PlayerController_U.GetPlayerInputTouch(1));
		DetectOnePointActions((num & 1) != 0, (PrevTouchState & 1) != 0, DeltaTime, fVector2D, ref TouchAnchors[0], ref Touch0DownTime);
		DetectTwoPointsActions((num & 1) != 0 && (num & 2) != 0, (PrevTouchState & 1) != 0 && (PrevTouchState & 2) != 0, DeltaTime, fVector2D, currentPosition);
		PrevTouchState = num;
	}

	private void ProcessKeyStates(float DeltaTime)
	{
		foreach (ActionBinding1P item in ActionBindings1P)
		{
			if (KeyStateMap.TryGetValue(item.Key, out var value) && value.Events[(uint)item.KeyEvent] != 0)
			{
				item.ActionDelegate?.Invoke(value.Position, value.DownTime);
			}
		}
		foreach (ActionBinding2P item2 in ActionBindings2P)
		{
			if (KeyStateMap.TryGetValue(item2.Key, out var value2) && value2.Events[(uint)item2.KeyEvent] != 0)
			{
				item2.ActionDelegate?.Invoke(value2.Position, value2.Position2, value2.DownTime);
			}
		}
		foreach (KeyValuePair<EGameKeyType, b1.SimpleKeyState> item3 in KeyStateMap)
		{
			b1.SimpleKeyState value3 = item3.Value;
			if (value3.Events[0] != 0)
			{
				value3.bDown = true;
			}
			else if (value3.Events[1] != 0)
			{
				value3.bDown = false;
			}
			value3.ClearEvents();
		}
	}

	private b1.SimpleKeyState FindOrAdd(EGameKeyType KeyType)
	{
		if (!KeyStateMap.TryGetValue(KeyType, out var value))
		{
			value = new b1.SimpleKeyState();
			KeyStateMap.Add(KeyType, value);
		}
		return value;
	}

	private void DetectOnePointActions(bool bCurrentState, bool bPrevState, float DeltaTime, FVector2D CurrentPosition, ref FVector2D AnchorPosition, ref float DownTime)
	{
		if (bCurrentState && !bTwoPointsTouch)
		{
			bOnePointsTouch = true;
			if (!bPrevState)
			{
				DownTime = 0f;
				AnchorPosition = CurrentPosition;
			}
			b1.SimpleKeyState simpleKeyState = FindOrAdd(EGameKeyType.Swipe);
			if (simpleKeyState.bDown)
			{
				simpleKeyState.Events[2]++;
				simpleKeyState.Position = CurrentPosition;
				simpleKeyState.DownTime = DownTime;
			}
			else if ((AnchorPosition - CurrentPosition).SizeSquared() > MOUSE_MOVE_MIN_DIST)
			{
				simpleKeyState.Events[0]++;
				simpleKeyState.Position = AnchorPosition;
				simpleKeyState.DownTime = DownTime;
			}
			if (DownTime + DeltaTime > 0.3f && DownTime <= 0.3f && !simpleKeyState.bDown)
			{
				b1.SimpleKeyState simpleKeyState2 = FindOrAdd(EGameKeyType.Hold);
				simpleKeyState2.Events[0]++;
				simpleKeyState2.Position = AnchorPosition;
				simpleKeyState2.DownTime = DownTime;
			}
			DownTime += DeltaTime;
			return;
		}
		bOnePointsTouch = false;
		if (!bPrevState)
		{
			return;
		}
		if ((AnchorPosition - CurrentPosition).SizeSquared() < MOUSE_MOVE_MIN_DIST)
		{
			if (DownTime < 0.3f)
			{
				b1.SimpleKeyState simpleKeyState3 = FindOrAdd(EGameKeyType.Tap);
				simpleKeyState3.Events[0]++;
				simpleKeyState3.Position = AnchorPosition;
				simpleKeyState3.DownTime = DownTime;
				bOnePointsTouch = true;
			}
			else
			{
				b1.SimpleKeyState simpleKeyState4 = FindOrAdd(EGameKeyType.Hold);
				if (simpleKeyState4.bDown)
				{
					simpleKeyState4.Events[1]++;
					simpleKeyState4.Position = AnchorPosition;
					simpleKeyState4.DownTime = DownTime;
				}
			}
		}
		b1.SimpleKeyState simpleKeyState5 = FindOrAdd(EGameKeyType.Swipe);
		if (simpleKeyState5.bDown)
		{
			simpleKeyState5.Events[1]++;
			simpleKeyState5.Position = CurrentPosition;
			simpleKeyState5.DownTime = DownTime;
		}
	}

	private void DetectTwoPointsActions(bool bCurrentState, bool bPrevState, float DeltaTime, FVector2D CurrentPosition1, FVector2D CurrentPosition2)
	{
		bTwoPointsTouch = bCurrentState;
		if (bCurrentState)
		{
			b1.SimpleKeyState simpleKeyState;
			b1.SimpleKeyState simpleKeyState2;
			if (!bPrevState)
			{
				TouchAnchors[0] = CurrentPosition1;
				TouchAnchors[1] = CurrentPosition2;
				TwoPointsDownTime = 0f;
				MaxPinchDistanceSq = 0f;
				if ((CurrentPosition1 - CurrentPosition2).SizeSquared() < FMath.Square(MaxSwipeDistance))
				{
					simpleKeyState = FindOrAdd(EGameKeyType.SwipeTwoPoints);
					simpleKeyState.Events[0]++;
					simpleKeyState.Position = CurrentPosition1;
					simpleKeyState.Position2 = CurrentPosition2;
					simpleKeyState.DownTime = TwoPointsDownTime;
				}
				simpleKeyState2 = FindOrAdd(EGameKeyType.Pinch);
				simpleKeyState2.Events[0]++;
				simpleKeyState2.Position = CurrentPosition1;
				simpleKeyState2.Position2 = CurrentPosition2;
				simpleKeyState2.DownTime = TwoPointsDownTime;
			}
			FVector2D fVector2D = (TouchAnchors[0] + TouchAnchors[1]) * 0.5;
			float num = ((CurrentPosition1 + CurrentPosition2) * 0.5 - fVector2D).SizeSquared();
			float val = FMath.Abs((CurrentPosition2 - CurrentPosition1).SizeSquared() - (TouchAnchors[1] - TouchAnchors[0]).SizeSquared());
			MaxPinchDistanceSq = FMath.Max(val, MaxPinchDistanceSq);
			simpleKeyState = FindOrAdd(EGameKeyType.SwipeTwoPoints);
			if (simpleKeyState.bDown)
			{
				bool flag = false;
				if (num < FMath.Square(PinchMoveThreshold) && MaxPinchDistanceSq > FMath.Square(PinchDistanceThreshold))
				{
					flag = true;
				}
				simpleKeyState.Events[flag ? 1 : 2]++;
				simpleKeyState.Position = CurrentPosition1;
				simpleKeyState.Position2 = CurrentPosition2;
				simpleKeyState.DownTime = TwoPointsDownTime;
			}
			simpleKeyState2 = FindOrAdd(EGameKeyType.Pinch);
			if (simpleKeyState2.bDown)
			{
				bool flag2 = false;
				if (num > FMath.Square(PinchMoveThreshold) && MaxPinchDistanceSq < FMath.Square(PinchDistanceThreshold))
				{
					flag2 = true;
				}
				simpleKeyState2.Events[flag2 ? 1 : 2]++;
				simpleKeyState2.Position = CurrentPosition1;
				simpleKeyState2.Position2 = CurrentPosition2;
				simpleKeyState2.DownTime = TwoPointsDownTime;
			}
			TwoPointsDownTime += DeltaTime;
		}
		else if (bPrevState)
		{
			b1.SimpleKeyState simpleKeyState = FindOrAdd(EGameKeyType.SwipeTwoPoints);
			if (simpleKeyState.bDown)
			{
				simpleKeyState.Events[1]++;
				simpleKeyState.Position = CurrentPosition1;
				simpleKeyState.Position2 = CurrentPosition2;
				simpleKeyState.DownTime = TwoPointsDownTime;
			}
			b1.SimpleKeyState simpleKeyState2 = FindOrAdd(EGameKeyType.Pinch);
			if (simpleKeyState2.bDown)
			{
				simpleKeyState2.Events[1]++;
				simpleKeyState2.Position = CurrentPosition1;
				simpleKeyState2.Position2 = CurrentPosition2;
				simpleKeyState2.DownTime = TwoPointsDownTime;
			}
		}
	}

	public FVector2D GetTouchAnchor(int i)
	{
		if (i < 0 || i >= TouchAnchors.Length)
		{
			return FVector2D.ZeroVector;
		}
		return TouchAnchors[i];
	}

	public bool IsOnePointsTouch()
	{
		return bOnePointsTouch;
	}

	public bool IsTwoPointsTouch()
	{
		return bTwoPointsTouch;
	}

	public void SetTwoPointsDistanceThreshold(float MaxSwipeDis, float PinchDis, float PinchMove)
	{
		MaxSwipeDistance = PinchMove;
		PinchDistanceThreshold = PinchDis;
		PinchMoveThreshold = PinchMove;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PlayerInput_U3");
	}

	static BGW_PlayerInput_U3()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW_PlayerInput_U3)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW_PlayerInput_U3));
	}
}
