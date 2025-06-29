using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[SecurityCritical]
[CLSCompliant(false)]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, ISerializationRootObject, IInternalMessage
{
	private MethodBase MI;

	private string methodName;

	private Type[] methodSignature;

	private string uri;

	private string typeName;

	private object retVal;

	private Exception fault;

	private object[] outArgs;

	private LogicalCallContext callContext;

	protected IDictionary InternalProperties;

	protected IDictionary ExternalProperties;

	private int argCount;

	private bool fSoap;

	private ArgMapper argMapper;

	private RemotingMethodCachedData _methodCache;

	public string Uri
	{
		[SecurityCritical]
		get
		{
			return uri;
		}
		set
		{
			uri = value;
		}
	}

	public string MethodName
	{
		[SecurityCritical]
		get
		{
			return methodName;
		}
	}

	public string TypeName
	{
		[SecurityCritical]
		get
		{
			return typeName;
		}
	}

	public object MethodSignature
	{
		[SecurityCritical]
		get
		{
			return methodSignature;
		}
	}

	public MethodBase MethodBase
	{
		[SecurityCritical]
		get
		{
			return MI;
		}
	}

	public bool HasVarArgs
	{
		[SecurityCritical]
		get
		{
			return false;
		}
	}

	public int ArgCount
	{
		[SecurityCritical]
		get
		{
			if (outArgs == null)
			{
				return 0;
			}
			return outArgs.Length;
		}
	}

	public object[] Args
	{
		[SecurityCritical]
		get
		{
			return outArgs;
		}
	}

	public int OutArgCount
	{
		[SecurityCritical]
		get
		{
			if (argMapper == null)
			{
				argMapper = new ArgMapper(this, fOut: true);
			}
			return argMapper.ArgCount;
		}
	}

	public object[] OutArgs
	{
		[SecurityCritical]
		get
		{
			if (argMapper == null)
			{
				argMapper = new ArgMapper(this, fOut: true);
			}
			return argMapper.Args;
		}
	}

	public Exception Exception
	{
		[SecurityCritical]
		get
		{
			return fault;
		}
	}

	public object ReturnValue
	{
		[SecurityCritical]
		get
		{
			return retVal;
		}
	}

	public virtual IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			lock (this)
			{
				if (InternalProperties == null)
				{
					InternalProperties = new Hashtable();
				}
				if (ExternalProperties == null)
				{
					ExternalProperties = new MRMDictionary(this, InternalProperties);
				}
				return ExternalProperties;
			}
		}
	}

	public LogicalCallContext LogicalCallContext
	{
		[SecurityCritical]
		get
		{
			return GetLogicalCallContext();
		}
	}

	ServerIdentity IInternalMessage.ServerIdentityObject
	{
		[SecurityCritical]
		get
		{
			return null;
		}
		[SecurityCritical]
		set
		{
		}
	}

	Identity IInternalMessage.IdentityObject
	{
		[SecurityCritical]
		get
		{
			return null;
		}
		[SecurityCritical]
		set
		{
		}
	}

	[SecurityCritical]
	public MethodResponse(Header[] h1, IMethodCallMessage mcm)
	{
		if (mcm == null)
		{
			throw new ArgumentNullException("mcm");
		}
		if (mcm is Message message)
		{
			MI = message.GetMethodBase();
		}
		else
		{
			MI = mcm.MethodBase;
		}
		if (MI == null)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Message_MethodMissing"), mcm.MethodName, mcm.TypeName));
		}
		_methodCache = InternalRemotingServices.GetReflectionCachedData(MI);
		argCount = _methodCache.Parameters.Length;
		fSoap = true;
		FillHeaders(h1);
	}

	[SecurityCritical]
	internal MethodResponse(IMethodCallMessage msg, SmuggledMethodReturnMessage smuggledMrm, ArrayList deserializedArgs)
	{
		MI = msg.MethodBase;
		_methodCache = InternalRemotingServices.GetReflectionCachedData(MI);
		methodName = msg.MethodName;
		uri = msg.Uri;
		typeName = msg.TypeName;
		if (_methodCache.IsOverloaded())
		{
			methodSignature = (Type[])msg.MethodSignature;
		}
		retVal = smuggledMrm.GetReturnValue(deserializedArgs);
		outArgs = smuggledMrm.GetArgs(deserializedArgs);
		fault = smuggledMrm.GetException(deserializedArgs);
		callContext = smuggledMrm.GetCallContext(deserializedArgs);
		if (smuggledMrm.MessagePropertyCount > 0)
		{
			smuggledMrm.PopulateMessageProperties(Properties, deserializedArgs);
		}
		argCount = _methodCache.Parameters.Length;
		fSoap = false;
	}

	[SecurityCritical]
	internal MethodResponse(IMethodCallMessage msg, object handlerObject, BinaryMethodReturnMessage smuggledMrm)
	{
		if (msg != null)
		{
			MI = msg.MethodBase;
			_methodCache = InternalRemotingServices.GetReflectionCachedData(MI);
			methodName = msg.MethodName;
			uri = msg.Uri;
			typeName = msg.TypeName;
			if (_methodCache.IsOverloaded())
			{
				methodSignature = (Type[])msg.MethodSignature;
			}
			argCount = _methodCache.Parameters.Length;
		}
		retVal = smuggledMrm.ReturnValue;
		outArgs = smuggledMrm.Args;
		fault = smuggledMrm.Exception;
		callContext = smuggledMrm.LogicalCallContext;
		if (smuggledMrm.HasProperties)
		{
			smuggledMrm.PopulateMessageProperties(Properties);
		}
		fSoap = false;
	}

	[SecurityCritical]
	internal MethodResponse(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		SetObjectData(info, context);
	}

	[SecurityCritical]
	public virtual object HeaderHandler(Header[] h)
	{
		SerializationMonkey serializationMonkey = (SerializationMonkey)FormatterServices.GetUninitializedObject(typeof(SerializationMonkey));
		Header[] array = null;
		if (h != null && h.Length != 0 && h[0].Name == "__methodName")
		{
			if (h.Length > 1)
			{
				array = new Header[h.Length - 1];
				Array.Copy(h, 1, array, 0, h.Length - 1);
			}
			else
			{
				array = null;
			}
		}
		else
		{
			array = h;
		}
		Type type = null;
		MethodInfo methodInfo = MI as MethodInfo;
		if (methodInfo != null)
		{
			type = methodInfo.ReturnType;
		}
		ParameterInfo[] parameters = _methodCache.Parameters;
		int num = _methodCache.MarshalResponseArgMap.Length;
		if (!(type == null) && !(type == typeof(void)))
		{
			num++;
		}
		Type[] array2 = new Type[num];
		string[] array3 = new string[num];
		int num2 = 0;
		if (!(type == null) && !(type == typeof(void)))
		{
			array2[num2++] = type;
		}
		int[] marshalResponseArgMap = _methodCache.MarshalResponseArgMap;
		foreach (int num3 in marshalResponseArgMap)
		{
			array3[num2] = parameters[num3].Name;
			if (parameters[num3].ParameterType.IsByRef)
			{
				array2[num2++] = parameters[num3].ParameterType.GetElementType();
			}
			else
			{
				array2[num2++] = parameters[num3].ParameterType;
			}
		}
		((IFieldInfo)serializationMonkey).FieldTypes = array2;
		((IFieldInfo)serializationMonkey).FieldNames = array3;
		FillHeaders(array, bFromHeaderHandler: true);
		serializationMonkey._obj = this;
		return serializationMonkey;
	}

	[SecurityCritical]
	public void RootSetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		SetObjectData(info, ctx);
	}

	[SecurityCritical]
	internal void SetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (fSoap)
		{
			SetObjectFromSoapData(info);
			return;
		}
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		bool flag = false;
		bool flag2 = false;
		while (enumerator.MoveNext())
		{
			if (enumerator.Name.Equals("__return"))
			{
				flag = true;
				break;
			}
			if (enumerator.Name.Equals("__fault"))
			{
				flag2 = true;
				fault = (Exception)enumerator.Value;
				break;
			}
			FillHeader(enumerator.Name, enumerator.Value);
		}
		if (!(flag2 && flag))
		{
			return;
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadSerialization"));
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Method"));
	}

	internal void SetObjectFromSoapData(SerializationInfo info)
	{
		Hashtable keyToNamespaceTable = (Hashtable)info.GetValue("__keyToNamespaceTable", typeof(Hashtable));
		ArrayList arrayList = (ArrayList)info.GetValue("__paramNameList", typeof(ArrayList));
		SoapFault soapFault = (SoapFault)info.GetValue("__fault", typeof(SoapFault));
		if (soapFault != null)
		{
			if (soapFault.Detail is ServerFault serverFault)
			{
				if (serverFault.Exception != null)
				{
					fault = serverFault.Exception;
					return;
				}
				Type type = Type.GetType(serverFault.ExceptionType, throwOnError: false, ignoreCase: false);
				if (type == null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("\nException Type: ");
					stringBuilder.Append(serverFault.ExceptionType);
					stringBuilder.Append("\n");
					stringBuilder.Append("Exception Message: ");
					stringBuilder.Append(serverFault.ExceptionMessage);
					stringBuilder.Append("\n");
					stringBuilder.Append(serverFault.StackTrace);
					fault = new ServerException(stringBuilder.ToString());
				}
				else
				{
					object[] args = new object[1] { serverFault.ExceptionMessage };
					fault = (Exception)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, args, null, null);
				}
			}
			else if (soapFault.Detail != null && soapFault.Detail.GetType() == typeof(string) && ((string)soapFault.Detail).Length != 0)
			{
				fault = new ServerException((string)soapFault.Detail);
			}
			else
			{
				fault = new ServerException(soapFault.FaultString);
			}
			return;
		}
		MethodInfo methodInfo = MI as MethodInfo;
		int num = 0;
		if (methodInfo != null)
		{
			Type returnType = methodInfo.ReturnType;
			if (returnType != typeof(void))
			{
				num++;
				object value = info.GetValue((string)arrayList[0], typeof(object));
				if (value is string)
				{
					retVal = Message.SoapCoerceArg(value, returnType, keyToNamespaceTable);
				}
				else
				{
					retVal = value;
				}
			}
		}
		ParameterInfo[] parameters = _methodCache.Parameters;
		object obj = ((InternalProperties == null) ? null : InternalProperties["__UnorderedParams"]);
		if (obj != null && obj is bool && (bool)obj)
		{
			for (int i = num; i < arrayList.Count; i++)
			{
				string text = (string)arrayList[i];
				int num2 = -1;
				for (int j = 0; j < parameters.Length; j++)
				{
					if (text.Equals(parameters[j].Name))
					{
						num2 = parameters[j].Position;
					}
				}
				if (num2 == -1)
				{
					if (!text.StartsWith("__param", StringComparison.Ordinal))
					{
						throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadSerialization"));
					}
					num2 = int.Parse(text.Substring(7), CultureInfo.InvariantCulture);
				}
				if (num2 >= argCount)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadSerialization"));
				}
				if (outArgs == null)
				{
					outArgs = new object[argCount];
				}
				outArgs[num2] = Message.SoapCoerceArg(info.GetValue(text, typeof(object)), parameters[num2].ParameterType, keyToNamespaceTable);
			}
			return;
		}
		if (argMapper == null)
		{
			argMapper = new ArgMapper(this, fOut: true);
		}
		for (int k = num; k < arrayList.Count; k++)
		{
			string name = (string)arrayList[k];
			if (outArgs == null)
			{
				outArgs = new object[argCount];
			}
			int num3 = argMapper.Map[k - num];
			outArgs[num3] = Message.SoapCoerceArg(info.GetValue(name, typeof(object)), parameters[num3].ParameterType, keyToNamespaceTable);
		}
	}

	[SecurityCritical]
	internal LogicalCallContext GetLogicalCallContext()
	{
		if (callContext == null)
		{
			callContext = new LogicalCallContext();
		}
		return callContext;
	}

	internal LogicalCallContext SetLogicalCallContext(LogicalCallContext ctx)
	{
		LogicalCallContext result = callContext;
		callContext = ctx;
		return result;
	}

	[SecurityCritical]
	public object GetArg(int argNum)
	{
		return outArgs[argNum];
	}

	[SecurityCritical]
	public string GetArgName(int index)
	{
		if (MI != null)
		{
			RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(MI);
			ParameterInfo[] parameters = reflectionCachedData.Parameters;
			if (index < 0 || index >= parameters.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return reflectionCachedData.Parameters[index].Name;
		}
		return "__param" + index;
	}

	[SecurityCritical]
	public object GetOutArg(int argNum)
	{
		if (argMapper == null)
		{
			argMapper = new ArgMapper(this, fOut: true);
		}
		return argMapper.GetArg(argNum);
	}

	[SecurityCritical]
	public string GetOutArgName(int index)
	{
		if (argMapper == null)
		{
			argMapper = new ArgMapper(this, fOut: true);
		}
		return argMapper.GetArgName(index);
	}

	[SecurityCritical]
	internal void FillHeaders(Header[] h)
	{
		FillHeaders(h, bFromHeaderHandler: false);
	}

	[SecurityCritical]
	private void FillHeaders(Header[] h, bool bFromHeaderHandler)
	{
		if (h == null)
		{
			return;
		}
		if (bFromHeaderHandler && fSoap)
		{
			foreach (Header header in h)
			{
				if (header.HeaderNamespace == "http://schemas.microsoft.com/clr/soap/messageProperties")
				{
					FillHeader(header.Name, header.Value);
					continue;
				}
				string propertyKeyForHeader = LogicalCallContext.GetPropertyKeyForHeader(header);
				FillHeader(propertyKeyForHeader, header);
			}
		}
		else
		{
			for (int j = 0; j < h.Length; j++)
			{
				FillHeader(h[j].Name, h[j].Value);
			}
		}
	}

	[SecurityCritical]
	internal void FillHeader(string name, object value)
	{
		if (name.Equals("__MethodName"))
		{
			methodName = (string)value;
		}
		else if (name.Equals("__Uri"))
		{
			uri = (string)value;
		}
		else if (name.Equals("__MethodSignature"))
		{
			methodSignature = (Type[])value;
		}
		else if (name.Equals("__TypeName"))
		{
			typeName = (string)value;
		}
		else if (name.Equals("__OutArgs"))
		{
			outArgs = (object[])value;
		}
		else if (name.Equals("__CallContext"))
		{
			if (value is string)
			{
				callContext = new LogicalCallContext();
				callContext.RemotingData.LogicalCallID = (string)value;
			}
			else
			{
				callContext = (LogicalCallContext)value;
			}
		}
		else if (name.Equals("__Return"))
		{
			retVal = value;
		}
		else
		{
			if (InternalProperties == null)
			{
				InternalProperties = new Hashtable();
			}
			InternalProperties[name] = value;
		}
	}

	[SecurityCritical]
	void IInternalMessage.SetURI(string val)
	{
		uri = val;
	}

	[SecurityCritical]
	void IInternalMessage.SetCallContext(LogicalCallContext newCallContext)
	{
		callContext = newCallContext;
	}

	[SecurityCritical]
	bool IInternalMessage.HasProperties()
	{
		if (ExternalProperties == null)
		{
			return InternalProperties != null;
		}
		return true;
	}
}
