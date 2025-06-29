using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class StreamWriter : TextWriter
{
	private sealed class MdaHelper
	{
		private StreamWriter streamWriter;

		private string allocatedCallstack;

		internal MdaHelper(StreamWriter sw, string cs)
		{
			streamWriter = sw;
			allocatedCallstack = cs;
		}

		~MdaHelper()
		{
			if (streamWriter.charPos != 0 && (streamWriter.stream != null && streamWriter.stream != Stream.Null))
			{
				string text = ((streamWriter.stream is FileStream) ? ((FileStream)streamWriter.stream).NameInternal : "<unknown>");
				string resourceString = allocatedCallstack;
				if (resourceString == null)
				{
					resourceString = Environment.GetResourceString("IO_StreamWriterBufferedDataLostCaptureAllocatedFromCallstackNotEnabled");
				}
				string resourceString2 = Environment.GetResourceString("IO_StreamWriterBufferedDataLost", streamWriter.stream.GetType().FullName, text, resourceString);
				Mda.StreamWriterBufferedDataLost.ReportError(resourceString2);
			}
		}
	}

	internal const int DefaultBufferSize = 1024;

	private const int DefaultFileStreamBufferSize = 4096;

	private const int MinBufferSize = 128;

	private const int DontCopyOnWriteLineThreshold = 512;

	[__DynamicallyInvokable]
	public new static readonly StreamWriter Null = new StreamWriter(Stream.Null, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), 128, leaveOpen: true);

	private Stream stream;

	private Encoding encoding;

	private Encoder encoder;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private int charPos;

	private int charLen;

	private bool autoFlush;

	private bool haveWrittenPreamble;

	private bool closable;

	[NonSerialized]
	private MdaHelper mdaHelper;

	[NonSerialized]
	private volatile Task _asyncWriteTask;

	private static volatile Encoding _UTF8NoBOM;

	internal static Encoding UTF8NoBOM
	{
		[FriendAccessAllowed]
		get
		{
			if (_UTF8NoBOM == null)
			{
				UTF8Encoding uTF8NoBOM = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
				Thread.MemoryBarrier();
				_UTF8NoBOM = uTF8NoBOM;
			}
			return _UTF8NoBOM;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool AutoFlush
	{
		[__DynamicallyInvokable]
		get
		{
			return autoFlush;
		}
		[__DynamicallyInvokable]
		set
		{
			CheckAsyncTaskInProgress();
			autoFlush = value;
			if (value)
			{
				Flush(flushStream: true, flushEncoder: false);
			}
		}
	}

	[__DynamicallyInvokable]
	public virtual Stream BaseStream
	{
		[__DynamicallyInvokable]
		get
		{
			return stream;
		}
	}

	internal bool LeaveOpen => !closable;

	internal bool HaveWrittenPreamble
	{
		set
		{
			haveWrittenPreamble = value;
		}
	}

	[__DynamicallyInvokable]
	public override Encoding Encoding
	{
		[__DynamicallyInvokable]
		get
		{
			return encoding;
		}
	}

	private int CharPos_Prop
	{
		set
		{
			charPos = value;
		}
	}

	private bool HaveWrittenPreamble_Prop
	{
		set
		{
			haveWrittenPreamble = value;
		}
	}

	private void CheckAsyncTaskInProgress()
	{
		Task asyncWriteTask = _asyncWriteTask;
		if (asyncWriteTask != null && !asyncWriteTask.IsCompleted)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AsyncIOInProgress"));
		}
	}

	internal StreamWriter()
		: base(null)
	{
	}

	[__DynamicallyInvokable]
	public StreamWriter(Stream stream)
		: this(stream, UTF8NoBOM, 1024, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamWriter(Stream stream, Encoding encoding)
		: this(stream, encoding, 1024, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamWriter(Stream stream, Encoding encoding, int bufferSize)
		: this(stream, encoding, bufferSize, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
		: base(null)
	{
		if (stream == null || encoding == null)
		{
			throw new ArgumentNullException((stream == null) ? "stream" : "encoding");
		}
		if (!stream.CanWrite)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_StreamNotWritable"));
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		Init(stream, encoding, bufferSize, leaveOpen);
	}

	public StreamWriter(string path)
		: this(path, append: false, UTF8NoBOM, 1024)
	{
	}

	public StreamWriter(string path, bool append)
		: this(path, append, UTF8NoBOM, 1024)
	{
	}

	public StreamWriter(string path, bool append, Encoding encoding)
		: this(path, append, encoding, 1024)
	{
	}

	[SecuritySafeCritical]
	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
		: this(path, append, encoding, bufferSize, checkHost: true)
	{
	}

	[SecurityCritical]
	internal StreamWriter(string path, bool append, Encoding encoding, int bufferSize, bool checkHost)
		: base(null)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"));
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		Stream streamArg = CreateFile(path, append, checkHost);
		Init(streamArg, encoding, bufferSize, shouldLeaveOpen: false);
	}

	[SecuritySafeCritical]
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
	{
		stream = streamArg;
		encoding = encodingArg;
		encoder = encoding.GetEncoder();
		if (bufferSize < 128)
		{
			bufferSize = 128;
		}
		charBuffer = new char[bufferSize];
		byteBuffer = new byte[encoding.GetMaxByteCount(bufferSize)];
		charLen = bufferSize;
		if (stream.CanSeek && stream.Position > 0)
		{
			haveWrittenPreamble = true;
		}
		closable = !shouldLeaveOpen;
		if (Mda.StreamWriterBufferedDataLost.Enabled)
		{
			string cs = null;
			if (Mda.StreamWriterBufferedDataLost.CaptureAllocatedCallStack)
			{
				cs = Environment.GetStackTrace(null, needFileInfo: false);
			}
			mdaHelper = new MdaHelper(this, cs);
		}
	}

	[SecurityCritical]
	private static Stream CreateFile(string path, bool append, bool checkHost)
	{
		FileMode mode = (append ? FileMode.Append : FileMode.Create);
		return new FileStream(path, mode, FileAccess.Write, FileShare.Read, 4096, FileOptions.SequentialScan, Path.GetFileName(path), bFromProxy: false, useLongPath: false, checkHost);
	}

	public override void Close()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (stream != null && (disposing || (LeaveOpen && stream is __ConsoleStream)))
			{
				CheckAsyncTaskInProgress();
				Flush(flushStream: true, flushEncoder: true);
				if (mdaHelper != null)
				{
					GC.SuppressFinalize(mdaHelper);
				}
			}
		}
		finally
		{
			if (!LeaveOpen && stream != null)
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
					stream = null;
					byteBuffer = null;
					charBuffer = null;
					encoding = null;
					encoder = null;
					charLen = 0;
					base.Dispose(disposing);
				}
			}
		}
	}

	[__DynamicallyInvokable]
	public override void Flush()
	{
		CheckAsyncTaskInProgress();
		Flush(flushStream: true, flushEncoder: true);
	}

	private void Flush(bool flushStream, bool flushEncoder)
	{
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		if (charPos == 0 && ((!flushStream && !flushEncoder) || CompatibilitySwitches.IsAppEarlierThanWindowsPhone8))
		{
			return;
		}
		if (!haveWrittenPreamble)
		{
			haveWrittenPreamble = true;
			byte[] preamble = encoding.GetPreamble();
			if (preamble.Length != 0)
			{
				stream.Write(preamble, 0, preamble.Length);
			}
		}
		int bytes = encoder.GetBytes(charBuffer, 0, charPos, byteBuffer, 0, flushEncoder);
		charPos = 0;
		if (bytes > 0)
		{
			stream.Write(byteBuffer, 0, bytes);
		}
		if (flushStream)
		{
			stream.Flush();
		}
	}

	[__DynamicallyInvokable]
	public override void Write(char value)
	{
		CheckAsyncTaskInProgress();
		if (charPos == charLen)
		{
			Flush(flushStream: false, flushEncoder: false);
		}
		charBuffer[charPos] = value;
		charPos++;
		if (autoFlush)
		{
			Flush(flushStream: true, flushEncoder: false);
		}
	}

	[__DynamicallyInvokable]
	public override void Write(char[] buffer)
	{
		if (buffer == null)
		{
			return;
		}
		CheckAsyncTaskInProgress();
		int num = 0;
		int num2 = buffer.Length;
		while (num2 > 0)
		{
			if (charPos == charLen)
			{
				Flush(flushStream: false, flushEncoder: false);
			}
			int num3 = charLen - charPos;
			if (num3 > num2)
			{
				num3 = num2;
			}
			Buffer.InternalBlockCopy(buffer, num * 2, charBuffer, charPos * 2, num3 * 2);
			charPos += num3;
			num += num3;
			num2 -= num3;
		}
		if (autoFlush)
		{
			Flush(flushStream: true, flushEncoder: false);
		}
	}

	[__DynamicallyInvokable]
	public override void Write(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		CheckAsyncTaskInProgress();
		while (count > 0)
		{
			if (charPos == charLen)
			{
				Flush(flushStream: false, flushEncoder: false);
			}
			int num = charLen - charPos;
			if (num > count)
			{
				num = count;
			}
			Buffer.InternalBlockCopy(buffer, index * 2, charBuffer, charPos * 2, num * 2);
			charPos += num;
			index += num;
			count -= num;
		}
		if (autoFlush)
		{
			Flush(flushStream: true, flushEncoder: false);
		}
	}

	[__DynamicallyInvokable]
	public override void Write(string value)
	{
		if (value == null)
		{
			return;
		}
		CheckAsyncTaskInProgress();
		int num = value.Length;
		int num2 = 0;
		while (num > 0)
		{
			if (charPos == charLen)
			{
				Flush(flushStream: false, flushEncoder: false);
			}
			int num3 = charLen - charPos;
			if (num3 > num)
			{
				num3 = num;
			}
			value.CopyTo(num2, charBuffer, charPos, num3);
			charPos += num3;
			num2 += num3;
			num -= num3;
		}
		if (autoFlush)
		{
			Flush(flushStream: true, flushEncoder: false);
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(char value)
	{
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteAsync(value);
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = WriteAsyncInternal(this, value, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: false);
	}

	private static async Task WriteAsyncInternal(StreamWriter _this, char value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
	{
		if (charPos == charLen)
		{
			await _this.FlushAsyncInternal(flushStream: false, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
			charPos = 0;
		}
		charBuffer[charPos] = value;
		charPos++;
		if (appendNewLine)
		{
			for (int i = 0; i < coreNewLine.Length; i++)
			{
				if (charPos == charLen)
				{
					await _this.FlushAsyncInternal(flushStream: false, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
					charPos = 0;
				}
				charBuffer[charPos] = coreNewLine[i];
				charPos++;
			}
		}
		if (autoFlush)
		{
			await _this.FlushAsyncInternal(flushStream: true, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
			charPos = 0;
		}
		_this.CharPos_Prop = charPos;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(string value)
	{
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteAsync(value);
		}
		if (value != null)
		{
			if (stream == null)
			{
				__Error.WriterClosed();
			}
			CheckAsyncTaskInProgress();
			return _asyncWriteTask = WriteAsyncInternal(this, value, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: false);
		}
		return Task.CompletedTask;
	}

	private static async Task WriteAsyncInternal(StreamWriter _this, string value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
	{
		int count = value.Length;
		int index = 0;
		while (count > 0)
		{
			if (charPos == charLen)
			{
				await _this.FlushAsyncInternal(flushStream: false, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
				charPos = 0;
			}
			int num = charLen - charPos;
			if (num > count)
			{
				num = count;
			}
			value.CopyTo(index, charBuffer, charPos, num);
			charPos += num;
			index += num;
			count -= num;
		}
		if (appendNewLine)
		{
			for (int i = 0; i < coreNewLine.Length; i++)
			{
				if (charPos == charLen)
				{
					await _this.FlushAsyncInternal(flushStream: false, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
					charPos = 0;
				}
				charBuffer[charPos] = coreNewLine[i];
				charPos++;
			}
		}
		if (autoFlush)
		{
			await _this.FlushAsyncInternal(flushStream: true, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
			charPos = 0;
		}
		_this.CharPos_Prop = charPos;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteAsync(buffer, index, count);
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = WriteAsyncInternal(this, buffer, index, count, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: false);
	}

	private static async Task WriteAsyncInternal(StreamWriter _this, char[] buffer, int index, int count, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
	{
		while (count > 0)
		{
			if (charPos == charLen)
			{
				await _this.FlushAsyncInternal(flushStream: false, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
				charPos = 0;
			}
			int num = charLen - charPos;
			if (num > count)
			{
				num = count;
			}
			Buffer.InternalBlockCopy(buffer, index * 2, charBuffer, charPos * 2, num * 2);
			charPos += num;
			index += num;
			count -= num;
		}
		if (appendNewLine)
		{
			for (int i = 0; i < coreNewLine.Length; i++)
			{
				if (charPos == charLen)
				{
					await _this.FlushAsyncInternal(flushStream: false, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
					charPos = 0;
				}
				charBuffer[charPos] = coreNewLine[i];
				charPos++;
			}
		}
		if (autoFlush)
		{
			await _this.FlushAsyncInternal(flushStream: true, flushEncoder: false, charBuffer, charPos).ConfigureAwait(continueOnCapturedContext: false);
			charPos = 0;
		}
		_this.CharPos_Prop = charPos;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync()
	{
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteLineAsync();
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = WriteAsyncInternal(this, null, 0, 0, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: true);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync(char value)
	{
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteLineAsync(value);
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = WriteAsyncInternal(this, value, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: true);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync(string value)
	{
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteLineAsync(value);
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = WriteAsyncInternal(this, value, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: true);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (GetType() != typeof(StreamWriter))
		{
			return base.WriteLineAsync(buffer, index, count);
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = WriteAsyncInternal(this, buffer, index, count, charBuffer, charPos, charLen, CoreNewLine, autoFlush, appendNewLine: true);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task FlushAsync()
	{
		if (GetType() != typeof(StreamWriter))
		{
			return base.FlushAsync();
		}
		if (stream == null)
		{
			__Error.WriterClosed();
		}
		CheckAsyncTaskInProgress();
		return _asyncWriteTask = FlushAsyncInternal(flushStream: true, flushEncoder: true, charBuffer, charPos);
	}

	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, char[] sCharBuffer, int sCharPos)
	{
		if (sCharPos == 0 && !flushStream && !flushEncoder)
		{
			return Task.CompletedTask;
		}
		Task result = FlushAsyncInternal(this, flushStream, flushEncoder, sCharBuffer, sCharPos, haveWrittenPreamble, encoding, encoder, byteBuffer, stream);
		charPos = 0;
		return result;
	}

	private static async Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, byte[] byteBuffer, Stream stream)
	{
		if (!haveWrittenPreamble)
		{
			_this.HaveWrittenPreamble_Prop = true;
			byte[] preamble = encoding.GetPreamble();
			if (preamble.Length != 0)
			{
				await stream.WriteAsync(preamble, 0, preamble.Length).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		int bytes = encoder.GetBytes(charBuffer, 0, charPos, byteBuffer, 0, flushEncoder);
		if (bytes > 0)
		{
			await stream.WriteAsync(byteBuffer, 0, bytes).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (flushStream)
		{
			await stream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);
		}
	}
}
