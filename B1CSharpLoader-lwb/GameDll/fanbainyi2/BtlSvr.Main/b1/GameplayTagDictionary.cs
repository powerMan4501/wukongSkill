using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

public class GameplayTagDictionary<T> : Dictionary<FName, T>
{
	public T this[FGameplayTag Tag]
	{
		get
		{
			return GetValue(Tag);
		}
		set
		{
			base[Tag.TagName] = value;
		}
	}

	public bool ContainsTag(FGameplayTag Tag)
	{
		return this.Any((KeyValuePair<FName, T> p) => GameplayTagExtension.IsTagName(p.Key, Tag));
	}

	public T GetValue(FGameplayTag Tag)
	{
		return base[Tag.TagName];
	}

	public void Add(FGameplayTag Tag, T Value)
	{
		Add(Tag.TagName, Value);
	}
}
