using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckInAngle")]
public class BAID_CheckInAngle : BAID_Base
{
	private static bool CheckTarget_IsValid;

	private static int CheckTarget_Offset;

	private static FFieldAddress CheckTarget_PropertyAddress;

	private static bool LeftAngle_IsValid;

	private static int LeftAngle_Offset;

	private static bool RightAngle_IsValid;

	private static int RightAngle_Offset;

	private static bool UseSocketDirection_IsValid;

	private static int UseSocketDirection_Offset;

	private static FFieldAddress UseSocketDirection_PropertyAddress;

	private static bool DirectionBaseSocket_IsValid;

	private static int DirectionBaseSocket_Offset;

	private static bool ForwardSocket_IsValid;

	private static int ForwardSocket_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckInAngle:CheckTarget")]
	public EAICheckTarget CheckTarget
	{
		get
		{
			CheckDestroyed();
			if (!CheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:CheckTarget");
				return EAICheckTarget.CachedScencItem;
			}
			return EnumMarshaler<EAICheckTarget>.FromNative(IntPtr.Add(base.Address, CheckTarget_Offset), 0, CheckTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:CheckTarget");
			}
			else
			{
				EnumMarshaler<EAICheckTarget>.ToNative(IntPtr.Add(base.Address, CheckTarget_Offset), 0, CheckTarget_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckInAngle:LeftAngle")]
	public float LeftAngle
	{
		get
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:LeftAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeftAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:LeftAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeftAngle_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckInAngle:RightAngle")]
	public float RightAngle
	{
		get
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:RightAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RightAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:RightAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RightAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckInAngle:UseSocketDirection")]
	public bool UseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:UseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:UseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[USharpPath("/Script/b1-Managed.BAID_CheckInAngle:DirectionBaseSocket")]
	public FName DirectionBaseSocket
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:DirectionBaseSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:DirectionBaseSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[USharpPath("/Script/b1-Managed.BAID_CheckInAngle:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckInAngle:ForwardSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ForwardSocket_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			return false;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(aBGUCharacter) as ABGUCharacter;
		switch (CheckTarget)
		{
		case EAICheckTarget.CurLockTarget:
			aActor = BGUFunctionLibraryCS.BGUGetTarget(aBGUCharacter) as ABGUCharacter;
			break;
		case EAICheckTarget.CachedScencItem:
			aActor = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(aBGUCharacter).SceneItemCatch;
			break;
		}
		if (aActor == null)
		{
			return false;
		}
		FRotator myDirRot = BGUFuncLibActorTransformCS.BGUGetActorRotation(aBGUCharacter);
		if (UseSocketDirection && aBGUCharacter.Mesh != null)
		{
			FVector socketLocation = aBGUCharacter.Mesh.GetSocketLocation(DirectionBaseSocket);
			FVector socketLocation2 = aBGUCharacter.Mesh.GetSocketLocation(ForwardSocket);
			if (aBGUCharacter.Mesh.DoesSocketExist(DirectionBaseSocket) && aBGUCharacter.Mesh.DoesSocketExist(ForwardSocket))
			{
				myDirRot = (socketLocation2 - socketLocation).ProjectVectorOnToPlane(FVector.UpVector).Rotation();
			}
		}
		float num = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter), myDirRot, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor));
		float num2 = FMath.Min(LeftAngle, RightAngle);
		float num3 = FMath.Max(LeftAngle, RightAngle);
		if (num >= num2 && num <= num3)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckInAngle");
		NativeReflection.GetPropertyRef(ref CheckTarget_PropertyAddress, unrealStruct, "CheckTarget");
		CheckTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckTarget");
		CheckTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckTarget", Classes.FEnumProperty);
		LeftAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeftAngle");
		LeftAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeftAngle", Classes.FFloatProperty);
		RightAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightAngle");
		RightAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseSocketDirection_PropertyAddress, unrealStruct, "UseSocketDirection");
		UseSocketDirection_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSocketDirection");
		UseSocketDirection_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSocketDirection", Classes.FBoolProperty);
		DirectionBaseSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionBaseSocket");
		DirectionBaseSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionBaseSocket", Classes.FNameProperty);
		ForwardSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardSocket");
		ForwardSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardSocket", Classes.FNameProperty);
	}

	static BAID_CheckInAngle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckInAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckInAngle));
	}
}
