using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System.Diagnostics;

[Serializable]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
public class StackTrace
{
	internal enum TraceFormat
	{
		Normal,
		TrailingNewLine,
		NoResourceLookup
	}

	private StackFrame[] frames;

	private int m_iNumOfFrames;

	public const int METHODS_TO_SKIP = 0;

	private int m_iMethodsToSkip;

	public virtual int FrameCount => m_iNumOfFrames;

	public StackTrace()
	{
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(0, fNeedFileInfo: false, null, null);
	}

	public StackTrace(bool fNeedFileInfo)
	{
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(0, fNeedFileInfo, null, null);
	}

	public StackTrace(int skipFrames)
	{
		if (skipFrames < 0)
		{
			throw new ArgumentOutOfRangeException("skipFrames", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(skipFrames, fNeedFileInfo: false, null, null);
	}

	public StackTrace(int skipFrames, bool fNeedFileInfo)
	{
		if (skipFrames < 0)
		{
			throw new ArgumentOutOfRangeException("skipFrames", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(skipFrames, fNeedFileInfo, null, null);
	}

	public StackTrace(Exception e)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(0, fNeedFileInfo: false, null, e);
	}

	public StackTrace(Exception e, bool fNeedFileInfo)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(0, fNeedFileInfo, null, e);
	}

	public StackTrace(Exception e, int skipFrames)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		if (skipFrames < 0)
		{
			throw new ArgumentOutOfRangeException("skipFrames", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(skipFrames, fNeedFileInfo: false, null, e);
	}

	public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		if (skipFrames < 0)
		{
			throw new ArgumentOutOfRangeException("skipFrames", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(skipFrames, fNeedFileInfo, null, e);
	}

	public StackTrace(StackFrame frame)
	{
		frames = new StackFrame[1];
		frames[0] = frame;
		m_iMethodsToSkip = 0;
		m_iNumOfFrames = 1;
	}

	[Obsolete("This constructor has been deprecated.  Please use a constructor that does not require a Thread parameter.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public StackTrace(Thread targetThread, bool needFileInfo)
	{
		m_iNumOfFrames = 0;
		m_iMethodsToSkip = 0;
		CaptureStackTrace(0, needFileInfo, targetThread, null);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern void GetStackFramesInternal(StackFrameHelper sfh, int iSkip, bool fNeedFileInfo, Exception e);

	internal static int CalculateFramesToSkip(StackFrameHelper StackF, int iNumFrames)
	{
		int num = 0;
		string strB = "System.Diagnostics";
		for (int i = 0; i < iNumFrames; i++)
		{
			MethodBase methodBase = StackF.GetMethodBase(i);
			if (methodBase != null)
			{
				Type declaringType = methodBase.DeclaringType;
				if (declaringType == null)
				{
					break;
				}
				string text = declaringType.Namespace;
				if (text == null || string.Compare(text, strB, StringComparison.Ordinal) != 0)
				{
					break;
				}
			}
			num++;
		}
		return num;
	}

	private void CaptureStackTrace(int iSkip, bool fNeedFileInfo, Thread targetThread, Exception e)
	{
		m_iMethodsToSkip += iSkip;
		using StackFrameHelper stackFrameHelper = new StackFrameHelper(targetThread);
		stackFrameHelper.InitializeSourceInfo(0, fNeedFileInfo, e);
		m_iNumOfFrames = stackFrameHelper.GetNumberOfFrames();
		if (m_iMethodsToSkip > m_iNumOfFrames)
		{
			m_iMethodsToSkip = m_iNumOfFrames;
		}
		if (m_iNumOfFrames != 0)
		{
			frames = new StackFrame[m_iNumOfFrames];
			for (int i = 0; i < m_iNumOfFrames; i++)
			{
				bool dummyFlag = true;
				bool dummyFlag2 = true;
				StackFrame stackFrame = new StackFrame(dummyFlag, dummyFlag2);
				stackFrame.SetMethodBase(stackFrameHelper.GetMethodBase(i));
				stackFrame.SetOffset(stackFrameHelper.GetOffset(i));
				stackFrame.SetILOffset(stackFrameHelper.GetILOffset(i));
				stackFrame.SetIsLastFrameFromForeignExceptionStackTrace(stackFrameHelper.IsLastFrameFromForeignExceptionStackTrace(i));
				if (fNeedFileInfo)
				{
					stackFrame.SetFileName(stackFrameHelper.GetFilename(i));
					stackFrame.SetLineNumber(stackFrameHelper.GetLineNumber(i));
					stackFrame.SetColumnNumber(stackFrameHelper.GetColumnNumber(i));
				}
				frames[i] = stackFrame;
			}
			if (e == null)
			{
				m_iMethodsToSkip += CalculateFramesToSkip(stackFrameHelper, m_iNumOfFrames);
			}
			m_iNumOfFrames -= m_iMethodsToSkip;
			if (m_iNumOfFrames < 0)
			{
				m_iNumOfFrames = 0;
			}
		}
		else
		{
			frames = null;
		}
	}

	public virtual StackFrame GetFrame(int index)
	{
		if (frames != null && index < m_iNumOfFrames && index >= 0)
		{
			return frames[index + m_iMethodsToSkip];
		}
		return null;
	}

	[ComVisible(false)]
	public virtual StackFrame[] GetFrames()
	{
		if (frames == null || m_iNumOfFrames <= 0)
		{
			return null;
		}
		StackFrame[] array = new StackFrame[m_iNumOfFrames];
		Array.Copy(frames, m_iMethodsToSkip, array, 0, m_iNumOfFrames);
		return array;
	}

	public override string ToString()
	{
		return ToString(TraceFormat.TrailingNewLine);
	}

	internal string ToString(TraceFormat traceFormat)
	{
		bool flag = true;
		string arg = "at";
		string format = "in {0}:line {1}";
		if (traceFormat != TraceFormat.NoResourceLookup)
		{
			arg = Environment.GetResourceString("Word_At");
			format = Environment.GetResourceString("StackTrace_InFileLineNumber");
		}
		bool flag2 = true;
		StringBuilder stringBuilder = new StringBuilder(255);
		for (int i = 0; i < m_iNumOfFrames; i++)
		{
			StackFrame frame = GetFrame(i);
			MethodBase method = frame.GetMethod();
			if (!(method != null))
			{
				continue;
			}
			if (flag2)
			{
				flag2 = false;
			}
			else
			{
				stringBuilder.Append(Environment.NewLine);
			}
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "   {0} ", arg);
			Type declaringType = method.DeclaringType;
			if (declaringType != null)
			{
				stringBuilder.Append(declaringType.FullName.Replace('+', '.'));
				stringBuilder.Append(".");
			}
			stringBuilder.Append(method.Name);
			if (method is MethodInfo && ((MethodInfo)method).IsGenericMethod)
			{
				Type[] genericArguments = ((MethodInfo)method).GetGenericArguments();
				stringBuilder.Append("[");
				int j = 0;
				bool flag3 = true;
				for (; j < genericArguments.Length; j++)
				{
					if (!flag3)
					{
						stringBuilder.Append(",");
					}
					else
					{
						flag3 = false;
					}
					stringBuilder.Append(genericArguments[j].Name);
				}
				stringBuilder.Append("]");
			}
			stringBuilder.Append("(");
			ParameterInfo[] parameters = method.GetParameters();
			bool flag4 = true;
			for (int k = 0; k < parameters.Length; k++)
			{
				if (!flag4)
				{
					stringBuilder.Append(", ");
				}
				else
				{
					flag4 = false;
				}
				string text = "<UnknownType>";
				if (parameters[k].ParameterType != null)
				{
					text = parameters[k].ParameterType.Name;
				}
				stringBuilder.Append(text + " " + parameters[k].Name);
			}
			stringBuilder.Append(")");
			if (flag && frame.GetILOffset() != -1)
			{
				string text2 = null;
				try
				{
					text2 = frame.GetFileName();
				}
				catch (NotSupportedException)
				{
					flag = false;
				}
				catch (SecurityException)
				{
					flag = false;
				}
				if (text2 != null)
				{
					stringBuilder.Append(' ');
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, format, text2, frame.GetFileLineNumber());
				}
			}
			if (frame.GetIsLastFrameFromForeignExceptionStackTrace())
			{
				stringBuilder.Append(Environment.NewLine);
				stringBuilder.Append(Environment.GetResourceString("Exception_EndStackTraceFromPreviousThrow"));
			}
		}
		if (traceFormat == TraceFormat.TrailingNewLine)
		{
			stringBuilder.Append(Environment.NewLine);
		}
		return stringBuilder.ToString();
	}

	private static string GetManagedStackTraceStringHelper(bool fNeedFileInfo)
	{
		StackTrace stackTrace = new StackTrace(0, fNeedFileInfo);
		return stackTrace.ToString();
	}
}
