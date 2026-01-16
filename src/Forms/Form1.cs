using OxyPlot;
using OxyPlot.Series;
using System.Runtime.CompilerServices;

namespace src;

public partial class Form1 : Form
{
// Members----------------------------------------------------------------------------------

	private PlotModel? 	m_oPlotModel;
	private Collatz m_oCollatzCalculation;
	private bool m_bAutogenerateIsChecked = false;
	uint m_nStartNumber = 0;

// Constructors------------------------------------------------------------------------------

	public Form1()
	{
		InitializeComponent();
		m_oCollatzCalculation = new Collatz();
		
		NumberInput.Text = "0";

		GenerateGraph ();
	}

//Methods------------------------------------------------------------------------------------

	private void GenerateGraph ()
	{
	string sInputValue = NumberInput.Text;
		bool bCanConvert = uint.TryParse(sInputValue, out m_nStartNumber);

		if (!bCanConvert) {
			MessageBox.Show("Bitte gebe eine Zahl an!");
			return;
		}

		List<uint> vnNumbers = m_oCollatzCalculation.CalcNumbers(m_nStartNumber);
		AddValuesToPlot(vnNumbers);
	}

	private void AddValuesToPlot(List<uint> vnNumbers)
	{ 
		m_oPlotModel = null!;
		m_oPlotModel = new PlotModel{ Title = "Collatz Problem" };

		LineSeries oLineSeries = new LineSeries();

		for (int i = 0; i < vnNumbers.Count; i++) {
			oLineSeries.Points.Add(new DataPoint(i, vnNumbers[i]));
		}

		m_oPlotModel!.Series.Add(oLineSeries);
		oPlotView.Model = m_oPlotModel;
	}

//Events from controlls--------------------------------------------------------------------

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (AutogenerateCheckbox.Checked) {
			m_bAutogenerateIsChecked = true;
		} else {
			m_bAutogenerateIsChecked = false;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		GenerateGraph();
	}

	private void NumberInput_TextChanged(object sender, EventArgs e)
	{
		if (m_bAutogenerateIsChecked) {
			GenerateGraph();
		}
	}

	private void OwnKeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter) {
			GenerateGraph ();
		}

		e.Handled = true;
	}
}
