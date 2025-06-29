using System;
using b1.UI.Comm;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TalentLineCS")]
public class BI_TalentLineCS : BUI_Widget
{
	private static bool ParentID_IsValid;

	private static int ParentID_Offset;

	private static bool ChildID_IsValid;

	private static int ChildID_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[Tooltip("父节点ID")]
	[USharpPath("/Script/b1-Managed.BI_TalentLineCS:ParentID")]
	public int ParentID
	{
		get
		{
			CheckDestroyed();
			if (!ParentID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TalentLineCS:ParentID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ParentID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TalentLineCS:ParentID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ParentID_Offset), value);
			}
		}
	}

	[Tooltip("子节点ID")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BI_TalentLineCS:ChildID")]
	public int ChildID
	{
		get
		{
			CheckDestroyed();
			if (!ChildID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TalentLineCS:ChildID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChildID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChildID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_TalentLineCS:ChildID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChildID_Offset), value);
			}
		}
	}

	public void UpdateState(bool IsActive, TalentState State)
	{
		if (IsActive)
		{
			switch (State)
			{
			case TalentState.NotLearn:
				GSAnimKeyToState("AKBStateChange", "StNot");
				break;
			case TalentState.HasLearn:
				GSAnimKeyToState("AKBStateChange", "StHas");
				break;
			case TalentState.MaxLearn:
				GSAnimKeyToState("AKBStateChange", "StMax");
				break;
			}
		}
		else
		{
			GSAnimKeyToState("AKBStateChange", "StNot");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_TalentLineCS");
		ParentID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParentID");
		ParentID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParentID", Classes.FIntProperty);
		ChildID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChildID");
		ChildID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChildID", Classes.FIntProperty);
	}

	static BI_TalentLineCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TalentLineCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TalentLineCS));
	}
}
