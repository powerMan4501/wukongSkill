using System.IO;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class PublicKey
{
	private AsnEncodedData m_encodedKeyValue;

	private AsnEncodedData m_encodedParameters;

	private Oid m_oid;

	private uint m_aiPubKey;

	private byte[] m_cspBlobData;

	private AsymmetricAlgorithm m_key;

	internal uint AlgorithmId
	{
		get
		{
			if (m_aiPubKey == 0)
			{
				m_aiPubKey = X509Utils.OidToAlgId(m_oid.Value);
			}
			return m_aiPubKey;
		}
	}

	private byte[] CspBlobData
	{
		get
		{
			if (m_cspBlobData == null)
			{
				DecodePublicKeyObject(AlgorithmId, m_encodedKeyValue.RawData, m_encodedParameters.RawData, out m_cspBlobData);
			}
			return m_cspBlobData;
		}
	}

	public AsymmetricAlgorithm Key
	{
		get
		{
			if (m_key == null)
			{
				switch (AlgorithmId)
				{
				case 9216u:
				case 41984u:
				{
					RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
					rSACryptoServiceProvider.ImportCspBlob(CspBlobData);
					m_key = rSACryptoServiceProvider;
					break;
				}
				case 8704u:
				{
					DSACryptoServiceProvider dSACryptoServiceProvider = new DSACryptoServiceProvider();
					dSACryptoServiceProvider.ImportCspBlob(CspBlobData);
					m_key = dSACryptoServiceProvider;
					break;
				}
				default:
					throw new NotSupportedException(System.SR.GetString("NotSupported_KeyAlgorithm"));
				}
			}
			return m_key;
		}
	}

	public Oid Oid => new Oid(m_oid);

	public AsnEncodedData EncodedKeyValue => m_encodedKeyValue;

	public AsnEncodedData EncodedParameters => m_encodedParameters;

	private PublicKey()
	{
	}

	public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
	{
		m_oid = new Oid(oid);
		m_encodedParameters = new AsnEncodedData(parameters);
		m_encodedKeyValue = new AsnEncodedData(keyValue);
	}

	internal PublicKey(PublicKey publicKey)
	{
		m_oid = new Oid(publicKey.m_oid);
		m_encodedParameters = new AsnEncodedData(publicKey.m_encodedParameters);
		m_encodedKeyValue = new AsnEncodedData(publicKey.m_encodedKeyValue);
	}

	private static void DecodePublicKeyObject(uint aiPubKey, byte[] encodedKeyValue, byte[] encodedParameters, out byte[] decodedData)
	{
		decodedData = null;
		IntPtr zero = IntPtr.Zero;
		switch (aiPubKey)
		{
		case 8704u:
			zero = new IntPtr(38L);
			break;
		case 9216u:
		case 41984u:
			zero = new IntPtr(19L);
			break;
		case 43521u:
		case 43522u:
			throw new NotSupportedException(System.SR.GetString("NotSupported_KeyAlgorithm"));
		default:
			throw new NotSupportedException(System.SR.GetString("NotSupported_KeyAlgorithm"));
		}
		SafeLocalAllocHandle decodedValue = null;
		uint cbDecodedValue = 0u;
		if (!CAPI.DecodeObject(zero, encodedKeyValue, out decodedValue, out cbDecodedValue))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		if ((int)zero == 19)
		{
			decodedData = new byte[cbDecodedValue];
			Marshal.Copy(decodedValue.DangerousGetHandle(), decodedData, 0, decodedData.Length);
		}
		else if ((int)zero == 38)
		{
			SafeLocalAllocHandle decodedValue2 = null;
			uint cbDecodedValue2 = 0u;
			if (!CAPI.DecodeObject(new IntPtr(39L), encodedParameters, out decodedValue2, out cbDecodedValue2))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			decodedData = ConstructDSSPubKeyCspBlob(decodedValue, decodedValue2);
			decodedValue2.Dispose();
		}
		decodedValue.Dispose();
	}

	private static byte[] ConstructDSSPubKeyCspBlob(SafeLocalAllocHandle decodedKeyValue, SafeLocalAllocHandle decodedParameters)
	{
		CAPIBase.CRYPTOAPI_BLOB cRYPTOAPI_BLOB = (CAPIBase.CRYPTOAPI_BLOB)Marshal.PtrToStructure(decodedKeyValue.DangerousGetHandle(), typeof(CAPIBase.CRYPTOAPI_BLOB));
		CAPIBase.CERT_DSS_PARAMETERS cERT_DSS_PARAMETERS = (CAPIBase.CERT_DSS_PARAMETERS)Marshal.PtrToStructure(decodedParameters.DangerousGetHandle(), typeof(CAPIBase.CERT_DSS_PARAMETERS));
		uint cbData = cERT_DSS_PARAMETERS.p.cbData;
		if (cbData == 0)
		{
			throw new CryptographicException(-2146893803);
		}
		uint capacity = 16 + cbData + 20 + cbData + cbData + 24;
		MemoryStream memoryStream = new MemoryStream((int)capacity);
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write((byte)6);
		binaryWriter.Write((byte)2);
		binaryWriter.Write((short)0);
		binaryWriter.Write(8704u);
		binaryWriter.Write(827544388u);
		binaryWriter.Write(cbData * 8);
		byte[] array = new byte[cERT_DSS_PARAMETERS.p.cbData];
		Marshal.Copy(cERT_DSS_PARAMETERS.p.pbData, array, 0, array.Length);
		binaryWriter.Write(array);
		uint cbData2 = cERT_DSS_PARAMETERS.q.cbData;
		if (cbData2 == 0 || cbData2 > 20)
		{
			throw new CryptographicException(-2146893803);
		}
		byte[] array2 = new byte[cERT_DSS_PARAMETERS.q.cbData];
		Marshal.Copy(cERT_DSS_PARAMETERS.q.pbData, array2, 0, array2.Length);
		binaryWriter.Write(array2);
		if (20 > cbData2)
		{
			binaryWriter.Write(new byte[20 - cbData2]);
		}
		cbData2 = cERT_DSS_PARAMETERS.g.cbData;
		if (cbData2 == 0 || cbData2 > cbData)
		{
			throw new CryptographicException(-2146893803);
		}
		byte[] array3 = new byte[cERT_DSS_PARAMETERS.g.cbData];
		Marshal.Copy(cERT_DSS_PARAMETERS.g.pbData, array3, 0, array3.Length);
		binaryWriter.Write(array3);
		if (cbData > cbData2)
		{
			binaryWriter.Write(new byte[cbData - cbData2]);
		}
		cbData2 = cRYPTOAPI_BLOB.cbData;
		if (cbData2 == 0 || cbData2 > cbData)
		{
			throw new CryptographicException(-2146893803);
		}
		byte[] array4 = new byte[cRYPTOAPI_BLOB.cbData];
		Marshal.Copy(cRYPTOAPI_BLOB.pbData, array4, 0, array4.Length);
		binaryWriter.Write(array4);
		if (cbData > cbData2)
		{
			binaryWriter.Write(new byte[cbData - cbData2]);
		}
		binaryWriter.Write(uint.MaxValue);
		binaryWriter.Write(new byte[20]);
		return memoryStream.ToArray();
	}
}
