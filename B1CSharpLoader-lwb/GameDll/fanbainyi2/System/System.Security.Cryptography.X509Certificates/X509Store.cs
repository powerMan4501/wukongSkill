using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Store : IDisposable
{
	private string m_storeName;

	private StoreLocation m_location;

	private System.Security.Cryptography.SafeCertStoreHandle m_safeCertStoreHandle = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;

	public IntPtr StoreHandle
	{
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			if (m_safeCertStoreHandle == null || m_safeCertStoreHandle.IsInvalid || m_safeCertStoreHandle.IsClosed)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_StoreNotOpen"));
			}
			return m_safeCertStoreHandle.DangerousGetHandle();
		}
	}

	public StoreLocation Location => m_location;

	public string Name => m_storeName;

	public X509Certificate2Collection Certificates
	{
		get
		{
			if (m_safeCertStoreHandle.IsInvalid || m_safeCertStoreHandle.IsClosed)
			{
				return new X509Certificate2Collection();
			}
			return X509Utils.GetCertificates(m_safeCertStoreHandle);
		}
	}

	public X509Store()
		: this("MY", StoreLocation.CurrentUser)
	{
	}

	public X509Store(string storeName)
		: this(storeName, StoreLocation.CurrentUser)
	{
	}

	public X509Store(StoreName storeName)
		: this(storeName, StoreLocation.CurrentUser)
	{
	}

	public X509Store(StoreLocation storeLocation)
		: this("MY", storeLocation)
	{
	}

	public X509Store(StoreName storeName, StoreLocation storeLocation)
	{
		if (storeLocation != StoreLocation.CurrentUser && storeLocation != StoreLocation.LocalMachine)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "storeLocation" }));
		}
		switch (storeName)
		{
		case StoreName.AddressBook:
			m_storeName = "AddressBook";
			break;
		case StoreName.AuthRoot:
			m_storeName = "AuthRoot";
			break;
		case StoreName.CertificateAuthority:
			m_storeName = "CA";
			break;
		case StoreName.Disallowed:
			m_storeName = "Disallowed";
			break;
		case StoreName.My:
			m_storeName = "My";
			break;
		case StoreName.Root:
			m_storeName = "Root";
			break;
		case StoreName.TrustedPeople:
			m_storeName = "TrustedPeople";
			break;
		case StoreName.TrustedPublisher:
			m_storeName = "TrustedPublisher";
			break;
		default:
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "storeName" }));
		}
		m_location = storeLocation;
	}

	public X509Store(string storeName, StoreLocation storeLocation)
	{
		if (storeLocation != StoreLocation.CurrentUser && storeLocation != StoreLocation.LocalMachine)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "storeLocation" }));
		}
		m_storeName = storeName;
		m_location = storeLocation;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public X509Store(IntPtr storeHandle)
	{
		if (storeHandle == IntPtr.Zero)
		{
			throw new ArgumentNullException("storeHandle");
		}
		m_safeCertStoreHandle = CAPISafe.CertDuplicateStore(storeHandle);
		if (m_safeCertStoreHandle == null || m_safeCertStoreHandle.IsInvalid)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_InvalidStoreHandle"), "storeHandle");
		}
	}

	public void Open(OpenFlags flags)
	{
		if (m_location != StoreLocation.CurrentUser && m_location != StoreLocation.LocalMachine)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "m_location" }));
		}
		uint dwFlags = X509Utils.MapX509StoreFlags(m_location, flags);
		if (!m_safeCertStoreHandle.IsInvalid)
		{
			m_safeCertStoreHandle.Dispose();
		}
		m_safeCertStoreHandle = CAPI.CertOpenStore(new IntPtr(10L), 65537u, IntPtr.Zero, dwFlags, m_storeName);
		if (m_safeCertStoreHandle == null || m_safeCertStoreHandle.IsInvalid)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		CAPISafe.CertControlStore(m_safeCertStoreHandle, 0u, 4u, IntPtr.Zero);
	}

	public void Dispose()
	{
		Close();
	}

	public void Close()
	{
		if (m_safeCertStoreHandle != null && !m_safeCertStoreHandle.IsClosed)
		{
			m_safeCertStoreHandle.Dispose();
		}
	}

	public void Add(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (m_safeCertStoreHandle == null || m_safeCertStoreHandle.IsInvalid || m_safeCertStoreHandle.IsClosed)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_X509_StoreNotOpen"));
		}
		if (!CAPI.CertAddCertificateContextToStore(m_safeCertStoreHandle, certificate.CertContext, 5u, System.Security.Cryptography.SafeCertContextHandle.InvalidHandle))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
	}

	public void AddRange(X509Certificate2Collection certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		int num = 0;
		try
		{
			X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				Add(current);
				num++;
			}
		}
		catch
		{
			for (int i = 0; i < num; i++)
			{
				Remove(certificates[i]);
			}
			throw;
		}
	}

	public void Remove(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		RemoveCertificateFromStore(m_safeCertStoreHandle, certificate.CertContext);
	}

	public void RemoveRange(X509Certificate2Collection certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		int num = 0;
		try
		{
			X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				Remove(current);
				num++;
			}
		}
		catch
		{
			for (int i = 0; i < num; i++)
			{
				Add(certificates[i]);
			}
			throw;
		}
	}

	private static void RemoveCertificateFromStore(System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle, System.Security.Cryptography.SafeCertContextHandle safeCertContext)
	{
		if (safeCertContext == null || safeCertContext.IsInvalid)
		{
			return;
		}
		if (safeCertStoreHandle == null || safeCertStoreHandle.IsInvalid || safeCertStoreHandle.IsClosed)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_X509_StoreNotOpen"));
		}
		System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle = CAPI.CertFindCertificateInStore(safeCertStoreHandle, 65537u, 0u, 851968u, safeCertContext.DangerousGetHandle(), System.Security.Cryptography.SafeCertContextHandle.InvalidHandle);
		if (safeCertContextHandle != null && !safeCertContextHandle.IsInvalid)
		{
			GC.SuppressFinalize(safeCertContextHandle);
			if (!CAPI.CertDeleteCertificateFromStore(safeCertContextHandle))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
	}
}
