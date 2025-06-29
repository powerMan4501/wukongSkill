using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CollisionHitMoveData
{
	private struct FCollisionHitMoveEnableStackElement
	{
		public ECollisionHitMoveEnableReqType ReqType;

		public int ReqId;

		public bool IsEnableCollisionHitMove;

		public FCollisionHitMoveEnableStackElement(bool IsEnableCollisionHitMove, ECollisionHitMoveEnableReqType ReqType, int ReqId = 0)
		{
			this.IsEnableCollisionHitMove = IsEnableCollisionHitMove;
			this.ReqType = ReqType;
			this.ReqId = ReqId;
		}
	}

	public Dictionary<UShapeComponent, TStrongObjectPtr<UCurveVector>> NeedUpdateCurveList = new Dictionary<UShapeComponent, TStrongObjectPtr<UCurveVector>>();

	public bool bShouldUpdateHitMove;

	private List<FCollisionHitMoveEnableStackElement> IsEnableCollisionHitMoveStack = new List<FCollisionHitMoveEnableStackElement>();

	public List<FHitMoveSetEnableRequest> HitMoveSetEnableRequestList = new List<FHitMoveSetEnableRequest>();

	public bool HitMoveCanUpdate { get; set; }

	public bool IsUnmovable { get; set; }

	public bool DisableBattleURO { get; set; }

	public Dictionary<UShapeComponent, CollisionUpdateInfo> NeedUpdateInfoTimerList { get; set; } = new Dictionary<UShapeComponent, CollisionUpdateInfo>();

	public List<UShapeComponent> HitMoveCollisions { get; set; } = new List<UShapeComponent>();

	public BUC_CollisionHitMoveData()
	{
		bShouldUpdateHitMove = true;
	}

	public void ClearHitMoveInfo(UBGUCharacterMovementComponent MovementComp)
	{
		NeedUpdateInfoTimerList.Clear();
		NeedUpdateCurveList.Clear();
		HitMoveCollisions.Clear();
		MovementComp.ClearHitMoveCollisions();
		HitMoveSetEnableRequestList.Clear();
	}

	public void SetIsEnableCollisionHitMove(UBGUCharacterMovementComponent MovementComp, bool IsEnableCollisionHitMove, ECollisionHitMoveEnableReqType ReqType, int ReqId = 0)
	{
		IsEnableCollisionHitMoveStack.RemoveAll((FCollisionHitMoveEnableStackElement r) => r.ReqType == ReqType && r.ReqId == ReqId);
		IsEnableCollisionHitMoveStack.Add(new FCollisionHitMoveEnableStackElement(IsEnableCollisionHitMove, ReqType, ReqId));
		MovementComp.HitMoveIsEnabled = IsEnableCollisionHitMove;
	}

	public void ResetIsEnableCollisionHitMove(UBGUCharacterMovementComponent MovementComp, ECollisionHitMoveEnableReqType ReqType, int ReqId = 0)
	{
		IsEnableCollisionHitMoveStack.RemoveAll((FCollisionHitMoveEnableStackElement r) => r.ReqType == ReqType && r.ReqId == ReqId);
		MovementComp.HitMoveIsEnabled = IsEnableCollisionHitMoveStack.Count == 0 || IsEnableCollisionHitMoveStack[IsEnableCollisionHitMoveStack.Count - 1].IsEnableCollisionHitMove;
	}
}
