using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.CurveSourceInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ICurveSourceInterfaceImpl))]
public interface ICurveSourceInterface : IInterface
{
	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.CurveSourceInterface:GetCurveValue")]
	float GetCurveValue(FName CurveName);

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Engine.CurveSourceInterface:GetCurves")]
	void GetCurves(out List<FNamedCurveValue> OutValues);

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.CurveSourceInterface:GetBindingName")]
	FName GetBindingName();
}
