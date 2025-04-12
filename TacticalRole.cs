using System.Collections.Generic;
using System.Linq;

public abstract class TacticalRole
{
    // public List<TacticalZoneOption> ZonesOwned { get; protected set; }
    public Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> ZonesOwned { get; protected set; }
    public string RoleName { get; private set; }
    public string RoleNameShort { get; private set; }
    public string RoleDescription { get; private set; }
    public List<TacticalPositionGroupOption> AvailablePositionGroups { get; private set; }
    public List<TacticalPositionOption> AvailablePositions { get; private set; }
    public List<TacticalDutyOption> AvailableDuties { get; private set; }
    
    public TacticalDutyOption SelectedDuty { get; private set; }
    public TacticalPositionOption SelectedPosition { get; private set; }

    public PersonalInstruction PersonalInstruction { get; protected set; }

    protected bool canAutomatic, canAttack, canSupport, canDefend, canStopper, canCover;

    private TacticalDutyOption _defaultDuty;
    private TacticalPositionOption _defaultPosition;

    protected TacticalRole(string roleName, string roleNameShort, string roleDescription, List<TacticalPositionGroupOption> availablePositionGroups, List<TacticalDutyOption> availableDuties)
    {
        RoleName = roleName;
        RoleNameShort = roleNameShort;
        RoleDescription = roleDescription;

        // Default Positoin Set Internally
        InitializePositions(availablePositionGroups);
        // Default Duty Set Internally
        InitializeDuties(availableDuties);
    }

    private void InitializePositions(List<TacticalPositionGroupOption> availablePositionGroups) 
    {
        AvailablePositionGroups = availablePositionGroups;
        AvailablePositions = PositionGroupManager.GetPositionOptionsForGroupAll(AvailablePositionGroups.ToArray()); 

        _defaultPosition = AvailablePositions.FirstOrDefault();
        SetSelectedPosition(GetDefaultPosition());
    }

    private void InitializeDuties(List<TacticalDutyOption> availableDuties)
    {
        AvailableDuties = availableDuties;
        canAttack = AvailableDuties.Contains(TacticalDutyOption.Attack);
        canSupport = AvailableDuties.Contains(TacticalDutyOption.Support);
        canDefend = AvailableDuties.Contains(TacticalDutyOption.Defend);
        canStopper = AvailableDuties.Contains(TacticalDutyOption.Stopper);
        canCover = AvailableDuties.Contains(TacticalDutyOption.Cover);

        
        _defaultDuty = AvailableDuties.FirstOrDefault();
        SetSelectedDuty(GetDefaultDuty());
    }

    public bool CanAutomatic() => canAutomatic;
    public bool CanAttack() => canAttack;
    public bool CanSupport() => canSupport;
    public bool CanDefend() => canDefend;
    public bool CanStopper() => canStopper;
    public bool CanCover() => canCover;

    public void SetSelectedDuty(TacticalDutyOption duty)
    {
        if (AvailableDuties.Contains(duty))
        {
            SelectedDuty = duty;
        }
        else
        {
            SelectedDuty = GetDefaultDuty();
        }
        // If Selected DUTY changes, ZonesOwned must be updated 
        UpdateZonesOwned();
    }

    public void SetSelectedPosition(TacticalPositionOption position)
    {
        if (AvailablePositions.Contains(position))
        {
            SelectedPosition = position;
        }
        else
        {
            SelectedPosition = GetDefaultPosition();
        }
        // If Selected POSITION changes, ZonesOwned must be updated 
        UpdateZonesOwned();
    }

    public TacticalDutyOption GetDefaultDuty() => _defaultDuty;
    
    TacticalPositionOption GetDefaultPosition() => _defaultPosition;

    protected void UpdateZonesOwned()
    {
        ZonesOwned = GetAvailableZones(SelectedPosition, SelectedDuty);
    }

    // Method to set the availability level for a zone
    // public void SetZoneAvailability(TacticalZoneOption zone, TacticalZoneAvailabilityOption level)
    // {
    //     ZonesOwned[zone] = level;
    // }

    // Method to get the availability level of a zone
    public TacticalZoneAvailabilityOption GetZoneAvailability(TacticalZoneOption zone)
    {
        if (ZonesOwned.TryGetValue(zone, out var level))
        {
            return level;
        }
        return TacticalZoneAvailabilityOption.None; // Return a default level if not found
    }
    
    // public abstract List<TacticalZoneOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty);
    public abstract Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty);
}
