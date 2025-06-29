using System.Collections;
using System.IO;
using System.Net.Mime;

namespace System.Net.Mail;

internal class SendMailAsyncResult : LazyAsyncResult
{
	private SmtpConnection connection;

	private MailAddress from;

	private string deliveryNotify;

	private static AsyncCallback sendMailFromCompleted = SendMailFromCompleted;

	private static AsyncCallback sendToCollectionCompleted = SendToCollectionCompleted;

	private static AsyncCallback sendDataCompleted = SendDataCompleted;

	private ArrayList failedRecipientExceptions = new ArrayList();

	private Stream stream;

	private MailAddressCollection toCollection;

	private int toIndex;

	private bool allowUnicode;

	internal SendMailAsyncResult(SmtpConnection connection, MailAddress from, MailAddressCollection toCollection, bool allowUnicode, string deliveryNotify, AsyncCallback callback, object state)
		: base(null, state, callback)
	{
		this.toCollection = toCollection;
		this.connection = connection;
		this.from = from;
		this.deliveryNotify = deliveryNotify;
		this.allowUnicode = allowUnicode;
	}

	internal void Send()
	{
		SendMailFrom();
	}

	internal static MailWriter End(IAsyncResult result)
	{
		SendMailAsyncResult sendMailAsyncResult = (SendMailAsyncResult)result;
		object obj = sendMailAsyncResult.InternalWaitForCompletion();
		if (obj is Exception && (!(obj is SmtpFailedRecipientException) || ((SmtpFailedRecipientException)obj).fatal))
		{
			throw (Exception)obj;
		}
		return new MailWriter(sendMailAsyncResult.stream);
	}

	private void SendMailFrom()
	{
		IAsyncResult asyncResult = MailCommand.BeginSend(connection, SmtpCommands.Mail, from, allowUnicode, sendMailFromCompleted, this);
		if (asyncResult.CompletedSynchronously)
		{
			MailCommand.EndSend(asyncResult);
			SendToCollection();
		}
	}

	private static void SendMailFromCompleted(IAsyncResult result)
	{
		if (!result.CompletedSynchronously)
		{
			SendMailAsyncResult sendMailAsyncResult = (SendMailAsyncResult)result.AsyncState;
			try
			{
				MailCommand.EndSend(result);
				sendMailAsyncResult.SendToCollection();
			}
			catch (Exception result2)
			{
				sendMailAsyncResult.InvokeCallback(result2);
			}
		}
	}

	private void SendToCollection()
	{
		while (toIndex < toCollection.Count)
		{
			MultiAsyncResult multiAsyncResult = (MultiAsyncResult)RecipientCommand.BeginSend(connection, toCollection[toIndex++].GetSmtpAddress(allowUnicode) + deliveryNotify, sendToCollectionCompleted, this);
			if (!multiAsyncResult.CompletedSynchronously)
			{
				return;
			}
			if (!RecipientCommand.EndSend(multiAsyncResult, out var response))
			{
				failedRecipientExceptions.Add(new SmtpFailedRecipientException(connection.Reader.StatusCode, toCollection[toIndex - 1].GetSmtpAddress(allowUnicode), response));
			}
		}
		SendData();
	}

	private static void SendToCollectionCompleted(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		SendMailAsyncResult sendMailAsyncResult = (SendMailAsyncResult)result.AsyncState;
		try
		{
			if (!RecipientCommand.EndSend(result, out var response))
			{
				sendMailAsyncResult.failedRecipientExceptions.Add(new SmtpFailedRecipientException(sendMailAsyncResult.connection.Reader.StatusCode, sendMailAsyncResult.toCollection[sendMailAsyncResult.toIndex - 1].GetSmtpAddress(sendMailAsyncResult.allowUnicode), response));
				if (sendMailAsyncResult.failedRecipientExceptions.Count == sendMailAsyncResult.toCollection.Count)
				{
					SmtpFailedRecipientException ex = null;
					ex = ((sendMailAsyncResult.toCollection.Count != 1) ? new SmtpFailedRecipientsException(sendMailAsyncResult.failedRecipientExceptions, allFailed: true) : ((SmtpFailedRecipientException)sendMailAsyncResult.failedRecipientExceptions[0]));
					ex.fatal = true;
					sendMailAsyncResult.InvokeCallback(ex);
					return;
				}
			}
			sendMailAsyncResult.SendToCollection();
		}
		catch (Exception result2)
		{
			sendMailAsyncResult.InvokeCallback(result2);
		}
	}

	private void SendData()
	{
		IAsyncResult asyncResult = DataCommand.BeginSend(connection, sendDataCompleted, this);
		if (asyncResult.CompletedSynchronously)
		{
			DataCommand.EndSend(asyncResult);
			stream = connection.GetClosableStream();
			if (failedRecipientExceptions.Count > 1)
			{
				InvokeCallback(new SmtpFailedRecipientsException(failedRecipientExceptions, failedRecipientExceptions.Count == toCollection.Count));
			}
			else if (failedRecipientExceptions.Count == 1)
			{
				InvokeCallback(failedRecipientExceptions[0]);
			}
			else
			{
				InvokeCallback();
			}
		}
	}

	private static void SendDataCompleted(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		SendMailAsyncResult sendMailAsyncResult = (SendMailAsyncResult)result.AsyncState;
		try
		{
			DataCommand.EndSend(result);
			sendMailAsyncResult.stream = sendMailAsyncResult.connection.GetClosableStream();
			if (sendMailAsyncResult.failedRecipientExceptions.Count > 1)
			{
				sendMailAsyncResult.InvokeCallback(new SmtpFailedRecipientsException(sendMailAsyncResult.failedRecipientExceptions, sendMailAsyncResult.failedRecipientExceptions.Count == sendMailAsyncResult.toCollection.Count));
			}
			else if (sendMailAsyncResult.failedRecipientExceptions.Count == 1)
			{
				sendMailAsyncResult.InvokeCallback(sendMailAsyncResult.failedRecipientExceptions[0]);
			}
			else
			{
				sendMailAsyncResult.InvokeCallback();
			}
		}
		catch (Exception result2)
		{
			sendMailAsyncResult.InvokeCallback(result2);
		}
	}

	internal SmtpFailedRecipientException GetFailedRecipientException()
	{
		if (failedRecipientExceptions.Count == 1)
		{
			return (SmtpFailedRecipientException)failedRecipientExceptions[0];
		}
		if (failedRecipientExceptions.Count > 1)
		{
			return new SmtpFailedRecipientsException(failedRecipientExceptions, allFailed: false);
		}
		return null;
	}
}
