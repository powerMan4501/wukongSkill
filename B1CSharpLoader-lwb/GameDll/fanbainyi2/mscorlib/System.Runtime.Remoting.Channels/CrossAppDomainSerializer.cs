using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;

namespace System.Runtime.Remoting.Channels;

internal static class CrossAppDomainSerializer
{
	[SecurityCritical]
	internal static MemoryStream SerializeMessage(IMessage msg)
	{
		MemoryStream memoryStream = new MemoryStream();
		RemotingSurrogateSelector surrogateSelector = new RemotingSurrogateSelector();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.SurrogateSelector = surrogateSelector;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
		binaryFormatter.Serialize(memoryStream, msg, null, fCheck: false);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	[SecurityCritical]
	internal static MemoryStream SerializeMessageParts(ArrayList argsToSerialize)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		RemotingSurrogateSelector surrogateSelector = new RemotingSurrogateSelector();
		binaryFormatter.SurrogateSelector = surrogateSelector;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
		binaryFormatter.Serialize(memoryStream, argsToSerialize, null, fCheck: false);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	[SecurityCritical]
	internal static void SerializeObject(object obj, MemoryStream stm)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		RemotingSurrogateSelector surrogateSelector = new RemotingSurrogateSelector();
		binaryFormatter.SurrogateSelector = surrogateSelector;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
		binaryFormatter.Serialize(stm, obj, null, fCheck: false);
	}

	[SecurityCritical]
	internal static MemoryStream SerializeObject(object obj)
	{
		MemoryStream memoryStream = new MemoryStream();
		SerializeObject(obj, memoryStream);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	[SecurityCritical]
	internal static IMessage DeserializeMessage(MemoryStream stm)
	{
		return DeserializeMessage(stm, null);
	}

	[SecurityCritical]
	internal static IMessage DeserializeMessage(MemoryStream stm, IMethodCallMessage reqMsg)
	{
		if (stm == null)
		{
			throw new ArgumentNullException("stm");
		}
		stm.Position = 0L;
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.SurrogateSelector = null;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
		return (IMessage)binaryFormatter.Deserialize(stm, null, fCheck: false, isCrossAppDomain: true, reqMsg);
	}

	[SecurityCritical]
	internal static ArrayList DeserializeMessageParts(MemoryStream stm)
	{
		return (ArrayList)DeserializeObject(stm);
	}

	[SecurityCritical]
	internal static object DeserializeObject(MemoryStream stm)
	{
		stm.Position = 0L;
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
		return binaryFormatter.Deserialize(stm, null, fCheck: false, isCrossAppDomain: true, null);
	}
}
