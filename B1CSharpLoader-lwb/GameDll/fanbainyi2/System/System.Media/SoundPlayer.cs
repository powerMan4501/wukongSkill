using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Media;

[Serializable]
[ToolboxItem(false)]
[HostProtection(SecurityAction.LinkDemand, UI = true)]
public class SoundPlayer : Component, ISerializable
{
	private class IntSecurity
	{
		private static volatile CodeAccessPermission safeSubWindows;

		internal static CodeAccessPermission SafeSubWindows
		{
			get
			{
				if (safeSubWindows == null)
				{
					safeSubWindows = new UIPermission(UIPermissionWindow.SafeSubWindows);
				}
				return safeSubWindows;
			}
		}

		private IntSecurity()
		{
		}
	}

	private class NativeMethods
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal class MMCKINFO
		{
			internal int ckID;

			internal int cksize;

			internal int fccType;

			internal int dwDataOffset;

			internal int dwFlags;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal class WAVEFORMATEX
		{
			internal short wFormatTag;

			internal short nChannels;

			internal int nSamplesPerSec;

			internal int nAvgBytesPerSec;

			internal short nBlockAlign;

			internal short wBitsPerSample;

			internal short cbSize;
		}

		internal const int WAVE_FORMAT_PCM = 1;

		internal const int WAVE_FORMAT_ADPCM = 2;

		internal const int WAVE_FORMAT_IEEE_FLOAT = 3;

		internal const int MMIO_READ = 0;

		internal const int MMIO_ALLOCBUF = 65536;

		internal const int MMIO_FINDRIFF = 32;

		internal const int SND_SYNC = 0;

		internal const int SND_ASYNC = 1;

		internal const int SND_NODEFAULT = 2;

		internal const int SND_MEMORY = 4;

		internal const int SND_LOOP = 8;

		internal const int SND_PURGE = 64;

		internal const int SND_FILENAME = 131072;

		internal const int SND_NOSTOP = 16;

		private NativeMethods()
		{
		}
	}

	private class UnsafeNativeMethods
	{
		private UnsafeNativeMethods()
		{
		}

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern bool PlaySound([MarshalAs(UnmanagedType.LPWStr)] string soundName, IntPtr hmod, int soundFlags);

		[DllImport("winmm.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		internal static extern bool PlaySound(byte[] soundName, IntPtr hmod, int soundFlags);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr mmioOpen(string fileName, IntPtr not_used, int flags);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioAscend(IntPtr hMIO, NativeMethods.MMCKINFO lpck, int flags);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioDescend(IntPtr hMIO, [MarshalAs(UnmanagedType.LPStruct)] NativeMethods.MMCKINFO lpck, [MarshalAs(UnmanagedType.LPStruct)] NativeMethods.MMCKINFO lcpkParent, int flags);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioRead(IntPtr hMIO, [MarshalAs(UnmanagedType.LPArray)] byte[] wf, int cch);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioClose(IntPtr hMIO, int flags);
	}

	private const int blockSize = 1024;

	private const int defaultLoadTimeout = 10000;

	private Uri uri;

	private string soundLocation = string.Empty;

	private int loadTimeout = 10000;

	private object tag;

	private ManualResetEvent semaphore = new ManualResetEvent(initialState: true);

	private Thread copyThread;

	private int currentPos;

	private Stream stream;

	private bool isLoadCompleted;

	private Exception lastLoadException;

	private bool doesLoadAppearSynchronous;

	private byte[] streamData;

	private AsyncOperation asyncOperation;

	private readonly SendOrPostCallback loadAsyncOperationCompleted;

	private static readonly object EventLoadCompleted = new object();

	private static readonly object EventSoundLocationChanged = new object();

	private static readonly object EventStreamChanged = new object();

	public int LoadTimeout
	{
		get
		{
			return loadTimeout;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("LoadTimeout", value, SR.GetString("SoundAPILoadTimeout"));
			}
			loadTimeout = value;
		}
	}

