using System.Collections;
using System.Security.Permissions;

namespace System.ComponentModel.Design.Serialization;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class ContextStack
{
	private ArrayList contextStack;

	public object Current
	{
		get
		{
			if (contextStack != null && contextStack.Count > 0)
			{
				return contextStack[contextStack.Count - 1];
			}
			return null;
		}
	}

	public object this[int level]
	{
		get
		{
			if (level < 0)
			{
				throw new ArgumentOutOfRangeException("level");
			}
			if (contextStack != null && level < contextStack.Count)
			{
				return contextStack[contextStack.Count - 1 - level];
			}
			return null;
		}
	}

	public object this[Type type]
	{
		get
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (contextStack != null)
			{
				int num = contextStack.Count;
				while (num > 0)
				{
					object obj = contextStack[--num];
					if (type.IsInstanceOfType(obj))
					{
						return obj;
					}
				}
			}
			return null;
		}
	}

	public void Append(object context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (contextStack == null)
		{
			contextStack = new ArrayList();
		}
		contextStack.Insert(0, context);
	}

	public object Pop()
	{
		object result = null;
		if (contextStack != null && contextStack.Count > 0)
		{
			int index = contextStack.Count - 1;
			result = contextStack[index];
			contextStack.RemoveAt(index);
		}
		return result;
	}

	public void Push(object context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (contextStack == null)
		{
			contextStack = new ArrayList();
		}
		contextStack.Add(context);
	}
}
