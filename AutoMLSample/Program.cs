using System;
using AutoMLSampleML.Model;

namespace AutoMLSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput
            {
                Passenger_count = 2,
                Trip_distance = 4,
                Trip_time_in_secs = 1150,
                Payment_type = "CRD"
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"Predicted fare: ${result.Score}");

        }
    }
}
