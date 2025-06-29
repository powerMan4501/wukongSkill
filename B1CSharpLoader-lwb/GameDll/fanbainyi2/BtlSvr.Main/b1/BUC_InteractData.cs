using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using GUR.Runtime;
using GurGsReplicate;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_InteractData : IBUC_InteractData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public InteractData[] _RepData = new InteractData[64];

	private EBGUInteractUnitState __InteractUnitStatePersistent_Raw;

	private EBGUInteractUnitState __InteractUnitState_Raw;

	private EInteractUIState __InteractUIState_Raw;

	private int __ActionGroupIDPersistent_Raw;

	private string __InteractTipOverride_Raw;

	private float __InteractinputTime_Raw;

	private EInteractConstraint __InteractConstraint_Raw;

	public int _InteractCounter;

	public int InteractiveUnitID { get; set; }

	public int RewardDropID { get; set; }

	public int DefalutInteractiveGroupID { get; set; }

	public int InstOverrideInteractiveGroupID { get; set; }

	public bool bInActiveArea { get; set; }

	[GSPersistent(MarkDelaySaveArchiveSource = "InteractStateChanged")]
	public EBGUInteractUnitState InteractUnitStatePersistent
	{
		get
		{
			return __InteractUnitStatePersistent_Raw;
		}
		set
		{
			EBGUInteractUnitState _InteractUnitStatePersistent_Raw = __InteractUnitStatePersistent_Raw;
			__InteractUnitStatePersistent_Raw = value;
			OnInteractUnitStatePersistentChg_Invoke(_InteractUnitStatePersistent_Raw, value);
		}
	}

	[GSReplicated]
	public EBGUInteractUnitState InteractUnitState
	{
		get
		{
			return __InteractUnitState_Raw;
		}
		set
		{
			EBGUInteractUnitState _InteractUnitState_Raw = __InteractUnitState_Raw;
			__InteractUnitState_Raw = value;
			OnInteractUnitStateChg_Invoke(_InteractUnitState_Raw, value);
		}
	}

	public Entity CanInteractPlayerEntity { get; set; }

	public Entity TriggerInteractPlayerEntity { get; set; }

	public Entity InteractingPlayerEntity { get; set; }

	public bool bIsInteractTarget { get; set; }

	public float RemainingInteractTime { get; set; }

	public float BlendOutTimer { get; set; }

	public FVector IconSockVector { get; set; }

	public bool bSpecialIcon { get; set; }

	public bool bMuteSubtitle { get; set; }

	public float CD { get; set; }

	public bool ModifiedCollision { get; set; }

	public Dictionary<string, TWeakObject<UCameraComponent>> CameraComps { get; set; } = new Dictionary<string, TWeakObject<UCameraComponent>>();

	[NeedToUI]
	public EInteractUIState InteractUIState
	{
		get
		{
			return __InteractUIState_Raw;
		}
		set
		{
			EInteractUIState _InteractUIState_Raw = __InteractUIState_Raw;
			__InteractUIState_Raw = value;
			OnInteractUIStateChg_Invoke(_InteractUIState_Raw, value);
		}
	}

	public List<FUStInteractionMappingDesc> ActionList { get; set; }

	public FUStInteractiveUnitCommDesc InteractiveUnitCommDesc { get; set; }

	public USceneComponent QAInteractRangeAnchor { get; set; }

	public int InteractCounter
	{
		get
		{
			return _InteractCounter;
		}
		set
		{
			_InteractCounter = value;
		}
	}

	[GSPersistent(MarkDelaySaveArchiveSource = "InteractStateChanged")]
	public int ActionGroupIDPersistent
	{
		get
		{
			return __ActionGroupIDPersistent_Raw;
		}
		set
		{
			int _ActionGroupIDPersistent_Raw = __ActionGroupIDPersistent_Raw;
			__ActionGroupIDPersistent_Raw = value;
			OnActionGroupIDPersistentChg_Invoke(_ActionGroupIDPersistent_Raw, value);
		}
	}

	public int ActionGroupID { get; private set; }

	public int ShopID { get; set; }

	public bool bIsNPC { get; set; }

	[NeedToUI]
	public string InteractTipOverride
	{
		get
		{
			return __InteractTipOverride_Raw;
		}
		set
		{
			string _InteractTipOverride_Raw = __InteractTipOverride_Raw;
			__InteractTipOverride_Raw = value;
			OnInteractTipOverrideChg_Invoke(_InteractTipOverride_Raw, value);
		}
	}

	[NeedToUI]
	public float InteractinputTime
	{
		get
		{
			return __InteractinputTime_Raw;
		}
		set
		{
			float _InteractinputTime_Raw = __InteractinputTime_Raw;
			__InteractinputTime_Raw = value;
			OnInteractinputTimeChg_Invoke(_InteractinputTime_Raw, value);
		}
	}

	[GSReplicated]
	public EInteractConstraint InteractConstraint
	{
		get
		{
			return __InteractConstraint_Raw;
		}
		set
		{
			EInteractConstraint _InteractConstraint_Raw = __InteractConstraint_Raw;
			__InteractConstraint_Raw = value;
			OnInteractConstraintChg_Invoke(_InteractConstraint_Raw, value);
		}
	}

	public List<int> InteractFuncList { get; set; }

	public FName InteractAnchorOverride { get; set; }

	public bool ItemRequireCondition { get; set; }

	public int AiConversationNeedToPlay { get; set; }

	public int PlayingHighLightDBCID { get; set; }

	public bool bIsInteracting { get; set; }

	public bool ModifiedGroupWhenInteracting { get; set; }

	public InteractiveObjectMaterial ObjectMaterial { get; set; }

	public float InstOverrideActivableDistance { get; set; }

	public float TrueActivableDistance { get; set; }

	public Dictionary<FName, FTransform> SceneCompTransformDict { get; set; }

	public Dictionary<InteractiveObjectMaterial, FName> Material2Name { get; set; }

	public List<FVector> AreaDefinition { get; set; }

	public event Action<EBGUInteractUnitState, EBGUInteractUnitState> OnInteractUnitStatePersistentChg;

	public event Action<EBGUInteractUnitState, EBGUInteractUnitState> OnInteractUnitStateChg;

	public event Action<EInteractUIState, EInteractUIState> OnInteractUIStateChg;

	public event Action<int, int> OnActionGroupIDPersistentChg;

	public event Action<string, string> OnInteractTipOverrideChg;

	public event Action<float, float> OnInteractinputTimeChg;

	public event Action<EInteractConstraint, EInteractConstraint> OnInteractConstraintChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public InteractData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		InteractData interactData = _RepData[__LocalRepVersion % 64];
		if (interactData == null)
		{
			interactData = new InteractData();
			_RepData[__LocalRepVersion % 64] = interactData;
		}
		else if (flag)
		{
			interactData.ClearInteractUnitState();
			interactData.ClearInteractConstraint();
		}
		return interactData;
	}

	public InteractData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		InteractData interactData = new InteractData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"InteractData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			interactData.InteractUnitState = (int)InteractUnitState;
			interactData.InteractConstraint = (int)InteractConstraint;
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					InteractData other = _RepData[i % 64];
					interactData.MergeFrom(other);
				}
			}
		}
		return interactData;
	}

	private void OnInteractUnitStatePersistentChg_Invoke(EBGUInteractUnitState OldValue, EBGUInteractUnitState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnInteractUnitStatePersistentChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInteractUnitStateChg_Invoke(EBGUInteractUnitState OldValue, EBGUInteractUnitState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().InteractUnitState = (int)NewValue;
			}
			this.OnInteractUnitStateChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInteractUIStateChg_Invoke(EInteractUIState OldValue, EInteractUIState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnInteractUIStateChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnActionGroupIDPersistentChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnActionGroupIDPersistentChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInteractTipOverrideChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnInteractTipOverrideChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInteractinputTimeChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnInteractinputTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnInteractConstraintChg_Invoke(EInteractConstraint OldValue, EInteractConstraint NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().InteractConstraint = (int)NewValue;
			}
			this.OnInteractConstraintChg?.Invoke(OldValue, NewValue);
		}
	}

	public void SetInteractUnitState(EBGUInteractUnitState State, bool UpdatePersistent)
	{
		InteractUnitState = State;
		if (UpdatePersistent)
		{
			InteractUnitStatePersistent = State;
		}
	}

	public void SetActionGroupID(int value, bool Persistent = true)
	{
		ActionGroupID = value;
		if (Persistent)
		{
			DefalutInteractiveGroupID = value;
			ActionGroupIDPersistent = value;
		}
		InteractCounter = 1;
	}

	public FName GetFNameByMaterial(InteractiveObjectMaterial Mat)
	{
		if (Material2Name.TryGetValue(Mat, out var value))
		{
			return value;
		}
		return FName.None;
	}

	public BUC_InteractData()
	{
		bMuteSubtitle = false;
		InteractCounter = 1;
		ActionList = new List<FUStInteractionMappingDesc>();
		InteractFuncList = new List<int>();
		ObjectMaterial = InteractiveObjectMaterial.Default;
		Material2Name = new Dictionary<InteractiveObjectMaterial, FName>
		{
			{
				InteractiveObjectMaterial.Default,
				FName.None
			},
			{
				InteractiveObjectMaterial.Wood,
				B1GlobalFNames.Wood
			},
			{
				InteractiveObjectMaterial.Stone,
				B1GlobalFNames.Stone
			},
			{
				InteractiveObjectMaterial.Steel,
				B1GlobalFNames.Steel
			}
		};
		SceneCompTransformDict = new Dictionary<FName, FTransform>();
		AreaDefinition = new List<FVector>();
	}

	public bool IsInBothSide(FVector Location1, FVector Location2)
	{
		if (AreaDefinition == null || AreaDefinition.Count < 2)
		{
			return true;
		}
		int num = 0;
		float num2 = float.MaxValue;
		for (int i = 0; i < AreaDefinition.Count; i++)
		{
			float num3 = FVector.Dist(AreaDefinition[i], Location1);
			if (num3 < num2)
			{
				num2 = num3;
				num = i;
			}
		}
		float num4 = FVector.Dist(AreaDefinition[num], Location2);
		for (int j = 0; j < AreaDefinition.Count; j++)
		{
			if (j != num && FVector.Dist(AreaDefinition[j], Location2) < num4)
			{
				return false;
			}
		}
		return true;
	}
}
