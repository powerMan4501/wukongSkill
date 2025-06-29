using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.CodeDom.Compiler;

[Serializable]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class TempFileCollection : ICollection, IEnumerable, IDisposable
{
	private string basePath;

	private string tempDir;

	private bool keepFiles;

	private Hashtable files;

	[NonSerialized]
	private WindowsIdentity currentIdentity;

	[NonSerialized]
	private string highIntegrityDirectory;

	public int Count => files.Count;

	int ICollection.Count => files.Count;

	object ICollection.SyncRoot => null;

	bool ICollection.IsSynchronized => false;

	public string TempDir
	{
		get
		{
			if (tempDir != null)
			{
				return tempDir;
			}
			return string.Empty;
		}
	}

	public string BasePath
	{
		get
		{
			EnsureTempNameCreated();
			return basePath;
		}
	}

	public bool KeepFiles
	{
		get
		{
			return keepFiles;
		}
		set
		{
			keepFiles = value;
		}
	}

	public TempFileCollection()
		: this(null, keepFiles: false)
	{
	}

	public TempFileCollection(string tempDir)
		: this(tempDir, keepFiles: false)
	{
	}

	[SecurityPermission(SecurityAction.Assert, ControlPrincipal = true)]
	public TempFileCollection(string tempDir, bool keepFiles)
	{
		this.keepFiles = keepFiles;
		this.tempDir = tempDir;
		files = new Hashtable(StringComparer.OrdinalIgnoreCase);
		WindowsImpersonationContext impersonation = Executor.RevertImpersonation();
		try
		{
			currentIdentity = WindowsIdentity.GetCurrent();
		}
		finally
		{
			Executor.ReImpersonate(impersonation);
		}
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		Delete();
		DeleteHighIntegrityDirectory();
	}

	~TempFileCollection()
	{
		Dispose(disposing: false);
	}

	public string AddExtension(string fileExtension)
	{
		return AddExtension(fileExtension, keepFiles);
	}

	public string AddExtension(string fileExtension, bool keepFile)
	{
		if (fileExtension == null || fileExtension.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidNullEmptyArgument", "fileExtension"), "fileExtension");
		}
		string text = BasePath + "." + fileExtension;
		AddFile(text, keepFile);
		return text;
	}

	public void AddFile(string fileName, bool keepFile)
	{
		if (fileName == null || fileName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidNullEmptyArgument", "fileName"), "fileName");
		}
		if (files[fileName] != null)
		{
			throw new ArgumentException(SR.GetString("DuplicateFileName", fileName), "fileName");
		}
		files.Add(fileName, keepFile);
	}

	public IEnumerator GetEnumerator()
	{
		return files.Keys.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return files.Keys.GetEnumerator();
	}

	void ICollection.CopyTo(Array array, int start)
	{
		files.Keys.CopyTo(array, start);
	}

	public void CopyTo(string[] fileNames, int start)
	{
		files.Keys.CopyTo(fileNames, start);
	}

	private void EnsureTempNameCreated()
	{
		if (basePath != null)
		{
			return;
		}
		string text = null;
		bool flag = false;
		int num = 5000;
		do
		{
			try
			{
				basePath = GetTempFileName(TempDir);
				string fullPath = Path.GetFullPath(basePath);
				new FileIOPermission(FileIOPermissionAccess.AllAccess, fullPath).Demand();
				text = basePath + ".tmp";
				FileStream fileStream;
				using (fileStream = new FileStream(text, FileMode.CreateNew, FileAccess.Write))
				{
				}
				flag = true;
			}
			catch (IOException e)
			{
				num--;
				uint num2 = 2147942480u;
				if (num == 0 || Marshal.GetHRForException(e) != num2)
				{
					throw;
				}
				flag = false;
			}
		}
		while (!flag);
		files.Add(text, keepFiles);
	}

	private bool KeepFile(string fileName)
	{
		object obj = files[fileName];
		if (obj == null)
		{
			return false;
		}
		return (bool)obj;
	}

	public void Delete()
	{
		if (files == null || files.Count <= 0)
		{
			return;
		}
		string[] array = new string[files.Count];
		files.Keys.CopyTo(array, 0);
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (!KeepFile(text))
			{
				Delete(text);
				files.Remove(text);
			}
		}
	}

	private void DeleteHighIntegrityDirectory()
	{
		try
		{
			if (currentIdentity != null && Directory.Exists(highIntegrityDirectory))
			{
				RemoveAceOnTempDirectory(highIntegrityDirectory, currentIdentity.User.ToString());
				if (Directory.GetFiles(highIntegrityDirectory).Length == 0)
				{
					Directory.Delete(highIntegrityDirectory, recursive: true);
				}
			}
		}
		catch
		{
		}
	}

	internal void SafeDelete()
	{
		WindowsImpersonationContext impersonation = Executor.RevertImpersonation();
		try
		{
			Delete();
		}
		finally
		{
			Executor.ReImpersonate(impersonation);
		}
	}

	private void Delete(string fileName)
	{
		try
		{
			File.Delete(fileName);
		}
		catch
		{
		}
	}

	private string GetTempFileName(string tempDir)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
		if (string.IsNullOrEmpty(tempDir))
		{
			tempDir = Path.GetTempPath();
			if (!System.LocalAppContextSwitches.DisableTempFileCollectionDirectoryFeature && currentIdentity != null && new WindowsPrincipal(currentIdentity).IsInRole(WindowsBuiltInRole.Administrator))
			{
				tempDir = Path.Combine(tempDir, fileNameWithoutExtension);
				CreateTempDirectoryWithAce(tempDir, currentIdentity.User.ToString());
				highIntegrityDirectory = tempDir;
			}
		}
		if (tempDir.EndsWith("\\", StringComparison.Ordinal))
		{
			return tempDir + fileNameWithoutExtension;
		}
		return tempDir + "\\" + fileNameWithoutExtension;
	}

	private static void CreateTempDirectoryWithAce(string directory, string identity)
	{
		string stringSecurityDescriptor = "D:(D;OI;SD;;;" + identity + ")(A;OICI;FA;;;BA)S:(ML;OI;NW;;;HI)";
		SafeLocalMemHandle pSecurityDescriptor = null;
		SafeLocalMemHandle.ConvertStringSecurityDescriptorToSecurityDescriptor(stringSecurityDescriptor, 1, out pSecurityDescriptor, IntPtr.Zero);
		Microsoft.Win32.NativeMethods.CreateDirectory(directory, pSecurityDescriptor);
	}

	private static void RemoveAceOnTempDirectory(string directory, string identity)
	{
		string stringSecurityDescriptor = "D:(A;OICI;FA;;;" + identity + ")(A;OICI;FA;;;BA)";
		SafeLocalMemHandle pSecurityDescriptor = null;
		SafeLocalMemHandle.ConvertStringSecurityDescriptorToSecurityDescriptor(stringSecurityDescriptor, 1, out pSecurityDescriptor, IntPtr.Zero);
		Microsoft.Win32.NativeMethods.SetNamedSecurityInfo(directory, pSecurityDescriptor);
	}
}
