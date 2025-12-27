using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificationApp
{
    using Microsoft.ML.Data;

    public class CreditData
    {
        [LoadColumn(0)] public float Income { get; set; }
        [LoadColumn(1)] public float CreditScore { get; set; }
        [LoadColumn(2)] public float HasJob { get; set; }
        [LoadColumn(3)] public bool Label { get; set; }
    }

    public class CreditPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

        public float Score { get; set; }
    }

}
