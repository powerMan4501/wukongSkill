using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("SetCameraTransform")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_SetCameraTransform")]
public class BED_QuestNode_SetCameraTransform : BED_QuestNode
{
	private static bool CameraTag_IsValid;

	private static int CameraTag_Offset;

	private static bool bCineCamera_IsValid;

	private static int bCineCamera_Offset;

	private static FFieldAddress bCineCamera_PropertyAddress;

	private static bool CameraTransform_IsValid;

	private static int CameraTransform_Offset;

	[EditAnywhere]
	[Category("Camera")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:CameraTag")]
	public FName CameraTag
	{
		get
		{
			CheckDestroyed();
			if (!CameraTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:CameraTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CameraTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:CameraTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CameraTag_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Camera")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:bCineCamera")]
	public bool bCineCamera
	{
		get
		{
			CheckDestroyed();
			if (!bCineCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:bCineCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCineCamera_Offset), 0, bCineCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCineCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:bCineCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCineCamera_Offset), 0, bCineCamera_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Camera")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:CameraTransform")]
	public FTransform CameraTransform
	{
		get
		{
			CheckDestroyed();
			if (!CameraTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:CameraTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, CameraTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SetCameraTransform:CameraTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, CameraTransform_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SetCameraTransform;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_SetCameraTransform
		{
			CameraTag = CameraTag.PlainName,
			IsCineCamera = bCineCamera,
			CameraTransformX = CameraTransform.Translation.X,
			CameraTransformY = CameraTransform.Translation.Y,
			CameraTransformZ = CameraTransform.Translation.Z,
			CameraTransformPitch = CameraTransform.Rotator().Pitch,
			CameraTransformYaw = CameraTransform.Rotator().Yaw,
			CameraTransformRoll = CameraTransform.Rotator().Roll,
			CameraTransformSx = CameraTransform.Scale3D.X,
			CameraTransformSy = CameraTransform.Scale3D.Y,
			CameraTransformSz = CameraTransform.Scale3D.Z
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_SetCameraTransform");
		CameraTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraTag");
		CameraTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bCineCamera_PropertyAddress, unrealStruct, "bCineCamera");
		bCineCamera_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCineCamera");
		bCineCamera_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCineCamera", Classes.FBoolProperty);
		CameraTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraTransform");
		CameraTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraTransform", Classes.FStructProperty);
	}

	static BED_QuestNode_SetCameraTransform()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_SetCameraTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_SetCameraTransform));
	}
}
