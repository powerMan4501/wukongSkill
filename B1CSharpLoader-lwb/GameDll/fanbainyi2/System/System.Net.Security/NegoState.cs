using System.ComponentModel;
using System.IO;
using System.Security;
using System.Security.Authentication;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Principal;
using System.Threading;

namespace System.Net.Security;

internal class NegoState
{
	private const int ERROR_TRUST_FAILURE = 1790;

	private static readonly byte[] _EmptyMessage = new byte[0];

	private static readonly AsyncCallback _ReadCallback = ReadCallback;

	private static readonly AsyncCallback _WriteCallback = WriteCallback;

	private Stream _InnerStream;

	private bool _LeaveStreamOpen;

	private Exception _Exception;

	private StreamFramer _Framer;

	private NTAuthentication _Context;

	private int _NestedAuth;

	internal const int c_MaxReadFrameSize = 65536;

	internal const int c_MaxWriteDataSize = 64512;

	private bool _CanRetryAuthentication;

	private ProtectionLevel _ExpectedProtectionLevel;

	private TokenImpersonationLevel _ExpectedImpersonationLevel;

	private uint _WriteSequenceNumber;

	private uint _ReadSequenceNumber;

	private ExtendedProtectionPolicy _ExtendedProtectionPolicy;

	private bool _RemoteOk;

	internal static string DefaultPackage => "Negotiate";

	internal bool IsAuthenticated
	{
		get
		{
			if (_Context != null && HandshakeComplete && _Exception == null)
			{
				return _RemoteOk;
			}
			return false;
		}
	}

	internal bool IsMutuallyAuthenticated
	{
		get
		{
			if (!IsAuthenticated)
			{
				return false;
			}
			if (_Context.IsNTLM)
			{
				return false;
			}
			return _Context.IsMutualAuthFlag;
		}
	}

	internal bool IsEncrypted
	{
		get
		{
			if (IsAuthenticated)
			{
				return _Context.IsConfidentialityFlag;
			}
			return false;
		}
	}

	internal bool IsSigned
	{
		get
		{
			if (IsAuthenticated)
			{
				if (!_Context.IsIntegrityFlag)
				{
					return _Context.IsConfidentialityFlag;
				}
				return true;
			}
			return false;
		}
	}

	internal bool IsServer
	{
		get
		{
			if (_Context != null)
			{
				return _Context.IsServer;
			}
			return false;
		}
	}

	internal bool CanGetSecureStream
	{
		get
		{
			if (!_Context.IsConfidentialityFlag)
			{
				return _Context.IsIntegrityFlag;
			}
			return true;
		}
	}

	internal TokenImpersonationLevel AllowedImpersonation
	{
		get
		{
			CheckThrow(authSucessCheck: true);
			return PrivateImpersonationLevel;
		}
	}

	private TokenImpersonationLevel PrivateImpersonationLevel
	{
		get
		{
			if (!_Context.IsDelegationFlag || !(_Context.ProtocolName != "NTLM"))
			{
				if (!_Context.IsIdentifyFlag)
				{
					return TokenImpersonationLevel.Impersonation;
				}
				return TokenImpersonationLevel.Identification;
			}
			return TokenImpersonationLevel.Delegation;
		}
	}

	private bool HandshakeComplete
	{
		get
		{
			if (_Context.IsCompleted)
			{
				return _Context.IsValidContext;
			}
			return false;
		}
	}

	internal NegoState(Stream innerStream, bool leaveStreamOpen)
	{
		if (innerStream == null)
		{
			throw new ArgumentNullException("stream");
		}
		_InnerStream = innerStream;
		_LeaveStreamOpen = leaveStreamOpen;
	}

