using UnrealEngine.Runtime;

namespace b1.AutoQA;

public interface ICSharpTestCase
{
	float TimeLimit { get; }

	string TestLabel { get; }

	UObject WorldContext { get; }

	void SetupTest();

	void RunTest();

	void TearDownTest();

	void OnTick(float DeltaTime);

	void SetCaseState(CaseState NewState);

	void Reset();

	CaseState GetCaseState();

	CaseType GetCaseType();

	string GetTestState();

	void HaltForReason(CaseState State, string Reason);

	bool IsEnabled();
}
