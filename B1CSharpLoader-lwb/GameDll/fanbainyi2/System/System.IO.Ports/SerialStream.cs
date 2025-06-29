using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Ports;

internal sealed class SerialStream : Stream
{
	internal sealed class EventLoopRunner
	{
		private WeakReference streamWeakReference;

		internal ManualResetEvent eventLoopEndedSignal = new ManualResetEvent(initialState: false);

		internal ManualResetEvent waitCommEventWaitHandle = new ManualResetEvent(initialState: false);

		private SafeFileHandle handle;

		private bool isAsync;

		internal bool endEventLoop;

		private int eventsOccurred;

		private WaitCallback callErrorEvents;

		private WaitCallback callReceiveEvents;

		private WaitCallback callPinEvents;

		private IOCompletionCallback freeNativeOverlappedCallback;

		internal bool ShutdownLoop => endEventLoop;

		internal unsafe EventLoopRunner(SerialStream stream)
		{
			handle = stream._handle;
			streamWeakReference = new WeakReference(stream);
			callErrorEvents = CallErrorEvents;
			callReceiveEvents = CallReceiveEvents;
			callPinEvents = CallPinEvents;
			freeNativeOverlappedCallback = FreeNativeOverlappedCallback;
			isAsync = stream.isAsync;
		}

		internal unsafe void WaitForCommEvent()
		{
			int lpNumberOfBytesTransferred = 0;
			bool flag = false;
			NativeOverlapped* ptr = null;
			while (!ShutdownLoop)
			{
				SerialStreamAsyncResult serialStreamAsyncResult = null;
				if (isAsync)
				{
					serialStreamAsyncResult = new SerialStreamAsyncResult();
					serialStreamAsyncResult._userCallback = null;
					serialStreamAsyncResult._userStateObject = null;
					serialStreamAsyncResult._isWrite = false;
					serialStreamAsyncResult._numBytes = 2;
					serialStreamAsyncResult._waitHandle = waitCommEventWaitHandle;
					waitCommEventWaitHandle.Reset();
					Overlapped overlapped = new Overlapped(0, 0, waitCommEventWaitHandle.SafeWaitHandle.DangerousGetHandle(), serialStreamAsyncResult);
					ptr = overlapped.Pack(freeNativeOverlappedCallback, null);
				}
				fixed (int* lpEvtMask = &eventsOccurred)
				{
					if (!Microsoft.Win32.UnsafeNativeMethods.WaitCommEvent(handle, lpEvtMask, ptr))
					{
						switch (Marshal.GetLastWin32Error())
						{
						case 5:
						case 22:
						case 1617:
							flag = true;
							goto end_IL_0158;
						case 997:
						{
							bool flag2 = waitCommEventWaitHandle.WaitOne();
							int lastWin32Error;
							do
							{
								flag2 = Microsoft.Win32.UnsafeNativeMethods.GetOverlappedResult(handle, ptr, ref lpNumberOfBytesTransferred, bWait: false);
								lastWin32Error = Marshal.GetLastWin32Error();
							}
							while (lastWin32Error == 996 && !ShutdownLoop && !flag2);
							if (!flag2 && (lastWin32Error == 996 || lastWin32Error == 87) && ShutdownLoop)
							{
							}
							break;
						}
						default:
							_ = 87;
							break;
						}
					}
				}
				if (!ShutdownLoop)
				{
					CallEvents(eventsOccurred);
				}
				if (isAsync && Interlocked.Decrement(ref serialStreamAsyncResult._numBytes) == 0)
				{
					Overlapped.Free(ptr);
				}
				continue;
				end_IL_0158:
				break;
			}
			if (flag)
			{
				endEventLoop = true;
				Overlapped.Free(ptr);
			}
			eventLoopEndedSignal.Set();
		}

		private unsafe void FreeNativeOverlappedCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
		{
			Overlapped overlapped = Overlapped.Unpack(pOverlapped);
			SerialStreamAsyncResult serialStreamAsyncResult = (SerialStreamAsyncResult)overlapped.AsyncResult;
			if (Interlocked.Decrement(ref serialStreamAsyncResult._numBytes) == 0)
			{
				Overlapped.Free(pOverlapped);
			}
		}

		private void CallEvents(int nativeEvents)
		{
			if ((nativeEvents & 0x81) != 0)
			{
				int lpErrors = 0;
				if (!Microsoft.Win32.UnsafeNativeMethods.ClearCommError(handle, ref lpErrors, IntPtr.Zero))
				{
					endEventLoop = true;
					Thread.MemoryBarrier();
					return;
				}
				lpErrors &= 0x10F;
				if (lpErrors != 0)
				{
					ThreadPool.QueueUserWorkItem(callErrorEvents, lpErrors);
				}
			}
			if ((nativeEvents & 0x178) != 0)
			{
				ThreadPool.QueueUserWorkItem(callPinEvents, nativeEvents);
			}
			if ((nativeEvents & 3) != 0)
			{
				ThreadPool.QueueUserWorkItem(callReceiveEvents, nativeEvents);
			}
		}

