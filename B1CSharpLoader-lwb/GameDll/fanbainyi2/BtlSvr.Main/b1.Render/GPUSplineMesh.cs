using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[USharpPath("/Script/b1-Managed.GPUSplineMesh")]
public class GPUSplineMesh : ABGUPlacedEditorUtilityBase
{
	private USplineComponent SplineComp;

	private UInstancedStaticMeshComponent InstancedSMComp;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[USharpPath("/Script/b1-Managed.GPUSplineMesh:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		if (SplineComp.IsNullOrDestroyed())
		{
			SplineComp = GetComponentByClass<USplineComponent>();
		}
		if (InstancedSMComp.IsNullOrDestroyed())
		{
			InstancedSMComp = GetComponentByClass<UInstancedStaticMeshComponent>();
		}
		if (!SplineComp.IsNullOrDestroyed() && !InstancedSMComp.IsNullOrDestroyed() && !InstancedSMComp.StaticMesh.IsNullOrDestroyed())
		{
			int numberOfSplinePoints = SplineComp.GetNumberOfSplinePoints();
			InstancedSMComp.ClearInstances();
			for (int i = 0; i <= numberOfSplinePoints - 2; i++)
			{
				FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.World);
				FVector tangentAtSplinePoint = SplineComp.GetTangentAtSplinePoint(i, ESplineCoordinateSpace.World);
				FVector locationAtSplinePoint2 = SplineComp.GetLocationAtSplinePoint(i + 1, ESplineCoordinateSpace.World);
				FVector tangentAtSplinePoint2 = SplineComp.GetTangentAtSplinePoint(i + 1, ESplineCoordinateSpace.World);
				InstancedSMComp.AddInstance(new FTransform(new FVector(0.0, 0.0, 0.0)));
				SetCustomVectorData(i, 0, locationAtSplinePoint);
				SetCustomVectorData(i, 3, tangentAtSplinePoint);
				SetCustomVectorData(i, 6, locationAtSplinePoint2);
				SetCustomVectorData(i, 9, tangentAtSplinePoint2);
				float customDataValue = (float)numberOfSplinePoints + (float)(i + 1) * 0.01f;
				InstancedSMComp.SetCustomDataValue(i, 12, customDataValue);
			}
		}
	}

	private void SetCustomVectorData(int InstanceID, int StartIndex, FVector Data)
	{
		InstancedSMComp.SetCustomDataValue(InstanceID, StartIndex, (float)Data[0], bMarkRenderStateDirty: true);
		InstancedSMComp.SetCustomDataValue(InstanceID, StartIndex + 1, (float)Data[1], bMarkRenderStateDirty: true);
		InstancedSMComp.SetCustomDataValue(InstanceID, StartIndex + 2, (float)Data[2], bMarkRenderStateDirty: true);
	}

	[UFunctionInvoker("/Script/b1-Managed.GPUSplineMesh:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		GPUSplineMesh gPUSplineMesh = GCHelper.Find<GPUSplineMesh>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		gPUSplineMesh.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GPUSplineMesh");
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GPUSplineMesh:ReceiveTick", ReceiveTick_IsValid);
	}

	static GPUSplineMesh()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GPUSplineMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GPUSplineMesh));
	}
}
