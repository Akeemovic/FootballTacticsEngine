using System.Collections.Generic;
using System.Linq;

public class TacticalPosition
{
    public TacticalPositionOption Position { get; }
    public TacticalPositionGroupOption PositionGroup { get; }
    public List<TacticalRole> AvailableRoles { get; }

    public TacticalRole SelectedRole;
    public TacticalDutyOption SelectedDuty;

    private TacticalRole _defaultRole;
    private TacticalDutyOption _defaultDuty;

    public TacticalPosition(TacticalPositionGroupOption positionGroup, TacticalPositionOption position, List<TacticalRole> tacticalRoles)
    {
        Position = position;
        PositionGroup = positionGroup;
        AvailableRoles = new List<TacticalRole>();

        foreach (var role in tacticalRoles)
        {
            if (role.AvailablePositions.Contains(Position))
            {
                role.SetSelectedPosition(Position);
                AvailableRoles.Add(role);
            }
        }

        SetDefaultRole();
        SetSelectedRole(GetDefaultRole());

        // SetDefaultDuty();
        // SetSelectedDuty(GetDefaultDuty());
    }

    public void SetSelectedDuty(TacticalDutyOption duty)
    {
       SelectedRole.SetSelectedDuty(duty);
    }

    public void SetSelectedRole(TacticalRole role)
    {
        if (AvailableRoles.Contains(role))
        {
            SelectedRole = role;
            SetSelectedDuty(role.SelectedDuty);
        }
    }

    TacticalRole GetDefaultRole() => _defaultRole;
    TacticalDutyOption GetDefaultDuty() => _defaultDuty;
    void SetDefaultRole() => _defaultRole = AvailableRoles.FirstOrDefault();
    void SetDefaultDuty() => _defaultDuty = SelectedRole.GetDefaultDuty();
}