	public string SoundLocation
	{
		get
		{
			if (uri != null && uri.IsFile)
			{
				FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
				fileIOPermission.AllFiles = FileIOPermissionAccess.PathDiscovery;
				fileIOPermission.Demand();
			}
			return soundLocation;
		}
		set
		{
			if (value == null)
			{
				value = string.Empty;
			}
			if (!soundLocation.Equals(value))
			{
				SetupSoundLocation(value);
				OnSoundLocationChanged(EventArgs.Empty);
			}
		}
	}

	public Stream Stream
	{
		get
		{
			if (uri != null)
			{
				return null;
			}
			return stream;
		}
		set
		{
			if (stream != value)
			{
				SetupStream(value);
				OnStreamChanged(EventArgs.Empty);
			}
		}
	}

	public bool IsLoadCompleted => isLoadCompleted;

	public object Tag
	{
		get
		{
			return tag;
		}
		set
		{
			tag = value;
		}
	}

	public event AsyncCompletedEventHandler LoadCompleted
	{
		add
		{
			base.Events.AddHandler(EventLoadCompleted, value);
		}
		remove
		{
			base.Events.RemoveHandler(EventLoadCompleted, value);
		}
	}

	public event EventHandler SoundLocationChanged
	{
		add
		{
			base.Events.AddHandler(EventSoundLocationChanged, value);
		}
		remove
		{
			base.Events.RemoveHandler(EventSoundLocationChanged, value);
		}
	}

	public event EventHandler StreamChanged
	{
		add
		{
			base.Events.AddHandler(EventStreamChanged, value);
		}
		remove
		{
			base.Events.RemoveHandler(EventStreamChanged, value);
		}
	}

	public SoundPlayer()
	{
		loadAsyncOperationCompleted = LoadAsyncOperationCompleted;
	}

	public SoundPlayer(string soundLocation)
		: this()
	{
		if (soundLocation == null)
		{
			soundLocation = string.Empty;
		}
		SetupSoundLocation(soundLocation);
	}

	public SoundPlayer(Stream stream)
		: this()
	{
		this.stream = stream;
	}

	protected SoundPlayer(SerializationInfo serializationInfo, StreamingContext context)
	{
		SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SerializationEntry current = enumerator.Current;
			switch (current.Name)
			{
			case "SoundLocation":
				SetupSoundLocation((string)current.Value);
				break;
			case "Stream":
				stream = (Stream)current.Value;
				if (stream.CanSeek)
				{
					stream.Seek(0L, SeekOrigin.Begin);
				}
				break;
			case "LoadTimeout":
				LoadTimeout = (int)current.Value;
				break;
			}
		}
	}

