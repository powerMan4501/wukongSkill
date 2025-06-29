using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.CodeDom.Compiler;

[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
public static class Executor
{
	private const int ProcessTimeOut = 600000;

	internal static string GetRuntimeInstallDirectory()
	{
		return RuntimeEnvironment.GetRuntimeDirectory();
	}

	private static FileStream CreateInheritedFile(string file)
	{
		return new FileStream(file, FileMode.CreateNew, FileAccess.Write, FileShare.Read | FileShare.Inheritable);
	}

	public static void ExecWait(string cmd, TempFileCollection tempFiles)
	{
		string outputName = null;
		string errorName = null;
		ExecWaitWithCapture(cmd, tempFiles, ref outputName, ref errorName);
	}

	public static int ExecWaitWithCapture(string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName)
	{
		return ExecWaitWithCapture(null, cmd, Environment.CurrentDirectory, tempFiles, ref outputName, ref errorName, null);
	}

	public static int ExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName)
	{
		return ExecWaitWithCapture(null, cmd, currentDir, tempFiles, ref outputName, ref errorName, null);
	}

	public static int ExecWaitWithCapture(IntPtr userToken, string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName)
	{
		return ExecWaitWithCapture(new SafeUserTokenHandle(userToken, ownsHandle: false), cmd, Environment.CurrentDirectory, tempFiles, ref outputName, ref errorName, null);
	}

	public static int ExecWaitWithCapture(IntPtr userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName)
	{
		return ExecWaitWithCapture(new SafeUserTokenHandle(userToken, ownsHandle: false), cmd, Environment.CurrentDirectory, tempFiles, ref outputName, ref errorName, null);
	}

	internal static int ExecWaitWithCapture(SafeUserTokenHandle userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName, string trueCmdLine)
	{
		int num = 0;
		try
		{
			WindowsImpersonationContext impersonation = RevertImpersonation();
			try
			{
				return ExecWaitWithCaptureUnimpersonated(userToken, cmd, currentDir, tempFiles, ref outputName, ref errorName, trueCmdLine);
			}
			finally
			{
				ReImpersonate(impersonation);
			}
		}
		catch
		{
			throw;
		}
	}

	private unsafe static int ExecWaitWithCaptureUnimpersonated(SafeUserTokenHandle userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName, string trueCmdLine)
	{
		IntSecurity.UnmanagedCode.Demand();
		int num = 0;
		if (outputName == null || outputName.Length == 0)
		{
			outputName = tempFiles.AddExtension("out");
		}
		if (errorName == null || errorName.Length == 0)
		{
			errorName = tempFiles.AddExtension("err");
		}
		FileStream fileStream = CreateInheritedFile(outputName);
		FileStream fileStream2 = CreateInheritedFile(errorName);
		bool flag = false;
		Microsoft.Win32.SafeNativeMethods.PROCESS_INFORMATION pROCESS_INFORMATION = new Microsoft.Win32.SafeNativeMethods.PROCESS_INFORMATION();
		SafeProcessHandle safeProcessHandle = new SafeProcessHandle();
		SafeThreadHandle safeThreadHandle = new SafeThreadHandle();
		SafeUserTokenHandle hNewToken = null;
		try
		{
			StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
			streamWriter.Write(currentDir);
			streamWriter.Write("> ");
			streamWriter.WriteLine((trueCmdLine != null) ? trueCmdLine : cmd);
			streamWriter.WriteLine();
			streamWriter.WriteLine();
			streamWriter.Flush();
			Microsoft.Win32.NativeMethods.STARTUPINFO sTARTUPINFO = new Microsoft.Win32.NativeMethods.STARTUPINFO();
			sTARTUPINFO.cb = Marshal.SizeOf((object)sTARTUPINFO);
			sTARTUPINFO.dwFlags = 257;
			sTARTUPINFO.wShowWindow = 0;
			sTARTUPINFO.hStdOutput = fileStream.SafeFileHandle;
			sTARTUPINFO.hStdError = fileStream2.SafeFileHandle;
			sTARTUPINFO.hStdInput = new SafeFileHandle(Microsoft.Win32.UnsafeNativeMethods.GetStdHandle(-10), ownsHandle: false);
			StringDictionary stringDictionary = new StringDictionary();
			foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
			{
				stringDictionary[(string)environmentVariable.Key] = (string)environmentVariable.Value;
			}
			stringDictionary["_ClrRestrictSecAttributes"] = "1";
			byte[] array = EnvironmentBlock.ToByteArray(stringDictionary, unicode: false);
			fixed (byte* value = array)
			{
				IntPtr intPtr = new IntPtr(value);
				if (userToken == null || userToken.IsInvalid)
				{
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
					}
					finally
					{
						flag = Microsoft.Win32.NativeMethods.CreateProcess(null, new StringBuilder(cmd), null, null, bInheritHandles: true, 0, intPtr, currentDir, sTARTUPINFO, pROCESS_INFORMATION);
						if (pROCESS_INFORMATION.hProcess != (IntPtr)0 && pROCESS_INFORMATION.hProcess != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
						{
							safeProcessHandle.InitialSetHandle(pROCESS_INFORMATION.hProcess);
						}
						if (pROCESS_INFORMATION.hThread != (IntPtr)0 && pROCESS_INFORMATION.hThread != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
						{
							safeThreadHandle.InitialSetHandle(pROCESS_INFORMATION.hThread);
						}
					}
				}
				else
				{
					flag = SafeUserTokenHandle.DuplicateTokenEx(userToken, 983551, null, 2, 1, out hNewToken);
					if (flag)
					{
						RuntimeHelpers.PrepareConstrainedRegions();
						try
						{
						}
						finally
						{
							flag = Microsoft.Win32.NativeMethods.CreateProcessAsUser(hNewToken, null, cmd, null, null, bInheritHandles: true, 0, new HandleRef(null, intPtr), currentDir, sTARTUPINFO, pROCESS_INFORMATION);
							if (pROCESS_INFORMATION.hProcess != (IntPtr)0 && pROCESS_INFORMATION.hProcess != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
							{
								safeProcessHandle.InitialSetHandle(pROCESS_INFORMATION.hProcess);
							}
							if (pROCESS_INFORMATION.hThread != (IntPtr)0 && pROCESS_INFORMATION.hThread != Microsoft.Win32.NativeMethods.INVALID_HANDLE_VALUE)
							{
								safeThreadHandle.InitialSetHandle(pROCESS_INFORMATION.hThread);
							}
						}
					}
				}
			}
		}
		finally
		{
			if (!flag && hNewToken != null && !hNewToken.IsInvalid)
			{
				hNewToken.Close();
				hNewToken = null;
			}
			fileStream.Close();
			fileStream2.Close();
		}
		if (flag)
		{
			try
			{
				ProcessWaitHandle processWaitHandle = null;
				bool flag2;
				try
				{
					processWaitHandle = new ProcessWaitHandle(safeProcessHandle);
					flag2 = processWaitHandle.WaitOne(600000, exitContext: false);
				}
				finally
				{
					processWaitHandle?.Close();
				}
				if (!flag2)
				{
					throw new ExternalException(SR.GetString("ExecTimeout", cmd), 258);
				}
				int exitCode = 259;
				if (!Microsoft.Win32.NativeMethods.GetExitCodeProcess(safeProcessHandle, out exitCode))
				{
					throw new ExternalException(SR.GetString("ExecCantGetRetCode", cmd), Marshal.GetLastWin32Error());
				}
				return exitCode;
			}
			finally
			{
				safeProcessHandle.Close();
				safeThreadHandle.Close();
				if (hNewToken != null && !hNewToken.IsInvalid)
				{
					hNewToken.Close();
				}
			}
		}
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (lastWin32Error == 8)
		{
			throw new OutOfMemoryException();
		}
		Win32Exception inner = new Win32Exception(lastWin32Error);
		ExternalException ex = new ExternalException(SR.GetString("ExecCantExec", cmd), inner);
		throw ex;
	}

	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[SecurityPermission(SecurityAction.Assert, ControlPrincipal = true, UnmanagedCode = true)]
	internal static WindowsImpersonationContext RevertImpersonation()
	{
		return WindowsIdentity.Impersonate(new IntPtr(0));
	}

	internal static void ReImpersonate(WindowsImpersonationContext impersonation)
	{
		impersonation.Undo();
	}
}
