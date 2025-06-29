using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics;

[Serializable]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
public class StackFrame
{
	private MethodBase method;

	private int offset;

	private int ILOffset;

	private string strFileName;

	private int iLineNumber;

	private int iColumnNumber;

	[OptionalField]
	private bool fIsLastFrameFromForeignExceptionStackTrace;

	public const int OFFSET_UNKNOWN = -1;

	internal void InitMembers()
	{
		method = null;
		offset = -1;
		ILOffset = -1;
		strFileName = null;
		iLineNumber = 0;
		iColumnNumber = 0;
		fIsLastFrameFromForeignExceptionStackTrace = false;
	}

	public StackFrame()
	{
		InitMembers();
		BuildStackFrame(0, fNeedFileInfo: false);
	}

	public StackFrame(bool fNeedFileInfo)
	{
		InitMembers();
		BuildStackFrame(0, fNeedFileInfo);
	}

	public StackFrame(int skipFrames)
	{
		InitMembers();
		BuildStackFrame(skipFrames, fNeedFileInfo: false);
	}

	public StackFrame(int skipFrames, bool fNeedFileInfo)
	{
		InitMembers();
		BuildStackFrame(skipFrames, fNeedFileInfo);
	}

	internal StackFrame(bool DummyFlag1, bool DummyFlag2)
	{
		InitMembers();
	}

	public StackFrame(string fileName, int lineNumber)
	{
		InitMembers();
		BuildStackFrame(0, fNeedFileInfo: false);
		strFileName = fileName;
		iLineNumber = lineNumber;
		iColumnNumber = 0;
	}

	public StackFrame(string fileName, int lineNumber, int colNumber)
	{
		InitMembers();
		BuildStackFrame(0, fNeedFileInfo: false);
		strFileName = fileName;
		iLineNumber = lineNumber;
		iColumnNumber = colNumber;
	}

	internal virtual void SetMethodBase(MethodBase mb)
	{
		method = mb;
	}

	internal virtual void SetOffset(int iOffset)
	{
		offset = iOffset;
	}

	internal virtual void SetILOffset(int iOffset)
	{
		ILOffset = iOffset;
	}

	internal virtual void SetFileName(string strFName)
	{
		strFileName = strFName;
	}

	internal virtual void SetLineNumber(int iLine)
	{
		iLineNumber = iLine;
	}

	internal virtual void SetColumnNumber(int iCol)
	{
		iColumnNumber = iCol;
	}

	internal virtual void SetIsLastFrameFromForeignExceptionStackTrace(bool fIsLastFrame)
	{
		fIsLastFrameFromForeignExceptionStackTrace = fIsLastFrame;
	}

	internal virtual bool GetIsLastFrameFromForeignExceptionStackTrace()
	{
		return fIsLastFrameFromForeignExceptionStackTrace;
	}

	public virtual MethodBase GetMethod()
	{
		return method;
	}

	public virtual int GetNativeOffset()
	{
		return offset;
	}

	public virtual int GetILOffset()
	{
		return ILOffset;
	}

	[SecuritySafeCritical]
	public virtual string GetFileName()
	{
		if (strFileName != null)
		{
			FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
			fileIOPermission.AllFiles = FileIOPermissionAccess.PathDiscovery;
			fileIOPermission.Demand();
		}
		return strFileName;
	}

	public virtual int GetFileLineNumber()
	{
		return iLineNumber;
	}

	public virtual int GetFileColumnNumber()
	{
		return iColumnNumber;
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		if (method != null)
		{
			stringBuilder.Append(method.Name);
			if (method is MethodInfo && ((MethodInfo)method).IsGenericMethod)
			{
				Type[] genericArguments = ((MethodInfo)method).GetGenericArguments();
				stringBuilder.Append("<");
				int i = 0;
				bool flag = true;
				for (; i < genericArguments.Length; i++)
				{
					if (!flag)
					{
						stringBuilder.Append(",");
					}
					else
					{
						flag = false;
					}
					stringBuilder.Append(genericArguments[i].Name);
				}
				stringBuilder.Append(">");
			}
			stringBuilder.Append(" at offset ");
			if (offset == -1)
			{
				stringBuilder.Append("<offset unknown>");
			}
			else
			{
				stringBuilder.Append(offset);
			}
			stringBuilder.Append(" in file:line:column ");
			bool flag2 = strFileName != null;
			if (flag2)
			{
				try
				{
					FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
					fileIOPermission.AllFiles = FileIOPermissionAccess.PathDiscovery;
					fileIOPermission.Demand();
				}
				catch (SecurityException)
				{
					flag2 = false;
				}
			}
			if (!flag2)
			{
				stringBuilder.Append("<filename unknown>");
			}
			else
			{
				stringBuilder.Append(strFileName);
			}
			stringBuilder.Append(":");
			stringBuilder.Append(iLineNumber);
			stringBuilder.Append(":");
			stringBuilder.Append(iColumnNumber);
		}
		else
		{
			stringBuilder.Append("<null>");
		}
		stringBuilder.Append(Environment.NewLine);
		return stringBuilder.ToString();
	}

	private void BuildStackFrame(int skipFrames, bool fNeedFileInfo)
	{
		using StackFrameHelper stackFrameHelper = new StackFrameHelper(null);
		stackFrameHelper.InitializeSourceInfo(0, fNeedFileInfo, null);
		int numberOfFrames = stackFrameHelper.GetNumberOfFrames();
		skipFrames += StackTrace.CalculateFramesToSkip(stackFrameHelper, numberOfFrames);
		if (numberOfFrames - skipFrames > 0)
		{
			method = stackFrameHelper.GetMethodBase(skipFrames);
			offset = stackFrameHelper.GetOffset(skipFrames);
			ILOffset = stackFrameHelper.GetILOffset(skipFrames);
			if (fNeedFileInfo)
			{
				strFileName = stackFrameHelper.GetFilename(skipFrames);
				iLineNumber = stackFrameHelper.GetLineNumber(skipFrames);
				iColumnNumber = stackFrameHelper.GetColumnNumber(skipFrames);
			}
		}
	}
}
