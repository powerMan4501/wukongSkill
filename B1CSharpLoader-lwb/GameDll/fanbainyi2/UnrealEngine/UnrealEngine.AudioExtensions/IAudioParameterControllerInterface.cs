using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioExtensions;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface", "AudioExtensions", UnrealModuleType.Engine, InterfaceImpl = typeof(IAudioParameterControllerInterfaceImpl))]
public interface IAudioParameterControllerInterface : IInterface
{
	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetTriggerParameter")]
	void SetTriggerParameter(FName InName);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringParameter")]
	void SetStringParameter(FName InName, string InValue);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringArrayParameter")]
	void SetStringArrayParameter(FName InName, List<string> InValue);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetParameters_Blueprint")]
	void SetParameters_Blueprint(List<FAudioParameter> InParameters);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectParameter")]
	void SetObjectParameter(FName InName, UObject InValue);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectArrayParameter")]
	void SetObjectArrayParameter(FName InName, List<UObject> InValue);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntParameter")]
	void SetIntParameter(FName InName, int InInt);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntArrayParameter")]
	void SetIntArrayParameter(FName InName, List<int> InValue);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatParameter")]
	void SetFloatParameter(FName InName, float InFloat);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatArrayParameter")]
	void SetFloatArrayParameter(FName InName, List<float> InValue);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolParameter")]
	void SetBoolParameter(FName InName, bool InBool);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolArrayParameter")]
	void SetBoolArrayParameter(FName InName, List<bool> InValue);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:ResetParameters")]
	void ResetParameters();
}
