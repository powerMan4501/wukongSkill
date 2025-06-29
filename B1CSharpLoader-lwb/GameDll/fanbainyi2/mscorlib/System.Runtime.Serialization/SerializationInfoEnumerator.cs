using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[ComVisible(true)]
public sealed class SerializationInfoEnumerator : IEnumerator
{
	private string[] m_members;

	private object[] m_data;

	private Type[] m_types;

	private int m_numItems;

	private int m_currItem;

	private bool m_current;

	object IEnumerator.Current
	{
		get
		{
			if (!m_current)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
			}
			return new SerializationEntry(m_members[m_currItem], m_data[m_currItem], m_types[m_currItem]);
		}
	}

	public SerializationEntry Current
	{
		get
		{
			if (!m_current)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
			}
			return new SerializationEntry(m_members[m_currItem], m_data[m_currItem], m_types[m_currItem]);
		}
	}

	public string Name
	{
		get
		{
			if (!m_current)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
			}
			return m_members[m_currItem];
		}
	}

	public object Value
	{
		get
		{
			if (!m_current)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
			}
			return m_data[m_currItem];
		}
	}

	public Type ObjectType
	{
		get
		{
			if (!m_current)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumOpCantHappen"));
			}
			return m_types[m_currItem];
		}
	}

	internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems)
	{
		m_members = members;
		m_data = info;
		m_types = types;
		m_numItems = numItems - 1;
		m_currItem = -1;
		m_current = false;
	}

	public bool MoveNext()
	{
		if (m_currItem < m_numItems)
		{
			m_currItem++;
			m_current = true;
		}
		else
		{
			m_current = false;
		}
		return m_current;
	}

	public void Reset()
	{
		m_currItem = -1;
		m_current = false;
	}
}
