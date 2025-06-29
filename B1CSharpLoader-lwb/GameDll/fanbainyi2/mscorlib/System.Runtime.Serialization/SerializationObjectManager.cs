using System.Collections;
using System.Security;

namespace System.Runtime.Serialization;

public sealed class SerializationObjectManager
{
	private Hashtable m_objectSeenTable = new Hashtable();

	private SerializationEventHandler m_onSerializedHandler;

	private StreamingContext m_context;

	public SerializationObjectManager(StreamingContext context)
	{
		m_context = context;
		m_objectSeenTable = new Hashtable();
	}

	[SecurityCritical]
	public void RegisterObject(object obj)
	{
		SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
		if (serializationEventsForType.HasOnSerializingEvents && m_objectSeenTable[obj] == null)
		{
			m_objectSeenTable[obj] = true;
			serializationEventsForType.InvokeOnSerializing(obj, m_context);
			AddOnSerialized(obj);
		}
	}

	public void RaiseOnSerializedEvent()
	{
		if (m_onSerializedHandler != null)
		{
			m_onSerializedHandler(m_context);
		}
	}

	[SecuritySafeCritical]
	private void AddOnSerialized(object obj)
	{
		SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
		m_onSerializedHandler = serializationEventsForType.AddOnSerialized(obj, m_onSerializedHandler);
	}
}
