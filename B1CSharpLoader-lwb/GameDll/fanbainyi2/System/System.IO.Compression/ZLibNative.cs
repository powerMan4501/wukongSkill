using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Compression;

internal static class ZLibNative
{
	public enum FlushCode
	{
		NoFlush,
		PartialFlush,
		SyncFlush,
		FullFlush,
		Finish,
		Block
	}

	public enum ErrorCode
	{
		Ok = 0,
		StreamEnd = 1,
		NeedDictionary = 2,
		ErrorNo = -1,
		StreamError = -2,
		DataError = -3,
		MemError = -4,
		BufError = -5,
		VersionError = -6
	}

	public enum CompressionLevel
	{
		NoCompression = 0,
		BestSpeed = 1,
		BestCompression = 9,
		DefaultCompression = -1
	}

	public enum CompressionStrategy
	{
		Filtered = 1,
		HuffmanOnly = 2,
		Rle = 3,
		Fixed = 4,
		DefaultStrategy = 0
	}

	public enum CompressionMethod
	{
		Deflated = 8
	}

	internal struct ZStream
	{
		internal IntPtr nextIn;

		internal uint availIn;

		internal uint totalIn;

		internal IntPtr nextOut;

		internal uint availOut;

		internal uint totalOut;

		internal IntPtr msg;

		internal IntPtr state;

		internal IntPtr zalloc;

		internal IntPtr zfree;

		internal IntPtr opaque;

		internal int dataType;

		internal uint adler;

		internal uint reserved;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private unsafe delegate ErrorCode DeflateInit2_Delegate(ZStream* stream, CompressionLevel level, CompressionMethod method, int windowBits, int memLevel, CompressionStrategy strategy, [MarshalAs(UnmanagedType.LPStr)] string version, int streamSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private unsafe delegate ErrorCode DeflateDelegate(ZStream* stream, FlushCode flush);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private unsafe delegate ErrorCode DeflateEndDelegate(ZStream* stream);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private unsafe delegate ErrorCode InflateInit2_Delegate(ZStream* stream, int windowBits, [MarshalAs(UnmanagedType.LPStr)] string version, int streamSize);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private unsafe delegate ErrorCode InflateDelegate(ZStream* stream, FlushCode flush);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private unsafe delegate ErrorCode InflateEndDelegate(ZStream* stream);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private delegate int ZlibCompileFlagsDelegate();

	private class NativeMethods
	{
		[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Ansi)]
		[SuppressUnmanagedCodeSecurity]
		[SecurityCritical]
		internal static extern IntPtr GetProcAddress(SafeLibraryHandle moduleHandle, string procName);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[SuppressUnmanagedCodeSecurity]
		[SecurityCritical]
		internal static extern SafeLibraryHandle LoadLibrary(string libPath);

		[DllImport("kernel32.dll", ExactSpelling = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[SecurityCritical]
		internal static extern bool FreeLibrary(IntPtr moduleHandle);
	}

	[SecurityCritical]
	private class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		[SecurityCritical]
		internal SafeLibraryHandle()
			: base(ownsHandle: true)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityCritical]
		protected override bool ReleaseHandle()
		{
			bool result = NativeMethods.FreeLibrary(handle);
			handle = IntPtr.Zero;
			return result;
		}
	}

	[SecurityCritical]
	public sealed class ZLibStreamHandle : SafeHandleMinusOneIsInvalid
	{
		[SecurityCritical]
		private static class NativeZLibDLLStub
		{
			[SecurityCritical]
			internal static DeflateInit2_Delegate deflateInit2_Delegate;

			[SecurityCritical]
			internal static DeflateDelegate deflateDelegate;

			[SecurityCritical]
			internal static DeflateEndDelegate deflateEndDelegate;

			[SecurityCritical]
			internal static InflateInit2_Delegate inflateInit2_Delegate;

			[SecurityCritical]
			internal static InflateDelegate inflateDelegate;

			[SecurityCritical]
			internal static InflateEndDelegate inflateEndDelegate;

			[SecurityCritical]
			internal static ZlibCompileFlagsDelegate zlibCompileFlagsDelegate;

			[SecuritySafeCritical]
			private static void LoadZLibDLL()
			{
				new FileIOPermission(PermissionState.Unrestricted).Assert();
				string runtimeDirectory = RuntimeEnvironment.GetRuntimeDirectory();
				string text = Path.Combine(runtimeDirectory, "clrcompression.dll");
				if (!File.Exists(text))
				{
					throw new DllNotFoundException("clrcompression.dll");
				}
				SafeLibraryHandle safeLibraryHandle = NativeMethods.LoadLibrary(text);
				if (safeLibraryHandle.IsInvalid)
				{
					int hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
					Marshal.ThrowExceptionForHR(hRForLastWin32Error, new IntPtr(-1));
					throw new InvalidOperationException();
				}
				zlibLibraryHandle = safeLibraryHandle;
			}

