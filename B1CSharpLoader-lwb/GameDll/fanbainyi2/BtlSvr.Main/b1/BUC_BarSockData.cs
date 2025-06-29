using System;
using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BarSockData : IBUC_BarSockData, IPersistentECSData
{
	private Entity __LockTargetActor_Raw;

	private string __LockTargetSkeletonSocket_Raw;

	private bool __CantShowBarSockUI_Raw;

	private bool __IsTargetSp_Raw;

	public USceneComponent InteractSock;

	public float LastSwitchLockTime;

	[NeedToUI]
	public Entity LockTargetActor
	{
		get
		{
			return __LockTargetActor_Raw;
		}
		set
		{
			Entity _LockTargetActor_Raw = __LockTargetActor_Raw;
			__LockTargetActor_Raw = value;
			OnLockTargetActorChg_Invoke(_LockTargetActor_Raw, value);
		}
	}

	[NeedToUI]
	public string LockTargetSkeletonSocket
	{
		get
		{
			return __LockTargetSkeletonSocket_Raw;
		}
		set
		{
			string _LockTargetSkeletonSocket_Raw = __LockTargetSkeletonSocket_Raw;
			__LockTargetSkeletonSocket_Raw = value;
			OnLockTargetSkeletonSocketChg_Invoke(_LockTargetSkeletonSocket_Raw, value);
		}
	}

	[NeedToUI]
	public bool CantShowBarSockUI
	{
		get
		{
			return __CantShowBarSockUI_Raw;
		}
		set
		{
			bool _CantShowBarSockUI_Raw = __CantShowBarSockUI_Raw;
			__CantShowBarSockUI_Raw = value;
			OnCantShowBarSockUIChg_Invoke(_CantShowBarSockUI_Raw, value);
		}
	}

	[NeedToUI]
	public bool IsTargetSp
	{
		get
		{
			return __IsTargetSp_Raw;
		}
		set
		{
			bool _IsTargetSp_Raw = __IsTargetSp_Raw;
			__IsTargetSp_Raw = value;
			OnIsTargetSpChg_Invoke(_IsTargetSp_Raw, value);
		}
	}

	public event Action<Entity, Entity> OnLockTargetActorChg;

	public event Action<string, string> OnLockTargetSkeletonSocketChg;

	public event Action<bool, bool> OnCantShowBarSockUIChg;

	public event Action<bool, bool> OnIsTargetSpChg;

	private void OnLockTargetActorChg_Invoke(Entity OldValue, Entity NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnLockTargetActorChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLockTargetSkeletonSocketChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnLockTargetSkeletonSocketChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCantShowBarSockUIChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCantShowBarSockUIChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnIsTargetSpChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnIsTargetSpChg?.Invoke(OldValue, NewValue);
		}
	}

	public bool IsCantShowBarSockUI()
	{
		return CantShowBarSockUI;
	}

	public FVector GetLockTargetSockLocation()
	{
		if (ECSExtension.ToActor(LockTargetActor).IsNullOrDestroyed())
		{
			return FVector.ZeroVector;
		}
		if (!(ECSExtension.ToActor(LockTargetActor) is ACharacter aCharacter))
		{
			return FVector.ZeroVector;
		}
		FName inSocketName = (string.IsNullOrEmpty(LockTargetSkeletonSocket) ? B1GlobalFNames.CAMERA_LOCK : new FName(LockTargetSkeletonSocket));
		return aCharacter.Mesh.GetSocketLocation(inSocketName);
	}

	public FVector GetInteractSockLocation()
	{
		if (InteractSock == null)
		{
			return FVector.ZeroVector;
		}
		return InteractSock.GetWorldLocation();
	}

	public string GetLockTargetSkeletonSocket()
	{
		return LockTargetSkeletonSocket;
	}

	public Entity GetLockTargetActor()
	{
		return LockTargetActor;
	}

	public float GetLastSwitchLockTime()
	{
		return LastSwitchLockTime;
	}

	public bool GetIsTargetSp()
	{
		return IsTargetSp;
	}
}
