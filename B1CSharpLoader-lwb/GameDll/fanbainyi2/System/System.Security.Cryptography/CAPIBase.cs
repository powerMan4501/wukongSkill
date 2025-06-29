using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace System.Security.Cryptography;

internal abstract class CAPIBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct BLOBHEADER
	{
		internal byte bType;

		internal byte bVersion;

		internal short reserved;

		internal uint aiKeyAlg;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_ALT_NAME_INFO
	{
		internal uint cAltEntry;

		internal IntPtr rgAltEntry;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_ALT_NAME_ENTRY
	{
		internal uint dwAltNameChoice;

		internal CERT_ALT_NAME_ENTRY_UNION Value;
	}

	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	internal struct CERT_ALT_NAME_ENTRY_UNION
	{
		[FieldOffset(0)]
		internal IntPtr pOtherName;

		[FieldOffset(0)]
		internal IntPtr pwszRfc822Name;

		[FieldOffset(0)]
		internal IntPtr pwszDNSName;

		[FieldOffset(0)]
		internal CRYPTOAPI_BLOB DirectoryName;

		[FieldOffset(0)]
		internal IntPtr pwszURL;

		[FieldOffset(0)]
		internal CRYPTOAPI_BLOB IPAddress;

		[FieldOffset(0)]
		internal IntPtr pszRegisteredID;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_BASIC_CONSTRAINTS_INFO
	{
		internal CRYPT_BIT_BLOB SubjectType;

		internal bool fPathLenConstraint;

		internal uint dwPathLenConstraint;

		internal uint cSubtreesConstraint;

		internal IntPtr rgSubtreesConstraint;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_BASIC_CONSTRAINTS2_INFO
	{
		internal int fCA;

		internal int fPathLenConstraint;

		internal uint dwPathLenConstraint;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CHAIN_CONTEXT
	{
		internal uint cbSize;

		internal uint dwErrorStatus;

		internal uint dwInfoStatus;

		internal uint cChain;

		internal IntPtr rgpChain;

		internal uint cLowerQualityChainContext;

		internal IntPtr rgpLowerQualityChainContext;

		internal uint fHasRevocationFreshnessTime;

		internal uint dwRevocationFreshnessTime;

		internal CERT_CHAIN_CONTEXT(int size)
		{
			cbSize = (uint)size;
			dwErrorStatus = 0u;
			dwInfoStatus = 0u;
			cChain = 0u;
			rgpChain = IntPtr.Zero;
			cLowerQualityChainContext = 0u;
			rgpLowerQualityChainContext = IntPtr.Zero;
			fHasRevocationFreshnessTime = 0u;
			dwRevocationFreshnessTime = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CHAIN_ELEMENT
	{
		internal uint cbSize;

		internal IntPtr pCertContext;

		internal uint dwErrorStatus;

		internal uint dwInfoStatus;

		internal IntPtr pRevocationInfo;

		internal IntPtr pIssuanceUsage;

		internal IntPtr pApplicationUsage;

		internal IntPtr pwszExtendedErrorInfo;

		internal CERT_CHAIN_ELEMENT(int size)
		{
			cbSize = (uint)size;
			pCertContext = IntPtr.Zero;
			dwErrorStatus = 0u;
			dwInfoStatus = 0u;
			pRevocationInfo = IntPtr.Zero;
			pIssuanceUsage = IntPtr.Zero;
			pApplicationUsage = IntPtr.Zero;
			pwszExtendedErrorInfo = IntPtr.Zero;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CHAIN_PARA
	{
		internal uint cbSize;

		internal CERT_USAGE_MATCH RequestedUsage;

		internal CERT_USAGE_MATCH RequestedIssuancePolicy;

		internal uint dwUrlRetrievalTimeout;

		internal bool fCheckRevocationFreshnessTime;

		internal uint dwRevocationFreshnessTime;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CHAIN_POLICY_PARA
	{
		internal uint cbSize;

		internal uint dwFlags;

		internal IntPtr pvExtraPolicyPara;

		internal CERT_CHAIN_POLICY_PARA(int size)
		{
			cbSize = (uint)size;
			dwFlags = 0u;
			pvExtraPolicyPara = IntPtr.Zero;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CHAIN_POLICY_STATUS
	{
		internal uint cbSize;

		internal uint dwError;

		internal IntPtr lChainIndex;

		internal IntPtr lElementIndex;

		internal IntPtr pvExtraPolicyStatus;

		internal CERT_CHAIN_POLICY_STATUS(int size)
		{
			cbSize = (uint)size;
			dwError = 0u;
			lChainIndex = IntPtr.Zero;
			lElementIndex = IntPtr.Zero;
			pvExtraPolicyStatus = IntPtr.Zero;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CONTEXT
	{
		internal uint dwCertEncodingType;

		internal IntPtr pbCertEncoded;

		internal uint cbCertEncoded;

		internal IntPtr pCertInfo;

		internal IntPtr hCertStore;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_DSS_PARAMETERS
	{
		internal CRYPTOAPI_BLOB p;

		internal CRYPTOAPI_BLOB q;

		internal CRYPTOAPI_BLOB g;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_ENHKEY_USAGE
	{
		internal uint cUsageIdentifier;

		internal IntPtr rgpszUsageIdentifier;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_EXTENSION
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal bool fCritical;

		internal CRYPTOAPI_BLOB Value;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_ID
	{
		internal uint dwIdChoice;

		internal CERT_ID_UNION Value;
	}

	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	internal struct CERT_ID_UNION
	{
		[FieldOffset(0)]
		internal CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber;

		[FieldOffset(0)]
		internal CRYPTOAPI_BLOB KeyId;

		[FieldOffset(0)]
		internal CRYPTOAPI_BLOB HashId;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_ISSUER_SERIAL_NUMBER
	{
		internal CRYPTOAPI_BLOB Issuer;

		internal CRYPTOAPI_BLOB SerialNumber;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_INFO
	{
		internal uint dwVersion;

		internal CRYPTOAPI_BLOB SerialNumber;

		internal CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

		internal CRYPTOAPI_BLOB Issuer;

		internal System.Runtime.InteropServices.ComTypes.FILETIME NotBefore;

		internal System.Runtime.InteropServices.ComTypes.FILETIME NotAfter;

		internal CRYPTOAPI_BLOB Subject;

		internal CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

		internal CRYPT_BIT_BLOB IssuerUniqueId;

		internal CRYPT_BIT_BLOB SubjectUniqueId;

		internal uint cExtension;

		internal IntPtr rgExtension;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_KEY_USAGE_RESTRICTION_INFO
	{
		internal uint cCertPolicyId;

		internal IntPtr rgCertPolicyId;

		internal CRYPT_BIT_BLOB RestrictedKeyUsage;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_NAME_INFO
	{
		internal uint cRDN;

		internal IntPtr rgRDN;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_NAME_VALUE
	{
		internal uint dwValueType;

		internal CRYPTOAPI_BLOB Value;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_OTHER_NAME
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal CRYPTOAPI_BLOB Value;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_POLICY_ID
	{
		internal uint cCertPolicyElementId;

		internal IntPtr rgpszCertPolicyElementId;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_POLICIES_INFO
	{
		internal uint cPolicyInfo;

		internal IntPtr rgPolicyInfo;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_POLICY_INFO
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszPolicyIdentifier;

		internal uint cPolicyQualifier;

		internal IntPtr rgPolicyQualifier;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_POLICY_QUALIFIER_INFO
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszPolicyQualifierId;

		private CRYPTOAPI_BLOB Qualifier;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_PUBLIC_KEY_INFO
	{
		internal CRYPT_ALGORITHM_IDENTIFIER Algorithm;

		internal CRYPT_BIT_BLOB PublicKey;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_PUBLIC_KEY_INFO2
	{
		internal CRYPT_ALGORITHM_IDENTIFIER2 Algorithm;

		internal CRYPT_BIT_BLOB PublicKey;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_RDN
	{
		internal uint cRDNAttr;

		internal IntPtr rgRDNAttr;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_RDN_ATTR
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal uint dwValueType;

		internal CRYPTOAPI_BLOB Value;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_SIMPLE_CHAIN
	{
		internal uint cbSize;

		internal uint dwErrorStatus;

		internal uint dwInfoStatus;

		internal uint cElement;

		internal IntPtr rgpElement;

		internal IntPtr pTrustListInfo;

		internal uint fHasRevocationFreshnessTime;

		internal uint dwRevocationFreshnessTime;

		internal CERT_SIMPLE_CHAIN(int size)
		{
			cbSize = (uint)size;
			dwErrorStatus = 0u;
			dwInfoStatus = 0u;
			cElement = 0u;
			rgpElement = IntPtr.Zero;
			pTrustListInfo = IntPtr.Zero;
			fHasRevocationFreshnessTime = 0u;
			dwRevocationFreshnessTime = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_TEMPLATE_EXT
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal uint dwMajorVersion;

		private bool fMinorVersion;

		private uint dwMinorVersion;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_TRUST_STATUS
	{
		internal uint dwErrorStatus;

		internal uint dwInfoStatus;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_USAGE_MATCH
	{
		internal uint dwType;

		internal CERT_ENHKEY_USAGE Usage;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CMS_RECIPIENT_INFO
	{
		internal uint dwRecipientChoice;

		internal IntPtr pRecipientInfo;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CMS_SIGNER_INFO
	{
		internal uint dwVersion;

		internal CERT_ID SignerId;

		internal CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

		internal CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;

		internal CRYPTOAPI_BLOB EncryptedHash;

		internal CRYPT_ATTRIBUTES AuthAttrs;

		internal CRYPT_ATTRIBUTES UnauthAttrs;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA
	{
		internal uint cbSize;

		internal uint dwSignerIndex;

		internal CRYPTOAPI_BLOB blob;

		internal CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA(int size)
		{
			cbSize = (uint)size;
			dwSignerIndex = 0u;
			blob = default(CRYPTOAPI_BLOB);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CTRL_DECRYPT_PARA
	{
		internal uint cbSize;

		internal IntPtr hCryptProv;

		internal uint dwKeySpec;

		internal uint dwRecipientIndex;

		internal CMSG_CTRL_DECRYPT_PARA(int size)
		{
			cbSize = (uint)size;
			hCryptProv = IntPtr.Zero;
			dwKeySpec = 0u;
			dwRecipientIndex = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR_PARA
	{
		internal uint cbSize;

		internal uint dwSignerIndex;

		internal uint dwUnauthAttrIndex;

		internal CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR_PARA(int size)
		{
			cbSize = (uint)size;
			dwSignerIndex = 0u;
			dwUnauthAttrIndex = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CTRL_KEY_TRANS_DECRYPT_PARA
	{
		internal uint cbSize;

		internal SafeCryptProvHandle hCryptProv;

		internal uint dwKeySpec;

		internal IntPtr pKeyTrans;

		internal uint dwRecipientIndex;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO
	{
		internal uint cbSize;

		internal CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

		internal IntPtr pvKeyEncryptionAuxInfo;

		internal CRYPT_ALGORITHM_IDENTIFIER KeyWrapAlgorithm;

		internal IntPtr pvKeyWrapAuxInfo;

		internal IntPtr hCryptProv;

		internal uint dwKeySpec;

		internal uint dwKeyChoice;

		internal IntPtr pEphemeralAlgorithmOrSenderId;

		internal CRYPTOAPI_BLOB UserKeyingMaterial;

		internal uint cRecipientEncryptedKeys;

		internal IntPtr rgpRecipientEncryptedKeys;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO
	{
		internal uint cbSize;

		internal CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

		internal IntPtr pvKeyEncryptionAuxInfo;

		internal IntPtr hCryptProv;

		internal CRYPT_BIT_BLOB RecipientPublicKey;

		internal CERT_ID RecipientId;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_RC2_AUX_INFO
	{
		internal uint cbSize;

		internal uint dwBitLen;

		internal CMSG_RC2_AUX_INFO(int size)
		{
			cbSize = (uint)size;
			dwBitLen = 0u;
		}
	}

	internal struct CMSG_RECIPIENT_ENCODE_INFO
	{
		internal uint dwRecipientChoice;

		internal IntPtr pRecipientInfo;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO
	{
		internal uint cbSize;

		internal CRYPT_BIT_BLOB RecipientPublicKey;

		internal CERT_ID RecipientId;

		internal System.Runtime.InteropServices.ComTypes.FILETIME Date;

		internal IntPtr pOtherAttr;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_ENVELOPED_ENCODE_INFO
	{
		internal uint cbSize;

		internal IntPtr hCryptProv;

		internal CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

		internal IntPtr pvEncryptionAuxInfo;

		internal uint cRecipients;

		internal IntPtr rgpRecipients;

		internal IntPtr rgCmsRecipients;

		internal uint cCertEncoded;

		internal IntPtr rgCertEncoded;

		internal uint cCrlEncoded;

		internal IntPtr rgCrlEncoded;

		internal uint cAttrCertEncoded;

		internal IntPtr rgAttrCertEncoded;

		internal uint cUnprotectedAttr;

		internal IntPtr rgUnprotectedAttr;

		internal CMSG_ENVELOPED_ENCODE_INFO(int size)
		{
			cbSize = (uint)size;
			hCryptProv = IntPtr.Zero;
			ContentEncryptionAlgorithm = default(CRYPT_ALGORITHM_IDENTIFIER);
			pvEncryptionAuxInfo = IntPtr.Zero;
			cRecipients = 0u;
			rgpRecipients = IntPtr.Zero;
			rgCmsRecipients = IntPtr.Zero;
			cCertEncoded = 0u;
			rgCertEncoded = IntPtr.Zero;
			cCrlEncoded = 0u;
			rgCrlEncoded = IntPtr.Zero;
			cAttrCertEncoded = 0u;
			rgAttrCertEncoded = IntPtr.Zero;
			cUnprotectedAttr = 0u;
			rgUnprotectedAttr = IntPtr.Zero;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CTRL_KEY_AGREE_DECRYPT_PARA
	{
		internal uint cbSize;

		internal IntPtr hCryptProv;

		internal uint dwKeySpec;

		internal IntPtr pKeyAgree;

		internal uint dwRecipientIndex;

		internal uint dwRecipientEncryptedKeyIndex;

		internal CRYPT_BIT_BLOB OriginatorPublicKey;

		internal CMSG_CTRL_KEY_AGREE_DECRYPT_PARA(int size)
		{
			cbSize = (uint)size;
			hCryptProv = IntPtr.Zero;
			dwKeySpec = 0u;
			pKeyAgree = IntPtr.Zero;
			dwRecipientIndex = 0u;
			dwRecipientEncryptedKeyIndex = 0u;
			OriginatorPublicKey = default(CRYPT_BIT_BLOB);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_KEY_AGREE_RECIPIENT_INFO
	{
		internal uint dwVersion;

		internal uint dwOriginatorChoice;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_KEY_AGREE_CERT_ID_RECIPIENT_INFO
	{
		internal uint dwVersion;

		internal uint dwOriginatorChoice;

		internal CERT_ID OriginatorCertId;

		internal IntPtr Padding;

		internal CRYPTOAPI_BLOB UserKeyingMaterial;

		internal CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

		internal uint cRecipientEncryptedKeys;

		internal IntPtr rgpRecipientEncryptedKeys;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_KEY_AGREE_PUBLIC_KEY_RECIPIENT_INFO
	{
		internal uint dwVersion;

		internal uint dwOriginatorChoice;

		internal CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;

		internal CRYPTOAPI_BLOB UserKeyingMaterial;

		internal CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

		internal uint cRecipientEncryptedKeys;

		internal IntPtr rgpRecipientEncryptedKeys;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_RECIPIENT_ENCRYPTED_KEY_INFO
	{
		internal CERT_ID RecipientId;

		internal CRYPTOAPI_BLOB EncryptedKey;

		internal System.Runtime.InteropServices.ComTypes.FILETIME Date;

		internal IntPtr pOtherAttr;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA
	{
		internal uint cbSize;

		internal IntPtr hCryptProv;

		internal uint dwSignerIndex;

		internal uint dwSignerType;

		internal IntPtr pvSigner;

		internal CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA(int size)
		{
			cbSize = (uint)size;
			hCryptProv = IntPtr.Zero;
			dwSignerIndex = 0u;
			dwSignerType = 0u;
			pvSigner = IntPtr.Zero;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_KEY_TRANS_RECIPIENT_INFO
	{
		internal uint dwVersion;

		internal CERT_ID RecipientId;

		internal CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

		internal CRYPTOAPI_BLOB EncryptedKey;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_SIGNED_ENCODE_INFO
	{
		internal uint cbSize;

		internal uint cSigners;

		internal IntPtr rgSigners;

		internal uint cCertEncoded;

		internal IntPtr rgCertEncoded;

		internal uint cCrlEncoded;

		internal IntPtr rgCrlEncoded;

		internal uint cAttrCertEncoded;

		internal IntPtr rgAttrCertEncoded;

		internal CMSG_SIGNED_ENCODE_INFO(int size)
		{
			cbSize = (uint)size;
			cSigners = 0u;
			rgSigners = IntPtr.Zero;
			cCertEncoded = 0u;
			rgCertEncoded = IntPtr.Zero;
			cCrlEncoded = 0u;
			rgCrlEncoded = IntPtr.Zero;
			cAttrCertEncoded = 0u;
			rgAttrCertEncoded = IntPtr.Zero;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_SIGNER_ENCODE_INFO
	{
		internal uint cbSize;

		internal IntPtr pCertInfo;

		internal IntPtr hCryptProv;

		internal uint dwKeySpec;

		internal CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

		internal IntPtr pvHashAuxInfo;

		internal uint cAuthAttr;

		internal IntPtr rgAuthAttr;

		internal uint cUnauthAttr;

		internal IntPtr rgUnauthAttr;

		internal CERT_ID SignerId;

		internal CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;

		internal IntPtr pvHashEncryptionAuxInfo;

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr LocalFree(IntPtr hMem);

		[DllImport("advapi32.dll", SetLastError = true)]
		internal static extern bool CryptReleaseContext([In] IntPtr hProv, [In] uint dwFlags);

		internal CMSG_SIGNER_ENCODE_INFO(int size)
		{
			cbSize = (uint)size;
			pCertInfo = IntPtr.Zero;
			hCryptProv = IntPtr.Zero;
			dwKeySpec = 0u;
			HashAlgorithm = default(CRYPT_ALGORITHM_IDENTIFIER);
			pvHashAuxInfo = IntPtr.Zero;
			cAuthAttr = 0u;
			rgAuthAttr = IntPtr.Zero;
			cUnauthAttr = 0u;
			rgUnauthAttr = IntPtr.Zero;
			SignerId = default(CERT_ID);
			HashEncryptionAlgorithm = default(CRYPT_ALGORITHM_IDENTIFIER);
			pvHashEncryptionAuxInfo = IntPtr.Zero;
		}

		internal void Dispose()
		{
			if (hCryptProv != IntPtr.Zero)
			{
				CryptReleaseContext(hCryptProv, 0u);
			}
			if (SignerId.Value.KeyId.pbData != IntPtr.Zero)
			{
				LocalFree(SignerId.Value.KeyId.pbData);
			}
			if (rgAuthAttr != IntPtr.Zero)
			{
				LocalFree(rgAuthAttr);
			}
			if (rgUnauthAttr != IntPtr.Zero)
			{
				LocalFree(rgUnauthAttr);
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CMSG_SIGNER_INFO
	{
		internal uint dwVersion;

		internal CRYPTOAPI_BLOB Issuer;

		internal CRYPTOAPI_BLOB SerialNumber;

		internal CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

		internal CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;

		internal CRYPTOAPI_BLOB EncryptedHash;

		internal CRYPT_ATTRIBUTES AuthAttrs;

		internal CRYPT_ATTRIBUTES UnauthAttrs;
	}

	internal delegate bool PFN_CMSG_STREAM_OUTPUT(IntPtr pvArg, IntPtr pbData, uint cbData, bool fFinal);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal class CMSG_STREAM_INFO
	{
		internal uint cbContent;

		internal PFN_CMSG_STREAM_OUTPUT pfnStreamOutput;

		internal IntPtr pvArg;

		internal CMSG_STREAM_INFO(uint cbContent, PFN_CMSG_STREAM_OUTPUT pfnStreamOutput, IntPtr pvArg)
		{
			this.cbContent = cbContent;
			this.pfnStreamOutput = pfnStreamOutput;
			this.pvArg = pvArg;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_ALGORITHM_IDENTIFIER
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal CRYPTOAPI_BLOB Parameters;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_ALGORITHM_IDENTIFIER2
	{
		internal IntPtr pszObjId;

		internal CRYPTOAPI_BLOB Parameters;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_ATTRIBUTE
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal uint cValue;

		internal IntPtr rgValue;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_ATTRIBUTES
	{
		internal uint cAttr;

		internal IntPtr rgAttr;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_ATTRIBUTE_TYPE_VALUE
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal CRYPTOAPI_BLOB Value;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_BIT_BLOB
	{
		internal uint cbData;

		internal IntPtr pbData;

		internal uint cUnusedBits;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_KEY_PROV_INFO
	{
		internal string pwszContainerName;

		internal string pwszProvName;

		internal uint dwProvType;

		internal uint dwFlags;

		internal uint cProvParam;

		internal IntPtr rgProvParam;

		internal uint dwKeySpec;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_OID_INFO
	{
		internal uint cbSize;

		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszOID;

		internal string pwszName;

		internal uint dwGroupId;

		internal uint Algid;

		internal CRYPTOAPI_BLOB ExtraInfo;

		internal CRYPT_OID_INFO(int size)
		{
			cbSize = (uint)size;
			pszOID = null;
			pwszName = null;
			dwGroupId = 0u;
			Algid = 0u;
			ExtraInfo = default(CRYPTOAPI_BLOB);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_RC2_CBC_PARAMETERS
	{
		internal uint dwVersion;

		internal bool fIV;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		internal byte[] rgbIV;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPTOAPI_BLOB
	{
		internal uint cbData;

		internal IntPtr pbData;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct DSSPUBKEY
	{
		internal uint magic;

		internal uint bitlen;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct KEY_USAGE_STRUCT
	{
		internal string pwszKeyUsage;

		internal uint dwKeyUsageBit;

		internal KEY_USAGE_STRUCT(string pwszKeyUsage, uint dwKeyUsageBit)
		{
			this.pwszKeyUsage = pwszKeyUsage;
			this.dwKeyUsageBit = dwKeyUsageBit;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct PROV_ENUMALGS_EX
	{
		internal uint aiAlgid;

		internal uint dwDefaultLen;

		internal uint dwMinLen;

		internal uint dwMaxLen;

		internal uint dwProtocols;

		internal uint dwNameLen;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		internal byte[] szName;

		internal uint dwLongNameLen;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
		internal byte[] szLongName;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct RSAPUBKEY
	{
		internal uint magic;

		internal uint bitlen;

		internal uint pubexp;
	}

	internal const string ADVAPI32 = "advapi32.dll";

	internal const string CRYPT32 = "crypt32.dll";

	internal const string KERNEL32 = "kernel32.dll";

	internal const uint LMEM_FIXED = 0u;

	internal const uint LMEM_ZEROINIT = 64u;

	internal const uint LPTR = 64u;

	internal const int S_OK = 0;

	internal const int S_FALSE = 1;

	internal const uint FORMAT_MESSAGE_FROM_SYSTEM = 4096u;

	internal const uint FORMAT_MESSAGE_IGNORE_INSERTS = 512u;

	internal const uint VER_PLATFORM_WIN32s = 0u;

	internal const uint VER_PLATFORM_WIN32_WINDOWS = 1u;

	internal const uint VER_PLATFORM_WIN32_NT = 2u;

	internal const uint VER_PLATFORM_WINCE = 3u;

	internal const uint ASN_TAG_NULL = 5u;

	internal const uint ASN_TAG_OBJID = 6u;

	internal const uint CERT_QUERY_OBJECT_FILE = 1u;

	internal const uint CERT_QUERY_OBJECT_BLOB = 2u;

	internal const uint CERT_QUERY_CONTENT_CERT = 1u;

	internal const uint CERT_QUERY_CONTENT_CTL = 2u;

	internal const uint CERT_QUERY_CONTENT_CRL = 3u;

	internal const uint CERT_QUERY_CONTENT_SERIALIZED_STORE = 4u;

	internal const uint CERT_QUERY_CONTENT_SERIALIZED_CERT = 5u;

	internal const uint CERT_QUERY_CONTENT_SERIALIZED_CTL = 6u;

	internal const uint CERT_QUERY_CONTENT_SERIALIZED_CRL = 7u;

	internal const uint CERT_QUERY_CONTENT_PKCS7_SIGNED = 8u;

	internal const uint CERT_QUERY_CONTENT_PKCS7_UNSIGNED = 9u;

	internal const uint CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED = 10u;

	internal const uint CERT_QUERY_CONTENT_PKCS10 = 11u;

	internal const uint CERT_QUERY_CONTENT_PFX = 12u;

	internal const uint CERT_QUERY_CONTENT_CERT_PAIR = 13u;

	internal const uint CERT_QUERY_CONTENT_FLAG_CERT = 2u;

	internal const uint CERT_QUERY_CONTENT_FLAG_CTL = 4u;

	internal const uint CERT_QUERY_CONTENT_FLAG_CRL = 8u;

	internal const uint CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE = 16u;

	internal const uint CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT = 32u;

	internal const uint CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL = 64u;

	internal const uint CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL = 128u;

	internal const uint CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED = 256u;

	internal const uint CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED = 512u;

	internal const uint CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED = 1024u;

	internal const uint CERT_QUERY_CONTENT_FLAG_PKCS10 = 2048u;

	internal const uint CERT_QUERY_CONTENT_FLAG_PFX = 4096u;

	internal const uint CERT_QUERY_CONTENT_FLAG_CERT_PAIR = 8192u;

	internal const uint CERT_QUERY_CONTENT_FLAG_ALL = 16382u;

	internal const uint CERT_QUERY_FORMAT_BINARY = 1u;

	internal const uint CERT_QUERY_FORMAT_BASE64_ENCODED = 2u;

	internal const uint CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3u;

	internal const uint CERT_QUERY_FORMAT_FLAG_BINARY = 2u;

	internal const uint CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = 4u;

	internal const uint CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = 8u;

	internal const uint CERT_QUERY_FORMAT_FLAG_ALL = 14u;

	internal const uint CRYPT_OID_INFO_OID_KEY = 1u;

	internal const uint CRYPT_OID_INFO_NAME_KEY = 2u;

	internal const uint CRYPT_OID_INFO_ALGID_KEY = 3u;

	internal const uint CRYPT_OID_INFO_SIGN_KEY = 4u;

	internal const uint CRYPT_HASH_ALG_OID_GROUP_ID = 1u;

	internal const uint CRYPT_ENCRYPT_ALG_OID_GROUP_ID = 2u;

	internal const uint CRYPT_PUBKEY_ALG_OID_GROUP_ID = 3u;

	internal const uint CRYPT_SIGN_ALG_OID_GROUP_ID = 4u;

	internal const uint CRYPT_RDN_ATTR_OID_GROUP_ID = 5u;

	internal const uint CRYPT_EXT_OR_ATTR_OID_GROUP_ID = 6u;

	internal const uint CRYPT_ENHKEY_USAGE_OID_GROUP_ID = 7u;

	internal const uint CRYPT_POLICY_OID_GROUP_ID = 8u;

	internal const uint CRYPT_TEMPLATE_OID_GROUP_ID = 9u;

	internal const uint CRYPT_LAST_OID_GROUP_ID = 9u;

	internal const uint CRYPT_FIRST_ALG_OID_GROUP_ID = 1u;

	internal const uint CRYPT_LAST_ALG_OID_GROUP_ID = 4u;

	internal const uint CRYPT_ASN_ENCODING = 1u;

	internal const uint CRYPT_NDR_ENCODING = 2u;

	internal const uint X509_ASN_ENCODING = 1u;

	internal const uint X509_NDR_ENCODING = 2u;

	internal const uint PKCS_7_ASN_ENCODING = 65536u;

	internal const uint PKCS_7_NDR_ENCODING = 131072u;

	internal const uint PKCS_7_OR_X509_ASN_ENCODING = 65537u;

	internal const uint CERT_STORE_PROV_MSG = 1u;

	internal const uint CERT_STORE_PROV_MEMORY = 2u;

	internal const uint CERT_STORE_PROV_FILE = 3u;

	internal const uint CERT_STORE_PROV_REG = 4u;

	internal const uint CERT_STORE_PROV_PKCS7 = 5u;

	internal const uint CERT_STORE_PROV_SERIALIZED = 6u;

	internal const uint CERT_STORE_PROV_FILENAME_A = 7u;

	internal const uint CERT_STORE_PROV_FILENAME_W = 8u;

	internal const uint CERT_STORE_PROV_FILENAME = 8u;

	internal const uint CERT_STORE_PROV_SYSTEM_A = 9u;

	internal const uint CERT_STORE_PROV_SYSTEM_W = 10u;

	internal const uint CERT_STORE_PROV_SYSTEM = 10u;

	internal const uint CERT_STORE_PROV_COLLECTION = 11u;

	internal const uint CERT_STORE_PROV_SYSTEM_REGISTRY_A = 12u;

	internal const uint CERT_STORE_PROV_SYSTEM_REGISTRY_W = 13u;

	internal const uint CERT_STORE_PROV_SYSTEM_REGISTRY = 13u;

	internal const uint CERT_STORE_PROV_PHYSICAL_W = 14u;

	internal const uint CERT_STORE_PROV_PHYSICAL = 14u;

	internal const uint CERT_STORE_PROV_SMART_CARD_W = 15u;

	internal const uint CERT_STORE_PROV_SMART_CARD = 15u;

	internal const uint CERT_STORE_PROV_LDAP_W = 16u;

	internal const uint CERT_STORE_PROV_LDAP = 16u;

	internal const uint CERT_STORE_NO_CRYPT_RELEASE_FLAG = 1u;

	internal const uint CERT_STORE_SET_LOCALIZED_NAME_FLAG = 2u;

	internal const uint CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG = 4u;

	internal const uint CERT_STORE_DELETE_FLAG = 16u;

	internal const uint CERT_STORE_SHARE_STORE_FLAG = 64u;

	internal const uint CERT_STORE_SHARE_CONTEXT_FLAG = 128u;

	internal const uint CERT_STORE_MANIFOLD_FLAG = 256u;

	internal const uint CERT_STORE_ENUM_ARCHIVED_FLAG = 512u;

	internal const uint CERT_STORE_UPDATE_KEYID_FLAG = 1024u;

	internal const uint CERT_STORE_BACKUP_RESTORE_FLAG = 2048u;

	internal const uint CERT_STORE_READONLY_FLAG = 32768u;

	internal const uint CERT_STORE_OPEN_EXISTING_FLAG = 16384u;

	internal const uint CERT_STORE_CREATE_NEW_FLAG = 8192u;

	internal const uint CERT_STORE_MAXIMUM_ALLOWED_FLAG = 4096u;

	internal const uint CERT_SYSTEM_STORE_UNPROTECTED_FLAG = 1073741824u;

	internal const uint CERT_SYSTEM_STORE_LOCATION_MASK = 16711680u;

	internal const uint CERT_SYSTEM_STORE_LOCATION_SHIFT = 16u;

	internal const uint CERT_SYSTEM_STORE_CURRENT_USER_ID = 1u;

	internal const uint CERT_SYSTEM_STORE_LOCAL_MACHINE_ID = 2u;

	internal const uint CERT_SYSTEM_STORE_CURRENT_SERVICE_ID = 4u;

	internal const uint CERT_SYSTEM_STORE_SERVICES_ID = 5u;

	internal const uint CERT_SYSTEM_STORE_USERS_ID = 6u;

	internal const uint CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID = 7u;

	internal const uint CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID = 8u;

	internal const uint CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID = 9u;

	internal const uint CERT_SYSTEM_STORE_CURRENT_USER = 65536u;

	internal const uint CERT_SYSTEM_STORE_LOCAL_MACHINE = 131072u;

	internal const uint CERT_SYSTEM_STORE_CURRENT_SERVICE = 262144u;

	internal const uint CERT_SYSTEM_STORE_SERVICES = 327680u;

	internal const uint CERT_SYSTEM_STORE_USERS = 393216u;

	internal const uint CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY = 458752u;

	internal const uint CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY = 524288u;

	internal const uint CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE = 589824u;

	internal const uint CERT_NAME_EMAIL_TYPE = 1u;

	internal const uint CERT_NAME_RDN_TYPE = 2u;

	internal const uint CERT_NAME_ATTR_TYPE = 3u;

	internal const uint CERT_NAME_SIMPLE_DISPLAY_TYPE = 4u;

	internal const uint CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5u;

	internal const uint CERT_NAME_DNS_TYPE = 6u;

	internal const uint CERT_NAME_URL_TYPE = 7u;

	internal const uint CERT_NAME_UPN_TYPE = 8u;

	internal const uint CERT_SIMPLE_NAME_STR = 1u;

	internal const uint CERT_OID_NAME_STR = 2u;

	internal const uint CERT_X500_NAME_STR = 3u;

	internal const uint CERT_NAME_STR_SEMICOLON_FLAG = 1073741824u;

	internal const uint CERT_NAME_STR_NO_PLUS_FLAG = 536870912u;

	internal const uint CERT_NAME_STR_NO_QUOTING_FLAG = 268435456u;

	internal const uint CERT_NAME_STR_CRLF_FLAG = 134217728u;

	internal const uint CERT_NAME_STR_COMMA_FLAG = 67108864u;

	internal const uint CERT_NAME_STR_REVERSE_FLAG = 33554432u;

	internal const uint CERT_NAME_ISSUER_FLAG = 1u;

	internal const uint CERT_NAME_STR_DISABLE_IE4_UTF8_FLAG = 65536u;

	internal const uint CERT_NAME_STR_ENABLE_T61_UNICODE_FLAG = 131072u;

	internal const uint CERT_NAME_STR_ENABLE_UTF8_UNICODE_FLAG = 262144u;

	internal const uint CERT_NAME_STR_FORCE_UTF8_DIR_STR_FLAG = 524288u;

	internal const uint CERT_KEY_PROV_HANDLE_PROP_ID = 1u;

	internal const uint CERT_KEY_PROV_INFO_PROP_ID = 2u;

	internal const uint CERT_SHA1_HASH_PROP_ID = 3u;

	internal const uint CERT_MD5_HASH_PROP_ID = 4u;

	internal const uint CERT_HASH_PROP_ID = 3u;

	internal const uint CERT_KEY_CONTEXT_PROP_ID = 5u;

	internal const uint CERT_KEY_SPEC_PROP_ID = 6u;

	internal const uint CERT_IE30_RESERVED_PROP_ID = 7u;

	internal const uint CERT_PUBKEY_HASH_RESERVED_PROP_ID = 8u;

	internal const uint CERT_ENHKEY_USAGE_PROP_ID = 9u;

	internal const uint CERT_CTL_USAGE_PROP_ID = 9u;

	internal const uint CERT_NEXT_UPDATE_LOCATION_PROP_ID = 10u;

	internal const uint CERT_FRIENDLY_NAME_PROP_ID = 11u;

	internal const uint CERT_PVK_FILE_PROP_ID = 12u;

	internal const uint CERT_DESCRIPTION_PROP_ID = 13u;

	internal const uint CERT_ACCESS_STATE_PROP_ID = 14u;

	internal const uint CERT_SIGNATURE_HASH_PROP_ID = 15u;

	internal const uint CERT_SMART_CARD_DATA_PROP_ID = 16u;

	internal const uint CERT_EFS_PROP_ID = 17u;

	internal const uint CERT_FORTEZZA_DATA_PROP_ID = 18u;

	internal const uint CERT_ARCHIVED_PROP_ID = 19u;

	internal const uint CERT_KEY_IDENTIFIER_PROP_ID = 20u;

	internal const uint CERT_AUTO_ENROLL_PROP_ID = 21u;

	internal const uint CERT_PUBKEY_ALG_PARA_PROP_ID = 22u;

	internal const uint CERT_CROSS_CERT_DIST_POINTS_PROP_ID = 23u;

	internal const uint CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID = 24u;

	internal const uint CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID = 25u;

	internal const uint CERT_ENROLLMENT_PROP_ID = 26u;

	internal const uint CERT_DATE_STAMP_PROP_ID = 27u;

	internal const uint CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID = 28u;

	internal const uint CERT_SUBJECT_NAME_MD5_HASH_PROP_ID = 29u;

	internal const uint CERT_EXTENDED_ERROR_INFO_PROP_ID = 30u;

	internal const uint CERT_RENEWAL_PROP_ID = 64u;

	internal const uint CERT_ARCHIVED_KEY_HASH_PROP_ID = 65u;

	internal const uint CERT_FIRST_RESERVED_PROP_ID = 66u;

	internal const uint CERT_NCRYPT_KEY_HANDLE_PROP_ID = 78u;

	internal const uint CERT_DELETE_KEYSET_PROP_ID = 125u;

	internal const uint CERT_SET_PROPERTY_IGNORE_PERSIST_ERROR_FLAG = 2147483648u;

	internal const uint CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG = 1073741824u;

	internal const uint CERT_INFO_VERSION_FLAG = 1u;

	internal const uint CERT_INFO_SERIAL_NUMBER_FLAG = 2u;

	internal const uint CERT_INFO_SIGNATURE_ALGORITHM_FLAG = 3u;

	internal const uint CERT_INFO_ISSUER_FLAG = 4u;

	internal const uint CERT_INFO_NOT_BEFORE_FLAG = 5u;

	internal const uint CERT_INFO_NOT_AFTER_FLAG = 6u;

	internal const uint CERT_INFO_SUBJECT_FLAG = 7u;

	internal const uint CERT_INFO_SUBJECT_PUBLIC_KEY_INFO_FLAG = 8u;

	internal const uint CERT_INFO_ISSUER_UNIQUE_ID_FLAG = 9u;

	internal const uint CERT_INFO_SUBJECT_UNIQUE_ID_FLAG = 10u;

	internal const uint CERT_INFO_EXTENSION_FLAG = 11u;

	internal const uint CERT_COMPARE_MASK = 65535u;

	internal const uint CERT_COMPARE_SHIFT = 16u;

	internal const uint CERT_COMPARE_ANY = 0u;

	internal const uint CERT_COMPARE_SHA1_HASH = 1u;

	internal const uint CERT_COMPARE_NAME = 2u;

	internal const uint CERT_COMPARE_ATTR = 3u;

	internal const uint CERT_COMPARE_MD5_HASH = 4u;

	internal const uint CERT_COMPARE_PROPERTY = 5u;

	internal const uint CERT_COMPARE_PUBLIC_KEY = 6u;

	internal const uint CERT_COMPARE_HASH = 1u;

	internal const uint CERT_COMPARE_NAME_STR_A = 7u;

	internal const uint CERT_COMPARE_NAME_STR_W = 8u;

	internal const uint CERT_COMPARE_KEY_SPEC = 9u;

	internal const uint CERT_COMPARE_ENHKEY_USAGE = 10u;

	internal const uint CERT_COMPARE_CTL_USAGE = 10u;

	internal const uint CERT_COMPARE_SUBJECT_CERT = 11u;

	internal const uint CERT_COMPARE_ISSUER_OF = 12u;

	internal const uint CERT_COMPARE_EXISTING = 13u;

	internal const uint CERT_COMPARE_SIGNATURE_HASH = 14u;

	internal const uint CERT_COMPARE_KEY_IDENTIFIER = 15u;

	internal const uint CERT_COMPARE_CERT_ID = 16u;

	internal const uint CERT_COMPARE_CROSS_CERT_DIST_POINTS = 17u;

	internal const uint CERT_COMPARE_PUBKEY_MD5_HASH = 18u;

	internal const uint CERT_FIND_ANY = 0u;

	internal const uint CERT_FIND_SHA1_HASH = 65536u;

	internal const uint CERT_FIND_MD5_HASH = 262144u;

	internal const uint CERT_FIND_SIGNATURE_HASH = 917504u;

	internal const uint CERT_FIND_KEY_IDENTIFIER = 983040u;

	internal const uint CERT_FIND_HASH = 65536u;

	internal const uint CERT_FIND_PROPERTY = 327680u;

	internal const uint CERT_FIND_PUBLIC_KEY = 393216u;

	internal const uint CERT_FIND_SUBJECT_NAME = 131079u;

	internal const uint CERT_FIND_SUBJECT_ATTR = 196615u;

	internal const uint CERT_FIND_ISSUER_NAME = 131076u;

	internal const uint CERT_FIND_ISSUER_ATTR = 196612u;

	internal const uint CERT_FIND_SUBJECT_STR_A = 458759u;

	internal const uint CERT_FIND_SUBJECT_STR_W = 524295u;

	internal const uint CERT_FIND_SUBJECT_STR = 524295u;

	internal const uint CERT_FIND_ISSUER_STR_A = 458756u;

	internal const uint CERT_FIND_ISSUER_STR_W = 524292u;

	internal const uint CERT_FIND_ISSUER_STR = 524292u;

	internal const uint CERT_FIND_KEY_SPEC = 589824u;

	internal const uint CERT_FIND_ENHKEY_USAGE = 655360u;

	internal const uint CERT_FIND_CTL_USAGE = 655360u;

	internal const uint CERT_FIND_SUBJECT_CERT = 720896u;

	internal const uint CERT_FIND_ISSUER_OF = 786432u;

	internal const uint CERT_FIND_EXISTING = 851968u;

	internal const uint CERT_FIND_CERT_ID = 1048576u;

	internal const uint CERT_FIND_CROSS_CERT_DIST_POINTS = 1114112u;

	internal const uint CERT_FIND_PUBKEY_MD5_HASH = 1179648u;

	internal const uint CERT_ENCIPHER_ONLY_KEY_USAGE = 1u;

	internal const uint CERT_CRL_SIGN_KEY_USAGE = 2u;

	internal const uint CERT_KEY_CERT_SIGN_KEY_USAGE = 4u;

	internal const uint CERT_KEY_AGREEMENT_KEY_USAGE = 8u;

	internal const uint CERT_DATA_ENCIPHERMENT_KEY_USAGE = 16u;

	internal const uint CERT_KEY_ENCIPHERMENT_KEY_USAGE = 32u;

	internal const uint CERT_NON_REPUDIATION_KEY_USAGE = 64u;

	internal const uint CERT_DIGITAL_SIGNATURE_KEY_USAGE = 128u;

	internal const uint CERT_DECIPHER_ONLY_KEY_USAGE = 32768u;

	internal const uint CERT_STORE_ADD_NEW = 1u;

	internal const uint CERT_STORE_ADD_USE_EXISTING = 2u;

	internal const uint CERT_STORE_ADD_REPLACE_EXISTING = 3u;

	internal const uint CERT_STORE_ADD_ALWAYS = 4u;

	internal const uint CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES = 5u;

	internal const uint CERT_STORE_ADD_NEWER = 6u;

	internal const uint CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES = 7u;

	internal const uint CRYPT_FORMAT_STR_MULTI_LINE = 1u;

	internal const uint CRYPT_FORMAT_STR_NO_HEX = 16u;

	internal const uint CERT_STORE_SAVE_AS_STORE = 1u;

	internal const uint CERT_STORE_SAVE_AS_PKCS7 = 2u;

	internal const uint CERT_STORE_SAVE_TO_FILE = 1u;

	internal const uint CERT_STORE_SAVE_TO_MEMORY = 2u;

	internal const uint CERT_STORE_SAVE_TO_FILENAME_A = 3u;

	internal const uint CERT_STORE_SAVE_TO_FILENAME_W = 4u;

	internal const uint CERT_STORE_SAVE_TO_FILENAME = 4u;

	internal const uint CERT_CA_SUBJECT_FLAG = 128u;

	internal const uint CERT_END_ENTITY_SUBJECT_FLAG = 64u;

	internal const uint REPORT_NO_PRIVATE_KEY = 1u;

	internal const uint REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY = 2u;

	internal const uint EXPORT_PRIVATE_KEYS = 4u;

	internal const uint PKCS12_EXPORT_RESERVED_MASK = 4294901760u;

	internal const uint RSA_CSP_PUBLICKEYBLOB = 19u;

	internal const uint X509_MULTI_BYTE_UINT = 38u;

	internal const uint X509_DSS_PUBLICKEY = 38u;

	internal const uint X509_DSS_PARAMETERS = 39u;

	internal const uint X509_DSS_SIGNATURE = 40u;

	internal const uint X509_EXTENSIONS = 5u;

	internal const uint X509_NAME_VALUE = 6u;

	internal const uint X509_NAME = 7u;

	internal const uint X509_AUTHORITY_KEY_ID = 9u;

	internal const uint X509_KEY_USAGE_RESTRICTION = 11u;

	internal const uint X509_BASIC_CONSTRAINTS = 13u;

	internal const uint X509_KEY_USAGE = 14u;

	internal const uint X509_BASIC_CONSTRAINTS2 = 15u;

	internal const uint X509_CERT_POLICIES = 16u;

	internal const uint PKCS_UTC_TIME = 17u;

	internal const uint PKCS_ATTRIBUTE = 22u;

	internal const uint X509_UNICODE_NAME_VALUE = 24u;

	internal const uint X509_OCTET_STRING = 25u;

	internal const uint X509_BITS = 26u;

	internal const uint X509_ANY_STRING = 6u;

	internal const uint X509_UNICODE_ANY_STRING = 24u;

	internal const uint X509_ENHANCED_KEY_USAGE = 36u;

	internal const uint PKCS_RC2_CBC_PARAMETERS = 41u;

	internal const uint X509_CERTIFICATE_TEMPLATE = 64u;

	internal const uint PKCS7_SIGNER_INFO = 500u;

	internal const uint CMS_SIGNER_INFO = 501u;

	internal const string szOID_COMMON_NAME = "2.5.4.3";

	internal const string szOID_AUTHORITY_KEY_IDENTIFIER = "2.5.29.1";

	internal const string szOID_KEY_USAGE_RESTRICTION = "2.5.29.4";

	internal const string szOID_SUBJECT_ALT_NAME = "2.5.29.7";

	internal const string szOID_ISSUER_ALT_NAME = "2.5.29.8";

	internal const string szOID_BASIC_CONSTRAINTS = "2.5.29.10";

	internal const string szOID_SUBJECT_KEY_IDENTIFIER = "2.5.29.14";

	internal const string szOID_KEY_USAGE = "2.5.29.15";

	internal const string szOID_SUBJECT_ALT_NAME2 = "2.5.29.17";

	internal const string szOID_ISSUER_ALT_NAME2 = "2.5.29.18";

	internal const string szOID_BASIC_CONSTRAINTS2 = "2.5.29.19";

	internal const string szOID_CRL_DIST_POINTS = "2.5.29.31";

	internal const string szOID_CERT_POLICIES = "2.5.29.32";

	internal const string szOID_ENHANCED_KEY_USAGE = "2.5.29.37";

	internal const string szOID_KEYID_RDN = "1.3.6.1.4.1.311.10.7.1";

	internal const string szOID_ENROLL_CERTTYPE_EXTENSION = "1.3.6.1.4.1.311.20.2";

	internal const string szOID_NT_PRINCIPAL_NAME = "1.3.6.1.4.1.311.20.2.3";

	internal const string szOID_CERTIFICATE_TEMPLATE = "1.3.6.1.4.1.311.21.7";

	internal const string szOID_RDN_DUMMY_SIGNER = "1.3.6.1.4.1.311.21.9";

	internal const string szOID_AUTHORITY_INFO_ACCESS = "1.3.6.1.5.5.7.1.1";

	internal const uint CERT_CHAIN_POLICY_BASE = 1u;

	internal const uint CERT_CHAIN_POLICY_AUTHENTICODE = 2u;

	internal const uint CERT_CHAIN_POLICY_AUTHENTICODE_TS = 3u;

	internal const uint CERT_CHAIN_POLICY_SSL = 4u;

	internal const uint CERT_CHAIN_POLICY_BASIC_CONSTRAINTS = 5u;

	internal const uint CERT_CHAIN_POLICY_NT_AUTH = 6u;

	internal const uint CERT_CHAIN_POLICY_MICROSOFT_ROOT = 7u;

	internal const uint USAGE_MATCH_TYPE_AND = 0u;

	internal const uint USAGE_MATCH_TYPE_OR = 1u;

	internal const uint CERT_CHAIN_REVOCATION_CHECK_END_CERT = 268435456u;

	internal const uint CERT_CHAIN_REVOCATION_CHECK_CHAIN = 536870912u;

	internal const uint CERT_CHAIN_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 1073741824u;

	internal const uint CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY = 2147483648u;

	internal const uint CERT_CHAIN_REVOCATION_ACCUMULATIVE_TIMEOUT = 134217728u;

	internal const uint CERT_TRUST_NO_ERROR = 0u;

	internal const uint CERT_TRUST_IS_NOT_TIME_VALID = 1u;

	internal const uint CERT_TRUST_IS_NOT_TIME_NESTED = 2u;

	internal const uint CERT_TRUST_IS_REVOKED = 4u;

	internal const uint CERT_TRUST_IS_NOT_SIGNATURE_VALID = 8u;

	internal const uint CERT_TRUST_IS_NOT_VALID_FOR_USAGE = 16u;

	internal const uint CERT_TRUST_IS_UNTRUSTED_ROOT = 32u;

	internal const uint CERT_TRUST_REVOCATION_STATUS_UNKNOWN = 64u;

	internal const uint CERT_TRUST_IS_CYCLIC = 128u;

	internal const uint CERT_TRUST_INVALID_EXTENSION = 256u;

	internal const uint CERT_TRUST_INVALID_POLICY_CONSTRAINTS = 512u;

	internal const uint CERT_TRUST_INVALID_BASIC_CONSTRAINTS = 1024u;

	internal const uint CERT_TRUST_INVALID_NAME_CONSTRAINTS = 2048u;

	internal const uint CERT_TRUST_HAS_NOT_SUPPORTED_NAME_CONSTRAINT = 4096u;

	internal const uint CERT_TRUST_HAS_NOT_DEFINED_NAME_CONSTRAINT = 8192u;

	internal const uint CERT_TRUST_HAS_NOT_PERMITTED_NAME_CONSTRAINT = 16384u;

	internal const uint CERT_TRUST_HAS_EXCLUDED_NAME_CONSTRAINT = 32768u;

	internal const uint CERT_TRUST_IS_OFFLINE_REVOCATION = 16777216u;

	internal const uint CERT_TRUST_NO_ISSUANCE_CHAIN_POLICY = 33554432u;

	internal const uint CERT_TRUST_IS_EXPLICIT_DISTRUST = 67108864u;

	internal const uint CERT_TRUST_HAS_NOT_SUPPORTED_CRITICAL_EXT = 134217728u;

	internal const uint CERT_TRUST_HAS_WEAK_SIGNATURE = 1048576u;

	internal const uint CERT_TRUST_IS_PARTIAL_CHAIN = 65536u;

	internal const uint CERT_TRUST_CTL_IS_NOT_TIME_VALID = 131072u;

	internal const uint CERT_TRUST_CTL_IS_NOT_SIGNATURE_VALID = 262144u;

	internal const uint CERT_TRUST_CTL_IS_NOT_VALID_FOR_USAGE = 524288u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG = 1u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG = 2u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG = 4u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG = 8u;

	internal const uint CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG = 16u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG = 32u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG = 64u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG = 128u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG = 256u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG = 512u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG = 1024u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG = 2048u;

	internal const uint CERT_CHAIN_POLICY_IGNORE_ALL_REV_UNKNOWN_FLAGS = 3840u;

	internal const uint CERT_TRUST_HAS_EXACT_MATCH_ISSUER = 1u;

	internal const uint CERT_TRUST_HAS_KEY_MATCH_ISSUER = 2u;

	internal const uint CERT_TRUST_HAS_NAME_MATCH_ISSUER = 4u;

	internal const uint CERT_TRUST_IS_SELF_SIGNED = 8u;

	internal const uint CERT_TRUST_HAS_PREFERRED_ISSUER = 256u;

	internal const uint CERT_TRUST_HAS_ISSUANCE_CHAIN_POLICY = 512u;

	internal const uint CERT_TRUST_HAS_VALID_NAME_CONSTRAINTS = 1024u;

	internal const uint CERT_TRUST_IS_COMPLEX_CHAIN = 65536u;

	internal const string szOID_PKIX_NO_SIGNATURE = "1.3.6.1.5.5.7.6.2";

	internal const string szOID_PKIX_KP_SERVER_AUTH = "1.3.6.1.5.5.7.3.1";

	internal const string szOID_PKIX_KP_CLIENT_AUTH = "1.3.6.1.5.5.7.3.2";

	internal const string szOID_PKIX_KP_CODE_SIGNING = "1.3.6.1.5.5.7.3.3";

	internal const string szOID_PKIX_KP_EMAIL_PROTECTION = "1.3.6.1.5.5.7.3.4";

	internal const string SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID = "1.3.6.1.4.1.311.2.1.21";

	internal const string SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID = "1.3.6.1.4.1.311.2.1.22";

	internal const uint HCCE_CURRENT_USER = 0u;

	internal const uint HCCE_LOCAL_MACHINE = 1u;

	internal const string szOID_PKCS_1 = "1.2.840.113549.1.1";

	internal const string szOID_PKCS_2 = "1.2.840.113549.1.2";

	internal const string szOID_PKCS_3 = "1.2.840.113549.1.3";

	internal const string szOID_PKCS_4 = "1.2.840.113549.1.4";

	internal const string szOID_PKCS_5 = "1.2.840.113549.1.5";

	internal const string szOID_PKCS_6 = "1.2.840.113549.1.6";

	internal const string szOID_PKCS_7 = "1.2.840.113549.1.7";

	internal const string szOID_PKCS_8 = "1.2.840.113549.1.8";

	internal const string szOID_PKCS_9 = "1.2.840.113549.1.9";

	internal const string szOID_PKCS_10 = "1.2.840.113549.1.10";

	internal const string szOID_PKCS_12 = "1.2.840.113549.1.12";

	internal const string szOID_RSA_data = "1.2.840.113549.1.7.1";

	internal const string szOID_RSA_signedData = "1.2.840.113549.1.7.2";

	internal const string szOID_RSA_envelopedData = "1.2.840.113549.1.7.3";

	internal const string szOID_RSA_signEnvData = "1.2.840.113549.1.7.4";

	internal const string szOID_RSA_digestedData = "1.2.840.113549.1.7.5";

	internal const string szOID_RSA_hashedData = "1.2.840.113549.1.7.5";

	internal const string szOID_RSA_encryptedData = "1.2.840.113549.1.7.6";

	internal const string szOID_RSA_emailAddr = "1.2.840.113549.1.9.1";

	internal const string szOID_RSA_unstructName = "1.2.840.113549.1.9.2";

	internal const string szOID_RSA_contentType = "1.2.840.113549.1.9.3";

	internal const string szOID_RSA_messageDigest = "1.2.840.113549.1.9.4";

	internal const string szOID_RSA_signingTime = "1.2.840.113549.1.9.5";

	internal const string szOID_RSA_counterSign = "1.2.840.113549.1.9.6";

	internal const string szOID_RSA_challengePwd = "1.2.840.113549.1.9.7";

	internal const string szOID_RSA_unstructAddr = "1.2.840.113549.1.9.8";

	internal const string szOID_RSA_extCertAttrs = "1.2.840.113549.1.9.9";

	internal const string szOID_RSA_SMIMECapabilities = "1.2.840.113549.1.9.15";

	internal const string szOID_CAPICOM = "1.3.6.1.4.1.311.88";

	internal const string szOID_CAPICOM_version = "1.3.6.1.4.1.311.88.1";

	internal const string szOID_CAPICOM_attribute = "1.3.6.1.4.1.311.88.2";

	internal const string szOID_CAPICOM_documentName = "1.3.6.1.4.1.311.88.2.1";

	internal const string szOID_CAPICOM_documentDescription = "1.3.6.1.4.1.311.88.2.2";

	internal const string szOID_CAPICOM_encryptedData = "1.3.6.1.4.1.311.88.3";

	internal const string szOID_CAPICOM_encryptedContent = "1.3.6.1.4.1.311.88.3.1";

	internal const string szOID_OIWSEC_sha1 = "1.3.14.3.2.26";

	internal const string szOID_RSA_MD5 = "1.2.840.113549.2.5";

	internal const string szOID_OIWSEC_SHA256 = "2.16.840.1.101.3.4.1";

	internal const string szOID_OIWSEC_SHA384 = "2.16.840.1.101.3.4.2";

	internal const string szOID_OIWSEC_SHA512 = "2.16.840.1.101.3.4.3";

	internal const string szOID_RSA_RC2CBC = "1.2.840.113549.3.2";

	internal const string szOID_RSA_RC4 = "1.2.840.113549.3.4";

	internal const string szOID_RSA_DES_EDE3_CBC = "1.2.840.113549.3.7";

	internal const string szOID_OIWSEC_desCBC = "1.3.14.3.2.7";

	internal const string szOID_RSA_SMIMEalg = "1.2.840.113549.1.9.16.3";

	internal const string szOID_RSA_SMIMEalgESDH = "1.2.840.113549.1.9.16.3.5";

	internal const string szOID_RSA_SMIMEalgCMS3DESwrap = "1.2.840.113549.1.9.16.3.6";

	internal const string szOID_RSA_SMIMEalgCMSRC2wrap = "1.2.840.113549.1.9.16.3.7";

	internal const string szOID_X957_DSA = "1.2.840.10040.4.1";

	internal const string szOID_X957_sha1DSA = "1.2.840.10040.4.3";

	internal const string szOID_OIWSEC_sha1RSASign = "1.3.14.3.2.29";

	internal const uint CERT_ALT_NAME_OTHER_NAME = 1u;

	internal const uint CERT_ALT_NAME_RFC822_NAME = 2u;

	internal const uint CERT_ALT_NAME_DNS_NAME = 3u;

	internal const uint CERT_ALT_NAME_X400_ADDRESS = 4u;

	internal const uint CERT_ALT_NAME_DIRECTORY_NAME = 5u;

	internal const uint CERT_ALT_NAME_EDI_PARTY_NAME = 6u;

	internal const uint CERT_ALT_NAME_URL = 7u;

	internal const uint CERT_ALT_NAME_IP_ADDRESS = 8u;

	internal const uint CERT_ALT_NAME_REGISTERED_ID = 9u;

	internal const uint CERT_RDN_ANY_TYPE = 0u;

	internal const uint CERT_RDN_ENCODED_BLOB = 1u;

	internal const uint CERT_RDN_OCTET_STRING = 2u;

	internal const uint CERT_RDN_NUMERIC_STRING = 3u;

	internal const uint CERT_RDN_PRINTABLE_STRING = 4u;

	internal const uint CERT_RDN_TELETEX_STRING = 5u;

	internal const uint CERT_RDN_T61_STRING = 5u;

	internal const uint CERT_RDN_VIDEOTEX_STRING = 6u;

	internal const uint CERT_RDN_IA5_STRING = 7u;

	internal const uint CERT_RDN_GRAPHIC_STRING = 8u;

	internal const uint CERT_RDN_VISIBLE_STRING = 9u;

	internal const uint CERT_RDN_ISO646_STRING = 9u;

	internal const uint CERT_RDN_GENERAL_STRING = 10u;

	internal const uint CERT_RDN_UNIVERSAL_STRING = 11u;

	internal const uint CERT_RDN_INT4_STRING = 11u;

	internal const uint CERT_RDN_BMP_STRING = 12u;

	internal const uint CERT_RDN_UNICODE_STRING = 12u;

	internal const uint CERT_RDN_UTF8_STRING = 13u;

	internal const uint CERT_RDN_TYPE_MASK = 255u;

	internal const uint CERT_RDN_FLAGS_MASK = 4278190080u;

	internal const uint CERT_STORE_CTRL_RESYNC = 1u;

	internal const uint CERT_STORE_CTRL_NOTIFY_CHANGE = 2u;

	internal const uint CERT_STORE_CTRL_COMMIT = 3u;

	internal const uint CERT_STORE_CTRL_AUTO_RESYNC = 4u;

	internal const uint CERT_STORE_CTRL_CANCEL_NOTIFY = 5u;

	internal const uint CERT_ID_ISSUER_SERIAL_NUMBER = 1u;

	internal const uint CERT_ID_KEY_IDENTIFIER = 2u;

	internal const uint CERT_ID_SHA1_HASH = 3u;

	internal const string MS_ENHANCED_PROV = "Microsoft Enhanced Cryptographic Provider v1.0";

	internal const string MS_STRONG_PROV = "Microsoft Strong Cryptographic Provider";

	internal const string MS_DEF_PROV = "Microsoft Base Cryptographic Provider v1.0";

	internal const string MS_DEF_DSS_DH_PROV = "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

	internal const string MS_ENH_DSS_DH_PROV = "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

	internal const string DummySignerCommonName = "CN=Dummy Signer";

	internal const uint PROV_RSA_FULL = 1u;

	internal const uint PROV_DSS_DH = 13u;

	internal const uint ALG_TYPE_ANY = 0u;

	internal const uint ALG_TYPE_DSS = 512u;

	internal const uint ALG_TYPE_RSA = 1024u;

	internal const uint ALG_TYPE_BLOCK = 1536u;

	internal const uint ALG_TYPE_STREAM = 2048u;

	internal const uint ALG_TYPE_DH = 2560u;

	internal const uint ALG_TYPE_SECURECHANNEL = 3072u;

	internal const uint ALG_CLASS_ANY = 0u;

	internal const uint ALG_CLASS_SIGNATURE = 8192u;

	internal const uint ALG_CLASS_MSG_ENCRYPT = 16384u;

	internal const uint ALG_CLASS_DATA_ENCRYPT = 24576u;

	internal const uint ALG_CLASS_HASH = 32768u;

	internal const uint ALG_CLASS_KEY_EXCHANGE = 40960u;

	internal const uint ALG_CLASS_ALL = 57344u;

	internal const uint ALG_SID_ANY = 0u;

	internal const uint ALG_SID_RSA_ANY = 0u;

	internal const uint ALG_SID_RSA_PKCS = 1u;

	internal const uint ALG_SID_RSA_MSATWORK = 2u;

	internal const uint ALG_SID_RSA_ENTRUST = 3u;

	internal const uint ALG_SID_RSA_PGP = 4u;

	internal const uint ALG_SID_DSS_ANY = 0u;

	internal const uint ALG_SID_DSS_PKCS = 1u;

	internal const uint ALG_SID_DSS_DMS = 2u;

	internal const uint ALG_SID_DES = 1u;

	internal const uint ALG_SID_3DES = 3u;

	internal const uint ALG_SID_DESX = 4u;

	internal const uint ALG_SID_IDEA = 5u;

	internal const uint ALG_SID_CAST = 6u;

	internal const uint ALG_SID_SAFERSK64 = 7u;

	internal const uint ALG_SID_SAFERSK128 = 8u;

	internal const uint ALG_SID_3DES_112 = 9u;

	internal const uint ALG_SID_CYLINK_MEK = 12u;

	internal const uint ALG_SID_RC5 = 13u;

	internal const uint ALG_SID_AES_128 = 14u;

	internal const uint ALG_SID_AES_192 = 15u;

	internal const uint ALG_SID_AES_256 = 16u;

	internal const uint ALG_SID_AES = 17u;

	internal const uint ALG_SID_SKIPJACK = 10u;

	internal const uint ALG_SID_TEK = 11u;

	internal const uint ALG_SID_RC2 = 2u;

	internal const uint ALG_SID_RC4 = 1u;

	internal const uint ALG_SID_SEAL = 2u;

	internal const uint ALG_SID_DH_SANDF = 1u;

	internal const uint ALG_SID_DH_EPHEM = 2u;

	internal const uint ALG_SID_AGREED_KEY_ANY = 3u;

	internal const uint ALG_SID_KEA = 4u;

	internal const uint ALG_SID_MD2 = 1u;

	internal const uint ALG_SID_MD4 = 2u;

	internal const uint ALG_SID_MD5 = 3u;

	internal const uint ALG_SID_SHA = 4u;

	internal const uint ALG_SID_SHA1 = 4u;

	internal const uint ALG_SID_MAC = 5u;

	internal const uint ALG_SID_RIPEMD = 6u;

	internal const uint ALG_SID_RIPEMD160 = 7u;

	internal const uint ALG_SID_SSL3SHAMD5 = 8u;

	internal const uint ALG_SID_HMAC = 9u;

	internal const uint ALG_SID_TLS1PRF = 10u;

	internal const uint ALG_SID_HASH_REPLACE_OWF = 11u;

	internal const uint ALG_SID_SSL3_MASTER = 1u;

	internal const uint ALG_SID_SCHANNEL_MASTER_HASH = 2u;

	internal const uint ALG_SID_SCHANNEL_MAC_KEY = 3u;

	internal const uint ALG_SID_PCT1_MASTER = 4u;

	internal const uint ALG_SID_SSL2_MASTER = 5u;

	internal const uint ALG_SID_TLS1_MASTER = 6u;

	internal const uint ALG_SID_SCHANNEL_ENC_KEY = 7u;

	internal const uint CALG_MD2 = 32769u;

	internal const uint CALG_MD4 = 32770u;

	internal const uint CALG_MD5 = 32771u;

	internal const uint CALG_SHA = 32772u;

	internal const uint CALG_SHA1 = 32772u;

	internal const uint CALG_MAC = 32773u;

	internal const uint CALG_RSA_SIGN = 9216u;

	internal const uint CALG_DSS_SIGN = 8704u;

	internal const uint CALG_NO_SIGN = 8192u;

	internal const uint CALG_RSA_KEYX = 41984u;

	internal const uint CALG_DES = 26113u;

	internal const uint CALG_3DES_112 = 26121u;

	internal const uint CALG_3DES = 26115u;

	internal const uint CALG_DESX = 26116u;

	internal const uint CALG_RC2 = 26114u;

	internal const uint CALG_RC4 = 26625u;

	internal const uint CALG_SEAL = 26626u;

	internal const uint CALG_DH_SF = 43521u;

	internal const uint CALG_DH_EPHEM = 43522u;

	internal const uint CALG_AGREEDKEY_ANY = 43523u;

	internal const uint CALG_KEA_KEYX = 43524u;

	internal const uint CALG_HUGHES_MD5 = 40963u;

	internal const uint CALG_SKIPJACK = 26122u;

	internal const uint CALG_TEK = 26123u;

	internal const uint CALG_CYLINK_MEK = 26124u;

	internal const uint CALG_SSL3_SHAMD5 = 32776u;

	internal const uint CALG_SSL3_MASTER = 19457u;

	internal const uint CALG_SCHANNEL_MASTER_HASH = 19458u;

	internal const uint CALG_SCHANNEL_MAC_KEY = 19459u;

	internal const uint CALG_SCHANNEL_ENC_KEY = 19463u;

	internal const uint CALG_PCT1_MASTER = 19460u;

	internal const uint CALG_SSL2_MASTER = 19461u;

	internal const uint CALG_TLS1_MASTER = 19462u;

	internal const uint CALG_RC5 = 26125u;

	internal const uint CALG_HMAC = 32777u;

	internal const uint CALG_TLS1PRF = 32778u;

	internal const uint CALG_HASH_REPLACE_OWF = 32779u;

	internal const uint CALG_AES_128 = 26126u;

	internal const uint CALG_AES_192 = 26127u;

	internal const uint CALG_AES_256 = 26128u;

	internal const uint CALG_AES = 26129u;

	internal const uint CRYPT_FIRST = 1u;

	internal const uint CRYPT_NEXT = 2u;

	internal const uint PP_ENUMALGS_EX = 22u;

	internal const uint CRYPT_VERIFYCONTEXT = 4026531840u;

	internal const uint CRYPT_NEWKEYSET = 8u;

	internal const uint CRYPT_DELETEKEYSET = 16u;

	internal const uint CRYPT_MACHINE_KEYSET = 32u;

	internal const uint CRYPT_SILENT = 64u;

	internal const uint CRYPT_USER_KEYSET = 4096u;

	internal const uint PKCS12_ALWAYS_CNG_KSP = 512u;

	internal const uint PKCS12_NO_PERSIST_KEY = 32768u;

	internal const uint CRYPT_EXPORTABLE = 1u;

	internal const uint CRYPT_USER_PROTECTED = 2u;

	internal const uint CRYPT_CREATE_SALT = 4u;

	internal const uint CRYPT_UPDATE_KEY = 8u;

	internal const uint CRYPT_NO_SALT = 16u;

	internal const uint CRYPT_PREGEN = 64u;

	internal const uint CRYPT_RECIPIENT = 16u;

	internal const uint CRYPT_INITIATOR = 64u;

	internal const uint CRYPT_ONLINE = 128u;

	internal const uint CRYPT_SF = 256u;

	internal const uint CRYPT_CREATE_IV = 512u;

	internal const uint CRYPT_KEK = 1024u;

	internal const uint CRYPT_DATA_KEY = 2048u;

	internal const uint CRYPT_VOLATILE = 4096u;

	internal const uint CRYPT_SGCKEY = 8192u;

	internal const uint CRYPT_ARCHIVABLE = 16384u;

	internal const byte CUR_BLOB_VERSION = 2;

	internal const byte SIMPLEBLOB = 1;

	internal const byte PUBLICKEYBLOB = 6;

	internal const byte PRIVATEKEYBLOB = 7;

	internal const byte PLAINTEXTKEYBLOB = 8;

	internal const byte OPAQUEKEYBLOB = 9;

	internal const byte PUBLICKEYBLOBEX = 10;

	internal const byte SYMMETRICWRAPKEYBLOB = 11;

	internal const uint DSS_MAGIC = 827544388u;

	internal const uint DSS_PRIVATE_MAGIC = 844321604u;

	internal const uint DSS_PUB_MAGIC_VER3 = 861098820u;

	internal const uint DSS_PRIV_MAGIC_VER3 = 877876036u;

	internal const uint RSA_PUB_MAGIC = 826364754u;

	internal const uint RSA_PRIV_MAGIC = 843141970u;

	internal const uint CRYPT_ACQUIRE_CACHE_FLAG = 1u;

	internal const uint CRYPT_ACQUIRE_USE_PROV_INFO_FLAG = 2u;

	internal const uint CRYPT_ACQUIRE_COMPARE_KEY_FLAG = 4u;

	internal const uint CRYPT_ACQUIRE_SILENT_FLAG = 64u;

	internal const uint CMSG_BARE_CONTENT_FLAG = 1u;

	internal const uint CMSG_LENGTH_ONLY_FLAG = 2u;

	internal const uint CMSG_DETACHED_FLAG = 4u;

	internal const uint CMSG_AUTHENTICATED_ATTRIBUTES_FLAG = 8u;

	internal const uint CMSG_CONTENTS_OCTETS_FLAG = 16u;

	internal const uint CMSG_MAX_LENGTH_FLAG = 32u;

	internal const uint CMSG_TYPE_PARAM = 1u;

	internal const uint CMSG_CONTENT_PARAM = 2u;

	internal const uint CMSG_BARE_CONTENT_PARAM = 3u;

	internal const uint CMSG_INNER_CONTENT_TYPE_PARAM = 4u;

	internal const uint CMSG_SIGNER_COUNT_PARAM = 5u;

	internal const uint CMSG_SIGNER_INFO_PARAM = 6u;

	internal const uint CMSG_SIGNER_CERT_INFO_PARAM = 7u;

	internal const uint CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8u;

	internal const uint CMSG_SIGNER_AUTH_ATTR_PARAM = 9u;

	internal const uint CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10u;

	internal const uint CMSG_CERT_COUNT_PARAM = 11u;

	internal const uint CMSG_CERT_PARAM = 12u;

	internal const uint CMSG_CRL_COUNT_PARAM = 13u;

	internal const uint CMSG_CRL_PARAM = 14u;

	internal const uint CMSG_ENVELOPE_ALGORITHM_PARAM = 15u;

	internal const uint CMSG_RECIPIENT_COUNT_PARAM = 17u;

	internal const uint CMSG_RECIPIENT_INDEX_PARAM = 18u;

	internal const uint CMSG_RECIPIENT_INFO_PARAM = 19u;

	internal const uint CMSG_HASH_ALGORITHM_PARAM = 20u;

	internal const uint CMSG_HASH_DATA_PARAM = 21u;

	internal const uint CMSG_COMPUTED_HASH_PARAM = 22u;

	internal const uint CMSG_ENCRYPT_PARAM = 26u;

	internal const uint CMSG_ENCRYPTED_DIGEST = 27u;

	internal const uint CMSG_ENCODED_SIGNER = 28u;

	internal const uint CMSG_ENCODED_MESSAGE = 29u;

	internal const uint CMSG_VERSION_PARAM = 30u;

	internal const uint CMSG_ATTR_CERT_COUNT_PARAM = 31u;

	internal const uint CMSG_ATTR_CERT_PARAM = 32u;

	internal const uint CMSG_CMS_RECIPIENT_COUNT_PARAM = 33u;

	internal const uint CMSG_CMS_RECIPIENT_INDEX_PARAM = 34u;

	internal const uint CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35u;

	internal const uint CMSG_CMS_RECIPIENT_INFO_PARAM = 36u;

	internal const uint CMSG_UNPROTECTED_ATTR_PARAM = 37u;

	internal const uint CMSG_SIGNER_CERT_ID_PARAM = 38u;

	internal const uint CMSG_CMS_SIGNER_INFO_PARAM = 39u;

	internal const uint CMSG_CTRL_VERIFY_SIGNATURE = 1u;

	internal const uint CMSG_CTRL_DECRYPT = 2u;

	internal const uint CMSG_CTRL_VERIFY_HASH = 5u;

	internal const uint CMSG_CTRL_ADD_SIGNER = 6u;

	internal const uint CMSG_CTRL_DEL_SIGNER = 7u;

	internal const uint CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR = 8u;

	internal const uint CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR = 9u;

	internal const uint CMSG_CTRL_ADD_CERT = 10u;

	internal const uint CMSG_CTRL_DEL_CERT = 11u;

	internal const uint CMSG_CTRL_ADD_CRL = 12u;

	internal const uint CMSG_CTRL_DEL_CRL = 13u;

	internal const uint CMSG_CTRL_ADD_ATTR_CERT = 14u;

	internal const uint CMSG_CTRL_DEL_ATTR_CERT = 15u;

	internal const uint CMSG_CTRL_KEY_TRANS_DECRYPT = 16u;

	internal const uint CMSG_CTRL_KEY_AGREE_DECRYPT = 17u;

	internal const uint CMSG_CTRL_MAIL_LIST_DECRYPT = 18u;

	internal const uint CMSG_CTRL_VERIFY_SIGNATURE_EX = 19u;

	internal const uint CMSG_CTRL_ADD_CMS_SIGNER_INFO = 20u;

	internal const uint CMSG_VERIFY_SIGNER_PUBKEY = 1u;

	internal const uint CMSG_VERIFY_SIGNER_CERT = 2u;

	internal const uint CMSG_VERIFY_SIGNER_CHAIN = 3u;

	internal const uint CMSG_VERIFY_SIGNER_NULL = 4u;

	internal const uint CMSG_DATA = 1u;

	internal const uint CMSG_SIGNED = 2u;

	internal const uint CMSG_ENVELOPED = 3u;

	internal const uint CMSG_SIGNED_AND_ENVELOPED = 4u;

	internal const uint CMSG_HASHED = 5u;

	internal const uint CMSG_ENCRYPTED = 6u;

	internal const uint CMSG_KEY_TRANS_RECIPIENT = 1u;

	internal const uint CMSG_KEY_AGREE_RECIPIENT = 2u;

	internal const uint CMSG_MAIL_LIST_RECIPIENT = 3u;

	internal const uint CMSG_KEY_AGREE_ORIGINATOR_CERT = 1u;

	internal const uint CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY = 2u;

	internal const uint CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE = 1u;

	internal const uint CMSG_KEY_AGREE_STATIC_KEY_CHOICE = 2u;

	internal const uint CMSG_ENVELOPED_RECIPIENT_V0 = 0u;

	internal const uint CMSG_ENVELOPED_RECIPIENT_V2 = 2u;

	internal const uint CMSG_ENVELOPED_RECIPIENT_V3 = 3u;

	internal const uint CMSG_ENVELOPED_RECIPIENT_V4 = 4u;

	internal const uint CMSG_KEY_TRANS_PKCS_1_5_VERSION = 0u;

	internal const uint CMSG_KEY_TRANS_CMS_VERSION = 2u;

	internal const uint CMSG_KEY_AGREE_VERSION = 3u;

	internal const uint CMSG_MAIL_LIST_VERSION = 4u;

	internal const uint CRYPT_RC2_40BIT_VERSION = 160u;

	internal const uint CRYPT_RC2_56BIT_VERSION = 52u;

	internal const uint CRYPT_RC2_64BIT_VERSION = 120u;

	internal const uint CRYPT_RC2_128BIT_VERSION = 58u;

	internal const int E_NOTIMPL = -2147483647;

	internal const int E_OUTOFMEMORY = -2147024882;

	internal const int NTE_NO_KEY = -2146893811;

	internal const int NTE_BAD_PUBLIC_KEY = -2146893803;

	internal const int NTE_BAD_KEYSET = -2146893802;

	internal const int CRYPT_E_MSG_ERROR = -2146889727;

	internal const int CRYPT_E_UNKNOWN_ALGO = -2146889726;

	internal const int CRYPT_E_INVALID_MSG_TYPE = -2146889724;

	internal const int CRYPT_E_RECIPIENT_NOT_FOUND = -2146889717;

	internal const int CRYPT_E_ISSUER_SERIALNUMBER = -2146889715;

	internal const int CRYPT_E_SIGNER_NOT_FOUND = -2146889714;

	internal const int CRYPT_E_ATTRIBUTES_MISSING = -2146889713;

	internal const int CRYPT_E_BAD_ENCODE = -2146885630;

	internal const int CRYPT_E_NOT_FOUND = -2146885628;

	internal const int CRYPT_E_NO_MATCH = -2146885623;

	internal const int CRYPT_E_NO_SIGNER = -2146885618;

	internal const int CRYPT_E_REVOKED = -2146885616;

	internal const int CRYPT_E_NO_REVOCATION_CHECK = -2146885614;

	internal const int CRYPT_E_REVOCATION_OFFLINE = -2146885613;

	internal const int CRYPT_E_ASN1_BADTAG = -2146881269;

	internal const int CERTSRV_E_WEAK_SIGNATURE_OR_KEY = -2146877418;

	internal const int TRUST_E_CERT_SIGNATURE = -2146869244;

	internal const int TRUST_E_BASIC_CONSTRAINTS = -2146869223;

	internal const int CERT_E_EXPIRED = -2146762495;

	internal const int CERT_E_VALIDITYPERIODNESTING = -2146762494;

	internal const int CERT_E_CRITICAL = -2146762491;

	internal const int CERT_E_UNTRUSTEDROOT = -2146762487;

	internal const int CERT_E_CHAINING = -2146762486;

	internal const int TRUST_E_FAIL = -2146762485;

	internal const int CERT_E_REVOKED = -2146762484;

	internal const int CERT_E_UNTRUSTEDTESTROOT = -2146762483;

	internal const int CERT_E_REVOCATION_FAILURE = -2146762482;

	internal const int CERT_E_WRONG_USAGE = -2146762480;

	internal const int TRUST_E_EXPLICIT_DISTRUST = -2146762479;

	internal const int CERT_E_INVALID_POLICY = -2146762477;

	internal const int CERT_E_INVALID_NAME = -2146762476;

	internal const int ERROR_SUCCESS = 0;

	internal const int ERROR_CALL_NOT_IMPLEMENTED = 120;

	internal const int ERROR_CANCELLED = 1223;
}
