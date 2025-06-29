using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle")]
internal class BAID_CheckUpAxisAngle : BAID_Base
{
	private static bool MinAngle_IsValid;

	private static int MinAngle_Offset;

	private static bool MaxAngle_IsValid;

	private static int MaxAngle_Offset;

	private static bool UseSocketDirection_IsValid;

	private static int UseSocketDirection_Offset;

	private static FFieldAddress UseSocketDirection_PropertyAddress;

	private static bool DirectionBaseSocket_IsValid;

	private static int DirectionBaseSocket_Offset;

	private static bool ForwardSocket_IsValid;

	private static int ForwardSocket_Offset;

	private static bool UpSocket_IsValid;

	private static int UpSocket_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle:MinAngle")]
	public float MinAngle
	{
		get
		{
			CheckDestroyed();
			if (!MinAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:MinAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:MinAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle:MaxAngle")]
	public float MaxAngle
	{
		get
		{
			CheckDestroyed();
			if (!MaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:MaxAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:MaxAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle:UseSocketDirection")]
	public bool UseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:UseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:UseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle:DirectionBaseSocket")]
	public FName DirectionBaseSocket
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:DirectionBaseSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:DirectionBaseSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:ForwardSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ForwardSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUpAxisAngle:UpSocket")]
	public FName UpSocket
	{
		get
		{
			CheckDestroyed();
			if (!UpSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:UpSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UpSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUpAxisAngle:UpSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UpSocket_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		FVector a = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(OwnerActor);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorUpVector(OwnerActor);
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (UseSocketDirection && aCharacter != null && aCharacter.Mesh != null)
		{
			FVector socketLocation = aCharacter.Mesh.GetSocketLocation(DirectionBaseSocket);
			FVector socketLocation2 = aCharacter.Mesh.GetSocketLocation(ForwardSocket);
			FVector socketLocation3 = aCharacter.Mesh.GetSocketLocation(UpSocket);
			if (aCharacter.Mesh.DoesSocketExist(DirectionBaseSocket))
			{
				if (aCharacter.Mesh.DoesSocketExist(ForwardSocket))
				{
					a = (socketLocation2 - socketLocation).GetSafeNormal();
				}
				if (aCharacter.Mesh.DoesSocketExist(UpSocket))
				{
					fVector = (socketLocation3 - socketLocation).GetSafeNormal();
				}
			}
		}
		float num = MathLib.DegAcos(FVector.DotProduct(fVector, FVector.UpVector));
		if (FVector.DotProduct(FVector.CrossProduct(a, fVector), FVector.UpVector) < 0f)
		{
			num *= -1f;
		}
		if (MinAngle <= num)
		{
			return num <= MaxAngle;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckUpAxisAngle");
		MinAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinAngle");
		MinAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinAngle", Classes.FFloatProperty);
		MaxAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxAngle");
		MaxAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseSocketDirection_PropertyAddress, unrealStruct, "UseSocketDirection");
		UseSocketDirection_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSocketDirection");
		UseSocketDirection_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSocketDirection", Classes.FBoolProperty);
		DirectionBaseSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionBaseSocket");
		DirectionBaseSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionBaseSocket", Classes.FNameProperty);
		ForwardSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardSocket");
		ForwardSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardSocket", Classes.FNameProperty);
		UpSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpSocket");
		UpSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpSocket", Classes.FNameProperty);
	}

	static BAID_CheckUpAxisAngle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckUpAxisAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckUpAxisAngle));
	}
}
