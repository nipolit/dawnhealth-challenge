namespace ApertureScience.AccelerationMeasurementsIngestion.Endpoints;

public class PostAccelerationMeasurementsEndpoint
{
    public static async Task<IResult> Handle(int testSubjectId)
    {
        await Task.Delay(1000);

        return Results.Ok();
    }
}