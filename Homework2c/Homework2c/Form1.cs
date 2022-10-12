namespace Homework2c
{
    public partial class Form1 : Form
    {
        public double green, blue, black, brown, hazel, amber, grey = 0;
        public string[] dataset = {
            "green","blue","grey","black","black","black","brown","brown","hazel","black","black","hazel","brown","black","green","blue",
            "grey","black","black","amber","brown","brown","amber","black","green","green","blue","grey","hazel","amber"};
        public Form1()
        {
            InitializeComponent();
            for( int i = 0; i < dataset.Length; i++)
            {
                richTextBox1.AppendText(dataset[i] + "\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataset.Length; i++)
            {
                var eyeColor = dataset[i];
                if (eyeColor.Equals("green")) {
                        green++;

                } else if (eyeColor.Equals("blue"))
                {
                    blue++;
                }
                else if (eyeColor.Equals("grey"))
                {
                    grey++;
                }
                else if (eyeColor.Equals("brown"))
                {
                    brown++;
                }
                else if (eyeColor.Equals("black"))
                {
                    black++;

                }
                else if (eyeColor.Equals("hazel"))
                {
                    hazel++;

                }
                else if (eyeColor.Equals("amber"))
                {
                    amber++;

                }
            }
            richTextBox2.AppendText("Eye colors distribution: \n" +
                "Green: " + green/dataset.Length + "\n" +
                "Blue: " + blue/dataset.Length + "\n" +
                "Grey: " + grey/dataset.Length + "\n" +
                "Black: " + black/dataset.Length + "\n" +
                "Hazel: " + hazel/dataset.Length + "\n" +
                "Amber: " + amber/dataset.Length + "\n" +
                "Brown: " + brown/dataset.Length + "\n");
        }
    }
}