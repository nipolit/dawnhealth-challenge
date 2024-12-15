namespace ApertureScience.AccelerationMeasurementsIngestion.Models;

public record AccelerationMeasurement(int x, int y, int z, long timestampMillis);