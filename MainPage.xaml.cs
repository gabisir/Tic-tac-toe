namespace Tic_tac_toe;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = "Trebam startat";
		if(count>2)
            CounterBtn.Text = "jasno je da trebam startat, cekaj!!!";

        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

