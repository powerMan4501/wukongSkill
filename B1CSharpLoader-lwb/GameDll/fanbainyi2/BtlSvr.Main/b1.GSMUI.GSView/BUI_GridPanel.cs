using System;
using b1.UI;
using UnrealEngine.Runtime;

namespace b1.GSMUI.GSView;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GridPanel")]
public class BUI_GridPanel : BUI_Widget
{
	private static bool ColumnNum_IsValid;

	private static int ColumnNum_Offset;

	private static bool MinRow_IsValid;

	private static int MinRow_Offset;

	private static bool ListMinRow_IsValid;

	private static int ListMinRow_Offset;

	[DisplayName("列数")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GridPanel:ColumnNum")]
	public int ColumnNum
	{
		get
		{
			CheckDestroyed();
			if (!ColumnNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GridPanel:ColumnNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ColumnNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColumnNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GridPanel:ColumnNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ColumnNum_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("最小行数(单个Widget)")]
	[USharpPath("/Script/b1-Managed.BUI_GridPanel:MinRow")]
	public int MinRow
	{
		get
		{
			CheckDestroyed();
			if (!MinRow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GridPanel:MinRow");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinRow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GridPanel:MinRow");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinRow_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最小行数(列表整体)")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_GridPanel:ListMinRow")]
	public int ListMinRow
	{
		get
		{
			CheckDestroyed();
			if (!ListMinRow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GridPanel:ListMinRow");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ListMinRow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ListMinRow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GridPanel:ListMinRow");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ListMinRow_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ColumnNum = 1;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_GridPanel");
		ColumnNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ColumnNum");
		ColumnNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ColumnNum", Classes.FIntProperty);
		MinRow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinRow");
		MinRow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinRow", Classes.FIntProperty);
		ListMinRow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ListMinRow");
		ListMinRow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ListMinRow", Classes.FIntProperty);
	}

	static BUI_GridPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_GridPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_GridPanel));
	}
}
