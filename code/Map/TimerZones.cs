
using Sandbox;

namespace Surf.Map;

internal partial class BaseZone : BaseTrigger 
{ 

}

[Library( "surf_timer_start", Description = "Where the timer will start" )]
internal partial class StartZone : BaseZone
{

}

[Library( "surf_timer_end", Description = "Where the timer will end" )]
internal partial class EndZone : BaseZone
{

}

[Library( "surf_timer_stage_start", Description = "Where the timer will begin a stage" )]
internal partial class StageStartZone : BaseZone 
{

}

[Library( "surf_timer_stage_end", Description = "Where the timer will end a stage" )]
internal partial class StageEndZone : BaseZone
{

}

[Library( "surf_timer_checkpoint", Description = "Where the timer will set a checkpoint (linear)" )]
internal partial class CheckpointZone : BaseZone
{

}
