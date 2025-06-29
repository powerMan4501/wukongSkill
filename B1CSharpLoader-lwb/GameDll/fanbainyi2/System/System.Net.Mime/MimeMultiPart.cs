using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Threading;

namespace System.Net.Mime;

internal class MimeMultiPart : MimeBasePart
{
	internal class MimePartContext
	{
		internal IEnumerator<MimeBasePart> partsEnumerator;

		internal Stream outputStream;

		internal LazyAsyncResult result;

		internal BaseWriter writer;

		internal bool completed;

		internal bool completedSynchronously = true;

		internal MimePartContext(BaseWriter writer, LazyAsyncResult result, IEnumerator<MimeBasePart> partsEnumerator)
		{
			this.writer = writer;
			this.result = result;
			this.partsEnumerator = partsEnumerator;
		}
	}

	private Collection<MimeBasePart> parts;

	private static int boundary;

	private AsyncCallback mimePartSentCallback;

	private bool allowUnicode;

	internal MimeMultiPartType MimeMultiPartType
	{
		set
		{
			if (value > MimeMultiPartType.Related || value < MimeMultiPartType.Mixed)
			{
				throw new NotSupportedException(value.ToString());
			}
			SetType(value);
		}
	}

	internal Collection<MimeBasePart> Parts
	{
		get
		{
			if (parts == null)
			{
				parts = new Collection<MimeBasePart>();
			}
			return parts;
		}
	}

	internal MimeMultiPart(MimeMultiPartType type)
	{
		MimeMultiPartType = type;
	}

	private void SetType(MimeMultiPartType type)
	{
		base.ContentType.MediaType = "multipart/" + type.ToString().ToLower(CultureInfo.InvariantCulture);
		base.ContentType.Boundary = GetNextBoundary();
	}

	internal void Complete(IAsyncResult result, Exception e)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		if (mimePartContext.completed)
		{
			throw e;
		}
		try
		{
			mimePartContext.outputStream.Close();
		}
		catch (Exception ex)
		{
			if (e == null)
			{
				e = ex;
			}
		}
		mimePartContext.completed = true;
		mimePartContext.result.InvokeCallback(e);
	}

	internal void MimeWriterCloseCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		((MimePartContext)result.AsyncState).completedSynchronously = false;
		try
		{
			MimeWriterCloseCallbackHandler(result);
		}
		catch (Exception e)
		{
			Complete(result, e);
		}
	}

	private void MimeWriterCloseCallbackHandler(IAsyncResult result)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		((MimeWriter)mimePartContext.writer).EndClose(result);
		Complete(result, null);
	}

	internal void MimePartSentCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		((MimePartContext)result.AsyncState).completedSynchronously = false;
		try
		{
			MimePartSentCallbackHandler(result);
		}
		catch (Exception e)
		{
			Complete(result, e);
		}
	}

	private void MimePartSentCallbackHandler(IAsyncResult result)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		MimeBasePart current = mimePartContext.partsEnumerator.Current;
		current.EndSend(result);
		if (mimePartContext.partsEnumerator.MoveNext())
		{
			current = mimePartContext.partsEnumerator.Current;
			IAsyncResult asyncResult = current.BeginSend(mimePartContext.writer, mimePartSentCallback, allowUnicode, mimePartContext);
			if (asyncResult.CompletedSynchronously)
			{
				MimePartSentCallbackHandler(asyncResult);
			}
		}
		else
		{
			IAsyncResult asyncResult2 = ((MimeWriter)mimePartContext.writer).BeginClose(MimeWriterCloseCallback, mimePartContext);
			if (asyncResult2.CompletedSynchronously)
			{
				MimeWriterCloseCallbackHandler(asyncResult2);
			}
		}
	}

	internal void ContentStreamCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		((MimePartContext)result.AsyncState).completedSynchronously = false;
		try
		{
			ContentStreamCallbackHandler(result);
		}
		catch (Exception e)
		{
			Complete(result, e);
		}
	}

	private void ContentStreamCallbackHandler(IAsyncResult result)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		mimePartContext.outputStream = mimePartContext.writer.EndGetContentStream(result);
		mimePartContext.writer = new MimeWriter(mimePartContext.outputStream, base.ContentType.Boundary);
		if (mimePartContext.partsEnumerator.MoveNext())
		{
			MimeBasePart current = mimePartContext.partsEnumerator.Current;
			mimePartSentCallback = MimePartSentCallback;
			IAsyncResult asyncResult = current.BeginSend(mimePartContext.writer, mimePartSentCallback, allowUnicode, mimePartContext);
			if (asyncResult.CompletedSynchronously)
			{
				MimePartSentCallbackHandler(asyncResult);
			}
		}
		else
		{
			IAsyncResult asyncResult2 = ((MimeWriter)mimePartContext.writer).BeginClose(MimeWriterCloseCallback, mimePartContext);
			if (asyncResult2.CompletedSynchronously)
			{
				MimeWriterCloseCallbackHandler(asyncResult2);
			}
		}
	}

	internal override IAsyncResult BeginSend(BaseWriter writer, AsyncCallback callback, bool allowUnicode, object state)
	{
		this.allowUnicode = allowUnicode;
		PrepareHeaders(allowUnicode);
		writer.WriteHeaders(base.Headers, allowUnicode);
		MimePartAsyncResult result = new MimePartAsyncResult(this, state, callback);
		MimePartContext state2 = new MimePartContext(writer, result, Parts.GetEnumerator());
		IAsyncResult asyncResult = writer.BeginGetContentStream(ContentStreamCallback, state2);
		if (asyncResult.CompletedSynchronously)
		{
			ContentStreamCallbackHandler(asyncResult);
		}
		return result;
	}

	internal override void Send(BaseWriter writer, bool allowUnicode)
	{
		PrepareHeaders(allowUnicode);
		writer.WriteHeaders(base.Headers, allowUnicode);
		Stream contentStream = writer.GetContentStream();
		MimeWriter mimeWriter = new MimeWriter(contentStream, base.ContentType.Boundary);
		foreach (MimeBasePart part in Parts)
		{
			part.Send(mimeWriter, allowUnicode);
		}
		mimeWriter.Close();
		contentStream.Close();
	}

	internal string GetNextBoundary()
	{
		return "--boundary_" + (Interlocked.Increment(ref boundary) - 1).ToString(CultureInfo.InvariantCulture) + "_" + Guid.NewGuid().ToString(null, CultureInfo.InvariantCulture);
	}
}
