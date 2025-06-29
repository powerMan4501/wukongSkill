using System;
using UnrealEngine.Runtime;

namespace b1;

[EditInlineNew]
[DisplayName("复合条件")]
[UClass]
[USharpPath("/Script/b1-Managed.PerformerCondition_Composite")]
public class PerformerCondition_Composite : PerformerConditionBase
{
	private static bool SubConditions_IsValid;

	private static int SubConditions_Offset;

	private static FFieldAddress SubConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<PerformerConditionBase> SubConditions_Marshaler;

	private static bool Relation_IsValid;

	private static int Relation_Offset;

	private static FFieldAddress Relation_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerCondition_Composite:SubConditions")]
	public TArrayReadWrite<PerformerConditionBase> SubConditions
	{
		get
		{
			CheckDestroyed();
			if (!SubConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_Composite:SubConditions");
				return null;
			}
			if (SubConditions_Marshaler == null)
			{
				SubConditions_Marshaler = new TArrayReadWriteMarshaler<PerformerConditionBase>(1, SubConditions_PropertyAddress, CachedMarshalingDelegates<PerformerConditionBase, UObjectMarshaler<PerformerConditionBase>>.FromNative, CachedMarshalingDelegates<PerformerConditionBase, UObjectMarshaler<PerformerConditionBase>>.ToNative);
			}
			return SubConditions_Marshaler.FromNative(IntPtr.Add(base.Address, SubConditions_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerCondition_Composite:Relation")]
	public EConditionalRelation Relation
	{
		get
		{
			CheckDestroyed();
			if (!Relation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_Composite:Relation");
				return EConditionalRelation.And;
			}
			return EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(base.Address, Relation_Offset), 0, Relation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Relation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_Composite:Relation");
			}
			else
			{
				EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(base.Address, Relation_Offset), 0, Relation_PropertyAddress.Address, value);
			}
		}
	}

	public override void SetOwnerComp(BUS_PerformerControlComp InControlComp)
	{
		base.SetOwnerComp(InControlComp);
		foreach (PerformerConditionBase subCondition in SubConditions)
		{
			subCondition.SetOwnerComp(InControlComp);
		}
	}

	protected override bool IsSuccess()
	{
		switch (Relation)
		{
		case EConditionalRelation.And:
			foreach (PerformerConditionBase subCondition in SubConditions)
			{
				if (subCondition != null && !subCondition.IsConditionSuccess())
				{
					return false;
				}
			}
			break;
		case EConditionalRelation.Or:
			foreach (PerformerConditionBase subCondition2 in SubConditions)
			{
				if (subCondition2 == null || subCondition2.IsConditionSuccess())
				{
					return true;
				}
			}
			break;
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerCondition_Composite");
		NativeReflection.GetPropertyRef(ref SubConditions_PropertyAddress, unrealStruct, "SubConditions");
		SubConditions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SubConditions");
		SubConditions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SubConditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Relation_PropertyAddress, unrealStruct, "Relation");
		Relation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Relation");
		Relation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Relation", Classes.FEnumProperty);
	}

	static PerformerCondition_Composite()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PerformerCondition_Composite)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PerformerCondition_Composite));
	}
}
