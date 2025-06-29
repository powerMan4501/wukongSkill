namespace System.Security.Cryptography.X509Certificates;

internal static class X509Constants
{
	internal const uint CRYPT_EXPORTABLE = 1u;

	internal const uint CRYPT_USER_PROTECTED = 2u;

	internal const uint CRYPT_MACHINE_KEYSET = 32u;

	internal const uint CRYPT_USER_KEYSET = 4096u;

	internal const uint PKCS12_ALWAYS_CNG_KSP = 512u;

	internal const uint PKCS12_NO_PERSIST_KEY = 32768u;

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

	internal const uint CERT_STORE_PROV_MEMORY = 2u;

	internal const uint CERT_STORE_PROV_SYSTEM = 10u;

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

	internal const uint CERT_NAME_EMAIL_TYPE = 1u;

	internal const uint CERT_NAME_RDN_TYPE = 2u;

	internal const uint CERT_NAME_SIMPLE_DISPLAY_TYPE = 4u;

	internal const uint CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5u;

	internal const uint CERT_NAME_DNS_TYPE = 6u;

	internal const uint CERT_NAME_URL_TYPE = 7u;

	internal const uint CERT_NAME_UPN_TYPE = 8u;
}
