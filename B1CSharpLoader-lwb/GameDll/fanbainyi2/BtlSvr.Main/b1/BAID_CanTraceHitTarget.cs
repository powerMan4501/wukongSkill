using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CanTraceHitTarget")]
internal class BAID_CanTraceHitTarget : BAID_Base
{
	private static bool TraceTypeQuery_IsValid;

	private static int TraceTypeQuery_Offset;

	private static FFieldAddress TraceTypeQuery_PropertyAddress;

	private static bool StartSocketName_IsValid;

	private static int StartSocketName_Offset;

	private static bool TargetSocketName_IsValid;

	private static int TargetSocketName_Offset;

	private static bool TraceDistance_IsValid;

	private static int TraceDistance_Offset;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("射线检测通道")]
	[USharpPath("/Script/b1-Managed.BAID_CanTraceHitTarget:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery
	{
		get
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:TraceTypeQuery");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:TraceTypeQuery");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("SelfSocketName")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CanTraceHitTarget:StartSocketName")]
	public FName StartSocketName
	{
		get
		{
			CheckDestroyed();
			if (!StartSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:StartSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StartSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:StartSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StartSocketName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("TargetSocketName")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CanTraceHitTarget:TargetSocketName")]
	public FName TargetSocketName
	{
		get
		{
			CheckDestroyed();
			if (!TargetSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:TargetSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TargetSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:TargetSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TargetSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("射线距离")]
	[USharpPath("/Script/b1-Managed.BAID_CanTraceHitTarget:TraceDistance")]
	public float TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:TraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("打开调试")]
	[USharpPath("/Script/b1-Managed.BAID_CanTraceHitTarget:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CanTraceHitTarget:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS);
		if (aActor == null)
		{
			return false;
		}
		USceneComponent SocketOwnerComp;
		FTransform socketOrCompTransform = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, bGUCharacterCS, StartSocketName, out SocketOwnerComp);
		USceneComponent SocketOwnerComp2;
		FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, aActor, StartSocketName, out SocketOwnerComp2).GetLocation();
		FVector location2 = socketOrCompTransform.GetLocation();
		FVector safeNormal = (location - location2).GetSafeNormal();
		FVector endTrace = location2 + safeNormal * TraceDistance;
		FHitResultSimple HitResult;
		int num = UBGUSelectUtil.LineTraceSimple(bGUCharacterCS, location2, endTrace, TraceTypeQuery, EnableDebug, out HitResult, null);
		if (num > 0)
		{
			BGUCharacterCS bGUCharacterCS2 = HitResult.HitActor as BGUCharacterCS;
			if (bGUCharacterCS2 != null && bGUCharacterCS2 == aActor)
			{
				if (!EnableDebug)
				{
				}
			}
			else
			{
				num = 0;
			}
		}
		return num > 0;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		TraceDistance = 10000f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CanTraceHitTarget");
		NativeReflection.GetPropertyRef(ref TraceTypeQuery_PropertyAddress, unrealStruct, "TraceTypeQuery");
		TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceTypeQuery");
		TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceTypeQuery", Classes.FEnumProperty);
		StartSocketName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartSocketName");
		StartSocketName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartSocketName", Classes.FNameProperty);
		TargetSocketName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetSocketName");
		TargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetSocketName", Classes.FNameProperty);
		TraceDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceDistance");
		TraceDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, unrealStruct, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableDebug", Classes.FBoolProperty);
	}

	static BAID_CanTraceHitTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CanTraceHitTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CanTraceHitTarget));
	}
}
