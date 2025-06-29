using System.Collections.Generic;
using b1;
using b1.ECS;
using b1.Plugins.TressFX;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace GSDispLib;

public class BUC_DispLibUnitRendererBaseData : BUC_DispLibDataBase, IPersistentECSData
{
	public int ForceOverrideMaterialQuality = -99;

	public Dictionary<UPrimitiveComponent, List<FName>> MeshComp2TagList;

	public Dictionary<uint, List<FName>> MeshCompUniqueID2TagList;

	public Dictionary<FName, List<UPrimitiveComponent>> Tag2MeshCompList;

	internal Dictionary<uint, UMaterialInterface[]> OriginMaterialInterfaces;

	public float UnitOriginHeight { get; internal set; }

	public int UnitOriginRadius { get; internal set; }

	public UPrimitiveComponent OriginMeshComp { get; private set; }

	public AActor OriginMeshCompOwnerActor { get; private set; }

	public bool CanSetMaterialQuality { get; private set; }

	internal Dictionary<uint, MIDycInfo[]> CurMIDynamics { get; private set; }

	public float GetUnitOriginHeightFromTable()
	{
		return UnitOriginHeight;
	}

	public int GetUnitOriginRadiusFromTable()
	{
		return UnitOriginRadius;
	}

	public List<UPrimitiveComponent> GetMeshCompsByTag(FName CompTag)
	{
		if (Tag2MeshCompList.TryGetValue(CompTag, out var value))
		{
			return value;
		}
		return null;
	}

	public bool GetFirstMatchMeshComp(FName CompTag, out UPrimitiveComponent Result)
	{
		Result = null;
		if (Tag2MeshCompList.TryGetValue(CompTag, out var value))
		{
			foreach (UPrimitiveComponent item in value)
			{
				if (!item.IsNullOrDestroyed())
				{
					Result = item;
					return true;
				}
			}
		}
		return false;
	}

