using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Change MI Param")]
[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam")]
public class BANS_GSChangeMIParam : BANS_GSBase
{
	private UMaterialInstanceDynamic MID;

	private float Timer;

	private float TotalTime;

	private static bool TargetMaterialName_IsValid;

	private static int TargetMaterialName_Offset;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool ParamStart_IsValid;

	private static int ParamStart_Offset;

	private static bool ParamEnd_IsValid;

	private static int ParamEnd_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[DisplayName("目标材质名")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:TargetMaterialName")]
	public string TargetMaterialName
	{
		get
		{
			CheckDestroyed();
			if (!TargetMaterialName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:TargetMaterialName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TargetMaterialName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetMaterialName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:TargetMaterialName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TargetMaterialName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("参数名")]
	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:ParamName")]
	public FName ParamName
	{
		get
		{
			CheckDestroyed();
			if (!ParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:ParamName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ParamName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:ParamName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ParamName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("参数起点值")]
	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:ParamStart")]
	public float ParamStart
	{
		get
		{
			CheckDestroyed();
			if (!ParamStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:ParamStart");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ParamStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParamStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:ParamStart");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ParamStart_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("参数终点值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:ParamEnd")]
	public float ParamEnd
	{
		get
		{
			CheckDestroyed();
			if (!ParamEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:ParamEnd");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ParamEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParamEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSChangeMIParam:ParamEnd");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ParamEnd_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		TotalTime = TotalDuration;
		Timer = 0f;
		if (owner == null)
		{
			return;
		}
		List<UActorComponent> componentsByClass = owner.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
		if (componentsByClass.Count != 0)
		{
			foreach (UMeshComponent item in componentsByClass)
			{
				List<UMaterialInterface> materials = item.GetMaterials();
				for (int i = 0; i < materials.Count; i++)
				{
					if (materials[i] != null && materials[i].GetName() == TargetMaterialName)
					{
						MID = GetDynamicMaterial(item, i, materials[i]);
						return;
					}
				}
			}
		}
		owner.GetAllChildActors(out var ChildActors);
		foreach (AActor item2 in ChildActors)
		{
			List<UActorComponent> componentsByClass2 = item2.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
			if (componentsByClass2.Count == 0)
			{
				continue;
			}
			foreach (UMeshComponent item3 in componentsByClass2)
			{
				List<UMaterialInterface> materials2 = item3.GetMaterials();
				for (int j = 0; j < materials2.Count; j++)
				{
					if (materials2[j] != null && materials2[j].GetName() == TargetMaterialName)
					{
						MID = GetDynamicMaterial(item3, j, materials2[j]);
						return;
					}
				}
			}
		}
	}

	private UMaterialInstanceDynamic GetDynamicMaterial(UMeshComponent Mesh, int Index, UMaterialInterface Material)
	{
		if (Material != null)
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = Material as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic == null)
			{
				uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(Mesh, Material, FName.None, EMIDCreationFlags.None);
				Mesh.SetMaterial(Index, uMaterialInstanceDynamic);
			}
			return uMaterialInstanceDynamic;
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		Timer += FrameDeltaTime;
		if (MID != null)
		{
			float value = Timer / TotalTime * (ParamEnd - ParamStart) + ParamStart;
			MID.SetScalarParameterValue(ParamName, value);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (MID != null)
		{
			MID.SetScalarParameterValue(ParamName, ParamEnd);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSChangeMIParam bANS_GSChangeMIParam = GCHelper.Find<BANS_GSChangeMIParam>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSChangeMIParam.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSChangeMIParam bANS_GSChangeMIParam = GCHelper.Find<BANS_GSChangeMIParam>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSChangeMIParam.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSChangeMIParam bANS_GSChangeMIParam = GCHelper.Find<BANS_GSChangeMIParam>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSChangeMIParam.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSChangeMIParam");
		TargetMaterialName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetMaterialName");
		TargetMaterialName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetMaterialName", Classes.FStrProperty);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ParamStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamStart");
		ParamStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamStart", Classes.FFloatProperty);
		ParamEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamEnd");
		ParamEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamEnd", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSChangeMIParam:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSChangeMIParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSChangeMIParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSChangeMIParam));
	}
}
