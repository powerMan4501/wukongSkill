using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

[Serializable]
public class X509CertificateCollection : CollectionBase
{
	public class X509CertificateEnumerator : IEnumerator
	{
		private IEnumerator baseEnumerator;

		private IEnumerable temp;

		public X509Certificate Current => (X509Certificate)baseEnumerator.Current;

		object IEnumerator.Current => baseEnumerator.Current;

		public X509CertificateEnumerator(X509CertificateCollection mappings)
		{
			temp = mappings;
			baseEnumerator = temp.GetEnumerator();
		}

		public bool MoveNext()
		{
			return baseEnumerator.MoveNext();
		}

		bool IEnumerator.MoveNext()
		{
			return baseEnumerator.MoveNext();
		}

		public void Reset()
		{
			baseEnumerator.Reset();
		}

		void IEnumerator.Reset()
		{
			baseEnumerator.Reset();
		}
	}

	public X509Certificate this[int index]
	{
		get
		{
			return (X509Certificate)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public X509CertificateCollection()
	{
	}

	public X509CertificateCollection(X509CertificateCollection value)
	{
		AddRange(value);
	}

	public X509CertificateCollection(X509Certificate[] value)
	{
		AddRange(value);
	}

	public int Add(X509Certificate value)
	{
		return base.List.Add(value);
	}

	public void AddRange(X509Certificate[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		for (int i = 0; i < value.Length; i++)
		{
			Add(value[i]);
		}
	}

	public void AddRange(X509CertificateCollection value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		for (int i = 0; i < value.Count; i++)
		{
			Add(value[i]);
		}
	}

	public bool Contains(X509Certificate value)
	{
		foreach (X509Certificate item in base.List)
		{
			if (item.Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	public void CopyTo(X509Certificate[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(X509Certificate value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, X509Certificate value)
	{
		base.List.Insert(index, value);
	}

	public new X509CertificateEnumerator GetEnumerator()
	{
		return new X509CertificateEnumerator(this);
	}

	public void Remove(X509Certificate value)
	{
		base.List.Remove(value);
	}

	public override int GetHashCode()
	{
		int num = 0;
		X509CertificateEnumerator x509CertificateEnumerator = GetEnumerator();
		try
		{
			while (x509CertificateEnumerator.MoveNext())
			{
				X509Certificate current = x509CertificateEnumerator.Current;
				num += current.GetHashCode();
			}
			return num;
		}
		finally
		{
			IDisposable disposable = x509CertificateEnumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}
}
