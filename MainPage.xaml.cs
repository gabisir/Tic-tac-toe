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
		
        //SemanticScreenReader.Announce(CounterBtn.Text); ispis na gumbu
	}
    //TODO: https://stackoverflow.com/questions/70797331/how-to-create-a-single-click-event-for-multiple-buttons-in-net-maui, POGLEDAJ TO DA NAPRAVIS 1 EVENT LISTENER ZA SVE GUMBE
	//TODO: IMAS JOS I EMPTY.SVG KOJI MORAS POSTAVIT NA SVAKI GUMB, TO JE SAMO PRAZAN FILE, ALI NEKI SOURCE MORA BITI NA GUMBU
	//TODO: SLIKE SU TI U Resources>Images FODLERU, I JOS IMAS ASSETS FOLDER SA ORIGINALIMA AKO NESTO SJEBES
    void OnImageButtonClicked(object sender, EventArgs e)
    {
		if (count == 0) {
            dada.Source = "krizic45.svg";
			count = 1;
        }
		else {
            dada.Source = "krizic.svg";
			count = 0;
        }
		
    }
}

