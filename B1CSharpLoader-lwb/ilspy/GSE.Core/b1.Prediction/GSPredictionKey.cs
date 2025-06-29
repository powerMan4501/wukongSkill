using System;
using System.Collections.Generic;

namespace b1.Prediction;

public class GSPredictionKey
{
	private int EventPredictionNodeIdAlloc;

	private List<IPredictableObject> RelatedObjectSet = new List<IPredictableObject>();

	private GSEventPredictionNode Root;

	private GSEventPredictionNode CurActiveEventNode;

	private GSEventPredictionNode CurConfirmingEventNode;

	private Stack<int> CompareNodeChildIdxStack = new Stack<int>();

	private GSPredictionKey ParentKey;

	private List<GSPredictionKey> ChildKeys = new List<GSPredictionKey>();

	public int Id { get; set; }

	public int ParentId
	{
		get
		{
			if (ParentKey == null)
			{
				return -1;
			}
			return ParentKey.Id;
		}
	}

	public bool NoConflict { get; private set; } = true;

	public void AddChild(GSPredictionKey Child)
	{
		ChildKeys.Add(Child);
		Child.ParentKey = this;
	}

	public void AddRelatedObject(IPredictableObject RelatedObject)
	{
		if (!RelatedObjectSet.Contains(RelatedObject))
		{
			RelatedObjectSet.Add(RelatedObject);
		}
	}

	public void RemoveRelatedObject(IPredictableObject RelatedObject)
	{
		RelatedObjectSet.Remove(RelatedObject);
	}

	public int PushRelatedEvent(int EventId)
	{
		EventPredictionNodeIdAlloc++;
		GSEventPredictionNode gSEventPredictionNode = new GSEventPredictionNode(EventPredictionNodeIdAlloc, EventId, CurActiveEventNode);
		if (Root == null)
		{
			Root = gSEventPredictionNode;
		}
		if (CurActiveEventNode != null)
		{
			CurActiveEventNode.Child.Add(gSEventPredictionNode);
		}
		CurActiveEventNode = gSEventPredictionNode;
		return EventPredictionNodeIdAlloc;
	}

	public void PopRelatedEvent()
	{
		if (CurActiveEventNode == null)
		{
			throw new Exception("PopRelatedEvent CurActiveEventNode == null");
		}
		CurActiveEventNode = CurActiveEventNode.Parent;
	}

	public void CompareRelatedEventBegin(int EventId)
	{
		if (NoConflict)
		{
			if (CurConfirmingEventNode == null)
			{
				CurConfirmingEventNode = Root;
				CompareNodeChildIdxStack.Push(0);
				NoConflict = CurConfirmingEventNode.EventId == EventId;
			}
			else if (CurConfirmingEventNode.Child.Count > CompareNodeChildIdxStack.Peek())
			{
				int num = CompareNodeChildIdxStack.Pop();
				CompareNodeChildIdxStack.Push(num + 1);
				CurConfirmingEventNode = CurConfirmingEventNode.Child[num];
				CompareNodeChildIdxStack.Push(0);
				NoConflict = CurConfirmingEventNode.EventId == EventId;
			}
			NoConflict = false;
		}
	}

	public void CompareRelatedEventEnd()
	{
		if (NoConflict)
		{
			if (CompareNodeChildIdxStack.Count == 0 || CurActiveEventNode == null)
			{
				NoConflict = false;
				return;
			}
			int num = CompareNodeChildIdxStack.Pop();
			NoConflict = CurConfirmingEventNode.Child.Count == num;
			CurConfirmingEventNode = CurConfirmingEventNode.Parent;
		}
	}

	public void DoConfirm()
	{
		foreach (IPredictableObject item in RelatedObjectSet)
		{
			item.OnConfirm(this);
		}
	}

	public void DoRollBack()
	{
		foreach (IPredictableObject item in RelatedObjectSet)
		{
			item.OnRollback(this);
		}
	}

	public override string ToString()
	{
		return $"Id:{Id}";
	}
}
