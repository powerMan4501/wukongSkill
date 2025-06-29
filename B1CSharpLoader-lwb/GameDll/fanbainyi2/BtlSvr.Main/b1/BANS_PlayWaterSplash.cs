using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Play Water Splash")]
[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash")]
internal class BANS_PlayWaterSplash : BANS_GSBase
{
	private static bool MappingID_IsValid;

	private static int MappingID_Offset;

	private static bool SweepRadius_IsValid;

	private static int SweepRadius_Offset;

	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static bool SocketNameList_IsValid;

	private static int SocketNameList_Offset;

	private static FFieldAddress SocketNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SocketNameList_Marshaler;

	private static bool PresetLocalPoints_IsValid;

	private static int PresetLocalPoints_Offset;

	private static FFieldAddress PresetLocalPoints_PropertyAddress;

	private TMapReadWriteMarshaler<float, FVector> PresetLocalPoints_Marshaler;

	private static bool PresetLocalSweepTangentArray_IsValid;

	private static int PresetLocalSweepTangentArray_Offset;

	private static FFieldAddress PresetLocalSweepTangentArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> PresetLocalSweepTangentArray_Marshaler;

	private static bool bDrawDebug_IsValid;

	private static int bDrawDebug_Offset;

	private static FFieldAddress bDrawDebug_PropertyAddress;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:MappingID")]
	public int MappingID
	{
		get
		{
			CheckDestroyed();
			if (!MappingID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:MappingID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MappingID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappingID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:MappingID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MappingID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("用于定义，取到点后，往下打多少长度的射线")]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:SweepRadius")]
	public float SweepRadius
	{
		get
		{
			CheckDestroyed();
			if (!SweepRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:SweepRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SweepRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SweepRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:SweepRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SweepRadius_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:WeaponIndex")]
	public int WeaponIndex
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:WeaponIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeaponIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:WeaponIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeaponIndex_Offset), value);
			}
		}
	}

	[Tooltip("存在预制点集时优先使用预制点集")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:SocketNameList")]
	public TArrayReadWrite<FName> SocketNameList
	{
		get
		{
			CheckDestroyed();
			if (!SocketNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:SocketNameList");
				return null;
			}
			if (SocketNameList_Marshaler == null)
			{
				SocketNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SocketNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SocketNameList_Marshaler.FromNative(IntPtr.Add(base.Address, SocketNameList_Offset));
		}
	}

	[Tooltip("<时间戳，本地坐标>")]
	[DisplayName("预制点集")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:PresetLocalPoints")]
	public TMapReadWrite<float, FVector> PresetLocalPoints
	{
		get
		{
			CheckDestroyed();
			if (!PresetLocalPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:PresetLocalPoints");
				return null;
			}
			if (PresetLocalPoints_Marshaler == null)
			{
				PresetLocalPoints_Marshaler = new TMapReadWriteMarshaler<float, FVector>(1, PresetLocalPoints_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return PresetLocalPoints_Marshaler.FromNative(IntPtr.Add(base.Address, PresetLocalPoints_Offset));
		}
	}

	[Tooltip("<本地挥舞切线方向>")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("预制挥舞切线方向")]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:PresetLocalSweepTangentArray")]
	public TArrayReadWrite<FVector> PresetLocalSweepTangentArray
	{
		get
		{
			CheckDestroyed();
			if (!PresetLocalSweepTangentArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:PresetLocalSweepTangentArray");
				return null;
			}
			if (PresetLocalSweepTangentArray_Marshaler == null)
			{
				PresetLocalSweepTangentArray_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, PresetLocalSweepTangentArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return PresetLocalSweepTangentArray_Marshaler.FromNative(IntPtr.Add(base.Address, PresetLocalSweepTangentArray_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:bDrawDebug")]
	public bool bDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_PlayWaterSplash:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SweepRadius = 50f;
		WeaponIndex = -1;
		bDrawDebug = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			int uniqueID = (int)GetUniqueID();
			int fromInstanceID = NotifyParam.FromInstanceID;
			FWaterSplashSweepConfig sweepConfig = new FWaterSplashSweepConfig(MappingID, SweepRadius, WeaponIndex, SocketNameList, PresetLocalPoints, PresetLocalSweepTangentArray);
			BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_WaterSplashSweepBegin.Invoke(uniqueID, fromInstanceID, sweepConfig);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner) && bDrawDebug)
		{
			DrawDebug(NotifyParam.MeshComp);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			int uniqueID = (int)GetUniqueID();
			int fromInstanceID = NotifyParam.FromInstanceID;
			BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_WaterSplashSweepEnd.Invoke(uniqueID, fromInstanceID);
		}
	}

	private void DrawDebug(USkeletalMeshComponent MeshComp)
	{
		FTransform worldTransform = MeshComp.GetWorldTransform();
		int num = 0;
		foreach (KeyValuePair<float, FVector> presetLocalPoint in PresetLocalPoints)
		{
			FVector fVector = worldTransform.TransformPosition(presetLocalPoint.Value);
			USystemLibrary.DrawDebugSphere(MeshComp, fVector, SweepRadius, 12, FLinearColor.Aqua, 0f, 2f);
			if (PresetLocalSweepTangentArray.Count > num)
			{
				FVector fVector2 = worldTransform.TransformPosition(PresetLocalSweepTangentArray[num]);
				USystemLibrary.DrawDebugArrow(MeshComp, fVector, fVector + fVector2 * 500.0, 50f, FLinearColor.Aqua, 0f, 2f);
			}
			num++;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlayWaterSplash bANS_PlayWaterSplash = GCHelper.Find<b1.BANS_PlayWaterSplash>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_PlayWaterSplash.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlayWaterSplash bANS_PlayWaterSplash = GCHelper.Find<b1.BANS_PlayWaterSplash>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_PlayWaterSplash.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_PlayWaterSplash bANS_PlayWaterSplash = GCHelper.Find<b1.BANS_PlayWaterSplash>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_PlayWaterSplash.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_PlayWaterSplash");
		MappingID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappingID");
		MappingID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappingID", Classes.FIntProperty);
		SweepRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepRadius");
		SweepRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepRadius", Classes.FFloatProperty);
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SocketNameList_PropertyAddress, intPtr, "SocketNameList");
		SocketNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketNameList");
		SocketNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketNameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PresetLocalPoints_PropertyAddress, intPtr, "PresetLocalPoints");
		PresetLocalPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "PresetLocalPoints");
		PresetLocalPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PresetLocalPoints", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref PresetLocalSweepTangentArray_PropertyAddress, intPtr, "PresetLocalSweepTangentArray");
		PresetLocalSweepTangentArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "PresetLocalSweepTangentArray");
		PresetLocalSweepTangentArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PresetLocalSweepTangentArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebug_PropertyAddress, intPtr, "bDrawDebug");
		bDrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawDebug");
		bDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_PlayWaterSplash:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_PlayWaterSplash()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_PlayWaterSplash)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_PlayWaterSplash));
	}
}
