using System.IO;
using System.Text;

namespace System.Net;

internal class CommandStream : PooledStream
{
	internal enum PipelineInstruction
	{
		Abort,
		Advance,
		Pause,
		Reread,
		GiveStream
	}

	[Flags]
	internal enum PipelineEntryFlags
	{
		UserCommand = 1,
		GiveDataStream = 2,
		CreateDataConnection = 4,
		DontLogParameter = 8
	}

	internal class PipelineEntry
	{
		internal string Command;

		internal PipelineEntryFlags Flags;

		internal PipelineEntry(string command)
		{
			Command = command;
		}

		internal PipelineEntry(string command, PipelineEntryFlags flags)
		{
			Command = command;
			Flags = flags;
		}

		internal bool HasFlag(PipelineEntryFlags flags)
		{
			return (Flags & flags) != 0;
		}
	}

	private static readonly AsyncCallback m_WriteCallbackDelegate = WriteCallback;

	private static readonly AsyncCallback m_ReadCallbackDelegate = ReadCallback;

	private bool m_RecoverableFailure;

	protected WebRequest m_Request;

	protected bool m_Async;

	private bool m_Aborted;

	protected PipelineEntry[] m_Commands;

	protected int m_Index;

	private bool m_DoRead;

	private bool m_DoSend;

	private ResponseDescription m_CurrentResponseDescription;

	protected string m_AbortReason;

	private const int _WaitingForPipeline = 1;

	private const int _CompletedPipeline = 2;

	private string m_Buffer = string.Empty;

	private Encoding m_Encoding = Encoding.UTF8;

	private Decoder m_Decoder;

	internal bool RecoverableFailure => m_RecoverableFailure;

	protected Encoding Encoding
	{
		get
		{
			return m_Encoding;
		}
		set
		{
			m_Encoding = value;
			m_Decoder = m_Encoding.GetDecoder();
		}
	}

	internal CommandStream(ConnectionPool connectionPool, TimeSpan lifetime, bool checkLifetime)
		: base(connectionPool, lifetime, checkLifetime)
	{
		m_Decoder = m_Encoding.GetDecoder();
	}

	internal virtual void Abort(Exception e)
	{
		lock (this)
		{
			if (m_Aborted)
			{
				return;
			}
			m_Aborted = true;
			base.CanBePooled = false;
		}
		try
		{
			Close(0);
		}
		finally
		{
			if (e != null)
			{
				InvokeRequestCallback(e);
			}
			else
			{
				InvokeRequestCallback(null);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		InvokeRequestCallback(null);
	}

	protected void InvokeRequestCallback(object obj)
	{
		m_Request?.RequestCallback(obj);
	}

	protected void MarkAsRecoverableFailure()
	{
		if (m_Index <= 1)
		{
			m_RecoverableFailure = true;
		}
	}

	internal Stream SubmitRequest(WebRequest request, bool async, bool readInitalResponseOnConnect)
	{
		ClearState();
		UpdateLifetime();
		PipelineEntry[] commands = BuildCommandsList(request);
		InitCommandPipeline(request, commands, async);
		if (readInitalResponseOnConnect && base.JustConnected)
		{
			m_DoSend = false;
			m_Index = -1;
		}
		return ContinueCommandPipeline();
	}

	protected virtual void ClearState()
	{
		InitCommandPipeline(null, null, async: false);
	}

	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request)
	{
		return null;
	}

	protected Exception GenerateException(WebExceptionStatus status, Exception innerException)
	{
		return new WebException(NetRes.GetWebStatusString("net_connclosed", status), innerException, status, null);
	}

	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
	{
		return new WebException(SR.GetString("net_servererror", NetRes.GetWebStatusCodeString(code, statusDescription)), innerException, WebExceptionStatus.ProtocolError, null);
	}

	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool async)
	{
		m_Commands = commands;
		m_Index = 0;
		m_Request = request;
		m_Aborted = false;
		m_DoRead = true;
		m_DoSend = true;
		m_CurrentResponseDescription = null;
		m_Async = async;
		m_RecoverableFailure = false;
		m_AbortReason = string.Empty;
	}

