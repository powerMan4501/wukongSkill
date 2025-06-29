using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net.Security;

internal class SslState
{
	private enum CachedSessionStatus : byte
	{
		Unknown,
		IsNotCached,
		IsCached,
		Renegotiated
	}

	private enum Framing
	{
		None,
		BeforeSSL3,
		SinceSSL3,
		Unified,
		Invalid
	}

	private enum FrameType : byte
	{
		ChangeCipherSpec = 20,
		Alert,
		Handshake,
		AppData
	}

	private static int UniqueNameInteger = 123;

	private static AsyncProtocolCallback _PartialFrameCallback = PartialFrameCallback;

	private static AsyncProtocolCallback _ReadFrameCallback = ReadFrameCallback;

	private static AsyncCallback _WriteCallback = WriteCallback;

	private RemoteCertValidationCallback _CertValidationDelegate;

	private LocalCertSelectionCallback _CertSelectionDelegate;

	private bool _CanRetryAuthentication;

	private Stream _InnerStream;

	private _SslStream _SecureStream;

	private FixedSizeReader _Reader;

	private int _NestedAuth;

	private SecureChannel _Context;

	private bool _HandshakeCompleted;

	private bool _CertValidationFailed;

	private bool _Shutdown;

	private SecurityStatus _SecurityStatus;

	private Exception _Exception;

	private CachedSessionStatus _CachedSession;

	private byte[] _QueuedReadData;

	private int _QueuedReadCount;

	private bool _PendingReHandshake;

	private const int _ConstMaxQueuedReadBytes = 131072;

	private const int LockNone = 0;

	private const int LockWrite = 1;

	private const int LockHandshake = 2;

	private const int LockPendingWrite = 3;

	private const int LockRead = 4;

	private const int LockPendingRead = 6;

	private int _LockWriteState;

	private object _QueuedWriteStateRequest;

	private int _LockReadState;

	private object _QueuedReadStateRequest;

	private bool _ForceBufferingLastHandshakePayload;

	private byte[] _LastPayload;

	private readonly EncryptionPolicy _EncryptionPolicy;

	private Framing _Framing;

	internal bool IsAuthenticated
	{
		get
		{
			if (_Context != null && _Context.IsValidContext && _Exception == null)
			{
				return HandshakeCompleted;
			}
			return false;
		}
	}

	internal bool IsMutuallyAuthenticated
	{
		get
		{
			if (IsAuthenticated && (Context.IsServer ? Context.LocalServerCertificate : Context.LocalClientCertificate) != null)
			{
				return Context.IsRemoteCertificateAvailable;
			}
			return false;
		}
	}

	internal bool RemoteCertRequired
	{
		get
		{
			if (Context != null)
			{
				return Context.RemoteCertRequired;
			}
			return true;
		}
	}

	internal bool IsServer
	{
		get
		{
			if (Context != null)
			{
				return Context.IsServer;
			}
			return false;
		}
	}

