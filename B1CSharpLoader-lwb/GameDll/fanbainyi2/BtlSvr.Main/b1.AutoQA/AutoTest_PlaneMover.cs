using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_PlaneMover")]
internal class AutoTest_PlaneMover : b1.AutoQA.AutoTest_Template
{
	public Dictionary<string, FVector> StartPointsDic = new Dictionary<string, FVector>();

	private static bool StartPoints_IsValid;

	private static int StartPoints_Offset;

	private static FFieldAddress StartPoints_PropertyAddress;

	private TMapReadWriteMarshaler<string, FVector> StartPoints_Marshaler;

	private static bool HasMaxClampValue_IsValid;

	private static int HasMaxClampValue_Offset;

	private static FFieldAddress HasMaxClampValue_PropertyAddress;

	private static bool MaxClampValue_IsValid;

	private static int MaxClampValue_Offset;

	private static bool HasMinClampValue_IsValid;

	private static int HasMinClampValue_Offset;

	private static FFieldAddress HasMinClampValue_PropertyAddress;

	private static bool MinClampValue_IsValid;

	private static int MinClampValue_Offset;

	public override float TickInterval => 0f;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("待测点")]
	[USharpPath("/Script/b1-Managed.AutoTest_PlaneMover:StartPoints")]
	public TMapReadWrite<string, FVector> StartPoints
	{
		get
		{
			CheckDestroyed();
			if (!StartPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:StartPoints");
				return null;
			}
			if (StartPoints_Marshaler == null)
			{
				StartPoints_Marshaler = new TMapReadWriteMarshaler<string, FVector>(1, StartPoints_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return StartPoints_Marshaler.FromNative(IntPtr.Add(base.Address, StartPoints_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否有上限")]
	[USharpPath("/Script/b1-Managed.AutoTest_PlaneMover:HasMaxClampValue")]
	public bool HasMaxClampValue
	{
		get
		{
			CheckDestroyed();
			if (!HasMaxClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:HasMaxClampValue");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasMaxClampValue_Offset), 0, HasMaxClampValue_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasMaxClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:HasMaxClampValue");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasMaxClampValue_Offset), 0, HasMaxClampValue_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("最大值")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_PlaneMover:MaxClampValue")]
	public float MaxClampValue
	{
		get
		{
			CheckDestroyed();
			if (!MaxClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:MaxClampValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxClampValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:MaxClampValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxClampValue_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("是否有下限")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTest_PlaneMover:HasMinClampValue")]
	public bool HasMinClampValue
	{
		get
		{
			CheckDestroyed();
			if (!HasMinClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:HasMinClampValue");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasMinClampValue_Offset), 0, HasMinClampValue_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasMinClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:HasMinClampValue");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasMinClampValue_Offset), 0, HasMinClampValue_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("最小值")]
	[USharpPath("/Script/b1-Managed.AutoTest_PlaneMover:MinClampValue")]
	public float MinClampValue
	{
		get
		{
			CheckDestroyed();
			if (!MinClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:MinClampValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinClampValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinClampValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AutoTest_PlaneMover:MinClampValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinClampValue_Offset), value);
			}
		}
	}

	protected override void RegisterTestState()
	{
		foreach (KeyValuePair<string, FVector> startPoint in StartPoints)
		{
			StartPointsDic.Add(startPoint.Key, startPoint.Value);
		}
		StateStack.Push(new b1.AutoQA.TestState_ChangeAbpSetting(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.ChangeGlobalSpd 5"));
		StateStack.Push(new b1.AutoQA.TestState_PlaneMover(base.WorldContext, StartPointsDic.First().Key, StartPointsDic.First().Value, CheckDefaultPointVaild: true, ref StartPointsDic, HasMaxClampValue, MaxClampValue, HasMinClampValue, MinClampValue));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_PlaneMover");
		NativeReflection.GetPropertyRef(ref StartPoints_PropertyAddress, unrealStruct, "StartPoints");
		StartPoints_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartPoints");
		StartPoints_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartPoints", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref HasMaxClampValue_PropertyAddress, unrealStruct, "HasMaxClampValue");
		HasMaxClampValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HasMaxClampValue");
		HasMaxClampValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HasMaxClampValue", Classes.FBoolProperty);
		MaxClampValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxClampValue");
		MaxClampValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxClampValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref HasMinClampValue_PropertyAddress, unrealStruct, "HasMinClampValue");
		HasMinClampValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HasMinClampValue");
		HasMinClampValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HasMinClampValue", Classes.FBoolProperty);
		MinClampValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinClampValue");
		MinClampValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinClampValue", Classes.FFloatProperty);
	}

	static AutoTest_PlaneMover()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_PlaneMover)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_PlaneMover));
	}
}
