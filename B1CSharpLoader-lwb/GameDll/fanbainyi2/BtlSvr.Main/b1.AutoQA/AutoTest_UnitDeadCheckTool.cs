using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadCheckTool")]
internal class AutoTest_UnitDeadCheckTool : b1.AutoQA.AutoTest_Template
{
	private static bool TamerList_IsValid;

	private static int TamerList_Offset;

	private static bool DistanceBetween_IsValid;

	private static int DistanceBetween_Offset;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	private static bool BUFF_IsValid;

	private static int BUFF_Offset;

	[Category("性能监测|Use_DA（By ATP）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "TestType==GetTamerMethod::Use_DA")]
	[DisplayName("要用到的DA")]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:TamerList")]
	public AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerList
	{
		get
		{
			CheckDestroyed();
			if (!TamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:TamerList");
				return null;
			}
			return UObjectMarshaler<AutoTestHelperLib.BGWDataAsset_TamerListConfig>.FromNative(IntPtr.Add(base.Address, TamerList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:TamerList");
			}
			else
			{
				UObjectMarshaler<AutoTestHelperLib.BGWDataAsset_TamerListConfig>.ToNative(IntPtr.Add(base.Address, TamerList_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("拍照相机和怪物的间距。数越大越远，不应小于8")]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:DistanceBetween")]
	public int DistanceBetween
	{
		get
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:DistanceBetween");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DistanceBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:DistanceBetween");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DistanceBetween_Offset), value);
			}
		}
	}

	[DisplayName("起始怪物Index，从0开始")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("异常BUFF")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:BUFF")]
	public int BUFF
	{
		get
		{
			CheckDestroyed();
			if (!BUFF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:BUFF");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BUFF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUFF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_UnitDeadCheckTool:BUFF");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BUFF_Offset), value);
			}
		}
	}

	protected override void RegisterTestState()
	{
		ACameraActor aCameraActor = null;
		ACameraActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACameraActor>(base.WorldContext);
		foreach (ACameraActor aCameraActor2 in allActorsOfClass)
		{
			if (aCameraActor2.GetName().Contains("CameraActor_1"))
			{
				aCameraActor = aCameraActor2;
				break;
			}
		}
		if (!(aCameraActor == null))
		{
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(base.WorldContext));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.Invisible"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SkipAllPlaySequenceNode 1"));
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.SkipAllChapterMovie 1"));
			StateStack.Push(new TestState_ATPAllUnitDeadTest(base.WorldContext, TamerList, QuitBiuPerUnit: false, DistanceBetween, BUFF));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_UnitDeadCheckTool");
		TamerList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerList");
		TamerList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerList", Classes.FObjectProperty);
		DistanceBetween_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceBetween");
		DistanceBetween_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceBetween", Classes.FIntProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartIndex", Classes.FIntProperty);
		BUFF_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BUFF");
		BUFF_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BUFF", Classes.FIntProperty);
	}

	static AutoTest_UnitDeadCheckTool()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_UnitDeadCheckTool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_UnitDeadCheckTool));
	}
}
