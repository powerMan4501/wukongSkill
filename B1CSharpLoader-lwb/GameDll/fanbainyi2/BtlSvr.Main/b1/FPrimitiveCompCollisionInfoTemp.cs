using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public struct FPrimitiveCompCollisionInfoTemp
{
	public USceneComponent AttachedComp;

	public FTransform RelativeTransform;

	public FName AttachSocketName;

	public ECollisionEnabled CollisionType;

	public FPrimitiveCompCollisionInfoTemp(UPrimitiveComponent Comp)
	{
		AttachedComp = null;
		RelativeTransform = FTransform.Default;
		AttachSocketName = FName.None;
		CollisionType = ECollisionEnabled.NoCollision;
		if (Comp != null)
		{
			AttachedComp = Comp.GetAttachParent();
			RelativeTransform = Comp.GetRelativeTransform();
			AttachSocketName = Comp.GetAttachSocketName();
			CollisionType = Comp.GetCollisionEnabled();
		}
	}
}
