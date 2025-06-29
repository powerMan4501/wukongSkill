using ResB1;

namespace b1.UI;

public struct FItemWithTag
{
	public ItemOne ItemData;

	public EItemTag ItemTag;

	public FItemWithTag(ItemOne _ItemData, EItemTag _ItemTag)
	{
		ItemData = _ItemData;
		ItemTag = _ItemTag;
	}
}
