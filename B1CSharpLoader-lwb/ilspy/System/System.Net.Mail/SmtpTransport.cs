using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Mail;

internal class SmtpTransport
{
	internal const int DefaultPort = 25;

	private ISmtpAuthenticationModule[] authenticationModules;

	private SmtpConnection connection;

	private SmtpClient client;

	private ICredentialsByHost credentials;

	private int timeout = 100000;

	private ArrayList failedRecipientExceptions = new ArrayList();

	private bool m_IdentityRequired;

	private bool enableSsl;

	private X509CertificateCollection clientCertificates;

	private ServicePoint lastUsedServicePoint;

	internal ICredentialsByHost Credentials
	{
		get
		{
			return credentials;
		}
		set
		{
			credentials = value;
		}
	}

	internal bool IdentityRequired
	{
		get
		{
			return m_IdentityRequired;
		}
		set
		{
			m_IdentityRequired = value;
		}
	}

	internal bool IsConnected
	{
		get
		{
			if (connection != null)
			{
				return connection.IsConnected;
			}
			return false;
		}
	}

	internal int Timeout
	{
		get
		{
			return timeout;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			timeout = value;
		}
	}

	internal bool EnableSsl
	{
		get
		{
			return enableSsl;
		}
		set
		{
			enableSsl = value;
		}
	}

	internal X509CertificateCollection ClientCertificates
	{
		get
		{
			if (clientCertificates == null)
			{
				clientCertificates = new X509CertificateCollection();
			}
			return clientCertificates;
		}
	}

	internal bool ServerSupportsEai
	{
		get
		{
			if (connection != null)
			{
				return connection.ServerSupportsEai;
			}
			return false;
		}
	}

	internal SmtpTransport(SmtpClient client)
		: this(client, SmtpAuthenticationManager.GetModules())
	{
	}

	internal SmtpTransport(SmtpClient client, ISmtpAuthenticationModule[] authenticationModules)
	{
		this.client = client;
		if (authenticationModules == null)
		{
			throw new ArgumentNullException("authenticationModules");
		}
		this.authenticationModules = authenticationModules;
	}

	private void UpdateServicePoint(ServicePoint servicePoint)
	{
		if (lastUsedServicePoint == null)
		{
			lastUsedServicePoint = servicePoint;
		}
		else if (lastUsedServicePoint.Host != servicePoint.Host || lastUsedServicePoint.Port != servicePoint.Port)
		{
			ConnectionPoolManager.CleanupConnectionPool(servicePoint, "");
			lastUsedServicePoint = servicePoint;
		}
	}

	internal void GetConnection(ServicePoint servicePoint)
	{
		UpdateServicePoint(servicePoint);
		connection = new SmtpConnection(this, client, credentials, authenticationModules);
		connection.Timeout = timeout;
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, connection);
		}
		if (EnableSsl)
		{
			connection.EnableSsl = true;
			connection.ClientCertificates = ClientCertificates;
		}
		connection.GetConnection(servicePoint);
	}

	internal IAsyncResult BeginGetConnection(ServicePoint servicePoint, ContextAwareResult outerResult, AsyncCallback callback, object state)
	{
		IAsyncResult asyncResult = null;
		try
		{
			UpdateServicePoint(servicePoint);
			connection = new SmtpConnection(this, client, credentials, authenticationModules);
			connection.Timeout = timeout;
			if (Logging.On)
			{
				Logging.Associate(Logging.Web, this, connection);
			}
			if (EnableSsl)
			{
				connection.EnableSsl = true;
				connection.ClientCertificates = ClientCertificates;
			}
			return connection.BeginGetConnection(servicePoint, outerResult, callback, state);
		}
		catch (Exception innerException)
		{
			throw new SmtpException(SR.GetString("MailHostNotFound"), innerException);
		}
	}

	internal void EndGetConnection(IAsyncResult result)
	{
		try
		{
			connection.EndGetConnection(result);
		}
		finally
		{
		}
	}

	internal IAsyncResult BeginSendMail(MailAddress sender, MailAddressCollection recipients, string deliveryNotify, bool allowUnicode, AsyncCallback callback, object state)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		SendMailAsyncResult sendMailAsyncResult = new SendMailAsyncResult(connection, sender, recipients, allowUnicode, connection.DSNEnabled ? deliveryNotify : null, callback, state);
		sendMailAsyncResult.Send();
		return sendMailAsyncResult;
	}

	internal void ReleaseConnection()
	{
		if (connection != null)
		{
			connection.ReleaseConnection();
		}
	}

	internal void Abort()
	{
		if (connection != null)
		{
			connection.Abort();
		}
	}

	internal MailWriter EndSendMail(IAsyncResult result)
	{
		return SendMailAsyncResult.End(result);
	}

	internal MailWriter SendMail(MailAddress sender, MailAddressCollection recipients, string deliveryNotify, bool allowUnicode, out SmtpFailedRecipientException exception)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		MailCommand.Send(connection, SmtpCommands.Mail, sender, allowUnicode);
		failedRecipientExceptions.Clear();
		exception = null;
		foreach (MailAddress recipient in recipients)
		{
			string smtpAddress = recipient.GetSmtpAddress(allowUnicode);
			string to = smtpAddress + (connection.DSNEnabled ? deliveryNotify : string.Empty);
			if (!RecipientCommand.Send(connection, to, out var response))
			{
				failedRecipientExceptions.Add(new SmtpFailedRecipientException(connection.Reader.StatusCode, smtpAddress, response));
			}
		}
		if (failedRecipientExceptions.Count > 0)
		{
			if (failedRecipientExceptions.Count == 1)
			{
				exception = (SmtpFailedRecipientException)failedRecipientExceptions[0];
			}
			else
			{
				exception = new SmtpFailedRecipientsException(failedRecipientExceptions, failedRecipientExceptions.Count == recipients.Count);
			}
			if (failedRecipientExceptions.Count == recipients.Count)
			{
				exception.fatal = true;
				throw exception;
			}
		}
		DataCommand.Send(connection);
		return new MailWriter(connection.GetClosableStream());
	}

	internal void CloseIdleConnections(ServicePoint servicePoint)
	{
		ConnectionPoolManager.CleanupConnectionPool(servicePoint, "");
	}
}
