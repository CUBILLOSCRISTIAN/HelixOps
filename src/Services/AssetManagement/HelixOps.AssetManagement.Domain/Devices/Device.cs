namespace HelixOps.AssetManagement.Domain.Devices;

public class Device
{
    public Guid Id { get; private set; }
    public string SerialNumber { get; private set; } = default!;
    public string Type { get; private set; } = default!;
    public Guid LocationId { get; private set; }

    private Device() { }

    public Device(Guid locationId, string serialNumber, string type)
    {
        Id = Guid.NewGuid();
        LocationId = locationId;
        SerialNumber = serialNumber;
        Type = type;
    }
}