			[SecurityCritical]
			private static DT CreateDelegate<DT>(string entryPointName)
			{
				IntPtr procAddress = NativeMethods.GetProcAddress(zlibLibraryHandle, entryPointName);
				if (IntPtr.Zero == procAddress)
				{
					throw new EntryPointNotFoundException("clrcompression.dll!" + entryPointName);
				}
				return (DT)(object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DT));
			}

			[SecuritySafeCritical]
			private static void InitDelegates()
			{
				deflateInit2_Delegate = CreateDelegate<DeflateInit2_Delegate>("deflateInit2_");
				deflateDelegate = CreateDelegate<DeflateDelegate>("deflate");
				deflateEndDelegate = CreateDelegate<DeflateEndDelegate>("deflateEnd");
				inflateInit2_Delegate = CreateDelegate<InflateInit2_Delegate>("inflateInit2_");
				inflateDelegate = CreateDelegate<InflateDelegate>("inflate");
				inflateEndDelegate = CreateDelegate<InflateEndDelegate>("inflateEnd");
				zlibCompileFlagsDelegate = CreateDelegate<ZlibCompileFlagsDelegate>("zlibCompileFlags");
				RuntimeHelpers.PrepareDelegate(deflateInit2_Delegate);
				RuntimeHelpers.PrepareDelegate(deflateDelegate);
				RuntimeHelpers.PrepareDelegate(deflateEndDelegate);
				RuntimeHelpers.PrepareDelegate(inflateInit2_Delegate);
				RuntimeHelpers.PrepareDelegate(inflateDelegate);
				RuntimeHelpers.PrepareDelegate(inflateEndDelegate);
				RuntimeHelpers.PrepareDelegate(zlibCompileFlagsDelegate);
			}

			[SecuritySafeCritical]
			static NativeZLibDLLStub()
			{
				LoadZLibDLL();
				InitDelegates();
			}
		}

		public enum State
		{
			NotInitialized,
			InitializedForDeflate,
			InitializedForInflate,
			Disposed
		}

		[SecurityCritical]
		private static SafeLibraryHandle zlibLibraryHandle;

		[SecurityCritical]
		private unsafe ZStream* zStreamPtr;

		[SecurityCritical]
		private volatile State initializationState;

		public State InitializationState
		{
			[SecurityCritical]
			get
			{
				return initializationState;
			}
		}

