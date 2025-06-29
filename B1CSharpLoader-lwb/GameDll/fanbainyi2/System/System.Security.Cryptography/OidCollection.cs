using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Cryptography;

public sealed class OidCollection : ICollection, IEnumerable
{
	private ArrayList m_list;

	public Oid this[int index] => m_list[index] as Oid;

	public Oid this[string oid]
	{
		get
		{
			string text = X509Utils.FindOidInfoWithFallback(2u, oid, OidGroup.All);
			if (text == null)
			{
				text = oid;
			}
			foreach (Oid item in m_list)
			{
				if (item.Value == text)
				{
					return item;
				}
			}
			return null;
		}
	}

	public int Count => m_list.Count;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	public OidCollection()
	{
		m_list = new ArrayList();
	}

	public int Add(Oid oid)
	{
		return m_list.Add(oid);
	}

	public OidEnumerator GetEnumerator()
	{
		return new OidEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new OidEnumerator(this);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(SR.GetString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0 || index >= array.Length)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("ArgumentOutOfRange_Index"));
		}
		if (index + Count > array.Length)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(this[i], index);
			index++;
		}
	}

	public void CopyTo(Oid[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}
}
