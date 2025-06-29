using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.IO.Ports;

[MonitoringDescription("SerialPortDesc")]
public class SerialPort : Component
{
	public const int InfiniteTimeout = -1;

	private const int defaultDataBits = 8;

	private const Parity defaultParity = Parity.None;

	private const StopBits defaultStopBits = StopBits.One;

	private const Handshake defaultHandshake = Handshake.None;

	private const int defaultBufferSize = 1024;

	private const string defaultPortName = "COM1";

	private const int defaultBaudRate = 9600;

	private const bool defaultDtrEnable = false;

	private const bool defaultRtsEnable = false;

	private const bool defaultDiscardNull = false;

	private const byte defaultParityReplace = 63;

	private const int defaultReceivedBytesThreshold = 1;

	private const int defaultReadTimeout = -1;

	private const int defaultWriteTimeout = -1;

	private const int defaultReadBufferSize = 4096;

	private const int defaultWriteBufferSize = 2048;

	private const int maxDataBits = 8;

	private const int minDataBits = 5;

	private const string defaultNewLine = "\n";

	private const string SERIAL_NAME = "\\Device\\Serial";

	private int baudRate = 9600;

	private int dataBits = 8;

	private Parity parity;

	private StopBits stopBits = StopBits.One;

	private string portName = "COM1";

	private Encoding encoding = Encoding.ASCII;

	private Decoder decoder = Encoding.ASCII.GetDecoder();

	private int maxByteCountForSingleChar = Encoding.ASCII.GetMaxByteCount(1);

	private Handshake handshake;

	private int readTimeout = -1;

	private int writeTimeout = -1;

	private int receivedBytesThreshold = 1;

	private bool discardNull;

	private bool dtrEnable;

	private bool rtsEnable;

	private byte parityReplace = 63;

	private string newLine = "\n";

	private int readBufferSize = 4096;

	private int writeBufferSize = 2048;

	private SerialStream internalSerialStream;

	private byte[] inBuffer = new byte[1024];

	private int readPos;

	private int readLen;

	private char[] oneChar = new char[1];

