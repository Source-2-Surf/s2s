
using Sandbox;
using Sandbox.UI;

namespace Surf.UI;

[UseTemplate]
internal class Hud : Panel
{

	public int Speedometer => (int)(Local.Pawn?.Velocity.WithZ( 0 ).Length ?? 0);

}