	public bool GetFirstMatchSkeletalMeshComp(FName CompTag, out USkeletalMeshComponent Result)
	{
		Result = null;
		if (Tag2MeshCompList.TryGetValue(CompTag, out var value))
		{
			foreach (UPrimitiveComponent item in value)
			{
				if (!item.IsNullOrDestroyed())
				{
					Result = item as USkeletalMeshComponent;
					if (!Result.IsNullOrDestroyed())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	public bool Get_One_OriginMaterialInterface(uint MeshCompID, int Idx, out UMaterialInterface OMI)
	{
		OMI = null;
		if (OriginMaterialInterfaces.TryGetValue(MeshCompID, out var value))
		{
			if (Idx < 0 || Idx >= value.Length)
			{
				return false;
			}
			OMI = value[Idx];
			return true;
		}
		return false;
	}

	public bool RemoveOMIArrayOnMeshCompRemove(uint MeshCompID)
	{
		if (OriginMaterialInterfaces.TryGetValue(MeshCompID, out var _))
		{
			OriginMaterialInterfaces.Remove(MeshCompID);
			return true;
		}
		return false;
	}

	public int GetCompCurMIDynamicsCount(uint MeshCompID)
	{
		if (CurMIDynamics.TryGetValue(MeshCompID, out var value))
		{
			if (value != null)
			{
				return value.Length;
			}
			return 0;
		}
		return 0;
	}

	public bool GetOneValidMIDycInfo(uint MeshCompID, int Idx, out MIDycInfo MIDycInfo)
	{
		MIDycInfo = null;
		if (CurMIDynamics.TryGetValue(MeshCompID, out var value))
		{
			if (Idx < 0 || value == null || Idx >= value.Length)
			{
				return false;
			}
			MIDycInfo = value[Idx];
			return MIDycInfo != null;
		}
		return false;
	}

	public bool GetOneValidMaterialInstanceDynamic(uint MeshCompID, int Idx, out UMaterialInstanceDynamic MIDyc)
	{
		MIDyc = null;
		if (CurMIDynamics.TryGetValue(MeshCompID, out var value))
		{
			if (Idx < 0 || value == null || Idx >= value.Length)
			{
				return false;
			}
			MIDyc = value[Idx].MIDyc;
			return !MIDyc.IsNullOrDestroyed();
		}
		return false;
	}

	public bool Get_One_MaterialSlotName(uint MeshCompID, int Idx, out FName SlotName)
	{
		SlotName = FName.None;
		if (CurMIDynamics.TryGetValue(MeshCompID, out var value))
		{
			if (Idx < 0 || value == null || Idx >= value.Length)
			{
				return false;
			}
			SlotName = value[Idx].SlotName;
			return true;
		}
		return false;
	}

	internal bool Init(float _UnitOriginHeight, int _UnitOriginRadius, UPrimitiveComponent _MasterComp)
	{
		if (_MasterComp.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[DBC] DispLib BUC_DispLibUnitRendererBaseData init failed. MasterComp is null");
			return false;
		}
		if (_MasterComp as UWidgetComponent != null || _MasterComp as UTressFXComponent != null)
		{
			BGW_LogUtil.LogError("[DBC] DispLib BUC_DispLibUnitRendererBaseData init failed. MasterComp is not MeshComp or SKMComp. Owner = " + _MasterComp.GetOwner()?.GetPathName());
			return false;
		}
		UnitOriginHeight = _UnitOriginHeight;
		UnitOriginRadius = _UnitOriginRadius;
		OriginMeshComp = _MasterComp;
		CanSetMaterialQuality = false;
		OriginMeshCompOwnerActor = OriginMeshComp.GetOwner();
		if (OriginMeshCompOwnerActor is BGUCharacterCS unit)
		{
			int actorResID = BGU_DataUtil.GetActorResID(unit);
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
			if (unitCommDesc != null && unitCommDesc.EnableDynamicMaterialQualitySwitch == EGSYesNo.Yes)
			{
				IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("r.EnableOverrideMaterialQualityLevel.Enemy");
				if (consoleVariable != null && consoleVariable.GetInt() > 0)
				{
					CanSetMaterialQuality = true;
				}
				else
				{
					CanSetMaterialQuality = actorResID == 10 || actorResID == 50 || actorResID == 10011;
				}
			}
		}
		Tag2MeshCompList = new Dictionary<FName, List<UPrimitiveComponent>>();
		Tag2MeshCompList.Add(DispLibDispWorld.MasterComp, new List<UPrimitiveComponent> { _MasterComp });
		MeshComp2TagList = new Dictionary<UPrimitiveComponent, List<FName>>();
		List<FName> list = new List<FName> { DispLibDispWorld.MasterComp };
		foreach (FName item in OriginMeshComp.ComponentTags.ToList())
		{
			if (!(item == DispLibDispWorld.MasterComp) && !(item == DispLibDispWorld.NonTag) && !list.Contains(item))
			{
				list.Add(item);
			}
		}
		MeshComp2TagList.Add(OriginMeshComp, list);
		foreach (FName item2 in list)
		{
			if (!(item2 == DispLibDispWorld.MasterComp))
			{
				Tag2MeshCompList.Add(item2, new List<UPrimitiveComponent> { _MasterComp });
			}
		}
		List<UActorComponent> componentsByClass = OriginMeshCompOwnerActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
		List<UActorComponent> componentsByClass2 = OriginMeshCompOwnerActor.GetComponentsByClass(UClass.GetClass<UChildActorComponent>());
		for (int i = 0; i < componentsByClass2.Count; i++)
		{
			if (componentsByClass2[i].ComponentHasTag(B1GlobalFNames.DBCChildActor))
			{
				UChildActorComponent uChildActorComponent = componentsByClass2[i] as UChildActorComponent;
				if (!uChildActorComponent.ChildActor.IsNullOrDestroyed())
				{
					List<UActorComponent> componentsByClass3 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
					componentsByClass.AddRange(componentsByClass3);
					List<UActorComponent> componentsByClass4 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
					componentsByClass.AddRange(componentsByClass4);
				}
			}
		}
		List<UActorComponent> componentsByClass5 = OriginMeshCompOwnerActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
		componentsByClass.AddRange(componentsByClass5);
		for (int j = 0; j < componentsByClass.Count; j++)
		{
			if (componentsByClass[j] as UWidgetComponent != null)
			{
				continue;
			}
			UPrimitiveComponent uPrimitiveComponent = componentsByClass[j] as UPrimitiveComponent;
			if (uPrimitiveComponent == OriginMeshComp)
			{
				continue;
			}
			List<FName> list2 = uPrimitiveComponent.ComponentTags.ToList();
			List<FName> list3 = new List<FName>();
			if (list2.Count == 0)
			{
				list3.Add(DispLibDispWorld.NonTag);
			}
			else
			{
				foreach (FName item3 in list2)
				{
					if (!(item3 == DispLibDispWorld.MasterComp) && !(item3 == DispLibDispWorld.NonTag) && !list3.Contains(item3))
					{
						list3.Add(item3);
					}
				}
			}
			MeshComp2TagList.Add(uPrimitiveComponent, list3);
			foreach (FName item4 in list3)
			{
				if (item4 == DispLibDispWorld.MasterComp)
				{
					continue;
				}
				if (Tag2MeshCompList.ContainsKey(item4))
				{
					if (!Tag2MeshCompList[item4].Contains(uPrimitiveComponent))
					{
						Tag2MeshCompList[item4].Add(uPrimitiveComponent);
					}
				}
				else
				{
					Tag2MeshCompList.Add(item4, new List<UPrimitiveComponent> { uPrimitiveComponent });
				}
			}
		}
		OriginMaterialInterfaces = new Dictionary<uint, UMaterialInterface[]>();
		CurMIDynamics = new Dictionary<uint, MIDycInfo[]>();
		foreach (UPrimitiveComponent key in MeshComp2TagList.Keys)
		{
			uint uniqueID = key.GetUniqueID();
			int numMaterials = key.GetNumMaterials();
			UMaterialInterface[] array = null;
			if (numMaterials == 0)
			{
				UTressFXComponent uTressFXComponent = key as UTressFXComponent;
				array = ((!uTressFXComponent.IsNullOrDestroyed()) ? new UMaterialInterface[1] { uTressFXComponent.HairMaterial } : new UMaterialInterface[1]);
			}
			else
			{
				array = new UMaterialInterface[numMaterials];
				for (int k = 0; k < numMaterials; k++)
				{
					array[k] = key.GetMaterial(k);
				}
			}
			MIDycInfo[] array2 = new MIDycInfo[array.Length];
			UMeshComponent uMeshComponent = key as UMeshComponent;
			List<FName> list4 = null;
			bool flag = true;
			if (uMeshComponent.IsNullOrDestroyed())
			{
				flag = false;
			}
			else
			{
				list4 = uMeshComponent.GetMaterialSlotNames();
				if (list4.Count == 0)
				{
					flag = false;
				}
			}
			for (int l = 0; l < array.Length; l++)
			{
				if (flag)
				{
					array2[l] = new MIDycInfo(null, list4[l]);
				}
				else
				{
					array2[l] = new MIDycInfo(null, B1GlobalFNames.GroomMat);
				}
			}
			OriginMaterialInterfaces.Add(uniqueID, array);
			CurMIDynamics.Add(uniqueID, array2);
		}
		MeshCompUniqueID2TagList = new Dictionary<uint, List<FName>>(MeshComp2TagList.Count);
		foreach (KeyValuePair<UPrimitiveComponent, List<FName>> meshComp2Tag in MeshComp2TagList)
		{
			uint uniqueID2 = meshComp2Tag.Key.GetUniqueID();
			MeshCompUniqueID2TagList.Add(uniqueID2, meshComp2Tag.Value);
		}
		base.DataInitOver = true;
		return true;
	}

	internal void Reset()
	{
		base.DataInitOver = false;
		UnitOriginHeight = 0f;
		UnitOriginRadius = 0;
		OriginMeshComp = null;
		CanSetMaterialQuality = false;
		OriginMaterialInterfaces.Clear();
		CurMIDynamics.Clear();
	}
}
