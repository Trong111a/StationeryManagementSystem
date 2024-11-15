using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    public class ModelHelper
    {
        private MLContext mlContext;

        public ModelHelper()
        {
            mlContext = new MLContext();
           
        }

        public ITransformer TrainModel(List<RevenueData> data)
        {
            var dataView = mlContext.Data.LoadFromEnumerable(data);
            var split = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);
            var trainData = split.TrainSet;
            var testData = split.TestSet;

            var pipeline = mlContext.Transforms.Concatenate("Features", "Year", "Month")
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Revenue",
                 maximumNumberOfIterations: 100

        ));

            var model = pipeline.Fit(trainData);

            // evaluate accuracy
            var predictions = model.Transform(testData);
            var metrics = mlContext.Regression.Evaluate(predictions, labelColumnName: "Revenue");

            Console.WriteLine($"Mean Absolute Error (MAE): {metrics.MeanAbsoluteError}");


            return model;
            
        }

       

        

        public float PredictNextMonthRevenue(ITransformer model, int year, int month)
        {
            var predictionEngine = mlContext.Model.CreatePredictionEngine<RevenueData, RevenuePrediction>(model);

            var input = new RevenueData { Year = year, Month = month };
            var prediction = predictionEngine.Predict(input);
            return prediction.NextMonthRevenue;
        }
    }
}
