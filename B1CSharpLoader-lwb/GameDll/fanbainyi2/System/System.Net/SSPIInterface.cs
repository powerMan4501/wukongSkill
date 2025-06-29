using System.Runtime.InteropServices;

namespace System.Net;

internal interface SSPIInterface
{
	SecurityPackageInfoClass[] SecurityPackages { get; set; }

	int EnumerateSecurityPackages(out int pkgnum, out SafeFreeContextBuffer pkgArray);

	int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref AuthIdentity authdata, out SafeFreeCredentials outCredential);

	int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential);

	int AcquireDefaultCredential(string moduleName, CredentialUse usage, out SafeFreeCredentials outCredential);

	int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SecureCredential authdata, out SafeFreeCredentials outCredential);

	int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SecureCredential2 authdata, out SafeFreeCredentials outCredential);

	int AcceptSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer inputBuffer, ContextFlags inFlags, Endianness endianness, SecurityBuffer outputBuffer, ref ContextFlags outFlags);

	int AcceptSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers, ContextFlags inFlags, Endianness endianness, SecurityBuffer outputBuffer, ref ContextFlags outFlags);

	int InitializeSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref ContextFlags outFlags);

	int InitializeSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref ContextFlags outFlags);

	int EncryptMessage(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber);

	int DecryptMessage(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber);

	int MakeSignature(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber);

	int VerifySignature(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber);

	int QueryContextChannelBinding(SafeDeleteContext phContext, ContextAttribute attribute, out SafeFreeContextBufferChannelBinding refHandle);

	int QueryContextAttributes(SafeDeleteContext phContext, ContextAttribute attribute, byte[] buffer, Type handleType, out SafeHandle refHandle);

	int SetContextAttributes(SafeDeleteContext phContext, ContextAttribute attribute, byte[] buffer);

	int QuerySecurityContextToken(SafeDeleteContext phContext, out SafeCloseHandle phToken);

	int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers);

	int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers);
}
