using System;
using b1.Plugins.UMGSpline;
using b1.UI.Comm;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSTalentSplineWidget")]
public class GSTalentSplineWidget : USplineWidget
{
	private static bool ParentID_IsValid;

	private static int ParentID_Offset;

	private static bool ChildID_IsValid;

	private static int ChildID_Offset;

	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("父节点ID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSTalentSplineWidget:ParentID")]
	public int ParentID
	{
		get
		{
			CheckDestroyed();
			if (!ParentID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTalentSplineWidget:ParentID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ParentID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTalentSplineWidget:ParentID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ParentID_Offset), value);
			}
		}
	}

	[Tooltip("子节点ID")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSTalentSplineWidget:ChildID")]
	public int ChildID
	{
		get
		{
			CheckDestroyed();
			if (!ChildID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTalentSplineWidget:ChildID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChildID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChildID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTalentSplineWidget:ChildID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChildID_Offset), value);
			}
		}
	}

	private UMaterialInstanceDynamic MI { get; set; }

	public void UpdateState(bool IsActive, TalentState State)
	{
		if (MI == null)
		{
			MI = GetSplineDynamicMaterial();
		}
		if (IsActive)
		{
			switch (State)
			{
			case TalentState.NotLearn:
				MI.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsActived, 0f);
				break;
			case TalentState.HasLearn:
				MI.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsActived, 1f);
				break;
			case TalentState.MaxLearn:
				MI.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsActived, 1f);
				break;
			}
		}
		else
		{
			MI.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsActived, 0f);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSTalentSplineWidget");
		ParentID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParentID");
		ParentID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParentID", Classes.FIntProperty);
		ChildID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChildID");
		ChildID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChildID", Classes.FIntProperty);
	}

	static GSTalentSplineWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSTalentSplineWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSTalentSplineWidget));
	}
}
