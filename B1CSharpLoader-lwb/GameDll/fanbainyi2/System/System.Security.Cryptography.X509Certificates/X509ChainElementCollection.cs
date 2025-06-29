using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainElementCollection : ICollection, IEnumerable
{
	private X509ChainElement[] m_elements;

	public X509ChainElement this[int index]
	{
		get
		{
			if (index < 0)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_EnumNotStarted"));
			}
			if (index >= m_elements.Length)
			{
				throw new ArgumentOutOfRangeException("index", System.SR.GetString("ArgumentOutOfRange_Index"));
			}
			return m_elements[index];
		}
	}

	public int Count => m_elements.Length;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	internal X509ChainElementCollection()
	{
		m_elements = new X509ChainElement[0];
	}

	internal unsafe X509ChainElementCollection(IntPtr pSimpleChain)
	{
		CAPIBase.CERT_SIMPLE_CHAIN cERT_SIMPLE_CHAIN = new CAPIBase.CERT_SIMPLE_CHAIN(Marshal.SizeOf(typeof(CAPIBase.CERT_SIMPLE_CHAIN)));
		uint num = (uint)Marshal.ReadInt32(pSimpleChain);
		if (num > Marshal.SizeOf((object)cERT_SIMPLE_CHAIN))
		{
			num = (uint)Marshal.SizeOf((object)cERT_SIMPLE_CHAIN);
		}
		X509Utils.memcpy(pSimpleChain, new IntPtr(&cERT_SIMPLE_CHAIN), num);
		m_elements = new X509ChainElement[cERT_SIMPLE_CHAIN.cElement];
		for (int i = 0; i < m_elements.Length; i++)
		{
			m_elements[i] = new X509ChainElement(Marshal.ReadIntPtr(new IntPtr((long)cERT_SIMPLE_CHAIN.rgpElement + i * Marshal.SizeOf(typeof(IntPtr)))));
		}
	}

	public X509ChainElementEnumerator GetEnumerator()
	{
		return new X509ChainElementEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new X509ChainElementEnumerator(this);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(System.SR.GetString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0 || index >= array.Length)
		{
			throw new ArgumentOutOfRangeException("index", System.SR.GetString("ArgumentOutOfRange_Index"));
		}
		if (index + Count > array.Length)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidOffLen"));
		}
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(this[i], index);
			index++;
		}
	}

	public void CopyTo(X509ChainElement[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}
}