	public void LoadAsync()
	{
		if (uri != null && uri.IsFile)
		{
			isLoadCompleted = true;
			FileInfo fileInfo = new FileInfo(uri.LocalPath);
			if (!fileInfo.Exists)
			{
				throw new FileNotFoundException(SR.GetString("SoundAPIFileDoesNotExist"), soundLocation);
			}
			OnLoadCompleted(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else if (copyThread == null || copyThread.ThreadState != ThreadState.Running)
		{
			isLoadCompleted = false;
			streamData = null;
			currentPos = 0;
			asyncOperation = AsyncOperationManager.CreateOperation(null);
			LoadStream(loadSync: false);
		}
	}

	private void LoadAsyncOperationCompleted(object arg)
	{
		OnLoadCompleted((AsyncCompletedEventArgs)arg);
	}

	private void CleanupStreamData()
	{
		currentPos = 0;
		streamData = null;
		isLoadCompleted = false;
		lastLoadException = null;
		doesLoadAppearSynchronous = false;
		copyThread = null;
		semaphore.Set();
	}

	public void Load()
	{
		if (uri != null && uri.IsFile)
		{
			FileInfo fileInfo = new FileInfo(uri.LocalPath);
			if (!fileInfo.Exists)
			{
				throw new FileNotFoundException(SR.GetString("SoundAPIFileDoesNotExist"), soundLocation);
			}
			isLoadCompleted = true;
			OnLoadCompleted(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else
		{
			LoadSync();
		}
	}

	private void LoadAndPlay(int flags)
	{
		if (string.IsNullOrEmpty(soundLocation) && stream == null)
		{
			SystemSounds.Beep.Play();
			return;
		}
		if (uri != null && uri.IsFile)
		{
			string localPath = uri.LocalPath;
			FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read, localPath);
			fileIOPermission.Demand();
			isLoadCompleted = true;
			IntSecurity.SafeSubWindows.Demand();
			System.ComponentModel.IntSecurity.UnmanagedCode.Assert();
			try
			{
				ValidateSoundFile(localPath);
				UnsafeNativeMethods.PlaySound(localPath, IntPtr.Zero, 2 | flags);
				return;
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		LoadSync();
		ValidateSoundData(streamData);
		IntSecurity.SafeSubWindows.Demand();
		System.ComponentModel.IntSecurity.UnmanagedCode.Assert();
		try
		{
			UnsafeNativeMethods.PlaySound(streamData, IntPtr.Zero, 6 | flags);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	private void LoadSync()
	{
		if (!semaphore.WaitOne(LoadTimeout, exitContext: false))
		{
			if (copyThread != null)
			{
				copyThread.Abort();
			}
			CleanupStreamData();
			throw new TimeoutException(SR.GetString("SoundAPILoadTimedOut"));
		}
		if (streamData != null)
		{
			return;
		}
		if (uri != null && !uri.IsFile && stream == null)
		{
			WebPermission webPermission = new WebPermission(NetworkAccess.Connect, uri.AbsolutePath);
			webPermission.Demand();
			WebRequest webRequest = WebRequest.Create(uri);
			webRequest.Timeout = LoadTimeout;
			WebResponse response = webRequest.GetResponse();
			stream = response.GetResponseStream();
		}
		if (stream.CanSeek)
		{
			LoadStream(loadSync: true);
		}
		else
		{
			doesLoadAppearSynchronous = true;
			LoadStream(loadSync: false);
			if (!semaphore.WaitOne(LoadTimeout, exitContext: false))
			{
				if (copyThread != null)
				{
					copyThread.Abort();
				}
				CleanupStreamData();
				throw new TimeoutException(SR.GetString("SoundAPILoadTimedOut"));
			}
			doesLoadAppearSynchronous = false;
			if (lastLoadException != null)
			{
				throw lastLoadException;
			}
		}
		copyThread = null;
	}

	private void LoadStream(bool loadSync)
	{
		if (loadSync && stream.CanSeek)
		{
			int num = (int)stream.Length;
			currentPos = 0;
			streamData = new byte[num];
			stream.Read(streamData, 0, num);
			isLoadCompleted = true;
			OnLoadCompleted(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else
		{
			semaphore.Reset();
			copyThread = new Thread(WorkerThread);
			copyThread.Start();
		}
	}

	public void Play()
	{
		LoadAndPlay(1);
	}

	public void PlaySync()
	{
		LoadAndPlay(0);
	}

	public void PlayLooping()
	{
		LoadAndPlay(9);
	}

	private static Uri ResolveUri(string partialUri)
	{
		Uri uri = null;
		try
		{
			uri = new Uri(partialUri);
		}
		catch (UriFormatException)
		{
		}
		if (uri == null)
		{
			try
			{
				uri = new Uri(Path.GetFullPath(partialUri));
			}
			catch (UriFormatException)
			{
			}
		}
		return uri;
	}

	private void SetupSoundLocation(string soundLocation)
	{
		if (copyThread != null)
		{
			copyThread.Abort();
			CleanupStreamData();
		}
		uri = ResolveUri(soundLocation);
		this.soundLocation = soundLocation;
		stream = null;
		if (uri == null)
		{
			if (!string.IsNullOrEmpty(soundLocation))
			{
				throw new UriFormatException(SR.GetString("SoundAPIBadSoundLocation"));
			}
		}
		else if (!uri.IsFile)
		{
			streamData = null;
			currentPos = 0;
			isLoadCompleted = false;
		}
	}

	private void SetupStream(Stream stream)
	{
		if (copyThread != null)
		{
			copyThread.Abort();
			CleanupStreamData();
		}
		this.stream = stream;
		soundLocation = string.Empty;
		streamData = null;
		currentPos = 0;
		isLoadCompleted = false;
		if (stream != null)
		{
			uri = null;
		}
	}

	public void Stop()
	{
		IntSecurity.SafeSubWindows.Demand();
		UnsafeNativeMethods.PlaySound((byte[])null, IntPtr.Zero, 64);
	}

	protected virtual void OnLoadCompleted(AsyncCompletedEventArgs e)
	{
		((AsyncCompletedEventHandler)base.Events[EventLoadCompleted])?.Invoke(this, e);
	}

	protected virtual void OnSoundLocationChanged(EventArgs e)
	{
		((EventHandler)base.Events[EventSoundLocationChanged])?.Invoke(this, e);
	}

	protected virtual void OnStreamChanged(EventArgs e)
	{
		((EventHandler)base.Events[EventStreamChanged])?.Invoke(this, e);
	}

	private void WorkerThread()
	{
		try
		{
			if (uri != null && !uri.IsFile && stream == null)
			{
				WebRequest webRequest = WebRequest.Create(uri);
				WebResponse response = webRequest.GetResponse();
				stream = response.GetResponseStream();
			}
			streamData = new byte[1024];
			int num = stream.Read(streamData, currentPos, 1024);
			int num2 = num;
			while (num > 0)
			{
				currentPos += num;
				if (streamData.Length < currentPos + 1024)
				{
					byte[] destinationArray = new byte[streamData.Length * 2];
					Array.Copy(streamData, destinationArray, streamData.Length);
					streamData = destinationArray;
				}
				num = stream.Read(streamData, currentPos, 1024);
				num2 += num;
			}
			lastLoadException = null;
		}
		catch (Exception ex)
		{
			lastLoadException = ex;
		}
		if (!doesLoadAppearSynchronous)
		{
			asyncOperation.PostOperationCompleted(loadAsyncOperationCompleted, new AsyncCompletedEventArgs(lastLoadException, cancelled: false, null));
		}
		isLoadCompleted = true;
		semaphore.Set();
	}

	private unsafe void ValidateSoundFile(string fileName)
	{
		NativeMethods.MMCKINFO mMCKINFO = new NativeMethods.MMCKINFO();
		NativeMethods.MMCKINFO mMCKINFO2 = new NativeMethods.MMCKINFO();
		NativeMethods.WAVEFORMATEX wAVEFORMATEX = null;
		IntPtr intPtr = UnsafeNativeMethods.mmioOpen(fileName, IntPtr.Zero, 65536);
		if (intPtr == IntPtr.Zero)
		{
			throw new FileNotFoundException(SR.GetString("SoundAPIFileDoesNotExist"), soundLocation);
		}
		try
		{
			mMCKINFO.fccType = mmioFOURCC('W', 'A', 'V', 'E');
			if (UnsafeNativeMethods.mmioDescend(intPtr, mMCKINFO, null, 32) != 0)
			{
				throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveFile", soundLocation));
			}
			while (UnsafeNativeMethods.mmioDescend(intPtr, mMCKINFO2, mMCKINFO, 0) == 0)
			{
				if (mMCKINFO2.dwDataOffset + mMCKINFO2.cksize > mMCKINFO.dwDataOffset + mMCKINFO.cksize)
				{
					throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
				}
				if (mMCKINFO2.ckID == mmioFOURCC('f', 'm', 't', ' ') && wAVEFORMATEX == null)
				{
					int num = mMCKINFO2.cksize;
					if (num < Marshal.SizeOf(typeof(NativeMethods.WAVEFORMATEX)))
					{
						num = Marshal.SizeOf(typeof(NativeMethods.WAVEFORMATEX));
					}
					wAVEFORMATEX = new NativeMethods.WAVEFORMATEX();
					byte[] array = new byte[num];
					if (UnsafeNativeMethods.mmioRead(intPtr, array, num) != num)
					{
						throw new InvalidOperationException(SR.GetString("SoundAPIReadError", soundLocation));
					}
					fixed (byte* ptr = array)
					{
						Marshal.PtrToStructure((IntPtr)ptr, (object)wAVEFORMATEX);
					}
				}
				UnsafeNativeMethods.mmioAscend(intPtr, mMCKINFO2, 0);
			}
			if (wAVEFORMATEX == null)
			{
				throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
			}
			if (wAVEFORMATEX.wFormatTag != 1 && wAVEFORMATEX.wFormatTag != 2 && wAVEFORMATEX.wFormatTag != 3)
			{
				throw new InvalidOperationException(SR.GetString("SoundAPIFormatNotSupported"));
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				UnsafeNativeMethods.mmioClose(intPtr, 0);
			}
		}
	}

	private static void ValidateSoundData(byte[] data)
	{
		int num = 0;
		short num2 = -1;
		bool flag = false;
		if (data.Length < 12)
		{
			throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
		}
		if (data[0] != 82 || data[1] != 73 || data[2] != 70 || data[3] != 70)
		{
			throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
		}
		if (data[8] != 87 || data[9] != 65 || data[10] != 86 || data[11] != 69)
		{
			throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
		}
		num = 12;
		int num3 = data.Length;
		while (!flag && num < num3 - 8)
		{
			if (data[num] == 102 && data[num + 1] == 109 && data[num + 2] == 116 && data[num + 3] == 32)
			{
				flag = true;
				int num4 = BytesToInt(data[num + 7], data[num + 6], data[num + 5], data[num + 4]);
				int num5 = 16;
				if (num4 != num5)
				{
					int num6 = 18;
					if (num3 < num + 8 + num6 - 1)
					{
						throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
					}
					short num7 = BytesToInt16(data[num + 8 + num6 - 1], data[num + 8 + num6 - 2]);
					if (num7 + num6 != num4)
					{
						throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
					}
				}
				if (num3 < num + 9)
				{
					throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
				}
				num2 = BytesToInt16(data[num + 9], data[num + 8]);
				num += num4 + 8;
			}
			else
			{
				num += 8 + BytesToInt(data[num + 7], data[num + 6], data[num + 5], data[num + 4]);
			}
		}
		if (!flag)
		{
			throw new InvalidOperationException(SR.GetString("SoundAPIInvalidWaveHeader"));
		}
		if (num2 != 1 && num2 != 2 && num2 != 3)
		{
			throw new InvalidOperationException(SR.GetString("SoundAPIFormatNotSupported"));
		}
	}

	private static short BytesToInt16(byte ch0, byte ch1)
	{
		int num = ch1;
		num |= ch0 << 8;
		return (short)num;
	}

	private static int BytesToInt(byte ch0, byte ch1, byte ch2, byte ch3)
	{
		return mmioFOURCC((char)ch3, (char)ch2, (char)ch1, (char)ch0);
	}

	private static int mmioFOURCC(char ch0, char ch1, char ch2, char ch3)
	{
		int num = 0;
		num |= ch0;
		num |= (int)((uint)ch1 << 8);
		num |= (int)((uint)ch2 << 16);
		return num | (int)((uint)ch3 << 24);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (!string.IsNullOrEmpty(soundLocation))
		{
			info.AddValue("SoundLocation", soundLocation);
		}
		if (stream != null)
		{
			info.AddValue("Stream", stream);
		}
		info.AddValue("LoadTimeout", loadTimeout);
	}
}
