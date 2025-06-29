using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace System.Net;

internal class NTAuthentication
{
	private class InitializeCallbackContext
	{
		internal readonly NTAuthentication thisPtr;

		internal readonly bool isServer;

		internal readonly string package;

		internal readonly NetworkCredential credential;

		internal readonly string spn;

		internal readonly ContextFlags requestedContextFlags;

		internal readonly ChannelBinding channelBinding;

		internal InitializeCallbackContext(NTAuthentication thisPtr, bool isServer, string package, NetworkCredential credential, string spn, ContextFlags requestedContextFlags, ChannelBinding channelBinding)
		{
			this.thisPtr = thisPtr;
			this.isServer = isServer;
			this.package = package;
			this.credential = credential;
			this.spn = spn;
			this.requestedContextFlags = requestedContextFlags;
			this.channelBinding = channelBinding;
		}
	}

	private static int s_UniqueGroupId = 1;

	private static ContextCallback s_InitializeCallback = InitializeCallback;

	private bool m_IsServer;

	private SafeFreeCredentials m_CredentialsHandle;

	private SafeDeleteContext m_SecurityContext;

	private string m_Spn;

	private string m_ClientSpecifiedSpn;

	private int m_TokenSize;

	private ContextFlags m_RequestedContextFlags;

	private ContextFlags m_ContextFlags;

	private string m_UniqueUserId;

	private bool m_IsCompleted;

	private string m_ProtocolName;

	private SecSizes m_Sizes;

	private string m_LastProtocolName;

	private string m_Package;

	private ChannelBinding m_ChannelBinding;

	internal string UniqueUserId => m_UniqueUserId;

	internal bool IsCompleted => m_IsCompleted;

	internal bool IsValidContext
	{
		get
		{
			if (m_SecurityContext != null)
			{
				return !m_SecurityContext.IsInvalid;
			}
			return false;
		}
	}

