using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Util;
using System.Threading;
using Microsoft.Win32;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class CryptoConfig
{
	private static volatile Dictionary<string, string> defaultOidHT = null;

	private static volatile Dictionary<string, object> defaultNameHT = null;

	private static volatile Dictionary<string, string> machineOidHT = null;

	private static volatile Dictionary<string, string> machineNameHT = null;

	private static volatile Dictionary<string, Type> appNameHT = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

	private static volatile Dictionary<string, string> appOidHT = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	private const string MachineConfigFilename = "machine.config";

	private static volatile string version = null;

	private static volatile bool s_fipsAlgorithmPolicy;

	private static volatile bool s_haveFipsAlgorithmPolicy;

	private static object s_InternalSyncObject;

	public static bool AllowOnlyFipsAlgorithms
	{
		[SecuritySafeCritical]
		get
		{
			if (!s_haveFipsAlgorithmPolicy)
			{
				if (Utils._GetEnforceFipsPolicySetting())
				{
					if (Environment.OSVersion.Version.Major >= 6)
					{
						bool pfEnabled;
						uint num = Win32Native.BCryptGetFipsAlgorithmMode(out pfEnabled);
						bool flag = num == 0 || num == 3221225524u;
						s_fipsAlgorithmPolicy = !flag || pfEnabled;
						s_haveFipsAlgorithmPolicy = true;
					}
					else
					{
						s_fipsAlgorithmPolicy = Utils.ReadLegacyFipsPolicy();
						s_haveFipsAlgorithmPolicy = true;
					}
				}
				else
				{
					s_fipsAlgorithmPolicy = false;
					s_haveFipsAlgorithmPolicy = true;
				}
			}
			return s_fipsAlgorithmPolicy;
		}
	}

	private static string Version
	{
		[SecurityCritical]
		get
		{
			if (version == null)
			{
				version = ((RuntimeType)typeof(CryptoConfig)).GetRuntimeAssembly().GetVersion().ToString();
			}
			return version;
		}
	}

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	private static Dictionary<string, string> DefaultOidHT
	{
		get
		{
			if (defaultOidHT == null)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
				dictionary.Add("SHA", "1.3.14.3.2.26");
				dictionary.Add("SHA1", "1.3.14.3.2.26");
				dictionary.Add("System.Security.Cryptography.SHA1", "1.3.14.3.2.26");
				dictionary.Add("System.Security.Cryptography.SHA1CryptoServiceProvider", "1.3.14.3.2.26");
				dictionary.Add("System.Security.Cryptography.SHA1Cng", "1.3.14.3.2.26");
				dictionary.Add("System.Security.Cryptography.SHA1Managed", "1.3.14.3.2.26");
				dictionary.Add("SHA256", "2.16.840.1.101.3.4.2.1");
				dictionary.Add("System.Security.Cryptography.SHA256", "2.16.840.1.101.3.4.2.1");
				dictionary.Add("System.Security.Cryptography.SHA256CryptoServiceProvider", "2.16.840.1.101.3.4.2.1");
				dictionary.Add("System.Security.Cryptography.SHA256Cng", "2.16.840.1.101.3.4.2.1");
				dictionary.Add("System.Security.Cryptography.SHA256Managed", "2.16.840.1.101.3.4.2.1");
				dictionary.Add("SHA384", "2.16.840.1.101.3.4.2.2");
				dictionary.Add("System.Security.Cryptography.SHA384", "2.16.840.1.101.3.4.2.2");
				dictionary.Add("System.Security.Cryptography.SHA384CryptoServiceProvider", "2.16.840.1.101.3.4.2.2");
				dictionary.Add("System.Security.Cryptography.SHA384Cng", "2.16.840.1.101.3.4.2.2");
				dictionary.Add("System.Security.Cryptography.SHA384Managed", "2.16.840.1.101.3.4.2.2");
				dictionary.Add("SHA512", "2.16.840.1.101.3.4.2.3");
				dictionary.Add("System.Security.Cryptography.SHA512", "2.16.840.1.101.3.4.2.3");
				dictionary.Add("System.Security.Cryptography.SHA512CryptoServiceProvider", "2.16.840.1.101.3.4.2.3");
				dictionary.Add("System.Security.Cryptography.SHA512Cng", "2.16.840.1.101.3.4.2.3");
				dictionary.Add("System.Security.Cryptography.SHA512Managed", "2.16.840.1.101.3.4.2.3");
				dictionary.Add("RIPEMD160", "1.3.36.3.2.1");
				dictionary.Add("System.Security.Cryptography.RIPEMD160", "1.3.36.3.2.1");
				dictionary.Add("System.Security.Cryptography.RIPEMD160Managed", "1.3.36.3.2.1");
				dictionary.Add("MD5", "1.2.840.113549.2.5");
				dictionary.Add("System.Security.Cryptography.MD5", "1.2.840.113549.2.5");
				dictionary.Add("System.Security.Cryptography.MD5CryptoServiceProvider", "1.2.840.113549.2.5");
				dictionary.Add("System.Security.Cryptography.MD5Managed", "1.2.840.113549.2.5");
				dictionary.Add("TripleDESKeyWrap", "1.2.840.113549.1.9.16.3.6");
				dictionary.Add("RC2", "1.2.840.113549.3.2");
				dictionary.Add("System.Security.Cryptography.RC2CryptoServiceProvider", "1.2.840.113549.3.2");
				dictionary.Add("DES", "1.3.14.3.2.7");
				dictionary.Add("System.Security.Cryptography.DESCryptoServiceProvider", "1.3.14.3.2.7");
				dictionary.Add("TripleDES", "1.2.840.113549.3.7");
				dictionary.Add("System.Security.Cryptography.TripleDESCryptoServiceProvider", "1.2.840.113549.3.7");
				defaultOidHT = dictionary;
			}
			return defaultOidHT;
		}
	}

	private static Dictionary<string, object> DefaultNameHT
	{
		get
		{
			if (defaultNameHT == null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
				Type typeFromHandle = typeof(SHA1CryptoServiceProvider);
				Type typeFromHandle2 = typeof(MD5CryptoServiceProvider);
				Type typeFromHandle3 = typeof(RIPEMD160Managed);
				Type typeFromHandle4 = typeof(HMACMD5);
				Type typeFromHandle5 = typeof(HMACRIPEMD160);
				Type typeFromHandle6 = typeof(HMACSHA1);
				Type typeFromHandle7 = typeof(HMACSHA256);
				Type typeFromHandle8 = typeof(HMACSHA384);
				Type typeFromHandle9 = typeof(HMACSHA512);
				Type typeFromHandle10 = typeof(MACTripleDES);
				Type typeFromHandle11 = typeof(RSACryptoServiceProvider);
				Type typeFromHandle12 = typeof(DSACryptoServiceProvider);
				Type typeFromHandle13 = typeof(DESCryptoServiceProvider);
				Type typeFromHandle14 = typeof(TripleDESCryptoServiceProvider);
				Type typeFromHandle15 = typeof(RC2CryptoServiceProvider);
				Type typeFromHandle16 = typeof(RijndaelManaged);
				Type typeFromHandle17 = typeof(DSASignatureDescription);
				Type typeFromHandle18 = typeof(RSAPKCS1SHA1SignatureDescription);
				Type typeFromHandle19 = typeof(RSAPKCS1SHA256SignatureDescription);
				Type typeFromHandle20 = typeof(RSAPKCS1SHA384SignatureDescription);
				Type typeFromHandle21 = typeof(RSAPKCS1SHA512SignatureDescription);
				Type typeFromHandle22 = typeof(RNGCryptoServiceProvider);
				string value = "System.Security.Cryptography.AesCryptoServiceProvider, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value2 = "System.Security.Cryptography.RSACng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value3 = "System.Security.Cryptography.DSACng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value4 = "System.Security.Cryptography.AesManaged, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value5 = "System.Security.Cryptography.ECDiffieHellmanCng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value6 = "System.Security.Cryptography.ECDsaCng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value7 = "System.Security.Cryptography.MD5Cng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value8 = "System.Security.Cryptography.SHA1Cng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string text = "System.Security.Cryptography.SHA256Cng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value9 = "System.Security.Cryptography.SHA256CryptoServiceProvider, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string text2 = "System.Security.Cryptography.SHA384Cng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value10 = "System.Security.Cryptography.SHA384CryptoServiceProvider, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string text3 = "System.Security.Cryptography.SHA512Cng, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				string value11 = "System.Security.Cryptography.SHA512CryptoServiceProvider, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
				bool allowOnlyFipsAlgorithms = AllowOnlyFipsAlgorithms;
				object value12 = typeof(SHA256Managed);
				if (allowOnlyFipsAlgorithms)
				{
					value12 = text;
				}
				object value13 = (allowOnlyFipsAlgorithms ? ((object)text2) : ((object)typeof(SHA384Managed)));
				object value14 = (allowOnlyFipsAlgorithms ? ((object)text3) : ((object)typeof(SHA512Managed)));
				string value15 = "System.Security.Cryptography.DpapiDataProtector, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
				dictionary.Add("RandomNumberGenerator", typeFromHandle22);
				dictionary.Add("System.Security.Cryptography.RandomNumberGenerator", typeFromHandle22);
				dictionary.Add("SHA", typeFromHandle);
				dictionary.Add("SHA1", typeFromHandle);
				dictionary.Add("System.Security.Cryptography.SHA1", typeFromHandle);
				dictionary.Add("System.Security.Cryptography.SHA1Cng", value8);
				dictionary.Add("System.Security.Cryptography.HashAlgorithm", typeFromHandle);
				dictionary.Add("MD5", typeFromHandle2);
				dictionary.Add("System.Security.Cryptography.MD5", typeFromHandle2);
				dictionary.Add("System.Security.Cryptography.MD5Cng", value7);
				dictionary.Add("SHA256", value12);
				dictionary.Add("SHA-256", value12);
				dictionary.Add("System.Security.Cryptography.SHA256", value12);
				dictionary.Add("System.Security.Cryptography.SHA256Cng", text);
				dictionary.Add("System.Security.Cryptography.SHA256CryptoServiceProvider", value9);
				dictionary.Add("SHA384", value13);
				dictionary.Add("SHA-384", value13);
				dictionary.Add("System.Security.Cryptography.SHA384", value13);
				dictionary.Add("System.Security.Cryptography.SHA384Cng", text2);
				dictionary.Add("System.Security.Cryptography.SHA384CryptoServiceProvider", value10);
				dictionary.Add("SHA512", value14);
				dictionary.Add("SHA-512", value14);
				dictionary.Add("System.Security.Cryptography.SHA512", value14);
				dictionary.Add("System.Security.Cryptography.SHA512Cng", text3);
				dictionary.Add("System.Security.Cryptography.SHA512CryptoServiceProvider", value11);
				dictionary.Add("RIPEMD160", typeFromHandle3);
				dictionary.Add("RIPEMD-160", typeFromHandle3);
				dictionary.Add("System.Security.Cryptography.RIPEMD160", typeFromHandle3);
				dictionary.Add("System.Security.Cryptography.RIPEMD160Managed", typeFromHandle3);
				dictionary.Add("System.Security.Cryptography.HMAC", typeFromHandle6);
				dictionary.Add("System.Security.Cryptography.KeyedHashAlgorithm", typeFromHandle6);
				dictionary.Add("HMACMD5", typeFromHandle4);
				dictionary.Add("System.Security.Cryptography.HMACMD5", typeFromHandle4);
				dictionary.Add("HMACRIPEMD160", typeFromHandle5);
				dictionary.Add("System.Security.Cryptography.HMACRIPEMD160", typeFromHandle5);
				dictionary.Add("HMACSHA1", typeFromHandle6);
				dictionary.Add("System.Security.Cryptography.HMACSHA1", typeFromHandle6);
				dictionary.Add("HMACSHA256", typeFromHandle7);
				dictionary.Add("System.Security.Cryptography.HMACSHA256", typeFromHandle7);
				dictionary.Add("HMACSHA384", typeFromHandle8);
				dictionary.Add("System.Security.Cryptography.HMACSHA384", typeFromHandle8);
				dictionary.Add("HMACSHA512", typeFromHandle9);
				dictionary.Add("System.Security.Cryptography.HMACSHA512", typeFromHandle9);
				dictionary.Add("MACTripleDES", typeFromHandle10);
				dictionary.Add("System.Security.Cryptography.MACTripleDES", typeFromHandle10);
				dictionary.Add("RSA", typeFromHandle11);
				dictionary.Add("System.Security.Cryptography.RSA", typeFromHandle11);
				dictionary.Add("System.Security.Cryptography.AsymmetricAlgorithm", typeFromHandle11);
				dictionary.Add("RSAPSS", value2);
				dictionary.Add("DSA-FIPS186-3", value3);
				dictionary.Add("DSA", typeFromHandle12);
				dictionary.Add("System.Security.Cryptography.DSA", typeFromHandle12);
				dictionary.Add("ECDsa", value6);
				dictionary.Add("ECDsaCng", value6);
				dictionary.Add("System.Security.Cryptography.ECDsaCng", value6);
				dictionary.Add("ECDH", value5);
				dictionary.Add("ECDiffieHellman", value5);
				dictionary.Add("ECDiffieHellmanCng", value5);
				dictionary.Add("System.Security.Cryptography.ECDiffieHellmanCng", value5);
				dictionary.Add("DES", typeFromHandle13);
				dictionary.Add("System.Security.Cryptography.DES", typeFromHandle13);
				dictionary.Add("3DES", typeFromHandle14);
				dictionary.Add("TripleDES", typeFromHandle14);
				dictionary.Add("Triple DES", typeFromHandle14);
				dictionary.Add("System.Security.Cryptography.TripleDES", typeFromHandle14);
				dictionary.Add("RC2", typeFromHandle15);
				dictionary.Add("System.Security.Cryptography.RC2", typeFromHandle15);
				dictionary.Add("Rijndael", typeFromHandle16);
				dictionary.Add("System.Security.Cryptography.Rijndael", typeFromHandle16);
				dictionary.Add("System.Security.Cryptography.SymmetricAlgorithm", typeFromHandle16);
				dictionary.Add("AES", value);
				dictionary.Add("AesCryptoServiceProvider", value);
				dictionary.Add("System.Security.Cryptography.AesCryptoServiceProvider", value);
				dictionary.Add("AesManaged", value4);
				dictionary.Add("System.Security.Cryptography.AesManaged", value4);
				dictionary.Add("DpapiDataProtector", value15);
				dictionary.Add("System.Security.Cryptography.DpapiDataProtector", value15);
				dictionary.Add("http://www.w3.org/2000/09/xmldsig#dsa-sha1", typeFromHandle17);
				dictionary.Add("System.Security.Cryptography.DSASignatureDescription", typeFromHandle17);
				dictionary.Add("http://www.w3.org/2000/09/xmldsig#rsa-sha1", typeFromHandle18);
				dictionary.Add("System.Security.Cryptography.RSASignatureDescription", typeFromHandle18);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha256", typeFromHandle19);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha384", typeFromHandle20);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha512", typeFromHandle21);
				dictionary.Add("http://www.w3.org/2000/09/xmldsig#sha1", typeFromHandle);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#sha256", value12);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#sha512", value14);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#ripemd160", typeFromHandle3);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#des-cbc", typeFromHandle13);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#tripledes-cbc", typeFromHandle14);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-tripledes", typeFromHandle14);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#aes128-cbc", typeFromHandle16);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-aes128", typeFromHandle16);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#aes192-cbc", typeFromHandle16);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-aes192", typeFromHandle16);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#aes256-cbc", typeFromHandle16);
				dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-aes256", typeFromHandle16);
				dictionary.Add("http://www.w3.org/TR/2001/REC-xml-c14n-20010315", "System.Security.Cryptography.Xml.XmlDsigC14NTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments", "System.Security.Cryptography.Xml.XmlDsigC14NWithCommentsTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2001/10/xml-exc-c14n#", "System.Security.Cryptography.Xml.XmlDsigExcC14NTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2001/10/xml-exc-c14n#WithComments", "System.Security.Cryptography.Xml.XmlDsigExcC14NWithCommentsTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig#base64", "System.Security.Cryptography.Xml.XmlDsigBase64Transform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/TR/1999/REC-xpath-19991116", "System.Security.Cryptography.Xml.XmlDsigXPathTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/TR/1999/REC-xslt-19991116", "System.Security.Cryptography.Xml.XmlDsigXsltTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig#enveloped-signature", "System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2002/07/decrypt#XML", "System.Security.Cryptography.Xml.XmlDecryptionTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("urn:mpeg:mpeg21:2003:01-REL-R-NS:licenseTransform", "System.Security.Cryptography.Xml.XmlLicenseTransform, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig# X509Data", "System.Security.Cryptography.Xml.KeyInfoX509Data, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig# KeyName", "System.Security.Cryptography.Xml.KeyInfoName, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig# KeyValue/DSAKeyValue", "System.Security.Cryptography.Xml.DSAKeyValue, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig# KeyValue/RSAKeyValue", "System.Security.Cryptography.Xml.RSAKeyValue, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig# RetrievalMethod", "System.Security.Cryptography.Xml.KeyInfoRetrievalMethod, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2001/04/xmlenc# EncryptedKey", "System.Security.Cryptography.Xml.KeyInfoEncryptedKey, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("http://www.w3.org/2000/09/xmldsig#hmac-sha1", typeFromHandle6);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#md5", typeFromHandle2);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#sha384", value13);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-md5", typeFromHandle4);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-ripemd160", typeFromHandle5);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha256", typeFromHandle7);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha384", typeFromHandle8);
				dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha512", typeFromHandle9);
				dictionary.Add("2.5.29.10", "System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				dictionary.Add("2.5.29.19", "System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				dictionary.Add("2.5.29.14", "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				dictionary.Add("2.5.29.15", "System.Security.Cryptography.X509Certificates.X509KeyUsageExtension, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				dictionary.Add("2.5.29.37", "System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				dictionary.Add("X509Chain", "System.Security.Cryptography.X509Certificates.X509Chain, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				dictionary.Add("1.2.840.113549.1.9.3", "System.Security.Cryptography.Pkcs.Pkcs9ContentType, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("1.2.840.113549.1.9.4", "System.Security.Cryptography.Pkcs.Pkcs9MessageDigest, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("1.2.840.113549.1.9.5", "System.Security.Cryptography.Pkcs.Pkcs9SigningTime, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("1.3.6.1.4.1.311.88.2.1", "System.Security.Cryptography.Pkcs.Pkcs9DocumentName, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				dictionary.Add("1.3.6.1.4.1.311.88.2.2", "System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription, System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				defaultNameHT = dictionary;
			}
			return defaultNameHT;
		}
	}

	[SecurityCritical]
	private static void InitializeConfigInfo()
	{
		if (machineNameHT != null)
		{
			return;
		}
		lock (InternalSyncObject)
		{
			if (machineNameHT != null)
			{
				return;
			}
			ConfigNode configNode = OpenCryptoConfig();
			if (configNode != null)
			{
				foreach (ConfigNode child in configNode.Children)
				{
					if (machineNameHT != null && machineOidHT != null)
					{
						break;
					}
					if (machineNameHT == null && string.Compare(child.Name, "cryptoNameMapping", StringComparison.Ordinal) == 0)
					{
						machineNameHT = InitializeNameMappings(child);
					}
					else if (machineOidHT == null && string.Compare(child.Name, "oidMap", StringComparison.Ordinal) == 0)
					{
						machineOidHT = InitializeOidMappings(child);
					}
				}
			}
			if (machineNameHT == null)
			{
				machineNameHT = new Dictionary<string, string>();
			}
			if (machineOidHT == null)
			{
				machineOidHT = new Dictionary<string, string>();
			}
		}
	}

	[SecurityCritical]
	public static void AddAlgorithm(Type algorithm, params string[] names)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		if (!algorithm.IsVisible)
		{
			throw new ArgumentException(Environment.GetResourceString("Cryptography_AlgorithmTypesMustBeVisible"), "algorithm");
		}
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		string[] array = new string[names.Length];
		Array.Copy(names, array, array.Length);
		string[] array2 = array;
		foreach (string value in array2)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(Environment.GetResourceString("Cryptography_AddNullOrEmptyName"));
			}
		}
		lock (InternalSyncObject)
		{
			string[] array3 = array;
			foreach (string key in array3)
			{
				appNameHT[key] = algorithm;
			}
		}
	}

	[SecuritySafeCritical]
	public static object CreateFromName(string name, params object[] args)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Type type = null;
		InitializeConfigInfo();
		lock (InternalSyncObject)
		{
			type = appNameHT.GetValueOrDefault(name);
		}
		if (type == null)
		{
			string valueOrDefault = machineNameHT.GetValueOrDefault(name);
			if (valueOrDefault != null)
			{
				type = Type.GetType(valueOrDefault, throwOnError: false, ignoreCase: false);
				if (type != null && !type.IsVisible)
				{
					type = null;
				}
			}
		}
		if (type == null)
		{
			object valueOrDefault2 = DefaultNameHT.GetValueOrDefault(name);
			if (valueOrDefault2 != null)
			{
				if (valueOrDefault2 is Type)
				{
					type = (Type)valueOrDefault2;
				}
				else if (valueOrDefault2 is string)
				{
					type = Type.GetType((string)valueOrDefault2, throwOnError: false, ignoreCase: false);
					if (type != null && !type.IsVisible)
					{
						type = null;
					}
				}
			}
		}
		if (type == null)
		{
			type = Type.GetType(name, throwOnError: false, ignoreCase: false);
			if (type != null && !type.IsVisible)
			{
				type = null;
			}
		}
		if (type == null)
		{
			return null;
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			return null;
		}
		if (args == null)
		{
			args = new object[0];
		}
		MethodBase[] constructors = runtimeType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance);
		MethodBase[] array = constructors;
		if (array == null)
		{
			return null;
		}
		List<MethodBase> list = new List<MethodBase>();
		foreach (MethodBase methodBase in array)
		{
			if (methodBase.GetParameters().Length == args.Length)
			{
				list.Add(methodBase);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		array = list.ToArray();
		object state;
		RuntimeConstructorInfo runtimeConstructorInfo = Type.DefaultBinder.BindToMethod(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, array, ref args, null, null, null, out state) as RuntimeConstructorInfo;
		if (runtimeConstructorInfo == null || typeof(Delegate).IsAssignableFrom(runtimeConstructorInfo.DeclaringType))
		{
			return null;
		}
		object result = runtimeConstructorInfo.Invoke(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, Type.DefaultBinder, args, null);
		if (state != null)
		{
			Type.DefaultBinder.ReorderArgumentArray(ref args, state);
		}
		return result;
	}

	public static object CreateFromName(string name)
	{
		return CreateFromName(name, null);
	}

	[SecurityCritical]
	public static void AddOID(string oid, params string[] names)
	{
		if (oid == null)
		{
			throw new ArgumentNullException("oid");
		}
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		string[] array = new string[names.Length];
		Array.Copy(names, array, array.Length);
		string[] array2 = array;
		foreach (string value in array2)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(Environment.GetResourceString("Cryptography_AddNullOrEmptyName"));
			}
		}
		lock (InternalSyncObject)
		{
			string[] array3 = array;
			foreach (string key in array3)
			{
				appOidHT[key] = oid;
			}
		}
	}

	public static string MapNameToOID(string name)
	{
		return MapNameToOID(name, OidGroup.AllGroups);
	}

	[SecuritySafeCritical]
	internal static string MapNameToOID(string name, OidGroup oidGroup)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		InitializeConfigInfo();
		string text = null;
		lock (InternalSyncObject)
		{
			text = appOidHT.GetValueOrDefault(name);
		}
		if (text == null)
		{
			text = machineOidHT.GetValueOrDefault(name);
		}
		if (text == null)
		{
			text = DefaultOidHT.GetValueOrDefault(name);
		}
		if (text == null)
		{
			text = X509Utils.GetOidFromFriendlyName(name, oidGroup);
		}
		return text;
	}

	public static byte[] EncodeOID(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		char[] separator = new char[1] { '.' };
		string[] array = str.Split(separator);
		uint[] array2 = new uint[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (uint)int.Parse(array[i], CultureInfo.InvariantCulture);
		}
		byte[] array3 = new byte[array2.Length * 5];
		int num = 0;
		if (array2.Length < 2)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_InvalidOID"));
		}
		uint dwValue = array2[0] * 40 + array2[1];
		byte[] array4 = EncodeSingleOIDNum(dwValue);
		Array.Copy(array4, 0, array3, num, array4.Length);
		num += array4.Length;
		for (int j = 2; j < array2.Length; j++)
		{
			array4 = EncodeSingleOIDNum(array2[j]);
			Buffer.InternalBlockCopy(array4, 0, array3, num, array4.Length);
			num += array4.Length;
		}
		if (num > 127)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_Config_EncodedOIDError"));
		}
		array4 = new byte[num + 2];
		array4[0] = 6;
		array4[1] = (byte)num;
		Buffer.InternalBlockCopy(array3, 0, array4, 2, num);
		return array4;
	}

	private static byte[] EncodeSingleOIDNum(uint dwValue)
	{
		if ((int)dwValue < 128)
		{
			return new byte[1] { (byte)dwValue };
		}
		if (dwValue < 16384)
		{
			return new byte[2]
			{
				(byte)((dwValue >> 7) | 0x80),
				(byte)(dwValue & 0x7F)
			};
		}
		if (dwValue < 2097152)
		{
			return new byte[3]
			{
				(byte)((dwValue >> 14) | 0x80),
				(byte)((dwValue >> 7) | 0x80),
				(byte)(dwValue & 0x7F)
			};
		}
		if (dwValue < 268435456)
		{
			return new byte[4]
			{
				(byte)((dwValue >> 21) | 0x80),
				(byte)((dwValue >> 14) | 0x80),
				(byte)((dwValue >> 7) | 0x80),
				(byte)(dwValue & 0x7F)
			};
		}
		return new byte[5]
		{
			(byte)((dwValue >> 28) | 0x80),
			(byte)((dwValue >> 21) | 0x80),
			(byte)((dwValue >> 14) | 0x80),
			(byte)((dwValue >> 7) | 0x80),
			(byte)(dwValue & 0x7F)
		};
	}

	private static Dictionary<string, string> InitializeNameMappings(ConfigNode nameMappingNode)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		foreach (ConfigNode child in nameMappingNode.Children)
		{
			if (string.Compare(child.Name, "cryptoClasses", StringComparison.Ordinal) == 0)
			{
				foreach (ConfigNode child2 in child.Children)
				{
					if (string.Compare(child2.Name, "cryptoClass", StringComparison.Ordinal) == 0 && child2.Attributes.Count > 0)
					{
						DictionaryEntry dictionaryEntry = child2.Attributes[0];
						dictionary2.Add((string)dictionaryEntry.Key, (string)dictionaryEntry.Value);
					}
				}
			}
			else
			{
				if (string.Compare(child.Name, "nameEntry", StringComparison.Ordinal) != 0)
				{
					continue;
				}
				string text = null;
				string text2 = null;
				foreach (DictionaryEntry attribute in child.Attributes)
				{
					if (string.Compare((string)attribute.Key, "name", StringComparison.Ordinal) == 0)
					{
						text = (string)attribute.Value;
					}
					else if (string.Compare((string)attribute.Key, "class", StringComparison.Ordinal) == 0)
					{
						text2 = (string)attribute.Value;
					}
				}
				if (text != null && text2 != null)
				{
					string valueOrDefault = dictionary2.GetValueOrDefault(text2);
					if (valueOrDefault != null)
					{
						dictionary.Add(text, valueOrDefault);
					}
				}
			}
		}
		return dictionary;
	}

	private static Dictionary<string, string> InitializeOidMappings(ConfigNode oidMappingNode)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (ConfigNode child in oidMappingNode.Children)
		{
			if (string.Compare(child.Name, "oidEntry", StringComparison.Ordinal) != 0)
			{
				continue;
			}
			string text = null;
			string text2 = null;
			foreach (DictionaryEntry attribute in child.Attributes)
			{
				if (string.Compare((string)attribute.Key, "OID", StringComparison.Ordinal) == 0)
				{
					text = (string)attribute.Value;
				}
				else if (string.Compare((string)attribute.Key, "name", StringComparison.Ordinal) == 0)
				{
					text2 = (string)attribute.Value;
				}
			}
			if (text2 != null && text != null)
			{
				dictionary.Add(text2, text);
			}
		}
		return dictionary;
	}

	[SecurityCritical]
	private static ConfigNode OpenCryptoConfig()
	{
		string text = Config.MachineDirectory + "machine.config";
		new FileIOPermission(FileIOPermissionAccess.Read, text).Assert();
		if (!File.Exists(text))
		{
			return null;
		}
		CodeAccessPermission.RevertAssert();
		ConfigTreeParser configTreeParser = new ConfigTreeParser();
		ConfigNode configNode = configTreeParser.Parse(text, "configuration", skipSecurityStuff: true);
		if (configNode == null)
		{
			return null;
		}
		ConfigNode configNode2 = null;
		foreach (ConfigNode child in configNode.Children)
		{
			bool flag = false;
			if (string.Compare(child.Name, "mscorlib", StringComparison.Ordinal) == 0)
			{
				foreach (DictionaryEntry attribute in child.Attributes)
				{
					if (string.Compare((string)attribute.Key, "version", StringComparison.Ordinal) == 0)
					{
						flag = true;
						if (string.Compare((string)attribute.Value, Version, StringComparison.Ordinal) == 0)
						{
							configNode2 = child;
							break;
						}
					}
				}
				if (!flag)
				{
					configNode2 = child;
				}
			}
			if (configNode2 != null)
			{
				break;
			}
		}
		if (configNode2 == null)
		{
			return null;
		}
		foreach (ConfigNode child2 in configNode2.Children)
		{
			if (string.Compare(child2.Name, "cryptographySettings", StringComparison.Ordinal) == 0)
			{
				return child2;
			}
		}
		return null;
	}
}