		private void CallErrorEvents(object state)
		{
			int num = (int)state;
			SerialStream serialStream = (SerialStream)streamWeakReference.Target;
			if (serialStream == null)
			{
				return;
			}
			if (serialStream.ErrorReceived != null)
			{
				if ((num & 0x100) != 0)
				{
					serialStream.ErrorReceived(serialStream, new SerialErrorReceivedEventArgs(SerialError.TXFull));
				}
				if ((num & 1) != 0)
				{
					serialStream.ErrorReceived(serialStream, new SerialErrorReceivedEventArgs(SerialError.RXOver));
				}
				if ((num & 2) != 0)
				{
					serialStream.ErrorReceived(serialStream, new SerialErrorReceivedEventArgs(SerialError.Overrun));
				}
				if ((num & 4) != 0)
				{
					serialStream.ErrorReceived(serialStream, new SerialErrorReceivedEventArgs(SerialError.RXParity));
				}
				if ((num & 8) != 0)
				{
					serialStream.ErrorReceived(serialStream, new SerialErrorReceivedEventArgs(SerialError.Frame));
				}
			}
			serialStream = null;
		}

		private void CallReceiveEvents(object state)
		{
			int num = (int)state;
			SerialStream serialStream = (SerialStream)streamWeakReference.Target;
			if (serialStream == null)
			{
				return;
			}
			if (serialStream.DataReceived != null)
			{
				if ((num & 1) != 0)
				{
					serialStream.DataReceived(serialStream, new SerialDataReceivedEventArgs(SerialData.Chars));
				}
				if ((num & 2) != 0)
				{
					serialStream.DataReceived(serialStream, new SerialDataReceivedEventArgs(SerialData.Eof));
				}
			}
			serialStream = null;
		}

		private void CallPinEvents(object state)
		{
			int num = (int)state;
			SerialStream serialStream = (SerialStream)streamWeakReference.Target;
			if (serialStream == null)
			{
				return;
			}
			if (serialStream.PinChanged != null)
			{
				if ((num & 8) != 0)
				{
					serialStream.PinChanged(serialStream, new SerialPinChangedEventArgs(SerialPinChange.CtsChanged));
				}
				if ((num & 0x10) != 0)
				{
					serialStream.PinChanged(serialStream, new SerialPinChangedEventArgs(SerialPinChange.DsrChanged));
				}
				if ((num & 0x20) != 0)
				{
					serialStream.PinChanged(serialStream, new SerialPinChangedEventArgs(SerialPinChange.CDChanged));
				}
				if ((num & 0x100) != 0)
				{
					serialStream.PinChanged(serialStream, new SerialPinChangedEventArgs(SerialPinChange.Ring));
				}
				if ((num & 0x40) != 0)
				{
					serialStream.PinChanged(serialStream, new SerialPinChangedEventArgs(SerialPinChange.Break));
				}
			}
			serialStream = null;
		}

		internal void SafelyWaitForCommEvent()
		{
			try
			{
				WaitForCommEvent();
			}
			catch (ObjectDisposedException)
			{
			}
			catch (Exception)
			{
			}
		}
	}

	internal sealed class SerialStreamAsyncResult : IAsyncResult
	{
		internal AsyncCallback _userCallback;

		internal object _userStateObject;

		internal bool _isWrite;

		internal bool _isComplete;

		internal bool _completedSynchronously;

		internal ManualResetEvent _waitHandle;

		internal int _EndXxxCalled;

		internal int _numBytes;

		internal int _errorCode;

		internal unsafe NativeOverlapped* _overlapped;

		public object AsyncState => _userStateObject;

		public bool IsCompleted => _isComplete;

		public WaitHandle AsyncWaitHandle => _waitHandle;

		public bool CompletedSynchronously => _completedSynchronously;
	}

	private const int errorEvents = 271;

	private const int receivedEvents = 3;

	private const int pinChangedEvents = 376;

	private const int infiniteTimeoutConst = -2;

	private string portName;

	private byte parityReplace = 63;

	private bool inBreak;

	private bool isAsync = true;

	private Handshake handshake;

	private bool rtsEnable;

	private Microsoft.Win32.UnsafeNativeMethods.DCB dcb;

	private Microsoft.Win32.UnsafeNativeMethods.COMMTIMEOUTS commTimeouts;

	private Microsoft.Win32.UnsafeNativeMethods.COMSTAT comStat;

	private Microsoft.Win32.UnsafeNativeMethods.COMMPROP commProp;

	private const int maxDataBits = 8;

	private const int minDataBits = 5;

	internal SafeFileHandle _handle;

	internal EventLoopRunner eventRunner;

	private byte[] tempBuf;

	private unsafe static readonly IOCompletionCallback IOCallback = AsyncFSCallback;

	public override bool CanRead => _handle != null;

	public override bool CanSeek => false;

	public override bool CanTimeout => _handle != null;

	public override bool CanWrite => _handle != null;

	public override long Length
	{
		get
		{
			throw new NotSupportedException(SR.GetString("NotSupported_UnseekableStream"));
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException(SR.GetString("NotSupported_UnseekableStream"));
		}
		set
		{
			throw new NotSupportedException(SR.GetString("NotSupported_UnseekableStream"));
		}
	}