	internal void CheckContinuePipeline()
	{
		if (m_Async)
		{
			return;
		}
		try
		{
			ContinueCommandPipeline();
		}
		catch (Exception e)
		{
			Abort(e);
		}
	}

	protected Stream ContinueCommandPipeline()
	{
		bool async = m_Async;
		while (m_Index < m_Commands.Length)
		{
			if (m_DoSend)
			{
				if (m_Index < 0)
				{
					throw new InternalException();
				}
				byte[] bytes = Encoding.GetBytes(m_Commands[m_Index].Command);
				if (Logging.On)
				{
					string text = m_Commands[m_Index].Command.Substring(0, m_Commands[m_Index].Command.Length - 2);
					if (m_Commands[m_Index].HasFlag(PipelineEntryFlags.DontLogParameter))
					{
						int num = text.IndexOf(' ');
						if (num != -1)
						{
							text = text.Substring(0, num) + " ********";
						}
					}
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_sending_command", text));
				}
				try
				{
					if (async)
					{
						BeginWrite(bytes, 0, bytes.Length, m_WriteCallbackDelegate, this);
					}
					else
					{
						Write(bytes, 0, bytes.Length);
					}
				}
				catch (IOException)
				{
					MarkAsRecoverableFailure();
					throw;
				}
				catch
				{
					throw;
				}
				if (async)
				{
					return null;
				}
			}
			Stream stream = null;
			if (PostSendCommandProcessing(ref stream))
			{
				return stream;
			}
		}
		lock (this)
		{
			Close();
		}
		return null;
	}

	private bool PostSendCommandProcessing(ref Stream stream)
	{
		if (m_DoRead)
		{
			bool async = m_Async;
			int index = m_Index;
			PipelineEntry[] commands = m_Commands;
			try
			{
				ResponseDescription currentResponseDescription = ReceiveCommandResponse();
				if (async)
				{
					return true;
				}
				m_CurrentResponseDescription = currentResponseDescription;
			}
			catch
			{
				if (index < 0 || index >= commands.Length || commands[index].Command != "QUIT\r\n")
				{
					throw;
				}
			}
		}
		return PostReadCommandProcessing(ref stream);
	}

	private bool PostReadCommandProcessing(ref Stream stream)
	{
		if (m_Index >= m_Commands.Length)
		{
			return false;
		}
		m_DoSend = false;
		m_DoRead = false;
		PipelineEntry pipelineEntry = ((m_Index != -1) ? m_Commands[m_Index] : null);
		switch ((m_CurrentResponseDescription == null && pipelineEntry.Command == "QUIT\r\n") ? PipelineInstruction.Advance : PipelineCallback(pipelineEntry, m_CurrentResponseDescription, timeout: false, ref stream))
		{
		case PipelineInstruction.Abort:
		{
			Exception ex = ((!(m_AbortReason != string.Empty)) ? GenerateException(WebExceptionStatus.ServerProtocolViolation, null) : new WebException(m_AbortReason));
			Abort(ex);
			throw ex;
		}
		case PipelineInstruction.Advance:
			m_CurrentResponseDescription = null;
			m_DoSend = true;
			m_DoRead = true;
			m_Index++;
			break;
		case PipelineInstruction.Pause:
			return true;
		case PipelineInstruction.GiveStream:
			m_CurrentResponseDescription = null;
			m_DoRead = true;
			if (m_Async)
			{
				ContinueCommandPipeline();
				InvokeRequestCallback(stream);
			}
			return true;
		case PipelineInstruction.Reread:
			m_CurrentResponseDescription = null;
			m_DoRead = true;
			break;
		}
		return false;
	}

	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
	{
		return PipelineInstruction.Abort;
	}

	private static void ReadCallback(IAsyncResult asyncResult)
	{
		ReceiveState receiveState = (ReceiveState)asyncResult.AsyncState;
		try
		{
			Stream connection = receiveState.Connection;
			int num = 0;
			try
			{
				num = connection.EndRead(asyncResult);
				if (num == 0)
				{
					receiveState.Connection.CloseSocket();
				}
			}
			catch (IOException)
			{
				receiveState.Connection.MarkAsRecoverableFailure();
				throw;
			}
			catch
			{
				throw;
			}
			receiveState.Connection.ReceiveCommandResponseCallback(receiveState, num);
		}
		catch (Exception e)
		{
			receiveState.Connection.Abort(e);
		}
	}