	private char[] singleCharBuffer;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Stream BaseStream
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("BaseStream_Invalid_Not_Open"));
			}
			return internalSerialStream;
		}
	}

	[Browsable(true)]
	[DefaultValue(9600)]
	[MonitoringDescription("BaudRate")]
	public int BaudRate
	{
		get
		{
			return baudRate;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("BaudRate", SR.GetString("ArgumentOutOfRange_NeedPosNum"));
			}
			if (IsOpen)
			{
				internalSerialStream.BaudRate = value;
			}
			baudRate = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool BreakState
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			return internalSerialStream.BreakState;
		}
		set
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			internalSerialStream.BreakState = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int BytesToWrite
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			return internalSerialStream.BytesToWrite;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int BytesToRead
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			return internalSerialStream.BytesToRead + CachedBytesToRead;
		}
	}

	private int CachedBytesToRead => readLen - readPos;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool CDHolding
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			return internalSerialStream.CDHolding;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool CtsHolding
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			return internalSerialStream.CtsHolding;
		}
	}

	[Browsable(true)]
	[DefaultValue(8)]
	[MonitoringDescription("DataBits")]
	public int DataBits
	{
		get
		{
			return dataBits;
		}
		set
		{
			if (value < 5 || value > 8)
			{
				throw new ArgumentOutOfRangeException("DataBits", SR.GetString("ArgumentOutOfRange_Bounds_Lower_Upper", 5, 8));
			}
			if (IsOpen)
			{
				internalSerialStream.DataBits = value;
			}
			dataBits = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[MonitoringDescription("DiscardNull")]
	public bool DiscardNull
	{
		get
		{
			return discardNull;
		}
		set
		{
			if (IsOpen)
			{
				internalSerialStream.DiscardNull = value;
			}
			discardNull = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool DsrHolding
	{
		get
		{
			if (!IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Port_not_open"));
			}
			return internalSerialStream.DsrHolding;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[MonitoringDescription("DtrEnable")]
	public bool DtrEnable
	{
		get
		{
			if (IsOpen)
			{
				dtrEnable = internalSerialStream.DtrEnable;
			}
			return dtrEnable;
		}
		set
		{
			if (IsOpen)
			{
				internalSerialStream.DtrEnable = value;
			}
			dtrEnable = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("Encoding")]
	public Encoding Encoding
	{
		get
		{
			return encoding;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("Encoding");
			}
			if (!(value is ASCIIEncoding) && !(value is UTF8Encoding) && !(value is UnicodeEncoding) && !(value is UTF32Encoding) && ((value.CodePage >= 50000 && value.CodePage != 54936) || !(value.GetType().Assembly == typeof(string).Assembly)))
			{
				throw new ArgumentException(SR.GetString("NotSupportedEncoding", value.WebName), "value");
			}
			encoding = value;
			decoder = encoding.GetDecoder();
			maxByteCountForSingleChar = encoding.GetMaxByteCount(1);
			singleCharBuffer = null;
		}
	}

	[Browsable(true)]
	[DefaultValue(Handshake.None)]
	[MonitoringDescription("Handshake")]
	public Handshake Handshake
	{
		get
		{
			return handshake;
		}
		set
		{
			if (value < Handshake.None || value > Handshake.RequestToSendXOnXOff)
			{
				throw new ArgumentOutOfRangeException("Handshake", SR.GetString("ArgumentOutOfRange_Enum"));
			}
			if (IsOpen)
			{
				internalSerialStream.Handshake = value;
			}
			handshake = value;
		}
	}

	[Browsable(false)]
	public bool IsOpen
	{
		get
		{
			if (internalSerialStream != null)
			{
				return internalSerialStream.IsOpen;
			}
			return false;
		}
	}

	[Browsable(false)]
	[DefaultValue("\n")]
	[MonitoringDescription("NewLine")]
	public string NewLine
	{
		get
		{
			return newLine;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(SR.GetString("InvalidNullEmptyArgument", "NewLine"));
			}
			newLine = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(Parity.None)]
	[MonitoringDescription("Parity")]
	public Parity Parity
	{
		get
		{
			return parity;
		}
		set
		{
			if (value < Parity.None || value > Parity.Space)
			{
				throw new ArgumentOutOfRangeException("Parity", SR.GetString("ArgumentOutOfRange_Enum"));
			}
			if (IsOpen)
			{
				internalSerialStream.Parity = value;
			}
			parity = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(63)]
	[MonitoringDescription("ParityReplace")]
	public byte ParityReplace
	{
		get
		{
			return parityReplace;
		}
		set
		{
			if (IsOpen)
			{
				internalSerialStream.ParityReplace = value;
			}
			parityReplace = value;
		}
	}

	[Browsable(true)]
	[DefaultValue("COM1")]
	[MonitoringDescription("PortName")]
	public string PortName
	{
		get
		{
			return portName;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PortName");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(SR.GetString("PortNameEmpty_String"), "PortName");
			}
			if (value.StartsWith("\\\\", StringComparison.Ordinal))
			{
				throw new ArgumentException(SR.GetString("Arg_SecurityException"), "PortName");
			}
			if (IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Cant_be_set_when_open", "PortName"));
			}
			portName = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(4096)]
	[MonitoringDescription("ReadBufferSize")]
	public int ReadBufferSize
	{
		get
		{
			return readBufferSize;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Cant_be_set_when_open", "value"));
			}
			readBufferSize = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(-1)]
	[MonitoringDescription("ReadTimeout")]
	public int ReadTimeout
	{
		get
		{
			return readTimeout;
		}
		set
		{
			if (value < 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("ReadTimeout", SR.GetString("ArgumentOutOfRange_Timeout"));
			}
			if (IsOpen)
			{
				internalSerialStream.ReadTimeout = value;
			}
			readTimeout = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(1)]
	[MonitoringDescription("ReceivedBytesThreshold")]
	public int ReceivedBytesThreshold
	{
		get
		{
			return receivedBytesThreshold;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("ReceivedBytesThreshold", SR.GetString("ArgumentOutOfRange_NeedPosNum"));
			}
			receivedBytesThreshold = value;
			if (IsOpen)
			{
				SerialDataReceivedEventArgs e = new SerialDataReceivedEventArgs(SerialData.Chars);
				CatchReceivedEvents(this, e);
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[MonitoringDescription("RtsEnable")]
	public bool RtsEnable
	{
		get
		{
			if (IsOpen)
			{
				rtsEnable = internalSerialStream.RtsEnable;
			}
			return rtsEnable;
		}
		set
		{
			if (IsOpen)
			{
				internalSerialStream.RtsEnable = value;
			}
			rtsEnable = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(StopBits.One)]
	[MonitoringDescription("StopBits")]
	public StopBits StopBits
	{
		get
		{
			return stopBits;
		}
		set
		{
			if (value < StopBits.One || value > StopBits.OnePointFive)
			{
				throw new ArgumentOutOfRangeException("StopBits", SR.GetString("ArgumentOutOfRange_Enum"));
			}
			if (IsOpen)
			{
				internalSerialStream.StopBits = value;
			}
			stopBits = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(2048)]
	[MonitoringDescription("WriteBufferSize")]
	public int WriteBufferSize
	{
		get
		{
			return writeBufferSize;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (IsOpen)
			{
				throw new InvalidOperationException(SR.GetString("Cant_be_set_when_open", "value"));
			}
			writeBufferSize = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(-1)]
	[MonitoringDescription("WriteTimeout")]
	public int WriteTimeout
	{
		get
		{
			return writeTimeout;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("WriteTimeout", SR.GetString("ArgumentOutOfRange_WriteTimeout"));
			}
			if (IsOpen)
			{
				internalSerialStream.WriteTimeout = value;
			}
			writeTimeout = value;
		}
	}

	[MonitoringDescription("SerialErrorReceived")]
	public event SerialErrorReceivedEventHandler ErrorReceived;

	[MonitoringDescription("SerialPinChanged")]
	public event SerialPinChangedEventHandler PinChanged;

	[MonitoringDescription("SerialDataReceived")]
	public event SerialDataReceivedEventHandler DataReceived;

	public SerialPort(IContainer container)
	{
		container.Add(this);
	}

	public SerialPort()
	{
	}

	public SerialPort(string portName)
		: this(portName, 9600, Parity.None, 8, StopBits.One)
	{
	}

	public SerialPort(string portName, int baudRate)
		: this(portName, baudRate, Parity.None, 8, StopBits.One)
	{
	}

	public SerialPort(string portName, int baudRate, Parity parity)
		: this(portName, baudRate, parity, 8, StopBits.One)
	{
	}

	public SerialPort(string portName, int baudRate, Parity parity, int dataBits)
		: this(portName, baudRate, parity, dataBits, StopBits.One)
	{
	}

	public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
	{
		PortName = portName;
		BaudRate = baudRate;
		Parity = parity;
		DataBits = dataBits;
		StopBits = stopBits;
	}

	public void Close()
	{
		Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && IsOpen)
		{
			internalSerialStream.Flush();
			internalSerialStream.Close();
			internalSerialStream = null;
		}
		base.Dispose(disposing);
	}

	public void DiscardInBuffer()
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		internalSerialStream.DiscardInBuffer();
		readPos = (readLen = 0);
	}

	public void DiscardOutBuffer()
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		internalSerialStream.DiscardOutBuffer();
	}

	public static string[] GetPortNames()
	{
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		string[] array = null;
		RegistryPermission registryPermission = new RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\\HARDWARE\\DEVICEMAP\\SERIALCOMM");
		registryPermission.Assert();
		try
		{
			registryKey = Registry.LocalMachine;
			registryKey2 = registryKey.OpenSubKey("HARDWARE\\DEVICEMAP\\SERIALCOMM", writable: false);
			if (registryKey2 != null)
			{
				string[] valueNames = registryKey2.GetValueNames();
				array = new string[valueNames.Length];
				for (int i = 0; i < valueNames.Length; i++)
				{
					array[i] = (string)registryKey2.GetValue(valueNames[i]);
				}
			}
		}
		finally
		{
			registryKey?.Close();
			registryKey2?.Close();
			CodeAccessPermission.RevertAssert();
		}
		if (array == null)
		{
			array = new string[0];
		}
		return array;
	}

	public void Open()
	{
		if (IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_already_open"));
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		internalSerialStream = new SerialStream(portName, baudRate, parity, dataBits, stopBits, readTimeout, writeTimeout, handshake, dtrEnable, rtsEnable, discardNull, parityReplace);
		internalSerialStream.SetBufferSizes(readBufferSize, writeBufferSize);
		internalSerialStream.ErrorReceived += CatchErrorEvents;
		internalSerialStream.PinChanged += CatchPinChangedEvents;
		internalSerialStream.DataReceived += CatchReceivedEvents;
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		int num = 0;
		if (CachedBytesToRead >= 1)
		{
			num = Math.Min(CachedBytesToRead, count);
			Buffer.BlockCopy(inBuffer, readPos, buffer, offset, num);
			readPos += num;
			if (num == count)
			{
				if (readPos == readLen)
				{
					readPos = (readLen = 0);
				}
				return count;
			}
			if (BytesToRead == 0)
			{
				return num;
			}
		}
		readLen = (readPos = 0);
		int count2 = count - num;
		num += internalSerialStream.Read(buffer, offset + num, count2);
		decoder.Reset();
		return num;
	}

	public int ReadChar()
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		return ReadOneChar(readTimeout);
	}

	private int ReadOneChar(int timeout)
	{
		int num = 0;
		if (decoder.GetCharCount(inBuffer, readPos, CachedBytesToRead) != 0)
		{
			int num2 = readPos;
			do
			{
				readPos++;
			}
			while (decoder.GetCharCount(inBuffer, num2, readPos - num2) < 1);
			try
			{
				decoder.GetChars(inBuffer, num2, readPos - num2, oneChar, 0);
			}
			catch
			{
				readPos = num2;
				throw;
			}
			return oneChar[0];
		}
		if (timeout == 0)
		{
			int num3 = internalSerialStream.BytesToRead;
			if (num3 == 0)
			{
				num3 = 1;
			}
			MaybeResizeBuffer(num3);
			readLen += internalSerialStream.Read(inBuffer, readLen, num3);
			if (ReadBufferIntoChars(oneChar, 0, 1, countMultiByteCharsAsOne: false) == 0)
			{
				throw new TimeoutException();
			}
			return oneChar[0];
		}
		int tickCount = Environment.TickCount;
		do
		{
			int num4;
			if (timeout == -1)
			{
				num4 = internalSerialStream.ReadByte(-1);
			}
			else
			{
				if (timeout - num < 0)
				{
					throw new TimeoutException();
				}
				num4 = internalSerialStream.ReadByte(timeout - num);
				num = Environment.TickCount - tickCount;
			}
			MaybeResizeBuffer(1);
			inBuffer[readLen++] = (byte)num4;
		}
		while (decoder.GetCharCount(inBuffer, readPos, readLen - readPos) < 1);
		decoder.GetChars(inBuffer, readPos, readLen - readPos, oneChar, 0);
		readLen = (readPos = 0);
		return oneChar[0];
	}

	public int Read(char[] buffer, int offset, int count)
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		return InternalRead(buffer, offset, count, readTimeout, countMultiByteCharsAsOne: false);
	}

	private int InternalRead(char[] buffer, int offset, int count, int timeout, bool countMultiByteCharsAsOne)
	{
		if (count == 0)
		{
			return 0;
		}
		int tickCount = Environment.TickCount;
		int bytesToRead = internalSerialStream.BytesToRead;
		MaybeResizeBuffer(bytesToRead);
		readLen += internalSerialStream.Read(inBuffer, readLen, bytesToRead);
		int charCount = decoder.GetCharCount(inBuffer, readPos, CachedBytesToRead);
		if (charCount > 0)
		{
			return ReadBufferIntoChars(buffer, offset, count, countMultiByteCharsAsOne);
		}
		if (timeout == 0)
		{
			throw new TimeoutException();
		}
		int maxByteCount = Encoding.GetMaxByteCount(count);
		do
		{
			MaybeResizeBuffer(maxByteCount);
			readLen += internalSerialStream.Read(inBuffer, readLen, maxByteCount);
			int num = ReadBufferIntoChars(buffer, offset, count, countMultiByteCharsAsOne);
			if (num > 0)
			{
				return num;
			}
		}
		while (timeout == -1 || timeout - GetElapsedTime(Environment.TickCount, tickCount) > 0);
		throw new TimeoutException();
	}

	private int ReadBufferIntoChars(char[] buffer, int offset, int count, bool countMultiByteCharsAsOne)
	{
		int num = Math.Min(count, CachedBytesToRead);
		DecoderReplacementFallback decoderReplacementFallback = encoding.DecoderFallback as DecoderReplacementFallback;
		if (encoding.IsSingleByte && encoding.GetMaxCharCount(num) == num && decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1)
		{
			decoder.GetChars(inBuffer, readPos, num, buffer, offset);
			readPos += num;
			if (readPos == readLen)
			{
				readPos = (readLen = 0);
			}
			return num;
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = readPos;
		do
		{
			int num5 = Math.Min(count - num3, readLen - readPos - num2);
			if (num5 <= 0)
			{
				break;
			}
			num2 += num5;
			num5 = readPos + num2 - num4;
			int charCount = decoder.GetCharCount(inBuffer, num4, num5);
			if (charCount > 0)
			{
				if (num3 + charCount > count && !countMultiByteCharsAsOne)
				{
					break;
				}
				int num6 = num5;
				do
				{
					num6--;
				}
				while (decoder.GetCharCount(inBuffer, num4, num6) == charCount);
				decoder.GetChars(inBuffer, num4, num6 + 1, buffer, offset + num3);
				num4 = num4 + num6 + 1;
			}
			num3 += charCount;
		}
		while (num3 < count && num2 < CachedBytesToRead);
		readPos = num4;
		if (readPos == readLen)
		{
			readPos = (readLen = 0);
		}
		return num3;
	}

	public int ReadByte()
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (readLen != readPos)
		{
			return inBuffer[readPos++];
		}
		decoder.Reset();
		return internalSerialStream.ReadByte();
	}

	public string ReadExisting()
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		byte[] array = new byte[BytesToRead];
		if (readPos < readLen)
		{
			Buffer.BlockCopy(inBuffer, readPos, array, 0, CachedBytesToRead);
		}
		internalSerialStream.Read(array, CachedBytesToRead, array.Length - CachedBytesToRead);
		Decoder decoder = Encoding.GetDecoder();
		int charCount = decoder.GetCharCount(array, 0, array.Length);
		int num = array.Length;
		if (charCount == 0)
		{
			Buffer.BlockCopy(array, 0, inBuffer, 0, array.Length);
			readPos = 0;
			readLen = array.Length;
			return "";
		}
		do
		{
			decoder.Reset();
			num--;
		}
		while (decoder.GetCharCount(array, 0, num) == charCount);
		readPos = 0;
		readLen = array.Length - (num + 1);
		Buffer.BlockCopy(array, num + 1, inBuffer, 0, array.Length - (num + 1));
		return Encoding.GetString(array, 0, num + 1);
	}

	public string ReadLine()
	{
		return ReadTo(NewLine);
	}

	public string ReadTo(string value)
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (value.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidNullEmptyArgument", "value"));
		}
		int tickCount = Environment.TickCount;
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder();
		char c = value[value.Length - 1];
		int bytesToRead = internalSerialStream.BytesToRead;
		MaybeResizeBuffer(bytesToRead);
		readLen += internalSerialStream.Read(inBuffer, readLen, bytesToRead);
		int num2 = readPos;
		if (singleCharBuffer == null)
		{
			singleCharBuffer = new char[maxByteCountForSingleChar];
		}
		try
		{
			while (true)
			{
				int num3;
				if (readTimeout == -1)
				{
					num3 = InternalRead(singleCharBuffer, 0, 1, readTimeout, countMultiByteCharsAsOne: true);
				}
				else
				{
					if (readTimeout - num < 0)
					{
						throw new TimeoutException();
					}
					int tickCount2 = Environment.TickCount;
					num3 = InternalRead(singleCharBuffer, 0, 1, readTimeout - num, countMultiByteCharsAsOne: true);
					num += Environment.TickCount - tickCount2;
				}
				stringBuilder.Append(singleCharBuffer, 0, num3);
				if (c != singleCharBuffer[num3 - 1] || stringBuilder.Length < value.Length)
				{
					continue;
				}
				bool flag = true;
				for (int i = 2; i <= value.Length; i++)
				{
					if (value[value.Length - i] != stringBuilder[stringBuilder.Length - i])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			string result = stringBuilder.ToString(0, stringBuilder.Length - value.Length);
			if (readPos == readLen)
			{
				readPos = (readLen = 0);
			}
			return result;
		}
		catch
		{
			byte[] bytes = encoding.GetBytes(stringBuilder.ToString());
			if (bytes.Length != 0)
			{
				int cachedBytesToRead = CachedBytesToRead;
				byte[] array = new byte[cachedBytesToRead];
				if (cachedBytesToRead > 0)
				{
					Buffer.BlockCopy(inBuffer, readPos, array, 0, cachedBytesToRead);
				}
				readPos = 0;
				readLen = 0;
				MaybeResizeBuffer(bytes.Length + cachedBytesToRead);
				Buffer.BlockCopy(bytes, 0, inBuffer, readLen, bytes.Length);
				readLen += bytes.Length;
				if (cachedBytesToRead > 0)
				{
					Buffer.BlockCopy(array, 0, inBuffer, readLen, cachedBytesToRead);
					readLen += cachedBytesToRead;
				}
			}
			throw;
		}
	}

	public void Write(string text)
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (text.Length != 0)
		{
			byte[] bytes = encoding.GetBytes(text);
			internalSerialStream.Write(bytes, 0, bytes.Length, writeTimeout);
		}
	}

	public void Write(char[] buffer, int offset, int count)
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (buffer.Length != 0)
		{
			byte[] bytes = Encoding.GetBytes(buffer, offset, count);
			Write(bytes, 0, bytes.Length);
		}
	}

	public void Write(byte[] buffer, int offset, int count)
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException(SR.GetString("Port_not_open"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (buffer.Length != 0)
		{
			internalSerialStream.Write(buffer, offset, count, writeTimeout);
		}
	}

	public void WriteLine(string text)
	{
		Write(text + NewLine);
	}

	private void CatchErrorEvents(object src, SerialErrorReceivedEventArgs e)
	{
		SerialErrorReceivedEventHandler serialErrorReceivedEventHandler = this.ErrorReceived;
		SerialStream serialStream = internalSerialStream;
		if (serialErrorReceivedEventHandler == null || serialStream == null)
		{
			return;
		}
		lock (serialStream)
		{
			if (serialStream.IsOpen)
			{
				serialErrorReceivedEventHandler(this, e);
			}
		}
	}

	private void CatchPinChangedEvents(object src, SerialPinChangedEventArgs e)
	{
		SerialPinChangedEventHandler serialPinChangedEventHandler = this.PinChanged;
		SerialStream serialStream = internalSerialStream;
		if (serialPinChangedEventHandler == null || serialStream == null)
		{
			return;
		}
		lock (serialStream)
		{
			if (serialStream.IsOpen)
			{
				serialPinChangedEventHandler(this, e);
			}
		}
	}

	private void CatchReceivedEvents(object src, SerialDataReceivedEventArgs e)
	{
		SerialDataReceivedEventHandler serialDataReceivedEventHandler = this.DataReceived;
		SerialStream serialStream = internalSerialStream;
		if (serialDataReceivedEventHandler == null || serialStream == null)
		{
			return;
		}
		lock (serialStream)
		{
			bool flag = false;
			try
			{
				flag = serialStream.IsOpen && (SerialData.Eof == e.EventType || BytesToRead >= receivedBytesThreshold);
			}
			catch
			{
			}
			finally
			{
				if (flag)
				{
					serialDataReceivedEventHandler(this, e);
				}
			}
		}
	}

	private void CompactBuffer()
	{
		Buffer.BlockCopy(inBuffer, readPos, inBuffer, 0, CachedBytesToRead);
		readLen = CachedBytesToRead;
		readPos = 0;
	}

	private void MaybeResizeBuffer(int additionalByteLength)
	{
		if (additionalByteLength + readLen > inBuffer.Length)
		{
			if (CachedBytesToRead + additionalByteLength <= inBuffer.Length / 2)
			{
				CompactBuffer();
				return;
			}
			int num = Math.Max(CachedBytesToRead + additionalByteLength, inBuffer.Length * 2);
			byte[] dst = new byte[num];
			Buffer.BlockCopy(inBuffer, readPos, dst, 0, CachedBytesToRead);
			readLen = CachedBytesToRead;
			readPos = 0;
			inBuffer = dst;
		}
	}

	private static int GetElapsedTime(int currentTickCount, int startTickCount)
	{
		int num = currentTickCount - startTickCount;
		if (num < 0)
		{
			return int.MaxValue;
		}
		return num;
	}
}
