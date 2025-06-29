internal static class Interop
{
	internal static class SChannel
	{
		public struct SCHANNEL_ALERT_TOKEN
		{
			public uint dwTokenType;

			public uint dwAlertType;

			public uint dwAlertNumber;
		}

		public const int SCHANNEL_RENEGOTIATE = 0;

		public const int SCHANNEL_SHUTDOWN = 1;

		public const int SCHANNEL_ALERT = 2;

		public const int SCHANNEL_SESSION = 3;

		public const int TLS1_ALERT_WARNING = 1;

		public const int TLS1_ALERT_FATAL = 2;

		public const int TLS1_ALERT_CLOSE_NOTIFY = 0;

		public const int TLS1_ALERT_UNEXPECTED_MESSAGE = 10;

		public const int TLS1_ALERT_BAD_RECORD_MAC = 20;

		public const int TLS1_ALERT_DECRYPTION_FAILED = 21;

		public const int TLS1_ALERT_RECORD_OVERFLOW = 22;

		public const int TLS1_ALERT_DECOMPRESSION_FAIL = 30;

		public const int TLS1_ALERT_HANDSHAKE_FAILURE = 40;

		public const int TLS1_ALERT_BAD_CERTIFICATE = 42;

		public const int TLS1_ALERT_UNSUPPORTED_CERT = 43;

		public const int TLS1_ALERT_CERTIFICATE_REVOKED = 44;

		public const int TLS1_ALERT_CERTIFICATE_EXPIRED = 45;

		public const int TLS1_ALERT_CERTIFICATE_UNKNOWN = 46;

		public const int TLS1_ALERT_ILLEGAL_PARAMETER = 47;

		public const int TLS1_ALERT_UNKNOWN_CA = 48;

		public const int TLS1_ALERT_ACCESS_DENIED = 49;

		public const int TLS1_ALERT_DECODE_ERROR = 50;

		public const int TLS1_ALERT_DECRYPT_ERROR = 51;

		public const int TLS1_ALERT_EXPORT_RESTRICTION = 60;

		public const int TLS1_ALERT_PROTOCOL_VERSION = 70;

		public const int TLS1_ALERT_INSUFFIENT_SECURITY = 71;

		public const int TLS1_ALERT_INTERNAL_ERROR = 80;

		public const int TLS1_ALERT_USER_CANCELED = 90;

		public const int TLS1_ALERT_NO_RENEGOTIATION = 100;

		public const int TLS1_ALERT_UNSUPPORTED_EXT = 110;
	}
}
