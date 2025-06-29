using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员: 设置位置/旋转")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform")]
internal class BED_MovieNode_PerformerSetTransform : b1.BED_MovieNode_PerformerAction
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	private static bool bPlayerAsPerformer_IsValid;

	private static int bPlayerAsPerformer_Offset;

	private static FFieldAddress bPlayerAsPerformer_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:Transform")]
	public FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("Player作为演员")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:bPlayerAsPerformer")]
	public bool bPlayerAsPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:bPlayerAsPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:bPlayerAsPerformer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		Transform = FTransform.Identity;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerSetTransform;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerSetTransform
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			TransformX = Transform.Translation.X,
			TransformY = Transform.Translation.Y,
			TransformZ = Transform.Translation.Z,
			TransformPitch = Transform.Rotator().Pitch,
			TransformYaw = Transform.Rotator().Yaw,
			TransformRoll = Transform.Rotator().Roll,
			TransformSx = Transform.Scale3D.X,
			TransformSy = Transform.Scale3D.Y,
			TransformSz = Transform.Scale3D.Z,
			IsPlayerAsPerformer = bPlayerAsPerformer
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (bPlayerAsPerformer)
		{
			stringBuilder.AppendLine("演员： Player");
		}
		else
		{
			stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		}
		stringBuilder.Append("Transform： \n" + Transform.ToHumanReadableString());
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerSetTransform bED_MovieNode_PerformerSetTransform = GCHelper.Find<b1.BED_MovieNode_PerformerSetTransform>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerSetTransform.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform");
		Transform_Offset = NativeReflection.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsPerformer_PropertyAddress, intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsPerformer", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerSetTransform:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerSetTransform()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerSetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerSetTransform));
	}
}
