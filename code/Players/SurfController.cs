﻿
using Sandbox;

namespace Surf.Players;

class SurfController : WalkController
{

	public override void AirMove()
	{
		SurfaceFriction = 1f;
		AirControl = 60f;

		base.AirMove();
	}

}

