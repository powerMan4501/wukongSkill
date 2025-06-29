using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

internal static class AppDomainDiagnostic
{
	[ComImport]
	[Guid("D332DB9E-B9B3-4125-8207-A14884F53216")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface ICLRMetaHost
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		object GetRuntime(string version, ref Guid iid);
	}

	[ComImport]
	[Guid("BD39D1D2-BA2F-486a-89B0-B4B0CB466891")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface ICLRRuntimeInfo
	{
		void GetVersionString(char[] buffer, int bufferLength);

		void GetRuntimeDirectory(char[] buffer, int bufferLength);

		bool IsLoaded(IntPtr hProcess);

		void LoadErrorString(uint id, char[] buffer, int bufferLength, int lcid);

		void LoadLibrary(string path, out IntPtr hMdodule);

		void GetProcAddress(string name, out IntPtr addr);

		[return: MarshalAs(UnmanagedType.Interface)]
		object GetInterface(ref Guid clsid, ref Guid iid);

		bool IsLoadable();

		void SetDefaultStartupFlags(uint flags, string configFile);

		void GetDefaultStartupFlags(out uint flags, char[] configFile, int configFileLength);

		void BindAsLegacyV2Runtime();

		void IsStarted(out bool started, out uint flags);
	}

	[ComImport]
	[Guid("CB2F6722-AB3A-11d2-9C40-00C04FA30A3E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface ICorRuntimeHost
	{
		void CreateLogicalThreadState();

		void DeleteLogicalThreadState();

		void SwitchinLogicalThreadState(IntPtr cookie);

		void SwitchoutLogicalThreadState(out IntPtr cookie);

		void LocksHeldByLogicalThread(out int count);

		void MapFile(IntPtr hFile, out IntPtr address);

		void GetConfiguration(out IntPtr config);

		void Start();

		void Stop();

		void CreateDomain(string name, object identity, out object domain);

		void GetDefaultDomain(out object domain);

		void EnumDomains(out IntPtr hEnum);

		void NextDomain(IntPtr hEnum, out _AppDomain domain);

		void CloseEnum(IntPtr hEnum);
	}

	private static Guid CLSID_CLRMetaHost = new Guid(2457868429u, 3726, 18535, 179, 12, 127, 168, 56, 132, 232, 222);

	private static Guid IID_CLRMetaHost = new Guid(3543325598u, 47539, 16677, 130, 7, 161, 72, 132, 245, 50, 22);

	private static Guid IID_CLRRuntimeInfo = new Guid(3174683090u, 47663, 18538, 137, 176, 180, 176, 203, 70, 104, 145);

	private static Guid CLSID_CorRuntimeHost = new Guid(3408881443u, 43834, 4562, 156, 64, 0, 192, 79, 163, 10, 62);

	private static Guid IID_CorRuntimeHost = new Guid(3408881442u, 43834, 4562, 156, 64, 0, 192, 79, 163, 10, 62);

	public static string[] GetNames()
	{
		try
		{
			List<string> list = new List<string>();
			foreach (object item in EnumAppDomains())
			{
				list.Add((item as _AppDomain).FriendlyName);
			}
			return list.ToArray();
		}
		catch
		{
		}
		return null;
	}

	public static IEnumerable<object> EnumAppDomains()
	{
		object ptr;
		int num = CLRCreateInstance(ref CLSID_CLRMetaHost, ref IID_CLRMetaHost, out ptr);
		if (num < 0)
		{
			throw new COMException("Cannot create meta host", num);
		}
		ICLRMetaHost obj = (ICLRMetaHost)ptr;
		Version version = Environment.Version;
		string version2 = $"v{version.Major}.{version.Minor}.{version.Build}";
		ICLRRuntimeInfo iCLRRuntimeInfo = (ICLRRuntimeInfo)obj.GetRuntime(version2, ref IID_CLRRuntimeInfo);
		iCLRRuntimeInfo.IsStarted(out var started, out var _);
		if (!started)
		{
			throw new COMException("CLR not started??");
		}
		ICorRuntimeHost V2Host = (ICorRuntimeHost)iCLRRuntimeInfo.GetInterface(ref CLSID_CorRuntimeHost, ref IID_CorRuntimeHost);
		V2Host.EnumDomains(out var hDomainEnum);
		while (true)
		{
			_AppDomain domain = null;
			V2Host.NextDomain(hDomainEnum, out domain);
			if (domain == null)
			{
				break;
			}
			yield return domain;
		}
		V2Host.CloseEnum(hDomainEnum);
	}

	[DllImport("mscoree.dll")]
	private static extern int CLRCreateInstance(ref Guid clsid, ref Guid iid, [MarshalAs(UnmanagedType.Interface)] out object ptr);
}
