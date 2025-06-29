using System.Collections;

namespace System.Runtime.Serialization;

internal static class SerializationEventsCache
{
	private static Hashtable cache = new Hashtable();

	internal static SerializationEvents GetSerializationEventsForType(Type t)
	{
		SerializationEvents serializationEvents;
		if ((serializationEvents = (SerializationEvents)cache[t]) == null)
		{
			lock (cache.SyncRoot)
			{
				if ((serializationEvents = (SerializationEvents)cache[t]) == null)
				{
					serializationEvents = new SerializationEvents(t);
					cache[t] = serializationEvents;
				}
			}
		}
		return serializationEvents;
	}
}
