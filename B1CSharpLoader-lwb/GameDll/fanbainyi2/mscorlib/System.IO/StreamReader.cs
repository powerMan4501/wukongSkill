using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class StreamReader : TextReader
{
	private class NullStreamReader : StreamReader
	{
		public override Stream BaseStream => Stream.Null;

		public override Encoding CurrentEncoding => Encoding.Unicode;

		internal NullStreamReader()
		{
			Init(Stream.Null);
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int Peek()
		{
			return -1;
		}

		public override int Read()
		{
			return -1;
		}

		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		public override string ReadLine()
		{
			return null;
		}

		public override string ReadToEnd()
		{
			return string.Empty;
		}

		internal override int ReadBuffer()
		{
			return 0;
		}
	}

	[__DynamicallyInvokable]
	public new static readonly StreamReader Null = new NullStreamReader();

	private const int DefaultFileStreamBufferSize = 4096;

	private const int MinBufferSize = 128;

	private Stream stream;

	private Encoding encoding;

	private Decoder decoder;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private byte[] _preamble;

	private int charPos;

	private int charLen;

	private int byteLen;

	private int bytePos;

	private int _maxCharsPerBuffer;

	private bool _detectEncoding;

	private bool _checkPreamble;

	private bool _isBlocked;

	private bool _closable;

	[NonSerialized]
	private volatile Task _asyncReadTask;

	internal static int DefaultBufferSize => 1024;

	[__DynamicallyInvokable]
	public virtual Encoding CurrentEncoding
	{
		[__DynamicallyInvokable]
		get
		{
			return encoding;
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

	internal bool LeaveOpen => !_closable;

	[__DynamicallyInvokable]
	public bool EndOfStream
	{
		[__DynamicallyInvokable]
		get
		{
			if (stream == null)
			{
				__Error.ReaderClosed();
			}
			CheckAsyncTaskInProgress();
			if (charPos < charLen)
			{
				return false;
			}
			int num = ReadBuffer();
			return num == 0;
		}
	}

	private int CharLen_Prop
	{
		get
		{
			return charLen;
		}
		set
		{
			charLen = value;
		}
	}

	private int CharPos_Prop
	{
		get
		{
			return charPos;
		}
		set
		{
			charPos = value;
		}
	}

	private int ByteLen_Prop
	{
		get
		{
			return byteLen;
		}
		set
		{
			byteLen = value;
		}
	}

	private int BytePos_Prop
	{
		get
		{
			return bytePos;
		}
		set
		{
			bytePos = value;
		}
	}

	private byte[] Preamble_Prop => _preamble;

	private bool CheckPreamble_Prop => _checkPreamble;

	private Decoder Decoder_Prop => decoder;

	private bool DetectEncoding_Prop => _detectEncoding;

	private char[] CharBuffer_Prop => charBuffer;

	private byte[] ByteBuffer_Prop => byteBuffer;

	private bool IsBlocked_Prop
	{
		get
		{
			return _isBlocked;
		}
		set
		{
			_isBlocked = value;
		}
	}

	private Stream Stream_Prop => stream;

	private int MaxCharsPerBuffer_Prop => _maxCharsPerBuffer;

	private void CheckAsyncTaskInProgress()
	{
		Task asyncReadTask = _asyncReadTask;
		if (asyncReadTask != null && !asyncReadTask.IsCompleted)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AsyncIOInProgress"));
		}
	}

	internal StreamReader()
	{
	}

	[__DynamicallyInvokable]
	public StreamReader(Stream stream)
		: this(stream, detectEncodingFromByteOrderMarks: true)
	{
	}

	[__DynamicallyInvokable]
	public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
		: this(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks, DefaultBufferSize, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamReader(Stream stream, Encoding encoding)
		: this(stream, encoding, detectEncodingFromByteOrderMarks: true, DefaultBufferSize, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
		: this(stream, encoding, detectEncodingFromByteOrderMarks, DefaultBufferSize, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		: this(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
	{
		if (stream == null || encoding == null)
		{
			throw new ArgumentNullException((stream == null) ? "stream" : "encoding");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_StreamNotReadable"));
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen);
	}

	public StreamReader(string path)
		: this(path, detectEncodingFromByteOrderMarks: true)
	{
	}

	public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
		: this(path, Encoding.UTF8, detectEncodingFromByteOrderMarks, DefaultBufferSize)
	{
	}

	public StreamReader(string path, Encoding encoding)
		: this(path, encoding, detectEncodingFromByteOrderMarks: true, DefaultBufferSize)
	{
	}

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
		: this(path, encoding, detectEncodingFromByteOrderMarks, DefaultBufferSize)
	{
	}

	[SecuritySafeCritical]
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		: this(path, encoding, detectEncodingFromByteOrderMarks, bufferSize, checkHost: true)
	{
	}

	[SecurityCritical]
	internal StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost)
	{
		if (path == null || encoding == null)
		{
			throw new ArgumentNullException((path == null) ? "path" : "encoding");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"));
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan, Path.GetFileName(path), bFromProxy: false, useLongPath: false, checkHost);
		Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen: false);
	}

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
	{
		this.stream = stream;
		this.encoding = encoding;
		decoder = encoding.GetDecoder();
		if (bufferSize < 128)
		{
			bufferSize = 128;
		}
		byteBuffer = new byte[bufferSize];
		_maxCharsPerBuffer = encoding.GetMaxCharCount(bufferSize);
		charBuffer = new char[_maxCharsPerBuffer];
		byteLen = 0;
		bytePos = 0;
		_detectEncoding = detectEncodingFromByteOrderMarks;
		_preamble = encoding.GetPreamble();
		_checkPreamble = _preamble.Length != 0;
		_isBlocked = false;
		_closable = !leaveOpen;
	}

	internal void Init(Stream stream)
	{
		this.stream = stream;
		_closable = true;
	}

	public override void Close()
	{
		Dispose(disposing: true);
	}

	[__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!LeaveOpen && disposing && stream != null)
			{
				stream.Close();
			}
		}
		finally
		{
			if (!LeaveOpen && stream != null)
			{
				stream = null;
				encoding = null;
				decoder = null;
				byteBuffer = null;
				charBuffer = null;
				charPos = 0;
				charLen = 0;
				base.Dispose(disposing);
			}
		}
	}

	[__DynamicallyInvokable]
	public void DiscardBufferedData()
	{
		CheckAsyncTaskInProgress();
		byteLen = 0;
		charLen = 0;
		charPos = 0;
		if (encoding != null)
		{
			decoder = encoding.GetDecoder();
		}
		_isBlocked = false;
	}

	[__DynamicallyInvokable]
	public override int Peek()
	{
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		if (charPos == charLen && (_isBlocked || ReadBuffer() == 0))
		{
			return -1;
		}
		return charBuffer[charPos];
	}

	[__DynamicallyInvokable]
	public override int Read()
	{
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		if (charPos == charLen && ReadBuffer() == 0)
		{
			return -1;
		}
		int result = charBuffer[charPos];
		charPos++;
		return result;
	}

	[__DynamicallyInvokable]
	public override int Read([In][Out] char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		int num = 0;
		bool readToUserBuffer = false;
		while (count > 0)
		{
			int num2 = charLen - charPos;
			if (num2 == 0)
			{
				num2 = ReadBuffer(buffer, index + num, count, out readToUserBuffer);
			}
			if (num2 == 0)
			{
				break;
			}
			if (num2 > count)
			{
				num2 = count;
			}
			if (!readToUserBuffer)
			{
				Buffer.InternalBlockCopy(charBuffer, charPos * 2, buffer, (index + num) * 2, num2 * 2);
				charPos += num2;
			}
			num += num2;
			count -= num2;
			if (_isBlocked)
			{
				break;
			}
		}
		return num;
	}

	[__DynamicallyInvokable]
	public override string ReadToEnd()
	{
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		StringBuilder stringBuilder = new StringBuilder(charLen - charPos);
		do
		{
			stringBuilder.Append(charBuffer, charPos, charLen - charPos);
			charPos = charLen;
			ReadBuffer();
		}
		while (charLen > 0);
		return stringBuilder.ToString();
	}

	[__DynamicallyInvokable]
	public override int ReadBlock([In][Out] char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		return base.ReadBlock(buffer, index, count);
	}

	private void CompressBuffer(int n)
	{
		Buffer.InternalBlockCopy(byteBuffer, n, byteBuffer, 0, byteLen - n);
		byteLen -= n;
	}

	private void DetectEncoding()
	{
		if (byteLen < 2)
		{
			return;
		}
		_detectEncoding = false;
		bool flag = false;
		if (byteBuffer[0] == 254 && byteBuffer[1] == byte.MaxValue)
		{
			encoding = new UnicodeEncoding(bigEndian: true, byteOrderMark: true);
			CompressBuffer(2);
			flag = true;
		}
		else if (byteBuffer[0] == byte.MaxValue && byteBuffer[1] == 254)
		{
			if (byteLen < 4 || byteBuffer[2] != 0 || byteBuffer[3] != 0)
			{
				encoding = new UnicodeEncoding(bigEndian: false, byteOrderMark: true);
				CompressBuffer(2);
				flag = true;
			}
			else
			{
				encoding = new UTF32Encoding(bigEndian: false, byteOrderMark: true);
				CompressBuffer(4);
				flag = true;
			}
		}
		else if (byteLen >= 3 && byteBuffer[0] == 239 && byteBuffer[1] == 187 && byteBuffer[2] == 191)
		{
			encoding = Encoding.UTF8;
			CompressBuffer(3);
			flag = true;
		}
		else if (byteLen >= 4 && byteBuffer[0] == 0 && byteBuffer[1] == 0 && byteBuffer[2] == 254 && byteBuffer[3] == byte.MaxValue)
		{
			encoding = new UTF32Encoding(bigEndian: true, byteOrderMark: true);
			CompressBuffer(4);
			flag = true;
		}
		else if (byteLen == 2)
		{
			_detectEncoding = true;
		}
		if (flag)
		{
			decoder = encoding.GetDecoder();
			_maxCharsPerBuffer = encoding.GetMaxCharCount(byteBuffer.Length);
			charBuffer = new char[_maxCharsPerBuffer];
		}
	}

	private bool IsPreamble()
	{
		if (!_checkPreamble)
		{
			return _checkPreamble;
		}
		int num = ((byteLen >= _preamble.Length) ? (_preamble.Length - bytePos) : (byteLen - bytePos));
		int num2 = 0;
		while (num2 < num)
		{
			if (byteBuffer[bytePos] != _preamble[bytePos])
			{
				bytePos = 0;
				_checkPreamble = false;
				break;
			}
			num2++;
			bytePos++;
		}
		if (_checkPreamble && bytePos == _preamble.Length)
		{
			CompressBuffer(_preamble.Length);
			bytePos = 0;
			_checkPreamble = false;
			_detectEncoding = false;
		}
		return _checkPreamble;
	}

	internal virtual int ReadBuffer()
	{
		charLen = 0;
		charPos = 0;
		if (!_checkPreamble)
		{
			byteLen = 0;
		}
		do
		{
			if (_checkPreamble)
			{
				int num = stream.Read(byteBuffer, bytePos, byteBuffer.Length - bytePos);
				if (num == 0)
				{
					if (byteLen > 0)
					{
						charLen += decoder.GetChars(byteBuffer, 0, byteLen, charBuffer, charLen);
						bytePos = (byteLen = 0);
					}
					return charLen;
				}
				byteLen += num;
			}
			else
			{
				byteLen = stream.Read(byteBuffer, 0, byteBuffer.Length);
				if (byteLen == 0)
				{
					return charLen;
				}
			}
			_isBlocked = byteLen < byteBuffer.Length;
			if (!IsPreamble())
			{
				if (_detectEncoding && byteLen >= 2)
				{
					DetectEncoding();
				}
				charLen += decoder.GetChars(byteBuffer, 0, byteLen, charBuffer, charLen);
			}
		}
		while (charLen == 0);
		return charLen;
	}

	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer)
	{
		charLen = 0;
		charPos = 0;
		if (!_checkPreamble)
		{
			byteLen = 0;
		}
		int num = 0;
		readToUserBuffer = desiredChars >= _maxCharsPerBuffer;
		do
		{
			if (_checkPreamble)
			{
				int num2 = stream.Read(byteBuffer, bytePos, byteBuffer.Length - bytePos);
				if (num2 == 0)
				{
					if (byteLen > 0)
					{
						if (readToUserBuffer)
						{
							num = decoder.GetChars(byteBuffer, 0, byteLen, userBuffer, userOffset + num);
							charLen = 0;
						}
						else
						{
							num = decoder.GetChars(byteBuffer, 0, byteLen, charBuffer, num);
							charLen += num;
						}
					}
					return num;
				}
				byteLen += num2;
			}
			else
			{
				byteLen = stream.Read(byteBuffer, 0, byteBuffer.Length);
				if (byteLen == 0)
				{
					break;
				}
			}
			_isBlocked = byteLen < byteBuffer.Length;
			if (!IsPreamble())
			{
				if (_detectEncoding && byteLen >= 2)
				{
					DetectEncoding();
					readToUserBuffer = desiredChars >= _maxCharsPerBuffer;
				}
				charPos = 0;
				if (readToUserBuffer)
				{
					num += decoder.GetChars(byteBuffer, 0, byteLen, userBuffer, userOffset + num);
					charLen = 0;
				}
				else
				{
					num = decoder.GetChars(byteBuffer, 0, byteLen, charBuffer, num);
					charLen += num;
				}
			}
		}
		while (num == 0);
		_isBlocked &= num < desiredChars;
		return num;
	}

	[__DynamicallyInvokable]
	public override string ReadLine()
	{
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		if (charPos == charLen && ReadBuffer() == 0)
		{
			return null;
		}
		StringBuilder stringBuilder = null;
		do
		{
			int num = charPos;
			do
			{
				char c = charBuffer[num];
				if (c == '\r' || c == '\n')
				{
					string result;
					if (stringBuilder != null)
					{
						stringBuilder.Append(charBuffer, charPos, num - charPos);
						result = stringBuilder.ToString();
					}
					else
					{
						result = new string(charBuffer, charPos, num - charPos);
					}
					charPos = num + 1;
					if (c == '\r' && (charPos < charLen || ReadBuffer() > 0) && charBuffer[charPos] == '\n')
					{
						charPos++;
					}
					return result;
				}
				num++;
			}
			while (num < charLen);
			num = charLen - charPos;
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num + 80);
			}
			stringBuilder.Append(charBuffer, charPos, num);
		}
		while (ReadBuffer() > 0);
		return stringBuilder.ToString();
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task<string> ReadLineAsync()
	{
		if (GetType() != typeof(StreamReader))
		{
			return base.ReadLineAsync();
		}
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		return (Task<string>)(_asyncReadTask = ReadLineAsyncInternal());
	}

	private async Task<string> ReadLineAsyncInternal()
	{
		bool flag = CharPos_Prop == CharLen_Prop;
		bool flag2 = flag;
		if (flag2)
		{
			flag2 = await ReadBufferAsync().ConfigureAwait(continueOnCapturedContext: false) == 0;
		}
		if (flag2)
		{
			return null;
		}
		StringBuilder sb = null;
		do
		{
			char[] charBuffer_Prop = CharBuffer_Prop;
			int charLen_Prop = CharLen_Prop;
			int charPos_Prop = CharPos_Prop;
			int num = charPos_Prop;
			do
			{
				char c = charBuffer_Prop[num];
				if (c == '\r' || c == '\n')
				{
					string s;
					if (sb != null)
					{
						sb.Append(charBuffer_Prop, charPos_Prop, num - charPos_Prop);
						s = sb.ToString();
					}
					else
					{
						s = new string(charBuffer_Prop, charPos_Prop, num - charPos_Prop);
					}
					charPos_Prop = (CharPos_Prop = num + 1);
					bool flag3 = c == '\r';
					bool flag4 = flag3;
					if (flag4)
					{
						bool flag5 = charPos_Prop < charLen_Prop;
						bool flag6 = flag5;
						if (!flag6)
						{
							flag6 = await ReadBufferAsync().ConfigureAwait(continueOnCapturedContext: false) > 0;
						}
						flag4 = flag6;
					}
					if (flag4)
					{
						charPos_Prop = CharPos_Prop;
						if (CharBuffer_Prop[charPos_Prop] == '\n')
						{
							CharPos_Prop = charPos_Prop + 1;
						}
					}
					return s;
				}
				num++;
			}
			while (num < charLen_Prop);
			num = charLen_Prop - charPos_Prop;
			if (sb == null)
			{
				sb = new StringBuilder(num + 80);
			}
			sb.Append(charBuffer_Prop, charPos_Prop, num);
		}
		while (await ReadBufferAsync().ConfigureAwait(continueOnCapturedContext: false) > 0);
		return sb.ToString();
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task<string> ReadToEndAsync()
	{
		if (GetType() != typeof(StreamReader))
		{
			return base.ReadToEndAsync();
		}
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		return (Task<string>)(_asyncReadTask = ReadToEndAsyncInternal());
	}

	private async Task<string> ReadToEndAsyncInternal()
	{
		StringBuilder sb = new StringBuilder(CharLen_Prop - CharPos_Prop);
		do
		{
			int charPos_Prop = CharPos_Prop;
			sb.Append(CharBuffer_Prop, charPos_Prop, CharLen_Prop - charPos_Prop);
			CharPos_Prop = CharLen_Prop;
			await ReadBufferAsync().ConfigureAwait(continueOnCapturedContext: false);
		}
		while (CharLen_Prop > 0);
		return sb.ToString();
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task<int> ReadAsync(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (GetType() != typeof(StreamReader))
		{
			return base.ReadAsync(buffer, index, count);
		}
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		return (Task<int>)(_asyncReadTask = ReadAsyncInternal(buffer, index, count));
	}

	internal override async Task<int> ReadAsyncInternal(char[] buffer, int index, int count)
	{
		bool flag = CharPos_Prop == CharLen_Prop;
		bool flag2 = flag;
		if (flag2)
		{
			flag2 = await ReadBufferAsync().ConfigureAwait(continueOnCapturedContext: false) == 0;
		}
		if (flag2)
		{
			return 0;
		}
		int charsRead = 0;
		bool readToUserBuffer = false;
		byte[] tmpByteBuffer = ByteBuffer_Prop;
		Stream tmpStream = Stream_Prop;
		while (count > 0)
		{
			int n = CharLen_Prop - CharPos_Prop;
			if (n == 0)
			{
				CharLen_Prop = 0;
				CharPos_Prop = 0;
				if (!CheckPreamble_Prop)
				{
					ByteLen_Prop = 0;
				}
				readToUserBuffer = count >= MaxCharsPerBuffer_Prop;
				do
				{
					if (CheckPreamble_Prop)
					{
						int bytePos_Prop = BytePos_Prop;
						int num = await tmpStream.ReadAsync(tmpByteBuffer, bytePos_Prop, tmpByteBuffer.Length - bytePos_Prop).ConfigureAwait(continueOnCapturedContext: false);
						if (num == 0)
						{
							if (ByteLen_Prop > 0)
							{
								if (readToUserBuffer)
								{
									n = Decoder_Prop.GetChars(tmpByteBuffer, 0, ByteLen_Prop, buffer, index + charsRead);
									CharLen_Prop = 0;
								}
								else
								{
									n = Decoder_Prop.GetChars(tmpByteBuffer, 0, ByteLen_Prop, CharBuffer_Prop, 0);
									CharLen_Prop += n;
								}
							}
							IsBlocked_Prop = true;
							break;
						}
						ByteLen_Prop += num;
					}
					else
					{
						ByteLen_Prop = await tmpStream.ReadAsync(tmpByteBuffer, 0, tmpByteBuffer.Length).ConfigureAwait(continueOnCapturedContext: false);
						if (ByteLen_Prop == 0)
						{
							IsBlocked_Prop = true;
							break;
						}
					}
					IsBlocked_Prop = ByteLen_Prop < tmpByteBuffer.Length;
					if (!IsPreamble())
					{
						if (DetectEncoding_Prop && ByteLen_Prop >= 2)
						{
							DetectEncoding();
							readToUserBuffer = count >= MaxCharsPerBuffer_Prop;
						}
						CharPos_Prop = 0;
						if (readToUserBuffer)
						{
							n += Decoder_Prop.GetChars(tmpByteBuffer, 0, ByteLen_Prop, buffer, index + charsRead);
							CharLen_Prop = 0;
						}
						else
						{
							n = Decoder_Prop.GetChars(tmpByteBuffer, 0, ByteLen_Prop, CharBuffer_Prop, 0);
							CharLen_Prop += n;
						}
					}
				}
				while (n == 0);
				if (n == 0)
				{
					break;
				}
			}
			if (n > count)
			{
				n = count;
			}
			if (!readToUserBuffer)
			{
				Buffer.InternalBlockCopy(CharBuffer_Prop, CharPos_Prop * 2, buffer, (index + charsRead) * 2, n * 2);
				CharPos_Prop += n;
			}
			charsRead += n;
			count -= n;
			if (IsBlocked_Prop)
			{
				break;
			}
		}
		return charsRead;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (GetType() != typeof(StreamReader))
		{
			return base.ReadBlockAsync(buffer, index, count);
		}
		if (stream == null)
		{
			__Error.ReaderClosed();
		}
		CheckAsyncTaskInProgress();
		return (Task<int>)(_asyncReadTask = base.ReadBlockAsync(buffer, index, count));
	}

	private async Task<int> ReadBufferAsync()
	{
		CharLen_Prop = 0;
		CharPos_Prop = 0;
		byte[] tmpByteBuffer = ByteBuffer_Prop;
		Stream tmpStream = Stream_Prop;
		if (!CheckPreamble_Prop)
		{
			ByteLen_Prop = 0;
		}
		do
		{
			if (CheckPreamble_Prop)
			{
				int bytePos_Prop = BytePos_Prop;
				int num = await tmpStream.ReadAsync(tmpByteBuffer, bytePos_Prop, tmpByteBuffer.Length - bytePos_Prop).ConfigureAwait(continueOnCapturedContext: false);
				if (num == 0)
				{
					if (ByteLen_Prop > 0)
					{
						CharLen_Prop += Decoder_Prop.GetChars(tmpByteBuffer, 0, ByteLen_Prop, CharBuffer_Prop, CharLen_Prop);
						BytePos_Prop = 0;
						ByteLen_Prop = 0;
					}
					return CharLen_Prop;
				}
				ByteLen_Prop += num;
			}
			else
			{
				ByteLen_Prop = await tmpStream.ReadAsync(tmpByteBuffer, 0, tmpByteBuffer.Length).ConfigureAwait(continueOnCapturedContext: false);
				if (ByteLen_Prop == 0)
				{
					return CharLen_Prop;
				}
			}
			IsBlocked_Prop = ByteLen_Prop < tmpByteBuffer.Length;
			if (!IsPreamble())
			{
				if (DetectEncoding_Prop && ByteLen_Prop >= 2)
				{
					DetectEncoding();
				}
				CharLen_Prop += Decoder_Prop.GetChars(tmpByteBuffer, 0, ByteLen_Prop, CharBuffer_Prop, CharLen_Prop);
			}
		}
		while (CharLen_Prop == 0);
		return CharLen_Prop;
	}
}
