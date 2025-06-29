using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Diagnostics;

[Serializable]
internal class StackFrameHelper : IDisposable
{
	private delegate void GetSourceLineInfoDelegate(string assemblyPath, IntPtr loadedPeAddress, int loadedPeSize, IntPtr inMemoryPdbAddress, int inMemoryPdbSize, int methodToken, int ilOffset, out string sourceFile, out int sourceLine, out int sourceColumn);

	[NonSerialized]
	private Thread targetThread;

	private int[] rgiOffset;

	private int[] rgiILOffset;

	private MethodBase[] rgMethodBase;

	private object dynamicMethods;

	[NonSerialized]
	private IntPtr[] rgMethodHandle;

	private string[] rgAssemblyPath;

	private IntPtr[] rgLoadedPeAddress;

	private int[] rgiLoadedPeSize;

	private IntPtr[] rgInMemoryPdbAddress;

	private int[] rgiInMemoryPdbSize;

	private int[] rgiMethodToken;

	private string[] rgFilename;

	private int[] rgiLineNumber;

	private int[] rgiColumnNumber;

	[OptionalField]
	private bool[] rgiLastFrameFromForeignExceptionStackTrace;

	private int iFrameCount;

	private static GetSourceLineInfoDelegate s_getSourceLineInfo;

	[ThreadStatic]
	private static int t_reentrancy;

	public StackFrameHelper(Thread target)
	{
		targetThread = target;
		rgMethodBase = null;
		rgMethodHandle = null;
		rgiMethodToken = null;
		rgiOffset = null;
		rgiILOffset = null;
		rgAssemblyPath = null;
		rgLoadedPeAddress = null;
		rgiLoadedPeSize = null;
		rgInMemoryPdbAddress = null;
		rgiInMemoryPdbSize = null;
		dynamicMethods = null;
		rgFilename = null;
		rgiLineNumber = null;
		rgiColumnNumber = null;
		rgiLastFrameFromForeignExceptionStackTrace = null;
		iFrameCount = 0;
	}

	[SecuritySafeCritical]
	internal void InitializeSourceInfo(int iSkip, bool fNeedFileInfo, Exception exception)
	{
		StackTrace.GetStackFramesInternal(this, iSkip, fNeedFileInfo, exception);
		if (!fNeedFileInfo || !RuntimeFeature.IsSupported("PortablePdb") || t_reentrancy > 0)
		{
			return;
		}
		t_reentrancy++;
		try
		{
			if (!CodeAccessSecurityEngine.QuickCheckForAllDemands())
			{
				new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
			}
			if (s_getSourceLineInfo == null)
			{
				Type type = Type.GetType("System.Diagnostics.StackTraceSymbols, System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", throwOnError: false);
				if (type == null)
				{
					return;
				}
				MethodInfo method = type.GetMethod("GetSourceLineInfoWithoutCasAssert", new Type[10]
				{
					typeof(string),
					typeof(IntPtr),
					typeof(int),
					typeof(IntPtr),
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(string).MakeByRefType(),
					typeof(int).MakeByRefType(),
					typeof(int).MakeByRefType()
				});
				if (method == null)
				{
					method = type.GetMethod("GetSourceLineInfo", new Type[10]
					{
						typeof(string),
						typeof(IntPtr),
						typeof(int),
						typeof(IntPtr),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(string).MakeByRefType(),
						typeof(int).MakeByRefType(),
						typeof(int).MakeByRefType()
					});
				}
				if (method == null)
				{
					return;
				}
				object target = Activator.CreateInstance(type);
				GetSourceLineInfoDelegate value = (GetSourceLineInfoDelegate)method.CreateDelegate(typeof(GetSourceLineInfoDelegate), target);
				Interlocked.CompareExchange(ref s_getSourceLineInfo, value, null);
			}
			for (int i = 0; i < iFrameCount; i++)
			{
				if (rgiMethodToken[i] != 0)
				{
					s_getSourceLineInfo(rgAssemblyPath[i], rgLoadedPeAddress[i], rgiLoadedPeSize[i], rgInMemoryPdbAddress[i], rgiInMemoryPdbSize[i], rgiMethodToken[i], rgiILOffset[i], out rgFilename[i], out rgiLineNumber[i], out rgiColumnNumber[i]);
				}
			}
		}
		catch
		{
		}
		finally
		{
			t_reentrancy--;
		}
	}

	void IDisposable.Dispose()
	{
	}

	[SecuritySafeCritical]
	public virtual MethodBase GetMethodBase(int i)
	{
		IntPtr methodHandleValue = rgMethodHandle[i];
		if (methodHandleValue.IsNull())
		{
			return null;
		}
		IRuntimeMethodInfo typicalMethodDefinition = RuntimeMethodHandle.GetTypicalMethodDefinition(new RuntimeMethodInfoStub(methodHandleValue, this));
		return RuntimeType.GetMethodBase(typicalMethodDefinition);
	}

	public virtual int GetOffset(int i)
	{
		return rgiOffset[i];
	}

	public virtual int GetILOffset(int i)
	{
		return rgiILOffset[i];
	}

	public virtual string GetFilename(int i)
	{
		if (rgFilename != null)
		{
			return rgFilename[i];
		}
		return null;
	}

	public virtual int GetLineNumber(int i)
	{
		if (rgiLineNumber != null)
		{
			return rgiLineNumber[i];
		}
		return 0;
	}

	public virtual int GetColumnNumber(int i)
	{
		if (rgiColumnNumber != null)
		{
			return rgiColumnNumber[i];
		}
		return 0;
	}

	public virtual bool IsLastFrameFromForeignExceptionStackTrace(int i)
	{
		if (rgiLastFrameFromForeignExceptionStackTrace != null)
		{
			return rgiLastFrameFromForeignExceptionStackTrace[i];
		}
		return false;
	}

	public virtual int GetNumberOfFrames()
	{
		return iFrameCount;
	}

	public virtual void SetNumberOfFrames(int i)
	{
		iFrameCount = i;
	}

	[OnSerializing]
	[SecuritySafeCritical]
	private void OnSerializing(StreamingContext context)
	{
		rgMethodBase = ((rgMethodHandle == null) ? null : new MethodBase[rgMethodHandle.Length]);
		if (rgMethodHandle == null)
		{
			return;
		}
		for (int i = 0; i < rgMethodHandle.Length; i++)
		{
			if (!rgMethodHandle[i].IsNull())
			{
				rgMethodBase[i] = RuntimeType.GetMethodBase(new RuntimeMethodInfoStub(rgMethodHandle[i], this));
			}
		}
	}

	[OnSerialized]
	private void OnSerialized(StreamingContext context)
	{
		rgMethodBase = null;
	}

	[OnDeserialized]
	[SecuritySafeCritical]
	private void OnDeserialized(StreamingContext context)
	{
		rgMethodHandle = ((rgMethodBase == null) ? null : new IntPtr[rgMethodBase.Length]);
		if (rgMethodBase != null)
		{
			for (int i = 0; i < rgMethodBase.Length; i++)
			{
				if (rgMethodBase[i] != null)
				{
					rgMethodHandle[i] = rgMethodBase[i].MethodHandle.Value;
				}
			}
		}
		rgMethodBase = null;
	}
}
