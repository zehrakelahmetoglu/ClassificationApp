using Microsoft.ML;
using System.Globalization;

namespace ClassificationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MLContext mlContext = new MLContext();
        ITransformer model;
        PredictionEngine<CreditData, CreditPrediction> predictionEngine;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            var data = mlContext.Data.LoadFromTextFile<CreditData>("data.csv", hasHeader: true, separatorChar: ',');

            var pipeline = mlContext.Transforms.Concatenate("Features",
                                "Income", "CreditScore", "HasJob")
                            .Append(mlContext.BinaryClassification.Trainers.FastTree());

            model = pipeline.Fit(data);

            predictionEngine = mlContext.Model.CreatePredictionEngine<CreditData, CreditPrediction>(model);

            lblResult.Text = "Model eðitildi!";
        }


        private void btnPradict_Click(object sender, EventArgs e)
        {
            // 1) Model eðitildi mi?
            if (predictionEngine == null)
            {
                MessageBox.Show("Model eðitilmemiþ. Lütfen önce 'Modeli Eðit' butonuna basýn.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Kullanýcý girdilerini güvenli þekilde parse et
            // Önce InvariantCulture ile dene (nokta kullananlar için), sonra CurrentCulture ile dene (virgül kullananlar için)
            bool parsedIncome = float.TryParse(txtIncome.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out float income);
            bool parsedScore = float.TryParse(txtScore.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out float score);
            bool parsedJob = float.TryParse(txtJob.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out float hasJob);

            if (!parsedIncome || !parsedScore || !parsedJob)
            {
                // InvariantCulture baþarýsýzsa, CurrentCulture ile tekrar dene (ör. Türkiye için virgül)
                parsedIncome = parsedIncome || float.TryParse(txtIncome.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out income);
                parsedScore = parsedScore || float.TryParse(txtScore.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out score);
                parsedJob = parsedJob || float.TryParse(txtJob.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out hasJob);
            }

            if (!parsedIncome || !parsedScore || !parsedJob)
            {
                MessageBox.Show("Lütfen geçerli sayýsal deðer girin.\nÖrnekler: Gelir = 5000  ,  Kredi Skoru = 700  ,  Ýþi Var mý = 1 veya 0", "Girdi Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ýþ deðeri mantýksal (0 veya 1) ise zorlayalým:
            if (!(hasJob == 0f || hasJob == 1f))
            {
                var ask = MessageBox.Show("Ýþ alaný 0 veya 1 deðil. 1 = Var, 0 = Yok. Devam etmek istiyor musunuz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.No) return;
            }

            // 3) Tahmini güvenli try-catch içinde yap
            try
            {
                var input = new CreditData
                {
                    Income = income,
                    CreditScore = score,
                    HasJob = hasJob
                };

                var result = predictionEngine.Predict(input);

                lblResult.Text = result.Prediction ? "KREDÝ ALABÝLÝR" : "KREDÝ ALAMAZ";
            }
            catch (Exception ex)
            {
                // Hata mesajýný kullanýcýya göster ve konsola/log'a býrak
                MessageBox.Show("Tahmin sýrasýnda hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