	internal void ValidateCreateContext(string package, NetworkCredential credential, string servicePrincipalName, ExtendedProtectionPolicy policy, ProtectionLevel protectionLevel, TokenImpersonationLevel impersonationLevel)
	{
		if (policy != null)
		{
			if (!AuthenticationManager.OSSupportsExtendedProtection)
			{
				if (policy.PolicyEnforcement == PolicyEnforcement.Always)
				{
					throw new PlatformNotSupportedException(SR.GetString("security_ExtendedProtection_NoOSSupport"));
				}
			}
			else if (policy.CustomChannelBinding == null && policy.CustomServiceNames == null)
			{
				throw new ArgumentException(SR.GetString("net_auth_must_specify_extended_protection_scheme"), "policy");
			}
			_ExtendedProtectionPolicy = policy;
		}
		else
		{
			_ExtendedProtectionPolicy = new ExtendedProtectionPolicy(PolicyEnforcement.Never);
		}
		ValidateCreateContext(package, isServer: true, credential, servicePrincipalName, _ExtendedProtectionPolicy.CustomChannelBinding, protectionLevel, impersonationLevel);
	}

	internal void ValidateCreateContext(string package, bool isServer, NetworkCredential credential, string servicePrincipalName, ChannelBinding channelBinding, ProtectionLevel protectionLevel, TokenImpersonationLevel impersonationLevel)
	{
		if (_Exception != null && !_CanRetryAuthentication)
		{
			throw _Exception;
		}
		if (_Context != null && _Context.IsValidContext)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_reauth"));
		}
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (servicePrincipalName == null)
		{
			throw new ArgumentNullException("servicePrincipalName");
		}
		if (impersonationLevel != TokenImpersonationLevel.Identification && impersonationLevel != TokenImpersonationLevel.Impersonation && impersonationLevel != TokenImpersonationLevel.Delegation)
		{
			throw new ArgumentOutOfRangeException("impersonationLevel", impersonationLevel.ToString(), SR.GetString("net_auth_supported_impl_levels"));
		}
		if (_Context != null && IsServer != isServer)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_client_server"));
		}
		_Exception = null;
		_RemoteOk = false;
		_Framer = new StreamFramer(_InnerStream);
		_Framer.WriteHeader.MessageId = 22;
		_ExpectedProtectionLevel = protectionLevel;
		_ExpectedImpersonationLevel = (isServer ? impersonationLevel : TokenImpersonationLevel.None);
		_WriteSequenceNumber = 0u;
		_ReadSequenceNumber = 0u;
		ContextFlags contextFlags = ContextFlags.Connection;
		if (protectionLevel == ProtectionLevel.None && !isServer)
		{
			package = "NTLM";
		}
		else
		{
			switch (protectionLevel)
			{
			case ProtectionLevel.EncryptAndSign:
				contextFlags |= ContextFlags.Confidentiality;
				break;
			case ProtectionLevel.Sign:
				contextFlags |= ContextFlags.ReplayDetect | ContextFlags.SequenceDetect | ContextFlags.AcceptStream;
				break;
			}
		}
		if (isServer)
		{
			if (_ExtendedProtectionPolicy.PolicyEnforcement == PolicyEnforcement.WhenSupported)
			{
				contextFlags |= ContextFlags.AllowMissingBindings;
			}
			if (_ExtendedProtectionPolicy.PolicyEnforcement != PolicyEnforcement.Never && _ExtendedProtectionPolicy.ProtectionScenario == ProtectionScenario.TrustedProxy)
			{
				contextFlags |= ContextFlags.ProxyBindings;
			}
		}
		else
		{
			if (protectionLevel != ProtectionLevel.None)
			{
				contextFlags |= ContextFlags.MutualAuth;
			}
			if (impersonationLevel == TokenImpersonationLevel.Identification)
			{
				contextFlags |= ContextFlags.AcceptIntegrity;
			}
			if (impersonationLevel == TokenImpersonationLevel.Delegation)
			{
				contextFlags |= ContextFlags.Delegate;
			}
		}
		_CanRetryAuthentication = false;
		if (!(credential is SystemNetworkCredential))
		{
			ExceptionHelper.ControlPrincipalPermission.Demand();
		}
		try
		{
			_Context = new NTAuthentication(isServer, package, credential, servicePrincipalName, contextFlags, channelBinding);
		}
		catch (Win32Exception innerException)
		{
			throw new AuthenticationException(SR.GetString("net_auth_SSPI"), innerException);
		}
	}

	private Exception SetException(Exception e)
	{
		if (_Exception == null || !(_Exception is ObjectDisposedException))
		{
			_Exception = e;
		}
		if (_Exception != null && _Context != null)
		{
			_Context.CloseContext();
		}
		return _Exception;
	}

	internal IIdentity GetIdentity()
	{
		CheckThrow(authSucessCheck: true);
		IIdentity identity = null;
		string name = (_Context.IsServer ? _Context.AssociatedName : _Context.Spn);
		string text = "NTLM";
		text = _Context.ProtocolName;
		if (_Context.IsServer)
		{
			SafeCloseHandle safeCloseHandle = null;
			try
			{
				safeCloseHandle = _Context.GetContextToken();
				string protocolName = _Context.ProtocolName;
				return new WindowsIdentity(safeCloseHandle.DangerousGetHandle(), protocolName, WindowsAccountType.Normal, isAuthenticated: true);
			}
			catch (SecurityException)
			{
			}
			finally
			{
				safeCloseHandle?.Close();
			}
		}
		return new GenericIdentity(name, text);
	}

	internal void CheckThrow(bool authSucessCheck)
	{
		if (_Exception != null)
		{
			throw _Exception;
		}
		if (authSucessCheck && !IsAuthenticated)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_noauth"));
		}
	}

	internal void Close()
	{
		_Exception = new ObjectDisposedException("NegotiateStream");
		if (_Context != null)
		{
			_Context.CloseContext();
		}
	}

	internal void ProcessAuthentication(LazyAsyncResult lazyResult)
	{
		CheckThrow(authSucessCheck: false);
		if (Interlocked.Exchange(ref _NestedAuth, 1) == 1)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidnestedcall", (lazyResult == null) ? "BeginAuthenticate" : "Authenticate", "authenticate"));
		}
		try
		{
			if (_Context.IsServer)
			{
				StartReceiveBlob(lazyResult);
			}
			else
			{
				StartSendBlob(null, lazyResult);
			}
		}
		catch (Exception exception)
		{
			Exception ex = SetException(exception);
			throw;
		}
		finally
		{
			if (lazyResult == null || _Exception != null)
			{
				_NestedAuth = 0;
			}
		}
	}

	internal void EndProcessAuthentication(IAsyncResult result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(result is LazyAsyncResult lazyAsyncResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", result.GetType().FullName), "asyncResult");
		}
		if (Interlocked.Exchange(ref _NestedAuth, 0) == 0)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndAuthenticate"));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		if (lazyAsyncResult.Result is Exception exception)
		{
			Exception ex = SetException(exception);
			throw ex;
		}
	}

	private bool CheckSpn()
	{
		if (_Context.IsKerberos)
		{
			return true;
		}
		if (_ExtendedProtectionPolicy.PolicyEnforcement == PolicyEnforcement.Never || _ExtendedProtectionPolicy.CustomServiceNames == null)
		{
			return true;
		}
		if (!AuthenticationManager.OSSupportsExtendedProtection)
		{
			return true;
		}
		string clientSpecifiedSpn = _Context.ClientSpecifiedSpn;
		if (string.IsNullOrEmpty(clientSpecifiedSpn))
		{
			if (_ExtendedProtectionPolicy.PolicyEnforcement == PolicyEnforcement.WhenSupported)
			{
				return true;
			}
			return false;
		}
		return _ExtendedProtectionPolicy.CustomServiceNames.Contains(clientSpecifiedSpn);
	}

	private void StartSendBlob(byte[] message, LazyAsyncResult lazyResult)
	{
		Win32Exception e = null;
		if (message != _EmptyMessage)
		{
			message = GetOutgoingBlob(message, ref e);
		}
		if (e != null)
		{
			StartSendAuthResetSignal(lazyResult, message, e);
			return;
		}
		if (HandshakeComplete)
		{
			if (_Context.IsServer && !CheckSpn())
			{
				Exception exception = new AuthenticationException(SR.GetString("net_auth_bad_client_creds_or_target_mismatch"));
				int num = 1790;
				message = new byte[8];
				for (int num2 = message.Length - 1; num2 >= 0; num2--)
				{
					message[num2] = (byte)(num & 0xFF);
					num >>>= 8;
				}
				StartSendAuthResetSignal(lazyResult, message, exception);
				return;
			}
			if (PrivateImpersonationLevel < _ExpectedImpersonationLevel)
			{
				Exception exception2 = new AuthenticationException(SR.GetString("net_auth_context_expectation", _ExpectedImpersonationLevel.ToString(), PrivateImpersonationLevel.ToString()));
				int num3 = 1790;
				message = new byte[8];
				for (int num4 = message.Length - 1; num4 >= 0; num4--)
				{
					message[num4] = (byte)(num3 & 0xFF);
					num3 >>>= 8;
				}
				StartSendAuthResetSignal(lazyResult, message, exception2);
				return;
			}
			ProtectionLevel protectionLevel = (_Context.IsConfidentialityFlag ? ProtectionLevel.EncryptAndSign : (_Context.IsIntegrityFlag ? ProtectionLevel.Sign : ProtectionLevel.None));
			if (protectionLevel < _ExpectedProtectionLevel)
			{
				Exception exception3 = new AuthenticationException(SR.GetString("net_auth_context_expectation", protectionLevel.ToString(), _ExpectedProtectionLevel.ToString()));
				int num5 = 1790;
				message = new byte[8];
				for (int num6 = message.Length - 1; num6 >= 0; num6--)
				{
					message[num6] = (byte)(num5 & 0xFF);
					num5 >>>= 8;
				}
				StartSendAuthResetSignal(lazyResult, message, exception3);
				return;
			}
			_Framer.WriteHeader.MessageId = 20;
			if (_Context.IsServer)
			{
				_RemoteOk = true;
				if (message == null)
				{
					message = _EmptyMessage;
				}
			}
		}
		else if (message == null || message == _EmptyMessage)
		{
			throw new InternalException();
		}
		if (message != null)
		{
			if (lazyResult == null)
			{
				_Framer.WriteMessage(message);
			}
			else
			{
				IAsyncResult asyncResult = _Framer.BeginWriteMessage(message, _WriteCallback, lazyResult);
				if (!asyncResult.CompletedSynchronously)
				{
					return;
				}
				_Framer.EndWriteMessage(asyncResult);
			}
		}
		CheckCompletionBeforeNextReceive(lazyResult);
	}

	private void CheckCompletionBeforeNextReceive(LazyAsyncResult lazyResult)
	{
		if (HandshakeComplete && _RemoteOk)
		{
			lazyResult?.InvokeCallback();
		}
		else
		{
			StartReceiveBlob(lazyResult);
		}
	}

	private void StartReceiveBlob(LazyAsyncResult lazyResult)
	{
		byte[] message;
		if (lazyResult == null)
		{
			message = _Framer.ReadMessage();
		}
		else
		{
			IAsyncResult asyncResult = _Framer.BeginReadMessage(_ReadCallback, lazyResult);
			if (!asyncResult.CompletedSynchronously)
			{
				return;
			}
			message = _Framer.EndReadMessage(asyncResult);
		}
		ProcessReceivedBlob(message, lazyResult);
	}

	private void ProcessReceivedBlob(byte[] message, LazyAsyncResult lazyResult)
	{
		if (message == null)
		{
			throw new AuthenticationException(SR.GetString("net_auth_eof"), null);
		}
		if (_Framer.ReadHeader.MessageId == 21)
		{
			Win32Exception ex = null;
			if (message.Length >= 8)
			{
				long num = 0L;
				for (int i = 0; i < 8; i++)
				{
					num = (num << 8) + message[i];
				}
				ex = new Win32Exception((int)num);
			}
			if (ex != null)
			{
				if (ex.NativeErrorCode == -2146893044)
				{
					throw new InvalidCredentialException(SR.GetString("net_auth_bad_client_creds"), ex);
				}
				if (ex.NativeErrorCode == 1790)
				{
					throw new AuthenticationException(SR.GetString("net_auth_context_expectation_remote"), ex);
				}
			}
			throw new AuthenticationException(SR.GetString("net_auth_alert"), ex);
		}
		if (_Framer.ReadHeader.MessageId == 20)
		{
			_RemoteOk = true;
		}
		else if (_Framer.ReadHeader.MessageId != 22)
		{
			throw new AuthenticationException(SR.GetString("net_io_header_id", "MessageId", _Framer.ReadHeader.MessageId, 22), null);
		}
		CheckCompletionBeforeNextSend(message, lazyResult);
	}

	private void CheckCompletionBeforeNextSend(byte[] message, LazyAsyncResult lazyResult)
	{
		if (HandshakeComplete)
		{
			if (!_RemoteOk)
			{
				throw new AuthenticationException(SR.GetString("net_io_header_id", "MessageId", _Framer.ReadHeader.MessageId, 20), null);
			}
			lazyResult?.InvokeCallback();
		}
		else
		{
			StartSendBlob(message, lazyResult);
		}
	}

	private void StartSendAuthResetSignal(LazyAsyncResult lazyResult, byte[] message, Exception exception)
	{
		_Framer.WriteHeader.MessageId = 21;
		if (exception is Win32Exception { NativeErrorCode: -2146893044 })
		{
			exception = ((!IsServer) ? new InvalidCredentialException(SR.GetString("net_auth_bad_client_creds_or_target_mismatch"), exception) : new InvalidCredentialException(SR.GetString("net_auth_bad_client_creds"), exception));
		}
		if (!(exception is AuthenticationException))
		{
			exception = new AuthenticationException(SR.GetString("net_auth_SSPI"), exception);
		}
		if (lazyResult == null)
		{
			_Framer.WriteMessage(message);
		}
		else
		{
			lazyResult.Result = exception;
			IAsyncResult asyncResult = _Framer.BeginWriteMessage(message, _WriteCallback, lazyResult);
			if (!asyncResult.CompletedSynchronously)
			{
				return;
			}
			_Framer.EndWriteMessage(asyncResult);
		}
		_CanRetryAuthentication = true;
		throw exception;
	}

	private static void WriteCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)transportResult.AsyncState;
		try
		{
			NegoState negoState = (NegoState)lazyAsyncResult.AsyncObject;
			negoState._Framer.EndWriteMessage(transportResult);
			if (lazyAsyncResult.Result is Exception)
			{
				negoState._CanRetryAuthentication = true;
				throw (Exception)lazyAsyncResult.Result;
			}
			negoState.CheckCompletionBeforeNextReceive(lazyAsyncResult);
		}
		catch (Exception result)
		{
			if (lazyAsyncResult.InternalPeekCompleted)
			{
				throw;
			}
			lazyAsyncResult.InvokeCallback(result);
		}
	}

	private static void ReadCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)transportResult.AsyncState;
		try
		{
			NegoState negoState = (NegoState)lazyAsyncResult.AsyncObject;
			byte[] message = negoState._Framer.EndReadMessage(transportResult);
			negoState.ProcessReceivedBlob(message, lazyAsyncResult);
		}
		catch (Exception result)
		{
			if (lazyAsyncResult.InternalPeekCompleted)
			{
				throw;
			}
			lazyAsyncResult.InvokeCallback(result);
		}
	}

	private byte[] GetOutgoingBlob(byte[] incomingBlob, ref Win32Exception e)
	{
		SecurityStatus statusCode;
		byte[] array = _Context.GetOutgoingBlob(incomingBlob, throwOnError: false, out statusCode);
		if ((statusCode & (SecurityStatus)(-2147483648)) != SecurityStatus.OK)
		{
			e = new Win32Exception((int)statusCode);
			array = new byte[8];
			for (int num = array.Length - 1; num >= 0; num--)
			{
				array[num] = (byte)(statusCode & (SecurityStatus)255);
				statusCode = (SecurityStatus)((uint)statusCode >> 8);
			}
		}
		if (array != null && array.Length == 0)
		{
			array = _EmptyMessage;
		}
		return array;
	}

	internal int EncryptData(byte[] buffer, int offset, int count, ref byte[] outBuffer)
	{
		CheckThrow(authSucessCheck: true);
		_WriteSequenceNumber++;
		return _Context.Encrypt(buffer, offset, count, ref outBuffer, _WriteSequenceNumber);
	}

	internal int DecryptData(byte[] buffer, int offset, int count, out int newOffset)
	{
		CheckThrow(authSucessCheck: true);
		_ReadSequenceNumber++;
		return _Context.Decrypt(buffer, offset, count, out newOffset, _ReadSequenceNumber);
	}
}
