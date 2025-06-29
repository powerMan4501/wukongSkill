using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ActionBinding1P
{
	public EGameKeyType Key;

	public EInputEventType KeyEvent;

	public Action<FVector2D, float> ActionDelegate;

	public ActionBinding1P(EGameKeyType KeyType, EInputEventType EventType, Action<FVector2D, float> Delegate)
	{
		Key = KeyType;
		KeyEvent = EventType;
		ActionDelegate = Delegate;
	}
}
