﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiUnit : UnitBase {
	public AiUnit (string unitType, float health = STANDART_UNIT_MAX_HEALTH) : base (unitType, health) {
	}

	~AiUnit () {
	}

	public override IAction[] MakeTurn (Map map, UnitsManager unitsManager, ItemsManager itemsManager) {
		// TODO: Implement AI.
		return new IAction[0];
	}
}
