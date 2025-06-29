using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

public static class UPCGMetadataAccessorHelpers_CsExtensions
{
	public static void SetVectorAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FVector Value)
	{
		UPCGMetadataAccessorHelpers.SetVectorAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetVector4Attribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FVector4 Value)
	{
		UPCGMetadataAccessorHelpers.SetVector4Attribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetVector2Attribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FVector2D Value)
	{
		UPCGMetadataAccessorHelpers.SetVector2Attribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetTransformAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FTransform Value)
	{
		UPCGMetadataAccessorHelpers.SetTransformAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetStringAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, string Value)
	{
		UPCGMetadataAccessorHelpers.SetStringAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetRotatorAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FRotator Value)
	{
		UPCGMetadataAccessorHelpers.SetRotatorAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetQuatAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FQuat Value)
	{
		UPCGMetadataAccessorHelpers.SetQuatAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetNameAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FName Value)
	{
		UPCGMetadataAccessorHelpers.SetNameAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetInteger64Attribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, long Value)
	{
		UPCGMetadataAccessorHelpers.SetInteger64Attribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetInteger32Attribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, int Value)
	{
		UPCGMetadataAccessorHelpers.SetInteger32Attribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetFloatAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, float Value)
	{
		UPCGMetadataAccessorHelpers.SetFloatAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetDoubleAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, double Value)
	{
		UPCGMetadataAccessorHelpers.SetDoubleAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void SetBoolAttribute(this ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, bool Value)
	{
		UPCGMetadataAccessorHelpers.SetBoolAttribute(ref Point, Metadata, AttributeName, Value);
	}

	public static void InitializeMetadata(this ref FPCGPoint Point, UPCGMetadata Metadata, FPCGPoint ParentPoint, UPCGMetadata ParentMetadata)
	{
		UPCGMetadataAccessorHelpers.InitializeMetadata(ref Point, Metadata, ParentPoint, ParentMetadata);
	}

	public static bool HasAttributeSet(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.HasAttributeSet(Point, Metadata, AttributeName);
	}

	public static FVector GetVectorAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetVectorAttribute(Point, Metadata, AttributeName);
	}

	public static FVector4 GetVector4Attribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetVector4Attribute(Point, Metadata, AttributeName);
	}

	public static FVector2D GetVector2Attribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetVector2Attribute(Point, Metadata, AttributeName);
	}

	public static FTransform GetTransformAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetTransformAttribute(Point, Metadata, AttributeName);
	}

	public static string GetStringAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetStringAttribute(Point, Metadata, AttributeName);
	}

	public static FRotator GetRotatorAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetRotatorAttribute(Point, Metadata, AttributeName);
	}

	public static FQuat GetQuatAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetQuatAttribute(Point, Metadata, AttributeName);
	}

	public static FName GetNameAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetNameAttribute(Point, Metadata, AttributeName);
	}

	public static long GetInteger64Attribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetInteger64Attribute(Point, Metadata, AttributeName);
	}

	public static int GetInteger32Attribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetInteger32Attribute(Point, Metadata, AttributeName);
	}

	public static float GetFloatAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetFloatAttribute(Point, Metadata, AttributeName);
	}

	public static double GetDoubleAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetDoubleAttribute(Point, Metadata, AttributeName);
	}

	public static bool GetBoolAttribute(this FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		return UPCGMetadataAccessorHelpers.GetBoolAttribute(Point, Metadata, AttributeName);
	}

	public static void CopyPoint(this FPCGPoint InPoint, out FPCGPoint OutPoint, bool bCopyMetadata, UPCGMetadata InMetadata, UPCGMetadata OutMetadata)
	{
		UPCGMetadataAccessorHelpers.CopyPoint(InPoint, out OutPoint, bCopyMetadata, InMetadata, OutMetadata);
	}
}