		public unsafe IntPtr NextIn
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->nextIn;
			}
			[SecurityCritical]
			set
			{
				if (zStreamPtr != null)
				{
					zStreamPtr->nextIn = value;
				}
			}
		}

		public unsafe uint AvailIn
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->availIn;
			}
			[SecurityCritical]
			set
			{
				if (zStreamPtr != null)
				{
					zStreamPtr->availIn = value;
				}
			}
		}

		public unsafe uint TotalIn
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->totalIn;
			}
		}

		public unsafe IntPtr NextOut
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->nextOut;
			}
			[SecurityCritical]
			set
			{
				if (zStreamPtr != null)
				{
					zStreamPtr->nextOut = value;
				}
			}
		}

		public unsafe uint AvailOut
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->availOut;
			}
			[SecurityCritical]
			set
			{
				if (zStreamPtr != null)
				{
					zStreamPtr->availOut = value;
				}
			}
		}

		public unsafe uint TotalOut
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->totalOut;
			}
		}

		public unsafe int DataType
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->dataType;
			}
		}

		public unsafe uint Adler
		{
			[SecurityCritical]
			get
			{
				return zStreamPtr->adler;
			}
		}

		public unsafe ZLibStreamHandle()
			: base(ownsHandle: true)
		{
			zStreamPtr = (ZStream*)(void*)AllocWithZeroOut(sizeof(ZStream));
			initializationState = State.NotInitialized;
			handle = IntPtr.Zero;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityCritical]
		protected unsafe override bool ReleaseHandle()
		{
			try
			{
				if (zlibLibraryHandle == null || zlibLibraryHandle.IsInvalid)
				{
					return false;
				}
				return InitializationState switch
				{
					State.NotInitialized => true, 
					State.InitializedForDeflate => DeflateEnd() == ErrorCode.Ok, 
					State.InitializedForInflate => InflateEnd() == ErrorCode.Ok, 
					State.Disposed => true, 
					_ => false, 
				};
			}
			finally
			{
				if (zStreamPtr != null)
				{
					Marshal.FreeHGlobal((IntPtr)zStreamPtr);
					zStreamPtr = null;
				}
			}
		}

		[SecurityCritical]
		private void EnsureNotDisposed()
		{
			if (InitializationState == State.Disposed)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
		}

		[SecurityCritical]
		private void EnsureState(State requiredState)
		{
			if (InitializationState != requiredState)
			{
				throw new InvalidOperationException("InitializationState != " + requiredState);
			}
		}

		[SecurityCritical]
		public unsafe ErrorCode DeflateInit2_(CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
		{
			EnsureNotDisposed();
			EnsureState(State.NotInitialized);
			bool success = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			ErrorCode result;
			try
			{
			}
			finally
			{
				result = NativeZLibDLLStub.deflateInit2_Delegate(zStreamPtr, level, CompressionMethod.Deflated, windowBits, memLevel, strategy, "1.3.1", sizeof(ZStream));
				initializationState = State.InitializedForDeflate;
				zlibLibraryHandle.DangerousAddRef(ref success);
			}
			return result;
		}

		[SecurityCritical]
		public unsafe ErrorCode Deflate(FlushCode flush)
		{
			EnsureNotDisposed();
			EnsureState(State.InitializedForDeflate);
			return NativeZLibDLLStub.deflateDelegate(zStreamPtr, flush);
		}

		[SecurityCritical]
		public unsafe ErrorCode DeflateEnd()
		{
			EnsureNotDisposed();
			EnsureState(State.InitializedForDeflate);
			RuntimeHelpers.PrepareConstrainedRegions();
			ErrorCode result;
			try
			{
			}
			finally
			{
				result = NativeZLibDLLStub.deflateEndDelegate(zStreamPtr);
				initializationState = State.Disposed;
				zlibLibraryHandle.DangerousRelease();
			}
			return result;
		}

		[SecurityCritical]
		public unsafe ErrorCode InflateInit2_(int windowBits)
		{
			EnsureNotDisposed();
			EnsureState(State.NotInitialized);
			bool success = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			ErrorCode result;
			try
			{
			}
			finally
			{
				result = NativeZLibDLLStub.inflateInit2_Delegate(zStreamPtr, windowBits, "1.3.1", sizeof(ZStream));
				initializationState = State.InitializedForInflate;
				zlibLibraryHandle.DangerousAddRef(ref success);
			}
			return result;
		}

		[SecurityCritical]
		public unsafe ErrorCode Inflate(FlushCode flush)
		{
			EnsureNotDisposed();
			EnsureState(State.InitializedForInflate);
			return NativeZLibDLLStub.inflateDelegate(zStreamPtr, flush);
		}

		[SecurityCritical]
		public unsafe ErrorCode InflateEnd()
		{
			EnsureNotDisposed();
			EnsureState(State.InitializedForInflate);
			RuntimeHelpers.PrepareConstrainedRegions();
			ErrorCode result;
			try
			{
			}
			finally
			{
				result = NativeZLibDLLStub.inflateEndDelegate(zStreamPtr);
				initializationState = State.Disposed;
				zlibLibraryHandle.DangerousRelease();
			}
			return result;
		}

		[SecurityCritical]
		public unsafe string GetErrorMessage()
		{
			if (ZNullPtr.Equals(zStreamPtr->msg))
			{
				return string.Empty;
			}
			return new string((sbyte*)(void*)zStreamPtr->msg);
		}

		[SecurityCritical]
		internal static int ZLibCompileFlags()
		{
			return NativeZLibDLLStub.zlibCompileFlagsDelegate();
		}

		[SecurityCritical]
		private unsafe static IntPtr AllocWithZeroOut(int byteCount)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount);
			byte* ptr = (byte*)(void*)intPtr;
			int num = byteCount;
			int num2 = num / 4;
			int* ptr2 = (int*)ptr;
			for (int i = 0; i < num2; i++)
			{
				ptr2[i] = 0;
			}
			num2 *= 4;
			ptr += num2;
			num -= num2;
			for (int j = 0; j < num; j++)
			{
				ptr[j] = 0;
			}
			return intPtr;
		}
	}

	public const string ZLibNativeDllName = "clrcompression.dll";

	private const string Kernel32DllName = "kernel32.dll";

	public const string ZLibVersion = "1.3.1";

	internal static readonly IntPtr ZNullPtr = (IntPtr)0;

	public const int Deflate_DefaultWindowBits = -15;

	public const int Deflate_DefaultMemLevel = 8;

	[SecurityCritical]
	public static ErrorCode CreateZLibStreamForDeflate(out ZLibStreamHandle zLibStreamHandle)
	{
		return CreateZLibStreamForDeflate(out zLibStreamHandle, CompressionLevel.DefaultCompression, -15, 8, CompressionStrategy.DefaultStrategy);
	}

	[SecurityCritical]
	public static ErrorCode CreateZLibStreamForDeflate(out ZLibStreamHandle zLibStreamHandle, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
	{
		zLibStreamHandle = new ZLibStreamHandle();
		return zLibStreamHandle.DeflateInit2_(level, windowBits, memLevel, strategy);
	}

	[SecurityCritical]
	public static ErrorCode CreateZLibStreamForInflate(out ZLibStreamHandle zLibStreamHandle)
	{
		return CreateZLibStreamForInflate(out zLibStreamHandle, -15);
	}

	[SecurityCritical]
	public static ErrorCode CreateZLibStreamForInflate(out ZLibStreamHandle zLibStreamHandle, int windowBits)
	{
		zLibStreamHandle = new ZLibStreamHandle();
		return zLibStreamHandle.InflateInit2_(windowBits);
	}

	[SecurityCritical]
	public static int ZLibCompileFlags()
	{
		return ZLibStreamHandle.ZLibCompileFlags();
	}
}
