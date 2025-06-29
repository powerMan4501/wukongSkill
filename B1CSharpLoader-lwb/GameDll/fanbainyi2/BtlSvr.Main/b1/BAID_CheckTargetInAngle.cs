using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckTargetInAngle")]
public class BAID_CheckTargetInAngle : BAID_Base
{
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
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetInAngle:LeftAngle")]
	public float LeftAngle
	{
		get
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:LeftAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeftAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:LeftAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeftAngle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetInAngle:RightAngle")]
	public float RightAngle
	{
		get
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:RightAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RightAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:RightAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RightAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetInAngle:UseSocketDirection")]
	public bool UseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:UseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:UseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetInAngle:DirectionBaseSocket")]
	public FName DirectionBaseSocket
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:DirectionBaseSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:DirectionBaseSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetInAngle:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetInAngle:ForwardSocket");
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
		ABGUCharacter aBGUCharacter2 = BGUFunctionLibraryCS.BGUGetTarget(aBGUCharacter) as ABGUCharacter;
		if (aBGUCharacter2 == null)
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
		float num = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter), myDirRot, BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter2));
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
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckTargetInAngle");
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

	static BAID_CheckTargetInAngle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckTargetInAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckTargetInAngle));
	}
}
