using System.Runtime.CompilerServices;

namespace System.Collections.Specialized;

[TypeForwardedFrom("WindowsBase, Version=3.0.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
[global::__DynamicallyInvokable]
public class NotifyCollectionChangedEventArgs : EventArgs
{
	private NotifyCollectionChangedAction _action;

	private IList _newItems;

	private IList _oldItems;

	private int _newStartingIndex = -1;

	private int _oldStartingIndex = -1;

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedAction Action
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _action;
		}
	}

	[global::__DynamicallyInvokable]
	public IList NewItems
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _newItems;
		}
	}

	[global::__DynamicallyInvokable]
	public IList OldItems
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _oldItems;
		}
	}

	[global::__DynamicallyInvokable]
	public int NewStartingIndex
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _newStartingIndex;
		}
	}

	[global::__DynamicallyInvokable]
	public int OldStartingIndex
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _oldStartingIndex;
		}
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
	{
		if (action != NotifyCollectionChangedAction.Reset)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Reset), "action");
		}
		InitializeAdd(action, null, -1);
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
	{
		if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
		{
			throw new ArgumentException(SR.GetString("MustBeResetAddOrRemoveActionForCtor"), "action");
		}
		if (action == NotifyCollectionChangedAction.Reset)
		{
			if (changedItem != null)
			{
				throw new ArgumentException(SR.GetString("ResetActionRequiresNullItem"), "action");
			}
			InitializeAdd(action, null, -1);
		}
		else
		{
			InitializeAddOrRemove(action, new object[1] { changedItem }, -1);
		}
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
	{
		if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
		{
			throw new ArgumentException(SR.GetString("MustBeResetAddOrRemoveActionForCtor"), "action");
		}
		if (action == NotifyCollectionChangedAction.Reset)
		{
			if (changedItem != null)
			{
				throw new ArgumentException(SR.GetString("ResetActionRequiresNullItem"), "action");
			}
			if (index != -1)
			{
				throw new ArgumentException(SR.GetString("ResetActionRequiresIndexMinus1"), "action");
			}
			InitializeAdd(action, null, -1);
		}
		else
		{
			InitializeAddOrRemove(action, new object[1] { changedItem }, index);
		}
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
	{
		if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
		{
			throw new ArgumentException(SR.GetString("MustBeResetAddOrRemoveActionForCtor"), "action");
		}
		if (action == NotifyCollectionChangedAction.Reset)
		{
			if (changedItems != null)
			{
				throw new ArgumentException(SR.GetString("ResetActionRequiresNullItem"), "action");
			}
			InitializeAdd(action, null, -1);
		}
		else
		{
			if (changedItems == null)
			{
				throw new ArgumentNullException("changedItems");
			}
			InitializeAddOrRemove(action, changedItems, -1);
		}
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
	{
		if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
		{
			throw new ArgumentException(SR.GetString("MustBeResetAddOrRemoveActionForCtor"), "action");
		}
		if (action == NotifyCollectionChangedAction.Reset)
		{
			if (changedItems != null)
			{
				throw new ArgumentException(SR.GetString("ResetActionRequiresNullItem"), "action");
			}
			if (startingIndex != -1)
			{
				throw new ArgumentException(SR.GetString("ResetActionRequiresIndexMinus1"), "action");
			}
			InitializeAdd(action, null, -1);
		}
		else
		{
			if (changedItems == null)
			{
				throw new ArgumentNullException("changedItems");
			}
			if (startingIndex < -1)
			{
				throw new ArgumentException(SR.GetString("IndexCannotBeNegative"), "startingIndex");
			}
			InitializeAddOrRemove(action, changedItems, startingIndex);
		}
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
	{
		if (action != NotifyCollectionChangedAction.Replace)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Replace), "action");
		}
		InitializeMoveOrReplace(action, new object[1] { newItem }, new object[1] { oldItem }, -1, -1);
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
	{
		if (action != NotifyCollectionChangedAction.Replace)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Replace), "action");
		}
		InitializeMoveOrReplace(action, new object[1] { newItem }, new object[1] { oldItem }, index, index);
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
	{
		if (action != NotifyCollectionChangedAction.Replace)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Replace), "action");
		}
		if (newItems == null)
		{
			throw new ArgumentNullException("newItems");
		}
		if (oldItems == null)
		{
			throw new ArgumentNullException("oldItems");
		}
		InitializeMoveOrReplace(action, newItems, oldItems, -1, -1);
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
	{
		if (action != NotifyCollectionChangedAction.Replace)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Replace), "action");
		}
		if (newItems == null)
		{
			throw new ArgumentNullException("newItems");
		}
		if (oldItems == null)
		{
			throw new ArgumentNullException("oldItems");
		}
		InitializeMoveOrReplace(action, newItems, oldItems, startingIndex, startingIndex);
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
	{
		if (action != NotifyCollectionChangedAction.Move)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Move), "action");
		}
		if (index < 0)
		{
			throw new ArgumentException(SR.GetString("IndexCannotBeNegative"), "index");
		}
		object[] array = new object[1] { changedItem };
		InitializeMoveOrReplace(action, array, array, index, oldIndex);
	}

	[global::__DynamicallyInvokable]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
	{
		if (action != NotifyCollectionChangedAction.Move)
		{
			throw new ArgumentException(SR.GetString("WrongActionForCtor", NotifyCollectionChangedAction.Move), "action");
		}
		if (index < 0)
		{
			throw new ArgumentException(SR.GetString("IndexCannotBeNegative"), "index");
		}
		InitializeMoveOrReplace(action, changedItems, changedItems, index, oldIndex);
	}

	internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int newIndex, int oldIndex)
	{
		_action = action;
		_newItems = ((newItems == null) ? null : ArrayList.ReadOnly(newItems));
		_oldItems = ((oldItems == null) ? null : ArrayList.ReadOnly(oldItems));
		_newStartingIndex = newIndex;
		_oldStartingIndex = oldIndex;
	}

	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
	{
		switch (action)
		{
		case NotifyCollectionChangedAction.Add:
			InitializeAdd(action, changedItems, startingIndex);
			break;
		case NotifyCollectionChangedAction.Remove:
			InitializeRemove(action, changedItems, startingIndex);
			break;
		}
	}

	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex)
	{
		_action = action;
		_newItems = ((newItems == null) ? null : ArrayList.ReadOnly(newItems));
		_newStartingIndex = newStartingIndex;
	}

	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex)
	{
		_action = action;
		_oldItems = ((oldItems == null) ? null : ArrayList.ReadOnly(oldItems));
		_oldStartingIndex = oldStartingIndex;
	}

	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex)
	{
		InitializeAdd(action, newItems, startingIndex);
		InitializeRemove(action, oldItems, oldStartingIndex);
	}
}
