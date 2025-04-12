using System;
using System.Collections.Generic;

public class BoxToBoxMidfielder : TacticalRole {
    public BoxToBoxMidfielder() : base(
        roleName: "Box-To-Box Midfielder",
        roleNameShort: "B2B",
        roleDescription: "A Box-To-Box Midfielder is the “workhorse” of the midfield, involved in both attacking and defending", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.M_Center 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Support
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
