using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class EventRegCacheContainer
{
	public IEntityComponent EntityComponent;

	public List<EventRegCache> CacheData = new List<EventRegCache>();
}
