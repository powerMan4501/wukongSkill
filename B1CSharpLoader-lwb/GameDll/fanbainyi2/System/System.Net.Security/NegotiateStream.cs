using System.IO;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Security;

public class NegotiateStream : AuthenticatedStream
{
	private NegoState _NegoState;

	private string _Package;

	private IIdentity _RemoteIdentity;

	private static AsyncCallback _WriteCallback = WriteCallback;

	private static AsyncProtocolCallback _ReadCallback = ReadCallback;

	private int _NestedWrite;

	private int _NestedRead;

	private byte[] _ReadHeader;

	private byte[] _InternalBuffer;

	private int _InternalOffset;

	private int _InternalBufferCount;

	private FixedSizeReader _FrameReader;

	public override bool IsAuthenticated => _NegoState.IsAuthenticated;

	public override bool IsMutuallyAuthenticated => _NegoState.IsMutuallyAuthenticated;

	public override bool IsEncrypted => _NegoState.IsEncrypted;

	public override bool IsSigned => _NegoState.IsSigned;

	public override bool IsServer => _NegoState.IsServer;

	public virtual TokenImpersonationLevel ImpersonationLevel => _NegoState.AllowedImpersonation;

	public virtual IIdentity RemoteIdentity
	{
		get
		{
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
			if (_RemoteIdentity == null)
			{
				_RemoteIdentity = _NegoState.GetIdentity();
			}
			return _RemoteIdentity;
		}
	}

	public override bool CanSeek => false;

	public override bool CanRead
	{
		get
		{
			if (IsAuthenticated)
			{
				return base.InnerStream.CanRead;
			}
			return false;
		}
	}

	public override bool CanTimeout => base.InnerStream.CanTimeout;

	public override bool CanWrite
	{
		get
		{
			if (IsAuthenticated)
			{
				return base.InnerStream.CanWrite;
			}
			return false;
		}
	}

	public override int ReadTimeout
	{
		get
		{
			return base.InnerStream.ReadTimeout;
		}
		set
		{
			base.InnerStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return base.InnerStream.WriteTimeout;
		}
		set
		{
			base.InnerStream.WriteTimeout = value;
		}
	}

	public override long Length => base.InnerStream.Length;

	public override long Position
	{
		get
		{
			return base.InnerStream.Position;
		}
		set
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
	}

	private byte[] InternalBuffer => _InternalBuffer;

	private int InternalOffset => _InternalOffset;

	private int InternalBufferCount => _InternalBufferCount;

	public NegotiateStream(Stream innerStream)
		: this(innerStream, leaveInnerStreamOpen: false)
	{
	}

	public NegotiateStream(Stream innerStream, bool leaveInnerStreamOpen)
		: base(innerStream, leaveInnerStreamOpen)
	{
		_NegoState = new NegoState(innerStream, leaveInnerStreamOpen);
		_Package = NegoState.DefaultPackage;
		InitializeStreamPart();
	}

	public virtual void AuthenticateAsClient()
	{
		AuthenticateAsClient((NetworkCredential)CredentialCache.DefaultCredentials, null, string.Empty, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification);
	}

