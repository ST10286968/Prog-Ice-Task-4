namespace Ice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator calculate = new calculator();


            calculate.Operation += (value1, value2) => Display.AppendText($"Performed Addition: {value1} + {value2}\n");
            calculate.Operation += (value1, value2) => Display.AppendText($"Performed Subtraction: {value1} - {value2}\n");
            calculate.Operation += (value1, value2) => Display.AppendText($"Performed Multiplication: {value1} * {value2}\n");
            calculate.Operation += (value1, value2) => Display.AppendText($"Performed Division: {value1} / {value2}\n");

            double value1 = Convert.ToDouble(Value1.Text);
            double value2 = Convert.ToDouble(Value2.Text);

            Display.AppendText($"Addition Result: {calculate.Add(value1, value2)}\n\n");
            Display.AppendText($"Subtraction Result: {calculate.Subtract(value1, value2)}\n\n");
            Display.AppendText($"Multiplication Result: {calculate.Multiply(value1, value2)}\n\n");
            Display.AppendText($"Division Result: {calculate.Divide(value1, value2)}\n\n");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Value1.Clear();
            Value2.Clear();
        }
    }
}
