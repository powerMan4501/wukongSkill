using System.Collections;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace System.Globalization;

internal static class EncodingTable
{
	private static int lastEncodingItem;

	private static volatile int lastCodePageItem;

	[SecurityCritical]
	internal unsafe static InternalEncodingDataItem* encodingDataPtr;

	[SecurityCritical]
	internal unsafe static InternalCodePageDataItem* codePageDataPtr;

	private static Hashtable hashByName;

	private static Hashtable hashByCodePage;

	[SecuritySafeCritical]
	static unsafe EncodingTable()
	{
		lastEncodingItem = GetNumEncodingItems() - 1;
		encodingDataPtr = GetEncodingData();
		codePageDataPtr = GetCodePageData();
		hashByName = Hashtable.Synchronized(new Hashtable(StringComparer.OrdinalIgnoreCase));
		hashByCodePage = Hashtable.Synchronized(new Hashtable());
	}

	[SecuritySafeCritical]
	private unsafe static int internalGetCodePageFromName(string name)
	{
		int i = 0;
		int num = lastEncodingItem;
		while (num - i > 3)
		{
			int num2 = (num - i) / 2 + i;
			int num3 = string.nativeCompareOrdinalIgnoreCaseWC(name, encodingDataPtr[num2].webName);
			if (num3 == 0)
			{
				return encodingDataPtr[num2].codePage;
			}
			if (num3 < 0)
			{
				num = num2;
			}
			else
			{
				i = num2;
			}
		}
		for (; i <= num; i++)
		{
			if (string.nativeCompareOrdinalIgnoreCaseWC(name, encodingDataPtr[i].webName) == 0)
			{
				return encodingDataPtr[i].codePage;
			}
		}
		throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_EncodingNotSupported"), name), "name");
	}

	[SecuritySafeCritical]
	internal unsafe static EncodingInfo[] GetEncodings()
	{
		if (lastCodePageItem == 0)
		{
			int i;
			for (i = 0; codePageDataPtr[i].codePage != 0; i++)
			{
			}
			lastCodePageItem = i;
		}
		EncodingInfo[] array = new EncodingInfo[lastCodePageItem];
		for (int j = 0; j < lastCodePageItem; j++)
		{
			array[j] = new EncodingInfo(codePageDataPtr[j].codePage, CodePageDataItem.CreateString(codePageDataPtr[j].Names, 0u), Environment.GetResourceString("Globalization.cp_" + codePageDataPtr[j].codePage));
		}
		return array;
	}

	internal static int GetCodePageFromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		object obj = hashByName[name];
		if (obj != null)
		{
			return (int)obj;
		}
		int num = internalGetCodePageFromName(name);
		hashByName[name] = num;
		return num;
	}

	[SecuritySafeCritical]
	internal unsafe static CodePageDataItem GetCodePageDataItem(int codepage)
	{
		CodePageDataItem codePageDataItem = (CodePageDataItem)hashByCodePage[codepage];
		if (codePageDataItem != null)
		{
			return codePageDataItem;
		}
		int num = 0;
		int codePage;
		while ((codePage = codePageDataPtr[num].codePage) != 0)
		{
			if (codePage == codepage)
			{
				codePageDataItem = new CodePageDataItem(num);
				hashByCodePage[codepage] = codePageDataItem;
				return codePageDataItem;
			}
			num++;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern InternalEncodingDataItem* GetEncodingData();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int GetNumEncodingItems();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern InternalCodePageDataItem* GetCodePageData();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern byte* nativeCreateOpenFileMapping(string inSectionName, int inBytesToAllocate, out IntPtr mappedFileHandle);
}