	internal int BaudRate
	{
		set
		{
			if (value <= 0 || (value > commProp.dwMaxBaud && commProp.dwMaxBaud > 0))
			{
				if (commProp.dwMaxBaud == 0)
				{
					throw new ArgumentOutOfRangeException("baudRate", SR.GetString("ArgumentOutOfRange_NeedPosNum"));
				}
				throw new ArgumentOutOfRangeException("baudRate", SR.GetString("ArgumentOutOfRange_Bounds_Lower_Upper", 0, commProp.dwMaxBaud));
			}
			if (value != dcb.BaudRate)
			{
				int baudRate = (int)dcb.BaudRate;
				dcb.BaudRate = (uint)value;
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					dcb.BaudRate = (uint)baudRate;
					InternalResources.WinIOError();
				}
			}
		}
	}

	public bool BreakState
	{
		get
		{
			return inBreak;
		}
		set
		{
			if (value)
			{
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommBreak(_handle))
				{
					InternalResources.WinIOError();
				}
				inBreak = true;
			}
			else
			{
				if (!Microsoft.Win32.UnsafeNativeMethods.ClearCommBreak(_handle))
				{
					InternalResources.WinIOError();
				}
				inBreak = false;
			}
		}
	}

	internal int DataBits
	{
		set
		{
			if (value != dcb.ByteSize)
			{
				byte byteSize = dcb.ByteSize;
				dcb.ByteSize = (byte)value;
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					dcb.ByteSize = byteSize;
					InternalResources.WinIOError();
				}
			}
		}
	}

	internal bool DiscardNull
	{
		set
		{
			int dcbFlag = GetDcbFlag(11);
			if ((value && dcbFlag == 0) || (!value && dcbFlag == 1))
			{
				int setting = dcbFlag;
				SetDcbFlag(11, value ? 1 : 0);
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					SetDcbFlag(11, setting);
					InternalResources.WinIOError();
				}
			}
		}
	}

	internal bool DtrEnable
	{
		get
		{
			int dcbFlag = GetDcbFlag(4);
			return dcbFlag == 1;
		}
		set
		{
			int dcbFlag = GetDcbFlag(4);
			SetDcbFlag(4, value ? 1 : 0);
			if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
			{
				SetDcbFlag(4, dcbFlag);
				InternalResources.WinIOError();
			}
			if (!Microsoft.Win32.UnsafeNativeMethods.EscapeCommFunction(_handle, value ? 5 : 6))
			{
				InternalResources.WinIOError();
			}
		}
	}

	internal Handshake Handshake
	{
		set
		{
			if (value != this.handshake)
			{
				Handshake handshake = this.handshake;
				int dcbFlag = GetDcbFlag(9);
				int dcbFlag2 = GetDcbFlag(2);
				int dcbFlag3 = GetDcbFlag(12);
				this.handshake = value;
				int setting = ((this.handshake == Handshake.XOnXOff || this.handshake == Handshake.RequestToSendXOnXOff) ? 1 : 0);
				SetDcbFlag(9, setting);
				SetDcbFlag(8, setting);
				SetDcbFlag(2, (this.handshake == Handshake.RequestToSend || this.handshake == Handshake.RequestToSendXOnXOff) ? 1 : 0);
				if (this.handshake == Handshake.RequestToSend || this.handshake == Handshake.RequestToSendXOnXOff)
				{
					SetDcbFlag(12, 2);
				}
				else if (rtsEnable)
				{
					SetDcbFlag(12, 1);
				}
				else
				{
					SetDcbFlag(12, 0);
				}
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					this.handshake = handshake;
					SetDcbFlag(9, dcbFlag);
					SetDcbFlag(8, dcbFlag);
					SetDcbFlag(2, dcbFlag2);
					SetDcbFlag(12, dcbFlag3);
					InternalResources.WinIOError();
				}
			}
		}
	}

	internal bool IsOpen
	{
		get
		{
			if (_handle != null)
			{
				return !eventRunner.ShutdownLoop;
			}
			return false;
		}
	}

	internal Parity Parity
	{
		set
		{
			if ((byte)value != dcb.Parity)
			{
				byte parity = dcb.Parity;
				int dcbFlag = GetDcbFlag(1);
				byte errorChar = dcb.ErrorChar;
				int dcbFlag2 = GetDcbFlag(10);
				dcb.Parity = (byte)value;
				int num = ((dcb.Parity != 0) ? 1 : 0);
				SetDcbFlag(1, num);
				if (num == 1)
				{
					SetDcbFlag(10, (parityReplace != 0) ? 1 : 0);
					dcb.ErrorChar = parityReplace;
				}
				else
				{
					SetDcbFlag(10, 0);
					dcb.ErrorChar = 0;
				}
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					dcb.Parity = parity;
					SetDcbFlag(1, dcbFlag);
					dcb.ErrorChar = errorChar;
					SetDcbFlag(10, dcbFlag2);
					InternalResources.WinIOError();
				}
			}
		}
	}

	internal byte ParityReplace
	{
		set
		{
			if (value != parityReplace)
			{
				byte b = parityReplace;
				byte errorChar = dcb.ErrorChar;
				int dcbFlag = GetDcbFlag(10);
				parityReplace = value;
				if (GetDcbFlag(1) == 1)
				{
					SetDcbFlag(10, (parityReplace != 0) ? 1 : 0);
					dcb.ErrorChar = parityReplace;
				}
				else
				{
					SetDcbFlag(10, 0);
					dcb.ErrorChar = 0;
				}
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					parityReplace = b;
					SetDcbFlag(10, dcbFlag);
					dcb.ErrorChar = errorChar;
					InternalResources.WinIOError();
				}
			}
		}
	}

	public override int ReadTimeout
	{
		get
		{
			int readTotalTimeoutConstant = commTimeouts.ReadTotalTimeoutConstant;
			if (readTotalTimeoutConstant == -2)
			{
				return -1;
			}
			return readTotalTimeoutConstant;
		}
		set
		{
			if (value < 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("ReadTimeout", SR.GetString("ArgumentOutOfRange_Timeout"));
			}
			if (_handle == null)
			{
				InternalResources.FileNotOpen();
			}
			int readTotalTimeoutConstant = commTimeouts.ReadTotalTimeoutConstant;
			int readIntervalTimeout = commTimeouts.ReadIntervalTimeout;
			int readTotalTimeoutMultiplier = commTimeouts.ReadTotalTimeoutMultiplier;
			switch (value)
			{
			case 0:
				commTimeouts.ReadTotalTimeoutConstant = 0;
				commTimeouts.ReadTotalTimeoutMultiplier = 0;
				commTimeouts.ReadIntervalTimeout = -1;
				break;
			case -1:
				commTimeouts.ReadTotalTimeoutConstant = -2;
				commTimeouts.ReadTotalTimeoutMultiplier = -1;
				commTimeouts.ReadIntervalTimeout = -1;
				break;
			default:
				commTimeouts.ReadTotalTimeoutConstant = value;
				commTimeouts.ReadTotalTimeoutMultiplier = -1;
				commTimeouts.ReadIntervalTimeout = -1;
				break;
			}
			if (!Microsoft.Win32.UnsafeNativeMethods.SetCommTimeouts(_handle, ref commTimeouts))
			{
				commTimeouts.ReadTotalTimeoutConstant = readTotalTimeoutConstant;
				commTimeouts.ReadTotalTimeoutMultiplier = readTotalTimeoutMultiplier;
				commTimeouts.ReadIntervalTimeout = readIntervalTimeout;
				InternalResources.WinIOError();
			}
		}
	}

	internal bool RtsEnable
	{
		get
		{
			int dcbFlag = GetDcbFlag(12);
			if (dcbFlag == 2)
			{
				throw new InvalidOperationException(SR.GetString("CantSetRtsWithHandshaking"));
			}
			return dcbFlag == 1;
		}
		set
		{
			if (handshake == Handshake.RequestToSend || handshake == Handshake.RequestToSendXOnXOff)
			{
				throw new InvalidOperationException(SR.GetString("CantSetRtsWithHandshaking"));
			}
			if (value != rtsEnable)
			{
				int dcbFlag = GetDcbFlag(12);
				rtsEnable = value;
				if (value)
				{
					SetDcbFlag(12, 1);
				}
				else
				{
					SetDcbFlag(12, 0);
				}
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					SetDcbFlag(12, dcbFlag);
					rtsEnable = !rtsEnable;
					InternalResources.WinIOError();
				}
				if (!Microsoft.Win32.UnsafeNativeMethods.EscapeCommFunction(_handle, value ? 3 : 4))
				{
					InternalResources.WinIOError();
				}
			}
		}
	}

	internal StopBits StopBits
	{
		set
		{
			byte b = 0;
			b = value switch
			{
				StopBits.One => 0, 
				StopBits.OnePointFive => 1, 
				_ => 2, 
			};
			if (b != dcb.StopBits)
			{
				byte stopBits = dcb.StopBits;
				dcb.StopBits = b;
				if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
				{
					dcb.StopBits = stopBits;
					InternalResources.WinIOError();
				}
			}
		}
	}

	public override int WriteTimeout
	{
		get
		{
			int writeTotalTimeoutConstant = commTimeouts.WriteTotalTimeoutConstant;
			if (writeTotalTimeoutConstant != 0)
			{
				return writeTotalTimeoutConstant;
			}
			return -1;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("WriteTimeout", SR.GetString("ArgumentOutOfRange_WriteTimeout"));
			}
			if (_handle == null)
			{
				InternalResources.FileNotOpen();
			}
			int writeTotalTimeoutConstant = commTimeouts.WriteTotalTimeoutConstant;
			commTimeouts.WriteTotalTimeoutConstant = ((value != -1) ? value : 0);
			if (!Microsoft.Win32.UnsafeNativeMethods.SetCommTimeouts(_handle, ref commTimeouts))
			{
				commTimeouts.WriteTotalTimeoutConstant = writeTotalTimeoutConstant;
				InternalResources.WinIOError();
			}
		}
	}

	internal bool CDHolding
	{
		get
		{
			int lpModemStat = 0;
			if (!Microsoft.Win32.UnsafeNativeMethods.GetCommModemStatus(_handle, ref lpModemStat))
			{
				InternalResources.WinIOError();
			}
			return (0x80 & lpModemStat) != 0;
		}
	}

	internal bool CtsHolding
	{
		get
		{
			int lpModemStat = 0;
			if (!Microsoft.Win32.UnsafeNativeMethods.GetCommModemStatus(_handle, ref lpModemStat))
			{
				InternalResources.WinIOError();
			}
			return (0x10 & lpModemStat) != 0;
		}
	}

	internal bool DsrHolding
	{
		get
		{
			int lpModemStat = 0;
			if (!Microsoft.Win32.UnsafeNativeMethods.GetCommModemStatus(_handle, ref lpModemStat))
			{
				InternalResources.WinIOError();
			}
			return (0x20 & lpModemStat) != 0;
		}
	}

	internal int BytesToRead
	{
		get
		{
			int lpErrors = 0;
			if (!Microsoft.Win32.UnsafeNativeMethods.ClearCommError(_handle, ref lpErrors, ref comStat))
			{
				InternalResources.WinIOError();
			}
			return (int)comStat.cbInQue;
		}
	}

	internal int BytesToWrite
	{
		get
		{
			int lpErrors = 0;
			if (!Microsoft.Win32.UnsafeNativeMethods.ClearCommError(_handle, ref lpErrors, ref comStat))
			{
				InternalResources.WinIOError();
			}
			return (int)comStat.cbOutQue;
		}
	}

	internal event SerialDataReceivedEventHandler DataReceived;

	internal event SerialPinChangedEventHandler PinChanged;

	internal event SerialErrorReceivedEventHandler ErrorReceived;

	internal SerialStream(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits, int readTimeout, int writeTimeout, Handshake handshake, bool dtrEnable, bool rtsEnable, bool discardNull, byte parityReplace)
	{
		int dwFlagsAndAttributes = 1073741824;
		if (Environment.OSVersion.Platform == PlatformID.Win32Windows)
		{
			dwFlagsAndAttributes = 128;
			isAsync = false;
		}
		if (portName == null || !portName.StartsWith("COM", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(SR.GetString("Arg_InvalidSerialPort"), "portName");
		}
		SafeFileHandle safeFileHandle = Microsoft.Win32.UnsafeNativeMethods.CreateFile("\\\\.\\" + portName, -1073741824, 0, IntPtr.Zero, 3, dwFlagsAndAttributes, IntPtr.Zero);
		if (safeFileHandle.IsInvalid)
		{
			InternalResources.WinIOError(portName);
		}
		try
		{
			int fileType = Microsoft.Win32.UnsafeNativeMethods.GetFileType(safeFileHandle);
			if (fileType != 2 && fileType != 0)
			{
				throw new ArgumentException(SR.GetString("Arg_InvalidSerialPort"), "portName");
			}
			_handle = safeFileHandle;
			this.portName = portName;
			this.handshake = handshake;
			this.parityReplace = parityReplace;
			tempBuf = new byte[1];
			commProp = default(Microsoft.Win32.UnsafeNativeMethods.COMMPROP);
			int lpModemStat = 0;
			if (!Microsoft.Win32.UnsafeNativeMethods.GetCommProperties(_handle, ref commProp) || !Microsoft.Win32.UnsafeNativeMethods.GetCommModemStatus(_handle, ref lpModemStat))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 87 || lastWin32Error == 6)
				{
					throw new ArgumentException(SR.GetString("Arg_InvalidSerialPortExtended"), "portName");
				}
				InternalResources.WinIOError(lastWin32Error, string.Empty);
			}
			if (commProp.dwMaxBaud != 0 && baudRate > commProp.dwMaxBaud)
			{
				throw new ArgumentOutOfRangeException("baudRate", SR.GetString("Max_Baud", commProp.dwMaxBaud));
			}
			comStat = default(Microsoft.Win32.UnsafeNativeMethods.COMSTAT);
			dcb = default(Microsoft.Win32.UnsafeNativeMethods.DCB);
			InitializeDCB(baudRate, parity, dataBits, stopBits, discardNull);
			DtrEnable = dtrEnable;
			this.rtsEnable = GetDcbFlag(12) == 1;
			if (handshake != Handshake.RequestToSend && handshake != Handshake.RequestToSendXOnXOff)
			{
				RtsEnable = rtsEnable;
			}
			switch (readTimeout)
			{
			case 0:
				commTimeouts.ReadTotalTimeoutConstant = 0;
				commTimeouts.ReadTotalTimeoutMultiplier = 0;
				commTimeouts.ReadIntervalTimeout = -1;
				break;
			case -1:
				commTimeouts.ReadTotalTimeoutConstant = -2;
				commTimeouts.ReadTotalTimeoutMultiplier = -1;
				commTimeouts.ReadIntervalTimeout = -1;
				break;
			default:
				commTimeouts.ReadTotalTimeoutConstant = readTimeout;
				commTimeouts.ReadTotalTimeoutMultiplier = -1;
				commTimeouts.ReadIntervalTimeout = -1;
				break;
			}
			commTimeouts.WriteTotalTimeoutMultiplier = 0;
			commTimeouts.WriteTotalTimeoutConstant = ((writeTimeout != -1) ? writeTimeout : 0);
			if (!Microsoft.Win32.UnsafeNativeMethods.SetCommTimeouts(_handle, ref commTimeouts))
			{
				InternalResources.WinIOError();
			}
			if (isAsync && !ThreadPool.BindHandle(_handle))
			{
				throw new IOException(SR.GetString("IO_BindHandleFailed"));
			}
			Microsoft.Win32.UnsafeNativeMethods.SetCommMask(_handle, 507);
			eventRunner = new EventLoopRunner(this);
			Thread thread = (System.LocalAppContextSwitches.DoNotCatchSerialStreamThreadExceptions ? new Thread(eventRunner.WaitForCommEvent) : new Thread(eventRunner.SafelyWaitForCommEvent));
			thread.IsBackground = true;
			thread.Start();
		}
		catch
		{
			safeFileHandle.Close();
			_handle = null;
			throw;
		}
	}

	~SerialStream()
	{
		Dispose(disposing: false);
	}

	protected override void Dispose(bool disposing)
	{
		if (_handle == null || _handle.IsInvalid)
		{
			return;
		}
		try
		{
			eventRunner.endEventLoop = true;
			Thread.MemoryBarrier();
			bool flag = false;
			Microsoft.Win32.UnsafeNativeMethods.SetCommMask(_handle, 0);
			if (!Microsoft.Win32.UnsafeNativeMethods.EscapeCommFunction(_handle, 6))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if ((lastWin32Error == 5 || lastWin32Error == 22 || lastWin32Error == 1617) && !disposing)
				{
					flag = true;
				}
				else if (disposing)
				{
					InternalResources.WinIOError();
				}
			}
			if (!flag && !_handle.IsClosed)
			{
				Flush();
			}
			eventRunner.waitCommEventWaitHandle.Set();
			if (!flag)
			{
				DiscardInBuffer();
				DiscardOutBuffer();
			}
			if (disposing && eventRunner != null)
			{
				eventRunner.eventLoopEndedSignal.WaitOne();
				eventRunner.eventLoopEndedSignal.Close();
				eventRunner.waitCommEventWaitHandle.Close();
			}
		}
		finally
		{
			if (disposing)
			{
				lock (this)
				{
					_handle.Close();
					_handle = null;
				}
			}
			else
			{
				_handle.Close();
				_handle = null;
			}
			base.Dispose(disposing);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (numBytes < 0)
		{
			throw new ArgumentOutOfRangeException("numBytes", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (array.Length - offset < numBytes)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		int readTimeout = ReadTimeout;
		ReadTimeout = -1;
		try
		{
			if (!isAsync)
			{
				return base.BeginRead(array, offset, numBytes, userCallback, stateObject);
			}
			return BeginReadCore(array, offset, numBytes, userCallback, stateObject);
		}
		finally
		{
			ReadTimeout = readTimeout;
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		if (inBreak)
		{
			throw new InvalidOperationException(SR.GetString("In_Break_State"));
		}
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (numBytes < 0)
		{
			throw new ArgumentOutOfRangeException("numBytes", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (array.Length - offset < numBytes)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		int writeTimeout = WriteTimeout;
		WriteTimeout = -1;
		try
		{
			if (!isAsync)
			{
				return base.BeginWrite(array, offset, numBytes, userCallback, stateObject);
			}
			return BeginWriteCore(array, offset, numBytes, userCallback, stateObject);
		}
		finally
		{
			WriteTimeout = writeTimeout;
		}
	}

	internal void DiscardInBuffer()
	{
		if (!Microsoft.Win32.UnsafeNativeMethods.PurgeComm(_handle, 10u))
		{
			InternalResources.WinIOError();
		}
	}

	internal void DiscardOutBuffer()
	{
		if (!Microsoft.Win32.UnsafeNativeMethods.PurgeComm(_handle, 5u))
		{
			InternalResources.WinIOError();
		}
	}

	public unsafe override int EndRead(IAsyncResult asyncResult)
	{
		if (!isAsync)
		{
			return base.EndRead(asyncResult);
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		SerialStreamAsyncResult serialStreamAsyncResult = asyncResult as SerialStreamAsyncResult;
		if (serialStreamAsyncResult == null || serialStreamAsyncResult._isWrite)
		{
			InternalResources.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref serialStreamAsyncResult._EndXxxCalled, 1, 0))
		{
			InternalResources.EndReadCalledTwice();
		}
		bool flag = false;
		WaitHandle waitHandle = serialStreamAsyncResult._waitHandle;
		if (waitHandle != null)
		{
			try
			{
				waitHandle.WaitOne();
				if (serialStreamAsyncResult._numBytes == 0 && ReadTimeout == -1 && serialStreamAsyncResult._errorCode == 0)
				{
					flag = true;
				}
			}
			finally
			{
				waitHandle.Close();
			}
		}
		NativeOverlapped* overlapped = serialStreamAsyncResult._overlapped;
		if (overlapped != null)
		{
			Overlapped.Free(overlapped);
		}
		if (serialStreamAsyncResult._errorCode != 0)
		{
			InternalResources.WinIOError(serialStreamAsyncResult._errorCode, portName);
		}
		if (flag)
		{
			throw new IOException(SR.GetString("IO_OperationAborted"));
		}
		return serialStreamAsyncResult._numBytes;
	}

	public unsafe override void EndWrite(IAsyncResult asyncResult)
	{
		if (!isAsync)
		{
			base.EndWrite(asyncResult);
			return;
		}
		if (inBreak)
		{
			throw new InvalidOperationException(SR.GetString("In_Break_State"));
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		SerialStreamAsyncResult serialStreamAsyncResult = asyncResult as SerialStreamAsyncResult;
		if (serialStreamAsyncResult == null || !serialStreamAsyncResult._isWrite)
		{
			InternalResources.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref serialStreamAsyncResult._EndXxxCalled, 1, 0))
		{
			InternalResources.EndWriteCalledTwice();
		}
		WaitHandle waitHandle = serialStreamAsyncResult._waitHandle;
		if (waitHandle != null)
		{
			try
			{
				waitHandle.WaitOne();
			}
			finally
			{
				waitHandle.Close();
			}
		}
		NativeOverlapped* overlapped = serialStreamAsyncResult._overlapped;
		if (overlapped != null)
		{
			Overlapped.Free(overlapped);
		}
		if (serialStreamAsyncResult._errorCode != 0)
		{
			InternalResources.WinIOError(serialStreamAsyncResult._errorCode, portName);
		}
	}

	public override void Flush()
	{
		if (_handle == null)
		{
			throw new ObjectDisposedException(SR.GetString("Port_not_open"));
		}
		Microsoft.Win32.UnsafeNativeMethods.FlushFileBuffers(_handle);
	}

	public override int Read([In][Out] byte[] array, int offset, int count)
	{
		return Read(array, offset, count, ReadTimeout);
	}

	internal unsafe int Read([In][Out] byte[] array, int offset, int count, int timeout)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (count == 0)
		{
			return 0;
		}
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		int num = 0;
		if (isAsync)
		{
			IAsyncResult asyncResult = BeginReadCore(array, offset, count, null, null);
			num = EndRead(asyncResult);
		}
		else
		{
			num = ReadFileNative(array, offset, count, null, out var _);
			if (num == -1)
			{
				InternalResources.WinIOError();
			}
		}
		if (num == 0)
		{
			throw new TimeoutException();
		}
		return num;
	}

	public override int ReadByte()
	{
		return ReadByte(ReadTimeout);
	}

	internal unsafe int ReadByte(int timeout)
	{
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		int num = 0;
		if (isAsync)
		{
			IAsyncResult asyncResult = BeginReadCore(tempBuf, 0, 1, null, null);
			num = EndRead(asyncResult);
		}
		else
		{
			num = ReadFileNative(tempBuf, 0, 1, null, out var _);
			if (num == -1)
			{
				InternalResources.WinIOError();
			}
		}
		if (num == 0)
		{
			throw new TimeoutException();
		}
		return tempBuf[0];
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("NotSupported_UnseekableStream"));
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("NotSupported_UnseekableStream"));
	}

	internal void SetBufferSizes(int readBufferSize, int writeBufferSize)
	{
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		if (!Microsoft.Win32.UnsafeNativeMethods.SetupComm(_handle, readBufferSize, writeBufferSize))
		{
			InternalResources.WinIOError();
		}
	}

	public override void Write(byte[] array, int offset, int count)
	{
		Write(array, offset, count, WriteTimeout);
	}

	internal unsafe void Write(byte[] array, int offset, int count, int timeout)
	{
		if (inBreak)
		{
			throw new InvalidOperationException(SR.GetString("In_Break_State"));
		}
		if (array == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Array"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (count == 0)
		{
			return;
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException("count", SR.GetString("ArgumentOutOfRange_OffsetOut"));
		}
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		int num;
		if (isAsync)
		{
			IAsyncResult asyncResult = BeginWriteCore(array, offset, count, null, null);
			EndWrite(asyncResult);
			SerialStreamAsyncResult serialStreamAsyncResult = asyncResult as SerialStreamAsyncResult;
			num = serialStreamAsyncResult._numBytes;
		}
		else
		{
			num = WriteFileNative(array, offset, count, null, out var hr);
			if (num == -1)
			{
				if (hr == 1121)
				{
					throw new TimeoutException(SR.GetString("Write_timed_out"));
				}
				InternalResources.WinIOError();
			}
		}
		if (num != 0)
		{
			return;
		}
		throw new TimeoutException(SR.GetString("Write_timed_out"));
	}

	public override void WriteByte(byte value)
	{
		WriteByte(value, WriteTimeout);
	}

	internal unsafe void WriteByte(byte value, int timeout)
	{
		if (inBreak)
		{
			throw new InvalidOperationException(SR.GetString("In_Break_State"));
		}
		if (_handle == null)
		{
			InternalResources.FileNotOpen();
		}
		tempBuf[0] = value;
		int num;
		if (isAsync)
		{
			IAsyncResult asyncResult = BeginWriteCore(tempBuf, 0, 1, null, null);
			EndWrite(asyncResult);
			SerialStreamAsyncResult serialStreamAsyncResult = asyncResult as SerialStreamAsyncResult;
			num = serialStreamAsyncResult._numBytes;
		}
		else
		{
			num = WriteFileNative(tempBuf, 0, 1, null, out var _);
			if (num == -1)
			{
				if (Marshal.GetLastWin32Error() == 1121)
				{
					throw new TimeoutException(SR.GetString("Write_timed_out"));
				}
				InternalResources.WinIOError();
			}
		}
		if (num == 0)
		{
			throw new TimeoutException(SR.GetString("Write_timed_out"));
		}
	}

	private void InitializeDCB(int baudRate, Parity parity, int dataBits, StopBits stopBits, bool discardNull)
	{
		if (!Microsoft.Win32.UnsafeNativeMethods.GetCommState(_handle, ref dcb))
		{
			InternalResources.WinIOError();
		}
		dcb.DCBlength = (uint)Marshal.SizeOf((object)dcb);
		dcb.BaudRate = (uint)baudRate;
		dcb.ByteSize = (byte)dataBits;
		switch (stopBits)
		{
		case StopBits.One:
			dcb.StopBits = 0;
			break;
		case StopBits.OnePointFive:
			dcb.StopBits = 1;
			break;
		case StopBits.Two:
			dcb.StopBits = 2;
			break;
		}
		dcb.Parity = (byte)parity;
		SetDcbFlag(1, (parity != Parity.None) ? 1 : 0);
		SetDcbFlag(0, 1);
		SetDcbFlag(2, (handshake == Handshake.RequestToSend || handshake == Handshake.RequestToSendXOnXOff) ? 1 : 0);
		SetDcbFlag(3, 0);
		SetDcbFlag(4, 0);
		SetDcbFlag(6, 0);
		SetDcbFlag(9, (handshake == Handshake.XOnXOff || handshake == Handshake.RequestToSendXOnXOff) ? 1 : 0);
		SetDcbFlag(8, (handshake == Handshake.XOnXOff || handshake == Handshake.RequestToSendXOnXOff) ? 1 : 0);
		if (parity != Parity.None)
		{
			SetDcbFlag(10, (parityReplace != 0) ? 1 : 0);
			dcb.ErrorChar = parityReplace;
		}
		else
		{
			SetDcbFlag(10, 0);
			dcb.ErrorChar = 0;
		}
		SetDcbFlag(11, discardNull ? 1 : 0);
		if (handshake == Handshake.RequestToSend || handshake == Handshake.RequestToSendXOnXOff)
		{
			SetDcbFlag(12, 2);
		}
		else if (GetDcbFlag(12) == 2)
		{
			SetDcbFlag(12, 0);
		}
		dcb.XonChar = 17;
		dcb.XoffChar = 19;
		dcb.XonLim = (dcb.XoffLim = (ushort)(commProp.dwCurrentRxQueue / 4));
		dcb.EofChar = 26;
		dcb.EvtChar = 26;
		if (!Microsoft.Win32.UnsafeNativeMethods.SetCommState(_handle, ref dcb))
		{
			InternalResources.WinIOError();
		}
	}

	internal int GetDcbFlag(int whichFlag)
	{
		uint num;
		switch (whichFlag)
		{
		case 4:
		case 12:
			num = 3u;
			break;
		case 15:
			num = 131071u;
			break;
		default:
			num = 1u;
			break;
		}
		uint num2 = dcb.Flags & (num << whichFlag);
		return (int)(num2 >> whichFlag);
	}

	internal void SetDcbFlag(int whichFlag, int setting)
	{
		setting <<= whichFlag;
		uint num;
		switch (whichFlag)
		{
		case 4:
		case 12:
			num = 3u;
			break;
		case 15:
			num = 131071u;
			break;
		default:
			num = 1u;
			break;
		}
		dcb.Flags &= ~(num << whichFlag);
		dcb.Flags |= (uint)setting;
	}

	private unsafe SerialStreamAsyncResult BeginReadCore(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		SerialStreamAsyncResult serialStreamAsyncResult = new SerialStreamAsyncResult();
		serialStreamAsyncResult._userCallback = userCallback;
		serialStreamAsyncResult._userStateObject = stateObject;
		serialStreamAsyncResult._isWrite = false;
		ManualResetEvent waitHandle = new ManualResetEvent(initialState: false);
		serialStreamAsyncResult._waitHandle = waitHandle;
		Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, serialStreamAsyncResult);
		NativeOverlapped* overlapped2 = (serialStreamAsyncResult._overlapped = overlapped.Pack(IOCallback, array));
		int hr = 0;
		int num = ReadFileNative(array, offset, numBytes, overlapped2, out hr);
		if (num == -1)
		{
			switch (hr)
			{
			case 38:
				InternalResources.EndOfFile();
				break;
			default:
				InternalResources.WinIOError(hr, string.Empty);
				break;
			case 997:
				break;
			}
		}
		return serialStreamAsyncResult;
	}

	private unsafe SerialStreamAsyncResult BeginWriteCore(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		SerialStreamAsyncResult serialStreamAsyncResult = new SerialStreamAsyncResult();
		serialStreamAsyncResult._userCallback = userCallback;
		serialStreamAsyncResult._userStateObject = stateObject;
		serialStreamAsyncResult._isWrite = true;
		ManualResetEvent waitHandle = new ManualResetEvent(initialState: false);
		serialStreamAsyncResult._waitHandle = waitHandle;
		Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, serialStreamAsyncResult);
		NativeOverlapped* overlapped2 = (serialStreamAsyncResult._overlapped = overlapped.Pack(IOCallback, array));
		int hr = 0;
		int num = WriteFileNative(array, offset, numBytes, overlapped2, out hr);
		if (num == -1)
		{
			switch (hr)
			{
			case 38:
				InternalResources.EndOfFile();
				break;
			default:
				InternalResources.WinIOError(hr, string.Empty);
				break;
			case 997:
				break;
			}
		}
		return serialStreamAsyncResult;
	}

	private unsafe int ReadFileNative(byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (bytes.Length - offset < count)
		{
			throw new IndexOutOfRangeException(SR.GetString("IndexOutOfRange_IORaceCondition"));
		}
		if (bytes.Length == 0)
		{
			hr = 0;
			return 0;
		}
		int num = 0;
		int numBytesRead = 0;
		fixed (byte* ptr = bytes)
		{
			num = ((!isAsync) ? Microsoft.Win32.UnsafeNativeMethods.ReadFile(_handle, ptr + offset, count, out numBytesRead, IntPtr.Zero) : Microsoft.Win32.UnsafeNativeMethods.ReadFile(_handle, ptr + offset, count, IntPtr.Zero, overlapped));
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			if (hr == 6)
			{
				_handle.SetHandleAsInvalid();
			}
			return -1;
		}
		hr = 0;
		return numBytesRead;
	}

	private unsafe int WriteFileNative(byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (bytes.Length - offset < count)
		{
			throw new IndexOutOfRangeException(SR.GetString("IndexOutOfRange_IORaceCondition"));
		}
		if (bytes.Length == 0)
		{
			hr = 0;
			return 0;
		}
		int numBytesWritten = 0;
		int num = 0;
		fixed (byte* ptr = bytes)
		{
			num = ((!isAsync) ? Microsoft.Win32.UnsafeNativeMethods.WriteFile(_handle, ptr + offset, count, out numBytesWritten, IntPtr.Zero) : Microsoft.Win32.UnsafeNativeMethods.WriteFile(_handle, ptr + offset, count, IntPtr.Zero, overlapped));
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			if (hr == 6)
			{
				_handle.SetHandleAsInvalid();
			}
			return -1;
		}
		hr = 0;
		return numBytesWritten;
	}

	private unsafe static void AsyncFSCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(pOverlapped);
		SerialStreamAsyncResult serialStreamAsyncResult = (SerialStreamAsyncResult)overlapped.AsyncResult;
		serialStreamAsyncResult._numBytes = (int)numBytes;
		serialStreamAsyncResult._errorCode = (int)errorCode;
		serialStreamAsyncResult._completedSynchronously = false;
		serialStreamAsyncResult._isComplete = true;
		ManualResetEvent waitHandle = serialStreamAsyncResult._waitHandle;
		if (waitHandle != null && !waitHandle.Set())
		{
			InternalResources.WinIOError();
		}
		serialStreamAsyncResult._userCallback?.Invoke(serialStreamAsyncResult);
	}
}
