using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Touch Item")]
[USharpPath("/Script/b1-Managed.BANS_GSTouchItem")]
internal class BANS_GSTouchItem : BANS_GSBase
{
	private float Timer;

	private float TotalTime;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	private static bool TouchIKType_IsValid;

	private static int TouchIKType_Offset;

	private static FFieldAddress TouchIKType_PropertyAddress;

	private static bool FindActorRadius_IsValid;

	private static int FindActorRadius_Offset;

	private static bool TouchActorTag_IsValid;

	private static int TouchActorTag_Offset;

	private static bool TouchActorSocketName_IsValid;

	private static int TouchActorSocketName_Offset;

	private static bool TouchCenterSocketName_IsValid;

	private static int TouchCenterSocketName_Offset;

	private static bool bUseFullBodyIK_IsValid;

	private static int bUseFullBodyIK_Offset;

	private static FFieldAddress bUseFullBodyIK_PropertyAddress;

	private static bool bUseIKPositionOffset_IsValid;

	private static int bUseIKPositionOffset_Offset;

	private static FFieldAddress bUseIKPositionOffset_PropertyAddress;

	private static bool OffsetCurve_IsValid;

	private static int OffsetCurve_Offset;

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

	[EditAnywhere]
	[Category("Anim Notify")]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:TouchIKType")]
	public ETouchIKType TouchIKType
	{
		get
		{
			CheckDestroyed();
			if (!TouchIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchIKType");
				return ETouchIKType.LeftHand;
			}
			return EnumMarshaler<ETouchIKType>.FromNative(IntPtr.Add(base.Address, TouchIKType_Offset), 0, TouchIKType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TouchIKType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchIKType");
			}
			else
			{
				EnumMarshaler<ETouchIKType>.ToNative(IntPtr.Add(base.Address, TouchIKType_Offset), 0, TouchIKType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("搜索目标Actor的球形半径")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:FindActorRadius")]
	public float FindActorRadius
	{
		get
		{
			CheckDestroyed();
			if (!FindActorRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:FindActorRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FindActorRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FindActorRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:FindActorRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FindActorRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:TouchActorTag")]
	public FName TouchActorTag
	{
		get
		{
			CheckDestroyed();
			if (!TouchActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TouchActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TouchActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TouchActorTag_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:TouchActorSocketName")]
	public FName TouchActorSocketName
	{
		get
		{
			CheckDestroyed();
			if (!TouchActorSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchActorSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TouchActorSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TouchActorSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchActorSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TouchActorSocketName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:TouchCenterSocketName")]
	public FName TouchCenterSocketName
	{
		get
		{
			CheckDestroyed();
			if (!TouchCenterSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchCenterSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TouchCenterSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TouchCenterSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:TouchCenterSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TouchCenterSocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:bUseFullBodyIK")]
	public bool bUseFullBodyIK
	{
		get
		{
			CheckDestroyed();
			if (!bUseFullBodyIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:bUseFullBodyIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseFullBodyIK_Offset), 0, bUseFullBodyIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseFullBodyIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:bUseFullBodyIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseFullBodyIK_Offset), 0, bUseFullBodyIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:bUseIKPositionOffset")]
	public bool bUseIKPositionOffset
	{
		get
		{
			CheckDestroyed();
			if (!bUseIKPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:bUseIKPositionOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseIKPositionOffset_Offset), 0, bUseIKPositionOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseIKPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:bUseIKPositionOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseIKPositionOffset_Offset), 0, bUseIKPositionOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bUseIKPositionOffset")]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:OffsetCurve")]
	public UCurveVector OffsetCurve
	{
		get
		{
			CheckDestroyed();
			if (!OffsetCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:OffsetCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, OffsetCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTouchItem:OffsetCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, OffsetCurve_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FindActorRadius = 300f;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null || aCharacter.Mesh == null)
		{
			return;
		}
		IBUC_ABPFootIKData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPFootIKData>(aCharacter);
		if (unPersistentReadOnlyData != null)
		{
			if (!unPersistentReadOnlyData.bActiveTouchIK || unPersistentReadOnlyData.TouchIKTargetActor.IsNullOrDestroyed())
			{
				return;
			}
			float x = 0f;
			if (Timer <= BlendInTime)
			{
				x = Timer / BlendInTime;
			}
			else if (Timer < TotalTime - BlendOutTime)
			{
				x = 1f;
			}
			else if (Timer >= TotalTime - BlendOutTime)
			{
				x = (TotalTime - Timer) / BlendOutTime;
			}
			x = FMath.Clamp(x, 0f, 1f);
			AActor touchIKTargetActor = unPersistentReadOnlyData.TouchIKTargetActor;
			FVector location = BGUFuncLibActorTransformCS.BGUGetActorLocation(touchIKTargetActor);
			List<UActorComponent> componentsByClass = touchIKTargetActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
			if (componentsByClass.Count != 0)
			{
				foreach (UMeshComponent item in componentsByClass)
				{
					if (item.DoesSocketExist(TouchActorSocketName))
					{
						location = item.GetSocketLocation(TouchActorSocketName);
						break;
					}
				}
			}
			if (bUseIKPositionOffset && !OffsetCurve.IsNullOrDestroyed())
			{
				location += OffsetCurve.GetVectorValue(Timer);
			}
			FVector fVector = MathLib.InverseTransformLocation(aCharacter.Mesh.GetWorldTransform(), location);
			FVector socketLocation = aCharacter.Mesh.GetSocketLocation(TouchCenterSocketName);
			ETouchIKType touchIKType = TouchIKType;
			FVector socketLocation2;
			FName inSocketName;
			if (touchIKType == ETouchIKType.LeftHand || touchIKType != ETouchIKType.RightHand)
			{
				socketLocation2 = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.hand_l);
				inSocketName = B1GlobalFNames.VB_root_hand_l;
			}
			else
			{
				socketLocation2 = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.hand_r);
				inSocketName = B1GlobalFNames.VB_root_hand_r;
			}
			FVector iKOffset = fVector - MathLib.InverseTransformLocation(aCharacter.Mesh.GetWorldTransform(), aCharacter.Mesh.GetSocketLocation(inSocketName));
			BUS_EventCollectionCS.Get(aCharacter).Evt_SetTouchIKInfo.Invoke(TouchIKType, iKOffset, socketLocation2 - socketLocation, x);
		}
		Timer += FrameDeltaTime;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			bUS_GSEventCollection.Evt_SetTouchIKActive.Invoke(P1: false, bUseFullBodyIK);
			bUS_GSEventCollection.Evt_SetTouchIKInfo.Invoke(TouchIKType, FVector.ZeroVector, FVector.ZeroVector, 0f);
			bUS_GSEventCollection.Evt_SetTouchIKTargetActor.Invoke(null);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null || aCharacter.Mesh == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		bUS_GSEventCollection.Evt_SetTouchIKActive.Invoke(P1: true, bUseFullBodyIK);
		bUS_GSEventCollection.Evt_SetTouchIKInfo.Invoke(TouchIKType, FVector.ZeroVector, FVector.ZeroVector, 0f);
		List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery>
		{
			EObjectTypeQuery.ObjectTypeQuery3,
			EObjectTypeQuery.ObjectTypeQuery1,
			EObjectTypeQuery.ObjectTypeQuery2
		};
		USystemLibrary.SphereOverlapActors(aCharacter, BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter), FindActorRadius, objectTypes, UClass.GetClass<AActor>(), new List<AActor> { aCharacter }, out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item.ActorHasTag(TouchActorTag))
			{
				bUS_GSEventCollection.Evt_SetTouchIKTargetActor.Invoke(item);
				break;
			}
		}
		Timer = 0f;
		TotalTime = TotalDuration;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTouchItem bANS_GSTouchItem = GCHelper.Find<b1.BANS_GSTouchItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSTouchItem.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTouchItem bANS_GSTouchItem = GCHelper.Find<b1.BANS_GSTouchItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSTouchItem.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTouchItem bANS_GSTouchItem = GCHelper.Find<b1.BANS_GSTouchItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSTouchItem.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTouchItem");
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TouchIKType_PropertyAddress, intPtr, "TouchIKType");
		TouchIKType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchIKType");
		TouchIKType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchIKType", Classes.FEnumProperty);
		FindActorRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "FindActorRadius");
		FindActorRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FindActorRadius", Classes.FFloatProperty);
		TouchActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchActorTag");
		TouchActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchActorTag", Classes.FNameProperty);
		TouchActorSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchActorSocketName");
		TouchActorSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchActorSocketName", Classes.FNameProperty);
		TouchCenterSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TouchCenterSocketName");
		TouchCenterSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TouchCenterSocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bUseFullBodyIK_PropertyAddress, intPtr, "bUseFullBodyIK");
		bUseFullBodyIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseFullBodyIK");
		bUseFullBodyIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseFullBodyIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseIKPositionOffset_PropertyAddress, intPtr, "bUseIKPositionOffset");
		bUseIKPositionOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseIKPositionOffset");
		bUseIKPositionOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseIKPositionOffset", Classes.FBoolProperty);
		OffsetCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetCurve");
		OffsetCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetCurve", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTouchItem:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSTouchItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSTouchItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSTouchItem));
	}
}
