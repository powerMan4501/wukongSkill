using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class Hash : EvidenceBase, ISerializable
{
	private RuntimeAssembly m_assembly;

	private Dictionary<Type, byte[]> m_hashes;

	private WeakReference m_rawData;

	public byte[] SHA1
	{
		get
		{
			byte[] value = null;
			if (!m_hashes.TryGetValue(typeof(SHA1), out value))
			{
				value = GenerateHash(GetDefaultHashImplementationOrFallback(typeof(SHA1), typeof(SHA1)));
			}
			byte[] array = new byte[value.Length];
			Array.Copy(value, array, array.Length);
			return array;
		}
	}

	public byte[] SHA256
	{
		get
		{
			byte[] value = null;
			if (!m_hashes.TryGetValue(typeof(SHA256), out value))
			{
				value = GenerateHash(GetDefaultHashImplementationOrFallback(typeof(SHA256), typeof(SHA256)));
			}
			byte[] array = new byte[value.Length];
			Array.Copy(value, array, array.Length);
			return array;
		}
	}

	public byte[] MD5
	{
		get
		{
			byte[] value = null;
			if (!m_hashes.TryGetValue(typeof(MD5), out value))
			{
				value = GenerateHash(GetDefaultHashImplementationOrFallback(typeof(MD5), typeof(MD5)));
			}
			byte[] array = new byte[value.Length];
			Array.Copy(value, array, array.Length);
			return array;
		}
	}

	[SecurityCritical]
	internal Hash(SerializationInfo info, StreamingContext context)
	{
		if (info.GetValueNoThrow("Hashes", typeof(Dictionary<Type, byte[]>)) is Dictionary<Type, byte[]> hashes)
		{
			m_hashes = hashes;
			return;
		}
		m_hashes = new Dictionary<Type, byte[]>();
		if (info.GetValueNoThrow("Md5", typeof(byte[])) is byte[] value)
		{
			m_hashes[typeof(MD5)] = value;
		}
		if (info.GetValueNoThrow("Sha1", typeof(byte[])) is byte[] value2)
		{
			m_hashes[typeof(SHA1)] = value2;
		}
		if (info.GetValueNoThrow("RawData", typeof(byte[])) is byte[] assemblyBytes)
		{
			GenerateDefaultHashes(assemblyBytes);
		}
	}

	public Hash(Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (assembly.IsDynamic)
		{
			throw new ArgumentException(Environment.GetResourceString("Security_CannotGenerateHash"), "assembly");
		}
		m_hashes = new Dictionary<Type, byte[]>();
		m_assembly = assembly as RuntimeAssembly;
		if (m_assembly == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"), "assembly");
		}
	}

	private Hash(Hash hash)
	{
		m_assembly = hash.m_assembly;
		m_rawData = hash.m_rawData;
		m_hashes = new Dictionary<Type, byte[]>(hash.m_hashes);
	}

	private Hash(Type hashType, byte[] hashValue)
	{
		m_hashes = new Dictionary<Type, byte[]>();
		byte[] array = new byte[hashValue.Length];
		Array.Copy(hashValue, array, array.Length);
		m_hashes[hashType] = hashValue;
	}

	public static Hash CreateSHA1(byte[] sha1)
	{
		if (sha1 == null)
		{
			throw new ArgumentNullException("sha1");
		}
		return new Hash(typeof(SHA1), sha1);
	}

	public static Hash CreateSHA256(byte[] sha256)
	{
		if (sha256 == null)
		{
			throw new ArgumentNullException("sha256");
		}
		return new Hash(typeof(SHA256), sha256);
	}

	public static Hash CreateMD5(byte[] md5)
	{
		if (md5 == null)
		{
			throw new ArgumentNullException("md5");
		}
		return new Hash(typeof(MD5), md5);
	}

	public override EvidenceBase Clone()
	{
		return new Hash(this);
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		GenerateDefaultHashes();
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		GenerateDefaultHashes();
		if (m_hashes.TryGetValue(typeof(MD5), out var value))
		{
			info.AddValue("Md5", value);
		}
		if (m_hashes.TryGetValue(typeof(SHA1), out var value2))
		{
			info.AddValue("Sha1", value2);
		}
		info.AddValue("RawData", null);
		info.AddValue("PEFile", IntPtr.Zero);
		info.AddValue("Hashes", m_hashes);
	}

	public byte[] GenerateHash(HashAlgorithm hashAlg)
	{
		if (hashAlg == null)
		{
			throw new ArgumentNullException("hashAlg");
		}
		byte[] array = GenerateHash(hashAlg.GetType());
		byte[] array2 = new byte[array.Length];
		Array.Copy(array, array2, array2.Length);
		return array2;
	}

	private byte[] GenerateHash(Type hashType)
	{
		Type hashIndexType = GetHashIndexType(hashType);
		byte[] value = null;
		if (!m_hashes.TryGetValue(hashIndexType, out value))
		{
			if (m_assembly == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Security_CannotGenerateHash"));
			}
			value = GenerateHash(hashType, GetRawData());
			m_hashes[hashIndexType] = value;
		}
		return value;
	}

	private static byte[] GenerateHash(Type hashType, byte[] assemblyBytes)
	{
		using HashAlgorithm hashAlgorithm = HashAlgorithm.Create(hashType.FullName);
		return hashAlgorithm.ComputeHash(assemblyBytes);
	}

	private void GenerateDefaultHashes()
	{
		if (m_assembly != null)
		{
			GenerateDefaultHashes(GetRawData());
		}
	}

	private void GenerateDefaultHashes(byte[] assemblyBytes)
	{
		Type[] array = new Type[3]
		{
			GetHashIndexType(typeof(SHA1)),
			GetHashIndexType(typeof(SHA256)),
			GetHashIndexType(typeof(MD5))
		};
		Type[] array2 = array;
		foreach (Type type in array2)
		{
			Type defaultHashImplementation = GetDefaultHashImplementation(type);
			if (defaultHashImplementation != null && !m_hashes.ContainsKey(type))
			{
				m_hashes[type] = GenerateHash(defaultHashImplementation, assemblyBytes);
			}
		}
	}

	private static Type GetDefaultHashImplementationOrFallback(Type hashAlgorithm, Type fallbackImplementation)
	{
		Type defaultHashImplementation = GetDefaultHashImplementation(hashAlgorithm);
		if (!(defaultHashImplementation != null))
		{
			return fallbackImplementation;
		}
		return defaultHashImplementation;
	}

	private static Type GetDefaultHashImplementation(Type hashAlgorithm)
	{
		if (hashAlgorithm.IsAssignableFrom(typeof(MD5)))
		{
			if (!CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				return typeof(MD5CryptoServiceProvider);
			}
			return null;
		}
		if (hashAlgorithm.IsAssignableFrom(typeof(SHA256)))
		{
			return Type.GetType("System.Security.Cryptography.SHA256CryptoServiceProvider, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
		}
		return hashAlgorithm;
	}

	private static Type GetHashIndexType(Type hashType)
	{
		Type type = hashType;
		while (type != null && type.BaseType != typeof(HashAlgorithm))
		{
			type = type.BaseType;
		}
		if (type == null)
		{
			type = typeof(HashAlgorithm);
		}
		return type;
	}

	private byte[] GetRawData()
	{
		byte[] array = null;
		if (m_assembly != null)
		{
			if (m_rawData != null)
			{
				array = m_rawData.Target as byte[];
			}
			if (array == null)
			{
				array = m_assembly.GetRawBytes();
				m_rawData = new WeakReference(array);
			}
		}
		return array;
	}

	private SecurityElement ToXml()
	{
		GenerateDefaultHashes();
		SecurityElement securityElement = new SecurityElement("System.Security.Policy.Hash");
		securityElement.AddAttribute("version", "2");
		foreach (KeyValuePair<Type, byte[]> hash in m_hashes)
		{
			SecurityElement securityElement2 = new SecurityElement("hash");
			securityElement2.AddAttribute("algorithm", hash.Key.Name);
			securityElement2.AddAttribute("value", Hex.EncodeHexString(hash.Value));
			securityElement.AddChild(securityElement2);
		}
		return securityElement;
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}
}
