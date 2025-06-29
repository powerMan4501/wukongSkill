using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_DistanceCheckTest")]
internal class BAID_DistanceCheckTest : BAID_Base
{
	private static bool CheckTarget_IsValid;

	private static int CheckTarget_Offset;

	private static FFieldAddress CheckTarget_PropertyAddress;

	private static bool CheckDistanceType_IsValid;

	private static int CheckDistanceType_Offset;

	private static FFieldAddress CheckDistanceType_PropertyAddress;

	private static bool Distance_IsValid;

	private static int Distance_Offset;

	private static bool PreferCloser_IsValid;

	private static int PreferCloser_Offset;

	private static FFieldAddress PreferCloser_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_DistanceCheckTest:CheckTarget")]
	public EAICheckTarget CheckTarget
	{
		get
		{
			CheckDestroyed();
			if (!CheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:CheckTarget");
				return EAICheckTarget.CachedScencItem;
			}
			return EnumMarshaler<EAICheckTarget>.FromNative(IntPtr.Add(base.Address, CheckTarget_Offset), 0, CheckTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:CheckTarget");
			}
			else
			{
				EnumMarshaler<EAICheckTarget>.ToNative(IntPtr.Add(base.Address, CheckTarget_Offset), 0, CheckTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_DistanceCheckTest:CheckDistanceType")]
	public EAICheckDistanceType CheckDistanceType
	{
		get
		{
			CheckDestroyed();
			if (!CheckDistanceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:CheckDistanceType");
				return EAICheckDistanceType.LocationDistanceXY;
			}
			return EnumMarshaler<EAICheckDistanceType>.FromNative(IntPtr.Add(base.Address, CheckDistanceType_Offset), 0, CheckDistanceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckDistanceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:CheckDistanceType");
			}
			else
			{
				EnumMarshaler<EAICheckDistanceType>.ToNative(IntPtr.Add(base.Address, CheckDistanceType_Offset), 0, CheckDistanceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_DistanceCheckTest:Distance")]
	public float Distance
	{
		get
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:Distance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Distance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:Distance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Distance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("小于等于返回真")]
	[Tooltip("默认不勾选，则是大于等于返回真")]
	[USharpPath("/Script/b1-Managed.BAID_DistanceCheckTest:PreferCloser")]
	public bool PreferCloser
	{
		get
		{
			CheckDestroyed();
			if (!PreferCloser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:PreferCloser");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreferCloser_Offset), 0, PreferCloser_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreferCloser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_DistanceCheckTest:PreferCloser");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreferCloser_Offset), 0, PreferCloser_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			IBUC_BTCheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BTCheckData, BUC_BTCheckData>(actor);
			if (readOnlyData != null)
			{
				return readOnlyData.CheckForBTCondition(EBTConditionCheckType.CheckDistance, new BTCondition_Distance
				{
					CheckTarget = CheckTarget,
					CheckDistanceType = CheckDistanceType,
					Distance = Distance,
					PreferCloser = PreferCloser
				});
			}
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_DistanceCheckTest");
		NativeReflection.GetPropertyRef(ref CheckTarget_PropertyAddress, unrealStruct, "CheckTarget");
		CheckTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckTarget");
		CheckTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckTarget", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CheckDistanceType_PropertyAddress, unrealStruct, "CheckDistanceType");
		CheckDistanceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckDistanceType");
		CheckDistanceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckDistanceType", Classes.FEnumProperty);
		Distance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Distance");
		Distance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Distance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PreferCloser_PropertyAddress, unrealStruct, "PreferCloser");
		PreferCloser_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreferCloser");
		PreferCloser_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreferCloser", Classes.FBoolProperty);
	}

	static BAID_DistanceCheckTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_DistanceCheckTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_DistanceCheckTest));
	}
}
