using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SceneItemData : IBUC_SceneItemData, IPersistentECSData
{
	private TStrongObjectPtr<BGUSceneItemBase> mSceneItemAttach = new TStrongObjectPtr<BGUSceneItemBase>();

	private bool HasAttach;

	private TStrongObjectPtr<BGUSceneItemBase> mSceneItemCatch = new TStrongObjectPtr<BGUSceneItemBase>();

	private bool HasCatch;

	private List<EObjectTypeQuery> DefaultSceneItemObjTypeList;

	public List<TStrongObjectPtr<AActor>> SceneItemInUse = new List<TStrongObjectPtr<AActor>>();

	public Dictionary<int, AActor> CatchedSceneItemByAM = new Dictionary<int, AActor>();

	public BGUSceneItemBase SceneItemAttach
	{
		get
		{
			return mSceneItemAttach.Get();
		}
		set
		{
			mSceneItemAttach.Set(value);
		}
	}

	public BGUSceneItemBase SceneItemCatch
	{
		get
		{
			return mSceneItemCatch.Get();
		}
		set
		{
			mSceneItemCatch.Set(value);
		}
	}

	public QueryBestLocationCondition QueryBestLocationConditionObject { get; } = new QueryBestLocationCondition();

	public AActor GetCatchedSceneItemByAMID(int AMID)
	{
		if (AMID < 0)
		{
			return null;
		}
		if (CatchedSceneItemByAM.TryGetValue(AMID, out var value))
		{
			return value;
		}
		return null;
	}

	public BUC_SceneItemData()
	{
		DefaultSceneItemObjTypeList = new List<EObjectTypeQuery>();
		DefaultSceneItemObjTypeList.Add(EObjectTypeQuery.ObjectTypeQuery2);
	}

	public void Init()
	{
		SceneItemAttach = null;
		SceneItemCatch = null;
		HasAttach = false;
		HasCatch = false;
	}

	public bool TryAddSceneItemForCatch(BGUSceneItemBase SIForCatch)
	{
		bool result = false;
		if (SceneItemAttach == null && SceneItemCatch == null)
		{
			SceneItemCatch = SIForCatch;
			result = true;
			HasCatch = true;
		}
		return result;
	}

	public bool TryAttachSceneItem()
	{
		bool result = false;
		if (SceneItemCatch != null && SceneItemAttach == null)
		{
			SceneItemAttach = SceneItemCatch;
			SceneItemCatch = null;
			result = true;
			HasAttach = true;
		}
		return result;
	}

	public bool HasSceneItem()
	{
		bool result = false;
		if (SceneItemAttach != null && HasAttach)
		{
			result = true;
		}
		return result;
	}

	public bool HasSceneItemCatch()
	{
		bool result = false;
		if (SceneItemCatch != null && HasCatch)
		{
			result = true;
		}
		return result;
	}

	public BGUSceneItemBase RemoveAttachSceneItem()
	{
		BGUSceneItemBase result = null;
		if (SceneItemAttach != null)
		{
			result = SceneItemAttach;
			SceneItemAttach = null;
			HasAttach = false;
		}
		return result;
	}

	public BGUSceneItemBase RemoveSceneItemCatch()
	{
		BGUSceneItemBase result = null;
		if (SceneItemCatch != null)
		{
			result = SceneItemCatch;
			SceneItemCatch = null;
			HasCatch = false;
		}
		return result;
	}

	public List<EObjectTypeQuery> GetDefaultSceneItemObjTypeList()
	{
		return DefaultSceneItemObjTypeList;
	}
}
