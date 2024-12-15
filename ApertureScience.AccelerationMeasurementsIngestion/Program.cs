using ApertureScience.AccelerationMeasurementsIngestion.Endpoints;

var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

var accelerationMeasurementApi = app.MapGroup("/acceleration");
    accelerationMeasurementApi.MapPost("/{testSubjectId}", PostAccelerationMeasurementsEndpoint.Handle)
        .WithSummary("Receives acceleration measurements");

app.Run();