	private static void WriteCallback(IAsyncResult asyncResult)
	{
		CommandStream commandStream = (CommandStream)asyncResult.AsyncState;
		try
		{
			try
			{
				commandStream.EndWrite(asyncResult);
			}
			catch (IOException)
			{
				commandStream.MarkAsRecoverableFailure();
				throw;
			}
			catch
			{
				throw;
			}
			Stream stream = null;
			if (!commandStream.PostSendCommandProcessing(ref stream))
			{
				commandStream.ContinueCommandPipeline();
			}
		}
		catch (Exception e)
		{
			commandStream.Abort(e);
		}
	}

	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
	{
		return false;
	}

	private ResponseDescription ReceiveCommandResponse()
	{
		ReceiveState receiveState = new ReceiveState(this);
		try
		{
			if (m_Buffer.Length > 0)
			{
				ReceiveCommandResponseCallback(receiveState, -1);
			}
			else
			{
				try
				{
					if (m_Async)
					{
						BeginRead(receiveState.Buffer, 0, receiveState.Buffer.Length, m_ReadCallbackDelegate, receiveState);
						return null;
					}
					int num = Read(receiveState.Buffer, 0, receiveState.Buffer.Length);
					if (num == 0)
					{
						CloseSocket();
					}
					ReceiveCommandResponseCallback(receiveState, num);
				}
				catch (IOException)
				{
					MarkAsRecoverableFailure();
					throw;
				}
				catch
				{
					throw;
				}
			}
		}
		catch (Exception ex2)
		{
			if (ex2 is WebException)
			{
				throw;
			}
			throw GenerateException(WebExceptionStatus.ReceiveFailure, ex2);
		}
		return receiveState.Resp;
	}

	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
	{
		int completeLength = -1;
		while (true)
		{
			int validThrough = state.ValidThrough;
			if (m_Buffer.Length > 0)
			{
				state.Resp.StatusBuffer.Append(m_Buffer);
				m_Buffer = string.Empty;
				if (!CheckValid(state.Resp, ref validThrough, ref completeLength))
				{
					throw GenerateException(WebExceptionStatus.ServerProtocolViolation, null);
				}
			}
			else
			{
				if (bytesRead <= 0)
				{
					throw GenerateException(WebExceptionStatus.ServerProtocolViolation, null);
				}
				char[] array = new char[m_Decoder.GetCharCount(state.Buffer, 0, bytesRead)];
				int chars = m_Decoder.GetChars(state.Buffer, 0, bytesRead, array, 0, flush: false);
				string text = new string(array, 0, chars);
				state.Resp.StatusBuffer.Append(text);
				if (!CheckValid(state.Resp, ref validThrough, ref completeLength))
				{
					throw GenerateException(WebExceptionStatus.ServerProtocolViolation, null);
				}
				if (completeLength >= 0)
				{
					int num = state.Resp.StatusBuffer.Length - completeLength;
					if (num > 0)
					{
						m_Buffer = text.Substring(text.Length - num, num);
					}
				}
			}
			if (completeLength >= 0)
			{
				break;
			}
			state.ValidThrough = validThrough;
			try
			{
				if (m_Async)
				{
					BeginRead(state.Buffer, 0, state.Buffer.Length, m_ReadCallbackDelegate, state);
					return;
				}
				bytesRead = Read(state.Buffer, 0, state.Buffer.Length);
				if (bytesRead == 0)
				{
					CloseSocket();
				}
			}
			catch (IOException)
			{
				MarkAsRecoverableFailure();
				throw;
			}
			catch
			{
				throw;
			}
		}
		string text2 = state.Resp.StatusBuffer.ToString();
		state.Resp.StatusDescription = text2.Substring(0, completeLength);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_received_response", text2.Substring(0, completeLength - 2)));
		}
		if (m_Async)
		{
			if (state.Resp != null)
			{
				m_CurrentResponseDescription = state.Resp;
			}
			Stream stream = null;
			if (!PostReadCommandProcessing(ref stream))
			{
				ContinueCommandPipeline();
			}
		}
	}
}
