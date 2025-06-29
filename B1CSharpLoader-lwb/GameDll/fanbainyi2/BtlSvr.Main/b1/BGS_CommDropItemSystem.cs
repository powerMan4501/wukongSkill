using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BGS_CommDropItemSystem : GameModeSystemBase
{
	public List<SimpleDropItem> SimpDroppingItems = new List<SimpleDropItem>();

	public List<BUC_DropItemData> DroppingItems = new List<BUC_DropItemData>();

	private List<b1.FNeedSpawnDropItem> NeedSpawnAwardList = new List<b1.FNeedSpawnDropItem>();

	private float SpawnTimer;

	private float DelayTimer;

	private BGS_GSEventCollection BGE;

	public override void OnAttach()
	{
		base.OnAttach();
		BGE = GetGameEventCollection();
		_ = BGE != null;
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		_ = BGE != null;
	}

	public List<SimpleDropItem> GetCurSimpDroppingItems()
	{
		return SimpDroppingItems;
	}

	public List<BUC_DropItemData> GetCurDroppingItems()
	{
		return DroppingItems;
	}
}
