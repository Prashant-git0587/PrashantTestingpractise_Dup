Feature: ScenarioContextTest
	Test for different properties and method of scenario context


@ShowUpInTheScenarioInfo @andThisToo
Scenario: showing information of the scenario
	When i execute my scenario
	Then The scenario info contains following informations
		| Field | Value                               |
		| Tags  | ShowUpInScenarioInfo, andThistoo    |
		| Title | Showing information of the scenario |