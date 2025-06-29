using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

public class SteepActorsData
{
	private UObject WorldContext;

	public int HuluID;

	private TStrongObjectPtr<AActor> HuluPreviewCon = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> HuluPreview = new TStrongObjectPtr<AActor>();

	public int LiquorID;

	private TStrongObjectPtr<AActor> LiquorPreviewCon = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> LiquorPreview = new TStrongObjectPtr<AActor>();

	public int Consume1ID;

	private TStrongObjectPtr<AActor> Consume1PreviewCon = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> Consume1Preview = new TStrongObjectPtr<AActor>();

	public int Consume2ID;

	private TStrongObjectPtr<AActor> Consume2PreviewCon = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> Consume2Preview = new TStrongObjectPtr<AActor>();

	public int Consume3ID;

	private TStrongObjectPtr<AActor> Consume3PreviewCon = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> Consume3Preview = new TStrongObjectPtr<AActor>();

	public int Consume4ID;

	private TStrongObjectPtr<AActor> Consume4PreviewCon = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> Consume4Preview = new TStrongObjectPtr<AActor>();

	private void ResetHuluPreview()
	{
		if (HuluPreview.IsValid())
		{
			HuluPreview.Get().SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(HuluPreview.Get());
			HuluPreview.Set(null);
		}
		HuluID = 0;
		CheckNeedGC();
	}

