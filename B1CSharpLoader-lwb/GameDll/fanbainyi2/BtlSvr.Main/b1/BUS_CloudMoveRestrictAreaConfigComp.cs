using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CloudMoveRestrictAreaConfigComp")]
public class BUS_CloudMoveRestrictAreaConfigComp : UActorEditCompBase
{
	private static bool CloudMoveRestrictType_IsValid;

	private static int CloudMoveRestrictType_Offset;

	private static FFieldAddress CloudMoveRestrictType_PropertyAddress;

	[BlueprintReadWrite]
	[Category("筋斗云限制配置")]
	[DisplayName("限制类型")]
	[Tooltip("限制类型")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_CloudMoveRestrictAreaConfigComp:CloudMoveRestrictType")]
	public EGSCloudMoveRestrictType CloudMoveRestrictType
	{
		get
		{
			CheckDestroyed();
			if (!CloudMoveRestrictType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CloudMoveRestrictAreaConfigComp:CloudMoveRestrictType");
				return EGSCloudMoveRestrictType.None;
			}
			return EnumMarshaler<EGSCloudMoveRestrictType>.FromNative(IntPtr.Add(base.Address, CloudMoveRestrictType_Offset), 0, CloudMoveRestrictType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CloudMoveRestrictType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CloudMoveRestrictAreaConfigComp:CloudMoveRestrictType");
			}
			else
			{
				EnumMarshaler<EGSCloudMoveRestrictType>.ToNative(IntPtr.Add(base.Address, CloudMoveRestrictType_Offset), 0, CloudMoveRestrictType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_CloudMoveRestrictAreaData>().CloudMoveRestrictType = CloudMoveRestrictType;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_CloudMoveRestrictAreaConfigComp");
		NativeReflection.GetPropertyRef(ref CloudMoveRestrictType_PropertyAddress, unrealStruct, "CloudMoveRestrictType");
		CloudMoveRestrictType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudMoveRestrictType");
		CloudMoveRestrictType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudMoveRestrictType", Classes.FEnumProperty);
	}

	static BUS_CloudMoveRestrictAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CloudMoveRestrictAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CloudMoveRestrictAreaConfigComp));
	}
}
