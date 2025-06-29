using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;
using UnrealEngine.StaticMeshEditor;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetSimpleCollisionOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetSimpleCollisionOperation : UDataprepOperation
{
	private static bool ShapeType_IsValid;

	private static FFieldAddress ShapeType_PropertyAddress;

	private static int ShapeType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetSimpleCollisionOperation:ShapeType")]
	public EScriptCollisionShapeType ShapeType
	{
		get
		{
			CheckDestroyed();
			if (!ShapeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetSimpleCollisionOperation:ShapeType");
				return EScriptCollisionShapeType.Box;
			}
			return EnumMarshaler<EScriptCollisionShapeType>.FromNative(IntPtr.Add(base.Address, ShapeType_Offset), 0, ShapeType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShapeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetSimpleCollisionOperation:ShapeType");
			}
			else
			{
				EnumMarshaler<EScriptCollisionShapeType>.ToNative(IntPtr.Add(base.Address, ShapeType_Offset), 0, ShapeType_PropertyAddress.Address, value);
			}
		}
	}

	static UDataprepSetSimpleCollisionOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetSimpleCollisionOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetSimpleCollisionOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetSimpleCollisionOperation");
		NativeReflectionCached.GetPropertyRef(ref ShapeType_PropertyAddress, unrealStruct, "ShapeType");
		ShapeType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShapeType");
		ShapeType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShapeType", Classes.FEnumProperty);
	}
}
