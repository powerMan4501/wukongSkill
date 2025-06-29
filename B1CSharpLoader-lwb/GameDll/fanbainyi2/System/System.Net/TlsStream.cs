using System.Collections;
using System.Globalization;
using System.Net.Configuration;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net;

internal class TlsStream : NetworkStream, IDisposable
{
	private SslState m_Worker;

	private WebExceptionStatus m_ExceptionStatus;

	private string m_DestinationHost;

	private X509CertificateCollection m_ClientCertificates;

	private static AsyncCallback _CompleteIOCallback = CompleteIOCallback;

	private ExecutionContext _ExecutionContext;

	private ChannelBinding m_CachedChannelBinding;

	private bool m_CheckCertificateRevocationList;

	private SslProtocols m_SslProtocols;

	private int m_ShutDown;

	private ArrayList m_PendingIO = new ArrayList();

	internal WebExceptionStatus ExceptionStatus => m_ExceptionStatus;

	public override bool DataAvailable
	{
		get
		{
			if (!m_Worker.DataAvailable)
			{
				return base.DataAvailable;
			}
			return true;
		}
	}

	public X509Certificate ClientCertificate => m_Worker.InternalLocalCertificate;

	public TlsStream(string destinationHost, NetworkStream networkStream, bool checkCertificateRevocationList, SslProtocols sslProtocols, X509CertificateCollection clientCertificates, ServicePoint servicePoint, object initiatingRequest, ExecutionContext executionContext)
		: base(networkStream, ownsSocket: true)
	{
		m_CheckCertificateRevocationList = checkCertificateRevocationList;
		m_SslProtocols = sslProtocols;
		_ExecutionContext = executionContext;
		if (_ExecutionContext == null)
		{
			_ExecutionContext = ExecutionContext.Capture();
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, ".ctor", string.Format("host={0}, #certs={1}, checkCertificateRevocationList={2}, sslProtocols={3}", destinationHost, (clientCertificates == null) ? "null" : clientCertificates.Count.ToString(NumberFormatInfo.InvariantInfo), checkCertificateRevocationList, sslProtocols));
		}
		m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
		m_Worker = new SslState(networkStream, initiatingRequest is HttpWebRequest, SettingsSectionInternal.Section.EncryptionPolicy);
		m_DestinationHost = destinationHost;
		m_ClientCertificates = clientCertificates;
		RemoteCertValidationCallback certValidationDelegate = servicePoint.SetupHandshakeDoneProcedure(this, initiatingRequest);
		m_Worker.SetCertValidationDelegate(certValidationDelegate);
	}

	protected override void Dispose(bool disposing)
	{
		if (Interlocked.Exchange(ref m_ShutDown, 1) == 1)
		{
			return;
		}
		try
		{
			if (disposing)
			{
				m_CachedChannelBinding = GetChannelBinding(ChannelBindingKind.Endpoint);
				m_Worker.Close();
			}
			else
			{
				m_Worker = null;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		if (!m_Worker.IsAuthenticated)
		{
			ProcessAuthentication(null);
		}
		try
		{
			return m_Worker.SecureStream.Read(buffer, offset, size);
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.ReceiveFailure;
			}
			throw;
		}
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback asyncCallback, object asyncState)
	{
		if (!m_Worker.IsAuthenticated)
		{
			BufferAsyncResult result = new BufferAsyncResult(this, buffer, offset, size, isWrite: false, asyncState, asyncCallback);
			if (ProcessAuthentication(result))
			{
				return result;
			}
		}
		try
		{
			return m_Worker.SecureStream.BeginRead(buffer, offset, size, asyncCallback, asyncState);
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.ReceiveFailure;
			}
			throw;
		}
	}

	internal override IAsyncResult UnsafeBeginRead(byte[] buffer, int offset, int size, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginRead(buffer, offset, size, asyncCallback, asyncState);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		try
		{
			if (!(asyncResult is BufferAsyncResult bufferAsyncResult) || bufferAsyncResult.AsyncObject != this)
			{
				return m_Worker.SecureStream.EndRead(asyncResult);
			}
			bufferAsyncResult.InternalWaitForCompletion();
			if (bufferAsyncResult.Result is Exception ex)
			{
				throw ex;
			}
			return (int)bufferAsyncResult.Result;
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.ReceiveFailure;
			}
			throw;
		}
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
		if (!m_Worker.IsAuthenticated)
		{
			ProcessAuthentication(null);
		}
		try
		{
			m_Worker.SecureStream.Write(buffer, offset, size);
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.SendFailure;
			}
			base.Socket?.InternalShutdown(SocketShutdown.Both);
			throw;
		}
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback asyncCallback, object asyncState)
	{
		if (!m_Worker.IsAuthenticated)
		{
			BufferAsyncResult result = new BufferAsyncResult(this, buffer, offset, size, isWrite: true, asyncState, asyncCallback);
			if (ProcessAuthentication(result))
			{
				return result;
			}
		}
		try
		{
			return m_Worker.SecureStream.BeginWrite(buffer, offset, size, asyncCallback, asyncState);
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.SendFailure;
			}
			throw;
		}
	}

	internal override IAsyncResult UnsafeBeginWrite(byte[] buffer, int offset, int size, AsyncCallback asyncCallback, object asyncState)
	{
		return BeginWrite(buffer, offset, size, asyncCallback, asyncState);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		try
		{
			if (!(asyncResult is BufferAsyncResult bufferAsyncResult) || bufferAsyncResult.AsyncObject != this)
			{
				m_Worker.SecureStream.EndWrite(asyncResult);
				return;
			}
			bufferAsyncResult.InternalWaitForCompletion();
			if (!(bufferAsyncResult.Result is Exception ex))
			{
				return;
			}
			throw ex;
		}
		catch
		{
			base.Socket?.InternalShutdown(SocketShutdown.Both);
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.SendFailure;
			}
			throw;
		}
	}

	internal override void MultipleWrite(BufferOffsetSize[] buffers)
	{
		if (!m_Worker.IsAuthenticated)
		{
			ProcessAuthentication(null);
		}
		try
		{
			m_Worker.SecureStream.Write(buffers);
		}
		catch
		{
			base.Socket?.InternalShutdown(SocketShutdown.Both);
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.SendFailure;
			}
			throw;
		}
	}

	internal override IAsyncResult BeginMultipleWrite(BufferOffsetSize[] buffers, AsyncCallback callback, object state)
	{
		if (!m_Worker.IsAuthenticated)
		{
			BufferAsyncResult result = new BufferAsyncResult(this, buffers, state, callback);
			if (ProcessAuthentication(result))
			{
				return result;
			}
		}
		try
		{
			return m_Worker.SecureStream.BeginWrite(buffers, callback, state);
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.SendFailure;
			}
			throw;
		}
	}

	internal override IAsyncResult UnsafeBeginMultipleWrite(BufferOffsetSize[] buffers, AsyncCallback callback, object state)
	{
		return BeginMultipleWrite(buffers, callback, state);
	}

	internal override void EndMultipleWrite(IAsyncResult asyncResult)
	{
		EndWrite(asyncResult);
	}

	internal ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		if (kind == ChannelBindingKind.Endpoint && m_CachedChannelBinding != null)
		{
			return m_CachedChannelBinding;
		}
		return m_Worker.GetChannelBinding(kind);
	}

	internal bool ProcessAuthentication(LazyAsyncResult result)
	{
		bool flag = false;
		bool flag2 = result == null;
		lock (m_PendingIO)
		{
			if (m_Worker.IsAuthenticated)
			{
				return false;
			}
			if (m_PendingIO.Count == 0)
			{
				flag = true;
			}
			if (flag2)
			{
				result = new LazyAsyncResult(this, null, null);
			}
			m_PendingIO.Add(result);
		}
		try
		{
			if (flag)
			{
				bool flag3 = true;
				LazyAsyncResult lazyAsyncResult = null;
				try
				{
					m_Worker.ValidateCreateContext(isServer: false, m_DestinationHost, m_SslProtocols, null, m_ClientCertificates, remoteCertRequired: true, m_CheckCertificateRevocationList, ServicePointManager.CheckCertificateName);
					if (!flag2)
					{
						lazyAsyncResult = new LazyAsyncResult(m_Worker, null, WakeupPendingIO);
					}
					if (_ExecutionContext != null)
					{
						ExecutionContext.Run(_ExecutionContext.CreateCopy(), CallProcessAuthentication, lazyAsyncResult);
					}
					else
					{
						m_Worker.ProcessAuthentication(lazyAsyncResult);
					}
				}
				catch
				{
					flag3 = false;
					throw;
				}
				finally
				{
					if (flag2 || !flag3)
					{
						lock (m_PendingIO)
						{
							if (m_PendingIO.Count > 1)
							{
								ThreadPool.QueueUserWorkItem(StartWakeupPendingIO, null);
							}
							else
							{
								m_PendingIO.Clear();
							}
						}
					}
				}
			}
			else if (flag2 && result.InternalWaitForCompletion() is Exception ex)
			{
				throw ex;
			}
		}
		catch
		{
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.ReceiveFailure;
			}
			throw;
		}
		return true;
	}

	private void CallProcessAuthentication(object state)
	{
		m_Worker.ProcessAuthentication((LazyAsyncResult)state);
	}

	private void StartWakeupPendingIO(object nullState)
	{
		WakeupPendingIO(null);
	}

	private void WakeupPendingIO(IAsyncResult ar)
	{
		Exception result = null;
		try
		{
			if (ar != null)
			{
				m_Worker.EndProcessAuthentication(ar);
			}
		}
		catch (Exception ex)
		{
			result = ex;
			if (m_Worker.IsCertValidationFailed)
			{
				m_ExceptionStatus = WebExceptionStatus.TrustFailure;
			}
			else if (m_Worker.LastSecurityStatus != SecurityStatus.OK)
			{
				m_ExceptionStatus = WebExceptionStatus.SecureChannelFailure;
			}
			else
			{
				m_ExceptionStatus = WebExceptionStatus.ReceiveFailure;
			}
		}
		lock (m_PendingIO)
		{
			while (m_PendingIO.Count != 0)
			{
				LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)m_PendingIO[m_PendingIO.Count - 1];
				m_PendingIO.RemoveAt(m_PendingIO.Count - 1);
				if (lazyAsyncResult is BufferAsyncResult)
				{
					if (m_PendingIO.Count == 0)
					{
						ResumeIOWorker(lazyAsyncResult);
					}
					else
					{
						ThreadPool.QueueUserWorkItem(ResumeIOWorker, lazyAsyncResult);
					}
				}
				else
				{
					try
					{
						lazyAsyncResult.InvokeCallback(result);
					}
					catch
					{
					}
				}
			}
		}
	}

	private void ResumeIOWorker(object result)
	{
		BufferAsyncResult bufferAsyncResult = (BufferAsyncResult)result;
		try
		{
			ResumeIO(bufferAsyncResult);
		}
		catch (Exception ex)
		{
			if (ex is OutOfMemoryException || ex is StackOverflowException || ex is ThreadAbortException)
			{
				throw;
			}
			if (bufferAsyncResult.InternalPeekCompleted)
			{
				throw;
			}
			bufferAsyncResult.InvokeCallback(ex);
		}
	}

	private void ResumeIO(BufferAsyncResult bufferResult)
	{
		IAsyncResult asyncResult = ((!bufferResult.IsWrite) ? m_Worker.SecureStream.BeginRead(bufferResult.Buffer, bufferResult.Offset, bufferResult.Count, _CompleteIOCallback, bufferResult) : ((bufferResult.Buffers == null) ? m_Worker.SecureStream.BeginWrite(bufferResult.Buffer, bufferResult.Offset, bufferResult.Count, _CompleteIOCallback, bufferResult) : m_Worker.SecureStream.BeginWrite(bufferResult.Buffers, _CompleteIOCallback, bufferResult)));
		if (asyncResult.CompletedSynchronously)
		{
			CompleteIO(asyncResult);
		}
	}

	private static void CompleteIOCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		try
		{
			CompleteIO(result);
		}
		catch (Exception ex)
		{
			if (ex is OutOfMemoryException || ex is StackOverflowException || ex is ThreadAbortException)
			{
				throw;
			}
			if (((LazyAsyncResult)result.AsyncState).InternalPeekCompleted)
			{
				throw;
			}
			((LazyAsyncResult)result.AsyncState).InvokeCallback(ex);
		}
	}

	private static void CompleteIO(IAsyncResult result)
	{
		BufferAsyncResult bufferAsyncResult = (BufferAsyncResult)result.AsyncState;
		object result2 = null;
		if (bufferAsyncResult.IsWrite)
		{
			((TlsStream)bufferAsyncResult.AsyncObject).m_Worker.SecureStream.EndWrite(result);
		}
		else
		{
			result2 = ((TlsStream)bufferAsyncResult.AsyncObject).m_Worker.SecureStream.EndRead(result);
		}
		bufferAsyncResult.InvokeCallback(result2);
	}
}
