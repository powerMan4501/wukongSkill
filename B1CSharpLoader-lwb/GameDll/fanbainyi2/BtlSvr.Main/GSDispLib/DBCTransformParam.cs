using UnrealEngine.Runtime;

namespace GSDispLib;

public struct DBCTransformParam
{
	private static readonly DBCTransformParam Identity = new DBCTransformParam(FTransform.Default, DBCTransformType.Absolute, _UseLocation: false, _UseRotation: false, _UseScale: false, DBCTransformOverrdieAttachType.NoOverrdie, FName.None, _AddDataAssetOffset: false);

	public static readonly DBCTransformParam Default = Identity;

	public bool TransformUseAll { get; private set; }

	public FTransform Transform { get; private set; }

	public bool UseLocation { get; private set; }

	public bool UseRotation { get; private set; }

	public bool UseScale { get; private set; }

	public DBCTransformType LocationType { get; private set; }

	public DBCTransformType RotationType { get; private set; }

	public DBCTransformType ScaleType { get; private set; }

	public DBCTransformOverrdieAttachType AttachType { get; private set; }

	public FName AttachedTargetSocketName { get; private set; }

	public bool AddDataAssetOffset { get; private set; }

	public DBCTransformParam(FTransform _Transform, DBCTransformType _Type = DBCTransformType.Absolute, DBCTransformOverrdieAttachType _AttachType = DBCTransformOverrdieAttachType.NoOverrdie, bool _AddDataAssetOffset = true)
	{
		TransformUseAll = true;
		Transform = _Transform;
		UseLocation = true;
		LocationType = _Type;
		UseRotation = true;
		RotationType = _Type;
		UseScale = true;
		ScaleType = _Type;
		AttachType = _AttachType;
		AttachedTargetSocketName = FName.None;
		AddDataAssetOffset = _AddDataAssetOffset;
	}

	public DBCTransformParam(FTransform _Transform, bool _UseLocation, DBCTransformType _LocationType, bool _UseRotation, DBCTransformType _RotationType, bool _UseScale, DBCTransformType _ScaleType, DBCTransformOverrdieAttachType _AttachType, FName _AttachedTargetSocketName, bool _AddDataAssetOffset = true)
	{
		UseLocation = _UseLocation;
		LocationType = _LocationType;
		UseRotation = _UseRotation;
		RotationType = _RotationType;
		UseScale = _UseScale;
		ScaleType = _ScaleType;
		TransformUseAll = UseLocation && UseRotation && UseScale;
		Transform = _Transform;
		AttachType = _AttachType;
		AttachedTargetSocketName = _AttachedTargetSocketName;
		AddDataAssetOffset = _AddDataAssetOffset;
	}

	public DBCTransformParam(bool _TransformUseAll, FTransform _Transform, DBCTransformType _Type = DBCTransformType.Absolute, bool _AddDataAssetOffset = true)
	{
		TransformUseAll = _TransformUseAll;
		Transform = _Transform;
		UseLocation = TransformUseAll;
		LocationType = _Type;
		UseRotation = TransformUseAll;
		RotationType = _Type;
		UseScale = TransformUseAll;
		ScaleType = _Type;
		AttachType = DBCTransformOverrdieAttachType.NoOverrdie;
		AttachedTargetSocketName = FName.None;
		AddDataAssetOffset = _AddDataAssetOffset;
	}

	public DBCTransformParam(FTransform _Transform, DBCTransformType _Type, bool _UseLocation, bool _UseRotation, bool _UseScale, DBCTransformOverrdieAttachType _AttachType, FName _AttachedTargetSocketName, bool _AddDataAssetOffset = true)
	{
		Transform = _Transform;
		UseLocation = _UseLocation;
		LocationType = _Type;
		UseRotation = _UseRotation;
		RotationType = _Type;
		UseScale = _UseScale;
		ScaleType = _Type;
		TransformUseAll = UseLocation && UseRotation && UseScale;
		AttachType = _AttachType;
		AttachedTargetSocketName = _AttachedTargetSocketName;
		AddDataAssetOffset = _AddDataAssetOffset;
	}

	public bool IsValid()
	{
		if (!TransformUseAll && !UseLocation && !UseRotation && !UseScale && AttachType == DBCTransformOverrdieAttachType.NoOverrdie)
		{
			return AttachedTargetSocketName != FName.None;
		}
		return true;
	}

	public string GetDBCSnapshootLog()
	{
		return $"UseAll = {TransformUseAll}\n" + $"UseLocation = {UseLocation}\n" + $"UseRotation = {UseRotation}\n" + $"UseScale = {UseScale}\n" + "Transform = " + Transform.ToString() + "\nLocationType = " + LocationType.ToString() + "\nRotationType = " + RotationType.ToString() + "\nScaleType = " + ScaleType.ToString() + "\n" + $"AttachType = {AttachType}\n" + $"AttachedTargetSocketName = {AttachedTargetSocketName}\n" + $"AddDataAssetOffset = {AddDataAssetOffset}\n";
	}
}
