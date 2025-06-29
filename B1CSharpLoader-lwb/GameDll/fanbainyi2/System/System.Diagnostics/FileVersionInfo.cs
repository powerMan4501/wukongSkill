using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.Diagnostics;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class FileVersionInfo
{
	private string fileName;

	private string companyName;

	private string fileDescription;

	private string fileVersion;

	private string internalName;

	private string legalCopyright;

	private string originalFilename;

	private string productName;

	private string productVersion;

	private string comments;

	private string legalTrademarks;

	private string privateBuild;

	private string specialBuild;

	private string language;

	private int fileMajor;

	private int fileMinor;

	private int fileBuild;

	private int filePrivate;

	private int productMajor;

	private int productMinor;

	private int productBuild;

	private int productPrivate;

	private int fileFlags;

	public string Comments => comments;

	public string CompanyName => companyName;

	public int FileBuildPart => fileBuild;

	public string FileDescription => fileDescription;

	public int FileMajorPart => fileMajor;

	public int FileMinorPart => fileMinor;

	public string FileName
	{
		get
		{
			new FileIOPermission(FileIOPermissionAccess.PathDiscovery, fileName).Demand();
			return fileName;
		}
	}

	public int FilePrivatePart => filePrivate;

	public string FileVersion => fileVersion;

	public string InternalName => internalName;

	public bool IsDebug => (fileFlags & 1) != 0;

	public bool IsPatched => (fileFlags & 4) != 0;

	public bool IsPrivateBuild => (fileFlags & 8) != 0;

	public bool IsPreRelease => (fileFlags & 2) != 0;

	public bool IsSpecialBuild => (fileFlags & 0x20) != 0;

	public string Language => language;

	public string LegalCopyright => legalCopyright;

	public string LegalTrademarks => legalTrademarks;

	public string OriginalFilename => originalFilename;

	public string PrivateBuild => privateBuild;

	public int ProductBuildPart => productBuild;

	public int ProductMajorPart => productMajor;

	public int ProductMinorPart => productMinor;

	public string ProductName => productName;

	public int ProductPrivatePart => productPrivate;

	public string ProductVersion => productVersion;

	public string SpecialBuild => specialBuild;

	private FileVersionInfo(string fileName)
	{
		this.fileName = fileName;
	}

	private static string ConvertTo8DigitHex(int value)
	{
		string text = Convert.ToString(value, 16);
		text = text.ToUpper(CultureInfo.InvariantCulture);
		if (text.Length == 8)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(8);
		for (int i = text.Length; i < 8; i++)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(text);
		return stringBuilder.ToString();
	}

	private static Microsoft.Win32.NativeMethods.VS_FIXEDFILEINFO GetFixedFileInfo(IntPtr memPtr)
	{
		IntPtr lplpBuffer = IntPtr.Zero;
		if (Microsoft.Win32.UnsafeNativeMethods.VerQueryValue(new HandleRef(null, memPtr), "\\", ref lplpBuffer, out var _))
		{
			Microsoft.Win32.NativeMethods.VS_FIXEDFILEINFO vS_FIXEDFILEINFO = new Microsoft.Win32.NativeMethods.VS_FIXEDFILEINFO();
			Marshal.PtrToStructure(lplpBuffer, (object)vS_FIXEDFILEINFO);
			return vS_FIXEDFILEINFO;
		}
		return new Microsoft.Win32.NativeMethods.VS_FIXEDFILEINFO();
	}

	private static string GetFileVersionLanguage(IntPtr memPtr)
	{
		int langID = GetVarEntry(memPtr) >> 16;
		StringBuilder stringBuilder = new StringBuilder(256);
		Microsoft.Win32.UnsafeNativeMethods.VerLanguageName(langID, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	private static string GetFileVersionString(IntPtr memPtr, string name)
	{
		string result = "";
		IntPtr lplpBuffer = IntPtr.Zero;
		if (Microsoft.Win32.UnsafeNativeMethods.VerQueryValue(new HandleRef(null, memPtr), name, ref lplpBuffer, out var _) && lplpBuffer != IntPtr.Zero)
		{
			result = Marshal.PtrToStringAuto(lplpBuffer);
		}
		return result;
	}

	private static int GetVarEntry(IntPtr memPtr)
	{
		IntPtr lplpBuffer = IntPtr.Zero;
		if (Microsoft.Win32.UnsafeNativeMethods.VerQueryValue(new HandleRef(null, memPtr), "\\VarFileInfo\\Translation", ref lplpBuffer, out var _))
		{
			return (Marshal.ReadInt16(lplpBuffer) << 16) + Marshal.ReadInt16((IntPtr)((long)lplpBuffer + 2));
		}
		return 67699940;
	}

	private bool GetVersionInfoForCodePage(IntPtr memIntPtr, string codepage)
	{
		string format = "\\\\StringFileInfo\\\\{0}\\\\{1}";
		companyName = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "CompanyName" }));
		fileDescription = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "FileDescription" }));
		fileVersion = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "FileVersion" }));
		internalName = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "InternalName" }));
		legalCopyright = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "LegalCopyright" }));
		originalFilename = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "OriginalFilename" }));
		productName = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "ProductName" }));
		productVersion = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "ProductVersion" }));
		comments = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "Comments" }));
		legalTrademarks = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "LegalTrademarks" }));
		privateBuild = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "PrivateBuild" }));
		specialBuild = GetFileVersionString(memIntPtr, string.Format(CultureInfo.InvariantCulture, format, new object[2] { codepage, "SpecialBuild" }));
		language = GetFileVersionLanguage(memIntPtr);
		Microsoft.Win32.NativeMethods.VS_FIXEDFILEINFO fixedFileInfo = GetFixedFileInfo(memIntPtr);
		fileMajor = HIWORD(fixedFileInfo.dwFileVersionMS);
		fileMinor = LOWORD(fixedFileInfo.dwFileVersionMS);
		fileBuild = HIWORD(fixedFileInfo.dwFileVersionLS);
		filePrivate = LOWORD(fixedFileInfo.dwFileVersionLS);
		productMajor = HIWORD(fixedFileInfo.dwProductVersionMS);
		productMinor = LOWORD(fixedFileInfo.dwProductVersionMS);
		productBuild = HIWORD(fixedFileInfo.dwProductVersionLS);
		productPrivate = LOWORD(fixedFileInfo.dwProductVersionLS);
		fileFlags = fixedFileInfo.dwFileFlags;
		return fileVersion != string.Empty;
	}

	[FileIOPermission(SecurityAction.Assert, AllFiles = FileIOPermissionAccess.PathDiscovery)]
	private static string GetFullPathWithAssert(string fileName)
	{
		return Path.GetFullPath(fileName);
	}

	public unsafe static FileVersionInfo GetVersionInfo(string fileName)
	{
		if (!File.Exists(fileName))
		{
			string fullPathWithAssert = GetFullPathWithAssert(fileName);
			new FileIOPermission(FileIOPermissionAccess.Read, fullPathWithAssert).Demand();
			throw new FileNotFoundException(fileName);
		}
		int handle;
		int fileVersionInfoSize = Microsoft.Win32.UnsafeNativeMethods.GetFileVersionInfoSize(fileName, out handle);
		FileVersionInfo fileVersionInfo = new FileVersionInfo(fileName);
		if (fileVersionInfoSize != 0)
		{
			fixed (byte* value = new byte[fileVersionInfoSize])
			{
				IntPtr intPtr = new IntPtr(value);
				if (Microsoft.Win32.UnsafeNativeMethods.GetFileVersionInfo(fileName, 0, fileVersionInfoSize, new HandleRef(null, intPtr)))
				{
					int varEntry = GetVarEntry(intPtr);
					if (!fileVersionInfo.GetVersionInfoForCodePage(intPtr, ConvertTo8DigitHex(varEntry)))
					{
						int[] array = new int[3] { 67699888, 67699940, 67698688 };
						int[] array2 = array;
						foreach (int num in array2)
						{
							if (num != varEntry && fileVersionInfo.GetVersionInfoForCodePage(intPtr, ConvertTo8DigitHex(num)))
							{
								break;
							}
						}
					}
				}
			}
		}
		return fileVersionInfo;
	}

	private static int HIWORD(int dword)
	{
		return Microsoft.Win32.NativeMethods.Util.HIWORD(dword);
	}

	private static int LOWORD(int dword)
	{
		return Microsoft.Win32.NativeMethods.Util.LOWORD(dword);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(128);
		string value = "\r\n";
		stringBuilder.Append("File:             ");
		stringBuilder.Append(FileName);
		stringBuilder.Append(value);
		stringBuilder.Append("InternalName:     ");
		stringBuilder.Append(InternalName);
		stringBuilder.Append(value);
		stringBuilder.Append("OriginalFilename: ");
		stringBuilder.Append(OriginalFilename);
		stringBuilder.Append(value);
		stringBuilder.Append("FileVersion:      ");
		stringBuilder.Append(FileVersion);
		stringBuilder.Append(value);
		stringBuilder.Append("FileDescription:  ");
		stringBuilder.Append(FileDescription);
		stringBuilder.Append(value);
		stringBuilder.Append("Product:          ");
		stringBuilder.Append(ProductName);
		stringBuilder.Append(value);
		stringBuilder.Append("ProductVersion:   ");
		stringBuilder.Append(ProductVersion);
		stringBuilder.Append(value);
		stringBuilder.Append("Debug:            ");
		stringBuilder.Append(IsDebug.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append("Patched:          ");
		stringBuilder.Append(IsPatched.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append("PreRelease:       ");
		stringBuilder.Append(IsPreRelease.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append("PrivateBuild:     ");
		stringBuilder.Append(IsPrivateBuild.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append("SpecialBuild:     ");
		stringBuilder.Append(IsSpecialBuild.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append("Language:         ");
		stringBuilder.Append(Language);
		stringBuilder.Append(value);
		return stringBuilder.ToString();
	}
}
