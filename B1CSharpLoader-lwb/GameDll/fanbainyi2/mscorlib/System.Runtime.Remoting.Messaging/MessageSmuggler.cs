using System.Collections;
using System.Runtime.Remoting.Proxies;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class MessageSmuggler
{
	protected class SerializedArg
	{
		private int _index;

		public int Index => _index;

		public SerializedArg(int index)
		{
			_index = index;
		}
	}

	private static bool CanSmuggleObjectDirectly(object obj)
	{
		if (obj is string || obj.GetType() == typeof(void) || obj.GetType().IsPrimitive)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	protected static object[] FixupArgs(object[] args, ref ArrayList argsToSerialize)
	{
		object[] array = new object[args.Length];
		int num = args.Length;
		for (int i = 0; i < num; i++)
		{
			array[i] = FixupArg(args[i], ref argsToSerialize);
		}
		return array;
	}

	[SecurityCritical]
	protected static object FixupArg(object arg, ref ArrayList argsToSerialize)
	{
		if (arg == null)
		{
			return null;
		}
		int count;
		if (arg is MarshalByRefObject marshalByRefObject)
		{
			if (!RemotingServices.IsTransparentProxy(marshalByRefObject) || RemotingServices.GetRealProxy(marshalByRefObject) is RemotingProxy)
			{
				ObjRef objRef = RemotingServices.MarshalInternal(marshalByRefObject, null, null);
				if (objRef.CanSmuggle())
				{
					if (!RemotingServices.IsTransparentProxy(marshalByRefObject))
					{
						ServerIdentity serverIdentity = (ServerIdentity)MarshalByRefObject.GetIdentity(marshalByRefObject);
						serverIdentity.SetHandle();
						objRef.SetServerIdentity(serverIdentity.GetHandle());
						objRef.SetDomainID(AppDomain.CurrentDomain.GetId());
					}
					ObjRef objRef2 = objRef.CreateSmuggleableCopy();
					objRef2.SetMarshaledObject();
					return new SmuggledObjRef(objRef2);
				}
			}
			if (argsToSerialize == null)
			{
				argsToSerialize = new ArrayList();
			}
			count = argsToSerialize.Count;
			argsToSerialize.Add(arg);
			return new SerializedArg(count);
		}
		if (CanSmuggleObjectDirectly(arg))
		{
			return arg;
		}
		if (arg is Array array)
		{
			Type elementType = array.GetType().GetElementType();
			if (elementType.IsPrimitive || elementType == typeof(string))
			{
				return array.Clone();
			}
		}
		if (argsToSerialize == null)
		{
			argsToSerialize = new ArrayList();
		}
		count = argsToSerialize.Count;
		argsToSerialize.Add(arg);
		return new SerializedArg(count);
	}

	[SecurityCritical]
	protected static object[] UndoFixupArgs(object[] args, ArrayList deserializedArgs)
	{
		object[] array = new object[args.Length];
		int num = args.Length;
		for (int i = 0; i < num; i++)
		{
			array[i] = UndoFixupArg(args[i], deserializedArgs);
		}
		return array;
	}

	[SecurityCritical]
	protected static object UndoFixupArg(object arg, ArrayList deserializedArgs)
	{
		if (arg is SmuggledObjRef smuggledObjRef)
		{
			return smuggledObjRef.ObjRef.GetRealObjectHelper();
		}
		if (arg is SerializedArg serializedArg)
		{
			return deserializedArgs[serializedArg.Index];
		}
		return arg;
	}

	[SecurityCritical]
	protected static int StoreUserPropertiesForMethodMessage(IMethodMessage msg, ref ArrayList argsToSerialize)
	{
		IDictionary properties = msg.Properties;
		if (properties is MessageDictionary messageDictionary)
		{
			if (messageDictionary.HasUserData())
			{
				int num = 0;
				{
					foreach (DictionaryEntry item in messageDictionary.InternalDictionary)
					{
						if (argsToSerialize == null)
						{
							argsToSerialize = new ArrayList();
						}
						argsToSerialize.Add(item);
						num++;
					}
					return num;
				}
			}
			return 0;
		}
		int num2 = 0;
		foreach (DictionaryEntry item2 in properties)
		{
			if (argsToSerialize == null)
			{
				argsToSerialize = new ArrayList();
			}
			argsToSerialize.Add(item2);
			num2++;
		}
		return num2;
	}
}
