using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class FileNotFoundException : IOException
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
	public FileNotFoundException()
		: base(Environment.GetResourceString("IO.FileNotFound"))
	{
		SetErrorCode(-2147024894);
	}

	[__DynamicallyInvokable]
	public FileNotFoundException(string message)
		: base(message)
	{
		SetErrorCode(-2147024894);
	}

	[__DynamicallyInvokable]
	public FileNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024894);
	}

	[__DynamicallyInvokable]
	public FileNotFoundException(string message, string fileName)
		: base(message)
	{
		SetErrorCode(-2147024894);
		_fileName = fileName;
	}

	[__DynamicallyInvokable]
	public FileNotFoundException(string message, string fileName, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024894);
		_fileName = fileName;
	}

	private void SetMessageField()
	{
		if (_message == null)
		{
			if (_fileName == null && base.HResult == -2146233088)
			{
				_message = Environment.GetResourceString("IO.FileNotFound");
			}
			else if (_fileName != null)
			{
				_message = FileLoadException.FormatFileLoadExceptionMessage(_fileName, base.HResult);
			}
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

	protected FileNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_fileName = info.GetString("FileNotFound_FileName");
		try
		{
			_fusionLog = info.GetString("FileNotFound_FusionLog");
		}
		catch
		{
			_fusionLog = null;
		}
	}

	private FileNotFoundException(string fileName, string fusionLog, int hResult)
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
		info.AddValue("FileNotFound_FileName", _fileName, typeof(string));
		try
		{
			info.AddValue("FileNotFound_FusionLog", FusionLog, typeof(string));
		}
		catch (SecurityException)
		{
		}
	}
}
