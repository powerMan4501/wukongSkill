using System;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MFNegativeOverlapComp")]
public class BUS_MFNegativeOverlapComp : UActorCompBaseUObj
{
	private static bool OverlapEnd_IsValid;

	private static IntPtr OverlapEnd_FunctionAddress;

	private static int OverlapEnd_ParamsSize;

	private static bool OverlapEnd_OverlappedComponent_IsValid;

	private static int OverlapEnd_OverlappedComponent_Offset;

	private static bool OverlapEnd_OtherActor_IsValid;

	private static int OverlapEnd_OtherActor_Offset;

	private static bool OverlapEnd_OtherComponent_IsValid;

	private static int OverlapEnd_OtherComponent_Offset;

	private static bool OverlapBegin_IsValid;

	private static IntPtr OverlapBegin_FunctionAddress;

	private static int OverlapBegin_ParamsSize;

	private static bool OverlapBegin_OverlappedComponent_IsValid;

	private static int OverlapBegin_OverlappedComponent_Offset;

	private static bool OverlapBegin_OtherActor_IsValid;

	private static int OverlapBegin_OtherActor_Offset;

	private static bool OverlapBegin_OtherComponent_IsValid;

	private static int OverlapBegin_OtherComponent_Offset;

	private BUC_MFNegativeOverlapData MFNegativeOverlapData { get; set; }

	private BUC_ProjectileBasicData ProjectileBasicData { get; set; }

	public override void OnAttach()
	{
		MFNegativeOverlapData = RequireWritableData<BUC_MFNegativeOverlapData>();
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnMagicFieldDead);
	}

	public override void OnBeginPlay()
	{
		MFNegativeOverlapData.OverlapComp = SelectCompForOverlap(ProjectileBasicData.CheckShapeType);
		if (!(MFNegativeOverlapData.OverlapComp == null))
		{
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(MFNegativeOverlapData.OverlapComp, this, B1GlobalFNames.OverlapBegin);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(MFNegativeOverlapData.OverlapComp, this, B1GlobalFNames.OverlapEnd);
		}
	}

	private UPrimitiveComponent SelectCompForOverlap(EProjectileCheckShapeType ShapeType)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			return null;
		}
		UPrimitiveComponent result = null;
		switch (ShapeType)
		{
		case EProjectileCheckShapeType.BoxShape:
			result = bGUProjectileBaseActor.GetBoxCollisionComp();
			break;
		case EProjectileCheckShapeType.CapsuleShape:
			result = bGUProjectileBaseActor.GetCapsuleCollisionComp();
			break;
		case EProjectileCheckShapeType.SphereShape:
			result = bGUProjectileBaseActor.GetSphereCollisionComp();
			break;
		case EProjectileCheckShapeType.CustomShape:
			result = bGUProjectileBaseActor.GetCustomCollisionComp();
			break;
		}
		return result;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_MFNegativeOverlapComp:OverlapBegin")]
	private void OverlapBegin(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComponent)
	{
		AActor owner = OverlappedComponent.GetOwner();
		if (!(owner == null) && OtherActor is BGUCharacterCS && !(owner == OtherActor))
		{
			MFNegativeOverlapData.InnerActors.Add(OtherActor);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_MFNegativeOverlapComp:OverlapEnd")]
	private void OverlapEnd(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComponent)
	{
		AActor owner = OverlappedComponent.GetOwner();
		if (!(owner == null) && OtherActor is BGUCharacterCS && !(owner == OtherActor))
		{
			MFNegativeOverlapData.InnerActors.Remove(OtherActor);
		}
	}

	protected virtual void OnMagicFieldDead(EBGUBulletDestroyReason Reason)
	{
		if (!(GetOwner() as BGUMagicFieldBaseCS == null) && MFNegativeOverlapData.OverlapComp != null)
		{
			UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(MFNegativeOverlapData.OverlapComp, this, B1GlobalFNames.OverlapBegin);
			UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(MFNegativeOverlapData.OverlapComp, this, B1GlobalFNames.OverlapEnd);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_MFNegativeOverlapComp:OverlapEnd")]
	private static void OverlapEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_MFNegativeOverlapComp bUS_MFNegativeOverlapComp = GCHelper.Find<BUS_MFNegativeOverlapComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OverlapEnd_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OverlapEnd_OtherActor_Offset));
		UPrimitiveComponent otherComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OverlapEnd_OtherComponent_Offset));
		bUS_MFNegativeOverlapComp.OverlapEnd(overlappedComponent, otherActor, otherComponent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_MFNegativeOverlapComp:OverlapBegin")]
	private static void OverlapBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_MFNegativeOverlapComp bUS_MFNegativeOverlapComp = GCHelper.Find<BUS_MFNegativeOverlapComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OverlapBegin_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OverlapBegin_OtherActor_Offset));
		UPrimitiveComponent otherComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OverlapBegin_OtherComponent_Offset));
		bUS_MFNegativeOverlapComp.OverlapBegin(overlappedComponent, otherActor, otherComponent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_MFNegativeOverlapComp");
		OverlapEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OverlapEnd");
		OverlapEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OverlapEnd_FunctionAddress);
		OverlapEnd_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OverlappedComponent");
		OverlapEnd_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OverlapEnd_OtherActor_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OtherActor");
		OverlapEnd_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OverlapEnd_OtherComponent_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OtherComponent");
		OverlapEnd_OtherComponent_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OtherComponent", Classes.FObjectProperty);
		OverlapEnd_IsValid = OverlapEnd_FunctionAddress != IntPtr.Zero && OverlapEnd_OverlappedComponent_IsValid && OverlapEnd_OtherActor_IsValid && OverlapEnd_OtherComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_MFNegativeOverlapComp:OverlapEnd", OverlapEnd_IsValid);
		OverlapBegin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OverlapBegin");
		OverlapBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OverlapBegin_FunctionAddress);
		OverlapBegin_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OverlapBegin_FunctionAddress, "OverlappedComponent");
		OverlapBegin_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OverlapBegin_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OverlapBegin_OtherActor_Offset = NativeReflection.GetPropertyOffset(OverlapBegin_FunctionAddress, "OtherActor");
		OverlapBegin_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OverlapBegin_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OverlapBegin_OtherComponent_Offset = NativeReflection.GetPropertyOffset(OverlapBegin_FunctionAddress, "OtherComponent");
		OverlapBegin_OtherComponent_IsValid = NativeReflection.ValidatePropertyClass(OverlapBegin_FunctionAddress, "OtherComponent", Classes.FObjectProperty);
		OverlapBegin_IsValid = OverlapBegin_FunctionAddress != IntPtr.Zero && OverlapBegin_OverlappedComponent_IsValid && OverlapBegin_OtherActor_IsValid && OverlapBegin_OtherComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_MFNegativeOverlapComp:OverlapBegin", OverlapBegin_IsValid);
	}

	static BUS_MFNegativeOverlapComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MFNegativeOverlapComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MFNegativeOverlapComp));
	}
}
