using System.Collections;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class SmuggledMethodCallMessage : MessageSmuggler
{
	private string _uri;

	private string _methodName;

	private string _typeName;

	private object[] _args;

	private byte[] _serializedArgs;

	private SerializedArg _methodSignature;

	private SerializedArg _instantiation;

	private object _callContext;

	private int _propertyCount;

	internal string Uri => _uri;

	internal string MethodName => _methodName;

	internal string TypeName => _typeName;

	internal int MessagePropertyCount => _propertyCount;

	[SecurityCritical]
	internal static SmuggledMethodCallMessage SmuggleIfPossible(IMessage msg)
	{
		if (!(msg is IMethodCallMessage mcm))
		{
			return null;
		}
		return new SmuggledMethodCallMessage(mcm);
	}

	private SmuggledMethodCallMessage()
	{
	}

	[SecurityCritical]
	private SmuggledMethodCallMessage(IMethodCallMessage mcm)
	{
		_uri = mcm.Uri;
		_methodName = mcm.MethodName;
		_typeName = mcm.TypeName;
		ArrayList argsToSerialize = null;
		if (!(mcm is IInternalMessage internalMessage) || internalMessage.HasProperties())
		{
			_propertyCount = MessageSmuggler.StoreUserPropertiesForMethodMessage(mcm, ref argsToSerialize);
		}
		if (mcm.MethodBase.IsGenericMethod)
		{
			Type[] genericArguments = mcm.MethodBase.GetGenericArguments();
			if (genericArguments != null && genericArguments.Length != 0)
			{
				if (argsToSerialize == null)
				{
					argsToSerialize = new ArrayList();
				}
				_instantiation = new SerializedArg(argsToSerialize.Count);
				argsToSerialize.Add(genericArguments);
			}
		}
		if (RemotingServices.IsMethodOverloaded(mcm))
		{
			if (argsToSerialize == null)
			{
				argsToSerialize = new ArrayList();
			}
			_methodSignature = new SerializedArg(argsToSerialize.Count);
			argsToSerialize.Add(mcm.MethodSignature);
		}
		LogicalCallContext logicalCallContext = mcm.LogicalCallContext;
		if (logicalCallContext == null)
		{
			_callContext = null;
		}
		else if (logicalCallContext.HasInfo)
		{
			if (argsToSerialize == null)
			{
				argsToSerialize = new ArrayList();
			}
			_callContext = new SerializedArg(argsToSerialize.Count);
			argsToSerialize.Add(logicalCallContext);
		}
		else
		{
			_callContext = logicalCallContext.RemotingData.LogicalCallID;
		}
		_args = MessageSmuggler.FixupArgs(mcm.Args, ref argsToSerialize);
		if (argsToSerialize != null)
		{
			MemoryStream memoryStream = CrossAppDomainSerializer.SerializeMessageParts(argsToSerialize);
			_serializedArgs = memoryStream.GetBuffer();
		}
	}

	[SecurityCritical]
	internal ArrayList FixupForNewAppDomain()
	{
		ArrayList result = null;
		if (_serializedArgs != null)
		{
			result = CrossAppDomainSerializer.DeserializeMessageParts(new MemoryStream(_serializedArgs));
			_serializedArgs = null;
		}
		return result;
	}

	internal Type[] GetInstantiation(ArrayList deserializedArgs)
	{
		if (_instantiation != null)
		{
			return (Type[])deserializedArgs[_instantiation.Index];
		}
		return null;
	}

	internal object[] GetMethodSignature(ArrayList deserializedArgs)
	{
		if (_methodSignature != null)
		{
			return (object[])deserializedArgs[_methodSignature.Index];
		}
		return null;
	}

	[SecurityCritical]
	internal object[] GetArgs(ArrayList deserializedArgs)
	{
		return MessageSmuggler.UndoFixupArgs(_args, deserializedArgs);
	}

	[SecurityCritical]
	internal LogicalCallContext GetCallContext(ArrayList deserializedArgs)
	{
		if (_callContext == null)
		{
			return null;
		}
		if (_callContext is string)
		{
			LogicalCallContext logicalCallContext = new LogicalCallContext();
			logicalCallContext.RemotingData.LogicalCallID = (string)_callContext;
			return logicalCallContext;
		}
		return (LogicalCallContext)deserializedArgs[((SerializedArg)_callContext).Index];
	}

	internal void PopulateMessageProperties(IDictionary dict, ArrayList deserializedArgs)
	{
		for (int i = 0; i < _propertyCount; i++)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)deserializedArgs[i];
			dict[dictionaryEntry.Key] = dictionaryEntry.Value;
		}
	}
}