	internal string AssociatedName
	{
		get
		{
			if (!IsValidContext || !IsCompleted)
			{
				throw new Win32Exception(-2146893055);
			}
			return SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPIAuth, m_SecurityContext, ContextAttribute.Names) as string;
		}
	}

	internal bool IsConfidentialityFlag => (m_ContextFlags & ContextFlags.Confidentiality) != 0;

	internal bool IsIntegrityFlag => ((uint)m_ContextFlags & (uint)(m_IsServer ? 131072 : 65536)) != 0;

	internal bool IsMutualAuthFlag => (m_ContextFlags & ContextFlags.MutualAuth) != 0;

	internal bool IsDelegationFlag => (m_ContextFlags & ContextFlags.Delegate) != 0;

	internal bool IsIdentifyFlag => ((uint)m_ContextFlags & (uint)(m_IsServer ? 524288 : 131072)) != 0;

	internal string Spn => m_Spn;

	internal string ClientSpecifiedSpn
	{
		get
		{
			if (m_ClientSpecifiedSpn == null)
			{
				m_ClientSpecifiedSpn = GetClientSpecifiedSpn();
			}
			return m_ClientSpecifiedSpn;
		}
	}

	internal bool OSSupportsExtendedProtection
	{
		get
		{
			SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPIAuth, m_SecurityContext, ContextAttribute.ClientSpecifiedSpn, out var errorCode);
			return errorCode != -2146893054;
		}
	}

	internal bool IsServer => m_IsServer;

	internal bool IsKerberos
	{
		get
		{
			if (m_LastProtocolName == null)
			{
				m_LastProtocolName = ProtocolName;
			}
			return (object)m_LastProtocolName == "Kerberos";
		}
	}

	internal bool IsNTLM
	{
		get
		{
			if (m_LastProtocolName == null)
			{
				m_LastProtocolName = ProtocolName;
			}
			return (object)m_LastProtocolName == "NTLM";
		}
	}

	internal string Package => m_Package;

	internal string ProtocolName
	{
		get
		{
			if (m_ProtocolName == null)
			{
				NegotiationInfoClass negotiationInfoClass = null;
				if (IsValidContext)
				{
					negotiationInfoClass = SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPIAuth, m_SecurityContext, ContextAttribute.NegotiationInfo) as NegotiationInfoClass;
					if (IsCompleted && negotiationInfoClass != null)
					{
						m_ProtocolName = negotiationInfoClass.AuthenticationPackage;
					}
				}
				if (negotiationInfoClass != null)
				{
					return negotiationInfoClass.AuthenticationPackage;
				}
				return string.Empty;
			}
			return m_ProtocolName;
		}
	}

	internal SecSizes Sizes
	{
		get
		{
			if (m_Sizes == null)
			{
				m_Sizes = SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPIAuth, m_SecurityContext, ContextAttribute.Sizes) as SecSizes;
			}
			return m_Sizes;
		}
	}

	internal ChannelBinding ChannelBinding => m_ChannelBinding;

	internal NTAuthentication(string package, NetworkCredential networkCredential, SpnToken spnToken, WebRequest request, ChannelBinding channelBinding)
		: this(isServer: false, package, networkCredential, spnToken.Spn, GetHttpContextFlags(request, spnToken.IsTrusted), request.GetWritingContext(), channelBinding)
	{
		if (package == "NTLM" || package == "Negotiate")
		{
			m_UniqueUserId = Interlocked.Increment(ref s_UniqueGroupId).ToString(NumberFormatInfo.InvariantInfo) + m_UniqueUserId;
		}
	}

	private static ContextFlags GetHttpContextFlags(WebRequest request, bool trustedSpn)
	{
		ContextFlags contextFlags = ContextFlags.Connection;
		if (request.ImpersonationLevel == TokenImpersonationLevel.Anonymous)
		{
			throw new NotSupportedException(SR.GetString("net_auth_no_anonymous_support"));
		}
		if (request.ImpersonationLevel == TokenImpersonationLevel.Identification)
		{
			contextFlags |= ContextFlags.AcceptIntegrity;
		}
		else if (request.ImpersonationLevel == TokenImpersonationLevel.Delegation)
		{
			contextFlags |= ContextFlags.Delegate;
		}
		if (request.AuthenticationLevel == AuthenticationLevel.MutualAuthRequested || request.AuthenticationLevel == AuthenticationLevel.MutualAuthRequired)
		{
			contextFlags |= ContextFlags.MutualAuth;
		}
		if (!trustedSpn && ComNetOS.IsWin7Sp1orLater)
		{
			contextFlags |= ContextFlags.UnverifiedTargetName;
		}
		return contextFlags;
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	internal NTAuthentication(bool isServer, string package, NetworkCredential credential, string spn, ContextFlags requestedContextFlags, ContextAwareResult context, ChannelBinding channelBinding)
	{
		if (credential is SystemNetworkCredential)
		{
			WindowsIdentity windowsIdentity = context?.Identity;
			try
			{
				IDisposable disposable = windowsIdentity?.Impersonate();
				if (disposable != null)
				{
					using (disposable)
					{
						Initialize(isServer, package, credential, spn, requestedContextFlags, channelBinding);
						return;
					}
				}
				ExecutionContext executionContext = context?.ContextCopy;
				if (executionContext == null)
				{
					Initialize(isServer, package, credential, spn, requestedContextFlags, channelBinding);
				}
				else
				{
					ExecutionContext.Run(executionContext, s_InitializeCallback, new InitializeCallbackContext(this, isServer, package, credential, spn, requestedContextFlags, channelBinding));
				}
				return;
			}
			catch
			{
				throw;
			}
		}
		Initialize(isServer, package, credential, spn, requestedContextFlags, channelBinding);
	}

	internal NTAuthentication(bool isServer, string package, NetworkCredential credential, string spn, ContextFlags requestedContextFlags, ChannelBinding channelBinding)
	{
		Initialize(isServer, package, credential, spn, requestedContextFlags, channelBinding);
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	internal NTAuthentication(bool isServer, string package, string spn, ContextFlags requestedContextFlags, ChannelBinding channelBinding)
	{
		try
		{
			using (WindowsIdentity.Impersonate(IntPtr.Zero))
			{
				Initialize(isServer, package, SystemNetworkCredential.defaultCredential, spn, requestedContextFlags, channelBinding);
			}
		}
		catch
		{
			throw;
		}
	}

	private static void InitializeCallback(object state)
	{
		InitializeCallbackContext initializeCallbackContext = (InitializeCallbackContext)state;
		initializeCallbackContext.thisPtr.Initialize(initializeCallbackContext.isServer, initializeCallbackContext.package, initializeCallbackContext.credential, initializeCallbackContext.spn, initializeCallbackContext.requestedContextFlags, initializeCallbackContext.channelBinding);
	}

	private void Initialize(bool isServer, string package, NetworkCredential credential, string spn, ContextFlags requestedContextFlags, ChannelBinding channelBinding)
	{
		m_TokenSize = SSPIWrapper.GetVerifyPackageInfo(GlobalSSPI.SSPIAuth, package, throwIfMissing: true).MaxToken;
		m_IsServer = isServer;
		m_Spn = spn;
		m_SecurityContext = null;
		m_RequestedContextFlags = requestedContextFlags;
		m_Package = package;
		m_ChannelBinding = channelBinding;
		if (credential is SystemNetworkCredential)
		{
			m_CredentialsHandle = SSPIWrapper.AcquireDefaultCredential(GlobalSSPI.SSPIAuth, package, m_IsServer ? CredentialUse.Inbound : CredentialUse.Outbound);
			m_UniqueUserId = "/S";
			return;
		}
		if (ComNetOS.IsWin7orLater)
		{
			SafeSspiAuthDataHandle authData = null;
			try
			{
				SecurityStatus securityStatus = UnsafeNclNativeMethods.SspiHelper.SspiEncodeStringsAsAuthIdentity(credential.InternalGetUserName(), credential.InternalGetDomain(), credential.InternalGetPassword(), out authData);
				if (securityStatus != SecurityStatus.OK)
				{
					if (Logging.On)
					{
						Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", "SspiEncodeStringsAsAuthIdentity()", string.Format(CultureInfo.CurrentCulture, "0x{0:X}", new object[1] { (int)securityStatus })));
					}
					throw new Win32Exception((int)securityStatus);
				}
				m_CredentialsHandle = SSPIWrapper.AcquireCredentialsHandle(GlobalSSPI.SSPIAuth, package, m_IsServer ? CredentialUse.Inbound : CredentialUse.Outbound, ref authData);
				return;
			}
			finally
			{
				authData?.Close();
			}
		}
		string text = credential.InternalGetUserName();
		string text2 = credential.InternalGetDomain();
		AuthIdentity authdata = new AuthIdentity(text, credential.InternalGetPassword(), ((object)package == "WDigest" && (text2 == null || text2.Length == 0)) ? null : text2);
		m_UniqueUserId = text2 + "/" + text + "/U";
		m_CredentialsHandle = SSPIWrapper.AcquireCredentialsHandle(GlobalSSPI.SSPIAuth, package, m_IsServer ? CredentialUse.Inbound : CredentialUse.Outbound, ref authdata);
	}

	internal SafeCloseHandle GetContextToken(out SecurityStatus status)
	{
		if (!IsValidContext)
		{
			throw new Win32Exception(-2146893055);
		}
		SafeCloseHandle token = null;
		status = (SecurityStatus)SSPIWrapper.QuerySecurityContextToken(GlobalSSPI.SSPIAuth, m_SecurityContext, out token);
		return token;
	}

	internal SafeCloseHandle GetContextToken()
	{
		SecurityStatus status;
		SafeCloseHandle contextToken = GetContextToken(out status);
		if (status != SecurityStatus.OK)
		{
			throw new Win32Exception((int)status);
		}
		return contextToken;
	}

	internal void CloseContext()
	{
		if (m_SecurityContext != null && !m_SecurityContext.IsClosed)
		{
			m_SecurityContext.Close();
		}
	}

	internal string GetOutgoingBlob(string incomingBlob)
	{
		byte[] array = null;
		if (incomingBlob != null && incomingBlob.Length > 0)
		{
			array = Convert.FromBase64String(incomingBlob);
		}
		byte[] array2 = null;
		if ((IsValidContext || IsCompleted) && array == null)
		{
			m_IsCompleted = true;
		}
		else
		{
			array2 = GetOutgoingBlob(array, throwOnError: true, out var _);
		}
		string result = null;
		if (array2 != null && array2.Length != 0)
		{
			result = Convert.ToBase64String(array2);
		}
		if (IsCompleted)
		{
			string protocolName = ProtocolName;
			CloseContext();
		}
		return result;
	}

	internal byte[] GetOutgoingBlob(byte[] incomingBlob, bool throwOnError, out SecurityStatus statusCode)
	{
		List<SecurityBuffer> list = new List<SecurityBuffer>(2);
		if (incomingBlob != null)
		{
			list.Add(new SecurityBuffer(incomingBlob, BufferType.Token));
		}
		if (m_ChannelBinding != null)
		{
			list.Add(new SecurityBuffer(m_ChannelBinding));
		}
		SecurityBuffer[] inputBuffers = null;
		if (list.Count > 0)
		{
			inputBuffers = list.ToArray();
		}
		SecurityBuffer securityBuffer = new SecurityBuffer(m_TokenSize, BufferType.Token);
		bool flag = m_SecurityContext == null;
		try
		{
			if (!m_IsServer)
			{
				statusCode = (SecurityStatus)SSPIWrapper.InitializeSecurityContext(GlobalSSPI.SSPIAuth, m_CredentialsHandle, ref m_SecurityContext, m_Spn, m_RequestedContextFlags, Endianness.Network, inputBuffers, securityBuffer, ref m_ContextFlags);
				if (statusCode == SecurityStatus.CompleteNeeded)
				{
					statusCode = (SecurityStatus)SSPIWrapper.CompleteAuthToken(inputBuffers: new SecurityBuffer[1] { securityBuffer }, SecModule: GlobalSSPI.SSPIAuth, context: ref m_SecurityContext);
					securityBuffer.token = null;
				}
			}
			else
			{
				statusCode = (SecurityStatus)SSPIWrapper.AcceptSecurityContext(GlobalSSPI.SSPIAuth, m_CredentialsHandle, ref m_SecurityContext, m_RequestedContextFlags, Endianness.Network, inputBuffers, securityBuffer, ref m_ContextFlags);
			}
		}
		finally
		{
			if (flag && m_CredentialsHandle != null)
			{
				m_CredentialsHandle.Close();
			}
		}
		if ((statusCode & (SecurityStatus)(-2147483648)) != SecurityStatus.OK)
		{
			CloseContext();
			m_IsCompleted = true;
			if (throwOnError)
			{
				Win32Exception ex = new Win32Exception((int)statusCode);
				throw ex;
			}
			return null;
		}
		if (flag && m_CredentialsHandle != null)
		{
			SSPIHandleCache.CacheCredential(m_CredentialsHandle);
		}
		if (statusCode == SecurityStatus.OK)
		{
			m_IsCompleted = true;
		}
		return securityBuffer.token;
	}

	internal string GetOutgoingDigestBlob(string incomingBlob, string requestMethod, string requestedUri, string realm, bool isClientPreAuth, bool throwOnError, out SecurityStatus statusCode)
	{
		SecurityBuffer[] inputBuffers = null;
		SecurityBuffer securityBuffer = new SecurityBuffer(m_TokenSize, isClientPreAuth ? BufferType.Parameters : BufferType.Token);
		bool flag = m_SecurityContext == null;
		try
		{
			if (!m_IsServer)
			{
				if (!isClientPreAuth)
				{
					if (incomingBlob != null)
					{
						List<SecurityBuffer> list = new List<SecurityBuffer>(5);
						list.Add(new SecurityBuffer(WebHeaderCollection.HeaderEncoding.GetBytes(incomingBlob), BufferType.Token));
						list.Add(new SecurityBuffer(WebHeaderCollection.HeaderEncoding.GetBytes(requestMethod), BufferType.Parameters));
						list.Add(new SecurityBuffer(null, BufferType.Parameters));
						list.Add(new SecurityBuffer(Encoding.Unicode.GetBytes(m_Spn), BufferType.TargetHost));
						if (m_ChannelBinding != null)
						{
							list.Add(new SecurityBuffer(m_ChannelBinding));
						}
						inputBuffers = list.ToArray();
					}
					statusCode = (SecurityStatus)SSPIWrapper.InitializeSecurityContext(GlobalSSPI.SSPIAuth, m_CredentialsHandle, ref m_SecurityContext, requestedUri, m_RequestedContextFlags, Endianness.Network, inputBuffers, securityBuffer, ref m_ContextFlags);
				}
				else
				{
					statusCode = SecurityStatus.OK;
				}
			}
			else
			{
				List<SecurityBuffer> list2 = new List<SecurityBuffer>(6);
				list2.Add((incomingBlob == null) ? new SecurityBuffer(0, BufferType.Token) : new SecurityBuffer(WebHeaderCollection.HeaderEncoding.GetBytes(incomingBlob), BufferType.Token));
				list2.Add((requestMethod == null) ? new SecurityBuffer(0, BufferType.Parameters) : new SecurityBuffer(WebHeaderCollection.HeaderEncoding.GetBytes(requestMethod), BufferType.Parameters));
				list2.Add((requestedUri == null) ? new SecurityBuffer(0, BufferType.Parameters) : new SecurityBuffer(WebHeaderCollection.HeaderEncoding.GetBytes(requestedUri), BufferType.Parameters));
				list2.Add(new SecurityBuffer(0, BufferType.Parameters));
				list2.Add((realm == null) ? new SecurityBuffer(0, BufferType.Parameters) : new SecurityBuffer(Encoding.Unicode.GetBytes(realm), BufferType.Parameters));
				if (m_ChannelBinding != null)
				{
					list2.Add(new SecurityBuffer(m_ChannelBinding));
				}
				inputBuffers = list2.ToArray();
				statusCode = (SecurityStatus)SSPIWrapper.AcceptSecurityContext(GlobalSSPI.SSPIAuth, m_CredentialsHandle, ref m_SecurityContext, m_RequestedContextFlags, Endianness.Network, inputBuffers, securityBuffer, ref m_ContextFlags);
				if (statusCode == SecurityStatus.CompleteNeeded)
				{
					inputBuffers[4] = securityBuffer;
					statusCode = (SecurityStatus)SSPIWrapper.CompleteAuthToken(GlobalSSPI.SSPIAuth, ref m_SecurityContext, inputBuffers);
					securityBuffer.token = null;
				}
			}
		}
		finally
		{
			if (flag && m_CredentialsHandle != null)
			{
				m_CredentialsHandle.Close();
			}
		}
		if ((statusCode & (SecurityStatus)(-2147483648)) != SecurityStatus.OK)
		{
			CloseContext();
			if (throwOnError)
			{
				Win32Exception ex = new Win32Exception((int)statusCode);
				throw ex;
			}
			return null;
		}
		if (flag && m_CredentialsHandle != null)
		{
			SSPIHandleCache.CacheCredential(m_CredentialsHandle);
		}
		if (statusCode == SecurityStatus.OK)
		{
			m_IsCompleted = true;
		}
		byte[] token = securityBuffer.token;
		string result = null;
		if (token != null && token.Length != 0)
		{
			result = WebHeaderCollection.HeaderEncoding.GetString(token, 0, securityBuffer.size);
		}
		return result;
	}

	internal int Encrypt(byte[] buffer, int offset, int count, ref byte[] output, uint sequenceNumber)
	{
		SecSizes sizes = Sizes;
		try
		{
			int num = checked(2147483643 - sizes.BlockSize - sizes.SecurityTrailer);
			if (count > num || count < 0)
			{
				throw new ArgumentOutOfRangeException("count", SR.GetString("net_io_out_range", num));
			}
		}
		catch (Exception exception)
		{
			NclUtilities.IsFatal(exception);
			throw;
		}
		int num2 = count + sizes.SecurityTrailer + sizes.BlockSize;
		if (output == null || output.Length < num2 + 4)
		{
			output = new byte[num2 + 4];
		}
		Buffer.BlockCopy(buffer, offset, output, 4 + sizes.SecurityTrailer, count);
		SecurityBuffer[] array = new SecurityBuffer[3]
		{
			new SecurityBuffer(output, 4, sizes.SecurityTrailer, BufferType.Token),
			new SecurityBuffer(output, 4 + sizes.SecurityTrailer, count, BufferType.Data),
			new SecurityBuffer(output, 4 + sizes.SecurityTrailer + count, sizes.BlockSize, BufferType.Padding)
		};
		int num3;
		if (IsConfidentialityFlag)
		{
			num3 = SSPIWrapper.EncryptMessage(GlobalSSPI.SSPIAuth, m_SecurityContext, array, sequenceNumber);
		}
		else
		{
			if (IsNTLM)
			{
				array[1].type |= BufferType.ReadOnlyFlag;
			}
			num3 = SSPIWrapper.MakeSignature(GlobalSSPI.SSPIAuth, m_SecurityContext, array, 0u);
		}
		if (num3 != 0)
		{
			throw new Win32Exception(num3);
		}
		num2 = array[0].size;
		bool flag = false;
		if (num2 != sizes.SecurityTrailer)
		{
			flag = true;
			Buffer.BlockCopy(output, array[1].offset, output, 4 + num2, array[1].size);
		}
		num2 += array[1].size;
		if (array[2].size != 0 && (flag || num2 != count + sizes.SecurityTrailer))
		{
			Buffer.BlockCopy(output, array[2].offset, output, 4 + num2, array[2].size);
		}
		num2 += array[2].size;
		output[0] = (byte)(num2 & 0xFF);
		output[1] = (byte)((num2 >> 8) & 0xFF);
		output[2] = (byte)((num2 >> 16) & 0xFF);
		output[3] = (byte)((num2 >> 24) & 0xFF);
		return num2 + 4;
	}

	internal int Decrypt(byte[] payload, int offset, int count, out int newOffset, uint expectedSeqNumber)
	{
		if (offset < 0 || offset > ((payload != null) ? payload.Length : 0))
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > ((payload != null) ? (payload.Length - offset) : 0))
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (IsNTLM)
		{
			return DecryptNtlm(payload, offset, count, out newOffset, expectedSeqNumber);
		}
		SecurityBuffer[] array = new SecurityBuffer[2]
		{
			new SecurityBuffer(payload, offset, count, BufferType.Stream),
			new SecurityBuffer(0, BufferType.Data)
		};
		int num = ((!IsConfidentialityFlag) ? SSPIWrapper.VerifySignature(GlobalSSPI.SSPIAuth, m_SecurityContext, array, expectedSeqNumber) : SSPIWrapper.DecryptMessage(GlobalSSPI.SSPIAuth, m_SecurityContext, array, expectedSeqNumber));
		if (num != 0)
		{
			throw new Win32Exception(num);
		}
		if (array[1].type != BufferType.Data)
		{
			throw new InternalException();
		}
		newOffset = array[1].offset;
		return array[1].size;
	}

	private string GetClientSpecifiedSpn()
	{
		return SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPIAuth, m_SecurityContext, ContextAttribute.ClientSpecifiedSpn) as string;
	}

	private int DecryptNtlm(byte[] payload, int offset, int count, out int newOffset, uint expectedSeqNumber)
	{
		if (count < 16)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		SecurityBuffer[] array = new SecurityBuffer[2]
		{
			new SecurityBuffer(payload, offset, 16, BufferType.Token),
			new SecurityBuffer(payload, offset + 16, count - 16, BufferType.Data)
		};
		BufferType bufferType = BufferType.Data;
		int num;
		if (IsConfidentialityFlag)
		{
			num = SSPIWrapper.DecryptMessage(GlobalSSPI.SSPIAuth, m_SecurityContext, array, expectedSeqNumber);
		}
		else
		{
			bufferType |= BufferType.ReadOnlyFlag;
			array[1].type = bufferType;
			num = SSPIWrapper.VerifySignature(GlobalSSPI.SSPIAuth, m_SecurityContext, array, expectedSeqNumber);
		}
		if (num != 0)
		{
			throw new Win32Exception(num);
		}
		if (array[1].type != bufferType)
		{
			throw new InternalException();
		}
		newOffset = array[1].offset;
		return array[1].size;
	}

	internal int VerifySignature(byte[] buffer, int offset, int count)
	{
		if (offset < 0 || offset > ((buffer != null) ? buffer.Length : 0))
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > ((buffer != null) ? (buffer.Length - offset) : 0))
		{
			throw new ArgumentOutOfRangeException("count");
		}
		SecurityBuffer[] array = new SecurityBuffer[2]
		{
			new SecurityBuffer(buffer, offset, count, BufferType.Stream),
			new SecurityBuffer(0, BufferType.Data)
		};
		int num = SSPIWrapper.VerifySignature(GlobalSSPI.SSPIAuth, m_SecurityContext, array, 0u);
		if (num != 0)
		{
			throw new Win32Exception(num);
		}
		if (array[1].type != BufferType.Data)
		{
			throw new InternalException();
		}
		return array[1].size;
	}

	internal int MakeSignature(byte[] buffer, int offset, int count, ref byte[] output)
	{
		SecSizes sizes = Sizes;
		int num = count + sizes.MaxSignature;
		if (output == null || output.Length < num)
		{
			output = new byte[num];
		}
		Buffer.BlockCopy(buffer, offset, output, sizes.MaxSignature, count);
		SecurityBuffer[] array = new SecurityBuffer[2]
		{
			new SecurityBuffer(output, 0, sizes.MaxSignature, BufferType.Token),
			new SecurityBuffer(output, sizes.MaxSignature, count, BufferType.Data)
		};
		int num2 = SSPIWrapper.MakeSignature(GlobalSSPI.SSPIAuth, m_SecurityContext, array, 0u);
		if (num2 != 0)
		{
			throw new Win32Exception(num2);
		}
		return array[0].size + array[1].size;
	}
}
