using System.Collections.Specialized;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail;

public class MailMessage : IDisposable
{
	private AlternateViewCollection views;

	private AttachmentCollection attachments;

	private AlternateView bodyView;

	private string body = string.Empty;

	private Encoding bodyEncoding;

	private TransferEncoding bodyTransferEncoding = TransferEncoding.Unknown;

	private bool isBodyHtml;

	private bool disposed;

	private Message message;

	private DeliveryNotificationOptions deliveryStatusNotification;

	public MailAddress From
	{
		get
		{
			return message.From;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			message.From = value;
		}
	}

	public MailAddress Sender
	{
		get
		{
			return message.Sender;
		}
		set
		{
			message.Sender = value;
		}
	}

	[Obsolete("ReplyTo is obsoleted for this type.  Please use ReplyToList instead which can accept multiple addresses. http://go.microsoft.com/fwlink/?linkid=14202")]
	public MailAddress ReplyTo
	{
		get
		{
			return message.ReplyTo;
		}
		set
		{
			message.ReplyTo = value;
		}
	}

	public MailAddressCollection ReplyToList => message.ReplyToList;

	public MailAddressCollection To => message.To;

	public MailAddressCollection Bcc => message.Bcc;

	public MailAddressCollection CC => message.CC;

	public MailPriority Priority
	{
		get
		{
			return message.Priority;
		}
		set
		{
			message.Priority = value;
		}
	}

	public DeliveryNotificationOptions DeliveryNotificationOptions
	{
		get
		{
			return deliveryStatusNotification;
		}
		set
		{
			if (7u < (uint)value && value != DeliveryNotificationOptions.Never)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			deliveryStatusNotification = value;
		}
	}

	public string Subject
	{
		get
		{
			if (message.Subject == null)
			{
				return string.Empty;
			}
			return message.Subject;
		}
		set
		{
			message.Subject = value;
		}
	}

	public Encoding SubjectEncoding
	{
		get
		{
			return message.SubjectEncoding;
		}
		set
		{
			message.SubjectEncoding = value;
		}
	}

	public NameValueCollection Headers => message.Headers;

	public Encoding HeadersEncoding
	{
		get
		{
			return message.HeadersEncoding;
		}
		set
		{
			message.HeadersEncoding = value;
		}
	}

	public string Body
	{
		get
		{
			if (body == null)
			{
				return string.Empty;
			}
			return body;
		}
		set
		{
			body = value;
			if (bodyEncoding == null && body != null)
			{
				if (MimeBasePart.IsAscii(body, permitCROrLF: true))
				{
					bodyEncoding = Encoding.ASCII;
				}
				else
				{
					bodyEncoding = Encoding.GetEncoding("utf-8");
				}
			}
		}
	}

	public Encoding BodyEncoding
	{
		get
		{
			return bodyEncoding;
		}
		set
		{
			bodyEncoding = value;
		}
	}

	public TransferEncoding BodyTransferEncoding
	{
		get
		{
			return bodyTransferEncoding;
		}
		set
		{
			bodyTransferEncoding = value;
		}
	}

	public bool IsBodyHtml
	{
		get
		{
			return isBodyHtml;
		}
		set
		{
			isBodyHtml = value;
		}
	}

	public AttachmentCollection Attachments
	{
		get
		{
			if (disposed)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			if (attachments == null)
			{
				attachments = new AttachmentCollection();
			}
			return attachments;
		}
	}

	public AlternateViewCollection AlternateViews
	{
		get
		{
			if (disposed)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			if (views == null)
			{
				views = new AlternateViewCollection();
			}
			return views;
		}
	}

