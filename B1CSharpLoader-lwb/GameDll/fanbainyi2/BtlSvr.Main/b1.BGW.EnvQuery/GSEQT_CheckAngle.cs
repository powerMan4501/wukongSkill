using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("GS EQT Check Angle")]
[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle")]
public class GSEQT_CheckAngle : UGSEQTBase
{
	private static bool BaseContext_IsValid;

	private static int BaseContext_Offset;

	private static FFieldAddress BaseContext_PropertyAddress;

	private static bool TargetContext_IsValid;

	private static int TargetContext_Offset;

	private static FFieldAddress TargetContext_PropertyAddress;

	private static bool AngleMin_IsValid;

	private static int AngleMin_Offset;

	private static bool AngleMax_IsValid;

	private static int AngleMax_Offset;

	private static bool ProcessItemCS_IsValid;

	private static IntPtr ProcessItemCS_FunctionAddress;

	private static int ProcessItemCS_ParamsSize;

	private static bool ProcessItemCS_World_IsValid;

	private static int ProcessItemCS_World_Offset;

	private static bool ProcessItemCS_ItemLocation_IsValid;

	private static int ProcessItemCS_ItemLocation_Offset;

	private static FFieldAddress ProcessItemCS_ItemLocation_PropertyAddress;

	private static bool ProcessItemCS_ItemActor_IsValid;

	private static int ProcessItemCS_ItemActor_Offset;

	private static bool ProcessItemCS_Querier_IsValid;

	private static int ProcessItemCS_Querier_Offset;

	private static bool ProcessItemCS_ReturnValue_IsValid;

	private static int ProcessItemCS_ReturnValue_Offset;

	private static FFieldAddress ProcessItemCS_ReturnValue_PropertyAddress;

	private static bool ShouldPrepareContext_IsValid;

	private static IntPtr ShouldPrepareContext_FunctionAddress;

	private static int ShouldPrepareContext_ParamsSize;

	private static bool ShouldPrepareContext_ReturnValue_IsValid;

	private static int ShouldPrepareContext_ReturnValue_Offset;

	private static FFieldAddress ShouldPrepareContext_ReturnValue_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle:BaseContext")]
	public EEQCType BaseContext
	{
		get
		{
			CheckDestroyed();
			if (!BaseContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:BaseContext");
				return EEQCType.None;
			}
			return EnumMarshaler<EEQCType>.FromNative(IntPtr.Add(base.Address, BaseContext_Offset), 0, BaseContext_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BaseContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:BaseContext");
			}
			else
			{
				EnumMarshaler<EEQCType>.ToNative(IntPtr.Add(base.Address, BaseContext_Offset), 0, BaseContext_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle:TargetContext")]
	public EEQCType TargetContext
	{
		get
		{
			CheckDestroyed();
			if (!TargetContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:TargetContext");
				return EEQCType.None;
			}
			return EnumMarshaler<EEQCType>.FromNative(IntPtr.Add(base.Address, TargetContext_Offset), 0, TargetContext_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:TargetContext");
			}
			else
			{
				EnumMarshaler<EEQCType>.ToNative(IntPtr.Add(base.Address, TargetContext_Offset), 0, TargetContext_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle:AngleMin")]
	private float AngleMin
	{
		get
		{
			CheckDestroyed();
			if (!AngleMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:AngleMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:AngleMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleMin_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle:AngleMax")]
	private float AngleMax
	{
		get
		{
			CheckDestroyed();
			if (!AngleMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:AngleMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_CheckAngle:AngleMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleMax_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle:ShouldPrepareContext")]
	protected override bool ShouldPrepareContext_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_CheckAngle:ProcessItemCS")]
	protected override bool ProcessItemCS_Implementation(UWorld World, FVector ItemLocation, AActor ItemActor, AActor Querier)
	{
		if (Querier.IsNullOrDestroyed())
		{
			return true;
		}
		AActor actorByEQCType = b1.EQSFuncLibForCS.GetActorByEQCType(BaseContext, Querier);
		AActor actorByEQCType2 = b1.EQSFuncLibForCS.GetActorByEQCType(TargetContext, Querier);
		if (actorByEQCType.IsNullOrDestroyed() || actorByEQCType2.IsNullOrDestroyed())
		{
			return false;
		}
		FVector x = BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByEQCType2) - BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByEQCType);
		FVector x2 = ItemLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByEQCType);
		FRotator fRotator = MathLib.MakeRotFromX(x);
		FRotator fRotator2 = MathLib.MakeRotFromX(x2);
		float num = fRotator.Yaw - fRotator2.Yaw;
		if (num > AngleMin && num < AngleMax)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_CheckAngle:ProcessItemCS")]
	private static void ProcessItemCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_CheckAngle gSEQT_CheckAngle = GCHelper.Find<GSEQT_CheckAngle>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, ProcessItemCS_World_Offset));
		FVector itemLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemLocation_Offset));
		AActor itemActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemActor_Offset));
		AActor querier = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_Querier_Offset));
		bool value = gSEQT_CheckAngle.ProcessItemCS_Implementation(world, itemLocation, itemActor, querier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_CheckAngle:ShouldPrepareContext")]
	private static void ShouldPrepareContext__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_CheckAngle gSEQT_CheckAngle = GCHelper.Find<GSEQT_CheckAngle>(obj);
		bool value = gSEQT_CheckAngle.ShouldPrepareContext_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQT_CheckAngle");
		NativeReflection.GetPropertyRef(ref BaseContext_PropertyAddress, intPtr, "BaseContext");
		BaseContext_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseContext");
		BaseContext_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseContext", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TargetContext_PropertyAddress, intPtr, "TargetContext");
		TargetContext_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetContext");
		TargetContext_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetContext", Classes.FEnumProperty);
		AngleMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleMin");
		AngleMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleMin", Classes.FFloatProperty);
		AngleMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleMax");
		AngleMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleMax", Classes.FFloatProperty);
		ProcessItemCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProcessItemCS");
		ProcessItemCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessItemCS_FunctionAddress);
		ProcessItemCS_World_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "World");
		ProcessItemCS_World_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProcessItemCS_ItemLocation_PropertyAddress, ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemLocation", Classes.FStructProperty);
		ProcessItemCS_ItemActor_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemActor");
		ProcessItemCS_ItemActor_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemActor", Classes.FObjectProperty);
		ProcessItemCS_Querier_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "Querier");
		ProcessItemCS_Querier_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProcessItemCS_ReturnValue_PropertyAddress, ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProcessItemCS_IsValid = ProcessItemCS_FunctionAddress != IntPtr.Zero && ProcessItemCS_World_IsValid && ProcessItemCS_ItemLocation_IsValid && ProcessItemCS_ItemActor_IsValid && ProcessItemCS_Querier_IsValid && ProcessItemCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_CheckAngle:ProcessItemCS", ProcessItemCS_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_CheckAngle:ShouldPrepareContext", ShouldPrepareContext_IsValid);
	}

	static GSEQT_CheckAngle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQT_CheckAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQT_CheckAngle));
	}
}
