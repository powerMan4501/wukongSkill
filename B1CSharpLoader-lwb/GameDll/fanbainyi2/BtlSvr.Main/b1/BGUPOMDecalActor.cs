using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPOMDecalActor")]
public class BGUPOMDecalActor : BGUDecalActor
{
	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_POMDecalCommComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_POMDecalDataComp>(this, B1GlobalFNames.POMDecalDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUPOMDecalActor:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		if (!UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			return;
		}
		FQuat rotation = BGUFuncLibActorTransformCS.BGUGetActorTransform(this).InvertTransform().Rotation;
		FTransform t = new FTransform(rotation, FVector.ZeroVector, FVector.OneVector);
		FMatrix fMatrix = MathLib.TransformToMatrix(t);
		if (!(base.DecalComp == null))
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = base.DecalComp.GetDecalMaterial() as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic == null)
			{
				uMaterialInstanceDynamic = base.DecalComp.CreateDynamicMaterialInstance();
			}
			if (!(uMaterialInstanceDynamic == null))
			{
				FLinearColor value = new FLinearColor(fMatrix.M11, fMatrix.M12, fMatrix.M13, 0.0);
				FLinearColor value2 = new FLinearColor(fMatrix.M21, fMatrix.M22, fMatrix.M23, 0.0);
				FLinearColor value3 = new FLinearColor(fMatrix.M31, fMatrix.M32, fMatrix.M33, 0.0);
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Transform3x1, value);
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Transform3x2, value2);
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Transform3x3, value3);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPOMDecalActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPOMDecalActor bGUPOMDecalActor = GCHelper.Find<BGUPOMDecalActor>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUPOMDecalActor.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUPOMDecalActor");
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPOMDecalActor:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUPOMDecalActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPOMDecalActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPOMDecalActor));
	}
}
