using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_Exception))]
[ComVisible(true)]
[__DynamicallyInvokable]
public class Exception : ISerializable, _Exception
{
	[Serializable]
	internal class __RestrictedErrorObject
	{
		[NonSerialized]
		private object _realErrorObject;

		public object RealErrorObject => _realErrorObject;

		internal __RestrictedErrorObject(object errorObject)
		{
			_realErrorObject = errorObject;
		}
	}

	internal enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted,
		OutOfMemory
	}

	[OptionalField]
	private static object s_EDILock = new object();

	private string _className;

	private MethodBase _exceptionMethod;

	private string _exceptionMethodString;

	internal string _message;

	private IDictionary _data;

	private Exception _innerException;

	private string _helpURL;

	private object _stackTrace;

	[OptionalField]
	private object _watsonBuckets;

	private string _stackTraceString;

	private string _remoteStackTraceString;

	private int _remoteStackIndex;

	private object _dynamicMethods;

	internal int _HResult;

	private string _source;

	private IntPtr _xptrs;

	private int _xcode;

	[OptionalField]
	private UIntPtr _ipForWatsonBuckets;

	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager;

	private const int _COMPlusExceptionCode = -532462766;

	[__DynamicallyInvokable]
	public virtual string Message
	{
		[__DynamicallyInvokable]
		get
		{
			if (_message == null)
			{
				if (_className == null)
				{
					_className = GetClassName();
				}
				return Environment.GetResourceString("Exception_WasThrown", _className);
			}
			return _message;
		}
	}

	[__DynamicallyInvokable]
	public virtual IDictionary Data
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			if (_data == null)
			{
				if (IsImmutableAgileException(this))
				{
					_data = new EmptyReadOnlyDictionaryInternal();
				}
				else
				{
					_data = new ListDictionaryInternal();
				}
			}
			return _data;
		}
	}

	[__DynamicallyInvokable]
	public Exception InnerException
	{
		[__DynamicallyInvokable]
		get
		{
			return _innerException;
		}
	}

	public MethodBase TargetSite
	{
		[SecuritySafeCritical]
		get
		{
			return GetTargetSiteInternal();
		}
	}

	[__DynamicallyInvokable]
	public virtual string StackTrace
	{
		[__DynamicallyInvokable]
		get
		{
			return GetStackTrace(needFileInfo: true);
		}
	}

	[__DynamicallyInvokable]
	public virtual string HelpLink
	{
		[__DynamicallyInvokable]
		get
		{
			return _helpURL;
		}
		[__DynamicallyInvokable]
		set
		{
			_helpURL = value;
		}
	}

	[__DynamicallyInvokable]
	public virtual string Source
	{
		[__DynamicallyInvokable]
		get
		{
			if (_source == null)
			{
				StackTrace stackTrace = new StackTrace(this, fNeedFileInfo: true);
				if (stackTrace.FrameCount > 0)
				{
					StackFrame frame = stackTrace.GetFrame(0);
					MethodBase method = frame.GetMethod();
					Module module = method.Module;
					RuntimeModule runtimeModule = module as RuntimeModule;
					if (runtimeModule == null)
					{
						ModuleBuilder moduleBuilder = module as ModuleBuilder;
						if (!(moduleBuilder != null))
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeReflectionObject"));
						}
						runtimeModule = moduleBuilder.InternalModule;
					}
					_source = runtimeModule.GetRuntimeAssembly().GetSimpleName();
				}
			}
			return _source;
		}
		[__DynamicallyInvokable]
		set
		{
			_source = value;
		}
	}

	internal UIntPtr IPForWatsonBuckets => _ipForWatsonBuckets;

	internal object WatsonBuckets => _watsonBuckets;

	internal string RemoteStackTrace => _remoteStackTraceString;

	[__DynamicallyInvokable]
	public int HResult
	{
		[__DynamicallyInvokable]
		get
		{
			return _HResult;
		}
		[__DynamicallyInvokable]
		protected set
		{
			_HResult = value;
		}
	}

	internal bool IsTransient
	{
		[SecuritySafeCritical]
		get
		{
			return nIsTransient(_HResult);
		}
	}

	protected event EventHandler<SafeSerializationEventArgs> SerializeObjectState
	{
		add
		{
			_safeSerializationManager.SerializeObjectState += value;
		}
		remove
		{
			_safeSerializationManager.SerializeObjectState -= value;
		}
	}

	private void Init()
	{
		_message = null;
		_stackTrace = null;
		_dynamicMethods = null;
		HResult = -2146233088;
		_xcode = -532462766;
		_xptrs = (IntPtr)0;
		_watsonBuckets = null;
		_ipForWatsonBuckets = UIntPtr.Zero;
		_safeSerializationManager = new SafeSerializationManager();
	}

	[__DynamicallyInvokable]
	public Exception()
	{
		Init();
	}

	[__DynamicallyInvokable]
	public Exception(string message)
	{
		Init();
		_message = message;
	}

	[__DynamicallyInvokable]
	public Exception(string message, Exception innerException)
	{
		Init();
		_message = message;
		_innerException = innerException;
	}

	[SecuritySafeCritical]
	protected Exception(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		_className = info.GetString("ClassName");
		_message = info.GetString("Message");
		_data = (IDictionary)info.GetValueNoThrow("Data", typeof(IDictionary));
		_innerException = (Exception)info.GetValue("InnerException", typeof(Exception));
		_helpURL = info.GetString("HelpURL");
		_stackTraceString = info.GetString("StackTraceString");
		_remoteStackTraceString = info.GetString("RemoteStackTraceString");
		_remoteStackIndex = info.GetInt32("RemoteStackIndex");
		_exceptionMethodString = (string)info.GetValue("ExceptionMethod", typeof(string));
		HResult = info.GetInt32("HResult");
		_source = info.GetString("Source");
		_watsonBuckets = info.GetValueNoThrow("WatsonBuckets", typeof(byte[]));
		_safeSerializationManager = info.GetValueNoThrow("SafeSerializationManager", typeof(SafeSerializationManager)) as SafeSerializationManager;
		if (_className == null || HResult == 0)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
		}
		if (context.State == StreamingContextStates.CrossAppDomain)
		{
			_remoteStackTraceString += _stackTraceString;
			_stackTraceString = null;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsImmutableAgileException(Exception e);

	[FriendAccessAllowed]
	internal void AddExceptionDataForRestrictedErrorInfo(string restrictedError, string restrictedErrorReference, string restrictedCapabilitySid, object restrictedErrorObject, bool hasrestrictedLanguageErrorObject = false)
	{
		IDictionary data = Data;
		if (data != null)
		{
			data.Add("RestrictedDescription", restrictedError);
			data.Add("RestrictedErrorReference", restrictedErrorReference);
			data.Add("RestrictedCapabilitySid", restrictedCapabilitySid);
			data.Add("__RestrictedErrorObject", (restrictedErrorObject == null) ? null : new __RestrictedErrorObject(restrictedErrorObject));
			data.Add("__HasRestrictedLanguageErrorObject", hasrestrictedLanguageErrorObject);
		}
	}

	internal bool TryGetRestrictedLanguageErrorObject(out object restrictedErrorObject)
	{
		restrictedErrorObject = null;
		if (Data != null && Data.Contains("__HasRestrictedLanguageErrorObject"))
		{
			if (Data.Contains("__RestrictedErrorObject") && Data["__RestrictedErrorObject"] is __RestrictedErrorObject _RestrictedErrorObject)
			{
				restrictedErrorObject = _RestrictedErrorObject.RealErrorObject;
			}
			return (bool)Data["__HasRestrictedLanguageErrorObject"];
		}
		return false;
	}

	private string GetClassName()
	{
		if (_className == null)
		{
			_className = GetType().ToString();
		}
		return _className;
	}

	[__DynamicallyInvokable]
	public virtual Exception GetBaseException()
	{
		Exception innerException = InnerException;
		Exception result = this;
		while (innerException != null)
		{
			result = innerException;
			innerException = innerException.InnerException;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern IRuntimeMethodInfo GetMethodFromStackTrace(object stackTrace);

	[SecuritySafeCritical]
	private MethodBase GetExceptionMethodFromStackTrace()
	{
		IRuntimeMethodInfo methodFromStackTrace = GetMethodFromStackTrace(_stackTrace);
		if (methodFromStackTrace == null)
		{
			return null;
		}
		return RuntimeType.GetMethodBase(methodFromStackTrace);
	}

	[SecurityCritical]
	private MethodBase GetTargetSiteInternal()
	{
		if (_exceptionMethod != null)
		{
			return _exceptionMethod;
		}
		if (_stackTrace == null)
		{
			return null;
		}
		if (_exceptionMethodString != null)
		{
			_exceptionMethod = GetExceptionMethodFromString();
		}
		else
		{
			_exceptionMethod = GetExceptionMethodFromStackTrace();
		}
		return _exceptionMethod;
	}

	private string GetStackTrace(bool needFileInfo)
	{
		string text = _stackTraceString;
		string text2 = _remoteStackTraceString;
		if (!needFileInfo)
		{
			text = StripFileInfo(text, isRemoteStackTrace: false);
			text2 = StripFileInfo(text2, isRemoteStackTrace: true);
		}
		if (text != null)
		{
			return text2 + text;
		}
		if (_stackTrace == null)
		{
			return text2;
		}
		string stackTrace = Environment.GetStackTrace(this, needFileInfo);
		return text2 + stackTrace;
	}

	[FriendAccessAllowed]
	internal void SetErrorCode(int hr)
	{
		HResult = hr;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return ToString(needFileLineInfo: true, needMessage: true);
	}

	private string ToString(bool needFileLineInfo, bool needMessage)
	{
		string text = (needMessage ? Message : null);
		string text2 = ((text != null && text.Length > 0) ? (GetClassName() + ": " + text) : GetClassName());
		if (_innerException != null)
		{
			text2 = text2 + " ---> " + _innerException.ToString(needFileLineInfo, needMessage) + Environment.NewLine + "   " + Environment.GetResourceString("Exception_EndOfInnerExceptionStack");
		}
		string stackTrace = GetStackTrace(needFileLineInfo);
		if (stackTrace != null)
		{
			text2 = text2 + Environment.NewLine + stackTrace;
		}
		return text2;
	}

	[SecurityCritical]
	private string GetExceptionMethodString()
	{
		MethodBase targetSiteInternal = GetTargetSiteInternal();
		if (targetSiteInternal == null)
		{
			return null;
		}
		if (targetSiteInternal is DynamicMethod.RTDynamicMethod)
		{
			return null;
		}
		char value = '\n';
		StringBuilder stringBuilder = new StringBuilder();
		if (targetSiteInternal is ConstructorInfo)
		{
			RuntimeConstructorInfo runtimeConstructorInfo = (RuntimeConstructorInfo)targetSiteInternal;
			Type reflectedType = runtimeConstructorInfo.ReflectedType;
			stringBuilder.Append(1);
			stringBuilder.Append(value);
			stringBuilder.Append(runtimeConstructorInfo.Name);
			if (reflectedType != null)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(reflectedType.Assembly.FullName);
				stringBuilder.Append(value);
				stringBuilder.Append(reflectedType.FullName);
			}
			stringBuilder.Append(value);
			stringBuilder.Append(runtimeConstructorInfo.ToString());
		}
		else
		{
			RuntimeMethodInfo runtimeMethodInfo = (RuntimeMethodInfo)targetSiteInternal;
			Type declaringType = runtimeMethodInfo.DeclaringType;
			stringBuilder.Append(8);
			stringBuilder.Append(value);
			stringBuilder.Append(runtimeMethodInfo.Name);
			stringBuilder.Append(value);
			stringBuilder.Append(runtimeMethodInfo.Module.Assembly.FullName);
			stringBuilder.Append(value);
			if (declaringType != null)
			{
				stringBuilder.Append(declaringType.FullName);
				stringBuilder.Append(value);
			}
			stringBuilder.Append(runtimeMethodInfo.ToString());
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	private MethodBase GetExceptionMethodFromString()
	{
		string[] array = _exceptionMethodString.Split('\0', '\n');
		if (array.Length != 5)
		{
			throw new SerializationException();
		}
		SerializationInfo serializationInfo = new SerializationInfo(typeof(MemberInfoSerializationHolder), new FormatterConverter());
		serializationInfo.AddValue("MemberType", int.Parse(array[0], CultureInfo.InvariantCulture), typeof(int));
		serializationInfo.AddValue("Name", array[1], typeof(string));
		serializationInfo.AddValue("AssemblyName", array[2], typeof(string));
		serializationInfo.AddValue("ClassName", array[3]);
		serializationInfo.AddValue("Signature", array[4]);
		StreamingContext context = new StreamingContext(StreamingContextStates.All);
		try
		{
			return (MethodBase)new MemberInfoSerializationHolder(serializationInfo, context).GetRealObject(context);
		}
		catch (SerializationException)
		{
			return null;
		}
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		string text = _stackTraceString;
		if (_stackTrace != null)
		{
			if (text == null)
			{
				text = Environment.GetStackTrace(this, needFileInfo: true);
			}
			if (_exceptionMethod == null)
			{
				_exceptionMethod = GetExceptionMethodFromStackTrace();
			}
		}
		if (_source == null)
		{
			_source = Source;
		}
		info.AddValue("ClassName", GetClassName(), typeof(string));
		info.AddValue("Message", _message, typeof(string));
		info.AddValue("Data", _data, typeof(IDictionary));
		info.AddValue("InnerException", _innerException, typeof(Exception));
		info.AddValue("HelpURL", _helpURL, typeof(string));
		info.AddValue("StackTraceString", text, typeof(string));
		info.AddValue("RemoteStackTraceString", _remoteStackTraceString, typeof(string));
		info.AddValue("RemoteStackIndex", _remoteStackIndex, typeof(int));
		info.AddValue("ExceptionMethod", GetExceptionMethodString(), typeof(string));
		info.AddValue("HResult", HResult);
		info.AddValue("Source", _source, typeof(string));
		info.AddValue("WatsonBuckets", _watsonBuckets, typeof(byte[]));
		if (_safeSerializationManager != null && _safeSerializationManager.IsActive)
		{
			info.AddValue("SafeSerializationManager", _safeSerializationManager, typeof(SafeSerializationManager));
			_safeSerializationManager.CompleteSerialization(this, info, context);
		}
	}

	internal Exception PrepForRemoting()
	{
		string text = null;
		text = ((_remoteStackIndex != 0) ? (StackTrace + Environment.NewLine + Environment.NewLine + "Exception rethrown at [" + _remoteStackIndex + "]: " + Environment.NewLine) : (Environment.NewLine + "Server stack trace: " + Environment.NewLine + StackTrace + Environment.NewLine + Environment.NewLine + "Exception rethrown at [" + _remoteStackIndex + "]: " + Environment.NewLine));
		_remoteStackTraceString = text;
		_remoteStackIndex++;
		return this;
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		_stackTrace = null;
		_ipForWatsonBuckets = UIntPtr.Zero;
		if (_safeSerializationManager == null)
		{
			_safeSerializationManager = new SafeSerializationManager();
		}
		else
		{
			_safeSerializationManager.CompleteDeserialization(this);
		}
	}

	internal void InternalPreserveStackTrace()
	{
		string stackTrace;
		if (AppDomain.IsAppXModel())
		{
			stackTrace = GetStackTrace(needFileInfo: true);
			string source = Source;
		}
		else
		{
			stackTrace = StackTrace;
		}
		if (stackTrace != null && stackTrace.Length > 0)
		{
			_remoteStackTraceString = stackTrace + Environment.NewLine;
		}
		_stackTrace = null;
		_stackTraceString = null;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void PrepareForForeignExceptionRaise();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void GetStackTracesDeepCopy(Exception exception, out object currentStackTrace, out object dynamicMethodArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void SaveStackTracesFromDeepCopy(Exception exception, object currentStackTrace, object dynamicMethodArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object CopyStackTrace(object currentStackTrace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object CopyDynamicMethods(object currentDynamicMethods);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern string StripFileInfo(string stackTrace, bool isRemoteStackTrace);

	[SecuritySafeCritical]
	internal object DeepCopyStackTrace(object currentStackTrace)
	{
		if (currentStackTrace != null)
		{
			return CopyStackTrace(currentStackTrace);
		}
		return null;
	}

	[SecuritySafeCritical]
	internal object DeepCopyDynamicMethods(object currentDynamicMethods)
	{
		if (currentDynamicMethods != null)
		{
			return CopyDynamicMethods(currentDynamicMethods);
		}
		return null;
	}

	[SecuritySafeCritical]
	internal void GetStackTracesDeepCopy(out object currentStackTrace, out object dynamicMethodArray)
	{
		GetStackTracesDeepCopy(this, out currentStackTrace, out dynamicMethodArray);
	}

	[SecuritySafeCritical]
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
	{
		if (IsImmutableAgileException(this))
		{
			return;
		}
		try
		{
		}
		finally
		{
			object currentStackTrace = ((exceptionDispatchInfo.BinaryStackTraceArray == null) ? null : DeepCopyStackTrace(exceptionDispatchInfo.BinaryStackTraceArray));
			object dynamicMethodArray = ((exceptionDispatchInfo.DynamicMethodArray == null) ? null : DeepCopyDynamicMethods(exceptionDispatchInfo.DynamicMethodArray));
			lock (s_EDILock)
			{
				_watsonBuckets = exceptionDispatchInfo.WatsonBuckets;
				_ipForWatsonBuckets = exceptionDispatchInfo.IPForWatsonBuckets;
				_remoteStackTraceString = exceptionDispatchInfo.RemoteStackTrace;
				SaveStackTracesFromDeepCopy(this, currentStackTrace, dynamicMethodArray);
			}
			_stackTraceString = null;
			PrepareForForeignExceptionRaise();
		}
	}

	[SecurityCritical]
	internal virtual string InternalToString()
	{
		try
		{
			SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy);
			securityPermission.Assert();
		}
		catch
		{
		}
		bool flag = true;
		return ToString(flag, needMessage: true);
	}

	[__DynamicallyInvokable]
	public new Type GetType()
	{
		return base.GetType();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool nIsTransient(int hr);

	[SecuritySafeCritical]
	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind)
	{
		string s = null;
		GetMessageFromNativeResources(kind, JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetMessageFromNativeResources(ExceptionMessageKind kind, StringHandleOnStack retMesg);
}
