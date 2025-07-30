using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.IO;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shatbot_Helper
{
    public partial class Form1 : Form
    {
        private readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string dataPath;
        private readonly string modelPath;
        private PredictionEngine<ChatExample, ChatPrediction> predictor;
        private MLContext mlContext;

        //dumb "animated" ShatBot pic shit
        private Timer jumpTimer;
        private int originalY;
        private int jumpStep = 0;
        private bool goingUp = true;
        private const int jumpHeight = 30;
        private const int jumpSpeed = 4;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            dataPath = Path.Combine(desktopPath, "chatbot_data.csv");// The test data
            modelPath = Path.Combine(desktopPath, "chatbot_model.zip"); // model we want to use
        }

        public class ChatExample
        {
            [LoadColumn(0)]
            public string Text { get; set; }

            [LoadColumn(1)]
            public string Label { get; set; }
        }

        public class ChatPrediction
        {
            [ColumnName("PredictedLabel")]
            public string PredictedLabel { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlContext = new MLContext();
            originalY = pictureBox1.Top;
            jumpTimer = new Timer();
            jumpTimer.Interval = 30;
            jumpTimer.Tick += jumpTimer_Tick;
            jumpTimer.Enabled = false;
            try
            {
                DataViewSchema inputSchema;
                var model = mlContext.Model.Load(modelPath, out inputSchema);
                predictor = mlContext.Model.CreatePredictionEngine<ChatExample, ChatPrediction>(model);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to load ML model, the chatbot_model.zip needs to be on your Desktop with the name chatbot_model. Following Error: " + ex.Message);
                predictor = null;
            }
        }
        private void jumpTimer_Tick(object sender, EventArgs e)
        {
            if (goingUp)
            {
                pictureBox1.Top -= jumpSpeed;
                jumpStep += jumpSpeed;
                if (jumpStep >= jumpHeight)
                {
                    goingUp = false;
                }
            }
            else
            {
                pictureBox1.Top += jumpSpeed;
                jumpStep -= jumpSpeed;
                if (jumpStep <= 0)
                {
                    pictureBox1.Top = originalY;
                    jumpTimer.Stop();
                    jumpStep = 0;
                    goingUp = true;
                }
            }
        }

        private void SendQuestionButton_Click(object sender, EventArgs e)
        {
            string input = QuestionField.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                AnswerField.Text = "Enter a question!";
                return;
            }
            if (!jumpTimer.Enabled)
                jumpTimer.Start();
            var result = predictor.Predict(new ChatExample { Text = input });

            string response;

            switch (result.PredictedLabel)
            {
                case "Stealth Install":
                    response = "How to Install a stealth";
                    break;
                case "Dashboard Update Fear":
                    response = "Console update is only a avatar update + even if it would be a console update you wouldnt be able to brick because there are safety measures these days";
                    break;
                case "Error 80154002":
                    response = "Xbox live has currently problems or check if you internet connection is working + basic trouble shoot steps";
                    break;
                case "Nuketown DLC Loop":
                    response = "Follow yt tutorial for nuketown map loop fix";
                    break;
                case "GSC Menu Injection":
                    response = "GSC studio + youtube tutorial on how to install GSC menus";
                    break;
                case "No KV Mode Activation":
                    response = "Set it if your stealth actually offers it and has it active, its in their custom stealth menu likely";
                    break;
                case "Get and Set new KV":
                    response = "buy(link to a shop) and then put the KV.bin and cpukey.txt into the root of your HDD";
                    break;
                case "RME Menu Download":
                    response = "Give RME Download links";
                    break;
                case "Save Unlock All":
                    response = "In BO2 make atleast one kill or death in a public match, it should haave saved now. Otherwise make a full stat reset, make the game save, try unlock all now again";
                    break;
                case "COD Tool Download":
                    response = "Give Tool downloads, only free ones not cracked ones";
                    break;
                case "XAM":
                    response = "Dont touch XAM you idiot!";
                        break;
                case "Tool Connecting To Console":
                    response = "Have JRPC2 and or XRPC set as plugins, comes down to which tool you wanna run";
                    break;
                case "Buy A RGH":
                    response = "List trusted sellers";
                    break;
                case "Fake xbGuard Website":
                    response = "There is a fake xbGuard website, the real website is: https://xbguard.live/";
                    break;
                case "VPN for console":
                    response = "Hotspot from PC thats on a VPN and then use that OR connected via Ethernet to PC and then pass the VPN connection from the PC through";
                    break;
                case "xbGuard Not Loading":
                    response = "xbGuard doesnt load? What else is new";
                    break;
                case "RCE menu":
                    response = "No, you will nevver get any RCE menu for any current TU's you asshole";
                    break;
                case "RME for other cods":
                    response = "RME works ONLY for BO1 and BO2 you dumb faggot";
                    break;
                case "Verify Console on xbguard":
                    response = "In the channel inside the xbGuard shit, im tired RN and dont give a fuck, give me proper responses to use here you dumb faggots";
                    break;
                case "Reflash NAND":
                    response = "NAND Reflash? Ether hardware based or through software only(yes can also be done you dumb retard)";
                    break;
                case "Aurora Stealth Crash":
                    response = "Dont use fucking Aurora with a stealth";
                    break;
                case "Deactivate SNET":
                    response = "Unload SNET via module loader while on the dashboard. SNET is comple trash anyways";
                    break;
                case "God Menu Remake Binds":
                    response = "List here all binds, i dont even care to do this right now here cause im just fucked from work";
                    break;
                case "Search Settings and DLC":
                    response = "Have search settings on cod to any and keep in mind that having DLC means you only get to lobbies with people that also havve DLC > less than normally...";
                    break;
                case "Map Stat Loop":
                    response = "Reset your stats and give yourself a unlock all and recovery again as your shitty account stats were fucked by someone else";
                    break;
                case "Freeze Classes":
                    response = "Use a tool to unfreeze classes you tool";
                    break;
                case "Some Account Security Setting":
                    response = "Its some account security setting bs";
                    break;
                case "Bypass Plugins":
                    response = "Press eject button to bypass plugins";
                    break;
                case "GTA4/GTA5 menu Downloads":
                    response = "List menu downloads for gta 4 and gta 5";
                    break;
                case "RME Options":
                    response = "Something odd in bo1 or bo2 happen modding wise? was likely RME";
                    break;
                default:
                    response = "Sorry, I didn't understand that question. LOG THE QUESTION IN THIS CASE TO ADD INTO DATASET";//implement here a auto log fnction, adding it into a txt onto your desktop for example
                    break;
            }
            AnswerField.Text = response;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            try
            {
                var mlContext = new MLContext();

                // Load data
                var data = mlContext.Data.LoadFromTextFile<ChatExample>(
                    path: dataPath,
                    hasHeader: true,
                    separatorChar: ',',
                    allowQuoting: true,
                    trimWhitespace: true);

                // Split data
                var split = mlContext.Data.TrainTestSplit(data, testFraction: 0.2);
                var trainData = split.TrainSet;
                var testData = split.TestSet;

                // Create pipeline
                var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", "Label")
                    .Append(mlContext.Transforms.Text.FeaturizeText("Features", "Text"))
                    .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy())
                    .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                // Train model
                var model = pipeline.Fit(trainData);

                // Evaluate
                var predictions = model.Transform(testData);
                var metrics = mlContext.MulticlassClassification.Evaluate(predictions, topKPredictionCount: 3);

                // Save model
                mlContext.Model.Save(model, trainData.Schema, modelPath);

                // Generate output
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("Model trained and saved to chatbot_model.zip");
                sb.AppendLine("\nEvaluation Results:");
                sb.AppendLine($"  MicroAccuracy:      {metrics.MicroAccuracy:F4}");
                sb.AppendLine($"  MacroAccuracy:      {metrics.MacroAccuracy:F4}");
                sb.AppendLine($"  LogLoss:            {metrics.LogLoss:F4}");
                sb.AppendLine($"  LogLossReduction:   {metrics.LogLossReduction:F4}");
                sb.AppendLine($"  Top-3 Accuracy:     {metrics.TopKAccuracy:F4}");

                sb.AppendLine("\nPer-Class LogLoss:");
                for (int i = 0; i < metrics.PerClassLogLoss.Count; i++)
                {
                    sb.AppendLine($"  Class {i}: {metrics.PerClassLogLoss[i]:F4}");
                }

                // Per-Class Precision and Recall
                var labelData = mlContext.Data.CreateEnumerable<ChatExample>(data, reuseRowObject: false);
                var uniqueLabels = labelData.Select(x => x.Label).Distinct().ToList();
                var cm = metrics.ConfusionMatrix;
                int numClasses = cm.NumberOfClasses;

                sb.AppendLine("\nPer-Class Precision and Recall:");
                for (int i = 0; i < numClasses; i++)
                {
                    int truePositives = (int)cm.Counts[i][i];
                    int falsePositives = (int)Enumerable.Range(0, numClasses).Where(j => j != i).Sum(j => cm.Counts[j][i]);
                    int falseNegatives = (int)Enumerable.Range(0, numClasses).Where(j => j != i).Sum(j => cm.Counts[i][j]);

                    float precision = (truePositives + falsePositives) > 0
                        ? (float)truePositives / (truePositives + falsePositives) : 0;

                    float recall = (truePositives + falseNegatives) > 0
                        ? (float)truePositives / (truePositives + falseNegatives) : 0;

                    string labelName = i < uniqueLabels.Count ? uniqueLabels[i] : $"Class {i}";
                    sb.AppendLine($"  {labelName}: Precision = {precision:F2}, Recall = {recall:F2}");
                }

                // Display in AnswerField
                TrainingOutputField.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                TrainingOutputField.Text = "Error during training: " + ex.Message;
            }
        }




    }



}


