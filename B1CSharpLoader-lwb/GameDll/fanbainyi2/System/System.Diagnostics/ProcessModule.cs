using System.ComponentModel;
using System.Globalization;
using System.Security.Permissions;

namespace System.Diagnostics;

[Designer("System.Diagnostics.Design.ProcessModuleDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class ProcessModule : Component
{
	internal ModuleInfo moduleInfo;

	private FileVersionInfo fileVersionInfo;

	[MonitoringDescription("ProcModModuleName")]
	public string ModuleName => moduleInfo.baseName;

	[MonitoringDescription("ProcModFileName")]
	public string FileName => moduleInfo.fileName;

	[MonitoringDescription("ProcModBaseAddress")]
	public IntPtr BaseAddress => moduleInfo.baseOfDll;

	[MonitoringDescription("ProcModModuleMemorySize")]
	public int ModuleMemorySize => moduleInfo.sizeOfImage;

	[MonitoringDescription("ProcModEntryPointAddress")]
	public IntPtr EntryPointAddress
	{
		get
		{
			EnsureNtProcessInfo();
			return moduleInfo.entryPoint;
		}
	}

	[Browsable(false)]
	public FileVersionInfo FileVersionInfo
	{
		get
		{
			if (fileVersionInfo == null)
			{
				fileVersionInfo = FileVersionInfo.GetVersionInfo(FileName);
			}
			return fileVersionInfo;
		}
	}

	internal ProcessModule(ModuleInfo moduleInfo)
	{
		this.moduleInfo = moduleInfo;
		GC.SuppressFinalize(this);
	}

	internal void EnsureNtProcessInfo()
	{
		if (Environment.OSVersion.Platform != PlatformID.Win32NT)
		{
			throw new PlatformNotSupportedException(SR.GetString("WinNTRequired"));
		}
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", new object[2]
		{
			base.ToString(),
			ModuleName
		});
	}
}