	public MailMessage()
	{
		message = new Message();
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, message);
		}
		string text = SmtpClient.MailConfiguration.Smtp.From;
		if (text != null && text.Length > 0)
		{
			message.From = new MailAddress(text);
		}
	}

	public MailMessage(string from, string to)
	{
		if (from == null)
		{
			throw new ArgumentNullException("from");
		}
		if (to == null)
		{
			throw new ArgumentNullException("to");
		}
		if (from == string.Empty)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "from"), "from");
		}
		if (to == string.Empty)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "to"), "to");
		}
		message = new Message(from, to);
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, message);
		}
	}

	public MailMessage(string from, string to, string subject, string body)
		: this(from, to)
	{
		Subject = subject;
		Body = body;
	}

	public MailMessage(MailAddress from, MailAddress to)
	{
		if (from == null)
		{
			throw new ArgumentNullException("from");
		}
		if (to == null)
		{
			throw new ArgumentNullException("to");
		}
		message = new Message(from, to);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			disposed = true;
			if (views != null)
			{
				views.Dispose();
			}
			if (attachments != null)
			{
				attachments.Dispose();
			}
			if (bodyView != null)
			{
				bodyView.Dispose();
			}
		}
	}

	private void SetContent(bool allowUnicode)
	{
		if (bodyView != null)
		{
			bodyView.Dispose();
			bodyView = null;
		}
		if (AlternateViews.Count == 0 && Attachments.Count == 0)
		{
			if (!string.IsNullOrEmpty(body))
			{
				bodyView = AlternateView.CreateAlternateViewFromString(body, bodyEncoding, isBodyHtml ? "text/html" : null);
				message.Content = bodyView.MimePart;
			}
		}
		else if (AlternateViews.Count == 0 && Attachments.Count > 0)
		{
			MimeMultiPart mimeMultiPart = new MimeMultiPart(MimeMultiPartType.Mixed);
			if (!string.IsNullOrEmpty(body))
			{
				bodyView = AlternateView.CreateAlternateViewFromString(body, bodyEncoding, isBodyHtml ? "text/html" : null);
			}
			else
			{
				bodyView = AlternateView.CreateAlternateViewFromString(string.Empty);
			}
			mimeMultiPart.Parts.Add(bodyView.MimePart);
			foreach (Attachment attachment in Attachments)
			{
				if (attachment != null)
				{
					attachment.PrepareForSending(allowUnicode);
					mimeMultiPart.Parts.Add(attachment.MimePart);
				}
			}
			message.Content = mimeMultiPart;
		}
		else
		{
			MimeMultiPart mimeMultiPart2 = null;
			MimeMultiPart mimeMultiPart3 = new MimeMultiPart(MimeMultiPartType.Alternative);
			if (!string.IsNullOrEmpty(body))
			{
				bodyView = AlternateView.CreateAlternateViewFromString(body, bodyEncoding, null);
				mimeMultiPart3.Parts.Add(bodyView.MimePart);
			}
			foreach (AlternateView alternateView in AlternateViews)
			{
				if (alternateView == null)
				{
					continue;
				}
				alternateView.PrepareForSending(allowUnicode);
				if (alternateView.LinkedResources.Count > 0)
				{
					MimeMultiPart mimeMultiPart4 = new MimeMultiPart(MimeMultiPartType.Related);
					mimeMultiPart4.ContentType.Parameters["type"] = alternateView.ContentType.MediaType;
					mimeMultiPart4.ContentLocation = alternateView.MimePart.ContentLocation;
					mimeMultiPart4.Parts.Add(alternateView.MimePart);
					foreach (LinkedResource linkedResource in alternateView.LinkedResources)
					{
						linkedResource.PrepareForSending(allowUnicode);
						mimeMultiPart4.Parts.Add(linkedResource.MimePart);
					}
					mimeMultiPart3.Parts.Add(mimeMultiPart4);
				}
				else
				{
					mimeMultiPart3.Parts.Add(alternateView.MimePart);
				}
			}
			if (Attachments.Count > 0)
			{
				mimeMultiPart2 = new MimeMultiPart(MimeMultiPartType.Mixed);
				mimeMultiPart2.Parts.Add(mimeMultiPart3);
				MimeMultiPart mimeMultiPart5 = new MimeMultiPart(MimeMultiPartType.Mixed);
				foreach (Attachment attachment2 in Attachments)
				{
					if (attachment2 != null)
					{
						attachment2.PrepareForSending(allowUnicode);
						mimeMultiPart5.Parts.Add(attachment2.MimePart);
					}
				}
				mimeMultiPart2.Parts.Add(mimeMultiPart5);
				message.Content = mimeMultiPart2;
			}
			else if (mimeMultiPart3.Parts.Count == 1 && string.IsNullOrEmpty(body))
			{
				message.Content = mimeMultiPart3.Parts[0];
			}
			else
			{
				message.Content = mimeMultiPart3;
			}
		}
		if (bodyView != null && bodyTransferEncoding != TransferEncoding.Unknown)
		{
			bodyView.TransferEncoding = bodyTransferEncoding;
		}
	}

	internal void Send(BaseWriter writer, bool sendEnvelope, bool allowUnicode)
	{
		SetContent(allowUnicode);
		message.Send(writer, sendEnvelope, allowUnicode);
	}

	internal IAsyncResult BeginSend(BaseWriter writer, bool sendEnvelope, bool allowUnicode, AsyncCallback callback, object state)
	{
		SetContent(allowUnicode);
		return message.BeginSend(writer, sendEnvelope, allowUnicode, callback, state);
	}

	internal void EndSend(IAsyncResult asyncResult)
	{
		message.EndSend(asyncResult);
	}

	internal string BuildDeliveryStatusNotificationString()
	{
		if (deliveryStatusNotification != DeliveryNotificationOptions.None)
		{
			StringBuilder stringBuilder = new StringBuilder(" NOTIFY=");
			bool flag = false;
			if (deliveryStatusNotification == DeliveryNotificationOptions.Never)
			{
				stringBuilder.Append("NEVER");
				return stringBuilder.ToString();
			}
			if ((deliveryStatusNotification & DeliveryNotificationOptions.OnSuccess) > DeliveryNotificationOptions.None)
			{
				stringBuilder.Append("SUCCESS");
				flag = true;
			}
			if ((deliveryStatusNotification & DeliveryNotificationOptions.OnFailure) > DeliveryNotificationOptions.None)
			{
				if (flag)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append("FAILURE");
				flag = true;
			}
			if ((deliveryStatusNotification & DeliveryNotificationOptions.Delay) > DeliveryNotificationOptions.None)
			{
				if (flag)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append("DELAY");
			}
			return stringBuilder.ToString();
		}
		return string.Empty;
	}
}
