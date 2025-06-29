using System.Net.Mime;
using System.Text;

namespace System.Net.Mail;

internal class Message
{
	internal class EmptySendContext
	{
		internal LazyAsyncResult result;

		internal BaseWriter writer;

		internal EmptySendContext(BaseWriter writer, LazyAsyncResult result)
		{
			this.writer = writer;
			this.result = result;
		}
	}

	private MailAddress from;

	private MailAddress sender;

	private MailAddressCollection replyToList;

	private MailAddress replyTo;

	private MailAddressCollection to;

	private MailAddressCollection cc;

	private MailAddressCollection bcc;

	private MimeBasePart content;

	private HeaderCollection headers;

	private HeaderCollection envelopeHeaders;

	private string subject;

	private Encoding subjectEncoding;

	private Encoding headersEncoding;

	private MailPriority priority = (MailPriority)(-1);

	public MailPriority Priority
	{
		get
		{
			if (priority != (MailPriority)(-1))
			{
				return priority;
			}
			return MailPriority.Normal;
		}
		set
		{
			priority = value;
		}
	}

	internal MailAddress From
	{
		get
		{
			return from;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			from = value;
		}
	}

	internal MailAddress Sender
	{
		get
		{
			return sender;
		}
		set
		{
			sender = value;
		}
	}

	internal MailAddress ReplyTo
	{
		get
		{
			return replyTo;
		}
		set
		{
			replyTo = value;
		}
	}

	internal MailAddressCollection ReplyToList
	{
		get
		{
			if (replyToList == null)
			{
				replyToList = new MailAddressCollection();
			}
			return replyToList;
		}
	}

	internal MailAddressCollection To
	{
		get
		{
			if (to == null)
			{
				to = new MailAddressCollection();
			}
			return to;
		}
	}

	internal MailAddressCollection Bcc
	{
		get
		{
			if (bcc == null)
			{
				bcc = new MailAddressCollection();
			}
			return bcc;
		}
	}

	internal MailAddressCollection CC
	{
		get
		{
			if (cc == null)
			{
				cc = new MailAddressCollection();
			}
			return cc;
		}
	}

	internal string Subject
	{
		get
		{
			return subject;
		}
		set
		{
			Encoding encoding = null;
			try
			{
				encoding = MimeBasePart.DecodeEncoding(value);
			}
			catch (ArgumentException)
			{
			}
			if (encoding != null && value != null)
			{
				try
				{
					value = MimeBasePart.DecodeHeaderValue(value);
					subjectEncoding = subjectEncoding ?? encoding;
				}
				catch (FormatException)
				{
				}
			}
			if (value != null && MailBnfHelper.HasCROrLF(value))
			{
				throw new ArgumentException(SR.GetString("MailSubjectInvalidFormat"));
			}
			subject = value;
			if (subject != null)
			{
				subject = subject.Normalize(NormalizationForm.FormC);
				if (subjectEncoding == null && !MimeBasePart.IsAscii(subject, permitCROrLF: false))
				{
					subjectEncoding = Encoding.GetEncoding("utf-8");
				}
			}
		}
	}

	internal Encoding SubjectEncoding
	{
		get
		{
			return subjectEncoding;
		}
		set
		{
			subjectEncoding = value;
		}
	}

	internal HeaderCollection Headers
	{
		get
		{
			if (headers == null)
			{
				headers = new HeaderCollection();
				if (Logging.On)
				{
					Logging.Associate(Logging.Web, this, headers);
				}
			}
			return headers;
		}
	}

	internal Encoding HeadersEncoding
	{
		get
		{
			return headersEncoding;
		}
		set
		{
			headersEncoding = value;
		}
	}

	internal HeaderCollection EnvelopeHeaders
	{
		get
		{
			if (envelopeHeaders == null)
			{
				envelopeHeaders = new HeaderCollection();
				if (Logging.On)
				{
					Logging.Associate(Logging.Web, this, envelopeHeaders);
				}
			}
			return envelopeHeaders;
		}
	}

	internal virtual MimeBasePart Content
	{
		get
		{
			return content;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			content = value;
		}
	}

	internal Message()
	{
	}

