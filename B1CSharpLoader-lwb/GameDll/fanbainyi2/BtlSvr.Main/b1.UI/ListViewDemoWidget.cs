using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ListViewDemoWidget")]
public class ListViewDemoWidget : BUI_Widget
{
	private UListView _lv;

	private static bool entryTemplate_IsValid;

	private static int entryTemplate_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ListViewDemoWidget:entryTemplate")]
	private TSubclassOf<ListViewDemoEntryWidget> entryTemplate
	{
		get
		{
			CheckDestroyed();
			if (!entryTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoWidget:entryTemplate");
				return default(TSubclassOf<ListViewDemoEntryWidget>);
			}
			return TSubclassOfMarshaler<ListViewDemoEntryWidget>.FromNative(IntPtr.Add(base.Address, entryTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!entryTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoWidget:entryTemplate");
			}
			else
			{
				TSubclassOfMarshaler<ListViewDemoEntryWidget>.ToNative(IntPtr.Add(base.Address, entryTemplate_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		USystemLibrary.PrintString(this, "OnUIConstruct", bPrintToScreen: true, bPrintToLog: true, new FLinearColor(1f, 0f, 0f), 2f, FName.None);
	}

	protected override void OnUIInitialized()
	{
		USystemLibrary.PrintString(this, "OnUIInitilized", bPrintToScreen: true, bPrintToLog: true, new FLinearColor(1f, 0f, 0f), 2f, FName.None);
		_lv = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.ListView_Main) as UListView;
		InitFunc_Demonstrate();
	}

	private FLinearColor GenRandomColor(int randomSeed)
	{
		Random random = new Random(randomSeed);
		float[] array = new float[3];
		for (int i = 0; i < 3; i++)
		{
			array[i] = (float)random.NextDouble();
		}
		return new FLinearColor(array[0], array[1], array[2]);
	}

	private void InitFunc()
	{
		ListViewDemoItemObject[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ListViewDemoItemObject>(this);
		foreach (ListViewDemoItemObject listViewDemoItemObject in allActorsOfClass)
		{
			listViewDemoItemObject.itemText = listViewDemoItemObject.GetName();
			_lv.AddItem(listViewDemoItemObject);
		}
	}

	private void InitFunc_Demonstrate()
	{
		for (int i = 0; i < 20; i++)
		{
			ListViewDemoItemObject listViewDemoItemObject = UObject.NewObject<ListViewDemoItemObject>(this);
			listViewDemoItemObject.itemText = string.Format($"item：{i}");
			listViewDemoItemObject.itemColor = GenRandomColor(i);
			if (_lv != null)
			{
				_lv.AddItem(listViewDemoItemObject);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.ListViewDemoWidget");
		entryTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "entryTemplate");
		entryTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "entryTemplate", Classes.FClassProperty);
	}

	static ListViewDemoWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ListViewDemoWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ListViewDemoWidget));
	}
}
