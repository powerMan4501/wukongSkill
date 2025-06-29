using System.Collections;

namespace System.Security.Policy;

internal sealed class CodeGroupStack
{
	private ArrayList m_array;

	internal CodeGroupStack()
	{
		m_array = new ArrayList();
	}

	internal void Push(CodeGroupStackFrame element)
	{
		m_array.Add(element);
	}

	internal CodeGroupStackFrame Pop()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EmptyStack"));
		}
		int count = m_array.Count;
		CodeGroupStackFrame result = (CodeGroupStackFrame)m_array[count - 1];
		m_array.RemoveAt(count - 1);
		return result;
	}

	internal bool IsEmpty()
	{
		return m_array.Count == 0;
	}
}