	internal Message(string from, string to)
		: this()
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
		this.from = new MailAddress(from);
		this.to = new MailAddressCollection { to };
	}

	internal Message(MailAddress from, MailAddress to)
		: this()
	{
		this.from = from;
		To.Add(to);
	}

	internal void EmptySendCallback(IAsyncResult result)
	{
		Exception result2 = null;
		if (!result.CompletedSynchronously)
		{
			EmptySendContext emptySendContext = (EmptySendContext)result.AsyncState;
			try
			{
				emptySendContext.writer.EndGetContentStream(result).Close();
			}
			catch (Exception ex)
			{
				result2 = ex;
			}
			emptySendContext.result.InvokeCallback(result2);
		}
	}

	internal virtual IAsyncResult BeginSend(BaseWriter writer, bool sendEnvelope, bool allowUnicode, AsyncCallback callback, object state)
	{
		PrepareHeaders(sendEnvelope, allowUnicode);
		writer.WriteHeaders(Headers, allowUnicode);
		if (Content != null)
		{
			return Content.BeginSend(writer, callback, allowUnicode, state);
		}
		LazyAsyncResult result = new LazyAsyncResult(this, state, callback);
		IAsyncResult asyncResult = writer.BeginGetContentStream(EmptySendCallback, new EmptySendContext(writer, result));
		if (asyncResult.CompletedSynchronously)
		{
			writer.EndGetContentStream(asyncResult).Close();
		}
		return result;
	}

	internal virtual void EndSend(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (Content != null)
		{
			Content.EndSend(asyncResult);
			return;
		}
		if (!(asyncResult is LazyAsyncResult lazyAsyncResult) || lazyAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"));
		}
		if (lazyAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndSend"));
		}
		lazyAsyncResult.InternalWaitForCompletion();
		lazyAsyncResult.EndCalled = true;
		if (!(lazyAsyncResult.Result is Exception))
		{
			return;
		}
		throw (Exception)lazyAsyncResult.Result;
	}

	internal virtual void Send(BaseWriter writer, bool sendEnvelope, bool allowUnicode)
	{
		if (sendEnvelope)
		{
			PrepareEnvelopeHeaders(sendEnvelope, allowUnicode);
			writer.WriteHeaders(EnvelopeHeaders, allowUnicode);
		}
		PrepareHeaders(sendEnvelope, allowUnicode);
		writer.WriteHeaders(Headers, allowUnicode);
		if (Content != null)
		{
			Content.Send(writer, allowUnicode);
		}
		else
		{
			writer.GetContentStream().Close();
		}
	}

	internal void PrepareEnvelopeHeaders(bool sendEnvelope, bool allowUnicode)
	{
		if (headersEncoding == null)
		{
			headersEncoding = Encoding.GetEncoding("utf-8");
		}
		EncodeHeaders(EnvelopeHeaders, allowUnicode);
		string text = MailHeaderInfo.GetString(MailHeaderID.XSender);
		if (!IsHeaderSet(text))
		{
			MailAddress mailAddress = Sender ?? From;
			EnvelopeHeaders.InternalSet(text, mailAddress.Encode(text.Length, allowUnicode));
		}
		string text2 = MailHeaderInfo.GetString(MailHeaderID.XReceiver);
		EnvelopeHeaders.Remove(text2);
		foreach (MailAddress item in To)
		{
			EnvelopeHeaders.InternalAdd(text2, item.Encode(text2.Length, allowUnicode));
		}
		foreach (MailAddress item2 in CC)
		{
			EnvelopeHeaders.InternalAdd(text2, item2.Encode(text2.Length, allowUnicode));
		}
		foreach (MailAddress item3 in Bcc)
		{
			EnvelopeHeaders.InternalAdd(text2, item3.Encode(text2.Length, allowUnicode));
		}
	}

	internal void PrepareHeaders(bool sendEnvelope, bool allowUnicode)
	{
		if (headersEncoding == null)
		{
			headersEncoding = Encoding.GetEncoding("utf-8");
		}
		Headers.Remove(MailHeaderInfo.GetString(MailHeaderID.ContentType));
		Headers[MailHeaderInfo.GetString(MailHeaderID.MimeVersion)] = "1.0";
		string text = MailHeaderInfo.GetString(MailHeaderID.Sender);
		if (Sender != null)
		{
			Headers.InternalAdd(text, Sender.Encode(text.Length, allowUnicode));
		}
		else
		{
			Headers.Remove(text);
		}
		text = MailHeaderInfo.GetString(MailHeaderID.From);
		Headers.InternalAdd(text, From.Encode(text.Length, allowUnicode));
		text = MailHeaderInfo.GetString(MailHeaderID.To);
		if (To.Count > 0)
		{
			Headers.InternalAdd(text, To.Encode(text.Length, allowUnicode));
		}
		else
		{
			Headers.Remove(text);
		}
		text = MailHeaderInfo.GetString(MailHeaderID.Cc);
		if (CC.Count > 0)
		{
			Headers.InternalAdd(text, CC.Encode(text.Length, allowUnicode));
		}
		else
		{
			Headers.Remove(text);
		}
		text = MailHeaderInfo.GetString(MailHeaderID.ReplyTo);
		if (ReplyTo != null)
		{
			Headers.InternalAdd(text, ReplyTo.Encode(text.Length, allowUnicode));
		}
		else if (ReplyToList.Count > 0)
		{
			Headers.InternalAdd(text, ReplyToList.Encode(text.Length, allowUnicode));
		}
		else
		{
			Headers.Remove(text);
		}
		Headers.Remove(MailHeaderInfo.GetString(MailHeaderID.Bcc));
		if (priority == MailPriority.High)
		{
			Headers[MailHeaderInfo.GetString(MailHeaderID.XPriority)] = "1";
			Headers[MailHeaderInfo.GetString(MailHeaderID.Priority)] = "urgent";
			Headers[MailHeaderInfo.GetString(MailHeaderID.Importance)] = "high";
		}
		else if (priority == MailPriority.Low)
		{
			Headers[MailHeaderInfo.GetString(MailHeaderID.XPriority)] = "5";
			Headers[MailHeaderInfo.GetString(MailHeaderID.Priority)] = "non-urgent";
			Headers[MailHeaderInfo.GetString(MailHeaderID.Importance)] = "low";
		}
		else if (priority != (MailPriority)(-1))
		{
			Headers.Remove(MailHeaderInfo.GetString(MailHeaderID.XPriority));
			Headers.Remove(MailHeaderInfo.GetString(MailHeaderID.Priority));
			Headers.Remove(MailHeaderInfo.GetString(MailHeaderID.Importance));
		}
		Headers.InternalAdd(MailHeaderInfo.GetString(MailHeaderID.Date), MailBnfHelper.GetDateTimeString(DateTime.Now, null));
		text = MailHeaderInfo.GetString(MailHeaderID.Subject);
		if (!string.IsNullOrEmpty(subject))
		{
			if (allowUnicode)
			{
				Headers.InternalAdd(text, subject);
			}
			else
			{
				Headers.InternalAdd(text, MimeBasePart.EncodeHeaderValue(subject, subjectEncoding, MimeBasePart.ShouldUseBase64Encoding(subjectEncoding), text.Length));
			}
		}
		else
		{
			Headers.Remove(text);
		}
		EncodeHeaders(headers, allowUnicode);
	}

	internal void EncodeHeaders(HeaderCollection headers, bool allowUnicode)
	{
		if (headersEncoding == null)
		{
			headersEncoding = Encoding.GetEncoding("utf-8");
		}
		for (int i = 0; i < headers.Count; i++)
		{
			string key = headers.GetKey(i);
			if (!MailHeaderInfo.IsUserSettable(key))
			{
				continue;
			}
			string[] values = headers.GetValues(key);
			string empty = string.Empty;
			for (int j = 0; j < values.Length; j++)
			{
				empty = ((!MimeBasePart.IsAscii(values[j], permitCROrLF: false) && (!allowUnicode || !MailHeaderInfo.AllowsUnicode(key) || MailBnfHelper.HasCROrLF(values[j]))) ? MimeBasePart.EncodeHeaderValue(values[j], headersEncoding, MimeBasePart.ShouldUseBase64Encoding(headersEncoding), key.Length) : values[j]);
				if (j == 0)
				{
					headers.Set(key, empty);
				}
				else
				{
					headers.Add(key, empty);
				}
			}
		}
	}

	private bool IsHeaderSet(string headerName)
	{
		for (int i = 0; i < Headers.Count; i++)
		{
			if (string.Compare(Headers.GetKey(i), headerName, StringComparison.InvariantCultureIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}
}
