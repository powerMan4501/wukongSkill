using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render.TressFX;

internal class FakeShadowMapComponent : UActorComponent
{
	private void Init()
	{
	}

	private void RenderCustomDeepShadowMap()
	{
		UPrimitiveComponent componentByClass = GetOwner().GetComponentByClass<UPrimitiveComponent>();
		UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, null, new FName(""), EMIDCreationFlags.None);
		((USceneCaptureComponent)null).CaptureEveryFrame = false;
		((USceneCaptureComponent2D)null).ProjectionType = ECameraProjectionMode.Orthographic;
		((USceneCaptureComponent2D)null).TextureTarget = URenderingLibrary.CreateRenderTarget2D(this, 256, 256, ETextureRenderTargetFormat.RTF_R32f, FLinearColor.Black, bAutoGenerateMipMaps: false);
		((USceneCaptureComponent)null).CaptureSource = ESceneCaptureSource.SCS_SceneDepth;
		((USceneCaptureComponent)null).ShowOnlyComponent(componentByClass);
		componentByClass.SetMaterial(1, null);
		((USceneCaptureComponent2D)null).OrthoWidth = 0f;
		uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Light, FLinearColor.White);
		((USceneCaptureComponent2D)null).CaptureScene();
		URenderingLibrary.DrawMaterialToRenderTarget(this, null, null);
	}

	private void RenderCustom()
	{
	}
}
