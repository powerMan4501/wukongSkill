using ResB1;

namespace b1.UI;

public struct FDropItem
{
	public ItemOne Item;

	public EItemTag Tag;

	public FDropItem(int InItemId, int InItemNum, EItemTag InItemTag)
	{
		Item = new ItemOne
		{
			Id = InItemId,
			Num = InItemNum
		};
		Tag = InItemTag;
	}

	public FDropItem(ItemOne InItem, EItemTag InItemTag)
	{
		Item = InItem;
		Tag = InItemTag;
	}

	public FDropItem(ItemOne InItem, bool IsInStore)
	{
		Item = InItem;
		Tag = ((!IsInStore) ? EItemTag.BAG : EItemTag.WAREHOUSE);
	}
}
