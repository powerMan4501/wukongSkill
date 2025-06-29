using System.Collections;
using System.Globalization;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventSchemaTraceListener : TextWriterTraceListener
{
	private sealed class TraceWriter : TextWriter
	{
		private Encoding encNoBOMwithFallback;

		private Stream stream;

		private object m_lockObject = new object();

		public override Encoding Encoding
		{
			get
			{
				if (encNoBOMwithFallback == null)
				{
					lock (m_lockObject)
					{
						if (encNoBOMwithFallback == null)
						{
							encNoBOMwithFallback = GetEncodingWithFallback(new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
						}
					}
				}
				return encNoBOMwithFallback;
			}
		}

		[SecurityCritical]
		internal TraceWriter(string _fileName, int bufferSize, TraceLogRetentionOption retention, long maxFileSize, int maxNumberOfFiles)
			: base(CultureInfo.InvariantCulture)
		{
			stream = new LogStream(_fileName, bufferSize, (LogRetentionOption)retention, maxFileSize, maxNumberOfFiles);
		}

		private static Encoding GetEncodingWithFallback(Encoding encoding)
		{
			Encoding encoding2 = (Encoding)encoding.Clone();
			encoding2.EncoderFallback = EncoderFallback.ReplacementFallback;
			encoding2.DecoderFallback = DecoderFallback.ReplacementFallback;
			return encoding2;
		}

		public override void Write(string value)
		{
			try
			{
				byte[] bytes = Encoding.GetBytes(value);
				stream.Write(bytes, 0, bytes.Length);
			}
			catch (Exception)
			{
				if (stream is BufferedStream2)
				{
					((BufferedStream2)stream).DiscardBuffer();
				}
			}
		}

		public override void Flush()
		{
			stream.Flush();
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					stream.Close();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
	}

	private const string s_optionBufferSize = "bufferSize";

	private const string s_optionLogRetention = "logRetentionOption";

	private const string s_optionMaximumFileSize = "maximumFileSize";

	private const string s_optionMaximumNumberOfFiles = "maximumNumberOfFiles";

	private const string s_userDataHeader = "<System.Diagnostics.UserData xmlns=\"http://schemas.microsoft.com/win/2006/09/System.Diagnostics/UserData/\">";

	private const string s_eventHeader = "<Event xmlns=\"http://schemas.microsoft.com/win/2004/08/events/event\"><System><Provider Guid=\"";

	private const int s_defaultPayloadSize = 512;

	private const int _retryThreshold = 2;

	private static readonly string machineName = Environment.MachineName;

	private TraceWriter traceWriter;

	private string fileName;

	private bool _initialized;

	private int _bufferSize = 32768;

	private TraceLogRetentionOption _retention = TraceLogRetentionOption.SingleFileUnboundedSize;

	private long _maxFileSize = 10240000L;

	private int _maxNumberOfFiles = 2;

	private readonly object m_lockObject = new object();

	public new TextWriter Writer
	{
		[SecurityCritical]
		get
		{
			EnsureWriter();
			return traceWriter;
		}
		set
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_SetTextWriter"));
		}
	}

	public override bool IsThreadSafe => true;

	public int BufferSize
	{
		get
		{
			Init();
			return _bufferSize;
		}
	}

	public TraceLogRetentionOption TraceLogRetentionOption
	{
		get
		{
			Init();
			return _retention;
		}
	}

	public long MaximumFileSize
	{
		get
		{
			Init();
			return _maxFileSize;
		}
	}

	public int MaximumNumberOfFiles
	{
		get
		{
			Init();
			return _maxNumberOfFiles;
		}
	}

	public EventSchemaTraceListener(string fileName)
		: this(fileName, string.Empty)
	{
	}

	public EventSchemaTraceListener(string fileName, string name)
		: this(fileName, name, 32768)
	{
	}

	public EventSchemaTraceListener(string fileName, string name, int bufferSize)
		: this(fileName, name, bufferSize, TraceLogRetentionOption.SingleFileUnboundedSize)
	{
	}

	public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption)
		: this(fileName, name, bufferSize, logRetentionOption, 10240000L)
	{
	}

	public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize)
		: this(fileName, name, bufferSize, logRetentionOption, maximumFileSize, 2)
	{
	}

	public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize, int maximumNumberOfFiles)
	{
		if (bufferSize < 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (logRetentionOption < TraceLogRetentionOption.UnlimitedSequentialFiles || logRetentionOption > TraceLogRetentionOption.SingleFileBoundedSize)
		{
			throw new ArgumentOutOfRangeException("logRetentionOption", System.SR.GetString("ArgumentOutOfRange_NeedValidLogRetention"));
		}
		base.Name = name;
		this.fileName = fileName;
		if (!string.IsNullOrEmpty(this.fileName) && fileName[0] != Path.DirectorySeparatorChar && fileName[0] != Path.AltDirectorySeparatorChar && !Path.IsPathRooted(fileName))
		{
			this.fileName = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile), this.fileName);
		}
		_retention = logRetentionOption;
		_bufferSize = bufferSize;
		_SetMaxFileSize(maximumFileSize, throwOnError: false);
		_SetMaxNumberOfFiles(maximumNumberOfFiles, throwOnError: false);
	}

	public override void Close()
	{
		try
		{
			if (traceWriter != null)
			{
				traceWriter.Flush();
				traceWriter.Close();
			}
		}
		finally
		{
			traceWriter = null;
			base.Close();
		}
	}

	[SecurityCritical]
	public override void Flush()
	{
		if (EnsureWriter())
		{
			traceWriter.Flush();
		}
	}

	public override void Write(string message)
	{
		WriteLine(message);
	}

	public override void WriteLine(string message)
	{
		TraceEvent(null, System.SR.GetString("TraceAsTraceSource"), TraceEventType.Information, 0, message);
	}

	public override void Fail(string message, string detailMessage)
	{
		StringBuilder stringBuilder = new StringBuilder(message);
		if (detailMessage != null)
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(detailMessage);
		}
		TraceEvent(null, System.SR.GetString("TraceAsTraceSource"), TraceEventType.Error, 0, stringBuilder.ToString());
	}

	[SecurityCritical]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
	{
		if (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, eventType, id, format, args, null, null))
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			BuildHeader(stringBuilder, source, eventType, id, eventCache, null, isUserData: false, base.TraceOutputOptions);
			string message = ((args == null) ? format : string.Format(CultureInfo.InvariantCulture, format, args));
			BuildMessage(stringBuilder, message);
			BuildFooter(stringBuilder, eventType, eventCache, isUserData: false, base.TraceOutputOptions);
			_InternalWriteRaw(stringBuilder);
		}
	}

	[SecurityCritical]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
	{
		if (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, eventType, id, message, null, null, null))
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			BuildHeader(stringBuilder, source, eventType, id, eventCache, null, isUserData: false, base.TraceOutputOptions);
			BuildMessage(stringBuilder, message);
			BuildFooter(stringBuilder, eventType, eventCache, isUserData: false, base.TraceOutputOptions);
			_InternalWriteRaw(stringBuilder);
		}
	}

	[SecurityCritical]
	public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
	{
		if (base.Filter == null || base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, data, null))
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			BuildHeader(stringBuilder, source, eventType, id, eventCache, null, isUserData: true, base.TraceOutputOptions);
			if (data != null)
			{
				_InternalBuildRaw(stringBuilder, "<System.Diagnostics.UserData xmlns=\"http://schemas.microsoft.com/win/2006/09/System.Diagnostics/UserData/\">");
				BuildUserData(stringBuilder, data);
				_InternalBuildRaw(stringBuilder, "</System.Diagnostics.UserData>");
			}
			BuildFooter(stringBuilder, eventType, eventCache, isUserData: true, base.TraceOutputOptions);
			_InternalWriteRaw(stringBuilder);
		}
	}

	[SecurityCritical]
	public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
	{
		if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, data))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(512);
		BuildHeader(stringBuilder, source, eventType, id, eventCache, null, isUserData: true, base.TraceOutputOptions);
		if (data != null && data.Length != 0)
		{
			_InternalBuildRaw(stringBuilder, "<System.Diagnostics.UserData xmlns=\"http://schemas.microsoft.com/win/2006/09/System.Diagnostics/UserData/\">");
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] != null)
				{
					BuildUserData(stringBuilder, data[i]);
				}
			}
			_InternalBuildRaw(stringBuilder, "</System.Diagnostics.UserData>");
		}
		BuildFooter(stringBuilder, eventType, eventCache, isUserData: true, base.TraceOutputOptions);
		_InternalWriteRaw(stringBuilder);
	}

	[SecurityCritical]
	public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		BuildHeader(stringBuilder, source, TraceEventType.Transfer, id, eventCache, relatedActivityId.ToString("B"), isUserData: false, base.TraceOutputOptions);
		BuildMessage(stringBuilder, message);
		BuildFooter(stringBuilder, TraceEventType.Transfer, eventCache, isUserData: false, base.TraceOutputOptions);
		_InternalWriteRaw(stringBuilder);
	}

	private static void BuildMessage(StringBuilder writer, string message)
	{
		_InternalBuildRaw(writer, "<Data>");
		BuildEscaped(writer, message);
		_InternalBuildRaw(writer, "</Data>");
	}

	[SecurityCritical]
	private static void BuildHeader(StringBuilder writer, string source, TraceEventType eventType, int id, TraceEventCache eventCache, string relatedActivityId, bool isUserData, TraceOptions opts)
	{
		_InternalBuildRaw(writer, "<Event xmlns=\"http://schemas.microsoft.com/win/2004/08/events/event\"><System><Provider Guid=\"");
		_InternalBuildRaw(writer, "{00000000-0000-0000-0000-000000000000}");
		_InternalBuildRaw(writer, "\"/><EventID>");
		_InternalBuildRaw(writer, ((id >= 0) ? ((uint)id) : 0u).ToString(CultureInfo.InvariantCulture));
		_InternalBuildRaw(writer, "</EventID>");
		_InternalBuildRaw(writer, "<Level>");
		int num = (int)eventType;
		int num2 = num;
		if (num > 255 || num < 0)
		{
			num = 8;
		}
		_InternalBuildRaw(writer, num.ToString(CultureInfo.InvariantCulture));
		_InternalBuildRaw(writer, "</Level>");
		if (num2 > 255)
		{
			num2 /= 256;
			_InternalBuildRaw(writer, "<Opcode>");
			_InternalBuildRaw(writer, num2.ToString(CultureInfo.InvariantCulture));
			_InternalBuildRaw(writer, "</Opcode>");
		}
		if ((TraceOptions.DateTime & opts) != TraceOptions.None)
		{
			_InternalBuildRaw(writer, "<TimeCreated SystemTime=\"");
			if (eventCache != null)
			{
				_InternalBuildRaw(writer, eventCache.DateTime.ToString("o", CultureInfo.InvariantCulture));
			}
			else
			{
				_InternalBuildRaw(writer, DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture));
			}
			_InternalBuildRaw(writer, "\"/>");
		}
		_InternalBuildRaw(writer, "<Correlation ActivityID=\"");
		_InternalBuildRaw(writer, Trace.CorrelationManager.ActivityId.ToString("B"));
		if (relatedActivityId != null)
		{
			_InternalBuildRaw(writer, "\" RelatedActivityID=\"");
			_InternalBuildRaw(writer, relatedActivityId);
		}
		_InternalBuildRaw(writer, "\"/>");
		if (eventCache != null && ((TraceOptions.ProcessId | TraceOptions.ThreadId) & opts) != TraceOptions.None)
		{
			_InternalBuildRaw(writer, "<Execution ");
			_InternalBuildRaw(writer, "ProcessID=\"");
			_InternalBuildRaw(writer, ((uint)eventCache.ProcessId).ToString(CultureInfo.InvariantCulture));
			_InternalBuildRaw(writer, "\" ");
			_InternalBuildRaw(writer, "ThreadID=\"");
			_InternalBuildRaw(writer, eventCache.ThreadId);
			_InternalBuildRaw(writer, "\"");
			_InternalBuildRaw(writer, "/>");
		}
		_InternalBuildRaw(writer, "<Computer>");
		_InternalBuildRaw(writer, machineName);
		_InternalBuildRaw(writer, "</Computer>");
		_InternalBuildRaw(writer, "</System>");
		if (!isUserData)
		{
			_InternalBuildRaw(writer, "<EventData>");
		}
		else
		{
			_InternalBuildRaw(writer, "<UserData>");
		}
	}

	private static void BuildFooter(StringBuilder writer, TraceEventType eventType, TraceEventCache eventCache, bool isUserData, TraceOptions opts)
	{
		if (!isUserData)
		{
			_InternalBuildRaw(writer, "</EventData>");
		}
		else
		{
			_InternalBuildRaw(writer, "</UserData>");
		}
		_InternalBuildRaw(writer, "<RenderingInfo Culture=\"en-EN\">");
		switch (eventType)
		{
		case TraceEventType.Critical:
			_InternalBuildRaw(writer, "<Level>Critical</Level>");
			break;
		case TraceEventType.Error:
			_InternalBuildRaw(writer, "<Level>Error</Level>");
			break;
		case TraceEventType.Warning:
			_InternalBuildRaw(writer, "<Level>Warning</Level>");
			break;
		case TraceEventType.Information:
			_InternalBuildRaw(writer, "<Level>Information</Level>");
			break;
		case TraceEventType.Verbose:
			_InternalBuildRaw(writer, "<Level>Verbose</Level>");
			break;
		case TraceEventType.Start:
			_InternalBuildRaw(writer, "<Level>Information</Level><Opcode>Start</Opcode>");
			break;
		case TraceEventType.Stop:
			_InternalBuildRaw(writer, "<Level>Information</Level><Opcode>Stop</Opcode>");
			break;
		case TraceEventType.Suspend:
			_InternalBuildRaw(writer, "<Level>Information</Level><Opcode>Suspend</Opcode>");
			break;
		case TraceEventType.Resume:
			_InternalBuildRaw(writer, "<Level>Information</Level><Opcode>Resume</Opcode>");
			break;
		case TraceEventType.Transfer:
			_InternalBuildRaw(writer, "<Level>Information</Level><Opcode>Transfer</Opcode>");
			break;
		}
		_InternalBuildRaw(writer, "</RenderingInfo>");
		if (eventCache != null && ((TraceOptions.LogicalOperationStack | TraceOptions.Timestamp | TraceOptions.Callstack) & opts) != TraceOptions.None)
		{
			_InternalBuildRaw(writer, "<System.Diagnostics.ExtendedData xmlns=\"http://schemas.microsoft.com/2006/09/System.Diagnostics/ExtendedData\">");
			if ((TraceOptions.Timestamp & opts) != TraceOptions.None)
			{
				_InternalBuildRaw(writer, "<Timestamp>");
				_InternalBuildRaw(writer, eventCache.Timestamp.ToString(CultureInfo.InvariantCulture));
				_InternalBuildRaw(writer, "</Timestamp>");
			}
			if ((TraceOptions.LogicalOperationStack & opts) != TraceOptions.None)
			{
				Stack logicalOperationStack = eventCache.LogicalOperationStack;
				_InternalBuildRaw(writer, "<LogicalOperationStack>");
				if (logicalOperationStack != null && logicalOperationStack.Count > 0)
				{
					foreach (object item in logicalOperationStack)
					{
						_InternalBuildRaw(writer, "<LogicalOperation>");
						BuildEscaped(writer, item.ToString());
						_InternalBuildRaw(writer, "</LogicalOperation>");
					}
				}
				_InternalBuildRaw(writer, "</LogicalOperationStack>");
			}
			if ((TraceOptions.Callstack & opts) != TraceOptions.None)
			{
				_InternalBuildRaw(writer, "<Callstack>");
				BuildEscaped(writer, eventCache.Callstack);
				_InternalBuildRaw(writer, "</Callstack>");
			}
			_InternalBuildRaw(writer, "</System.Diagnostics.ExtendedData>");
		}
		_InternalBuildRaw(writer, "</Event>");
	}

	private static void BuildEscaped(StringBuilder writer, string str)
	{
		if (str == null)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < str.Length; i++)
		{
			switch (str[i])
			{
			case '&':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&amp;");
				num = i + 1;
				break;
			case '<':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&lt;");
				num = i + 1;
				break;
			case '>':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&gt;");
				num = i + 1;
				break;
			case '"':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&quot;");
				num = i + 1;
				break;
			case '\'':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&apos;");
				num = i + 1;
				break;
			case '\r':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&#xD;");
				num = i + 1;
				break;
			case '\n':
				_InternalBuildRaw(writer, str.Substring(num, i - num));
				_InternalBuildRaw(writer, "&#xA;");
				num = i + 1;
				break;
			}
		}
		_InternalBuildRaw(writer, str.Substring(num, str.Length - num));
	}

	private static void BuildUserData(StringBuilder writer, object data)
	{
		if (!(data is UnescapedXmlDiagnosticData unescapedXmlDiagnosticData))
		{
			BuildMessage(writer, data.ToString());
		}
		else
		{
			_InternalBuildRaw(writer, unescapedXmlDiagnosticData.ToString());
		}
	}

	private static void _InternalBuildRaw(StringBuilder writer, string message)
	{
		writer.Append(message);
	}

	[SecurityCritical]
	private void _InternalWriteRaw(StringBuilder writer)
	{
		if (EnsureWriter())
		{
			traceWriter.Write(writer.ToString());
		}
	}

	protected override string[] GetSupportedAttributes()
	{
		return new string[4] { "bufferSize", "logRetentionOption", "maximumFileSize", "maximumNumberOfFiles" };
	}

	private void Init()
	{
		if (_initialized)
		{
			return;
		}
		lock (m_lockObject)
		{
			if (_initialized)
			{
				return;
			}
			try
			{
				if (base.Attributes.ContainsKey("bufferSize"))
				{
					int num = int.Parse(base.Attributes["bufferSize"], CultureInfo.InvariantCulture);
					if (num > 0)
					{
						_bufferSize = num;
					}
				}
				if (base.Attributes.ContainsKey("logRetentionOption"))
				{
					string strA = base.Attributes["logRetentionOption"];
					if (string.Compare(strA, "SingleFileUnboundedSize", StringComparison.OrdinalIgnoreCase) == 0)
					{
						_retention = TraceLogRetentionOption.SingleFileUnboundedSize;
					}
					else if (string.Compare(strA, "LimitedCircularFiles", StringComparison.OrdinalIgnoreCase) == 0)
					{
						_retention = TraceLogRetentionOption.LimitedCircularFiles;
					}
					else if (string.Compare(strA, "UnlimitedSequentialFiles", StringComparison.OrdinalIgnoreCase) == 0)
					{
						_retention = TraceLogRetentionOption.UnlimitedSequentialFiles;
					}
					else if (string.Compare(strA, "SingleFileBoundedSize", StringComparison.OrdinalIgnoreCase) == 0)
					{
						_retention = TraceLogRetentionOption.SingleFileBoundedSize;
					}
					else if (string.Compare(strA, "LimitedSequentialFiles", StringComparison.OrdinalIgnoreCase) == 0)
					{
						_retention = TraceLogRetentionOption.LimitedSequentialFiles;
					}
					else
					{
						_retention = TraceLogRetentionOption.SingleFileUnboundedSize;
					}
				}
				if (base.Attributes.ContainsKey("maximumFileSize"))
				{
					long maximumFileSize = long.Parse(base.Attributes["maximumFileSize"], CultureInfo.InvariantCulture);
					_SetMaxFileSize(maximumFileSize, throwOnError: false);
				}
				if (base.Attributes.ContainsKey("maximumNumberOfFiles"))
				{
					int maximumNumberOfFiles = int.Parse(base.Attributes["maximumNumberOfFiles"], CultureInfo.InvariantCulture);
					_SetMaxNumberOfFiles(maximumNumberOfFiles, throwOnError: false);
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				_initialized = true;
			}
		}
	}

	private void _SetMaxFileSize(long maximumFileSize, bool throwOnError)
	{
		switch (_retention)
		{
		case TraceLogRetentionOption.SingleFileUnboundedSize:
			_maxFileSize = -1L;
			break;
		case TraceLogRetentionOption.UnlimitedSequentialFiles:
		case TraceLogRetentionOption.LimitedCircularFiles:
		case TraceLogRetentionOption.LimitedSequentialFiles:
		case TraceLogRetentionOption.SingleFileBoundedSize:
			if (maximumFileSize < 0 && throwOnError)
			{
				throw new ArgumentOutOfRangeException("maximumFileSize", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (maximumFileSize < _bufferSize)
			{
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("maximumFileSize", System.SR.GetString("ArgumentOutOfRange_NeedMaxFileSizeGEBufferSize"));
				}
				_maxFileSize = _bufferSize;
			}
			else
			{
				_maxFileSize = maximumFileSize;
			}
			break;
		}
	}

	private void _SetMaxNumberOfFiles(int maximumNumberOfFiles, bool throwOnError)
	{
		switch (_retention)
		{
		case TraceLogRetentionOption.SingleFileUnboundedSize:
		case TraceLogRetentionOption.SingleFileBoundedSize:
			_maxNumberOfFiles = 1;
			break;
		case TraceLogRetentionOption.UnlimitedSequentialFiles:
			_maxNumberOfFiles = -1;
			break;
		case TraceLogRetentionOption.LimitedSequentialFiles:
			if (maximumNumberOfFiles < 1)
			{
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("maximumNumberOfFiles", System.SR.GetString("ArgumentOutOfRange_NeedValidMaxNumFiles", 1));
				}
				_maxNumberOfFiles = 1;
			}
			else
			{
				_maxNumberOfFiles = maximumNumberOfFiles;
			}
			break;
		case TraceLogRetentionOption.LimitedCircularFiles:
			if (maximumNumberOfFiles < 2)
			{
				if (throwOnError)
				{
					throw new ArgumentOutOfRangeException("maximumNumberOfFiles", System.SR.GetString("ArgumentOutOfRange_NeedValidMaxNumFiles", 2));
				}
				_maxNumberOfFiles = 2;
			}
			else
			{
				_maxNumberOfFiles = maximumNumberOfFiles;
			}
			break;
		}
	}

	[SecurityCritical]
	private bool EnsureWriter()
	{
		if (traceWriter == null)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				return false;
			}
			lock (m_lockObject)
			{
				if (traceWriter != null)
				{
					return true;
				}
				string text = fileName;
				for (int i = 0; i < 2; i++)
				{
					try
					{
						Init();
						traceWriter = new TraceWriter(text, _bufferSize, _retention, _maxFileSize, _maxNumberOfFiles);
					}
					catch (IOException)
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
						string extension = Path.GetExtension(fileName);
						text = fileNameWithoutExtension + Guid.NewGuid().ToString() + extension;
						continue;
					}
					catch (UnauthorizedAccessException)
					{
					}
					catch (Exception)
					{
					}
					break;
				}
				if (traceWriter == null)
				{
					fileName = null;
				}
			}
		}
		return traceWriter != null;
	}
}
