using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Util;
using System.Text;
using Microsoft.Win32;

namespace System.Security.Cryptography.X509Certificates;

[Serializable]
[ComVisible(true)]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
{
	private const string m_format = "X509";

	private string m_subjectName;

	private string m_issuerName;

	private byte[] m_serialNumber;

	private byte[] m_publicKeyParameters;

	private byte[] m_publicKeyValue;

	private string m_publicKeyOid;

	private byte[] m_rawData;

	private byte[] m_thumbprint;

	private DateTime m_notBefore;

	private DateTime m_notAfter;

	[SecurityCritical]
	private SafeCertContextHandle m_safeCertContext;

	private bool m_certContextCloned;

	internal const X509KeyStorageFlags KeyStorageFlagsAll = X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet;

	[ComVisible(false)]
	public IntPtr Handle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			return m_safeCertContext.pCertContext;
		}
	}

	public string Issuer
	{
		[SecuritySafeCritical]
		get
		{
			ThrowIfContextInvalid();
			if (m_issuerName == null)
			{
				m_issuerName = X509Utils._GetIssuerName(m_safeCertContext, legacyV1Mode: false);
			}
			return m_issuerName;
		}
	}

	public string Subject
	{
		[SecuritySafeCritical]
		get
		{
			ThrowIfContextInvalid();
			if (m_subjectName == null)
			{
				m_subjectName = X509Utils._GetSubjectInfo(m_safeCertContext, 2u, legacyV1Mode: false);
			}
			return m_subjectName;
		}
	}

	internal SafeCertContextHandle CertContext
	{
		[SecurityCritical]
		get
		{
			return m_safeCertContext;
		}
	}

	private DateTime NotAfter
	{
		[SecuritySafeCritical]
		get
		{
			ThrowIfContextInvalid();
			if (m_notAfter == DateTime.MinValue)
			{
				Win32Native.FILE_TIME fileTime = default(Win32Native.FILE_TIME);
				X509Utils._GetDateNotAfter(m_safeCertContext, ref fileTime);
				m_notAfter = DateTime.FromFileTime(fileTime.ToTicks());
			}
			return m_notAfter;
		}
	}

	private DateTime NotBefore
	{
		[SecuritySafeCritical]
		get
		{
			ThrowIfContextInvalid();
			if (m_notBefore == DateTime.MinValue)
			{
				Win32Native.FILE_TIME fileTime = default(Win32Native.FILE_TIME);
				X509Utils._GetDateNotBefore(m_safeCertContext, ref fileTime);
				m_notBefore = DateTime.FromFileTime(fileTime.ToTicks());
			}
			return m_notBefore;
		}
	}

	private byte[] RawData
	{
		[SecurityCritical]
		get
		{
			ThrowIfContextInvalid();
			if (m_rawData == null)
			{
				m_rawData = X509Utils._GetCertRawData(m_safeCertContext);
			}
			return (byte[])m_rawData.Clone();
		}
	}

	private string SerialNumber
	{
		[SecuritySafeCritical]
		get
		{
			ThrowIfContextInvalid();
			if (m_serialNumber == null)
			{
				m_serialNumber = X509Utils._GetSerialNumber(m_safeCertContext);
			}
			return Hex.EncodeHexStringFromInt(m_serialNumber);
		}
	}

	[SecuritySafeCritical]
	private void Init()
	{
		m_safeCertContext = SafeCertContextHandle.InvalidHandle;
	}

	public X509Certificate()
	{
		Init();
	}

	public X509Certificate(byte[] data)
		: this()
	{
		if (data != null && data.Length != 0)
		{
			LoadCertificateFromBlob(data, null, X509KeyStorageFlags.DefaultKeySet, passwordProvided: false);
		}
	}

	public X509Certificate(byte[] rawData, string password)
		: this()
	{
		LoadCertificateFromBlob(rawData, password, X509KeyStorageFlags.DefaultKeySet, passwordProvided: true);
	}

	public X509Certificate(byte[] rawData, SecureString password)
		: this()
	{
		LoadCertificateFromBlob(rawData, password, X509KeyStorageFlags.DefaultKeySet, passwordProvided: true);
	}

	public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
		: this()
	{
		LoadCertificateFromBlob(rawData, password, keyStorageFlags, passwordProvided: true);
	}

	public X509Certificate(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
		: this()
	{
		LoadCertificateFromBlob(rawData, password, keyStorageFlags, passwordProvided: true);
	}

	[SecuritySafeCritical]
	public X509Certificate(string fileName)
		: this()
	{
		LoadCertificateFromFile(fileName, null, X509KeyStorageFlags.DefaultKeySet);
	}

	[SecuritySafeCritical]
	public X509Certificate(string fileName, string password)
		: this()
	{
		LoadCertificateFromFile(fileName, password, X509KeyStorageFlags.DefaultKeySet);
	}

	[SecuritySafeCritical]
	public X509Certificate(string fileName, SecureString password)
		: this()
	{
		LoadCertificateFromFile(fileName, password, X509KeyStorageFlags.DefaultKeySet);
	}

	[SecuritySafeCritical]
	public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		: this()
	{
		LoadCertificateFromFile(fileName, password, keyStorageFlags);
	}

	[SecuritySafeCritical]
	public X509Certificate(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
		: this()
	{
		LoadCertificateFromFile(fileName, password, keyStorageFlags);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public X509Certificate(IntPtr handle)
		: this()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidHandle"), "handle");
		}
		X509Utils.DuplicateCertContext(handle, m_safeCertContext);
	}

	[SecuritySafeCritical]
	public X509Certificate(X509Certificate cert)
		: this()
	{
		if (cert == null)
		{
			throw new ArgumentNullException("cert");
		}
		if (cert.m_safeCertContext.pCertContext != IntPtr.Zero)
		{
			m_safeCertContext = cert.GetCertContextForCloning();
			m_certContextCloned = true;
		}
	}

	public X509Certificate(SerializationInfo info, StreamingContext context)
		: this()
	{
		byte[] array = (byte[])info.GetValue("RawData", typeof(byte[]));
		if (array != null)
		{
			LoadCertificateFromBlob(array, null, X509KeyStorageFlags.DefaultKeySet, passwordProvided: false);
		}
	}

	public static X509Certificate CreateFromCertFile(string filename)
	{
		return new X509Certificate(filename);
	}

	public static X509Certificate CreateFromSignedFile(string filename)
	{
		return new X509Certificate(filename);
	}

	[SecuritySafeCritical]
	[Obsolete("This method has been deprecated.  Please use the Subject property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public virtual string GetName()
	{
		ThrowIfContextInvalid();
		return X509Utils._GetSubjectInfo(m_safeCertContext, 2u, legacyV1Mode: true);
	}

	[SecuritySafeCritical]
	[Obsolete("This method has been deprecated.  Please use the Issuer property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public virtual string GetIssuerName()
	{
		ThrowIfContextInvalid();
		return X509Utils._GetIssuerName(m_safeCertContext, legacyV1Mode: true);
	}

	[SecuritySafeCritical]
	public virtual byte[] GetSerialNumber()
	{
		ThrowIfContextInvalid();
		if (m_serialNumber == null)
		{
			m_serialNumber = X509Utils._GetSerialNumber(m_safeCertContext);
		}
		return (byte[])m_serialNumber.Clone();
	}

	public virtual string GetSerialNumberString()
	{
		return SerialNumber;
	}

	[SecuritySafeCritical]
	public virtual byte[] GetKeyAlgorithmParameters()
	{
		ThrowIfContextInvalid();
		if (m_publicKeyParameters == null)
		{
			m_publicKeyParameters = X509Utils._GetPublicKeyParameters(m_safeCertContext);
		}
		return (byte[])m_publicKeyParameters.Clone();
	}

	[SecuritySafeCritical]
	public virtual string GetKeyAlgorithmParametersString()
	{
		ThrowIfContextInvalid();
		return Hex.EncodeHexString(GetKeyAlgorithmParameters());
	}

	[SecuritySafeCritical]
	public virtual string GetKeyAlgorithm()
	{
		ThrowIfContextInvalid();
		if (m_publicKeyOid == null)
		{
			m_publicKeyOid = X509Utils._GetPublicKeyOid(m_safeCertContext);
		}
		return m_publicKeyOid;
	}

	[SecuritySafeCritical]
	public virtual byte[] GetPublicKey()
	{
		ThrowIfContextInvalid();
		if (m_publicKeyValue == null)
		{
			m_publicKeyValue = X509Utils._GetPublicKeyValue(m_safeCertContext);
		}
		return (byte[])m_publicKeyValue.Clone();
	}

	public virtual string GetPublicKeyString()
	{
		return Hex.EncodeHexString(GetPublicKey());
	}

	[SecuritySafeCritical]
	public virtual byte[] GetRawCertData()
	{
		return RawData;
	}

	public virtual string GetRawCertDataString()
	{
		return Hex.EncodeHexString(GetRawCertData());
	}

	public virtual byte[] GetCertHash()
	{
		SetThumbprint();
		return (byte[])m_thumbprint.Clone();
	}

	[SecuritySafeCritical]
	public virtual byte[] GetCertHash(HashAlgorithmName hashAlgorithm)
	{
		ThrowIfContextInvalid();
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(Environment.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		using HashAlgorithm hashAlgorithm2 = CryptoConfig.CreateFromName(hashAlgorithm.Name) as HashAlgorithm;
		if (hashAlgorithm2 == null || hashAlgorithm2 is KeyedHashAlgorithm)
		{
			throw new CryptographicException(-1073741275);
		}
		byte[] rawData = m_rawData;
		if (rawData == null)
		{
			rawData = RawData;
		}
		return hashAlgorithm2.ComputeHash(rawData);
	}

	public virtual string GetCertHashString()
	{
		SetThumbprint();
		return Hex.EncodeHexString(m_thumbprint);
	}

	public virtual string GetCertHashString(HashAlgorithmName hashAlgorithm)
	{
		byte[] certHash = GetCertHash(hashAlgorithm);
		return Hex.EncodeHexString(certHash);
	}

	public virtual string GetEffectiveDateString()
	{
		return NotBefore.ToString();
	}

	public virtual string GetExpirationDateString()
	{
		return NotAfter.ToString();
	}

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		if (!(obj is X509Certificate))
		{
			return false;
		}
		X509Certificate other = (X509Certificate)obj;
		return Equals(other);
	}

	[SecuritySafeCritical]
	public virtual bool Equals(X509Certificate other)
	{
		if (other == null)
		{
			return false;
		}
		if (m_safeCertContext.IsInvalid)
		{
			return other.m_safeCertContext.IsInvalid;
		}
		if (!Issuer.Equals(other.Issuer))
		{
			return false;
		}
		if (!SerialNumber.Equals(other.SerialNumber))
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	public override int GetHashCode()
	{
		if (m_safeCertContext.IsInvalid)
		{
			return 0;
		}
		SetThumbprint();
		int num = 0;
		for (int i = 0; i < m_thumbprint.Length && i < 4; i++)
		{
			num = (num << 8) | m_thumbprint[i];
		}
		return num;
	}

	public override string ToString()
	{
		return ToString(fVerbose: false);
	}

	[SecuritySafeCritical]
	public virtual string ToString(bool fVerbose)
	{
		if (!fVerbose || m_safeCertContext.IsInvalid)
		{
			return GetType().FullName;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("[Subject]" + Environment.NewLine + "  ");
		stringBuilder.Append(Subject);
		stringBuilder.Append(Environment.NewLine + Environment.NewLine + "[Issuer]" + Environment.NewLine + "  ");
		stringBuilder.Append(Issuer);
		stringBuilder.Append(Environment.NewLine + Environment.NewLine + "[Serial Number]" + Environment.NewLine + "  ");
		stringBuilder.Append(SerialNumber);
		stringBuilder.Append(Environment.NewLine + Environment.NewLine + "[Not Before]" + Environment.NewLine + "  ");
		stringBuilder.Append(FormatDate(NotBefore));
		stringBuilder.Append(Environment.NewLine + Environment.NewLine + "[Not After]" + Environment.NewLine + "  ");
		stringBuilder.Append(FormatDate(NotAfter));
		stringBuilder.Append(Environment.NewLine + Environment.NewLine + "[Thumbprint]" + Environment.NewLine + "  ");
		stringBuilder.Append(GetCertHashString());
		stringBuilder.Append(Environment.NewLine);
		return stringBuilder.ToString();
	}

	protected static string FormatDate(DateTime date)
	{
		CultureInfo cultureInfo = CultureInfo.CurrentCulture;
		if (!cultureInfo.DateTimeFormat.Calendar.IsValidDay(date.Year, date.Month, date.Day, 0))
		{
			if (cultureInfo.DateTimeFormat.Calendar is UmAlQuraCalendar)
			{
				cultureInfo = cultureInfo.Clone() as CultureInfo;
				cultureInfo.DateTimeFormat.Calendar = new HijriCalendar();
			}
			else
			{
				cultureInfo = CultureInfo.InvariantCulture;
			}
		}
		return date.ToString(cultureInfo);
	}

	public virtual string GetFormat()
	{
		return "X509";
	}

	[SecurityCritical]
	[ComVisible(false)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Import(byte[] rawData)
	{
		Reset();
		LoadCertificateFromBlob(rawData, null, X509KeyStorageFlags.DefaultKeySet, passwordProvided: false);
	}

	[SecurityCritical]
	[ComVisible(false)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
	{
		Reset();
		LoadCertificateFromBlob(rawData, password, keyStorageFlags, passwordProvided: true);
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
	{
		Reset();
		LoadCertificateFromBlob(rawData, password, keyStorageFlags, passwordProvided: true);
	}

	[SecurityCritical]
	[ComVisible(false)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Import(string fileName)
	{
		Reset();
		LoadCertificateFromFile(fileName, null, X509KeyStorageFlags.DefaultKeySet);
	}

	[SecurityCritical]
	[ComVisible(false)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
	{
		Reset();
		LoadCertificateFromFile(fileName, password, keyStorageFlags);
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
	{
		Reset();
		LoadCertificateFromFile(fileName, password, keyStorageFlags);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public virtual byte[] Export(X509ContentType contentType)
	{
		return ExportHelper(contentType, null);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public virtual byte[] Export(X509ContentType contentType, string password)
	{
		return ExportHelper(contentType, password);
	}

	[SecuritySafeCritical]
	public virtual byte[] Export(X509ContentType contentType, SecureString password)
	{
		return ExportHelper(contentType, password);
	}

	[SecurityCritical]
	[ComVisible(false)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual void Reset()
	{
		m_subjectName = null;
		m_issuerName = null;
		m_serialNumber = null;
		m_publicKeyParameters = null;
		m_publicKeyValue = null;
		m_publicKeyOid = null;
		m_rawData = null;
		m_thumbprint = null;
		m_notBefore = DateTime.MinValue;
		m_notAfter = DateTime.MinValue;
		if (!m_safeCertContext.IsInvalid)
		{
			if (!m_certContextCloned)
			{
				m_safeCertContext.Dispose();
			}
			m_safeCertContext = SafeCertContextHandle.InvalidHandle;
		}
		m_certContextCloned = false;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			Reset();
		}
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (m_safeCertContext.IsInvalid)
		{
			info.AddValue("RawData", null);
		}
		else
		{
			info.AddValue("RawData", RawData);
		}
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	[SecurityCritical]
	internal SafeCertContextHandle GetCertContextForCloning()
	{
		m_certContextCloned = true;
		return m_safeCertContext;
	}

	[SecurityCritical]
	private void ThrowIfContextInvalid()
	{
		if (m_safeCertContext.IsInvalid)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidHandle"), "m_safeCertContext");
		}
	}

	[SecuritySafeCritical]
	private void SetThumbprint()
	{
		ThrowIfContextInvalid();
		if (m_thumbprint == null)
		{
			m_thumbprint = X509Utils._GetThumbprint(m_safeCertContext);
		}
	}

	[SecurityCritical]
	private byte[] ExportHelper(X509ContentType contentType, object password)
	{
		switch (contentType)
		{
		case X509ContentType.Pfx:
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.Open | KeyContainerPermissionFlags.Export);
			keyContainerPermission.Demand();
			break;
		}
		default:
			throw new CryptographicException(Environment.GetResourceString("Cryptography_X509_InvalidContentType"));
		case X509ContentType.Cert:
		case X509ContentType.SerializedCert:
			break;
		}
		IntPtr intPtr = IntPtr.Zero;
		byte[] array = null;
		SafeCertStoreHandle safeCertStoreHandle = X509Utils.ExportCertToMemoryStore(this);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			intPtr = X509Utils.PasswordToHGlobalUni(password);
			array = X509Utils._ExportCertificatesToBlob(safeCertStoreHandle, contentType, intPtr);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
			safeCertStoreHandle.Dispose();
		}
		if (array == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_X509_ExportFailed"));
		}
		return array;
	}

	[SecuritySafeCritical]
	private void LoadCertificateFromBlob(byte[] rawData, object password, X509KeyStorageFlags keyStorageFlags, bool passwordProvided)
	{
		if (rawData == null || rawData.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EmptyOrNullArray"), "rawData");
		}
		X509ContentType x509ContentType = X509Utils.MapContentType(X509Utils._QueryCertBlobType(rawData));
		if (x509ContentType == X509ContentType.Pfx && (keyStorageFlags & X509KeyStorageFlags.PersistKeySet) == X509KeyStorageFlags.PersistKeySet)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.Create);
			keyContainerPermission.Demand();
		}
		if (x509ContentType == X509ContentType.Pfx && !AppDomain.IsStillInEarlyInit())
		{
			IterationCountLimitEnforcer.EnforceIterationCountLimit(rawData, readingFromFile: false, passwordProvided);
		}
		uint dwFlags = X509Utils.MapKeyStorageFlags(keyStorageFlags);
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			intPtr = X509Utils.PasswordToHGlobalUni(password);
			X509Utils.LoadCertFromBlob(rawData, intPtr, dwFlags, ((keyStorageFlags & X509KeyStorageFlags.PersistKeySet) != X509KeyStorageFlags.DefaultKeySet) ? true : false, m_safeCertContext);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
		}
	}

	[SecurityCritical]
	private void LoadCertificateFromFile(string fileName, object password, X509KeyStorageFlags keyStorageFlags)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		string fullPathInternal = Path.GetFullPathInternal(fileName);
		new FileIOPermission(FileIOPermissionAccess.Read, fullPathInternal).Demand();
		X509ContentType x509ContentType = X509Utils.MapContentType(X509Utils._QueryCertFileType(fileName));
		if (x509ContentType == X509ContentType.Pfx && (keyStorageFlags & X509KeyStorageFlags.PersistKeySet) == X509KeyStorageFlags.PersistKeySet)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.Create);
			keyContainerPermission.Demand();
		}
		uint dwFlags = X509Utils.MapKeyStorageFlags(keyStorageFlags);
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			intPtr = X509Utils.PasswordToHGlobalUni(password);
			X509Utils.LoadCertFromFile(fileName, intPtr, dwFlags, ((keyStorageFlags & X509KeyStorageFlags.PersistKeySet) != X509KeyStorageFlags.DefaultKeySet) ? true : false, m_safeCertContext);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
		}
	}
}