	internal X509Certificate LocalCertificate
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return InternalLocalCertificate;
		}
	}

	internal X509Certificate InternalLocalCertificate
	{
		get
		{
			if (!Context.IsServer)
			{
				return Context.LocalClientCertificate;
			}
			return Context.LocalServerCertificate;
		}
	}

	internal bool CheckCertRevocationStatus
	{
		get
		{
			if (Context != null)
			{
				return Context.CheckCertRevocationStatus;
			}
			return false;
		}
	}

	internal SecurityStatus LastSecurityStatus => _SecurityStatus;

	internal bool IsCertValidationFailed => _CertValidationFailed;

	internal bool IsShutdown => _Shutdown;

	internal bool DataAvailable
	{
		get
		{
			if (IsAuthenticated)
			{
				if (!SecureStream.DataAvailable)
				{
					return _QueuedReadCount != 0;
				}
				return true;
			}
			return false;
		}
	}

	internal CipherAlgorithmType CipherAlgorithm
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return (CipherAlgorithmType)(Context.ConnectionInfo?.DataCipherAlg ?? 0);
		}
	}

	internal int CipherStrength
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return Context.ConnectionInfo?.DataKeySize ?? 0;
		}
	}

	internal HashAlgorithmType HashAlgorithm
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return (HashAlgorithmType)(Context.ConnectionInfo?.DataHashAlg ?? 0);
		}
	}

	internal int HashStrength
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return Context.ConnectionInfo?.DataHashKeySize ?? 0;
		}
	}

	internal ExchangeAlgorithmType KeyExchangeAlgorithm
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return (ExchangeAlgorithmType)(Context.ConnectionInfo?.KeyExchangeAlg ?? 0);
		}
	}

	internal int KeyExchangeStrength
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			return Context.ConnectionInfo?.KeyExchKeySize ?? 0;
		}
	}

	internal SslProtocols SslProtocol
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			SslConnectionInfo connectionInfo = Context.ConnectionInfo;
			if (connectionInfo == null)
			{
				return SslProtocols.None;
			}
			SslProtocols sslProtocols = (SslProtocols)connectionInfo.Protocol;
			if ((sslProtocols & SslProtocols.Ssl2) != SslProtocols.None)
			{
				sslProtocols |= SslProtocols.Ssl2;
			}
			if ((sslProtocols & SslProtocols.Ssl3) != SslProtocols.None)
			{
				sslProtocols |= SslProtocols.Ssl3;
			}
			if ((sslProtocols & SslProtocols.Tls) != SslProtocols.None)
			{
				sslProtocols |= SslProtocols.Tls;
			}
			if ((sslProtocols & SslProtocols.Tls11) != SslProtocols.None)
			{
				sslProtocols |= SslProtocols.Tls11;
			}
			if ((sslProtocols & SslProtocols.Tls12) != SslProtocols.None)
			{
				sslProtocols |= SslProtocols.Tls12;
			}
			if ((sslProtocols & SslProtocols.Tls13) != SslProtocols.None)
			{
				sslProtocols |= SslProtocols.Tls13;
			}
			return sslProtocols;
		}
	}

	internal Stream InnerStream => _InnerStream;

	internal _SslStream SecureStream
	{
		get
		{
			CheckThrow(authSuccessCheck: true);
			if (_SecureStream == null)
			{
				Interlocked.CompareExchange(ref _SecureStream, new _SslStream(this), null);
			}
			return _SecureStream;
		}
	}

	internal int HeaderSize => Context.HeaderSize;

	internal int MaxDataSize => Context.MaxDataSize;

	internal byte[] LastPayload => _LastPayload;

	private bool HandshakeCompleted => _HandshakeCompleted;

	private SecureChannel Context => _Context;

	internal SslState(Stream innerStream, bool isHTTP, EncryptionPolicy encryptionPolicy)
		: this(innerStream, null, null, encryptionPolicy)
	{
		_ForceBufferingLastHandshakePayload = isHTTP;
	}

	internal SslState(Stream innerStream, RemoteCertValidationCallback certValidationCallback, LocalCertSelectionCallback certSelectionCallback, EncryptionPolicy encryptionPolicy)
	{
		_InnerStream = innerStream;
		_Reader = new FixedSizeReader(innerStream);
		_CertValidationDelegate = certValidationCallback;
		_CertSelectionDelegate = certSelectionCallback;
		_EncryptionPolicy = encryptionPolicy;
	}

	internal void ValidateCreateContext(bool isServer, string targetHost, SslProtocols enabledSslProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool remoteCertRequired, bool checkCertRevocationStatus)
	{
		ValidateCreateContext(isServer, targetHost, enabledSslProtocols, serverCertificate, clientCertificates, remoteCertRequired, checkCertRevocationStatus, !isServer);
	}

	internal void ValidateCreateContext(bool isServer, string targetHost, SslProtocols enabledSslProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool remoteCertRequired, bool checkCertRevocationStatus, bool checkCertName)
	{
		if (_Exception != null && !_CanRetryAuthentication)
		{
			throw _Exception;
		}
		if (Context != null && Context.IsValidContext)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_reauth"));
		}
		if (Context != null && IsServer != isServer)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_client_server"));
		}
		if (targetHost == null)
		{
			throw new ArgumentNullException("targetHost");
		}
		if (isServer)
		{
			enabledSslProtocols &= (SslProtocols)1073747285;
			if (serverCertificate == null)
			{
				throw new ArgumentNullException("serverCertificate");
			}
		}
		else
		{
			enabledSslProtocols &= (SslProtocols)(-2147472726);
		}
		if (ServicePointManager.DisableSystemDefaultTlsVersions && enabledSslProtocols == SslProtocols.None)
		{
			throw new ArgumentException(SR.GetString("net_invalid_enum", "SslProtocolType"), "sslProtocolType");
		}
		if (clientCertificates == null)
		{
			clientCertificates = new X509CertificateCollection();
		}
		if (targetHost.Length == 0)
		{
			targetHost = "?" + Interlocked.Increment(ref UniqueNameInteger).ToString(NumberFormatInfo.InvariantInfo);
		}
		_Exception = null;
		try
		{
			_Context = new SecureChannel(targetHost, isServer, (SchProtocols)enabledSslProtocols, serverCertificate, clientCertificates, remoteCertRequired, checkCertName, checkCertRevocationStatus, _EncryptionPolicy, _CertSelectionDelegate);
		}
		catch (Win32Exception innerException)
		{
			throw new AuthenticationException(SR.GetString("net_auth_SSPI"), innerException);
		}
	}

	internal void SetCertValidationDelegate(RemoteCertValidationCallback certValidationCallback)
	{
		_CertValidationDelegate = certValidationCallback;
	}

	internal ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		if (Context != null)
		{
			return Context.GetChannelBinding(kind);
		}
		return null;
	}

	internal void LastPayloadConsumed()
	{
		_LastPayload = null;
	}

	private Exception SetException(Exception e)
	{
		if (_Exception == null)
		{
			_Exception = e;
		}
		if (_Exception != null && Context != null)
		{
			Context.Close();
		}
		return _Exception;
	}

	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
	{
		if (_Exception != null)
		{
			throw _Exception;
		}
		if (authSuccessCheck && !IsAuthenticated)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_noauth"));
		}
		if (shutdownCheck && _Shutdown && !System.LocalAppContextSwitches.DontEnableTlsAlerts)
		{
			throw new InvalidOperationException("net_ssl_io_already_shutdown");
		}
	}

	internal void Flush()
	{
		InnerStream.Flush();
	}

	internal void Close()
	{
		_Exception = new ObjectDisposedException("SslStream");
		if (Context != null)
		{
			Context.Close();
		}
	}

	internal SecurityStatus EncryptData(byte[] buffer, int offset, int count, ref byte[] outBuffer, out int outSize)
	{
		CheckThrow(authSuccessCheck: true);
		return Context.Encrypt(buffer, offset, count, ref outBuffer, out outSize);
	}

	internal SecurityStatus DecryptData(byte[] buffer, ref int offset, ref int count)
	{
		CheckThrow(authSuccessCheck: true);
		return PrivateDecryptData(buffer, ref offset, ref count);
	}

	private SecurityStatus PrivateDecryptData(byte[] buffer, ref int offset, ref int count)
	{
		return Context.Decrypt(buffer, ref offset, ref count);
	}

	private Exception EnqueueOldKeyDecryptedData(byte[] buffer, int offset, int count)
	{
		lock (this)
		{
			if (_QueuedReadCount + count > 131072)
			{
				return new IOException(SR.GetString("net_auth_ignored_reauth", 131072.ToString(NumberFormatInfo.CurrentInfo)));
			}
			if (count != 0)
			{
				_QueuedReadData = EnsureBufferSize(_QueuedReadData, _QueuedReadCount, _QueuedReadCount + count);
				Buffer.BlockCopy(buffer, offset, _QueuedReadData, _QueuedReadCount, count);
				_QueuedReadCount += count;
				FinishHandshakeRead(2);
			}
		}
		return null;
	}

	internal int CheckOldKeyDecryptedData(byte[] buffer, int offset, int count)
	{
		CheckThrow(authSuccessCheck: true);
		if (_QueuedReadData != null)
		{
			int num = Math.Min(_QueuedReadCount, count);
			Buffer.BlockCopy(_QueuedReadData, 0, buffer, offset, num);
			_QueuedReadCount -= num;
			if (_QueuedReadCount == 0)
			{
				_QueuedReadData = null;
			}
			else
			{
				Buffer.BlockCopy(_QueuedReadData, num, _QueuedReadData, 0, _QueuedReadCount);
			}
			return num;
		}
		return -1;
	}

	internal void ProcessAuthentication(LazyAsyncResult lazyResult)
	{
		if (Interlocked.Exchange(ref _NestedAuth, 1) == 1)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidnestedcall", (lazyResult == null) ? "BeginAuthenticate" : "Authenticate", "authenticate"));
		}
		try
		{
			CheckThrow(authSuccessCheck: false);
			AsyncProtocolRequest asyncProtocolRequest = null;
			if (lazyResult != null)
			{
				asyncProtocolRequest = new AsyncProtocolRequest(lazyResult);
				asyncProtocolRequest.Buffer = null;
			}
			_CachedSession = CachedSessionStatus.Unknown;
			ForceAuthentication(Context.IsServer, null, asyncProtocolRequest);
			if (lazyResult == null && Logging.On)
			{
				Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_selected_cipher_suite", "ProcessAuthentication", SslProtocol, CipherAlgorithm, CipherStrength, HashAlgorithm, HashStrength, KeyExchangeAlgorithm, KeyExchangeStrength));
			}
		}
		catch (Exception)
		{
			_NestedAuth = 0;
			throw;
		}
		finally
		{
			if (lazyResult == null)
			{
				_NestedAuth = 0;
			}
		}
	}

	internal void ReplyOnReAuthentication(byte[] buffer)
	{
		lock (this)
		{
			_LockReadState = 2;
			if (_PendingReHandshake)
			{
				FinishRead(buffer);
				return;
			}
		}
		AsyncProtocolRequest asyncProtocolRequest = new AsyncProtocolRequest(new LazyAsyncResult(this, null, RehandshakeCompleteCallback));
		asyncProtocolRequest.Buffer = buffer;
		ForceAuthentication(receiveFirst: false, buffer, asyncProtocolRequest, renegotiation: true);
	}

	private void ForceAuthentication(bool receiveFirst, byte[] buffer, AsyncProtocolRequest asyncRequest, bool renegotiation = false)
	{
		if (CheckEnqueueHandshake(buffer, asyncRequest))
		{
			return;
		}
		SslConnectionInfo connectionInfo = Context.ConnectionInfo;
		if (connectionInfo == null || (connectionInfo.Protocol & 0x3000) == 0)
		{
			_Framing = Framing.None;
		}
		try
		{
			if (receiveFirst)
			{
				StartReceiveBlob(buffer, asyncRequest);
			}
			else
			{
				StartSendBlob(buffer, (buffer != null) ? buffer.Length : 0, asyncRequest, renegotiation);
			}
		}
		catch (Exception ex)
		{
			_Framing = Framing.None;
			_HandshakeCompleted = false;
			if (SetException(ex) == ex)
			{
				throw;
			}
			throw _Exception;
		}
		finally
		{
			if (_Exception != null)
			{
				FinishHandshake(null, null);
			}
		}
	}

	internal void EndProcessAuthentication(IAsyncResult result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(result is LazyAsyncResult lazyResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", result.GetType().FullName), "asyncResult");
		}
		if (Interlocked.Exchange(ref _NestedAuth, 0) == 0)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndAuthenticate"));
		}
		InternalEndProcessAuthentication(lazyResult);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_selected_cipher_suite", "EndProcessAuthentication", SslProtocol, CipherAlgorithm, CipherStrength, HashAlgorithm, HashStrength, KeyExchangeAlgorithm, KeyExchangeStrength));
		}
	}

	internal void InternalEndProcessAuthentication(LazyAsyncResult lazyResult)
	{
		lazyResult.InternalWaitForCompletion();
		if (lazyResult.Result is Exception exception)
		{
			_Framing = Framing.None;
			_HandshakeCompleted = false;
			throw SetException(exception);
		}
	}

	private void StartSendBlob(byte[] incoming, int count, AsyncProtocolRequest asyncRequest, bool renegotiation = false)
	{
		ProtocolToken protocolToken = Context.NextMessage(incoming, 0, count);
		_SecurityStatus = protocolToken.Status;
		if (protocolToken.Size != 0)
		{
			if (Context.IsServer && _CachedSession == CachedSessionStatus.Unknown)
			{
				_CachedSession = ((protocolToken.Size >= 200) ? CachedSessionStatus.IsNotCached : CachedSessionStatus.IsCached);
			}
			if (_Framing == Framing.Unified)
			{
				_Framing = DetectFraming(protocolToken.Payload, protocolToken.Payload.Length);
			}
			SslConnectionInfo connectionInfo = Context.ConnectionInfo;
			bool flag = renegotiation && !Context.IsServer && connectionInfo != null && (connectionInfo.Protocol & 0x3000) != 0;
			if (protocolToken.Done && _ForceBufferingLastHandshakePayload && InnerStream.GetType() == typeof(NetworkStream) && !_PendingReHandshake && !flag)
			{
				_LastPayload = protocolToken.Payload;
			}
			else if (asyncRequest == null)
			{
				InnerStream.Write(protocolToken.Payload, 0, protocolToken.Size);
			}
			else
			{
				asyncRequest.AsyncState = protocolToken;
				IAsyncResult asyncResult = InnerStream.BeginWrite(protocolToken.Payload, 0, protocolToken.Size, _WriteCallback, asyncRequest);
				if (!asyncResult.CompletedSynchronously)
				{
					return;
				}
				InnerStream.EndWrite(asyncResult);
			}
		}
		CheckCompletionBeforeNextReceive(protocolToken, asyncRequest);
	}

	private void CheckCompletionBeforeNextReceive(ProtocolToken message, AsyncProtocolRequest asyncRequest)
	{
		if (message.Failed)
		{
			StartSendAuthResetSignal(null, asyncRequest, new AuthenticationException(SR.GetString("net_auth_SSPI"), message.GetException()));
		}
		else if (message.Done && !_PendingReHandshake)
		{
			ProtocolToken alertToken = null;
			if (!CompleteHandshake(ref alertToken))
			{
				StartSendAuthResetSignal(alertToken, asyncRequest, new AuthenticationException(SR.GetString("net_ssl_io_cert_validation"), null));
			}
			else
			{
				FinishHandshake(null, asyncRequest);
			}
		}
		else
		{
			StartReceiveBlob(message.Payload, asyncRequest);
		}
	}

	private void StartReceiveBlob(byte[] buffer, AsyncProtocolRequest asyncRequest)
	{
		if (_PendingReHandshake)
		{
			if (CheckEnqueueHandshakeRead(ref buffer, asyncRequest))
			{
				return;
			}
			if (!_PendingReHandshake)
			{
				ProcessReceivedBlob(buffer, buffer.Length, asyncRequest);
				return;
			}
		}
		buffer = EnsureBufferSize(buffer, 0, 5);
		int num = 0;
		if (asyncRequest == null)
		{
			num = _Reader.ReadPacket(buffer, 0, 5);
		}
		else
		{
			asyncRequest.SetNextRequest(buffer, 0, 5, _PartialFrameCallback);
			_Reader.AsyncReadPacket(asyncRequest);
			if (!asyncRequest.MustCompleteSynchronously)
			{
				return;
			}
			num = asyncRequest.Result;
		}
		StartReadFrame(buffer, num, asyncRequest);
	}

	private void StartReadFrame(byte[] buffer, int readBytes, AsyncProtocolRequest asyncRequest)
	{
		if (readBytes == 0)
		{
			throw new IOException(SR.GetString("net_auth_eof"));
		}
		if (_Framing == Framing.None)
		{
			_Framing = DetectFraming(buffer, readBytes);
		}
		int remainingFrameSize = GetRemainingFrameSize(buffer, readBytes);
		if (remainingFrameSize < 0)
		{
			throw new IOException(SR.GetString("net_ssl_io_frame"));
		}
		if (remainingFrameSize == 0)
		{
			throw new AuthenticationException(SR.GetString("net_auth_eof"), null);
		}
		buffer = EnsureBufferSize(buffer, readBytes, readBytes + remainingFrameSize);
		if (asyncRequest == null)
		{
			remainingFrameSize = _Reader.ReadPacket(buffer, readBytes, remainingFrameSize);
		}
		else
		{
			asyncRequest.SetNextRequest(buffer, readBytes, remainingFrameSize, _ReadFrameCallback);
			_Reader.AsyncReadPacket(asyncRequest);
			if (!asyncRequest.MustCompleteSynchronously)
			{
				return;
			}
			remainingFrameSize = asyncRequest.Result;
			if (remainingFrameSize == 0)
			{
				readBytes = 0;
			}
		}
		ProcessReceivedBlob(buffer, readBytes + remainingFrameSize, asyncRequest);
	}

	private void ProcessReceivedBlob(byte[] buffer, int count, AsyncProtocolRequest asyncRequest)
	{
		if (count == 0)
		{
			throw new AuthenticationException(SR.GetString("net_auth_eof"), null);
		}
		if (_PendingReHandshake)
		{
			int offset = 0;
			SecurityStatus securityStatus = PrivateDecryptData(buffer, ref offset, ref count);
			switch (securityStatus)
			{
			case SecurityStatus.OK:
			{
				Exception ex = EnqueueOldKeyDecryptedData(buffer, offset, count);
				if (ex != null)
				{
					StartSendAuthResetSignal(null, asyncRequest, ex);
					return;
				}
				_Framing = Framing.None;
				StartReceiveBlob(buffer, asyncRequest);
				return;
			}
			default:
			{
				ProtocolToken protocolToken = new ProtocolToken(null, securityStatus);
				StartSendAuthResetSignal(null, asyncRequest, new AuthenticationException(SR.GetString("net_auth_SSPI"), protocolToken.GetException()));
				return;
			}
			case SecurityStatus.Renegotiate:
				break;
			}
			_PendingReHandshake = false;
			if (offset != 0)
			{
				Buffer.BlockCopy(buffer, offset, buffer, 0, count);
			}
		}
		StartSendBlob(buffer, count, asyncRequest);
	}

	private void StartSendAuthResetSignal(ProtocolToken message, AsyncProtocolRequest asyncRequest, Exception exception)
	{
		if (message == null || message.Size == 0)
		{
			throw exception;
		}
		if (asyncRequest == null)
		{
			InnerStream.Write(message.Payload, 0, message.Size);
		}
		else
		{
			asyncRequest.AsyncState = exception;
			IAsyncResult asyncResult = InnerStream.BeginWrite(message.Payload, 0, message.Size, _WriteCallback, asyncRequest);
			if (!asyncResult.CompletedSynchronously)
			{
				return;
			}
			InnerStream.EndWrite(asyncResult);
		}
		throw exception;
	}

	private bool CompleteHandshake(ref ProtocolToken alertToken)
	{
		Context.ProcessHandshakeSuccess();
		if (!Context.VerifyRemoteCertificate(_CertValidationDelegate, ref alertToken))
		{
			_HandshakeCompleted = false;
			_CertValidationFailed = true;
			return false;
		}
		_CertValidationFailed = false;
		_HandshakeCompleted = true;
		return true;
	}

	private static void WriteCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		AsyncProtocolRequest asyncProtocolRequest = (AsyncProtocolRequest)transportResult.AsyncState;
		SslState sslState = (SslState)asyncProtocolRequest.AsyncObject;
		try
		{
			sslState.InnerStream.EndWrite(transportResult);
			object asyncState = asyncProtocolRequest.AsyncState;
			if (asyncState is Exception ex)
			{
				throw ex;
			}
			sslState.CheckCompletionBeforeNextReceive((ProtocolToken)asyncState, asyncProtocolRequest);
		}
		catch (Exception e)
		{
			if (asyncProtocolRequest.IsUserCompleted)
			{
				throw;
			}
			sslState.FinishHandshake(e, asyncProtocolRequest);
		}
	}

	private static void PartialFrameCallback(AsyncProtocolRequest asyncRequest)
	{
		SslState sslState = (SslState)asyncRequest.AsyncObject;
		try
		{
			sslState.StartReadFrame(asyncRequest.Buffer, asyncRequest.Result, asyncRequest);
		}
		catch (Exception e)
		{
			if (asyncRequest.IsUserCompleted)
			{
				throw;
			}
			sslState.FinishHandshake(e, asyncRequest);
		}
	}

	private static void ReadFrameCallback(AsyncProtocolRequest asyncRequest)
	{
		SslState sslState = (SslState)asyncRequest.AsyncObject;
		try
		{
			if (asyncRequest.Result == 0)
			{
				asyncRequest.Offset = 0;
			}
			sslState.ProcessReceivedBlob(asyncRequest.Buffer, asyncRequest.Offset + asyncRequest.Result, asyncRequest);
		}
		catch (Exception e)
		{
			if (asyncRequest.IsUserCompleted)
			{
				throw;
			}
			sslState.FinishHandshake(e, asyncRequest);
		}
	}

	private bool CheckEnqueueHandshakeRead(ref byte[] buffer, AsyncProtocolRequest request)
	{
		LazyAsyncResult lazyAsyncResult = null;
		lock (this)
		{
			if (_LockReadState == 6)
			{
				return false;
			}
			int num = Interlocked.Exchange(ref _LockReadState, 2);
			if (num != 4)
			{
				return false;
			}
			if (request != null)
			{
				_QueuedReadStateRequest = request;
				return true;
			}
			lazyAsyncResult = (LazyAsyncResult)(_QueuedReadStateRequest = new LazyAsyncResult(null, null, null));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		buffer = (byte[])lazyAsyncResult.Result;
		return false;
	}

	private void FinishHandshakeRead(int newState)
	{
		lock (this)
		{
			int num = Interlocked.Exchange(ref _LockReadState, newState);
			if (num != 6)
			{
				return;
			}
			_LockReadState = 4;
			object queuedReadStateRequest = _QueuedReadStateRequest;
			if (queuedReadStateRequest != null)
			{
				_QueuedReadStateRequest = null;
				if (queuedReadStateRequest is LazyAsyncResult)
				{
					((LazyAsyncResult)queuedReadStateRequest).InvokeCallback();
				}
				else
				{
					ThreadPool.QueueUserWorkItem(CompleteRequestWaitCallback, queuedReadStateRequest);
				}
			}
		}
	}

	internal int CheckEnqueueRead(byte[] buffer, int offset, int count, AsyncProtocolRequest request)
	{
		int num = Interlocked.CompareExchange(ref _LockReadState, 4, 0);
		if (num != 2)
		{
			return CheckOldKeyDecryptedData(buffer, offset, count);
		}
		LazyAsyncResult lazyAsyncResult = null;
		lock (this)
		{
			int num2 = CheckOldKeyDecryptedData(buffer, offset, count);
			if (num2 != -1)
			{
				return num2;
			}
			if (_LockReadState != 2)
			{
				_LockReadState = 4;
				return -1;
			}
			_LockReadState = 6;
			if (request != null)
			{
				_QueuedReadStateRequest = request;
				return 0;
			}
			lazyAsyncResult = (LazyAsyncResult)(_QueuedReadStateRequest = new LazyAsyncResult(null, null, null));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		lock (this)
		{
			return CheckOldKeyDecryptedData(buffer, offset, count);
		}
	}

	internal void FinishRead(byte[] renegotiateBuffer)
	{
		int num = Interlocked.CompareExchange(ref _LockReadState, 0, 4);
		if (num != 2)
		{
			return;
		}
		lock (this)
		{
			if (_QueuedReadStateRequest is LazyAsyncResult lazyAsyncResult)
			{
				_QueuedReadStateRequest = null;
				lazyAsyncResult.InvokeCallback(renegotiateBuffer);
				return;
			}
			AsyncProtocolRequest asyncProtocolRequest = (AsyncProtocolRequest)_QueuedReadStateRequest;
			asyncProtocolRequest.Buffer = renegotiateBuffer;
			_QueuedReadStateRequest = null;
			ThreadPool.QueueUserWorkItem(AsyncResumeHandshakeRead, asyncProtocolRequest);
		}
	}

	internal bool CheckEnqueueWrite(AsyncProtocolRequest asyncRequest)
	{
		_QueuedWriteStateRequest = null;
		int num = Interlocked.CompareExchange(ref _LockWriteState, 1, 0);
		if (num != 2)
		{
			return false;
		}
		LazyAsyncResult lazyAsyncResult = null;
		lock (this)
		{
			if (_LockWriteState != 2)
			{
				CheckThrow(authSuccessCheck: true);
				return false;
			}
			_LockWriteState = 3;
			if (asyncRequest != null)
			{
				_QueuedWriteStateRequest = asyncRequest;
				return true;
			}
			lazyAsyncResult = (LazyAsyncResult)(_QueuedWriteStateRequest = new LazyAsyncResult(null, null, null));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		CheckThrow(authSuccessCheck: true);
		return false;
	}

	internal void FinishWrite()
	{
		int num = Interlocked.CompareExchange(ref _LockWriteState, 0, 1);
		if (num != 2)
		{
			return;
		}
		lock (this)
		{
			object queuedWriteStateRequest = _QueuedWriteStateRequest;
			if (queuedWriteStateRequest != null)
			{
				_QueuedWriteStateRequest = null;
				if (queuedWriteStateRequest is LazyAsyncResult)
				{
					((LazyAsyncResult)queuedWriteStateRequest).InvokeCallback();
				}
				else
				{
					ThreadPool.QueueUserWorkItem(AsyncResumeHandshake, queuedWriteStateRequest);
				}
			}
		}
	}

	internal IAsyncResult BeginShutdown(AsyncCallback asyncCallback, object asyncState)
	{
		CheckThrow(authSuccessCheck: true, shutdownCheck: true);
		ProtocolToken protocolToken = Context.CreateShutdownToken();
		return InnerStream.BeginWrite(protocolToken.Payload, 0, protocolToken.Payload.Length, asyncCallback, asyncState);
	}

	internal void EndShutdown(IAsyncResult result)
	{
		CheckThrow(authSuccessCheck: true, shutdownCheck: true);
		InnerStream.EndWrite(result);
		_Shutdown = true;
	}

	private bool CheckEnqueueHandshake(byte[] buffer, AsyncProtocolRequest asyncRequest)
	{
		LazyAsyncResult lazyAsyncResult = null;
		lock (this)
		{
			if (_LockWriteState == 3)
			{
				return false;
			}
			int num = Interlocked.Exchange(ref _LockWriteState, 2);
			if (num != 1)
			{
				return false;
			}
			if (asyncRequest != null)
			{
				asyncRequest.Buffer = buffer;
				_QueuedWriteStateRequest = asyncRequest;
				return true;
			}
			lazyAsyncResult = (LazyAsyncResult)(_QueuedWriteStateRequest = new LazyAsyncResult(null, null, null));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		return false;
	}

	private void FinishHandshake(Exception e, AsyncProtocolRequest asyncRequest)
	{
		try
		{
			lock (this)
			{
				if (e != null)
				{
					SetException(e);
				}
				FinishHandshakeRead(0);
				int num = Interlocked.CompareExchange(ref _LockWriteState, 0, 2);
				if (num != 3)
				{
					return;
				}
				_LockWriteState = 1;
				object queuedWriteStateRequest = _QueuedWriteStateRequest;
				if (queuedWriteStateRequest != null)
				{
					_QueuedWriteStateRequest = null;
					if (queuedWriteStateRequest is LazyAsyncResult)
					{
						((LazyAsyncResult)queuedWriteStateRequest).InvokeCallback();
					}
					else
					{
						ThreadPool.QueueUserWorkItem(CompleteRequestWaitCallback, queuedWriteStateRequest);
					}
				}
			}
		}
		finally
		{
			if (asyncRequest != null)
			{
				if (e != null)
				{
					asyncRequest.CompleteWithError(e);
				}
				else
				{
					asyncRequest.CompleteUser();
				}
			}
		}
	}

	private static byte[] EnsureBufferSize(byte[] buffer, int copyCount, int size)
	{
		if (buffer == null || buffer.Length < size)
		{
			byte[] array = buffer;
			buffer = new byte[size];
			if (array != null && copyCount != 0)
			{
				Buffer.BlockCopy(array, 0, buffer, 0, copyCount);
			}
		}
		return buffer;
	}

	private Framing DetectFraming(byte[] bytes, int length)
	{
		int num = -1;
		if (bytes[0] == 22 || bytes[0] == 23 || bytes[0] == 21)
		{
			if (length < 3)
			{
				return Framing.Invalid;
			}
			num = (bytes[1] << 8) | bytes[2];
			if (num < 768 || num >= 1280)
			{
				return Framing.Invalid;
			}
			return Framing.SinceSSL3;
		}
		if (length < 3)
		{
			return Framing.Invalid;
		}
		if (bytes[2] > 8)
		{
			return Framing.Invalid;
		}
		if (bytes[2] == 1)
		{
			if (length >= 5)
			{
				num = (bytes[3] << 8) | bytes[4];
			}
		}
		else if (bytes[2] == 4 && length >= 7)
		{
			num = (bytes[5] << 8) | bytes[6];
		}
		if (num != -1)
		{
			if (_Framing == Framing.None)
			{
				if (num != 2 && (num < 512 || num >= 1280))
				{
					return Framing.Invalid;
				}
			}
			else if (num != 2)
			{
				return Framing.Invalid;
			}
		}
		if (!Context.IsServer || _Framing == Framing.Unified)
		{
			return Framing.BeforeSSL3;
		}
		return Framing.Unified;
	}

	internal int GetRemainingFrameSize(byte[] buffer, int dataSize)
	{
		int result = -1;
		switch (_Framing)
		{
		case Framing.BeforeSSL3:
		case Framing.Unified:
			if (dataSize < 2)
			{
				throw new IOException(SR.GetString("net_ssl_io_frame"));
			}
			if ((buffer[0] & 0x80) != 0)
			{
				result = (((buffer[0] & 0x7F) << 8) | buffer[1]) + 2;
				result -= dataSize;
			}
			else
			{
				result = (((buffer[0] & 0x3F) << 8) | buffer[1]) + 3;
				result -= dataSize;
			}
			break;
		case Framing.SinceSSL3:
			if (dataSize < 5)
			{
				throw new IOException(SR.GetString("net_ssl_io_frame"));
			}
			result = ((buffer[3] << 8) | buffer[4]) + 5;
			result -= dataSize;
			break;
		}
		return result;
	}

	private void AsyncResumeHandshake(object state)
	{
		AsyncProtocolRequest asyncProtocolRequest = state as AsyncProtocolRequest;
		try
		{
			ForceAuthentication(Context.IsServer, asyncProtocolRequest.Buffer, asyncProtocolRequest);
		}
		catch (Exception e)
		{
			asyncProtocolRequest.CompleteWithError(e);
		}
	}

	private void AsyncResumeHandshakeRead(object state)
	{
		AsyncProtocolRequest asyncProtocolRequest = (AsyncProtocolRequest)state;
		try
		{
			if (_PendingReHandshake)
			{
				StartReceiveBlob(asyncProtocolRequest.Buffer, asyncProtocolRequest);
			}
			else
			{
				ProcessReceivedBlob(asyncProtocolRequest.Buffer, (asyncProtocolRequest.Buffer != null) ? asyncProtocolRequest.Buffer.Length : 0, asyncProtocolRequest);
			}
		}
		catch (Exception e)
		{
			if (asyncProtocolRequest.IsUserCompleted)
			{
				throw;
			}
			FinishHandshake(e, asyncProtocolRequest);
		}
	}

	private void CompleteRequestWaitCallback(object state)
	{
		AsyncProtocolRequest asyncProtocolRequest = (AsyncProtocolRequest)state;
		if (asyncProtocolRequest.MustCompleteSynchronously)
		{
			throw new InternalException();
		}
		asyncProtocolRequest.CompleteRequest(0);
	}

	private void RehandshakeCompleteCallback(IAsyncResult result)
	{
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)result;
		if (lazyAsyncResult.InternalWaitForCompletion() is Exception e)
		{
			FinishHandshake(e, null);
		}
	}
}
