using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Net.Cache;

internal static class _WinInetCache
{
	[Flags]
	internal enum EntryType
	{
		NormalEntry = 0x41,
		StickyEntry = 0x44,
		Edited = 8,
		TrackOffline = 0x10,
		TrackOnline = 0x20,
		Sparse = 0x10000,
		Cookie = 0x100000,
		UrlHistory = 0x200000
	}

	[Flags]
	internal enum Entry_FC
	{
		None = 0,
		Attribute = 4,
		Hitrate = 0x10,
		Modtime = 0x40,
		Exptime = 0x80,
		Acctime = 0x100,
		Synctime = 0x200,
		Headerinfo = 0x400,
		ExemptDelta = 0x800
	}

	internal enum Status
	{
		Success = 0,
		InsufficientBuffer = 122,
		FileNotFound = 2,
		NoMoreItems = 259,
		NotEnoughStorage = 8,
		SharingViolation = 32,
		InvalidParameter = 87,
		Warnings = 16777216,
		FatalErrors = 16781312,
		CorruptedHeaders = 16781313,
		InternalError = 16781314
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct FILETIME
	{
		public uint Low;

		public uint High;

		public static readonly FILETIME Zero = new FILETIME(0L);

		public bool IsNull
		{
			get
			{
				if (Low == 0)
				{
					return High == 0;
				}
				return false;
			}
		}

		public FILETIME(long time)
		{
			Low = (uint)time;
			High = (uint)(time >> 32);
		}

		public long ToLong()
		{
			return (long)(((ulong)High << 32) | Low);
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct EntryBuffer
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct Rsv
		{
			[FieldOffset(0)]
			public int ExemptDelta;

			[FieldOffset(0)]
			public int Reserved;
		}

		public static int MarshalSize = Marshal.SizeOf(typeof(EntryBuffer));

		public int StructSize;

		public IntPtr _OffsetSourceUrlName;

		public IntPtr _OffsetFileName;

		public EntryType EntryType;

		public int UseCount;

		public int HitRate;

		public int SizeLow;

		public int SizeHigh;

		public FILETIME LastModifiedTime;

		public FILETIME ExpireTime;

		public FILETIME LastAccessTime;

		public FILETIME LastSyncTime;

		public IntPtr _OffsetHeaderInfo;

		public int HeaderInfoChars;

		public IntPtr _OffsetExtension;

		public Rsv U;
	}

	internal class Entry
	{
		public const int DefaultBufferSize = 2048;

		public Status Error;

		public string Key;

		public string Filename;

		public string FileExt;

		public int OptionalLength;

		public string OriginalUrl;

		public string MetaInfo;

		public int MaxBufferBytes;

		public EntryBuffer Info;

		public Entry(string key, int maxHeadersSize)
		{
			Key = key;
			MaxBufferBytes = maxHeadersSize;
			if (maxHeadersSize != int.MaxValue && int.MaxValue - (key.Length + EntryBuffer.MarshalSize + 1024) * 2 > maxHeadersSize)
			{
				MaxBufferBytes += (key.Length + EntryBuffer.MarshalSize + 1024) * 2;
			}
			Info.EntryType = EntryType.NormalEntry;
		}
	}

	private const int c_CharSz = 2;

	internal unsafe static Status LookupInfo(Entry entry)
	{
		byte[] array = new byte[2048];
		int bufferSz = array.Length;
		byte[] array2 = array;
		for (int i = 0; i < 64; i++)
		{
			fixed (byte* ptr = array2)
			{
				if (UnsafeNclNativeMethods.UnsafeWinInetCache.GetUrlCacheEntryInfoW(entry.Key, ptr, ref bufferSz))
				{
					array = array2;
					entry.MaxBufferBytes = bufferSz;
					EntryFixup(entry, (EntryBuffer*)ptr, array2);
					entry.Error = Status.Success;
					return entry.Error;
				}
				entry.Error = (Status)Marshal.GetLastWin32Error();
				if (entry.Error == Status.InsufficientBuffer && array2 == array && bufferSz <= entry.MaxBufferBytes)
				{
					array2 = new byte[bufferSz];
					continue;
				}
			}
			break;
		}
		return entry.Error;
	}

	internal unsafe static SafeUnlockUrlCacheEntryFile LookupFile(Entry entry)
	{
		byte[] array = new byte[2048];
		int entryBufSize = array.Length;
		SafeUnlockUrlCacheEntryFile handle = null;
		try
		{
			while (true)
			{
				fixed (byte* ptr = array)
				{
					entry.Error = SafeUnlockUrlCacheEntryFile.GetAndLockFile(entry.Key, ptr, ref entryBufSize, out handle);
					if (entry.Error == Status.Success)
					{
						entry.MaxBufferBytes = entryBufSize;
						EntryFixup(entry, (EntryBuffer*)ptr, array);
						return handle;
					}
					if (entry.Error == Status.InsufficientBuffer && entryBufSize <= entry.MaxBufferBytes)
					{
						array = new byte[entryBufSize];
						continue;
					}
				}
				break;
			}
		}
		catch (Exception ex)
		{
			handle?.Close();
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (entry.Error == Status.Success)
			{
				entry.Error = Status.InternalError;
			}
		}
		return null;
	}

	private unsafe static Status EntryFixup(Entry entry, EntryBuffer* bufferPtr, byte[] buffer)
	{
		bufferPtr->_OffsetExtension = ((bufferPtr->_OffsetExtension == IntPtr.Zero) ? IntPtr.Zero : ((IntPtr)((byte*)(void*)bufferPtr->_OffsetExtension - (byte*)bufferPtr)));
		bufferPtr->_OffsetFileName = ((bufferPtr->_OffsetFileName == IntPtr.Zero) ? IntPtr.Zero : ((IntPtr)((byte*)(void*)bufferPtr->_OffsetFileName - (byte*)bufferPtr)));
		bufferPtr->_OffsetHeaderInfo = ((bufferPtr->_OffsetHeaderInfo == IntPtr.Zero) ? IntPtr.Zero : ((IntPtr)((byte*)(void*)bufferPtr->_OffsetHeaderInfo - (byte*)bufferPtr)));
		bufferPtr->_OffsetSourceUrlName = ((bufferPtr->_OffsetSourceUrlName == IntPtr.Zero) ? IntPtr.Zero : ((IntPtr)((byte*)(void*)bufferPtr->_OffsetSourceUrlName - (byte*)bufferPtr)));
		entry.Info = *bufferPtr;
		entry.OriginalUrl = GetEntryBufferString(bufferPtr, (int)bufferPtr->_OffsetSourceUrlName);
		entry.Filename = GetEntryBufferString(bufferPtr, (int)bufferPtr->_OffsetFileName);
		entry.FileExt = GetEntryBufferString(bufferPtr, (int)bufferPtr->_OffsetExtension);
		return GetEntryHeaders(entry, bufferPtr, buffer);
	}

	internal static Status CreateFileName(Entry entry)
	{
		entry.Error = Status.Success;
		StringBuilder stringBuilder = new StringBuilder(260);
		if (UnsafeNclNativeMethods.UnsafeWinInetCache.CreateUrlCacheEntryW(entry.Key, entry.OptionalLength, entry.FileExt, stringBuilder, 0))
		{
			entry.Filename = stringBuilder.ToString();
			return Status.Success;
		}
		entry.Error = (Status)Marshal.GetLastWin32Error();
		return entry.Error;
	}

	internal unsafe static Status Commit(Entry entry)
	{
		string text = entry.MetaInfo;
		if (text == null)
		{
			text = string.Empty;
		}
		if (text.Length + entry.Key.Length + entry.Filename.Length + ((entry.OriginalUrl != null) ? entry.OriginalUrl.Length : 0) > entry.MaxBufferBytes / 2)
		{
			entry.Error = Status.InsufficientBuffer;
			return entry.Error;
		}
		entry.Error = Status.Success;
		fixed (char* ptr = text)
		{
			byte* headerInfo = (byte*)((text.Length == 0) ? null : ptr);
			if (!UnsafeNclNativeMethods.UnsafeWinInetCache.CommitUrlCacheEntryW(entry.Key, entry.Filename, entry.Info.ExpireTime, entry.Info.LastModifiedTime, entry.Info.EntryType, headerInfo, text.Length, null, entry.OriginalUrl))
			{
				entry.Error = (Status)Marshal.GetLastWin32Error();
			}
		}
		return entry.Error;
	}

	internal unsafe static Status Update(Entry newEntry, Entry_FC attributes)
	{
		byte[] array = new byte[EntryBuffer.MarshalSize];
		newEntry.Error = Status.Success;
		fixed (byte* ptr = array)
		{
			EntryBuffer* ptr2 = (EntryBuffer*)ptr;
			*ptr2 = newEntry.Info;
			ptr2->StructSize = EntryBuffer.MarshalSize;
			if ((attributes & Entry_FC.Headerinfo) == 0)
			{
				if (!UnsafeNclNativeMethods.UnsafeWinInetCache.SetUrlCacheEntryInfoW(newEntry.Key, ptr, attributes))
				{
					newEntry.Error = (Status)Marshal.GetLastWin32Error();
				}
			}
			else
			{
				Entry entry = new Entry(newEntry.Key, newEntry.MaxBufferBytes);
				SafeUnlockUrlCacheEntryFile safeUnlockUrlCacheEntryFile = null;
				bool flag = false;
				try
				{
					safeUnlockUrlCacheEntryFile = LookupFile(entry);
					if (safeUnlockUrlCacheEntryFile == null)
					{
						newEntry.Error = entry.Error;
						return newEntry.Error;
					}
					newEntry.Filename = entry.Filename;
					newEntry.OriginalUrl = entry.OriginalUrl;
					newEntry.FileExt = entry.FileExt;
					attributes &= ~Entry_FC.Headerinfo;
					if ((attributes & Entry_FC.Exptime) == 0)
					{
						newEntry.Info.ExpireTime = entry.Info.ExpireTime;
					}
					if ((attributes & Entry_FC.Modtime) == 0)
					{
						newEntry.Info.LastModifiedTime = entry.Info.LastModifiedTime;
					}
					if ((attributes & Entry_FC.Attribute) == 0)
					{
						newEntry.Info.EntryType = entry.Info.EntryType;
						newEntry.Info.U.ExemptDelta = entry.Info.U.ExemptDelta;
						if ((entry.Info.EntryType & EntryType.StickyEntry) == EntryType.StickyEntry)
						{
							attributes |= Entry_FC.Attribute | Entry_FC.ExemptDelta;
						}
					}
					attributes &= ~(Entry_FC.Modtime | Entry_FC.Exptime);
					flag = (entry.Info.EntryType & EntryType.Edited) != 0;
					if (!flag)
					{
						entry.Info.EntryType |= EntryType.Edited;
						if (Update(entry, Entry_FC.Attribute) != Status.Success)
						{
							newEntry.Error = entry.Error;
							return newEntry.Error;
						}
					}
				}
				finally
				{
					safeUnlockUrlCacheEntryFile?.Close();
				}
				Remove(entry);
				if (Commit(newEntry) != Status.Success)
				{
					if (!flag)
					{
						entry.Info.EntryType &= ~EntryType.Edited;
						Update(entry, Entry_FC.Attribute);
					}
					return newEntry.Error;
				}
				if (attributes != Entry_FC.None)
				{
					Update(newEntry, attributes);
				}
			}
		}
		return newEntry.Error;
	}

	internal static Status Remove(Entry entry)
	{
		entry.Error = Status.Success;
		if (!UnsafeNclNativeMethods.UnsafeWinInetCache.DeleteUrlCacheEntryW(entry.Key))
		{
			entry.Error = (Status)Marshal.GetLastWin32Error();
		}
		return entry.Error;
	}

	private unsafe static string GetEntryBufferString(void* bufferPtr, int offset)
	{
		if (offset == 0)
		{
			return null;
		}
		IntPtr ptr = new IntPtr((byte*)bufferPtr + offset);
		return Marshal.PtrToStringUni(ptr);
	}

	private unsafe static Status GetEntryHeaders(Entry entry, EntryBuffer* bufferPtr, byte[] buffer)
	{
		entry.Error = Status.Success;
		entry.MetaInfo = null;
		if (bufferPtr->_OffsetHeaderInfo == IntPtr.Zero || bufferPtr->HeaderInfoChars == 0 || (bufferPtr->EntryType & EntryType.UrlHistory) != 0)
		{
			return Status.Success;
		}
		int num = bufferPtr->HeaderInfoChars + (int)bufferPtr->_OffsetHeaderInfo / 2;
		if (num * 2 > entry.MaxBufferBytes)
		{
			num = entry.MaxBufferBytes / 2;
		}
		while (((ushort*)bufferPtr)[num - 1] == 0)
		{
			num--;
		}
		entry.MetaInfo = Encoding.Unicode.GetString(buffer, (int)bufferPtr->_OffsetHeaderInfo, (num - (int)bufferPtr->_OffsetHeaderInfo / 2) * 2);
		return entry.Error;
	}
}
