using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Mail;

public class SmtpClient : IDisposable
{
	private string host;

	private int port;

	private bool inCall;

	private bool cancelled;

	private bool timedOut;

	private string targetName;

	private SmtpDeliveryMethod deliveryMethod;

	private SmtpDeliveryFormat deliveryFormat;

	private string pickupDirectoryLocation;

	private SmtpTransport transport;

	private MailMessage message;

	private MailWriter writer;

	private MailAddressCollection recipients;

	private SendOrPostCallback onSendCompletedDelegate;

	private Timer timer;

	private static volatile MailSettingsSectionGroupInternal mailConfiguration;

	private ContextAwareResult operationCompletedResult;

	private AsyncOperation asyncOp;

	private static AsyncCallback _ContextSafeCompleteCallback = ContextSafeCompleteCallback;

	private static int defaultPort = 25;

	internal string clientDomain;

	private bool disposed;

	private bool servicePointChanged;

	private ServicePoint servicePoint;

	private SmtpFailedRecipientException failedRecipientException;

	private const int maxPortValue = 65535;

	public string Host
	{
		get
		{
			return host;
		}
		set
		{
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("SmtpInvalidOperationDuringSend"));
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value == string.Empty)
			{
				throw new ArgumentException(SR.GetString("net_emptystringset"), "value");
			}
			value = value.Trim();
			if (value != host)
			{
				host = value;
				servicePointChanged = true;
			}
		}
	}

	public int Port
	{
		get
		{
			return port;
		}
		set
		{
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("SmtpInvalidOperationDuringSend"));
			}
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value != defaultPort)
			{
				new SmtpPermission(SmtpAccess.ConnectToUnrestrictedPort).Demand();
			}
			if (value != port)
			{
				port = value;
				servicePointChanged = true;
			}
		}
	}

	public bool UseDefaultCredentials
	{
		get
		{
			if (!(transport.Credentials is SystemNetworkCredential))
			{
				return false;
			}
			return true;
		}
		set
		{
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("SmtpInvalidOperationDuringSend"));
			}
			transport.Credentials = (value ? CredentialCache.DefaultNetworkCredentials : null);
		}
	}

	public ICredentialsByHost Credentials
	{
		get
		{
			return transport.Credentials;
		}
		set
		{
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("SmtpInvalidOperationDuringSend"));
			}
			transport.Credentials = value;
		}
	}

	public int Timeout
	{
		get
		{
			return transport.Timeout;
		}
		set
		{
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("SmtpInvalidOperationDuringSend"));
			}
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			transport.Timeout = value;
		}
	}

	public ServicePoint ServicePoint
	{
		get
		{
			CheckHostAndPort();
			if (servicePoint == null || servicePointChanged)
			{
				servicePoint = ServicePointManager.FindServicePoint(host, port);
				servicePointChanged = false;
			}
			return servicePoint;
		}
	}

	public SmtpDeliveryMethod DeliveryMethod
	{
		get
		{
			return deliveryMethod;
		}
		set
		{
			deliveryMethod = value;
		}
	}

	public SmtpDeliveryFormat DeliveryFormat
	{
		get
		{
			return deliveryFormat;
		}
		set
		{
			deliveryFormat = value;
		}
	}

	public string PickupDirectoryLocation
	{
		get
		{
			return pickupDirectoryLocation;
		}
		set
		{
			pickupDirectoryLocation = value;
		}
	}

	public bool EnableSsl
	{
		get
		{
			return transport.EnableSsl;
		}
		set
		{
			transport.EnableSsl = value;
		}
	}

	public X509CertificateCollection ClientCertificates => transport.ClientCertificates;

	public string TargetName
	{
		get
		{
			return targetName;
		}
		set
		{
			targetName = value;
		}
	}

	private bool ServerSupportsEai => transport.ServerSupportsEai;

	internal bool InCall
	{
		get
		{
			return inCall;
		}
		set
		{
			inCall = value;
		}
	}

	internal static MailSettingsSectionGroupInternal MailConfiguration
	{
		get
		{
			if (mailConfiguration == null)
			{
				mailConfiguration = MailSettingsSectionGroupInternal.GetSection();
			}
			return mailConfiguration;
		}
	}

	public event SendCompletedEventHandler SendCompleted;

	public SmtpClient()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, "SmtpClient", ".ctor", "");
		}
		try
		{
			Initialize();
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, "SmtpClient", ".ctor", this);
			}
		}
	}

	public SmtpClient(string host)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, "SmtpClient", ".ctor", "host=" + host);
		}
		try
		{
			this.host = host;
			Initialize();
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, "SmtpClient", ".ctor", this);
			}
		}
	}

	public SmtpClient(string host, int port)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, "SmtpClient", ".ctor", "host=" + host + ", port=" + port);
		}
		try
		{
			if (port < 0)
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this.host = host;
			this.port = port;
			Initialize();
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, "SmtpClient", ".ctor", this);
			}
		}
	}

	private void Initialize()
	{
		if (port == defaultPort || port == 0)
		{
			new SmtpPermission(SmtpAccess.Connect).Demand();
		}
		else
		{
			new SmtpPermission(SmtpAccess.ConnectToUnrestrictedPort).Demand();
		}
		transport = new SmtpTransport(this);
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, transport);
		}
		onSendCompletedDelegate = SendCompletedWaitCallback;
		if (MailConfiguration.Smtp != null)
		{
			if (MailConfiguration.Smtp.Network != null)
			{
				if (host == null || host.Length == 0)
				{
					host = MailConfiguration.Smtp.Network.Host;
				}
				if (port == 0)
				{
					port = MailConfiguration.Smtp.Network.Port;
				}
				transport.Credentials = MailConfiguration.Smtp.Network.Credential;
				transport.EnableSsl = MailConfiguration.Smtp.Network.EnableSsl;
				if (MailConfiguration.Smtp.Network.TargetName != null)
				{
					targetName = MailConfiguration.Smtp.Network.TargetName;
				}
				clientDomain = MailConfiguration.Smtp.Network.ClientDomain;
			}
			deliveryFormat = MailConfiguration.Smtp.DeliveryFormat;
			deliveryMethod = MailConfiguration.Smtp.DeliveryMethod;
			if (MailConfiguration.Smtp.SpecifiedPickupDirectory != null)
			{
				pickupDirectoryLocation = MailConfiguration.Smtp.SpecifiedPickupDirectory.PickupDirectoryLocation;
			}
		}
		if (host != null && host.Length != 0)
		{
			host = host.Trim();
		}
		if (port == 0)
		{
			port = defaultPort;
		}
		if (targetName == null)
		{
			targetName = "SMTPSVC/" + host;
		}
		if (clientDomain != null)
		{
			return;
		}
		string text = IPGlobalProperties.InternalGetIPGlobalProperties().HostName;
		IdnMapping idnMapping = new IdnMapping();
		try
		{
			text = idnMapping.GetAscii(text);
		}
		catch (ArgumentException)
		{
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in text)
		{
			if (c <= '\u007f')
			{
				stringBuilder.Append(c);
			}
		}
		if (stringBuilder.Length > 0)
		{
			clientDomain = stringBuilder.ToString();
		}
		else
		{
			clientDomain = "LocalHost";
		}
	}

	private bool IsUnicodeSupported()
	{
		if (DeliveryMethod == SmtpDeliveryMethod.Network)
		{
			if (ServerSupportsEai)
			{
				return DeliveryFormat == SmtpDeliveryFormat.International;
			}
			return false;
		}
		return DeliveryFormat == SmtpDeliveryFormat.International;
	}

	internal MailWriter GetFileMailWriter(string pickupDirectory)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "SmtpClient.Send() pickupDirectory=" + pickupDirectory);
		}
		if (!Path.IsPathRooted(pickupDirectory))
		{
			throw new SmtpException(SR.GetString("SmtpNeedAbsolutePickupDirectory"));
		}
		string path2;
		do
		{
			string path = Guid.NewGuid().ToString() + ".eml";
			path2 = Path.Combine(pickupDirectory, path);
		}
		while (File.Exists(path2));
		FileStream stream = new FileStream(path2, FileMode.CreateNew);
		return new MailWriter(stream);
	}

	protected void OnSendCompleted(AsyncCompletedEventArgs e)
	{
		if (this.SendCompleted != null)
		{
			this.SendCompleted(this, e);
		}
	}

	private void SendCompletedWaitCallback(object operationState)
	{
		OnSendCompleted((AsyncCompletedEventArgs)operationState);
	}

	public void Send(string from, string recipients, string subject, string body)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		MailMessage mailMessage = new MailMessage(from, recipients, subject, body);
		Send(mailMessage);
	}

	public void Send(MailMessage message)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Send", message);
		}
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		try
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, "Send", "DeliveryMethod=" + DeliveryMethod);
			}
			if (Logging.On)
			{
				Logging.Associate(Logging.Web, this, message);
			}
			SmtpFailedRecipientException exception = null;
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("net_inasync"));
			}
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			if (DeliveryMethod == SmtpDeliveryMethod.Network)
			{
				CheckHostAndPort();
			}
			MailAddressCollection mailAddressCollection = new MailAddressCollection();
			if (message.From == null)
			{
				throw new InvalidOperationException(SR.GetString("SmtpFromRequired"));
			}
			if (message.To != null)
			{
				foreach (MailAddress item in message.To)
				{
					mailAddressCollection.Add(item);
				}
			}
			if (message.Bcc != null)
			{
				foreach (MailAddress item2 in message.Bcc)
				{
					mailAddressCollection.Add(item2);
				}
			}
			if (message.CC != null)
			{
				foreach (MailAddress item3 in message.CC)
				{
					mailAddressCollection.Add(item3);
				}
			}
			if (mailAddressCollection.Count == 0)
			{
				throw new InvalidOperationException(SR.GetString("SmtpRecipientRequired"));
			}
			transport.IdentityRequired = false;
			try
			{
				InCall = true;
				timedOut = false;
				timer = new Timer(TimeOutCallback, null, Timeout, Timeout);
				bool flag = false;
				string pickupDirectory = PickupDirectoryLocation;
				MailWriter mailWriter;
				switch (DeliveryMethod)
				{
				case SmtpDeliveryMethod.PickupDirectoryFromIis:
					pickupDirectory = IisPickupDirectory.GetPickupDirectory();
					goto case SmtpDeliveryMethod.SpecifiedPickupDirectory;
				case SmtpDeliveryMethod.SpecifiedPickupDirectory:
					if (EnableSsl)
					{
						throw new SmtpException(SR.GetString("SmtpPickupDirectoryDoesnotSupportSsl"));
					}
					flag = IsUnicodeSupported();
					ValidateUnicodeRequirement(message, mailAddressCollection, flag);
					mailWriter = GetFileMailWriter(pickupDirectory);
					break;
				default:
					GetConnection();
					flag = IsUnicodeSupported();
					ValidateUnicodeRequirement(message, mailAddressCollection, flag);
					mailWriter = transport.SendMail(message.Sender ?? message.From, mailAddressCollection, message.BuildDeliveryStatusNotificationString(), flag, out exception);
					break;
				}
				this.message = message;
				message.Send(mailWriter, DeliveryMethod != SmtpDeliveryMethod.Network, flag);
				mailWriter.Close();
				transport.ReleaseConnection();
				if (DeliveryMethod == SmtpDeliveryMethod.Network && exception != null)
				{
					throw exception;
				}
			}
			catch (Exception ex)
			{
				if (Logging.On)
				{
					Logging.Exception(Logging.Web, this, "Send", ex);
				}
				if (ex is SmtpFailedRecipientException && !((SmtpFailedRecipientException)ex).fatal)
				{
					throw;
				}
				Abort();
				if (timedOut)
				{
					throw new SmtpException(SR.GetString("net_timeout"));
				}
				if (ex is SecurityException || ex is AuthenticationException || ex is SmtpException)
				{
					throw;
				}
				throw new SmtpException(SR.GetString("SmtpSendMailFailure"), ex);
			}
			finally
			{
				InCall = false;
				if (timer != null)
				{
					timer.Dispose();
				}
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "Send", null);
			}
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(string from, string recipients, string subject, string body, object userToken)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		SendAsync(new MailMessage(from, recipients, subject, body), userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(MailMessage message, object userToken)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "SendAsync", "DeliveryMethod=" + DeliveryMethod);
		}
		try
		{
			if (InCall)
			{
				throw new InvalidOperationException(SR.GetString("net_inasync"));
			}
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			if (DeliveryMethod == SmtpDeliveryMethod.Network)
			{
				CheckHostAndPort();
			}
			recipients = new MailAddressCollection();
			if (message.From == null)
			{
				throw new InvalidOperationException(SR.GetString("SmtpFromRequired"));
			}
			if (message.To != null)
			{
				foreach (MailAddress item in message.To)
				{
					recipients.Add(item);
				}
			}
			if (message.Bcc != null)
			{
				foreach (MailAddress item2 in message.Bcc)
				{
					recipients.Add(item2);
				}
			}
			if (message.CC != null)
			{
				foreach (MailAddress item3 in message.CC)
				{
					recipients.Add(item3);
				}
			}
			if (recipients.Count == 0)
			{
				throw new InvalidOperationException(SR.GetString("SmtpRecipientRequired"));
			}
			try
			{
				InCall = true;
				cancelled = false;
				this.message = message;
				string pickupDirectory = PickupDirectoryLocation;
				transport.IdentityRequired = Credentials != null && (Credentials is SystemNetworkCredential || !(Credentials is CredentialCache credentialCache) || credentialCache.IsDefaultInCache);
				asyncOp = AsyncOperationManager.CreateOperation(userToken);
				switch (DeliveryMethod)
				{
				case SmtpDeliveryMethod.PickupDirectoryFromIis:
					pickupDirectory = IisPickupDirectory.GetPickupDirectory();
					goto case SmtpDeliveryMethod.SpecifiedPickupDirectory;
				case SmtpDeliveryMethod.SpecifiedPickupDirectory:
				{
					if (EnableSsl)
					{
						throw new SmtpException(SR.GetString("SmtpPickupDirectoryDoesnotSupportSsl"));
					}
					writer = GetFileMailWriter(pickupDirectory);
					bool allowUnicode = IsUnicodeSupported();
					ValidateUnicodeRequirement(message, recipients, allowUnicode);
					message.Send(writer, sendEnvelope: true, allowUnicode);
					if (writer != null)
					{
						writer.Close();
					}
					transport.ReleaseConnection();
					AsyncCompletedEventArgs arg = new AsyncCompletedEventArgs(null, cancelled: false, asyncOp.UserSuppliedState);
					InCall = false;
					asyncOp.PostOperationCompleted(onSendCompletedDelegate, arg);
					break;
				}
				default:
					operationCompletedResult = new ContextAwareResult(transport.IdentityRequired, forceCaptureContext: true, null, this, _ContextSafeCompleteCallback);
					lock (operationCompletedResult.StartPostingAsyncOp())
					{
						transport.BeginGetConnection(ServicePoint, operationCompletedResult, ConnectCallback, operationCompletedResult);
						operationCompletedResult.FinishPostingAsyncOp();
						break;
					}
				}
			}
			catch (Exception ex)
			{
				InCall = false;
				if (Logging.On)
				{
					Logging.Exception(Logging.Web, this, "Send", ex);
				}
				if (ex is SmtpFailedRecipientException && !((SmtpFailedRecipientException)ex).fatal)
				{
					throw;
				}
				Abort();
				if (timedOut)
				{
					throw new SmtpException(SR.GetString("net_timeout"));
				}
				if (ex is SecurityException || ex is AuthenticationException || ex is SmtpException)
				{
					throw;
				}
				throw new SmtpException(SR.GetString("SmtpSendMailFailure"), ex);
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "SendAsync", null);
			}
		}
	}

	public void SendAsyncCancel()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "SendAsyncCancel", null);
		}
		try
		{
			if (InCall && !cancelled)
			{
				cancelled = true;
				Abort();
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "SendAsyncCancel", null);
			}
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task SendMailAsync(string from, string recipients, string subject, string body)
	{
		MailMessage mailMessage = new MailMessage(from, recipients, subject, body);
		return SendMailAsync(mailMessage);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task SendMailAsync(MailMessage message)
	{
		TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
		SendCompletedEventHandler handler = null;
		handler = delegate(object sender, AsyncCompletedEventArgs e)
		{
			HandleCompletion(tcs, e, handler);
		};
		SendCompleted += handler;
		try
		{
			SendAsync(message, tcs);
		}
		catch
		{
			SendCompleted -= handler;
			throw;
		}
		return tcs.Task;
	}

	private void HandleCompletion(TaskCompletionSource<object> tcs, AsyncCompletedEventArgs e, SendCompletedEventHandler handler)
	{
		if (e.UserState != tcs)
		{
			return;
		}
		try
		{
			SendCompleted -= handler;
		}
		finally
		{
			if (e.Error != null)
			{
				tcs.TrySetException(e.Error);
			}
			else if (e.Cancelled)
			{
				tcs.TrySetCanceled();
			}
			else
			{
				tcs.TrySetResult(null);
			}
		}
	}

	private void CheckHostAndPort()
	{
		if (host == null || host.Length == 0)
		{
			throw new InvalidOperationException(SR.GetString("UnspecifiedHost"));
		}
		if (port <= 0 || port > 65535)
		{
			throw new InvalidOperationException(SR.GetString("InvalidPort"));
		}
	}

	private void TimeOutCallback(object state)
	{
		if (!timedOut)
		{
			timedOut = true;
			Abort();
		}
	}

	private void Complete(Exception exception, IAsyncResult result)
	{
		ContextAwareResult contextAwareResult = (ContextAwareResult)result.AsyncState;
		try
		{
			if (cancelled)
			{
				exception = null;
				Abort();
				return;
			}
			if (exception != null && (!(exception is SmtpFailedRecipientException) || ((SmtpFailedRecipientException)exception).fatal))
			{
				Abort();
				if (!(exception is SmtpException))
				{
					exception = new SmtpException(SR.GetString("SmtpSendMailFailure"), exception);
				}
				return;
			}
			if (writer != null)
			{
				try
				{
					writer.Close();
				}
				catch (SmtpException ex)
				{
					exception = ex;
				}
			}
			transport.ReleaseConnection();
		}
		finally
		{
			contextAwareResult.InvokeCallback(exception);
		}
	}

	private static void ContextSafeCompleteCallback(IAsyncResult ar)
	{
		ContextAwareResult contextAwareResult = (ContextAwareResult)ar;
		SmtpClient smtpClient = (SmtpClient)ar.AsyncState;
		Exception error = contextAwareResult.Result as Exception;
		AsyncOperation asyncOperation = smtpClient.asyncOp;
		AsyncCompletedEventArgs arg = new AsyncCompletedEventArgs(error, smtpClient.cancelled, asyncOperation.UserSuppliedState);
		smtpClient.InCall = false;
		smtpClient.failedRecipientException = null;
		asyncOperation.PostOperationCompleted(smtpClient.onSendCompletedDelegate, arg);
	}

	private void SendMessageCallback(IAsyncResult result)
	{
		try
		{
			message.EndSend(result);
			Complete(failedRecipientException, result);
		}
		catch (Exception exception)
		{
			Complete(exception, result);
		}
	}

	private void SendMailCallback(IAsyncResult result)
	{
		try
		{
			writer = transport.EndSendMail(result);
			SendMailAsyncResult sendMailAsyncResult = (SendMailAsyncResult)result;
			failedRecipientException = sendMailAsyncResult.GetFailedRecipientException();
		}
		catch (Exception exception)
		{
			Complete(exception, result);
			return;
		}
		try
		{
			if (cancelled)
			{
				Complete(null, result);
			}
			else
			{
				message.BeginSend(writer, DeliveryMethod != SmtpDeliveryMethod.Network, ServerSupportsEai, SendMessageCallback, result.AsyncState);
			}
		}
		catch (Exception exception2)
		{
			Complete(exception2, result);
		}
	}

	private void ConnectCallback(IAsyncResult result)
	{
		try
		{
			transport.EndGetConnection(result);
			if (cancelled)
			{
				Complete(null, result);
				return;
			}
			bool allowUnicode = IsUnicodeSupported();
			ValidateUnicodeRequirement(message, recipients, allowUnicode);
			transport.BeginSendMail(message.Sender ?? message.From, recipients, message.BuildDeliveryStatusNotificationString(), allowUnicode, SendMailCallback, result.AsyncState);
		}
		catch (Exception exception)
		{
			Complete(exception, result);
		}
	}

	private void ValidateUnicodeRequirement(MailMessage message, MailAddressCollection recipients, bool allowUnicode)
	{
		foreach (MailAddress recipient in recipients)
		{
			recipient.GetSmtpAddress(allowUnicode);
		}
		if (message.Sender != null)
		{
			message.Sender.GetSmtpAddress(allowUnicode);
		}
		message.From.GetSmtpAddress(allowUnicode);
	}

	private void GetConnection()
	{
		if (!transport.IsConnected)
		{
			transport.GetConnection(ServicePoint);
		}
	}

	private void Abort()
	{
		try
		{
			transport.Abort();
		}
		catch
		{
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			if (InCall && !cancelled)
			{
				cancelled = true;
				Abort();
			}
			if (transport != null && servicePoint != null)
			{
				transport.CloseIdleConnections(servicePoint);
			}
			if (timer != null)
			{
				timer.Dispose();
			}
			disposed = true;
		}
	}
}
