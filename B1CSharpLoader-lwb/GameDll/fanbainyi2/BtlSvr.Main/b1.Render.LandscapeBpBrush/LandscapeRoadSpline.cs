using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render.LandscapeBpBrush;

[UClass]
[USharpPath("/Script/b1-Managed.LandscapeRoadSpline")]
internal class LandscapeRoadSpline : ABGUPlacedEditorUtilityBase
{
	private USplineComponent SplineComp;

	private bool IsDirty;

	private float LastSplineLen;

	private static bool RoadWidth_IsValid;

	private static int RoadWidth_Offset;

	private static bool SplineMesh_IsValid;

	private static int SplineMesh_Offset;

	private static bool RoadMaterial_IsValid;

	private static int RoadMaterial_Offset;

	private static bool NodeWidth_IsValid;

	private static int NodeWidth_Offset;

	private static FFieldAddress NodeWidth_PropertyAddress;

	private TArrayReadWriteMarshaler<float> NodeWidth_Marshaler;

	private static bool RoadRVT_IsValid;

	private static int RoadRVT_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LandscapeRoadSpline:RoadWidth")]
	public float RoadWidth
	{
		get
		{
			CheckDestroyed();
			if (!RoadWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:RoadWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RoadWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoadWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:RoadWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RoadWidth_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeRoadSpline:SplineMesh")]
	public UStaticMesh SplineMesh
	{
		get
		{
			CheckDestroyed();
			if (!SplineMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:SplineMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, SplineMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:SplineMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, SplineMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeRoadSpline:RoadMaterial")]
	public UMaterialInterface RoadMaterial
	{
		get
		{
			CheckDestroyed();
			if (!RoadMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:RoadMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, RoadMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoadMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:RoadMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, RoadMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LandscapeRoadSpline:NodeWidth")]
	public TArrayReadWrite<float> NodeWidth
	{
		get
		{
			CheckDestroyed();
			if (!NodeWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:NodeWidth");
				return null;
			}
			if (NodeWidth_Marshaler == null)
			{
				NodeWidth_Marshaler = new TArrayReadWriteMarshaler<float>(1, NodeWidth_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return NodeWidth_Marshaler.FromNative(IntPtr.Add(base.Address, NodeWidth_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeRoadSpline:RoadRVT")]
	public URuntimeVirtualTexture RoadRVT
	{
		get
		{
			CheckDestroyed();
			if (!RoadRVT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:RoadRVT");
				return null;
			}
			return UObjectMarshaler<URuntimeVirtualTexture>.FromNative(IntPtr.Add(base.Address, RoadRVT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoadRVT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadSpline:RoadRVT");
			}
			else
			{
				UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(base.Address, RoadRVT_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.LandscapeRoadSpline:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		if (SplineComp.IsNullOrDestroyed())
		{
			SplineComp = GetComponentByClass<USplineComponent>();
		}
		if (SplineComp.IsNullOrDestroyed() || SplineMesh.IsNullOrDestroyed() || RoadRVT.IsNullOrDestroyed())
		{
			return;
		}
		int numberOfSplinePoints = SplineComp.GetNumberOfSplinePoints();
		List<UActorComponent> componentsByClass = GetComponentsByClass(UClass.GetClass<USplineMeshComponent>());
		int count = componentsByClass.Count;
		if (count < numberOfSplinePoints - 1)
		{
			IsDirty = true;
			for (int i = 1; i <= numberOfSplinePoints - 1 - count; i++)
			{
				USplineMeshComponent uSplineMeshComponent = UObject.NewObject<USplineMeshComponent>(this);
				uSplineMeshComponent.SetStaticMesh(SplineMesh);
				UBGUFunctionLibrary.SerializeActorComponentToLevelActor(this, uSplineMeshComponent);
				uSplineMeshComponent.AttachToComponent(base.RootComponent, new FName(""), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
				UGSE_EngineFuncLib.RegisterComponent(uSplineMeshComponent);
			}
			return;
		}
		if (count > numberOfSplinePoints - 1)
		{
			for (int j = numberOfSplinePoints - 1 + 1; j <= count; j++)
			{
				(componentsByClass[j - 1] as USplineMeshComponent).SetVisibility(bNewVisibility: false);
			}
		}
		float splineLength = SplineComp.GetSplineLength();
		if (splineLength != LastSplineLen)
		{
			IsDirty = true;
			LastSplineLen = splineLength;
		}
		if (!IsDirty)
		{
			return;
		}
		IsDirty = false;
		for (int k = 0; k < numberOfSplinePoints - 1; k++)
		{
			USplineMeshComponent uSplineMeshComponent2 = null;
			if (k <= count - 1)
			{
				FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(k, ESplineCoordinateSpace.World);
				FVector leaveTangentAtSplinePoint = SplineComp.GetLeaveTangentAtSplinePoint(k, ESplineCoordinateSpace.World);
				FVector locationAtSplinePoint2 = SplineComp.GetLocationAtSplinePoint(k + 1, ESplineCoordinateSpace.World);
				FVector arriveTangentAtSplinePoint = SplineComp.GetArriveTangentAtSplinePoint(k + 1, ESplineCoordinateSpace.World);
				uSplineMeshComponent2 = componentsByClass[k] as USplineMeshComponent;
				uSplineMeshComponent2.SetVisibility(bNewVisibility: true);
				if (uSplineMeshComponent2.GetMaterial(0) != RoadMaterial)
				{
					uSplineMeshComponent2.SetMaterial(0, RoadMaterial);
				}
				if (uSplineMeshComponent2.StaticMesh != SplineMesh)
				{
					uSplineMeshComponent2.SetStaticMesh(SplineMesh);
				}
				uSplineMeshComponent2.SetStartPosition(locationAtSplinePoint);
				uSplineMeshComponent2.SetStartTangent(leaveTangentAtSplinePoint);
				uSplineMeshComponent2.SetEndPosition(locationAtSplinePoint2);
				uSplineMeshComponent2.SetEndTangent(arriveTangentAtSplinePoint);
				float num = RoadWidth;
				float num2 = RoadWidth;
				if (k < NodeWidth.Count)
				{
					num += NodeWidth[k];
				}
				if (k + 1 < NodeWidth.Count)
				{
					num2 += NodeWidth[k + 1];
				}
				uSplineMeshComponent2.SetStartScale(new FVector2D(num, 1.0), bUpdateMesh: false);
				uSplineMeshComponent2.SetEndScale(new FVector2D(num2, 1.0), bUpdateMesh: false);
				float distanceAlongSplineAtSplinePoint = SplineComp.GetDistanceAlongSplineAtSplinePoint(k);
				float distanceAlongSplineAtSplinePoint2 = SplineComp.GetDistanceAlongSplineAtSplinePoint(k + 1);
				uSplineMeshComponent2.SetCustomPrimitiveDataFloat(0, distanceAlongSplineAtSplinePoint);
				uSplineMeshComponent2.SetCustomPrimitiveDataFloat(1, distanceAlongSplineAtSplinePoint2);
				uSplineMeshComponent2.SetCustomPrimitiveDataFloat(2, splineLength);
				uSplineMeshComponent2.SetCustomPrimitiveDataVector2(3, locationAtSplinePoint.Conv_VectorToVector2D());
				uSplineMeshComponent2.SetCustomPrimitiveDataVector2(5, leaveTangentAtSplinePoint.Conv_VectorToVector2D());
				uSplineMeshComponent2.SetCustomPrimitiveDataVector2(7, locationAtSplinePoint2.Conv_VectorToVector2D());
				uSplineMeshComponent2.SetCustomPrimitiveDataVector2(9, arriveTangentAtSplinePoint.Conv_VectorToVector2D());
				if (!UGSFuncLibForEditor.ContainRuntimeVirtualTexture(uSplineMeshComponent2, RoadRVT))
				{
					UGSFuncLibForEditor.ClearRuntimeVirtualTexture(uSplineMeshComponent2);
					UGSFuncLibForEditor.AddRuntimeVirtualTexture(uSplineMeshComponent2, RoadRVT);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeRoadSpline:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.LandscapeBpBrush.LandscapeRoadSpline landscapeRoadSpline = GCHelper.Find<b1.Render.LandscapeBpBrush.LandscapeRoadSpline>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		landscapeRoadSpline.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.LandscapeRoadSpline");
		RoadWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "RoadWidth");
		RoadWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RoadWidth", Classes.FFloatProperty);
		SplineMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineMesh");
		SplineMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineMesh", Classes.FObjectProperty);
		RoadMaterial_Offset = NativeReflection.GetPropertyOffset(intPtr, "RoadMaterial");
		RoadMaterial_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RoadMaterial", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref NodeWidth_PropertyAddress, intPtr, "NodeWidth");
		NodeWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "NodeWidth");
		NodeWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NodeWidth", Classes.FArrayProperty);
		RoadRVT_Offset = NativeReflection.GetPropertyOffset(intPtr, "RoadRVT");
		RoadRVT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RoadRVT", Classes.FObjectProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeRoadSpline:ReceiveTick", ReceiveTick_IsValid);
	}

	static LandscapeRoadSpline()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Render.LandscapeBpBrush.LandscapeRoadSpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Render.LandscapeBpBrush.LandscapeRoadSpline));
	}
}