	public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName)
	{
		AuthenticateAsClient(credential, null, targetName, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification);
	}

	public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName)
	{
		AuthenticateAsClient(credential, binding, targetName, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification);
	}

	public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
	{
		AuthenticateAsClient(credential, null, targetName, requiredProtectionLevel, allowedImpersonationLevel);
	}

	public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
	{
		_NegoState.ValidateCreateContext(_Package, isServer: false, credential, targetName, binding, requiredProtectionLevel, allowedImpersonationLevel);
		_NegoState.ProcessAuthentication(null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsClient((NetworkCredential)CredentialCache.DefaultCredentials, null, string.Empty, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsClient(credential, null, targetName, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsClient(credential, binding, targetName, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsClient(credential, null, targetName, requiredProtectionLevel, allowedImpersonationLevel, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
	{
		_NegoState.ValidateCreateContext(_Package, isServer: false, credential, targetName, binding, requiredProtectionLevel, allowedImpersonationLevel);
		LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(_NegoState, asyncState, asyncCallback);
		_NegoState.ProcessAuthentication(lazyAsyncResult);
		return lazyAsyncResult;
	}

	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
	{
		_NegoState.EndProcessAuthentication(asyncResult);
	}

	public virtual void AuthenticateAsServer()
	{
		AuthenticateAsServer((NetworkCredential)CredentialCache.DefaultCredentials, null, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification);
	}

	public virtual void AuthenticateAsServer(ExtendedProtectionPolicy policy)
	{
		AuthenticateAsServer((NetworkCredential)CredentialCache.DefaultCredentials, policy, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification);
	}

	public virtual void AuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
	{
		AuthenticateAsServer(credential, null, requiredProtectionLevel, requiredImpersonationLevel);
	}

	public virtual void AuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
	{
		_NegoState.ValidateCreateContext(_Package, credential, string.Empty, policy, requiredProtectionLevel, requiredImpersonationLevel);
		_NegoState.ProcessAuthentication(null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsServer(AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsServer((NetworkCredential)CredentialCache.DefaultCredentials, null, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsServer(ExtendedProtectionPolicy policy, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsServer((NetworkCredential)CredentialCache.DefaultCredentials, policy, ProtectionLevel.EncryptAndSign, TokenImpersonationLevel.Identification, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginAuthenticateAsServer(credential, null, requiredProtectionLevel, requiredImpersonationLevel, asyncCallback, asyncState);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
	{
		_NegoState.ValidateCreateContext(_Package, credential, string.Empty, policy, requiredProtectionLevel, requiredImpersonationLevel);
		LazyAsyncResult lazyAsyncResult = new LazyAsyncResult(_NegoState, asyncState, asyncCallback);
		_NegoState.ProcessAuthentication(lazyAsyncResult);
		return lazyAsyncResult;
	}

	public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult)
	{
		_NegoState.EndProcessAuthentication(asyncResult);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsClientAsync()
	{
		return Task.Factory.FromAsync(BeginAuthenticateAsClient, EndAuthenticateAsClient, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName)
	{
		return Task.Factory.FromAsync(BeginAuthenticateAsClient, EndAuthenticateAsClient, credential, targetName, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
	{
		return Task.Factory.FromAsync((AsyncCallback callback, object state) => BeginAuthenticateAsClient(credential, targetName, requiredProtectionLevel, allowedImpersonationLevel, callback, state), EndAuthenticateAsClient, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName)
	{
		return Task.Factory.FromAsync(BeginAuthenticateAsClient, EndAuthenticateAsClient, credential, binding, targetName, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
	{
		return Task.Factory.FromAsync((AsyncCallback callback, object state) => BeginAuthenticateAsClient(credential, binding, targetName, requiredProtectionLevel, allowedImpersonationLevel, callback, state), EndAuthenticateAsClient, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsServerAsync()
	{
		return Task.Factory.FromAsync(BeginAuthenticateAsServer, EndAuthenticateAsServer, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsServerAsync(ExtendedProtectionPolicy policy)
	{
		return Task.Factory.FromAsync(BeginAuthenticateAsServer, EndAuthenticateAsServer, policy, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
	{
		return Task.Factory.FromAsync(BeginAuthenticateAsServer, EndAuthenticateAsServer, credential, requiredProtectionLevel, requiredImpersonationLevel, null);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
	{
		return Task.Factory.FromAsync((AsyncCallback callback, object state) => BeginAuthenticateAsServer(credential, policy, requiredProtectionLevel, requiredImpersonationLevel, callback, state), EndAuthenticateAsClient, null);
	}

	public override void SetLength(long value)
	{
		base.InnerStream.SetLength(value);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void Flush()
	{
		base.InnerStream.Flush();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			_NegoState.Close();
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		_NegoState.CheckThrow(authSucessCheck: true);
		if (!_NegoState.CanGetSecureStream)
		{
			return base.InnerStream.Read(buffer, offset, count);
		}
		return ProcessRead(buffer, offset, count, null);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		_NegoState.CheckThrow(authSucessCheck: true);
		if (!_NegoState.CanGetSecureStream)
		{
			base.InnerStream.Write(buffer, offset, count);
		}
		else
		{
			ProcessWrite(buffer, offset, count, null);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		_NegoState.CheckThrow(authSucessCheck: true);
		if (!_NegoState.CanGetSecureStream)
		{
			return base.InnerStream.BeginRead(buffer, offset, count, asyncCallback, asyncState);
		}
		BufferAsyncResult bufferAsyncResult = new BufferAsyncResult(this, buffer, offset, count, asyncState, asyncCallback);
		AsyncProtocolRequest asyncRequest = new AsyncProtocolRequest(bufferAsyncResult);
		ProcessRead(buffer, offset, count, asyncRequest);
		return bufferAsyncResult;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		_NegoState.CheckThrow(authSucessCheck: true);
		if (!_NegoState.CanGetSecureStream)
		{
			return base.InnerStream.EndRead(asyncResult);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is BufferAsyncResult bufferAsyncResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", asyncResult.GetType().FullName), "asyncResult");
		}
		if (Interlocked.Exchange(ref _NestedRead, 0) == 0)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndRead"));
		}
		bufferAsyncResult.InternalWaitForCompletion();
		if (bufferAsyncResult.Result is Exception)
		{
			if (bufferAsyncResult.Result is IOException)
			{
				throw (Exception)bufferAsyncResult.Result;
			}
			throw new IOException(SR.GetString("net_io_read"), (Exception)bufferAsyncResult.Result);
		}
		return (int)bufferAsyncResult.Result;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		_NegoState.CheckThrow(authSucessCheck: true);
		if (!_NegoState.CanGetSecureStream)
		{
			return base.InnerStream.BeginWrite(buffer, offset, count, asyncCallback, asyncState);
		}
		BufferAsyncResult bufferAsyncResult = new BufferAsyncResult(this, buffer, offset, count, isWrite: true, asyncState, asyncCallback);
		AsyncProtocolRequest asyncRequest = new AsyncProtocolRequest(bufferAsyncResult);
		ProcessWrite(buffer, offset, count, asyncRequest);
		return bufferAsyncResult;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		_NegoState.CheckThrow(authSucessCheck: true);
		if (!_NegoState.CanGetSecureStream)
		{
			base.InnerStream.EndWrite(asyncResult);
			return;
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is BufferAsyncResult bufferAsyncResult))
		{
			throw new ArgumentException(SR.GetString("net_io_async_result", asyncResult.GetType().FullName), "asyncResult");
		}
		if (Interlocked.Exchange(ref _NestedWrite, 0) == 0)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndWrite"));
		}
		bufferAsyncResult.InternalWaitForCompletion();
		if (!(bufferAsyncResult.Result is Exception))
		{
			return;
		}
		if (bufferAsyncResult.Result is IOException)
		{
			throw (Exception)bufferAsyncResult.Result;
		}
		throw new IOException(SR.GetString("net_io_write"), (Exception)bufferAsyncResult.Result);
	}

	private void InitializeStreamPart()
	{
		_ReadHeader = new byte[4];
		_FrameReader = new FixedSizeReader(base.InnerStream);
	}

	private void DecrementInternalBufferCount(int decrCount)
	{
		_InternalOffset += decrCount;
		_InternalBufferCount -= decrCount;
	}

	private void EnsureInternalBufferSize(int bytes)
	{
		_InternalBufferCount = bytes;
		_InternalOffset = 0;
		if (InternalBuffer == null || InternalBuffer.Length < bytes)
		{
			_InternalBuffer = new byte[bytes];
		}
	}

	private void AdjustInternalBufferOffsetSize(int bytes, int offset)
	{
		_InternalBufferCount = bytes;
		_InternalOffset = offset;
	}

	private void ValidateParameters(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("net_offset_plus_count"));
		}
	}

	private void ProcessWrite(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		ValidateParameters(buffer, offset, count);
		if (Interlocked.Exchange(ref _NestedWrite, 1) == 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", (asyncRequest != null) ? "BeginWrite" : "Write", "write"));
		}
		bool flag = false;
		try
		{
			StartWriting(buffer, offset, count, asyncRequest);
		}
		catch (Exception ex)
		{
			flag = true;
			if (ex is IOException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_write"), ex);
		}
		finally
		{
			if (asyncRequest == null || flag)
			{
				_NestedWrite = 0;
			}
		}
	}

	private void StartWriting(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		if (count >= 0)
		{
			byte[] outBuffer = null;
			do
			{
				int num = Math.Min(count, 64512);
				int count2;
				try
				{
					count2 = _NegoState.EncryptData(buffer, offset, num, ref outBuffer);
				}
				catch (Exception innerException)
				{
					throw new IOException(SR.GetString("net_io_encrypt"), innerException);
				}
				if (asyncRequest != null)
				{
					asyncRequest.SetNextRequest(buffer, offset + num, count - num, null);
					IAsyncResult asyncResult = base.InnerStream.BeginWrite(outBuffer, 0, count2, _WriteCallback, asyncRequest);
					if (!asyncResult.CompletedSynchronously)
					{
						return;
					}
					base.InnerStream.EndWrite(asyncResult);
				}
				else
				{
					base.InnerStream.Write(outBuffer, 0, count2);
				}
				offset += num;
				count -= num;
			}
			while (count != 0);
		}
		asyncRequest?.CompleteUser();
	}

	private int ProcessRead(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		ValidateParameters(buffer, offset, count);
		if (Interlocked.Exchange(ref _NestedRead, 1) == 1)
		{
			throw new NotSupportedException(SR.GetString("net_io_invalidnestedcall", (asyncRequest != null) ? "BeginRead" : "Read", "read"));
		}
		bool flag = false;
		try
		{
			if (InternalBufferCount != 0)
			{
				int num = ((InternalBufferCount > count) ? count : InternalBufferCount);
				if (num != 0)
				{
					Buffer.BlockCopy(InternalBuffer, InternalOffset, buffer, offset, num);
					DecrementInternalBufferCount(num);
				}
				asyncRequest?.CompleteUser(num);
				return num;
			}
			return StartReading(buffer, offset, count, asyncRequest);
		}
		catch (Exception ex)
		{
			flag = true;
			if (ex is IOException)
			{
				throw;
			}
			throw new IOException(SR.GetString("net_io_read"), ex);
		}
		finally
		{
			if (asyncRequest == null || flag)
			{
				_NestedRead = 0;
			}
		}
	}

	private int StartReading(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		int result;
		while ((result = StartFrameHeader(buffer, offset, count, asyncRequest)) == -1)
		{
		}
		return result;
	}

	private int StartFrameHeader(byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		int num = 0;
		if (asyncRequest != null)
		{
			asyncRequest.SetNextRequest(_ReadHeader, 0, _ReadHeader.Length, _ReadCallback);
			_FrameReader.AsyncReadPacket(asyncRequest);
			if (!asyncRequest.MustCompleteSynchronously)
			{
				return 0;
			}
			num = asyncRequest.Result;
		}
		else
		{
			num = _FrameReader.ReadPacket(_ReadHeader, 0, _ReadHeader.Length);
		}
		return StartFrameBody(num, buffer, offset, count, asyncRequest);
	}

	private int StartFrameBody(int readBytes, byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		if (readBytes == 0)
		{
			asyncRequest?.CompleteUser(0);
			return 0;
		}
		readBytes = _ReadHeader[3];
		readBytes = (readBytes << 8) | _ReadHeader[2];
		readBytes = (readBytes << 8) | _ReadHeader[1];
		readBytes = (readBytes << 8) | _ReadHeader[0];
		if (readBytes <= 4 || readBytes > 65536)
		{
			throw new IOException(SR.GetString("net_frame_read_size"));
		}
		EnsureInternalBufferSize(readBytes);
		if (asyncRequest != null)
		{
			asyncRequest.SetNextRequest(InternalBuffer, 0, readBytes, _ReadCallback);
			_FrameReader.AsyncReadPacket(asyncRequest);
			if (!asyncRequest.MustCompleteSynchronously)
			{
				return 0;
			}
			readBytes = asyncRequest.Result;
		}
		else
		{
			readBytes = _FrameReader.ReadPacket(InternalBuffer, 0, readBytes);
		}
		return ProcessFrameBody(readBytes, buffer, offset, count, asyncRequest);
	}

	private int ProcessFrameBody(int readBytes, byte[] buffer, int offset, int count, AsyncProtocolRequest asyncRequest)
	{
		if (readBytes == 0)
		{
			throw new IOException(SR.GetString("net_io_eof"));
		}
		readBytes = _NegoState.DecryptData(InternalBuffer, 0, readBytes, out var newOffset);
		AdjustInternalBufferOffsetSize(readBytes, newOffset);
		if (readBytes == 0 && count != 0)
		{
			return -1;
		}
		if (readBytes > count)
		{
			readBytes = count;
		}
		Buffer.BlockCopy(InternalBuffer, InternalOffset, buffer, offset, readBytes);
		DecrementInternalBufferCount(readBytes);
		asyncRequest?.CompleteUser(readBytes);
		return readBytes;
	}

	private static void WriteCallback(IAsyncResult transportResult)
	{
		if (transportResult.CompletedSynchronously)
		{
			return;
		}
		AsyncProtocolRequest asyncProtocolRequest = (AsyncProtocolRequest)transportResult.AsyncState;
		try
		{
			NegotiateStream negotiateStream = (NegotiateStream)asyncProtocolRequest.AsyncObject;
			negotiateStream.InnerStream.EndWrite(transportResult);
			if (asyncProtocolRequest.Count == 0)
			{
				asyncProtocolRequest.Count = -1;
			}
			negotiateStream.StartWriting(asyncProtocolRequest.Buffer, asyncProtocolRequest.Offset, asyncProtocolRequest.Count, asyncProtocolRequest);
		}
		catch (Exception e)
		{
			if (asyncProtocolRequest.IsUserCompleted)
			{
				throw;
			}
			asyncProtocolRequest.CompleteWithError(e);
		}
	}

	private static void ReadCallback(AsyncProtocolRequest asyncRequest)
	{
		try
		{
			NegotiateStream negotiateStream = (NegotiateStream)asyncRequest.AsyncObject;
			BufferAsyncResult bufferAsyncResult = (BufferAsyncResult)asyncRequest.UserAsyncResult;
			if (asyncRequest.Buffer == negotiateStream._ReadHeader)
			{
				negotiateStream.StartFrameBody(asyncRequest.Result, bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest);
			}
			else if (-1 == negotiateStream.ProcessFrameBody(asyncRequest.Result, bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest))
			{
				negotiateStream.StartReading(bufferAsyncResult.Buffer, bufferAsyncResult.Offset, bufferAsyncResult.Count, asyncRequest);
			}
		}
		catch (Exception e)
		{
			if (asyncRequest.IsUserCompleted)
			{
				throw;
			}
			asyncRequest.CompleteWithError(e);
		}
	}
}