	public void ChangeHuluPreview(UObject WorldContext, int ItemID)
	{
		if (ItemID != HuluID && HuluPreviewCon.IsValid())
		{
			ResetHuluPreview();
			HuluID = ItemID;
			AActor itemPreview = GetItemPreview(WorldContext, ItemID, HuluPreviewCon.Get().GetActorLocation(), HuluPreviewCon.Get().GetActorRotation());
			if (itemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeHuluPreview]ItemPreview = null,ItemID = {ItemID}");
			}
			else
			{
				HuluPreview.Set(itemPreview);
			}
		}
	}

	public AActor GetHuluPreview()
	{
		if (!HuluPreview.Get().IsNullOrDestroyed())
		{
			return HuluPreview.Get();
		}
		return null;
	}

	private void ResetLiquorPreview()
	{
		if (LiquorPreview.IsValid())
		{
			LiquorPreview.Get().SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(LiquorPreview.Get());
			LiquorPreview.Set(null);
		}
		LiquorID = 0;
		CheckNeedGC();
	}

	public void ChangeLiquorPreview(UObject WorldContext, int ItemID)
	{
		if (ItemID != LiquorID && LiquorPreviewCon.IsValid())
		{
			ResetLiquorPreview();
			LiquorID = ItemID;
			AActor itemPreview = GetItemPreview(WorldContext, ItemID, LiquorPreviewCon.Get().GetActorLocation(), LiquorPreviewCon.Get().GetActorRotation());
			if (itemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeLiquorPreview]ItemPreview = null,ItemID = {ItemID}");
			}
			else
			{
				LiquorPreview.Set(itemPreview);
			}
		}
	}

	public AActor GetLiquorPreview()
	{
		if (!LiquorPreview.Get().IsNullOrDestroyed())
		{
			return LiquorPreview.Get();
		}
		return null;
	}

	private void ResetConsume1Preview()
	{
		if (Consume1Preview.IsValid())
		{
			Consume1Preview.Get().SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(Consume1Preview.Get());
			Consume1Preview.Set(null);
		}
		Consume1ID = 0;
		CheckNeedGC();
	}

	public void ChangeConsume1Preview(UObject WorldContext, int ItemID)
	{
		if (ItemID != Consume1ID && Consume1PreviewCon.IsValid())
		{
			ResetConsume1Preview();
			Consume1ID = ItemID;
			AActor itemPreview = GetItemPreview(WorldContext, ItemID, Consume1PreviewCon.Get().GetActorLocation(), Consume1PreviewCon.Get().GetActorRotation());
			if (itemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeConsume1Preview]ItemPreview = null,ItemID = {ItemID}");
			}
			else
			{
				Consume1Preview.Set(itemPreview);
			}
		}
	}

	public AActor GetConsume1Preview()
	{
		if (!Consume1Preview.Get().IsNullOrDestroyed())
		{
			return Consume1Preview.Get();
		}
		return null;
	}

	private void ResetConsume2Preview()
	{
		if (Consume2Preview.IsValid())
		{
			Consume2Preview.Get().SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(Consume2Preview.Get());
			Consume2Preview.Set(null);
		}
		Consume2ID = 0;
		CheckNeedGC();
	}

	public void ChangeConsume2Preview(UObject WorldContext, int ItemID)
	{
		if (ItemID != Consume2ID && Consume2PreviewCon.IsValid())
		{
			ResetConsume2Preview();
			Consume2ID = ItemID;
			AActor itemPreview = GetItemPreview(WorldContext, ItemID, Consume2PreviewCon.Get().GetActorLocation(), Consume2PreviewCon.Get().GetActorRotation());
			if (itemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeConsume2Preview]ItemPreview = null,ItemID = {ItemID}");
			}
			else
			{
				Consume2Preview.Set(itemPreview);
			}
		}
	}

	public AActor GetConsume2Preview()
	{
		if (!Consume2Preview.Get().IsNullOrDestroyed())
		{
			return Consume2Preview.Get();
		}
		return null;
	}

	private void ResetConsume3Preview()
	{
		if (Consume3Preview.IsValid())
		{
			Consume3Preview.Get().SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(Consume3Preview.Get());
			Consume3Preview.Set(null);
		}
		Consume3ID = 0;
		CheckNeedGC();
	}

	public void ChangeConsume3Preview(UObject WorldContext, int ItemID)
	{
		if (ItemID != Consume3ID && Consume3PreviewCon.IsValid())
		{
			ResetConsume3Preview();
			Consume3ID = ItemID;
			AActor itemPreview = GetItemPreview(WorldContext, ItemID, Consume3PreviewCon.Get().GetActorLocation(), Consume3PreviewCon.Get().GetActorRotation());
			if (itemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeConsume3Preview]ItemPreview = null,ItemID = {ItemID}");
			}
			else
			{
				Consume3Preview.Set(itemPreview);
			}
		}
	}

	public AActor GetConsume3Preview()
	{
		if (!Consume3Preview.Get().IsNullOrDestroyed())
		{
			return Consume3Preview.Get();
		}
		return null;
	}

	private void ResetConsume4Preview()
	{
		if (Consume4Preview.IsValid())
		{
			Consume4Preview.Get().SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(Consume4Preview.Get());
			Consume4Preview.Set(null);
		}
		Consume4ID = 0;
		CheckNeedGC();
	}

	public void ChangeConsume4Preview(UObject WorldContext, int ItemID)
	{
		if (ItemID != Consume4ID && Consume4PreviewCon.IsValid())
		{
			ResetConsume4Preview();
			Consume4ID = ItemID;
			AActor itemPreview = GetItemPreview(WorldContext, ItemID, Consume4PreviewCon.Get().GetActorLocation(), Consume4PreviewCon.Get().GetActorRotation());
			if (itemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeConsume4Preview]ItemPreview = null,ItemID = {ItemID}");
			}
			else
			{
				Consume4Preview.Set(itemPreview);
			}
		}
	}

	public AActor GetConsume4Preview()
	{
		if (!Consume4Preview.Get().IsNullOrDestroyed())
		{
			return Consume4Preview.Get();
		}
		return null;
	}

	public void InitCon(UObject WorldContext)
	{
		this.WorldContext = WorldContext;
		List<AActor> OutActors = new List<AActor>();
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.HuluPreviewCon, out OutActors);
		using (List<AActor>.Enumerator enumerator = OutActors.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current = enumerator.Current;
				HuluPreviewCon.Set(current);
			}
		}
		OutActors.Clear();
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.LiquorPreviewCon, out OutActors);
		using (List<AActor>.Enumerator enumerator = OutActors.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current2 = enumerator.Current;
				LiquorPreviewCon.Set(current2);
			}
		}
		OutActors.Clear();
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.ConsumePreviewCon1, out OutActors);
		using (List<AActor>.Enumerator enumerator = OutActors.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current3 = enumerator.Current;
				Consume1PreviewCon.Set(current3);
			}
		}
		OutActors.Clear();
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.ConsumePreviewCon2, out OutActors);
		using (List<AActor>.Enumerator enumerator = OutActors.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current4 = enumerator.Current;
				Consume2PreviewCon.Set(current4);
			}
		}
		OutActors.Clear();
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.ConsumePreviewCon3, out OutActors);
		using (List<AActor>.Enumerator enumerator = OutActors.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current5 = enumerator.Current;
				Consume3PreviewCon.Set(current5);
			}
		}
		OutActors.Clear();
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.ConsumePreviewCon4, out OutActors);
		using List<AActor>.Enumerator enumerator = OutActors.GetEnumerator();
		if (enumerator.MoveNext())
		{
			AActor current6 = enumerator.Current;
			Consume4PreviewCon.Set(current6);
		}
	}

	public void ResetPreview()
	{
		ResetHuluPreview();
		ResetLiquorPreview();
		ResetConsume1Preview();
		ResetConsume2Preview();
		ResetConsume3Preview();
		ResetConsume4Preview();
	}

	public void ResetAllPreview()
	{
		ResetPreview();
		HuluPreviewCon.Set(null);
		LiquorPreviewCon.Set(null);
		Consume1PreviewCon.Set(null);
		Consume2PreviewCon.Set(null);
		Consume3PreviewCon.Set(null);
		Consume4PreviewCon.Set(null);
	}

	private AActor GetItemPreview(UObject WorldContext, int ItemID, FVector Location = default(FVector), FRotator Rotation = default(FRotator))
	{
		if (WorldContext == null || ItemID == 0)
		{
			return null;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GetItemPath(ItemID), EUIResourceLoadType.NoCache);
		if (worldFromObj == null || uClass == null)
		{
			return null;
		}
		return BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass, in Location, in Rotation);
	}

	private string GetItemPath(int ItemID)
	{
		return $"/Game/00Main/Design/Blueprints/Item/WinePartnerPreview/WinePartnerPreview_{ItemID}.WinePartnerPreview_{ItemID}_C";
	}

	private void CheckNeedGC()
	{
		if (!WorldContext.IsNullOrDestroyed())
		{
			BGW_MemoryMgr.Get(WorldContext).CheckNeedGC();
		}
	}
}
