using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public static class CalliopeExtension
{
	public static FTransform ToFTransform(this CalliopeCustom_Transform Custom_Transform)
	{
		return new FTransform(new FRotator(Custom_Transform.TransformPitch, Custom_Transform.TransformYaw, Custom_Transform.TransformRoll), new FVector(Custom_Transform.TransformX, Custom_Transform.TransformY, Custom_Transform.TransformZ), new FVector(Custom_Transform.TransformSx, Custom_Transform.TransformSy, Custom_Transform.TransformSz));
	}

	public static CalliopeCustom_Transform ToCalliopeTransform(this FTransform InTransform)
	{
		return new CalliopeCustom_Transform
		{
			TransformX = InTransform.Translation.X,
			TransformY = InTransform.Translation.Y,
			TransformZ = InTransform.Translation.Z,
			TransformPitch = InTransform.Rotator().Pitch,
			TransformYaw = InTransform.Rotator().Yaw,
			TransformRoll = InTransform.Rotator().Roll,
			TransformSx = InTransform.Scale3D.X,
			TransformSy = InTransform.Scale3D.Y,
			TransformSz = InTransform.Scale3D.Z
		};
	}
}
