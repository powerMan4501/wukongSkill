using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ExtensionCollection : ICollection, IEnumerable
{
	private ArrayList m_list = new ArrayList();

	public X509Extension this[int index]
	{
		get
		{
			if (index < 0)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_EnumNotStarted"));
			}
			if (index >= m_list.Count)
			{
				throw new ArgumentOutOfRangeException("index", System.SR.GetString("ArgumentOutOfRange_Index"));
			}
			return (X509Extension)m_list[index];
		}
	}

	public X509Extension this[string oid]
	{
		get
		{
			string text = X509Utils.FindOidInfoWithFallback(2u, oid, System.Security.Cryptography.OidGroup.ExtensionOrAttribute);
			if (text == null)
			{
				text = oid;
			}
			foreach (X509Extension item in m_list)
			{
				if (string.Compare(item.Oid.Value, text, StringComparison.OrdinalIgnoreCase) == 0)
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

	public X509ExtensionCollection()
	{
	}

	internal unsafe X509ExtensionCollection(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle)
	{
		using System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle2 = CAPI.CertDuplicateCertificateContext(safeCertContextHandle);
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle2.DangerousGetHandle();
		CAPIBase.CERT_INFO cERT_INFO = (CAPIBase.CERT_INFO)Marshal.PtrToStructure(cERT_CONTEXT.pCertInfo, typeof(CAPIBase.CERT_INFO));
		uint cExtension = cERT_INFO.cExtension;
		IntPtr rgExtension = cERT_INFO.rgExtension;
		for (uint num = 0u; num < cExtension; num++)
		{
			X509Extension x509Extension = new X509Extension(new IntPtr((long)rgExtension + num * Marshal.SizeOf(typeof(CAPIBase.CERT_EXTENSION))));
			if (CryptoConfig.CreateFromName(x509Extension.Oid.Value) is X509Extension x509Extension2)
			{
				x509Extension2.CopyFrom(x509Extension);
				x509Extension = x509Extension2;
			}
			Add(x509Extension);
		}
	}

	public int Add(X509Extension extension)
	{
		if (extension == null)
		{
			throw new ArgumentNullException("extension");
		}
		return m_list.Add(extension);
	}

	public X509ExtensionEnumerator GetEnumerator()
	{
		return new X509ExtensionEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new X509ExtensionEnumerator(this);
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

	public void CopyTo(X509Extension[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}
}
