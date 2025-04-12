using System;
using System.Collections.Generic;

public class HalfBack : TacticalRole {
    public HalfBack() : base(
        roleName: "Half Back",
        roleNameShort: "HB",
        roleDescription: "The half-back at times will play as an extra center back to help recycle possession or be an extra passing option to continue moving the ball.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.DM_Center 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Defend
            }
        )
    {
        // Contructor body
    }

    public override Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty) 
    {
        return null;    
    }
}
