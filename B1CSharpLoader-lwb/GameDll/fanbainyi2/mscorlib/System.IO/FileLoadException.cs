using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class FileLoadException : IOException
{
	private string _fileName;

	private string _fusionLog;

	[__DynamicallyInvokable]
	public override string Message
	{
		[__DynamicallyInvokable]
		get
		{
			SetMessageField();
			return _message;
		}
	}

	[__DynamicallyInvokable]
	public string FileName
	{
		[__DynamicallyInvokable]
		get
		{
			return _fileName;
		}
	}

	public string FusionLog
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = (SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy))]
		get
		{
			return _fusionLog;
		}
	}

	[__DynamicallyInvokable]
	public FileLoadException()
		: base(Environment.GetResourceString("IO.FileLoad"))
	{
		SetErrorCode(-2146232799);
	}

	[__DynamicallyInvokable]
	public FileLoadException(string message)
		: base(message)
	{
		SetErrorCode(-2146232799);
	}

	[__DynamicallyInvokable]
	public FileLoadException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146232799);
	}

	[__DynamicallyInvokable]
	public FileLoadException(string message, string fileName)
		: base(message)
	{
		SetErrorCode(-2146232799);
		_fileName = fileName;
	}

	[__DynamicallyInvokable]
	public FileLoadException(string message, string fileName, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146232799);
		_fileName = fileName;
	}

	private void SetMessageField()
	{
		if (_message == null)
		{
			_message = FormatFileLoadExceptionMessage(_fileName, base.HResult);
		}
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		string text = GetType().FullName + ": " + Message;
		if (_fileName != null && _fileName.Length != 0)
		{
			text = text + Environment.NewLine + Environment.GetResourceString("IO.FileName_Name", _fileName);
		}
		if (base.InnerException != null)
		{
			text = text + " ---> " + base.InnerException.ToString();
		}
		if (StackTrace != null)
		{
			text = text + Environment.NewLine + StackTrace;
		}
		try
		{
			if (FusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text += Environment.NewLine;
				text += Environment.NewLine;
				text += FusionLog;
			}
		}
		catch (SecurityException)
		{
		}
		return text;
	}

	protected FileLoadException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_fileName = info.GetString("FileLoad_FileName");
		try
		{
			_fusionLog = info.GetString("FileLoad_FusionLog");
		}
		catch
		{
			_fusionLog = null;
		}
	}

	private FileLoadException(string fileName, string fusionLog, int hResult)
		: base(null)
	{
		SetErrorCode(hResult);
		_fileName = fileName;
		_fusionLog = fusionLog;
		SetMessageField();
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("FileLoad_FileName", _fileName, typeof(string));
		try
		{
			info.AddValue("FileLoad_FusionLog", FusionLog, typeof(string));
		}
		catch (SecurityException)
		{
		}
	}

	[SecuritySafeCritical]
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
	{
		string s = null;
		GetFileLoadExceptionMessage(hResult, JitHelpers.GetStringHandleOnStack(ref s));
		string s2 = null;
		GetMessageForHR(hResult, JitHelpers.GetStringHandleOnStack(ref s2));
		return string.Format(CultureInfo.CurrentCulture, s, fileName, s2);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetFileLoadExceptionMessage(int hResult, StringHandleOnStack retString);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetMessageForHR(int hresult, StringHandleOnStack retString);
}
