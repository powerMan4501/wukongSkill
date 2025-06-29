using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyName : _AssemblyName, ICloneable, ISerializable, IDeserializationCallback
{
	private string _Name;

	private byte[] _PublicKey;

	private byte[] _PublicKeyToken;

	private CultureInfo _CultureInfo;

	private string _CodeBase;

	private Version _Version;

	private StrongNameKeyPair _StrongNameKeyPair;

	private SerializationInfo m_siInfo;

	private byte[] _HashForControl;

	private AssemblyHashAlgorithm _HashAlgorithm;

	private AssemblyHashAlgorithm _HashAlgorithmForControl;

	private AssemblyVersionCompatibility _VersionCompatibility;

	private AssemblyNameFlags _Flags;

	[__DynamicallyInvokable]
	public string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return _Name;
		}
		[__DynamicallyInvokable]
		set
		{
			_Name = value;
		}
	}

	[__DynamicallyInvokable]
	public Version Version
	{
		[__DynamicallyInvokable]
		get
		{
			return _Version;
		}
		[__DynamicallyInvokable]
		set
		{
			_Version = value;
		}
	}

	[__DynamicallyInvokable]
	public CultureInfo CultureInfo
	{
		[__DynamicallyInvokable]
		get
		{
			return _CultureInfo;
		}
		[__DynamicallyInvokable]
		set
		{
			_CultureInfo = value;
		}
	}

	[__DynamicallyInvokable]
	public string CultureName
	{
		[__DynamicallyInvokable]
		get
		{
			if (_CultureInfo != null)
			{
				return _CultureInfo.Name;
			}
			return null;
		}
		[__DynamicallyInvokable]
		set
		{
			_CultureInfo = ((value == null) ? null : new CultureInfo(value));
		}
	}

	public string CodeBase
	{
		get
		{
			return _CodeBase;
		}
		set
		{
			_CodeBase = value;
		}
	}

	public string EscapedCodeBase
	{
		[SecuritySafeCritical]
		get
		{
			if (_CodeBase == null)
			{
				return null;
			}
			return EscapeCodeBase(_CodeBase);
		}
	}

	[__DynamicallyInvokable]
	public ProcessorArchitecture ProcessorArchitecture
	{
		[__DynamicallyInvokable]
		get
		{
			int num = (int)(_Flags & (AssemblyNameFlags)112) >> 4;
			if (num > 5)
			{
				num = 0;
			}
			return (ProcessorArchitecture)num;
		}
		[__DynamicallyInvokable]
		set
		{
			int num = (int)(value & (ProcessorArchitecture)7);
			if (num <= 5)
			{
				_Flags = (AssemblyNameFlags)((long)_Flags & 0xFFFFFF0FL);
				_Flags |= (AssemblyNameFlags)(num << 4);
			}
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public AssemblyContentType ContentType
	{
		[__DynamicallyInvokable]
		get
		{
			int num = (int)(_Flags & (AssemblyNameFlags)3584) >> 9;
			if (num > 1)
			{
				num = 0;
			}
			return (AssemblyContentType)num;
		}
		[__DynamicallyInvokable]
		set
		{
			int num = (int)(value & (AssemblyContentType)7);
			if (num <= 1)
			{
				_Flags = (AssemblyNameFlags)((long)_Flags & 0xFFFFF1FFL);
				_Flags |= (AssemblyNameFlags)(num << 9);
			}
		}
	}

	[__DynamicallyInvokable]
	public AssemblyNameFlags Flags
	{
		[__DynamicallyInvokable]
		get
		{
			return _Flags & (AssemblyNameFlags)(-3825);
		}
		[__DynamicallyInvokable]
		set
		{
			_Flags &= (AssemblyNameFlags)3824;
			_Flags |= value & (AssemblyNameFlags)(-3825);
		}
	}

	public AssemblyHashAlgorithm HashAlgorithm
	{
		get
		{
			return _HashAlgorithm;
		}
		set
		{
			_HashAlgorithm = value;
		}
	}

	public AssemblyVersionCompatibility VersionCompatibility
	{
		get
		{
			return _VersionCompatibility;
		}
		set
		{
			_VersionCompatibility = value;
		}
	}

	public StrongNameKeyPair KeyPair
	{
		get
		{
			return _StrongNameKeyPair;
		}
		set
		{
			_StrongNameKeyPair = value;
		}
	}

	[__DynamicallyInvokable]
	public string FullName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			string text = nToString();
			if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8 && string.IsNullOrEmpty(text))
			{
				return base.ToString();
			}
			return text;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyName()
	{
		_HashAlgorithm = AssemblyHashAlgorithm.None;
		_VersionCompatibility = AssemblyVersionCompatibility.SameMachine;
		_Flags = AssemblyNameFlags.None;
	}

	public object Clone()
	{
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Init(_Name, _PublicKey, _PublicKeyToken, _Version, _CultureInfo, _HashAlgorithm, _VersionCompatibility, _CodeBase, _Flags, _StrongNameKeyPair);
		assemblyName._HashForControl = _HashForControl;
		assemblyName._HashAlgorithmForControl = _HashAlgorithmForControl;
		return assemblyName;
	}

	[SecuritySafeCritical]
	public static AssemblyName GetAssemblyName(string assemblyFile)
	{
		if (assemblyFile == null)
		{
			throw new ArgumentNullException("assemblyFile");
		}
		string fullPathInternal = Path.GetFullPathInternal(assemblyFile);
		new FileIOPermission(FileIOPermissionAccess.PathDiscovery, fullPathInternal).Demand();
		return nGetFileInformation(fullPathInternal);
	}

	internal void SetHashControl(byte[] hash, AssemblyHashAlgorithm hashAlgorithm)
	{
		_HashForControl = hash;
		_HashAlgorithmForControl = hashAlgorithm;
	}

	[__DynamicallyInvokable]
	public byte[] GetPublicKey()
	{
		return _PublicKey;
	}

	[__DynamicallyInvokable]
	public void SetPublicKey(byte[] publicKey)
	{
		_PublicKey = publicKey;
		if (publicKey == null)
		{
			_Flags &= ~AssemblyNameFlags.PublicKey;
		}
		else
		{
			_Flags |= AssemblyNameFlags.PublicKey;
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public byte[] GetPublicKeyToken()
	{
		if (_PublicKeyToken == null)
		{
			_PublicKeyToken = nGetPublicKeyToken();
		}
		return _PublicKeyToken;
	}

	[__DynamicallyInvokable]
	public void SetPublicKeyToken(byte[] publicKeyToken)
	{
		_PublicKeyToken = publicKeyToken;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		string fullName = FullName;
		if (fullName == null)
		{
			return base.ToString();
		}
		return fullName;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("_Name", _Name);
		info.AddValue("_PublicKey", _PublicKey, typeof(byte[]));
		info.AddValue("_PublicKeyToken", _PublicKeyToken, typeof(byte[]));
		info.AddValue("_CultureInfo", (_CultureInfo == null) ? (-1) : _CultureInfo.LCID);
		info.AddValue("_CodeBase", _CodeBase);
		info.AddValue("_Version", _Version);
		info.AddValue("_HashAlgorithm", _HashAlgorithm, typeof(AssemblyHashAlgorithm));
		info.AddValue("_HashAlgorithmForControl", _HashAlgorithmForControl, typeof(AssemblyHashAlgorithm));
		info.AddValue("_StrongNameKeyPair", _StrongNameKeyPair, typeof(StrongNameKeyPair));
		info.AddValue("_VersionCompatibility", _VersionCompatibility, typeof(AssemblyVersionCompatibility));
		info.AddValue("_Flags", _Flags, typeof(AssemblyNameFlags));
		info.AddValue("_HashForControl", _HashForControl, typeof(byte[]));
	}

	public void OnDeserialization(object sender)
	{
		if (m_siInfo != null)
		{
			_Name = m_siInfo.GetString("_Name");
			_PublicKey = (byte[])m_siInfo.GetValue("_PublicKey", typeof(byte[]));
			_PublicKeyToken = (byte[])m_siInfo.GetValue("_PublicKeyToken", typeof(byte[]));
			int @int = m_siInfo.GetInt32("_CultureInfo");
			if (@int != -1)
			{
				_CultureInfo = new CultureInfo(@int);
			}
			_CodeBase = m_siInfo.GetString("_CodeBase");
			_Version = (Version)m_siInfo.GetValue("_Version", typeof(Version));
			_HashAlgorithm = (AssemblyHashAlgorithm)m_siInfo.GetValue("_HashAlgorithm", typeof(AssemblyHashAlgorithm));
			_StrongNameKeyPair = (StrongNameKeyPair)m_siInfo.GetValue("_StrongNameKeyPair", typeof(StrongNameKeyPair));
			_VersionCompatibility = (AssemblyVersionCompatibility)m_siInfo.GetValue("_VersionCompatibility", typeof(AssemblyVersionCompatibility));
			_Flags = (AssemblyNameFlags)m_siInfo.GetValue("_Flags", typeof(AssemblyNameFlags));
			try
			{
				_HashAlgorithmForControl = (AssemblyHashAlgorithm)m_siInfo.GetValue("_HashAlgorithmForControl", typeof(AssemblyHashAlgorithm));
				_HashForControl = (byte[])m_siInfo.GetValue("_HashForControl", typeof(byte[]));
			}
			catch (SerializationException)
			{
				_HashAlgorithmForControl = AssemblyHashAlgorithm.None;
				_HashForControl = null;
			}
			m_siInfo = null;
		}
	}

	internal AssemblyName(SerializationInfo info, StreamingContext context)
	{
		m_siInfo = info;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public AssemblyName(string assemblyName)
	{
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		if (assemblyName.Length == 0 || assemblyName[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Format_StringZeroLength"));
		}
		_Name = assemblyName;
		nInit();
	}

	[SecuritySafeCritical]
	public static bool ReferenceMatchesDefinition(AssemblyName reference, AssemblyName definition)
	{
		if (reference == definition)
		{
			return true;
		}
		return ReferenceMatchesDefinitionInternal(reference, definition, parse: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool ReferenceMatchesDefinitionInternal(AssemblyName reference, AssemblyName definition, bool parse);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void nInit(out RuntimeAssembly assembly, bool forIntrospection, bool raiseResolveEvent);

	[SecurityCritical]
	internal void nInit()
	{
		RuntimeAssembly assembly = null;
		nInit(out assembly, forIntrospection: false, raiseResolveEvent: false);
	}

	internal void SetProcArchIndex(PortableExecutableKinds pek, ImageFileMachine ifm)
	{
		ProcessorArchitecture = CalculateProcArchIndex(pek, ifm, _Flags);
	}

	internal static ProcessorArchitecture CalculateProcArchIndex(PortableExecutableKinds pek, ImageFileMachine ifm, AssemblyNameFlags flags)
	{
		if ((flags & (AssemblyNameFlags)240) == (AssemblyNameFlags)112)
		{
			return ProcessorArchitecture.None;
		}
		if ((pek & PortableExecutableKinds.PE32Plus) == PortableExecutableKinds.PE32Plus)
		{
			switch (ifm)
			{
			case ImageFileMachine.IA64:
				return ProcessorArchitecture.IA64;
			case ImageFileMachine.AMD64:
				return ProcessorArchitecture.Amd64;
			case ImageFileMachine.I386:
				if ((pek & PortableExecutableKinds.ILOnly) == PortableExecutableKinds.ILOnly)
				{
					return ProcessorArchitecture.MSIL;
				}
				break;
			}
		}
		else
		{
			switch (ifm)
			{
			case ImageFileMachine.I386:
				if ((pek & PortableExecutableKinds.Required32Bit) == PortableExecutableKinds.Required32Bit)
				{
					return ProcessorArchitecture.X86;
				}
				if ((pek & PortableExecutableKinds.ILOnly) == PortableExecutableKinds.ILOnly)
				{
					return ProcessorArchitecture.MSIL;
				}
				return ProcessorArchitecture.X86;
			case ImageFileMachine.ARM:
				return ProcessorArchitecture.Arm;
			}
		}
		return ProcessorArchitecture.None;
	}

	internal void Init(string name, byte[] publicKey, byte[] publicKeyToken, Version version, CultureInfo cultureInfo, AssemblyHashAlgorithm hashAlgorithm, AssemblyVersionCompatibility versionCompatibility, string codeBase, AssemblyNameFlags flags, StrongNameKeyPair keyPair)
	{
		_Name = name;
		if (publicKey != null)
		{
			_PublicKey = new byte[publicKey.Length];
			Array.Copy(publicKey, _PublicKey, publicKey.Length);
		}
		if (publicKeyToken != null)
		{
			_PublicKeyToken = new byte[publicKeyToken.Length];
			Array.Copy(publicKeyToken, _PublicKeyToken, publicKeyToken.Length);
		}
		if (version != null)
		{
			_Version = (Version)version.Clone();
		}
		_CultureInfo = cultureInfo;
		_HashAlgorithm = hashAlgorithm;
		_VersionCompatibility = versionCompatibility;
		_CodeBase = codeBase;
		_Flags = flags;
		_StrongNameKeyPair = keyPair;
	}

	void _AssemblyName.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _AssemblyName.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _AssemblyName.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _AssemblyName.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}

	internal string GetNameWithPublicKey()
	{
		byte[] publicKey = GetPublicKey();
		return Name + ", PublicKey=" + Hex.EncodeHexString(publicKey);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern AssemblyName nGetFileInformation(string s);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern string nToString();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern byte[] nGetPublicKeyToken();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string EscapeCodeBase(string codeBase);
}
