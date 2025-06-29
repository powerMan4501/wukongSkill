using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Text;

[Serializable]
internal abstract class BaseCodePageEncoding : EncodingNLS, ISerializable
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct CodePageDataFileHeader
	{
		[FieldOffset(0)]
		internal char TableName;

		[FieldOffset(32)]
		internal ushort Version;

		[FieldOffset(40)]
		internal short CodePageCount;

		[FieldOffset(42)]
		internal short unused1;

		[FieldOffset(44)]
		internal CodePageIndex CodePages;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 2)]
	internal struct CodePageIndex
	{
		[FieldOffset(0)]
		internal char CodePageName;

		[FieldOffset(32)]
		internal short CodePage;

		[FieldOffset(34)]
		internal short ByteCount;

		[FieldOffset(36)]
		internal int Offset;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct CodePageHeader
	{
		[FieldOffset(0)]
		internal char CodePageName;

		[FieldOffset(32)]
		internal ushort VersionMajor;

		[FieldOffset(34)]
		internal ushort VersionMinor;

		[FieldOffset(36)]
		internal ushort VersionRevision;

		[FieldOffset(38)]
		internal ushort VersionBuild;

		[FieldOffset(40)]
		internal short CodePage;

		[FieldOffset(42)]
		internal short ByteCount;

		[FieldOffset(44)]
		internal char UnicodeReplace;

		[FieldOffset(46)]
		internal ushort ByteReplace;

		[FieldOffset(48)]
		internal short FirstDataWord;
	}

	internal const string CODE_PAGE_DATA_FILE_NAME = "codepages.nlp";

	[NonSerialized]
	protected int dataTableCodePage;

	[NonSerialized]
	protected bool bFlagDataTable = true;

	[NonSerialized]
	protected int iExtraBytes;

	[NonSerialized]
	protected char[] arrayUnicodeBestFit;

	[NonSerialized]
	protected char[] arrayBytesBestFit;

	[NonSerialized]
	protected bool m_bUseMlangTypeForSerialization;

	[SecurityCritical]
	private unsafe static CodePageDataFileHeader* m_pCodePageFileHeader;

	[NonSerialized]
	[SecurityCritical]
	protected unsafe CodePageHeader* pCodePage = null;

	[NonSerialized]
	[SecurityCritical]
	protected SafeViewOfFileHandle safeMemorySectionHandle;

	[NonSerialized]
	[SecurityCritical]
	protected SafeFileMappingHandle safeFileMappingHandle;

	[SecuritySafeCritical]
	static unsafe BaseCodePageEncoding()
	{
		m_pCodePageFileHeader = (CodePageDataFileHeader*)GlobalizationAssembly.GetGlobalizationResourceBytePtr(typeof(CharUnicodeInfo).Assembly, "codepages.nlp");
	}

	[SecurityCritical]
	internal BaseCodePageEncoding(int codepage)
		: this(codepage, codepage)
	{
	}

	[SecurityCritical]
	internal unsafe BaseCodePageEncoding(int codepage, int dataCodePage)
		: base((codepage == 0) ? Win32Native.GetACP() : codepage)
	{
		dataTableCodePage = dataCodePage;
		LoadCodePageTables();
	}

	[SecurityCritical]
	internal unsafe BaseCodePageEncoding(SerializationInfo info, StreamingContext context)
		: base(0)
	{
		throw new ArgumentNullException("this");
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		SerializeEncoding(info, context);
		info.AddValue(m_bUseMlangTypeForSerialization ? "m_maxByteSize" : "maxCharSize", IsSingleByte ? 1 : 2);
		info.SetType(m_bUseMlangTypeForSerialization ? typeof(MLangCodePageEncoding) : typeof(CodePageEncoding));
	}

	[SecurityCritical]
	private unsafe void LoadCodePageTables()
	{
		CodePageHeader* ptr = FindCodePage(dataTableCodePage);
		if (ptr == null)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NoCodepageData", CodePage));
		}
		pCodePage = ptr;
		LoadManagedCodePage();
	}

	[SecurityCritical]
	private unsafe static CodePageHeader* FindCodePage(int codePage)
	{
		for (int i = 0; i < m_pCodePageFileHeader->CodePageCount; i++)
		{
			CodePageIndex* ptr = &m_pCodePageFileHeader->CodePages + i;
			if (ptr->CodePage == codePage)
			{
				return (CodePageHeader*)((byte*)m_pCodePageFileHeader + ptr->Offset);
			}
		}
		return null;
	}

	[SecurityCritical]
	internal unsafe static int GetCodePageByteSize(int codePage)
	{
		CodePageHeader* ptr = FindCodePage(codePage);
		if (ptr == null)
		{
			return 0;
		}
		return ptr->ByteCount;
	}

	[SecurityCritical]
	protected abstract void LoadManagedCodePage();

	[SecurityCritical]
	protected unsafe byte* GetSharedMemory(int iSize)
	{
		string memorySectionName = GetMemorySectionName();
		IntPtr mappedFileHandle;
		byte* ptr = EncodingTable.nativeCreateOpenFileMapping(memorySectionName, iSize, out mappedFileHandle);
		if (ptr == null)
		{
			throw new OutOfMemoryException(Environment.GetResourceString("Arg_OutOfMemoryException"));
		}
		if (mappedFileHandle != IntPtr.Zero)
		{
			safeMemorySectionHandle = new SafeViewOfFileHandle((IntPtr)ptr, ownsHandle: true);
			safeFileMappingHandle = new SafeFileMappingHandle(mappedFileHandle, ownsHandle: true);
		}
		return ptr;
	}

	[SecurityCritical]
	protected unsafe virtual string GetMemorySectionName()
	{
		int num = (bFlagDataTable ? dataTableCodePage : CodePage);
		return string.Format(CultureInfo.InvariantCulture, "NLS_CodePage_{0}_{1}_{2}_{3}_{4}", num, pCodePage->VersionMajor, pCodePage->VersionMinor, pCodePage->VersionRevision, pCodePage->VersionBuild);
	}

	[SecurityCritical]
	protected abstract void ReadBestFitTable();

	[SecuritySafeCritical]
	internal override char[] GetBestFitUnicodeToBytesData()
	{
		if (arrayUnicodeBestFit == null)
		{
			ReadBestFitTable();
		}
		return arrayUnicodeBestFit;
	}

	[SecuritySafeCritical]
	internal override char[] GetBestFitBytesToUnicodeData()
	{
		if (arrayBytesBestFit == null)
		{
			ReadBestFitTable();
		}
		return arrayBytesBestFit;
	}

	[SecurityCritical]
	internal void CheckMemorySection()
	{
		if (safeMemorySectionHandle != null && safeMemorySectionHandle.DangerousGetHandle() == IntPtr.Zero)
		{
			LoadManagedCodePage();
		}
	}
}
